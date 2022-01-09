using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the mounted duplicate chunks.")]
    public class ListDuplicateChunksCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Chunks = ((GameContext) p_Context).GetMountedChunkVariations();

            if (s_Chunks.Count == 0)
            {
                p_Writer.WriteLine("There are no mounted chunks.");
                return true;
            }

            p_Writer.WriteLine("Mounted chunks:");
            p_Writer.WriteLine();

            if (!s_Chunks.TryGetValue(new GUID("E274F7E2-0B2F-708A-1918-A61D02C78847"), out var s_Chunk))
                return true;

            foreach (var s_Variant in s_Chunk.Variants)
            {
                p_Writer.WriteLine($"Variant: {s_Variant.GetContainedSuperbundle()} {s_Variant.GetContainedBundle()}");
            }

            /*Parallel.ForEach(s_Chunks, (p_Chunk) =>
            {
                if (p_Chunk.Value.Variants.Count() == 1)
                    return;

                var s_Variants = new HashSet<string>();

                foreach (var s_Variant in p_Chunk.Value.Variants)
                {
                    using var s_MD5 = MD5.Create();
                    using var s_Reader = s_Variant.GetReader();
                    var s_HashBytes = s_MD5.ComputeHash(s_Reader);
                    var s_HashStr = Regex.Replace(BitConverter.ToString(s_HashBytes), @"[\0\-]", "", RegexOptions.None)
                        .ToLowerInvariant();
                    s_Variants.Add(s_HashStr + "-" + s_Variant.GetSize());
                }

                if (s_Variants.Count == 1)
                    return;

                p_Writer.WriteLine($"- {p_Chunk.Key.ToString("D")} ({string.Join(' ', s_Variants)})");
            });*/

            return true;
        }
    }
}