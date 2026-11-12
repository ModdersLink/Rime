using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Terrain.Frostbite2_0.Frostbite;
using RimeLib.Terrain.Frostbite2_0.Frostbite.Heightfield;
using RimeLib.Terrain.Frostbite2013_2.Frostbite;
using RimeLib.Terrain.Resources;
using HeightfieldTreeNode = RimeLib.Terrain.Frostbite2_0.Frostbite.Heightfield.HeightfieldTreeNode;
using Frostbite2ColorTree = RimeLib.Terrain.Frostbite2_0.Frostbite.TerrainColor.TerrainColorTree;
using TerrainDecalsBuilder = RimeLib.Terrain.Frostbite2_0.TerrainDecalsBuilder;
using Frostbite2Heightfield = RimeLib.Terrain.Frostbite2_0.HeightfieldTree;
using Frostbite2StreamingTree = RimeLib.Terrain.Frostbite2_0.TerrainStreamingTree;
using Frostbite2VisualTerrain = RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain.VisualTerrain;
using Frostbite2VisualTerrainLayer = RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain.VisualTerrainLayer;
using Frostbite2Draw = RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain.TerrainLayerCombinationDraw;
using Frostbite2Draw2d = RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain.Surface2dDrawMethod;
using Frostbite2Draw3d = RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain.Surface3dDrawMethod;

namespace RimeLib.Terrain.Frostbite2013_2;

/// <summary>
/// This engine's terrain as Frostbite 2's. The streaming tree keeps the heightfield, every node's
/// samples in the tree itself: this engine streams them from chunks, a node's own block from its
/// streaming node's first chunk and its children's from the second, last child first; the mask the
/// same way, with the source's layers, and the colour tree's tiles; the material and destruction
/// trees as they are, with the target's materials. The visual
/// terrain becomes Frostbite 2's terrain resource, which names the streaming tree.
/// </summary>
public class TerrainConverter : ITerrainConverter
{
    private const string c_StreamingTreeSuffix = ".streamingtree_win32";
    private const string c_Frostbite2StreamingTreeSuffix = ".streamingtree";

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyList<ConvertedTerrainResource> Convert(IResourceObject p_Resource, string p_Name, IEngineMounter p_Mounter, EngineType p_Target,
        Func<uint, uint> p_Materials, TextWriter p_Log)
    {
        if (p_Target != EngineType.Frostbite2_0)
            throw new NotSupportedException($"terrain is converted to Frostbite 2 only, not {p_Target}");

        return p_Resource.GetResourceType() switch
        {
            ResourceType.TerrainStreamingTree => [StreamingTree(p_Resource, p_Name, p_Mounter, p_Materials, p_Log)],
            ResourceType.VisualTerrain => [TerrainResource(p_Name)],
            _ => [],
        };
    }

    /// <summary>
    /// Frostbite 2's decals: the 2d and 3d blocks without tangent space, whose vertices both engines
    /// lay out alike. Frostbite 2's decals carry their opacity in the first and last user mask
    /// (1,0,0,1 inside, fading at the edges), this engine's in the last, so both take the last.
    /// </summary>
    public TerrainDecalsResource ConvertDecals(TerrainDecalsResource p_Decals, EngineType p_Target, TextWriter p_Log)
    {
        if (p_Target != EngineType.Frostbite2_0)
            throw new NotSupportedException($"terrain decals are converted to Frostbite 2 only, not {p_Target}");

        var s_Builder = new TerrainDecalsBuilder(p_Decals);
        var s_Skipped = 0;
        foreach (var (s_Kind, s_Geometry) in new[] { (DecalGeometryKind.Decal2d, p_Decals.Geometry2d), (DecalGeometryKind.Decal3d, p_Decals.Geometry3d) })
        {
            foreach (var s_Block in s_Geometry.Blocks)
            {
                if (TerrainDecalsConverter.BlockVertices(s_Geometry, s_Block, s_Kind) is not { } s_Vertices)
                {
                    ++s_Skipped;
                    continue;
                }

                foreach (var s_Vertex in s_Vertices)
                {
                    var s_Opacity = s_Vertex.UserMasks[3];
                    s_Vertex.UserMasks = [s_Opacity, 0, 0, s_Opacity];
                }

                var s_Indices = s_Geometry.Indices.GetRange((int)s_Block.StartIndex, (int)s_Block.PrimitiveCount * 3);
                s_Builder.Add(s_Kind, s_Block, s_Block.SurfaceShaderName, s_Block.ZOnlySurfaceShaderName, s_Vertices, s_Indices);
            }
        }

        var s_Decals = s_Builder.Build();
        p_Log.WriteLine($"DECALS: {s_Decals.Geometry2d.BlockCount} 2d and {s_Decals.Geometry3d.BlockCount} 3d block(s) converted, " +
            $"{s_Skipped} with tangent space and {p_Decals.GeometryWater.BlockCount} water block(s) left out.");
        return s_Decals;
    }

