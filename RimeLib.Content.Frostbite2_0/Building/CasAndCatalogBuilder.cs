using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2_0.Frostbite.Cas;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System.Collections.Generic;
using System.IO;

namespace RimeLib.Content.Frostbite2_0.Building
{

    class CasAndCatalogBuilder
    {
        private Catalog m_Catalog;

        private uint m_StartIndex;

        private readonly BundleDescriptor m_Descriptor;

        private const int c_MaxContentAddressableStorageSize = 1073741824;

        private List<MemoryStream> m_CasStreams = new List<MemoryStream>();

        public CasAndCatalogBuilder(BundleDescriptor p_Descriptor, string p_Path, uint p_StartIndex = 0)
        {
            // Assign the bundle descriptor
            m_Descriptor = p_Descriptor;

            // Create a new catalog file
            m_Catalog = new Catalog
            {
                Path = p_Path, // TODO: Check to see if this is the name, or the absolute file path on disk
            };

            m_StartIndex = p_StartIndex;
        }

        public void Serialize(RimeWriter p_Writer, string p_CasPath)
        {
            foreach (var s_Partition in m_Descriptor.Partitions)
                AddObject(s_Partition.Value);

            foreach (var s_Resource in m_Descriptor.Resources)
                AddObject(s_Resource.Value);

            foreach (var s_Chunk in m_Descriptor.Chunks)
                AddObject(s_Chunk.Value);

            // Serialize the catalog
            p_Writer.Write(Catalog.c_Nyan);
            p_Writer.Write(Catalog.c_Nyan);

            // Write out all of the catalog entries
            foreach (var s_Entry in m_Catalog.Entries.Values)
                s_Entry.Serialize(p_Writer);

            // TODO: XOR this shit back

            for (var s_CasStreamIndex = 0; s_CasStreamIndex < m_CasStreams.Count; ++s_CasStreamIndex)
            {
                var s_CasFileName = $"{p_CasPath}/cas_{m_StartIndex + s_CasStreamIndex:D2}.cas";

                using var s_CasFileStream = new FileStream(s_CasFileName, FileMode.Create, FileAccess.ReadWrite);

                m_CasStreams[s_CasStreamIndex].WriteTo(s_CasFileStream);
            }
        }

        private void AddObject(IReadableObject p_Object)
        {
            var s_ObjectReader = p_Object.GetReader();
            var s_Data = s_ObjectReader.ReadBytes((int)p_Object.GetSize());

            var s_Stream = FindStreamWithSpace((uint)s_Data.Length, out uint s_Index);

            var s_Hash = Sha1.FromData(s_Data);

            var s_Entry = new CatalogEntry(m_Catalog)
            {
                Hash = s_Hash,
                FileNumber = m_StartIndex + s_Index,
                FileOffset = (uint)s_Stream.Position,
                FileSize = (uint)s_Data.Length
            };

            m_Catalog.Entries.AddOrUpdate(s_Hash, s_Entry, (p_K, p_V) => s_Entry);

            s_Stream.Write(s_Data);
        }

        private MemoryStream FindStreamWithSpace(uint p_DataLength, out uint p_Index)
        {
            // If we currently have no streams open, open one
            if (m_CasStreams.Count == 0)
            {
                var s_FirstStream = new MemoryStream();
                m_CasStreams.Add(s_FirstStream);
                p_Index = 0;

                return s_FirstStream;
            }

            // Iterate over all the current open streams
            for (uint s_CasStreamIndex = 0; s_CasStreamIndex < m_CasStreams.Count; ++s_CasStreamIndex)
            {
                var s_ExistingStream = m_CasStreams[(int)s_CasStreamIndex];

                // Validate that this stream has enough space for the data we want to insert
                if (s_ExistingStream.Length + p_DataLength > c_MaxContentAddressableStorageSize)
                    continue;

                // If we do have enough space in this stream, return it
                p_Index = s_CasStreamIndex;
                return s_ExistingStream;
            }

            // If we iterate through all existing streams and there is no space, then create a new one
            var s_NewStream = new MemoryStream();
            m_CasStreams.Add(s_NewStream);
            p_Index = (uint)(m_CasStreams.Count - 1);

            return s_NewStream;
        }

    }
}
