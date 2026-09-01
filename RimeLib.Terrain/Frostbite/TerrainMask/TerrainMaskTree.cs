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

    private void LoadNodes(RimeReader p_Reader, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId,
        AxisAlignedBox2 p_NodeCoverage)
    {
        var s_NodeHasData = p_Reader.ReadBool();
        var s_NodeHasPersistent = p_Reader.ReadBool();

        if (s_NodeHasData && s_NodeHasPersistent)
        {
            var s_RleDataSize = p_Reader.ReadUInt32();
            var s_RleData = p_Reader.ReadBytes((int)s_RleDataSize);

            var s_LineSizes = new ushort[NodeSamplesPerSide];

            for (var i = 0; i < NodeSamplesPerSide; ++i)
                s_LineSizes[i] = p_Reader.ReadUInt16();

            Nodes.Add(new TerrainMaskNode
            {
                Level = p_NodeId.Level,
                IndexX = p_NodeId.IndexX,
                IndexY = p_NodeId.IndexY,
                MinX = p_NodeCoverage.min.x,
                MinY = p_NodeCoverage.min.y,
                MaxX = p_NodeCoverage.max.x,
                MaxY = p_NodeCoverage.max.y,
                RleData = s_RleData,
                LineSizes = s_LineSizes
            });
        }

        var s_HasChildren = p_Reader.ReadBool();

        if (!s_HasChildren)
            return;

        p_FirstFreeNodeIndex += 4;

        var s_ChildNodeWidth = (float)((p_NodeCoverage.max.x - p_NodeCoverage.min.x) * 0.5);

        for (var i = 0; i < 4; i++)
        {
            var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
            ++s_ChildNodeId.Level;

            s_ChildNodeId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] + 2 * s_ChildNodeId.IndexX);
            s_ChildNodeId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] + 2 * s_ChildNodeId.IndexY);

            var s_ChildCoverage = new AxisAlignedBox();

            s_ChildCoverage.min = new Vec3
            {
                x = QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] * s_ChildNodeWidth + p_NodeCoverage.min.x,
                y = QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] * s_ChildNodeWidth + p_NodeCoverage.min.y,
            };

            s_ChildCoverage.max = new Vec3
            {
                x = s_ChildCoverage.min.x + s_ChildNodeWidth,
                y = s_ChildCoverage.min.y + s_ChildNodeWidth
            };

            LoadNodes(p_Reader, ref p_FirstFreeNodeIndex, s_ChildNodeId, s_ChildCoverage);
        }
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
        NodeSamplesPerSide = p_Reader.ReadUInt32();

        var s_Blurriness = p_Reader.ReadInt32();
        BlurrinessFactor = (uint)(1 << s_Blurriness);

        var s_TreeCoverage = new AxisAlignedBox();
        s_TreeCoverage.DeserializeVec2(p_Reader);

        NodeCount = p_Reader.ReadUInt32();
        PersistentNodeCount = p_Reader.ReadUInt32();
        LevelMax = p_Reader.ReadUInt32();

        CoverageMin = new Vec2
        {
            x = s_TreeCoverage.min.x,
            y = s_TreeCoverage.min.y
        };

        NodeGridCellsPerSide = (uint)(1 << (int)LevelMax);

        var s_RootNodeId = new QuadtreeNodeId
        {
            Level = 0,
            IndexX = 0,
            IndexY = 0
        };

        uint s_FirstFreeNodeIndex = 1;
        LoadNodes(p_Reader, ref s_FirstFreeNodeIndex, s_RootNodeId, s_TreeCoverage);
        Consumed = p_Reader.Position;
    }

    public override void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}
