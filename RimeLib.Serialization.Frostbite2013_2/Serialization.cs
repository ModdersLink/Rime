/*
using RimeLib.Frostbite.Containers;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2013_2.Ebx;
using RimeLib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace RimeLib.Serialization.Frostbite2013_2
{
    public class Serialization
    {
        // The partition we are serializing
        private readonly FrostbitePartition m_Partition;

        // Total amount of types in this partition
        private List<RimeLib.Serialization.Ebx.TypeDescriptor> m_TypeDescriptors;

        // List of field descriptors for all of the types
        private List<FieldDescriptor> m_FieldDescriptors;

        // List of all of the instance entries
        private List<InstanceEntry> m_InstanceEntries;

        public List<string> m_TypeStrings;

        /// <summary>
        /// Creates a new serialization instance
        /// </summary>
        /// <param name="p_Partition">Partition to serialize</param>
        public Serialization(FrostbitePartition p_Partition)
        {
            m_Partition = p_Partition;
            m_TypeDescriptors = new List<RimeLib.Serialization.Ebx.TypeDescriptor>();
            m_FieldDescriptors = new List<FieldDescriptor>();
            m_InstanceEntries = new List<InstanceEntry>();
            m_TypeStrings = new List<string>();

            ParsePartition();
        }

        private void ParsePartition()
        {
            // Get the C# type for this partition container
            var s_ContainerType = m_Partition.GetType();
            if (s_ContainerType == null)
            {
                Debug.WriteLine($"Could not find container type for {m_Partition.Name}.");
                return;
            }

            // Iterate each "whole object"
            foreach (var s_PartitionInstance in m_Partition.Instances)
            {
                // Parse each instance
                ParseInstance(s_PartitionInstance);
            }
        }

        private void ParseInstance(DataContainer p_Instance)
        {

            //var s_InstanceTypeDescriptor = p_Instance.GetTypeDescriptor();

            // This is an index of the start of the Fields for this type
            // m_FieldDescriptors[s_TypeDescriptor.LayoutDescriptor]
            // and goes until
            // m_FieldDescriptors[s_TypeDescritpr.LayoutDescriptor + FieldCount]
            //s_InstanceTypeDescriptor.LayoutDescriptor = 0;

            Debug.WriteLine("---");

            // Iterate through each of the fields
            Type? s_CurrentType = p_Instance.GetType();
            int s_MainTypeDescriptorIndex = -1;
            while (s_CurrentType != typeof(System.Dynamic.DynamicObject) && s_CurrentType != typeof(FrostbiteContainer))
            {
                // Check to see if this type has already been added to our list
                if (m_TypeDescriptors.Any(p_TypeDescriptor =>
                {
                    return p_TypeDescriptor.Name == s_CurrentType.Name;
                }))
                {
                    // Go higher up in the inheritance chain
                    s_CurrentType = s_CurrentType.BaseType;

                    continue;
                }

                if (!m_TypeStrings.Contains(s_CurrentType.Name))
                    m_TypeStrings.Add(s_CurrentType.Name);

                // Get the container type attribute
                var s_ContainerTypeAttribute = s_CurrentType.GetCustomAttribute<ContainerTypeAttribute>();
                if (s_ContainerTypeAttribute == null)
                {
                    Debug.WriteLine($"There was an error getting {s_CurrentType.Name} ContainerType attribute.");
                    continue;
                }

                var s_ContainerSizeAttribute = s_CurrentType.GetCustomAttribute<ContainerSizeAttribute>(false);
                if (s_ContainerSizeAttribute == null)
                {
                    if (s_CurrentType == typeof(DataContainer))
                        s_ContainerSizeAttribute = new ContainerSizeAttribute(8);
                    else
                    {
                        Debug.WriteLine($"Skipping instance {s_CurrentType.Name} because container size attribute was not found.");
                        continue;
                    }
                }

                // Get the memberinfoflags attribute
                var s_MemberInfoFlagAttribute = s_CurrentType.GetCustomAttribute<MemberInfoFlagAttribute>();

                // Get all of the fields for this current type
                var s_Fields = GetFieldDescriptorsFromType(s_CurrentType);

                // Iterate each of the fields and add the names to the partition string table
                foreach (var l_Field in s_Fields)
                {
                    var l_FieldName = l_Field.Name;

                    if (!m_TypeStrings.Contains(l_FieldName))
                        m_TypeStrings.Add(l_FieldName);


                    var s_FieldType = l_Field.Flags.GetFieldType();
                    switch (s_FieldType)
                    {
                        case FieldType.Enum:
                            var s_Typ = l_Field.CSharpType;
                            if (!m_TypeStrings.Contains(s_Typ.Name))
                                m_TypeStrings.Add(s_Typ.Name);

                            Array values = Enum.GetValues(s_Typ);

                            foreach (Enum val in values)
                            {
                                if (!m_TypeStrings.Contains(val.ToString()))
                                    m_TypeStrings.Add(val.ToString());
                            }
                            break;
                        case FieldType.Array:
                            if (!m_TypeStrings.Contains("array"))
                                m_TypeStrings.Add("array");
                            break;
                    }
                }

                // Save the start index, because we need to set this in our type descriptor
                var s_FieldStartIndex = m_FieldDescriptors.Count;

                // Add the field descriptors to the long ass list we have
                m_FieldDescriptors.AddRange(s_Fields);

                // Save the ending field descriptor
                var s_FieldEndIndex = m_FieldDescriptors.Count;

                // Create a new type descriptor
                var s_TypeDescriptor = new RimeLib.Serialization.Ebx.TypeDescriptor
                {
                    Alignment = s_ContainerTypeAttribute.DataAlignment,
                    FieldCount = (byte)s_Fields.Count,
                    Flags = new MemberInfoFlags(s_MemberInfoFlagAttribute?.Flag ?? 0),
                    LayoutDescriptor = (uint)s_FieldStartIndex,
                    Name = s_CurrentType.Name,
                    NameHash = FbUtils.HashQuick(s_CurrentType.Name),
                    SecondarySize = 0,
                    Size = s_ContainerSizeAttribute.Size 
                };

                // Add this type descriptor to the list of all type descriptors
                m_TypeDescriptors.Add(s_TypeDescriptor);

                // Save the primary type descriptor index
                /*if (p_Instance.ContainerTypeName == s_CurrentType.Name)
                    s_MainTypeDescriptorIndex = m_TypeDescriptors.Count() - 1;#1#

                // Debug information for rattling off each of the fields within a specific type
                Debug.WriteLine(s_CurrentType.Name);
                s_Fields.ForEach(p_Item => Debug.WriteLine("\t" + p_Item.Name));

                // Go higher up in the inheritance chain
                s_CurrentType = s_CurrentType.BaseType;
            }

            if (s_MainTypeDescriptorIndex == -1)
            {
                return;
            }

            // Create a new instance
            var s_InstanceEntry = new InstanceEntry
            {
                TypeDescriptorIndex = (uint)s_MainTypeDescriptorIndex,
                // NOTE: WE recalculate these later
                InternalCount = 0, // CtrRef's pointing to the same partition
                ExportCount  = 0, // CtrRef's pointing to another partition
            };

            // TODO: Calculate the import and export counts
            // Export Count = new GUID[ExportCount]
            // The export count is stored inside of m_InstanceGuids

            m_InstanceEntries.Add(s_InstanceEntry);
        }

        private List<FieldDescriptor> GetFieldDescriptorsFromType(Type p_InstanceType)
        {
            // NOTE: This will give you everything in the inheritance chain
            // Is this what we want? or no?

            // I'm thinking no, we need to do it based on each type, and if there is inheritance create a new type for it
            // That way each field belongs to the correct type no matter what.

            // Do some reflection on the incoming class
            // TODO: Implement some kind of list in the actual bindings directly (that aren't used for any other purpose)

            var s_FieldDescriptors = new List<FieldDescriptor>();            

            foreach (var s_Property in p_InstanceType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
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

                var s_MemberInfoFlagAttributes = s_Property.GetCustomAttribute<MemberInfoFlagAttribute>();
                if (s_MemberInfoFlagAttributes == null)
                    continue;

                var s_MemberInfoFlags = new MemberInfoFlags
                {
                    FlagBits = s_MemberInfoFlagAttributes.Flag
                };

                var s_FieldName = s_Property.Name;
                var s_Offset = s_FieldAttributes.FieldOffset;

                // Create a new field descriptor based on the provided information
                var s_FieldDescriptor = new FieldDescriptor
                {
                    Name = s_FieldName,
                    NameHash = FbUtils.HashQuick(s_FieldName),
                    FieldType = 0, // This is the TypeDescriptor index, not actual field type
                    Flags = s_MemberInfoFlags,
                    Offset = (int)s_Offset,
                    SecondaryOffset = 0, // Is this ever non-zero?
                    CSharpType = s_Property.PropertyType
                };

                s_FieldDescriptors.Add(s_FieldDescriptor);
            }

            return s_FieldDescriptors;
        }
    }
}
*/
