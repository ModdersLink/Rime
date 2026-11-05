using System;
using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Terrain.Frostbite2_0.Frostbite;
using RimeLib.Terrain.Frostbite2_0.Frostbite.Heightfield;
using RimeLib.Terrain.Frostbite2_0.Frostbite.TerrainMask;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2_0;

/// <summary>Reads and writes a terrain streaming tree and its raster trees.</summary>
public class TerrainHeightfieldReader : ITerrainHeightfield
{
    public virtual EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    /// <summary>This engine's streaming tree.</summary>
    protected virtual TerrainStreamingTree CreateTree() => new();

    private TerrainStreamingTree ReadTree(IResourceObject p_Resource)
    {
        var s_Tree = CreateTree();
        using (var s_Source = p_Resource.GetReader())
            s_Tree.Deserialize(s_Source.ReadBytes((int)s_Source.Length));
        return s_Tree;
    }

    protected static bool RewritesExactly(RasterTree p_Tree, byte[] p_Raw) =>
        p_Tree.Serialize(out var s_Bytes) && s_Bytes.AsSpan().SequenceEqual(p_Raw);

    /// <summary>Index of the first differing byte, -1 when they match to the shorter length, -2 when nothing was written.</summary>
    private static int FirstDiff(byte[] p_A, byte[]? p_B)
    {
        if (p_B == null)
            return -2;

        var s_N = System.Math.Min(p_A.Length, p_B.Length);
        for (var i = 0; i < s_N; ++i)
        {
            if (p_A[i] != p_B[i])
                return i;
        }

        return -1;
    }

    /// <summary>
    /// Rebuilds the streaming tree with edited heightfield samples. Everything else is written from
    /// what was read, which reproduces the shipped bytes, so the result differs only by the edit.
    /// </summary>
    public bool WriteHeightfield(IResourceObject p_Resource, IReadOnlyList<TerrainNodeEdit> p_Edits, out byte[]? p_Payload, out string? p_Error)
    {
        p_Payload = null;
        p_Error = null;

        var s_Tree = ReadTree(p_Resource);
        if (s_Tree.HeightfieldTree is not { } s_Heightfield)
        {
            p_Error = "this streaming tree carries no heightfield";
            return false;
        }

        foreach (var s_Edit in p_Edits)
        {
            var s_Node = s_Heightfield.TryFindNode(new QuadtreeNodeId { Level = (byte)s_Edit.Level, IndexX = s_Edit.IndexX, IndexY = s_Edit.IndexY });
            if (s_Node == null)
            {
                p_Error = $"no node at level={s_Edit.Level} x={s_Edit.IndexX} y={s_Edit.IndexY}";
                return false;
            }

            if (s_Edit.Samples.Length != s_Node.EmbeddedData.Length)
            {
                p_Error = $"node level={s_Edit.Level} x={s_Edit.IndexX} y={s_Edit.IndexY} takes {s_Node.EmbeddedData.Length} bytes, got {s_Edit.Samples.Length}";
                return false;
            }

            s_Node.EmbeddedData = s_Edit.Samples;
        }

        if (!s_Tree.Serialize(out p_Payload))
        {
            p_Error = "the streaming tree could not be written back";
            return false;
        }

        return true;
    }

    public bool ReadHeightfield(IResourceObject p_Resource, IEngineMounter p_Mounter, out TerrainHeightfield? p_Heightfield)
    {
        p_Heightfield = null;

        var s_Tree = ReadTree(p_Resource);
        if (s_Tree.HeightfieldTree is not { RootNode: HeightfieldTreeNode s_Root } s_Heightfield)
            return false;

        var s_Written = s_Tree.Serialize(out var s_TreeBytes) ? s_TreeBytes : null;
        p_Heightfield = new TerrainHeightfield
        {
            SamplesPerSide = s_Heightfield.NodeSamplesPerSide,
            NodeBorderWidth = s_Heightfield.NodeBorderWidth,
            WorldSizeY = s_Heightfield.WorldSizeY,
            WorldScaleY = s_Heightfield.WorldScaleY,
            HeightfieldRawLength = s_Heightfield.Raw.Length,
            HeightfieldTrailing = s_Heightfield.Trailing.Length,
            HeightfieldRewritesExactly = RewritesExactly(s_Heightfield, s_Heightfield.Raw),
            StreamingTreeRewritesExactly = s_Written != null && s_Written.AsSpan().SequenceEqual(s_Tree.Raw),
            StreamingTreeRawLength = s_Tree.Raw.Length,
            StreamingTreeWrittenLength = s_Written?.Length ?? -1,
            StreamingTreeFirstDiff = FirstDiff(s_Tree.Raw, s_Written),
        };

        // What the stream declared, so "no material tree" can be told from "not parsed".
        foreach (var (s_Type, s_Raw) in s_Tree.RasterTreeOrder)
            p_Heightfield.RasterTrees.Add($"{(RasterTree.RasterTreeTypes)s_Type}{(s_Raw != null ? " (kept as bytes)" : "")}");

        ReadMask(s_Tree, p_Heightfield);

        if (s_Tree.TerrainMaterialTree is { } s_Materials)
        {
            p_Heightfield.HasMaterialTree = true;
            p_Heightfield.MaterialPairIndices = s_Materials.MaterialPairIndices;
            p_Heightfield.BackgroundMaterialIndex = s_Materials.BackgroundMaterialIndex;
            p_Heightfield.MaterialSamplesPerSide = s_Materials.NodeSamplesPerSide;
            p_Heightfield.MaterialRewritesExactly = RewritesExactly(s_Materials, s_Materials.Raw);
            foreach (var s_Node in s_Materials.Nodes)
            {
                p_Heightfield.MaterialNodes.Add(new TerrainMaterialSamples
                {
                    Level = s_Node.Level,
                    IndexX = s_Node.IndexX,
                    IndexY = s_Node.IndexY,
                    Min = [s_Node.MinX, s_Node.MinY],
                    Max = [s_Node.MaxX, s_Node.MaxY],
                    Rle = s_Node.RleData,
                    LineSizes = s_Node.LineSizes,
                });
            }
        }

        if (s_Tree.DestructionTree is { } s_Destruction)
        {
            p_Heightfield.DestructionSamplesPerSide = s_Destruction.NodeSamplesPerSide;
            p_Heightfield.DestructionRewritesExactly = RewritesExactly(s_Destruction, s_Destruction.Raw);
            foreach (var s_Node in s_Destruction.Nodes)
            {
                p_Heightfield.DestructionNodes.Add(new TerrainMaterialSamples
                {
                    Level = s_Node.ID.Level,
                    IndexX = s_Node.ID.IndexX,
                    IndexY = s_Node.ID.IndexY,
                    Min = [s_Node.WorldCoverage!.min.x, s_Node.WorldCoverage!.min.y],
                    Max = [s_Node.WorldCoverage!.max.x, s_Node.WorldCoverage!.max.y],
                    Rle = s_Node.RleData,
                    LineSizes = s_Node.LineSizes,
                });
            }
        }

        Walk(s_Root, 0, p_Heightfield.Nodes);

        // A level whose heightfield tree embeds only its root streams the samples from the chunks
        // the streaming nodes name.
        WalkStream(s_Tree.RootNode, 0, p_Heightfield.StreamNodes);
        return true;
    }

