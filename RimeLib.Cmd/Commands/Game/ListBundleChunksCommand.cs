using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the chunks present in a specific bundle.")]
    public class ListBundleChunksCommand : Command
    {
        [CommandArgument(Description = "The name of the bundle.")]
        public string? Bundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Chunks = ((GameContext) p_Context).GetBundleChunks(Bundle!).ToList();

            if (s_Chunks.Count == 0)
            {
                p_Writer.WriteLine("This bundle contains no chunks.");
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
