using System;
using System.Linq;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite2_0.Frostbite;

namespace RimeLib.Texture.Frostbite2_0;

public class TextureConverter : ITextureConverter
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2_0 };
    }

    public void ConvertToDDS(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_OutputWriter)
    {
        if (p_Resource.GetResourceType() != ResourceType.DxTexture)
            throw new ArgumentException("This converter only supports DxTexture resources.", nameof(p_Resource));

        using var s_ResourceReader = p_Resource.GetReader();
        var s_Header = new DxTexture(s_ResourceReader);
        
        // Try to find the chunk for this texture.
        if (!p_Mounter.TryGetChunk(s_Header.StreamingChunkId, out var s_Chunk))
            throw new Exception($"Could not find chunk '{s_Header.StreamingChunkId}' bound to this texture resource.");
        
        // Try to find a variant with a 0 logical offset.
        // That's because chunks with a non-0 offset only contain partial data.
        var s_FullVariant = s_Chunk.Variants.FirstOrDefault(p_Variant => p_Variant.GetLogicalOffset() == 0);
        
        if (s_FullVariant == null)
            throw new Exception($"Could not find full chunk '{s_Header.StreamingChunkId}'. Maybe you haven't mounted a catalog or a chunk superbundle?");
        
        var s_DDSHeader = GenerateDDSHeader(s_Header);

        s_DDSHeader.Serialize(p_OutputWriter);
        s_FullVariant.GetReader().CopyTo(p_OutputWriter);
    }

    private static DDSCaps CapsFromTexture(DxTexture p_Texture)
    {
        var s_Caps = DDSCaps.Texture;
        
        switch (p_Texture.Type)
        {
            case TextureType.TextureType_1D:
            case TextureType.TextureType_1DArray:
            case TextureType.TextureType_2D:
            case TextureType.TextureType_2DArray:
            case TextureType.TextureType_3D:
            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                s_Caps |= DDSCaps.Complex;
                break;
        }

        if (p_Texture.MipmapCount > 1)
            s_Caps |= DDSCaps.Mipmap;

        return s_Caps;
    }

    private static DDSCaps2 Caps2FromTexture(DxTexture p_Texture)
    {
        DDSCaps2 s_Caps = 0;
        
        switch (p_Texture.Type)
        {
            case TextureType.TextureType_3D:
                s_Caps |= DDSCaps2.Volume;
                break;
            
            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                s_Caps |= DDSCaps2.AllFaces;
                break;
        }

        return s_Caps;
    }

    private static DDSResoruceDimension ResourceDimensionFromTexture(DxTexture p_Texture)
    {
        switch (p_Texture.Type)
        {
            case TextureType.TextureType_1D:
            case TextureType.TextureType_1DArray:
                return DDSResoruceDimension.Texture1D;
            
            case TextureType.TextureType_2D:
            case TextureType.TextureType_2DArray:
                return DDSResoruceDimension.Texture2D;

            case TextureType.TextureType_3D:
                return DDSResoruceDimension.Texture3D;

            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                return DDSResoruceDimension.Texture2D;
        }

        return 0;
    }

    private static DDSMiscFlag1 MiscFlag1FromTexture(DxTexture p_Texture)
    {
        switch (p_Texture.Type)
        {
            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                return DDSMiscFlag1.TextureCube;
        }

        return 0;
    }

    private static uint ArraySizeFromTexture(DxTexture p_Texture)
    {
        switch (p_Texture.Type)
        {
            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                return 6;
        }

        return 0;
    }

    private static DDSFlags DDSFlagsFromTexture(DxTexture p_Texture)
    {
        // Start with the required flags for all textures
        var s_Flags = DDSFlags.Caps | DDSFlags.Height | DDSFlags.Width | DDSFlags.PixelFormat;

        // Set flag if texture is not compressed
        if (!TextureUtils.IsCompressed(p_Texture.Format))
            s_Flags |= DDSFlags.Pitch;
        else
            s_Flags |= DDSFlags.LinearSize;

        // Check to see if we have any mipmaps
        if (p_Texture.MipmapCount > 1)
            s_Flags |= DDSFlags.MipmapCount;

        if (p_Texture.Depth > 1)
            s_Flags |= DDSFlags.Depth;

        if (p_Texture.Flags.HasFlag(TextureFlags.SrgbGamma))
            s_Flags |= DDSFlags.Srgb;

        return s_Flags;
    }

    private static DXGIFormat DXGIFormatFromTexture(DxTexture p_Texture)
    {
        var s_IsSrgb = (p_Texture.Flags & TextureFlags.SrgbGamma) != 0;

        return p_Texture.Format switch
        {
            TextureFormat.TextureFormat_DXT1 or TextureFormat.TextureFormat_NormalDXT1 => s_IsSrgb
                ? DXGIFormat.BC1_UNORM_SRGB
                : DXGIFormat.BC1_UNORM,
            TextureFormat.TextureFormat_DXT3 => s_IsSrgb ? DXGIFormat.BC2_UNORM_SRGB : DXGIFormat.BC2_UNORM,
            TextureFormat.TextureFormat_DXT5 or TextureFormat.TextureFormat_NormalDXT5
                or TextureFormat.TextureFormat_NormalDXT5RGA => s_IsSrgb
                    ? DXGIFormat.BC3_UNORM_SRGB
                    : DXGIFormat.BC3_UNORM,
            TextureFormat.TextureFormat_DXT5A => DXGIFormat.BC4_UNORM,
            TextureFormat.TextureFormat_DXN or TextureFormat.TextureFormat_NormalDXN => DXGIFormat.BC5_UNORM,
            TextureFormat.TextureFormat_RGB565 => DXGIFormat.B5G6R5_UNORM,
            TextureFormat.TextureFormat_ARGB1555 => DXGIFormat.B5G5R5A1_UNORM,
            TextureFormat.TextureFormat_ARGB4444 => DXGIFormat.B4G4R4A4_UNORM,
            TextureFormat.TextureFormat_ARGB8888 => s_IsSrgb
                ? DXGIFormat.R8G8B8A8_UNORM_SRGB
                : DXGIFormat.R8G8B8A8_UNORM,
            TextureFormat.TextureFormat_L8 => DXGIFormat.R8_UNORM,
            TextureFormat.TextureFormat_L16 or TextureFormat.TextureFormat_D16 => DXGIFormat.R16_UNORM,
            TextureFormat.TextureFormat_ABGR16 => DXGIFormat.R16G16B16A16_UNORM,
            TextureFormat.TextureFormat_ABGR16F => DXGIFormat.R16G16B16A16_FLOAT,
            TextureFormat.TextureFormat_ABGR32F => DXGIFormat.R32G32B32A32_FLOAT,
            TextureFormat.TextureFormat_R16F => DXGIFormat.R16_FLOAT,
            TextureFormat.TextureFormat_R32F => DXGIFormat.D32_FLOAT,
            TextureFormat.TextureFormat_GR16 => DXGIFormat.R16G16_UNORM,
            TextureFormat.TextureFormat_GR16F => DXGIFormat.R16G16_FLOAT,
            TextureFormat.TextureFormat_D24S8 => DXGIFormat.D24_UNORM_S8_UINT,
            TextureFormat.TextureFormat_D32F => DXGIFormat.D32_FLOAT,
            TextureFormat.TextureFormat_ABGR32 => DXGIFormat.R32G32B32A32_UINT,
            TextureFormat.TextureFormat_GR32F => DXGIFormat.R32G32_FLOAT,
            TextureFormat.TextureFormat_A2R10G10B10 => DXGIFormat.R10G10B10A2_UNORM,
            _ => DXGIFormat.UNKNOWN
        };
    }

    private static DDSPixelFormat PixelFormatFromTexture(DxTexture p_Texture)
    {
        if (TextureUtils.c_DDSFormatMap.TryGetValue(p_Texture.Format, out var s_Format))
            return s_Format;

        return new DDSPixelFormat
        {
            Size = 32,
            Flags = 0,
            FourCC = 0,
            RGBBitCount = 0,
            ABitMask = 0,
            BBitMask = 0,
            GBitMask = 0,
            RBitMask = 0
        };
    }

    private static DDSHeader GenerateDDSHeader(DxTexture p_Texture)
    {
        var s_DXGIFormat = DXGIFormatFromTexture(p_Texture);
        var s_PixelFormat = PixelFormatFromTexture(p_Texture);

        DDSDX10Header? s_Dx10Header = null;

        if (TextureUtils.c_DDSFormatMap.TryGetValue(p_Texture.Format, out var s_Format) && s_Format.FourCC == DDSUtils.MakeFourCC("DX10"))
        {
            s_Dx10Header = new DDSDX10Header
            {
                DxgiFormat = s_DXGIFormat,
                ResourceDimension = ResourceDimensionFromTexture(p_Texture),
                MiscFlag = MiscFlag1FromTexture(p_Texture),
                ArraySize = ArraySizeFromTexture(p_Texture),
                MiscFlags2 = 0,
            };
        }

        DDSUtils.ComputePitch(
            s_DXGIFormat,
            p_Texture.Width,
            p_Texture.Height,
            out var s_RowPitch,
            out var s_SlicePitch,
            DDSUtils.CPFLAGS.NONE
        );

        return new DDSHeader
        {
            Magic = DDSHeader.c_DDSMagic,
            // https://docs.microsoft.com/en-us/windows/win32/direct3ddds/dds-header
            Flags = DDSFlagsFromTexture(p_Texture),
            Height = (uint)p_Texture.Height,
            Width = (uint)p_Texture.Width,
            PitchOrLinearSize =
                (uint)(TextureUtils.IsCompressed(p_Texture.Format) ? s_SlicePitch : s_RowPitch), // TODO: Verify
            Depth = (uint)p_Texture.Depth,
            MipMapCount = p_Texture.MipmapCount,
            Reserved = new uint[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, DDSUtils.MakeFourCC("RIME") },
            PixelFormat = s_PixelFormat,
            Caps = CapsFromTexture(p_Texture),
            Caps2 = Caps2FromTexture(p_Texture),
            Caps3 = 0,
            Caps4 = 0,
            Reserved2 = 0,
            Dx10Header = s_Dx10Header,
        };
    }
}
