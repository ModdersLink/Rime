using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using System;
using System.IO;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Converts the specified texture resource to a DDS file.")]
    public class ConvertTextureCommand : Command
    {
        [CommandArgument(Description = "The name of the texture resource to convert.")]
        public string? Name
        {
            get; set;
        }

        [CommandArgument(Description = "The destination file name where the DDS file will be saved.")]
        public FileInfo? Destination
        {
            get; set;
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                (p_Context as GameContext)!.ConvertTexture(Name!, Destination!);
                p_Writer.WriteLine("Texture successfully converted.");
                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to convert texture with error:");
                p_Writer.WriteLine(s_Exception.Message);
                return false;
            }
        }
    }
}
