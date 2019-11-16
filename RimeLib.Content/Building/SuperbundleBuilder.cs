using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Building
{
    public class SuperbundleBuilder
    {
        public static SuperbundleBuilder Create(EngineType p_Type, string p_SbName)
        {
            return new SuperbundleBuilder(SuperbundleSerializerRegistry.Create(p_Type), p_SbName);
        }

        private readonly ISuperbundleSerializer m_Serializer;
        private readonly SuperbundleDescriptor m_Descriptor;

        private SuperbundleBuilder(ISuperbundleSerializer p_Serializer, string p_SbName)
        {
            m_Serializer = p_Serializer;
            m_Descriptor = new SuperbundleDescriptor(p_SbName);
        }

        public SuperbundleBuilder WithChunk(GUID p_Id, IChunkObject p_Chunk)
        {
            m_Descriptor.Chunks[p_Id] = p_Chunk;
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
    }
}
