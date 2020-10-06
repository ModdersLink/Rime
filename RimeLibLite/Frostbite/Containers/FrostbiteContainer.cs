using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Ebx;
using System;
using System.Collections.Generic;
using System.Dynamic;
using RimeLib.Frostbite.Core;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Utils;
using System.Linq;
using System.Collections;
using TypeDescriptor = RimeLib.Serialization.Ebx.TypeDescriptor;

namespace RimeLib.Serialization.Containers
{
    /// <summary>
    /// A base container class for data bindings.
    /// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FrostbiteContainer : DynamicObject, INotifyPropertyChanging, INotifyPropertyChanged
    {
        /// <summary>
        /// Alignment of this container
        /// </summary>
        [Browsable(false)]
        public virtual byte ContainerAlignment
        {
            get
            {
                if (m_HasCustomAlignment)
                    return m_CustomAlignment;

                var s_Attributes = (ContainerTypeAttribute[])GetType().GetCustomAttributes(typeof(ContainerTypeAttribute), false);

                if (s_Attributes.Length == 0)
                    return 1;

                return s_Attributes[0].DataAlignment;
            }
            set
            {
                m_HasCustomAlignment = true;
                m_CustomAlignment = value;
            }
        }

        /// <summary>
        /// Flags for this container
        /// </summary>
        [Browsable(false)]
        public virtual ushort ContainerFlags
        {
            get
            {
                if (m_HasCustomFlags)
                    return m_CustomFlags;

                ushort s_Flags;

                if (typeof(DataContainer).IsAssignableFrom(GetType()))
                {
                    s_Flags = (ushort)MemberTypeEnum.TypeInfo
                              | ((ushort)TypeCategoryEnum.Class << (ushort)MemberInfoFlagsEnum.TypeCategoryShift)
                              | ((ushort)BasicTypesEnum.Class << (ushort)MemberInfoFlagsEnum.TypeCodeShift);
                }
                else
                {
                    s_Flags = (ushort)MemberTypeEnum.TypeInfo
                              | ((ushort)TypeCategoryEnum.ValueType << (ushort)MemberInfoFlagsEnum.TypeCategoryShift)
                              | ((ushort)BasicTypesEnum.ValueType << (ushort)MemberInfoFlagsEnum.TypeCodeShift);
                }

                if (Attribute.IsDefined(GetType(), typeof(HomogeneousAttribute)))
                    s_Flags |= (ushort)MemberInfoFlagsEnum.Homogeneous;

                if (Attribute.IsDefined(GetType(), typeof(LayoutImmutableAttribute)))
                    s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;

                if (Attribute.IsDefined(GetType(), typeof(BlittableAttribute)))
                    s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;

                return s_Flags;
            }
            set
            {
                m_HasCustomFlags = true;
                m_CustomFlags = value;
            }
        }

        /// <summary>
        /// Type name of this container
        /// </summary>
        [Browsable(false)]
        public virtual string ContainerTypeName
        {
            get
            {
                return m_HasCustomTypeName ? m_CustomTypeName : GetType().Name;
            }
            set
            {
                m_HasCustomTypeName = true;
                m_CustomTypeName = value;
            }
        }

        /// <summary>
        /// Whether this container is dynamically constructed or not.
        /// </summary>
        [Browsable(false)]
        public bool IsDynamicContainer => m_Fields != null && m_Fields.Count > 0;

        private bool m_HasCustomAlignment;
        private byte m_CustomAlignment;

        private bool m_HasCustomFlags;
        private ushort m_CustomFlags;

        private bool m_HasCustomTypeName;
        private string m_CustomTypeName;

        private readonly Dictionary<string, Tuple<FieldDescriptor, object>> m_Fields;

        /// <summary>
        /// PropertyChanged event
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// PropertyChanging event
        /// </summary>
        public event PropertyChangingEventHandler? PropertyChanging;

        /// <summary>
        /// Default constructor
        /// </summary>
        public FrostbiteContainer()
        {
            m_HasCustomAlignment = false;
            m_HasCustomFlags = false;
            m_HasCustomTypeName = false;
            m_CustomTypeName = string.Empty;

            m_Fields = new Dictionary<string, Tuple<FieldDescriptor, object>>();
        }

        /// <summary>
        /// Gets a fields value by its name hash
        /// This is implemented by the generated bindings
        /// </summary>
        /// <param name="p_Hash">Name hash</param>
        /// <returns>null</returns>
        public virtual object? GetFieldValueByHash(uint p_Hash)
        {
            return null;
        }

        /// <summary>
        /// Gets field information by its name hash
        /// This is implemented by the generated bindings
        /// </summary>
        /// <param name="p_Hash">Name hash</param>
        /// <returns>null</returns>
        public virtual PropertyInfo? GetFieldInfoByHash(uint p_Hash)
        {
            return null;
        }

        /// <summary>
        /// Default binding template
        /// </summary>
        /// <param name="p_Descriptor">Field descriptor</param>
        /// <param name="p_Value">Value</param>
        public virtual void Bind(FieldDescriptor p_Descriptor, object p_Value)
        {
            if (m_Fields.ContainsKey(p_Descriptor.Name))
                m_Fields[p_Descriptor.Name] = new Tuple<FieldDescriptor, object>(p_Descriptor, p_Value);
            else
                m_Fields.Add(p_Descriptor.Name, new Tuple<FieldDescriptor, object>(p_Descriptor, p_Value));
        }

        /// <summary>
        /// Tries to get a member binder (see nf for more documentation)
        /// </summary>
        /// <param name="p_Binder">GetMemberBinder object</param>
        /// <param name="p_Result">Result object</param>
        /// <returns>True on success, false otherwise</returns>
	    public override bool TryGetMember(GetMemberBinder p_Binder, out object? p_Result)
        {
            Tuple<FieldDescriptor, object> s_Value;

            p_Result = null;

            if (!m_Fields.TryGetValue(p_Binder.Name, out s_Value))
                return false;

            p_Result = s_Value.Item2;
            return true;
        }

        /// <summary>
        /// Tries to set a member binder (see nf for more documentation)
        /// </summary>
        /// <param name="p_Binder">SetMemberBinder object</param>
        /// <param name="p_Value">Object to set</param>
        /// <returns>True on success, false otherwise</returns>
	    public override bool TrySetMember(SetMemberBinder p_Binder, object p_Value)
        {
            if (!m_Fields.ContainsKey(p_Binder.Name))
                return false;

            m_Fields[p_Binder.Name] = new Tuple<FieldDescriptor, object>(m_Fields[p_Binder.Name].Item1, p_Value);
            return true;
        }

        /// <summary>
        /// Gets the type descriptor for this object
        /// </summary>
        /// <returns>TypeDescriptor object</returns>
        /*public TypeDescriptor GetTypeDescriptor()
        {
            return new TypeDescriptor
            {
                Alignment = ContainerAlignment,
                Flags = new MemberInfoFlags() { FlagBits = ContainerFlags },
                Name = ContainerTypeName,
                FieldCount = (byte)(m_Fields.Count() & 0xFF),
                NameHash = FbUtils.HashQuick(ContainerTypeName),
                LayoutDescriptor = 0, // Index into FieldDescriptor table for fields
                SecondarySize = 0, // Is this ever non-zero?
                Size = 0 // Size in bytes of this type
            };
        }*/

        /// <summary>
        /// Gets the type names for provided object
        /// </summary>
        /// <typeparam name="T">Object</typeparam>
        /// <returns>Enumerable string list</returns>
        public static IEnumerable<string> GetTypeNames<T>()
        {
            return GetTypeNames(typeof(T));
        }

        /// <summary>
        /// Gets the type names for a specified type
        /// </summary>
        /// <param name="p_Type">Type object</param>
        /// <returns>Enumerable string list</returns>
        public static IEnumerable<string> GetTypeNames(Type p_Type)
        {
            var s_Names = new HashSet<string> { p_Type.Name };

            var s_BaseType = p_Type.BaseType;

            while (s_BaseType != null)
            {
                var s_TypeAttributes = (ContainerTypeAttribute[])s_BaseType.GetCustomAttributes(typeof(ContainerTypeAttribute), false);

                if (s_TypeAttributes.Length == 0)
                {
                    s_BaseType = s_BaseType.BaseType;
                    continue;
                }

                s_Names.Add(s_BaseType.Name);
                s_BaseType = s_BaseType.BaseType;
            }

            foreach (var s_Property in p_Type.GetProperties())
            {
                var s_Browsable = (BrowsableAttribute[])s_Property.GetCustomAttributes(typeof(BrowsableAttribute), false);

                var s_NotBrowsable = s_Browsable.Any(p_Attr => !p_Attr.Browsable);

                if (s_NotBrowsable)
                    continue;

                var s_FieldAttributes = (ContainerFieldAttribute[])s_Property.GetCustomAttributes(typeof(ContainerFieldAttribute), false);

                if (s_FieldAttributes.Length == 0)
                    continue;

                // Handle value type fields.
                if (typeof(FrostbiteContainer).IsAssignableFrom(s_Property.PropertyType))
                    s_Names.UnionWith(GetTypeNames(s_Property.PropertyType));

                // Handle arrays.
                if (s_Property.PropertyType.IsGenericType && s_Property.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    var s_ArrayType = s_Property.PropertyType.GetGenericArguments()[0];

                    if (typeof(FrostbiteContainer).IsAssignableFrom(s_ArrayType))
                        s_Names.UnionWith(GetTypeNames(s_ArrayType));
                }

                // Handle enum fields.
                if (s_Property.PropertyType.IsEnum)
                {
                    s_Names.Add(s_Property.PropertyType.Name);

                    foreach (var s_Value in Enum.GetNames(s_Property.PropertyType))
                        s_Names.Add(s_Value);
                }

                // Custom field name.
                if (!string.IsNullOrWhiteSpace(s_FieldAttributes[0].FieldName))
                {
                    s_Names.Add(s_FieldAttributes[0].FieldName);
                    continue;
                }

                s_Names.Add(s_Property.Name);
            }

            return s_Names;
        }

        public uint GetImportCount(bool p_TotalImportCount = false)
        {
            uint s_ImportCount = 0;
            foreach (var s_Property in GetType().GetProperties())
            {
                // Check to see if this property is browsable or not
                var s_Browsable = (BrowsableAttribute[])s_Property.GetCustomAttributes(typeof(BrowsableAttribute), false);

                var s_NotBrowsable = s_Browsable.Any(p_Attr => !p_Attr.Browsable);

                if (s_NotBrowsable)
                    continue;

                // Check to ensure that this property has a ContainerField attribute
                var s_FieldAttributes = s_Property.GetCustomAttribute<ContainerFieldAttribute>();
                if (s_FieldAttributes == null)
                    continue;

                if (!typeof(CtrRefBase).IsAssignableFrom(s_Property.PropertyType))
                    continue;

                var s_Value = s_Property.GetValue(this);
                if (s_Value == null)
                    continue;

                var s_CtrRef = (CtrRefBase)s_Value;

                if ((s_CtrRef.PartitionGuid != GUID.Empty && s_CtrRef.InstanceGuid != GUID.Empty) || p_TotalImportCount)
                    s_ImportCount++;
            }

            return s_ImportCount;
        }

        /// <summary>
        /// Gets the custom fields of this object
        /// </summary>
        /// <returns>Enumerable string list of custom fields</returns>
        public IEnumerable<string> GetCustomFields()
        {
            var s_Names = new HashSet<string>();

            s_Names.UnionWith(m_Fields.Keys);

            foreach (var s_Property in GetType().GetProperties())
            {
                var s_Browsable = (BrowsableAttribute[])s_Property.GetCustomAttributes(typeof(BrowsableAttribute), false);

                var s_NotBrowsable = s_Browsable.Any(p_Attr => !p_Attr.Browsable);

                if (s_NotBrowsable)
                    continue;

                var s_FieldAttributes = (ContainerFieldAttribute[])s_Property.GetCustomAttributes(typeof(ContainerFieldAttribute), false);

                if (s_FieldAttributes.Length == 0)
                    continue;

                // Handle arrays.
                if (s_Property.PropertyType.IsGenericType && s_Property.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    var s_ArrayType = s_Property.PropertyType.GetGenericArguments()[0];

                    if (typeof(FrostbiteContainer).IsAssignableFrom(s_ArrayType))
                    {
                        var s_List = (IList)s_Property.GetValue(this);

                        foreach (var s_ListValue in s_List)
                        {
                            if (s_ListValue == null)
                                continue;

                            s_Names.UnionWith(((FrostbiteContainer)s_ListValue).GetCustomFields());
                        }
                    }

                    continue;
                }

                if (!typeof(FrostbiteContainer).IsAssignableFrom(s_Property.PropertyType))
                    continue;

                var s_ValueProperty = (FrostbiteContainer)s_Property.GetValue(this);

                if (s_ValueProperty == null)
                    continue;

                s_Names.UnionWith(s_ValueProperty.GetCustomFields());
            }

            return s_Names;
        }

        /// <summary>
        /// Gets the field flags for a specified type
        /// </summary>
        /// <param name="p_Type">Type object</param>
        /// <returns>Flag bits</returns>
        public static ushort GetFieldFlags(Type p_Type)
        {
            var s_Flags = (ushort)MemberTypeEnum.TypeInfo;

            // For some odd reason only arrays of value types are marked as "field" (I think).
            if (p_Type.IsGenericType && p_Type.GetGenericTypeDefinition() == typeof(List<>) &&
                typeof(FrostbiteContainer).IsAssignableFrom(p_Type.GetGenericArguments()[0]))
            {
                s_Flags = (ushort)MemberTypeEnum.Field;
            }

            // Type Category.
            if (p_Type.IsGenericType && p_Type.GetGenericTypeDefinition() == typeof(List<>))
            {
                s_Flags |= ((ushort)TypeCategoryEnum.NotApplicable << (ushort)MemberInfoFlagsEnum.TypeCategoryShift);
            }
            else if (typeof(CtrRefBase).IsAssignableFrom(p_Type))
            {
                s_Flags |= (ushort)TypeCategoryEnum.Class << (ushort)MemberInfoFlagsEnum.TypeCategoryShift;
            }
            else if (typeof(FrostbiteContainer).IsAssignableFrom(p_Type))
            {
                s_Flags |= (ushort)TypeCategoryEnum.ValueType << (ushort)MemberInfoFlagsEnum.TypeCategoryShift;
            }
            else
            {
                s_Flags |= (ushort)TypeCategoryEnum.PrimitiveType << (ushort)MemberInfoFlagsEnum.TypeCategoryShift;
            }

            // Type Code.
            if (p_Type.IsGenericType && p_Type.GetGenericTypeDefinition() == typeof(List<>))
            {
                s_Flags |= (ushort)BasicTypesEnum.Array << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            }
            else if (typeof(CtrRefBase).IsAssignableFrom(p_Type))
            {
                s_Flags |= (ushort)BasicTypesEnum.Class << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            }
            else if (typeof(FrostbiteContainer).IsAssignableFrom(p_Type))
            {
                s_Flags |= (ushort)BasicTypesEnum.ValueType << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            }
            else if (p_Type == typeof(bool))
            {
                s_Flags |= (ushort)BasicTypesEnum.Boolean << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(sbyte))
            {
                s_Flags |= (ushort)BasicTypesEnum.Int8 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(byte))
            {
                s_Flags |= (ushort)BasicTypesEnum.Uint8 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(short))
            {
                s_Flags |= (ushort)BasicTypesEnum.Int16 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(ushort))
            {
                s_Flags |= (ushort)BasicTypesEnum.Uint16 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(int))
            {
                s_Flags |= (ushort)BasicTypesEnum.Int32 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(uint))
            {
                s_Flags |= (ushort)BasicTypesEnum.Uint32 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(long))
            {
                s_Flags |= (ushort)BasicTypesEnum.Int64 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(ulong))
            {
                s_Flags |= (ushort)BasicTypesEnum.Uint16 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(float))
            {
                s_Flags |= (ushort)BasicTypesEnum.Float32 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(double))
            {
                s_Flags |= (ushort)BasicTypesEnum.Float64 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(string))
            {
                s_Flags |= (ushort)BasicTypesEnum.CString << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
            }
            else if (p_Type == typeof(GUID))
            {
                s_Flags |= (ushort)BasicTypesEnum.Guid << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type == typeof(Sha1))
            {
                s_Flags |= (ushort)BasicTypesEnum.Sha1 << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;
            }
            else if (p_Type.IsEnum)
            {
                s_Flags |= (ushort)BasicTypesEnum.Enum << (ushort)MemberInfoFlagsEnum.TypeCodeShift;
            }

            // TODO: Add ResourceRef (ResourceRef is LayoutImmutable too).

            return s_Flags;
        }

        /// <summary>
        /// Gets the field descriptor for a specified property and attributes
        /// </summary>
        /// <param name="p_Property">PropertyInfo object</param>
        /// <param name="p_Attributes">ContainerFieldAttributes (default: null)</param>
        /// <returns>Field descriptor object</returns>
        public static FieldDescriptor? GetFieldDescriptor(PropertyInfo p_Property, ContainerFieldAttribute[]? p_Attributes = null)
        {
            if (p_Attributes == null)
                p_Attributes = (ContainerFieldAttribute[])p_Property.GetCustomAttributes(typeof(ContainerFieldAttribute), false);

            if (p_Attributes.Length == 0)
                return null;

            var s_Descriptor = new FieldDescriptor()
            {
                SecondaryOffset = (int)p_Attributes[0].FieldOffset
            };

            // Custom field name.
            if (!string.IsNullOrWhiteSpace(p_Attributes[0].FieldName))
            {
                s_Descriptor.Name = p_Attributes[0].FieldName;
                s_Descriptor.NameHash = FbUtils.HashQuick(p_Attributes[0].FieldName);
            }
            else
            {
                s_Descriptor.Name = p_Property.Name;
                s_Descriptor.NameHash = FbUtils.HashQuick(p_Property.Name);
            }

            // FieldType is only valid for value, void, enum, and array.
            // TODO: Pass TypeDescriptor instances and set FieldType appropriately.

            var s_Flags = GetFieldFlags(p_Property.PropertyType);

            // Flags.
            if (Attribute.IsDefined(p_Property, typeof(MetadataAttribute)))
                s_Flags |= (ushort)MemberInfoFlagsEnum.Metadata;

            if (Attribute.IsDefined(p_Property, typeof(HomogeneousAttribute)))
                s_Flags |= (ushort)MemberInfoFlagsEnum.Homogeneous;

            if (Attribute.IsDefined(p_Property, typeof(AlwaysPersistAttribute)))
                s_Flags |= (ushort)MemberInfoFlagsEnum.AlwaysPersist;

            if (Attribute.IsDefined(p_Property, typeof(ExposedAttribute)))
                s_Flags |= (ushort)MemberInfoFlagsEnum.Exposed;

            if (Attribute.IsDefined(p_Property, typeof(LayoutImmutableAttribute)))
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;

            if (Attribute.IsDefined(p_Property, typeof(BlittableAttribute)))
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;

            s_Descriptor.Flags = new MemberInfoFlags() { FlagBits = s_Flags };

            return s_Descriptor;
        }

        /// <summary>
        /// Gets the flags for a specified type
        /// </summary>
        /// <param name="p_Type">Type object</param>
        /// <returns>MemberInfoFlags object</returns>
        public static MemberInfoFlags GetTypeFlags(Type p_Type)
        {
            ushort s_Flags;

            if (p_Type.IsGenericType && p_Type.GetGenericTypeDefinition() == typeof(List<>))
            {
                s_Flags = (ushort)MemberTypeEnum.TypeInfo
                          | ((ushort)TypeCategoryEnum.NotApplicable << (ushort)MemberInfoFlagsEnum.TypeCategoryShift)
                          | ((ushort)BasicTypesEnum.Array << (ushort)MemberInfoFlagsEnum.TypeCodeShift);
            }
            else if (p_Type.IsEnum)
            {
                s_Flags = (ushort)MemberTypeEnum.TypeInfo
                          | ((ushort)TypeCategoryEnum.ValueType << (ushort)MemberInfoFlagsEnum.TypeCategoryShift)
                          | ((ushort)BasicTypesEnum.Enum << (ushort)MemberInfoFlagsEnum.TypeCodeShift);
            }
            else if (typeof(DataContainer).IsAssignableFrom(p_Type))
            {
                s_Flags = (ushort)MemberTypeEnum.TypeInfo
                          | ((ushort)TypeCategoryEnum.Class << (ushort)MemberInfoFlagsEnum.TypeCategoryShift)
                          | ((ushort)BasicTypesEnum.Class << (ushort)MemberInfoFlagsEnum.TypeCodeShift);
            }

            else
            {
                s_Flags = (ushort)MemberTypeEnum.TypeInfo
                          | ((ushort)TypeCategoryEnum.ValueType << (ushort)MemberInfoFlagsEnum.TypeCategoryShift)
                          | ((ushort)BasicTypesEnum.ValueType << (ushort)MemberInfoFlagsEnum.TypeCodeShift);
            }

            if (Attribute.IsDefined(p_Type, typeof(HomogeneousAttribute)))
                s_Flags |= (ushort)MemberInfoFlagsEnum.Homogeneous;

            if (Attribute.IsDefined(p_Type, typeof(LayoutImmutableAttribute)))
                s_Flags |= (ushort)MemberInfoFlagsEnum.LayoutImmutable;

            if (Attribute.IsDefined(p_Type, typeof(BlittableAttribute)))
                s_Flags |= (ushort)MemberInfoFlagsEnum.Blittable;

            return new MemberInfoFlags() { FlagBits = s_Flags };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="p_PropertyName"></param>
        /// <param name="p_Parent"></param>
        /// <param name="p_OriginalValue"></param>
        /// <param name="p_NewValue"></param>
        /// <returns></returns>
        protected bool OnPropertyChanging<T>(string p_PropertyName, object p_Parent, T p_OriginalValue, T p_NewValue)
        {
            if (PropertyChanging == null)
                return true;

            var s_Args = new PropertyChangingCancelEventArgs(p_PropertyName, p_Parent, p_OriginalValue, p_NewValue);
            PropertyChanging(this, s_Args);
            return !s_Args.Cancel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="p_PropertyName"></param>
        /// <param name="p_Parent"></param>
        /// <param name="p_PreviousValue"></param>
        /// <param name="p_CurrentValue"></param>
        protected void OnPropertyChanged<T>(string p_PropertyName, object p_Parent, T p_PreviousValue, T p_CurrentValue)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new RimePropertyChangedEventArgs(p_PropertyName, p_Parent, p_PreviousValue, p_CurrentValue));
        }
    }

}
