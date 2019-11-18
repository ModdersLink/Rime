using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.SbBuilding
{
    [CommandDescription("Lists all the bundles that have been added to the superbundle.")]
    public class ListBundlesCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Bundles = ((SbBuildingContext) p_Context).GetBundles();

            p_Writer.WriteLine("Bundles to include:");
            p_Writer.WriteLine();

            foreach (var s_Bundle in s_Bundles)
                Console.WriteLine($"- {s_Bundle.Key}");

            return true;
        }
    }
}
