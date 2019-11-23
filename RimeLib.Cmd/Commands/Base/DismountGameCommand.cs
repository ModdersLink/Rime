using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Base
{
    [CommandDescription("Dismounts a mounted game.")]
    public class DismountGameCommand : Command
    {
        [CommandArgument(Description = "The id of the game to dismount.")]
        public int Id { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Context = ((BaseContext) p_Context);

            if (!s_Context.TryGetMounterById(Id, out _))
            {
                Console.WriteLine($"Could not find mounted game with id '{Id}'. Use the 'list_games' command to see all mounted games and their ids.");
                return false;
            }

            s_Context.DeregisterMounter(Id);

            // TODO: Maybe we want to manually perform GC here?

            return true;
        }
    }
}
