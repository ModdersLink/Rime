using System;

namespace RimeLib.Texture.DDS;

public static class DDSUtils
{
    /// <summary>
    /// Gets the Bits Per Pixel for the given format
    /// </summary>
    private static long BitsPerPixel(DXGIFormat p_Format)
    {
        switch (p_Format)
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

    [Flags]
    public enum CPFLAGS
    {
        NONE = 0x0, // Normal operation
        LEGACYDWORD = 0x1, // Assume pitch is DWORD aligned instead of BYTE aligned
        PARAGRAPH = 0x2, // Assume pitch is 16-byte aligned instead of BYTE aligned
        YMM = 0x4, // Assume pitch is 32-byte aligned instead of BYTE aligned
        ZMM = 0x8, // Assume pitch is 64-byte aligned instead of BYTE aligned
        PAGE4K = 0x200, // Assume pitch is 4096-byte aligned instead of BYTE aligned
        BADDXTNTAILS = 0x1000, // BC formats with malformed mipchain blocks smaller than 4x4
        BPP24 = 0x10000, // Override with a legacy 24 bits-per-pixel format size
        BPP16 = 0x20000, // Override with a legacy 16 bits-per-pixel format size
        BPP8 = 0x40000, // Override with a legacy 8 bits-per-pixel format size
    };

    /// <summary>
    /// Computes Row and Slice Pitch
    /// </summary>
    public static void ComputePitch(
        DXGIFormat p_Format,
        long p_Width,
        long p_Height,
        out long p_RowPitch,
        out long p_SlicePitch,
        CPFLAGS p_Flags
    )
    {
        switch (p_Format)
        {
            case DXGIFormat.BC1_TYPELESS:
            case DXGIFormat.BC1_UNORM:
            case DXGIFormat.BC1_UNORM_SRGB:
            case DXGIFormat.BC4_TYPELESS:
            case DXGIFormat.BC4_UNORM:
            case DXGIFormat.BC4_SNORM:
            {
                if (p_Flags.HasFlag(CPFLAGS.BADDXTNTAILS))
                {
                    var s_Nbw = p_Width >> 2;
                    var s_Nbh = p_Height >> 2;
                    p_RowPitch = System.Math.Clamp(1, s_Nbw * 8, long.MaxValue);
                    p_SlicePitch = System.Math.Clamp(1, p_RowPitch * s_Nbh, long.MaxValue);
                }
                else
                {
                    var s_Nbw = System.Math.Clamp(1, (p_Width + 3) / 4, long.MaxValue);
                    var s_Nbh = System.Math.Clamp(1, (p_Height + 3) / 4, long.MaxValue);
                    p_RowPitch = s_Nbw * 8;
                    p_SlicePitch = p_RowPitch * s_Nbh;
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
                if (p_Flags.HasFlag(CPFLAGS.BADDXTNTAILS))
                {
                    var s_Nbw = p_Width >> 2;
                    var s_Nbh = p_Height >> 2;
                    p_RowPitch = System.Math.Clamp(1, s_Nbw * 16, long.MaxValue);
                    p_SlicePitch = System.Math.Clamp(1, p_RowPitch * s_Nbh, long.MaxValue);
                }
                else
                {
                    var s_Nbw = System.Math.Clamp(1, (p_Width + 3) / 4, long.MaxValue);
                    var s_Nbh = System.Math.Clamp(1, (p_Height + 3) / 4, long.MaxValue);
                    p_RowPitch = s_Nbw * 16;
                    p_SlicePitch = p_RowPitch * s_Nbh;
                }
            }
                break;
            case DXGIFormat.R8G8_B8G8_UNORM:
            case DXGIFormat.G8R8_G8B8_UNORM:
            case DXGIFormat.YUY2:
                p_RowPitch = ((p_Width + 1) >> 1) * 4;
                p_SlicePitch = p_RowPitch * p_Height;
                break;
            case DXGIFormat.Y210:
            case DXGIFormat.Y216:
                p_RowPitch = ((p_Width + 1) >> 1) * 8;
                p_SlicePitch = p_RowPitch * p_Height;
                break;

            case DXGIFormat.NV12:
            case DXGIFormat.OPAQUE_420:
                p_RowPitch = ((p_Width + 1) >> 1) * 2;
                p_SlicePitch = p_RowPitch * (p_Height + ((p_Height + 1) >> 1));
                break;

            case DXGIFormat.P010:
            case DXGIFormat.P016:
                p_RowPitch = ((p_Width + 1) >> 1) * 4;
                p_SlicePitch = p_RowPitch * (p_Height + ((p_Height + 1) >> 1));
                break;
            case DXGIFormat.NV11:
                p_RowPitch = ((p_Width + 3) >> 2) * 4;
                p_SlicePitch = p_RowPitch * p_Height * 2;
                break;
            default:
            {

                long s_Bpp;

                if (p_Flags.HasFlag(CPFLAGS.BPP24))
                    s_Bpp = 24;
                else if (p_Flags.HasFlag(CPFLAGS.BPP16))
                    s_Bpp = 16;
                else if (p_Flags.HasFlag(CPFLAGS.BPP8))
                    s_Bpp = 8;
                else
                    s_Bpp = BitsPerPixel(p_Format);

                if (p_Flags.HasFlag(CPFLAGS.LEGACYDWORD | CPFLAGS.PARAGRAPH | CPFLAGS.YMM | CPFLAGS.ZMM | CPFLAGS.PAGE4K))
                {
                    if (p_Flags.HasFlag(CPFLAGS.PAGE4K))
                    {
                        p_RowPitch = ((p_Width * s_Bpp + 32767) / 32768) * 4096;
                        p_SlicePitch = p_RowPitch * p_Height;
                    }
                    else if (p_Flags.HasFlag(CPFLAGS.ZMM))
                    {
                        p_RowPitch = ((p_Width * s_Bpp + 511) / 512) * 64;
                        p_SlicePitch = p_RowPitch * p_Height;
                    }
                    else if (p_Flags.HasFlag(CPFLAGS.YMM))
                    {
                        p_RowPitch = ((p_Width * s_Bpp + 255) / 256) * 32;
                        p_SlicePitch = p_RowPitch * p_Height;
                    }
                    else if (p_Flags.HasFlag(CPFLAGS.PARAGRAPH))
                    {
                        p_RowPitch = ((p_Width * s_Bpp + 127) / 128) * 16;
                        p_SlicePitch = p_RowPitch * p_Height;
                    }
                    else // DWORD alignment
                    {
                        // Special computation for some incorrectly created DDS files based on
                        // legacy DirectDraw assumptions about pitch alignment
                        p_RowPitch = ((p_Width * s_Bpp + 31) / 32) * 4;
                        p_SlicePitch = p_RowPitch * p_Height;
                    }
                }
                else
                {
                    // Default byte alignment
                    p_RowPitch = (p_Width * s_Bpp + 7) / 8;
                    p_SlicePitch = p_RowPitch * p_Height;
                }
            }
                break;
        }
    }

    /// <summary>
    /// Gets the integer representation of the foucc string.
    /// 
    /// Credits: Grimdoomer
    /// </summary>
    /// <param name="p_FourCC"></param>
    /// <returns></returns>
    public static uint MakeFourCC(string p_FourCC)
    {
        if (p_FourCC.Length != 4)
            throw new Exception("invalid 4cc");

        return ((uint)p_FourCC[0] & 0xFF) | (((uint)p_FourCC[1] & 0xFF) << 8) |
               (((uint)p_FourCC[2] & 0xFF) << 16) | ((uint)p_FourCC[3] & 0xFF) << 24;
    }

    public static bool IsDXT1(DDSHeader p_Header)
    {
        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT1"))
            return true;

        if (p_Header.PixelFormat.FourCC != DDSUtils.MakeFourCC("DX10"))
            return false;
        
        return p_Header.Dx10Header!.DxgiFormat is DXGIFormat.BC1_UNORM or DXGIFormat.BC1_UNORM_SRGB;
    }

    public static bool IsDXT3(DDSHeader p_Header)
    {
        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT3"))
            return true;

        if (p_Header.PixelFormat.FourCC != DDSUtils.MakeFourCC("DX10"))
            return false;
        
        return p_Header.Dx10Header!.DxgiFormat is DXGIFormat.BC2_UNORM_SRGB or DXGIFormat.BC2_UNORM;
    }

    public static bool IsDXT5(DDSHeader p_Header)
    {
        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT5"))
            return true;

        if (p_Header.PixelFormat.FourCC != DDSUtils.MakeFourCC("DX10"))
            return false;
        
        return p_Header.Dx10Header!.DxgiFormat is DXGIFormat.BC3_UNORM_SRGB or DXGIFormat.BC3_UNORM;
    }

    public static bool IsDXT5A(DDSHeader p_Header)
    {
        if (p_Header.PixelFormat.FourCC != DDSUtils.MakeFourCC("DX10"))
            return false;
        
        return p_Header.Dx10Header!.DxgiFormat is DXGIFormat.BC4_UNORM;
    }

    public static bool IsDXN(DDSHeader p_Header)
    {
        if (p_Header.PixelFormat.FourCC != DDSUtils.MakeFourCC("DX10"))
            return false;
        
        return p_Header.Dx10Header!.DxgiFormat is DXGIFormat.BC5_UNORM;
    }

    public static bool IsCompressed(DDSHeader p_Header)
    {
        return IsDXT1(p_Header)
               || IsDXT3(p_Header)
               || IsDXT5(p_Header)
               || IsDXT5A(p_Header)
               || IsDXN(p_Header);
    }

    public static uint CalculateDXTSizeFromHeader(DDSHeader p_Header, uint p_MipMap = 0)
    {
        var s_Width = p_Header.Width;
        var s_Height = p_Header.Height;
        
        var s_BlockSize = IsDXT1(p_Header)
            ? 8
            : 16;

        var s_MipMapSize = ((s_Width + 3) / 4) * ((s_Height + 3) / 4) * s_BlockSize;
        
        for (var i = 0; i < p_MipMap; ++i)
        {
            // TODO: Verify this is correct
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
        var s_Compressed = IsCompressed(p_Header);

        for (uint i = 0; i < p_Header.MipMapCount; ++i)
        {
            if (s_Compressed)
                s_Chain[i] = CalculateDXTSizeFromHeader(p_Header, i);
            else
                s_Chain[i] = CalcualteRGBSizeFromHeader(p_Header.Width, p_Header.Height, 4, i);
        }

        return s_Chain;
    }
}