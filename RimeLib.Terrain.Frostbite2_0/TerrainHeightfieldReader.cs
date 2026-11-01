using RimeLib.Terrain.Frostbite.Destruction;
using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Terrain.Frostbite;
using RimeLib.Terrain.Frostbite.Heightfield;
using RimeLib.Terrain.Frostbite.TerrainMask;
using RimeLib.Terrain.Frostbite.TerrainMaterial;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2_0;

public class TerrainHeightfieldReader : ITerrainHeightfield
{
    public EngineType[] GetSupportedEngines()
    {
        return [EngineType.Frostbite2_0];
    }

    /// <summary>Index of the first differing byte, or -1 when they match to the shorter length.</summary>
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
    /// Rebuild the streaming tree with edited heightfield samples.
    ///
    /// This is only safe because the whole tree re-serialises to its shipped bytes exactly -- all
    /// 33 of BF3's terrains, container and all four raster trees. That is what makes a diff against
    /// the original equal to the edit: everything untouched comes back identical.
    /// </summary>
    public bool WriteHeightfield(IResourceObject p_Resource, IReadOnlyList<TerrainNodeEdit> p_Edits,
        out byte[]? p_Payload, out string? p_Error)
    {
        p_Payload = null;
        p_Error = null;

        var s_Tree = new TerrainStreamingTree();

        using (var s_Source = p_Resource.GetReader())
            s_Tree.Raw = s_Source.ReadBytes((int)s_Source.Length);

        s_Tree.Deserialize(s_Tree.Raw);

        if (s_Tree.HeightfieldTree is not HeightfieldTree s_Heightfield)
        {
            p_Error = "this streaming tree carries no heightfield";
            return false;
        }

        foreach (var s_Edit in p_Edits)
        {
            var s_Node = s_Heightfield.TryFindNode(new QuadtreeNodeId
            {
                Level = (byte)s_Edit.Level, IndexX = s_Edit.IndexX, IndexY = s_Edit.IndexY,
            });

            if (s_Node == null)
            {
                p_Error = $"no node at level={s_Edit.Level} x={s_Edit.IndexX} y={s_Edit.IndexY}";
                return false;
            }

            if (s_Edit.Samples.Length != s_Node.EmbeddedData.Length)
            {
                p_Error = $"node level={s_Edit.Level} x={s_Edit.IndexX} y={s_Edit.IndexY} takes " +
                    $"{s_Node.EmbeddedData.Length} bytes, got {s_Edit.Samples.Length}";
                return false;
            }

            s_Node.EmbeddedData = s_Edit.Samples;
        }

        if (!s_Tree.Serialize(out p_Payload) || p_Payload == null)
        {
            p_Error = "the streaming tree could not be written back";
            return false;
        }

        return true;
    }

