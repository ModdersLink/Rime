using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite;
using RimeLib.Texture.Frostbite2_0.Engine;
using RimeLib.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace RimeLib.Texture.Frostbite2_0
{
    public static class FB2DDSImporter
    {
        public static TextureType TextureTypeFromDDSHeader(DDSHeader p_Header)
        {

            // TODO: Implement
            // TODO: Do we allow this to be user selectable? There's no real way to know from DDS
            return TextureType.TextureType_2D;
        }

        public static TextureFormat TextureFormatFromDDSHeader(DDSHeader p_Header)
        {
            var s_IsNormal = false;
            if (p_Header.PixelFormat.Flags.HasFlag(DDSFormatFlags.FourCC))
            {
                if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT1"))
                {
                    return s_IsNormal ? TextureFormat.TextureFormat_NormalDXT1 : TextureFormat.TextureFormat_DXT1;
                }
                else if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT3"))
                {
                    return TextureFormat.TextureFormat_DXT3;
                }
                else if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT5"))
                {
                    return s_IsNormal ? TextureFormat.TextureFormat_NormalDXT5 : TextureFormat.TextureFormat_DXT5;
                }
                else if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DX10"))
                {
                    // Read the DX10Header
                    var s_Dx10Header = p_Header.Dx10Header;

                    return s_Dx10Header.DxgiFormat switch
                    {
                        DXGIFormat.BC1_UNORM or DXGIFormat.BC1_UNORM_SRGB => TextureFormat.TextureFormat_DXT1,
                        DXGIFormat.BC2_UNORM_SRGB or DXGIFormat.BC2_UNORM => TextureFormat.TextureFormat_DXT3,
                        DXGIFormat.BC3_UNORM_SRGB or DXGIFormat.BC3_UNORM => TextureFormat.TextureFormat_DXT5,
                        DXGIFormat.BC4_UNORM => TextureFormat.TextureFormat_DXT5A,
                        DXGIFormat.BC5_UNORM => TextureFormat.TextureFormat_DXN,
                        DXGIFormat.B5G6R5_UNORM => TextureFormat.TextureFormat_RGB565,
                        DXGIFormat.B5G5R5A1_UNORM => TextureFormat.TextureFormat_ARGB1555,
                        DXGIFormat.B4G4R4A4_UNORM => TextureFormat.TextureFormat_ARGB4444,
                        DXGIFormat.R8G8B8A8_UNORM_SRGB or DXGIFormat.R8G8B8A8_UNORM => TextureFormat.TextureFormat_ARGB8888,
                        DXGIFormat.R8_UNORM => TextureFormat.TextureFormat_L8,
                        DXGIFormat.R16_UNORM => TextureFormat.TextureFormat_L16,
                        DXGIFormat.R16G16B16A16_UNORM => TextureFormat.TextureFormat_ABGR16,
                        DXGIFormat.R16G16B16A16_FLOAT => TextureFormat.TextureFormat_ABGR16F,
                        DXGIFormat.R32G32B32A32_FLOAT => TextureFormat.TextureFormat_ABGR32F,
                        DXGIFormat.R16_FLOAT => TextureFormat.TextureFormat_R16F,
                        DXGIFormat.D32_FLOAT => TextureFormat.TextureFormat_R32F, // or TextureFormat_D32F, need to check ARGBFlagBits to determine?
                        DXGIFormat.R16G16_UNORM => TextureFormat.TextureFormat_GR16,
                        DXGIFormat.R16G16_FLOAT => TextureFormat.TextureFormat_GR16F,
                        DXGIFormat.D24_UNORM_S8_UINT => TextureFormat.TextureFormat_D24S8,
                        //DXGIFormat.D32_FLOAT => TextureFormat.TextureFormat_D32F,
                        DXGIFormat.R32G32B32A32_UINT => TextureFormat.TextureFormat_ABGR32,
                        DXGIFormat.R32G32_FLOAT => TextureFormat.TextureFormat_GR32F,
                        DXGIFormat.R10G10B10A2_UNORM => TextureFormat.TextureFormat_A2R10G10B10,
                        _ => TextureFormat.TextureFormat_Unknown
                    };
                }
                else if (p_Header.PixelFormat.FourCC == 111)
                {
                    return TextureFormat.TextureFormat_R16F;
                }
            }

#if DEBUG
            throw new NotImplementedException();
#else

            return TextureFormat.TextureFormat_Unknown;
#endif
        }

        public static TextureFlags TextureFlagsFromDDSHeader(DDSHeader p_Header)
        {
            // Default to all textures being streamable
            var s_Flags = TextureFlags.Streaming;

            // Add SRGB support
            if (p_Header.Flags.HasFlag(DDSFlags.Srgb))
                s_Flags |= TextureFlags.SrgbGamma;

            return s_Flags;
        }

        public static uint CalculateDXTSizeFromHeader(DDSHeader p_Header, uint p_MipMap = 0)
        {
            var s_Format = TextureFormatFromDDSHeader(p_Header);
            var s_Width = p_Header.Width;
            var s_Height = p_Header.Height;
            var s_BlockSize = ((s_Format == TextureFormat.TextureFormat_NormalDXT1 || s_Format == TextureFormat.TextureFormat_DXT1) ? 8 : 16);

            var s_MipMapSize = ((s_Width + 3) / 4) * ((s_Height + 3) / 4) * s_BlockSize;
            for (var i = 0; i < p_MipMap; ++i)
            {
                // TODOD: Verify this is correct
                s_MipMapSize = System.Math.Max(s_BlockSize, (s_MipMapSize / 4));
            }
            return (uint)s_MipMapSize;
        }

        public static uint CalcualteRGBSizeFromHeader(uint p_Width, uint p_Height, uint p_Components, uint p_MipMap = 0)
        {
            var s_Size = p_Width * p_Height * p_Components;
            
            for (var i = 0; i < p_MipMap; ++i)
            {
                s_Size /= 4;
            }

            return s_Size;
        }

        public static uint[] CalculateMipMapSizes(DDSHeader p_Header)
        {
            var s_Chain = new uint[15];
            var s_Format = TextureFormatFromDDSHeader(p_Header);
            var s_Compressed = TextureUtils.IsCompressed(s_Format);

            for (uint i = 0; i < p_Header.MipMapCount; ++i)
            {
                if (s_Compressed)
                    s_Chain[i] = CalculateDXTSizeFromHeader(p_Header, i);
                else
                    s_Chain[i] = CalcualteRGBSizeFromHeader(p_Header.Width, p_Header.Height, 4, i);
            }

            return s_Chain;
        }

        public static TextureHeader TextureHeaderFromDDSHeader(DDSHeader p_Header, string p_Name = "", string p_TextureGroup = "", short p_SliceCount = 1)
        {
            /*
             * SliceCount seems to be how many "objects" are on this texture
             * as in if it's a TextureType.Cube then sliceCount will be 6
             * 
             * Sometimes things like 2DArray also show up with slice count != 1
             * In the cases I looked they were 2, 6
             */

            var s_MipMapSizes = CalculateMipMapSizes(p_Header);

            return new TextureHeader
            {
                Type = TextureTypeFromDDSHeader(p_Header),
                Format = TextureFormatFromDDSHeader(p_Header),
                Flags = TextureFlagsFromDDSHeader(p_Header),
                Width = (short)p_Header.Width,
                Height = (short)p_Header.Height,
                Depth = (short)p_Header.Depth,
                SliceCount = p_SliceCount,
                Unused0 = 0,
                MipmapCount = (byte)p_Header.MipMapCount,
                MipmapBaseIndex = 0, // Should this be user settable??
                StreamingChunkId = Guid.Empty,
                MipmapSizes = s_MipMapSizes,
                MipmapChainSize = (uint)s_MipMapSizes.Sum(x => x),
                ResourceNamehash = (string.IsNullOrWhiteSpace(p_Name) ? 0 : FbUtils.HashQuick(p_Name)),
                TextureGroup = "Default"
            };
        }
        public static void LoadDDS(RimeReader p_Reader, out TextureHeader p_Header, out Stream p_Data)
        {
            
            var s_StartPosition = p_Reader.Position;

            var s_DDSHeader = new DDSHeader(p_Reader);

            var s_TextureDataStart = s_StartPosition + 4 + DDSHeader.c_DDSHeaderSize;
            if (s_DDSHeader.Dx10Header != null)
                s_TextureDataStart += DDSDX10Header.c_HeaderSize;

            p_Header = TextureHeaderFromDDSHeader(s_DDSHeader);

            p_Data = new MemoryStream();
            using (var s_Writer = new RimeWriter(p_Data, p_ShouldDispose: false))
                s_Writer.Write(p_Reader.ReadBytes((int)(p_Reader.Length - p_Reader.Position)));
        }

        public static void LoadDDS2(RimeReader p_Reader, out TextureHeader p_Header, out Stream p_Data)
        {
            var s_StartPosition = p_Reader.Position;

            var s_DDSHeader = new DDSHeader( p_Reader );

            p_Header = new TextureHeader();

            // This is the default position where texture data starts
            long s_TextureDataStart = 4 + DDSHeader.c_DDSHeaderSize;

            //Init this
            p_Header.MipmapSizes = new uint[15];

            p_Header.Width = (short)s_DDSHeader.Width;
            p_Header.Height = (short)s_DDSHeader.Height;
            p_Header.Depth = (short)s_DDSHeader.Depth;

            //Check for mipmaps
            if (s_DDSHeader.Flags.HasFlag(DDSFlags.MipmapCount))
            {
                p_Header.MipmapCount = (byte)s_DDSHeader.MipMapCount;
                p_Header.SliceCount = (short)s_DDSHeader.MipMapCount;

                //Calculate mimap sizes and chain size
                var s_CurrentWidth = (uint) p_Header.Width;
                var s_CurrentHeight = (uint) p_Header.Height;

                uint s_ChainSize = 0;

                for (var i = 0; i < p_Header.MipmapCount; i++)
                {
                    // TODO: Fix line below
                    uint s_SlicePitch = 0;
                    throw new NotImplementedException();
                    //TextureUtils.ComputePitch(s_DDSHeader., s_CurrentWidth, s_CurrentHeight, out var _, out var s_SlicePitch, TextureUtils.CPFLAGS.NONE);

                    p_Header.MipmapSizes[i] = (uint)s_SlicePitch;

                    s_ChainSize += (uint)s_SlicePitch;

                    s_CurrentWidth /= 2;
                    s_CurrentHeight /= 2;

                }

                p_Header.MipmapChainSize = s_ChainSize;
            }

            //Some srgb check, not sure about this one
            if (s_DDSHeader.Flags.HasFlag(DDSFlags.Srgb))
                p_Header.Flags |= TextureFlags.SrgbGamma;


            //Make it work for some strange dds
            p_Reader.Seek(s_StartPosition + s_DDSHeader.Size, SeekOrigin.Begin);



            if (s_DDSHeader.PixelFormat.Flags.HasFlag(DDSFormatFlags.FourCC) &&
                s_DDSHeader.PixelFormat.FourCC == DDSPixelFormat.s_DXExtFormat.FourCC) //This is a dx texture
            {
                //This is aligned for some reason
                p_Reader.Align(0x10);

                var s_ExtendedHeader = new DDSDX10Header(p_Reader);

                if (s_ExtendedHeader.DxgiFormat == DXGIFormat.UNKNOWN)
                    throw new Exception("Invalid format for dx10 texture!");

                //TODO: rgb formats, typeless formats!!
                throw new Exception();
                var s_TextureFormat = TextureFormat.TextureFormat_Unknown; //DDSUtils.c_DDSDXFormatMap.Where( x => x.Value == s_ExtendedHeader.DxgiFormat ).Select( x => x.Key ).FirstOrDefault( );
                p_Header.Format = s_TextureFormat;


                //Read type from extendedheader
                if (s_ExtendedHeader.MiscFlag.HasFlag(DDSMiscFlag1.TextureCube))
                {
                    p_Header.Type = TextureType.TextureType_Cube;

                    if (s_ExtendedHeader.ArraySize != 6)
                        throw new Exception("This cube is not a full cube");
                }
                else
                {
                    switch (s_ExtendedHeader.ResourceDimension)
                    {
                    case DDSResoruceDimension.Texture1D:
                        p_Header.Type = TextureType.TextureType_1D;
                        break;
                    case DDSResoruceDimension.Texture2D:
                        p_Header.Type = TextureType.TextureType_2D;
                        break;
                    case DDSResoruceDimension.Texture3D:
                        p_Header.Type = TextureType.TextureType_3D;
                        break;
                    }
                }

            }
            else
            {
                var s_TextureFormat = TextureFormat.TextureFormat_Unknown;

                //Match texture format, clean this up maybe?
                foreach (var s_FormatPair in DDSUtils.c_DDSFormatMap)
                {
                    if (s_DDSHeader.PixelFormat.Flags == DDSFormatFlags.FourCC)
                    {
                        if (s_FormatPair.Value.Flags != DDSFormatFlags.FourCC)
                            continue;

                        if (s_FormatPair.Value.FourCC != s_DDSHeader.PixelFormat.FourCC)
                            continue;

                        /*
                         * If the DDS_PIXELFORMAT dwFlags is set to DDPF_FOURCC and dwFourCC is set to "DX10" an additional DDS_HEADER_DXT10 structure 
                         * will be present to accommodate texture arrays or DXGI formats that cannot be expressed as an RGB pixel format such as 
                         * floating point formats, sRGB formats etc. 
                         * 
                         * When the DDS_HEADER_DXT10 structure is present the entire data description will looks like this.
                         */
                        if (s_DDSHeader.PixelFormat.FourCC == 0x30315844)
                        {
                            s_TextureDataStart += DDSDX10Header.c_HeaderSize;
                        }
                    }
                    else
                    {
                        if (s_FormatPair.Value.Flags != s_DDSHeader.PixelFormat.Flags)
                            continue;

                        if (s_FormatPair.Value.RBitMask != s_DDSHeader.PixelFormat.RBitMask)
                            continue;
                        if (s_FormatPair.Value.GBitMask != s_DDSHeader.PixelFormat.GBitMask)
                            continue;
                        if (s_FormatPair.Value.BBitMask != s_DDSHeader.PixelFormat.BBitMask)
                            continue;
                        if (s_FormatPair.Value.ABitMask != s_DDSHeader.PixelFormat.ABitMask)
                            continue;
                    }



                    s_TextureFormat = s_FormatPair.Key;
                    Debug.WriteLine($"Found valid format {s_FormatPair.Key}");
                    break;
                }

                if (s_TextureFormat == TextureFormat.TextureFormat_Unknown)
                    throw new Exception("Unsupported dds!");



                if (s_DDSHeader.Caps2.HasFlag(DDSCaps2.Cubemap))
                    p_Header.Type = TextureType.TextureType_Cube;
                else if (s_DDSHeader.Flags.HasFlag(DDSFlags.Depth))
                    p_Header.Type = TextureType.TextureType_3D;
                else if (s_DDSHeader.Height > 1)
                    p_Header.Type = TextureType.TextureType_2D;
                else
                    p_Header.Type = TextureType.TextureType_1D; //if the height is 1, load as texture1d

            }


            //TODO: Probably calculate texture size based off bitcount, will just use the input stream size for now
            var s_SizeLeft = p_Reader.Length - s_TextureDataStart;

            p_Data = new LimitedRimeReader(p_Reader, s_SizeLeft);
        }
    }
}
