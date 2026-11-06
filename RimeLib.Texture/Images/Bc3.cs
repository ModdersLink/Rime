using System;

namespace RimeLib.Texture.Images;

/// <summary>
/// BC3 (DXT5) blocks to RGBA texels and back, and the box filter between mip levels. The encoder
/// fits each block's endpoints to its extremes, which suits small mip levels.
/// </summary>
public static class Bc3
{
    public const int BlockSize = 16;

    /// <summary>Whether the format's blocks are laid out as BC3's.</summary>
    public static bool IsBc3(TexturePixelFormat p_Format) =>
        p_Format is TexturePixelFormat.Dxt5 or TexturePixelFormat.NormalDxt5 or TexturePixelFormat.NormalDxt5Rga;

    /// <summary>RGBA texels, four bytes each, of a level of BC3 blocks.</summary>
    public static byte[] Decode(int p_Width, int p_Height, ReadOnlySpan<byte> p_Blocks)
    {
        var s_Rgba = new byte[p_Width * p_Height * 4];
        var s_BlocksX = (p_Width + 3) / 4;
        var s_BlocksY = (p_Height + 3) / 4;
        Span<byte> s_Alpha = stackalloc byte[8];
        Span<int> s_Colors = stackalloc int[12];

        for (var s_By = 0; s_By < s_BlocksY; ++s_By)
        for (var s_Bx = 0; s_Bx < s_BlocksX; ++s_Bx)
        {
            var s_Block = p_Blocks.Slice((s_By * s_BlocksX + s_Bx) * BlockSize, BlockSize);
            AlphaPalette(s_Block[0], s_Block[1], s_Alpha);
            ulong s_AlphaBits = 0;
            for (var i = 5; i >= 0; --i)
                s_AlphaBits = (s_AlphaBits << 8) | s_Block[2 + i];

            Unpack565(s_Block[8] | (s_Block[9] << 8), s_Colors[..3]);
            Unpack565(s_Block[10] | (s_Block[11] << 8), s_Colors.Slice(3, 3));
            for (var c = 0; c < 3; ++c)
            {
                s_Colors[6 + c] = (2 * s_Colors[c] + s_Colors[3 + c]) / 3;
                s_Colors[9 + c] = (s_Colors[c] + 2 * s_Colors[3 + c]) / 3;
            }

            var s_ColorBits = (uint)(s_Block[12] | (s_Block[13] << 8) | (s_Block[14] << 16) | (s_Block[15] << 24));
            for (var s_Texel = 0; s_Texel < 16; ++s_Texel)
            {
                int s_X = s_Bx * 4 + (s_Texel & 3), s_Y = s_By * 4 + (s_Texel >> 2);
                if (s_X >= p_Width || s_Y >= p_Height)
                    continue;

                var s_Out = (s_Y * p_Width + s_X) * 4;
                var s_Color = (int)((s_ColorBits >> (2 * s_Texel)) & 3) * 3;
                s_Rgba[s_Out] = (byte)s_Colors[s_Color];
                s_Rgba[s_Out + 1] = (byte)s_Colors[s_Color + 1];
                s_Rgba[s_Out + 2] = (byte)s_Colors[s_Color + 2];
                s_Rgba[s_Out + 3] = s_Alpha[(int)((s_AlphaBits >> (3 * s_Texel)) & 7)];
            }
        }

        return s_Rgba;
    }

    /// <summary>A level of BC3 blocks of RGBA texels; a block past the level's edge repeats its last texels.</summary>
    public static byte[] Encode(int p_Width, int p_Height, ReadOnlySpan<byte> p_Rgba)
    {
        var s_BlocksX = (p_Width + 3) / 4;
        var s_BlocksY = (p_Height + 3) / 4;
        var s_Blocks = new byte[s_BlocksX * s_BlocksY * BlockSize];
        Span<byte> s_Texels = stackalloc byte[64];
        Span<byte> s_Alpha = stackalloc byte[8];
        Span<int> s_Colors = stackalloc int[12];

        for (var s_By = 0; s_By < s_BlocksY; ++s_By)
        for (var s_Bx = 0; s_Bx < s_BlocksX; ++s_Bx)
        {
            for (var s_Texel = 0; s_Texel < 16; ++s_Texel)
            {
                var s_X = System.Math.Min(s_Bx * 4 + (s_Texel & 3), p_Width - 1);
                var s_Y = System.Math.Min(s_By * 4 + (s_Texel >> 2), p_Height - 1);
                p_Rgba.Slice((s_Y * p_Width + s_X) * 4, 4).CopyTo(s_Texels.Slice(s_Texel * 4, 4));
            }

            var s_Block = s_Blocks.AsSpan((s_By * s_BlocksX + s_Bx) * BlockSize, BlockSize);
            EncodeAlpha(s_Texels, s_Block[..8], s_Alpha);
            EncodeColor(s_Texels, s_Block[8..], s_Colors);
        }

        return s_Blocks;
    }

    /// <summary>The next mip level of RGBA texels: each texel the mean of the two by two it covers.</summary>
    public static byte[] Downsample(int p_Width, int p_Height, ReadOnlySpan<byte> p_Rgba)
    {
        int s_Width = System.Math.Max(1, p_Width / 2), s_Height = System.Math.Max(1, p_Height / 2);
        int s_StepX = p_Width > 1 ? 2 : 1, s_StepY = p_Height > 1 ? 2 : 1;
        var s_Out = new byte[s_Width * s_Height * 4];
        for (var s_Y = 0; s_Y < s_Height; ++s_Y)
        for (var s_X = 0; s_X < s_Width; ++s_X)
        for (var c = 0; c < 4; ++c)
        {
            var s_Sum = 0;
            for (var s_Dy = 0; s_Dy < s_StepY; ++s_Dy)
            for (var s_Dx = 0; s_Dx < s_StepX; ++s_Dx)
                s_Sum += p_Rgba[((s_Y * s_StepY + s_Dy) * p_Width + s_X * s_StepX + s_Dx) * 4 + c];

            var s_Count = s_StepX * s_StepY;
            s_Out[(s_Y * s_Width + s_X) * 4 + c] = (byte)((s_Sum + s_Count / 2) / s_Count);
        }

        return s_Out;
    }

