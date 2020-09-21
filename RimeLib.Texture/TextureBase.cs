using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite;
using RimeLib.Texture.Frostbite.DDS;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace RimeLib.Texture
{
    public abstract class TextureBase
    {
        


        public abstract TextureType Type { get; }
        
        public abstract TextureFormat Format { get; }

 
        public virtual uint GetMipmapSize(uint p_MipmapIndex) => 0;

        public virtual bool SerializeHeaderData(Stream p_Header)
        {
            return false;
        }

        //Return -1 if invalid or not avalible
        public virtual uint TextureSize => 0;

        public virtual bool IsTiled => false;

        //Return -1 if invalid or not avalible

        public virtual TextureFlags Flags => 0;

        public virtual uint Width => 0;

        public virtual uint Height => 0;

        public virtual uint Depth => 0;

        public virtual uint MipmapCount => 0;


        public ITextureDataProvider? Provider { get; set; }

        public virtual void SaveAsDDS( Stream p_Stream )
        {
            var s_Writer = new RimeWriter( p_Stream );

            var s_Header = new DDSHeader( );

            //Signature, not needed
            s_Header.m_Reserved1[9] = DDSPixelFormat.MakeFourCC("RIME");

            s_Header.m_Flags = DDSFlags.Texture;

            s_Header.m_Caps = DDSCaps.Texture;

            s_Header.m_Height = this.Height;
            s_Header.m_Width = this.Width;
            s_Header.m_Depth = this.Depth;

            s_Header.m_MipmapCount = this.MipmapCount;

            if (s_Header.m_MipmapCount > 0)
            {
                s_Header.m_Flags |= DDSFlags.MipmapCount;

                if (s_Header.m_MipmapCount > 1)
                    s_Header.m_Caps |= DDSCaps.MipmapFlags;
            }

            switch (Type)
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

            if (Flags.HasFlag(TextureFlags.SrgbGamma))  //NVIDIA format | some loaders might require this? (DirectXTex)
                s_Header.m_Flags |= DDSFlags.Srgb;


            if (!TextureUtils.ComputePitch(Format, Width, Height, out var s_RowPitch, out var s_SlicePitch))
                throw new Exception("Failed to compute pitch!");

            if (TextureUtils.IsCompressed(Format))
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

            if (DDSUtils.c_DDSFormatMap.TryGetValue(this.Format, out var s_Format))
            {
                s_Format.m_RGBBitCount = TextureUtils.BitsPerPixel(this.Format);

                s_Header.m_PixelFormat = s_Format;
            }
            else
            {
                if (!DDSUtils.c_DDSDXFormatMap.TryGetValue(this.Format, out var s_DXGIFormat))
                    throw new Exception($"Invalid textureformat {this.Format}");

                s_Header.m_PixelFormat = DDSPixelFormat.s_DXExtFormat;

                s_ExtendedHeader = new DDSDX10Header();


                s_ExtendedHeader.m_DxgiFormat = s_DXGIFormat;


                switch (this.Type)
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
        }
    }
}
