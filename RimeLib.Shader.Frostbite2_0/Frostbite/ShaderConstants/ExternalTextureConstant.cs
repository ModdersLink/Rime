using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;
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

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new NotImplementedException();

        /*p_Writer.Write(Encoding.ASCII.GetBytes(m_Name).Take(0x20).ToArray());

        p_Writer.Write(m_Handle);
        p_Writer.Write(m_Index);
        p_Writer.Write(m_TextureType);
        p_Writer.Write(m_Required);

        return true;*/
    }
        
    public void Deserialize(RimeReader p_Reader)
    {
        Name = Encoding.UTF8.GetString(p_Reader.ReadBytes(0x20));

        Handle = p_Reader.ReadUInt32();

        Index = p_Reader.ReadUInt16();

        TextureType = (TextureType)p_Reader.ReadUByte();
        Required = p_Reader.ReadBool(); 
    }


    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;
        throw new System.NotImplementedException();
    }


    public void Deserialize(byte[] p_Data)
    {
        throw new System.NotImplementedException();
    }

}