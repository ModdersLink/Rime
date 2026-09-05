using fb;
using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite.Destruction;

public class DestructionDepthTreeNode : RasterTreeNode
{
	public AxisAlignedBox? WorldCoverage { get; set; } = new AxisAlignedBox();

	/// <summary>The encoded samples, run-length encoded as the material tree's are.</summary>
	public byte[] RleData { get; set; } = System.Array.Empty<byte>();

	/// <summary>How many encoded bytes each line of the node occupies.</summary>
	public ushort[] LineSizes { get; set; } = System.Array.Empty<ushort>();

	/// <summary>
	/// The two flags that shape the node in the file. Flags carries the first as bit 0x10; the
	/// second is not recorded there, and a node with data but no persistent copy writes no samples,
	/// so both are needed to put the node back.
	/// </summary>
	public bool HasData { get; set; }
	public bool HasPersistent { get; set; }
}
