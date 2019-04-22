namespace RimeLib.Mesh.Frostbite
{
    /// <summary>
    /// Model primitive type
    /// </summary>
    public enum PrimitiveType : byte
    {
        /// <summary>
        /// Point List
        /// </summary>
        PrimitiveType_PointList = 0x0,

        /// <summary>
        /// Line List
        /// </summary>
        PrimitiveType_LineList = 0x1,
        
        /// <summary>
        /// Line Strip
        /// </summary>
        PrimitiveType_LineStrip = 0x2,

        /// <summary>
        /// Triangle List
        /// </summary>
        PrimitiveType_TriangleList = 0x3,

        /// <summary>
        /// Triangle Strip
        /// </summary>
        PrimitiveType_TriangleStrip = 0x5,

        /// <summary>
        /// Quad List
        /// </summary>
        PrimitiveType_QuadList = 0x7,

        /// <summary>
        /// Xbox 360 Rectange List
        /// </summary>
        PrimitiveType_XenonRectList = 0x8,
    }
}
