using RimeLib.Texture.Frostbite;
using System.Collections.Generic;

namespace RimeLib.Texture.DDS
{
    public static class DDSUtils
    {
        public static readonly Dictionary<TextureFormat, DDSPixelFormat> c_DDSFormatMap = new Dictionary<TextureFormat, DDSPixelFormat>()
        {
            { TextureFormat.TextureFormat_Dxt1, new DDSPixelFormat("DXT1") },
            { TextureFormat.TextureFormat_Dxt1A, new DDSPixelFormat("DXT1") },

            { TextureFormat.TextureFormat_Dxt3, new DDSPixelFormat("DXT3") },

            { TextureFormat.TextureFormat_Dxt5, new DDSPixelFormat("DXT5") }, //ATI1
            { TextureFormat.TextureFormat_Dxt5A, new DDSPixelFormat("ATI1") }, //ATI1N
            { TextureFormat.TextureFormat_Dxn, new DDSPixelFormat("ATI2") }, //BC5, ATI2

            { TextureFormat.TextureFormat_Bc7, new DDSPixelFormat("BC7") },

            { TextureFormat.TextureFormat_NormalDxn, new DDSPixelFormat("DXT5") }, //ATI2

            { TextureFormat.TextureFormat_NormalDxt1, new DDSPixelFormat("DXT1") },
            { TextureFormat.TextureFormat_NormalDxt5, new DDSPixelFormat("ATI1") },
            { TextureFormat.TextureFormat_NormalDxt5Rga, new DDSPixelFormat("ATI1") }, //Not sure about this one

            { TextureFormat.TextureFormat_Rgb565, new DDSPixelFormat(DDSFormatFlags.Rgb, 0, 0x0000f800, 0x000007e0, 0x0000001f) },
            { TextureFormat.TextureFormat_Rgb888, new DDSPixelFormat(DDSFormatFlags.Rgb, 0, 0x00ff0000, 0x0000ff00, 0x000000ff) },
            { TextureFormat.TextureFormat_Argb1555, new DDSPixelFormat(DDSFormatFlags.Rgba, 0, 0x00007c00, 0x000003e0, 0x0000001f, 0x00008000) },
            { TextureFormat.TextureFormat_Argb4444, new DDSPixelFormat(DDSFormatFlags.Rgba, 0, 0xF000, 0x0F00, 0x00F0, 0x000F) },
            { TextureFormat.TextureFormat_Argb8888, new DDSPixelFormat(DDSFormatFlags.Rgba, 0, 0xFF0000, 0xFF00, 0xFF, 0xFF000000 ) },

            { TextureFormat.TextureFormat_L8, new DDSPixelFormat(DDSFormatFlags.Luminance, 8, 0xFF) },
            { TextureFormat.TextureFormat_L16, new DDSPixelFormat(DDSFormatFlags.Luminance, 16, 0xFFFF) },
            { TextureFormat.TextureFormat_L16_Uint, new DDSPixelFormat(DDSFormatFlags.Luminance, 16,  0xFFFF) }, //not sure about this one
            { TextureFormat.TextureFormat_L32, new DDSPixelFormat(DDSFormatFlags.Luminance, 32, 0xFFFFFFFF) },




            { TextureFormat.TextureFormat_Rg8, new DDSPixelFormat(DDSFormatFlags.Rgb, 0, 0xFF00, 0xFF) },

            { TextureFormat.TextureFormat_Gr16, new DDSPixelFormat(DDSFormatFlags.Rgb, 16, 0xFFFF, 0xFFFF0000) },



            { TextureFormat.TextureFormat_A2R10G10B10, new DDSPixelFormat( DDSFormatFlags.Rgba, 0, 0x3FF00000, 0xFFC00, 0x3FF, 0xC0000000 ) },
        };


