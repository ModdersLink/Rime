using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2_0.Frostbite.Bundles;
using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Frostbite2_0.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using System;
using System.Linq;

namespace RimeLib.Content.Frostbite2_0.Building
{
    public class CasBundleManifestBuilder
    {
        protected CasBundle m_Header;

        protected BundleDescriptor m_Descriptor;

        /// <summary>
        /// TODO: Implement
        /// </summary>
        public Sha1 Checksum { get; private set; } = new Sha1();

        public CasBundleManifestBuilder(BundleDescriptor p_Descriptor) 
        {
            m_Descriptor = p_Descriptor;
            m_Header = new CasBundle
            {
                Path = p_Descriptor.BundleName,
                ResourceEntries = new CasBundle.Resource[p_Descriptor.Resources.Count],
                EbxEntries = new CasBundle.Ebx[p_Descriptor.Partitions.Count],
                ChunkEntries = new CasBundle.Chunk[p_Descriptor.Chunks.Count],
                ChunkMeta = new ChunkEntry.ChunkMetaEntry[p_Descriptor.Chunks.Count] // NOTE: This matches the amount of chunk entries
            };
        }


        public void Serialize(RimeWriter p_Writer)
        {
            // Validate our entries
            if (!Validate())
            {
                return;
            }

            for (var s_ResourceIndex = 0; s_ResourceIndex < m_Descriptor.Resources.Count; s_ResourceIndex++)
            {
                var s_ResourcePair = m_Descriptor.Resources.ElementAt(s_ResourceIndex);

                var s_ResourceName = s_ResourcePair.Key;
                var s_ResourceObject = s_ResourcePair.Value;
                var s_ResourceVariant = s_ResourcePair.Value as ResourceVariant; // ????
                if (s_ResourceVariant is null)
                    throw new Exception("broke");

                // Get the metadata (if it exists)
                var s_ResourceMetadata = new byte[0];
                if (s_ResourceObject.TryGetMeta(out var s_MetaData))
                {
                    // This file has meta
                    s_ResourceMetadata = s_MetaData;
                }

                m_Header.ResourceEntries[s_ResourceIndex].Name = s_ResourceName;
                m_Header.ResourceEntries[s_ResourceIndex].ResourceType = (int)s_ResourceObject.GetResourceType();
                m_Header.ResourceEntries[s_ResourceIndex].Hash = s_ResourceVariant.GetSha1() ?? new Sha1();
                m_Header.ResourceEntries[s_ResourceIndex].Meta = s_ResourceMetadata;

            }

            // Write all of the entries for chunks
            for (var s_ChunkIndex = 0; s_ChunkIndex < m_Descriptor.Chunks.Count; s_ChunkIndex++)
            {
                var s_ChunkPair = m_Descriptor.Chunks.ElementAt(s_ChunkIndex);

                var s_ChunkId = s_ChunkPair.Key;
                var s_ChunkObject = s_ChunkPair.Value;

                using var s_ChunkReader = s_ChunkObject.GetReader();

                var s_ChunkHash = new Sha1(s_ChunkReader);

                m_Header.ChunkEntries[s_ChunkIndex].Id = s_ChunkId;
                m_Header.ChunkEntries[s_ChunkIndex].Hash = s_ChunkHash;
                m_Header.ChunkEntries[s_ChunkIndex].Size = s_ChunkReader.Length;

                var s_Resource = m_Header.ResourceEntries.FirstOrDefault(p_Entry => p_Entry.Hash == s_ChunkHash);
                if (s_Resource == null)
                    throw new Exception("Could not find the resource for this chunk.");

                // Copy the chunk meta if it exists
                if (s_ChunkObject.TryGetMeta(out DbObject? s_MetaData))
                {
                    
                }

                m_Header.ChunkMeta[s_ChunkIndex].AssetNameHash = (int)RimeLib.Frostbite.Utils.HashQuick(s_Resource.Name); // TODO: Figure out the corelation
                m_Header.ChunkMeta[s_ChunkIndex].Payload = new ChunkEntry.ChunkMetaPayload
                {
                    // TODO: Figure out what goes in here
                };
            }

            for (var s_PartitionIndex = 0; s_PartitionIndex < m_Descriptor.Partitions.Count; ++s_PartitionIndex)
            {
                var s_PartitionPair = m_Descriptor.Partitions.ElementAt(s_PartitionIndex);

                var s_PartitionName = s_PartitionPair.Key;
                var s_PartitionObject = s_PartitionPair.Value;

                var s_PartitionReader = s_PartitionObject.GetReader();
                var s_ParititionSize = s_PartitionObject.GetSize();

                var s_PartitionHash = new Sha1(s_PartitionReader);

                m_Header.EbxEntries[s_PartitionIndex].Name = s_PartitionName;
                m_Header.EbxEntries[s_PartitionIndex].Size = s_ParititionSize;
                m_Header.EbxEntries[s_PartitionIndex].OriginalSize = s_ParititionSize; // TODO: What
                m_Header.EbxEntries[s_PartitionIndex].Hash = s_PartitionHash;
            }

            // Convert the CasBundle header to the DbObject data
            if (!DbObjectConverter.ToDbObjectBytes(m_Header, out byte[] s_Data))
                throw new Exception("could not convert the header data.");

            // Update the checksum
            Checksum = new Sha1(s_Data);

            // Write out the data
            p_Writer.Write(s_Data);
        }

        public bool Validate()
        {
            foreach (var l_Chunk in m_Descriptor.Chunks.Values)
            {
                if (!(l_Chunk is CasChunkEntry))
                    continue;
            }
            return true;
        }
    }
}
