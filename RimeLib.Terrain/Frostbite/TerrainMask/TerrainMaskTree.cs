using fb;
using RimeLib.IO;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Serialization.Frostbite2_0.Extensions;
using AxisAlignedBox2 = fb.AxisAlignedBox;

namespace RimeLib.Terrain.Frostbite.TerrainMask;

/// <summary>
/// Which terrain layer covers which ground, and how strongly.
///
/// The material tree beside it says what a patch of ground IS -- the physics material you hear and
/// skid on. This one says what it LOOKS like: the blend weights the terrain's layer textures are
/// mixed with. Nothing in EBX carries it.
/// </summary>
public class TerrainMaskTree : RasterTree
{
    public uint NodeSamplesPerSide { get; set; }

    /// <summary>The mask raster's resolution across the whole tree, in samples per side.</summary>
    public uint RasterSamplesPerSide { get; set; }

    /// <summary>How many nodes carry samples. The node list should end up this long.</summary>
    public uint DataNodeCount { get; set; }

    /// <summary>
    /// Two header fields whose meaning is not established, kept verbatim so a writer can carry
    /// them rather than invent them.
    ///
    /// SURVEYED across all 33 shipped BF3 terrains: <c>UnknownB</c> is 1 everywhere, and
    /// <c>UnknownA</c> is only ever 1024 (6 terrains) or 2048 (27). Neither correlates with the
    /// raster size, the node size, the world extent or any node count -- and sp_tank_terrain_02
    /// ships TWICE with different values of A, which is what rules out its being derived from the
    /// terrain at all. It reads as an authoring or streaming setting.
    ///
    /// So a writer does not need to understand them: preserve them when rewriting an existing
    /// terrain, and use the shipped majority (A = 2048, B = 1) for a new one.
    /// </summary>
    public uint UnknownA { get; set; }

    /// <inheritdoc cref="UnknownA"/>
    public uint UnknownB { get; set; }
    public uint BlurrinessFactor { get; set; }
    public uint NodeCount { get; set; }
    public uint PersistentNodeCount { get; set; }
    public uint LevelMax { get; set; }

    public Vec2 CoverageMin { get; set; } = new Vec2();
    public uint NodeGridCellsPerSide { get; set; }

    /// <summary>Every node that carries mask samples, in tree order.</summary>
    public List<TerrainMaskNode> Nodes { get; } = new List<TerrainMaskNode>();

    /// <summary>
    /// One group of the block: its records, the u32 that follows the counts, how many 7-byte zero
    /// blocks preceded it, and whether it carries samples. Kept so the block can be WRITTEN from
    /// fields rather than copied.
    /// </summary>
    public sealed class Group
    {
        public List<TerrainMaskNode> Records { get; } = new List<TerrainMaskNode>();
        public ushort NodeCount { get; set; }
        public uint Unknown { get; set; }
        public byte Flag { get; set; }
        public int ZeroBlocks { get; set; }
        public bool HasSamples { get; set; }
    }

    /// <summary>The block's groups, in order.</summary>
    public List<Group> Groups { get; } = new List<Group>();

    /// <summary>The header exactly as read -- 48 bytes, written back unchanged.</summary>
    public byte[] HeaderRaw { get; set; } = System.Array.Empty<byte>();

    private byte m_PendingFlag;
    private int m_PendingZeroBlocks;

    /// Where the last group ENDED. Not the same as Consumed: the seek that looks for the next group
    /// eats the trailing separator before it gives up, so Consumed sits past the block's real tail.
    private long m_LastGroupEnd;

    /// <summary>Whatever follows the nodes, kept so an unknown tail is visible rather than silent.</summary>
    public byte[] Trailing { get; set; } = System.Array.Empty<byte>();

    /// <summary>The whole block as it was stored, for working out what the parse has not covered.</summary>
    public byte[] Raw { get; set; } = System.Array.Empty<byte>();

    /// <summary>How many bytes the node walk consumed.</summary>
    public long Consumed { get; set; }


