using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the mounted superbundles.")]
    public class ListMountedSbCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Superbundles = ((GameContext) p_Context).GetMountedSuperbundles().ToList();

            if (s_Superbundles.Count == 0)
            {
                p_Writer.WriteLine("There are no mounted superbundles.");
                return true;
            }

            p_Writer.WriteLine("Mounted superbundles:");
            p_Writer.WriteLine();

            foreach (var s_Superbundle in s_Superbundles)
                p_Writer.WriteLine("- " + s_Superbundle);

            return true;
        }
    }
}