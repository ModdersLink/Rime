using fb;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Serialization.Frostbite2_0.Extensions;
using AxisAlignedBox2 = fb.AxisAlignedBox;

namespace RimeLib.Terrain.Frostbite.TerrainMaterial;
public class TerrainMaterialTree : RasterTree
{
    public uint NodeSamplesPerSide { get; set; }
    public uint BlurrinessFactor { get; set; }
    public uint NodeCount { get; set; }
    public uint PersistentNodeCount { get; set; }
    public uint LevelMax { get; set; }
    public List<uint> MaterialPairIndices { get; set; } = new List<uint>();
    public uint BackgroundMaterialIndex { get; set; }

    /// <summary>Every node that carries material samples, in tree order.</summary>
    public List<TerrainMaterialNode> Nodes { get; } = new List<TerrainMaterialNode>();

    /// <summary>
    /// The tree itself, which <see cref="Nodes"/> is only the fruit of.
    ///
    /// A flat list of the nodes that carry samples cannot be written back: the file is a shape, and
    /// which nodes were empty and which had children is exactly the part a list of the non-empty
    /// ones throws away. Reading builds both -- the list for callers that want the samples, this
    /// for anyone who has to put the tree back.
    /// </summary>
    public MaterialTreeEntry? Root { get; set; }

    /// <summary>The tree coverage box, as read. The node boxes are derived from it.</summary>
    public AxisAlignedBox2 TreeCoverage { get; set; } = new AxisAlignedBox2();

    /// <summary>The shift <see cref="BlurrinessFactor"/> was decoded from.</summary>
    public int BlurrinessFactorExponent { get; set; }

    /// <summary>The block as it was read, for measuring a rewrite against.</summary>
    public byte[] Raw { get; set; } = Array.Empty<byte>();

    /// <summary>One visited node: the three flags that shape the file, and what hung off it.</summary>
    public class MaterialTreeEntry
    {
        public bool HasData { get; set; }
        public bool HasPersistent { get; set; }

        /// <summary>The samples, where this node carried any.</summary>
        public TerrainMaterialNode? Node { get; set; }

        /// <summary>Four children, or none.</summary>
        public List<MaterialTreeEntry>? Children { get; set; }
    }

    public Vec2 CoverageMin { get; set; } = new Vec2();
    public uint NodeGridCellsPerSide { get; set; }
    public float VirtualSamplesPerMeter { get; set; }
    public uint VirtualRasterSampleIndexMax { get; set; }

    private MaterialTreeEntry LoadNodes(RimeReader p_Reader, uint p_NodeIndex, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId, AxisAlignedBox2 p_NodeCoverage)
    {
        var s_NodeHasData = p_Reader.ReadBool();
        var s_NodeHasPersistent = p_Reader.ReadBool();

        var s_Entry = new MaterialTreeEntry
        {
            HasData = s_NodeHasData,
            HasPersistent = s_NodeHasPersistent
        };


        if (s_NodeHasData && s_NodeHasPersistent)
        {
            // The samples are run-length encoded, one run of lines per node, with the length of
            // each line following the payload. Kept rather than skipped: this is the only record
            // of which material covers which part of the terrain.
            var s_RleDataSize = p_Reader.ReadUInt32();
            var s_RleData = p_Reader.ReadBytes((int)s_RleDataSize);

            var s_LineSizes = new ushort[NodeSamplesPerSide];

            for (var i = 0; i < NodeSamplesPerSide; ++i)
                s_LineSizes[i] = p_Reader.ReadUInt16();

            var s_MaterialNode = new TerrainMaterialNode
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
            };

            Nodes.Add(s_MaterialNode);
            s_Entry.Node = s_MaterialNode;
        }

