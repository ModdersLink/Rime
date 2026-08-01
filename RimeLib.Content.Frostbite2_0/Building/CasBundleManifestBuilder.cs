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

        // When set, a noncas source whose stored frame the player's catalog already holds is emitted
        // as a bare sha1 ref. Everything else ships its frame verbatim as inline data.
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
                // A retail manifest always carries the chunks and chunkMeta keys, even when they are
                // empty arrays. Omitting them yields a bundle Rime can parse but the game's own loader
                // never reads the content of.
                ChunkEntries = new CasBundle.Chunk[p_Descriptor.Chunks.Count],
                ChunkMeta = new ChunkEntry.ChunkMetaEntry[p_Descriptor.Chunks.Count], // NOTE: This matches the amount of chunk entries
            };
        }

        // A real cas bundle payload, inline data included, is stored in the compressed block format
        // and content-addressed by the sha1 of the compressed bytes. Inlining raw bytes with the
        // compression flag off makes the game misparse them.
        private readonly Dictionary<IReadableObject, (byte[] Data, Sha1 Hash)> m_CompressedCache = new();

        // EBX partitions are the exception: they are never zlib-compressed in a cas bundle, every real
        // EBX entry in the game has size == originalSize, and the noncas builder writes them raw too.
        // A compressed inline EBX makes the game treat the data as corrupt and refuse to start.
        private readonly Dictionary<IReadableObject, (byte[] Data, Sha1 Hash)> m_RawCache = new();

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

        // A source whose payload sits embedded in a mounted noncas superbundle or toc chunk. Their
        // manifest sha1 is not a usable catalog key, so they are content-addressed by their stored
        // frame instead. Emitting them as bare refs gives the engine something it can never fetch.
        private static bool IsNoncasMounted(IReadableObject p_Object)
        {
            return p_Object is ResourceEntry
                || p_Object is EbxEntry
                || p_Object is BundleChunkEntry
                || p_Object is SbChunkEntry;
        }

        // The stored frame of a noncas source: the original compressed blocks, or the raw window when
        // the source is uncompressed. Its sha1 is the same identity a catalog keys entries by.
        private readonly Dictionary<IReadableObject, (byte[] Data, Sha1 Hash)> m_StoredFrameCache = new();

        private static (byte[] Data, Sha1 Hash) GetCached(
            Dictionary<IReadableObject, (byte[] Data, Sha1 Hash)> p_Cache,
            IReadableObject p_Object,
            Func<IReadableObject, byte[]> p_Read)
        {
            if (p_Cache.TryGetValue(p_Object, out var s_Cached))
                return s_Cached;

            var s_Data = p_Read(p_Object);
            var s_Result = (s_Data, Sha1.FromData(s_Data));

            p_Cache[p_Object] = s_Result;
            return s_Result;
        }

        private (byte[] Data, Sha1 Hash) GetStoredFrame(IReadableObject p_Object)
        {
            return GetCached(m_StoredFrameCache, p_Object, p_Source =>
            {
                using var s_Reader = p_Source.GetReader();

                if (s_Reader is ZlibRimeReader s_SelfZlib)
                    return s_SelfZlib.GetRawBytes();
                if (s_Reader.BaseStream is ZlibRimeReader s_Zlib)
                    return s_Zlib.GetRawBytes();

                var s_Length = (int)(s_Reader.Length - s_Reader.Position);
                return s_Length > 0 ? s_Reader.ReadBytes(s_Length) : Array.Empty<byte>();
            });
        }

        private (byte[] Data, Sha1 Hash) GetFileBackedCompressed(IReadableObject p_Object)
        {
            return GetCached(m_CompressedCache, p_Object, p_Source =>
            {
                using var s_Reader = p_Source.GetReader();
                return CompressBlocks(s_Reader.ReadBytes((int)s_Reader.Length));
            });
        }

        private (byte[] Data, Sha1 Hash) GetFileBackedRaw(IReadableObject p_Object)
        {
            return GetCached(m_RawCache, p_Object, p_Source =>
            {
                using var s_Reader = p_Source.GetReader();
                return s_Reader.ReadBytes((int)s_Reader.Length);
            });
        }

        // Compresses raw bytes into the zlib block payload format: a run of segments, each one a
        // big-endian uint32 original size, a big-endian uint32 compressed size and the deflate data,
        // with each segment covering at most 0x10000 uncompressed bytes. Mirrors the noncas
        // BundleManifestBuilder so ZlibRimeReader and the game read it back.
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
            // File/memory-backed: the size is that of the compressed block payload.
            return GetFileBackedCompressed(p_Object).Data.Length;
        }

        Sha1 GetCompressedHash(IReadableObject p_Object)
        {
            if (p_Object is CatalogReadable s_Catalog) return s_Catalog.GetCompressedHash()!;
            if (p_Object is InlineReadable s_Inline) return s_Inline.GetCompressedHash()!;
            if (p_Object is ResourceEntry s_Resource) return s_Resource.Hash;
            if (p_Object is EbxEntry s_Ebx) return s_Ebx.Hash;
            if (p_Object is BundleChunkEntry s_Chunk) return s_Chunk.Hash;
            if (p_Object is CasChunkEntry s_CasChunk) return s_CasChunk.Hash;
            // File/memory-backed: the content address is the hash of the compressed payload.
            return GetFileBackedCompressed(p_Object).Hash;
        }

        byte[]? GetInlineData(IReadableObject p_Object)
        {
            if (p_Object is InlineReadable s_Inline) return s_Inline.GetCompressedData();
            // File-backed and memory-backed objects inline the compressed block payload, so the game
            // and Rime's own reader decompress it instead of misparsing it as raw.
            if (IsFileBacked(p_Object))
                return GetFileBackedCompressed(p_Object).Data;
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
                    // A catalog hit becomes a bare ref, a miss ships the frame verbatim.
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
                    // A sliced source only keeps its slice semantics as inline data, since a ref would
                    // re-base the range against a slice-sized blob. Only whole chunks become refs.
                    var s_Sliced = s_RangeStart != 0 || s_LogicalOffset != 0;
                    var s_CanRef = !s_Sliced && m_CatalogProbe != null && m_CatalogProbe(s_StoredHash);
                    s_ChunkInline = s_CanRef ? null : s_Stored;
                }
                else if (IsFileBacked(s_Readable) && !s_ChunkId.HasCompressionFlag())
                {
                    // A chunk signals compression only through the flag bit in its guid, with no
                    // size and originalSize pair like a resource has, so a compressed frame under an
                    // unflagged guid is consumed as raw bytes and the payload comes out corrupt. The
                    // noncas builder likewise compresses a chunk only when its guid is flagged.
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
                    // With no stored meta, fall back to the chunk's asset name hash the way the noncas
                    // builder does. A texture chunk left with h32=0 loses its association with the
                    // texture and never renders; other chunk kinds tolerate it.
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
                    // New or modified EBX is stored raw with size == originalSize, since the game
                    // never zlib-compresses EBX.
                    var (s_Raw, s_RawHash) = GetFileBackedRaw(s_Readable);
                    s_PartitionInline = s_Raw;
                    s_PartitionSize = s_Raw.Length;
                    s_PartitionOriginalSize = s_Raw.Length;
                    s_PartitionHash = s_RawHash;
                }
                else if (IsNoncasMounted(s_Readable))
                {
                    // Since EBX is stored raw, the stored frame of an embedded noncas partition is
                    // the raw partition itself.
                    var (s_Stored, s_StoredHash) = GetStoredFrame(s_Readable);
                    s_PartitionSize = s_Stored.Length;
                    s_PartitionOriginalSize = s_Readable.GetSize();
                    s_PartitionHash = s_StoredHash;
                    s_PartitionInline = m_CatalogProbe != null && m_CatalogProbe(s_StoredHash) ? null : s_Stored;
                }
                else
                {
                    // Unchanged EBX keeps its existing catalog reference or inline data.
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