    /// <summary>
    /// Frostbite 2's visual terrain: this engine's settings and layers without scattering (no
    /// virtual texture for the layer this engine disables it for), and the layer combination draws
    /// with their shaders renamed, the destruction mask flag the resource's on each 2d method, and
    /// without the mask scale methods, which only scattering uses.
    /// </summary>
    public byte[] ConvertVisualTerrain(IResourceObject p_Visual, IResourceObject p_LayerCombinations, string p_StreamingTree, string p_Decals,
        string p_SurfaceShader, Func<string, string> p_ShaderName, bool p_Keep3d, EngineType p_Target, TextWriter p_Log)
    {
        if (p_Target != EngineType.Frostbite2_0)
            throw new NotSupportedException($"visual terrain is converted to Frostbite 2 only, not {p_Target}");

        var s_Source = new VisualTerrain();
        s_Source.Deserialize(ReadAll(p_Visual));
        var s_Combinations = new TerrainLayerCombinations();
        s_Combinations.Deserialize(ReadAll(p_LayerCombinations));

        var s_Visual = new Frostbite2VisualTerrain
        {
            MeshScatteringCellFov = s_Source.MeshScatteringCellFov,
            MeshScatteringCellMaskSamplesPerSide = s_Source.MeshScatteringCellMaskSamplesPerSide,
            MeshScatteringInstancePoolSize = s_Source.MeshScatteringInstancePoolSize,
            MeshScatteringInstanceDrawBufferSize = s_Source.MeshScatteringInstanceDrawBufferSize,
            ResourcePatchFov = s_Source.ResourcePatchFov,
            ResourceLodScale = s_Source.ResourceLodScale,
            ResourceTriangleSizeMin = s_Source.ResourceTriangleSizeMin,
            TextureAtlasSampleCountX = s_Source.TextureAtlasSampleCountX,
            TextureAtlasSampleCountY = s_Source.TextureAtlasSampleCountY,
            TextureSamplesPerMeterMax = s_Source.TextureSamplesPerMeterMax,
            TextureDetailFalloffCurve = s_Source.TextureDetailFalloffCurve,
            TextureDetailFalloffDistance = s_Source.TextureDetailFalloffDistance,
            TextureDetailFalloffFactor = s_Source.TextureDetailFalloffFactor,
            TextureInvisibleDetailReductionFactor = s_Source.TextureInvisibleDetailReductionFactor,
            TextureOccludedDetailReductionFactor = s_Source.TextureOccludedDetailReductionFactor,
            SurfaceShaderName = p_SurfaceShader,
            StreamingTreeResourceName = p_StreamingTree,
            DecalsResourceName = p_Decals,
            Layers = s_Source.Layers.Select((_, i) => new Frostbite2VisualTerrainLayer { VirtualTextureEnable = i != s_Source.VirtualTextureDisableTerrainLayerIndex }).ToArray(),
        };

        var s_Dropped3d = 0;
        s_Visual.TerrainLayerCombinationDraws = s_Combinations.Draws.Select(p_Draw =>
        {
            s_Dropped3d += p_Keep3d ? 0 : p_Draw.Surface3dDrawMethods.Length;
            return new Frostbite2Draw
            {
                TerrainLayerIndices = p_Draw.TerrainLayerIndices,
                Surface2dDrawMethods = p_Draw.Surface2dDrawMethods.Select(p_Method => new Frostbite2Draw2d
                {
                    DrawPassType = p_Method.DrawPassType,
                    MaskedTerrainLayerIndices = p_Method.MaskedTerrainLayerIndices,
                    ShaderName = p_ShaderName(p_Method.ShaderName),
                    DestructionMaskEnable = s_Combinations.DestructionMaskEnable,
                }).ToArray(),
                Surface3dDrawMethods = p_Keep3d
                    ? p_Draw.Surface3dDrawMethods.Select(p_Method => new Frostbite2Draw3d
                    {
                        MaskedTerrainLayerIndices = p_Method.MaskedTerrainLayerIndices,
                        ShaderName = p_ShaderName(p_Method.ShaderName),
                        DestructionMaskEnable = s_Combinations.DestructionMaskEnable,
                        Level = p_Method.Level,
                        DrawDirectLayerCount = p_Method.DrawDirectLayerCount,
                    }).ToArray()
                    : [],
            };
        }).ToArray();

        p_Log.WriteLine($"VISUAL: {s_Visual.Layers.Length} layer(s), {s_Visual.TerrainLayerCombinationDraws.Length} combination(s) with " +
            $"{s_Visual.TerrainLayerCombinationDraws.Sum(p_D => p_D.Surface2dDrawMethods.Length)} 2d method(s); {s_Dropped3d} 3d method(s) and the scattering left out.");
        return s_Visual.Serialize(out var s_Data) ? s_Data : throw new InvalidDataException("the visual terrain did not serialize");
    }

    private static byte[] ReadAll(IResourceObject p_Resource)
    {
        using var s_Reader = p_Resource.GetReader();
        return s_Reader.ReadBytes((int)s_Reader.Length);
    }

    /// <summary>Frostbite 2's terrain resource: the name of the streaming tree, which carries the terrain's own.</summary>
    private static ConvertedTerrainResource TerrainResource(string p_Name) =>
        new(p_Name, ResourceType.Terrain, Encoding.ASCII.GetBytes(p_Name + c_Frostbite2StreamingTreeSuffix + '\0'));

