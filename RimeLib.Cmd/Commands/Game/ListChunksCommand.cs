using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Lists all the mounted chunks.")]
    public class ListChunksCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Chunks = ((GameContext) p_Context).GetMountedChunks().ToList();

            if (s_Chunks.Count == 0)
            {
                p_Writer.WriteLine("There are no mounted chunks.");
                return true;
            }

            p_Writer.WriteLine("Mounted chunks:");
            p_Writer.WriteLine();

            foreach (var s_Chunk in s_Chunks)
                p_Writer.WriteLine("- " + s_Chunk.ToString("D"));

            return true;
        }
    }
}