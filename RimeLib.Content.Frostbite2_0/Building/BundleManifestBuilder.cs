using System;
using System.Collections.Generic;
using System.IO;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Frostbite2_0.Frostbite.Bundles;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2_0.Building
{
    class BundleManifestBuilder
    {
        private readonly BundleManifest.Header m_Header = new();

        private readonly BundleDescriptor m_Descriptor;

        public Sha1 Checksum { get; private set; }

        private long m_ResourceEntriesOffset = 0;
        private long m_ChunkEntriesOffset = 0;

        public BundleManifestBuilder(BundleDescriptor p_Descriptor)
        {
            Checksum = new Sha1();

            // Populate the header.
            // some way to check if descriptor entries are dbx?
            m_Header = new BundleManifest.Header();

            m_Header.EbxCount = p_Descriptor.Partitions.Count;
            m_Header.ResourceCount = p_Descriptor.Resources.Count;
            m_Header.ChunkCount = p_Descriptor.Chunks.Count;
            m_Header.EntryCount = m_Header.EbxCount + m_Header.ResourceCount + m_Header.ChunkCount;

            m_Descriptor = p_Descriptor;
        }

        public void Serialize(RimeWriter p_Writer)
        {
            // Structure:
            // Header
            // Sha1[]
            // Entries[]
            // ResourceTypes[]
            // ResourceMeta[] 
            // ChunkEntries[]
            // ChunkMeta at ChunkMetaOffset, 4-aligned
            // StringBlock at StringBlockOffset, 4-aligned
            
            var s_StartOffset = p_Writer.Position;

            // Write temp position. Will update after.
            p_Writer.Write((uint) 0);

            // Write the header.
            m_Header.Serialize(p_Writer);

            // Write fake Sha1s. We will replace these later.
            var s_HashOffset = p_Writer.Position;
            for (var i = 0; i < m_Header.EntryCount; ++i)
                new Sha1().Serialize(p_Writer);

            using var s_TextWriter = new RimeWriter(new MemoryStream());

            // Write records.
            foreach (var s_Partition in m_Descriptor.Partitions)
                SerializeEntry(s_Partition.Key, s_Partition.Value, s_TextWriter, p_Writer);

            m_ResourceEntriesOffset = p_Writer.Position;

            foreach (var s_Resource in m_Descriptor.Resources)
                SerializeEntry(s_Resource.Key, s_Resource.Value, s_TextWriter, p_Writer);

            // Write resource types.
            foreach (var s_Resource in m_Descriptor.Resources)
                p_Writer.Write((uint) s_Resource.Value.GetResourceType());

            // Write resource metas.
            foreach (var s_Resource in m_Descriptor.Resources)
            {
                var s_Meta = new byte[16];

                if (s_Resource.Value.TryGetMeta(out var s_ResourceMeta))
                    s_Meta = s_ResourceMeta;

                if (s_Meta.Length != 16)
                    throw new Exception($"Expected metadata for resource '{s_Resource.Key}' to be 16 bytes but instead got {s_Meta.Length}.");

                p_Writer.Write(s_Meta);
            }

            m_ChunkEntriesOffset = p_Writer.Position - s_StartOffset;
            
            // Write chunk entries.
            foreach (var s_Chunk in m_Descriptor.Chunks)
            {
                var s_RangeStart = s_Chunk.Value.GetRangeStart();
                var s_Size = (uint) s_Chunk.Value.GetSize();

                var s_ChunkEntry = new BundleManifest.ChunkEntry(s_Chunk.Key)
                {
                    RangeStart = s_RangeStart,
                    RangeEnd = s_RangeStart + s_Size,
                    LogicalOffset = s_Chunk.Value.GetLogicalOffset(),
                };

                s_ChunkEntry.Serialize(p_Writer);
            }

            // Write chunk meta.
            p_Writer.Align(4);
            var s_ChunkMetaStart = p_Writer.Position - s_StartOffset;

            var s_ChunkMeta = new DbObject();
            var s_ChunkMetaArray = new DbObject();
            
            foreach (var (s_GUID, s_ChunkObject) in m_Descriptor.Chunks)
            {
                var s_AssetNameHash = s_ChunkObject.GetAssetNameHash();
                
                if (s_AssetNameHash == null)
                    throw new Exception($"Tried serializing chunk with ID '{s_GUID}' with no asset name hash.");
                
                var s_MetaObject = new DbObject();
                s_MetaObject.AddElement(new DbObjectElement("h32", s_AssetNameHash.Value));
                
                // Set metadata data.
                var s_Meta = new DbObject();

                if (s_ChunkObject.TryGetMeta(out var s_ChunkMetaEntry))
                    s_Meta = s_ChunkMetaEntry;

                s_MetaObject.AddElement(new DbObjectElement("meta", s_Meta, false));

                s_ChunkMetaArray.AddElement(new DbObjectElement("", s_MetaObject, false));
            }

            s_ChunkMeta.AddElement(new DbObjectElement("chunkMeta", s_ChunkMetaArray, true));

            s_ChunkMeta.Serialize(p_Writer);

            m_Header.ChunkMetaOffset = (int) (s_ChunkMetaStart - 4); // -4 because the manifest size is not accounted for.
            m_Header.ChunkMetaSize = (int) (p_Writer.Position - (s_StartOffset + s_ChunkMetaStart));

            // Write the text block.
            m_Header.StringBlockOffset = (int) (p_Writer.Position - (s_StartOffset + 4)); // -4 because the manifest size is not accounted for.

            s_TextWriter.Flush();
            s_TextWriter.Seek(0, SeekOrigin.Begin);
            s_TextWriter.CopyTo(p_Writer);

            p_Writer.Align(16);

            // Record the manifest size.
            var s_ManifestSize = p_Writer.Position - s_StartOffset - 4; // -4 because the manifest size is not accounted for.

            // Update manifest size and header.
            p_Writer.Seek(s_StartOffset, SeekOrigin.Begin);
            p_Writer.Write((uint) s_ManifestSize);
            m_Header.Serialize(p_Writer);

            // Get ready to start writing our actual entries.
            // +4 to account for the manifest size.
            p_Writer.Seek(s_StartOffset + s_ManifestSize + 4, SeekOrigin.Begin);

            WriteEntries(p_Writer, s_HashOffset);
        }

        private void WriteEntries(RimeWriter p_Writer, long p_HashOffset)
        {
            var s_Hashes = new List<Sha1>();

            using var s_ChecksumWriter = new HashingRimeWriter(new MemoryStream());

            foreach (var s_Partition in m_Descriptor.Partitions)
            {
                p_Writer.Align(16);
                
                using var s_PartitionReader = s_Partition.Value.GetReader();
                using var s_HashWriter = new HashingRimeWriter(p_Writer, false);

                s_PartitionReader.CopyTo(s_HashWriter);

                var s_Hash = s_HashWriter.GetHash();
                s_Hashes.Add(s_Hash);

                s_Hash.Serialize(s_ChecksumWriter);
            }

            var s_ResourceIndex = 0;

            foreach (var s_Resource in m_Descriptor.Resources)
            {
                p_Writer.Align(16);
                
                var s_ShouldCompress = false;

                // TODO: Figure out what other resources need to be compressed.
                if (s_Resource.Value.GetResourceType() == ResourceType.DxTexture)
                {
                    s_ShouldCompress = true;
                }

                using var s_ResourceReader = s_Resource.Value.GetReader();
                using var s_HashWriter = new HashingRimeWriter(new MemoryStream());
                s_ResourceReader.CopyTo(s_HashWriter);

                var s_Hash = s_HashWriter.GetHash();
                s_Hashes.Add(s_Hash);

                s_Hash.Serialize(s_ChecksumWriter);

                if (s_ShouldCompress)
                {
                    s_ResourceReader.Seek(0, SeekOrigin.Begin);
                    var s_CompressedSize = WriteCompressed(p_Writer, s_ResourceReader);

                    // Go back and patch the entry sizes.
                    var s_CurrentOffset = p_Writer.Position;

                    // 12 = EntryRecord size, 4 = offset to PayloadSize.
                    p_Writer.Seek(m_ResourceEntriesOffset + (12 * s_ResourceIndex) + 4, SeekOrigin.Begin);
                    p_Writer.Write(s_CompressedSize);
                    p_Writer.Seek(s_CurrentOffset, SeekOrigin.Begin);
                }
                else
                {
                    s_ResourceReader.Seek(0, SeekOrigin.Begin);
                    p_Writer.Write(s_ResourceReader);
                }
                
                ++s_ResourceIndex;
            }
            
            var s_ChunkIndex = 0;

            foreach (var s_Chunk in m_Descriptor.Chunks)
            {
                p_Writer.Align(16);
                
                using var s_ChunkReader = s_Chunk.Value.GetReader();
                using var s_HashWriter = new HashingRimeWriter(p_Writer, false);
                
                if (s_Chunk.Key.HasCompressionFlag())
                {
                    var s_CompressedSize = WriteCompressed(s_HashWriter, s_ChunkReader);
                    
                    // Go back and patch the entry sizes.
                    var s_CurrentOffset = p_Writer.Position;
                    var s_RangeStart = s_Chunk.Value.GetRangeStart();
                    
                    // 28 = ChunkEntry size, 20 = Offset to RangeEnd.
                    p_Writer.Seek(m_ChunkEntriesOffset + (28 * s_ChunkIndex) + 20, SeekOrigin.Begin);
                    p_Writer.Write(s_RangeStart + s_CompressedSize);
                    p_Writer.Seek(s_CurrentOffset, SeekOrigin.Begin);
                }
                else
                {
                    s_ChunkReader.CopyTo(s_HashWriter);
                }
                
                var s_Hash = s_HashWriter.GetHash();
                s_Hashes.Add(s_Hash);
                s_Hash.Serialize(s_ChecksumWriter);

                ++s_ChunkIndex;
            }
            
            p_Writer.Align(16);

            // Store final checksum, which is a sha1 of all the sha1s.
            Checksum = s_ChecksumWriter.GetHash();

            // Patch the hashes.
            var s_FinalOffset = p_Writer.Position;
            p_Writer.Seek(p_HashOffset, SeekOrigin.Begin);

            foreach (var s_Hash in s_Hashes)
                s_Hash.Serialize(p_Writer);

            // Return back to the end of the stream.
            p_Writer.Seek(s_FinalOffset, SeekOrigin.Begin);
        }

        private void SerializeEntry(string p_Name, IReadableObject p_Object, RimeWriter p_TextWriter, RimeWriter p_ManifestWriter)
        {
            var s_Size = p_Object.GetSize();

            var s_EntryRecord = new BundleManifest.EntryRecord
            {
                NameOffset = (uint) p_TextWriter.Position,
                PayloadSize = (uint) s_Size,
                OriginalSize = (uint) s_Size,
            };

            p_TextWriter.WriteNullTerminatedString(p_Name);

            s_EntryRecord.Serialize(p_ManifestWriter);
        }

        private uint WriteCompressed(RimeWriter p_Writer, Stream p_InputStream)
        {
            var s_CompressedSegments = new List<Tuple<byte[], uint>>();
            
            var s_LeftBytes = p_InputStream.Length;
                
            while (s_LeftBytes > 0)
            {
                // Compressed segments are at most 0x10000 (65536) bytes in size.
                var s_BytesToCompress = (uint) System.Math.Min(0x10000, s_LeftBytes);
                s_LeftBytes -= s_BytesToCompress;

                var s_CompressionMemoryStream = new MemoryStream();
                using (var s_CompressionStream = new DeflaterOutputStream(s_CompressionMemoryStream, new Deflater(Deflater.DEFAULT_COMPRESSION), 4096))
                {
                    var s_ByteBuffer = new byte[s_BytesToCompress];
                    var s_BytesRead = p_InputStream.Read(s_ByteBuffer);

                    if (s_BytesRead != s_BytesToCompress)
                    {
                        throw new Exception(
                            $"An error occurred while reading the data of a texture chunk. Tried reading {s_BytesToCompress} bytes but read {s_BytesRead}."
                        );
                    }

                    s_CompressionStream.Write(s_ByteBuffer);
                    s_CompressionStream.Flush();

                    s_CompressedSegments.Add(Tuple.Create(s_CompressionMemoryStream.ToArray(), s_BytesToCompress));
                }
            }
            
            // Now write the final compressed data.
            uint s_TotalSize = 0;
            
            foreach (var (s_CompressedSegment, s_OriginalSize) in s_CompressedSegments)
            {
                p_Writer.Write(s_OriginalSize);
                p_Writer.Write(s_CompressedSegment.Length);
                p_Writer.Write(s_CompressedSegment);

                s_TotalSize += 8;
                s_TotalSize += (uint) s_CompressedSegment.Length;
            }

            return s_TotalSize;
        }
    }
}
