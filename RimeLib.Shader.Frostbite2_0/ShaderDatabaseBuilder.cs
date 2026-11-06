using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;
using RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;

namespace RimeLib.Shader.Frostbite2_0;

/// <summary>Reads, writes and merges shader databases through the <see cref="ShaderDatabaseContainer"/> structs.</summary>
public class ShaderDatabaseBuilder : IShaderDatabaseBuilder
{
    public virtual EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    public virtual bool ShipsEveryShader => false;

    protected virtual ShaderDatabaseContainer CreateContainer() => new();

    protected virtual ShaderDatabaseMerger CreateMerger(IEnumerable<uint> p_Wanted, bool p_AllSolutions) => new(p_Wanted, p_AllSolutions);

    private ShaderDatabaseContainer Read(byte[] p_Data)
    {
        var s_Container = CreateContainer();
        s_Container.Deserialize(p_Data);
        return s_Container;
    }

    private static byte[] Write(ShaderDatabaseContainer p_Container) => p_Container.Serialize(out var s_Data) ? s_Data : [];

    public byte[] RoundTrip(byte[] p_Data) => Write(Read(p_Data));

    public string Describe(byte[] p_Data) => string.Join("\n", Read(p_Data).Databases.Values.Select(p_D =>
        $"render path {p_D.RenderPath}: {p_D.ShaderInfos.Count} shaders, " +
        string.Join(", ", p_D.PoolCounts().Select(p_P => $"{p_P.Count} {p_P.Name}")) +
        $", {p_D.Declarations.Count} declarations"));

    public ISet<uint> GetShaderKeys(byte[] p_Data) => Read(p_Data).Databases.Values.SelectMany(p_D => p_D.ShaderInfos).Select(p_S => p_S.Key).ToHashSet();

    public uint GetShaderKey(string p_Name) => RimeLib.Frostbite.Utils.HashQuickLowerCase(p_Name);

    public ShaderDeclarations GetDeclarations(byte[] p_Data)
    {
        var s_ByShader = new Dictionary<uint, HashSet<uint>>();
        var s_Declarations = new Dictionary<uint, byte[]>();
        var s_Mismatches = 0;
        foreach (var s_Database in Read(p_Data).Databases.Values)
        {
            foreach (var s_Shader in s_Database.ShaderInfos)
            {
                if (!s_ByShader.TryGetValue(s_Shader.Key, out var s_Hashes))
                    s_ByShader[s_Shader.Key] = s_Hashes = new HashSet<uint>();
                foreach (var s_Solution in s_Shader.Solutions)
                {
                    s_Hashes.Add(s_Solution.State.GeometryDeclarationHash);
                    if (s_Solution.State.Hash != s_Solution.StateHash)
                        ++s_Mismatches;
                }
            }

            foreach (var s_Declaration in s_Database.Declarations)
            {
                if (s_Declaration.Desc.Serialize(out var s_Bytes))
                    s_Declarations.TryAdd(s_Declaration.Hash, s_Bytes);
            }
        }

        return new ShaderDeclarations(s_ByShader.ToDictionary(p_P => p_P.Key, p_P => (IReadOnlySet<uint>)p_P.Value), s_Declarations, s_Mismatches);
    }

    public byte[] Build(IEnumerable<Func<byte[]>> p_Sources, IReadOnlyCollection<string> p_Shaders, bool p_AllSolutions,
        TextWriter p_Log, out List<string> p_Missing)
    {
        var s_Keys = p_Shaders.GroupBy(GetShaderKey).ToDictionary(p_G => p_G.Key, p_G => p_G.First());
        var s_Merger = CreateMerger(s_Keys.Keys, p_AllSolutions);

        foreach (var s_Load in p_Sources)
        {
            // Without other solutions to collect, the sources stop mattering once every shader is found.
            if (!p_AllSolutions && s_Merger.Found.Count() == s_Keys.Count)
                break;
            s_Merger.Add(Read(s_Load()));
        }

        var s_Found = s_Merger.Found.ToHashSet();
        p_Missing = s_Keys.Where(p_K => !s_Found.Contains(p_K.Key)).Select(p_K => p_K.Value).OrderBy(p_N => p_N).ToList();
        if (s_Merger.InfoConflicts.Count > 0)
            p_Log.WriteLine($"{s_Merger.InfoConflicts.Count} shader(s) differ in type, flags or textures between sources; the first source's are kept.");

        var s_Result = s_Merger.Result(CreateContainer());
        p_Log.WriteLine(string.Join("\n", s_Result.Databases.Values.Select(p_D => $"render path {p_D.RenderPath}: {p_D.ShaderInfos.Count} shaders, {p_D.Solutions.Count} solutions.")));
        return Write(s_Result);
    }

