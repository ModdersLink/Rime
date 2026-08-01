using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite2_0.Mounting;

namespace RimeLib.Cmd.Commands.SbBuilding
{
    [CommandDescription("Clones a mounted superbundle's toc-level chunk list into the one being built, as bare sha1 refs. A level superbundle override without them hangs while loading terrain.")]
    public class CloneSbChunksCommand : Command
    {
        // The toc-level chunks are the terrain and streaming payloads the engine fetches by guid, and
        // the mod loader replaces the whole superbundle with no fallthrough to the original, so a
        // clone that omits them leaves the engine with nothing to fetch. They are cloned as bare id
        // and sha1 refs carrying no payload, which the engine resolves through the catalog. Chunks
        // with no sha1, meaning the noncas offset style, cannot be referenced this way and are
        // reported as skipped.
        [CommandArgument(Description = "The mounted superbundle whose toc chunks to clone, e.g. win32/levels/mp_017/mp_017.")]
        public string? Superbundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_SbBuildingContext = p_Context as SbBuildingContext;
            if (s_SbBuildingContext == null)
            {
                p_Writer.WriteLine("clone_sb_chunks must run inside a superbundle-building context.");
                return false;
            }

            var s_BaseContext = (BaseContext)s_SbBuildingContext.Parent!;
            var s_Mounter = s_BaseContext.GetMounters().Values.FirstOrDefault() as EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("clone_sb_chunks: no Frostbite2_0 mounter found (mount_game first).");
                return false;
            }

            int s_Added = 0, s_Skipped = 0;
            foreach (var (s_Id, s_Sha1) in s_Mounter.GetSuperbundleTocChunks(Superbundle!))
            {
                if (s_Sha1 == null)
                {
                    s_Skipped++;
                    continue;
                }

                s_SbBuildingContext.AddCasTocChunk(s_Id, s_Sha1);
                s_Added++;
            }

            p_Writer.WriteLine($"clone_sb_chunks: {s_Added} cas toc chunk ref(s) cloned from '{Superbundle}'"
                               + (s_Skipped > 0 ? $" ({s_Skipped} non-cas offset chunk(s) skipped)" : "") + ".");
            return s_Added > 0 || s_Skipped == 0;
        }
    }
}
