using System.IO;
using RimeLib.Cmd.Attributes;

namespace RimeLib.Cmd.Commands.Game;

[CommandDescription("Dumps the specified mesh to a file.")]
public class DumpMeshCommand : Command
{
    public enum MeshExportType
    {
        None,
        Obj,
        Gltf,
        BlenderScript
    }
    
    [CommandArgument(Description = "Mesh export format")]
    public MeshExportType ExportType { get; set; }
    
    [CommandArgument(Description = "The destination file name where the mesh will be exported")]
    public FileInfo? Destination { get; set; }
    
    [CommandArgument(Description = "The path of the mesh")]
    public string Path { get; set; }
    
    public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }
}