    /// <summary>The mask tree's samples: here one entry per node, its samples stored flat.</summary>
    protected virtual void ReadMask(TerrainStreamingTree p_Tree, TerrainHeightfield p_Heightfield)
    {
        if (p_Tree.TerrainMaskTree is not TerrainMaskTree s_Mask)
            return;

        p_Heightfield.MaskRaw = s_Mask.Raw;
        p_Heightfield.MaskConsumed = s_Mask.Consumed;
        p_Heightfield.MaskSamplesPerSide = s_Mask.NodeSamplesPerSide;
        p_Heightfield.MaskRewritesExactly = RewritesExactly(s_Mask, s_Mask.Raw);
        p_Heightfield.MaskRewriteInfo = $"groups={s_Mask.Groups.Count} header={s_Mask.HeaderRaw.Length} trailing={s_Mask.Trailing.Length} raw={s_Mask.Raw.Length}";

        foreach (var s_Node in s_Mask.Nodes)
        {
            p_Heightfield.MaskNodes.Add(new TerrainMaterialSamples
            {
                Level = s_Node.Level,
                IndexX = s_Node.IndexX,
                IndexY = s_Node.IndexY,
                Min = [s_Node.MinX, s_Node.MinY],
                Max = [s_Node.MaxX, s_Node.MaxY],
                Rle = s_Node.Samples,
                LineSizes = [],
            });
        }
    }

    private static void WalkStream(HeightfieldNode p_Node, int p_Depth, List<TerrainStreamNode> p_Out)
    {
        p_Out.Add(new TerrainStreamNode
        {
            Depth = p_Depth,
            IndexX = p_Node.ID.IndexX,
            IndexY = p_Node.ID.IndexY,
            Lod0Chunk = p_Node.Lod0ChunkID.ToString(),
            Lod0Size = p_Node.Lod0ChunkSize,
            Lod1Chunk = p_Node.Lod1ChunkID.ToString(),
            Lod1Size = p_Node.Lod1ChunkSize,
            Leaf = p_Node.Children.Length == 0,
            Min = [p_Node.TreeNode.BoundingBox.min.x, p_Node.TreeNode.BoundingBox.min.y, p_Node.TreeNode.BoundingBox.min.z],
            Max = [p_Node.TreeNode.BoundingBox.max.x, p_Node.TreeNode.BoundingBox.max.y, p_Node.TreeNode.BoundingBox.max.z],
        });

        foreach (var s_Child in p_Node.Children)
            WalkStream(s_Child, p_Depth + 1, p_Out);
    }

    private static void Walk(HeightfieldTreeNode p_Node, int p_Depth, List<TerrainHeightfieldNode> p_Out)
    {
        p_Out.Add(new TerrainHeightfieldNode
        {
            Depth = p_Depth,
            IndexX = p_Node.ID.IndexX,
            IndexY = p_Node.ID.IndexY,
            Leaf = p_Node.Children.Length == 0,
            Min = [p_Node.BoundingBox.min.x, p_Node.BoundingBox.min.y, p_Node.BoundingBox.min.z],
            Max = [p_Node.BoundingBox.max.x, p_Node.BoundingBox.max.y, p_Node.BoundingBox.max.z],
            SamplesPerMeter = p_Node.SamplesPerMeter,
            Embedded = p_Node.EmbeddedData,
            Flags = p_Node.Flags,
        });

        foreach (var s_Child in p_Node.Children)
        {
            if (s_Child is HeightfieldTreeNode s_Node)
                Walk(s_Node, p_Depth + 1, p_Out);
        }
    }
}
