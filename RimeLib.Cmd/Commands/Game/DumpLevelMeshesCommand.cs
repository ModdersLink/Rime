using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Mesh;

namespace RimeLib.Cmd.Commands.Game;

[CommandDescription("Dumps the specified level to a bunch of meshes")]
public class DumpLevelMeshesCommand : Command
{
    [CommandArgument(Description = "Format of the exported mesh")]
    public MeshConverterType Format { get; set; }
    
    [CommandArgument(Description = "The path to the level partition")]
    public string LevelPartition { get; set; } = string.Empty;

    [CommandArgument(Description = "The output path name")]
    public FileInfo? Destination { get; set; }

    public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
    {
        // TODO: Implement try/catch
        ((GameContext)p_Context).ExportLevelMesh(LevelPartition, Destination!, p_Writer);
        p_Writer.WriteLine($"Extracted Level {LevelPartition} to {Destination?.FullName}");
        return true;
    }
}