        public static readonly Dictionary<TextureFormat, DXGIFormat> c_DDSDXFormatMap = new Dictionary<TextureFormat, DXGIFormat>()
        {
            // Formats that is imported

            { TextureFormat.TextureFormat_Dxt1A, DXGIFormat.BC1_UNORM },
            { TextureFormat.TextureFormat_Dxt5A, DXGIFormat.BC4_UNORM },
            { TextureFormat.TextureFormat_Dxn, DXGIFormat.BC5_UNORM },
            { TextureFormat.TextureFormat_NormalDxn, DXGIFormat.BC5_UNORM},

            { TextureFormat.TextureFormat_Bc7, DXGIFormat.BC7_UNORM },

            { TextureFormat.TextureFormat_Rgb565, DXGIFormat.B5G6R5_UNORM },
            //{ TextureFormat.TextureFormat_Rgb888, DXGIFormat.B8G8R8X8_UNORM },
            { TextureFormat.TextureFormat_Argb1555, DXGIFormat.B5G5R5A1_UNORM }, //Not sure about this one
            { TextureFormat.TextureFormat_Argb4444, DXGIFormat.B4G4R4A4_UNORM },
            { TextureFormat.TextureFormat_Argb8888, DXGIFormat.R8G8B8A8_UNORM },


            { TextureFormat.TextureFormat_Rg8, DXGIFormat.R8G8_UNORM },
            { TextureFormat.TextureFormat_Gr16, DXGIFormat.R16G16_UNORM }, //Not sure


            { TextureFormat.TextureFormat_A2R10G10B10, DXGIFormat.R10G10B10A2_UINT },







            // Its own formats
            { TextureFormat.TextureFormat_Abgr16, DXGIFormat.R16G16B16A16_UNORM },
            { TextureFormat.TextureFormat_Abgr16F, DXGIFormat.R16G16B16A16_FLOAT},
            { TextureFormat.TextureFormat_Abgr32F, DXGIFormat.R32G32B32A32_FLOAT },
            { TextureFormat.TextureFormat_R16F, DXGIFormat.R16_FLOAT },
            { TextureFormat.TextureFormat_R32F, DXGIFormat.R32_FLOAT },


            { TextureFormat.TextureFormat_Gr16F, DXGIFormat.R16G16_FLOAT },


            { TextureFormat.TextureFormat_R11G11B10F, DXGIFormat.R11G11B10_FLOAT },
            { TextureFormat.TextureFormat_R9G9B9E5F,  DXGIFormat.R9G9B9E5_SHAREDEXP }, //strange, should be float? not sure what sharedexp is

            { TextureFormat.TextureFormat_Abgr16_Snorm, DXGIFormat.R16G16B16A16_SNORM },
            { TextureFormat.TextureFormat_Abgr16_Uint, DXGIFormat.R16G16B16A16_UINT },


            { TextureFormat.TextureFormat_GR16_Uint, DXGIFormat.R16G16_UINT },
            { TextureFormat.TextureFormat_GR32_Uint, DXGIFormat.R32G32_UINT},


            { TextureFormat.TextureFormat_S8, DXGIFormat.D24_UNORM_S8_UINT },


            { TextureFormat.TextureFormat_Abgr32, DXGIFormat.R32G32B32A32_UINT },
            { TextureFormat.TextureFormat_Gr32F, DXGIFormat.R32G32_FLOAT},


            //D is for depth, texture3d
            { TextureFormat.TextureFormat_D16, DXGIFormat.D16_UNORM },
            { TextureFormat.TextureFormat_D24S8, DXGIFormat.D24_UNORM_S8_UINT },
            { TextureFormat.TextureFormat_D24Fs8, DXGIFormat.UNKNOWN },
            { TextureFormat.TextureFormat_D32F, DXGIFormat.D32_FLOAT },
            { TextureFormat.TextureFormat_D32Fs8, DXGIFormat.D32_FLOAT_S8X24_UINT },
        };

        /// <summary>
        /// Gets the integer representation of the foucc string.
        /// 
        /// Credits: Grimdoomer
        /// </summary>
        /// <param name="p_FourCC"></param>
        /// <returns></returns>
        public static uint MakeFourCC(string p_FourCC)
        {
            return (uint)(((uint)p_FourCC[0] & 0xFF) | (((uint)p_FourCC[1] & 0xFF) << 8) | (((uint)p_FourCC[2] & 0xFF) << 16) | ((uint)p_FourCC[3] & 0xFF) << 24);
        }
    }
}
