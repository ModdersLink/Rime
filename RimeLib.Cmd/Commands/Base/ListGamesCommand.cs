using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Base
{
    [CommandDescription("Lists the currently mounted games.")]
    public class ListGamesCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounters = ((BaseContext) p_Context).GetMounters();

            if (s_Mounters.Count == 0)
            {
                p_Writer.WriteLine("No games are currently mounted.");
                return true;
            }

            p_Writer.WriteLine("Mounted games:");
            p_Writer.WriteLine();

            foreach (var s_Mounter in s_Mounters)
                p_Writer.WriteLine($"[{s_Mounter.Key}] {s_Mounter.Value.GetGamePath()} - {s_Mounter.Value.GetEngineType()}");

            return true;
        }
    }
}
