using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.SbBuilding
{
    [CommandDescription("Lists all the chunks that have been added to the superbundle.")]
    public class ListChunksCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Chunks = ((SbBuildingContext) p_Context).GetChunks();

            if (s_Chunks.Count == 0)
            {
                p_Writer.WriteLine("No chunks have been added.");
                return true;
            }

            p_Writer.WriteLine("Chunks to include:");
            p_Writer.WriteLine();

            foreach (var s_Chunk in s_Chunks)
                Console.WriteLine($"- {s_Chunk.Key.ToString("D")}");

            return true;
        }
    }
}
