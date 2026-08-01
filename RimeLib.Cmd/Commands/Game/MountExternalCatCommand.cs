using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite2_0.Mounting;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Chains an external cas.cat onto the mounted base, so builds emit cas refs to its sha1s instead of embedding the bytes. Build time only.")]
    public class MountExternalCatCommand : Command
    {
        // Point it at a catalog built by build_cas_catalog and the build commands that follow, such as
        // add_cas_chunk and destream_texture, will emit refs to its sha1s rather than embedding the
        // content. The catalog itself has to be staged with the mod for those refs to resolve at
        // runtime; nothing here reads its bytes.
        [CommandArgument(Description = "Path to the external cas.cat.")]
        public FileInfo? CatPath { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            // Accepts both contexts so a build script can call this straight after mount_game, without
            // the select_game and exit dance.
            EngineMounter? s_Mounter = null;
            if (p_Context is GameContext s_GameContext)
                s_Mounter = s_GameContext.GetMounter() as EngineMounter;
            else if (p_Context is BaseContext s_BaseContext)
                s_Mounter = s_BaseContext.GetMounters().Values.FirstOrDefault() as EngineMounter;

            if (s_Mounter == null)
            {
                p_Writer.WriteLine("mount_external_cat: no Frostbite2_0 mounter (mount_game first).");
                return false;
            }

            p_Writer.WriteLine(s_Mounter.MountExternalCatalog(CatPath!.FullName));
            return true;
        }
    }
}