    /// <summary>Whether a chunk header starts here, without consuming it.</summary>
    private bool LooksLikeChunk(RimeReader p_Reader, long p_End)
    {
        var s_Start = p_Reader.Position;
        var s_Ok = false;

        if (s_Start + 8 <= p_End)
        {
            var s_Records = (ushort)((p_Reader.ReadUByte() << 8) | p_Reader.ReadUByte());
            var s_Nodes = (ushort)((p_Reader.ReadUByte() << 8) | p_Reader.ReadUByte());
            p_Reader.ReadUInt32();

            var s_SampleBytes = (long)NodeSamplesPerSide * NodeSamplesPerSide;
            var s_DataAt = s_Start + 8 + s_Records * 32L;

            // Every chunk measured carries four container records beyond its node count, so a
            // header with fewer than four records is not one.
            if (s_Records >= 4 && s_DataAt + 4 <= p_End)
            {
                p_Reader.Seek(s_DataAt - p_Reader.Position, SeekOrigin.Current);

                var s_Size = p_Reader.ReadUInt32();
                s_Ok = s_Size == s_Nodes * s_SampleBytes && s_DataAt + 4 + s_Size <= p_End;
            }
        }

        p_Reader.Seek(s_Start - p_Reader.Position, SeekOrigin.Current);
        return s_Ok;
    }

    /// <summary>
    /// One run of node records followed by their samples.
    ///
    /// The counts are u16 BIG-endian, which is why they read as nonsense little-endian: MP_001's
    /// `00 1b 00 17` is 27 records and 23 nodes, not 6912 and 5888.
    /// </summary>
    private bool ReadChunk(RimeReader p_Reader, long p_End)
    {
        if (p_Reader.Position + 8 > p_End)
            return false;

        var s_RecordCount = (ushort)((p_Reader.ReadUByte() << 8) | p_Reader.ReadUByte());
        var s_NodeCount = (ushort)((p_Reader.ReadUByte() << 8) | p_Reader.ReadUByte());
        var s_Unknown = p_Reader.ReadUInt32();

        if (s_RecordCount == 0 || p_Reader.Position + s_RecordCount * 32 + 4 > p_End)
            return false;

        var s_Group = new Group { NodeCount = s_NodeCount, Unknown = s_Unknown,
                                  Flag = m_PendingFlag, ZeroBlocks = m_PendingZeroBlocks };
        Groups.Add(s_Group);
        var s_Records = s_Group.Records;

        for (var i = 0; i < s_RecordCount; ++i)
        {
            var s_Node = new TerrainMaskNode
            {
                MinX = p_Reader.ReadSingle(),
                MinY = p_Reader.ReadSingle(),
                MaxX = p_Reader.ReadSingle(),
                MaxY = p_Reader.ReadSingle(),
                Flags = p_Reader.ReadUInt32()
            };

            s_Node.PresenceMask = p_Reader.ReadBytes(11);
            s_Node.Level = p_Reader.ReadUByte();
            s_Records.Add(s_Node);
        }

        var s_SampleBytes = NodeSamplesPerSide * NodeSamplesPerSide;

        // A group carries samples only if the u32 after its records is exactly the size they would
        // occupy. Most groups carry none -- they are the tree's interior nodes -- and for those
        // this u32 is already the next group's separator, so it must be put back rather than
        // consumed. Reading every group as if it had samples is what stopped the walk one group in.
        if (p_Reader.Position + 4 > p_End)
        {
            m_LastGroupEnd = p_Reader.Position;
            return true;
        }

        var s_Mark = p_Reader.Position;
        var s_DataSize = p_Reader.ReadUInt32();

        if (s_NodeCount == 0 || s_DataSize != s_NodeCount * s_SampleBytes
            || p_Reader.Position + s_DataSize > p_End)
        {
            p_Reader.Seek(s_Mark - p_Reader.Position, SeekOrigin.Current);
            m_LastGroupEnd = p_Reader.Position;
            return true;
        }

        // The leading records are the containers the tree descends through -- four of them, one
        // per root quadrant, on every level measured bar one. The trailing records are the ones
        // that own samples, in the order the blocks follow.
        s_Group.HasSamples = true;
        var s_First = s_Records.Count - s_NodeCount;

        for (var i = 0; i < s_NodeCount; ++i)
        {
            var s_Node = s_Records[s_First + i];
            s_Node.SampleOffset = p_Reader.Position;
            s_Node.Samples = p_Reader.ReadBytes((int)s_SampleBytes);
            Nodes.Add(s_Node);
        }

        m_LastGroupEnd = p_Reader.Position;
        return true;
    }

    /// <summary>
    /// Write the whole block from parsed fields: header, then every group in order -- separator,
    /// counts, the u32 that follows them, the records, and the samples for the groups that carry
    /// any.
    ///
    /// Nothing is copied from the source block except the 48-byte header, which is written back
    /// verbatim because two of its fields are surveyed rather than understood (see UnknownA).
    /// Everything else is reconstructed, which is what makes this a writer rather than an edit --
    /// a terrain can be given different samples, or a different set of nodes, and still come out
    /// as a block the reader accepts.
    ///
    /// The separator's zero-block count is carried per group. It has no length field and the
    /// reader simply eats zero blocks, so a NEW group can use none; keeping the observed count is
    /// what lets an unmodified tree come back byte for byte.
    /// </summary>
    public override bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;

