using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization
{
    public class TypeTable
    {
        private List<TypeEntry> m_Types;

        private List<TypeDescriptor> m_TypeDescriptors;
        private List<FieldDescriptor> m_FieldDescriptors;

        protected List<string> m_BuiltinTypes;


        private const int c_Fb20MaxFields = 255;

        public TypeTable()
        {
            m_Types = new List<TypeEntry>();
            m_TypeDescriptors = new List<TypeDescriptor>();
            m_FieldDescriptors = new List<FieldDescriptor>();

            m_BuiltinTypes = new List<string>
            {
                "String",
                "UInt32",
                "Boolean"
            };
        }

        private bool SanityCheck()
        {
            // TODO: Ensure that there are no duplicate types

            // TODO: Ensure that type fields have proper linkback

            // TODO: Make sure that all types are covered properly

            return true;
        }

        public void Generate_FrostbiteTypes()
        {
            if (!SanityCheck())
                throw new Exception("Failed sanity check.");

            var s_TotalFieldCount = m_Types.Sum(p_Type => p_Type.Fields.Count());

            m_FieldDescriptors = new List<FieldDescriptor>(s_TotalFieldCount);

            // Calculate all of the fields
            for (var l_TypeIndex = 0; l_TypeIndex < m_Types.Count; ++l_TypeIndex)
            {

            }
            //m_TypeDescriptors = new List<TypeDescriptor>(m_Types.Count);

            //for (var l_TypeIndex = 0; l_TypeIndex < m_Types.Count; ++l_TypeIndex)
            //{
            //    var l_Type = m_Types[l_TypeIndex];
            //    var l_TypeDescriptor = m_TypeDescriptors[l_TypeIndex];

            //    l_TypeDescriptor.Alignment = (byte)l_Type.Alignment;

            //    var l_FieldCount = l_Type.Fields.Count();
            //    if (l_FieldCount >= c_Fb20MaxFields)
            //        throw new Exception("reached beyond the maximum field count");

            //    l_TypeDescriptor.FieldCount = (byte)l_FieldCount;

            //    l_TypeDescriptor.Flags = new MemberInfoFlags(l_Type.Flags);
            //    l_TypeDescriptor.LayoutDescriptor = null; // This is pointing to the index of the start of the fields

            //    // All fields are stored back to back for each type

            //}
        }

        /// <summary>
        /// Get the base Frostbite Type information
        /// 
        /// This will strip any generics of their used class. Fuck I hate arrays...
        /// </summary>
        /// <param name="p_Object"></param>
        public void AddTypeByObject(dynamic p_Object)
        {
            AddType(p_Object.GetType());
        }

        public TypeEntry? AddType(Type p_IncomingType)
        {
            var s_TypeEntry = new TypeEntry();

            // C# wizardry is pretty neat
            var s_ObjectType = p_IncomingType;

            // TODO: Parse all of the type information into TypeEntry's

            // Check if this is a RefArray
            if (s_ObjectType.IsGenericType && s_ObjectType.GetGenericTypeDefinition() == typeof(RefArray<>))
            {
                s_ObjectType = s_ObjectType.GetGenericArguments().First();
            }
            else if (s_ObjectType.IsGenericType && s_ObjectType.GetGenericTypeDefinition() == typeof(IList<>)) // Generic List<T>
            {
                s_ObjectType = s_ObjectType.GetGenericArguments().First();
            }
            else if (s_ObjectType.IsGenericType)
                throw new NotImplementedException("generic type not handled, contact a developer");


            // Next we will need to create the TypeInstance for this paticular type
            // we do this by getting the ContainerType information

            var s_ContainerTypeAttribute = s_ObjectType.GetCustomAttribute<ContainerTypeAttribute>();
            if (s_ContainerTypeAttribute is null)
            {
                // This is an expected failure case for builtin frostbite/pod types
                if (m_BuiltinTypes.Contains(s_ObjectType.Name))
                    return null;

                // Log skipped variables for our own good
                Console.WriteLine($"Skipping: {s_ObjectType.Name}");
                return null;
            }

            // "UnlockAsset"
            var s_TypeName = s_ObjectType.Name;

            // Check to see if we already have this type added
            var s_ExistingType = m_Types.FirstOrDefault(p_Type => p_Type.Name == s_TypeName);
            if (s_ExistingType is not null)
                return s_ExistingType;

            // Set the type name and other information
            s_TypeEntry.Name = s_TypeName;
            s_TypeEntry.Size = s_ContainerTypeAttribute.Size;
            s_TypeEntry.Flags = s_ContainerTypeAttribute.Flags;
            s_TypeEntry.Alignment = s_ContainerTypeAttribute.DataAlignment;

            // Check to see if the type is an enum
            if (s_ObjectType.IsEnum)
            {
                // TODO: Handle enums


                // TODO: Remove the code below
                //// If the type is an enum, we need to not only add the typestring name, but each of the values
                //var s_EnumNames = Enum.GetNames(s_ObjectType);
                //if (s_EnumNames.Length > 0)
                //    m_TypeStrings.AddString("member");

                //foreach (var l_EnumName in s_EnumNames)
                //{
                //    if (!m_TypeStrings.AddString(l_EnumName))
                //        throw new Exception("could not add enum name.");
                //}
            }
            // Then do the exact same thing for each of the properties

            // Get all properties (EBX fields)
            PropertyInfo[] s_Properties = s_ObjectType.GetProperties();

            // Iterate through all properties, to calculate the field count
            for (var l_PropertyIndex = 0; l_PropertyIndex < s_Properties.Length; ++l_PropertyIndex)
            {
                // Get the C# property, which represents a field
                PropertyInfo l_PropertyInfo = s_Properties[l_PropertyIndex];

                Type l_PropertyType = l_PropertyInfo.PropertyType;

                // Attempt to get our container field attribute which contains some data from Frostbite
                var l_ContainerFieldAttribute = l_PropertyInfo.GetCustomAttribute<ContainerFieldAttribute>();

                // Validate that this field has "some" container field attribute, otherwise skip it (could be editor-only data, etc)
                if (l_ContainerFieldAttribute is null)
                    continue;

                // "LinkedTo"
                var l_FieldName = l_PropertyInfo.Name;

#if DEBUG
                Console.WriteLine($"Parsing field: {l_FieldName}.");
#endif

                s_TypeEntry.Fields.Add(new FieldEntry
                {
                    FieldType = l_PropertyType,
                    Flags = l_ContainerFieldAttribute.FieldFlags,
                    Parent = s_TypeEntry,
                    Name = l_FieldName,
                    Offset = l_ContainerFieldAttribute.FieldOffset
                });
            }

            // Ding ding ding, we have frostbite inheritance
            if (s_ObjectType.BaseType?.GetCustomAttribute<ContainerTypeAttribute>() is not null)
            {
#if DEBUG
                Console.WriteLine($"Inherited Fb Class: {s_ObjectType.BaseType.Name}.");
#endif

                var s_InheritedType = AddType(s_ObjectType.BaseType);

                // Link up the inherited type
                s_TypeEntry.InheritedType = s_InheritedType;
            }

            m_Types.Add(s_TypeEntry);
            Console.WriteLine($"Added {s_TypeEntry.Name}");

            return s_TypeEntry;
        }
        
    }
}