    public void Compare(byte[] p_Built, byte[] p_Reference, IReadOnlyDictionary<uint, string> p_Names, TextWriter p_Writer)
    {
        var s_Built = Read(p_Built);
        var s_Reference = Read(p_Reference);
        string Name(uint p_Key) => p_Names.TryGetValue(p_Key, out var s_N) ? s_N : $"0x{p_Key:X8}";

        foreach (var s_Ref in s_Reference.Databases.Values)
        {
            if (!s_Built.Databases.TryGetValue(s_Ref.RenderPath, out var s_Own))
            {
                p_Writer.WriteLine($"render path {s_Ref.RenderPath}: missing.");
                continue;
            }

            var s_OwnShaders = Fingerprints(s_Own);
            var s_RefShaders = Fingerprints(s_Ref);
            var s_Missing = s_RefShaders.Keys.Where(p_K => !s_OwnShaders.ContainsKey(p_K)).ToList();
            var s_Extra = s_OwnShaders.Keys.Where(p_K => !s_RefShaders.ContainsKey(p_K)).ToList();

            int s_Same = 0, s_MissingSolutions = 0, s_ExtraSolutions = 0, s_Different = 0, s_InfoDifferent = 0;
            foreach (var (s_Key, (s_RefInfo, s_RefSolutions)) in s_RefShaders)
            {
                if (!s_OwnShaders.TryGetValue(s_Key, out var s_Mine))
                    continue;

                if (s_Mine.Info != s_RefInfo)
                    s_InfoDifferent++;

                foreach (var (s_State, s_Print) in s_RefSolutions)
                {
                    if (!s_Mine.Solutions.TryGetValue(s_State, out var s_MinePrint))
                        s_MissingSolutions++;
                    else if (s_MinePrint != s_Print)
                        s_Different++;
                    else
                        s_Same++;
                }

                s_ExtraSolutions += s_Mine.Solutions.Keys.Count(p_S => !s_RefSolutions.ContainsKey(p_S));
            }

            p_Writer.WriteLine($"render path {s_Ref.RenderPath}: {s_RefShaders.Count} shaders in the reference, {s_OwnShaders.Count} built, {s_Missing.Count} missing, {s_Extra.Count} extra; " +
                $"of the shared ones {s_InfoDifferent} with other info; solutions: {s_Same} identical, {s_Different} different, {s_MissingSolutions} missing, {s_ExtraSolutions} extra.");
            foreach (var s_Name in s_Missing.Select(Name).OrderBy(p_N => p_N))
                p_Writer.WriteLine($"  MISSING {s_Name}");
            foreach (var s_Name in s_Extra.Select(Name).OrderBy(p_N => p_N))
                p_Writer.WriteLine($"  EXTRA {s_Name}");
        }
    }

    /// <summary>Per shader a hash of its entry and, per solution state hash, a hash of the solution with everything it uses.</summary>
    private Dictionary<uint, (string Info, Dictionary<ulong, string> Solutions)> Fingerprints(ShaderDatabase p_Database)
    {
        var s_Result = new Dictionary<uint, (string, Dictionary<ulong, string>)>();
        foreach (var s_Shader in p_Database.ShaderInfos)
        {
            var s_Info = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Info))
                s_Shader.SerializeInfo(s_Writer);

            var s_Solutions = new Dictionary<ulong, string>();
            foreach (var s_Index in s_Shader.SolutionIndices)
                s_Solutions[p_Database.Solutions[s_Index].StateHash] = Fingerprint(p_Database, p_Database.Solutions[s_Index]);
            s_Result[s_Shader.Key] = (Convert.ToHexString(s_Info.ToArray()), s_Solutions);
        }

        return s_Result;
    }

    /// <summary>
    /// A hash of a solution with its indices replaced by what they point at: the solution with its
    /// indices cleared, each record it uses (permutations with their own indices replaced the same
    /// way), its state and its geometry declaration.
    /// </summary>
    private string Fingerprint(ShaderDatabase p_Database, ShaderSolution p_Solution)
    {
        using var s_Hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA1);
        void Add(IFbSerializable? p_Record)
        {
            s_Hash.AppendData(p_Record == null ? [1] : [0]);
            if (p_Record != null && p_Record.Serialize(out var s_Data))
                s_Hash.AppendData(s_Data);
        }

        void AddPermutation(ShaderPermutation? p_Permutation)
        {
            if (p_Permutation == null)
            {
                Add(null);
                return;
            }

            var s_Copy = ShaderDatabase.Clone(p_Permutation);
            s_Copy.ConstantIndex = s_Copy.ConstantFunctionIndex = s_Copy.TextureFunctionIndex = 0;
            Add(s_Copy);
            Add(p_Permutation.Constant);
            Add(p_Permutation.ConstantFunction);
            Add(p_Permutation.TextureFunction);
        }

        var s_Solution = ShaderDatabase.Clone(p_Solution);
        ClearIndices(s_Solution);
        Add(s_Solution);
        AddPermutation(p_Solution.VertexPermutation);
        AddPermutation(p_Solution.PixelPermutation);
        Add(p_Solution.GeometryPermutation);
        foreach (var s_Permutation in StagePermutations(p_Solution))
            AddPermutation(s_Permutation);
        Add(p_Solution.VertexConstants);
        Add(p_Solution.PixelConstants);
        Add(p_Solution.State);
        foreach (var s_Declaration in p_Database.Declarations.Where(p_D => p_D.Hash == p_Solution.State.GeometryDeclarationHash))
            Add(s_Declaration);

        return Convert.ToHexString(s_Hash.GetHashAndReset());
    }

    /// <summary>Sets a solution's indices to zero, so only what they point at tells solutions apart.</summary>
    protected virtual void ClearIndices(ShaderSolution p_Solution)
    {
        p_Solution.VertexPermutationIndex = p_Solution.PixelPermutationIndex = p_Solution.GeometryPermutationIndex = 0;
        p_Solution.VertexConstantsIndex = p_Solution.PixelConstantsIndex = 0;
    }

    /// <summary>The permutations of the stages a later engine adds, in solution order.</summary>
    protected virtual IEnumerable<ShaderPermutation?> StagePermutations(ShaderSolution p_Solution) => [];
}
