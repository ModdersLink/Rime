using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Extensions;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite2013_2.Frostbite;
using RimeLib.Frostbite.Core;
using SharpDX;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using Device = SharpDX.Direct3D11.Device;
using Resource = SharpDX.Direct3D11.Resource;

namespace RimeLib.Texture.Frostbite2013_2;

public class TextureConverter : ITextureConverter
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2013_2 };
    }

    public void ConvertToDDS(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_OutputWriter)
    {
        if (p_Resource.GetResourceType() != ResourceType.DxTexture &&
            p_Resource.GetResourceType() != ResourceType.Ps3Texture)
            throw new ArgumentException("This converter only supports DxTexture and Ps3Texture resources.", nameof(p_Resource));

        using var s_ResourceReader = p_Resource.GetReader();

        ITexture? s_Header = null;
        switch (p_Resource.GetResourceType())
        {
            case ResourceType.DxTexture:
                s_Header = new DxTexture(s_ResourceReader);
                break;
            case ResourceType.Ps3Texture:
                s_Header = new Ps3Texture(s_ResourceReader);
                break;
        }

        if (s_Header == null)
            throw new Exception("Header is null, this should never occur");


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

    public ShaderResourceView CreateTextureResourceView(IResourceObject p_Resource, IEngineMounter p_Mounter, Device p_D3DDevice)
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

        var s_TextureData = s_FullVariant.GetReader().ToArray();

        var s_DataStream = DataStream.Create(s_TextureData, true, true);

        var s_Format = DXGIFormatFromTexture(s_Header, true);

        if (s_Header.Type == TextureType.TextureType_1D)
        {
            var s_Desc = new Texture1DDescription()
            {
                ArraySize = 1,
                BindFlags = BindFlags.ShaderResource,
                Format = s_Format,
                MipLevels = s_Header.MipmapCount,
                Width = s_Header.Width,
                Usage = ResourceUsage.Default,
            };

            using var s_Texture = new Texture1D(
                p_D3DDevice,
                s_Desc,
                GetInitData(
                    s_Header.Width,
                    s_Header.Height,
                    s_Header.Depth,
                    s_Header.MipmapCount,
                    1,
                    s_Format,
                    s_DataStream.DataPointer,
                    s_DataStream.Length
                ).ToArray()
            );

            return new ShaderResourceView(
                p_D3DDevice,
                s_Texture,
                new ShaderResourceViewDescription()
                {
                    Format = s_Format,
                    Dimension = ShaderResourceViewDimension.Texture1D,
                    Texture1D = new ShaderResourceViewDescription.Texture1DResource()
                    {
                        MipLevels = s_Header.MipmapCount,
                    }
                }
            );
        }

        if (s_Header.Type == TextureType.TextureType_2D)
        {
            var s_Desc = new Texture2DDescription()
            {
                Width = s_Header.Width,
                Height = s_Header.Height,
                MipLevels = s_Header.MipmapCount,
                ArraySize = s_Header.Depth,
                BindFlags = BindFlags.ShaderResource,
                Format = s_Format,
                Usage = ResourceUsage.Default,
                SampleDescription = new SampleDescription(1, 0)
            };

            using var s_Texture = new Texture2D(
                p_D3DDevice,
                s_Desc,
                GetInitData(
                    s_Header.Width,
                    s_Header.Height,
                    1,
                    s_Header.MipmapCount,
                    s_Header.Depth,
                    s_Format,
                    s_DataStream.DataPointer,
                    s_DataStream.Length
                ).ToArray()
            );

            return new ShaderResourceView(
                p_D3DDevice,
                s_Texture,
                new ShaderResourceViewDescription()
                {
                    Format = s_Format,
                    Dimension = ShaderResourceViewDimension.Texture2D,
                    Texture2D = new ShaderResourceViewDescription.Texture2DResource()
                    {
                        MipLevels = s_Header.MipmapCount,
                    }
                }
            );
        }

        if (s_Header.Type == TextureType.TextureType_3D)
        {
            var s_Desc = new Texture3DDescription()
            {
                Depth = s_Header.Depth,
                BindFlags = BindFlags.ShaderResource,
                Format = s_Format,
                MipLevels = s_Header.MipmapCount,
                Width = s_Header.Width,
                Height = s_Header.Height,
                Usage = ResourceUsage.Default,
            };

            using var s_Texture = new Texture3D(
                p_D3DDevice,
                s_Desc,
                GetInitData(
                    s_Header.Width,
                    s_Header.Height,
                    s_Header.Depth,
                    s_Header.MipmapCount,
                    s_Header.Depth,
                    s_Format,
                    s_DataStream.DataPointer,
                    s_DataStream.Length
                ).ToArray()
            );

            return new ShaderResourceView(
                p_D3DDevice,
                s_Texture,
                new ShaderResourceViewDescription()
                {
                    Format = s_Format,
                    Dimension = ShaderResourceViewDimension.Texture3D,
                    Texture3D = new ShaderResourceViewDescription.Texture3DResource()
                    {
                        MipLevels = s_Header.MipmapCount,
                    }
                }
            );
        }

        throw new Exception($"Unsupported texture type {s_Header.Type}.");
    }

    public RawTextureData? GetRawTextureData(IResourceObject p_Resource, IEngineMounter p_Mounter)
    {
        using var s_ResourceReader = p_Resource.GetReader();
        var s_Header = new DxTexture(s_ResourceReader);

        if (!p_Mounter.TryGetChunk(s_Header.StreamingChunkId, out var s_Chunk) || s_Chunk == null)
            return null;

        var s_FullVariant = s_Chunk.Variants.FirstOrDefault(p_Variant => p_Variant.GetLogicalOffset() == 0) ?? s_Chunk.FirstVariant;
        if (s_FullVariant == null) return null;

        using var s_ChunkReader = s_FullVariant.GetReader();
        var s_RawData = s_ChunkReader.ToArray();

        byte[]? s_Pixels = s_Header.Format switch
        {
            TextureFormat.TextureFormat_DXT1 or TextureFormat.TextureFormat_NormalDXT1 => DXTDecoder.DecodeDXT1Texture(s_Header.Width, s_Header.Height, s_RawData, false),
            TextureFormat.TextureFormat_DXT3 => DXTDecoder.DecodeDXT23Texture(s_Header.Width, s_Header.Height, s_RawData, false),
            TextureFormat.TextureFormat_DXT5 => DXTDecoder.DecodeDXT45Texture(s_Header.Width, s_Header.Height, s_RawData, false),
            TextureFormat.TextureFormat_DXT5A => DXTDecoder.DecodeBC4(s_Header.Width, s_Header.Height, s_RawData),
            TextureFormat.TextureFormat_NormalDXN => DXTDecoder.DecodeBC5Texture(s_Header.Width, s_Header.Height, s_RawData, false),
            TextureFormat.TextureFormat_ARGB8888 => DXTDecoder.DecodeARGB8888(s_Header.Width, s_Header.Height, s_RawData),
            TextureFormat.TextureFormat_L8 => DXTDecoder.DecodeL8(s_Header.Width, s_Header.Height, s_RawData),
            _ => null
        };

        if (s_Pixels == null) return null;

        return new RawTextureData
        {
            Width = s_Header.Width,
            Height = s_Header.Height,
            Pixels = s_Pixels,
            FormatName = s_Header.Format.ToString()
        };
    }

    public GUID GetTextureChunkId(IResourceObject p_Resource)
    {
        if (p_Resource.GetResourceType() != ResourceType.DxTexture && p_Resource.GetResourceType() != ResourceType.Ps3Texture)
            throw new ArgumentException("This converter only supports DxTexture and Ps3Texture resources.", nameof(p_Resource));

        using var s_ResourceReader = p_Resource.GetReader();
        ITexture? s_Header = null;
        if (p_Resource.GetResourceType() == ResourceType.DxTexture)
            s_Header = new DxTexture(s_ResourceReader);
        else if (p_Resource.GetResourceType() == ResourceType.Ps3Texture)
            s_Header = new Ps3Texture(s_ResourceReader);

        if (s_Header != null)
            return s_Header.StreamingChunkId;

        return GUID.Empty;
    }

    static void GetSurfaceInfo(
        int p_Width,
        int p_Height,
        Format p_Format,
        out int p_OutNumBytes,
        out int p_OutRowBytes,
        out int p_OutNumRows
    )
    {
        int s_RowBytes;
        int s_NumRows;

        var s_IsBc = false;
        var s_IsPacked = false;
        var s_BcNumBytesPerBlock = 0;

        switch (p_Format)
        {
            case Format.BC1_Typeless:
            case Format.BC1_UNorm:
            case Format.BC1_UNorm_SRgb:
            case Format.BC4_Typeless:
            case Format.BC4_UNorm:
            case Format.BC4_SNorm:
                s_IsBc = true;
                s_BcNumBytesPerBlock = 8;
                break;

            case Format.BC2_Typeless:
            case Format.BC2_UNorm_SRgb:
            case Format.BC2_UNorm:
            case Format.BC3_Typeless:
            case Format.BC3_UNorm:
            case Format.BC3_UNorm_SRgb:
            case Format.BC5_Typeless:
            case Format.BC5_UNorm:
            case Format.BC5_SNorm:
            case Format.BC6H_Typeless:
            case Format.BC6H_Uf16:
            case Format.BC6H_Sf16:
            case Format.BC7_Typeless:
            case Format.BC7_UNorm:
            case Format.BC7_UNorm_SRgb:
                s_IsBc = true;
                s_BcNumBytesPerBlock = 16;
                break;

            case Format.R8G8_B8G8_UNorm:
            case Format.G8R8_G8B8_UNorm:
                s_IsPacked = true;
                break;
        }

        if (s_IsBc)
        {
            var s_NumBlocksWide = 0;

            if (p_Width > 0)
                s_NumBlocksWide = System.Math.Max(1, (p_Width + 3) / 4);

            var s_NumBlocksHigh = 0;

            if (p_Height > 0)
                s_NumBlocksHigh = System.Math.Max(1, (p_Height + 3) / 4);

            s_RowBytes = s_NumBlocksWide * s_BcNumBytesPerBlock;
            s_NumRows = s_NumBlocksHigh;
        }
        else if (s_IsPacked)
        {
            s_RowBytes = ((p_Width + 1) >> 1) * 4;
            s_NumRows = p_Height;
        }
        else
        {
            var s_Bpp = BitsPerPixel(p_Format);
            s_RowBytes = (p_Width * s_Bpp + 7) / 8;
            s_NumRows = p_Height;
        }

        var s_NumBytes = s_RowBytes * s_NumRows;

        p_OutNumBytes = s_NumBytes;
        p_OutRowBytes = s_RowBytes;
        p_OutNumRows = s_NumRows;
    }

    static int BitsPerPixel(Format p_Format)
    {
        switch (p_Format)
        {
            case Format.R32G32B32A32_Typeless:
            case Format.R32G32B32A32_Float:
            case Format.R32G32B32A32_UInt:
            case Format.R32G32B32A32_SInt:
                return 128;

            case Format.R32G32B32_Typeless:
            case Format.R32G32B32_Float:
            case Format.R32G32B32_UInt:
            case Format.R32G32B32_SInt:
                return 96;

            case Format.R16G16B16A16_Typeless:
            case Format.R16G16B16A16_Float:
            case Format.R16G16B16A16_UNorm:
            case Format.R16G16B16A16_UInt:
            case Format.R16G16B16A16_SInt:
            case Format.R16G16B16A16_SNorm:
            case Format.R32G32_Typeless:
            case Format.R32G32_Float:
            case Format.R32G32_UInt:
            case Format.R32G32_SInt:
            case Format.R32G8X24_Typeless:
            case Format.D32_Float_S8X24_UInt:
            case Format.R32_Float_X8X24_Typeless:
            case Format.X32_Typeless_G8X24_UInt:
                return 64;

            case Format.R10G10B10A2_Typeless:
            case Format.R10G10B10A2_UNorm:
            case Format.R10G10B10A2_UInt:
            case Format.R11G11B10_Float:
            case Format.R8G8B8A8_Typeless:
            case Format.R8G8B8A8_UNorm:
            case Format.R8G8B8A8_UNorm_SRgb:
            case Format.R8G8B8A8_UInt:
            case Format.R8G8B8A8_SNorm:
            case Format.R8G8B8A8_SInt:
            case Format.R16G16_Typeless:
            case Format.R16G16_Float:
            case Format.R16G16_UNorm:
            case Format.R16G16_UInt:
            case Format.R16G16_SNorm:
            case Format.R16G16_SInt:
            case Format.R32_Typeless:
            case Format.D32_Float:
            case Format.R32_Float:
            case Format.R32_UInt:
            case Format.R32_SInt:
            case Format.R24G8_Typeless:
            case Format.D24_UNorm_S8_UInt:
            case Format.R24_UNorm_X8_Typeless:
            case Format.X24_Typeless_G8_UInt:
            case Format.R9G9B9E5_Sharedexp:
            case Format.R8G8_B8G8_UNorm:
            case Format.G8R8_G8B8_UNorm:
            case Format.B8G8R8A8_UNorm:
            case Format.B8G8R8X8_UNorm:
            case Format.R10G10B10_Xr_Bias_A2_UNorm:
            case Format.B8G8R8A8_Typeless:
            case Format.B8G8R8A8_UNorm_SRgb:
            case Format.B8G8R8X8_Typeless:
            case Format.B8G8R8X8_UNorm_SRgb:
                return 32;

            case Format.R8G8_Typeless:
            case Format.R8G8_UNorm:
            case Format.R8G8_UInt:
            case Format.R8G8_SNorm:
            case Format.R8G8_SInt:
            case Format.R16_Typeless:
            case Format.R16_Float:
            case Format.D16_UNorm:
            case Format.R16_UNorm:
            case Format.R16_UInt:
            case Format.R16_SNorm:
            case Format.R16_SInt:
            case Format.B5G6R5_UNorm:
            case Format.B5G5R5A1_UNorm:
            case Format.B4G4R4A4_UNorm:
                return 16;

            case Format.R8_Typeless:
            case Format.R8_UNorm:
            case Format.R8_UInt:
            case Format.R8_SNorm:
            case Format.R8_SInt:
            case Format.A8_UNorm:
                return 8;

            case Format.R1_UNorm:
                return 1;

            case Format.BC1_Typeless:
            case Format.BC1_UNorm:
            case Format.BC1_UNorm_SRgb:
            case Format.BC4_Typeless:
            case Format.BC4_UNorm:
            case Format.BC4_SNorm:
                return 4;

            case Format.BC2_Typeless:
            case Format.BC2_UNorm:
            case Format.BC2_UNorm_SRgb:
            case Format.BC3_Typeless:
            case Format.BC3_UNorm:
            case Format.BC3_UNorm_SRgb:
            case Format.BC5_Typeless:
            case Format.BC5_UNorm:
            case Format.BC5_SNorm:
            case Format.BC6H_Typeless:
            case Format.BC6H_Uf16:
            case Format.BC6H_Sf16:
            case Format.BC7_Typeless:
            case Format.BC7_UNorm:
            case Format.BC7_UNorm_SRgb:
                return 8;

            default:
                return 0;
        }
    }

    private static IEnumerable<DataBox> GetInitData(
        int p_Width,
        int p_Height,
        int p_Depth,
        int p_MipCount,
        int p_ArraySize,
        Format p_Format,
        IntPtr p_Data,
        long p_DataSize
    )
    {
        var s_DataPtr = p_Data;
        var s_DataEnd = p_Data.ToInt64() + p_DataSize;

        for (var i = 0; i < p_ArraySize; ++i)
        {
            var s_Width = p_Width;
            var s_Height = p_Height;
            var s_Depth = p_Depth;

            for (var j = 0; j < p_MipCount; ++j)
            {
                GetSurfaceInfo(s_Width, s_Height, p_Format, out var s_NumBytes, out var s_RowBytes, out _);

                yield return new DataBox(s_DataPtr, s_RowBytes, s_NumBytes);

                if ((s_DataPtr + (s_NumBytes * s_Depth)).ToInt64() > s_DataEnd)
                    throw new Exception("Texture data was out of bounds.");

                s_DataPtr += s_NumBytes * s_Depth;

                s_Width >>= 1;
                s_Height >>= 1;
                s_Depth >>= 1;

                if (s_Width == 0)
                    s_Width = 1;

                if (s_Height == 0)
                    s_Height = 1;

                if (s_Depth == 0)
                    s_Depth = 1;
            }
        }
    }

    private static DDSCaps CapsFromTexture(ITexture p_Texture)
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

    private static DDSCaps2 Caps2FromTexture(ITexture p_Texture)
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

    private static DDSResoruceDimension ResourceDimensionFromTexture(ITexture p_Texture)
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

    private static DDSMiscFlag1 MiscFlag1FromTexture(ITexture p_Texture)
    {
        switch (p_Texture.Type)
        {
            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                return DDSMiscFlag1.TextureCube;
        }

        return 0;
    }

    private static uint ArraySizeFromTexture(ITexture p_Texture)
    {
        switch (p_Texture.Type)
        {
            case TextureType.TextureType_Cube:
            case TextureType.TextureType_CubeArray:
                return 6;
        }

        return 0;
    }

    private static DDSFlags DDSFlagsFromTexture(ITexture p_Texture)
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

    private static Format DXGIFormatFromTexture(ITexture p_Texture, bool p_IgnoreSrgb = false)
    {
        var s_IsSrgb = !p_IgnoreSrgb && (p_Texture.Flags & TextureFlags.SrgbGamma) != 0;

        return p_Texture.Format switch
        {
            TextureFormat.TextureFormat_DXT1 or TextureFormat.TextureFormat_NormalDXT1 => s_IsSrgb
                ? Format.BC1_UNorm_SRgb
                : Format.BC1_UNorm,
            TextureFormat.TextureFormat_DXT3 => s_IsSrgb ? Format.BC2_UNorm_SRgb : Format.BC2_UNorm,
            TextureFormat.TextureFormat_DXT5 or TextureFormat.TextureFormat_NormalDXT5
                or TextureFormat.TextureFormat_NormalDXT5RGA => s_IsSrgb
                    ? Format.BC3_UNorm_SRgb
                    : Format.BC3_UNorm,
            TextureFormat.TextureFormat_DXT5A => Format.BC4_UNorm,
            TextureFormat.TextureFormat_DXN or TextureFormat.TextureFormat_NormalDXN => Format.BC5_UNorm,
            TextureFormat.TextureFormat_RGB565 => Format.B5G6R5_UNorm,
            TextureFormat.TextureFormat_ARGB1555 => Format.B5G5R5A1_UNorm,
            TextureFormat.TextureFormat_ARGB4444 => Format.B4G4R4A4_UNorm,
            TextureFormat.TextureFormat_ARGB8888 => s_IsSrgb
                ? Format.R8G8B8A8_UNorm_SRgb
                : Format.R8G8B8A8_UNorm,
            TextureFormat.TextureFormat_L8 => Format.R8_UNorm,
            TextureFormat.TextureFormat_L16 or TextureFormat.TextureFormat_D16 => Format.R16_UNorm,
            TextureFormat.TextureFormat_ABGR16 => Format.R16G16B16A16_UNorm,
            TextureFormat.TextureFormat_ABGR16F => Format.R16G16B16A16_Float,
            TextureFormat.TextureFormat_ABGR32F => Format.R32G32B32A32_Float,
            TextureFormat.TextureFormat_R16F => Format.R16_Float,
            TextureFormat.TextureFormat_R32F => Format.D32_Float,
            TextureFormat.TextureFormat_GR16 => Format.R16G16_UNorm,
            TextureFormat.TextureFormat_GR16F => Format.R16G16_Float,
            TextureFormat.TextureFormat_D24S8 => Format.D24_UNorm_S8_UInt,
            TextureFormat.TextureFormat_D32F => Format.D32_Float,
            TextureFormat.TextureFormat_ABGR32 => Format.R32G32B32A32_UInt,
            TextureFormat.TextureFormat_GR32F => Format.R32G32_Float,
            TextureFormat.TextureFormat_A2R10G10B10 => Format.R10G10B10A2_UNorm,
            _ => Format.Unknown
        };
    }

    private static DDSPixelFormat PixelFormatFromTexture(ITexture p_Texture)
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

    private static DDSHeader GenerateDDSHeader(ITexture p_Texture)
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
