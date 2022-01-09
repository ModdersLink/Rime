using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Mounts the specified superbundle.")]
    public class MountSbCommand : Command
    {
        [CommandArgument(Description = "The name of the superbundle to mount.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Whether to automatically mount all contained bundles or not. Defaults to false.", Optional = true)]
        public bool AutoMount { get; set; } = false;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                p_Writer.WriteLine("Mounting superbundle. Please wait, this could take a while...");

                ((GameContext) p_Context).MountSuperbundle(Name!, AutoMount);

                p_Writer.WriteLine("Superbundle successfully mounted!");

                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine();
                p_Writer.WriteLine("Failed to mount superbundle with the following error:");
                p_Writer.WriteLine(s_Exception.Message);
                return false;
            }
        }
    }
}
