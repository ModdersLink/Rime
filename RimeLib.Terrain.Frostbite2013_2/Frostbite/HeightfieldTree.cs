using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.IO;
using RimeLib.Terrain.Frostbite;
using RimeLib.Terrain.Frostbite.Heightfield;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>
/// The heightfield raster tree. Compared with Frostbite 2 the header adds the density map settings
/// and the skipped node count, the second physics value is an integer, every node that is not disabled carries all four flags, a pruned node keeps a
/// min/max stack, and a node's data ends with its density map.
/// </summary>
public class HeightfieldTree : HeightfieldTreeBase
{
    public uint SkippedNodeCount { get; set; }

    public int PhysicsAdditionalLevelCount { get; set; }

    public uint DensityMapSize => DensityMapNodeSamplesPerSide * DensityMapNodeSamplesPerSide;

    public override void Deserialize(byte[] p_Data)
    {
        Raw = p_Data;

        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        NodeSamplesPerSide = p_Reader.ReadUInt32();
        ResourceAtlasSampleCountX = p_Reader.ReadUInt32();
        ResourceAtlasSampleCountY = p_Reader.ReadUInt32();
        ResourceBlurrinessFactorExponent = p_Reader.ReadInt32();
        ResourceBlurrinessFactor = (uint)(1 << ResourceBlurrinessFactorExponent);
        WorldSizeY = p_Reader.ReadSingle();
        WorldScaleY = WorldSizeY / 65535.0f;
        PhysicsMetersPerSample = p_Reader.ReadSingle();
        PhysicsAdditionalLevelCount = p_Reader.ReadInt32();
        Ps3RsxHeightfieldEnable = p_Reader.ReadBool();
        Ps3RsxHeightfieldCacheFraction = p_Reader.ReadSingle();
        MinMaxStackDepth = p_Reader.ReadUInt32();
        OccluderGridStackDepth = p_Reader.ReadUInt32();
        DensityMapNodeSamplesPerSide = p_Reader.ReadUInt32();
        DensityMapBorderWidth = p_Reader.ReadUInt32();
        DensityMapNodeSamplesPerSidePot = p_Reader.ReadUInt32();
        DensityMapResolutionRatio = p_Reader.ReadSingle();
        NodeCount = p_Reader.ReadUInt32();
        PersistentNodeCount = p_Reader.ReadUInt32();
        PersistentDedicatedServerNodeCount = p_Reader.ReadUInt32();
        SkippedNodeCount = p_Reader.ReadUInt32();
        NodeBorderWidth = p_Reader.ReadUInt32();

        MinMaxStackSize = 0;
        for (var i = 0; i < MinMaxStackDepth; ++i)
        {
            var s_Side = (1u << ((int)MinMaxStackDepth - 1)) >> i;
            MinMaxStackSize += 2 * s_Side * s_Side;
        }

        OccluderGridStackSize = 0;
        for (var i = 0; i < OccluderGridStackDepth; ++i)
        {
            var s_Side = ((1u << ((int)OccluderGridStackDepth - 1)) >> i) + 1;
            OccluderGridStackSize += s_Side * s_Side;
        }

        uint s_FirstIndex = 1;
        RootNode = LoadNodes(p_Reader, ref s_FirstIndex, new QuadtreeNodeId());

        if (p_Reader.Length > p_Reader.Position)
            Trailing = p_Reader.ReadBytes((int)(p_Reader.Length - p_Reader.Position));
    }

