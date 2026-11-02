using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;
using RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

/// <summary>
/// Collects shaders from several shader databases into one. Each shader brings its solutions and
/// what they use (permutations, constant blocks, function blocks, geometry declarations); records
/// with the same content are stored once.
/// </summary>
public class ShaderDatabaseMerger
{
    /// <summary>A record's bytes as a dictionary key.</summary>
    protected sealed class Bytes : IEquatable<Bytes>
    {
        private readonly byte[] m_Data;
        private readonly int m_Hash;

        public Bytes(params IFbSerializable[] p_Records)
        {
            m_Data = p_Records.SelectMany(p_R => p_R.Serialize(out var s_Data) ? s_Data : []).ToArray();
            var s_Hash = new HashCode();
            s_Hash.AddBytes(m_Data);
            m_Hash = s_Hash.ToHashCode();
        }

        public bool Equals(Bytes? p_Other) => p_Other != null && m_Hash == p_Other.m_Hash && m_Data.AsSpan().SequenceEqual(p_Other.m_Data);
        public override bool Equals(object? p_Other) => Equals(p_Other as Bytes);
        public override int GetHashCode() => m_Hash;
    }

    /// <summary>One render path being built.</summary>
    protected sealed class Output
    {
        public ShaderDatabase Database { get; init; } = null!;
        public Dictionary<uint, SurfaceShaderInfo> Shaders { get; } = new();
        public Dictionary<uint, HashSet<ulong>> ShaderStates { get; } = new();
        public HashSet<uint> Declarations { get; } = new();

        /// <summary>Per pool, the index of each record stored, by content.</summary>
        public Dictionary<object, Dictionary<Bytes, int>> Seen { get; } = new(ReferenceEqualityComparer.Instance);
    }

    /// <summary>Copies the records one source render path's solutions use, remembering what it already copied.</summary>
    protected sealed class Copier
    {
        private readonly Dictionary<(object Pool, long Index), long> m_Copied = new();

        public ShaderDatabase Source { get; }
        public Output Output { get; }

        public Copier(ShaderDatabase p_Source, Output p_Output)
        {
            Source = p_Source;
            Output = p_Output;
        }

        /// <summary>The index in <paramref name="p_Into"/> of a copy of the record at <paramref name="p_Index"/>, -1 for none.</summary>
        public long Copy<T>(List<T> p_From, List<T> p_Into, long p_Index, Action<T>? p_Remap = null) where T : IFbSerializable
        {
            if (p_Index == -1)
                return -1;

            if (m_Copied.TryGetValue((p_From, p_Index), out var s_New))
                return s_New;

            var s_Record = ShaderDatabase.Clone(p_From[(int)p_Index]);
            p_Remap?.Invoke(s_Record);
            s_New = Store(p_Into, new Bytes(s_Record), () => p_Into.Add(s_Record));
            m_Copied[(p_From, p_Index)] = s_New;
            return s_New;
        }

        /// <summary>A permutation's copy, its constant and function blocks copied with it.</summary>
        public long CopyPermutation<T>(List<T> p_From, List<T> p_Into, long p_Index) where T : ShaderPermutation =>
            Copy(p_From, p_Into, p_Index, p_Permutation =>
            {
                p_Permutation.ConstantIndex = (int)Copy(Source.Constants, Output.Database.Constants, p_Permutation.ConstantIndex);
                p_Permutation.ConstantFunctionIndex = (int)Copy(Source.ConstantFunctions, Output.Database.ConstantFunctions, p_Permutation.ConstantFunctionIndex);
                p_Permutation.TextureFunctionIndex = (int)Copy(Source.TextureFunctions, Output.Database.TextureFunctions, p_Permutation.TextureFunctionIndex);
            });

        /// <summary>The index of a stored record with the same content, or of this one, added.</summary>
        public int Store(object p_Pool, Bytes p_Key, Action p_Add)
        {
            if (!Output.Seen.TryGetValue(p_Pool, out var s_Seen))
                Output.Seen[p_Pool] = s_Seen = new Dictionary<Bytes, int>();

            if (s_Seen.TryGetValue(p_Key, out var s_Index))
                return s_Index;

            s_Index = s_Seen.Count;
            s_Seen[p_Key] = s_Index;
            p_Add();
            return s_Index;
        }
    }

    private readonly HashSet<uint> m_Wanted;
    private readonly bool m_AllSolutions;
    private readonly List<Output> m_Outputs = new();

    /// <summary>Shaders whose entry (type, flags, textures) differs between sources; the first source's is kept.</summary>
    public HashSet<uint> InfoConflicts { get; } = new();

    /// <param name="p_Wanted">Shader keys (lowercase name hashes).</param>
    /// <param name="p_AllSolutions">Take a shader's solutions from every source, not just the first that has it.</param>
    public ShaderDatabaseMerger(IEnumerable<uint> p_Wanted, bool p_AllSolutions)
    {
        m_Wanted = p_Wanted.ToHashSet();
        m_AllSolutions = p_AllSolutions;
    }

