
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Security.AccessControl;

using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite;
using RimeLib.Texture.Frostbite.DDS;
using RimeLib.Texture;
using RimeLib.Content.Frostbite;
using RimeLib.Texture.Attributes;

namespace RimeLib.Texture.TextureHandlers
{
    [TextureHandler("dds")]
    class DDSTextureHandler : ITextureFileHandler
    {
        public DDSTextureHandler()
        {
        }

        /*
        public bool Save(RimeReader p_Reader, TextureBase p_Texture)
        {
            
            if (!ReadHeaders(p_Reader, out var s_Header, out var s_ExtendedHeader))
                return false;

            if (s_Header.m_Width != p_Texture.Width ||
                s_Header.m_Height != p_Texture.Height)
            {
                throw new Exception("Cannot load texture into buffer that doesnt match");
                return false;
            }


            FindTextureInfo(s_Header, s_ExtendedHeader, out var s_TextureFormat, out var s_TextureType);

            //TODO: Move to create texture
            CalculateMipmaps(s_Header, s_TextureFormat, out var s_MipmapSizes, out var s_ChainSize);

            var s_TextureData = p_Reader.ReadBytes((int) s_ChainSize);


            p_Texture.WriteData(s_TextureData);
            

            return true;
        }*/


        public bool Load(ITextureHandler p_Handler, RimeReader p_Reader, out TextureBase? p_Texture)
        {
            p_Texture = null;

            if (!ReadHeaders(p_Reader, out var s_Header, out var s_ExtendedHeader))
                return false;

            FindTextureInfo(s_Header, s_ExtendedHeader, out var s_TextureFormat, out var s_TextureType);

            //CalculateMipmaps(s_Header, s_TextureFormat, out _, out var s_ChainSize);

           

            // TODO: Custom textures support?
            var s_Texture = p_Handler.CreateTexture(ResourceType.DxTexture, s_Header.m_Width, s_Header.m_Height, s_TextureFormat, s_TextureType, s_Header.m_MipmapCount);

            if (s_Texture == null)
                return false;

            var s_TextureData = p_Reader.ReadBytes((int) s_Texture.TextureSize);

            //Generate mimpaps using texture?

            var s_Writer = s_Texture?.Provider?.GetWriter();

            if (s_Writer == null)
                return false;

            s_Writer.Write(s_TextureData);

            return true;
        }


        public bool Save(TextureBase p_Texture, RimeWriter p_Writer)
        {
            GenerateDDSHeader(p_Texture, out var s_Header, out var s_ExtendedHeader);

            s_Header.Serialize(p_Writer);

            if (s_ExtendedHeader != null)
            {
                //Align
                if (p_Writer.Position % 0x10 != 0)
                    p_Writer.Seek(0x10 - (p_Writer.Position % 0x10), SeekOrigin.Current);

                s_ExtendedHeader.Serialize(p_Writer);
            }

            p_Texture.Provider?.GetReader()?.CopyTo(p_Writer);

            return false;
        }



