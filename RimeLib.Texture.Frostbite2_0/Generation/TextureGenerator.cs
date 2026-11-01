using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite2_0.Frostbite;
using RimeLib.Texture.Generation;
using RimeLib.Utils;
using SharpDX.DXGI;

namespace RimeLib.Texture.Frostbite2_0.Generation;

public class TextureGenerator : ITextureGenerator
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2_0 };
    }

    public void GenerateFromDDS(
        RimeReader p_DDSReader,
        TextureAttributes p_Attributes,
        RimeWriter p_ResourceWriter,
        out Dictionary<GUID, Stream> p_GeneratedChunks
    )
    {
        var s_DDSHeader = new DDSHeader(p_DDSReader);

        var s_DxTexture = DxTextureFromDDS(s_DDSHeader, p_Attributes, 0, 1);
        s_DxTexture.Serialize(p_ResourceWriter);
        
        // The DDS reader should be at the start of the texture data now, since
        // we have already read the header. Copy the rest of the data to a memory
        // stream for the chunk.
        var s_ChunkData = new MemoryStream();
        p_DDSReader.CopyTo(s_ChunkData);
        s_ChunkData.Seek(0, SeekOrigin.Begin);

        p_GeneratedChunks = new Dictionary<GUID, Stream>
        {
            { s_DxTexture.StreamingChunkId, s_ChunkData },
        };
    }

    public ResourceType GetTargetResourceType()
    {
        return ResourceType.DxTexture;
    }

    private static TextureType TextureTypeFromDDSHeader(DDSHeader p_Header)
    {
        // TODO: Implement. Do we allow this to be user selectable? There's no real way to know from DDS
        return TextureType.TextureType_2D;
    }

    /// <summary>
    /// The TextureFormat an UNCOMPRESSED DDS describes, from its bit count and channel masks.
    ///
    /// A DDS only carries a FourCC when it is block-compressed; the uncompressed ones describe
    /// themselves with DDPF_RGB or DDPF_LUMINANCE plus per-channel masks, and BF3 has texture
    /// formats for exactly these. Rejecting them meant a level's uncompressed textures could not be
    /// imported at all -- and because the throw aborts the whole build, one such texture took every
    /// other one with it.
    /// </summary>
    private static TextureFormat TextureFormatFromMasks(DDSPixelFormat p_Format)
    {
        var s_Bits = p_Format.RGBBitCount;
        var s_HasAlpha = p_Format.Flags.HasFlag(DDSFormatFlags.AlphaPixels);

        if (p_Format.Flags.HasFlag(DDSFormatFlags.Luminance))
        {
            if (s_Bits == 8)
                return TextureFormat.TextureFormat_L8;

            if (s_Bits == 16)
                return TextureFormat.TextureFormat_L16;
        }

        if (p_Format.Flags.HasFlag(DDSFormatFlags.Rgb))
        {
            switch (s_Bits)
            {
                case 32:
                    // BF3 stores 32-bit colour as ARGB8888 whichever way round the masks read; the
                    // channel ORDER is the pixel data's business, not the format's.
                    return TextureFormat.TextureFormat_ARGB8888;

                case 24:
                    return TextureFormat.TextureFormat_ARGB8888;

                case 16:
                    if (p_Format.RBitMask == 0xF800 && p_Format.GBitMask == 0x07E0)
                        return TextureFormat.TextureFormat_RGB565;

                    if (p_Format.RBitMask == 0x7C00 && s_HasAlpha)
                        return TextureFormat.TextureFormat_ARGB1555;

                    if (p_Format.RBitMask == 0x0F00)
                        return TextureFormat.TextureFormat_ARGB4444;

                    return TextureFormat.TextureFormat_RGB565;
            }
        }

        if (p_Format.Flags.HasFlag(DDSFormatFlags.Alpha) && s_Bits == 8)
            return TextureFormat.TextureFormat_L8;

        throw new Exception(
            $"Unsupported uncompressed DDS: {s_Bits} bpp, flags {p_Format.Flags}, " +
            $"masks R=0x{p_Format.RBitMask:X8} G=0x{p_Format.GBitMask:X8} " +
            $"B=0x{p_Format.BBitMask:X8} A=0x{p_Format.ABitMask:X8}.");
    }

    private static TextureFormat TextureFormatFromDDSHeader(DDSHeader p_Header, bool p_IsNormalMap = false)
    {
        if (!p_Header.PixelFormat.Flags.HasFlag(DDSFormatFlags.FourCC))
            return TextureFormatFromMasks(p_Header.PixelFormat);
        
        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT1"))
            return p_IsNormalMap ? TextureFormat.TextureFormat_NormalDXT1 : TextureFormat.TextureFormat_DXT1;

        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT3"))
            return TextureFormat.TextureFormat_DXT3;

        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT5"))
            return p_IsNormalMap ? TextureFormat.TextureFormat_NormalDXT5 : TextureFormat.TextureFormat_DXT5;
        
        if (p_Header.PixelFormat.FourCC == 111)
            return TextureFormat.TextureFormat_R16F;
        
        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DX10"))
        {
            var s_Dx10Header = p_Header.Dx10Header;

            return s_Dx10Header!.DxgiFormat switch
            {
                Format.BC1_UNorm or Format.BC1_UNorm_SRgb => TextureFormat.TextureFormat_DXT1,
                Format.BC2_UNorm_SRgb or Format.BC2_UNorm => TextureFormat.TextureFormat_DXT3,
                Format.BC3_UNorm_SRgb or Format.BC3_UNorm => TextureFormat.TextureFormat_DXT5,
                Format.BC4_UNorm => TextureFormat.TextureFormat_DXT5A,
                Format.BC5_UNorm => TextureFormat.TextureFormat_DXN,
                Format.B5G6R5_UNorm => TextureFormat.TextureFormat_RGB565,
                Format.B5G5R5A1_UNorm => TextureFormat.TextureFormat_ARGB1555,
                Format.B4G4R4A4_UNorm => TextureFormat.TextureFormat_ARGB4444,
                Format.R8G8B8A8_UNorm_SRgb or Format.R8G8B8A8_UNorm =>
                    TextureFormat.TextureFormat_ARGB8888,
                Format.R8_UNorm => TextureFormat.TextureFormat_L8,
                Format.R16_UNorm => TextureFormat.TextureFormat_L16,
                Format.R16G16B16A16_UNorm => TextureFormat.TextureFormat_ABGR16,
                Format.R16G16B16A16_Float => TextureFormat.TextureFormat_ABGR16F,
                Format.R32G32B32A32_Float => TextureFormat.TextureFormat_ABGR32F,
                Format.R16_Float => TextureFormat.TextureFormat_R16F,
                Format.D32_Float => 
                    TextureFormat.TextureFormat_R32F, // or TextureFormat_D32F, need to check ARGBFlagBits to determine?
                Format.R16G16_UNorm => TextureFormat.TextureFormat_GR16,
                Format.R16G16_Float => TextureFormat.TextureFormat_GR16F,
                Format.D24_UNorm_S8_UInt => TextureFormat.TextureFormat_D24S8,
                Format.R32G32B32A32_UInt=> TextureFormat.TextureFormat_ABGR32,
                Format.R32G32_Float => TextureFormat.TextureFormat_GR32F,
                Format.R10G10B10A2_UNorm => TextureFormat.TextureFormat_A2R10G10B10,
                _ => TextureFormat.TextureFormat_Unknown
            };
        }

        throw new Exception($"Unsupported DDS FourCC code '{p_Header.PixelFormat.FourCC}'.");
    }
 
    private static TextureFlags TextureFlagsFromDDSHeader(DDSHeader p_Header, TextureAttributes p_Attributes)
    {
        // Streaming by default. A texture delivered self-contained in a mod bundle has to be fully
        // resident instead, since the engine would otherwise look for its high-res mips in a streaming
        // pool that the bundle never populates.
        var s_Flags = p_Attributes.Streaming ? TextureFlags.Streaming : (TextureFlags)0;

        if (p_Attributes.SrgbGamma)
            s_Flags |= TextureFlags.SrgbGamma;

        return s_Flags;
    }
    
    private static DxTexture DxTextureFromDDS(
        DDSHeader p_Header,
        TextureAttributes p_Attributes,
        byte p_MipMapBaseIndex = 0,
        short p_SliceCount = 1
    )
    {
        /*
         * SliceCount seems to be how many "objects" are on this texture
         * as in if it's a TextureType.Cube then sliceCount will be 6
         * 
         * Sometimes things like 2DArray also show up with slice count != 1
         * In the cases I looked they were 2, 6
         */

        var s_MipMapSizes = DDSUtils.CalculateMipMapSizes(p_Header);

        // Textures must always be compressed so set the flag in the GUID.
        var s_ChunkGuid = new GUID(Guid.NewGuid());
        s_ChunkGuid.SetCompressionFlag(true);
        
        return new DxTexture
        {
            // TODO: Make this user settable and handle accordingly
            Type = TextureTypeFromDDSHeader(p_Header),
            Format = TextureFormatFromDDSHeader(p_Header, p_Attributes.IsNormalMap),
            Flags = TextureFlagsFromDDSHeader(p_Header, p_Attributes),
            Width = (short)p_Header.Width,
            Height = (short)p_Header.Height,
            Depth = (short)p_Header.Depth,
            SliceCount = p_SliceCount,
            Unused0 = 0,
            MipmapCount = (byte)p_Header.MipMapCount,
            MipmapBaseIndex = p_MipMapBaseIndex,
            StreamingChunkId = s_ChunkGuid,
            MipmapSizes = s_MipMapSizes,
            MipmapChainSize = (uint)s_MipMapSizes.Sum(x => x),
            ResourceNameHash = (string.IsNullOrWhiteSpace(p_Attributes.Name) ? 0 : RimeLib.Frostbite.Utils.HashQuick(p_Attributes.Name)),
            TextureGroup = p_Attributes.TextureGroup,
        };
    }
}
