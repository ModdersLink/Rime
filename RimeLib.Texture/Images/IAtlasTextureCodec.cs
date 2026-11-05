namespace RimeLib.Texture.Images;

/// <summary>
/// A texture the engine packs into its particle atlas itself, with the border, in texels of its
/// first mip level, that its cell keeps around what particles sample.
/// </summary>
public sealed record AtlasTextureImage(TextureImage Image, bool IsNormalMap, float BorderWidth, float BorderHeight);

/// <summary>Reads an engine's atlas texture resource and its chunk into an <see cref="AtlasTextureImage"/>.</summary>
public interface IAtlasTextureCodec : IEngineInterface
{
    /// <param name="p_Resource">The atlas texture resource's payload.</param>
    /// <param name="p_Chunk">The chunk's bytes, or none to read the resource alone.</param>
    AtlasTextureImage Decode(byte[] p_Resource, byte[] p_Chunk);
}
