using System;
using System.IO;
using RimeLib.IO;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

/// <summary>A vertex shader: a <see cref="ShaderPermutation"/> with its input signature and elements.</summary>
public class VertexShaderPermutation : ShaderPermutation
{
    // This is basically the same as taking the main HLSL and removing everything but the
    // ISGN (Input Signature) section. Checksums and sizes and such also have to be updated
    // obviously. Probably generated using D3DGetInputSignatureBlob.
    public byte[] InputSignatureBytecode { get; set; } = Array.Empty<byte>();

    public InputElement[] Elements { get; set; } = Array.Empty<InputElement>();

    /// <summary>The input signature, the elements, then their semantic names in the same order.</summary>
    protected override void DeserializeStage(RimeReader p_Reader)
    {
        InputSignatureBytecode = p_Reader.ReadBytes(p_Reader.ReadInt32());

        Elements = new InputElement[p_Reader.ReadUInt32()];
        for (var i = 0; i < Elements.Length; ++i)
        {
            Elements[i].SemanticIndex = p_Reader.ReadInt32();
            Elements[i].Format = (Format)p_Reader.ReadInt32();
            Elements[i].Slot = p_Reader.ReadInt32();
            Elements[i].AlignedByteOffset = p_Reader.ReadInt32();
            Elements[i].Classification = (InputClassification)p_Reader.ReadInt32();
            Elements[i].InstanceDataStepRate = p_Reader.ReadInt32();
        }

        var s_NameCount = p_Reader.ReadUInt32();
        if (s_NameCount != Elements.Length)
            throw new InvalidDataException($"A vertex shader has {Elements.Length} elements but {s_NameCount} element names.");

        for (var i = 0; i < Elements.Length; i++)
            Elements[i].SemanticName = p_Reader.ReadNullTerminatedString();
    }

    protected override void SerializeStage(RimeWriter p_Writer)
    {
        p_Writer.Write(InputSignatureBytecode.Length);
        p_Writer.Write(InputSignatureBytecode);

        p_Writer.Write((uint)Elements.Length);
        foreach (var s_Element in Elements)
        {
            p_Writer.Write(s_Element.SemanticIndex);
            p_Writer.Write((int)s_Element.Format);
            p_Writer.Write(s_Element.Slot);
            p_Writer.Write(s_Element.AlignedByteOffset);
            p_Writer.Write((int)s_Element.Classification);
            p_Writer.Write(s_Element.InstanceDataStepRate);
        }

        p_Writer.Write((uint)Elements.Length);
        foreach (var s_Element in Elements)
            p_Writer.WriteNullTerminatedString(s_Element.SemanticName);
    }
}