    private static void AlphaPalette(byte p_A0, byte p_A1, Span<byte> p_Palette)
    {
        p_Palette[0] = p_A0;
        p_Palette[1] = p_A1;
        if (p_A0 > p_A1)
        {
            for (var i = 1; i < 7; ++i)
                p_Palette[1 + i] = (byte)(((7 - i) * p_A0 + i * p_A1 + 3) / 7);
        }
        else
        {
            for (var i = 1; i < 5; ++i)
                p_Palette[1 + i] = (byte)(((5 - i) * p_A0 + i * p_A1 + 2) / 5);
            p_Palette[6] = 0;
            p_Palette[7] = 255;
        }
    }

    private static void EncodeAlpha(ReadOnlySpan<byte> p_Texels, Span<byte> p_Block, Span<byte> p_Palette)
    {
        byte s_Min = 255, s_Max = 0;
        for (var i = 0; i < 16; ++i)
        {
            s_Min = System.Math.Min(s_Min, p_Texels[i * 4 + 3]);
            s_Max = System.Math.Max(s_Max, p_Texels[i * 4 + 3]);
        }

        // Eight interpolated alphas need the first endpoint the greater; equal ones need no indices.
        p_Block[0] = s_Max;
        p_Block[1] = s_Min;
        p_Block[2..].Clear();
        if (s_Max == s_Min)
            return;

        AlphaPalette(s_Max, s_Min, p_Palette);
        ulong s_Bits = 0;
        for (var i = 0; i < 16; ++i)
            s_Bits |= (ulong)Nearest(p_Palette, p_Texels[i * 4 + 3]) << (3 * i);
        for (var i = 0; i < 6; ++i)
            p_Block[2 + i] = (byte)(s_Bits >> (8 * i));
    }

    private static void EncodeColor(ReadOnlySpan<byte> p_Texels, Span<byte> p_Block, Span<int> p_Palette)
    {
        Span<int> s_Min = stackalloc int[] { 255, 255, 255 };
        Span<int> s_Max = stackalloc int[] { 0, 0, 0 };
        for (var i = 0; i < 16; ++i)
        for (var c = 0; c < 3; ++c)
        {
            s_Min[c] = System.Math.Min(s_Min[c], p_Texels[i * 4 + c]);
            s_Max[c] = System.Math.Max(s_Max[c], p_Texels[i * 4 + c]);
        }

        // Four colours need the first endpoint the greater.
        var s_C0 = Pack565(s_Max);
        var s_C1 = Pack565(s_Min);
        if (s_C0 < s_C1)
            (s_C0, s_C1) = (s_C1, s_C0);

        p_Block[0] = (byte)s_C0;
        p_Block[1] = (byte)(s_C0 >> 8);
        p_Block[2] = (byte)s_C1;
        p_Block[3] = (byte)(s_C1 >> 8);
        p_Block[4..].Clear();
        if (s_C0 == s_C1)
            return;

        Unpack565(s_C0, p_Palette[..3]);
        Unpack565(s_C1, p_Palette.Slice(3, 3));
        for (var c = 0; c < 3; ++c)
        {
            p_Palette[6 + c] = (2 * p_Palette[c] + p_Palette[3 + c]) / 3;
            p_Palette[9 + c] = (p_Palette[c] + 2 * p_Palette[3 + c]) / 3;
        }

        uint s_Bits = 0;
        for (var i = 0; i < 16; ++i)
        {
            int s_Best = 0, s_BestDistance = int.MaxValue;
            for (var s_Index = 0; s_Index < 4; ++s_Index)
            {
                var s_Distance = 0;
                for (var c = 0; c < 3; ++c)
                {
                    var s_D = p_Texels[i * 4 + c] - p_Palette[s_Index * 3 + c];
                    s_Distance += s_D * s_D;
                }

                if (s_Distance < s_BestDistance)
                    (s_Best, s_BestDistance) = (s_Index, s_Distance);
            }

            s_Bits |= (uint)s_Best << (2 * i);
        }

        for (var i = 0; i < 4; ++i)
            p_Block[4 + i] = (byte)(s_Bits >> (8 * i));
    }

    private static int Nearest(ReadOnlySpan<byte> p_Palette, byte p_Value)
    {
        int s_Best = 0, s_BestDistance = int.MaxValue;
        for (var i = 0; i < p_Palette.Length; ++i)
        {
            var s_Distance = System.Math.Abs(p_Palette[i] - p_Value);
            if (s_Distance < s_BestDistance)
                (s_Best, s_BestDistance) = (i, s_Distance);
        }

        return s_Best;
    }

    private static int Pack565(ReadOnlySpan<int> p_Rgb) =>
        ((p_Rgb[0] * 31 + 127) / 255 << 11) | ((p_Rgb[1] * 63 + 127) / 255 << 5) | ((p_Rgb[2] * 31 + 127) / 255);

    private static void Unpack565(int p_Color, Span<int> p_Rgb)
    {
        var s_R = (p_Color >> 11) & 31;
        var s_G = (p_Color >> 5) & 63;
        var s_B = p_Color & 31;
        p_Rgb[0] = (s_R << 3) | (s_R >> 2);
        p_Rgb[1] = (s_G << 2) | (s_G >> 4);
        p_Rgb[2] = (s_B << 3) | (s_B >> 2);
    }
}
