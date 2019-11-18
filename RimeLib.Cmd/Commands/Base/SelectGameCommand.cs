using System;
using System.IO;
using RimeLib.Cmd.Attributes;

namespace RimeLib.Cmd.Commands.Base
{
    [CommandDescription("Switches the current context to the context of a game.")]
    public class SelectGameCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            throw new NotImplementedException();
        }
    }
}
