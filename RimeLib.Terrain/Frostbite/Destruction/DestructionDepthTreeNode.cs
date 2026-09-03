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
}
