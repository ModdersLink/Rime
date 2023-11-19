using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all chunks of the given superbundle.")]
    public class ListSbChunksCommand : Command
    {
        [CommandArgument(Description = "The name of the superbundle.")]
        public string? SuperBundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Chunks = ((GameContext)p_Context).GetSuperbundleChunks(SuperBundle!).ToList();

            if (s_Chunks.Count == 0)
            {
                p_Writer.WriteLine("There are no chunks in this superbundle.");
                return true;
            }

            p_Writer.WriteLine("Chunks:");
            p_Writer.WriteLine();

            foreach (var s_Chunk in s_Chunks)
                p_Writer.WriteLine("- " + s_Chunk.ToString("D"));

            return true;
        }
    }
}
