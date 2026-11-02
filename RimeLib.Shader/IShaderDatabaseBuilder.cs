using System;
using System.Collections.Generic;
using System.IO;
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
    }
}
