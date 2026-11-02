using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants;

/// <summary>
/// A texture a constant block binds, 152 bytes: slot, type, the texture's name, and the lowercase
/// hash of that name (BF4; BF3 leaves it zero).
/// </summary>
public class TextureConstant : IFbSerializable
{
    private const int c_NameLength = 0x80;

    public byte Index { get; set; }
    public TextureType TextureType { get; set; } = TextureType.TextureType_2d;
    public string Name { get; set; } = string.Empty;
    public uint NameHash { get; set; }

    public TextureConstant()
    {
    }

    public TextureConstant(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Index = p_Reader.ReadUByte();
        TextureType = (TextureType)p_Reader.ReadUByte();
        p_Reader.Seek(6, SeekOrigin.Current);
        Name = p_Reader.ReadFixedLengthString(c_NameLength);
        p_Reader.Seek(8, SeekOrigin.Current);
        NameHash = p_Reader.ReadUInt32();
        p_Reader.Seek(4, SeekOrigin.Current);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Index);
        p_Writer.Write((byte)TextureType);
        p_Writer.Write(new byte[6]);
        p_Writer.WriteFixedLengthString(Name, c_NameLength);
        p_Writer.Write(new byte[8]);
        p_Writer.Write(NameHash);
        p_Writer.Write(new byte[4]);
        return true;
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
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
    }
}
