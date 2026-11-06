using System.Collections.Generic;
using BaseSolution = RimeLib.Shader.Frostbite2_0.Frostbite.Solutions.ShaderSolution;

namespace RimeLib.Shader.Frostbite2013_2.Frostbite;

/// <summary>BF3's merger, copying the hull and domain permutations too.</summary>
public class ShaderDatabaseMerger : Frostbite2_0.Frostbite.ShaderDatabaseMerger
{
    public ShaderDatabaseMerger(IEnumerable<uint> p_Wanted, bool p_AllSolutions) : base(p_Wanted, p_AllSolutions)
    {
    }

    protected override void CopyStages(Copier p_Copier, BaseSolution p_Solution)
    {
        var s_Source = (ShaderDatabase)p_Copier.Source;
        var s_Into = (ShaderDatabase)p_Copier.Output.Database;
        var s_Solution = (ShaderSolution)p_Solution;
        s_Solution.HullPermutationIndex = p_Copier.CopyPermutation(s_Source.HullPermutations, s_Into.HullPermutations, s_Solution.HullPermutationIndex);
        s_Solution.DomainPermutationIndex = p_Copier.CopyPermutation(s_Source.DomainPermutations, s_Into.DomainPermutations, s_Solution.DomainPermutationIndex);
    }
}
