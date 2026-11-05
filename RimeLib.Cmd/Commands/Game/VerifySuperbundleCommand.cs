using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Mounts a built superbundle next to the game and compares every partition, resource and chunk of its bundles, byte for byte, with what the game's bundles of the same name ship.")]
    public class VerifySuperbundleCommand : Command
    {
        [CommandArgument(Description = "The built superbundle's .sb file.")]
        public FileInfo? Path { get; set; }

        [CommandArgument(Description = "How many differences to list.", Optional = true)]
        public int List { get; set; } = 10;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (Path is not { Exists: true })
            {
                p_Writer.WriteLine("usage: verify_superbundle <built.sb> [list]");
                return false;
            }

            var s_Context = (GameContext)p_Context;
            var s_Mounter = s_Context.GetMounter();
            var s_Name = "verify/" + System.IO.Path.GetFileNameWithoutExtension(Path.Name) + "_" + DateTime.Now.Ticks;
            s_Context.MountStandaloneSuperbundle(s_Name, Path.FullName, true);

            var s_Problems = new List<string>();
            var s_Same = 0;
            var s_Bundles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            void Compare<T>(string p_Kind, string p_Name, IEnumerable<T> p_Variants) where T : IObjectVariant
            {
                var s_All = p_Variants.ToList();
                foreach (var s_Built in s_All.Where(p_V => p_V.GetContainedSuperbundle().Equals(s_Name, StringComparison.OrdinalIgnoreCase)))
                {
                    var s_Bundle = s_Built.GetContainedBundle();
                    if (s_Bundle != null)
                        s_Bundles.Add(s_Bundle);
                    var s_Retail = s_All.FirstOrDefault(p_V => !p_V.GetContainedSuperbundle().Equals(s_Name, StringComparison.OrdinalIgnoreCase)
                        && string.Equals(p_V.GetContainedBundle(), s_Bundle, StringComparison.OrdinalIgnoreCase));
                    string? s_Problem;
                    try
                    {
                        s_Problem = s_Retail == null ? "no retail namesake"
                            : Sha1Of(s_Built).Equals(Sha1Of(s_Retail)) ? null : "content differs";
                    }
                    catch (Exception s_Ex)
                    {
                        s_Problem = s_Ex.Message;
                    }

                    if (s_Problem == null)
                        ++s_Same;
                    else
                        s_Problems.Add($"{p_Kind} {p_Name} in {s_Bundle}: {s_Problem}");
                }
            }

            foreach (var (s_Key, s_Object) in s_Mounter.GetPartitions())
                Compare("partition", s_Key, s_Object.Variants);
            foreach (var (s_Key, s_Object) in s_Mounter.GetResources())
                Compare("resource", s_Key, s_Object.Variants);
            foreach (var (s_Key, s_Object) in s_Mounter.GetChunks())
                Compare("chunk", s_Key.ToString(), s_Object.Variants);

            p_Writer.WriteLine($"{s_Bundles.Count} bundle(s): {s_Same} object(s) identical to the game's, {s_Problems.Count} not.");
            foreach (var s_Problem in s_Problems.Take(List))
                p_Writer.WriteLine($"  {s_Problem}");
            return s_Problems.Count == 0;
        }

        private static RimeLib.Frostbite.Core.Sha1 Sha1Of(IReadableObject p_Object)
        {
            using var s_Reader = p_Object.GetReader();
            using var s_Hash = System.Security.Cryptography.SHA1.Create();
            return new RimeLib.Frostbite.Core.Sha1(s_Hash.ComputeHash(s_Reader));
        }
    }
}
