using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Base
{
    [CommandDescription("Switches the current context to the context of a game.")]
    public class SelectGameCommand : Command
    {
        [CommandArgument(Description = "The id of the mounted game.")]
        public int Id { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (!((BaseContext) p_Context).TryGetMounterById(Id, out var s_Mounter))
            {
                p_Writer.WriteLine($"Could not find a mounted game with the specified id '{Id}'. Use the 'list_games' command to see a list of currently mounted games.");
                return false;
            }

            p_Context = new GameContext((BaseContext) p_Context, Id, s_Mounter!);

            return true;
        }
    }
}
