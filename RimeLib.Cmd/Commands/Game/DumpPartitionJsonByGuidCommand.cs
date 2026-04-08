using System;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps the specified partition to a JSON file.")]
    public class DumpPartitionJsonByGuidCommand : Command
    {
        [CommandArgument(Description = "The name of the partition to dump to JSON.")]
        public GUID? Guid { get; set; }

        [CommandArgument(Description = "The destination file name where the partition will be dumped to.")]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "How to format the generated JSON file. Default: None.", Optional = true)]
        public Formatting Formatting { get; set; } = Formatting.None;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                ((GameContext) p_Context).DumpPartitionJsonByGuid(Guid!, Destination!, Formatting);
                p_Writer.WriteLine("Partition successfully dumped to JSON.");
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
