using RimeLib.Frostbite.Core;
using System;

namespace RimeLib.Terrain.Frostbite.Heightfield;
public class HeightfieldNode
{
    public HeightfieldTreeNode TreeNode { get; set; } = new HeightfieldTreeNode();

    public QuadtreeNodeId ID { get; set; } = new QuadtreeNodeId();

    public GUID Lod0ChunkID { get; set; } = GUID.Empty;
    public uint Lod0ChunkSize { get; set; }

    public GUID Lod1ChunkID { get; set; } = GUID.Empty;
    public uint Lod1ChunkSize { get; set; }

    public bool PersistentDedicatedServer { get; set; }

    public HeightfieldNode[] Children { get; set; } = Array.Empty<HeightfieldNode>();
}