        bool GenerateDDSHeader(TextureBase p_Texture, out DDSHeader p_Header, out DDSDX10Header? p_ExtendedHeader)
        {
            p_ExtendedHeader = null;
            p_Header = new DDSHeader( );

            // Signature, not needed
            p_Header.m_Reserved1[9] = DDSPixelFormat.MakeFourCC("RIME");

            // Set texture
            p_Header.m_Flags = DDSFlags.Texture;
            p_Header.m_Caps = DDSCaps.Texture;

            // Set texture info
            p_Header.m_Height = p_Texture.Height;
            p_Header.m_Width = p_Texture.Width;
            p_Header.m_Depth = p_Texture.Depth;

            // Mipmap
            p_Header.m_MipmapCount = p_Texture.MipmapCount;

            if (p_Header.m_MipmapCount > 0)
            {
                p_Header.m_Flags |= DDSFlags.MipmapCount;

                if (p_Header.m_MipmapCount > 1)
                    p_Header.m_Caps |= DDSCaps.MipmapFlags;
            }

            // Texture type
            switch (p_Texture.Type)
            {
            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                p_Header.m_Caps |= DDSCaps.Complex;
                p_Header.m_Caps2 |= DDSCaps2.AllFaces;
                break;

            case TextureType.TextureType_3D:
                p_Header.m_Flags |= DDSFlags.Depth;
                p_Header.m_Caps2 |= DDSCaps2.Volume;
                break;
            }

            // SRGB texture
            if (p_Texture.Flags.HasFlag(TextureFlags.SrgbGamma))  //NVIDIA format | some loaders might require this? (DirectXTex)
                p_Header.m_Flags |= DDSFlags.Srgb;

            // TODO: Fix pitch with proper bpp
            if (!TextureUtils.ComputePitch(p_Texture.Format, p_Texture.Width, p_Texture.Height, out var s_RowPitch, out var s_SlicePitch))
            {
                throw new Exception("Failed to compute pitch!");
                //return false;
            }

            if (TextureUtils.IsCompressed(p_Texture.Format))
            {
                p_Header.m_Flags |= DDSFlags.LinearSize;
                p_Header.m_PitchOrLinearSize = s_SlicePitch;
            }
            else
            {
                p_Header.m_Flags |= DDSFlags.Pitch;
                p_Header.m_PitchOrLinearSize = s_RowPitch;
            }

            if (DDSUtils.c_DDSFormatMap.TryGetValue(p_Texture.Format, out var s_Format))
            {
                s_Format.m_RGBBitCount = TextureUtils.BitsPerPixel(p_Texture.Format);

                p_Header.m_PixelFormat = s_Format;
            }
            else
            {
                if (!DDSUtils.c_DDSDXFormatMap.TryGetValue(p_Texture.Format, out var s_DXGIFormat))
                {
                    throw new Exception($"Invalid textureformat {p_Texture.Format}");
                    //return false;
                }

                // Set extended header
                p_Header.m_PixelFormat = DDSPixelFormat.s_DXExtFormat;

                p_ExtendedHeader = new DDSDX10Header();


                p_ExtendedHeader.m_DxgiFormat = s_DXGIFormat;

                // Texture type
                switch (p_Texture.Type)
                {
                case TextureType.TextureType_1D:
                case TextureType.TextureType_1DArray:
                    p_ExtendedHeader.m_ResourceDimension = DDSResoruceDimension.Texture1D;
                    break;

                case TextureType.TextureType_2D:
                case TextureType.TextureType_2DArray:
                    p_ExtendedHeader.m_ResourceDimension = DDSResoruceDimension.Texture2D;
                    break;

                case TextureType.TextureType_3D:
                    p_ExtendedHeader.m_ResourceDimension = DDSResoruceDimension.Texture3D;
                    break;

                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    p_ExtendedHeader.m_ResourceDimension = DDSResoruceDimension.Texture2D;

                    p_ExtendedHeader.m_MiscFlag = DDSMiscFlag1.TextureCube;
                    p_ExtendedHeader.m_ArraySize = 6;
                    break;
                }
            }

            return true;
        }

        bool ReadHeaders(RimeReader p_Reader, out DDSHeader p_Header, out DDSDX10Header? p_ExtendedHeader)
        {
            p_ExtendedHeader = null;

            var s_StartPosition = p_Reader.Position;

            p_Header = new DDSHeader(p_Reader);

            p_Reader.Seek(s_StartPosition + p_Header.m_Size, SeekOrigin.Begin);

            if (p_Header.m_PixelFormat.m_Flags.HasFlag(DDSFormatFlags.FourCC) &&
                p_Header.m_PixelFormat.m_FourCC == DDSPixelFormat.s_DXExtFormat.m_FourCC) //This is a dx texture
            {
                //This is aligned for some reason
                p_Reader.Align(0x10);

                p_ExtendedHeader = new DDSDX10Header(p_Reader);

                if (p_ExtendedHeader.m_DxgiFormat == DXGIFormat.UNKNOWN)
                {
                    throw new Exception("Invalid format for dx10 texture!");
                    // return false;
                }
            }
            return true;
        }

