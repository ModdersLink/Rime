using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture.Frostbite
{
    public static class TextureUtils
    {

        public static readonly Dictionary<TextureFormat, uint> s_FormatBits = new Dictionary<TextureFormat, uint>()
        {
            { TextureFormat.TextureFormat_Dxt1,          4 }, 
            { TextureFormat.TextureFormat_Dxt1A,         4 }, 
                                                         
            { TextureFormat.TextureFormat_NormalDxt1,    4 }, 
                                                         
            { TextureFormat.TextureFormat_Dxt3,          8 }, 
            { TextureFormat.TextureFormat_Dxt5,          4 }, 
            { TextureFormat.TextureFormat_Dxt5A,         4 }, 
                                                         
                                                         
            { TextureFormat.TextureFormat_NormalDxt5,    8 }, 
            { TextureFormat.TextureFormat_NormalDxt5Rga, 8 }, 
                                                         
            { TextureFormat.TextureFormat_Dxn,           8 },
            { TextureFormat.TextureFormat_NormalDxn,     8 },
            { TextureFormat.TextureFormat_Bc7,           8 },
                                                         
            { TextureFormat.TextureFormat_Rgb565,        16 }, //Check
            { TextureFormat.TextureFormat_Rgb888,        24 },
            { TextureFormat.TextureFormat_Argb1555,      32 }, //1 + 5 + 5 + 5 + 5
            { TextureFormat.TextureFormat_Argb4444,      16 },  //this is really 16, but calcualted as 8???
                                                         
            { TextureFormat.TextureFormat_Argb8888,      32 }, //this is really 32, but calcualted as 16???
                                                         
            { TextureFormat.TextureFormat_L8,            8 },
            { TextureFormat.TextureFormat_L16,           16 }, //check?
                                                         
            { TextureFormat.TextureFormat_Abgr16,        64 },
            { TextureFormat.TextureFormat_Abgr16F,       64 },
                                                         
            { TextureFormat.TextureFormat_Abgr32F,       128 },
            { TextureFormat.TextureFormat_R16F,          16 }, 
            { TextureFormat.TextureFormat_R32F,          32 }, //this has 32 bitcount, but is calculated as 4 
            { TextureFormat.TextureFormat_Rg8,           16 },
            { TextureFormat.TextureFormat_Gr16,          32 },
            { TextureFormat.TextureFormat_Gr16F,         32 }, // not sure
            { TextureFormat.TextureFormat_D16,           16 }, // not sure
            { TextureFormat.TextureFormat_D24S8,         32 },
            { TextureFormat.TextureFormat_D24Fs8,        24 + 8 }, // not sure


            { TextureFormat.TextureFormat_D32F,          32 },
            { TextureFormat.TextureFormat_D32Fs8,        32 + 8 },
            
            { TextureFormat.TextureFormat_S8,            8 },
            { TextureFormat.TextureFormat_Abgr32,        32 * 4 },
            { TextureFormat.TextureFormat_Gr32F,         32 * 2 },
            { TextureFormat.TextureFormat_A2R10G10B10,   32 },
            { TextureFormat.TextureFormat_R11G11B10F,    32 },
            { TextureFormat.TextureFormat_Abgr16_Snorm,  64 },
            { TextureFormat.TextureFormat_Abgr16_Uint,   64 },
            { TextureFormat.TextureFormat_L16_Uint,      16 }, // not sure
            { TextureFormat.TextureFormat_L32,           32 },
            { TextureFormat.TextureFormat_GR16_Uint,     32 },
            { TextureFormat.TextureFormat_GR32_Uint,     64 },
            { TextureFormat.TextureFormat_R9G9B9E5F,     32 },
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
                TextureFormat.TextureFormat_Dxt1 => true,
                TextureFormat.TextureFormat_NormalDxt1 => true,
                TextureFormat.TextureFormat_Dxt1A => true,
                TextureFormat.TextureFormat_Dxt3 => true,
                TextureFormat.TextureFormat_Dxn => true,
                TextureFormat.TextureFormat_NormalDxn => true,
                TextureFormat.TextureFormat_Dxt5 => true,
                TextureFormat.TextureFormat_NormalDxt5 => true,
                TextureFormat.TextureFormat_NormalDxt5Rga => true,
                TextureFormat.TextureFormat_Dxt5A => true,
                TextureFormat.TextureFormat_Bc7 => true,

                _ => false
            };



        public static bool IsPalettized(TextureFormat p_Format) =>
            p_Format switch
            {
                _ => false,
            };

        public static bool IsPacked(TextureFormat p_Format) =>
            p_Format switch
            {
                _ => false,
            };

        public static bool IsPlanar(TextureFormat p_Format) =>
            p_Format switch
            {
                _ => false,
            };



        public static bool ComputePitch(TextureFormat p_Format, uint p_Width, uint p_Height, out uint p_RowPitch, out uint p_SlicePitch)
        {
            uint s_Pitch = 0;
            uint s_Slice = 0;

            var s_BitsPerPixel = BitsPerPixel(p_Format);

            switch (p_Format)
            {
            case TextureFormat.TextureFormat_Dxt1:
            
            case TextureFormat.TextureFormat_Dxt5A:
            {
                //aligns to nearest 4 bits
                var s_Nbw = System.Math.Max(1, (p_Width + 3) / 4);
                var s_Nbh = System.Math.Max(1, (p_Height + 3) / 4);

                s_Pitch = s_Nbw * 8; //uint8?
                s_Slice = s_Pitch * s_Nbh;
                break;
            }

            //This fixes stuff
            case TextureFormat.TextureFormat_NormalDxt1:
            case TextureFormat.TextureFormat_Dxt1A:


            case TextureFormat.TextureFormat_Dxt3:
            case TextureFormat.TextureFormat_Dxt5:
            case TextureFormat.TextureFormat_NormalDxt5:
            case TextureFormat.TextureFormat_NormalDxt5Rga:
            case TextureFormat.TextureFormat_Dxn:
            case TextureFormat.TextureFormat_NormalDxn:
            case TextureFormat.TextureFormat_Bc7:
            {

                //aligns to nearest 4 bits
                var s_Nbw = System.Math.Max(1, (p_Width + 3) / 4);
                var s_Nbh = System.Math.Max(1, (p_Height + 3) / 4);

                s_Pitch = s_Nbw * 16; //uint16?
                s_Slice = s_Pitch * s_Nbh;
                break;
            }


            case TextureFormat.TextureFormat_R32F:
            {
                s_Pitch = (p_Width * s_BitsPerPixel + 7u) / (8u * 8u);
                s_Slice = s_Pitch * p_Height;
                break;
            }


            default:
            {

                

                //aligns to nearest 8 bits
                s_Pitch = (p_Width * s_BitsPerPixel + 7u) / 8u;
                s_Slice = s_Pitch * p_Height;
                break;
            }
            }

            p_RowPitch = s_Pitch;
            p_SlicePitch = s_Slice;

            return s_Pitch != 0;
        }



    }
}
