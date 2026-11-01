using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

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
