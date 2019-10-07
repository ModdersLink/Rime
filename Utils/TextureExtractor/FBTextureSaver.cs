using System;
using System.Collections.Generic;
using System.Text;

using DXTex = DirectXTexNet;



using RimeLib.Texture.Frostbite;
using System.Runtime.InteropServices;

namespace TextureExtractor
{


    public static class FBTextureSaver
    {



        public static bool SaveTexture( ITexture p_Texture, string p_FilePath)
        {

            DXTex.ScratchImage? s_Image = null;


            var s_Format = GetTextureFormat( p_Texture.GetTextureFormat(), ( p_Texture.GetFlags() & (int)TextureFlags.SrgbGamma) != 0, false );


            switch ( p_Texture.GetTextureType( ) )
            {
            
            case TextureType.TextureType_1D:
            case TextureType.TextureType_1DArray:
                s_Image = DXTex.TexHelper.Instance.Initialize1D( s_Format, p_Texture.GetWidth( ), 1, p_Texture.GetMipmapCount( ), DXTex.CP_FLAGS.NONE );
                break;

            case TextureType.TextureType_2D:
            case TextureType.TextureType_2DArray:
                s_Image = DXTex.TexHelper.Instance.Initialize2D( s_Format, p_Texture.GetWidth( ), p_Texture.GetHeight( ), 1, p_Texture.GetMipmapCount( ), DXTex.CP_FLAGS.NONE );

                break;

            case TextureType.TextureType_3D:
                s_Image = DXTex.TexHelper.Instance.Initialize3D( s_Format, p_Texture.GetWidth( ), p_Texture.GetHeight( ), p_Texture.GetDepth( ), p_Texture.GetMipmapCount( ), DXTex.CP_FLAGS.NONE );
                break;

            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                s_Image = DXTex.TexHelper.Instance.InitializeCube( s_Format, p_Texture.GetWidth( ), p_Texture.GetHeight( ), 1, p_Texture.GetMipmapCount( ), DXTex.CP_FLAGS.NONE );
                break;
            }

            if ( s_Image == null )
                return false;

            


            var s_CopySize = Math.Min( p_Texture.GetRawTextureSize( ), (int)s_Image.GetPixelsSize( ) );

            byte[] s_TempBuffer = null;


            using ( var s_Stream = p_Texture.GetRawTextureData( ) )
            {
                s_TempBuffer = s_Stream.ReadBytes( s_CopySize );
            }

            if ( s_TempBuffer == null )
                return false;


            try
            {
                Marshal.Copy( s_TempBuffer, 0, s_Image.GetPixels( ), s_CopySize );
            }
            catch
            {
                return false;
            }


            s_Image.SaveToDDSFile( DXTex.DDS_FLAGS.NONE, p_FilePath );

            return true;
        }




        public static DXTex.DXGI_FORMAT GetTextureFormat( TextureFormat p_Format, bool p_Srgb, bool p_Typeless )
        {
            switch ( p_Format )
            {
            case TextureFormat.TextureFormat_Dxt1:
            case TextureFormat.TextureFormat_NormalDxt1:

                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.BC1_TYPELESS;
                else if ( p_Srgb )
                    return DXTex.DXGI_FORMAT.BC1_UNORM_SRGB;
                else
                    return DXTex.DXGI_FORMAT.BC1_UNORM;

            case TextureFormat.TextureFormat_Dxt3:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.BC2_TYPELESS;
                else if ( p_Srgb )
                    return DXTex.DXGI_FORMAT.BC2_UNORM_SRGB;
                else
                    return DXTex.DXGI_FORMAT.BC2_UNORM;

            case TextureFormat.TextureFormat_Dxt5:
            case TextureFormat.TextureFormat_NormalDxt5:
            case TextureFormat.TextureFormat_NormalDxt5Rga:

                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.BC3_TYPELESS;
                else if ( p_Srgb )
                    return DXTex.DXGI_FORMAT.BC3_UNORM_SRGB;
                else
                    return DXTex.DXGI_FORMAT.BC3_UNORM;

            case TextureFormat.TextureFormat_Dxt5A:

                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.BC4_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.BC4_UNORM;

            case TextureFormat.TextureFormat_Argb8888:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R8G8B8A8_TYPELESS;
                else if ( p_Srgb )
                    return DXTex.DXGI_FORMAT.R8G8B8A8_UNORM;
                else
                    return DXTex.DXGI_FORMAT.R8G8B8A8_UNORM_SRGB;

            case TextureFormat.TextureFormat_L8:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R8_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R8_UNORM;

            case TextureFormat.TextureFormat_L16:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R16_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R16_UNORM;


            case TextureFormat.TextureFormat_Abgr16:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R16G16B16A16_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R16G16B16A16_UNORM;

            case TextureFormat.TextureFormat_Abgr16F:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R16G16B16A16_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R16G16B16A16_FLOAT;

            case TextureFormat.TextureFormat_Abgr32F:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R32G32B32A32_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R32G32B32A32_FLOAT;

            case TextureFormat.TextureFormat_R16F:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R16_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R16_UNORM;

            case TextureFormat.TextureFormat_R32F:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R32_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R32_FLOAT;


            case TextureFormat.TextureFormat_NormalDxn:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.BC5_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.BC5_UNORM;

            case TextureFormat.TextureFormat_Gr16:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R16G16_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R16G16_UNORM;

            case TextureFormat.TextureFormat_Gr16F:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R16G16_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R16G16_FLOAT;

            case TextureFormat.TextureFormat_D16:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R16_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R16_UNORM;


            case TextureFormat.TextureFormat_D24S8:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R24G8_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.D24_UNORM_S8_UINT;


            case TextureFormat.TextureFormat_D32F:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R32_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R32_FLOAT;


            case TextureFormat.TextureFormat_Abgr32:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R32G32B32A32_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R32G32B32A32_UINT;


            case TextureFormat.TextureFormat_Gr32F:
                if ( p_Typeless )
                    return DXTex.DXGI_FORMAT.R32G32_TYPELESS;
                else if ( p_Srgb )
                    throw new NotSupportedException( );
                else
                    return DXTex.DXGI_FORMAT.R32G32_FLOAT;


            default:
                throw new NotImplementedException( $"Textureformat {p_Format} not implimented" );
            }
        }
    }
}
