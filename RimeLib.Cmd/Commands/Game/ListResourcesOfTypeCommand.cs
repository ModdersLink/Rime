using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the mounted resources of a given type.")]
    public class ListResourcesOfTypeCommand : Command
    {
        [CommandArgument(Description = "The resource type to list")]
        public string? Type { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Resources = ((GameContext) p_Context).GetMountedResourceVariations();

            if (s_Resources.Count == 0)
            {
                p_Writer.WriteLine("There are no mounted resources.");
                return true;
            }

            p_Writer.WriteLine("Mounted resources of type " + Type + ":");
            p_Writer.WriteLine();

            foreach (var s_Resource in s_Resources)
                if (s_Resource.Value.FirstVariant.GetResourceType().ToString() == Type)
                    p_Writer.WriteLine("- " + s_Resource.Key);

            return true;
        }
    }
}