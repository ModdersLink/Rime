using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Removes from this bundle every chunk that vanilla BF3 stores ONLY at SUPERBUNDLE level (a toc chunk-section entry, contained in NO bundle anywhere in the mounted game). Those are streaming-only payloads (voiceover/sound/video) the engine fetches by GUID at runtime from any MOUNTED superbundle's chunk section — they never load as part of a bundle, so shipping them is pure bloat (the resolver over-brings them, e.g. every language's voiceovers). Prints STRIP-SB <superbundle> lines: for each non-loc superbundle listed, the mod loader should ResourceManager:MountSuperBundle it at runtime (cheap toc mount, loads NO partitions) so the chunks stay fetchable; win32/loc/<lang> is always mounted by the game. Run AFTER resolve. No args.")]
    internal class StripSbLevelChunksCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = p_Context as BundleBuildingContext;
            if (s_Ctx == null)
            {
                p_Writer.WriteLine("strip_sblevel_chunks must run inside a bundle-building context.");
                return false;
            }

            var s_SbCtx = (SbBuildingContext)s_Ctx.Parent!;
            var s_BaseCtx = (BaseContext)s_SbCtx.Parent!;
            var s_Mounter = s_BaseCtx.GetMounters().Values.FirstOrDefault();
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("strip_sblevel_chunks: no mounter found.");
                return false;
            }

            long s_Bytes = 0;
            int s_Stripped = 0;
            var s_BySb = new Dictionary<string, (int Count, long Bytes)>();

            foreach (var s_Kv in s_Ctx.GetChunks().ToList())
            {
                var s_Id = s_Kv.Key;
                if (!s_Mounter.TryGetChunk(s_Id, out var s_Obj))
                    continue;   // generated (add_chunk/add_dds) or unknown -> keep

                // strip ONLY when NO variant anywhere is bundle-contained: a chunk that vanilla
                // never puts in a bundle cannot be needed at bundle-load time (it's streaming-only).
                // Chunks with any bundle-contained variant (texture/mesh data) are KEPT.
                var s_Variants = s_Obj.Variants.ToList();
                if (s_Variants.Count == 0 || s_Variants.Any(v => v.GetContainedBundle() != null))
                    continue;

                long s_Size = 0;
                try { s_Size = s_Kv.Value.GetSize(); } catch { }

                s_Ctx.RemoveChunk(s_Id);
                s_Stripped++; s_Bytes += s_Size;
                foreach (var s_Sb in s_Variants.Select(v => v.GetContainedSuperbundle()).Distinct())
                {
                    var s_T = s_BySb.TryGetValue(s_Sb, out var s_Cur) ? s_Cur : (0, 0L);
                    s_BySb[s_Sb] = (s_T.Item1 + 1, s_T.Item2 + s_Size);
                }
            }

            foreach (var s_Kv in s_BySb.OrderByDescending(p_K => p_K.Value.Bytes))
                p_Writer.WriteLine($"STRIP-SB {s_Kv.Key} ({s_Kv.Value.Count} chunks / {s_Kv.Value.Bytes / 1024 / 1024} MB)");
            p_Writer.WriteLine($"strip_sblevel_chunks: removed {s_Stripped} superbundle-level streaming chunk(s) / {s_Bytes / 1024 / 1024} MB from the bundle (runtime-fetchable from their mounted superbundles).");
            return true;
        }
    }
}
