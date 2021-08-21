using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using RimeLib.Utils;
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

        // String table, this is used for CString and FileRef types only, everything else goes in m_TypeStrings
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

        protected List<KeyValuePair<GUID, GUID>> m_ExternalPartitionGuids;
        protected List<KeyValuePair<GUID, GUID>> m_InternalPartitionGuids;

        protected List<string> m_BuiltinTypes = new List<string>
        {
            "String",
            "UInt32",
            "Boolean"
        };

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
            m_TypeDescriptors = new List<TypeDescriptor>();

            // This is just used for internal tracking
            m_ReferencedPartitions = new List<FrostbitePartition>();

            m_Partition = p_Partition;

            m_ExternalPartitionGuids = new List<KeyValuePair<GUID, GUID>>();
            m_InternalPartitionGuids = new List<KeyValuePair<GUID, GUID>>();
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

        protected void ParseTypes(dynamic p_Object, DataContainer p_ParentContainer)
        {
            if (p_Object is DataContainer)
                m_TypeStrings.AddString("DataContainer");
            
            // We need to do this first for the incoming type
            Type s_ObjectType = p_Object.GetType();

            var s_PotentialTypeIndex = (ushort)m_TypeDescriptors.Count;

            // Check if this is a RefArray
            if (s_ObjectType.IsGenericType && s_ObjectType.GetGenericTypeDefinition() == typeof(RefArray<>))
            {
                s_ObjectType = s_ObjectType.GetGenericArguments().First();
            }
            else if (s_ObjectType.IsGenericType && s_ObjectType.GetGenericTypeDefinition() == typeof(IList<>)) // Generic List<T>
            {
                s_ObjectType = s_ObjectType.GetGenericArguments().First();
                m_TypeStrings.AddString("array");
            }
            else if (s_ObjectType.IsGenericType && s_ObjectType.GetGenericTypeDefinition() == typeof(CtrRef<>))
            {
                // This is either an internal reference (pointing to a instance within the same partition)
                // or an external reference (pointing to an instance inside a different partition)

                s_ObjectType = s_ObjectType.GetGenericArguments().First();

                // TODO: Figure out what actual data we need to collect here,
                // do we need just the instance guids? partition/instance pair?
                // just get as much information as you can right here and now to make our lives easier

                // Check to see if this CtrRef is *null*, if so ignore as there are no references
                if (p_Object.PartitionGuid != GUID.Empty)
                {
                    // Determine if this is an internal or external reference
                    if (p_Object.PartitionGuid == p_ParentContainer.PartitionGuid)
                        m_InternalPartitionGuids.Add(new KeyValuePair<GUID, GUID>(p_Object.PartitionGuid, p_Object.InstanceGuid));
                    else
                        m_ExternalPartitionGuids.Add(new KeyValuePair<GUID, GUID>(p_Object.PartitionGuid, p_Object.InstanceGuid));
                }
            }
            else if (s_ObjectType.IsGenericType)
                throw new NotImplementedException("generic type not handled, contact a developer");

            // Ding ding ding, we have frostbite inheritance
            if (s_ObjectType.BaseType?.GetCustomAttribute<ContainerTypeAttribute>() is not null)
            {
#if DEBUG
                Console.WriteLine($"Inherited Fb Class: {s_ObjectType.BaseType.Name}.");
#endif
                // TODO: Figure out what else needs to be done
                m_TypeStrings.AddString("$");
            }
            // Next we will need to create the TypeInstance for this paticular type
            // we do this by getting the ContainerType information

            var s_ContainerTypeAttribute = s_ObjectType.GetCustomAttribute<ContainerTypeAttribute>();
            if (s_ContainerTypeAttribute is null)
            {
                // This is an expected failure case for builtin frostbite/pod types
                if (m_BuiltinTypes.Contains(s_ObjectType.Name))
                    return;

                // Log skipped variables for our own good
                Console.WriteLine($"Skipping: {s_ObjectType.Name}");
                return;
            }

            // "UnlockAsset"
            var s_TypeName = s_ObjectType.Name;

            // Check to see if this type has already been added before
            if (m_TypeStrings.GetOffset(s_TypeName) != -1)
                return;

            // Add this "main" type to our type strings
            m_TypeStrings.AddString(s_TypeName);

            // Check to see if the type is an enum
            if (s_ObjectType.IsEnum)
            {
                // If the type is an enum, we need to not only add the typestring name, but each of the values
                var s_EnumNames = Enum.GetNames(s_ObjectType);
                if (s_EnumNames.Length > 0)
                    m_TypeStrings.AddString("member");

                foreach (var l_EnumName in s_EnumNames)
                {
                    if (!m_TypeStrings.AddString(l_EnumName))
                        throw new Exception("could not add enum name.");
                }
            }
            // Then do the exact same thing for each of the properties

            // Get all properties (EBX fields)
            PropertyInfo[] s_Properties = s_ObjectType.GetProperties();

            var s_CalculatedFieldCount = 0;
            // Iterate through all properties, to calculate the field count
            for (var l_PropertyIndex = 0; l_PropertyIndex < s_Properties.Length; ++l_PropertyIndex)
            {
                // Check that the property length
                if (l_PropertyIndex >= s_Properties.Length)
                    throw new IndexOutOfRangeException("invalid property index");

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

                s_CalculatedFieldCount++;
            }


            // Save the current type descriptor index
            var s_TypeDescriptorIndex = m_TypeDescriptors.Count;
            var s_FieldTypeStartIndex = (uint)m_FieldDescriptors.Count;

            // Add dummy field descriptors
            for (var l_FieldIndex = 0; l_FieldIndex < s_CalculatedFieldCount; ++l_FieldIndex)
                m_FieldDescriptors.Add(new FieldDescriptor());

            // Add a "dummy" type descriptor
            m_TypeDescriptors.Add(new TypeDescriptor
            {
                Alignment = s_ContainerTypeAttribute.DataAlignment,
                FieldCount = (byte)s_CalculatedFieldCount, // TODO: Implement, this is the field count
                Flags = new MemberInfoFlags(s_ContainerTypeAttribute.Flags),
                LayoutDescriptor = (uint)s_FieldTypeStartIndex, // TODO: Implement, this is an index to the start of the FieldDescriptor start + this types index, then we read FieldCount from that FieldDescriptor Start + this types index + fieldCount
                Name = s_TypeName,
                NameHash = FbUtils.HashQuick(s_TypeName),
                SecondarySize = 0,
                Size = s_ContainerTypeAttribute.Size
            });

            // Iterate through all properties, to fill in information
            var s_CurrentFieldCount = 0;
            for (var l_PropertyIndex = 0; l_PropertyIndex < s_Properties.Length; ++l_PropertyIndex)
            {
                // Check that the property length
                if (l_PropertyIndex >= s_Properties.Length)
                    throw new IndexOutOfRangeException("invalid property index");

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

                // Add the field name to our string table
                m_TypeStrings.AddString(l_FieldName);

                // Get the value of this property
                dynamic l_Value = l_PropertyInfo.GetValue(p_ParentContainer);
                if (l_Value is null)
                    continue;

                // Get the current field type index
                var l_FieldTypeDescriptorIndex = m_TypeDescriptors.Count;

                // Parse the type for the field
                ParseTypes(l_Value, p_ParentContainer);

                m_FieldDescriptors[(int)s_FieldTypeStartIndex + (int)s_CurrentFieldCount] = new FieldDescriptor
                {
                    CSharpType = l_PropertyType,
                    Flags = new MemberInfoFlags(l_ContainerFieldAttribute.FieldFlags),
                    Name = l_FieldName,
                    NameHash = FbUtils.HashQuick(l_FieldName),
                    FieldType = (ushort)l_FieldTypeDescriptorIndex, // TODO: Implement this, This is the TypeDescriptor index (which has not been created/set yet)
                    SecondaryOffset = 0,
                    Offset = (int)l_ContainerFieldAttribute.FieldOffset
                };

                // Not all fields will be serialized so we update our current count
                s_CurrentFieldCount++;
            }
        }

        protected void ParseInstance(DataContainer p_DataContainer)
        {
            // This should go through and make sure all types are parsed. Need to confirm
            ParseTypes(p_DataContainer, p_DataContainer);

            var s_InstanceIndex = m_TypeDescriptors.FindIndex(p_TypeDescriptor => p_TypeDescriptor.Name == p_DataContainer.ContainerTypeName);
            if (s_InstanceIndex == -1)
                throw new Exception("could not find type index.");

            /*
             *                 for (var i = 0; i < s_Entry.ExportCount; ++i)
                {
                    var s_Guid = new GUID(m_Reader);
                    m_InstanceGuiDs.Add(s_Guid);

                    // Create our container used for binding.
                    if (s_ContainerType != null)
                    {
                        m_CurrentContainer = (FrostbiteContainer)Activator.CreateInstance(s_ContainerType);
                        ((DataContainer)m_CurrentContainer).InstanceGuid = s_Guid;
                        ((DataContainer)m_CurrentContainer).PartitionGuid = m_Header.PartitionGuid;
                    }
                    else
                    {
                        m_CurrentContainer = new DataContainer()
                        {
                            ContainerAlignment = s_Descriptor.Alignment,
                            ContainerFlags = s_Descriptor.Flags.FlagBits,
                            ContainerTypeName = s_Descriptor.Name,
                            InstanceGuid = s_Guid,
                            PartitionGuid = m_Header.PartitionGuid
                        };

                    }

                    m_Instances.Add(new Instance { Id = s_Guid, Type = ParseTypeInstance(s_Guid, s_Entry.TypeDescriptorIndex) });

                    // Add our fully parsed container to the list of parsed containers.
                    m_ParsingPartition.AddInstance((DataContainer)m_CurrentContainer, s_Guid == m_Header.PrimaryInstanceGuid);
                    m_CurrentContainer = null;
                }

            */

            // TODO: Figure out ExportCount and how the Instance GUID's are generated
            m_InstanceEntries.Add(new InstanceEntry
            {
                ExportCount = 1, // 1, export count is a pair of partition/instance guids in a row
                InternalCount = 0, // 0, we have an exception if it's not 0
                TypeDescriptorIndex = (uint)s_InstanceIndex
            });


            // TODO: Generate all GUID's
            // TODO: With generating new GUIDs read all GUIDs in the current game archives to prevent conflicts
            // TODO: Also add overriding of GUID's from file so we can rebuild in place with same GUIDs

        }
    }
}
