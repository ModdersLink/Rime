namespace RimeLib.Terrain.Frostbite.TerrainMask;

/// <summary>
/// One node of a terrain mask tree: how strongly each layer covers each sample of its patch.
/// </summary>
public class TerrainMaskNode
{
    public ushort Level { get; set; }
    public ushort IndexX { get; set; }
    public ushort IndexY { get; set; }

    public float MinX { get; set; }
    public float MinY { get; set; }
    public float MaxX { get; set; }
    public float MaxY { get; set; }

    /// <summary>
    /// Which of this node's descendants carry samples, one bit each in quadtree order. Eleven
    /// bytes covers the 85 nodes of a four-level quadtree (1 + 4 + 16 + 64).
    /// </summary>
    public byte[] PresenceMask { get; set; } = System.Array.Empty<byte>();

    /// <summary>Flags stored alongside the presence mask; the low bytes are its length.</summary>
    public uint Flags { get; set; }

    /// <summary>
    /// The node's samples, NodeSamplesPerSide squared of them. Unlike the material tree these are
    /// not run-length encoded -- they are stored flat, one byte per sample.
    /// </summary>
    public byte[] Samples { get; set; } = System.Array.Empty<byte>();
}
