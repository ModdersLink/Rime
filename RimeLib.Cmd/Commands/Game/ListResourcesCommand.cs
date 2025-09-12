using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the mounted resources.")]
    public class ListResourcesCommand : Command
    {
        [CommandArgument(Description = "Name of Resource to filter by", Optional = true)]
        public string ResourceSearch { get; set; } = string.Empty;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Resources = ((GameContext) p_Context).GetMountedResourceVariations();

            if (s_Resources.Count == 0)
            {
                p_Writer.WriteLine("There are no mounted resources.");
                return true;
            }

            p_Writer.WriteLine("Mounted resources:");
            p_Writer.WriteLine();

            foreach (var s_Resource in s_Resources)
            {
                if (!string.IsNullOrWhiteSpace(ResourceSearch))
                {
                    if (s_Resource.Value.FirstVariant.GetResourceType().ToString() == ResourceSearch)
                        p_Writer.WriteLine("- " + s_Resource.Key + " (" + s_Resource.Value.FirstVariant.GetResourceType() +
                                           ")");
                }
                else
                {
                    if (s_Resource.Value.FirstVariant.GetResourceType().ToString() == ResourceSearch)
                        p_Writer.WriteLine("- " + s_Resource.Key + " (" +
                                           s_Resource.Value.FirstVariant.GetResourceType() +
                                           ")");
                }
            }

            return true;
        }
    }
}