using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

public class PixelShaderPermutation : IFbSerializable
{

    public GUID Guid { get; set; } = GUID.Empty;
    public byte[] ShaderData { get; set; } = Array.Empty<byte>();
        
    public uint ConstantsIndex { get; set; }
    public uint ConstantFunctionIndex { get; set; }
    public uint TextureFunctionIndex { get; set; }

    public uint InstructionCount { get; set; }

    public PixelShaderPermutation()
    {
    }

    public PixelShaderPermutation(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Guid = new GUID(p_Reader);


        var s_DataSize = p_Reader.ReadUInt32();
        ShaderData = p_Reader.ReadBytes((int) s_DataSize);


        ConstantsIndex = p_Reader.ReadUInt32();
        ConstantFunctionIndex = p_Reader.ReadUInt32();
        TextureFunctionIndex = p_Reader.ReadUInt32();

        InstructionCount = p_Reader.ReadUInt32();
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