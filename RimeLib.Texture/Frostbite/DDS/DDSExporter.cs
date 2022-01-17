using RimeLib.IO;
using RimeLib.Texture.DDS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.Frostbite.DDS
{
    public class DDSExporter
    {
        public DDSExporter(TextureBase p_Texture)
        {
            m_IsTiled = p_Texture.IsTiled;

            SetHeader(p_Texture);
            SetPixelFormat(p_Texture);
        }
        DDSHeader m_Header = new DDSHeader();
        DDSDX10Header? m_ExtendedHeader = null;
        bool m_IsTiled = false;

        void SetHeader(TextureBase p_Texture)
        {
            //Signature, not needed
            m_Header.Reserved[9] = DDSUtils.MakeFourCC("RIME");

            m_Header.Flags = DDSFlags.Texture;

            m_Header.Caps = DDSCaps.Texture;

            m_Header.Height = p_Texture.Height;
            m_Header.Width = p_Texture.Width;
            m_Header.Depth = p_Texture.Depth;

            m_Header.MipMapCount = p_Texture.MipmapCount;

            if (m_Header.MipMapCount > 0)
            {
                m_Header.Flags |= DDSFlags.MipmapCount;


                if (m_Header.MipMapCount > 1)
                    m_Header.Caps |= DDSCaps.MipmapFlags;
            }


            switch (p_Texture.Type)
            {
            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                m_Header.Caps |= DDSCaps.Complex;
                m_Header.Caps2 |= DDSCaps2.AllFaces;
                break;

            case TextureType.TextureType_3D:
                m_Header.Flags |= DDSFlags.Depth;
                m_Header.Caps2 |= DDSCaps2.Volume;
                break;
            }

            if (p_Texture.Flags.HasFlag(TextureFlags.SrgbGamma))  //NVIDIA format | some loaders might require this? (DirectXTex)
                m_Header.Flags |= DDSFlags.Srgb;


            if (!TextureUtils.ComputePitch(p_Texture.Format, (uint) p_Texture.Width, (uint) p_Texture.Height, out var s_RowPitch, out var s_SlicePitch))
                throw new Exception("Failed to compute pitch!");

            if (TextureUtils.IsCompressed(p_Texture.Format))
            {
                m_Header.Flags |= DDSFlags.LinearSize;
                m_Header.PitchOrLinearSize = s_SlicePitch;
            }
            else
            {
                m_Header.Flags |= DDSFlags.Pitch;
                m_Header.PitchOrLinearSize = s_RowPitch;
            }

        }

        void SetPixelFormat(TextureBase p_Texture)
        {
            if (DDSUtils.c_DDSFormatMap.TryGetValue(p_Texture.Format, out var s_Format))
            {
                //TODO: change
                s_Format.RGBBitCount = TextureUtils.BitsPerPixel(p_Texture.Format);

                m_Header.PixelFormat = s_Format;
            }
            else
            {
                if (!DDSUtils.c_DDSDXFormatMap.TryGetValue(p_Texture.Format, out var s_DXGIFormat))
                    throw new Exception($"Invalid textureformat {p_Texture.Format}");

                m_Header.PixelFormat = DDSPixelFormat.s_DXExtFormat;

                m_ExtendedHeader = new DDSDX10Header();


                m_ExtendedHeader.DxgiFormat = s_DXGIFormat;


                switch (p_Texture.Type)
                {
                case TextureType.TextureType_1D:
                case TextureType.TextureType_1DArray:
                    m_ExtendedHeader.ResourceDimension = DDSResoruceDimension.Texture1D;
                    break;

                case TextureType.TextureType_2D:
                case TextureType.TextureType_2DArray:
                    m_ExtendedHeader.ResourceDimension = DDSResoruceDimension.Texture2D;
                    break;

                case TextureType.TextureType_3D:
                    m_ExtendedHeader.ResourceDimension = DDSResoruceDimension.Texture3D;
                    break;

                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    m_ExtendedHeader.ResourceDimension = DDSResoruceDimension.Texture2D;

                    m_ExtendedHeader.MiscFlag = DDSMiscFlag1.TextureCube;
                    m_ExtendedHeader.ArraySize = 6;
                    break;
                }
            }
        }


        public void WriteToStream(RimeWriter p_Stream)
        {
            m_Header.Serialize(p_Stream);

            if (m_ExtendedHeader != null)
            {
                //Align
                if (p_Stream.Position % 0x10 != 0)
                    p_Stream.Seek(0x10 - (p_Stream.Position % 0x10), SeekOrigin.Current);

                m_ExtendedHeader.Serialize(p_Stream);
            }

            /*
            if (m_IsTiled)
            {
                var s_Untiled = Xbox.XboxUntiler.GetUntiledTextureData(this);

                if (s_Untiled == null)
                    throw new Exception("Failed to get texture data");

                p_Stream.Write(s_Untiled);
            }
            else
            {

                var s_TextureData = this.GetRawTextureData( );

                if (s_TextureData == null)
                    throw new Exception("Failed to get texture data");

                s_TextureData.CopyTo(p_Stream.BaseStream);
            }
            */
            
        }

        /*
        public static void WriteTextureToStream(RimeWriter p_Stream)
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


            switch (p_Texture.Type)
            {
            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                s_Header.m_Caps |= DDSCaps.Complex;
                s_Header.m_Caps2 |= DDSCaps2.AllFaces;
                break;

            case TextureType.TextureType_3D:
                s_Header.m_Flags |= DDSFlags.Depth;
                s_Header.m_Caps2 |= DDSCaps2.Volume;
                break;
            }

            if (p_Texture.Flags.HasFlag(TextureFlags.SrgbGamma))  //NVIDIA format | some loaders might require this? (DirectXTex)
                s_Header.m_Flags |= DDSFlags.Srgb;
            
            
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

            /*
            if (p_Texture.Flags.HasFlag(TextureFlags.UnknownFlag))
            {
                var s_Untiled = Xbox.XboxUntiler.GetUntiledTextureData(p_Texture);

                if (s_Untiled == null)
                    throw new Exception("Failed to get texture data");

                p_Stream.Write(s_Untiled);
            }
            else
            *
            {

                var s_TextureData = p_Texture.GetRawTextureData( );

                if (s_TextureData == null)
                    throw new Exception("Failed to get texture data");

                s_TextureData.CopyTo(p_Stream.BaseStream);
            }
        }*/

    }
}
