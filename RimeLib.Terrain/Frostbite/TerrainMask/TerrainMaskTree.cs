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
        p_Reader.ReadUInt32();

        if (s_RecordCount == 0 || p_Reader.Position + s_RecordCount * 32 + 4 > p_End)
            return false;

        var s_Records = new List<TerrainMaskNode>();

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
        var s_DataSize = p_Reader.ReadUInt32();

        if (s_DataSize != s_NodeCount * s_SampleBytes || p_Reader.Position + s_DataSize > p_End)
            return false;

        // The leading records are the containers the tree descends through -- four of them, one
        // per root quadrant, on every level measured bar one. The trailing records are the ones
        // that own samples, in the order the blocks follow.
        var s_First = s_Records.Count - s_NodeCount;

        for (var i = 0; i < s_NodeCount; ++i)
        {
            var s_Node = s_Records[s_First + i];
            s_Node.SampleOffset = p_Reader.Position;
            s_Node.Samples = p_Reader.ReadBytes((int)s_SampleBytes);
            Nodes.Add(s_Node);
        }

        return true;
    }

    /// <summary>
    /// Write the tree back: the block as it was read, with each node's CURRENT samples in place.
    ///
    /// This edits rather than rebuilds, and that is deliberate. A node's sample block is a fixed
    /// NodeSamplesPerSide^2 bytes, so replacing one moves nothing after it and every offset, count
    /// and padding run in the container stays valid -- including the inter-chunk padding, which
    /// comes in 7-byte units the reader has to probe for and which nothing here can currently
    /// reproduce from scratch. Rebuilding the container would mean inventing that layout; editing
    /// in place does not.
    ///
    /// An untouched tree therefore serialises to the bytes it was read from, exactly.
    /// </summary>
    public override bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;

        if (Raw.Length == 0)
            return false;

        var s_Out = (byte[])Raw.Clone();

        foreach (var s_Node in Nodes)
        {
            if (s_Node.SampleOffset < 0 || s_Node.Samples.Length == 0)
                continue;

            if (s_Node.SampleOffset + s_Node.Samples.Length > s_Out.Length)
                return false;

            System.Array.Copy(s_Node.Samples, 0, s_Out, s_Node.SampleOffset,
                s_Node.Samples.Length);
        }

        p_Data = s_Out;
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
    /// The 7-byte step is a PROBE, not the format. Measured across all 33 shipped terrains the gap
    /// is 1 + 7k bytes for k from 0 to 34, and a strict 1-byte gap fails on the second chunk of
    /// every one of them -- so the gap carries real content this does not model. Probing finds 1039
    /// mask nodes where assuming a fixed gap finds 761, which is why it stays.
    ///
    /// It also means the walk stops early: 25 KB to 190 KB of each block is left unparsed. Enough
    /// for reading and for rewriting samples in place, NOT enough to build a container from
    /// nothing. Whatever lives in those gaps is the thing to decode next.
    /// </summary>
    private bool SeekNextChunk(RimeReader p_Reader, long p_End)
    {
        p_Reader.ReadUByte();

        for (var i = 0; i < 8; ++i)
        {
            if (LooksLikeChunk(p_Reader, p_End))
                return true;

            p_Reader.Seek(7, SeekOrigin.Current);
        }

        return false;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        ReadHeader(p_Reader);

        var s_End = Raw.Length > 0 ? Raw.Length : p_Reader.Length;

        while (p_Reader.Position < s_End && ReadChunk(p_Reader, s_End))
        {
            if (p_Reader.Position >= s_End || !SeekNextChunk(p_Reader, s_End))
                break;
        }

        Consumed = p_Reader.Position;
    }

    public override void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}
