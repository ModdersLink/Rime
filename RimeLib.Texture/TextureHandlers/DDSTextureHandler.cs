
using System;
using System.IO;
using System.Linq;
using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite;
using RimeLib.Texture.Frostbite.DDS;
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
            var s_Texture = p_Handler.CreateTexture(Content.Frostbite.ResourceType.DxTexture, s_Header.Width, s_Header.Height, s_TextureFormat, s_TextureType, s_Header.MipMapCount);

            if (s_Texture is null)
                return false;

            var s_TextureData = p_Reader.ReadBytes((int) s_Texture.TextureSize);

            //Generate mimpaps using texture?

            var s_Writer = s_Texture?.Provider?.GetWriter();

            if (s_Writer is null)
                return false;

            s_Writer.Write(s_TextureData);

            return true;
        }


        public bool Save(TextureBase p_Texture, RimeWriter p_Writer)
        {
            if (!GenerateDDSHeader(p_Texture, out var s_Header, out var s_ExtendedHeader))
                return false;

            s_Header.Serialize(p_Writer);

            if (!(s_ExtendedHeader is null))
            {
                //Align
                if (p_Writer.Position % 0x10 != 0)
                    p_Writer.Seek(0x10 - (p_Writer.Position % 0x10), SeekOrigin.Current);

                s_ExtendedHeader.Serialize(p_Writer);
            }

            p_Texture.Provider?.GetReader()?.CopyTo(p_Writer);

            return true;
        }



        bool GenerateDDSHeader(TextureBase p_Texture, out DDSHeader p_Header, out DDSDX10Header? p_ExtendedHeader)
        {
            p_ExtendedHeader = null;
            p_Header = new DDSHeader( );

            // Signature, not needed
            p_Header.Reserved[9] = DDS.DDSUtils.MakeFourCC("RIME");

            // Set texture
            p_Header.Flags = DDSFlags.Texture;
            p_Header.Caps = DDSCaps.Texture;

            // Set texture info
            p_Header.Height = p_Texture.Height;
            p_Header.Width = p_Texture.Width;
            p_Header.Depth = p_Texture.Depth;

            // Mipmap
            p_Header.MipMapCount = p_Texture.MipmapCount;

            if (p_Header.MipMapCount > 0)
            {
                p_Header.Flags |= DDSFlags.MipmapCount;

                if (p_Header.MipMapCount > 1)
                    p_Header.Caps |= DDSCaps.MipmapFlags;
            }

            // Texture type
            switch (p_Texture.Type)
            {
            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                p_Header.Caps |= DDSCaps.Complex;
                p_Header.Caps2 |= DDSCaps2.AllFaces;
                break;

            case TextureType.TextureType_3D:
                p_Header.Flags |= DDSFlags.Depth;
                p_Header.Caps2 |= DDSCaps2.Volume;
                break;
            }

            // SRGB texture
            if (p_Texture.Flags.HasFlag(TextureFlags.SrgbGamma))  //NVIDIA format | some loaders might require this? (DirectXTex)
                p_Header.Flags |= DDSFlags.Srgb;

            // TODO: Fix pitch with proper bpp
            if (!TextureUtils.ComputePitch(p_Texture.Format, p_Texture.Width, p_Texture.Height, out var s_RowPitch, out var s_SlicePitch))
            {
                throw new Exception("Failed to compute pitch!");
                //return false;
            }

            if (TextureUtils.IsCompressed(p_Texture.Format))
            {
                p_Header.Flags |= DDSFlags.LinearSize;
                p_Header.PitchOrLinearSize = s_SlicePitch;
            }
            else
            {
                p_Header.Flags |= DDSFlags.Pitch;
                p_Header.PitchOrLinearSize = s_RowPitch;
            }

            if (DDSUtils.c_DDSFormatMap.TryGetValue(p_Texture.Format, out var s_Format))
            {
                s_Format.RGBBitCount = TextureUtils.BitsPerPixel(p_Texture.Format);

                p_Header.PixelFormat = s_Format;
            }
            else
            {
                if (!DDSUtils.c_DDSDXFormatMap.TryGetValue(p_Texture.Format, out var s_DXGIFormat))
                {
                    throw new Exception($"Invalid textureformat {p_Texture.Format}");
                    //return false;
                }

                // Set extended header
                p_Header.PixelFormat = DDSPixelFormat.s_DXExtFormat;

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
            p_Header = new DDSHeader(p_Reader);
            p_ExtendedHeader = p_Header.Dx10Header;

            return true;
        }

        void FindTextureInfo(DDSHeader p_Header, DDSDX10Header? p_ExtendedHeader, out TextureFormat p_Format, out TextureType p_Type)
        {
            // TODO: Fixme
            throw new NotImplementedException();

            /*
            p_Type = TextureType.TextureType_2D;

            if (p_ExtendedHeader != null)
            {
                if (p_ExtendedHeader.m_DxgiFormat == DXGIFormat.UNKNOWN)
                    throw new Exception("Invalid format for dx10 texture!");

                //TODO: rgb formats, typeless formats!!
                p_Format = Frostbite.DDS.DDSUtils.c_DDSDXFormatMap.Where(x => x.Value == p_ExtendedHeader.m_DxgiFormat).Select(x => x.Key).FirstOrDefault();

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
                    if (p_Header.PixelFormat.Flags == DDSFormatFlags.FourCC)
                    {
                        if (s_FormatPair.Value.Flags != DDSFormatFlags.FourCC)
                            continue;

                        if (s_FormatPair.Value.FourCC != p_Header.PixelFormat.FourCC)
                            continue;
                    }
                    else
                    {
                        if (s_FormatPair.Value.Flags != p_Header.PixelFormat.Flags)
                            continue;

                        if (s_FormatPair.Value.RBitMask != p_Header.PixelFormat.RBitMask)
                            continue;
                        if (s_FormatPair.Value.GBitMask != p_Header.PixelFormat.GBitMask)
                            continue;
                        if (s_FormatPair.Value.BBitMask != p_Header.PixelFormat.BBitMask)
                            continue;
                        if (s_FormatPair.Value.ABitMask != p_Header.PixelFormat.ABitMask)
                            continue;
                    }

                    p_Format = s_FormatPair.Key;
                    break;
                }

                if (p_Format == TextureFormat.TextureFormat_Unknown)
                    throw new Exception("Unsupported dds!");

                if (p_Header.Caps2.HasFlag(DDSCaps2.Cubemap))
                    p_Type = TextureType.TextureType_Cube;
                else if (p_Header.Flags.HasFlag(DDSFlags.Depth))
                    p_Type = TextureType.TextureType_3D;
                else if (p_Header.Height > 1)
                    p_Type = TextureType.TextureType_2D;
                else
                    p_Type = TextureType.TextureType_1D; //if the height is 1, load as texture1d
            }*/
        }

        void CalculateMipmaps(DDSHeader p_Header, TextureFormat p_Format, out uint[] p_MipmapSizes, out uint p_ChainSize)
        {
            p_MipmapSizes = new uint[0];
            p_ChainSize = 0;

            //Calculate mipmap slices, format needs to be set before this

            //This needs to be recalculated for specific consoles, take note

            if (p_Header.Flags.HasFlag(DDSFlags.MipmapCount))
            {
                p_MipmapSizes = new uint[p_Header.MipMapCount];

                //Calculate mimap sizes and chain size
                var s_CurrentWidth = (uint) p_Header.Width;
                var s_CurrentHeight = (uint) p_Header.Height;

                uint s_ChainSize = 0;

                for (var i = 0; i < p_Header.MipMapCount; i++)
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
