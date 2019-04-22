using RimeLib.Frostbite.Core;
using System;
using System.Collections;

namespace RimeLib.Frostbite.Db
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
    public sealed class DbObjectAttribute : Attribute
    {
        // This attribute does nothing else other than specify that this class is eligible for serialization to/from DbObject.
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class DbObjectFieldAttribute : Attribute
    {
        public string FieldName { get; set; }

        /// <summary>
        /// When a field is of type `long`, this specifies whether it 
        /// should be encoded as a variable length integer or not.
        /// </summary>
        public bool VariableLength { get; set; }

        public DbObjectFieldAttribute(string p_FieldName, bool p_VariableLength = false)
        {
            FieldName = p_FieldName;
            VariableLength = p_VariableLength;
        }
    }

    [DbObject]
    public interface IDbObjectSerializable
    {
    }

    public class DbObjectConverter
    {
        /// <summary>
        /// Converts a managed object to a DbObject.
        /// </summary>
        /// <typeparam name="T">The type of the object to convert. Must derive from IDbObjectSerializable.</typeparam>
        /// <param name="p_Object">The object to convert</param>
        /// <returns>The converted DbObject</returns>
        public static DbObject ConvertTo<T>(T p_Object) where T : IDbObjectSerializable
        {
            // Check if we have the DbObject attribute.
            var s_Type = p_Object.GetType();
            var s_DbObjectAttributes = s_Type.GetCustomAttributes(typeof(DbObjectAttribute), true);

            if (s_DbObjectAttributes.Length == 0)
                throw new ArgumentException("Provided object does not inherit from IDbObjectSerializable.");

            var s_Object = new DbObject();

            // Map out all the fields that have the DbObjectField attribute.
            foreach (var s_Property in s_Type.GetProperties())
            {
                var s_PropertyAttributes = s_Property.GetCustomAttributes(typeof(DbObjectFieldAttribute), true);

                if (s_PropertyAttributes.Length == 0)
                    continue;

                var s_Attribute = (DbObjectFieldAttribute) s_PropertyAttributes[0];
                s_Object.AddElement(ConvertObject(s_Property.GetValue(p_Object), s_Attribute.FieldName, s_Attribute.VariableLength));
            }            

            return s_Object;
        }

        /// <summary>
        /// Converts a DbObject to a managed object.
        /// </summary>
        /// <typeparam name="T">The type of the object to convert. Must derive from IDbObjectSerializable.</typeparam>
        /// <param name="p_Object">The DbObject to convert</param>
        /// <returns>The converted managed object</returns>
        public static T ConvertFrom<T>(DbObject p_Object) where T : IDbObjectSerializable, new()
        {
            var s_Type = typeof(T);

            var s_DbObjectAttributes = s_Type.GetCustomAttributes(typeof(DbObjectAttribute), true);

            if (s_DbObjectAttributes.Length == 0)
                throw new ArgumentException("Provided object does not inherit from IDbObjectSerializable.");

            var s_Object = new T();

            foreach (var s_Property in s_Type.GetProperties())
            {
                // Check if we have the DbObjectField attribute.
                var s_PropertyAttributes = s_Property.GetCustomAttributes(typeof(DbObjectFieldAttribute), true);

                if (s_PropertyAttributes.Length == 0)
                    continue;

                var s_Attribute = (DbObjectFieldAttribute) s_PropertyAttributes[0];
                var s_IsNullable = Nullable.GetUnderlyingType(s_Property.PropertyType) != null;
                var s_HasKey = p_Object.HasKey(s_Attribute.FieldName);

                // If we don't have this field and the property is not nullable then throw an exception.
                if (!s_HasKey && !s_IsNullable)
                    throw new Exception($"Could not find expected field '{s_Attribute.FieldName}' for property '{s_Property.Name}' in DbObject.");

                // If we don't have the key and this is nullable just set to null.
                if (!s_HasKey && s_IsNullable)
                {
                    s_Property.SetValue(s_Object, null);
                    continue;
                }

                // Otherwise parse normally.
                var s_Value = ConvertField(p_Object[s_Attribute.FieldName], s_Property.PropertyType);
                s_Property.SetValue(s_Object, s_Value);
            }

            return s_Object;
        }

        private static void EnsureElementType(DbObjectElement p_Element, params DbObjectType[] p_ExpectedTypes)
        {
            if (Array.IndexOf(p_ExpectedTypes, p_Element.Type) == -1)
                throw new Exception($"Tried deserializing DbObject element of type '{p_Element.Type}' when we were expecting '{string.Join(", ", p_ExpectedTypes)}'.");
        }

        private static object? ConvertField(DbObjectElement p_Element, Type s_FieldType)
        {
            // Check if we need to return null.
            var s_IsNullable = Nullable.GetUnderlyingType(s_FieldType) != null;

            if (s_IsNullable && p_Element.Type == DbObjectType.Null)
                return null;

            if (!s_IsNullable && p_Element.Type == DbObjectType.Null)
                throw new Exception("Received null DbObject element for non-nullable field.");

            // If this is an array then we need to handle it separately.
            if (s_FieldType.IsArray)
            {
                // Handle byte arrays separately from all other arrays.
                if (s_FieldType == typeof(byte[]))
                {
                    // Ensure the element is of the right type.
                    EnsureElementType(p_Element, DbObjectType.Blob);
                    return p_Element.Value;
                }

                // Ensure the element is of the right type.
                EnsureElementType(p_Element, DbObjectType.Array);

                var s_ArrayItemType = s_FieldType.GetElementType();
                var s_DbArray = (DbObject) p_Element.Value;

                // Create our array.
                var s_Array = Array.CreateInstance(s_ArrayItemType, s_DbArray.Count);

                // Convert every object and assign it to the array.
                for (var i = 0; i < s_DbArray.Count; ++i)
                {
                    var s_Element = s_DbArray[i];
                    s_Array.SetValue(ConvertField(s_Element, s_ArrayItemType), i);
                }

                return s_Array;
            }

            // If this property derives from IDbObjectSerializable then handle it separately.
            if (s_FieldType.IsAssignableFrom(typeof(IDbObjectSerializable)))
            {
                // Ensure the element is of the right type.
                EnsureElementType(p_Element, DbObjectType.Object);

                // Call ConvertFrom with the property type as the generic parameter.
                var s_Method = typeof(DbObjectConverter).GetMethod("ConvertFrom").MakeGenericMethod(s_FieldType);
                return s_Method.Invoke(null, new[] { p_Element.Value });
            }

            // Handle primitive types.
            if (s_FieldType == typeof(string))
            {
                EnsureElementType(p_Element, DbObjectType.String);
                return p_Element.Value;
            }

            if (s_FieldType == typeof(bool))
            {
                EnsureElementType(p_Element, DbObjectType.Bool);
                return p_Element.Value;
            }

            if (s_FieldType == typeof(int))
            {
                EnsureElementType(p_Element, DbObjectType.Integer);
                return p_Element.Value;
            }

            if (s_FieldType == typeof(long))
            {
                EnsureElementType(p_Element, DbObjectType.Long, DbObjectType.VarInt);
                return p_Element.Value;
            }

            if (s_FieldType == typeof(float))
            {
                EnsureElementType(p_Element, DbObjectType.Float);
                return p_Element.Value;
            }

            if (s_FieldType == typeof(double))
            {
                EnsureElementType(p_Element, DbObjectType.Double);
                return p_Element.Value;
            }

            // Handle all other core types.
            if (s_FieldType == typeof(ObjectId))
            {
                EnsureElementType(p_Element, DbObjectType.ObjectId);
                return p_Element.Value;
            }

            if (s_FieldType == typeof(DbObjectTimestamp))
            {
                EnsureElementType(p_Element, DbObjectType.Timestamp);
                return p_Element.Value;
            }

            if (s_FieldType == typeof(RecordId))
            {
                EnsureElementType(p_Element, DbObjectType.RecordId);
                return p_Element.Value;
            }

            if (s_FieldType == typeof(GUID))
            {
                EnsureElementType(p_Element, DbObjectType.Guid);
                return p_Element.Value;
            }

            if (s_FieldType == typeof(Sha1))
            {
                EnsureElementType(p_Element, DbObjectType.Sha1);
                return p_Element.Value;
            }

            if (s_FieldType == typeof(DbObjectTimespan))
            {
                EnsureElementType(p_Element, DbObjectType.Timespan);
                return p_Element.Value;
            }

            throw new Exception("Tried mapping DbObject field into an unsupported property type.");
        }

        private static DbObjectElement ConvertObject(object p_Object, string p_FieldName = "", bool p_VariableLength = false)
        {
            // Handle null values appropriately.
            if (p_Object == null)
                return new DbObjectElement(p_FieldName);

            var s_Type = p_Object.GetType();

            // TODO: Add support for collection types?
            // Handle array types.
            if (s_Type.IsArray)
            {
                // Handle byte arrays separately.
                if (s_Type == typeof(byte[]))
                    return new DbObjectElement(p_FieldName, (byte[]) p_Object);

                var s_Object = new DbObject();
                var s_Items = (IEnumerable) p_Object;

                // Create and add the items of the array.
                foreach (var s_Item in s_Items)
                    s_Object.AddElement(ConvertObject(s_Item, "", p_VariableLength));

                return new DbObjectElement(p_FieldName, s_Object, true);
            }

            // Handle IDbObjectSerializable types.
            if (s_Type.IsAssignableFrom(typeof(IDbObjectSerializable)))
                return new DbObjectElement(p_FieldName, ConvertTo((IDbObjectSerializable)p_Object), false);

            // Handle primitive types.
            if (s_Type == typeof(string))
                return new DbObjectElement(p_FieldName, (string) p_Object);

            if (s_Type == typeof(bool))
                return new DbObjectElement(p_FieldName, (bool) p_Object);

            if (s_Type == typeof(int))
                return new DbObjectElement(p_FieldName, (int) p_Object);

            if (s_Type == typeof(long))
                return new DbObjectElement(p_FieldName, (long) p_Object, p_VariableLength);

            if (s_Type == typeof(float))
                return new DbObjectElement(p_FieldName, (float) p_Object);

            if (s_Type == typeof(double))
                return new DbObjectElement(p_FieldName, (double) p_Object);

            // Handle all other core types.
            if (s_Type == typeof(ObjectId))
                return new DbObjectElement(p_FieldName, (ObjectId) p_Object);

            if (s_Type == typeof(DbObjectTimestamp))
                return new DbObjectElement(p_FieldName, (DbObjectTimestamp) p_Object);

            if (s_Type == typeof(RecordId))
                return new DbObjectElement(p_FieldName, (RecordId) p_Object);
            
            if (s_Type == typeof(GUID))
                return new DbObjectElement(p_FieldName, (GUID) p_Object);
            
            if (s_Type == typeof(Sha1))
                return new DbObjectElement(p_FieldName, (Sha1) p_Object);
            
            if (s_Type == typeof(DbObjectTimespan))
                return new DbObjectElement(p_FieldName, (DbObjectTimespan) p_Object);

            throw new ArgumentException("Tried converting an unsupported object type.");
        }
    }
}
