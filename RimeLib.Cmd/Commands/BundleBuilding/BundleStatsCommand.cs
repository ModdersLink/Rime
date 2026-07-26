using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Reports whether the current bundle's chunks/resources/partitions are CAS-REFERENCEABLE (Cas=true -> can be delivered as a SHA1 reference, tiny) or INLINE (Cas=false -> bytes must be embedded/idata, big). Prints counts + total OriginalSize per class. Answers: is the bloat inline-only source data, or cas-referenceable data the builder is needlessly inlining? No args.")]
    internal class BundleStatsCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = p_Context as BundleBuildingContext;
            if (s_Ctx == null) { p_Writer.WriteLine("run inside a bundle-building context."); return false; }

            long s_CasBytes = 0, s_InlineBytes = 0, s_UnknownBytes = 0;
            int s_Cas = 0, s_Inline = 0, s_Unknown = 0;

            void Tally(object p_Obj, long p_Size)
            {
                if (p_Obj is IObjectVariant s_V)
                {
                    if (s_V.Cas) { s_Cas++; s_CasBytes += p_Size; }
                    else { s_Inline++; s_InlineBytes += p_Size; }
                }
                else { s_Unknown++; s_UnknownBytes += p_Size; }   // file/memory-backed (generated) -> inline
            }

            foreach (var s_Kv in s_Ctx.GetChunks())   Tally(s_Kv.Value, s_Kv.Value.GetSize());
            foreach (var s_Kv in s_Ctx.GetResources()) Tally(s_Kv.Value, s_Kv.Value.GetSize());
            foreach (var s_Kv in s_Ctx.GetPartitions())
            {
                long s_Sz = 0; try { s_Sz = s_Kv.Value.GetSize(); } catch { }
                Tally(s_Kv.Value, s_Sz);
            }

            p_Writer.WriteLine($"bundle_stats: CAS-referenceable = {s_Cas} items / {s_CasBytes / 1024 / 1024} MB  |  INLINE(non-cas variant) = {s_Inline} items / {s_InlineBytes / 1024 / 1024} MB  |  generated/file-backed = {s_Unknown} items / {s_UnknownBytes / 1024 / 1024} MB");
            p_Writer.WriteLine($"  -> if CAS-referenceable MB is large, the builder is needlessly INLINING referenceable data (CAS-ref feature would shrink it). If INLINE MB dominates, the source stores it inline (must ship).");
            return true;
        }
    }
}
