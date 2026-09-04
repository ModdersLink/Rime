using System.Collections.Generic;

namespace RimeLib.Terrain.Frostbite;

/// <summary>
/// The run-length encoding the terrain mask and material trees store their samples in.
///
/// Both trees keep one encoded run per scanline, with a separate table saying how many bytes each
/// line occupies. A run is marked by two EQUAL bytes: the first is the value, the second is only a
/// marker, and the byte after it says how many more copies follow. So <c>A A n</c> decodes to
/// <c>1 + n</c> copies of A, and any byte not followed by its own value is a single sample.
///
/// Measured against MP_001, whose material nodes are 256 lines of <c>00 00 7F</c> -- 1 + 127 = 128
/// bytes, which at two 4-bit indices per byte is the 256 samples the tree declares. Reading the
/// second byte as data instead of a marker gives 129 and the line no longer fits.
/// </summary>
public static class TerrainRle
{
    /// <summary>
    /// Decode one node's samples: <paramref name="p_LineSizes"/> lines of
    /// <paramref name="p_BytesPerLine"/> bytes each.
    /// </summary>
    /// <returns>The decoded samples, or null if a line does not decode to exactly its width --
    /// which means the encoding is not what this understands, and a caller should say so rather
    /// than carry on with a half-filled buffer.</returns>
    /// <summary>Decode one line into <paramref name="p_Out"/>. -1 if it does not fit exactly.</summary>
    private static int DecodeLine(byte[] p_Rle, int p_Src, int p_End, byte[] p_Out, int p_Dst,
        int p_LineEnd)
    {
        while (p_Src < p_End)
        {
            var s_Value = p_Rle[p_Src++];
            var s_Count = 1;

            // Two equal bytes open a run: the second is a marker, and the byte after it says how
            // many MORE copies follow.
            if (p_Src < p_End && p_Rle[p_Src] == s_Value)
            {
                ++p_Src;                        // the marker, not a sample
                s_Count += p_Rle[p_Src++];      // how many MORE copies follow
            }

            if (p_Dst + s_Count > p_LineEnd)
                return -1;

            for (var i = 0; i < s_Count; ++i)
                p_Out[p_Dst++] = s_Value;
        }

        return p_Dst == p_LineEnd ? p_Src : -1;
    }

    /// <summary>
    /// Decode one node's samples: <paramref name="p_LineSizes"/> lines of
    /// <paramref name="p_BytesPerLine"/> bytes each.
    /// </summary>
    /// <returns>The decoded samples, or null if a line does not decode to exactly its width --
    /// which means the encoding is not what this understands, and a caller should say so rather
    /// than carry on with a half-filled buffer.</returns>
    public static byte[]? Decode(byte[] p_Rle, ushort[] p_LineSizes, int p_BytesPerLine)
    {
        if (p_BytesPerLine <= 0)
            return null;

        var s_Out = new byte[p_BytesPerLine * p_LineSizes.Length];
        var s_Src = 0;
        var s_Dst = 0;

        foreach (var s_LineSize in p_LineSizes)
        {
            if (s_Src + s_LineSize > p_Rle.Length)
                return null;

            s_Src = DecodeLine(p_Rle, s_Src, s_Src + s_LineSize, s_Out, s_Dst,
                s_Dst + p_BytesPerLine);

            if (s_Src < 0)
                return null;

            s_Dst += p_BytesPerLine;
        }

        return s_Out;
    }

    /// <summary>
    /// How many bytes a line of <paramref name="p_SamplesPerLine"/> nibble-packed samples takes.
    /// An odd sample count still needs the whole byte: the destruction tree's 133 samples are 67
    /// bytes, not 66, and reading them as 66 makes every line come up short.
    /// </summary>
    public static int BytesPerLine(int p_SamplesPerLine)
    {
        return (p_SamplesPerLine + 1) / 2;
    }

    /// <summary>
    /// Unpack nibble-packed rows, dropping the half-sample an odd row width leaves at its end.
    /// </summary>
    public static byte[] UnpackRows(byte[] p_Packed, int p_SamplesPerLine, int p_Lines)
    {
        var s_Stride = BytesPerLine(p_SamplesPerLine);
        var s_Out = new byte[p_SamplesPerLine * p_Lines];

        for (var s_Line = 0; s_Line < p_Lines; ++s_Line)
        {
            for (var i = 0; i < p_SamplesPerLine; ++i)
            {
                var s_Byte = p_Packed[s_Line * s_Stride + i / 2];
                s_Out[s_Line * p_SamplesPerLine + i] =
                    (byte)(i % 2 == 0 ? s_Byte & 0xF : s_Byte >> 4);
            }
        }

        return s_Out;
    }


