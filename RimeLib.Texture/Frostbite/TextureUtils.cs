using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture.Frostbite
{
    public static class TextureUtils
    {
        public static uint BitsPerPixel( TextureFormat p_Format )
        {
            switch ( p_Format )
            {
            case TextureFormat.TextureFormat_Rgb565:
                return 5 + 6 + 5;

            case TextureFormat.TextureFormat_Rgb888:
                return 8 + 8 + 8;

            case TextureFormat.TextureFormat_Argb1555:
                return 1 + 5 + 5 + 5 + 5;

            case TextureFormat.TextureFormat_Argb4444:
                return 4 + 4 + 4 + 4;

            case TextureFormat.TextureFormat_Argb8888:
                return 8 + 8 + 8 + 8;



            case TextureFormat.TextureFormat_L8:
                return 8; // not sure

            case TextureFormat.TextureFormat_L16:
                return 16; // not sure

            case TextureFormat.TextureFormat_Abgr16:
            case TextureFormat.TextureFormat_Abgr16F:
                return 16 * 4;

            case TextureFormat.TextureFormat_Abgr32F:
                return 32 * 4;

            case TextureFormat.TextureFormat_R16F:
                return 16;

            case TextureFormat.TextureFormat_R32F:
                return 32;

            case TextureFormat.TextureFormat_Rg8:
                return 8 * 2;

            case TextureFormat.TextureFormat_Gr16:
            case TextureFormat.TextureFormat_Gr16F: // not sure
                return 16 * 2;


            case TextureFormat.TextureFormat_D16:
                return 16; // not sure

            case TextureFormat.TextureFormat_D24S8:
            case TextureFormat.TextureFormat_D24Fs8: // not sure
                return 24 + 8;


            case TextureFormat.TextureFormat_D32F:
                return 32;

            case TextureFormat.TextureFormat_D32Fs8:
                return 32 + 8;

            case TextureFormat.TextureFormat_S8:
                return 8;

            case TextureFormat.TextureFormat_Abgr32:
                return 32 * 4;

            case TextureFormat.TextureFormat_Gr32F:
                return 32 * 2;

            case TextureFormat.TextureFormat_A2R10G10B10:

                return 2 + 10 + 10 + 10;

            case TextureFormat.TextureFormat_R11G11B10F:
                return 11 + 11 + 10;

            case TextureFormat.TextureFormat_Abgr16_Snorm:
            case TextureFormat.TextureFormat_Abgr16_Uint:
                return 16 * 4;

            case TextureFormat.TextureFormat_L16_Uint:
                return 16; // not sure

            case TextureFormat.TextureFormat_L32:
                return 32;

            case TextureFormat.TextureFormat_GR16_Uint:
                return 16 * 2;

            case TextureFormat.TextureFormat_GR32_Uint:
                return 32 * 2;

            case TextureFormat.TextureFormat_R9G9B9E5F:
                return 9 + 9 + 9 + 5;

            }

            return 0;
        }

        public static bool IsCompressed( TextureFormat p_Format )
        {
            switch ( p_Format )
            {
            

            case TextureFormat.TextureFormat_Dxt1:
            case TextureFormat.TextureFormat_NormalDxt1:

            case TextureFormat.TextureFormat_Dxt1A:

            case TextureFormat.TextureFormat_Dxt3:

            case TextureFormat.TextureFormat_Dxn:
            case TextureFormat.TextureFormat_NormalDxn:
            case TextureFormat.TextureFormat_Dxt5:
            case TextureFormat.TextureFormat_NormalDxt5:
            case TextureFormat.TextureFormat_NormalDxt5Rga:

            case TextureFormat.TextureFormat_Dxt5A:

            case TextureFormat.TextureFormat_Bc7:

                return true;
            }


            return false;
        }



        public static bool IsPalettized( TextureFormat p_Format )
        {
            return false;
        }

        public static bool IsPacked( TextureFormat p_Format )
        {
            return false;
        }

        public static bool IsPlanar( TextureFormat p_Format )
        {
            return false;
        }



        public static bool ComputePitch( TextureFormat p_Format, uint p_Width, uint p_Height, out uint p_RowPitch, out uint p_SlicePitch )
        {
            uint s_Pitch = 0;
            uint s_Slice = 0;

            switch ( p_Format )
            {

            //TODO: Find what dxt1a is
            case TextureFormat.TextureFormat_Dxt1:
            case TextureFormat.TextureFormat_NormalDxt1:
            case TextureFormat.TextureFormat_Dxt5A:
            {
                //aligns to nearest 4 bits
                var s_Nbw = System.Math.Max( 1, ( p_Width + 3 ) / 4 );
                var s_Nbh = System.Math.Max( 1, ( p_Height + 3 ) / 4 );

                s_Pitch = s_Nbw * 8; //uint8?
                s_Slice = s_Pitch * s_Nbh;
                break;
            }
            case TextureFormat.TextureFormat_Dxt3:
            case TextureFormat.TextureFormat_Dxt5:
            case TextureFormat.TextureFormat_NormalDxt5:
            case TextureFormat.TextureFormat_NormalDxt5Rga:
            case TextureFormat.TextureFormat_Dxn:
            case TextureFormat.TextureFormat_NormalDxn:
            case TextureFormat.TextureFormat_Bc7:
            
            {

                //aligns to nearest 4 bits
                var s_Nbw = System.Math.Max( 1, ( p_Width + 3 ) / 4 );
                var s_Nbh = System.Math.Max( 1, ( p_Height + 3 ) / 4 );

                s_Pitch = s_Nbw * 16; //uint16?
                s_Slice = s_Pitch * s_Nbh;
                break;
            }

            default:
            {

                var s_BitsPerPixel = BitsPerPixel( p_Format );

                //aligns to nearest 8 bits
                s_Pitch = ( p_Width * s_BitsPerPixel + 7u ) / 8u;
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
