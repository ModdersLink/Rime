using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Texture.Frostbite2_0.Frostbite;

public class DxTexture : IFbSerializable
{
    public uint Version { get; set; } = 10;
    public TextureType Type { get; set; }
    public TextureFormat Format { get; set; }
    public TextureFlags Flags { get; set; }
    public short Width { get; set; }
    public short Height { get; set; }
    public short Depth { get; set; }
    public short SliceCount { get; set; }
    public short Unused0 { get; set; }
    public byte MipmapCount { get; set; }
    public byte MipmapBaseIndex { get; set; }
    public GUID StreamingChunkId { get; set; } = Guid.Empty;
    public uint[] MipmapSizes { get; set; } = new uint[15];
    public uint MipmapChainSize { get; set; }
    public uint ResourceNameHash { get; set; }
    public string TextureGroup { get; set; } = "Default";

    public DxTexture()
    {

    }

    /// <summary>
    /// TextureHeader Constructor
    /// This will read out the ITexture structure at an opened stream where the position is at a ITexture structure in the data
    /// </summary>
    /// <param name="p_Reader">Reference to an IceReader class</param>
    public DxTexture(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        var s_PrevEndianness = p_Writer.Endianness;
        p_Writer.Endianness = Endianness.LittleEndian;
        
        p_Writer.Write(Version);
        p_Writer.Write((uint)Type);
        p_Writer.Write((uint)Format);
        p_Writer.Write((uint)Flags);
        p_Writer.Write(Width);
        p_Writer.Write(Height);
        p_Writer.Write(Depth);
        p_Writer.Write(SliceCount);
        p_Writer.Write(Unused0);
        p_Writer.Write(MipmapCount);
        p_Writer.Write(MipmapBaseIndex);
        StreamingChunkId.Serialize(p_Writer);

        foreach (var s_MipMapSize in MipmapSizes)
            p_Writer.Write(s_MipMapSize);

        p_Writer.Write(MipmapChainSize);
        p_Writer.Write(ResourceNameHash);

        var s_TextureGroupData = Encoding.UTF8.GetBytes(TextureGroup);
        p_Writer.Write(s_TextureGroupData, 0, System.Math.Min(s_TextureGroupData.Length, 16));

        if (s_TextureGroupData.Length < 16)
            p_Writer.WriteNullBytes(16 - (uint)s_TextureGroupData.Length);

        p_Writer.Endianness = s_PrevEndianness;
        
        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        if (Serialize(s_Writer))
        {
            p_Data = s_Stream.ToArray();
            return true;
        }

        p_Data = null;
        return false;
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_PrevEndianness = p_Reader.Endianness;
        p_Reader.Endianness = Endianness.LittleEndian;

        Version = p_Reader.ReadUInt32();

        if (Version != 10)
            throw new Exception($"Unsupported texture version '{Version}'. Expected '10'.");

        Type = (TextureType) p_Reader.ReadUInt32();
        Format = (TextureFormat) p_Reader.ReadUInt32();

        if (Format >= TextureFormat.TextureFormat_Unknown)
            throw new Exception($"Unsupported texture format '{Format}.");

        Flags = (TextureFlags) p_Reader.ReadUInt32();
        Width = p_Reader.ReadInt16();
        Height = p_Reader.ReadInt16();
        Depth = p_Reader.ReadInt16();
        SliceCount = p_Reader.ReadInt16();
        Unused0 = p_Reader.ReadInt16();
        MipmapCount = p_Reader.ReadUByte();
        MipmapBaseIndex = p_Reader.ReadUByte();
        StreamingChunkId = new GUID(p_Reader);

        MipmapSizes = new uint[15];
        for (var i = 0; i < 15; ++i)
            MipmapSizes[i] = p_Reader.ReadUInt32();

        MipmapChainSize = p_Reader.ReadUInt32();
        ResourceNameHash = p_Reader.ReadUInt32();
        TextureGroup = Encoding.UTF8.GetString(p_Reader.ReadBytes(16));
        
        p_Reader.Endianness = s_PrevEndianness;
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}