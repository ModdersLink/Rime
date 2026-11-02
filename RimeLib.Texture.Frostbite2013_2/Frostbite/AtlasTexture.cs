using System.IO;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Texture.Frostbite2013_2.Frostbite;

/// <summary>An AtlasTexture resource (AtlasTextureHeader): a texture whose pixels are in a chunk.</summary>
public class AtlasTexture
{
    public const ushort NormalMapFlag = 1;

    public ushort Flags { get; set; }
    public ushort Width { get; set; }
    public ushort Height { get; set; }
    public ushort Unused { get; set; }
    public float BorderWidth { get; set; }
    public float BorderHeight { get; set; }
    public GUID ChunkId { get; set; } = GUID.Empty;

    public static AtlasTexture Read(byte[] p_Data)
    {
        if (p_Data.Length != 32)
            throw new InvalidDataException($"An atlas texture is 32 bytes, not {p_Data.Length}.");

        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        return new AtlasTexture
        {
            Flags = s_Reader.ReadUInt16(),
            Width = s_Reader.ReadUInt16(),
            Height = s_Reader.ReadUInt16(),
            Unused = s_Reader.ReadUInt16(),
            BorderWidth = s_Reader.ReadSingle(),
            BorderHeight = s_Reader.ReadSingle(),
            ChunkId = new GUID(s_Reader),
        };
    }

    public byte[] Write()
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
        {
            s_Writer.Write(Flags);
            s_Writer.Write(Width);
            s_Writer.Write(Height);
            s_Writer.Write(Unused);
            s_Writer.Write(BorderWidth);
            s_Writer.Write(BorderHeight);
            ChunkId.Serialize(s_Writer);
        }

        return s_Stream.ToArray();
    }
}
