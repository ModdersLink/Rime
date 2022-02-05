
using System;
using System.IO;
using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite;
using RimeLib.Texture.Attributes;
using System.Collections.Generic;

namespace RimeLib.Texture.TextureHandlers
{
    [TextureHandler("dds")]
    class DDSTextureHandler : ITextureFileHandler
    {
        public DDSTextureHandler()
        {
        }

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
            SaveDDS(p_Writer, p_Texture, p_Texture.Provider!.GetReader()!);

            return true;
        }

        public static void SaveDDS(RimeWriter p_Writer, TextureBase p_TextureHeader, RimeReader p_ImageData)
        {
            var s_DDSHeader = FromTexture(p_TextureHeader);

            s_DDSHeader.Serialize(p_Writer);
            p_Writer.Write(p_ImageData);
        }

        public static DDSFormatFlags PixelFormatFlagsFromTexture(TextureBase p_TextureHeader)
        {
            if (!TextureUtils.s_FormatFlags.TryGetValue(p_TextureHeader.Format, out DDSFormatFlags s_Format))
                return DDSFormatFlags.None;

            return s_Format;
        }

        public static DDSCaps CapsFromTexture(TextureBase p_TextureHeader)
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
                s_Caps |= DDSCaps.Mipmap;

            return s_Caps;
        }

        public static DDSCaps2 Caps2FromTexture(TextureBase p_TextureHeader)
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

        public static DDSResoruceDimension ResourceDimensionFromTexture(TextureBase p_TextureHeader)
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

        public static DDSMiscFlag1 MiscFlag1FromTexture(TextureBase p_TextureHeader)
        {
            switch (p_TextureHeader.Type)
            {
                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    return DDSMiscFlag1.TextureCube;
            }

            return 0;
        }

        public static uint ArraySizeFromTexture(TextureBase p_TextureHeader)
        {
            switch (p_TextureHeader.Type)
            {
                case TextureType.TextureType_Cube:
                case TextureType.TextureType_CubeArray:
                    return 6;
            }

            return 0;
        }

        public static DDSMiscFlag2 MiscFlag2FromTexture(TextureBase p_TextureHeader)
        {
            // The legacy D3DX 10 and D3DX 11 utility libraries will fail to load any .DDS file with miscFlags2 not equal to zero.

            return 0;
        }

        public static DDSFlags DDSFlagsFromTexture(TextureBase p_TextureHeader)
        {
            // Start with the required flags for all textures
            DDSFlags s_Flags = DDSFlags.Caps | DDSFlags.Height | DDSFlags.Width | DDSFlags.PixelFormat;

            // Set flag if texture is not compressed
            if (!TextureUtils.IsCompressed(p_TextureHeader.Format))
                s_Flags |= DDSFlags.Pitch;
            else
                s_Flags |= DDSFlags.LinearSize;

            // Check to see if we have any mipmaps
            if (p_TextureHeader.MipmapCount > 1)
                s_Flags |= DDSFlags.MipmapCount;

            if (p_TextureHeader.Depth > 1)
                s_Flags |= DDSFlags.Depth;

            if (p_TextureHeader.Flags.HasFlag(TextureFlags.SrgbGamma))
                s_Flags |= DDSFlags.Srgb;

            return s_Flags;
        }

        public static DXGIFormat DXGIFormatFromTexture(TextureBase p_Texture)
        {
            var s_IsSrgb = (p_Texture.Flags & TextureFlags.SrgbGamma) != 0;

            return p_Texture.Format switch
            {
                TextureFormat.TextureFormat_DXT1 or TextureFormat.TextureFormat_NormalDXT1 => s_IsSrgb ? DXGIFormat.BC1_UNORM_SRGB : DXGIFormat.BC1_UNORM,
                TextureFormat.TextureFormat_DXT3 => s_IsSrgb ? DXGIFormat.BC2_UNORM_SRGB : DXGIFormat.BC2_UNORM,
                TextureFormat.TextureFormat_DXT5 or TextureFormat.TextureFormat_NormalDXT5 or TextureFormat.TextureFormat_NormalDXT5RGA => s_IsSrgb ? DXGIFormat.BC3_UNORM_SRGB : DXGIFormat.BC3_UNORM,
                TextureFormat.TextureFormat_DXT5A => DXGIFormat.BC4_UNORM,
                TextureFormat.TextureFormat_DXN or TextureFormat.TextureFormat_NormalDXN => DXGIFormat.BC5_UNORM,
                TextureFormat.TextureFormat_RGB565 => DXGIFormat.B5G6R5_UNORM,
                TextureFormat.TextureFormat_ARGB1555 => DXGIFormat.B5G5R5A1_UNORM,
                TextureFormat.TextureFormat_ARGB4444 => DXGIFormat.B4G4R4A4_UNORM,
                TextureFormat.TextureFormat_ARGB8888 => s_IsSrgb ? DXGIFormat.R8G8B8A8_UNORM_SRGB : DXGIFormat.R8G8B8A8_UNORM,
                TextureFormat.TextureFormat_L8 => DXGIFormat.R8_UNORM,
                TextureFormat.TextureFormat_L16 or TextureFormat.TextureFormat_D16 => DXGIFormat.R16_UNORM,
                TextureFormat.TextureFormat_ABGR16 => DXGIFormat.R16G16B16A16_UNORM,
                TextureFormat.TextureFormat_ABGR16F => DXGIFormat.R16G16B16A16_FLOAT,
                TextureFormat.TextureFormat_ABGR32F => DXGIFormat.R32G32B32A32_FLOAT,
                TextureFormat.TextureFormat_R16F => DXGIFormat.R16_FLOAT,
                TextureFormat.TextureFormat_R32F => DXGIFormat.D32_FLOAT,
                TextureFormat.TextureFormat_GR16 => DXGIFormat.R16G16_UNORM,
                TextureFormat.TextureFormat_GR16F => DXGIFormat.R16G16_FLOAT,
                TextureFormat.TextureFormat_D24S8 => DXGIFormat.D24_UNORM_S8_UINT,
                TextureFormat.TextureFormat_D32F => DXGIFormat.D32_FLOAT,
                TextureFormat.TextureFormat_ABGR32 => DXGIFormat.R32G32B32A32_UINT,
                TextureFormat.TextureFormat_GR32F => DXGIFormat.R32G32_FLOAT,
                TextureFormat.TextureFormat_A2R10G10B10 => DXGIFormat.R10G10B10A2_UNORM,
                _ => DXGIFormat.UNKNOWN
            };
        }

        public static uint FourCCFromTexture(TextureBase p_Texture)
        {
            switch (p_Texture.Format)
            {
                default:
                    break;
            }

            return 0;
        }

        public static DDSPixelFormat PixelFormatFromTexture(TextureBase p_Texture)
        {
            if (DDSUtils.c_DDSFormatMap.TryGetValue(p_Texture.Format, out var s_Format))
                return s_Format;

            return new DDSPixelFormat
            {
                Size = 32,
                Flags = 0,
                FourCC = 0,
                RGBBitCount = 0,
                ABitMask = 0,
                BBitMask = 0,
                GBitMask = 0,
                RBitMask = 0
            };
        }

        public static uint DepthFromTexture(TextureBase p_Texture)
        {
            return p_Texture.Depth;
        }

        public static DDSHeader FromTexture(TextureBase p_Texture)
        {
            var s_DXGIFormat = DXGIFormatFromTexture(p_Texture);

            var s_PixelFormat = PixelFormatFromTexture(p_Texture);

            if (!DDSUtils.c_DDSFormatMap.TryGetValue(p_Texture.Format, out var s_Format))
            {
                Console.WriteLine($"could not get dds format map for format {p_Texture.Format}.");
            }
            
            TextureUtils.ComputePitch(s_DXGIFormat, p_Texture.Width, p_Texture.Height, out long s_RowPitch, out long s_SlicePitch, TextureUtils.CPFLAGS.NONE);

            return new DDSHeader
            {
                Magic = DDSHeader.c_DDSMagic,
                // https://docs.microsoft.com/en-us/windows/win32/direct3ddds/dds-header
                Flags = DDSFlagsFromTexture(p_Texture),
                Height = p_Texture.Height,
                Width = p_Texture.Width,
                PitchOrLinearSize = (uint)(TextureUtils.IsCompressed(p_Texture.Format) ? s_SlicePitch : s_RowPitch), // TODO: Verify
                Depth = DepthFromTexture(p_Texture),
                MipMapCount = p_Texture.MipmapCount,
                Reserved = new uint[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, DDSUtils.MakeFourCC("RIME") },
                PixelFormat = s_PixelFormat,
                Caps = CapsFromTexture(p_Texture),
                Caps2 = Caps2FromTexture(p_Texture),
                Caps3 = 0,
                Caps4 = 0,
                Reserved2 = 0,
                Dx10Header = (s_Format != null ? (s_Format.FourCC == DDSUtils.MakeFourCC("DX10") ? new DDSDX10Header
                {
                    DxgiFormat = s_DXGIFormat,
                    ResourceDimension = ResourceDimensionFromTexture(p_Texture),
                    MiscFlag = MiscFlag1FromTexture(p_Texture),
                    ArraySize = ArraySizeFromTexture(p_Texture),
                    MiscFlags2 = MiscFlag2FromTexture(p_Texture),
                } : null) : null)
            };
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
    }
}
