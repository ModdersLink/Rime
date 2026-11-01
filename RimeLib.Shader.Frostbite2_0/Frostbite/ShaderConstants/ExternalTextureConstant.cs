using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using fb;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants;

public class ExternalTextureConstant : IFbSerializable
{
    public string Name { get; set; } = string.Empty;

    public uint Handle { get; set; }
    public ushort Index { get; set; }
    public TextureType TextureType { get; set; } = TextureType.TextureType_2d;
    public bool Required { get; set; }

    public ExternalTextureConstant()
    {

    }

    public ExternalTextureConstant(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    /// <summary>
    /// Mirrors <see cref="Deserialize(RimeReader)"/> field for field, in its order: 0x28 bytes.
    /// </summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.WriteFixedLengthString(Name, 0x20);

        p_Writer.Write(Handle);

        p_Writer.Write(Index);

        p_Writer.Write((byte) TextureType);
        p_Writer.Write(Required);

        return true;
    }
        
    public void Deserialize(RimeReader p_Reader)
    {
        Name = p_Reader.ReadFixedLengthString(0x20);

        Handle = p_Reader.ReadUInt32();

        Index = p_Reader.ReadUInt16();

        TextureType = (TextureType)p_Reader.ReadUByte();
        Required = p_Reader.ReadBool(); 
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


    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));

        Deserialize(s_Reader);
    }

}