using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

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
