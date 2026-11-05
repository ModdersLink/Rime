using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using RimeLib.Frostbite.Core;

namespace RimeLib.Texture.Images;

/// <summary>A texture's rectangle in an atlas's first mip level, in texels.</summary>
public sealed record AtlasCell(string Name, int X, int Y, int Width, int Height);

/// <summary>
/// A BC3 atlas grown to twice its height: its own texels in the top half, at every mip level, and
/// textures packed into the bottom half, each at a multiple of its size so that its mip levels land
/// on whole blocks of the atlas's. A level too small for that is filtered from the one above it,
/// the halves apart, with the atlas's and each texture's own level put back where they have one.
/// </summary>
public sealed class TextureAtlas
{
    private readonly TextureImage m_Atlas;
    private readonly List<(AtlasCell Cell, TextureImage Image, int Mip)> m_Placed = [];

    /// <summary>The atlas's size, twice the height of the one it grows.</summary>
    public int Width => m_Atlas.Width;
    public int Height => m_Atlas.Height * 2;

    /// <summary>The top mip levels left off every texture so that they fit.</summary>
    public int DroppedMips { get; }

    public IReadOnlyList<AtlasCell> Cells => m_Placed.Select(p_P => p_P.Cell).ToList();

    /// <param name="p_Atlas">A tightly packed 2D BC3 atlas whose sides are powers of two.</param>
    /// <param name="p_Textures">Tightly packed 2D BC3 textures whose sides are powers of two.</param>
    public TextureAtlas(TextureImage p_Atlas, IReadOnlyList<(string Name, TextureImage Image)> p_Textures)
    {
        Check(p_Atlas, "The atlas");
        foreach (var (s_Name, s_Image) in p_Textures)
            Check(s_Image, $"'{s_Name}'");

        m_Atlas = p_Atlas;
        for (var s_Dropped = 0; ; ++s_Dropped)
        {
            if (p_Textures.Any(p_T => p_T.Image.MipCount <= s_Dropped || System.Math.Min(p_T.Image.Width, p_T.Image.Height) >> s_Dropped < 4))
                throw new InvalidDataException($"The textures do not fit below a {p_Atlas.Width}x{p_Atlas.Height} atlas.");

            if (Pack(p_Textures, s_Dropped) is { } s_Placed)
            {
                m_Placed = s_Placed;
                DroppedMips = s_Dropped;
                return;
            }
        }
    }

    private static void Check(TextureImage p_Image, string p_What)
    {
        if (p_Image.Kind != TextureKind.Texture2D || p_Image.SliceCount != 1 || !Bc3.IsBc3(p_Image.Format))
            throw new InvalidDataException($"{p_What} is a {p_Image.Kind} of {p_Image.Format}, not a 2D BC3 texture.");
        if (!BitOperations.IsPow2(p_Image.Width) || !BitOperations.IsPow2(p_Image.Height))
            throw new InvalidDataException($"{p_What} is {p_Image.Width}x{p_Image.Height}, not a power of two.");
        if (p_Image.Data.Length != p_Image.DataSize())
            throw new InvalidDataException($"{p_What} holds {p_Image.Data.Length} bytes of texels, not {p_Image.DataSize()}.");
    }