        var s_HasChildren = p_Reader.ReadBool();
        if (s_HasChildren)
        {
            // s_Node.m_FirstChildIndex = p_FirstFreeNodeIndex;
            var s_FirstChildIndex = p_FirstFreeNodeIndex;
            p_FirstFreeNodeIndex += 4;

            s_Entry.Children = new List<MaterialTreeEntry>(4);

            
            float s_ChildNodeWidth = (float)((p_NodeCoverage.max.x - p_NodeCoverage.min.x) * 0.5);

            for(var i=0; i < 4; i++)
            {
                var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
                ++s_ChildNodeId.Level;

                s_ChildNodeId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] + 2 * s_ChildNodeId.IndexX);
                s_ChildNodeId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] + 2 * s_ChildNodeId.IndexY);

                
                var s_ChildCoverage = new AxisAlignedBox();

                // TODO: Verify these are correct.
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

                s_Entry.Children.Add(LoadNodes(p_Reader, (uint)(i + s_FirstChildIndex),
                    ref p_FirstFreeNodeIndex, s_ChildNodeId, s_ChildCoverage));
            }
            
            // var s_V14 = 0;
            //float s_ChildNodeWidth = (float)((p_NodeCoverage.Min.Y - p_NodeCoverage.Min.X) * 0.5);

            //do
            //{
            //    var s_ChildNodeId = new QuadtreeNodeId(p_NodeId);
            //    ++s_ChildNodeId.Level;

            //    s_ChildNodeId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[s_V14] + 2 * s_ChildNodeId.IndexX);
            //    s_ChildNodeId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[s_V14] + 2 * s_ChildNodeId.IndexY);

            //    var s_ChildCoverage = new AxisAlignedBox2();

            //    // TODO: Verify these are correct.
            //    s_ChildCoverage.Min = new Vec2(
            //            QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[s_V14] * s_ChildNodeWidth + p_NodeCoverage.Min.X,
            //            QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[s_V14] * s_ChildNodeWidth + p_NodeCoverage.Min.Y);

            //    s_ChildCoverage.Max = new Vec2(
            //        s_ChildCoverage.Min.X + s_ChildNodeWidth,
            //        s_ChildCoverage.Min.Y + s_ChildNodeWidth);

            //    LoadNodes(p_Reader, (uint)(s_V14 + s_FirstChildIndex), ref p_FirstFreeNodeIndex, s_ChildNodeId, s_ChildCoverage);
            //    ++s_V14;
            //} while (s_V14 < 4);
        }

        return s_Entry;
    }

    /// <summary>The exact inverse of <see cref="Deserialize(RimeReader)"/>.</summary>
    public override bool Serialize(RimeWriter p_Writer)
    {
        if (Root == null)
            return false;

        p_Writer.Write(NodeSamplesPerSide);
        p_Writer.Write(BlurrinessFactorExponent);

        p_Writer.Write(TreeCoverage.min.x);
        p_Writer.Write(TreeCoverage.min.y);
        p_Writer.Write(TreeCoverage.max.x);
        p_Writer.Write(TreeCoverage.max.y);

        p_Writer.Write(NodeCount);
        p_Writer.Write(PersistentNodeCount);
        p_Writer.Write(LevelMax);

        SaveNodes(p_Writer, Root);

        p_Writer.Write((uint) MaterialPairIndices.Count);

        foreach (var s_Index in MaterialPairIndices)
            p_Writer.Write(s_Index);

        p_Writer.Write(BackgroundMaterialIndex);

        return true;
    }

    private static void SaveNodes(RimeWriter p_Writer, MaterialTreeEntry p_Entry)
    {
        p_Writer.Write(p_Entry.HasData);
        p_Writer.Write(p_Entry.HasPersistent);

        if (p_Entry.HasData && p_Entry.HasPersistent && p_Entry.Node != null)
        {
            p_Writer.Write((uint) p_Entry.Node.RleData.Length);
            p_Writer.Write(p_Entry.Node.RleData);

            foreach (var s_LineSize in p_Entry.Node.LineSizes)
                p_Writer.Write(s_LineSize);
        }

        p_Writer.Write(p_Entry.Children != null);

        if (p_Entry.Children == null)
            return;

        foreach (var s_Child in p_Entry.Children)
            SaveNodes(p_Writer, s_Child);
    }

    public override bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        if (Serialize(s_Writer))
        {
            p_Data = s_Stream.ToArray();
            return true;
        }

        p_Data = null;
        return false;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        NodeSamplesPerSide = p_Reader.ReadUInt32();

        BlurrinessFactorExponent = p_Reader.ReadInt32();
        BlurrinessFactor = (uint)(1 << BlurrinessFactorExponent);
        if (BlurrinessFactor != 1)
            throw new InvalidDataException("Blurrinessfactor must be 1");

        var s_TreeCoverage = new AxisAlignedBox();
        s_TreeCoverage.DeserializeVec2(p_Reader);
        TreeCoverage = s_TreeCoverage;

        NodeCount = p_Reader.ReadUInt32();
        if (NodeCount >= 10000)
            throw new InvalidDataException("Nodecount exceeds 10000");

        PersistentNodeCount = p_Reader.ReadUInt32();
        LevelMax = p_Reader.ReadUInt32();

        CoverageMin = new Vec2 
        { 
            x = s_TreeCoverage.min.x,
            y = s_TreeCoverage.min.y
        };
        NodeGridCellsPerSide = (uint)(1 << (int)LevelMax);
        VirtualSamplesPerMeter = ((float)NodeGridCellsPerSide * (float)NodeSamplesPerSide) /
                                 (s_TreeCoverage.max.x - s_TreeCoverage.max.y);
        VirtualRasterSampleIndexMax = (NodeGridCellsPerSide * NodeSamplesPerSide) - 1;

        var s_RootNodeId = new QuadtreeNodeId
        {
            Level = 0,
            IndexX = 0,
            IndexY = 0
        };

        uint s_FirstFreeNodeIndex = 1; // TODO: This is 1 in ida??
        Root = LoadNodes(p_Reader, 0, ref s_FirstFreeNodeIndex, s_RootNodeId, s_TreeCoverage);

        var s_MaterialPairCount = p_Reader.ReadUInt32();

        MaterialPairIndices = new List<uint>();
        for (var i = 0; i < s_MaterialPairCount; ++i)
            MaterialPairIndices.Add(p_Reader.ReadUInt32());

        BackgroundMaterialIndex = p_Reader.ReadUInt32();
    }

    public override void Deserialize(byte[] p_Data)
    {
        Raw = p_Data;

        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}

