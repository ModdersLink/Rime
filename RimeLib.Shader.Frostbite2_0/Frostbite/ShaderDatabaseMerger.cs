using System;
using System.Collections.Generic;
using System.Linq;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

/// <summary>
/// Collects shaders from several shader databases into one. Each shader brings its solutions and
/// what they use (permutations, constants, functions, geometry declarations); identical records
/// are stored once.
/// </summary>
public class ShaderDatabaseMerger
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
        public ShaderDatabaseImage.Database Database { get; init; } = null!;
        public Dictionary<uint, ShaderDatabaseImage.ShaderEntry> Shaders { get; } = new();
        public Dictionary<uint, HashSet<ulong>> ShaderStates { get; } = new();
        public Dictionary<Bytes, int> Constants { get; } = new();
        public Dictionary<Bytes, int> ConstantFunctions { get; } = new();
        public Dictionary<Bytes, int> TextureFunctions { get; } = new();
        public Dictionary<Bytes, int> VertexPermutations { get; } = new();
        public Dictionary<Bytes, int> PixelPermutations { get; } = new();
        public Dictionary<Bytes, int> GeometryPermutations { get; } = new();
        public Dictionary<Bytes, int> Solutions { get; } = new();
        public HashSet<uint> Declarations { get; } = new();
    }

    private readonly HashSet<uint> m_Wanted;
    private readonly bool m_AllSolutions;
    private readonly List<Output> m_Outputs = new();

    /// <summary>Shaders whose type, flags or textures differ between sources (the first source's are kept).</summary>
    public HashSet<uint> InfoConflicts { get; } = new();

    /// <param name="p_Wanted">Shader keys (lowercase name hashes).</param>
    /// <param name="p_AllSolutions">Take a shader's solutions from every source, not just the first that has it.</param>
    public ShaderDatabaseMerger(IEnumerable<uint> p_Wanted, bool p_AllSolutions)
    {
        m_Wanted = p_Wanted.ToHashSet();
        m_AllSolutions = p_AllSolutions;
    }

    public IEnumerable<uint> Found => m_Outputs.SelectMany(p_O => p_O.Shaders.Keys).Distinct();

    /// <summary>Takes the wanted shaders from one source. Returns how many solutions it added.</summary>
    public int Add(ShaderDatabaseImage p_Source)
    {
        var s_Added = 0;
        foreach (var s_Source in p_Source.Databases)
        {
            var s_Output = m_Outputs.FirstOrDefault(p_O => p_O.Database.RenderPathKey == s_Source.RenderPathKey);
            if (s_Output == null)
            {
                s_Output = new Output
                {
                    Database = new ShaderDatabaseImage.Database { RenderPathKey = s_Source.RenderPathKey, Version = s_Source.Version, RenderPath = s_Source.RenderPath },
                };
                m_Outputs.Add(s_Output);
            }

            s_Added += new Copier(s_Source, s_Output).CopyShaders(m_Wanted, m_AllSolutions, InfoConflicts);
        }

        return s_Added;
    }

    public ShaderDatabaseImage Result()
    {
        var s_Image = new ShaderDatabaseImage();
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
        private readonly ShaderDatabaseImage.Database m_Source;
        private readonly Output m_Output;
        private readonly Dictionary<(int Pool, long Index), int> m_Copied = new();

        public Copier(ShaderDatabaseImage.Database p_Source, Output p_Output)
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
                    s_Into = new ShaderDatabaseImage.ShaderEntry { Key = s_Shader.Key, Info = s_Shader.Info };
                    m_Output.Shaders[s_Shader.Key] = s_Into;
                    m_Output.ShaderStates[s_Shader.Key] = new HashSet<ulong>();
                }

                var s_States = m_Output.ShaderStates[s_Shader.Key];
                foreach (var s_Index in s_Shader.Solutions)
                {
                    if (!s_States.Add(m_Source.Solutions[s_Index].StateHash))
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
            var s_Solution = new ShaderDatabaseImage.Solution { Bytes = (byte[])m_Source.Solutions[p_Index].Bytes.Clone() };
            var s_State = m_Source.States[p_Index];

            Remap(s_Solution, 0, CopyVertexPermutation);
            Remap(s_Solution, 1, CopyPixelPermutation);
            Remap(s_Solution, 2, CopyGeometryPermutation);
            Remap(s_Solution, 3, CopyConstant);
            Remap(s_Solution, 4, CopyConstant);

            var s_Declaration = BitConverter.ToUInt32(s_State, 8);
            if (m_Output.Declarations.Add(s_Declaration))
            {
                foreach (var s_Entry in m_Source.Declarations.Where(p_D => p_D.Hash == s_Declaration))
                    m_Output.Database.Declarations.Add(s_Entry);
            }

            return Store(m_Output.Solutions, new Bytes(s_Solution.Bytes, s_State), () =>
            {
                m_Output.Database.Solutions.Add(s_Solution);
                m_Output.Database.States.Add(s_State);
            });
        }

        private static void Remap(ShaderDatabaseImage.Solution p_Solution, int p_Slot, Func<long, int> p_Copy)
        {
            var s_Index = p_Solution.GetIndex(p_Slot);
            if (s_Index != -1)
                p_Solution.SetIndex(p_Slot, p_Copy(s_Index));
        }

        private int CopyVertexPermutation(long p_Index) => CopyPermutation(1, p_Index, m_Source.VertexPermutations, m_Output.VertexPermutations, m_Output.Database.VertexPermutations);
        private int CopyPixelPermutation(long p_Index) => CopyPermutation(2, p_Index, m_Source.PixelPermutations, m_Output.PixelPermutations, m_Output.Database.PixelPermutations);

        private int CopyPermutation(int p_Pool, long p_Index, List<ShaderDatabaseImage.Permutation> p_From,
            Dictionary<Bytes, int> p_Seen, List<ShaderDatabaseImage.Permutation> p_Into)
        {
            return Once(p_Pool, p_Index, () =>
            {
                var s_Source = p_From[(int)p_Index];
                var s_Copy = new ShaderDatabaseImage.Permutation
                {
                    Head = s_Source.Head,
                    Constant = (uint)CopyConstant(s_Source.Constant),
                    ConstantFunction = (uint)CopyRecord(3, s_Source.ConstantFunction, m_Source.ConstantFunctions, m_Output.ConstantFunctions, m_Output.Database.ConstantFunctions),
                    TextureFunction = (uint)CopyRecord(4, s_Source.TextureFunction, m_Source.TextureFunctions, m_Output.TextureFunctions, m_Output.Database.TextureFunctions),
                    Tail = s_Source.Tail,
                };

                var s_Key = new Bytes(s_Copy.Head, BitConverter.GetBytes(s_Copy.Constant), BitConverter.GetBytes(s_Copy.ConstantFunction),
                    BitConverter.GetBytes(s_Copy.TextureFunction), s_Copy.Tail);
                return Store(p_Seen, s_Key, () => p_Into.Add(s_Copy));
            });
        }

        private int CopyGeometryPermutation(long p_Index) =>
            CopyRecord(5, p_Index, m_Source.GeometryPermutations, m_Output.GeometryPermutations, m_Output.Database.GeometryPermutations);

        private int CopyConstant(long p_Index) =>
            CopyRecord(6, p_Index, m_Source.Constants, m_Output.Constants, m_Output.Database.Constants);

        private int CopyRecord(int p_Pool, long p_Index, List<byte[]> p_From, Dictionary<Bytes, int> p_Seen, List<byte[]> p_Into)
        {
            return Once(p_Pool, p_Index, () =>
            {
                var s_Record = p_From[(int)p_Index];
                return Store(p_Seen, new Bytes(s_Record), () => p_Into.Add(s_Record));
            });
        }

        private int Once(int p_Pool, long p_Index, Func<int> p_Copy)
        {
            if (!m_Copied.TryGetValue((p_Pool, p_Index), out var s_New))
                m_Copied[(p_Pool, p_Index)] = s_New = p_Copy();
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
