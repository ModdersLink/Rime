using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Texture.Images;

/// <summary>
/// An <see cref="ITextureCodec"/> for the Frostbite texture headers, which differ in how they lay
/// their fields out but not in what the fields say. An engine's codec reads and writes its layout
/// as <see cref="Fields"/>; this checks them and maps them onto the image.
/// </summary>
public abstract class TextureHeaderCodec : ITextureCodec
{
    /// <summary>A texture header's fields, in the image's terms.</summary>
    protected sealed record Fields(
        TextureKind Kind, TexturePixelFormat Format, uint Flags,
        int Width, int Height, int Depth, int SliceCount, int MipCount, int MipBaseIndex,
        GUID ChunkId, uint[] MipSizes, uint ChainSize, uint NameHash, string Group);

    private const uint c_KnownFlags = (uint)(TextureOptions.Streaming | TextureOptions.SrgbGamma | TextureOptions.CpuResource
        | TextureOptions.OnDemandLoaded | TextureOptions.Mutable | TextureOptions.NoSkipMip | TextureOptions.StreamingAlways);

    public abstract EngineType[] GetSupportedEngines();

    public abstract IReadOnlyCollection<TexturePixelFormat> Formats { get; }

    /// <summary>The per-level size slots the header has.</summary>
    protected abstract int MipSlots { get; }

    /// <summary>What the engine pads each row of texels in its chunk to.</summary>
    protected virtual int RowAlignment => 1;

    protected abstract Fields ReadHeader(byte[] p_Header);

    /// <param name="p_Template">The header the fields that depend on how the chunk is stored come from, if any.</param>
    protected abstract byte[] WriteHeader(Fields p_Fields, byte[]? p_Template);

    public TextureImage Decode(string p_Name, byte[] p_Header, byte[] p_Chunk)
    {
        var s_Fields = ReadHeader(p_Header);
        if ((s_Fields.Flags & ~c_KnownFlags) != 0)
            throw new InvalidDataException($"A texture with flags 0x{s_Fields.Flags & ~c_KnownFlags:X} beyond the platform-independent ones.");

        var s_Image = new TextureImage
        {
            Kind = s_Fields.Kind,
            Format = s_Fields.Format,
            Options = (TextureOptions)s_Fields.Flags,
            Width = s_Fields.Width,
            Height = s_Fields.Height,
            Depth = s_Fields.Depth,
            SliceCount = s_Fields.SliceCount,
            MipCount = s_Fields.MipCount,
            MipBaseIndex = s_Fields.MipBaseIndex,
            Group = s_Fields.Group,
            ChunkId = s_Fields.ChunkId,
        };

        // A header that says something its layout does not give is refused rather than rewritten.
        var s_Expected = MipSizes(s_Image);
        for (var i = 0; i < s_Expected.Length; ++i)
        {
            if (s_Fields.MipSizes[i] != s_Expected[i])
                throw new InvalidDataException($"Mip level {i} of a {s_Image.Width}x{s_Image.Height} {s_Image.Format} {s_Image.Kind} is {s_Fields.MipSizes[i]} bytes; its layout gives {s_Expected[i]}.");
        }

        if (s_Fields.ChainSize != s_Image.ChainSize(RowAlignment))
            throw new InvalidDataException($"A texture's mip chain is {s_Fields.ChainSize} bytes; its levels add up to {s_Image.ChainSize(RowAlignment)}.");

        if (s_Fields.NameHash != RimeLib.Frostbite.Utils.HashQuickLowerCase(p_Name))
            throw new InvalidDataException($"A texture's name hash 0x{s_Fields.NameHash:X8} is not that of '{p_Name}'.");

        s_Image.Data = p_Chunk.Length == 0 ? p_Chunk : s_Image.RealignRows(p_Chunk, RowAlignment, 1);
        return s_Image;
    }

    public TextureResource Encode(TextureImage p_Image, string p_Name, byte[]? p_Template = null)
    {
        if (!Formats.Contains(p_Image.Format))
            throw new ArgumentException($"{GetType().FullName} writes no {p_Image.Format} textures.", nameof(p_Image));

        var s_Fields = new Fields(
            p_Image.Kind, p_Image.Format, (uint)p_Image.Options,
            p_Image.Width, p_Image.Height, p_Image.Depth, p_Image.SliceCount, p_Image.MipCount, p_Image.MipBaseIndex,
            p_Image.ChunkId, MipSizes(p_Image), checked((uint)p_Image.ChainSize(RowAlignment)), RimeLib.Frostbite.Utils.HashQuickLowerCase(p_Name), p_Image.Group);

        var s_Chunk = p_Image.Data.Length == 0 ? p_Image.Data : p_Image.RealignRows(p_Image.Data, 1, RowAlignment);
        return new TextureResource(WriteHeader(s_Fields, p_Template), s_Chunk);
    }

    public long ChunkSize(TextureImage p_Image) => p_Image.DataSize(RowAlignment);

    /// <summary>The header's per-level sizes: one face or slice per level, then zeros.</summary>
    private uint[] MipSizes(TextureImage p_Image)
    {
        if (p_Image.MipCount > MipSlots)
            throw new ArgumentException($"A texture of {p_Image.MipCount} mip levels; the header holds {MipSlots}.", nameof(p_Image));

        var s_Sizes = new uint[MipSlots];
        for (var i = 0; i < p_Image.MipCount; ++i)
            s_Sizes[i] = checked((uint)p_Image.MipSize(i, RowAlignment));
        return s_Sizes;
    }
}
