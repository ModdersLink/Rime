using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimeLib.IO;
using RimeLib.Serialization.Ebx;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public class EbxWriter
    {
        private StreamingPartitionHeader m_Header;

        private RimeWriter m_PayloadWriter;
        private RimeWriter m_TypeStringWriter;
        private RimeWriter m_StringWriter;
        private RimeWriter m_ArrayPayloadWriter;

        private List<ImportEntry> m_ImportEntries;
        private List<FieldDescriptor> m_FieldDescriptors;
        private List<TypeDescriptor> m_TypeDescriptors;
        private List<InstanceEntry> m_InstanceEntries;
        private List<ArrayEntry> m_ArrayEntries;

        public void Serialize(RimeWriter p_Writer, DatabasePartition p_Partition)
        {
            m_Header = new StreamingPartitionHeader()
            {
                Magic = 0x0FB2D1CE,
                MetaSize = 0,
                PayloadSize = 0,
                ImportCount = 0,
                TypeCount = 0,
                TypeDescriptorCount = 0,
                FieldDescriptorCount = 0,
                TypeStringTableSize = 0,
                StringTableSize = 0,
                ArrayCount = 0,
                ArrayOffset = 0,
                PartitionGuid = p_Partition.PartitionGuid,
                PrimaryInstanceGuid = p_Partition.PrimaryInstanceGuid,
            };

            m_ImportEntries = new List<ImportEntry>();
            m_FieldDescriptors = new List<FieldDescriptor>();
            m_TypeDescriptors = new List<TypeDescriptor>();
            m_InstanceEntries = new List<InstanceEntry>();
            m_ArrayEntries = new List<ArrayEntry>();

            m_PayloadWriter = new RimeWriter(new MemoryStream());
            m_TypeStringWriter = new RimeWriter(new MemoryStream());
            m_StringWriter = new RimeWriter(new MemoryStream());
            m_ArrayPayloadWriter = new RimeWriter(new MemoryStream());

            // Group instances by type.
            var s_GroupedInstances = p_Partition.Instances.GroupBy((p_Pair) => p_Pair.Value.GetType());

            foreach (var s_InstanceGroup in s_GroupedInstances)
            {
                var s_InstanceEntry = new InstanceEntry()
                {
                    InternalCount = 0,
                    ExportCount = 0,
                    TypeDescriptorIndex = WriteTypeDescriptor(s_InstanceGroup.Key),
                };

                foreach (var (s_InstanceGuid, s_Instance) in s_InstanceGroup)
                {
                    ++s_InstanceEntry.ExportCount;
                    s_InstanceGuid.Serialize(m_PayloadWriter);
                }

                m_InstanceEntries.Add(s_InstanceEntry);
            }
        }

        private uint WriteTypeDescriptor(Type p_Type)
        {
            // TODO
            return 0;
        }
    }
}
