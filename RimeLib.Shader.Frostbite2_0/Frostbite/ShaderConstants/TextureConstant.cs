using RimeLib.Frostbite;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using fb;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants;

public class TextureConstant : IFbSerializable
{
    public byte Index { get; set; }
    public TextureType TextureType { get; set; } = TextureType.TextureType_2d;
    public string Name { get; set; } = string.Empty;

    public TextureConstant()
    {

    }

    public TextureConstant(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Index = p_Reader.ReadUByte();
        TextureType = (TextureType)p_Reader.ReadUByte();

        p_Reader.Seek(0x6, SeekOrigin.Current); 

        Name = p_Reader.ReadFixedLengthString(0x80);

        p_Reader.Seek(0x10, SeekOrigin.Current); //This is moved to the previous pad in newer shaderdbs
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