    /// <summary>
    /// Each texture, its top mips dropped, at the first free place that is a multiple of its size,
    /// the largest first; none when one does not fit.
    /// </summary>
    private List<(AtlasCell, TextureImage, int)>? Pack(IReadOnlyList<(string Name, TextureImage Image)> p_Textures, int p_Dropped)
    {
        var s_Sized = p_Textures.Select(p_T => (p_T.Name, p_T.Image, Width: p_T.Image.Width >> p_Dropped, Height: p_T.Image.Height >> p_Dropped))
            .OrderByDescending(p_T => System.Math.Max(p_T.Width, p_T.Height)).ThenByDescending(p_T => p_T.Width * p_T.Height)
            .ThenBy(p_T => p_T.Name, StringComparer.OrdinalIgnoreCase)
            .ToList();
        if (s_Sized.Count == 0)
            return [];

        var s_Unit = s_Sized.Min(p_T => System.Math.Min(p_T.Width, p_T.Height));
        int s_Columns = m_Atlas.Width / s_Unit, s_Rows = m_Atlas.Height / s_Unit;
        if (s_Columns == 0 || s_Rows == 0)
            return null;

        var s_Used = new bool[s_Columns, s_Rows];
        var s_Placed = new List<(AtlasCell, TextureImage, int)>();
        foreach (var (s_Name, s_Image, s_Width, s_Height) in s_Sized)
        {
            int s_W = s_Width / s_Unit, s_H = s_Height / s_Unit;
            var s_Found = false;
            for (var s_Y = 0; !s_Found && s_Y + s_H <= s_Rows; s_Y += s_H)
            for (var s_X = 0; !s_Found && s_X + s_W <= s_Columns; s_X += s_W)
            {
                if (!Free(s_Used, s_X, s_Y, s_W, s_H))
                    continue;

                for (var i = 0; i < s_W; ++i)
                for (var j = 0; j < s_H; ++j)
                    s_Used[s_X + i, s_Y + j] = true;
                s_Placed.Add((new AtlasCell(s_Name, s_X * s_Unit, m_Atlas.Height + s_Y * s_Unit, s_Width, s_Height), s_Image, p_Dropped));
                s_Found = true;
            }

            if (!s_Found)
                return null;
        }

        return s_Placed;
    }

    private static bool Free(bool[,] p_Used, int p_X, int p_Y, int p_W, int p_H)
    {
        for (var i = 0; i < p_W; ++i)
        for (var j = 0; j < p_H; ++j)
            if (p_Used[p_X + i, p_Y + j])
                return false;
        return true;
    }

    /// <summary>The grown atlas, with every mip level its size has, its chunk left to the caller to name.</summary>
    public TextureImage Build()
    {
        var s_Image = m_Atlas.Copy();
        s_Image.Height = Height;
        s_Image.MipCount = BitOperations.Log2((uint)System.Math.Max(Width, Height)) + 1;
        s_Image.ChunkId = GUID.Empty;

        var s_Data = new byte[s_Image.DataSize()];
        var s_Offset = 0L;
        byte[]? s_Previous = null;
        for (var s_Mip = 0; s_Mip < s_Image.MipCount; ++s_Mip)
        {
            int s_Width = TextureImage.Level(Width, s_Mip), s_Height = TextureImage.Level(Height, s_Mip);
            var s_Level = s_Data.AsSpan((int)s_Offset, (int)s_Image.MipSize(s_Mip));
            if (CopiesBlocks(s_Mip))
                s_Previous = null;
            else
            {
                s_Previous ??= Bc3.Decode(TextureImage.Level(Width, s_Mip - 1), TextureImage.Level(Height, s_Mip - 1), Level(s_Data, s_Image, s_Mip - 1));
                s_Previous = Filter(s_Mip, s_Previous);
                Bc3.Encode(s_Width, s_Height, s_Previous).CopyTo(s_Level);
            }

            // Whole blocks of the atlas's or a texture's own level are kept as they are.
            CopyBlocks(s_Mip, s_Level);

            s_Offset += s_Level.Length;
        }

        s_Image.Data = s_Data;
        return s_Image;
    }

    private static ReadOnlySpan<byte> Level(byte[] p_Data, TextureImage p_Image, int p_Mip)
    {
        var s_Offset = 0L;
        for (var i = 0; i < p_Mip; ++i)
            s_Offset += p_Image.MipSize(i);
        return p_Data.AsSpan((int)s_Offset, (int)p_Image.MipSize(p_Mip));
    }

    /// <summary>Whether the halves of the level split apart: the atlas has the level, and it is half the grown one.</summary>
    private bool Splits(int p_Mip) =>
        p_Mip < m_Atlas.MipCount && TextureImage.Level(Height, p_Mip) == 2 * TextureImage.Level(m_Atlas.Height, p_Mip);

    /// <summary>Whether the level is the atlas's and each texture's level, block for block.</summary>
    private bool CopiesBlocks(int p_Mip) =>
        Splits(p_Mip) && TextureImage.Level(Width, p_Mip) % 4 == 0 && TextureImage.Level(m_Atlas.Height, p_Mip) % 4 == 0
        && m_Placed.All(p_P => HasLevel(p_P, p_Mip) && (p_P.Cell.Width >> p_Mip) % 4 == 0 && (p_P.Cell.Height >> p_Mip) % 4 == 0);

