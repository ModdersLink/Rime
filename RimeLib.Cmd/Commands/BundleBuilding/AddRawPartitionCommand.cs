using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds a partition byte for byte from a raw EBX file, as produced by dump_partition, bypassing the JSON converter.")]
    public class AddRawPartitionCommand : Command
    {
        // Going in byte for byte preserves the exact structure the game built, which is what a
        // patched copy of a real partition needs in order to still realize.
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
