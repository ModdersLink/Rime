using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists the bundle ids in a superbundle's TOC (Patch layered), one 'SB-BUNDLE: <id>' line each. Used to enumerate what a COMPLETE level-sb override clone must contain (base + every gamemode bundle).")]
    public class ListSbBundlesCommand : Command
    {
        [CommandArgument(Description = "The superbundle name, e.g. win32/levels/mp_017/mp_017.")]
        public string? Superbundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = (GameContext)p_Context;
            var s_Mounter = s_Ctx.GetMounter() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter; // This will break for other frostbite versions
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("list_sb_bundles: no Frostbite2_0 mounter.");
                return false;
            }

            var s_Count = 0;
            foreach (var s_Id in s_Mounter.GetSuperbundleBundleIds(Superbundle!)) // TODO: Make this apart of the interface
            {
                p_Writer.WriteLine($"SB-BUNDLE: {s_Id}");
                s_Count++;
            }
            p_Writer.WriteLine($"list_sb_bundles: {s_Count} bundle(s) in '{Superbundle}'.");
            return s_Count > 0;
        }
    }
}
