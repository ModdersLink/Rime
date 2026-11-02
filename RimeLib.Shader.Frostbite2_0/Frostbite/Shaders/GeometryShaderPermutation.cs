using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

/// <summary>A geometry shader: guid, bytecode and instruction count, with no constants.</summary>
public class GeometryShaderPermutation : IFbSerializable
{
    public GUID Guid { get; set; } = GUID.Empty;
    public byte[] ShaderBytecode { get; set; } = Array.Empty<byte>();
    public uint InstructionCount { get; set; }

    public void Deserialize(RimeReader p_Reader)
    {
        Guid = new GUID(p_Reader);
        ShaderBytecode = p_Reader.ReadBytes((int)p_Reader.ReadUInt32());
        InstructionCount = p_Reader.ReadUInt32();
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        Guid.Serialize(p_Writer);
        p_Writer.Write((uint)ShaderBytecode.Length);
        p_Writer.Write(ShaderBytecode);
        p_Writer.Write(InstructionCount);
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