    public bool ReadHeightfield(IResourceObject p_Resource, IEngineMounter p_Mounter, out TerrainHeightfield? p_Heightfield)
    {
        p_Heightfield = null;

        var s_Tree = new TerrainStreamingTree();

        // Read the resource whole and deserialise from that, so the tree keeps its own bytes to
        // measure a rewrite against. Deserialising straight off the stream leaves Raw empty and
        // every rewrite check silently compares against nothing.
        using (var s_Source = p_Resource.GetReader())
            s_Tree.Raw = s_Source.ReadBytes((int)s_Source.Length);

        using (var s_Stream = new System.IO.MemoryStream(s_Tree.Raw))
        using (var s_Reader = new RimeReader(s_Stream))
            s_Tree.Deserialize(s_Reader);

        if (s_Tree.RasterTrees[(int)RasterTree.RasterTreeTypes.HeightfieldTreeType] is not HeightfieldTree s_Heightfield ||
            s_Heightfield.RootNode == null)
            return false;

        p_Heightfield = new TerrainHeightfield
        {
            SamplesPerSide = s_Heightfield.NodeSamplesPerSide,
            NodeBorderWidth = s_Heightfield.NodeBorderWidth,
            WorldSizeY = s_Heightfield.WorldSizeY,
            WorldScaleY = s_Heightfield.WorldScaleY,
            HeightfieldRawLength = s_Heightfield.Raw.Length,
            StreamingTreeRewritesExactly = s_Tree.Serialize(out var s_TreeBytes)
                && s_TreeBytes!.Length == s_Tree.Raw.Length
                && System.Linq.Enumerable.SequenceEqual(s_TreeBytes, s_Tree.Raw),
            StreamingTreeRawLength = s_Tree.Raw.Length,
            StreamingTreeWrittenLength = s_Tree.Serialize(out var s_TreeBytes2) ? s_TreeBytes2!.Length : -1,
            StreamingTreeFirstDiff = FirstDiff(s_Tree.Raw, s_Tree.Serialize(out var s_TreeBytes3) ? s_TreeBytes3 : null),
            HeightfieldTrailing = s_Heightfield.Trailing.Length,
            HeightfieldRewritesExactly = s_Heightfield.Serialize(out var s_HeightfieldBytes)
                && s_HeightfieldBytes!.Length == s_Heightfield.Raw.Length
                && System.Linq.Enumerable.SequenceEqual(s_HeightfieldBytes, s_Heightfield.Raw)
        };

        // What the stream actually declared, and which slots got filled. Without this the caller
        // cannot tell "this level ships no material tree" from "the parse never looked".
        p_Heightfield.RasterTrees.Add($"slots={s_Tree.RasterTrees.Count}");

        for (var i = 0; i < s_Tree.RasterTrees.Count; i++)
            p_Heightfield.RasterTrees.Add($"slot{i}={(s_Tree.RasterTrees[i]?.GetType().Name ?? "null")}");

        foreach (var s_Seen in s_Tree.SeenRasterTrees)
            p_Heightfield.RasterTrees.Add($"declared={(RasterTree.RasterTreeTypes)s_Seen.Type}:{s_Seen.Size} read={s_Seen.Consumed}");

        if (s_Tree.RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainMaskTreeType] is TerrainMaskTree s_Mask)
        {
            p_Heightfield.MaskRaw = s_Mask.Raw;
            p_Heightfield.MaskConsumed = s_Mask.Consumed;
            p_Heightfield.MaskSamplesPerSide = s_Mask.NodeSamplesPerSide;

            // Whether writing the tree straight back reproduces the block it was read from. A
            // writer that cannot do that for an UNEDITED tree cannot be trusted with an edited one.
            p_Heightfield.MaskRewriteInfo = string.Format("groups={0} header={1} trailing={2} raw={3} built={4}",
                s_Mask.Groups.Count, s_Mask.HeaderRaw.Length, s_Mask.Trailing.Length, s_Mask.Raw.Length,
                s_Mask.Serialize(out var s_Probe) ? s_Probe!.Length : -1);
            p_Heightfield.MaskRewritesExactly = s_Mask.Serialize(out var s_Rewritten)
                && s_Rewritten!.Length == s_Mask.Raw.Length
                && System.Linq.Enumerable.SequenceEqual(s_Rewritten, s_Mask.Raw);

            foreach (var s_Node in s_Mask.Nodes)
            {
                p_Heightfield.MaskNodes.Add(new TerrainMaterialSamples
                {
                    Level = s_Node.Level,
                    IndexX = s_Node.IndexX,
                    IndexY = s_Node.IndexY,
                    Min = new[] { s_Node.MinX, s_Node.MinY },
                    Max = new[] { s_Node.MaxX, s_Node.MaxY },
                    // Mask samples are stored flat, not run-length encoded like the material
                    // tree's, so they travel in the same field without a line-size table.
                    Rle = s_Node.Samples,
                    LineSizes = System.Array.Empty<ushort>()
                });
            }
        }

