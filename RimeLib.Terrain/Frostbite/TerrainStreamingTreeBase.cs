using System.Collections.Generic;
using RimeLib.Terrain.Frostbite.Destruction;
using RimeLib.Terrain.Frostbite.Heightfield;
using RimeLib.Terrain.Frostbite.TerrainMaterial;


namespace RimeLib.Terrain.Frostbite;
public abstract class TerrainStreamingTreeBase
{
    public HeightfieldNode RootNode { get; set; } = new HeightfieldNode();
    public uint UnblurredSamplesPerNodeSidePot { get; set; }
    public bool TrackTextureDetailFalloff { get; set; }
    public float InvisibleDetailReductionFactor { get; set; }
    public float OccludedDetailReductionFactor { get; set; }
    public uint ResourceBlurriness { get; set; }
    public uint NodeCount { get; set; }
    public bool FreeStreamingEnabled { get; set; }
    public List<RasterTree> RasterTrees { get; set; } = new List<RasterTree>();


    public HeightfieldTreeBase? HeightfieldTree => RasterTrees[(int)RasterTree.RasterTreeTypes.HeightfieldTreeType] as HeightfieldTreeBase;
    public RasterTree? TerrainMaskTree => RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainMaskTreeType] as RasterTree;
    public RasterTree? TerrainColorTree => RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainColorTreeType] as RasterTree;
    public TerrainMaterialTree? TerrainMaterialTree => RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainMaterialTreeType] as TerrainMaterialTree;
    public DestructionDepthTree? DestructionTree => RasterTrees[(int)RasterTree.RasterTreeTypes.DestructionDepthTreeType] as DestructionDepthTree;


}
