using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.IO;
using RimeLib.Terrain.Frostbite2_0.Frostbite;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>
/// The terrain mask raster tree: which layer covers which part of the ground. Each node holds
/// subtiles, one per layer present in it, each with a coverage grid and, unless full, a tile of
/// mask samples.
/// </summary>
public class TerrainMaskTree : RasterTree
{
    public class Subtile
    {
        public byte TerrainLayerIndex { get; set; }

        /// <summary>World coverage: min x, min z, max x, max z.</summary>
        public float[] WorldCoverage { get; set; } = new float[4];

        public bool IsLeaf { get; set; }

        /// <summary>Fully covered, so no mask samples are stored for it.</summary>
        public bool IsFull { get; set; }

        public byte[] HighResolutionCoverageGridStack { get; set; } = [];

        /// <summary>TileSamplesPerSide² samples, for a subtile of a persistent node that is not full.</summary>
        public byte[] Samples { get; set; } = [];
    }

    public class Node : RasterTreeNode
    {
        public bool HasBeenPruned { get; set; }
        public ushort NonTrivialSubtileCount { get; set; }
        public ushort NonTrivialPersistentSubtileCountRecursive { get; set; }
        public List<Subtile> Subtiles { get; set; } = new();
        public bool Persistent { get; set; }
    }

    public uint TileSamplesPerSide { get; set; }
    public uint TilesPerNodeSide { get; set; }

    public uint FirstValidLevel { get; set; }

    public uint ResourceAtlasSampleCountX { get; set; }
    public uint ResourceAtlasSampleCountY { get; set; }
    public int BlurrinessFactorExponent { get; set; }

    /// <summary>Min x, min z, max x, max z.</summary>
    public float[] TreeCoverage { get; set; } = new float[4];

    public uint NodeCount { get; set; }
    public uint SubtileCount { get; set; }
    public uint PersistentNonTrivialSubtileCount { get; set; }

    public List<Node> Nodes { get; } = new();

    /// <summary>The block as it was read, for measuring a rewrite against.</summary>
    public byte[] Raw { get; set; } = [];

    public override void Deserialize(byte[] p_Data)
    {
        Raw = p_Data;

        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        TileSamplesPerSide = p_Reader.ReadUInt32();
        TilesPerNodeSide = p_Reader.ReadUInt32();
        FirstValidLevel = p_Reader.ReadUInt32();
        ResourceAtlasSampleCountX = p_Reader.ReadUInt32();
        ResourceAtlasSampleCountY = p_Reader.ReadUInt32();
        BlurrinessFactorExponent = p_Reader.ReadInt32();
        for (var i = 0; i < 4; ++i)
            TreeCoverage[i] = p_Reader.ReadSingle();
        NodeCount = p_Reader.ReadUInt32();
        SubtileCount = p_Reader.ReadUInt32();
        PersistentNonTrivialSubtileCount = p_Reader.ReadUInt32();

        Nodes.Clear();
        RootNode = LoadNode(p_Reader, new QuadtreeNodeId());
    }

    private Node LoadNode(RimeReader p_Reader, QuadtreeNodeId p_Id)
    {
        var s_Node = new Node { ID = p_Id };
        Nodes.Add(s_Node);

        s_Node.HasBeenPruned = p_Reader.ReadBool();
        var s_SubtileCount = p_Reader.ReadUInt16();
        s_Node.NonTrivialSubtileCount = p_Reader.ReadUInt16();
        s_Node.NonTrivialPersistentSubtileCountRecursive = p_Reader.ReadUInt16();

        if (s_Node.HasBeenPruned || s_SubtileCount == 0)
            return s_Node;

        for (var i = 0; i < s_SubtileCount; ++i)
        {
            var s_Subtile = new Subtile { TerrainLayerIndex = p_Reader.ReadUByte() };
            for (var j = 0; j < 4; ++j)
                s_Subtile.WorldCoverage[j] = p_Reader.ReadSingle();
            s_Subtile.IsLeaf = p_Reader.ReadBool();
            s_Subtile.IsFull = p_Reader.ReadBool();
            s_Subtile.HighResolutionCoverageGridStack = p_Reader.ReadBytes(p_Reader.ReadUInt16());
            s_Node.Subtiles.Add(s_Subtile);
        }

        s_Node.Persistent = p_Reader.ReadBool();
        if (s_Node.Persistent)
        {
            foreach (var s_Subtile in s_Node.Subtiles)
            {
                if (!s_Subtile.IsFull)
                    s_Subtile.Samples = p_Reader.ReadBytes((int)(TileSamplesPerSide * TileSamplesPerSide));
            }
        }

        if (!p_Reader.ReadBool())
            return s_Node;

        s_Node.Children = new RasterTreeNode[4];
        for (var i = 0; i < 4; ++i)
        {
            var s_ChildId = p_Id.Child(i);
            s_Node.Children[i] = LoadNode(p_Reader, s_ChildId);
        }

        return s_Node;
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(TileSamplesPerSide);
        p_Writer.Write(TilesPerNodeSide);
        p_Writer.Write(FirstValidLevel);
        p_Writer.Write(ResourceAtlasSampleCountX);
        p_Writer.Write(ResourceAtlasSampleCountY);
        p_Writer.Write(BlurrinessFactorExponent);
        foreach (var s_Value in TreeCoverage)
            p_Writer.Write(s_Value);
        p_Writer.Write(NodeCount);
        p_Writer.Write(SubtileCount);
        p_Writer.Write(PersistentNonTrivialSubtileCount);

        if (RootNode is Node s_Root)
            SaveNode(p_Writer, s_Root);

        return true;
    }

    private static void SaveNode(RimeWriter p_Writer, Node p_Node)
    {
        p_Writer.Write(p_Node.HasBeenPruned);
        p_Writer.Write((ushort)p_Node.Subtiles.Count);
        p_Writer.Write(p_Node.NonTrivialSubtileCount);
        p_Writer.Write(p_Node.NonTrivialPersistentSubtileCountRecursive);

        if (p_Node.HasBeenPruned || p_Node.Subtiles.Count == 0)
            return;

        foreach (var s_Subtile in p_Node.Subtiles)
        {
            p_Writer.Write(s_Subtile.TerrainLayerIndex);
            foreach (var s_Value in s_Subtile.WorldCoverage)
                p_Writer.Write(s_Value);
            p_Writer.Write(s_Subtile.IsLeaf);
            p_Writer.Write(s_Subtile.IsFull);
            p_Writer.Write((ushort)s_Subtile.HighResolutionCoverageGridStack.Length);
            p_Writer.Write(s_Subtile.HighResolutionCoverageGridStack);
        }

        p_Writer.Write(p_Node.Persistent);
        if (p_Node.Persistent)
        {
            foreach (var s_Subtile in p_Node.Subtiles)
            {
                if (!s_Subtile.IsFull)
                    p_Writer.Write(s_Subtile.Samples);
            }
        }

        p_Writer.Write(p_Node.Children.Length > 0);
        foreach (var s_Child in p_Node.Children)
            SaveNode(p_Writer, (Node)s_Child);
    }

    public override bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            Serialize(s_Writer);

        p_Data = s_Stream.ToArray();
        return true;
    }
}
