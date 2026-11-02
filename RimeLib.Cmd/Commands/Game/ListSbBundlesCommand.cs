using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists the bundle ids in a superbundle's toc, patch layered on top, one per line.")]
    public class ListSbBundlesCommand : Command
    {
        // Use it to enumerate what a complete level superbundle override has to contain: the base
        // bundle plus every gamemode bundle.
        [CommandArgument(Description = "The superbundle name, e.g. win32/levels/mp_017/mp_017.")]
        public string? Superbundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounter = ((GameContext)p_Context).GetMounter();

            var s_Count = 0;
            foreach (var s_Id in s_Mounter.GetBundlesInSuperbundle(Superbundle!))
            {
                p_Writer.WriteLine($"SB-BUNDLE: {s_Id}");
                s_Count++;
            }
            p_Writer.WriteLine($"list_sb_bundles: {s_Count} bundle(s) in '{Superbundle}'.");
            return s_Count > 0;
        }
    }
}
