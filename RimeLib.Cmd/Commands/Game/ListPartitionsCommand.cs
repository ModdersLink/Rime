using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the mounted partitions.")]
    public class ListPartitionsCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Partitions = ((GameContext) p_Context).GetMountedPartitions().ToList();

            if (s_Partitions.Count == 0)
            {
                p_Writer.WriteLine("There are no mounted partitions.");
                return true;
            }

            p_Writer.WriteLine("Mounted partitions:");
            p_Writer.WriteLine();

            foreach (var s_Partition in s_Partitions)
                p_Writer.WriteLine("- " + s_Partition);

            return true;
        }
    }
}