using RimeLib.Frostbite;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;
using fb;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;

public class ShaderSolution : IFbSerializable
{
    public ulong StateHash { get; set; } = 0;
    public ShaderSolutionState State { get; set; } = default!;

    public byte Flags { get; set; } // 1 = DoubleSided, 2 = GammaCorrection

    public SurfaceShaderType SurfaceType { get; set; } = SurfaceShaderType.SurfaceShaderType_Opaque;
    public ShaderBlendMode BlendMode { get; set; } = ShaderBlendMode.ShaderBlendMode_Lerp;

    public long VertexPermutationIndex { get; set; } = -1;
    public long PixelPermutationIndex { get; set; } = -1;
    public long GeometryPermutationIndex { get; set; } = -1;

    public long VertexConstantsIndex { get; set; } = -1;
    public long PixelConstantsIndex { get; set; } = -1;

    public ShaderSolution()
    {
    }

    public ShaderSolution(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }
      
    public void Deserialize(RimeReader p_Reader)
    {
        StateHash = p_Reader.ReadUInt64( );

        Flags = p_Reader.ReadUByte(); // 1 = DoubleSided, 2 = GammaCorrection

        SurfaceType = (SurfaceShaderType)p_Reader.ReadUByte();
        BlendMode = (ShaderBlendMode)p_Reader.ReadUByte();

        p_Reader.Seek(0xD, System.IO.SeekOrigin.Current);

        VertexPermutationIndex = p_Reader.ReadInt64();
        PixelPermutationIndex = p_Reader.ReadInt64();
        GeometryPermutationIndex = p_Reader.ReadInt64();

        VertexConstantsIndex = p_Reader.ReadInt64();
        PixelConstantsIndex = p_Reader.ReadInt64();
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