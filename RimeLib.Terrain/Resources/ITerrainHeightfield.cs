using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

/// <summary>One node of a terrain heightfield quadtree, free of any engine's own types.</summary>
public class TerrainHeightfieldNode
{
    public int Depth { get; set; }

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

    /// <summary>type:size for every raster tree the stream declared.</summary>
    public List<string> RasterTrees { get; set; } = new();

    public uint SamplesPerSide { get; set; }
    public float WorldSizeY { get; set; }
    public float WorldScaleY { get; set; }
    public List<TerrainHeightfieldNode> Nodes { get; set; } = new();
}

/// <summary>Reads a terrain streaming tree's heightfield, which is where a level's ground surface
/// lives -- nothing in EBX describes it.</summary>
public interface ITerrainHeightfield : IEngineInterface
{
    bool ReadHeightfield(IResourceObject p_Resource, IEngineMounter p_Mounter, out TerrainHeightfield? p_Heightfield);
}