    public IEnumerable<uint> Found => m_Outputs.SelectMany(p_O => p_O.Shaders.Keys).Distinct();

    /// <summary>Takes the wanted shaders from one source.</summary>
    public void Add(ShaderDatabaseContainer p_Source)
    {
        foreach (var s_Source in p_Source.Databases.Values)
        {
            var s_Output = m_Outputs.FirstOrDefault(p_O => p_O.Database.RenderPath == s_Source.RenderPath);
            if (s_Output == null)
                m_Outputs.Add(s_Output = new Output { Database = s_Source.CreateEmpty() });

            CopyShaders(new Copier(s_Source, s_Output));
        }
    }

    /// <summary>The merged databases, with each shader table sorted by key.</summary>
    public ShaderDatabaseContainer Result(ShaderDatabaseContainer p_Into)
    {
        p_Into.Databases.Clear();
        foreach (var s_Output in m_Outputs)
        {
            s_Output.Database.ShaderInfos = s_Output.Shaders.Values.OrderBy(p_S => p_S.Key).ToList();
            s_Output.Database.Resolve();
            p_Into.Databases.Add(s_Output.Database.RenderPath, s_Output.Database);
        }

        return p_Into;
    }

    private void CopyShaders(Copier p_Copier)
    {
        foreach (var s_Shader in p_Copier.Source.ShaderInfos)
        {
            if (!m_Wanted.Contains(s_Shader.Key))
                continue;

            if (p_Copier.Output.Shaders.TryGetValue(s_Shader.Key, out var s_Into))
            {
                if (!InfoBytes(s_Into).AsSpan().SequenceEqual(InfoBytes(s_Shader)))
                    InfoConflicts.Add(s_Shader.Key);
                if (!m_AllSolutions)
                    continue;
            }
            else
            {
                s_Into = ShaderDatabase.Clone(s_Shader);
                s_Into.SolutionIndices.Clear();
                p_Copier.Output.Shaders[s_Shader.Key] = s_Into;
                p_Copier.Output.ShaderStates[s_Shader.Key] = new HashSet<ulong>();
            }

            var s_States = p_Copier.Output.ShaderStates[s_Shader.Key];
            foreach (var s_Index in s_Shader.SolutionIndices)
            {
                if (!s_States.Add(p_Copier.Source.Solutions[s_Index].StateHash))
                    continue;

                var s_New = CopySolution(p_Copier, s_Index);
                if (s_New > ushort.MaxValue)
                    throw new InvalidOperationException("More solutions than a shader database can index.");
                s_Into.SolutionIndices.Add((ushort)s_New);
            }
        }
    }

    private static byte[] InfoBytes(SurfaceShaderInfo p_Info)
    {
        var s_Stream = new System.IO.MemoryStream();
        using (var s_Writer = new RimeLib.IO.RimeWriter(s_Stream))
            p_Info.SerializeInfo(s_Writer);
        return s_Stream.ToArray();
    }

    private int CopySolution(Copier p_Copier, int p_Index)
    {
        var s_Source = p_Copier.Source;
        var s_Into = p_Copier.Output.Database;

        var s_Solution = ShaderDatabase.Clone(s_Source.Solutions[p_Index]);
        var s_State = ShaderDatabase.Clone(s_Source.Solutions[p_Index].State);
        s_Solution.VertexPermutationIndex = p_Copier.CopyPermutation(s_Source.VertexPermutations, s_Into.VertexPermutations, s_Solution.VertexPermutationIndex);
        s_Solution.PixelPermutationIndex = p_Copier.CopyPermutation(s_Source.PixelPermutations, s_Into.PixelPermutations, s_Solution.PixelPermutationIndex);
        s_Solution.GeometryPermutationIndex = p_Copier.Copy(s_Source.GeometryPermutations, s_Into.GeometryPermutations, s_Solution.GeometryPermutationIndex);
        CopyStages(p_Copier, s_Solution);
        s_Solution.VertexConstantsIndex = p_Copier.Copy(s_Source.Constants, s_Into.Constants, s_Solution.VertexConstantsIndex);
        s_Solution.PixelConstantsIndex = p_Copier.Copy(s_Source.Constants, s_Into.Constants, s_Solution.PixelConstantsIndex);

        if (p_Copier.Output.Declarations.Add(s_State.GeometryDeclarationHash))
            s_Into.Declarations.AddRange(s_Source.Declarations.Where(p_D => p_D.Hash == s_State.GeometryDeclarationHash).Select(ShaderDatabase.Clone));

        return p_Copier.Store(s_Into.Solutions, new Bytes(s_Solution, s_State), () =>
        {
            s_Solution.State = s_State;
            s_Into.Solutions.Add(s_Solution);
        });
    }

    /// <summary>Copies the permutations of the stages a later engine adds and points the solution at the copies.</summary>
    protected virtual void CopyStages(Copier p_Copier, ShaderSolution p_Solution)
    {
    }
}
