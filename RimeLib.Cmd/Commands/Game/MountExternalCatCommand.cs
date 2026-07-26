using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Chains an external cas.cat (e.g. a generated DLC 'vmdlc' catalog) onto the mounted base as its AuthoritativeCatalog, so subsequent build commands (casref-ify, destream_texture chunkonly) treat its sha1s as catalog-backed and emit pure cas-refs to them instead of embedding the bytes. Build-time only. Arg: <cat_path>.")]
    public class MountExternalCatCommand : Command
    {
        [CommandArgument(Description = "Path to the external cas.cat.")]
        public FileInfo? CatPath { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            // Works from GameContext OR BaseContext (so a build script can call it right after
            // mount_game without a select_game/exit context dance that disturbed the build).
            RimeLib.Content.Frostbite2_0.Mounting.EngineMounter? s_Mounter = null;
            if (p_Context is GameContext s_Game)
                s_Mounter = s_Game.GetMounter() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            else if (p_Context is BaseContext s_Base)
                s_Mounter = System.Linq.Enumerable.FirstOrDefault(s_Base.GetMounters().Values) as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
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
