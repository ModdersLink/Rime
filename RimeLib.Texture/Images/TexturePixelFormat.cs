namespace RimeLib.Texture.Images;

/// <summary>
/// How a texture's texels are stored, named as Frostbite names its texture formats. Every engine's
/// own format list maps onto this one; a format only some engines have appears once here.
/// </summary>
public enum TexturePixelFormat
{
    Dxt1,
    Dxt1A,
    Dxt3,
    Dxt5,
    Dxt5A,
    Dxn,
    Bc7,
    Rgb565,
    Rgb888,
    Argb1555,
    Argb4444,
    Argb8888,
    L8,
    L16,
    Abgr16,
    Abgr16F,
    Abgr32F,
    R16F,
    R32F,
    NormalDxn,
    NormalDxt1,
    NormalDxt5,
    NormalDxt5Rga,
    Rg8,
    Gr16,
    Gr16F,
    D16,
    D24S8,
    D24FS8,
    D32F,
    D32FS8,
    S8,
    Abgr32,
    Gr32F,
    A2R10G10B10,
    R11G11B10F,
    Abgr16Snorm,
    Abgr16Uint,
    L16Uint,
    L32,
    Gr16Uint,
    Gr32Uint,
    R9G9B9E5F,
}

public static class TexturePixelFormats
{
    /// <summary>Bytes per 4x4 block for a block-compressed format, 0 for the others.</summary>
    public static int BlockSize(this TexturePixelFormat p_Format) => p_Format switch
    {
        TexturePixelFormat.Dxt1 or TexturePixelFormat.Dxt1A or TexturePixelFormat.NormalDxt1 or TexturePixelFormat.Dxt5A => 8,
        TexturePixelFormat.Dxt3 or TexturePixelFormat.Dxt5 or TexturePixelFormat.NormalDxt5 or TexturePixelFormat.NormalDxt5Rga
            or TexturePixelFormat.Dxn or TexturePixelFormat.NormalDxn or TexturePixelFormat.Bc7 => 16,
        _ => 0,
    };

    /// <summary>Bytes per texel for a format that is not block-compressed.</summary>
    public static int TexelSize(this TexturePixelFormat p_Format) => p_Format switch
    {
        TexturePixelFormat.L8 or TexturePixelFormat.S8 => 1,
        TexturePixelFormat.Rgb565 or TexturePixelFormat.Argb1555 or TexturePixelFormat.Argb4444 or TexturePixelFormat.L16
            or TexturePixelFormat.R16F or TexturePixelFormat.Rg8 or TexturePixelFormat.D16 or TexturePixelFormat.L16Uint => 2,
        TexturePixelFormat.Rgb888 => 3,
        TexturePixelFormat.Argb8888 or TexturePixelFormat.R32F or TexturePixelFormat.Gr16 or TexturePixelFormat.Gr16F
            or TexturePixelFormat.D24S8 or TexturePixelFormat.D24FS8 or TexturePixelFormat.D32F or TexturePixelFormat.A2R10G10B10
            or TexturePixelFormat.R11G11B10F or TexturePixelFormat.L32 or TexturePixelFormat.Gr16Uint or TexturePixelFormat.R9G9B9E5F => 4,
        TexturePixelFormat.Abgr16 or TexturePixelFormat.Abgr16F or TexturePixelFormat.D32FS8 or TexturePixelFormat.Gr32F
            or TexturePixelFormat.Abgr16Snorm or TexturePixelFormat.Abgr16Uint or TexturePixelFormat.Gr32Uint => 8,
        TexturePixelFormat.Abgr32F or TexturePixelFormat.Abgr32 => 16,
        _ => throw new System.ArgumentException($"{p_Format} is block-compressed.", nameof(p_Format)),
    };

    /// <summary>The bytes of a row of texels, or of 4x4 blocks, padded to <paramref name="p_RowAlignment"/>.</summary>
    public static long RowSize(this TexturePixelFormat p_Format, int p_Width, int p_RowAlignment = 1)
    {
        var s_BlockSize = p_Format.BlockSize();
        var s_Row = s_BlockSize == 0
            ? (long)p_Width * p_Format.TexelSize()
            : (long)System.Math.Max(1, (p_Width + 3) / 4) * s_BlockSize;
        return (s_Row + p_RowAlignment - 1) / p_RowAlignment * p_RowAlignment;
    }

    /// <summary>The rows of a level: texel rows, or rows of 4x4 blocks.</summary>
    public static int RowCount(this TexturePixelFormat p_Format, int p_Height) =>
        p_Format.BlockSize() == 0 ? p_Height : System.Math.Max(1, (p_Height + 3) / 4);

    /// <summary>The bytes of one face or slice of a width x height level.</summary>
    public static long SurfaceSize(this TexturePixelFormat p_Format, int p_Width, int p_Height, int p_RowAlignment = 1) =>
        p_Format.RowSize(p_Width, p_RowAlignment) * p_Format.RowCount(p_Height);
}