    /// <summary>
    /// Encode one line, the inverse of <see cref="DecodeLine"/>.
    ///
    /// A run of two or more equal bytes is written <c>V V (n-1)</c>; a lone byte is written as
    /// itself. A PAIR has to be written as a run even though that costs three bytes rather than
    /// two: two equal bytes in a row are exactly what opens a run, so emitting them as two singles
    /// would decode as a run header and swallow whatever follows.
    ///
    /// A run longer than 256 is split, since the count byte holds n-1.
    /// </summary>
    public static byte[] EncodeLine(byte[] p_Line, int p_Start, int p_Length)
    {
        var s_Out = new List<byte>();
        var s_At = p_Start;
        var s_End = p_Start + p_Length;

        while (s_At < s_End)
        {
            var s_Value = p_Line[s_At];
            var s_Run = 1;

            while (s_At + s_Run < s_End && p_Line[s_At + s_Run] == s_Value && s_Run < 256)
                ++s_Run;

            if (s_Run == 1)
            {
                s_Out.Add(s_Value);
            }
            else
            {
                s_Out.Add(s_Value);
                s_Out.Add(s_Value);
                s_Out.Add((byte)(s_Run - 1));
            }

            s_At += s_Run;
        }

        return s_Out.ToArray();
    }

    /// <summary>
    /// Encode a node's samples the way the mask and material trees store them:
    /// <paramref name="p_Lines"/> lines of <paramref name="p_BytesPerLine"/> bytes, each run-length
    /// coded on its own. Returns the coded bytes and, through
    /// <paramref name="p_LineSizes"/>, how many each line took -- the table the decoder needs.
    ///
    /// MEASURED against MP_001's material tree: 3386 of its 4096 packed lines come back out as
    /// <c>00 00 7F</c>, which is the encoding those nodes ship, and all 4096 decode to exactly the
    /// samples they went in as.
    /// </summary>
    public static byte[] Encode(byte[] p_Samples, int p_BytesPerLine, int p_Lines,
        out ushort[] p_LineSizes)
    {
        p_LineSizes = new ushort[p_Lines];
        var s_Out = new List<byte>();

        for (var s_Line = 0; s_Line < p_Lines; ++s_Line)
        {
            var s_Coded = EncodeLine(p_Samples, s_Line * p_BytesPerLine, p_BytesPerLine);
            p_LineSizes[s_Line] = (ushort)s_Coded.Length;
            s_Out.AddRange(s_Coded);
        }

        return s_Out.ToArray();
    }

    /// <summary>
    /// Pack samples two per byte, low nibble first -- the inverse of
    /// <see cref="UnpackRows"/>. An odd sample count still takes the whole byte.
    /// </summary>
    public static byte[] PackRows(byte[] p_Samples, int p_SamplesPerLine, int p_Lines)
    {
        var s_Stride = BytesPerLine(p_SamplesPerLine);
        var s_Out = new byte[s_Stride * p_Lines];

        for (var s_Line = 0; s_Line < p_Lines; ++s_Line)
        {
            for (var i = 0; i < p_SamplesPerLine; ++i)
            {
                var s_Sample = (byte)(p_Samples[s_Line * p_SamplesPerLine + i] & 0xF);

                if (i % 2 == 0)
                    s_Out[s_Line * s_Stride + i / 2] = s_Sample;
                else
                    s_Out[s_Line * s_Stride + i / 2] |= (byte)(s_Sample << 4);
            }
        }

        return s_Out;
    }

    /// <summary>
    /// Samples packed two per byte, as the material tree stores them: the low nibble first.
    /// </summary>
    public static byte[] Unpack(byte[] p_Packed)
    {
        var s_Out = new byte[p_Packed.Length * 2];

        for (var i = 0; i < p_Packed.Length; ++i)
        {
            s_Out[i * 2] = (byte)(p_Packed[i] & 0xF);
            s_Out[i * 2 + 1] = (byte)(p_Packed[i] >> 4);
        }

        return s_Out;
    }
}
