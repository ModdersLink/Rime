
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

    /// <summary>
    /// Header fields the reader used to consume into locals and drop.
    ///
    /// <see cref="ResourceBlurrinessFactor"/> is stored as a shift, and 1 &lt;&lt; n cannot be
    /// turned back into n for n = 0 without knowing that is what happened, so the exponent is kept
    /// as read. <see cref="PersistentDedicatedServerNodeCount"/> is kept apart from
    /// <see cref="PersistentNodeCount"/> for the same reason: the reader adds the two together,
    /// and a sum does not say what its parts were.
    /// </summary>
    public int ResourceBlurrinessFactorExponent { get; set; }
    public float PhysicsMetersPerSample { get; set; }
    public float PhysicsCropWidth { get; set; }
    public uint PersistentDedicatedServerNodeCount { get; set; }

    /// <summary>The block as it was read, for measuring a rewrite against.</summary>
    public byte[] Raw { get; set; } = System.Array.Empty<byte>();

    /// <summary>Anything after the root node that this does not yet model.</summary>
    public byte[] Trailing { get; set; } = System.Array.Empty<byte>();
    public uint NodeBorderWidth { get; set; }
    public uint MinMaxStackSize { get; set; }
    public uint OccluderGridStackSize { get; set; }

    public uint LevelMax { get; set; }

    public ushort FirstChildIndex { get; set; }

    public HeightfieldTreeNode? HeightfieldRootNode => RootNode as HeightfieldTreeNode;
}

