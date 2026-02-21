using RimeLib.Cmd.Attributes;
using System;
using System.IO;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Validate signature for a toc file.")]
    public class SignatureValidateCommand : Command
    {
        [CommandArgument(Description = "Frostbite TOC file to be validated.")]
        public FileInfo? TocFile { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            throw new NotImplementedException();
        }
    }
}
