
namespace RimeLib.Terrain.Frostbite.Heightfield;
public abstract class HeightfieldTreeBase : RasterTree
{
    
    public uint NodeSamplesPerSide { get; set; }
    public uint ResourceAtlasSampleCountX { get; set; }
    public uint ResourceAtlasSampleCountY { get; set; }
    public uint ResourceBlurrinessFactor { get; set; }
    public float WorldSizeY { get; set; }
    public float WorldScaleY { get; set; }
    public bool Ps3RsxHeightfieldEnable { get; set; }
    public float Ps3RsxHeightfieldCacheFraction { get; set; }
    public uint MinMaxStackDepth { get; set; }
    public uint OccluderGridStackDepth { get; set; }

    public uint DensityMapNodeSamplesPerSide { get; set; }
    public uint DensityMapBorderWidth { get; set; }
    public uint DensityMapNodeSamplesPerSidePot { get; set; }
    public float DensityMapResolutionRatio { get; set; }

    public uint NodeCount { get; set; }
    public uint PersistentNodeCount { get; set; }
    public uint NodeBorderWidth { get; set; }
    public uint MinMaxStackSize { get; set; }
    public uint OccluderGridStackSize { get; set; }

    public uint LevelMax { get; set; }

    public ushort FirstChildIndex { get; set; }

    public HeightfieldTreeNode? HeightfieldRootNode => RootNode as HeightfieldTreeNode;
}

