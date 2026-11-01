using System;
using RimeLib.Terrain.Frostbite;
using Xunit;

namespace RimeLib.Tests.Terrain;

/// <summary>
/// The terrain mask/material run-length codec, both directions.
///
/// The encoder exists so a terrain can be written back, not only read, and the property that
/// matters is that it is the exact inverse of the decoder the game's own data is read with.
/// </summary>
public class TerrainRleTest
{
    private static byte[] Roundtrip(byte[] p_Samples, int p_BytesPerLine, int p_Lines)
    {
        var s_Coded = TerrainRle.Encode(p_Samples, p_BytesPerLine, p_Lines, out var s_LineSizes);
        var s_Back = TerrainRle.Decode(s_Coded, s_LineSizes, p_BytesPerLine);
        Assert.NotNull(s_Back);
        return s_Back!;
    }

    [Fact]
    public void EncodesAUniformLineTheWayMp001Ships()
    {
        // MP_001's material nodes are lines of 128 zero bytes, and each ships as `00 00 7F`:
        // the value, the marker, then 127 MORE copies.
        var s_Coded = TerrainRle.EncodeLine(new byte[128], 0, 128);
        Assert.Equal(new byte[] { 0x00, 0x00, 0x7F }, s_Coded);
    }

    [Fact]
    public void EncodesAPairAsARunNotTwoSingles()
    {
        // Two equal bytes are what OPENS a run, so a pair cannot be written as two singles even
        // though that would be shorter -- the decoder would read the second as a marker.
        Assert.Equal(new byte[] { 0x07, 0x07, 0x01 }, TerrainRle.EncodeLine(new byte[] { 7, 7 }, 0, 2));
    }

    [Fact]
    public void SplitsARunLongerThanTheCountByteCanHold()
    {
        // The count byte holds n-1, so 256 is the longest single run.
        var s_Coded = TerrainRle.EncodeLine(new byte[300], 0, 300);
        Assert.Equal(new byte[] { 0x00, 0x00, 0xFF, 0x00, 0x00, 0x2B }, s_Coded);
        Assert.Equal(new byte[300], Roundtrip(new byte[300], 300, 1));
    }

    [Fact]
    public void RoundtripsLinesWithNoRunsAtAll()
    {
        var s_Line = new byte[64];

        for (var i = 0; i < s_Line.Length; ++i)
            s_Line[i] = (byte)(i % 2 == 0 ? 0x1A : 0x2B);      // alternating: every sample single

        Assert.Equal(s_Line, Roundtrip(s_Line, 64, 1));
    }

    [Fact]
    public void RoundtripsPseudoRandomMultiLineData()
    {
        // Deterministic, and mixed enough to exercise singles, pairs, long runs and line ends.
        var s_Random = new Random(1337);
        var s_Samples = new byte[64 * 32];

        for (var i = 0; i < s_Samples.Length; ++i)
            s_Samples[i] = (byte)(s_Random.Next(4) == 0 ? s_Random.Next(256) : 0);

        Assert.Equal(s_Samples, Roundtrip(s_Samples, 64, 32));
    }

    [Fact]
    public void PacksAndUnpacksNibblesBackToTheSameSamples()
    {
        // 133 is the destruction tree's width: an ODD count, which still takes the whole last byte.
        var s_Samples = new byte[133 * 3];

        for (var i = 0; i < s_Samples.Length; ++i)
            s_Samples[i] = (byte)(i % 16);

        var s_Packed = TerrainRle.PackRows(s_Samples, 133, 3);
        Assert.Equal(TerrainRle.BytesPerLine(133) * 3, s_Packed.Length);
        Assert.Equal(s_Samples, TerrainRle.UnpackRows(s_Packed, 133, 3));
    }

    [Fact]
    public void EncodesPackedRowsBackThroughTheDecoder()
    {
        // The full write path a terrain writer uses: samples -> nibble-packed -> run-length coded,
        // and back out again.
        var s_Samples = new byte[256 * 8];

        for (var i = 0; i < s_Samples.Length; ++i)
            s_Samples[i] = (byte)(i / 256 % 2 == 0 ? 0 : i % 3);

        var s_Packed = TerrainRle.PackRows(s_Samples, 256, 8);
        var s_Stride = TerrainRle.BytesPerLine(256);
        Assert.Equal(s_Samples, TerrainRle.UnpackRows(Roundtrip(s_Packed, s_Stride, 8), 256, 8));
    }
}
