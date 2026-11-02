using RimeLib.IO;

namespace RimeLib.Shader.Frostbite2013_2.Frostbite;

/// <summary>A version 194 solution: BF3's, with the hull and domain permutations after the geometry one.</summary>
public class ShaderSolution : Frostbite2_0.Frostbite.Solutions.ShaderSolution
{
    public long HullPermutationIndex { get; set; } = -1;
    public long DomainPermutationIndex { get; set; } = -1;

    public HullShaderPermutation? HullPermutation { get; set; }
    public DomainShaderPermutation? DomainPermutation { get; set; }

    protected override void DeserializeStages(RimeReader p_Reader)
    {
        HullPermutationIndex = p_Reader.ReadInt64();
        DomainPermutationIndex = p_Reader.ReadInt64();
    }

    protected override void SerializeStages(RimeWriter p_Writer)
    {
        p_Writer.Write(HullPermutationIndex);
        p_Writer.Write(DomainPermutationIndex);
    }
}
