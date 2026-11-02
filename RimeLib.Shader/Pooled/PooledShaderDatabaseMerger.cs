using System;
using System.Collections.Generic;
using System.Linq;

namespace RimeLib.Shader.Pooled;

/// <summary>
/// Collects shaders from several shader databases into one. Each shader brings its solutions and
/// what they use (permutations, constants, functions, geometry declarations); identical records
/// are stored once.
/// </summary>
public sealed class PooledShaderDatabaseMerger
{
    private sealed class Bytes : IEquatable<Bytes>
    {
        private readonly byte[] m_Data;
        private readonly int m_Hash;

        public Bytes(params byte[][] p_Parts)
        {
            m_Data = p_Parts.Length == 1 ? p_Parts[0] : p_Parts.SelectMany(p_P => p_P).ToArray();
            var s_Hash = new HashCode();
            s_Hash.AddBytes(m_Data);
            m_Hash = s_Hash.ToHashCode();
        }

        public bool Equals(Bytes? p_Other) => p_Other != null && m_Hash == p_Other.m_Hash && m_Data.AsSpan().SequenceEqual(p_Other.m_Data);
        public override bool Equals(object? p_Other) => Equals(p_Other as Bytes);
        public override int GetHashCode() => m_Hash;
    }

    private sealed class Output
    {
        public PooledDatabase Database { get; init; } = null!;
        public Dictionary<uint, PooledShaderEntry> Shaders { get; } = new();
        public Dictionary<uint, HashSet<ulong>> ShaderStates { get; } = new();

        /// <summary>Per pool, the index of each record stored (for the solutions, record and state).</summary>
        public Dictionary<Bytes, int>[] Seen { get; init; } = [];

        public HashSet<uint> Declarations { get; } = new();
    }

    private readonly HashSet<uint> m_Wanted;
    private readonly bool m_AllSolutions;
    private readonly List<Output> m_Outputs = new();

    /// <summary>Shaders whose info (type, flags, textures) differs between sources; the first source's is kept.</summary>
    public HashSet<uint> InfoConflicts { get; } = new();

    /// <param name="p_Wanted">Shader keys (lowercase name hashes).</param>
    /// <param name="p_AllSolutions">Take a shader's solutions from every source, not just the first that has it.</param>
    public PooledShaderDatabaseMerger(IEnumerable<uint> p_Wanted, bool p_AllSolutions)
    {
        m_Wanted = p_Wanted.ToHashSet();
        m_AllSolutions = p_AllSolutions;
    }

    public IEnumerable<uint> Found => m_Outputs.SelectMany(p_O => p_O.Shaders.Keys).Distinct();

    /// <summary>Takes the wanted shaders from one source. Returns how many solutions it added.</summary>
    public int Add(PooledShaderDatabaseImage p_Source)
    {
        var s_Added = 0;
        foreach (var s_Source in p_Source.Databases)
        {
            var s_Output = m_Outputs.FirstOrDefault(p_O => p_O.Database.RenderPathKey == s_Source.RenderPathKey);
            if (s_Output == null)
            {
                s_Output = new Output
                {
                    Database = s_Source.CreateEmpty(),
                    Seen = s_Source.Pools.Select(_ => new Dictionary<Bytes, int>()).ToArray(),
                };
                m_Outputs.Add(s_Output);
            }

            s_Added += new Copier(s_Source, s_Output).CopyShaders(m_Wanted, m_AllSolutions, InfoConflicts);
        }

        return s_Added;
    }

    public PooledShaderDatabaseImage Result()
    {
        var s_Image = new PooledShaderDatabaseImage();
        foreach (var s_Output in m_Outputs)
        {
            s_Output.Database.Shaders.Clear();
            s_Output.Database.Shaders.AddRange(s_Output.Shaders.Values.OrderBy(p_S => p_S.Key));
            s_Image.Databases.Add(s_Output.Database);
        }

        return s_Image;
    }

