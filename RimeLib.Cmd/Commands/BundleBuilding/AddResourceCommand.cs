using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds a new resource to this bundle or replaces an existing one.")]
    public class AddResourceCommand : Command
    {
        [CommandArgument(Description = "The name of the resource.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The resource type.")]
        public ResourceType Type { get; set; }

        [CommandArgument(Description = "The path to the file containing the resource data.")]
        public FileInfo? FilePath { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (!FilePath!.Exists)
            {
                p_Writer.WriteLine("The specified file could not be found.");
                return false;
            }

            ((BundleBuildingContext) p_Context).AddResource(Name!, Type, FilePath);

            return true;
        }
    }
}
