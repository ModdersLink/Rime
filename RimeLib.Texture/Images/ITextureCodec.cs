using System.Collections.Generic;

namespace RimeLib.Texture.Images;

/// <summary>
/// A texture resource's payload, the streaming chunk it names and the resource meta the engine
/// ships it with, or none where the engine's meta is not known.
/// </summary>
public sealed record TextureResource(byte[] Header, byte[] Chunk, byte[]? Meta = null);

/// <summary>
/// Reads an engine's texture header and chunk into a <see cref="TextureImage"/> and writes them back.
/// A codec refuses what it does not understand (an unknown flag, a mip size its layout does not
/// give), so nothing is dropped on the way through.
/// </summary>
public interface ITextureCodec : IEngineInterface
{
    /// <summary>The formats this engine's headers can name.</summary>
    IReadOnlyCollection<TexturePixelFormat> Formats { get; }

    /// <param name="p_Name">The texture resource's name, which the header records a hash of.</param>
    /// <param name="p_Header">The texture resource's payload.</param>
    /// <param name="p_Chunk">The streaming chunk's bytes, or none to read the header alone.</param>
    TextureImage Decode(string p_Name, byte[] p_Header, byte[] p_Chunk);

    /// <param name="p_Template">
    /// A header of the same texture whose fields that depend on how its chunk is stored are kept,
    /// where the engine has such fields. Without one they are left empty.
    /// </param>
    TextureResource Encode(TextureImage p_Image, string p_Name, byte[]? p_Template = null);

    /// <summary>The bytes this engine's chunk holds for the image.</summary>
    long ChunkSize(TextureImage p_Image);
}
