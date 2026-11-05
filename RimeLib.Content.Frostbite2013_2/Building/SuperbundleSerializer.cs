using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2013_2.Frostbite.Bundles;
using RimeLib.Content.Frostbite2013_2.Frostbite.Sb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Frostbite2013_2.Building
{
    public class SuperbundleSerializer : ISuperbundleSerializer
    {
        private TableOfContents<SuperbundleLayout> m_Toc = new(new SuperbundleLayout());
        private List<ChunkInfo> m_Chunks = [];
        private List<BundleInfo> m_Bundles = [];

        private List<string> m_Warnings = [];

        // Bad bundles abort; what is reported is how much of a cas build is stored inline.
        public IReadOnlyList<string> Warnings => m_Warnings;

        public void Serialize(SuperbundleDescriptor p_Descriptor, Stream p_OutputSbStream, Stream p_OutputTocStream)
        {
            // Re-initialize everything.
            m_Toc = new(new SuperbundleLayout());
            m_Chunks = [];
            m_Bundles = [];
            m_Warnings = [];

            // Set up an sb writer to use.
            using var s_SbWriter = new RimeWriter(p_OutputSbStream, Endianness.BigEndian, false);

            // Set basic layout properties.
            m_Toc.Layout.Name = p_Descriptor.SuperbundleName;
            m_Toc.Layout.AlwaysEmitSuperbundle = !p_Descriptor.Cas;
            if (p_Descriptor.Cas)
                m_Toc.Layout.Cas = p_Descriptor.Cas;
            else
                m_Toc.Layout.Tag = Guid.NewGuid();

            if (p_Descriptor.Cas)
            {
                SerializeCasBundles(p_Descriptor, s_SbWriter);
            }
            else
            {
                // Serialize non-cas bundles.
                foreach (var s_Pair in p_Descriptor.Bundles)
                {
                    SerializeBundle(s_Pair.Key, s_Pair.Value, s_SbWriter);
                }
            }

            // Serialize chunks.
            foreach (var s_Pair in p_Descriptor.Chunks)
                SerializeChunk(s_Pair.Key, s_Pair.Value, s_SbWriter);

            // Toc chunks of a cas superbundle are bare id and sha1 references into the catalogs.
            foreach (var s_Pair in p_Descriptor.CasTocChunks)
                m_Chunks.Add(new ChunkInfo { Id = s_Pair.Key, Sha1 = s_Pair.Value });

            // Assign final chunk and bundle info.
            m_Toc.Layout.Chunks = m_Chunks.ToArray();
            m_Toc.Layout.Bundles = m_Bundles.ToArray();
            m_Toc.Layout.TotalSize = s_SbWriter.Length;

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

        private void SerializeCasBundles(SuperbundleDescriptor p_Descriptor, RimeWriter p_SbWriter)
        {
            // The sb is one DbObject holding the list of bundle manifests. The toc points at each
            // manifest by its offset, which depends on the varint sizes before it, so the whole
            // list is serialized first and each manifest is found by its bytes (unique, since they
            // carry its path).
            var s_Bundles = new List<CasBundle>();
            var s_BundleData = new List<(string Id, byte[] Data)>();
            var s_References = 0;
            var s_Inline = 0;

            foreach (var s_Pair in p_Descriptor.Bundles)
            {
                var s_Builder = new CasBundleManifestBuilder(s_Pair.Value);
                var s_Bundle = s_Builder.GetBundle();
                s_Bundles.Add(s_Bundle);
                s_References += s_Builder.References;
                s_Inline += s_Builder.Inline;

                if (!DbObjectConverter.ToDbObjectBytes(s_Bundle, out var s_Data))
                    throw new Exception($"Failed to serialize cas bundle '{s_Pair.Value.BundleName}'.");
                s_BundleData.Add((s_Pair.Value.BundleName, s_Data));
            }

            var s_Superbundle = new CasSuperbundle { Bundles = s_Bundles.ToArray() };
            if (!DbObjectConverter.ToDbObjectBytes(s_Superbundle, out var s_AllBytes))
                throw new Exception("Failed to serialize the cas superbundle.");

            var s_SearchStart = 0;
            foreach (var (s_Id, s_Data) in s_BundleData)
            {
                var s_Offset = s_AllBytes.AsSpan(s_SearchStart).IndexOf(s_Data);
                if (s_Offset < 0)
                    throw new Exception($"Failed to locate cas bundle '{s_Id}' within the serialized superbundle.");
                s_Offset += s_SearchStart;

                m_Bundles.Add(new BundleInfo
                {
                    Id = s_Id,
                    Offset = s_Offset,
                    Size = s_Data.Length,
                    Checksum = Sha1.FromData(s_Data),
                });

                s_SearchStart = s_Offset + s_Data.Length;
            }

            p_SbWriter.Write(s_AllBytes);
            m_Warnings.Add($"{s_References} entries reference the game's catalogs, {s_Inline} are stored inline.");
        }

        public EngineType[] GetSupportedEngines()
        {
            return new[] { EngineType.Frostbite2013_2 };
        }
    }
}
