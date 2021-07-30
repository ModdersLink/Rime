using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps the specified texture resource to a dds file.")]
    public class DumpTextureCommand : Command
    {
        [CommandArgument(Description = "The name of the texture resource to dump.")]
        public string? Name
        {
            get; set;
        }

        [CommandArgument(Description = "The destination file name where the texture will be dumped to.")]
        public FileInfo? Destination
        {
            get; set;
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                (p_Context as GameContext)!.DumpTexture(Name!, Destination!);
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
