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

    private static TextureFormat TextureFormatFromDDSHeader(DDSHeader p_Header)
    {
        // TODO: What's this?
        var s_IsNormal = false;

        if (!p_Header.PixelFormat.Flags.HasFlag(DDSFormatFlags.FourCC))
            throw new Exception("The provided DDS had no FourCC code.");
        
        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT1"))
            return s_IsNormal ? TextureFormat.TextureFormat_NormalDXT1 : TextureFormat.TextureFormat_DXT1;

        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT3"))
            return TextureFormat.TextureFormat_DXT3;

        if (p_Header.PixelFormat.FourCC == DDSUtils.MakeFourCC("DXT5"))
            return s_IsNormal ? TextureFormat.TextureFormat_NormalDXT5 : TextureFormat.TextureFormat_DXT5;
        
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
        // Default to all textures being streamable
        var s_Flags = TextureFlags.Streaming;
        
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
            Format = TextureFormatFromDDSHeader(p_Header),
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
