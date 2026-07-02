using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps ALL manifest fields (size/origSize/hash/meta/idata head) of every mounted variant of a resource. Diff a retail idata texture vs our generated one to find the black-vehicle field.")]
    public class DumpResEntryCommand : Command
    {
        [CommandArgument(Description = "Resource name.")]
        public string? Name { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = (GameContext)p_Context;
            var s_Mounter = s_Ctx.GetMounter() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null) { p_Writer.WriteLine("no fb2 mounter"); return false; }
            p_Writer.WriteLine(s_Mounter.DumpResourceEntry(Name!));
            return true;
        }
    }
}
