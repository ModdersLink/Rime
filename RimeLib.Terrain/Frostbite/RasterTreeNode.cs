using RimeLib.IO;
using System;


namespace RimeLib.Terrain.Frostbite;
public class RasterTreeNode
{
    public ushort FirstChildIndex { get; set; }
    public ushort Flags { get; set; }
    public QuadtreeNodeId ID { get; set; } = new QuadtreeNodeId();
    public RasterTreeNode[] Children { get; set; } = Array.Empty<RasterTreeNode>();

    public RasterTreeNode()
    {
        FirstChildIndex = 0xFFFF;
        Flags = 0;
        ID = new QuadtreeNodeId();
    }

    public RasterTreeNode(RimeReader p_Reader)
    {

    }
}
