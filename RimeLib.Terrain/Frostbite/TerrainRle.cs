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
    public static byte[]? Decode(byte[] p_Rle, ushort[] p_LineSizes, int p_BytesPerLine)
    {
        if (p_BytesPerLine <= 0)
            return null;

        var s_Out = new byte[p_BytesPerLine * p_LineSizes.Length];
        var s_Src = 0;
        var s_Dst = 0;

        foreach (var s_LineSize in p_LineSizes)
        {
            var s_End = s_Src + s_LineSize;
            var s_LineEnd = s_Dst + p_BytesPerLine;

            if (s_End > p_Rle.Length)
                return null;

            while (s_Src < s_End)
            {
                var s_Value = p_Rle[s_Src++];

                if (s_Src < s_End && p_Rle[s_Src] == s_Value)
                {
                    ++s_Src;                                  // the marker, not a sample
                    var s_Extra = p_Rle[s_Src++];

                    for (var i = 0; i <= s_Extra; ++i)
                    {
                        if (s_Dst >= s_LineEnd)
                            return null;                      // the run overruns its line

                        s_Out[s_Dst++] = s_Value;
                    }
                }
                else
                {
                    if (s_Dst >= s_LineEnd)
                        return null;

                    s_Out[s_Dst++] = s_Value;
                }
            }

            if (s_Dst != s_LineEnd)
                return null;                                  // the line came up short
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
