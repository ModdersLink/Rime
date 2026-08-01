using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2_0.Frostbite.Sb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Frostbite2_0.Building
{
    public class SuperbundleSerializer : ISuperbundleSerializer
    {
        private TableOfContents<SuperbundleLayout> m_Toc = new TableOfContents<SuperbundleLayout>(new SuperbundleLayout());

        private List<ChunkInfo> m_Chunks = new List<ChunkInfo>();
        private List<BundleInfo> m_Bundles = new List<BundleInfo>();
        private List<string> m_Warnings = new List<string>();

        public IReadOnlyList<string> Warnings => m_Warnings;

        public void Serialize(SuperbundleDescriptor p_Descriptor, Stream p_OutputSbStream, Stream p_OutputTocStream)
        {
            // Re-initialize everything.
            m_Toc = new TableOfContents<SuperbundleLayout>(new SuperbundleLayout());
            m_Chunks = new List<ChunkInfo>();
            m_Bundles = new List<BundleInfo>();
            m_Warnings = new List<string>();

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

            // TODO: Validate that this code produces in the toc not sb for cas bundles?
            // Serialize chunks.
            foreach (var s_Pair in p_Descriptor.Chunks)
                SerializeChunk(s_Pair.Key, s_Pair.Value, s_SbWriter);

            // Toc chunks are bare id and sha1 refs with no payload written; the engine fetches them
            // from the catalog by hash.
            foreach (var s_Pair in p_Descriptor.CasTocChunks)
                m_Chunks.Add(new ChunkInfo { Id = s_Pair.Key, Sha1 = s_Pair.Value });

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
            m_Warnings.AddRange(s_Builder.Warnings);

            // Calculate size.
            s_BundleInfo.Size = p_SbWriter.Position - s_BundleInfo.Offset;
            s_BundleInfo.Checksum = s_Builder.Checksum;

            // Add bundle to layout.
            m_Bundles.Add(s_BundleInfo);
        }

        private void SerializeCasBundles(SuperbundleDescriptor p_Descriptor, RimeWriter p_SbWriter)
        {
            // Bundles
            var s_BundlesListObject = new DbObject();

            // The toc references each bundle manifest by its byte offset within the .sb, and that
            // offset is not a constant: the preamble before the first manifest is sized by DbObject
            // varints that grow with the total size, taking 2 bytes in a small mod superbundle and 4
            // in a full game one. So serialize the whole thing first and find each manifest's real
            // offset by its serialized bytes, which are unique because they carry its path.
            var s_BundleData = new List<(string Id, byte[] Data)>();

            foreach (var s_Pair in p_Descriptor.Bundles)
            {
                var s_Builder = new CasBundleManifestBuilder(s_Pair.Value, p_Descriptor.CatalogProbe);
                var s_Object = s_Builder.GetDbObject();

                // Has the Object | Anon
                var s_AnonDbObjectElement = new DbObjectElement(s_Object, false);

                s_BundlesListObject.AddElement(s_AnonDbObjectElement);

                // Serialize the same element on its own to get the exact bytes it will contribute to
                // the bundles list.
                var s_FullObject = new DbObject();
                s_FullObject.AddElement(s_AnonDbObjectElement);

                s_BundleData.Add((s_Pair.Value.BundleName, s_FullObject.Serialize()));
            }

            s_BundlesListObject.AddElement(new DbObjectElement());


            var s_CasBundleListObject = new DbObject();
            s_CasBundleListObject.AddElement(new DbObjectElement("bundles", s_BundlesListObject, true));
            s_CasBundleListObject.AddElement(new DbObjectElement());

            var s_Anon = new DbObjectElement(s_CasBundleListObject, false);

            // Create the parent object
            var s_CasDbObject = new DbObject();
            s_CasDbObject.AddElement(s_Anon);

            var s_AllBytes = s_CasDbObject.Serialize();

            var s_SearchStart = 0;
            foreach (var (s_Id, s_Data) in s_BundleData)
            {
                var s_Offset = IndexOf(s_AllBytes, s_Data, s_SearchStart);
                if (s_Offset < 0)
                    throw new Exception($"Failed to locate cas bundle '{s_Id}' within the serialized superbundle.");

                m_Bundles.Add(new BundleInfo
                {
                    Id = s_Id,
                    Offset = s_Offset,
                    Size = s_Data.Length,
                    Checksum = Sha1.FromData(s_Data)
                });

                s_SearchStart = s_Offset + s_Data.Length;
            }

            p_SbWriter.Write(s_AllBytes);
        }

        private static int IndexOf(byte[] p_Haystack, byte[] p_Needle, int p_Start)
        {
            for (var s_I = p_Start; s_I <= p_Haystack.Length - p_Needle.Length; ++s_I)
            {
                var s_Match = true;
                for (var s_J = 0; s_J < p_Needle.Length; ++s_J)
                {
                    if (p_Haystack[s_I + s_J] != p_Needle[s_J])
                    {
                        s_Match = false;
                        break;
                    }
                }

                if (s_Match)
                    return s_I;
            }

            return -1;
        }

        public EngineType[] GetSupportedEngines()
        {
            return new[] { EngineType.Frostbite2_0 };
        }
    }
}
