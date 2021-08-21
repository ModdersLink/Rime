using System.Collections.Generic;

namespace RimeLib.Terrain
{
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

        public HeightfieldTreeBase GetHeightfieldTree()
        {
            return (HeightfieldTreeBase)RasterTrees[(int)RasterTree.RasterTreeTypes.HeightfieldTreeType];
        }

        public RasterTree GetTerrainMaskTree()
        {
            return RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainMaskTreeType];
        }

        public RasterTree GetTerrainColorTree()
        {
            return RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainColorTreeType];
        }

        public TerrainMaterialTree GetTerrainMaterialTree()
        {
            return (TerrainMaterialTree)RasterTrees[(int)RasterTree.RasterTreeTypes.TerrainMaterialTreeType];
        }

        public DestructionDepthTree GetDestructionDepthTree()
        {
            return (DestructionDepthTree)RasterTrees[(int)RasterTree.RasterTreeTypes.DestructionDepthTreeType];
        }
    }

}