    private HeightfieldTreeNode LoadNodes(RimeReader p_Reader, ref uint p_FirstFreeNodeIndex, QuadtreeNodeId p_NodeId)
    {
        var s_Node = new HeightfieldTreeNode(p_Reader) { ID = p_NodeId };
        LevelMax = System.Math.Max(p_NodeId.Level, LevelMax);

        s_Node.Disabled = p_Reader.ReadBool();
        if (s_Node.Disabled)
        {
            s_Node.Flags |= (ushort)RasterTreeNodeFlags.Disabled;
            return s_Node;
        }

        s_Node.HasBeenPruned = p_Reader.ReadBool();
        s_Node.HasData = p_Reader.ReadBool();
        s_Node.PartialNonPhysics = p_Reader.ReadBool();
        s_Node.HasPersistent = p_Reader.ReadBool();

        if (s_Node.HasData)
            s_Node.Flags |= (ushort)RasterTreeNodeFlags.CanBeStreamedIn;
        else if (s_Node.HasBeenPruned)
            s_Node.Flags |= (ushort)RasterTreeNodeFlags.Pruned;

        if (s_Node.HasBeenPruned)
            s_Node.PrunedMinMaxData = p_Reader.ReadBytes((int)(MinMaxStackSize * 2));

        if (s_Node.HasData && s_Node.HasPersistent)
        {
            s_Node.EmbeddedData = p_Reader.ReadBytes((int)(NodeSamplesPerSide * NodeSamplesPerSide * 2));
            s_Node.MinMaxData = p_Reader.ReadBytes((int)(MinMaxStackSize * 2));
            s_Node.OccluderGridData = p_Reader.ReadBytes((int)(OccluderGridStackSize * 2));
            s_Node.DensityMapData = p_Reader.ReadBytes((int)DensityMapSize);
        }

        if (!p_Reader.ReadBool())
            return s_Node;

        s_Node.Children = new RasterTreeNode[4];
        s_Node.FirstChildIndex = (ushort)p_FirstFreeNodeIndex;
        p_FirstFreeNodeIndex += 4;

        for (var i = 0; i < 4; ++i)
        {
            var s_ChildId = new QuadtreeNodeId(p_NodeId);
            ++s_ChildId.Level;
            s_ChildId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] + 2 * p_NodeId.IndexX);
            s_ChildId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] + 2 * p_NodeId.IndexY);
            s_Node.Children[i] = LoadNodes(p_Reader, ref p_FirstFreeNodeIndex, s_ChildId);
        }

        return s_Node;
    }

    /// <summary>The heightfield node for an id, or null where the tree has none.</summary>
    public HeightfieldTreeNode? TryFindNode(QuadtreeNodeId p_Id) => HeightfieldRootNode == null ? null : Find(HeightfieldRootNode, p_Id);

    private static HeightfieldTreeNode? Find(HeightfieldTreeNode p_Node, QuadtreeNodeId p_Id)
    {
        if (p_Node.ID.Level == p_Id.Level && p_Node.ID.IndexX == p_Id.IndexX && p_Node.ID.IndexY == p_Id.IndexY)
            return p_Node;

        foreach (var s_Child in p_Node.Children)
        {
            if (s_Child is HeightfieldTreeNode s_Node && Find(s_Node, p_Id) is { } s_Found)
                return s_Found;
        }

        return null;
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(NodeSamplesPerSide);
        p_Writer.Write(ResourceAtlasSampleCountX);
        p_Writer.Write(ResourceAtlasSampleCountY);
        p_Writer.Write(ResourceBlurrinessFactorExponent);
        p_Writer.Write(WorldSizeY);
        p_Writer.Write(PhysicsMetersPerSample);
        p_Writer.Write(PhysicsAdditionalLevelCount);
        p_Writer.Write(Ps3RsxHeightfieldEnable);
        p_Writer.Write(Ps3RsxHeightfieldCacheFraction);
        p_Writer.Write(MinMaxStackDepth);
        p_Writer.Write(OccluderGridStackDepth);
        p_Writer.Write(DensityMapNodeSamplesPerSide);
        p_Writer.Write(DensityMapBorderWidth);
        p_Writer.Write(DensityMapNodeSamplesPerSidePot);
        p_Writer.Write(DensityMapResolutionRatio);
        p_Writer.Write(NodeCount);
        p_Writer.Write(PersistentNodeCount);
        p_Writer.Write(PersistentDedicatedServerNodeCount);
        p_Writer.Write(SkippedNodeCount);
        p_Writer.Write(NodeBorderWidth);

        if (RootNode is HeightfieldTreeNode s_Root)
            SaveNodes(p_Writer, s_Root);

        p_Writer.Write(Trailing);
        return true;
    }

    private static void SaveNodes(RimeWriter p_Writer, HeightfieldTreeNode p_Node)
    {
        p_Writer.Write(p_Node.BoundingBox.min.x);
        p_Writer.Write(p_Node.BoundingBox.min.y);
        p_Writer.Write(p_Node.BoundingBox.min.z);
        p_Writer.Write(p_Node.BoundingBox.max.x);
        p_Writer.Write(p_Node.BoundingBox.max.y);
        p_Writer.Write(p_Node.BoundingBox.max.z);

        p_Writer.Write(p_Node.Disabled);
        if (p_Node.Disabled)
            return;

        p_Writer.Write(p_Node.HasBeenPruned);
        p_Writer.Write(p_Node.HasData);
        p_Writer.Write(p_Node.PartialNonPhysics);
        p_Writer.Write(p_Node.HasPersistent);

        if (p_Node.HasBeenPruned)
            p_Writer.Write(p_Node.PrunedMinMaxData);

        if (p_Node.HasData && p_Node.HasPersistent)
        {
            p_Writer.Write(p_Node.EmbeddedData);
            p_Writer.Write(p_Node.MinMaxData);
            p_Writer.Write(p_Node.OccluderGridData);
            p_Writer.Write(p_Node.DensityMapData);
        }

        var s_HasChildren = p_Node.Children.Length > 0;
        p_Writer.Write(s_HasChildren);

        foreach (var s_Child in p_Node.Children)
            SaveNodes(p_Writer, (HeightfieldTreeNode)s_Child);
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
