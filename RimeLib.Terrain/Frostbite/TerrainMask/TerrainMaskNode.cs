namespace RimeLib.Terrain.Frostbite.TerrainMask;

/// <summary>
/// One node of a terrain mask tree: how strongly each layer covers each sample, run-length encoded.
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

    /// <summary>The encoded samples, decoded a line at a time against <see cref="LineSizes"/>.</summary>
    public byte[] RleData { get; set; } = System.Array.Empty<byte>();

    /// <summary>How many encoded bytes each line of the node occupies.</summary>
    public ushort[] LineSizes { get; set; } = System.Array.Empty<ushort>();
}
