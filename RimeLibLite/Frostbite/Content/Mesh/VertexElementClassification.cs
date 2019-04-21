namespace RimeLib.Frostbite.Content.Mesh
{
    /// <summary>
    /// Vertex element classification
    /// </summary>
    public enum VertexElementClassification : byte
    {
        /// <summary>
        /// Classification if per-vertex
        /// </summary>
        VertexElementClassification_PerVertex = 0x0,

        /// <summary>
        /// Classification if per-instance
        /// </summary>
        VertexElementClassification_PerInstance = 0x1,

        /// <summary>
        /// Classification index
        /// </summary>
        VertexElementClassification_Index = 0x2,
    }
}
