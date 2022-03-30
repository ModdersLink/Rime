using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Texture.DDS;
using RimeLib.Texture.Frostbite2_0.Frostbite;
using RimeLib.Texture.Generation;
using RimeLib.Utils;

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

        var s_DxTexture = DxTextureFromDDS(s_DDSHeader, p_Attributes.Name, p_Attributes.TextureGroup, 0, 1);
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
                DXGIFormat.BC1_UNORM or DXGIFormat.BC1_UNORM_SRGB => TextureFormat.TextureFormat_DXT1,
                DXGIFormat.BC2_UNORM_SRGB or DXGIFormat.BC2_UNORM => TextureFormat.TextureFormat_DXT3,
                DXGIFormat.BC3_UNORM_SRGB or DXGIFormat.BC3_UNORM => TextureFormat.TextureFormat_DXT5,
                DXGIFormat.BC4_UNORM => TextureFormat.TextureFormat_DXT5A,
                DXGIFormat.BC5_UNORM => TextureFormat.TextureFormat_DXN,
                DXGIFormat.B5G6R5_UNORM => TextureFormat.TextureFormat_RGB565,
                DXGIFormat.B5G5R5A1_UNORM => TextureFormat.TextureFormat_ARGB1555,
                DXGIFormat.B4G4R4A4_UNORM => TextureFormat.TextureFormat_ARGB4444,
                DXGIFormat.R8G8B8A8_UNORM_SRGB or DXGIFormat.R8G8B8A8_UNORM =>
                    TextureFormat.TextureFormat_ARGB8888,
                DXGIFormat.R8_UNORM => TextureFormat.TextureFormat_L8,
                DXGIFormat.R16_UNORM => TextureFormat.TextureFormat_L16,
                DXGIFormat.R16G16B16A16_UNORM => TextureFormat.TextureFormat_ABGR16,
                DXGIFormat.R16G16B16A16_FLOAT => TextureFormat.TextureFormat_ABGR16F,
                DXGIFormat.R32G32B32A32_FLOAT => TextureFormat.TextureFormat_ABGR32F,
                DXGIFormat.R16_FLOAT => TextureFormat.TextureFormat_R16F,
                DXGIFormat.D32_FLOAT => 
                    TextureFormat.TextureFormat_R32F, // or TextureFormat_D32F, need to check ARGBFlagBits to determine?
                DXGIFormat.R16G16_UNORM => TextureFormat.TextureFormat_GR16,
                DXGIFormat.R16G16_FLOAT => TextureFormat.TextureFormat_GR16F,
                DXGIFormat.D24_UNORM_S8_UINT => TextureFormat.TextureFormat_D24S8,
                //DXGIFormat.D32_FLOAT => TextureFormat.TextureFormat_D32F,
                DXGIFormat.R32G32B32A32_UINT => TextureFormat.TextureFormat_ABGR32,
                DXGIFormat.R32G32_FLOAT => TextureFormat.TextureFormat_GR32F,
                DXGIFormat.R10G10B10A2_UNORM => TextureFormat.TextureFormat_A2R10G10B10,
                _ => TextureFormat.TextureFormat_Unknown
            };
        }

        throw new Exception($"Unsupported DDS FourCC code '{p_Header.PixelFormat.FourCC}'.");
    }
 
    private static TextureFlags TextureFlagsFromDDSHeader(DDSHeader p_Header)
    {
        // Default to all textures being streamable
        var s_Flags = TextureFlags.Streaming;

        // Add SRGB support
        if (p_Header.Flags.HasFlag(DDSFlags.Srgb))
            s_Flags |= TextureFlags.SrgbGamma;

        return s_Flags;
    }
    
    private static DxTexture DxTextureFromDDS(
        DDSHeader p_Header,
        string p_Name = "",
        string p_TextureGroup = "Default",
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

        return new DxTexture
        {
            // TODO: Make this user settable and handle accordingly
            Type = TextureTypeFromDDSHeader(p_Header),
            Format = TextureFormatFromDDSHeader(p_Header),
            Flags = TextureFlagsFromDDSHeader(p_Header),
            Width = (short)p_Header.Width,
            Height = (short)p_Header.Height,
            Depth = (short)p_Header.Depth,
            SliceCount = p_SliceCount,
            Unused0 = 0,
            MipmapCount = (byte)p_Header.MipMapCount,
            MipmapBaseIndex = p_MipMapBaseIndex,
            StreamingChunkId = Guid.Empty,
            MipmapSizes = s_MipMapSizes,
            MipmapChainSize = (uint)s_MipMapSizes.Sum(x => x),
            ResourceNameHash = (string.IsNullOrWhiteSpace(p_Name) ? 0 : FbUtils.HashQuick(p_Name)),
            TextureGroup = p_TextureGroup
        };
    }
}
