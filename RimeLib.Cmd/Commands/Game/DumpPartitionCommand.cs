using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps the specified partition to a file.")]
    public class DumpPartitionCommand : Command
    {
        [CommandArgument(Description = "The name of the partition to dump.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The destination file name where the partition will be dumped to.")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                ((GameContext) p_Context).DumpPartition(Name!, Destination!);
                p_Writer.WriteLine("Partition successfully dumped.");
                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to dump partition with error:");
                p_Writer.WriteLine(s_Exception.Message);
                return false;
            }
        }
    }
}
