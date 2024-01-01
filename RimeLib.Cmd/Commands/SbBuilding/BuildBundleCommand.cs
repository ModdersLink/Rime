using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.SbBuilding
{
    [CommandDescription("Enters a bundle building context for this superbundle.")]
    public class BuildBundleCommand : Command
    {
        [CommandArgument(Description = "The name of the bundle to start building.")]
        public string? Bundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            // TODO: Validate bundle name.
            p_Context = new BundleBuildingContext((SbBuildingContext) p_Context, Bundle!);
            return true;
        }
    }
}
