using System;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps a TerrainDecals (.decals) resource's full structure as JSON (header + 2d/3d/water geometries with blocks, decoded vertices and indices). Round-trips byte-identical via build_terraindecals.")]
    public class DumpTerrainDecalsJsonCommand : Command
    {
        [CommandArgument(Description = "The name of the TerrainDecals resource to dump.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The destination .json file.")]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "How to format the generated JSON file. Default: None.", Optional = true)]
        public Formatting Formatting { get; set; } = Formatting.None;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                ((GameContext) p_Context).DumpTerrainDecalsJson(Name!, Destination!, Formatting);
                p_Writer.WriteLine("TerrainDecals successfully dumped to JSON.");
                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to dump TerrainDecals with error:");
                p_Writer.WriteLine(s_Exception.Message);
                return false;
            }
        }
    }
}
