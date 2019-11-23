using System.IO;
using RimeLib.Cmd.Attributes;

namespace RimeLib.Cmd.Commands.Common
{
    [CommandDescription("Exits the current execution context.")]
    public class ExitCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            // Even though this could be null, we're skipping the null check here.
            // This will be properly handled by the context itself.
            p_Context = p_Context.Parent!;
            return true;
        }
    }
}
