using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds a partition to this bundle from a RAW EBX binary file (as produced by dump_partition), byte-for-byte — bypassing the JSON converter. Use this to inject a faithfully-patched real partition.")]
    public class AddRawPartitionCommand : Command
    {
        [CommandArgument(Description = "The name of the partition.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The path to the raw .bin partition file.")]
        public FileInfo? FilePath { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (!FilePath!.Exists)
            {
                p_Writer.WriteLine("The specified file could not be found.");
                return false;
            }

            ((BundleBuildingContext) p_Context).AddRawPartition(Name!, FilePath);
            p_Writer.WriteLine($"Raw partition '{Name}' added ({FilePath.Length} bytes).");
            return true;
        }
    }
}
