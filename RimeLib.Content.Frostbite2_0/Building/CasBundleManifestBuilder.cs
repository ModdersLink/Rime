using RimeLib.Content.Building;
using RimeLib.Content.Frostbite.Bundles;
using RimeLib.Content.Frostbite2_0.Frostbite.Bundles;
using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Frostbite2_0.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using System.Linq;

namespace RimeLib.Content.Frostbite2_0.Building
{
    public class CasBundleManifestBuilder
    {
        protected CasBundle m_Header;

        protected BundleDescriptor m_Descriptor;

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


        public DbObject GetDbObject()
        {
            for (var s_ResourceIndex = 0; s_ResourceIndex < m_Descriptor.Resources.Count; s_ResourceIndex++)
            {
                var s_ResourcePair = m_Descriptor.Resources.ElementAt(s_ResourceIndex);

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

                m_Header.ResourceEntries[s_ResourceIndex] = new CasBundle.Resource
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
                m_Header.TotalSize += s_CompressedSize;
            }

            // Write all of the entries for chunks
            for (var s_ChunkIndex = 0; s_ChunkIndex < m_Descriptor.Chunks.Count; s_ChunkIndex++)
            {
                var s_ChunkPair = m_Descriptor.Chunks.ElementAt(s_ChunkIndex);

                var s_ChunkId = s_ChunkPair.Key;
                var s_ChunkObject = s_ChunkPair.Value;

                var s_Readable = ResolveReadable(s_ChunkObject);

                var s_ReadableSize = GetCompressedSize(s_Readable);

                var s_RangeStart = (int)s_ChunkObject.GetRangeStart();
                var s_RangeEnd = (int)s_ChunkObject.GetRangeEnd();
                var s_LogicalOffset = (int)s_ChunkObject.GetLogicalOffset();
                var s_ShouldWriteEntry = s_RangeStart != 0 || s_Readable is InlineReadable || GetInlineData(s_Readable) != null;


                m_Header.ChunkEntries![s_ChunkIndex] = new CasBundle.Chunk
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
                m_Header.TotalSize += s_ReadableSize;

                // Copy the chunk meta if it exists
                if (s_ChunkObject.TryGetMeta(out DbObject? s_MetaData))
                {
                    var s_DbObject = DbObjectConverter.FromDbObject<ChunkEntry.ChunkMetaEntry>(s_MetaData);
                    m_Header.ChunkMeta![s_ChunkIndex] = s_DbObject;
                }
                else
                    m_Header.ChunkMeta![s_ChunkIndex] = new ChunkEntry.ChunkMetaEntry(); // TODO: Fix this

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

                var s_Readable = ResolveReadable(s_PartitionObject);

                var s_PartitionReader = s_PartitionObject.GetReader();

                var s_PartitionSize = GetCompressedSize(s_Readable);
                var s_PartitionHash = GetCompressedHash(s_Readable);

                m_Header.EbxEntries[s_PartitionIndex] = new CasBundle.Ebx
                {
                    Name = s_PartitionName,
                    Size = s_PartitionSize,
                    OriginalSize = s_Readable.GetSize(),
                    Hash = s_PartitionHash,
                    InlineData = GetInlineData(s_Readable)
                };

                // Update totalSize
                m_Header.TotalSize += s_PartitionSize;
            }

            return DbObjectConverter.ToDbObject(m_Header);
        }
    }
}
