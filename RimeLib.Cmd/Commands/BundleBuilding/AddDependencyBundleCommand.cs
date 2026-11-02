using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds a bundle that definitely gets loaded before the bundle that gets built.")]
    internal class AddDependencyBundleCommand : Command
    {
        [CommandArgument(Description = "The name of the dependency bundle.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The bundle is loaded but not self-contained: leave out what it carries, but still add what that content references.", Optional = true)]
        public bool Walked { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("The specified bundle name is invalid.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            s_BundleContext.AddDependencyBundle(Name, Walked);

            return true;
        }
    }
}
