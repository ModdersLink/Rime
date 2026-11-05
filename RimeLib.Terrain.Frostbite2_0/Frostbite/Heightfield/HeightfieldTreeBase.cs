namespace RimeLib.Terrain.Frostbite2_0.Frostbite.Heightfield;
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

    /// <summary>
    /// The sizes of a node's min/max stack (two values per sample, each level half the side of the
    /// one before) and occluder grid stack (one value per grid point), from their depths.
    /// </summary>
    protected void ComputeStackSizes()
    {
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
    }

    /// <summary>The heightfield node with the given id, or null when the tree has none.</summary>
    public HeightfieldTreeNode? TryFindNode(QuadtreeNodeId p_Id) => HeightfieldRootNode == null ? null : Find(HeightfieldRootNode, p_Id);

    private static HeightfieldTreeNode? Find(HeightfieldTreeNode p_Node, QuadtreeNodeId p_Id)
    {
        if (p_Node.ID == p_Id)
            return p_Node;

        foreach (var s_Child in p_Node.Children ?? [])
        {
            if (s_Child is HeightfieldTreeNode s_Node && Find(s_Node, p_Id) is { } s_Found)
                return s_Found;
        }

        return null;
    }
}

