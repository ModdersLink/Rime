using RimeLib.IO;
using RimeLib.Texture.DDS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.Frostbite.DDS
{
    public static class DDSExporter
    {
        public static void WriteTextureToStream(RimeWriter p_Stream, ITexture p_Texture)
        {
            var s_Header = new DDSHeader( );

            //Signature, not needed
            s_Header.m_Reserved1[9] = DDSPixelFormat.MakeFourCC("RIME");

            s_Header.m_Flags = DDSFlags.Texture;

            s_Header.m_Caps = DDSCaps.Texture;

            s_Header.m_Height = p_Texture.Height;
            s_Header.m_Width = p_Texture.Width;
            s_Header.m_Depth = p_Texture.Depth;

            s_Header.m_MipmapCount = p_Texture.MipmapCount;

            if (s_Header.m_MipmapCount > 0)
            {
                s_Header.m_Flags |= DDSFlags.MipmapCount;


                if (s_Header.m_MipmapCount > 1)
                    s_Header.m_Caps |= DDSCaps.MipmapFlags;
            }


            if (p_Texture.Type == TextureType.TextureType_Cube ||
                p_Texture.Type == TextureType.TextureType_CubeArray)
            {
                s_Header.m_Caps |= DDSCaps.Complex;

                s_Header.m_Caps2 |= DDSCaps2.AllFaces;
            }

            if (p_Texture.Type == TextureType.TextureType_3D)
            {
                s_Header.m_Flags |= DDSFlags.Depth;

                s_Header.m_Caps2 |= DDSCaps2.Volume;
            }


            if ((p_Texture.Flags & (int) TextureFlags.SrgbGamma) != 0)
            {
                //NVIDIA format | some loaders might require this? (DirectXTex)

                //
                s_Header.m_Flags |= DDSFlags.Srgb;
            }

            if (!TextureUtils.ComputePitch(p_Texture.Format, (uint) p_Texture.Width, (uint) p_Texture.Height, out var s_RowPitch, out var s_SlicePitch))
                throw new Exception("Failed to compute pitch!");

            if ( TextureUtils.IsCompressed(p_Texture.Format) )
            {
                s_Header.m_Flags |= DDSFlags.LinearSize;
                s_Header.m_PitchOrLinearSize = s_SlicePitch;
            }
            else
            {
                s_Header.m_Flags |= DDSFlags.Pitch;
                s_Header.m_PitchOrLinearSize = s_RowPitch;
            }

            DDSDX10Header? s_ExtendedHeader = null;

            if (DDSUtils.c_DDSFormatMap.TryGetValue(p_Texture.Format, out var s_Format) )
            {
                s_Format.m_RGBBitCount = TextureUtils.BitsPerPixel(p_Texture.Format);

                s_Header.m_PixelFormat = s_Format;
            }
            else
            {
                if (!DDSUtils.c_DDSDXFormatMap.TryGetValue(p_Texture.Format, out var s_DXGIFormat))
                    throw new Exception($"Invalid textureformat {p_Texture.Format}");

                s_Header.m_PixelFormat = DDSPixelFormat.s_DXExtFormat;

                s_ExtendedHeader = new DDSDX10Header();


                s_ExtendedHeader.m_DxgiFormat = s_DXGIFormat;


                switch ( p_Texture.Type )
                {
                case TextureType.TextureType_1D:
                case TextureType.TextureType_1DArray:
                    s_ExtendedHeader.m_ResourceDimension = DDSResoruceDimension.Texture1D;
                    break;

                case TextureType.TextureType_2D:
                case TextureType.TextureType_2DArray:
                    s_ExtendedHeader.m_ResourceDimension = DDSResoruceDimension.Texture2D;
                    break;

                case TextureType.TextureType_3D:
                    s_ExtendedHeader.m_ResourceDimension = DDSResoruceDimension.Texture3D;
                    break;

                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    s_ExtendedHeader.m_ResourceDimension = DDSResoruceDimension.Texture2D;

                    s_ExtendedHeader.m_MiscFlag = DDSMiscFlag1.TextureCube;
                    s_ExtendedHeader.m_ArraySize = 6;
                    break;
                }
            }


            s_Header.Serialize(p_Stream);

            if (s_ExtendedHeader != null)
            {
                //Align
                if (p_Stream.Position % 0x10 != 0)
                    p_Stream.Seek(0x10 - (p_Stream.Position % 0x10), SeekOrigin.Current);

                s_ExtendedHeader.Serialize(p_Stream);
            }


            var s_TextureData = p_Texture.GetRawTextureData( );

            if ( s_TextureData != null )
                s_TextureData.CopyTo(p_Stream.BaseStream);

        }

    }
}