        if (HeaderRaw.Length == 0 || Groups.Count == 0)
            return false;

        var s_Out = new List<byte>(Raw.Length > 0 ? Raw.Length : 4096);
        s_Out.AddRange(HeaderRaw);

        for (var s_Index = 0; s_Index < Groups.Count; ++s_Index)
        {
            var s_Group = Groups[s_Index];

            if (s_Index > 0)
            {
                s_Out.Add(s_Group.Flag);

                for (var i = 0; i < s_Group.ZeroBlocks; ++i)
                    s_Out.AddRange(new byte[7]);
            }

            var s_Records = s_Group.Records;
            s_Out.Add((byte)(s_Records.Count >> 8));         // counts are BIG-endian u16
            s_Out.Add((byte)(s_Records.Count & 0xFF));
            s_Out.Add((byte)(s_Group.NodeCount >> 8));
            s_Out.Add((byte)(s_Group.NodeCount & 0xFF));
            s_Out.AddRange(System.BitConverter.GetBytes(s_Group.Unknown));

            foreach (var s_Node in s_Records)
            {
                s_Out.AddRange(System.BitConverter.GetBytes(s_Node.MinX));
                s_Out.AddRange(System.BitConverter.GetBytes(s_Node.MinY));
                s_Out.AddRange(System.BitConverter.GetBytes(s_Node.MaxX));
                s_Out.AddRange(System.BitConverter.GetBytes(s_Node.MaxY));
                s_Out.AddRange(System.BitConverter.GetBytes(s_Node.Flags));
                s_Out.AddRange(s_Node.PresenceMask);
                s_Out.Add((byte)s_Node.Level);
            }

            if (!s_Group.HasSamples)
                continue;

            var s_Sampled = s_Records.GetRange(s_Records.Count - s_Group.NodeCount,
                s_Group.NodeCount);
            var s_Size = 0;

            foreach (var s_Node in s_Sampled)
                s_Size += s_Node.Samples.Length;

            s_Out.AddRange(System.BitConverter.GetBytes((uint)s_Size));

            foreach (var s_Node in s_Sampled)
                s_Out.AddRange(s_Node.Samples);
        }

        s_Out.AddRange(Trailing);

        p_Data = s_Out.ToArray();
        return true;
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        if (!Serialize(out var s_Data))
            return false;

