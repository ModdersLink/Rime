using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Content.Mounting;

namespace RimeLib.Shader
{
    /// <summary>Writes shader databases (the resource behind a level's <c>/shaderdb</c>).</summary>
    public interface IShaderDatabaseBuilder : IEngineInterface
    {
        /// <summary>Reads a database and writes it back unchanged, to check the writer.</summary>
        byte[] RoundTrip(byte[] p_Data);

        /// <summary>One line per render path: its shader, solution and permutation counts.</summary>
        string Describe(byte[] p_Data);

        /// <summary>
        /// A database holding the given shaders, taken from the sources in order: each shader comes
        /// from the first source that has it, and with <paramref name="p_AllSolutions"/> also gets
        /// the solutions only later sources have. Returns the shaders no source has in <paramref name="p_Missing"/>.
        /// </summary>
        byte[] Build(IEnumerable<Func<byte[]>> p_Sources, IReadOnlyCollection<string> p_Shaders, bool p_AllSolutions,
            TextWriter p_Log, out List<string> p_Missing);

        /// <summary>
        /// Compares two databases by content, whatever the record order: which shaders each has, and
        /// per shader which solutions, with what they use.
        /// </summary>
        void Compare(byte[] p_Built, byte[] p_Reference, IReadOnlyDictionary<uint, string> p_Names, TextWriter p_Writer);

        /// <summary>The keys of the shaders a database holds, across its render paths.</summary>
        ISet<uint> GetShaderKeys(byte[] p_Data);

        /// <summary>The key a database stores a shader under.</summary>
        uint GetShaderKey(string p_Name);

        /// <summary>
        /// Whether the bundle holding the database ships every shader it names, those only other
        /// bundles draw with included, rather than leaving those to the bundles that draw with them.
        /// </summary>
        bool ShipsEveryShader => false;

        /// <summary>The vertex declarations a database's solutions are for.</summary>
        ShaderDeclarations GetDeclarations(byte[] p_Data);
    }

    /// <summary>
    /// The vertex declarations shaders have solutions for: per shader key the declaration hashes,
    /// and each declaration as stored, by hash. A shader draws a mesh subset only with a solution
    /// for its declaration.
    /// </summary>
    /// <param name="StateHashMismatches">Solutions whose stored state hash is not their state's.</param>
    public sealed record ShaderDeclarations(
        IReadOnlyDictionary<uint, IReadOnlySet<uint>> ByShader,
        IReadOnlyDictionary<uint, byte[]> Declarations,
        int StateHashMismatches)
    {
        /// <summary>
        /// Per shader key the declarations with the skinning method of a solution for each, as
        /// <see cref="Skinned"/> packs them: a mesh draws with the solution for both.
        /// </summary>
        public IReadOnlyDictionary<uint, IReadOnlySet<ulong>> BySkinning { get; init; } = new Dictionary<uint, IReadOnlySet<ulong>>();

        /// <summary>Per shader key the declarations with the instancing method of a solution for each, packed alike.</summary>
        public IReadOnlyDictionary<uint, IReadOnlySet<ulong>> ByInstancing { get; init; } = new Dictionary<uint, IReadOnlySet<ulong>>();

        /// <summary>A declaration and a skinning method as one key.</summary>
        public static ulong Skinned(uint p_Declaration, int p_Skinning) => ((ulong)p_Declaration << 8) | (byte)p_Skinning;

        public static ShaderDeclarations Merge(IEnumerable<ShaderDeclarations> p_All)
        {
            var s_ByShader = new Dictionary<uint, HashSet<uint>>();
            var s_Declarations = new Dictionary<uint, byte[]>();
            var s_BySkinning = new Dictionary<uint, HashSet<ulong>>();
            var s_ByInstancing = new Dictionary<uint, HashSet<ulong>>();
            var s_Mismatches = 0;
            foreach (var s_One in p_All)
            {
                foreach (var (s_Key, s_Pairs) in s_One.ByInstancing)
                {
                    if (!s_ByInstancing.TryGetValue(s_Key, out var s_Known))
                        s_ByInstancing[s_Key] = s_Known = new HashSet<ulong>();
                    s_Known.UnionWith(s_Pairs);
                }

                foreach (var (s_Key, s_Pairs) in s_One.BySkinning)
                {
                    if (!s_BySkinning.TryGetValue(s_Key, out var s_Known))
                        s_BySkinning[s_Key] = s_Known = new HashSet<ulong>();
                    s_Known.UnionWith(s_Pairs);
                }

                foreach (var (s_Key, s_Hashes) in s_One.ByShader)
                {
                    if (!s_ByShader.TryGetValue(s_Key, out var s_Known))
                        s_ByShader[s_Key] = s_Known = new HashSet<uint>();
                    s_Known.UnionWith(s_Hashes);
                }

                foreach (var (s_Hash, s_Declaration) in s_One.Declarations)
                    s_Declarations.TryAdd(s_Hash, s_Declaration);
                s_Mismatches += s_One.StateHashMismatches;
            }

            return new ShaderDeclarations(s_ByShader.ToDictionary(p_P => p_P.Key, p_P => (IReadOnlySet<uint>)p_P.Value), s_Declarations, s_Mismatches)
            {
                BySkinning = s_BySkinning.ToDictionary(p_P => p_P.Key, p_P => (IReadOnlySet<ulong>)p_P.Value),
                ByInstancing = s_ByInstancing.ToDictionary(p_P => p_P.Key, p_P => (IReadOnlySet<ulong>)p_P.Value),
            };
        }

        /// <summary>Whether the shader has a solution for the declaration.</summary>
        public bool Draws(uint p_Shader, uint p_Declaration) => ByShader.TryGetValue(p_Shader, out var s_Hashes) && s_Hashes.Contains(p_Declaration);

        /// <summary>
        /// Whether the shader has a solution for the declaration with the skinning method, any where it is null: a
        /// skinned mesh's varies with its bones.
        /// </summary>
        public bool Draws(uint p_Shader, uint p_Declaration, int? p_Skinning) => p_Skinning is not { } s_Skinning
            ? Draws(p_Shader, p_Declaration)
            : BySkinning.TryGetValue(p_Shader, out var s_Pairs) && s_Pairs.Contains(Skinned(p_Declaration, s_Skinning));

        /// <summary>
        /// Whether the shader has a solution for the declaration with the skinning method and with the instancing method,
        /// either one any where null.
        /// </summary>
        public bool Draws(uint p_Shader, uint p_Declaration, int? p_Skinning, int? p_Instancing) =>
            Draws(p_Shader, p_Declaration, p_Skinning) && (p_Instancing is not { } s_Instancing ||
                ByInstancing.TryGetValue(p_Shader, out var s_Pairs) && s_Pairs.Contains(Skinned(p_Declaration, s_Instancing)));
    }
}
