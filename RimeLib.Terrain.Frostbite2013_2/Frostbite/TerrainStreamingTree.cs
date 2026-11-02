using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Terrain.Frostbite2_0.Frostbite;
using RimeLib.Terrain.Frostbite2_0.Frostbite.Destruction;
using RimeLib.Terrain.Frostbite2_0.Frostbite.Heightfield;
using RimeLib.Terrain.Frostbite2_0.Frostbite.TerrainMaterial;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>
/// A terrain streaming tree: a header, the raster trees (each a type byte and a length, 0xFF ends
/// the list), then the streaming quadtree whose nodes name the chunks holding their tile data.
/// Frostbite 2's layout with the skip level count before the node count. The material and
/// destruction depth trees are Frostbite 2's; the heightfield, mask and colour trees are this
/// engine's own.
/// </summary>
public class TerrainStreamingTree : TerrainStreamingTreeBase, IFbSerializable
{
    public uint SkipLevels { get; set; }

    public new HeightfieldTree? HeightfieldTree => RasterTrees[(int)RasterTree.RasterTreeTypes.HeightfieldTreeType] as HeightfieldTree;

    public void Deserialize(byte[] p_Data)
    {
        Raw = p_Data;

        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        UnblurredSamplesPerNodeSidePot = p_Reader.ReadUInt32();
        TrackTextureDetailFalloff = p_Reader.ReadBool();
        InvisibleDetailReductionFactor = p_Reader.ReadSingle();
        OccludedDetailReductionFactor = p_Reader.ReadSingle();
        ResourceBlurriness = p_Reader.ReadUInt32();
        SkipLevels = p_Reader.ReadUInt32();
        NodeCount = p_Reader.ReadUInt32();
        FreeStreamingEnabled = p_Reader.ReadBool();

        RasterTrees = new List<RasterTree>();
        for (var i = 0; i < (int)RasterTree.RasterTreeTypes.RasterTreeTypeCount; ++i)
            RasterTrees.Add(null!);
        RasterTreeOrder.Clear();

        while (true)
        {
            var s_Type = p_Reader.ReadUByte();
            if (s_Type == (byte)RasterTree.RasterTreeTypes.RasterTreeTypeInvalid)
                break;

            var s_Size = p_Reader.ReadUInt32();
            if (s_Size > p_Reader.Length - p_Reader.Position)
                throw new InvalidDataException($"Raster tree {s_Type} of {s_Size} byte(s) overruns the streaming tree.");

            var s_Bytes = p_Reader.ReadBytes((int)s_Size);
            RasterTree? s_Tree = (RasterTree.RasterTreeTypes)s_Type switch
            {
                RasterTree.RasterTreeTypes.HeightfieldTreeType => new HeightfieldTree(),
                RasterTree.RasterTreeTypes.TerrainMaskTreeType => new TerrainMaskTree(),
                RasterTree.RasterTreeTypes.TerrainColorTreeType => new TerrainColorTree(),
                RasterTree.RasterTreeTypes.TerrainMaterialTreeType => new TerrainMaterialTree(),
                RasterTree.RasterTreeTypes.DestructionDepthTreeType => new DestructionDepthTree(),
                _ => null,
            };

            if (s_Tree == null)
            {
                RasterTreeOrder.Add((s_Type, s_Bytes));
                continue;
            }

            s_Tree.Deserialize(s_Bytes);
            RasterTrees[s_Type] = s_Tree;
            RasterTreeOrder.Add((s_Type, null));
        }

        var s_Read = 0u;
        RootNode = LoadNode(p_Reader, new QuadtreeNodeId(), ref s_Read);
    }

    private HeightfieldNode LoadNode(RimeReader p_Reader, QuadtreeNodeId p_Id, ref uint p_Read)
    {
        // The tree has no index, so a misread would recurse on garbage; the node count bounds it.
        if (++p_Read > NodeCount)
            throw new InvalidDataException($"The streaming tree walk passed its {NodeCount} node(s).");

        var s_Node = new HeightfieldNode
        {
            ID = p_Id,
            Lod0ChunkSize = p_Reader.ReadUInt32(),
            Lod0ChunkID = new GUID(p_Reader),
        };

        if (HeightfieldTree?.TryFindNode(p_Id) is { } s_TreeNode)
            s_Node.TreeNode = s_TreeNode;

        if (p_Reader.ReadBool())
        {
            s_Node.Lod1ChunkSize = p_Reader.ReadUInt32();
            s_Node.Lod1ChunkID = new GUID(p_Reader);
        }

        s_Node.PersistentDedicatedServer = p_Reader.ReadBool();

        if (!p_Reader.ReadBool())
            return s_Node;

        s_Node.Children = new HeightfieldNode[4];
        for (var i = 0; i < 4; ++i)
        {
            var s_ChildId = new QuadtreeNodeId(p_Id);
            ++s_ChildId.Level;
            s_ChildId.IndexX = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetX[i] + 2 * p_Id.IndexX);
            s_ChildId.IndexY = (ushort)(QuadtreeNodeId.m_QuadtreeNodeChildOffsetY[i] + 2 * p_Id.IndexY);
            s_Node.Children[i] = LoadNode(p_Reader, s_ChildId, ref p_Read);
        }

        return s_Node;
    }

    /// <summary>Each raster tree's length is measured from what its writer produced, so an edited tree records its new size.</summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(UnblurredSamplesPerNodeSidePot);
        p_Writer.Write(TrackTextureDetailFalloff);
        p_Writer.Write(InvisibleDetailReductionFactor);
        p_Writer.Write(OccludedDetailReductionFactor);
        p_Writer.Write(ResourceBlurriness);
        p_Writer.Write(SkipLevels);
        p_Writer.Write(NodeCount);
        p_Writer.Write(FreeStreamingEnabled);

        foreach (var (s_Type, s_Raw) in RasterTreeOrder)
        {
            var s_Payload = s_Raw;
            if (s_Payload == null && !RasterTrees[s_Type].Serialize(out s_Payload))
                return false;

            p_Writer.Write((byte)s_Type);
            p_Writer.Write((uint)s_Payload.Length);
            p_Writer.Write(s_Payload);
        }

        p_Writer.Write((byte)RasterTree.RasterTreeTypes.RasterTreeTypeInvalid);
        SaveNode(p_Writer, RootNode);
        return true;
    }

    private static void SaveNode(RimeWriter p_Writer, HeightfieldNode p_Node)
    {
        p_Writer.Write(p_Node.Lod0ChunkSize);
        p_Node.Lod0ChunkID.Serialize(p_Writer);

        // Lod1 is optional and its flag is the only record that it was there.
        var s_Lod1 = p_Node.Lod1ChunkID != GUID.Empty || p_Node.Lod1ChunkSize != 0;
        p_Writer.Write(s_Lod1);
        if (s_Lod1)
        {
            p_Writer.Write(p_Node.Lod1ChunkSize);
            p_Node.Lod1ChunkID.Serialize(p_Writer);
        }

        p_Writer.Write(p_Node.PersistentDedicatedServer);
        p_Writer.Write(p_Node.Children.Length > 0);
        foreach (var s_Child in p_Node.Children)
            SaveNode(p_Writer, s_Child);
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        bool s_Written;
        using (var s_Writer = new RimeWriter(s_Stream))
            s_Written = Serialize(s_Writer);

        p_Data = s_Written ? s_Stream.ToArray() : null;
        return s_Written;
    }
}