    private static bool HasLevel((AtlasCell Cell, TextureImage Image, int Mip) p_Placed, int p_Mip) =>
        p_Placed.Mip + p_Mip < p_Placed.Image.MipCount && p_Placed.Cell.Width >> p_Mip > 0 && p_Placed.Cell.Height >> p_Mip > 0;

    private void CopyBlocks(int p_Mip, Span<byte> p_Level)
    {
        if (Splits(p_Mip) && TextureImage.Level(Width, p_Mip) % 4 == 0 && TextureImage.Level(m_Atlas.Height, p_Mip) % 4 == 0)
            Level(m_Atlas.Data, m_Atlas, p_Mip).CopyTo(p_Level);

        var s_Row = (int)m_Atlas.Format.RowSize(TextureImage.Level(Width, p_Mip));
        foreach (var (s_Cell, s_Image, s_Dropped) in m_Placed)
        {
            if (!HasLevel((s_Cell, s_Image, s_Dropped), p_Mip) || (s_Cell.Width >> p_Mip) % 4 != 0 || (s_Cell.Height >> p_Mip) % 4 != 0)
                continue;

            var s_Source = Level(s_Image.Data, s_Image, s_Dropped + p_Mip);
            var s_SourceRow = (int)s_Image.Format.RowSize(s_Cell.Width >> p_Mip);
            var s_Start = ((s_Cell.Y >> p_Mip) / 4) * s_Row + ((s_Cell.X >> p_Mip) / 4) * Bc3.BlockSize;
            for (var s_BlockRow = 0; s_BlockRow < (s_Cell.Height >> p_Mip) / 4; ++s_BlockRow)
                s_Source.Slice(s_BlockRow * s_SourceRow, s_SourceRow).CopyTo(p_Level[(s_Start + s_BlockRow * s_Row)..]);
        }
    }

    /// <summary>
    /// The level's texels from the one above: the atlas's own in the top half and the bottom half
    /// filtered, with each texture's own level where it has one, or the whole level filtered once
    /// the halves no longer split.
    /// </summary>
    private byte[] Filter(int p_Mip, byte[] p_Above)
    {
        int s_AboveWidth = TextureImage.Level(Width, p_Mip - 1), s_AboveHeight = TextureImage.Level(Height, p_Mip - 1);
        if (!Splits(p_Mip))
            return Bc3.Downsample(s_AboveWidth, s_AboveHeight, p_Above);

        int s_Width = TextureImage.Level(Width, p_Mip), s_Half = TextureImage.Level(m_Atlas.Height, p_Mip);
        var s_RowBytes = s_Width * 4;
        var s_Texels = new byte[s_RowBytes * s_Half * 2];
        Bc3.Decode(s_Width, s_Half, Level(m_Atlas.Data, m_Atlas, p_Mip)).CopyTo(s_Texels, 0);
        Bc3.Downsample(s_AboveWidth, s_AboveHeight / 2, p_Above.AsSpan(s_AboveWidth * 4 * (s_AboveHeight / 2))).CopyTo(s_Texels, s_RowBytes * s_Half);

        foreach (var s_Placed in m_Placed.Where(p_P => HasLevel(p_P, p_Mip)))
        {
            var (s_Cell, s_Image, s_Dropped) = s_Placed;
            int s_CellWidth = s_Cell.Width >> p_Mip, s_CellHeight = s_Cell.Height >> p_Mip;
            var s_Own = Bc3.Decode(s_CellWidth, s_CellHeight, Level(s_Image.Data, s_Image, s_Dropped + p_Mip));
            for (var s_Y = 0; s_Y < s_CellHeight; ++s_Y)
                Array.Copy(s_Own, s_Y * s_CellWidth * 4, s_Texels, ((s_Cell.Y >> p_Mip) + s_Y) * s_RowBytes + (s_Cell.X >> p_Mip) * 4, s_CellWidth * 4);
        }

        return s_Texels;
    }
}
