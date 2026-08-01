using System;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps a TerrainDecals resource's structure as JSON: the header and the 2d, 3d and water geometries. Round-trips byte-identical via replace_terrain_decals.")]
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
