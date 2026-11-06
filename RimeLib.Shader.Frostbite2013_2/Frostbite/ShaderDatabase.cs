using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Serialization;
using BaseSolution = RimeLib.Shader.Frostbite2_0.Frostbite.Solutions.ShaderSolution;
using BaseState = RimeLib.Shader.Frostbite2_0.Frostbite.Solutions.ShaderSolutionState;
using BaseVertex = RimeLib.Shader.Frostbite2_0.Frostbite.Shaders.VertexShaderPermutation;
using BaseInfo = RimeLib.Shader.Frostbite2_0.Frostbite.SurfaceShaderInfo;

namespace RimeLib.Shader.Frostbite2013_2.Frostbite;

/// <summary>
/// A version 194 shader database: BF3's, with a quality level in the header, hull and domain
/// shader pools after the geometry shaders, and the version 194 records.
/// </summary>
public class ShaderDatabase : Frostbite2_0.Frostbite.ShaderDatabase
{
    public override uint Version => 194;

    public uint QualityLevel { get; set; }

    public List<HullShaderPermutation> HullPermutations { get; set; } = new();
    public List<DomainShaderPermutation> DomainPermutations { get; set; } = new();

    protected override BaseSolution CreateSolution() => new ShaderSolution();
    protected override BaseState CreateSolutionState() => new ShaderSolutionState();
    protected override BaseVertex CreateVertexPermutation() => new VertexShaderPermutation();
    protected override BaseInfo CreateShaderInfo() => new SurfaceShaderInfo();

    public override Frostbite2_0.Frostbite.ShaderDatabase CreateEmpty() => new ShaderDatabase { RenderPath = RenderPath, QualityLevel = QualityLevel };

    protected override string? ShaderAssetName(DataContainerBase? p_Primary) => (p_Primary as fb.Render.SurfaceShaderBaseAsset)?.Name;

    protected override void DeserializeHeader(RimeReader p_Reader) => QualityLevel = p_Reader.ReadUInt32();

    protected override void SerializeHeader(RimeWriter p_Writer) => p_Writer.Write(QualityLevel);

    protected override void DeserializeStagePools(RimeReader p_Reader)
    {
        HullPermutations = ReadPool(p_Reader, () => new HullShaderPermutation());
        DomainPermutations = ReadPool(p_Reader, () => new DomainShaderPermutation());
    }

    protected override void SerializeStagePools(RimeWriter p_Writer)
    {
        WritePool(p_Writer, HullPermutations);
        WritePool(p_Writer, DomainPermutations);
    }

    public override void Resolve()
    {
        base.Resolve();

        foreach (var s_Permutation in HullPermutations)
            ResolvePermutation(s_Permutation);
        foreach (var s_Permutation in DomainPermutations)
            ResolvePermutation(s_Permutation);

        foreach (var s_Solution in Solutions)
        {
            var s_Own = (ShaderSolution)s_Solution;
            s_Own.HullPermutation = At(HullPermutations, s_Own.HullPermutationIndex);
            s_Own.DomainPermutation = At(DomainPermutations, s_Own.DomainPermutationIndex);
        }
    }

    public override IEnumerable<(string Name, int Count)> PoolCounts()
    {
        foreach (var s_Pool in base.PoolCounts())
        {
            if (s_Pool.Name == "solutions")
            {
                yield return ("hull permutations", HullPermutations.Count);
                yield return ("domain permutations", DomainPermutations.Count);
            }

            yield return s_Pool;
        }
    }
}

/// <summary>A shaderdb resource of version 194 databases.</summary>
public class ShaderDatabaseContainer : Frostbite2_0.Frostbite.ShaderDatabaseContainer
{
    protected override Frostbite2_0.Frostbite.ShaderDatabase CreateDatabase() => new ShaderDatabase();
}