    /// <summary>Copies records of one source render path, remembering what it already copied.</summary>
    private sealed class Copier
    {
        private readonly PooledDatabase m_Source;
        private readonly Output m_Output;
        private readonly Dictionary<(int Pool, long Index), int> m_Copied = new();

        public Copier(PooledDatabase p_Source, Output p_Output)
        {
            m_Source = p_Source;
            m_Output = p_Output;
        }

        public int CopyShaders(HashSet<uint> p_Wanted, bool p_AllSolutions, HashSet<uint> p_InfoConflicts)
        {
            var s_Added = 0;
            foreach (var s_Shader in m_Source.Shaders)
            {
                if (!p_Wanted.Contains(s_Shader.Key))
                    continue;

                if (m_Output.Shaders.TryGetValue(s_Shader.Key, out var s_Into))
                {
                    if (!s_Into.Info.AsSpan().SequenceEqual(s_Shader.Info))
                        p_InfoConflicts.Add(s_Shader.Key);
                    if (!p_AllSolutions)
                        continue;
                }
                else
                {
                    s_Into = new PooledShaderEntry { Key = s_Shader.Key, Info = s_Shader.Info };
                    m_Output.Shaders[s_Shader.Key] = s_Into;
                    m_Output.ShaderStates[s_Shader.Key] = new HashSet<ulong>();
                }

                var s_States = m_Output.ShaderStates[s_Shader.Key];
                foreach (var s_Index in s_Shader.Solutions)
                {
                    if (!s_States.Add(PooledDatabase.StateHash(m_Source.Solutions[s_Index])))
                        continue;

                    var s_New = CopySolution(s_Index);
                    if (s_New > ushort.MaxValue)
                        throw new Exception("More solutions than a shader database can index.");
                    s_Into.Solutions.Add((ushort)s_New);
                    s_Added++;
                }
            }

            return s_Added;
        }

        private int CopySolution(int p_Index)
        {
            var s_Solution = CopyRefs(m_Source.Solutions[p_Index]);
            var s_State = m_Source.States[p_Index];

            var s_Declaration = m_Source.DeclarationHash(p_Index);
            if (m_Output.Declarations.Add(s_Declaration))
            {
                foreach (var s_Entry in m_Source.Declarations.Where(p_D => p_D.Hash == s_Declaration))
                    m_Output.Database.Declarations.Add(s_Entry);
            }

            return Store(m_Output.Seen[^1], new Bytes(s_Solution.Bytes, s_State), () =>
            {
                m_Output.Database.Solutions.Add(s_Solution);
                m_Output.Database.States.Add(s_State);
            });
        }

        /// <summary>A copy of the record with its indices pointing at copies of what they index.</summary>
        private PooledRecord CopyRefs(PooledRecord p_Record)
        {
            if (p_Record.Refs.Count == 0)
                return p_Record;

            var s_Copy = p_Record.Clone();
            foreach (var s_Ref in s_Copy.Refs)
            {
                var s_Index = s_Copy.GetIndex(s_Ref);
                if (s_Index != -1)
                    s_Copy.SetIndex(s_Ref, CopyRecord(s_Ref.Pool, s_Index));
            }

            return s_Copy;
        }

        private int CopyRecord(int p_Pool, long p_Index)
        {
            if (m_Copied.TryGetValue((p_Pool, p_Index), out var s_New))
                return s_New;

            var s_Record = CopyRefs(m_Source.Pools[p_Pool][(int)p_Index]);
            s_New = Store(m_Output.Seen[p_Pool], new Bytes(s_Record.Bytes), () => m_Output.Database.Pools[p_Pool].Add(s_Record));
            m_Copied[(p_Pool, p_Index)] = s_New;
            return s_New;
        }

        /// <summary>The index of an identical record already stored, or of this one, added.</summary>
        private static int Store(Dictionary<Bytes, int> p_Seen, Bytes p_Key, Action p_Add)
        {
            if (p_Seen.TryGetValue(p_Key, out var s_Index))
                return s_Index;

            s_Index = p_Seen.Count;
            p_Seen[p_Key] = s_Index;
            p_Add();
            return s_Index;
        }
    }
}
