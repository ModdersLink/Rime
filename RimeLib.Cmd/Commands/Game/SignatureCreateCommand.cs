using RimeLib.Cmd.Attributes;
using System;
using System.IO;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Creates a new signature for a toc file.")]
    public class SignatureCreateCommand : Command
    {
        [CommandArgument(Description = "Private RSA key for signing.")]
        public FileInfo? PrivateKey { get; set; }

        [CommandArgument(Description = "Frostbite TOC file to be signed.")]
        public FileInfo? TocFile { get; set; }
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            throw new NotImplementedException();
        }
    }
}
