using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib;
using RimeLib.Terrain.Resources;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Writes what a level's ground is painted with: its terrain layers, and for each combination of
    /// them the shader that blends it.
    ///
    /// This is the missing half of terrain. dump_terrain_nodes gives the shape of the ground; this
    /// gives the layers, and the shader names lead to their textures.
    /// </summary>
    [CommandDescription("Dumps a level's VisualTerrain resource (layers and their shaders) as JSON.")]
    public class DumpVisualTerrainCommand : Command
    {
        [CommandArgument(Description = "The visualterrain resource, e.g. levels/mp_017/mp_017/visualterrain")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_visual_terrain <visualterrain-resource> <destination.json>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource) || s_Resource.FirstVariant == null)
            {
                p_Writer.WriteLine($"Could not find visual terrain resource ({Name}).");
                return false;
            }

            var s_Reader = EngineInterfaceRegistry.Create<IVisualTerrain>(s_Mounter.GetEngineType());

            if (!s_Reader.ReadVisualTerrain(s_Resource.FirstVariant, s_Mounter, out var s_Info) || s_Info == null)
            {
                p_Writer.WriteLine("Could not read that visual terrain.");
                return false;
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(s_Info));

            p_Writer.WriteLine($"Visual terrain for {Name} written to {Destination.FullName} " +
                               $"({s_Info.LayerCount} layers, {s_Info.Draws.Count} draws).");

            return true;
        }
    }
}