    private static ConvertedTerrainResource StreamingTree(IResourceObject p_Resource, string p_Name, IEngineMounter p_Mounter, Func<uint, uint> p_Materials, TextWriter p_Log)
    {
        var s_Source = new TerrainStreamingTree();
        using (var s_Reader = p_Resource.GetReader())
            s_Source.Deserialize(s_Reader.ReadBytes((int)s_Reader.Length));

        if (s_Source.HeightfieldTree is not HeightfieldTree { HeightfieldRootNode: { } s_Root } s_Heights)
            throw new InvalidDataException("a streaming tree without a heightfield");

        var s_SourceMask = s_Source.TerrainMaskTree as TerrainMaskTree;
        var s_SourceColor = s_Source.TerrainColorTree;
        var (s_Blocks, s_MaskSamples, s_ColorTiles) = Blocks(s_Source, s_Heights, s_SourceMask, s_SourceColor, p_Mounter);
        var s_Counts = new Counts();
        var s_Target = new Frostbite2Heightfield
        {
            NodeSamplesPerSide = s_Heights.NodeSamplesPerSide,
            ResourceAtlasSampleCountX = s_Heights.ResourceAtlasSampleCountX,
            ResourceAtlasSampleCountY = s_Heights.ResourceAtlasSampleCountY,
            ResourceBlurrinessFactorExponent = s_Heights.ResourceBlurrinessFactorExponent,
            WorldSizeY = s_Heights.WorldSizeY,
            PhysicsMetersPerSample = s_Heights.PhysicsMetersPerSample,
            // The engine reads the physics crop as an int, -1 for the whole terrain, as its own terrains have it.
            PhysicsCropWidth = BitConverter.Int32BitsToSingle(-1),
            Ps3RsxHeightfieldEnable = s_Heights.Ps3RsxHeightfieldEnable,
            Ps3RsxHeightfieldCacheFraction = s_Heights.Ps3RsxHeightfieldCacheFraction,
            MinMaxStackDepth = s_Heights.MinMaxStackDepth,
            OccluderGridStackDepth = s_Heights.OccluderGridStackDepth,
            NodeCount = s_Heights.NodeCount,
            NodeBorderWidth = s_Heights.NodeBorderWidth,
            RootNode = Node(s_Root, s_Heights, s_Blocks, s_Counts),
        };
        s_Target.PersistentNodeCount = (uint)s_Counts.Persistent;
        s_Target.ResourceAtlasSampleCountX = s_Target.ResourceAtlasSampleCountY =
            OnePageAtlas(s_Heights.NodeSamplesPerSide, s_Target.PersistentNodeCount, System.Math.Max(s_Heights.ResourceAtlasSampleCountX, s_Heights.ResourceAtlasSampleCountY));

        // One streaming node without chunks: every node's samples are in the tree.
        var s_Tree = new Frostbite2StreamingTree
        {
            UnblurredSamplesPerNodeSidePot = s_Source.UnblurredSamplesPerNodeSidePot,
            TrackTextureDetailFalloff = s_Source.TrackTextureDetailFalloff,
            InvisibleDetailReductionFactor = s_Source.InvisibleDetailReductionFactor,
            OccludedDetailReductionFactor = s_Source.OccludedDetailReductionFactor,
            ResourceBlurriness = s_Source.ResourceBlurriness,
            NodeCount = 1,
            FreeStreamingEnabled = s_Source.FreeStreamingEnabled,
            RootNode = new HeightfieldNode(),
        };
        s_Tree.RasterTrees = Enumerable.Repeat<RasterTree>(null!, (int)RasterTree.RasterTreeTypes.RasterTreeTypeCount).ToList();
        s_Tree.RasterTrees[(int)RasterTree.RasterTreeTypes.HeightfieldTreeType] = s_Target;

        // The material and destruction trees are Frostbite 2's own and keep their samples in the
        // tree; the materials become the target's.
        if (s_Source.TerrainMaterialTree is { } s_MaterialTree)
        {
            s_MaterialTree.MaterialPairIndices = s_MaterialTree.MaterialPairIndices.Select(p_Materials).ToList();
            s_MaterialTree.BackgroundMaterialIndex = p_Materials(s_MaterialTree.BackgroundMaterialIndex);
            s_Tree.RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainMaterialTreeType] = s_MaterialTree;
        }

        if (s_Source.DestructionTree is { } s_DestructionTree)
            s_Tree.RasterTrees[(int)RasterTree.RasterTreeTypes.DestructionDepthTreeType] = s_DestructionTree;

