using fb;
using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants;

public class ExternalValueConstant : IFbSerializable
{
    public string Name { get; set; } = string.Empty;

    public uint Handle { get; set; }
    public ushort Index { get; set; }
    public ushort ArraySize { get; set; }
    public byte Size { get; set; }
    public bool Required { get; set; }

    public Vec4 DefaultValue { get; set; } = new();

    public ExternalValueConstant()
    {
    }

    public ExternalValueConstant(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new NotImplementedException();
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Name = p_Reader.ReadFixedLengthString(0x20);

        Handle = p_Reader.ReadUInt32();

        Index = p_Reader.ReadUInt16();

        ArraySize = p_Reader.ReadUInt16();

        Size = p_Reader.ReadUByte();
        Required = p_Reader.ReadBool();

        p_Reader.Seek(2, System.IO.SeekOrigin.Current);

        DefaultValue.x = p_Reader.ReadSingle();
        DefaultValue.y = p_Reader.ReadSingle();
        DefaultValue.z = p_Reader.ReadSingle();
        DefaultValue.w = p_Reader.ReadSingle();
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