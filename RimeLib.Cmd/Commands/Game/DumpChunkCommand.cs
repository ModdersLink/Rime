using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps the specified chunk to a file.")]
    public class DumpChunkCommand : Command
    {
        [CommandArgument(Description = "The id of the chunk to dump.")]
        public GUID? Id { get; set; }

        [CommandArgument(Description = "The destination file name where the chunk will be dumped to.")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                ((GameContext) p_Context).DumpChunk(Id!, Destination!);
                p_Writer.WriteLine("Chunk successfully dumped.");
                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to dump chunk with error:");
                p_Writer.WriteLine(s_Exception.Message);
                return false;
            }
        }
    }
}
