using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2_0.Frostbite.Sb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Frostbite2_0.Building
{
    public class SuperbundleSerializer : ISuperbundleSerializer
    {
        private TableOfContents<SuperbundleLayout> m_Toc = new TableOfContents<SuperbundleLayout>(new SuperbundleLayout());

        private List<ChunkInfo> m_Chunks = new List<ChunkInfo>();
        private List<BundleInfo> m_Bundles = new List<BundleInfo>();

        public void Serialize(SuperbundleDescriptor p_Descriptor, Stream p_OutputSbStream, Stream p_OutputTocStream)
        {
            // Re-initialize everything.
            m_Toc = new TableOfContents<SuperbundleLayout>(new SuperbundleLayout());
            m_Chunks = new List<ChunkInfo>();
            m_Bundles = new List<BundleInfo>();

            // Set up an sb writer to use.
            using var s_SbWriter = new RimeWriter(p_OutputSbStream, Endianness.BigEndian, false);

            // Set basic layout properties.
            m_Toc.Layout.Name = p_Descriptor.SuperbundleName;
            m_Toc.Layout.Tag = Guid.NewGuid();
            m_Toc.Layout.AlwaysEmitSuperbundle = true;
            if (p_Descriptor.Cas)
                m_Toc.Layout.Cas = p_Descriptor.Cas;

            // Serialize bundles.
            foreach (var s_Pair in p_Descriptor.Bundles)
            {
                if (p_Descriptor.Cas)
                    SerializeCasBundle(s_Pair.Key, s_Pair.Value, s_SbWriter);
                else
                    SerializeBundle(s_Pair.Key, s_Pair.Value, s_SbWriter);
            }

            // TODO: Validate that this code produces in the toc not sb for cas bundles?
            // Serialize chunks.
            foreach (var s_Pair in p_Descriptor.Chunks)
                SerializeChunk(s_Pair.Key, s_Pair.Value, s_SbWriter);
            
            // Assign final chunk and bundle info.
            m_Toc.Layout.Chunks = m_Chunks.ToArray();
            m_Toc.Layout.Bundles = m_Bundles.ToArray();

            // Serialize the toc into the toc stream.
            using var s_TocWriter = new RimeWriter(p_OutputTocStream, Endianness.LittleEndian, false);
            m_Toc.Serialize(s_TocWriter);
        }

        private void SerializeChunk(GUID p_Id, IChunkObject p_Chunk, RimeWriter p_SbWriter)
        {
            //if (p_Id.HasCompressionFlag())
            //    throw new Exception("Packing compressed chunks is not currently supported.");

            var s_ChunkInfo = new ChunkInfo
            {
                Id = p_Id,
                Offset = p_SbWriter.Position,
                Size = p_Chunk.GetSize(),
            };

            // Write chunk data to sb.
            using var s_ChunkReader = p_Chunk.GetReader();

            // TODO: Eventually replace this with a more "proper" workaround
            if (p_Id.HasCompressionFlag())
                ((s_ChunkReader.BaseStream as RimeReader)?.BaseStream as RimeReader)?.CopyTo(p_SbWriter);
            else
                s_ChunkReader.CopyTo(p_SbWriter);

            // Add chunk info to layout.
            m_Chunks.Add(s_ChunkInfo);
        }

        private void SerializeBundle(string p_Path, BundleDescriptor p_Descriptor, RimeWriter p_SbWriter)
        {
            var s_BundleInfo = new BundleInfo
            {
                Id = p_Path,
                Offset = p_SbWriter.Position,
                Size = 0,
                Checksum = new Sha1(),
            };

            var s_Builder = new BundleManifestBuilder(p_Descriptor);
            s_Builder.Serialize(p_SbWriter);

            // Calculate size.
            s_BundleInfo.Size = p_SbWriter.Position - s_BundleInfo.Offset;
            s_BundleInfo.Checksum = s_Builder.Checksum;

            // Add bundle to layout.
            m_Bundles.Add(s_BundleInfo);
        }

        private void SerializeCasBundle(string p_Path, BundleDescriptor p_Descriptor, RimeWriter p_SbWriter)
        {
            var s_BundleInfo = new BundleInfo
            {
                Id = p_Path,
                Offset = p_SbWriter.Position,
                Size = 0,               // This will get updated later
                Checksum = new Sha1(),  // This will get updated later
            };

            var s_Builder = new CasBundleManifestBuilder(p_Descriptor);
            s_Builder.Serialize(p_SbWriter);

            // Calculate Size
            s_BundleInfo.Size = p_SbWriter.Position - s_BundleInfo.Offset;
            s_BundleInfo.Checksum = s_Builder.Checksum;

            m_Bundles.Add(s_BundleInfo);
        }

        public EngineType[] GetSupportedEngines()
        {
            return new[] { EngineType.Frostbite2_0 };
        }
    }
}
