using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.IO;

namespace RimeLib.Texture.Images;

/// <summary>Fits an image to what another engine's textures can be: its formats and its streaming groups.</summary>
public static class TextureConversion
{
    /// <summary>
    /// The image in one of <paramref name="p_Formats"/>: itself when its format is among them, else
    /// converted without loss to one that is. Refused when there is no such conversion.
    /// </summary>
    public static TextureImage ToFormats(TextureImage p_Image, IReadOnlyCollection<TexturePixelFormat> p_Formats)
    {
        if (p_Formats.Contains(p_Image.Format))
            return p_Image;

        foreach (var (s_Target, s_Convert) in Conversions(p_Image.Format))
        {
            if (!p_Formats.Contains(s_Target))
                continue;

            var s_Converted = p_Image.Copy();
            s_Converted.Format = s_Target;
            s_Converted.Data = s_Convert(p_Image.Data);
            return s_Converted;
        }

        throw new NotSupportedException($"A {p_Image.Format} texture has no lossless conversion to {string.Join(", ", p_Formats.OrderBy(p_F => p_F))}.");
    }

    /// <summary>Whether fitting the image to <paramref name="p_Formats"/> needs its texels.</summary>
    public static bool NeedsData(TexturePixelFormat p_Format, IReadOnlyCollection<TexturePixelFormat> p_Formats) =>
        !p_Formats.Contains(p_Format) && Conversions(p_Format).Any(p_C => p_Formats.Contains(p_C.Target) && p_C.Convert != Same);

    private static byte[] Same(byte[] p_Data) => p_Data;

    /// <summary>The formats a format converts to without loss, nearest first.</summary>
    private static IEnumerable<(TexturePixelFormat Target, Func<byte[], byte[]> Convert)> Conversions(TexturePixelFormat p_Format) => p_Format switch
    {
        // Dxt1 blocks already carry the one-bit alpha: a block whose first colour is not above the
        // second has a transparent fourth colour.
        TexturePixelFormat.Dxt1A => [(TexturePixelFormat.Dxt1, Same)],
        TexturePixelFormat.R9G9B9E5F => [(TexturePixelFormat.Abgr16F, SharedExponentToHalf)],
        _ => [],
    };

    /// <summary>
    /// RGB with nine mantissa bits each and a shared five-bit exponent, as four half floats with an
    /// alpha of one. Exact: a half has more mantissa bits and as wide an exponent.
    /// </summary>
    private static byte[] SharedExponentToHalf(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        var s_Out = new MemoryStream(p_Data.Length * 2);
        using (var s_Writer = new RimeWriter(s_Out))
        {
            while (s_Reader.Position < s_Reader.Length)
            {
                var s_Texel = s_Reader.ReadUInt32();
                var s_Exponent = (int)(s_Texel >> 27) - 15 - 9;
                s_Writer.Write(HalfBits((s_Texel & 0x1FF), s_Exponent));
                s_Writer.Write(HalfBits((s_Texel >> 9) & 0x1FF, s_Exponent));
                s_Writer.Write(HalfBits((s_Texel >> 18) & 0x1FF, s_Exponent));
                s_Writer.Write(BitConverter.HalfToUInt16Bits(Half.One));
            }
        }

        return s_Out.ToArray();
    }

    private static ushort HalfBits(uint p_Mantissa, int p_Exponent) =>
        BitConverter.HalfToUInt16Bits((Half)MathF.ScaleB(p_Mantissa, p_Exponent));

    /// <summary>
    /// A streaming group the target engine has for <paramref name="p_Group"/>: the same one, else
    /// the longest of its groups the name starts with (World_Max1024 goes under World), else Default.
    /// </summary>
    public static string ToGroups(string p_Group, IReadOnlyCollection<string> p_Groups)
    {
        if (p_Groups.Contains(p_Group, StringComparer.Ordinal))
            return p_Group;

        return p_Groups
            .Where(p_G => p_G.Length > 0 && p_Group.StartsWith(p_G, StringComparison.Ordinal))
            .OrderByDescending(p_G => p_G.Length)
            .FirstOrDefault() ?? "Default";
    }
}
