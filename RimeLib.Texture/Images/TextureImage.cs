using System;
using System.IO;
using RimeLib.Frostbite.Core;

namespace RimeLib.Texture.Images;

/// <summary>
/// A texture without its engine's layout: what it is, how it is loaded, and its texels, packed
/// tightly: per face or slice, its mip levels one after another.
/// </summary>
public sealed class TextureImage
{
    public TextureKind Kind { get; set; }
    public TexturePixelFormat Format { get; set; }
    public TextureOptions Options { get; set; }

    public int Width { get; set; }
    public int Height { get; set; }

    /// <summary>The depth of a 3D texture; for the others the number of faces or slices.</summary>
    public int Depth { get; set; } = 1;

    public int SliceCount { get; set; } = 1;
    public int MipCount { get; set; } = 1;

    /// <summary>The first mip level the engine loads at full quality settings.</summary>
    public int MipBaseIndex { get; set; }

    /// <summary>The streaming group the engine budgets the texture under.</summary>
    public string Group { get; set; } = "Default";

    public GUID ChunkId { get; set; } = GUID.Empty;

    /// <summary>The streaming chunk's bytes.</summary>
    public byte[] Data { get; set; } = Array.Empty<byte>();

    /// <summary>A copy sharing the data, to change the description of.</summary>
    public TextureImage Copy() => (TextureImage)MemberwiseClone();

    /// <summary>The width, height or depth of a mip level.</summary>
    public static int Level(int p_Size, int p_Mip) => System.Math.Max(1, p_Size >> p_Mip);

    /// <summary>
    /// The bytes of one face or slice of a mip level, which is what Frostbite headers record per level.
    /// The data is packed tightly; an engine that pads rows passes its alignment.
    /// </summary>
    public long MipSize(int p_Mip, int p_RowAlignment = 1)
    {
        var s_Size = Format.SurfaceSize(Level(Width, p_Mip), Level(Height, p_Mip), p_RowAlignment);
        return Kind == TextureKind.Texture3D ? s_Size * Level(Depth, p_Mip) : s_Size;
    }

    /// <summary>The bytes of every mip level of one face or slice.</summary>
    public long ChainSize(int p_RowAlignment = 1)
    {
        var s_Size = 0L;
        for (var i = 0; i < MipCount; ++i)
            s_Size += MipSize(i, p_RowAlignment);
        return s_Size;
    }

    /// <summary>The faces or slices the chunk holds a mip chain for.</summary>
    public int Layers => Kind == TextureKind.Texture3D ? 1 : SliceCount;

    /// <summary>The bytes of the whole chunk.</summary>
    public long DataSize(int p_RowAlignment = 1) => ChainSize(p_RowAlignment) * Layers;

    /// <summary>
    /// Texel data of this image's layout with its rows padded from one alignment to another: per
    /// face or slice, per mip level, per depth slice, each row copied with the target's padding.
    /// Data whose rows are aligned to both is returned as it is.
    /// </summary>
    public byte[] RealignRows(byte[] p_Data, int p_From, int p_To)
    {
        if (DataSize(p_From) == DataSize(p_To))
            return p_Data;

        if (p_Data.Length != DataSize(p_From))
            throw new InvalidDataException($"{p_Data.Length} bytes of texels for a texture whose layout gives {DataSize(p_From)}.");

        var s_Out = new byte[DataSize(p_To)];
        long s_Read = 0, s_Written = 0;
        for (var s_Layer = 0; s_Layer < Layers; ++s_Layer)
        for (var s_Mip = 0; s_Mip < MipCount; ++s_Mip)
        {
            var s_Width = Level(Width, s_Mip);
            var s_Rows = Format.RowCount(Level(Height, s_Mip)) * (Kind == TextureKind.Texture3D ? Level(Depth, s_Mip) : 1);
            var s_Tight = Format.RowSize(s_Width);
            var s_FromRow = Format.RowSize(s_Width, p_From);
            var s_ToRow = Format.RowSize(s_Width, p_To);

            for (var s_Row = 0; s_Row < s_Rows; ++s_Row)
            {
                Array.Copy(p_Data, s_Read, s_Out, s_Written, s_Tight);
                s_Read += s_FromRow;
                s_Written += s_ToRow;
            }
        }

        return s_Out;
    }
}
