using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using RimeLib.Shader.Frostbite2_0.Frostbite.Functions;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

public class PixelShaderPermutation
{
    public GUID Guid { get; set; } = GUID.Empty;
    public byte[] ShaderData { get; set; } = Array.Empty<byte>();

    public ShaderConstant Constant { get; set; } = default!;
    public ShaderConstantFunctionData ConstantFunction { get; set; } = default!;
    public ShaderTextureFunctionData TextureFunction { get; set; } = default!;

    public uint InstructionCount { get; set; }

    public PixelShaderPermutation()
    {
    }

    public PixelShaderPermutation(
        RimeReader p_Reader,
        ShaderConstant[] p_Constants,
        ShaderConstantFunctionData[] p_ConstantFunctionData,
        ShaderTextureFunctionData[] p_TextureFunctionData
    )
    {
        Guid = new GUID(p_Reader);

        var s_DataSize = p_Reader.ReadUInt32();
        ShaderData = p_Reader.ReadBytes((int)s_DataSize);

        Constant = p_Constants[p_Reader.ReadUInt32()];
        ConstantFunction = p_ConstantFunctionData[p_Reader.ReadUInt32()];
        TextureFunction = p_TextureFunctionData[p_Reader.ReadUInt32()];

        InstructionCount = p_Reader.ReadUInt32();
    }
}