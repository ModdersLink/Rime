using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Mesh;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps the specified resource with its chunks to a directly.")]
    public class DumpResourceWithChunksCommand : Command
    {
        [CommandArgument(Description = "The name of the resource to dump.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The destination directory name where the resource and chunks will be dumped to.")]
        public DirectoryInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                ((GameContext)p_Context).DumpResourceWithChunks(Name!, Destination!);
                p_Writer.WriteLine("Resource and chunks successfully dumped.");
                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to dump resource with error:");
                p_Writer.WriteLine(s_Exception.Message);
                return false;
            }
        }
    }
}
