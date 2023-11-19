using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2_0.Frostbite.Bundles;
using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Frostbite2_0.Mounting;
using RimeLib.Frostbite.Core;
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
                ChunkMeta = new ChunkEntry.ChunkMetaEntry[0] // TODO: Figure out how this is serialized
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

            for (var s_ChunkIndex = 0; s_ChunkIndex < m_Descriptor.Chunks.Count; s_ChunkIndex++)
            {
                var s_ChunkPair = m_Descriptor.Chunks.ElementAt(s_ChunkIndex);

                var s_ChunkId = s_ChunkPair.Key;
                var s_ChunkObject = s_ChunkPair.Value;
            }
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
