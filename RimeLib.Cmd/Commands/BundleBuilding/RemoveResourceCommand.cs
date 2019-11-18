using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Removes the specified resource from the bundle.")]
    public class RemoveResourceCommand : Command
    {
        [CommandArgument(Description = "The name of the resource.")]
        public string? Name { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            ((BundleBuildingContext) p_Context).RemoveResource(Name!);
            return true;
        }
    }
}
