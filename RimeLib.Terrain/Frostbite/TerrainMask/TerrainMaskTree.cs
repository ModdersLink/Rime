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

    public uint UnknownA { get; set; }
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
            s_Node.Samples = p_Reader.ReadBytes((int)s_SampleBytes);
            Nodes.Add(s_Node);
        }

        return true;
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }

    public override bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;
        throw new System.NotImplementedException();
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        // The header is 48 bytes, not 36: three fields sit between the blurriness and the coverage
        // box that were not being read, which put coverage at the wrong offset and turned every
        // field after it into garbage -- a node count of 3.2 billion, and a sample length that ran
        // off the end of the stream and took the whole terrain read down with it.
        NodeSamplesPerSide = p_Reader.ReadUInt32();

        var s_Blurriness = p_Reader.ReadInt32();
        BlurrinessFactor = (uint)(1 << s_Blurriness);

        // The mask raster's own resolution, which is not the terrain's: MP_001 covers 1 km at 2048
        // samples (0.5 m each) where the 4 km sp_bank uses 1024 (4 m each). Bigger map, coarser
        // mask.
        RasterSamplesPerSide = p_Reader.ReadUInt32();
        UnknownA = p_Reader.ReadUInt32();
        UnknownB = p_Reader.ReadUInt32();

        var s_TreeCoverage = new AxisAlignedBox();
        s_TreeCoverage.DeserializeVec2(p_Reader);

        NodeCount = p_Reader.ReadUInt32();
        PersistentNodeCount = p_Reader.ReadUInt32();
        DataNodeCount = p_Reader.ReadUInt32();

        CoverageMin = new Vec2
        {
            x = s_TreeCoverage.min.x,
            y = s_TreeCoverage.min.y
        };

        var s_CellsPerSide = NodeSamplesPerSide > 2
            ? RasterSamplesPerSide / (NodeSamplesPerSide - 2)
            : 1;

        NodeGridCellsPerSide = s_CellsPerSide == 0 ? 1 : s_CellsPerSide;
        LevelMax = 0;

        for (var s_Cells = NodeGridCellsPerSide; s_Cells > 1; s_Cells >>= 1)
            ++LevelMax;

        var s_End = Raw.Length > 0 ? Raw.Length : p_Reader.Length;

        // Chunks run until one does not check out. Every level measured carries all DataNodeCount
        // of its nodes in the first, bar MP_001, which continues into further chunks this does not
        // yet follow -- so stopping is a partial read, not a failure, and the nodes already taken
        // are good.
        while (p_Reader.Position < s_End && ReadChunk(p_Reader, s_End))
        {
            if (p_Reader.Position >= s_End || p_Reader.ReadUByte() != 1)
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
