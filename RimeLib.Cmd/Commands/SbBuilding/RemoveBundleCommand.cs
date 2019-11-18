using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.SbBuilding
{
    [CommandDescription("Removes the specified bundle from the superbundle.")]
    public class RemoveBundleCommand : Command
    {
        [CommandArgument(Description = "The name of the bundle to remove.")]
        public string? Bundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            ((SbBuildingContext) p_Context).RemoveBundle(Bundle!);
            return true;
        }
    }
}
