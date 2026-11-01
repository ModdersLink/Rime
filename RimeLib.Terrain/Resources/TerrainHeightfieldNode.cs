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
