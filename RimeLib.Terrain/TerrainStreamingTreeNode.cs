namespace RimeLib.Terrain
{
    public class TerrainStreamingTreeNode
    {
        public QuadtreeNodeId Id { get; set; } = QuadtreeNodeId.Empty;

        public byte Flags { get; set; }
    }
}
