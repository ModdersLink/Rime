using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Mesh;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps the specified mesh to a file.")]
    public class DumpMeshChunksCommand : Command
    {

        [CommandArgument(Description = "The path of the mesh")]
        public string Path { get; set; } = string.Empty;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                ((GameContext)p_Context).DumpMeshChunks(Path);
                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine($"Could not extract mesh. Error: {s_Exception.Message}");
                return false;
            }
        }
    }
}
