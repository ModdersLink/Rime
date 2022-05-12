using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using RimeLib.Shader.Frostbite2_0.Frostbite.Functions;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

public class VertexShaderPermutation
{
    public GUID Guid { get; set; } = GUID.Empty;
    public byte[] ShaderBytecode { get; set; } = Array.Empty<byte>();
        
    // This is basically the same as taking the main HLSL and removing everything but the
    // ISGN (Input Signature) section. Checksums and sizes and such also have to be updated
    // obviously. Probably generated using D3DGetInputSignatureBlob.
    public byte[] InputSignatureBytecode { get; set; } = Array.Empty<byte>();
        
    public ShaderConstant Constant { get; set; } = default!;
    public ShaderConstantFunctionData ConstantFunction { get; set; } = default!;
    public ShaderTextureFunctionData TextureFunction { get; set; } = default!;
    
    public InputElement[] Elements { get; set; } = Array.Empty<InputElement>();
        
    public uint InstructionCount { get; set; }

    public VertexShaderPermutation()
    {
    }

    public VertexShaderPermutation(
        RimeReader p_Reader,
        ShaderConstant[] p_Constants,
        ShaderConstantFunctionData[] p_ConstantFunctionData,
        ShaderTextureFunctionData[] p_TextureFunctionData
    )
    {
        Guid = new GUID(p_Reader);

        var s_DataSize = p_Reader.ReadUInt32();
        ShaderBytecode = p_Reader.ReadBytes((int)s_DataSize);

        Constant = p_Constants[p_Reader.ReadUInt32()];
        ConstantFunction = p_ConstantFunctionData[p_Reader.ReadUInt32()];
        TextureFunction = p_TextureFunctionData[p_Reader.ReadUInt32()];

        var s_BytecodeSize = p_Reader.ReadInt32();
        InputSignatureBytecode = p_Reader.ReadBytes(s_BytecodeSize);

        var s_ElementCount = p_Reader.ReadUInt32();

        Elements = new InputElement[s_ElementCount];

        for (var i = 0; i < s_ElementCount; ++i)
        {
            Elements[i].SemanticIndex = p_Reader.ReadInt32();
            Elements[i].Format = (Format)p_Reader.ReadInt32();
            Elements[i].Slot = p_Reader.ReadInt32();
            Elements[i].AlignedByteOffset = p_Reader.ReadInt32();
            Elements[i].Classification = (InputClassification)p_Reader.ReadInt32();
            Elements[i].InstanceDataStepRate = p_Reader.ReadInt32();
        }

        var s_ElementNamesCount = p_Reader.ReadUInt32();

        if (s_ElementNamesCount != s_ElementCount)
            throw new Exception($"Element names count does not match element count (expected {s_ElementCount} got {s_ElementNamesCount}. Is this shader database corrupted?");

        for (var i = 0; i < s_ElementNamesCount; i++)
            Elements[i].SemanticName = p_Reader.ReadNullTerminatedString();

        InstructionCount = p_Reader.ReadUInt32();
    }
}