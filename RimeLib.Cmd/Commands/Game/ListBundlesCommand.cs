using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the available bundles.")]
    public class ListBundlesCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Bundles = ((GameContext) p_Context).GetAvailableBundles().ToList();

            if (s_Bundles.Count == 0)
            {
                p_Writer.WriteLine("There are no bundles available to be mounted.");
                return true;
            }

            p_Writer.WriteLine("Available bundles:");
            p_Writer.WriteLine();

            foreach (var s_Bundle in s_Bundles)
                p_Writer.WriteLine("- " + s_Bundle);

            return true;
        }
    }
}