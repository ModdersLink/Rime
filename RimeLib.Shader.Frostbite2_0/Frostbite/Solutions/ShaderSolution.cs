using RimeLib.IO;
using fb;
using RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;

public class ShaderSolution
{
    public ulong StateHash { get; set; }
    public ShaderSolutionState State { get; set; } = default!;

    public byte Flags { get; set; } // 1 = DoubleSided, 2 = GammaCorrection

    public SurfaceShaderType SurfaceType { get; set; } = SurfaceShaderType.SurfaceShaderType_Opaque;
    public ShaderBlendMode BlendMode { get; set; } = ShaderBlendMode.ShaderBlendMode_Lerp;

    public VertexShaderPermutation? VertexPermutation { get; set; }
    public PixelShaderPermutation? PixelPermutation { get; set; }
    public GeometryShaderPermutation? GeometryPermutation { get; set; }
    public ShaderConstant? VertexConstants { get; set; }
    public ShaderConstant? PixelConstants { get; set; }

    public ShaderSolution()
    {
    }

    public ShaderSolution(
        RimeReader p_Reader,
        VertexShaderPermutation[] p_VertexShaderPermutations,
        PixelShaderPermutation[] p_PixelShaderPermutations,
        GeometryShaderPermutation[] p_GeometryShaderPermutations,
        ShaderConstant[] p_Constants
    )
    {
        StateHash = p_Reader.ReadUInt64( );

        Flags = p_Reader.ReadUByte(); // 1 = DoubleSided, 2 = GammaCorrection

        SurfaceType = (SurfaceShaderType)p_Reader.ReadUByte();
        BlendMode = (ShaderBlendMode)p_Reader.ReadUByte();

        p_Reader.Seek(0xD, System.IO.SeekOrigin.Current);

        var s_VertexPermutationIndex = p_Reader.ReadInt64();
        
        if (s_VertexPermutationIndex != -1)
            VertexPermutation = p_VertexShaderPermutations[s_VertexPermutationIndex];

        var s_PixelPermutationIndex = p_Reader.ReadInt64();
        
        if (s_PixelPermutationIndex != -1)
            PixelPermutation = p_PixelShaderPermutations[s_PixelPermutationIndex];

        var s_GeometryPermutationIndex = p_Reader.ReadInt64();
        
        if (s_GeometryPermutationIndex != -1)
            GeometryPermutation = p_GeometryShaderPermutations[s_GeometryPermutationIndex];

        var s_VertexConstantsIndex = p_Reader.ReadInt64();
        
        if (s_VertexConstantsIndex != -1)
            VertexConstants = p_Constants[s_VertexConstantsIndex];
        
        var s_PixelConstantsIndex = p_Reader.ReadInt64();

        if (s_PixelConstantsIndex != -1)
            PixelConstants = p_Constants[s_PixelConstantsIndex];
    }
}