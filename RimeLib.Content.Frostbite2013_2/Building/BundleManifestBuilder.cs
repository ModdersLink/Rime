using LZ4;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite2013_2.Frostbite.Bundles;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Codec;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2013_2.Building
{
    class BundleManifestBuilder
    {
        private readonly BundleManifest.Header m_Header = new();
        private readonly BundleDescriptor m_Descriptor;
        public Sha1 Checksum { get; private set; }

        private Dictionary<string, uint> m_StringTable = new();

        public BundleManifestBuilder(BundleDescriptor p_Descriptor)
        {
            Checksum = new Sha1();

            m_Header = new BundleManifest.Header
            {
                EbxCount = p_Descriptor.Partitions.Count,
                ResourceCount = p_Descriptor.Resources.Count,
                ChunkCount = p_Descriptor.Chunks.Count
            };
            m_Header.EntryCount = m_Header.EbxCount + m_Header.ResourceCount + m_Header.ChunkCount;

            m_Descriptor = p_Descriptor;
        }

        public void Serialize(RimeWriter p_Writer)
        {
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

            foreach (var s_Resource in m_Descriptor.Resources)
                SerializeEntry(s_Resource.Key, s_Resource.Value, s_TextWriter, p_Writer);

            // Write resource types.
            foreach (var s_Resource in m_Descriptor.Resources)
                p_Writer.Write((uint) s_Resource.Value.GetResourceType());

            // Write resource metas.
            foreach (var s_Resource in m_Descriptor.Resources)
            {
                var s_Meta = new byte[16];

                if (s_Resource.Value.TryGetMeta(out var s_ResourceMeta)) // TODO: what if this fails?
                    s_Meta = s_ResourceMeta;

                if (s_Meta.Length != 16)
                    throw new Exception($"Expected metadata for resource '{s_Resource.Key}' to be 16 bytes but instead got {s_Meta.Length}.");

                p_Writer.Write(s_Meta);
            }

            // new addition in fb2013_2: Write resource ref id.
            foreach (var s_Resource in m_Descriptor.Resources)
            {
                var s_ResourceRef = s_Resource.Value.GetId(s_Resource.Key);
                s_ResourceRef.Serialize(p_Writer);
            }
            
            // Write chunk entries.
            foreach (var s_Chunk in m_Descriptor.Chunks)
            {
                var s_RangeStart = s_Chunk.Value.GetRangeStart();
                var s_Size = (uint) s_Chunk.Value.GetSize();

                var s_ChunkEntry = new BundleManifest.ChunkEntry(s_Chunk.Key)
                {
                    LogicalOffset = s_Chunk.Value.GetLogicalOffset(),
                    // TODO: LogicalSize = s_Chunk.Value.GetLogicalSize(),
                };

                s_ChunkEntry.Serialize(p_Writer);
            }

            if (m_Descriptor.Chunks.Count > 0)
            {
                var s_ChunkMetaStart = p_Writer.Position - s_StartOffset;
                var s_ChunkMeta = new DbObject();
                var s_ChunkMetaArray = new DbObject();

                foreach (var (s_GUID, s_ChunkObject) in m_Descriptor.Chunks)
                {
                    // Set metadata data.
                    var s_MetaObject = new DbObject();

                    if (s_ChunkObject.TryGetMeta(out var s_ChunkMetaEntry))
                        s_MetaObject = s_ChunkMetaEntry;
                    else
                    {
                        var s_AssetNameHash = s_ChunkObject.GetAssetNameHash();

                        if (s_AssetNameHash == null)
                            throw new Exception($"Tried serializing chunk with ID '{s_GUID}' with no asset name hash.");

                        var s_Meta = new DbObject(); // TODO: what about firstMip?
                        s_MetaObject.AddElement(new DbObjectElement("h32", s_AssetNameHash.Value));
                        s_MetaObject.AddElement(new DbObjectElement("meta", s_Meta, false));
                    }

                    s_ChunkMetaArray.AddElement(new DbObjectElement("", s_MetaObject, false));
                }

                s_ChunkMeta.AddElement(new DbObjectElement("chunkMeta", s_ChunkMetaArray, true));

                s_ChunkMeta.Serialize(p_Writer);

                m_Header.ChunkMetaOffset = (int)(s_ChunkMetaStart - 4); // -4 because the manifest size is not accounted for.
                m_Header.ChunkMetaSize = (int)(p_Writer.Position - (s_StartOffset + s_ChunkMetaStart));
            }

            // Write the text block.
            m_Header.StringBlockOffset = (int) (p_Writer.Position - (s_StartOffset + 4)); // -4 because the manifest size is not accounted for.

            s_TextWriter.Flush();
            s_TextWriter.Seek(0, SeekOrigin.Begin);
            s_TextWriter.CopyTo(p_Writer);
            
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
                using var s_PartitionReader = s_Partition.Value.GetReader();
                using var s_HashWriter = new HashingRimeWriter(p_Writer, false);

                var s_CompressedSize = WriteLZ4Compressed(s_HashWriter, s_PartitionReader);

                var s_Hash = s_HashWriter.GetHash();
                s_Hashes.Add(s_Hash);

                s_Hash.Serialize(s_ChecksumWriter);
            }

            foreach (var s_Resource in m_Descriptor.Resources)
            {
                using var s_ResourceReader = s_Resource.Value.GetReader();
                using var s_HashWriter = new HashingRimeWriter(p_Writer, false);

                var s_CompressedSize = WriteLZ4Compressed(s_HashWriter, s_ResourceReader);

                var s_Hash = s_HashWriter.GetHash();
                s_Hashes.Add(s_Hash);

                s_Hash.Serialize(s_ChecksumWriter);
            }

            foreach (var s_Chunk in m_Descriptor.Chunks)
            {
                using var s_ChunkReader = s_Chunk.Value.GetReader();
                using var s_HashWriter = new HashingRimeWriter(p_Writer, false);

                var s_CompressedSize = WriteLZ4Compressed(s_HashWriter, s_ChunkReader);

                var s_Hash = s_HashWriter.GetHash();
                s_Hashes.Add(s_Hash);

                s_Hash.Serialize(s_ChecksumWriter);
            }

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

        private uint WriteLZ4Compressed(RimeWriter p_Writer, Stream p_InputStream)
        {
            var s_LeftBytes = p_InputStream.Length;
            uint s_TotalSize = 0;

            while (s_LeftBytes > 0)
            {
                var s_BytesToCompress = (int)System.Math.Min(0x10000, s_LeftBytes);
                var s_Buffer = new byte[s_BytesToCompress];
                p_InputStream.Read(s_Buffer, 0, s_BytesToCompress);

                var s_CompressedBuffer = LZ4Codec.Encode(s_Buffer, 0, s_BytesToCompress);

                var s_Header = new CodecHeader((uint)s_CompressedBuffer.Length, (uint)s_BytesToCompress, CodecMethod.LZ4);
                s_Header.Serialize(p_Writer);

                p_Writer.Write(s_CompressedBuffer);

                s_TotalSize += (uint)(8 + s_CompressedBuffer.Length);
                s_LeftBytes -= s_BytesToCompress;
            }

            return s_TotalSize;
        }

        private void SerializeEntry(string p_Name, IReadableObject p_Object, RimeWriter p_TextWriter, RimeWriter p_ManifestWriter)
        {
            var s_Size = p_Object.GetSize();

            if (!m_StringTable.TryGetValue(p_Name, out uint s_NameOffset))
            {
                s_NameOffset = (uint)p_TextWriter.Position;
                m_StringTable[p_Name] = s_NameOffset;
                p_TextWriter.WriteNullTerminatedString(p_Name);
            }

            var s_EntryRecord = new BundleManifest.EntryRecord
            {
                NameOffset = s_NameOffset,
                OriginalSize = (uint) s_Size,
            };

            s_EntryRecord.Serialize(p_ManifestWriter);
        }
    }
}
