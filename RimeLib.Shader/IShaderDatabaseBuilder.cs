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
        public static ShaderDeclarations Merge(IEnumerable<ShaderDeclarations> p_All)
        {
            var s_ByShader = new Dictionary<uint, HashSet<uint>>();
            var s_Declarations = new Dictionary<uint, byte[]>();
            var s_Mismatches = 0;
            foreach (var s_One in p_All)
            {
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

            return new ShaderDeclarations(s_ByShader.ToDictionary(p_P => p_P.Key, p_P => (IReadOnlySet<uint>)p_P.Value), s_Declarations, s_Mismatches);
        }

        /// <summary>Whether the shader has a solution for the declaration.</summary>
        public bool Draws(uint p_Shader, uint p_Declaration) => ByShader.TryGetValue(p_Shader, out var s_Hashes) && s_Hashes.Contains(p_Declaration);
    }
}
