using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.IO;
using RimeLib.Terrain.Frostbite2_0.Frostbite;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>
/// The terrain colour raster tree. Retail BF4 terrains ship only its node structure: no node is
/// both data-carrying and persistent, so the layout of colour samples is unknown and a tree that
/// has them is refused rather than misread.
/// </summary>
public class TerrainColorTree : RasterTree
{
    public class Node : RasterTreeNode
    {
        public bool HasBeenPruned { get; set; }
        public bool HasData { get; set; }
        public bool HasPersistent { get; set; }
    }

    public uint NodeSamplesPerSide { get; set; }
    public uint TileBorderWidth { get; set; }
    public uint ResourceAtlasSampleCountX { get; set; }
    public uint ResourceAtlasSampleCountY { get; set; }
    public int BlurrinessFactorExponent { get; set; }

    /// <summary>Min x, min z, max x, max z.</summary>
    public float[] TreeCoverage { get; set; } = new float[4];

    public uint AtlasTextureFormat { get; set; }
    public uint SourceTexturesChannelCount { get; set; }
    public uint NodeCount { get; set; }
    public uint PersistentNodeCount { get; set; }

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
        NodeSamplesPerSide = p_Reader.ReadUInt32();
        TileBorderWidth = p_Reader.ReadUInt32();
        ResourceAtlasSampleCountX = p_Reader.ReadUInt32();
        ResourceAtlasSampleCountY = p_Reader.ReadUInt32();
        BlurrinessFactorExponent = p_Reader.ReadInt32();
        for (var i = 0; i < 4; ++i)
            TreeCoverage[i] = p_Reader.ReadSingle();
        AtlasTextureFormat = p_Reader.ReadUInt32();
        SourceTexturesChannelCount = p_Reader.ReadUInt32();
        NodeCount = p_Reader.ReadUInt32();
        PersistentNodeCount = p_Reader.ReadUInt32();

        RootNode = LoadNode(p_Reader, new QuadtreeNodeId());
    }

    private static Node LoadNode(RimeReader p_Reader, QuadtreeNodeId p_Id)
    {
        var s_Node = new Node
        {
            ID = p_Id,
            HasBeenPruned = p_Reader.ReadBool(),
            HasData = p_Reader.ReadBool(),
        };

        // As in the heightfield: a node with neither flag ends here.
        if (!s_Node.HasBeenPruned && !s_Node.HasData)
            return s_Node;

        s_Node.HasPersistent = p_Reader.ReadBool();
        if (s_Node.HasData && s_Node.HasPersistent)
            throw new InvalidDataException("The colour tree has a persistent node with data, whose layout is unknown.");

        if (!p_Reader.ReadBool())
            return s_Node;

        s_Node.Children = new RasterTreeNode[4];
        for (var i = 0; i < 4; ++i)
        {
            var s_ChildId = new QuadtreeNodeId(p_Id);
            ++s_ChildId.Level;
            s_ChildId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] + 2 * p_Id.IndexX);
            s_ChildId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] + 2 * p_Id.IndexY);
            s_Node.Children[i] = LoadNode(p_Reader, s_ChildId);
        }

        return s_Node;
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(NodeSamplesPerSide);
        p_Writer.Write(TileBorderWidth);
        p_Writer.Write(ResourceAtlasSampleCountX);
        p_Writer.Write(ResourceAtlasSampleCountY);
        p_Writer.Write(BlurrinessFactorExponent);
        foreach (var s_Value in TreeCoverage)
            p_Writer.Write(s_Value);
        p_Writer.Write(AtlasTextureFormat);
        p_Writer.Write(SourceTexturesChannelCount);
        p_Writer.Write(NodeCount);
        p_Writer.Write(PersistentNodeCount);

        if (RootNode is Node s_Root)
            SaveNode(p_Writer, s_Root);

        return true;
    }

    private static void SaveNode(RimeWriter p_Writer, Node p_Node)
    {
        p_Writer.Write(p_Node.HasBeenPruned);
        p_Writer.Write(p_Node.HasData);
        if (!p_Node.HasBeenPruned && !p_Node.HasData)
            return;

        p_Writer.Write(p_Node.HasPersistent);
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
