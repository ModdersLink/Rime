using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;

/// <summary>
/// One way to draw a shader: the hash of its state, its blend setup, and the indices of its
/// permutations and constant blocks (-1 for none). The referenced records and the state are filled
/// in by <see cref="ShaderDatabase"/> after reading.
/// </summary>
public class ShaderSolution : IFbSerializable
{
    /// <summary>Where the engine keeps its state pointer; always zero in the file.</summary>
    private const int c_StatePointerSize = 12;

    public ulong StateHash { get; set; }

    public byte Flags { get; set; } // 1 = DoubleSided, 2 = GammaCorrection

    public SurfaceShaderType SurfaceType { get; set; } = SurfaceShaderType.SurfaceShaderType_Opaque;
    public ShaderBlendMode BlendMode { get; set; } = ShaderBlendMode.ShaderBlendMode_Lerp;
    public byte AlphaRef { get; set; }

    public long VertexPermutationIndex { get; set; } = -1;
    public long PixelPermutationIndex { get; set; } = -1;
    public long GeometryPermutationIndex { get; set; } = -1;
    public long VertexConstantsIndex { get; set; } = -1;
    public long PixelConstantsIndex { get; set; } = -1;

    public ShaderSolutionState State { get; set; } = default!;

    public VertexShaderPermutation? VertexPermutation { get; set; }
    public PixelShaderPermutation? PixelPermutation { get; set; }
    public GeometryShaderPermutation? GeometryPermutation { get; set; }
    public ShaderConstant? VertexConstants { get; set; }
    public ShaderConstant? PixelConstants { get; set; }

    public void Deserialize(RimeReader p_Reader)
    {
        StateHash = p_Reader.ReadUInt64();
        Flags = p_Reader.ReadUByte();
        SurfaceType = (SurfaceShaderType)p_Reader.ReadUByte();
        BlendMode = (ShaderBlendMode)p_Reader.ReadUByte();
        AlphaRef = p_Reader.ReadUByte();
        p_Reader.Seek(c_StatePointerSize, SeekOrigin.Current);

        VertexPermutationIndex = p_Reader.ReadInt64();
        PixelPermutationIndex = p_Reader.ReadInt64();
        GeometryPermutationIndex = p_Reader.ReadInt64();
        DeserializeStages(p_Reader);
        VertexConstantsIndex = p_Reader.ReadInt64();
        PixelConstantsIndex = p_Reader.ReadInt64();
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(StateHash);
        p_Writer.Write(Flags);
        p_Writer.Write((byte)SurfaceType);
        p_Writer.Write((byte)BlendMode);
        p_Writer.Write(AlphaRef);
        p_Writer.Write(new byte[c_StatePointerSize]);

        p_Writer.Write(VertexPermutationIndex);
        p_Writer.Write(PixelPermutationIndex);
        p_Writer.Write(GeometryPermutationIndex);
        SerializeStages(p_Writer);
        p_Writer.Write(VertexConstantsIndex);
        p_Writer.Write(PixelConstantsIndex);
        return true;
    }

    /// <summary>The permutation indices of the stages a later engine adds after the geometry shader.</summary>
    protected virtual void DeserializeStages(RimeReader p_Reader)
    {
    }

    protected virtual void SerializeStages(RimeWriter p_Writer)
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
