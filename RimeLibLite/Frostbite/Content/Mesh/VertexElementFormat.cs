namespace RimeLib.Frostbite.Content.Mesh
{
    /// <summary>
    /// Vertex element format
    /// </summary>
    public enum VertexElementFormat : byte
    {
        /// <summary>
        /// No Format
        /// </summary>
        VertexElementFormat_None = 0x0,

        /// <summary>
        /// Single float
        /// </summary>
        VertexElementFormat_Float = 0x1,

        /// <summary>
        /// 2 floats
        /// </summary>
        VertexElementFormat_Float2 = 0x2,

        /// <summary>
        /// 3 floats
        /// </summary>
        VertexElementFormat_Float3 = 0x3,

        /// <summary>
        /// 4 floats
        /// </summary>
        VertexElementFormat_Float4 = 0x4,

        /// <summary>
        /// Single half-float (16 bit floating point percision)
        /// </summary>
        VertexElementFormat_Half = 0x5,

        /// <summary>
        /// 2 half-floats
        /// </summary>
        VertexElementFormat_Half2 = 0x6,

        /// <summary>
        /// 3 half-floats
        /// </summary>
        VertexElementFormat_Half3 = 0x7,

        /// <summary>
        /// 4 half-flats
        /// </summary>
        VertexElementFormat_Half4 = 0x8,

        /// <summary>
        /// Unsigned byte N (unconfirmed)
        /// </summary>
        VertexElementFormat_UByteN = 0x32,

        /// <summary>
        /// 4 signed bytes (unconfirmed)
        /// </summary>
        VertexElementFormat_Byte4 = 0xA,

        /// <summary>
        /// 4 signed bytes N (unconfirmed)
        /// </summary>
        VertexElementFormat_Byte4N = 0xB,

        /// <summary>
        /// 4 unsigned bytes
        /// </summary>
        VertexElementFormat_UByte4 = 0xC,

        /// <summary>
        /// 4 unsigned bytes N (unconfirmed)
        /// </summary>
        VertexElementFormat_UByte4N = 0xD,

        /// <summary>
        /// Signed short
        /// </summary>
        VertexElementFormat_Short = 0xE,

        /// <summary>
        /// 2 signed shorts
        /// </summary>
        VertexElementFormat_Short2 = 0xF,

        /// <summary>
        /// 3 signed shorts
        /// </summary>
        VertexElementFormat_Short3 = 0x10,

        /// <summary>
        /// 4 signed shorts
        /// </summary>
        VertexElementFormat_Short4 = 0x11,

        /// <summary>
        /// Signed short N (unconfirmed)
        /// </summary>
        VertexElementFormat_ShortN = 0x12,

        /// <summary>
        /// 2 signed shorts N (unconfirmed)
        /// </summary>
        VertexElementFormat_Short2N = 0x13,

        /// <summary>
        /// 3 signed shorts N (unconfirmed)
        /// </summary>
        VertexElementFormat_Short3N = 0x14,

        /// <summary>
        /// 4 signed shorts N (unconfirmed)
        /// </summary>
        VertexElementFormat_Short4N = 0x15,

        /// <summary>
        /// 2 unsigned shorts
        /// </summary>
        VertexElementFormat_UShort2 = 0x16,

        /// <summary>
        /// 4 unsigned shorts
        /// </summary>
        VertexElementFormat_UShort4 = 0x17,

        /// <summary>
        /// 2 unsigned shorts N (unconfirmed)
        /// </summary>
        VertexElementFormat_UShort2N = 0x18,

        /// <summary>
        /// 4 unsigned shorts N (unconfirmed)
        /// </summary>
        VertexElementFormat_UShort4N = 0x19,

        /// <summary>
        /// Single int
        /// </summary>
        VertexElementFormat_Int = 0x1A,

        /// <summary>
        /// 2 ints
        /// </summary>
        VertexElementFormat_Int2 = 0x1B,

        /// <summary>
        /// 3 ints
        /// </summary>
        VertexElementFormat_Int3 = 0x33,

        /// <summary>
        /// 4 ints
        /// </summary>
        VertexElementFormat_Int4 = 0x1C,

        /// <summary>
        /// int N (unconfirmed)
        /// </summary>
        VertexElementFormat_IntN = 0x1D,

        /// <summary>
        /// 2 ints N (unconfirmed)
        /// </summary>
        VertexElementFormat_Int2N = 0x1E,

        /// <summary>
        /// 4 ints N (unconfirmed)
        /// </summary>
        VertexElementFormat_Int4N = 0x1F,

        /// <summary>
        /// Single unsigned int
        /// </summary>
        VertexElementFormat_UInt = 0x20,

        /// <summary>
        /// 2 unsigned ints
        /// </summary>
        VertexElementFormat_UInt2 = 0x21,

        /// <summary>
        /// 3 unsigned ints
        /// </summary>
        VertexElementFormat_UInt3 = 0x34,

        /// <summary>
        /// 4 unsigned ints
        /// </summary>
        VertexElementFormat_UInt4 = 0x22,

        /// <summary>
        /// Single unsigned int N (unconfirmed)
        /// </summary>
        VertexElementFormat_UIntN = 0x23,

        /// <summary>
        /// 2 unsigned ints N (unconfirmed)
        /// </summary>
        VertexElementFormat_UInt2N = 0x24,

        /// <summary>
        /// 4 unsigned ints N (unconfirmed)
        /// </summary>
        VertexElementFormat_UInt4N = 0x25,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_Comp3_10_10_10 = 0x26,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_Comp3N_10_10_10 = 0x27,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_UComp3_10_10_10 = 0x28,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_UComp3N_10_10_10 = 0x29,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_Comp3_11_11_10 = 0x2A,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_Comp3N_11_11_10 = 0x2B,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_UComp3_11_11_10 = 0x2C,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_UComp3N_11_11_10 = 0x2D,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_Comp4_10_10_10_2 = 0x2E,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_Comp4N_10_10_10_2 = 0x2F,
        
        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_UComp4_10_10_10_2 = 0x30,

        /// <summary>
        /// Unknown
        /// </summary>
        VertexElementFormat_UComp4N_10_10_10_2 = 0x31,
    }
}
