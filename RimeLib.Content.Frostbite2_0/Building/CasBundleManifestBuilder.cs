using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2_0.Frostbite.Bundles;
using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Frostbite2_0.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO.Conversion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

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

        // Cache of compressed (Frostbite zlib-block format) payloads for file/memory-backed
        // objects, keyed by the readable. Real BF3 cas-bundle payloads (incl. inline `idata`)
        // are ALWAYS stored in the compressed-block format and content-addressed by the SHA1
        // of the COMPRESSED bytes. Rime used to inline RAW bytes with Size==OriginalSize
        // (compression flag off) which BF3 misparses -> crash. We now compress + hash the
        // compressed payload so both Rime's reader and BF3 decompress it correctly.
        private readonly Dictionary<IReadableObject, (byte[] Compressed, Sha1 Hash)> m_FileBackedCache = new();

        // Cache of RAW (uncompressed) payloads for file/memory-backed EBX partitions.
        // Unlike resources/chunks, EBX partitions are NEVER zlib-compressed in BF3 cas
        // bundles: every real EBX entry across the whole BF3 install has size == originalSize,
        // and the non-cas BundleManifestBuilder also writes EBX raw. Compressing inline EBX
        // (size != originalSize) makes BF3 treat it as compressed and reject it ("your game
        // data is corrupt"). So new/modified EBX delivered via cas idata must be stored raw,
        // content-addressed by the SHA1 of the RAW bytes.
        private readonly Dictionary<IReadableObject, (byte[] Raw, Sha1 Hash)> m_FileBackedRawCache = new();

        private static bool IsFileBacked(IReadableObject p_Object)
        {
            return p_Object is not CatalogReadable
                && p_Object is not InlineReadable
                && p_Object is not ResourceEntry
                && p_Object is not EbxEntry
                && p_Object is not BundleChunkEntry
                && p_Object is not CasChunkEntry;
        }

        private (byte[] Compressed, Sha1 Hash) GetFileBackedCompressed(IReadableObject p_Object)
        {
            if (m_FileBackedCache.TryGetValue(p_Object, out var s_Cached))
                return s_Cached;

            byte[] s_Raw;
            using (var s_Reader = p_Object.GetReader())
                s_Raw = s_Reader.ReadBytes((int)s_Reader.Length);

            var s_Compressed = CompressBlocks(s_Raw);
            var s_Result = (s_Compressed, Sha1.FromData(s_Compressed));

            m_FileBackedCache[p_Object] = s_Result;
            return s_Result;
        }

        // Reads a file/memory-backed object's RAW bytes (no compression) and content-addresses
        // them by SHA1 of the raw payload. Used for EBX partitions, which BF3 stores raw.
        private (byte[] Raw, Sha1 Hash) GetFileBackedRaw(IReadableObject p_Object)
        {
            if (m_FileBackedRawCache.TryGetValue(p_Object, out var s_Cached))
                return s_Cached;

            byte[] s_Raw;
            using (var s_Reader = p_Object.GetReader())
                s_Raw = s_Reader.ReadBytes((int)s_Reader.Length);

            var s_Result = (s_Raw, Sha1.FromData(s_Raw));

            m_FileBackedRawCache[p_Object] = s_Result;
            return s_Result;
        }

        // Compresses raw bytes into the Frostbite zlib-block payload format: a sequence of
        // segments, each = uint32 originalSize (BE) + uint32 compressedSize (BE) + deflate
        // data; uncompressed segments are at most 0x10000 bytes. Mirrors the non-cas
        // BundleManifestBuilder.WriteCompressed so ZlibRimeReader (and BF3) reads it back.
        private static byte[] CompressBlocks(byte[] p_Raw)
        {
            using var s_Output = new MemoryStream();

            var s_Offset = 0;
            do
            {
                var s_BlockSize = System.Math.Min(0x10000, p_Raw.Length - s_Offset);

                using var s_DeflateOutput = new MemoryStream();
                using (var s_Deflate = new DeflaterOutputStream(s_DeflateOutput, new Deflater(Deflater.BEST_COMPRESSION), 4096))
                {
                    s_Deflate.Write(p_Raw, s_Offset, s_BlockSize);
                    s_Deflate.Finish();
                }

                var s_Block = s_DeflateOutput.ToArray();

                s_Output.Write(EndianBitConverter.Big.GetBytes((uint)s_BlockSize));
                s_Output.Write(EndianBitConverter.Big.GetBytes((uint)s_Block.Length));
                s_Output.Write(s_Block);

                s_Offset += s_BlockSize;
            }
            while (s_Offset < p_Raw.Length);

            return s_Output.ToArray();
        }

        long GetCompressedSize(IReadableObject p_Object)
        {
            if (p_Object is CatalogReadable s_Catalog) return s_Catalog.GetCompressedSize();
            if (p_Object is InlineReadable s_Inline) return s_Inline.GetCompressedSize();
            if (p_Object is ResourceEntry s_Resource) return s_Resource.PayloadSize;
            if (p_Object is EbxEntry s_Ebx) return s_Ebx.PayloadSize;
            if (p_Object is BundleChunkEntry s_Chunk) return s_Chunk.PayloadSize;
            if (p_Object is CasChunkEntry s_CasChunk) return s_CasChunk.PayloadSize;
            // File/memory-backed: size is the COMPRESSED payload size (block format).
            return GetFileBackedCompressed(p_Object).Compressed.Length;
        }

        Sha1 GetCompressedHash(IReadableObject p_Object)
        {
            if (p_Object is CatalogReadable s_Catalog) return s_Catalog.GetCompressedHash()!;
            if (p_Object is InlineReadable s_Inline) return s_Inline.GetCompressedHash()!;
            if (p_Object is ResourceEntry s_Resource) return s_Resource.Hash;
            if (p_Object is EbxEntry s_Ebx) return s_Ebx.Hash;
            if (p_Object is BundleChunkEntry s_Chunk) return s_Chunk.Hash;
            if (p_Object is CasChunkEntry s_CasChunk) return s_CasChunk.Hash;
            // File/memory-backed: hash of the COMPRESSED payload (content address).
            return GetFileBackedCompressed(p_Object).Hash;
        }

        byte[]? GetInlineData(IReadableObject p_Object)
        {
            if (p_Object is InlineReadable s_Inline) return s_Inline.GetCompressedData();
            // File-backed / memory-backed objects: embed the COMPRESSED (block-format) payload
            // as inline data, so BF3 (and Rime's reader) decompress it instead of misparsing raw.
            if (IsFileBacked(p_Object))
                return GetFileBackedCompressed(p_Object).Compressed;
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

                long s_PartitionSize;
                long s_PartitionOriginalSize;
                Sha1 s_PartitionHash;
                byte[]? s_PartitionInline;

                if (IsFileBacked(s_Readable))
                {
                    // New/modified EBX (add_raw_partition / add_json_partition): store RAW,
                    // with size == originalSize (BF3 never zlib-compresses EBX). Compressing
                    // it here is what corrupted inline EBX in cas before.
                    var (s_Raw, s_RawHash) = GetFileBackedRaw(s_Readable);
                    s_PartitionInline = s_Raw;
                    s_PartitionSize = s_Raw.Length;
                    s_PartitionOriginalSize = s_Raw.Length;
                    s_PartitionHash = s_RawHash;
                }
                else
                {
                    // Unchanged EBX (mounted catalog/inline variant): keep its existing
                    // catalog reference (idata == null) or already-present inline data.
                    s_PartitionSize = GetCompressedSize(s_Readable);
                    s_PartitionOriginalSize = s_Readable.GetSize();
                    s_PartitionHash = GetCompressedHash(s_Readable);
                    s_PartitionInline = GetInlineData(s_Readable);
                }

                m_Header.EbxEntries[s_PartitionIndex] = new CasBundle.Ebx
                {
                    Name = s_PartitionName,
                    Size = s_PartitionSize,
                    OriginalSize = s_PartitionOriginalSize,
                    Hash = s_PartitionHash,
                    InlineData = s_PartitionInline
                };

                // Update totalSize
                m_Header.TotalSize += s_PartitionSize;
            }

            return DbObjectConverter.ToDbObject(m_Header);
        }
    }
}
