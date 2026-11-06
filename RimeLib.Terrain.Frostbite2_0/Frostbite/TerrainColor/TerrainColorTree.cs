using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite2_0.Frostbite.TerrainColor;

/// <summary>
/// The terrain colour raster tree: a tint over the ground, a DXT1 tile of colour samples per node.
/// A persistent node keeps its tile in the tree, after its flags; the others stream theirs.
/// </summary>
public class TerrainColorTree : RasterTree
{
    public class Node : RasterTreeNode
    {
        public bool HasBeenPruned { get; set; }
        public bool HasData { get; set; }
        public bool HasPersistent { get; set; }

        /// <summary>The DXT1 tile, for a persistent node with data.</summary>
        public byte[] Samples { get; set; } = [];
    }

    /// <summary>The atlas texture format of DXT1 tiles, the only one the tree is read with.</summary>
    public const uint Dxt1Format = 0;

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

    /// <summary>The bytes of a node's tile: 8 per 4x4 block.</summary>
    public int TileSize => (int)((NodeSamplesPerSide + 3) / 4 * ((NodeSamplesPerSide + 3) / 4) * 8);

    /// <summary>Whether a node neither pruned nor with data ends after those two flags.</summary>
    protected virtual bool EmptyNodeEnds => false;

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

    private Node LoadNode(RimeReader p_Reader, QuadtreeNodeId p_Id)
    {
        var s_Node = new Node
        {
            ID = p_Id,
            HasBeenPruned = p_Reader.ReadBool(),
            HasData = p_Reader.ReadBool(),
        };

        if (EmptyNodeEnds && !s_Node.HasBeenPruned && !s_Node.HasData)
            return s_Node;

        s_Node.HasPersistent = p_Reader.ReadBool();
        if (s_Node.HasData && s_Node.HasPersistent)
        {
            if (AtlasTextureFormat != Dxt1Format)
                throw new InvalidDataException($"The colour tree keeps tiles of format {AtlasTextureFormat}, whose size is unknown.");
            s_Node.Samples = p_Reader.ReadBytes(TileSize);
        }

        if (!p_Reader.ReadBool())
            return s_Node;

        s_Node.Children = new RasterTreeNode[4];
        for (var i = 0; i < 4; ++i)
            s_Node.Children[i] = LoadNode(p_Reader, p_Id.Child(i));

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

    private void SaveNode(RimeWriter p_Writer, Node p_Node)
    {
        p_Writer.Write(p_Node.HasBeenPruned);
        p_Writer.Write(p_Node.HasData);
        if (EmptyNodeEnds && !p_Node.HasBeenPruned && !p_Node.HasData)
            return;

        p_Writer.Write(p_Node.HasPersistent);
        if (p_Node.HasData && p_Node.HasPersistent)
            p_Writer.Write(p_Node.Samples);

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
