using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fb;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization.Ebx;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public class EbxWriter : IEbxWriter
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

        private DatabasePartition m_Partition;
        
        private Dictionary<GUID, uint> m_InternalInstanceGuids;
        private Dictionary<string, uint> m_WrittenStrings;
        private Dictionary<string, uint> m_WrittenTypeStrings;

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

            m_Partition = p_Partition;

            m_ImportEntries = new List<ImportEntry>();
            m_FieldDescriptors = new List<FieldDescriptor>();
            m_TypeDescriptors = new List<TypeDescriptor>();
            m_InstanceEntries = new List<InstanceEntry>();
            m_ArrayEntries = new List<ArrayEntry>();

            m_PayloadWriter = new RimeWriter(new MemoryStream());
            m_TypeStringWriter = new RimeWriter(new MemoryStream());
            m_StringWriter = new RimeWriter(new MemoryStream());
            m_ArrayPayloadWriter = new RimeWriter(new MemoryStream());

            m_WrittenStrings = new Dictionary<string, uint>();
            m_WrittenTypeStrings = new Dictionary<string, uint>();

            // Group instances by type.
            var s_GroupedInstances = p_Partition.Instances.GroupBy((p_Pair) => p_Pair.Value.GetType());

            var s_SortedInstances = new SortedDictionary<string, SortedDictionary<GUID, DataContainer>>();

            foreach (var s_InstanceGroup in s_GroupedInstances)
            {
                var s_Group = new SortedDictionary<GUID, DataContainer>();

                foreach (var (s_InstanceGuid, s_Instance) in s_InstanceGroup)
                    s_Group.Add(s_InstanceGuid, s_Instance);

                s_SortedInstances.Add(s_InstanceGroup.Key.FullName, s_Group);
            }

            // Calculate internal instance indices.
            // Since everything is grouped and sorted, the indices won't change while we are serializing.
            m_InternalInstanceGuids = new Dictionary<GUID, uint>();
            var s_InstanceIndex = 0u;

            foreach (var (_, s_Group) in s_SortedInstances)
                foreach (var (s_InstanceGuid, _) in s_Group)
                    m_InternalInstanceGuids.Add(s_InstanceGuid, s_InstanceIndex++);

            foreach (var (s_TypeName, s_Group) in s_SortedInstances)
            {
                var s_InstanceEntry = new InstanceEntry()
                {
                    InternalCount = 0,
                    ExportCount = 0,
                    TypeDescriptorIndex = WriteTypeDescriptor(Type.GetType(s_TypeName)),
                };

                foreach (var (s_InstanceGuid, s_Instance) in s_Group)
                {
                    ++s_InstanceEntry.ExportCount;
                    s_InstanceGuid.Serialize(m_PayloadWriter);
                    s_Instance.Serialize(m_PayloadWriter, this);
                }

                m_InstanceEntries.Add(s_InstanceEntry);
            }
        }

        private uint WriteTypeDescriptor(Type p_Type)
        {
            // TODO
            return 0;
        }

        public uint WriteImport(CtrRefBase p_CtrRef)
        {
            if (p_CtrRef.IsNull())
                return 0;

            if (p_CtrRef.PartitionGuid == m_Partition.PartitionGuid)
            {
                if (m_InternalInstanceGuids.TryGetValue(p_CtrRef.InstanceGuid, out var s_Index))
                    return s_Index;

                throw new Exception($"Found internal reference to instance '{p_CtrRef.InstanceGuid}', but this instance doesn't exist in this partition.");
            }

            // See if we already have an entry for this import.
            var s_ImportIndex = m_ImportEntries.FindIndex(
                (p_Entry) => p_Entry.InstanceGuid == p_CtrRef.InstanceGuid &&
                             p_Entry.PartitionGuid == p_CtrRef.PartitionGuid
            );

            if (s_ImportIndex == -1)
            {
                // Import not found, create one.
                s_ImportIndex = m_ImportEntries.Count;

                m_ImportEntries.Add(new ImportEntry()
                {
                    InstanceGuid = p_CtrRef.InstanceGuid,
                    PartitionGuid = p_CtrRef.PartitionGuid,
                });
            }

            return (uint) s_ImportIndex;
        }

        public uint WriteString(string p_String)
        {
            if (m_WrittenStrings.TryGetValue(p_String, out var s_Offset))
                return s_Offset;

            var s_StringOffset = m_StringWriter.Position;

            m_StringWriter.Write(Encoding.UTF8.GetBytes(p_String));
            m_StringWriter.WriteByte(0);

            m_WrittenStrings.Add(p_String, (uint) s_StringOffset);

            return (uint) s_StringOffset;
        }

        public (RimeWriter, uint) GetArrayWriter(Type p_ArrayType, int p_ElementCount)
        {
            m_ArrayPayloadWriter.Align(4);

            var s_ArrayIndex = m_ArrayEntries.Count;
            m_ArrayEntries.Add(new ArrayEntry()
            {
                ElementCount = (uint) p_ElementCount,
                Offset = (uint) m_ArrayPayloadWriter.Position,
                TypeDescriptorIndex = WriteTypeDescriptor(p_ArrayType),
            });

            return (m_ArrayPayloadWriter, (uint) s_ArrayIndex);
        }
    }
}
