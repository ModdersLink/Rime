using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using RimeLib.Frostbite;
using RimeLib.Shader.Frostbite2_0.Frostbite;

namespace RimeLib.Shader.Frostbite2_0
{
    public class ShaderDatabaseBuilder : IShaderDatabaseBuilder
    {
        public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

        public byte[] RoundTrip(byte[] p_Data) => ShaderDatabaseImage.Read(p_Data).Write();

        public string Describe(byte[] p_Data) => string.Join("\n", ShaderDatabaseImage.Read(p_Data).Databases.Select(p_D =>
            $"render path {p_D.RenderPathKey}: {p_D.Shaders.Count} shaders, {p_D.Solutions.Count} solutions, {p_D.VertexPermutations.Count} vertex / {p_D.PixelPermutations.Count} pixel / {p_D.GeometryPermutations.Count} geometry permutations, {p_D.Constants.Count} constants, {p_D.Declarations.Count} declarations, {p_D.Trailing.Length} trailing bytes"));

        public ISet<uint> GetShaderKeys(byte[] p_Data) => ShaderDatabaseImage.Read(p_Data).Databases.SelectMany(p_D => p_D.Shaders).Select(p_S => p_S.Key).ToHashSet();

        public uint GetShaderKey(string p_Name) => RimeLib.Frostbite.Utils.HashQuickLowerCase(p_Name);

        public byte[] Build(IEnumerable<Func<byte[]>> p_Sources, IReadOnlyCollection<string> p_Shaders, bool p_AllSolutions,
            TextWriter p_Log, out List<string> p_Missing)
        {
            var s_Keys = p_Shaders.GroupBy(GetShaderKey).ToDictionary(p_G => p_G.Key, p_G => p_G.First());
            var s_Merger = new ShaderDatabaseMerger(s_Keys.Keys, p_AllSolutions);

            foreach (var s_Load in p_Sources)
            {
                // Without other solutions to collect, the sources stop mattering once every shader is found.
                if (!p_AllSolutions && s_Merger.Found.Count() == s_Keys.Count)
                    break;
                s_Merger.Add(ShaderDatabaseImage.Read(s_Load()));
            }

            var s_Found = s_Merger.Found.ToHashSet();
            p_Missing = s_Keys.Where(p_K => !s_Found.Contains(p_K.Key)).Select(p_K => p_K.Value).OrderBy(p_N => p_N).ToList();
            if (s_Merger.InfoConflicts.Count > 0)
                p_Log.WriteLine($"{s_Merger.InfoConflicts.Count} shader(s) differ in type, flags or textures between sources; the first source's are kept.");

            var s_Image = s_Merger.Result();
            p_Log.WriteLine(string.Join("\n", s_Image.Databases.Select(p_D => $"render path {p_D.RenderPathKey}: {p_D.Shaders.Count} shaders, {p_D.Solutions.Count} solutions.")));
            return s_Image.Write();
        }

        public void Compare(byte[] p_Built, byte[] p_Reference, IReadOnlyDictionary<uint, string> p_Names, TextWriter p_Writer)
        {
            var s_Built = ShaderDatabaseImage.Read(p_Built);
            var s_Reference = ShaderDatabaseImage.Read(p_Reference);
            string Name(uint p_Key) => p_Names.TryGetValue(p_Key, out var s_N) ? s_N : $"0x{p_Key:X8}";

            foreach (var s_Ref in s_Reference.Databases)
            {
                var s_Own = s_Built.Databases.FirstOrDefault(p_D => p_D.RenderPathKey == s_Ref.RenderPathKey);
                if (s_Own == null)
                {
                    p_Writer.WriteLine($"render path {s_Ref.RenderPathKey}: missing.");
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

                    if (!s_Mine.Info.AsSpan().SequenceEqual(s_RefInfo))
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

                p_Writer.WriteLine($"render path {s_Ref.RenderPathKey}: {s_RefShaders.Count} shaders in the reference, {s_OwnShaders.Count} built, {s_Missing.Count} missing, {s_Extra.Count} extra; " +
                    $"of the shared ones {s_InfoDifferent} with other info; solutions: {s_Same} identical, {s_Different} different, {s_MissingSolutions} missing, {s_ExtraSolutions} extra.");
                foreach (var s_Key in s_Missing.Select(Name).OrderBy(p_N => p_N))
                    p_Writer.WriteLine($"  MISSING {s_Key}");
                foreach (var s_Key in s_Extra.Select(Name).OrderBy(p_N => p_N))
                    p_Writer.WriteLine($"  EXTRA {s_Key}");
            }
        }

        /// <summary>Per shader its info and, per solution state hash, a hash of the solution with everything it uses.</summary>
        private static Dictionary<uint, (byte[] Info, Dictionary<ulong, string> Solutions)> Fingerprints(ShaderDatabaseImage.Database p_Database)
        {
            var s_Result = new Dictionary<uint, (byte[], Dictionary<ulong, string>)>();
            foreach (var s_Shader in p_Database.Shaders)
            {
                var s_Solutions = new Dictionary<ulong, string>();
                foreach (var s_Index in s_Shader.Solutions)
                    s_Solutions[p_Database.Solutions[s_Index].StateHash] = Fingerprint(p_Database, s_Index);
                s_Result[s_Shader.Key] = (s_Shader.Info, s_Solutions);
            }

            return s_Result;
        }

        private static string Fingerprint(ShaderDatabaseImage.Database p_Database, int p_Solution)
        {
            using var s_Hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA1);
            var s_Solution = new ShaderDatabaseImage.Solution { Bytes = (byte[])p_Database.Solutions[p_Solution].Bytes.Clone() };
            var s_Indices = Enumerable.Range(0, 5).Select(s_Solution.GetIndex).ToArray();
            for (var i = 0; i < 5; i++)
                s_Solution.SetIndex(i, 0);

            s_Hash.AppendData(s_Solution.Bytes);
            s_Hash.AppendData(p_Database.States[p_Solution]);

            var s_Declaration = BitConverter.ToUInt32(p_Database.States[p_Solution], 8);
            foreach (var (_, s_Desc) in p_Database.Declarations.Where(p_D => p_D.Hash == s_Declaration))
                s_Hash.AppendData(s_Desc);

            void Permutation(ShaderDatabaseImage.Permutation p_Permutation)
            {
                s_Hash.AppendData(p_Permutation.Head);
                s_Hash.AppendData(p_Database.Constants[(int)p_Permutation.Constant]);
                s_Hash.AppendData(p_Database.ConstantFunctions[(int)p_Permutation.ConstantFunction]);
                s_Hash.AppendData(p_Database.TextureFunctions[(int)p_Permutation.TextureFunction]);
                s_Hash.AppendData(p_Permutation.Tail);
            }

            for (var i = 0; i < 5; i++)
            {
                s_Hash.AppendData(BitConverter.GetBytes(s_Indices[i] == -1));
                if (s_Indices[i] == -1)
                    continue;

                switch (i)
                {
                    case 0: Permutation(p_Database.VertexPermutations[(int)s_Indices[i]]); break;
                    case 1: Permutation(p_Database.PixelPermutations[(int)s_Indices[i]]); break;
                    case 2: s_Hash.AppendData(p_Database.GeometryPermutations[(int)s_Indices[i]]); break;
                    default: s_Hash.AppendData(p_Database.Constants[(int)s_Indices[i]]); break;
                }
            }

            return Convert.ToHexString(s_Hash.GetHashAndReset());
        }
    }
}
