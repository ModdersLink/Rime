using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.SbBuilding
{
    [CommandDescription("Clones a mounted superbundle's TOC-LEVEL chunk list into the superbundle being built, as pure { id, sha1 } CAS refs (no payload). Needed for a COMPLETE level-sb override: the sb-level chunks are the terrain/streaming payloads the engine fetches by GUID from the sb's toc — a level-sb clone without them hangs the server at 'Loading terrain' (VU replaces the whole sb with no fallthrough to the original). Chunks without a sha1 (noncas offset-style) are skipped with a warning.")]
    public class CloneSbChunksCommand : Command
    {
        [CommandArgument(Description = "The mounted superbundle whose toc chunks to clone, e.g. win32/levels/mp_017/mp_017.")]
        public string? Superbundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = p_Context as SbBuildingContext;
            if (s_Ctx == null)
            {
                p_Writer.WriteLine("clone_sb_chunks must run inside a superbundle-building context.");
                return false;
            }

            var s_BaseCtx = (BaseContext)s_Ctx.Parent!;
            var s_Mounter = s_BaseCtx.GetMounters().Values.FirstOrDefault()
                as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
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
                s_Ctx.AddCasTocChunk(s_Id, s_Sha1);
                s_Added++;
            }

            p_Writer.WriteLine($"clone_sb_chunks: {s_Added} cas toc chunk ref(s) cloned from '{Superbundle}'"
                               + (s_Skipped > 0 ? $" ({s_Skipped} non-cas offset chunk(s) SKIPPED)" : "") + ".");
            return s_Added > 0 || s_Skipped == 0;
        }
    }
}
