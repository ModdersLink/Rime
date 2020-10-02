using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;
using RimeLib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace RimeLib.Serialization
{
    public class Serialization
    {
        // The partition we are serializing
        private readonly FrostbitePartition m_Partition;

        // This will map each of the FieldDescriptor types to the owning type
        private Dictionary<Ebx.TypeDescriptor, FieldDescriptor[]> m_TypeFieldDict;

        /// <summary>
        /// Creates a new serialization instance
        /// </summary>
        /// <param name="p_Partition">Partition to serialize</param>
        public Serialization(FrostbitePartition p_Partition)
        {
            m_Partition = p_Partition;
            m_TypeFieldDict = new Dictionary<Ebx.TypeDescriptor, FieldDescriptor[]>();

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
            var s_TypeDescriptor = p_Instance.GetTypeDescriptor();

            // This is an index of the start of the Fields for this type
            // m_FieldDescriptors[s_TypeDescriptor.LayoutDescriptor]
            // and goes until
            // m_FieldDescriptors[s_TypeDescritpr.LayoutDescriptor + FieldCount]
            s_TypeDescriptor.LayoutDescriptor = 0;

            // Iterate through each of the fields
            Type? s_CurrentType = p_Instance.GetType();
            while (s_CurrentType != typeof(System.Dynamic.DynamicObject))
            {
                var s_Fields = GetFieldsFromType(s_CurrentType);

                Debug.WriteLine(s_CurrentType.Name);
                s_Fields.ForEach(p_Item => Debug.WriteLine("\t" + p_Item.Name));

                s_CurrentType = s_CurrentType.BaseType;
            }
            //var s_Fields = GetFieldsFromType(p_Instance);
        }

        private List<FieldDescriptor> GetFieldsFromType(Type p_InstanceType)
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
                    SecondaryOffset = 0 // Is this ever non-zero?
                };

                s_FieldDescriptors.Add(s_FieldDescriptor);
            }

            return s_FieldDescriptors;
        }
    }
}
