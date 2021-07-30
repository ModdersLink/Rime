using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the partitions present in a specific bundle.")]
    public class ListBundlePartitionsCommand : Command
    {
        [CommandArgument(Description = "The name of the bundle.")]
        public string? Bundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Partitions = ((GameContext) p_Context).GetBundlePartitions(Bundle!).ToList();

            if (s_Partitions.Count == 0)
            {
                p_Writer.WriteLine("This bundle contains no partitions.");
                return true;
            }

            p_Writer.WriteLine("Partitions:");
            p_Writer.WriteLine();

            foreach (var s_Partition in s_Partitions)
                p_Writer.WriteLine("- " + s_Partition);

            return true;
        }
    }
}