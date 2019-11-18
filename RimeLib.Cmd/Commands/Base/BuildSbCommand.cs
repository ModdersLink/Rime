using System;
using System.IO;
using RimeLib.Cmd.Attributes;

namespace RimeLib.Cmd.Commands.Base
{
    [CommandDescription("Enters the superbundle building context.")]
    public class BuildSbCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            throw new NotImplementedException();
        }
    }
}
