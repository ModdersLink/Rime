using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

/// <summary>One node of a terrain heightfield quadtree, free of any engine's own types.</summary>
public class TerrainHeightfieldNode
{
    public int Depth { get; set; }

    /// <summary>Where the node sits in its level of the quadtree.</summary>
    public int IndexX { get; set; }
    public int IndexY { get; set; }

    /// <summary>
    /// Whether this node has no children. The heightfield tree is adaptive like the streaming tree
    /// beside it -- MP_001 has one node at depth 0, four at 1, five at 2 and twenty at 3 -- so its
    /// leaves are the set that covers the map, and its deepest level covers under a third of it.
    /// </summary>
    public bool Leaf { get; set; }

    /// <summary>World-space bounds: x, y, z.</summary>
    public float[] Min { get; set; } = new float[3];
    public float[] Max { get; set; } = new float[3];

    public float SamplesPerMeter { get; set; }

    /// <summary>Height samples carried in the tree itself, if any (bytes, UInt16 each).</summary>
    public byte[] Embedded { get; set; } = System.Array.Empty<byte>();

    public uint Flags { get; set; }
}

/// <summary>
/// One node of the material tree: which material covers which sample, still run-length encoded.
/// </summary>
public class TerrainMaterialSamples
{
    public int Level { get; set; }
    public int IndexX { get; set; }
    public int IndexY { get; set; }
    /// <summary>World-space coverage of the node: x, y (the terrain plane).</summary>
    public float[] Min { get; set; } = new float[2];
    public float[] Max { get; set; } = new float[2];
    /// <summary>The encoded samples, decoded a line at a time against <see cref="LineSizes"/>.</summary>
    public byte[] Rle { get; set; } = System.Array.Empty<byte>();
    public ushort[] LineSizes { get; set; } = System.Array.Empty<ushort>();
}

/// <summary>
/// One node of the streaming tree: where it sits, and the chunk its height samples stream from.
/// </summary>
public class TerrainStreamNode
{
    public int Depth { get; set; }
    public int IndexX { get; set; }
    public int IndexY { get; set; }
    /// <summary>The chunk holding this node's samples, as a guid string.</summary>
    public string Lod0Chunk { get; set; } = string.Empty;
    public uint Lod0Size { get; set; }
    public string Lod1Chunk { get; set; } = string.Empty;
    public uint Lod1Size { get; set; }
    /// <summary>World bounds, where a heightfield node backs this one.</summary>
    public float[]? Min { get; set; }
    public float[]? Max { get; set; }

    /// <summary>
    /// Whether this node has no children, and so is one of the tiles that actually covers ground.
    /// </summary>
    /// <remarks>
    /// The tree is adaptive -- MP_017 subdivides to depth 6 in places and stops at 3 in others --
    /// so drawing "the deepest nodes" leaves holes wherever the tree stopped early. The leaves are
    /// the set that tiles the map exactly once.
    /// </remarks>
    public bool Leaf { get; set; }
}

public class TerrainHeightfield
{
    /// <summary>Material indices the level's terrain uses, and the one covering everything else.</summary>
    public List<uint> MaterialPairIndices { get; set; } = new();
    public uint BackgroundMaterialIndex { get; set; }
    public bool HasMaterialTree { get; set; }
    /// <summary>How many samples a material-tree node holds along one side.</summary>
    public uint MaterialSamplesPerSide { get; set; }
    /// <summary>The material tree's nodes, where it carries any.</summary>
    public List<TerrainMaterialSamples> MaterialNodes { get; set; } = new();

    /// <summary>How deep the ground has been destroyed, per sample, where the tree carries it.</summary>
    public List<TerrainMaterialSamples> DestructionNodes { get; set; } = new();

    public uint DestructionSamplesPerSide { get; set; }

    /// <summary>
    /// The mask tree's nodes, in the same shape as the material ones.
    ///
    /// The material tree says WHICH two materials meet at a texel; this says HOW MUCH of each.
    /// Without it a consumer can only pick one material per texel, which draws hard mosaic edges
    /// where the engine draws a blend. Read all along -- only Raw was ever carried out.
    /// </summary>
    public List<TerrainMaterialSamples> MaskNodes { get; set; } = new();
    /// <summary>The mask tree's block as stored, while its layout is being worked out.</summary>
    public byte[] MaskRaw { get; set; } = System.Array.Empty<byte>();

    /// <summary>Whether the mask tree serialises back to exactly the bytes it was read from.</summary>
    public bool MaskRewritesExactly { get; set; }

    /// <summary>
    /// Whether the heightfield tree re-serialises to the bytes it was read from, and how much of
    /// its block the parse does not model. The heightfield is the tree the terrain surface itself
    /// lives in, so a writer that cannot reproduce it is a writer that cannot ship a terrain edit.
    /// </summary>
    public bool HeightfieldRewritesExactly { get; set; }
    public int HeightfieldRawLength { get; set; }
    public int HeightfieldTrailing { get; set; }

    /// <summary>Whether the material and destruction trees re-serialise to their shipped bytes.</summary>
    public bool MaterialRewritesExactly { get; set; }
    public bool DestructionRewritesExactly { get; set; }

    /// <summary>
    /// Whether the WHOLE streaming tree -- header, every raster tree, and the stream nodes --
    /// re-serialises to its shipped bytes. The per-tree flags say the pieces survive; this says the
    /// container that holds them does, which is what shipping an edited terrain actually needs.
    /// </summary>
    public bool StreamingTreeRewritesExactly { get; set; }
    public int StreamingTreeRawLength { get; set; }
    public int StreamingTreeWrittenLength { get; set; }
    public int StreamingTreeFirstDiff { get; set; }

    /// <summary>Diagnostic for the rewrite: group/header/trailing sizes against the source block.</summary>
    public string MaskRewriteInfo { get; set; } = string.Empty;
    public long MaskConsumed { get; set; }
    public uint MaskSamplesPerSide { get; set; }

    /// <summary>type:size for every raster tree the stream declared.</summary>
    public List<string> RasterTrees { get; set; } = new();

    public uint SamplesPerSide { get; set; }

        /// <summary>
        /// How many rows of stitching skirt sit around each node's samples. The interior is
        /// SamplesPerSide - 2 * NodeBorderWidth wide, and it is the interior alone that covers the
        /// node's box -- treating every sample as terrain stretches the field and draws the skirt
        /// as ground, which shows up as nodes disagreeing by metres along their shared edges.
        /// </summary>
        public uint NodeBorderWidth { get; set; }
    public float WorldSizeY { get; set; }
    public float WorldScaleY { get; set; }
    public List<TerrainHeightfieldNode> Nodes { get; set; } = new();
    /// <summary>The streaming tree's own nodes, which name the chunks heights come from.</summary>
    public List<TerrainStreamNode> StreamNodes { get; set; } = new();
}

/// <summary>Reads a terrain streaming tree's heightfield, which is where a level's ground surface
/// lives -- nothing in EBX describes it.</summary>
public interface ITerrainHeightfield : IEngineInterface
{
    bool ReadHeightfield(IResourceObject p_Resource, IEngineMounter p_Mounter, out TerrainHeightfield? p_Heightfield);
}
