using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Building
{
    public class SuperbundleBuilder
    {
        public static SuperbundleBuilder Create(EngineType p_Type, string p_SbName, bool p_Cas = false)
        {
            return new SuperbundleBuilder(p_Type, EngineInterfaceRegistry.Create<ISuperbundleSerializer>(p_Type), p_SbName, p_Cas);
        }

        private readonly ISuperbundleSerializer m_Serializer;
        private readonly SuperbundleDescriptor m_Descriptor;
        private readonly EngineType m_EngineType;

        private SuperbundleBuilder(EngineType p_EngineType, ISuperbundleSerializer p_Serializer, string p_SbName, bool p_Cas = false)
        {
            m_EngineType = p_EngineType;
            m_Serializer = p_Serializer;
            m_Descriptor = new SuperbundleDescriptor(p_SbName, p_Cas);
        }

        public SuperbundleBuilder WithChunk(GUID p_Id, IChunkObject p_Chunk)
        {
            m_Descriptor.Chunks[p_Id] = p_Chunk;
            return this;
        }

        // TODO: Implement this in interface
        public SuperbundleBuilder WithCasTocChunk(GUID p_Id, Sha1 p_Sha1)
        {
            m_Descriptor.CasTocChunks[p_Id] = p_Sha1;
            return this;
        }

        // TODO: Implement this in interface
        // TODO: Determine if this is needed
        public SuperbundleBuilder WithCatalogProbe(Func<Sha1, bool> p_Probe)
        {
            m_Descriptor.CatalogProbe = p_Probe;
            return this;
        }

        public SuperbundleBuilder WithBundle(BundleDescriptor p_Bundle)
        {
            m_Descriptor.Bundles[p_Bundle.BundleName.ToLowerInvariant()] = p_Bundle;
            return this;
        }

        public SuperbundleBuilder WithBundles(params BundleDescriptor[] p_Bundles)
        {
            foreach (var s_Bundle in p_Bundles)
                m_Descriptor.Bundles[s_Bundle.BundleName.ToLowerInvariant()] = s_Bundle;

            return this;
        }

        public void Build(Stream p_OutputSbStream, Stream p_OutputTocStream)
        {
            m_Serializer.Serialize(m_Descriptor, p_OutputSbStream, p_OutputTocStream);
        }

        public Dictionary<GUID, IChunkObject> GetChunks()
        {
            return m_Descriptor.Chunks;
        }

        public Dictionary<string, BundleDescriptor> GetBundles()
        {
            return m_Descriptor.Bundles;
        }

        public string GetSbName()
        {
            return m_Descriptor.SuperbundleName;
        }

        public EngineType GetEngineType()
        {
            return m_EngineType;
        }

        public void RemoveChunk(GUID p_Id)
        {
            m_Descriptor.Chunks.Remove(p_Id);
        }

        public void RemoveBundle(string p_Name)
        {
            m_Descriptor.Bundles.Remove(p_Name);
        }

        public bool Cas()
        {
            return m_Descriptor.Cas;
        }
    }
}
