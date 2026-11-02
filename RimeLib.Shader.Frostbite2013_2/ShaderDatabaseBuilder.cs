using System.Collections.Generic;
using RimeLib.Frostbite;
using RimeLib.Shader.Frostbite2013_2.Frostbite;
using BaseContainer = RimeLib.Shader.Frostbite2_0.Frostbite.ShaderDatabaseContainer;
using BaseMerger = RimeLib.Shader.Frostbite2_0.Frostbite.ShaderDatabaseMerger;
using BasePermutation = RimeLib.Shader.Frostbite2_0.Frostbite.Shaders.ShaderPermutation;
using BaseSolution = RimeLib.Shader.Frostbite2_0.Frostbite.Solutions.ShaderSolution;

namespace RimeLib.Shader.Frostbite2013_2;

/// <summary>BF3's shader database builder over the version 194 structs.</summary>
public class ShaderDatabaseBuilder : Frostbite2_0.ShaderDatabaseBuilder
{
    public override EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2013_2 };

    // mp_siege's main bundle carries the 438 shaders only its sub-worlds draw with.
    public override bool ShipsEveryShader => true;

    protected override BaseContainer CreateContainer() => new ShaderDatabaseContainer();

    protected override BaseMerger CreateMerger(IEnumerable<uint> p_Wanted, bool p_AllSolutions) => new ShaderDatabaseMerger(p_Wanted, p_AllSolutions);

    protected override void ClearIndices(BaseSolution p_Solution)
    {
        base.ClearIndices(p_Solution);
        var s_Solution = (ShaderSolution)p_Solution;
        s_Solution.HullPermutationIndex = s_Solution.DomainPermutationIndex = 0;
    }

    protected override IEnumerable<BasePermutation?> StagePermutations(BaseSolution p_Solution)
    {
        var s_Solution = (ShaderSolution)p_Solution;
        return [s_Solution.HullPermutation, s_Solution.DomainPermutation];
    }
}
