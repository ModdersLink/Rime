using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Mounts all avalible bundles.")]
    public class MountAllBundlesCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                p_Writer.WriteLine("Mounting bundle. Please wait, this could take a while...");

                var s_GameContext = p_Context as GameContext;


                foreach( var s_Bundle in s_GameContext!.GetAvailableBundles())
                    s_GameContext.MountBundle(s_Bundle);

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