        if (s_Tree.RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainMaterialTreeType] is TerrainMaterialTree s_Materials)
        {
            p_Heightfield.HasMaterialTree = true;
            p_Heightfield.MaterialPairIndices = s_Materials.MaterialPairIndices;
            p_Heightfield.BackgroundMaterialIndex = s_Materials.BackgroundMaterialIndex;
            p_Heightfield.MaterialSamplesPerSide = s_Materials.NodeSamplesPerSide;
            p_Heightfield.MaterialRewritesExactly = s_Materials.Serialize(out var s_MaterialBytes)
                && s_MaterialBytes!.Length == s_Materials.Raw.Length
                && System.Linq.Enumerable.SequenceEqual(s_MaterialBytes, s_Materials.Raw);

            foreach (var s_Node in s_Materials.Nodes)
            {
                p_Heightfield.MaterialNodes.Add(new TerrainMaterialSamples
                {
                    Level = s_Node.Level,
                    IndexX = s_Node.IndexX,
                    IndexY = s_Node.IndexY,
                    Min = new[] { s_Node.MinX, s_Node.MinY },
                    Max = new[] { s_Node.MaxX, s_Node.MaxY },
                    Rle = s_Node.RleData,
                    LineSizes = s_Node.LineSizes
                });
            }
        }

        if (s_Heightfield.RootNode is HeightfieldTreeNode s_Root)
            Walk(s_Root, 0, p_Heightfield.Nodes);

        if (s_Tree.RasterTrees[(int)RasterTree.RasterTreeTypes.DestructionDepthTreeType]
                is DestructionDepthTree s_Destruction)
        {
            p_Heightfield.DestructionSamplesPerSide = s_Destruction.NodeSamplesPerSide;
            p_Heightfield.DestructionRewritesExactly = s_Destruction.Serialize(out var s_DestructionBytes)
                && s_DestructionBytes!.Length == s_Destruction.Raw.Length
                && System.Linq.Enumerable.SequenceEqual(s_DestructionBytes, s_Destruction.Raw);

            foreach (var s_Node in s_Destruction.Nodes)
            {
                p_Heightfield.DestructionNodes.Add(new TerrainMaterialSamples
                {
                    Level = s_Node.ID.Level,
                    IndexX = s_Node.ID.IndexX,
                    IndexY = s_Node.ID.IndexY,
                    Min = new[] { s_Node.WorldCoverage!.min.x, s_Node.WorldCoverage!.min.y },
                    Max = new[] { s_Node.WorldCoverage!.max.x, s_Node.WorldCoverage!.max.y },
                    Rle = s_Node.RleData,
                    LineSizes = s_Node.LineSizes
                });
            }
        }

        // The streaming tree's own nodes. A level whose heightfield tree carries no samples --
        // MP_017 embeds only its root -- streams them from the chunks these name, so without this
        // there is no surface to build at all.
        WalkStream(s_Tree.RootNode, 0, p_Heightfield.StreamNodes);

        return true;
    }

    private static void WalkStream(HeightfieldNode? p_Node, int p_Depth, List<TerrainStreamNode> p_Out)
    {
        if (p_Node == null)
            return;

        var s_Entry = new TerrainStreamNode
        {
            Depth = p_Depth,
            IndexX = p_Node.ID.IndexX,
            IndexY = p_Node.ID.IndexY,
            Lod0Chunk = p_Node.Lod0ChunkID.ToString(),
            Lod0Size = p_Node.Lod0ChunkSize,
            Lod1Chunk = p_Node.Lod1ChunkID.ToString(),
            Lod1Size = p_Node.Lod1ChunkSize,
            Leaf = p_Node.Children.Length == 0
        };

        if (p_Node.TreeNode is HeightfieldTreeNode s_Tree)
        {
            s_Entry.Min = new[] { s_Tree.BoundingBox.min.x, s_Tree.BoundingBox.min.y, s_Tree.BoundingBox.min.z };
            s_Entry.Max = new[] { s_Tree.BoundingBox.max.x, s_Tree.BoundingBox.max.y, s_Tree.BoundingBox.max.z };
        }

        p_Out.Add(s_Entry);

        foreach (var l_Child in p_Node.Children)
            WalkStream(l_Child, p_Depth + 1, p_Out);
    }

    private static void Walk(HeightfieldTreeNode p_Node, int p_Depth, List<TerrainHeightfieldNode> p_Out)
    {
        p_Out.Add(new TerrainHeightfieldNode
        {
            Depth = p_Depth,
            IndexX = p_Node.ID.IndexX,
            IndexY = p_Node.ID.IndexY,
            Leaf = p_Node.Children == null || p_Node.Children.Length == 0,
            Min = [p_Node.BoundingBox.min.x, p_Node.BoundingBox.min.y, p_Node.BoundingBox.min.z],
            Max = [p_Node.BoundingBox.max.x, p_Node.BoundingBox.max.y, p_Node.BoundingBox.max.z],
            SamplesPerMeter = p_Node.SamplesPerMeter,
            Embedded = p_Node.EmbeddedData,
            Flags = p_Node.Flags
        });

        foreach (var s_Child in p_Node.Children)
        {
            if (s_Child is HeightfieldTreeNode s_Node)
                Walk(s_Node, p_Depth + 1, p_Out);
        }
    }
}