        if (s_SourceMask != null)
            s_Tree.RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainMaskTreeType] = Mask(s_SourceMask, s_MaskSamples, s_Counts);

        if (s_SourceColor != null)
            s_Tree.RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainColorTreeType] = Color(s_SourceColor, s_ColorTiles, s_Counts);

        foreach (var (s_Type, _) in s_Source.RasterTreeOrder.Where(p_T => s_Tree.RasterTrees[p_T.Type] != null))
            s_Tree.RasterTreeOrder.Add((s_Type, null));

        if (!s_Tree.Serialize(out var s_Data))
            throw new InvalidDataException("the converted streaming tree did not serialize");

        p_Log.WriteLine($"TERRAIN {p_Name}: {s_Counts.Persistent} heightfield node(s) with samples ({s_Counts.FromChildren} from their children), {s_Counts.Missing} without their block pruned, " +
            $"{s_Counts.Holes} hole sample(s) filled; {s_Counts.MaskMissing} mask subtile(s) without samples left out, {s_Counts.ColorMissing} colour tile(s) missing, {s_Counts.ColorFromChildren} from their children.");
        var s_Name = p_Name.EndsWith(c_StreamingTreeSuffix, StringComparison.Ordinal) ? p_Name[..^c_StreamingTreeSuffix.Length] + c_Frostbite2StreamingTreeSuffix : p_Name;
        return new ConvertedTerrainResource(s_Name, ResourceType.TerrainStreamingTree, s_Data);
    }

    /// <summary>
    /// The mask as Frostbite 2 keeps it, with the source's layers: every node persistent, the
    /// samples of each subtile that is not full in the tree. A subtile whose samples are in no chunk
    /// is left out, so the layers beside it cover its part.
    /// </summary>
    private static Frostbite2_0.Frostbite.TerrainMask.TerrainMaskTree Mask(TerrainMaskTree p_Source, Dictionary<(int, int, int), byte[]> p_Samples, Counts p_Counts)
    {
        var s_TileSize = (int)(p_Source.TileSamplesPerSide * p_Source.TileSamplesPerSide);
        var s_Target = new Frostbite2_0.Frostbite.TerrainMask.TerrainMaskTree
        {
            TileSamplesPerSide = p_Source.TileSamplesPerSide,
            TilesPerNodeSide = p_Source.TilesPerNodeSide,
            ResourceAtlasSampleCountX = p_Source.ResourceAtlasSampleCountX,
            ResourceAtlasSampleCountY = p_Source.ResourceAtlasSampleCountY,
            BlurrinessFactorExponent = p_Source.BlurrinessFactorExponent,
            TreeCoverage = p_Source.TreeCoverage,
        };

        Frostbite2_0.Frostbite.TerrainMask.TerrainMaskTree.Node Convert(TerrainMaskTree.Node p_Node)
        {
            var s_Node = new Frostbite2_0.Frostbite.TerrainMask.TerrainMaskTree.Node { ID = p_Node.ID, HasBeenPruned = p_Node.HasBeenPruned };
            ++s_Target.NodeCount;
            if (!p_Node.HasBeenPruned)
            {
                var s_Samples = p_Samples.GetValueOrDefault(Key(p_Node.ID));
                var s_Offset = 0;
                foreach (var s_Subtile in p_Node.Subtiles)
                {
                    if (!s_Subtile.IsFull)
                    {
                        if (s_Samples == null || s_Offset + s_TileSize > s_Samples.Length)
                        {
                            ++p_Counts.MaskMissing;
                            continue;
                        }

                        s_Subtile.Samples = s_Samples[s_Offset..(s_Offset + s_TileSize)];
                        s_Offset += s_TileSize;
                    }

                    s_Node.Subtiles.Add(s_Subtile);
                }

                s_Node.NonTrivialSubtileCount = (ushort)s_Node.Subtiles.Count(p_S => !p_S.IsFull);
                s_Node.Persistent = s_Node.Subtiles.Count > 0;
                s_Target.SubtileCount += (uint)s_Node.Subtiles.Count;
            }

            s_Node.Children = p_Node.Children.Cast<TerrainMaskTree.Node>().Select(p_C => (RasterTreeNode)Convert(p_C)).ToArray();
            s_Node.NonTrivialPersistentSubtileCountRecursive = (ushort)(s_Node.NonTrivialSubtileCount
                + s_Node.Children.Cast<Frostbite2_0.Frostbite.TerrainMask.TerrainMaskTree.Node>().Sum(p_C => p_C.NonTrivialPersistentSubtileCountRecursive));
            return s_Node;
        }

        var s_Root = Convert((TerrainMaskTree.Node)p_Source.RootNode!);
        s_Target.RootNode = s_Root;
        s_Target.PersistentNonTrivialSubtileCount = s_Root.NonTrivialPersistentSubtileCountRecursive;
        return s_Target;
    }

    private sealed class Counts
    {
        public int Persistent;
        public int Missing;
        public int Holes;
        public int FromChildren;
        public int MaskMissing;
        public int ColorMissing;
        public int ColorFromChildren;
    }

    /// <summary>
    /// Each node's data from the chunks, by tree and node: its heightfield block (samples, min/max
    /// stack, occluder grid, density map), the samples of its mask subtiles that are not full, and
    /// its colour tile. A streaming node's first chunk holds its own, its second its children's, last
    /// child first, each tree's after the previous tree's for every child.
    /// </summary>
    private static (Dictionary<(int, int, int), byte[]> Heights, Dictionary<(int, int, int), byte[]> Masks, Dictionary<(int, int, int), byte[]> Colors) Blocks(
        TerrainStreamingTree p_Tree, HeightfieldTree p_Heights, TerrainMaskTree? p_Mask, Frostbite2ColorTree? p_Color, IEngineMounter p_Mounter)
    {
        var s_BlockSize = (int)(p_Heights.NodeSamplesPerSide * p_Heights.NodeSamplesPerSide * 2 + p_Heights.MinMaxStackSize * 2
            + p_Heights.OccluderGridStackSize * 2 + p_Heights.DensityMapSize);
        var s_MaskNodes = p_Mask?.Nodes.ToDictionary(p_N => Key(p_N.ID)) ?? [];
        var s_TileSize = (int)(p_Mask == null ? 0 : p_Mask.TileSamplesPerSide * p_Mask.TileSamplesPerSide);
        var s_ColorNodes = new Dictionary<(int, int, int), Frostbite2ColorTree.Node>();
        void CollectColor(Frostbite2ColorTree.Node p_Node)
        {
            s_ColorNodes[Key(p_Node.ID)] = p_Node;
            foreach (var s_Child in p_Node.Children)
                CollectColor((Frostbite2ColorTree.Node)s_Child);
        }
        if (p_Color?.RootNode is Frostbite2ColorTree.Node s_ColorRoot)
            CollectColor(s_ColorRoot);

        // Each tree's data for a node, in the order the chunks keep the trees.
        (Func<QuadtreeNodeId, int> Size, Dictionary<(int, int, int), byte[]> Data)[] s_Trees =
        [
            (p_Id => p_Heights.TryFindNode(p_Id) is { HasData: true } ? s_BlockSize : 0, new()),
            (p_Id => s_MaskNodes.TryGetValue(Key(p_Id), out var s_Node) && !s_Node.HasBeenPruned ? s_Node.Subtiles.Count(p_S => !p_S.IsFull) * s_TileSize : 0, new()),
            (p_Id => s_ColorNodes.TryGetValue(Key(p_Id), out var s_Node) && s_Node is { HasData: true, HasPersistent: false } ? p_Color!.TileSize : 0, new()),
        ];

        void Read(byte[] p_Data, IReadOnlyList<QuadtreeNodeId> p_Nodes)
        {
            var s_Offset = 0;
            foreach (var (s_Size, s_Data) in s_Trees)
            {
                foreach (var s_Id in p_Nodes)
                {
                    var s_Length = s_Size(s_Id);
                    if (s_Length == 0 || s_Offset + s_Length > p_Data.Length)
                        continue;

                    s_Data[Key(s_Id)] = p_Data[s_Offset..(s_Offset + s_Length)];
                    s_Offset += s_Length;
                }
            }
        }

        void Walk(HeightfieldNode p_Node)
        {
            if (p_Node.Lod0ChunkID != GUID.Empty)
                Read(Chunk(p_Mounter, p_Node.Lod0ChunkID), [p_Node.ID]);

            if (p_Node.Lod1ChunkID != GUID.Empty)
                Read(Chunk(p_Mounter, p_Node.Lod1ChunkID), [p_Node.ID.Child(3), p_Node.ID.Child(2), p_Node.ID.Child(1), p_Node.ID.Child(0)]);

            foreach (var s_Child in p_Node.Children)
                Walk(s_Child);
        }

        Walk(p_Tree.RootNode);
        return (s_Trees[0].Data, s_Trees[1].Data, s_Trees[2].Data);
    }

    /// <summary>
    /// The colour tree with every node that has a tile persistent, its tile in the tree. A node
    /// whose tile is in no chunk keeps no data, so its parent's tile tints its part.
    /// </summary>
    private static Frostbite2ColorTree Color(Frostbite2ColorTree p_Source, Dictionary<(int, int, int), byte[]> p_Tiles, Counts p_Counts)
    {
        var s_Persistent = 0u;
        Frostbite2ColorTree.Node Convert(Frostbite2ColorTree.Node p_Node)
        {
            var s_Node = new Frostbite2ColorTree.Node { ID = p_Node.ID, HasBeenPruned = p_Node.HasBeenPruned, HasData = p_Node.HasData };
            if (s_Node.HasData)
            {
                var s_Tile = p_Node.HasPersistent ? p_Node.Samples : p_Tiles.GetValueOrDefault(Key(p_Node.ID));
                if (s_Tile is { Length: > 0 })
                {
                    s_Node.HasPersistent = true;
                    s_Node.Samples = s_Tile;
                    ++s_Persistent;
                }
                else
                {
                    s_Node.HasData = false;
                    s_Node.HasBeenPruned = true;
                    ++p_Counts.ColorMissing;
                }
            }

            s_Node.Children = p_Node.Children.Cast<Frostbite2ColorTree.Node>().Select(p_C => (RasterTreeNode)Convert(p_C)).ToArray();
            if (s_Node is { HasBeenPruned: true, HasData: false } && s_Node.Children.Length == 4
                && s_Node.Children.Any(p_C => p_C is Frostbite2ColorTree.Node { HasData: true }))
            {
                s_Node.Samples = ColorFromChildren(s_Node, (int)p_Source.NodeSamplesPerSide, (int)p_Source.TileBorderWidth);
                s_Node.HasBeenPruned = false;
                s_Node.HasData = true;
                s_Node.HasPersistent = true;
                ++s_Persistent;
                ++p_Counts.ColorFromChildren;
            }

            return s_Node;
        }

        var s_Root = Convert((Frostbite2ColorTree.Node)p_Source.RootNode!);
        return new Frostbite2ColorTree
        {
            NodeSamplesPerSide = p_Source.NodeSamplesPerSide,
            TileBorderWidth = p_Source.TileBorderWidth,
            ResourceAtlasSampleCountX = OnePageAtlas(p_Source.NodeSamplesPerSide, s_Persistent, System.Math.Max(p_Source.ResourceAtlasSampleCountX, p_Source.ResourceAtlasSampleCountY)),
            ResourceAtlasSampleCountY = OnePageAtlas(p_Source.NodeSamplesPerSide, s_Persistent, System.Math.Max(p_Source.ResourceAtlasSampleCountX, p_Source.ResourceAtlasSampleCountY)),
            BlurrinessFactorExponent = p_Source.BlurrinessFactorExponent,
            TreeCoverage = p_Source.TreeCoverage,
            AtlasTextureFormat = p_Source.AtlasTextureFormat,
            SourceTexturesChannelCount = p_Source.SourceTexturesChannelCount,
            NodeCount = p_Source.NodeCount,
            PersistentNodeCount = s_Persistent,
            RootNode = s_Root,
        };
    }

    /// <summary>
    /// The atlas side, in samples, that holds every persistent node of a tree on one page. Frostbite 2 adds
    /// atlas pages when a tree has at least as many persistent nodes as a page has tiles, but the visual terrain
    /// draws the heightfield and colour from the first page only (VisualTerrain::setHeightfieldShaderParams,
    /// drawPatch), so the nodes on any other page would be drawn with the first page's samples. A converted tree
    /// keeps every node persistent, far more than the source's atlas, which streamed them, holds.
    /// </summary>
    private static uint OnePageAtlas(uint p_NodeSamplesPerSide, uint p_Persistent, uint p_SourceSamplesPerSide)
    {
        var s_Tiles = System.Math.Max(p_SourceSamplesPerSide / p_NodeSamplesPerSide, 1u);
        while (s_Tiles * s_Tiles <= p_Persistent)
            ++s_Tiles;

        var s_Samples = s_Tiles * p_NodeSamplesPerSide;
        if (s_Samples > 0x2000)
            throw new InvalidDataException($"{p_Persistent} persistent node(s) of {p_NodeSamplesPerSide} samples do not fit one atlas page");
        return s_Samples;
    }

    private static (int, int, int) Key(QuadtreeNodeId p_Id) => (p_Id.Level, p_Id.IndexX, p_Id.IndexY);

    private static byte[] Chunk(IEngineMounter p_Mounter, GUID p_Id)
    {
        if (!p_Mounter.TryGetChunk(p_Id, out var s_Chunk))
            throw new InvalidDataException($"terrain chunk {p_Id} is not mounted");

        using var s_Reader = (s_Chunk.Variants.FirstOrDefault(p_V => p_V.GetLogicalOffset() == 0) ?? s_Chunk.FirstVariant).GetReader();
        return s_Reader.ReadBytes((int)s_Reader.Length);
    }

    /// <summary>
    /// The node as Frostbite 2 keeps it, its samples in the tree. A node whose block is missing is
    /// kept as pruned, so its children stay; a node that marks some samples as no ground has them
    /// raised to its lowest ground, which Frostbite 2 would otherwise read as ground at zero.
    /// </summary>
    private static HeightfieldTreeNode Node(HeightfieldTreeNode p_Source, HeightfieldTree p_Heights, Dictionary<(int, int, int), byte[]> p_Blocks, Counts p_Counts)
    {
        var s_Node = new HeightfieldTreeNode
        {
            ID = p_Source.ID,
            BoundingBox = p_Source.BoundingBox,
            Disabled = p_Source.Disabled,
            HasBeenPruned = p_Source.HasBeenPruned,
        };

        if (s_Node.Disabled)
            return s_Node;

        var s_Block = p_Source.EmbeddedData.Length > 0
            ? [.. p_Source.EmbeddedData, .. p_Source.MinMaxData, .. p_Source.OccluderGridData]
            : p_Source.HasData ? p_Blocks.GetValueOrDefault(Key(p_Source.ID)) : null;
        if (p_Source.HasData && s_Block == null)
        {
            s_Node.HasBeenPruned = true;
            ++p_Counts.Missing;
        }
        else if (s_Block != null)
        {
            var s_Samples = (int)(p_Heights.NodeSamplesPerSide * p_Heights.NodeSamplesPerSide * 2);
            var s_MinMax = (int)(p_Heights.MinMaxStackSize * 2);
            var s_Occluder = (int)(p_Heights.OccluderGridStackSize * 2);
            s_Node.HasData = true;
            s_Node.HasPersistent = true;
            s_Node.EmbeddedData = p_Source.PartialNonPhysics ? WithoutHoles(s_Block[..s_Samples], p_Counts) : s_Block[..s_Samples];
            s_Node.MinMaxData = s_Block[s_Samples..(s_Samples + s_MinMax)];
            s_Node.OccluderGridData = s_Block[(s_Samples + s_MinMax)..(s_Samples + s_MinMax + s_Occluder)];
            ++p_Counts.Persistent;
        }

        s_Node.Children = p_Source.Children.Cast<HeightfieldTreeNode>().Select(p_C => (RasterTreeNode)Node(p_C, p_Heights, p_Blocks, p_Counts)).ToArray();
        if (!s_Node.HasData && s_Node.Children.Length == 4 && s_Node.Children.All(p_C => p_C is HeightfieldTreeNode { HasData: true }))
        {
            FromChildren(s_Node, p_Heights);
            ++p_Counts.Persistent;
            ++p_Counts.FromChildren;
        }

        return s_Node;
    }

    /// <summary>
    /// Gives a node its data from its four children, as Frostbite 2 culls from the root's min/max
    /// stack whether or not it is loaded: every second child sample, edge samples clamped; each
    /// finer min/max level the children's next coarser one tiled by quadrant, the coarsest their
    /// overall range; an occluder grid of zeros.
    /// </summary>
    private static void FromChildren(HeightfieldTreeNode p_Node, HeightfieldTree p_Heights)
    {
        var s_Side = (int)p_Heights.NodeSamplesPerSide;
        var s_Border = (int)p_Heights.NodeBorderWidth;
        var s_Inner = s_Side - 2 * s_Border - 1;
        var s_Children = new HeightfieldTreeNode[4];
        foreach (var s_Child in p_Node.Children.Cast<HeightfieldTreeNode>())
            s_Children[(s_Child.ID.IndexX - 2 * p_Node.ID.IndexX) + 2 * (s_Child.ID.IndexY - 2 * p_Node.ID.IndexY)] = s_Child;

        static ushort Read(byte[] p_Data, int p_Index) => (ushort)(p_Data[2 * p_Index] | p_Data[2 * p_Index + 1] << 8);

        var s_Samples = new byte[s_Side * s_Side * 2];
        for (var y = 0; y < s_Side; ++y)
        {
            for (var x = 0; x < s_Side; ++x)
            {
                var s_X = 2 * System.Math.Clamp(x - s_Border, 0, s_Inner);
                var s_Y = 2 * System.Math.Clamp(y - s_Border, 0, s_Inner);
                var s_QuadX = s_X > s_Inner ? 1 : 0;
                var s_QuadY = s_Y > s_Inner ? 1 : 0;
                var s_Child = s_Children[s_QuadX + 2 * s_QuadY];
                var s_Value = Read(s_Child.EmbeddedData, s_X - s_QuadX * s_Inner + s_Border + (s_Y - s_QuadY * s_Inner + s_Border) * s_Side);
                s_Samples[2 * (x + y * s_Side)] = (byte)s_Value;
                s_Samples[2 * (x + y * s_Side) + 1] = (byte)(s_Value >> 8);
            }
        }

        var s_MinMax = new byte[p_Heights.MinMaxStackSize * 2];
        var s_Offset = 0;
        var s_ChildOffset = 0;
        for (var s_Level = 0; s_Level < p_Heights.MinMaxStackDepth; ++s_Level)
        {
            var s_LevelSide = 1 << s_Level;
            for (var y = 0; y < s_LevelSide; ++y)
            {
                for (var x = 0; x < s_LevelSide; ++x)
                {
                    ushort s_Min, s_Max;
                    if (s_Level == 0)
                    {
                        s_Min = s_Children.Min(p_C => Read(p_C.MinMaxData, 0));
                        s_Max = s_Children.Max(p_C => Read(p_C.MinMaxData, 1));
                    }
                    else
                    {
                        var s_Half = s_LevelSide / 2;
                        var s_Child = s_Children[x / s_Half + 2 * (y / s_Half)];
                        var s_Pair = s_ChildOffset + x % s_Half + y % s_Half * s_Half;
                        s_Min = Read(s_Child.MinMaxData, 2 * s_Pair);
                        s_Max = Read(s_Child.MinMaxData, 2 * s_Pair + 1);
                    }

                    var s_Index = 4 * (s_Offset + x + y * s_LevelSide);
                    s_MinMax[s_Index] = (byte)s_Min;
                    s_MinMax[s_Index + 1] = (byte)(s_Min >> 8);
                    s_MinMax[s_Index + 2] = (byte)s_Max;
                    s_MinMax[s_Index + 3] = (byte)(s_Max >> 8);
                }
            }

            if (s_Level > 0)
                s_ChildOffset += (s_LevelSide / 2) * (s_LevelSide / 2);
            s_Offset += s_LevelSide * s_LevelSide;
        }

        p_Node.HasBeenPruned = false;
        p_Node.HasData = true;
        p_Node.HasPersistent = true;
        p_Node.EmbeddedData = s_Samples;
        p_Node.MinMaxData = s_MinMax;
        p_Node.OccluderGridData = new byte[p_Heights.OccluderGridStackSize * 2];
    }

    /// <summary>The samples with each zero, no ground, raised to the lowest ground sample.</summary>
    private static byte[] WithoutHoles(byte[] p_Samples, Counts p_Counts)
    {
        var s_Samples = new ushort[p_Samples.Length / 2];
        Buffer.BlockCopy(p_Samples, 0, s_Samples, 0, p_Samples.Length);
        var s_Ground = s_Samples.Where(p_S => p_S != 0).DefaultIfEmpty().Min();
        for (var i = 0; i < s_Samples.Length; ++i)
        {
            if (s_Samples[i] != 0)
                continue;

            s_Samples[i] = s_Ground;
            ++p_Counts.Holes;
        }

        var s_Data = new byte[p_Samples.Length];
        Buffer.BlockCopy(s_Samples, 0, s_Data, 0, s_Data.Length);
        return s_Data;
    }

    /// <summary>
    /// A pruned colour node's DXT1 tile from its children's, as Frostbite 2 retries a terrain tile at
    /// ever coarser colour until it finds a loaded node and never finds one under a pruned root: each
    /// sample the average of the 2x2 child samples it covers, edge samples clamped, a child without a
    /// tile the 50% grey Frostbite 2 draws for one.
    /// </summary>
    private static byte[] ColorFromChildren(Frostbite2ColorTree.Node p_Node, int p_Side, int p_Border)
    {
        var s_Inner = p_Side - 2 * p_Border;
        var s_Children = new uint[]?[4];
        foreach (var s_Child in p_Node.Children.Cast<Frostbite2ColorTree.Node>())
            s_Children[(s_Child.ID.IndexX - 2 * p_Node.ID.IndexX) + 2 * (s_Child.ID.IndexY - 2 * p_Node.ID.IndexY)] =
                s_Child is { HasData: true, Samples.Length: > 0 } ? DecodeDxt1(s_Child.Samples, p_Side) : null;

        uint Sample(int p_X, int p_Y)
        {
            var s_Child = s_Children[p_X / s_Inner + 2 * (p_Y / s_Inner)];
            return s_Child == null ? 0x808080u : s_Child[p_X % s_Inner + p_Border + (p_Y % s_Inner + p_Border) * p_Side];
        }

        var s_Pixels = new uint[p_Side * p_Side];
        for (var y = 0; y < p_Side; ++y)
        {
            for (var x = 0; x < p_Side; ++x)
            {
                var s_X = 2 * System.Math.Clamp(x - p_Border, 0, s_Inner - 1);
                var s_Y = 2 * System.Math.Clamp(y - p_Border, 0, s_Inner - 1);
                uint s_R = 0, s_G = 0, s_B = 0;
                foreach (var s_C in (uint[])[Sample(s_X, s_Y), Sample(s_X + 1, s_Y), Sample(s_X, s_Y + 1), Sample(s_X + 1, s_Y + 1)])
                {
                    s_R += s_C >> 16 & 0xFF;
                    s_G += s_C >> 8 & 0xFF;
                    s_B += s_C & 0xFF;
                }

                s_Pixels[x + y * p_Side] = (s_R + 2) / 4 << 16 | (s_G + 2) / 4 << 8 | (s_B + 2) / 4;
            }
        }

        return EncodeDxt1(s_Pixels, p_Side);
    }

    private static uint Rgb565(ushort p_Color) =>
        (uint)((p_Color >> 11 & 0x1F) * 255 / 31) << 16 | (uint)((p_Color >> 5 & 0x3F) * 255 / 63) << 8 | (uint)((p_Color & 0x1F) * 255 / 31);

    private static uint Mix(uint p_A, uint p_B, int p_WeightA, int p_WeightB)
    {
        uint Channel(int p_Shift) => (uint)(((p_A >> p_Shift & 0xFF) * p_WeightA + (p_B >> p_Shift & 0xFF) * p_WeightB) / (p_WeightA + p_WeightB)) << p_Shift;
        return Channel(16) | Channel(8) | Channel(0);
    }

    private static uint[] Palette(ushort p_Color0, ushort p_Color1)
    {
        var s_A = Rgb565(p_Color0);
        var s_B = Rgb565(p_Color1);
        return p_Color0 > p_Color1 ? [s_A, s_B, Mix(s_A, s_B, 2, 1), Mix(s_A, s_B, 1, 2)] : [s_A, s_B, Mix(s_A, s_B, 1, 1), 0];
    }

    /// <summary>A DXT1 image's samples as 0xRRGGBB, its side a whole number of blocks or less.</summary>
    private static uint[] DecodeDxt1(byte[] p_Data, int p_Side)
    {
        var s_Blocks = (p_Side + 3) / 4;
        var s_Pixels = new uint[p_Side * p_Side];
        for (var s_Block = 0; s_Block < s_Blocks * s_Blocks; ++s_Block)
        {
            var s_Offset = 8 * s_Block;
            var s_Palette = Palette(BitConverter.ToUInt16(p_Data, s_Offset), BitConverter.ToUInt16(p_Data, s_Offset + 2));
            var s_Indices = BitConverter.ToUInt32(p_Data, s_Offset + 4);
            for (var i = 0; i < 16; ++i)
            {
                var s_X = s_Block % s_Blocks * 4 + i % 4;
                var s_Y = s_Block / s_Blocks * 4 + i / 4;
                if (s_X < p_Side && s_Y < p_Side)
                    s_Pixels[s_X + s_Y * p_Side] = s_Palette[s_Indices >> 2 * i & 3];
            }
        }

        return s_Pixels;
    }

    /// <summary>Samples as DXT1, each block between its darkest and brightest channels.</summary>
    private static byte[] EncodeDxt1(uint[] p_Pixels, int p_Side)
    {
        static ushort To565(uint p_C) => (ushort)((p_C >> 16 & 0xFF) * 31 / 255 << 11 | (p_C >> 8 & 0xFF) * 63 / 255 << 5 | (p_C & 0xFF) * 31 / 255);

        var s_Blocks = (p_Side + 3) / 4;
        var s_Data = new byte[s_Blocks * s_Blocks * 8];
        var s_Block = new uint[16];
        for (var b = 0; b < s_Blocks * s_Blocks; ++b)
        {
            uint s_Min = 0xFFFFFF, s_Max = 0;
            for (var i = 0; i < 16; ++i)
            {
                var s_X = System.Math.Min(b % s_Blocks * 4 + i % 4, p_Side - 1);
                var s_Y = System.Math.Min(b / s_Blocks * 4 + i / 4, p_Side - 1);
                var s_C = s_Block[i] = p_Pixels[s_X + s_Y * p_Side];
                s_Min = System.Math.Min(s_Min >> 16 & 0xFF, s_C >> 16 & 0xFF) << 16 | System.Math.Min(s_Min >> 8 & 0xFF, s_C >> 8 & 0xFF) << 8 | System.Math.Min(s_Min & 0xFF, s_C & 0xFF);
                s_Max = System.Math.Max(s_Max >> 16 & 0xFF, s_C >> 16 & 0xFF) << 16 | System.Math.Max(s_Max >> 8 & 0xFF, s_C >> 8 & 0xFF) << 8 | System.Math.Max(s_Max & 0xFF, s_C & 0xFF);
            }

            var s_Color0 = To565(s_Max);
            var s_Color1 = To565(s_Min);
            if (s_Color0 < s_Color1)
                (s_Color0, s_Color1) = (s_Color1, s_Color0);
            var s_Palette = Palette(s_Color0, s_Color1);
            var s_Count = s_Color0 > s_Color1 ? 4 : 1;
            uint s_Indices = 0;
            for (var i = 0; i < 16; ++i)
            {
                var s_Best = 0;
                var s_BestError = int.MaxValue;
                for (var k = 0; k < s_Count; ++k)
                {
                    int Diff(int p_Shift) => (int)(s_Block[i] >> p_Shift & 0xFF) - (int)(s_Palette[k] >> p_Shift & 0xFF);
                    var s_Error = Diff(16) * Diff(16) + Diff(8) * Diff(8) + Diff(0) * Diff(0);
                    if (s_Error < s_BestError)
                        (s_Best, s_BestError) = (k, s_Error);
                }

                s_Indices |= (uint)s_Best << 2 * i;
            }

            BitConverter.TryWriteBytes(s_Data.AsSpan(8 * b), s_Color0);
            BitConverter.TryWriteBytes(s_Data.AsSpan(8 * b + 2), s_Color1);
            BitConverter.TryWriteBytes(s_Data.AsSpan(8 * b + 4), s_Indices);
        }

        return s_Data;
    }
}
