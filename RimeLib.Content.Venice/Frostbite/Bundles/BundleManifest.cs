using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.IO;
using RimeLib.Content.Venice.Frostbite.Chunks;
using RimeLib.Content.Venice.Frostbite.Sb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Venice.Frostbite.Bundles
{
    public class EbxEntry : IReadableObject
    {
        public string Name { get; set; }

        public SuperbundleEntry ContainedSuperbundle { get; set; }
        public BundleManifest ContainedBundle { get; set; }

        private long m_SeekOffset;

        private long m_Size;
        private long m_OriginalSize;

        internal EbxEntry(string p_Name, BundleManifest.EntryRecord p_Record, long p_SeekOffset,
            SuperbundleEntry p_Superbundle, BundleManifest p_Bundle)
        {
            Name = p_Name;
            ContainedSuperbundle = p_Superbundle;
            ContainedBundle = p_Bundle;

            m_SeekOffset = p_SeekOffset;
            m_Size = p_Record.PayloadSize;
            m_OriginalSize = p_Record.OriginalSize;
        }

        public RimeReader GetReader()
        {
            // Figure out which endianness our readers should have.
            var s_Endianness = ContainedSuperbundle.Toc.Layout.Cas ? Endianness.LittleEndian : Endianness.BigEndian;

            var s_Reader = new RimeReader(File.Open(ContainedSuperbundle.Path + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);
            s_Reader.Seek(ContainedBundle.ContainedBundle.Offset, SeekOrigin.Begin);

            // If this is patched we'll need to make a multiplexed reader.
            if (ContainedBundle.PatchBundle != null)
            {
                var s_PatchReader = new RimeReader(File.Open(ContainedSuperbundle.PatchPath + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);
                s_PatchReader.Seek(ContainedBundle.PatchBundle.Offset, SeekOrigin.Begin);

                s_Reader = new RimeMultiplexedReader(s_PatchReader, s_Reader, Endianness.BigEndian);
            }

            // Seek to this entry.
            s_Reader.Seek(m_SeekOffset, SeekOrigin.Current);
            
            // TODO: Compression.
            // TODO: Use a limited reader.

            return s_Reader;
        }

        public long GetSize()
        {
            return m_Size;
        }
    }

    public class ResourceEntry : IReadableObject
    {
        public string Name { get; set; }

        public uint ResourceType { get; set; }

        public byte[] ResourceMeta { get; set; }

        public SuperbundleEntry ContainedSuperbundle { get; set; }
        
        public BundleManifest ContainedBundle { get; set; }

        private long m_SeekOffset;

        private long m_Size;
        private long m_OriginalSize;

        internal ResourceEntry(string p_Name, uint p_Type, byte[] p_Meta, BundleManifest.EntryRecord p_Record,
            long p_SeekOffset, SuperbundleEntry p_Superbundle, BundleManifest p_Bundle)
        {
            Name = p_Name;
            ResourceType = p_Type;
            ResourceMeta = p_Meta;
            ContainedSuperbundle = p_Superbundle;
            ContainedBundle = p_Bundle;

            m_SeekOffset = p_SeekOffset;
            m_Size = p_Record.PayloadSize;
            m_OriginalSize = p_Record.OriginalSize;
        }

        public RimeReader GetReader()
        {
            // Figure out which endianness our readers should have.
            var s_Endianness = ContainedSuperbundle.Toc.Layout.Cas ? Endianness.LittleEndian : Endianness.BigEndian;

            var s_Reader = new RimeReader(File.Open(ContainedSuperbundle.Path + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);
            s_Reader.Seek(ContainedBundle.ContainedBundle.Offset, SeekOrigin.Begin);

            // If this is patched we'll need to make a multiplexed reader.
            if (ContainedBundle.PatchBundle != null)
            {
                var s_PatchReader = new RimeReader(File.Open(ContainedSuperbundle.PatchPath + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);
                s_PatchReader.Seek(ContainedBundle.PatchBundle.Offset, SeekOrigin.Begin);

                s_Reader = new RimeMultiplexedReader(s_PatchReader, s_Reader, Endianness.BigEndian);;
            }

            // Seek to this entry.
            s_Reader.Seek(m_SeekOffset, SeekOrigin.Current);

            // TODO: Compression.
            // TODO: Use a limited reader.

            return s_Reader;
        }

        public long GetSize()
        {
            return m_Size;
        }
    }

    public class BundleChunkEntry : ChunkEntry
    {
        public SuperbundleEntry ContainedSuperbundle { get; set; }
        
        public BundleManifest ContainedBundle { get; set; }

        public ChunkMeta Meta { get; set; }

        private long m_SeekOffset;

        private long m_Size;
        private bool m_Compressed;

        internal BundleChunkEntry(BundleManifest.ChunkEntry p_Entry, long p_SeekOffset, SuperbundleEntry p_Superbundle, BundleManifest p_Bundle, ChunkMeta p_Meta) :
            base(p_Entry.Id)
        {
            ContainedSuperbundle = p_Superbundle;
            ContainedBundle = p_Bundle;

            Meta = p_Meta;

            m_SeekOffset = p_SeekOffset;
            m_Size = p_Entry.RangeEnd - p_Entry.RangeStart;
            m_Compressed = Id.HasCompressionFlag();
        }

        public override RimeReader GetReader()
        {
            // Figure out which endianness our readers should have.
            var s_Endianness = ContainedSuperbundle.Toc.Layout.Cas ? Endianness.LittleEndian : Endianness.BigEndian;

            var s_Reader = new RimeReader(File.Open(ContainedSuperbundle.Path + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);
            s_Reader.Seek(ContainedBundle.ContainedBundle.Offset, SeekOrigin.Begin);

            // If this is patched we'll need to make a multiplexed reader.
            if (ContainedBundle.PatchBundle != null)
            {
                var s_PatchReader = new RimeReader(File.Open(ContainedSuperbundle.PatchPath + ".sb", FileMode.Open, FileAccess.Read, FileShare.Read), s_Endianness);
                s_PatchReader.Seek(ContainedBundle.PatchBundle.Offset, SeekOrigin.Begin);

                s_Reader = new RimeMultiplexedReader(s_PatchReader, s_Reader, Endianness.BigEndian);
            }

            // Seek to this entry.
            s_Reader.Seek(m_SeekOffset, SeekOrigin.Current);

            // Wrap into a zlib reader if this is compressed.
            if (m_Compressed)
                s_Reader = new ZlibRimeReader(s_Reader, true);
            // TODO: Compression.
            // TODO: Use a limited reader.

            return s_Reader;
        }

        public override long GetSize()
        {
            if (!m_Compressed)
                return m_Size;

            using var s_Reader = GetReader() as ZlibRimeReader;
            return s_Reader!.OriginalSize!.Value;
        }
    }

    public class BundleManifest
    {
        private class Header
        {
            public uint Magic { get; set; }
            public int EntryCount { get; set; }
            public int EbxCount { get; set; }
            public int ResourceCount { get; set; }
            public int ChunkCount { get; set; }
            public int StringBlockOffset { get; set; }
            public int ChunkMetaOffset { get; set; }
            public int ChunkMetaSize { get; set; }

            public Header(RimeReader p_Reader)
            {
                Magic = p_Reader.ReadUInt32();
                EntryCount = p_Reader.ReadInt32();
                EbxCount = p_Reader.ReadInt32();
                ResourceCount = p_Reader.ReadInt32();
                ChunkCount = p_Reader.ReadInt32();
                StringBlockOffset = p_Reader.ReadInt32();
                ChunkMetaOffset = p_Reader.ReadInt32();
                ChunkMetaSize = p_Reader.ReadInt32();
            }
        }

        internal class EntryRecord
        {
            public uint NameOffset { get; set; }

            public uint PayloadSize { get; set; }

            public uint OriginalSize { get; set; }

            public EntryRecord(RimeReader p_Reader)
            {
                NameOffset = p_Reader.ReadUInt32();
                PayloadSize = p_Reader.ReadUInt32();
                OriginalSize = p_Reader.ReadUInt32();
            }
        }

        internal class ChunkEntry
        {
            public GUID Id { get; set; }

            public uint RangeStart { get; set; }

            public uint RangeEnd { get; set; }

            public uint LogicalOffset { get; set; }

            public ChunkEntry(RimeReader p_Reader)
            {
                Id = new GUID(p_Reader);
                RangeStart = p_Reader.ReadUInt32();
                RangeEnd = p_Reader.ReadUInt32();
                LogicalOffset = p_Reader.ReadUInt32();
            }
        }

        private const uint c_ManifestEbx = 0xED1CEDB8;

        private readonly Header m_Header;
        private readonly uint m_ManifestSize;
        private readonly List<Sha1> m_Hashes = new List<Sha1>();
        private readonly List<EntryRecord> m_Records = new List<EntryRecord>();
        private readonly List<uint> m_ResourceTypeHashes = new List<uint>();
        private readonly List<byte[]> m_ResourceMeta = new List<byte[]>();
        private readonly List<ChunkEntry> m_Chunks = new List<ChunkEntry>();
        private readonly Chunks.ChunkEntry.ChunkMeta[] m_ChunkMeta = new Chunks.ChunkEntry.ChunkMeta[0];
        private readonly byte[] m_TextBlock;
        private readonly long m_StartPosition;

        public List<EbxEntry> Ebx { get; set; } = new List<EbxEntry>();
        public List<ResourceEntry> Resources { get; set; } = new List<ResourceEntry>();
        public List<BundleChunkEntry> Chunks { get; set; } = new List<BundleChunkEntry>();

        public SuperbundleEntry ContainedSuperbundle { get; set; }
        public BundleInfo ContainedBundle { get; set; }
        public BundleInfo? PatchBundle { get; set; }

        public BundleManifest(RimeReader p_Reader, SuperbundleEntry p_Superbundle, BundleInfo p_Bundle, BundleInfo? p_PatchBundle = null)
        {
            ContainedSuperbundle = p_Superbundle;
            ContainedBundle = p_Bundle;
            PatchBundle = p_PatchBundle;

            m_StartPosition = p_Reader.Position;

            m_ManifestSize = p_Reader.ReadUInt32();

            // Parse the header.
            m_Header = new Header(p_Reader);

            if ((m_Header.Magic ^ 0x7A11F1AB) != c_ManifestEbx)
                throw new Exception($"Tried to load an unsupported BundleManifest ({m_Header.Magic:X8}).");

            // Read the contained entry SHA1s
            for (var i = 0; i < m_Header.EntryCount; ++i)
                m_Hashes.Add(new Sha1(p_Reader));

            // Read all the entry records
            for (var i = 0; i < m_Header.EbxCount + m_Header.ResourceCount; ++i)
                m_Records.Add(new EntryRecord(p_Reader));

            // Read all the resource type hashes
            for (var i = 0; i < m_Header.ResourceCount; ++i)
                m_ResourceTypeHashes.Add(p_Reader.ReadUInt32());

            // Read all the resource metas
            for (var i = 0; i < m_Header.ResourceCount; ++i)
                m_ResourceMeta.Add(p_Reader.ReadBytes(16));

            // Read all the chunk info
            for (var i = 0; i < m_Header.ChunkCount; ++i)
                m_Chunks.Add(new ChunkEntry(p_Reader));

            // Read the chunk meta
            if (m_Header.ChunkMetaSize > 0)
            {
                var s_Stream = new MemoryStream();
                s_Stream.Write(p_Reader.ReadBytes(m_Header.ChunkMetaSize), 0, m_Header.ChunkMetaSize);
                s_Stream.Position = 0;

                // Create a new reader and get a DbObject from it
                var s_ObjectReader = new RimeReader(s_Stream);
                var s_Object = new DbObject(s_ObjectReader);
                var s_RealObject = s_Object[0].Value as DbObject;
                s_ObjectReader.Dispose();

                // Parse the chunk meta.
                m_ChunkMeta = new Chunks.ChunkEntry.ChunkMeta[m_Header.ChunkCount];

                for (var i = 0; i < m_Header.ChunkCount; ++i)
                    m_ChunkMeta[i] = DbObjectConverter.FromDbObject<Chunks.ChunkEntry.ChunkMeta>((s_RealObject![i].Value as DbObject)!);
            }

            // Read the text block (can be used later to associate EntryRecords).
            m_TextBlock = p_Reader.ReadBytes((int) (m_ManifestSize - p_Reader.Position + (m_StartPosition + 4)));

            // Prepare entries for reading.
            ParseEntries(p_Reader);

            // Clean up.
            m_TextBlock = new byte[0];
            m_Hashes.Clear();
            m_Records.Clear();
            m_ResourceTypeHashes.Clear();
            m_ResourceMeta.Clear();
            m_Chunks.Clear();
        }

        private void ParseEntries(RimeReader p_Reader)
        {
            // Create a reader for our text block.
            using var s_TextBlockReader = new RimeReader(new MemoryStream(m_TextBlock), Endianness.BigEndian);

            // Align reader to 16 bytes.
            p_Reader.Align(16);

            // Parse ebx entries.
            for (var i = 0; i < m_Header.EbxCount; ++i)
            {
                var s_Entry = m_Records[i];

                // Read the name of the entry.
                s_TextBlockReader.Seek(s_Entry.NameOffset, SeekOrigin.Begin);
                var s_Name = s_TextBlockReader.ReadNullTerminatedString();

                // Get the data offset for this entry.
                var s_Offset = p_Reader.Position;

                // Create the entry.
                var s_RealEntry = new EbxEntry(s_Name, s_Entry, s_Offset - m_StartPosition, ContainedSuperbundle, this);
                Ebx.Add(s_RealEntry);

                // Skip the data, we don't need to read it right now.
                p_Reader.Seek(s_Entry.PayloadSize, SeekOrigin.Current);

                // Align!
                p_Reader.Align(16);
            }

            // Parse resource entries.
            for (var i = 0; i < m_Header.ResourceCount; ++i)
            {
                var s_EntryIndex = i + m_Header.EbxCount;
                var s_Entry = m_Records[s_EntryIndex];

                // Read the name of the entry.
                s_TextBlockReader.Seek(s_Entry.NameOffset, SeekOrigin.Begin);
                var s_Name = s_TextBlockReader.ReadNullTerminatedString();

                // Get the resource type and meta.
                var s_ResourceType = m_ResourceTypeHashes[i];
                var s_ResourceMeta = m_ResourceMeta[i];

                // Get the data offset for this entry.
                var s_Offset = p_Reader.Position;
                
                // Create the entry.
                var s_RealEntry = new ResourceEntry(s_Name, s_ResourceType, s_ResourceMeta, s_Entry,
                    s_Offset - m_StartPosition, ContainedSuperbundle, this);
                Resources.Add(s_RealEntry);

                // Skip the data, we don't need to read it right now.
                p_Reader.Seek(s_Entry.PayloadSize, SeekOrigin.Current);

                // Align!
                p_Reader.Align(16);
            }

            // Parse chunk entries.
            for (var i = 0; i < m_Header.ChunkCount; ++i)
            {
                var s_EntryIndex = i + m_Header.EbxCount + m_Header.ResourceCount;

                // Get the chunk info.
                var s_ChunkEntry = m_Chunks[i];
                
                // Get the chunk meta. 
                var s_ChunkMeta = m_ChunkMeta[i];

                // Get the data offset for this entry.
                var s_Offset = p_Reader.Position;

                var s_RealEntry = new BundleChunkEntry(s_ChunkEntry, s_Offset - m_StartPosition, ContainedSuperbundle, this, s_ChunkMeta);
                Chunks.Add(s_RealEntry);

                // Skip the data, we don't need to read it right now.
                p_Reader.Seek(s_ChunkEntry.RangeEnd - s_ChunkEntry.RangeStart, SeekOrigin.Current);

                // Align!
                p_Reader.Align(16);
            }
        }
    }
}
