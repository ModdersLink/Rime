using fb;
using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite.Destruction;

public class DestructionDepthTreeNode : RasterTreeNode
{
	public AxisAlignedBox? WorldCoverage { get; set; } = new AxisAlignedBox();


}