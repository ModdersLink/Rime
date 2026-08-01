using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Removes every chunk that vanilla stores only at superbundle level, since the engine fetches those by guid at runtime. Prints one STRIP-SB line per superbundle the loader then has to mount.")]
    internal class StripSbLevelChunksCommand : Command
    {
        // These are the voiceover, sound and video payloads: they have a toc chunk-section entry but
        // are contained in no bundle anywhere, so the engine only ever fetches them by guid from a
        // mounted superbundle's chunk section and shipping them is pure weight. The resolver brings
        // far too many of them, every language's voiceovers included.
        //
        // For each superbundle named in the STRIP-SB output, the mod loader has to mount that
        // superbundle at runtime so the chunks stay fetchable. That is a cheap toc mount which loads
        // no partitions. The loc superbundles need no such handling, as the game always mounts them.
        //
        // Run this after the resolve commands.
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = p_Context as BundleBuildingContext;
            if (s_BundleContext == null)
            {
                p_Writer.WriteLine("strip_sblevel_chunks must run inside a bundle-building context.");
                return false;
            }

            var s_SbBuildingContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbBuildingContext.Parent!;
            var s_Mounter = s_BaseContext.GetMounters().Values.FirstOrDefault();
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("strip_sblevel_chunks: no mounter found.");
                return false;
            }

            long s_TotalBytes = 0;
            var s_Stripped = 0;
            var s_BySuperbundle = new Dictionary<string, (int Count, long Bytes)>();

            foreach (var s_Kv in s_BundleContext.GetChunks().ToList())
            {
                var s_Id = s_Kv.Key;

                // Generated or unknown chunks are kept.
                if (!s_Mounter.TryGetChunk(s_Id, out var s_Chunk))
                    continue;

                // A chunk vanilla never puts in a bundle cannot be needed at bundle-load time, so strip
                // it only when no variant anywhere is bundle-contained.
                var s_Variants = s_Chunk.Variants.ToList();
                if (s_Variants.Count == 0 || s_Variants.Any(p_V => p_V.GetContainedBundle() != null))
                    continue;

                long s_Size = 0;
                try { s_Size = s_Kv.Value.GetSize(); } catch { }

                s_BundleContext.RemoveChunk(s_Id);
                s_Stripped++;
                s_TotalBytes += s_Size;

                foreach (var s_Sb in s_Variants.Select(p_V => p_V.GetContainedSuperbundle()).Distinct())
                {
                    var s_Current = s_BySuperbundle.TryGetValue(s_Sb, out var s_Existing) ? s_Existing : (0, 0L);
                    s_BySuperbundle[s_Sb] = (s_Current.Item1 + 1, s_Current.Item2 + s_Size);
                }
            }

            foreach (var s_Kv in s_BySuperbundle.OrderByDescending(p_K => p_K.Value.Bytes))
                p_Writer.WriteLine($"STRIP-SB {s_Kv.Key} ({s_Kv.Value.Count} chunks / {s_Kv.Value.Bytes / 1024 / 1024} MB)");

            p_Writer.WriteLine($"strip_sblevel_chunks: removed {s_Stripped} superbundle-level streaming chunk(s) / {s_TotalBytes / 1024 / 1024} MB from the bundle.");
            return true;
        }
    }
}
