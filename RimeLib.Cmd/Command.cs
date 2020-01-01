using System.IO;

namespace RimeLib.Cmd
{
    public abstract class Command
    {
        /// <summary>
        /// Execute this command.
        /// </summary>
        /// <param name="p_Context">A reference to the current context. This command can replace this context by re-assigning it.</param>
        /// <param name="p_Writer">A text writer that can be used to write textual command output.</param>
        /// <returns>Returns `true` if the command execution succeeded, `false` otherwise.</returns>
        public abstract bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer);
    }
}