        void FindTextureInfo(DDSHeader p_Header, DDSDX10Header? p_ExtendedHeader, out TextureFormat p_Format, out TextureType p_Type)
        {
            p_Type = TextureType.TextureType_2D;

            if (p_ExtendedHeader != null)
            {
                if (p_ExtendedHeader.m_DxgiFormat == DXGIFormat.UNKNOWN)
                    throw new Exception("Invalid format for dx10 texture!");

                //TODO: rgb formats, typeless formats!!
                p_Format = DDSUtils.c_DDSDXFormatMap.Where(x => x.Value == p_ExtendedHeader.m_DxgiFormat).Select(x => x.Key).FirstOrDefault();

                //Read type from extendedheader
                if (p_ExtendedHeader.m_MiscFlag.HasFlag(DDSMiscFlag1.TextureCube))
                {
                    p_Type = TextureType.TextureType_Cube;

                    if (p_ExtendedHeader.m_ArraySize != 6)
                        throw new Exception("This cube is not a full cube");
                }
                else
                {
                    switch (p_ExtendedHeader.m_ResourceDimension)
                    {
                    case DDSResoruceDimension.Texture1D:
                        p_Type = TextureType.TextureType_1D;
                        break;
                    case DDSResoruceDimension.Texture2D:
                        p_Type = TextureType.TextureType_2D;
                        break;
                    case DDSResoruceDimension.Texture3D:
                        p_Type = TextureType.TextureType_3D;
                        break;
                    }
                }
            }
            else
            {
                p_Format = TextureFormat.TextureFormat_Unknown;

                //Match texture format, clean this up maybe?
                foreach (var s_FormatPair in DDSUtils.c_DDSFormatMap)
                {
                    if (p_Header.m_PixelFormat.m_Flags == DDSFormatFlags.FourCC)
                    {
                        if (s_FormatPair.Value.m_Flags != DDSFormatFlags.FourCC)
                            continue;

                        if (s_FormatPair.Value.m_FourCC != p_Header.m_PixelFormat.m_FourCC)
                            continue;
                    }
                    else
                    {
                        if (s_FormatPair.Value.m_Flags != p_Header.m_PixelFormat.m_Flags)
                            continue;

                        if (s_FormatPair.Value.m_RBitMask != p_Header.m_PixelFormat.m_RBitMask)
                            continue;
                        if (s_FormatPair.Value.m_GBitMask != p_Header.m_PixelFormat.m_GBitMask)
                            continue;
                        if (s_FormatPair.Value.m_BBitMask != p_Header.m_PixelFormat.m_BBitMask)
                            continue;
                        if (s_FormatPair.Value.m_ABitMask != p_Header.m_PixelFormat.m_ABitMask)
                            continue;
                    }

                    p_Format = s_FormatPair.Key;
                    break;
                }

                if (p_Format == TextureFormat.TextureFormat_Unknown)
                    throw new Exception("Unsupported dds!");

                if (p_Header.m_Caps2.HasFlag(DDSCaps2.Cubemap))
                    p_Type = TextureType.TextureType_Cube;
                else if (p_Header.m_Flags.HasFlag(DDSFlags.Depth))
                    p_Type = TextureType.TextureType_3D;
                else if (p_Header.m_Height > 1)
                    p_Type = TextureType.TextureType_2D;
                else
                    p_Type = TextureType.TextureType_1D; //if the height is 1, load as texture1d
            }
        }

        void CalculateMipmaps(DDSHeader p_Header, TextureFormat p_Format, out uint[] p_MipmapSizes, out uint p_ChainSize)
        {
            p_MipmapSizes = new uint[0];
            p_ChainSize = 0;

            //Calculate mipmap slices, format needs to be set before this

            //This needs to be recalculated for specific consoles, take note

            if (p_Header.m_Flags.HasFlag(DDSFlags.MipmapCount))
            {
                p_MipmapSizes = new uint[p_Header.m_MipmapCount];

                //Calculate mimap sizes and chain size
                var s_CurrentWidth = (uint) p_Header.m_Width;
                var s_CurrentHeight = (uint) p_Header.m_Height;

                uint s_ChainSize = 0;

                for (var i = 0; i < p_Header.m_MipmapCount; i++)
                {
                    TextureUtils.ComputePitch(p_Format, s_CurrentWidth, s_CurrentHeight, out var _, out var s_SlicePitch);

                    p_MipmapSizes[i] = s_SlicePitch;

                    s_ChainSize += s_SlicePitch;

                    s_CurrentWidth /= 2;
                    s_CurrentHeight /= 2;

                }

                p_ChainSize = s_ChainSize;
            }
        }

    }
}
