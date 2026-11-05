using System.IO;
using RimeLib.Frostbite;
using RimeLib.Texture.Frostbite2013_2.Frostbite;
using RimeLib.Texture.Images;

namespace RimeLib.Texture.Frostbite2013_2;

/// <summary>
/// Frostbite 2013.2's atlas texture: BC3 texels in a chunk, each mip level after the other down to
/// the one whose smaller side is 4 texels.
/// </summary>
public class AtlasTextureCodec : IAtlasTextureCodec
{
    private const int c_SmallestSide = 4;

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public AtlasTextureImage Decode(byte[] p_Resource, byte[] p_Chunk)
    {
        var s_Header = new AtlasTexture();
        s_Header.Deserialize(p_Resource);
        if ((s_Header.Flags & ~AtlasTexture.NormalMapFlag) != 0 || s_Header.Unused != 0)
            throw new InvalidDataException($"An atlas texture with flags {s_Header.Flags} and {s_Header.Unused} in its unused field.");

        var s_MipCount = 1;
        while (System.Math.Min(s_Header.Width, s_Header.Height) >> s_MipCount >= c_SmallestSide)
            ++s_MipCount;

        var s_Image = new TextureImage
        {
            Kind = TextureKind.Texture2D,
            Format = TexturePixelFormat.Dxt5,
            Width = s_Header.Width,
            Height = s_Header.Height,
            MipCount = s_MipCount,
            ChunkId = s_Header.ChunkId,
            Data = p_Chunk,
        };

        if (p_Chunk.Length != 0 && p_Chunk.Length != s_Image.DataSize())
            throw new InvalidDataException($"A {s_Header.Width}x{s_Header.Height} atlas texture's chunk is {s_Image.DataSize()} bytes, not {p_Chunk.Length}.");

        return new AtlasTextureImage(s_Image, (s_Header.Flags & AtlasTexture.NormalMapFlag) != 0, s_Header.BorderWidth, s_Header.BorderHeight);
    }
}
