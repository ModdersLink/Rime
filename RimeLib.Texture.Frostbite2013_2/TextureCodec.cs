using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Texture.Frostbite2013_2.Frostbite;
using RimeLib.Texture.Images;

namespace RimeLib.Texture.Frostbite2013_2;

/// <summary>
/// Frostbite 2013.2's texture header as a <see cref="TextureImage"/>. Its two mip offsets are where
/// the second and third mip levels start in the compressed chunk, so they come from the template:
/// only whoever compresses the chunk knows them.
/// </summary>
public class TextureCodec : TextureHeaderCodec
{
    private static readonly Dictionary<TextureFormat, TexturePixelFormat> s_ToImage = new()
    {
        [TextureFormat.TextureFormat_DXT1] = TexturePixelFormat.Dxt1,
        [TextureFormat.TextureFormat_DXT1A] = TexturePixelFormat.Dxt1A,
        [TextureFormat.TextureFormat_DXT3] = TexturePixelFormat.Dxt3,
        [TextureFormat.TextureFormat_DXT5] = TexturePixelFormat.Dxt5,
        [TextureFormat.TextureFormat_DXT5A] = TexturePixelFormat.Dxt5A,
        [TextureFormat.TextureFormat_DXN] = TexturePixelFormat.Dxn,
        [TextureFormat.TextureFormat_BC7] = TexturePixelFormat.Bc7,
        [TextureFormat.TextureFormat_RGB565] = TexturePixelFormat.Rgb565,
        [TextureFormat.TextureFormat_RGB888] = TexturePixelFormat.Rgb888,
        [TextureFormat.TextureFormat_ARGB1555] = TexturePixelFormat.Argb1555,
        [TextureFormat.TextureFormat_ARGB4444] = TexturePixelFormat.Argb4444,
        [TextureFormat.TextureFormat_ARGB8888] = TexturePixelFormat.Argb8888,
        [TextureFormat.TextureFormat_L8] = TexturePixelFormat.L8,
        [TextureFormat.TextureFormat_L16] = TexturePixelFormat.L16,
        [TextureFormat.TextureFormat_ABGR16] = TexturePixelFormat.Abgr16,
        [TextureFormat.TextureFormat_ABGR16F] = TexturePixelFormat.Abgr16F,
        [TextureFormat.TextureFormat_ABGR32F] = TexturePixelFormat.Abgr32F,
        [TextureFormat.TextureFormat_R16F] = TexturePixelFormat.R16F,
        [TextureFormat.TextureFormat_R32F] = TexturePixelFormat.R32F,
        [TextureFormat.TextureFormat_NormalDXN] = TexturePixelFormat.NormalDxn,
        [TextureFormat.TextureFormat_NormalDXT1] = TexturePixelFormat.NormalDxt1,
        [TextureFormat.TextureFormat_NormalDXT5] = TexturePixelFormat.NormalDxt5,
        [TextureFormat.TextureFormat_NormalDXT5RGA] = TexturePixelFormat.NormalDxt5Rga,
        [TextureFormat.TextureFormat_RG8] = TexturePixelFormat.Rg8,
        [TextureFormat.TextureFormat_GR16] = TexturePixelFormat.Gr16,
        [TextureFormat.TextureFormat_GR16F] = TexturePixelFormat.Gr16F,
        [TextureFormat.TextureFormat_D16] = TexturePixelFormat.D16,
        [TextureFormat.TextureFormat_D24S8] = TexturePixelFormat.D24S8,
        [TextureFormat.TextureFormat_D24FS8] = TexturePixelFormat.D24FS8,
        [TextureFormat.TextureFormat_D32F] = TexturePixelFormat.D32F,
        [TextureFormat.TextureFormat_D32FS8] = TexturePixelFormat.D32FS8,
        [TextureFormat.TextureFormat_S8] = TexturePixelFormat.S8,
        [TextureFormat.TextureFormat_ABGR32] = TexturePixelFormat.Abgr32,
        [TextureFormat.TextureFormat_GR32F] = TexturePixelFormat.Gr32F,
        [TextureFormat.TextureFormat_A2R10G10B10] = TexturePixelFormat.A2R10G10B10,
        [TextureFormat.TextureFormat_R11G11B10F] = TexturePixelFormat.R11G11B10F,
        [TextureFormat.TextureFormat_ABGR16_SNORM] = TexturePixelFormat.Abgr16Snorm,
        [TextureFormat.TextureFormat_ABGR16_UINT] = TexturePixelFormat.Abgr16Uint,
        [TextureFormat.TextureFormat_L16_UINT] = TexturePixelFormat.L16Uint,
        [TextureFormat.TextureFormat_L32] = TexturePixelFormat.L32,
        [TextureFormat.TextureFormat_GR16_UINT] = TexturePixelFormat.Gr16Uint,
        [TextureFormat.TextureFormat_GR32_UINT] = TexturePixelFormat.Gr32Uint,
        [TextureFormat.TextureFormat_R9G9B9E5F] = TexturePixelFormat.R9G9B9E5F,
    };

    private static readonly Dictionary<TexturePixelFormat, TextureFormat> s_ToEngine = s_ToImage.ToDictionary(p_E => p_E.Value, p_E => p_E.Key);

    private const int c_HeaderSize = 128;

    public override EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public override IReadOnlyCollection<TexturePixelFormat> Formats => s_ToEngine.Keys;

    protected override int MipSlots => 15;

    private static DxTexture Read(byte[] p_Header)
    {
        if (p_Header.Length != c_HeaderSize)
            throw new InvalidDataException($"A texture header is {c_HeaderSize} bytes, not {p_Header.Length}.");

        var s_Header = new DxTexture();
        s_Header.Deserialize(p_Header);
        return s_Header;
    }

    protected override Fields ReadHeader(byte[] p_Header)
    {
        var s_Header = Read(p_Header);
        return new Fields(
            (TextureKind)s_Header.Type, s_ToImage[s_Header.Format], (uint)s_Header.Flags,
            s_Header.Width, s_Header.Height, s_Header.Depth, s_Header.SliceCount, s_Header.MipmapCount, s_Header.MipmapBaseIndex,
            s_Header.StreamingChunkId, s_Header.MipmapSizes, s_Header.MipmapChainSize, s_Header.ResourceNameHash, s_Header.TextureGroup);
    }

    protected override byte[] WriteHeader(Fields p_Fields, byte[]? p_Template)
    {
        var s_Header = new DxTexture
        {
            MipOffsets = p_Template != null ? Read(p_Template).MipOffsets : new uint[2],
            Type = (TextureType)p_Fields.Kind,
            Format = s_ToEngine[p_Fields.Format],
            Flags = (TextureFlags)checked((ushort)p_Fields.Flags),
            Width = checked((short)p_Fields.Width),
            Height = checked((short)p_Fields.Height),
            Depth = checked((short)p_Fields.Depth),
            SliceCount = checked((short)p_Fields.SliceCount),
            MipmapCount = checked((byte)p_Fields.MipCount),
            MipmapBaseIndex = checked((byte)p_Fields.MipBaseIndex),
            StreamingChunkId = p_Fields.ChunkId,
            MipmapSizes = p_Fields.MipSizes,
            MipmapChainSize = p_Fields.ChainSize,
            ResourceNameHash = p_Fields.NameHash,
            TextureGroup = p_Fields.Group,
        };

        s_Header.Serialize(out var s_Data);
        return s_Data!;
    }
}
