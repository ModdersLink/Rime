using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the mounted resources.")]
    public class ListResourcesCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Resources = ((GameContext) p_Context).GetMountedResources().ToList();

            if (s_Resources.Count == 0)
            {
                p_Writer.WriteLine("There are no mounted resources.");
                return true;
            }

            p_Writer.WriteLine("Mounted resources:");
            p_Writer.WriteLine();

            foreach (var s_Resource in s_Resources)
                p_Writer.WriteLine("- " + s_Resource);

            return true;
        }
    }
}