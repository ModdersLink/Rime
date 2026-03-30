using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2_0.Frostbite.Bundles;
using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Frostbite2_0.Frostbite.Sb;
using RimeLib.Content.Frostbite2_0.Mounting;
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
            m_Toc.Layout.AlwaysEmitSuperbundle = !p_Descriptor.Cas;
            if (p_Descriptor.Cas)
                m_Toc.Layout.Cas = p_Descriptor.Cas;
            else
                m_Toc.Layout.Tag = Guid.NewGuid();


            long GetCompressedSize(IReadableObject p_Object)
            {
                if (p_Object is CatalogReadable s_Catalog) return s_Catalog.GetCompressedSize();
                if (p_Object is InlineReadable s_Inline) return s_Inline.GetCompressedSize();
                if (p_Object is ResourceEntry s_Resource) return s_Resource.PayloadSize;
                if (p_Object is EbxEntry s_Ebx) return s_Ebx.PayloadSize;
                if (p_Object is BundleChunkEntry s_Chunk) return s_Chunk.PayloadSize;
                if (p_Object is CasChunkEntry s_CasChunk) return s_CasChunk.PayloadSize;
                // File/memory-backed: size is the raw file size (stored as inline data)
                return p_Object.GetSize();
            }

            Sha1 GetCompressedHash(IReadableObject p_Object)
            {
                if (p_Object is CatalogReadable s_Catalog) return s_Catalog.GetCompressedHash() ?? new Sha1();
                if (p_Object is InlineReadable s_Inline) return s_Inline.GetCompressedHash() ?? new Sha1();
                if (p_Object is ResourceEntry s_Resource) return s_Resource.Hash;
                if (p_Object is EbxEntry s_Ebx) return s_Ebx.Hash;
                if (p_Object is BundleChunkEntry s_Chunk) return s_Chunk.Hash;
                if (p_Object is CasChunkEntry s_CasChunk) return s_CasChunk.Hash;
                // File/memory-backed: compute hash from raw data
                using var s_HashReader = p_Object.GetReader();
                var s_Bytes = s_HashReader.ReadBytes((int)s_HashReader.Length);
                return Sha1.FromData(s_Bytes);
            }

            byte[]? GetInlineData(IReadableObject p_Object)
            {
                if (p_Object is InlineReadable s_Inline) return s_Inline.GetCompressedData();
                // File-backed / memory-backed objects: read data directly and embed as inline
                if (p_Object is not CatalogReadable && p_Object is not ResourceEntry && p_Object is not EbxEntry && p_Object is not BundleChunkEntry && p_Object is not CasChunkEntry)
                {
                    using var s_Reader = p_Object.GetReader();
                    return s_Reader.ReadBytes((int)s_Reader.Length);
                }
                return null;
            }

            // Helper to resolve the underlying IReadableObject from an IReadableObject that may be
            // wrapped inside an ObjectVariant, or may itself be a file/memory-backed reader.
            IReadableObject ResolveReadable(IReadableObject p_Object)
            {
                if (p_Object is ObjectVariant s_Variant) return s_Variant.GetReadable();
                return p_Object; // FileReader, ChunkFileReader, ResourceFileReader, MemoryReader, etc.
            }

            // TODO: UNFUCK THIS, THIS IS AWFUL.
            if (p_Descriptor.Cas)
            {
                // Bundles
                var s_BundlesListObject = new DbObject();

                var lam = (BundleDescriptor p_Descriptor) =>
                {
                    // Create a new DbObject
                    var s_CasBundle = new CasBundle
                    {
                        MagicSalt = 2047996331, // TODO: figure out how to set this the proper way.
                        Path = p_Descriptor.BundleName.ToLowerInvariant(),
                        ResourceEntries = new CasBundle.Resource[p_Descriptor.Resources.Count],
                        EbxEntries = new CasBundle.Ebx[p_Descriptor.Partitions.Count],
                        ChunkEntries = p_Descriptor.Chunks.Count != 0 ? new CasBundle.Chunk[p_Descriptor.Chunks.Count] : null,
                        ChunkMeta = p_Descriptor.Chunks.Count != 0 ? new ChunkEntry.ChunkMetaEntry[p_Descriptor.Chunks.Count] : null, // NOTE: This matches the amount of chunk entries
                    };

                    for (var s_ResourceIndex = 0; s_ResourceIndex < p_Descriptor.Resources.Count; s_ResourceIndex++)
                    {
                        var s_ResourcePair = p_Descriptor.Resources.ElementAt(s_ResourceIndex);

                        var s_ResourceName = s_ResourcePair.Key;
                        var s_ResourceObject = s_ResourcePair.Value;

                        // Resolve the underlying readable - supports both mounted ObjectVariant/ResourceVariant
                        // and file/memory-backed objects (ResourceFileReader, ResourceMemoryReader, etc.)
                        var s_Readable = ResolveReadable(s_ResourceObject);
                        // Get the metadata (if it exists)
                        var s_ResourceMetadata = new byte[0];
                        if (s_ResourceObject.TryGetMeta(out var s_MetaData))
                        {
                            // This file has meta
                            s_ResourceMetadata = s_MetaData;
                        }

                        var s_CompressedSize = GetCompressedSize(s_Readable);

                        s_CasBundle.ResourceEntries[s_ResourceIndex] = new CasBundle.Resource
                        {
                            Name = s_ResourceName,
                            ResourceType = (int)s_ResourceObject.GetResourceType(),
                            Hash = GetCompressedHash(s_Readable),
                            Meta = s_ResourceMetadata,
                            Size = s_CompressedSize,
                            OriginalSize = s_Readable.GetSize(),
                            InlineData = GetInlineData(s_Readable)
                        };

                        // Update the total size
                        s_CasBundle.TotalSize += s_CompressedSize;
                    }



                    // Write all of the entries for chunks
                    for (var s_ChunkIndex = 0; s_ChunkIndex < p_Descriptor.Chunks.Count; s_ChunkIndex++)
                    {
                        var s_ChunkPair = p_Descriptor.Chunks.ElementAt(s_ChunkIndex);

                        var s_ChunkId = s_ChunkPair.Key;
                        var s_ChunkObject = s_ChunkPair.Value;

                        var s_Readable = ResolveReadable(s_ChunkObject);

                        //using var s_ChunkReader = s_ChunkObject.GetReader();

                        //var s_DecompressedData = s_ChunkReader.ReadBytes((int)s_ChunkReader.Length);

                        //var s_ChunkHash = Sha1.FromData(s_DecompressedData);

                        var s_ReadableSize = GetCompressedSize(s_Readable);

                        var s_RangeStart = (int)s_ChunkObject.GetRangeStart();
                        var s_RangeEnd = s_RangeStart + (int)s_ReadableSize;
                        var s_LogicalOffset = (int)s_ChunkObject.GetLogicalOffset();
                        var s_ShouldWriteEntry = s_RangeStart != 0 || s_Readable is InlineReadable || GetInlineData(s_Readable) != null;

                        s_CasBundle.ChunkEntries[s_ChunkIndex] = new CasBundle.Chunk
                        {
                            Id = s_ChunkId,
                            Hash = GetCompressedHash(s_Readable),
                            Size = s_ReadableSize,
                            RangeStart = s_ShouldWriteEntry ? s_RangeStart : null,
                            RangeEnd = s_ShouldWriteEntry ? s_RangeEnd : null,
                            LogicalOffset = s_ShouldWriteEntry ? s_LogicalOffset : null,
                            InlineData = GetInlineData(s_Readable)
                        };

                        // Update totalSize
                        s_CasBundle.TotalSize += s_ReadableSize;

                        // Copy the chunk meta if it exists
                        if (s_ChunkObject.TryGetMeta(out DbObject? s_MetaData))
                        {
                            var s_DbObject = DbObjectConverter.FromDbObject<ChunkEntry.ChunkMetaEntry>(s_MetaData);
                            s_CasBundle.ChunkMeta[s_ChunkIndex] = s_DbObject;
                        }
                        else
                            s_CasBundle.ChunkMeta[s_ChunkIndex] = new ChunkEntry.ChunkMetaEntry(); // TODO: Fix this

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

                    for (var s_PartitionIndex = 0; s_PartitionIndex < p_Descriptor.Partitions.Count; ++s_PartitionIndex)
                    {
                        var s_PartitionPair = p_Descriptor.Partitions.ElementAt(s_PartitionIndex);

                        var s_PartitionName = s_PartitionPair.Key;
                        var s_PartitionObject = s_PartitionPair.Value;


                        var s_Readable = ResolveReadable(s_PartitionObject);

                        var s_PartitionReader = s_PartitionObject.GetReader();
                        var s_PartitionData = s_PartitionReader.ReadBytes((int)s_PartitionReader.Length);

                        var s_PartitionSize = GetCompressedSize(s_Readable);

                        var s_PartitionHash = GetCompressedHash(s_Readable);

                        s_CasBundle.EbxEntries[s_PartitionIndex] = new CasBundle.Ebx
                        {
                            Name = s_PartitionName,
                            Size = s_PartitionSize,
                            OriginalSize = s_Readable.GetSize(),
                            Hash = s_PartitionHash,
                            InlineData = GetInlineData(s_Readable)
                        };

                        // Update totalSize
                        s_CasBundle.TotalSize += s_PartitionSize;
                    }

                    return DbObjectConverter.ToDbObject(s_CasBundle);
                };

                var s_GenPos = (long)18;

                foreach (var s_Pair in p_Descriptor.Bundles)
                {
                    var s_Desc = s_Pair.Value;

                    var s_Object = lam(s_Pair.Value);

                    // Has the Object | Anon
                    var s_AnonDbObjectElement = new DbObjectElement("", s_Object, false);
                    s_AnonDbObjectElement.Type |= DbObjectType.Anonymous;

                    s_BundlesListObject.AddElement(s_AnonDbObjectElement);

                    var s_BundleInfo = new BundleInfo
                    {
                        Id = s_Pair.Value.BundleName,
                        Offset = s_GenPos,
                        Size = 0,               // This will get updated later
                        Checksum = new Sha1(),  // This will get updated later
                    };

                    var s_FullObject = new DbObject();
                    s_FullObject.AddElement(s_AnonDbObjectElement);
                    var s_ObjectData = s_FullObject.Serialize();

                    // Calculate Size
                    s_BundleInfo.Size = s_ObjectData.Length;
                    s_BundleInfo.Checksum = Sha1.FromData(s_ObjectData);

                    m_Bundles.Add(s_BundleInfo);

                    s_GenPos += s_BundleInfo.Size;
                }

                s_BundlesListObject.AddElement(new DbObjectElement
                {
                    FieldName = "",
                    Type = DbObjectType.Eoo
                });


                var s_CasBundleListObject = new DbObject();


                var s_Array = new DbObjectElement("bundles", s_BundlesListObject, true);

                s_CasBundleListObject.AddElement(s_Array);
                s_CasBundleListObject.AddElement(new DbObjectElement
                {
                    FieldName = "",
                    Type = DbObjectType.Eoo
                });

                var s_Anon = new DbObjectElement("", s_CasBundleListObject, false);
                s_Anon.Type |= DbObjectType.Anonymous;

                // Create the parent object
                var s_CasDbObject = new DbObject();
                s_CasDbObject.AddElement(s_Anon);

                s_SbWriter.Write(s_CasDbObject.Serialize());
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
