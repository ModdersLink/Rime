using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Mounts the specified bundle.")]
    public class MountBundleCommand : Command
    {
        [CommandArgument(Description = "The name of the bundle to mount.")]
        public string? Name { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                p_Writer.WriteLine("Mounting bundle. Please wait, this could take a while...");

                ((GameContext) p_Context).MountBundle(Name!);

                p_Writer.WriteLine("Bundle successfully mounted!");

                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine();
                p_Writer.WriteLine("Failed to mount bundle with the following error:");
                p_Writer.WriteLine(s_Exception.Message);
                return false;
            }
        }
    }
}