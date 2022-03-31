using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Lists all the resources that have been added to the bundle.")]
    public class ListResourcesCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Resources = ((BundleBuildingContext) p_Context).GetResources();

            if (s_Resources.Count == 0)
            {
                p_Writer.WriteLine("No resources have been added.");
                return true;
            }

            p_Writer.WriteLine("Resources to include:");
            p_Writer.WriteLine();

            foreach (var s_Resource in s_Resources)
                p_Writer.WriteLine($"- {s_Resource.Key}");

            return true;
        }
    }
}
