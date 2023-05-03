using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Converts and dumps the specified mesh resource file.")]
    public class DumpMeshCommand : Command
    {
        [CommandArgument(Description = "The name of the mesh resource.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The destination file name where the mesh file will be saved.")]
        public FileInfo? Destination { get; set; }

        public enum ExportType
        {
            Text,
            Obj,
            BlenderScript,
            Gltf
        }

        [CommandArgument(Description = "The exporting type.")]
        public ExportType DestinationType { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                (p_Context as GameContext)?.DumpMesh(Name!, Destination!, DestinationType);
                p_Writer.WriteLine("Mesh successfully converted and dumped.");
                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to convert and dump mesh.");
                p_Writer.Write(s_Exception.Message);
            }

            return false;
        }
    }
}
