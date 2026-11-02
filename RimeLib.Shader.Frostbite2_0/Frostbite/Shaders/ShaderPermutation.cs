using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite.Functions;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

/// <summary>
/// A compiled shader with its constants: guid, bytecode, the indices of its constant block,
/// constant function block and texture function block, what the stage adds, and the instruction
/// count. The referenced records are filled in by <see cref="ShaderDatabase"/> after reading.
/// </summary>
public abstract class ShaderPermutation : IFbSerializable
{
    public GUID Guid { get; set; } = GUID.Empty;
    public byte[] ShaderBytecode { get; set; } = Array.Empty<byte>();

    public int ConstantIndex { get; set; }
    public int ConstantFunctionIndex { get; set; }
    public int TextureFunctionIndex { get; set; }

    public uint InstructionCount { get; set; }

    public ShaderConstant Constant { get; set; } = default!;
    public ShaderConstantFunctionData ConstantFunction { get; set; } = default!;
    public ShaderTextureFunctionData TextureFunction { get; set; } = default!;

    public void Deserialize(RimeReader p_Reader)
    {
        Guid = new GUID(p_Reader);
        ShaderBytecode = p_Reader.ReadBytes((int)p_Reader.ReadUInt32());
        ConstantIndex = p_Reader.ReadInt32();
        ConstantFunctionIndex = p_Reader.ReadInt32();
        TextureFunctionIndex = p_Reader.ReadInt32();
        DeserializeStage(p_Reader);
        InstructionCount = p_Reader.ReadUInt32();
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        Guid.Serialize(p_Writer);
        p_Writer.Write((uint)ShaderBytecode.Length);
        p_Writer.Write(ShaderBytecode);
        p_Writer.Write(ConstantIndex);
        p_Writer.Write(ConstantFunctionIndex);
        p_Writer.Write(TextureFunctionIndex);
        SerializeStage(p_Writer);
        p_Writer.Write(InstructionCount);
        return true;
    }

    /// <summary>What the stage keeps between the function indices and the instruction count.</summary>
    protected virtual void DeserializeStage(RimeReader p_Reader)
    {
    }

    protected virtual void SerializeStage(RimeWriter p_Writer)
    {
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
