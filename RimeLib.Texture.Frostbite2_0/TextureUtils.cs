using System;
using System.Collections.Generic;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite2_0.Frostbite;

namespace RimeLib.Texture.Frostbite2_0;

internal static class TextureUtils
{
    public static readonly Dictionary<TextureFormat, DDSPixelFormat> c_DDSFormatMap = new()
    {
        { TextureFormat.TextureFormat_DXT1, new DDSPixelFormat("DXT1") },
        { TextureFormat.TextureFormat_DXT3, new DDSPixelFormat("DXT3") },
        { TextureFormat.TextureFormat_DXT5, new DDSPixelFormat("DXT5") }, //ATI1
        { TextureFormat.TextureFormat_DXT5A, new DDSPixelFormat("DX10") }, //ATI1N
        { TextureFormat.TextureFormat_DXN, new DDSPixelFormat("DX10") }, //BC5, ATI2
        { TextureFormat.TextureFormat_NormalDXN, new DDSPixelFormat("DX10") }, //ATI2
        { TextureFormat.TextureFormat_NormalDXT1, new DDSPixelFormat("DXT1") },
        { TextureFormat.TextureFormat_NormalDXT5, new DDSPixelFormat("DXT5") },
        { TextureFormat.TextureFormat_NormalDXT5RGA, new DDSPixelFormat("DX10") }, //Not sure about this one

        { TextureFormat.TextureFormat_RGB565, new DDSPixelFormat(DDSFormatFlags.Rgb, 0, 0x0000f800, 0x000007e0, 0x0000001f) },
        { TextureFormat.TextureFormat_RGB888, new DDSPixelFormat(DDSFormatFlags.Rgb, 0, 0x00ff0000, 0x0000ff00, 0x000000ff) },
        { TextureFormat.TextureFormat_ARGB1555, new DDSPixelFormat(DDSFormatFlags.Rgba, 0, 0x00007c00, 0x000003e0, 0x0000001f, 0x00008000) },
        { TextureFormat.TextureFormat_ARGB4444, new DDSPixelFormat(DDSFormatFlags.Rgba, 0, 0xF000, 0x0F00, 0x00F0, 0x000F) },
        { TextureFormat.TextureFormat_ARGB8888, new DDSPixelFormat(DDSFormatFlags.Rgba, 0, 0xFF0000, 0xFF00, 0xFF, 0xFF000000 ) },
        /*
        { TextureFormat.TextureFormat_L8, new DDSPixelFormat(DDSFormatFlags.Luminance, 8, 0xFF) },
        { TextureFormat.TextureFormat_L16, new DDSPixelFormat("DX10") { Flags = DDSFormatFlags.FourCC } },
        { TextureFormat.TextureFormat_L16_Uint, new DDSPixelFormat(DDSFormatFlags.Luminance, 16,  0xFFFF) }, //not sure about this one
        { TextureFormat.TextureFormat_L32, new DDSPixelFormat(DDSFormatFlags.Luminance, 32, 0xFFFFFFFF) },
        */
        {
            TextureFormat.TextureFormat_L8,
            new DDSPixelFormat
            {
                Size = 32,
                Flags = DDSFormatFlags.Rgb,
                FourCC = 0,
                RBitMask = 0x000000FF,
                GBitMask = 0x00000000,
                BBitMask = 0x00000000,
                ABitMask = 0x00000000
            }
        },
        {
            // TODO: Verify this is correct
            TextureFormat.TextureFormat_L16, new DDSPixelFormat { Size = 32, Flags = DDSFormatFlags.Rgb, RBitMask = 0x0000FFFF }
        },
        {
            TextureFormat.TextureFormat_R16F,
            new DDSPixelFormat
            {
                Size = 32,
                Flags = DDSFormatFlags.FourCC,
                FourCC = 111,
            }
        },
        { TextureFormat.TextureFormat_ABGR16F, new DDSPixelFormat { Size = 32, Flags = DDSFormatFlags.FourCC, FourCC = 113} },
        /*

        { TextureFormat.TextureFormat_Rg8, new DDSPixelFormat(DDSFormatFlags.Rgb, 0, 0xFF00, 0xFF) },

        { TextureFormat.TextureFormat_Gr16, new DDSPixelFormat(DDSFormatFlags.Rgb, 16, 0xFFFF, 0xFFFF0000) },



        { TextureFormat.TextureFormat_A2R10G10B10, new DDSPixelFormat( DDSFormatFlags.Rgba, 0, 0x3FF00000, 0xFFC00, 0x3FF, 0xC0000000 ) },
        */
    };

