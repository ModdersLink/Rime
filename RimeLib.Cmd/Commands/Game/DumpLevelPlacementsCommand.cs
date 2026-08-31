using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game;

[CommandDescription("Dumps where every mesh in a level is placed, as JSON, without extracting geometry.")]
public class DumpLevelPlacementsCommand : Command
{
    [CommandArgument(Description = "The path to the level partition")]
    public string LevelPartition { get; set; } = string.Empty;

    [CommandArgument(Description = "The output .json file")]
    public FileInfo? Destination { get; set; }

    public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
    {
        return ((GameContext)p_Context).DumpLevelPlacements(LevelPartition, Destination!, p_Writer);
    }
}
