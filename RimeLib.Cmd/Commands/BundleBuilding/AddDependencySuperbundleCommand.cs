using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds a superbundle whose chunks will be excluded from the bundle that gets built.")]
    internal class AddDependencySuperbundleCommand : Command
    {
        [CommandArgument(Description = "The name of the dependency superbundle.")]
        public string? Name { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("The specified superbundle name is invalid.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            s_BundleContext.AddDependencySuperbundle(Name);

            return true;
        }
    }
}
