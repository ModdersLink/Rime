using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2_0.Frostbite.Bundles;
using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Frostbite2_0.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using System;
using System.Collections.Generic;
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
                ChunkEntries = p_Descriptor.Chunks.Count != 0 ? new CasBundle.Chunk[p_Descriptor.Chunks.Count] : null,
                ChunkMeta = p_Descriptor.Chunks.Count != 0 ? new ChunkEntry.ChunkMetaEntry[p_Descriptor.Chunks.Count] : null, // NOTE: This matches the amount of chunk entries
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

                m_Header.ResourceEntries[s_ResourceIndex] = new CasBundle.Resource
                {
                    Name = s_ResourceName,
                    ResourceType = (int)s_ResourceObject.GetResourceType(),
                    Hash = s_ResourceVariant.GetSha1() ?? new Sha1(),
                    Meta = s_ResourceMetadata
                };
            }

            

            // Write all of the entries for chunks
            for (var s_ChunkIndex = 0; s_ChunkIndex < m_Descriptor.Chunks.Count; s_ChunkIndex++)
            {
                var s_ChunkPair = m_Descriptor.Chunks.ElementAt(s_ChunkIndex);

                var s_ChunkId = s_ChunkPair.Key;
                var s_ChunkObject = s_ChunkPair.Value;

                using var s_ChunkReader = s_ChunkObject.GetReader();

                var s_DecompressedData = s_ChunkReader.ReadBytes((int)s_ChunkReader.Length);

                var s_ChunkHash = Sha1.FromData(s_DecompressedData);

                m_Header.ChunkEntries[s_ChunkIndex] = new CasBundle.Chunk
                {
                    Id = s_ChunkId,
                    Hash = s_ChunkHash,
                    Size = s_ChunkReader.Length
                };

                // Copy the chunk meta if it exists
                if (s_ChunkObject.TryGetMeta(out DbObject? s_MetaData))
                {
                    var s_DbObject = DbObjectConverter.FromDbObject<ChunkEntry.ChunkMetaEntry>(s_MetaData);
                    m_Header.ChunkMeta[s_ChunkIndex] = s_DbObject;
                }
                else
                    m_Header.ChunkMeta[s_ChunkIndex] = new ChunkEntry.ChunkMetaEntry(); // TODO: Fix this

                /*
                 * NOTE FOR FUTURE ME:
                 * Currently the serialization works, and Rime can at least read the cas superbundle, with the cas bundles
                 * with a chunk added to the bundle from existing CAS
                 * 
                 * This was mounted using the mount_standalone_sb
                 * 
                 * There are a few points that have to be investigated before this can be set as "working"
                 * 
                 * 1. Investigate why ChunkMeta != ChunkEntries for our built bundles, for whatever reason the above code in TryGetMeta returns null
                 * for certain chunks, that when loading *should* exist from retail bf3 bundles
                 * 
                 * 2. For the ebx entries, check if the OriginalSize == Size always, or if they differ and under what circumstances they differ
                 * and fix that in the serialization code
                 */
            }

            for (var s_PartitionIndex = 0; s_PartitionIndex < m_Descriptor.Partitions.Count; ++s_PartitionIndex)
            {
                var s_PartitionPair = m_Descriptor.Partitions.ElementAt(s_PartitionIndex);

                var s_PartitionName = s_PartitionPair.Key;
                var s_PartitionObject = s_PartitionPair.Value;

                var s_PartitionReader = s_PartitionObject.GetReader();
                var s_PartitionSize = s_PartitionObject.GetSize();

                var s_PartitionData = s_PartitionReader.ReadBytes((int)s_PartitionSize);
                s_PartitionReader = s_PartitionObject.GetReader();

                var s_PartitionHash = Sha1.FromData(s_PartitionData);

                m_Header.EbxEntries[s_PartitionIndex] = new CasBundle.Ebx
                {
                    Name = s_PartitionName,
                    Size = s_PartitionSize,
                    OriginalSize = s_PartitionSize, // TODO: Investigate are these the same
                    Hash = s_PartitionHash
                };
            }

            // Convert the CasBundle header to the DbObject data
            if (!DbObjectConverter.ToDbObjectBytes(m_Header, out byte[] s_Data))
                throw new Exception("could not convert the header data.");

            // Update the checksum
            Checksum = Sha1.FromData(s_Data);

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
