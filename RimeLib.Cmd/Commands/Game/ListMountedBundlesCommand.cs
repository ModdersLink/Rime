using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the currently mounted bundles.")]
    public class ListMountedBundlesCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Bundles = ((GameContext) p_Context).GetMountedBundles().ToList();

            if (s_Bundles.Count == 0)
            {
                p_Writer.WriteLine("There are no mounted bundles.");
                return true;
            }

            p_Writer.WriteLine("Mounted bundles:");
            p_Writer.WriteLine();

            foreach (var s_Bundle in s_Bundles)
                p_Writer.WriteLine("- " + s_Bundle);

            return true;
        }
    }
}