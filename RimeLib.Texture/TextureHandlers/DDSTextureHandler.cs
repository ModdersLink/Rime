
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
            SaveDDS(p_Writer, p_Texture, p_Texture.Provider!.GetReader()!.BaseStream);

            return true;
        }

        public static void SaveDDS(RimeWriter p_Writer, TextureBase p_TextureHeader, Stream p_ImageData)
        {
            var s_DDSHeader = FromTextureHeader(p_TextureHeader);

            s_DDSHeader.Serialize(p_Writer);
            p_Writer.Write(new RimeReader(p_ImageData, p_ShouldDispose: false).ReadBytes((int)p_ImageData.Length));
        }

        public static DDSFormatFlags PixelFormatFlagsFromTextureHeader(TextureBase p_TextureHeader)
        {
            if (!TextureUtils.s_FormatFlags.TryGetValue(p_TextureHeader.Format, out DDSFormatFlags s_Format))
                return DDSFormatFlags.None;

            return s_Format;
        }

        public static DDSCaps CapsFromTextureHeader(TextureBase p_TextureHeader)
        {
            DDSCaps s_Caps = DDSCaps.Texture;
            switch (p_TextureHeader.Type)
            {
                case TextureType.TextureType_1D:
                case TextureType.TextureType_1DArray:
                case TextureType.TextureType_2D:
                case TextureType.TextureType_2DArray:
                case TextureType.TextureType_3D:
                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    s_Caps |= DDSCaps.Complex;
                    break;
            }

            if (p_TextureHeader.MipmapCount > 1)
                s_Caps |= DDSCaps.MipmapFlags;

            return s_Caps;
        }

        public static DDSCaps2 Caps2FromTextureHeader(TextureBase p_TextureHeader)
        {
            DDSCaps2 s_Caps = 0;
            switch (p_TextureHeader.Type)
            {
                case TextureType.TextureType_3D:
                    s_Caps |= DDSCaps2.Volume;
                    break;
                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    s_Caps |= DDSCaps2.AllFaces;
                    break;
            }

            return s_Caps;
        }

        public static DDSResoruceDimension ResourceDimensionFromTextureHeader(TextureBase p_TextureHeader)
        {
            switch (p_TextureHeader.Type)
            {
                case TextureType.TextureType_1D:
                case TextureType.TextureType_1DArray:
                    return DDSResoruceDimension.Texture1D;
                case TextureType.TextureType_2D:
                case TextureType.TextureType_2DArray:
                    return DDSResoruceDimension.Texture2D;

                case TextureType.TextureType_3D:
                    return DDSResoruceDimension.Texture3D;

                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    return DDSResoruceDimension.Texture2D;
            }

            return 0;
        }

        public static DDSMiscFlag1 MiscFlag1FromTextureHeader(TextureBase p_TextureHeader)
        {
            switch (p_TextureHeader.Type)
            {
                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    return DDSMiscFlag1.TextureCube;
            }

            return 0;
        }

        public static uint ArraySizeFromTextureHeader(TextureBase p_TextureHeader)
        {
            switch (p_TextureHeader.Type)
            {
                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    return 6;
            }

            return 0;
        }

        public static DDSMiscFlag2 MiscFlag2FromTextureHeader(TextureBase p_TextureHeader)
        {
            // The legacy D3DX 10 and D3DX 11 utility libraries will fail to load any .DDS file with miscFlags2 not equal to zero.
            return 0;
        }

        public static DDSFlags DDSFlagsFromTextureHeader(TextureBase p_TextureHeader)
        {
            // Start with the required flags for all textures
            DDSFlags s_Flags = DDSFlags.Caps | DDSFlags.Height | DDSFlags.Width | DDSFlags.PixelFormat;

            // Set flag if texture is not compressed
            if (!TextureUtils.IsCompressed(p_TextureHeader.Format))
                s_Flags |= DDSFlags.Pitch;
            else
                s_Flags |= DDSFlags.LinearSize;

            // Check to see if we have any mipmaps
            if (p_TextureHeader.MipmapCount > 0)
                s_Flags |= DDSFlags.MipmapCount;

            if (p_TextureHeader.Depth > 1)
                s_Flags |= DDSFlags.Depth;

            /*if (p_TextureHeader.Flags.HasFlag(TextureFlags.SrgbGamma))
                s_Flags |= DDSFlags.Srgb;*/

            return s_Flags;
        }

        public static DDSHeader FromTextureHeader(TextureBase p_TextureHeader)
        {
            if (!DDSUtils.c_DDSDXFormatMap.TryGetValue(p_TextureHeader.Format, out var s_DXGIFormat))
            {
                throw new Exception($"Invalid textureformat {p_TextureHeader.Format}");
            }

            if (!DDSUtils.c_DDSFormatMap.TryGetValue(p_TextureHeader.Format, out var s_Format))
            {
                Console.WriteLine($"could not get dds format map for format {p_TextureHeader.Format}.");
            }
            
            TextureUtils.ComputePitch(s_DXGIFormat, p_TextureHeader.Width, p_TextureHeader.Height, out long s_RowPitch, out long s_SlicePitch, TextureUtils.CPFLAGS.NONE);

            return new DDSHeader
            {
                Magic = DDSHeader.c_DDSMagic,
                // https://docs.microsoft.com/en-us/windows/win32/direct3ddds/dds-header
                Flags = DDSFlagsFromTextureHeader(p_TextureHeader),
                Height = p_TextureHeader.Height,
                Width = p_TextureHeader.Width,
                PitchOrLinearSize = (uint)(TextureUtils.IsCompressed(p_TextureHeader.Format) ? s_SlicePitch : s_RowPitch), // TODO: Verify
                Depth = (p_TextureHeader.Depth > 1 ? p_TextureHeader.Depth : 0),
                MipMapCount = p_TextureHeader.MipmapCount,
                Reserved = new uint[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, DDSUtils.MakeFourCC("RIME") },
                PixelFormat = (s_Format != null ? s_Format : new DDSPixelFormat
                {
                    Size = 32,
                    Flags = DDSFormatFlags.FourCC,
                    FourCC = DDSUtils.MakeFourCC("DX10"),
                    RGBBitCount = 0,
                    RBitMask = 0,
                    GBitMask = 0,
                    BBitMask = 0,
                    ABitMask = 0
                }),
                Caps = CapsFromTextureHeader(p_TextureHeader),
                Caps2 = Caps2FromTextureHeader(p_TextureHeader),
                Caps3 = 0,
                Caps4 = 0,
                Reserved2 = 0,
                Dx10Header = (s_Format != null ? (s_Format.FourCC == DDSUtils.MakeFourCC("DX10") ? new DDSDX10Header
                {
                    DxgiFormat = s_DXGIFormat,
                    ResourceDimension = ResourceDimensionFromTextureHeader(p_TextureHeader),
                    MiscFlag = MiscFlag1FromTextureHeader(p_TextureHeader),
                    ArraySize = ArraySizeFromTextureHeader(p_TextureHeader),
                    MiscFlags2 = MiscFlag2FromTextureHeader(p_TextureHeader),
                } : null) : null)
            };
        }

        static uint CalculateBlockCompressedPitch(uint p_Width, uint p_BlockSize)
        {
            return System.Math.Max(1, ((p_Width + 3) / 4)) * p_BlockSize;
        }

        static uint CalculateLegacyPitch(uint p_Width)
        {
            return ((p_Width + 1) >> 1) * 4;
        }

        static uint CalculateOtherPitch(uint p_Width, uint p_BitsPerPixel)
        {
            return (p_Width * p_BitsPerPixel + 7) / 8;
        }

        static uint CalculatePitch(TextureFormat p_Format, uint p_Width, uint p_BitsPerPixel = 0)
        {
            // https://docs.microsoft.com/en-us/windows/win32/direct3ddds/dx-graphics-dds-pguide
            switch (p_Format)
            {
                // For block-compressed formats, compute the pitch as:
                // The block-size is 8 bytes for DXT1, BC1 and BC4 formats
                // 16 bytes for other block-compressed formats.

                // BC1
                case TextureFormat.TextureFormat_Dxt1:
                case TextureFormat.TextureFormat_Dxt1A:
                case TextureFormat.TextureFormat_NormalDxt1:

                // BC2
                case TextureFormat.TextureFormat_Dxt3:
                // BC3
                case TextureFormat.TextureFormat_Dxt5:
                case TextureFormat.TextureFormat_NormalDxt5:
                case TextureFormat.TextureFormat_NormalDxt5Rga:
                // BC4
                case TextureFormat.TextureFormat_Dxt5A:
                // BC5
                case TextureFormat.TextureFormat_Dxn:
                case TextureFormat.TextureFormat_NormalDxn:
                // BC 7
                case TextureFormat.TextureFormat_Bc7:
                    return CalculateBlockCompressedPitch(p_Width, 8);
                case TextureFormat.TextureFormat_Rgb888:
                    return CalculateLegacyPitch(p_Width);
                default:
                    return CalculateOtherPitch(p_Width, TextureUtils.BitsPerPixel(p_Format));
                    //throw new Exception($"unsupported type {p_Format}.");
            }
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

            if (!DDSUtils.c_DDSDXFormatMap.TryGetValue(p_Texture.Format, out var s_DXGIFormat))
                throw new Exception($"Invalid textureformat {p_Texture.Format}");

            TextureUtils.ComputePitch(s_DXGIFormat, p_Texture.Width, p_Texture.Height, out long s_RowPitch, out long s_SlicePitch, TextureUtils.CPFLAGS.NONE);


            // TODO: Fix pitch with proper bpp
            //if (!TextureUtils.ComputePitch(p_Texture.Format, p_Texture.Width, p_Texture.Height, out var s_RowPitch, out var s_SlicePitch))
            //{
            //    throw new Exception("Failed to compute pitch!");
            //    //return false;
            //}

            if (TextureUtils.IsCompressed(p_Texture.Format))
            {
                p_Header.Flags |= DDSFlags.LinearSize;
                p_Header.PitchOrLinearSize = (uint)s_SlicePitch;
            }
            else
            {
                p_Header.Flags |= DDSFlags.Pitch;
                p_Header.PitchOrLinearSize = (uint)s_RowPitch;
            }

            if (DDSUtils.c_DDSFormatMap.TryGetValue(p_Texture.Format, out var s_Format))
            {
                s_Format.RGBBitCount = TextureUtils.BitsPerPixel(p_Texture.Format);

                p_Header.PixelFormat = s_Format;
            }
            else
            {
                if (!DDSUtils.c_DDSDXFormatMap.TryGetValue(p_Texture.Format, out s_DXGIFormat))
                {
                    throw new Exception($"Invalid textureformat {p_Texture.Format}");
                    //return false;
                }

                // Set extended header
                p_Header.PixelFormat = DDSPixelFormat.s_DXExtFormat;

                p_ExtendedHeader = new DDSDX10Header();


                p_ExtendedHeader.DxgiFormat = s_DXGIFormat;

                // Texture type
                switch (p_Texture.Type)
                {
                case TextureType.TextureType_1D:
                case TextureType.TextureType_1DArray:
                    p_ExtendedHeader.ResourceDimension = DDSResoruceDimension.Texture1D;
                    break;

                case TextureType.TextureType_2D:
                case TextureType.TextureType_2DArray:
                    p_ExtendedHeader.ResourceDimension = DDSResoruceDimension.Texture2D;
                    break;

                case TextureType.TextureType_3D:
                    p_ExtendedHeader.ResourceDimension = DDSResoruceDimension.Texture3D;
                    break;

                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    p_ExtendedHeader.ResourceDimension = DDSResoruceDimension.Texture2D;

                    p_ExtendedHeader.MiscFlag = DDSMiscFlag1.TextureCube;
                    p_ExtendedHeader.ArraySize = 6;
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
