using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Mesh;

namespace RimeLib.Cmd.Commands.Game;

[CommandDescription("Dumps the specified mesh to a file.")]
public class DumpMeshCommand : Command
{
    [CommandArgument(Description = "Mesh export format")]
    public MeshConverterType ExportType { get; set; }

    [CommandArgument(Description = "The path of the mesh")]
    public string Path { get; set; } = string.Empty;
    
    [CommandArgument(Description = "The destination file name where the mesh will be exported")]
    public FileInfo? Destination { get; set; }

    public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
    {
        ((GameContext)p_Context).DumpMesh(ExportType, Path, Destination!);
        p_Writer.WriteLine($"Extracted {ExportType} {Path} to {Destination?.FullName}");
        return true;
    }
}