using System;

namespace RimeLib.Mesh.Frostbite
{
    /// <summary>
    /// Flags for the mesh layout
    /// </summary>
    [Flags]
    public enum MeshLayoutFlags
    {
        /// <summary>
        /// Is this a base level of detail
        /// </summary>
        IsBaseLod = 0x1,

        /// <summary>
        /// Is streaming enabled
        /// </summary>
        StreamingEnable = 0x40,

        /// <summary>
        /// Is stream instancing enabled
        /// </summary>
        StreamInstancingEnable = 0x10,

        /// <summary>
        /// Vertex animation enabled
        /// </summary>
        VertexAnimationEnable = 0x80,

        /// <summary>
        /// Is the data available
        /// </summary>
        IsDataAvailable = 0x20000000,
    };
}
