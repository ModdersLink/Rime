using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Texture.Frostbite2013_2.Frostbite;

/// <summary>An AtlasTexture resource (AtlasTextureHeader, BF4; BF3 ships none): a texture whose pixels are in a chunk.</summary>
public class AtlasTexture : IFbSerializable
{
    public const int Size = 32;
    public const ushort NormalMapFlag = 1;

    public ushort Flags { get; set; }
    public ushort Width { get; set; }
    public ushort Height { get; set; }
    public ushort Unused { get; set; }
    public float BorderWidth { get; set; }
    public float BorderHeight { get; set; }
    public GUID ChunkId { get; set; } = GUID.Empty;

    public void Deserialize(RimeReader p_Reader)
    {
        Flags = p_Reader.ReadUInt16();
        Width = p_Reader.ReadUInt16();
        Height = p_Reader.ReadUInt16();
        Unused = p_Reader.ReadUInt16();
        BorderWidth = p_Reader.ReadSingle();
        BorderHeight = p_Reader.ReadSingle();
        ChunkId = new GUID(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Flags);
        p_Writer.Write(Width);
        p_Writer.Write(Height);
        p_Writer.Write(Unused);
        p_Writer.Write(BorderWidth);
        p_Writer.Write(BorderHeight);
        return ChunkId.Serialize(p_Writer);
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            Serialize(s_Writer);

        p_Data = s_Stream.ToArray();
        return true;
    }

    public void Deserialize(byte[] p_Data)
    {
        if (p_Data.Length != Size)
            throw new InvalidDataException($"An atlas texture is {Size} bytes, not {p_Data.Length}.");

        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
    }
}
