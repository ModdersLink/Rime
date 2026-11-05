using System;
using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 heightfield node: Frostbite 2's node with the min/max stack a pruned node
/// keeps and the density map that ends a node's data.
/// </summary>
public class HeightfieldTreeNode : Frostbite2_0.Frostbite.Heightfield.HeightfieldTreeNode
{
    /// <summary>The min/max stack a pruned node keeps in place of its samples.</summary>
    public byte[] PrunedMinMaxData { get; set; } = Array.Empty<byte>();

    /// <summary>The density map samples that follow the occluder grid.</summary>
    public byte[] DensityMapData { get; set; } = Array.Empty<byte>();

    public HeightfieldTreeNode()
    {
    }

    public HeightfieldTreeNode(RimeReader p_Reader) : base(p_Reader)
    {
    }
}
