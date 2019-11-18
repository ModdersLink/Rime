using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Building
{
    public class BundleBuilder
    {
        public static BundleBuilder Create(string p_BundleName)
        {
            return new BundleBuilder(p_BundleName);
        }

        private readonly BundleDescriptor m_Descriptor; 

        protected BundleBuilder(string p_BundleName)
        {
            m_Descriptor = new BundleDescriptor(p_BundleName);
        }

        public BundleDescriptor Build()
        {
            return m_Descriptor;
        }

        public BundleBuilder WithResource(string p_Path, IResourceObject p_Resource)
        {
            m_Descriptor.Resources[p_Path.ToLowerInvariant()] = p_Resource;
            return this;
        }

        public BundleBuilder WithChunk(GUID p_Guid, IChunkObject p_Chunk)
        {
            m_Descriptor.Chunks[p_Guid] = p_Chunk;
            return this;
        }

        public BundleBuilder WithPartition(string p_Path, IReadableObject p_Partition)
        {
            m_Descriptor.Partitions[p_Path.ToLowerInvariant()] = p_Partition;
            return this;
        }

        public Dictionary<string, IResourceObject> GetResources()
        {
            return m_Descriptor.Resources;
        }

        public Dictionary<GUID, IChunkObject> GetChunks()
        {
            return m_Descriptor.Chunks;
        }

        public Dictionary<string, IReadableObject> GetPartitions()
        {
            return m_Descriptor.Partitions;
        }

        public void RemoveResource(string p_Path)
        {
            m_Descriptor.Resources.Remove(p_Path.ToLowerInvariant());
        }

        public void RemoveChunk(GUID p_Guid)
        {
            m_Descriptor.Chunks.Remove(p_Guid);
        }

        public void RemovePartition(string p_Path)
        {
            m_Descriptor.Partitions.Remove(p_Path.ToLowerInvariant());
        }
    }
}