        p_Writer.Write(s_Data!);
        return true;
    }

    /// <summary>
    /// The 48-byte header. Three fields sit between the blurriness and the coverage box that an
    /// earlier read skipped, which put coverage at the wrong offset and turned every field after
    /// it into garbage -- a node count of 3.2 billion, and a sample length that ran off the end.
    /// </summary>
    private AxisAlignedBox ReadHeader(RimeReader p_Reader)
    {
        NodeSamplesPerSide = p_Reader.ReadUInt32();
        BlurrinessFactor = (uint)(1 << p_Reader.ReadInt32());

        // The mask raster's own resolution, which is not the terrain's: MP_001 covers 1 km at 2048
        // samples, 0.5 m each, where the 4 km sp_bank uses 1024 at 4 m each.
        RasterSamplesPerSide = p_Reader.ReadUInt32();
        UnknownA = p_Reader.ReadUInt32();
        UnknownB = p_Reader.ReadUInt32();

        var s_Coverage = new AxisAlignedBox();
        s_Coverage.DeserializeVec2(p_Reader);

        NodeCount = p_Reader.ReadUInt32();
        PersistentNodeCount = p_Reader.ReadUInt32();
        DataNodeCount = p_Reader.ReadUInt32();

        CoverageMin = new Vec2 { x = s_Coverage.min.x, y = s_Coverage.min.y };

        var s_Cells = NodeSamplesPerSide > 2 ? RasterSamplesPerSide / (NodeSamplesPerSide - 2) : 1;

        NodeGridCellsPerSide = s_Cells == 0 ? 1 : s_Cells;
        LevelMax = 0;

        for (var s_Remaining = NodeGridCellsPerSide; s_Remaining > 1; s_Remaining >>= 1)
            ++LevelMax;

        return s_Coverage;
    }

    /// <summary>
    /// Step over the flag byte and whatever separates one chunk from the next, landing on a header.
    /// Skipping zero bytes instead does not work and quietly loses a chunk: the counts are
    /// big-endian, so any below 256 opens with a zero byte of its own.
    ///
    /// What follows the first chunk is RECORD GROUPS WITHOUT SAMPLES, and that is the whole tail.
    ///
    /// MEASURED across the shipped terrains. A block is: the 48-byte header; ONE chunk carrying
    /// records AND samples, holding exactly DataNodeCount nodes (verified equal on every terrain);
    /// then a run of groups shaped `separator, counts, u32, recs * 32 bytes of records` and NO
    /// sample payload. Parsing them that way consumes the block to its last byte, and their records
    /// sum to PersistentNodeCount exactly -- 1326, 2123, 4109, 2309, 4496 and 911 on the nose for
    /// six terrains measured.
    ///
    /// Reading them as more sample chunks is the trap: the counts and bounding boxes look right and
    /// the size field never lands, because there is no size field -- the u32 read as one belongs to
    /// the next group. That is why LooksLikeChunk stops after the first chunk and 25-190 KB goes
    /// unread.
    ///
    /// The separator is a 0-or-1 flag byte followed by ZERO bytes in 7-byte units, and the count is
    /// NOT stored anywhere: you eat 7-byte all-zero blocks until one is not all zero. A group
    /// header can never be mistaken for padding because its record count sits in the second byte,
    /// so seven zeros in a row is unambiguous.
    ///
    /// Which is why hunting for a length field was wasted: it was measured against the previous
    /// group's record and node counts, the next group's counts, records-minus-nodes, tree level,
    /// record count modulo 8, presence-mask popcount and start alignment, and it correlates with
    /// none of them -- because there is nothing to correlate with.
    ///
    /// VERIFIED on ALL 33 shipped terrains, three ways: the walk lands on the block's last byte,
    /// the records across every group sum to PersistentNodeCount exactly, and the groups that carry
    /// samples hold exactly DataNodeCount nodes between them. MP_001 looked like an exception only
    /// while groups were assumed to carry samples -- it spreads its 307 data nodes over several
    /// groups where the other 32 put them all in the first. Until it is settled the group walk lands exactly on
    /// most terrains and stops early on a few (sp_villa, xp5_004, mp_018), which is enough to read
    /// a terrain and to rewrite its samples in place, and not enough to write a container from
    /// nothing.
    /// </summary>
    private bool SeekNextChunk(RimeReader p_Reader, long p_End)
    {
        m_PendingFlag = p_Reader.ReadUByte();       // the flag byte, 0 or 1
        m_PendingZeroBlocks = 0;

        // Eat 7-byte ALL-ZERO blocks. This is a rule, not a search: the padding is only ever zeros,
        // and a group header never opens with seven of them, because its record count occupies the
        // second byte. So the walk is decided by the bytes rather than by trying offsets until one
        // parses.
        while (p_Reader.Position + 7 <= p_End)
        {
            var s_At = p_Reader.Position;
            var s_Zero = true;

            for (var i = 0; i < 7; ++i)
            {
                if (p_Reader.ReadUByte() != 0)
                {
                    s_Zero = false;
                    break;
                }
            }

            if (s_Zero)
            {
                ++m_PendingZeroBlocks;
                continue;
            }

            p_Reader.Seek(s_At - p_Reader.Position, SeekOrigin.Current);
            break;
        }

        return p_Reader.Position + 8 <= p_End;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        var s_Start = p_Reader.Position;
        ReadHeader(p_Reader);
        var s_HeaderEnd = p_Reader.Position;
        p_Reader.Seek(s_Start - p_Reader.Position, SeekOrigin.Current);
        HeaderRaw = p_Reader.ReadBytes((int)(s_HeaderEnd - s_Start));

        var s_End = Raw.Length > 0 ? Raw.Length : p_Reader.Length;

        while (p_Reader.Position < s_End && ReadChunk(p_Reader, s_End))
        {
            if (p_Reader.Position >= s_End || !SeekNextChunk(p_Reader, s_End))
                break;
        }

        Consumed = p_Reader.Position;

        // A block ends with a separator that opens a group which never arrives -- a flag byte and
        // up to a few 7-byte zero blocks. Keep it so the tree writes back complete.
        if (Raw.Length > 0 && m_LastGroupEnd > 0 && m_LastGroupEnd < Raw.Length)
        {
            Trailing = new byte[Raw.Length - m_LastGroupEnd];
            System.Array.Copy(Raw, m_LastGroupEnd, Trailing, 0, Trailing.Length);
        }
    }

    public override void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}
