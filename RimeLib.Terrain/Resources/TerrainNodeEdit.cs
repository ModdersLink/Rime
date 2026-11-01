using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

/// <summary>One node's replacement samples, addressed the way the tree addresses its nodes.</summary>
public class TerrainNodeEdit
{
    public ushort Level { get; set; }
    public ushort IndexX { get; set; }
    public ushort IndexY { get; set; }
    public byte[] Samples { get; set; } = System.Array.Empty<byte>();
}
