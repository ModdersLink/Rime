using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the resources present in a specific bundle.")]
    public class ListBundleResourcesCommand : Command
    {
        [CommandArgument(Description = "The name of the bundle.")]
        public string? Bundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Resources = ((GameContext) p_Context).GetBundleResources(Bundle!).ToList();

            if (s_Resources.Count == 0)
            {
                p_Writer.WriteLine("This bundle contains no resources.");
                return true;
            }

            p_Writer.WriteLine("Resources:");
            p_Writer.WriteLine();

            foreach (var s_Resource in s_Resources)
                p_Writer.WriteLine("- " + s_Resource);

            return true;
        }
    }
}