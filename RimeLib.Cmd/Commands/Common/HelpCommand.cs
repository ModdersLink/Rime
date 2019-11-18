using System.IO;
using RimeLib.Cmd.Attributes;

namespace RimeLib.Cmd.Commands.Common
{
    [CommandDescription("Displays all available commands or information about a specific command.")]
    public class HelpCommand : Command
    {
        [CommandArgument(Optional = true)]
        public string? Command { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (Command != null)
            {
                if (!p_Context.GetCommandHelp(Command, out var s_HelpText))
                    return false;

                p_Writer.WriteLine(s_HelpText);
                return true;
            }

            p_Writer.WriteLine(p_Context.GetHelp());
            return true;
        }
    }
}
