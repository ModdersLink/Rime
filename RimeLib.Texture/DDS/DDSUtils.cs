using System;
using SharpDX.DXGI;

namespace RimeLib.Texture.DDS;

public static class DDSUtils
{
    /// <summary>
    /// Gets the Bits Per Pixel for the given format
    /// </summary>
    private static long BitsPerPixel(Format p_Format)
    {
        switch (p_Format)
        {
            case Format.R32G32B32A32_Typeless:
            case Format.R32G32B32A32_Float:
            case Format.R32G32B32A32_UInt:
            case Format.R32G32B32A32_SInt:
                return 128;

            case Format.R32G32B32_Typeless:
            case Format.R32G32B32_Float:
            case Format.R32G32B32_UInt:
            case Format.R32G32B32_SInt:
                return 96;

            case Format.R16G16B16A16_Typeless:
            case Format.R16G16B16A16_Float:
            case Format.R16G16B16A16_UNorm:
            case Format.R16G16B16A16_UInt:
            case Format.R16G16B16A16_SNorm:
            case Format.R16G16B16A16_SInt:
            case Format.R32G32_Typeless:
            case Format.R32G32_Float:
            case Format.R32G32_UInt:
            case Format.R32G32_SInt:
            case Format.R32G8X24_Typeless:
            case Format.D32_Float_S8X24_UInt:
            case Format.R32_Float_X8X24_Typeless:
            case Format.X32_Typeless_G8X24_UInt:
            case Format.Y416:
            case Format.Y210:
            case Format.Y216:
                return 64;

            case Format.R10G10B10A2_Typeless:
            case Format.R10G10B10A2_UNorm:
            case Format.R10G10B10A2_UInt:
            case Format.R11G11B10_Float:
            case Format.R8G8B8A8_Typeless:
            case Format.R8G8B8A8_UNorm:
            case Format.R8G8B8A8_UNorm_SRgb:
            case Format.R8G8B8A8_UInt:
            case Format.R8G8B8A8_SNorm:
            case Format.R8G8B8A8_SInt:
            case Format.R16G16_Typeless:
            case Format.R16G16_Float:
            case Format.R16G16_UNorm:
            case Format.R16G16_UInt:
            case Format.R16G16_SNorm:
            case Format.R16G16_SInt:
            case Format.R32_Typeless:
            case Format.D32_Float:
            case Format.R32_Float:
            case Format.R32_UInt:
            case Format.R32_SInt:
            case Format.R24G8_Typeless:
            case Format.D24_UNorm_S8_UInt:
            case Format.R24_UNorm_X8_Typeless:
            case Format.X24_Typeless_G8_UInt:
            case Format.R9G9B9E5_Sharedexp:
            case Format.R8G8_B8G8_UNorm:
            case Format.G8R8_G8B8_UNorm:
            case Format.B8G8R8A8_UNorm:
            case Format.B8G8R8X8_UNorm:
            case Format.R10G10B10_Xr_Bias_A2_UNorm:
            case Format.B8G8R8A8_Typeless:
            case Format.B8G8R8A8_UNorm_SRgb:
            case Format.B8G8R8X8_Typeless:
            case Format.B8G8R8X8_UNorm_SRgb:
            case Format.AYUV:
            case Format.Y410:
            case Format.YUY2:
                return 32;

            case Format.P010:
            case Format.P016:
                return 24;

            case Format.R8G8_Typeless:
            case Format.R8G8_UNorm:
            case Format.R8G8_UInt:
            case Format.R8G8_SNorm:
            case Format.R8G8_SInt:
            case Format.R16_Typeless:
            case Format.R16_Float:
            case Format.D16_UNorm:
            case Format.R16_UNorm:
            case Format.R16_UInt:
            case Format.R16_SNorm:
            case Format.R16_SInt:
            case Format.B5G6R5_UNorm:
            case Format.B5G5R5A1_UNorm:
            case Format.A8P8:
            case Format.B4G4R4A4_UNorm:
                return 16;

            case Format.NV12:
            //case Format.420_OPAQUE:
            case Format.Opaque420:
            case Format.NV11:
                return 12;

            case Format.R8_Typeless:
            case Format.R8_UNorm:
            case Format.R8_UInt:
            case Format.R8_SNorm:
            case Format.R8_SInt:
            case Format.A8_UNorm:
            case Format.AI44:
            case Format.IA44:
            case Format.P8:
                return 8;

            case Format.R1_UNorm:
                return 1;

            case Format.BC1_Typeless:
            case Format.BC1_UNorm:
            case Format.BC1_UNorm_SRgb:
            case Format.BC4_Typeless:
            case Format.BC4_UNorm:
            case Format.BC4_SNorm:
                return 4;

            case Format.BC2_Typeless:
            case Format.BC2_UNorm:
            case Format.BC2_UNorm_SRgb:
            case Format.BC3_Typeless:
            case Format.BC3_UNorm:
            case Format.BC3_UNorm_SRgb:
            case Format.BC5_Typeless:
            case Format.BC5_UNorm:
            case Format.BC5_SNorm:
            case Format.BC6H_Typeless:
            case Format.BC6H_Uf16:
            case Format.BC6H_Sf16:
            case Format.BC7_Typeless:
            case Format.BC7_UNorm:
            case Format.BC7_UNorm_SRgb:
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
        Format p_Format,
        long p_Width,
        long p_Height,
        out long p_RowPitch,
        out long p_SlicePitch,
        CPFLAGS p_Flags
    )
    {
        switch (p_Format)
        {
            case Format.BC1_Typeless:
            case Format.BC1_UNorm:
            case Format.BC1_UNorm_SRgb:
            case Format.BC4_Typeless:
            case Format.BC4_UNorm:
            case Format.BC4_SNorm:
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
            case Format.BC2_Typeless:
            case Format.BC2_UNorm:
            case Format.BC2_UNorm_SRgb:
            case Format.BC3_Typeless:
            case Format.BC3_UNorm:
            case Format.BC3_UNorm_SRgb:
            case Format.BC5_Typeless:
            case Format.BC5_UNorm:
            case Format.BC5_SNorm:
            case Format.BC6H_Typeless:
            case Format.BC6H_Uf16:
            case Format.BC6H_Sf16:
            case Format.BC7_Typeless:
            case Format.BC7_UNorm:
            case Format.BC7_UNorm_SRgb:
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
            case Format.R8G8_B8G8_UNorm:
            case Format.G8R8_G8B8_UNorm:
            case Format.YUY2:
                p_RowPitch = ((p_Width + 1) >> 1) * 4;
                p_SlicePitch = p_RowPitch * p_Height;
                break;
            case Format.Y210:
            case Format.Y216:
                p_RowPitch = ((p_Width + 1) >> 1) * 8;
                p_SlicePitch = p_RowPitch * p_Height;
                break;

            case Format.NV12:
            case Format.Opaque420:
                p_RowPitch = ((p_Width + 1) >> 1) * 2;
                p_SlicePitch = p_RowPitch * (p_Height + ((p_Height + 1) >> 1));
                break;

            case Format.P010:
            case Format.P016:
                p_RowPitch = ((p_Width + 1) >> 1) * 4;
                p_SlicePitch = p_RowPitch * (p_Height + ((p_Height + 1) >> 1));
                break;
            case Format.NV11:
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
        
        return p_Header.Dx10Header!.DxgiFormat is Format.BC1_UNorm or Format.BC1_UNorm_SRgb;
    }

    public static bool IsDXT3(DDSHeader p_Header)
    {
        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT3"))
            return true;

        if (p_Header.PixelFormat.FourCC != DDSUtils.MakeFourCC("DX10"))
            return false;
        
        return p_Header.Dx10Header!.DxgiFormat is Format.BC2_UNorm or Format.BC2_UNorm_SRgb;
    }

    public static bool IsDXT5(DDSHeader p_Header)
    {
        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT5"))
            return true;

        if (p_Header.PixelFormat.FourCC != DDSUtils.MakeFourCC("DX10"))
            return false;
        
        return p_Header.Dx10Header!.DxgiFormat is Format.BC3_UNorm or Format.BC3_UNorm_SRgb;
    }

    public static bool IsDXT5A(DDSHeader p_Header)
    {
        if (p_Header.PixelFormat.FourCC != DDSUtils.MakeFourCC("DX10"))
            return false;
        
        return p_Header.Dx10Header!.DxgiFormat is Format.BC4_UNorm;
    }

    public static bool IsDXN(DDSHeader p_Header)
    {
        if (p_Header.PixelFormat.FourCC != DDSUtils.MakeFourCC("DX10"))
            return false;
        
        return p_Header.Dx10Header!.DxgiFormat is Format.BC5_UNorm;
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