using RimeLib.Texture.Frostbite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture.Xbox
{
    class XboxFormat
    {
        // From https://github.com/gildor2/UEViewer/blob/master/Unreal/UnTexture.cpp#L52
        /*
    
    REST OF FORMATS IS 1x1

    GPUTEXTUREFORMAT_Cr_Y1_Cb_Y0_REP                = 11, //Block 2x1
    GPUTEXTUREFORMAT_Y1_Cr_Y0_Cb_REP                = 12, //Block 2x1

    GPUTEXTUREFORMAT_DXT1                           = 18, //Block 4x4
    GPUTEXTUREFORMAT_DXT2_3                         = 19, //Block 4x4
    GPUTEXTUREFORMAT_DXT4_5                         = 20, //Block 4x4

    GPUTEXTUREFORMAT_32_AS_8                        = 39, //Block 4x1

    GPUTEXTUREFORMAT_32_AS_8_8                      = 40, //Block 2x1

    GPUTEXTUREFORMAT_32_AS_8_INTERLACED             = 44, //Block 4x1

    GPUTEXTUREFORMAT_DXN                            = 49, //Block 4x4
    GPUTEXTUREFORMAT_8_8_8_8_AS_16_16_16_16         = 50, //Block 4x4
    GPUTEXTUREFORMAT_DXT1_AS_16_16_16_16            = 51, //Block 4x4
    GPUTEXTUREFORMAT_DXT2_3_AS_16_16_16_16          = 52, //Block 4x4
    GPUTEXTUREFORMAT_DXT4_5_AS_16_16_16_16          = 53, //Block 4x4
    GPUTEXTUREFORMAT_DXT3A                          = 58, //Block 4x4
    GPUTEXTUREFORMAT_DXT5A                          = 59, //Block 4x4
    GPUTEXTUREFORMAT_CTX1                           = 60, //Block 4x4
    GPUTEXTUREFORMAT_DXT3A_AS_1_1_1_1               = 61, //Block 4x4

        */
        public static readonly Dictionary<TextureFormat, XboxFormatInformation> c_XboxFormat = new Dictionary<TextureFormat, XboxFormatInformation>( )
        {
            { TextureFormat.TextureFormat_Dxt1, new XboxFormatInformation(4, 4, 128, 128) },
            { TextureFormat.TextureFormat_Dxt1A, new XboxFormatInformation(4, 4, 128, 128) }, //not sure
            { TextureFormat.TextureFormat_Dxt3, new XboxFormatInformation(4, 4, 128, 128) },
            { TextureFormat.TextureFormat_Dxt5, new XboxFormatInformation(4, 4, 128, 128) },
            { TextureFormat.TextureFormat_Dxt5A, new XboxFormatInformation(4, 4) },
            { TextureFormat.TextureFormat_Dxn, new XboxFormatInformation(4, 4)},

            { TextureFormat.TextureFormat_Bc7, new XboxFormatInformation(4, 4) },

            { TextureFormat.TextureFormat_NormalDxn, new XboxFormatInformation(4, 4) },

            { TextureFormat.TextureFormat_NormalDxt1, new XboxFormatInformation(4, 4, 128, 128) },
            { TextureFormat.TextureFormat_NormalDxt5, new XboxFormatInformation(4, 4, 128, 128) },
            { TextureFormat.TextureFormat_NormalDxt5Rga, new XboxFormatInformation(4, 4, 128, 128) }, //Not sure
        };


        public static XboxFormatInformation GetFormatInformation(TextureFormat p_Format)
        {
            if (c_XboxFormat.TryGetValue(p_Format, out var s_Information))
                return s_Information;

            //Rest of blocks are 1x1
            return new XboxFormatInformation(1, 1);
        }


        public static readonly Dictionary<TextureFormat, uint> c_EndianByteSize = new Dictionary<TextureFormat, uint>( )
        {
            { TextureFormat.TextureFormat_Dxt1,         2 },
            { TextureFormat.TextureFormat_Dxt1A,        2 },
            { TextureFormat.TextureFormat_NormalDxt1,   2 },

            { TextureFormat.TextureFormat_Dxn,          2 },



            { TextureFormat.TextureFormat_NormalDxn,    2 },

            { TextureFormat.TextureFormat_R16F,         2 }, // this is just a test


            { TextureFormat.TextureFormat_Gr16,         2 },
            { TextureFormat.TextureFormat_Gr16F,         2 },


            { TextureFormat.TextureFormat_Rgb565,        2 },


            { TextureFormat.TextureFormat_Gr32F,         4 },
            { TextureFormat.TextureFormat_R11G11B10F,    4 }, //GPUTEXTUREFORMAT_10_11_11


            
        };

    }
}
