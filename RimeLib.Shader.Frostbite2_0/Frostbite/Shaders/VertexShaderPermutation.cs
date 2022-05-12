using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

public class VertexShaderPermutation : IFbSerializable
{
    public GUID Guid { get; set; } = GUID.Empty;
    public byte[] ShaderBytecode { get; set; } = Array.Empty<byte>();
        
    // This is basically the same as taking the main HLSL and removing everything but the
    // ISGN (Input Signature) section. Checksums and sizes and such also have to be updated
    // obviously. Probably generated using D3DGetInputSignatureBlob.
    public byte[] InputSignatureBytecode { get; set; } = Array.Empty<byte>();
        
    public uint ConstantsIndex { get; set; }
    public uint ConstantFunctionIndex { get; set; }
    public uint TextureFunctionIndex { get; set; }
    
    public InputElement[] Elements { get; set; } = Array.Empty<InputElement>();
        
    public uint InstructionCount { get; set; }

    public VertexShaderPermutation()
    {
    }

    public VertexShaderPermutation(RimeReader p_Reader)
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
        ShaderBytecode = p_Reader.ReadBytes((int)s_DataSize);

        ConstantsIndex = p_Reader.ReadUInt32();
        ConstantFunctionIndex = p_Reader.ReadUInt32();
        TextureFunctionIndex = p_Reader.ReadUInt32();

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