using RimeLib.Texture.DDS;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture.Frostbite
{
    public static class TextureUtils
    {
        public static readonly Dictionary<TextureFormat, DDSFormatFlags> s_FormatFlags = new Dictionary<TextureFormat, DDSFormatFlags>()
        {
            { TextureFormat.TextureFormat_Dxt1,          DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_Dxt1A,         DDSFormatFlags.FourCC },

            { TextureFormat.TextureFormat_NormalDxt1,    DDSFormatFlags.FourCC },

            { TextureFormat.TextureFormat_Dxt3,          DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_Dxt5,          DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_Dxt5A,         DDSFormatFlags.FourCC },


            { TextureFormat.TextureFormat_NormalDxt5,    DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_NormalDxt5Rga, DDSFormatFlags.FourCC },

            { TextureFormat.TextureFormat_Dxn,           DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_NormalDxn,     DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_Bc7,           DDSFormatFlags.FourCC },

            { TextureFormat.TextureFormat_Rgb565,        DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb }, //Check
            { TextureFormat.TextureFormat_Rgb888,        DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb },
            { TextureFormat.TextureFormat_Argb1555,      DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha }, //1 + 5 + 5 + 5 + 5
            { TextureFormat.TextureFormat_Argb4444,      DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha },  //this is really 16, but calcualted as 8???
                                                         
            { TextureFormat.TextureFormat_Argb8888,      DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha }, //this is really 32, but calcualted as 16???
                                                         
            { TextureFormat.TextureFormat_L8,            DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_L16,           DDSFormatFlags.FourCC }, //check?
                                                         
            { TextureFormat.TextureFormat_Abgr16,        DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha },
            { TextureFormat.TextureFormat_Abgr16F,       DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha },

            { TextureFormat.TextureFormat_Abgr32F,       DDSFormatFlags.AlphaPixels | DDSFormatFlags.Rgb | DDSFormatFlags.Alpha },
            { TextureFormat.TextureFormat_R16F,          DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_R32F,          DDSFormatFlags.FourCC }, //this has 32 bitcount, but is calculated as 4 
            { TextureFormat.TextureFormat_Rg8,           DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_Gr16,          DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_Gr16F,         DDSFormatFlags.FourCC }, // not sure
            { TextureFormat.TextureFormat_D16,           DDSFormatFlags.FourCC }, // not sure
            { TextureFormat.TextureFormat_D24S8,         DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_D24Fs8,        DDSFormatFlags.FourCC }, // not sure


            { TextureFormat.TextureFormat_D32F,          DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_D32Fs8,        DDSFormatFlags.FourCC },

            { TextureFormat.TextureFormat_S8,            DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_Abgr32,        DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_Gr32F,         DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_A2R10G10B10,   DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_R11G11B10F,    DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_Abgr16_Snorm,  DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_Abgr16_Uint,   DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_L16_Uint,      DDSFormatFlags.FourCC }, // not sure
            { TextureFormat.TextureFormat_L32,           DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_GR16_Uint,     DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_GR32_Uint,     DDSFormatFlags.FourCC },
            { TextureFormat.TextureFormat_R9G9B9E5F,     DDSFormatFlags.FourCC },
        };

        public static readonly Dictionary<TextureFormat, uint> s_FormatBits = new Dictionary<TextureFormat, uint>()
        {
            { TextureFormat.TextureFormat_Dxt1,          4 }, 
            { TextureFormat.TextureFormat_Dxt1A,         4 }, 
                                                         
            { TextureFormat.TextureFormat_NormalDxt1,    4 }, 
                                                         
            { TextureFormat.TextureFormat_Dxt3,          8 }, 
            { TextureFormat.TextureFormat_Dxt5,          4 }, 
            { TextureFormat.TextureFormat_Dxt5A,         4 }, 
                                                         
                                                         
            { TextureFormat.TextureFormat_NormalDxt5,    8 }, 
            { TextureFormat.TextureFormat_NormalDxt5Rga, 8 }, 
                                                         
            { TextureFormat.TextureFormat_Dxn,           8 },
            { TextureFormat.TextureFormat_NormalDxn,     8 },
            { TextureFormat.TextureFormat_Bc7,           8 },
                                                         
            { TextureFormat.TextureFormat_Rgb565,        16 }, //Check
            { TextureFormat.TextureFormat_Rgb888,        24 },
            { TextureFormat.TextureFormat_Argb1555,      32 }, //1 + 5 + 5 + 5 + 5
            { TextureFormat.TextureFormat_Argb4444,      16 },  //this is really 16, but calcualted as 8???
                                                         
            { TextureFormat.TextureFormat_Argb8888,      32 }, //this is really 32, but calcualted as 16???
                                                         
            { TextureFormat.TextureFormat_L8,            8 },
            { TextureFormat.TextureFormat_L16,           16 }, //check?
                                                         
            { TextureFormat.TextureFormat_Abgr16,        64 },
            { TextureFormat.TextureFormat_Abgr16F,       64 },
                                                         
            { TextureFormat.TextureFormat_Abgr32F,       128 },
            { TextureFormat.TextureFormat_R16F,          16 }, 
            { TextureFormat.TextureFormat_R32F,          32 }, //this has 32 bitcount, but is calculated as 4 
            { TextureFormat.TextureFormat_Rg8,           16 },
            { TextureFormat.TextureFormat_Gr16,          32 },
            { TextureFormat.TextureFormat_Gr16F,         32 }, // not sure
            { TextureFormat.TextureFormat_D16,           16 }, // not sure
            { TextureFormat.TextureFormat_D24S8,         32 },
            { TextureFormat.TextureFormat_D24Fs8,        24 + 8 }, // not sure


            { TextureFormat.TextureFormat_D32F,          32 },
            { TextureFormat.TextureFormat_D32Fs8,        32 + 8 },
            
            { TextureFormat.TextureFormat_S8,            8 },
            { TextureFormat.TextureFormat_Abgr32,        32 * 4 },
            { TextureFormat.TextureFormat_Gr32F,         32 * 2 },
            { TextureFormat.TextureFormat_A2R10G10B10,   32 },
            { TextureFormat.TextureFormat_R11G11B10F,    32 },
            { TextureFormat.TextureFormat_Abgr16_Snorm,  64 },
            { TextureFormat.TextureFormat_Abgr16_Uint,   64 },
            { TextureFormat.TextureFormat_L16_Uint,      16 }, // not sure
            { TextureFormat.TextureFormat_L32,           32 },
            { TextureFormat.TextureFormat_GR16_Uint,     32 },
            { TextureFormat.TextureFormat_GR32_Uint,     64 },
            { TextureFormat.TextureFormat_R9G9B9E5F,     32 },
        };

        public static uint BitsPerPixel(TextureFormat p_Format)
        {
            if (!s_FormatBits.TryGetValue(p_Format, out var s_OutBits))
                return 0;

            return s_OutBits;
        }

        public static bool IsCompressed(TextureFormat p_Format) =>
            p_Format switch
            {
                TextureFormat.TextureFormat_Dxt1 => true,
                TextureFormat.TextureFormat_NormalDxt1 => true,
                TextureFormat.TextureFormat_Dxt1A => true,
                TextureFormat.TextureFormat_Dxt3 => true,
                TextureFormat.TextureFormat_Dxn => true,
                TextureFormat.TextureFormat_NormalDxn => true,
                TextureFormat.TextureFormat_Dxt5 => true,
                TextureFormat.TextureFormat_NormalDxt5 => true,
                TextureFormat.TextureFormat_NormalDxt5Rga => true,
                TextureFormat.TextureFormat_Dxt5A => true,
                TextureFormat.TextureFormat_Bc7 => true,

                _ => false
            };



        public static bool IsPalettized(TextureFormat p_Format) =>
            p_Format switch
            {
                _ => false,
            };

        public static bool IsPacked(TextureFormat p_Format) =>
            p_Format switch
            {
                _ => false,
            };

        public static bool IsPlanar(TextureFormat p_Format) =>
            p_Format switch
            {
                _ => false,
            };
        /// <summary>
        /// Gets the Bits Per Pixel for the given format
        /// </summary>
        private static long BitsPerPixel(DXGIFormat format)
        {
            switch (format)
            {
                case DXGIFormat.R32G32B32A32_TYPELESS:
                case DXGIFormat.R32G32B32A32_FLOAT:
                case DXGIFormat.R32G32B32A32_UINT:
                case DXGIFormat.R32G32B32A32_SINT:
                    return 128;
                case DXGIFormat.R32G32B32_TYPELESS:
                case DXGIFormat.R32G32B32_FLOAT:
                case DXGIFormat.R32G32B32_UINT:
                case DXGIFormat.R32G32B32_SINT:
                    return 96;
                case DXGIFormat.R16G16B16A16_TYPELESS:
                case DXGIFormat.R16G16B16A16_FLOAT:
                case DXGIFormat.R16G16B16A16_UNORM:
                case DXGIFormat.R16G16B16A16_UINT:
                case DXGIFormat.R16G16B16A16_SNORM:
                case DXGIFormat.R16G16B16A16_SINT:
                case DXGIFormat.R32G32_TYPELESS:
                case DXGIFormat.R32G32_FLOAT:
                case DXGIFormat.R32G32_UINT:
                case DXGIFormat.R32G32_SINT:
                case DXGIFormat.R32G8X24_TYPELESS:
                case DXGIFormat.D32_FLOAT_S8X24_UINT:
                case DXGIFormat.R32_FLOAT_X8X24_TYPELESS:
                case DXGIFormat.X32_TYPELESS_G8X24_UINT:
                case DXGIFormat.Y416:
                case DXGIFormat.Y210:
                case DXGIFormat.Y216:
                    return 64;
                case DXGIFormat.R10G10B10A2_TYPELESS:
                case DXGIFormat.R10G10B10A2_UNORM:
                case DXGIFormat.R10G10B10A2_UINT:
                case DXGIFormat.R11G11B10_FLOAT:
                case DXGIFormat.R8G8B8A8_TYPELESS:
                case DXGIFormat.R8G8B8A8_UNORM:
                case DXGIFormat.R8G8B8A8_UNORM_SRGB:
                case DXGIFormat.R8G8B8A8_UINT:
                case DXGIFormat.R8G8B8A8_SNORM:
                case DXGIFormat.R8G8B8A8_SINT:
                case DXGIFormat.R16G16_TYPELESS:
                case DXGIFormat.R16G16_FLOAT:
                case DXGIFormat.R16G16_UNORM:
                case DXGIFormat.R16G16_UINT:
                case DXGIFormat.R16G16_SNORM:
                case DXGIFormat.R16G16_SINT:
                case DXGIFormat.R32_TYPELESS:
                case DXGIFormat.D32_FLOAT:
                case DXGIFormat.R32_FLOAT:
                case DXGIFormat.R32_UINT:
                case DXGIFormat.R32_SINT:
                case DXGIFormat.R24G8_TYPELESS:
                case DXGIFormat.D24_UNORM_S8_UINT:
                case DXGIFormat.R24_UNORM_X8_TYPELESS:
                case DXGIFormat.X24_TYPELESS_G8_UINT:
                case DXGIFormat.R9G9B9E5_SHAREDEXP:
                case DXGIFormat.R8G8_B8G8_UNORM:
                case DXGIFormat.G8R8_G8B8_UNORM:
                case DXGIFormat.B8G8R8A8_UNORM:
                case DXGIFormat.B8G8R8X8_UNORM:
                case DXGIFormat.R10G10B10_XR_BIAS_A2_UNORM:
                case DXGIFormat.B8G8R8A8_TYPELESS:
                case DXGIFormat.B8G8R8A8_UNORM_SRGB:
                case DXGIFormat.B8G8R8X8_TYPELESS:
                case DXGIFormat.B8G8R8X8_UNORM_SRGB:
                case DXGIFormat.AYUV:
                case DXGIFormat.Y410:
                case DXGIFormat.YUY2:
                    return 32;
                case DXGIFormat.P010:
                case DXGIFormat.P016:
                    return 24;
                case DXGIFormat.R8G8_TYPELESS:
                case DXGIFormat.R8G8_UNORM:
                case DXGIFormat.R8G8_UINT:
                case DXGIFormat.R8G8_SNORM:
                case DXGIFormat.R8G8_SINT:
                case DXGIFormat.R16_TYPELESS:
                case DXGIFormat.R16_FLOAT:
                case DXGIFormat.D16_UNORM:
                case DXGIFormat.R16_UNORM:
                case DXGIFormat.R16_UINT:
                case DXGIFormat.R16_SNORM:
                case DXGIFormat.R16_SINT:
                case DXGIFormat.B5G6R5_UNORM:
                case DXGIFormat.B5G5R5A1_UNORM:
                case DXGIFormat.A8P8:
                case DXGIFormat.B4G4R4A4_UNORM:
                    return 16;
                case DXGIFormat.NV12:
                case DXGIFormat.OPAQUE_420:
                case DXGIFormat.NV11:
                    return 12;
                case DXGIFormat.R8_TYPELESS:
                case DXGIFormat.R8_UNORM:
                case DXGIFormat.R8_UINT:
                case DXGIFormat.R8_SNORM:
                case DXGIFormat.R8_SINT:
                case DXGIFormat.A8_UNORM:
                case DXGIFormat.AI44:
                case DXGIFormat.IA44:
                case DXGIFormat.P8:
                    return 8;
                case DXGIFormat.R1_UNORM:
                    return 1;
                case DXGIFormat.BC1_TYPELESS:
                case DXGIFormat.BC1_UNORM:
                case DXGIFormat.BC1_UNORM_SRGB:
                case DXGIFormat.BC4_TYPELESS:
                case DXGIFormat.BC4_UNORM:
                case DXGIFormat.BC4_SNORM:
                    return 4;
                case DXGIFormat.BC2_TYPELESS:
                case DXGIFormat.BC2_UNORM:
                case DXGIFormat.BC2_UNORM_SRGB:
                case DXGIFormat.BC3_TYPELESS:
                case DXGIFormat.BC3_UNORM:
                case DXGIFormat.BC3_UNORM_SRGB:
                case DXGIFormat.BC5_TYPELESS:
                case DXGIFormat.BC5_UNORM:
                case DXGIFormat.BC5_SNORM:
                case DXGIFormat.BC6H_TYPELESS:
                case DXGIFormat.BC6H_UF16:
                case DXGIFormat.BC6H_SF16:
                case DXGIFormat.BC7_TYPELESS:
                case DXGIFormat.BC7_UNORM:
                case DXGIFormat.BC7_UNORM_SRGB:
                    return 8;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// CP Flags
        /// </summary>
        public enum CPFLAGS
        {
            NONE = 0x0,      // Normal operation
            LEGACYDWORD = 0x1,      // Assume pitch is DWORD aligned instead of BYTE aligned
            PARAGRAPH = 0x2,      // Assume pitch is 16-byte aligned instead of BYTE aligned
            YMM = 0x4,      // Assume pitch is 32-byte aligned instead of BYTE aligned
            ZMM = 0x8,      // Assume pitch is 64-byte aligned instead of BYTE aligned
            PAGE4K = 0x200,    // Assume pitch is 4096-byte aligned instead of BYTE aligned
            BADDXTNTAILS = 0x1000,   // BC formats with malformed mipchain blocks smaller than 4x4
            BPP24 = 0x10000,  // Override with a legacy 24 bits-per-pixel format size
            BPP16 = 0x20000,  // Override with a legacy 16 bits-per-pixel format size
            BPP8 = 0x40000,  // Override with a legacy 8 bits-per-pixel format size
        };

        /// <summary>
        /// Computes Row and Slice Pitch
        /// </summary>
        public static void ComputePitch(DXGIFormat format, long width, long height, out long rowPitch, out long slicePitch, CPFLAGS flags)
        {
            switch (format)
            {
                case DXGIFormat.BC1_TYPELESS:
                case DXGIFormat.BC1_UNORM:
                case DXGIFormat.BC1_UNORM_SRGB:
                case DXGIFormat.BC4_TYPELESS:
                case DXGIFormat.BC4_UNORM:
                case DXGIFormat.BC4_SNORM:
                    {
                        if (flags.HasFlag(CPFLAGS.BADDXTNTAILS))
                        {
                            long nbw = width >> 2;
                            long nbh = height >> 2;
                            rowPitch = System.Math.Clamp(1, nbw * 8, Int64.MaxValue);
                            slicePitch = System.Math.Clamp(1, rowPitch * nbh, Int64.MaxValue);
                        }
                        else
                        {
                            long nbw = System.Math.Clamp(1, (width + 3) / 4, Int64.MaxValue);
                            long nbh = System.Math.Clamp(1, (height + 3) / 4, Int64.MaxValue);
                            rowPitch = nbw * 8;
                            slicePitch = rowPitch * nbh;
                        }
                    }
                    break;
                case DXGIFormat.BC2_TYPELESS:
                case DXGIFormat.BC2_UNORM:
                case DXGIFormat.BC2_UNORM_SRGB:
                case DXGIFormat.BC3_TYPELESS:
                case DXGIFormat.BC3_UNORM:
                case DXGIFormat.BC3_UNORM_SRGB:
                case DXGIFormat.BC5_TYPELESS:
                case DXGIFormat.BC5_UNORM:
                case DXGIFormat.BC5_SNORM:
                case DXGIFormat.BC6H_TYPELESS:
                case DXGIFormat.BC6H_UF16:
                case DXGIFormat.BC6H_SF16:
                case DXGIFormat.BC7_TYPELESS:
                case DXGIFormat.BC7_UNORM:
                case DXGIFormat.BC7_UNORM_SRGB:
                    {
                        if (flags.HasFlag(CPFLAGS.BADDXTNTAILS))
                        {
                            long nbw = width >> 2;
                            long nbh = height >> 2;
                            rowPitch = System.Math.Clamp(1, nbw * 16, Int64.MaxValue);
                            slicePitch = System.Math.Clamp(1, rowPitch * nbh, Int64.MaxValue);
                        }
                        else
                        {
                            long nbw = System.Math.Clamp(1, (width + 3) / 4, Int64.MaxValue);
                            long nbh = System.Math.Clamp(1, (height + 3) / 4, Int64.MaxValue);
                            rowPitch = nbw * 16;
                            slicePitch = rowPitch * nbh;
                        }
                    }
                    break;
                case DXGIFormat.R8G8_B8G8_UNORM:
                case DXGIFormat.G8R8_G8B8_UNORM:
                case DXGIFormat.YUY2:
                    rowPitch = ((width + 1) >> 1) * 4;
                    slicePitch = rowPitch * height;
                    break;
                case DXGIFormat.Y210:
                case DXGIFormat.Y216:
                    rowPitch = ((width + 1) >> 1) * 8;
                    slicePitch = rowPitch * height;
                    break;

                case DXGIFormat.NV12:
                case DXGIFormat.OPAQUE_420:
                    rowPitch = ((width + 1) >> 1) * 2;
                    slicePitch = rowPitch * (height + ((height + 1) >> 1));
                    break;

                case DXGIFormat.P010:
                case DXGIFormat.P016:
                    rowPitch = ((width + 1) >> 1) * 4;
                    slicePitch = rowPitch * (height + ((height + 1) >> 1));
                    break;
                case DXGIFormat.NV11:
                    rowPitch = ((width + 3) >> 2) * 4;
                    slicePitch = rowPitch * height * 2;
                    break;
                default:
                    {

                        long bpp;

                        if (flags.HasFlag(CPFLAGS.BPP24))
                            bpp = 24;
                        else if (flags.HasFlag(CPFLAGS.BPP16))
                            bpp = 16;
                        else if (flags.HasFlag(CPFLAGS.BPP8))
                            bpp = 8;
                        else
                            bpp = BitsPerPixel(format);

                        if (flags.HasFlag(CPFLAGS.LEGACYDWORD | CPFLAGS.PARAGRAPH | CPFLAGS.YMM | CPFLAGS.ZMM | CPFLAGS.PAGE4K))
                        {
                            if (flags.HasFlag(CPFLAGS.PAGE4K))
                            {
                                rowPitch = ((width * bpp + 32767) / 32768) * 4096;
                                slicePitch = rowPitch * height;
                            }
                            else if (flags.HasFlag(CPFLAGS.ZMM))
                            {
                                rowPitch = ((width * bpp + 511) / 512) * 64;
                                slicePitch = rowPitch * height;
                            }
                            else if (flags.HasFlag(CPFLAGS.YMM))
                            {
                                rowPitch = ((width * bpp + 255) / 256) * 32;
                                slicePitch = rowPitch * height;
                            }
                            else if (flags.HasFlag(CPFLAGS.PARAGRAPH))
                            {
                                rowPitch = ((width * bpp + 127) / 128) * 16;
                                slicePitch = rowPitch * height;
                            }
                            else // DWORD alignment
                            {
                                // Special computation for some incorrectly created DDS files based on
                                // legacy DirectDraw assumptions about pitch alignment
                                rowPitch = ((width * bpp + 31) / 32) * 4;
                                slicePitch = rowPitch * height;
                            }
                        }
                        else
                        {
                            // Default byte alignment
                            rowPitch = (width * bpp + 7) / 8;
                            slicePitch = rowPitch * height;
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// TODO: Determine if this is correct
        /// </summary>
        /// <param name="p_Format"></param>
        /// <param name="p_Width"></param>
        /// <param name="p_Height"></param>
        /// <param name="p_RowPitch"></param>
        /// <param name="p_SlicePitch"></param>
        /// <returns></returns>
        //public static bool ComputePitch(TextureFormat p_Format, uint p_Width, uint p_Height, out uint p_RowPitch, out uint p_SlicePitch)
        //{
        //    uint s_Pitch = 0;
        //    uint s_Slice = 0;

        //    var s_BitsPerPixel = BitsPerPixel(p_Format);

        //    switch (p_Format)
        //    {
        //    case TextureFormat.TextureFormat_Dxt1:
            
        //    case TextureFormat.TextureFormat_Dxt5A:
        //    {
        //        //aligns to nearest 4 bits
        //        var s_Nbw = System.Math.Max(1, (p_Width + 3) / 4);
        //        var s_Nbh = System.Math.Max(1, (p_Height + 3) / 4);

        //        s_Pitch = s_Nbw * 8; //uint8?
        //        s_Slice = s_Pitch * s_Nbh;
        //        break;
        //    }

        //    //This fixes stuff
        //    case TextureFormat.TextureFormat_NormalDxt1:
        //    case TextureFormat.TextureFormat_Dxt1A:


        //    case TextureFormat.TextureFormat_Dxt3:
        //    case TextureFormat.TextureFormat_Dxt5:
        //    case TextureFormat.TextureFormat_NormalDxt5:
        //    case TextureFormat.TextureFormat_NormalDxt5Rga:
        //    case TextureFormat.TextureFormat_Dxn:
        //    case TextureFormat.TextureFormat_NormalDxn:
        //    case TextureFormat.TextureFormat_Bc7:
        //    {

        //        //aligns to nearest 4 bits
        //        var s_Nbw = System.Math.Max(1, (p_Width + 3) / 4);
        //        var s_Nbh = System.Math.Max(1, (p_Height + 3) / 4);

        //        s_Pitch = s_Nbw * 16; //uint16?
        //        s_Slice = s_Pitch * s_Nbh;
        //        break;
        //    }


        //    case TextureFormat.TextureFormat_R32F:
        //    {
        //        s_Pitch = (p_Width * s_BitsPerPixel + 7u) / (8u * 8u);
        //        s_Slice = s_Pitch * p_Height;
        //        break;
        //    }


        //    default:
        //    {

                

        //        //aligns to nearest 8 bits
        //        s_Pitch = (p_Width * s_BitsPerPixel + 7u) / 8u;
        //        s_Slice = s_Pitch * p_Height;
        //        break;
        //    }
        //    }

        //    p_RowPitch = s_Pitch;
        //    p_SlicePitch = s_Slice;

        //    return s_Pitch != 0;
        //}



    }
}
