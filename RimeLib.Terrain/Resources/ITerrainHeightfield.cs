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

public class TerrainHeightfield
{
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
