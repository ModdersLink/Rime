using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.SbBuilding
{
    [CommandDescription("Enters a bundle building context for this superbundle; a bundle built into it before is added to.")]
    public class BuildBundleCommand : Command
    {
        [CommandArgument(Description = "The name of the bundle to start building, or to add to.")]
        public string? Bundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            // TODO: Validate bundle name.
            p_Context = new BundleBuildingContext((SbBuildingContext) p_Context, Bundle!);
            return true;
        }
    }
}
