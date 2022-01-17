using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite;
using RimeLib.Texture.Frostbite.DDS;
using RimeLib.Texture.Frostbite2_0.Engine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace RimeLib.Texture.Frostbite2_0
{
    public static class FB2DDSImporter
    {
        public static void LoadDDS(RimeReader p_Reader, out TextureHeader p_Header, out Stream p_Data)
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
                    TextureUtils.ComputePitch(p_Header.Format, s_CurrentWidth, s_CurrentHeight, out var _, out var s_SlicePitch);

                    p_Header.MipmapSizes[i] = s_SlicePitch;

                    s_ChainSize += s_SlicePitch;

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
                var s_TextureFormat = DDSUtils.c_DDSDXFormatMap.Where( x => x.Value == s_ExtendedHeader.DxgiFormat ).Select( x => x.Key ).FirstOrDefault( );
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
