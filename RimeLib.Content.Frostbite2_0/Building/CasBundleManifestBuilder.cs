using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2_0.Frostbite.Bundles;
using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Frostbite2_0.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
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

        // Optional catalog-membership probe (SuperbundleDescriptor.CatalogProbe). When set,
        // embedded noncas sources whose STORED frame already exists in the player's cas.cat
        // are emitted as pure sha1 refs; otherwise their frame ships verbatim as idata.
        private readonly Func<Sha1, bool>? m_CatalogProbe;

        public CasBundleManifestBuilder(BundleDescriptor p_Descriptor, Func<Sha1, bool>? p_CatalogProbe = null)
        {
            m_Descriptor = p_Descriptor;
            m_CatalogProbe = p_CatalogProbe;
            m_Header = new CasBundle
            {
                Path = p_Descriptor.BundleName,
                ResourceEntries = new CasBundle.Resource[p_Descriptor.Resources.Count],
                EbxEntries = new CasBundle.Ebx[p_Descriptor.Partitions.Count],
                // DICE's manifest schema ALWAYS carries chunks + chunkMeta, even as empty arrays
                // (verified on retail mp_subway_loading_music: res[0], chunks[1]... all keys present).
                // Omitting them (the old null-when-0 behavior) produced bundles VU could parse but
                // whose content the ENGINE's native loader never consumed (2026-07-14 grid saga).
                ChunkEntries = new CasBundle.Chunk[p_Descriptor.Chunks.Count],
                ChunkMeta = new ChunkEntry.ChunkMetaEntry[p_Descriptor.Chunks.Count], // NOTE: This matches the amount of chunk entries
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
                && p_Object is not CasChunkEntry
                && p_Object is not SbChunkEntry;
        }

        // A source whose payload sits embedded in a mounted noncas .sb (or a noncas toc chunk).
        // These are the entries whose manifest sha1 is NOT a usable catalog key (null/uncataloged
        // for compressed payloads) — the old code emitted them as bare refs, which the engine
        // could never fetch. They are handled by content-addressing the stored frame instead.
        private static bool IsNoncasMounted(IReadableObject p_Object)
        {
            return p_Object is ResourceEntry
                || p_Object is EbxEntry
                || p_Object is BundleChunkEntry
                || p_Object is SbChunkEntry;
        }

        // Cache of STORED frames for noncas-mounted sources: the original compressed blocks
        // (ZlibRimeReader.GetRawBytes — same accessor the noncas writer's verbatim fast-path
        // uses) or the raw window when uncompressed. Content-addressed by sha1 of those exact
        // bytes — the same identity a cas.cat uses (retail cat key == sha1(stored bytes),
        // verified 800/800 against the base and patch catalogs).
        private readonly Dictionary<IReadableObject, (byte[] Stored, Sha1 Hash)> m_StoredFrameCache = new();

        private (byte[] Stored, Sha1 Hash) GetStoredFrame(IReadableObject p_Object)
        {
            if (m_StoredFrameCache.TryGetValue(p_Object, out var s_Cached))
                return s_Cached;

            byte[] s_Stored;
            using (var s_Reader = p_Object.GetReader())
            {
                if (s_Reader is ZlibRimeReader s_SelfZlib)
                    s_Stored = s_SelfZlib.GetRawBytes();
                else if (s_Reader.BaseStream is ZlibRimeReader s_Zlib)
                    s_Stored = s_Zlib.GetRawBytes();
                else
                {
                    var s_Length = (int)(s_Reader.Length - s_Reader.Position);
                    s_Stored = s_Length > 0 ? s_Reader.ReadBytes(s_Length) : Array.Empty<byte>();
                }
            }

            var s_Result = (s_Stored, Sha1.FromData(s_Stored));
            m_StoredFrameCache[p_Object] = s_Result;
            return s_Result;
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

                long s_CompressedSize;
                Sha1 s_ResourceHash;
                byte[]? s_ResourceInline;

                if (IsNoncasMounted(s_Readable))
                {
                    // Embedded noncas payload: catalog-hit -> pure ref, miss -> frame verbatim.
                    var (s_Stored, s_StoredHash) = GetStoredFrame(s_Readable);
                    s_CompressedSize = s_Stored.Length;
                    s_ResourceHash = s_StoredHash;
                    s_ResourceInline = m_CatalogProbe != null && m_CatalogProbe(s_StoredHash) ? null : s_Stored;
                }
                else
                {
                    s_CompressedSize = GetCompressedSize(s_Readable);
                    s_ResourceHash = GetCompressedHash(s_Readable);
                    s_ResourceInline = GetInlineData(s_Readable);
                }

                m_Header.ResourceEntries[s_ResourceIndex] = new CasBundle.Resource
                {
                    Name = s_ResourceName,
                    ResourceType = (int)s_ResourceObject.GetResourceType(),
                    Hash = s_ResourceHash,
                    Meta = s_ResourceMetadata,
                    Size = s_CompressedSize,
                    OriginalSize = s_Readable.GetSize(),
                    InlineData = s_ResourceInline
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

                var s_RangeStart = (int)s_ChunkObject.GetRangeStart();
                var s_RangeEnd = (int)s_ChunkObject.GetRangeEnd();
                var s_LogicalOffset = (int)s_ChunkObject.GetLogicalOffset();

                long s_ReadableSize;
                Sha1 s_ChunkHash;
                byte[]? s_ChunkInline;

                if (IsNoncasMounted(s_Readable))
                {
                    var (s_Stored, s_StoredHash) = GetStoredFrame(s_Readable);
                    s_ReadableSize = s_Stored.Length;
                    s_ChunkHash = s_StoredHash;
                    // SLICED sources (rangeStart/logicalOffset != 0) keep their slice semantics
                    // only as idata — a ref would re-base the range against a slice-sized blob,
                    // which is untested range territory. Full chunks ref when catalog-hit.
                    var s_Sliced = s_RangeStart != 0 || s_LogicalOffset != 0;
                    var s_CanRef = !s_Sliced && m_CatalogProbe != null && m_CatalogProbe(s_StoredHash);
                    s_ChunkInline = s_CanRef ? null : s_Stored;
                }
                else if (IsFileBacked(s_Readable) && !s_ChunkId.HasCompressionFlag())
                {
                    // File-backed chunk WITHOUT the guid compression flag: must ship RAW.
                    // Chunk compression is signaled ONLY by the guid flag bit (no
                    // size/originalSize pair like resources), so a compressed frame here
                    // gets consumed as raw bytes -> corrupted payload (caught on the XP5
                    // weapdeploy wave chunks). Mirrors the noncas BundleManifestBuilder,
                    // which compresses chunks only when the guid is flagged.
                    var (s_Raw, s_RawHash) = GetFileBackedRaw(s_Readable);
                    s_ReadableSize = s_Raw.Length;
                    s_ChunkHash = s_RawHash;
                    s_ChunkInline = s_Raw;
                }
                else
                {
                    s_ReadableSize = GetCompressedSize(s_Readable);
                    s_ChunkHash = GetCompressedHash(s_Readable);
                    s_ChunkInline = GetInlineData(s_Readable);
                }

                var s_ShouldWriteEntry = s_RangeStart != 0 || s_Readable is InlineReadable || s_ChunkInline != null;

                m_Header.ChunkEntries![s_ChunkIndex] = new CasBundle.Chunk
                {
                    Id = s_ChunkId,
                    Hash = s_ChunkHash,
                    Size = s_ReadableSize,
                    RangeStart = s_ShouldWriteEntry ? s_RangeStart : null,
                    RangeEnd = s_ShouldWriteEntry ? s_RangeEnd : null,
                    LogicalOffset = s_ShouldWriteEntry ? s_LogicalOffset : null,
                    InlineData = s_ChunkInline
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
                {
                    // No stored meta: fall back to the chunk's asset-name hash (mirrors the noncas
                    // BundleManifestBuilder). h32=0 breaks the chunk<->texture association for
                    // texture chunks (BLACK body); non-texture chunks tolerate it.
                    var s_Entry = new ChunkEntry.ChunkMetaEntry();
                    var s_NameHash = s_ChunkObject.GetAssetNameHash();
                    if (s_NameHash.HasValue)
                        s_Entry.AssetNameHash = s_NameHash.Value;
                    m_Header.ChunkMeta![s_ChunkIndex] = s_Entry;
                }

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
                else if (IsNoncasMounted(s_Readable))
                {
                    // Embedded noncas EBX (DLC partitions): BF3 EBX is stored raw, so the
                    // stored frame IS the raw partition. Catalog-hit -> ref, miss -> raw idata.
                    var (s_Stored, s_StoredHash) = GetStoredFrame(s_Readable);
                    s_PartitionSize = s_Stored.Length;
                    s_PartitionOriginalSize = s_Readable.GetSize();
                    s_PartitionHash = s_StoredHash;
                    s_PartitionInline = m_CatalogProbe != null && m_CatalogProbe(s_StoredHash) ? null : s_Stored;
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
