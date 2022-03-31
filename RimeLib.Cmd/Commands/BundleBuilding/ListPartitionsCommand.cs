using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Lists all the partitions that have been added to the bundle.")]
    public class ListPartitionsCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Partitions = ((BundleBuildingContext) p_Context).GetPartitions();

            if (s_Partitions.Count == 0)
            {
                p_Writer.WriteLine("No partitions have been added.");
                return true;
            }

            p_Writer.WriteLine("Partitions to include:");
            p_Writer.WriteLine();

            foreach (var s_Partition in s_Partitions)
                p_Writer.WriteLine($"- {s_Partition.Key}");

            return true;
        }
    }
}
