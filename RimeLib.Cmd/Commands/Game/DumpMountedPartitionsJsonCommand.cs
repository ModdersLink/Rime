using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps all mounted partitions to JSON files.")]
    public class DumpMountedPartitionsJsonCommand : Command
    {
        [CommandArgument(Description = "The destination directory where the partitions will be dumped to.")]
        public DirectoryInfo? Destination { get; set; }

        [CommandArgument(Description = "How to format the generated JSON files. Default: None.", Optional = true)]
        public Formatting Formatting { get; set; } = Formatting.None;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                var s_GameContext = (GameContext)p_Context;
                var s_Partitions = s_GameContext.GetMountedPartitions().ToList();

                p_Writer.WriteLine($"Dumping {s_Partitions.Count} partitions to {Destination!.FullName}...");

                int s_SuccessCount = 0;
                int s_FailCount = 0;

                foreach (var s_PartitionName in s_Partitions)
                {
                    try
                    {
                        // Clean up the partition name to be used as a file path
                        // Partitions usually use / as separator, which works for Path.Combine on most systems, 
                        // but we should ensure it's compatible with the OS.
                        string s_RelativePath = s_PartitionName.Replace('/', Path.DirectorySeparatorChar);
                        if (s_RelativePath.StartsWith(Path.DirectorySeparatorChar))
                        {
                            s_RelativePath = s_RelativePath.Substring(1);
                        }

                        string s_FilePath = Path.Combine(Destination.FullName, s_RelativePath + ".json");
                        FileInfo s_DestinationFile = new FileInfo(s_FilePath);

                        s_GameContext.DumpPartitionJson(s_PartitionName, s_DestinationFile, Formatting);
                        s_SuccessCount++;
                    }
                    catch (Exception s_Ex)
                    {
                        p_Writer.WriteLine($"Failed to dump partition '{s_PartitionName}': {s_Ex.Message}");
                        s_FailCount++;
                    }
                }

                p_Writer.WriteLine($"Successfully dumped {s_SuccessCount} partitions.");
                if (s_FailCount > 0)
                {
                    p_Writer.WriteLine($"Failed to dump {s_FailCount} partitions.");
                }

                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to dump mounted partitions with error:");
                p_Writer.WriteLine(s_Exception.Message);
                return false;
            }
        }
    }
}