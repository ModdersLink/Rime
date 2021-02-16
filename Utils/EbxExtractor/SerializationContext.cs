using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EbxExtractor
{
    public class SerializationContext : ISerializationContext
    {
        // Type string table
        protected StringTable m_TypeStrings;

        // String table
        protected StringTable m_StringTable;

        // Created InstanceEntries
        protected List<InstanceEntry> m_InstanceEntries;

        // Created FieldDescriptors
        protected List<FieldDescriptor> m_FieldDescriptors;

        // Created TypeDescriptors
        protected List<TypeDescriptor> m_TypeDescriptors;

        // A list of all partitions that are referenced within this partition in some way shape or form
        protected List<FrostbitePartition> m_ReferencedPartitions;

        // The partition we are serializing
        protected FrostbitePartition m_Partition;

        // PARTITION SPECIFIC STUFF

        // This is the full path of the partition, (ex: Weapons/M1014/U_M1014_Flashlight)
        private string m_PartitionName;

        // Guid of the partition
        private GUID m_PartitionGuid;

        // Guid of the primary instance in this guid
        private GUID m_PartitionPrimaryInstanceGuid;
        // END PARTITION SPECIFIC STUFF

        /// <summary>
        /// Determines should there be new serialization contexts based on dependencies of this current partition
        /// </summary>
        public bool ShouldHandleDependencies = false;

        public SerializationContext(FrostbitePartition p_Partition)
        {
            m_TypeStrings = new StringTable();
            m_StringTable = new StringTable();
            m_InstanceEntries = new List<InstanceEntry>();
            m_FieldDescriptors = new List<FieldDescriptor>();

            // This is just used for internal tracking
            m_ReferencedPartitions = new List<FrostbitePartition>();

            m_Partition = p_Partition;
        }

        /// <summary>
        /// Initially this will only support serialization of partitions
        /// 
        /// We will eventually expand the SerializationContext to rebuild whole games
        /// but baby steps for now
        /// </summary>
        public void Parse()
        {
            // "Weapons/M1014/U_M1014_Flashlight"
            m_PartitionName = m_Partition.Name;

            // Save the partition guid
            m_PartitionGuid = m_Partition.PartitionGuid;

            // Save the partition primmary instance guid
            m_PartitionPrimaryInstanceGuid = m_Partition.PrimaryInstanceGuid;

            // "FrostbitePartition"
            var s_PartitionTypeName = m_Partition.GetType().Name;
            if (m_Partition.GetType() != typeof(FrostbitePartition))
                throw new InvalidOperationException("attempted to serialize something that is not FrostbitePartition");

#if DEBUG
            Console.WriteLine($"Parsing partition type ({s_PartitionTypeName}) ({m_PartitionName})");
#endif

            // Iterate through all of the instances that we have and collect information
            for (var l_InstanceIndex = 0; l_InstanceIndex < m_Partition.Instances.Count; ++l_InstanceIndex)
            {
                // Bounds checking
                if (l_InstanceIndex >= m_Partition.Instances.Count)
                    throw new IndexOutOfRangeException("invalid instance index");

                // Get the instance container
                var l_InstanceContainer = m_Partition.Instances[l_InstanceIndex];

                // Type checking
                if (l_InstanceContainer.GetType().IsAssignableFrom(typeof(DataContainer)))
                    throw new InvalidOperationException("instance is not a DataContainer");

                // Parse the instance
                ParseInstance(l_InstanceContainer);
            }

        }

        protected void ParseInstance(DataContainer p_DataContainer)
        {
            // Get the type of this DataContainer
            var s_ContainerType = p_DataContainer.GetType();

            // "UnlockAsset"
            var s_TypeName = s_ContainerType.Name;

            // Add this "main" type to our type strings
            m_TypeStrings.AddString(s_TypeName);

            // Get all properties
            var s_Properties = s_ContainerType.GetProperties();

            // Iterate through all properties
            for (var l_PropertyIndex = 0; l_PropertyIndex < s_Properties.Length; ++l_PropertyIndex)
            {
                // Check that the property length
                if (l_PropertyIndex >= s_Properties.Length)
                    throw new IndexOutOfRangeException("invalid property index");

                // Get the C# property, which represents a field
                var l_PropertyInfo = s_Properties[l_PropertyIndex];

                var l_PropertyType = l_PropertyInfo.PropertyType;

                // Attempt to get our container field attribute which contains some data from Frostbite
                var l_ContainerTypeAttribute = l_PropertyInfo.GetCustomAttribute<ContainerFieldAttribute>();

                // Validate that this field has "some" container field attribute, otherwise skip it (could be editor-only data, etc)
                if (l_ContainerTypeAttribute is null)
                    continue;

                // "LinkedTo"
                var l_FieldName = l_PropertyInfo.Name;

                // Add the field name to our string table
                m_StringTable.AddString(l_FieldName);

                // Determine if this is an array of some kind

                // TODO: Figure out how to handle arrays

                // Check if this is a RefArray
                if (l_PropertyType.IsGenericType && l_PropertyType.GetGenericTypeDefinition() == typeof(RefArray<>))
                {
                }
                else if (l_PropertyType.IsGenericType && l_PropertyType.GetGenericTypeDefinition() == typeof(IList<>)) // Generic List<T>
                {
                }
                else if (l_PropertyType.IsGenericType && l_PropertyType.GetGenericTypeDefinition() == typeof(CtrRef<>))
                {
                    // This is either an internal reference (pointing to a instance within the same partition)
                    // or an external reference (pointing to an instance inside a different partition)
                }
                else if (l_PropertyType.IsGenericType)
                    throw new NotImplementedException("generic type not handled, contact a developer");

                // TODO: Handle inheritance

                // TODO: Generate the new type if we haven't, and also populate the fields
            }
        }
    }
}