    public static readonly Dictionary<TextureFormat, DDSFormatFlags> s_FormatFlags = new()
    {
        { TextureFormat.TextureFormat_DXT1,          DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_NormalDXT1,    DDSFormatFlags.FourCC },

        { TextureFormat.TextureFormat_DXT3,          DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_DXT5,          DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_DXT5A,         DDSFormatFlags.FourCC },


        { TextureFormat.TextureFormat_NormalDXT5,    DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_NormalDXT5RGA, DDSFormatFlags.FourCC },

        { TextureFormat.TextureFormat_DXN,           DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_NormalDXN,     DDSFormatFlags.FourCC },

        { TextureFormat.TextureFormat_RGB565,        DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb }, //Check
        { TextureFormat.TextureFormat_RGB888,        DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb },
        { TextureFormat.TextureFormat_ARGB1555,      DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha }, //1 + 5 + 5 + 5 + 5
        { TextureFormat.TextureFormat_ARGB4444,      DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha },  //this is really 16, but calcualted as 8???
                                                         
        { TextureFormat.TextureFormat_ARGB8888,      DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha }, //this is really 32, but calcualted as 16???
                                                         
        { TextureFormat.TextureFormat_L8,            DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_L16,           DDSFormatFlags.FourCC }, //check?
                                                         
        { TextureFormat.TextureFormat_ABGR16,        DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha },
        { TextureFormat.TextureFormat_ABGR16F,       DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha },

        { TextureFormat.TextureFormat_ABGR32F,       DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha },
        { TextureFormat.TextureFormat_R16F,          DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_R32F,          DDSFormatFlags.FourCC }, //this has 32 bitcount, but is calculated as 4 
        { TextureFormat.TextureFormat_RG8,           DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_GR16,          DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_GR16F,         DDSFormatFlags.FourCC }, // not sure
        { TextureFormat.TextureFormat_D16,           DDSFormatFlags.FourCC }, // not sure
        { TextureFormat.TextureFormat_D24S8,         DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_D24FS8,        DDSFormatFlags.FourCC }, // not sure


        { TextureFormat.TextureFormat_D32F,          DDSFormatFlags.FourCC },
            
        { TextureFormat.TextureFormat_ABGR32,        DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_GR32F,         DDSFormatFlags.FourCC },
        { TextureFormat.TextureFormat_A2R10G10B10,   DDSFormatFlags.FourCC },
    };

    public static readonly Dictionary<TextureFormat, uint> s_FormatBits = new()
    {
        { TextureFormat.TextureFormat_DXT1,          4 }, 
                                                         
        { TextureFormat.TextureFormat_NormalDXT1,    4 }, 
                                                         
        { TextureFormat.TextureFormat_DXT3,          8 }, 
        { TextureFormat.TextureFormat_DXT5,          4 }, 
        { TextureFormat.TextureFormat_DXT5A,         4 }, 
                                                         
                                                         
        { TextureFormat.TextureFormat_NormalDXT5,    8 }, 
        { TextureFormat.TextureFormat_NormalDXT5RGA, 8 }, 
                                                         
        { TextureFormat.TextureFormat_DXN,           8 },
        { TextureFormat.TextureFormat_NormalDXN,     8 },
                                                         
        { TextureFormat.TextureFormat_RGB565,        16 }, //Check
        { TextureFormat.TextureFormat_RGB888,        24 },
        { TextureFormat.TextureFormat_ARGB1555,      32 }, //1 + 5 + 5 + 5 + 5
        { TextureFormat.TextureFormat_ARGB4444,      16 },  //this is really 16, but calcualted as 8???
                                                         
        { TextureFormat.TextureFormat_ARGB8888,      32 }, //this is really 32, but calcualted as 16???
                                                         
        { TextureFormat.TextureFormat_L8,            8 },
        { TextureFormat.TextureFormat_L16,           16 }, //check?
                                                         
        { TextureFormat.TextureFormat_ABGR16,        64 },
        { TextureFormat.TextureFormat_ABGR16F,       64 },
                                                         
        { TextureFormat.TextureFormat_ABGR32F,       128 },
        { TextureFormat.TextureFormat_R16F,          16 }, 
        { TextureFormat.TextureFormat_R32F,          32 }, //this has 32 bitcount, but is calculated as 4 
        { TextureFormat.TextureFormat_RG8,           16 },
        { TextureFormat.TextureFormat_GR16,          32 },
        { TextureFormat.TextureFormat_GR16F,         32 }, // not sure
        { TextureFormat.TextureFormat_D16,           16 }, // not sure
        { TextureFormat.TextureFormat_D24S8,         32 },
        { TextureFormat.TextureFormat_D24FS8,        24 + 8 }, // not sure


        { TextureFormat.TextureFormat_D32F,          32 },
            
        { TextureFormat.TextureFormat_ABGR32,        32 * 4 },
        { TextureFormat.TextureFormat_GR32F,         32 * 2 },
        { TextureFormat.TextureFormat_A2R10G10B10,   32 },
    };

    public static uint BitsPerPixel(TextureFormat p_Format)
    {
        if (!s_FormatBits.TryGetValue(p_Format, out var s_OutBits))
            return 0;

        return s_OutBits;
    }

    public static bool IsCompressed(TextureFormat p_Format) =>
        p_Format switch
        {
            TextureFormat.TextureFormat_DXT1 => true,
            TextureFormat.TextureFormat_NormalDXT1 => true,
            TextureFormat.TextureFormat_DXT3 => true,
            TextureFormat.TextureFormat_DXN => true,
            TextureFormat.TextureFormat_NormalDXN => true,
            TextureFormat.TextureFormat_DXT5 => true,
            TextureFormat.TextureFormat_NormalDXT5 => true,
            TextureFormat.TextureFormat_NormalDXT5RGA => true,
            TextureFormat.TextureFormat_DXT5A => true,

            _ => false
        };
}