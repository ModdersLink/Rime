namespace RimeLib.Texture.Frostbite
{
    /// <summary>
    /// Texture format information
    /// </summary>
    public enum TextureFormat : uint
    {
        /// <summary>
        /// DXT1 = BC1
        /// </summary>
        TextureFormat_Dxt1 = 0,

        /// <summary>
        /// DXT1A 
        /// </summary>
        TextureFormat_Dxt1A = 1,

        /// <summary>
        /// DXT3 = BC2
        /// </summary>
        TextureFormat_Dxt3 = 2,

        /// <summary>
        /// DXT5 = BC3
        /// </summary>
        TextureFormat_Dxt5 = 3,

        /// <summary>
        /// DXT5A = BC4
        /// </summary>
        TextureFormat_Dxt5A = 4,

        /// <summary>
        /// DXN = BC5
        /// </summary>
        TextureFormat_Dxn = 5,

        /// <summary>
        /// BC7
        /// </summary>
        TextureFormat_Bc7 = 6,

        /// <summary>
        /// RGB565
        /// </summary>
        TextureFormat_Rgb565 = 7,

        /// <summary>
        /// RGB888
        /// </summary>
        TextureFormat_Rgb888 = 8,

        /// <summary>
        /// ARGB1555
        /// </summary>
        TextureFormat_Argb1555 = 9,

        /// <summary>
        /// ARGB4444
        /// </summary>
        TextureFormat_Argb4444 = 10,

        /// <summary>
        /// ARGB8888
        /// </summary>
        TextureFormat_Argb8888 = 11,

        /// <summary>
        /// L8
        /// </summary>
        TextureFormat_L8 = 12,

        /// <summary>
        /// L16
        /// </summary>
        TextureFormat_L16 = 13,

        /// <summary>
        /// ABGR16
        /// </summary>
        TextureFormat_Abgr16 = 14,

        /// <summary>
        /// ABGR16 Floating Point
        /// </summary>
        TextureFormat_Abgr16F = 15,

        /// <summary>
        /// ABGR32 Floating Point
        /// </summary>
        TextureFormat_Abgr32F = 16,

        /// <summary>
        /// R16 Floating Point
        /// </summary>
        TextureFormat_R16F = 17,

        /// <summary>
        /// R32 Floating Point
        /// </summary>
        TextureFormat_R32F = 18,

        /// <summary>
        /// Normal DXN
        /// </summary>
        TextureFormat_NormalDxn = 19,

        /// <summary>
        /// Normal DXT1
        /// </summary>
        TextureFormat_NormalDxt1 = 20,

        /// <summary>
        /// Normal DXT5 | BC3
        /// </summary>
        TextureFormat_NormalDxt5 = 21,

        /// <summary>
        /// Normal DXT5 RGA
        /// </summary>
        TextureFormat_NormalDxt5Rga = 22,

        /// <summary>
        /// RG8
        /// </summary>
        TextureFormat_Rg8 = 23,

        /// <summary>
        /// GR16
        /// </summary>
        TextureFormat_Gr16 = 24,

        /// <summary>
        /// GR16 Floating Point
        /// </summary>
        TextureFormat_Gr16F = 25,

        /// <summary>
        /// D16
        /// </summary>
        TextureFormat_D16 = 26,

        /// <summary>
        /// D24S8
        /// </summary>
        TextureFormat_D24S8 = 27,

        /// <summary>
        /// D24Fs8
        /// </summary>
        TextureFormat_D24Fs8 = 28,

        /// <summary>
        /// D32 Floating Point
        /// </summary>
        TextureFormat_D32F = 29,

        /// <summary>
        /// D32Fs8
        /// </summary>
        TextureFormat_D32Fs8 = 30,

        /// <summary>
        /// S8
        /// </summary>
        TextureFormat_S8 = 31,

        /// <summary>
        /// ABGR32
        /// </summary>
        TextureFormat_Abgr32 = 32,

        /// <summary>
        /// GR32 Floating Point
        /// </summary>
        TextureFormat_Gr32F = 33,

        /// <summary>
        /// A2R10G10B10
        /// </summary>
        TextureFormat_A2R10G10B10 = 34,

        /// <summary>
        /// R11G11B10 Floating Point
        /// </summary>
        TextureFormat_R11G11B10F = 35,

        /// <summary>
        /// ABGR16 Snorm
        /// </summary>
        TextureFormat_Abgr16_Snorm = 36,

        /// <summary>
        /// ABGR16 Unsigned Int
        /// </summary>
        TextureFormat_Abgr16_Uint = 37,

        /// <summary>
        /// !!!!! Unknown in fb2 !!!!!
        /// L16 Unsigned Integer
        /// </summary>
        TextureFormat_FB2_Unknown = 38,
        TextureFormat_L16_Uint = 38,
        

        /// <summary>
        /// Invalid in fb2
        /// L32
        /// </summary>
        TextureFormat_L32 = 39,

        /// <summary>
        /// Invalid in fb2
        /// GR16 Unsigned Integer
        /// </summary>
        TextureFormat_GR16_Uint = 40,

        /// <summary>
        /// Invalid in fb2
        /// GR32 Unsigned Integer
        /// </summary>
        TextureFormat_GR32_Uint = 41,

        /// <summary>
        /// Invalid in fb2
        /// L32
        /// </summary>
        TextureFormat_R9G9B9E5F = 42,

        /// <summary>
        /// Invalid in fb2
        /// L32
        /// </summary>
        TextureFormat_Unknown = 43
    }



    
}
