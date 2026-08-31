using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.IO;
using RimeLib;
using RimeLib.Terrain.Resources;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Writes a level's terrain heightfield quadtree as JSON: every node's bounds and the chunk that
    /// holds its height samples.
    ///
    /// A tile chunk is 133x133 UInt16 samples with a two-sample border, so the usable grid is
    /// 129x129 (RimeLib.Terrain.Rime.HeightmapTile). With the node's bounding box giving its extent
    /// and height range, that is everything needed to rebuild the terrain surface -- dump_chunk
    /// fetches the samples themselves.
    /// </summary>
    [CommandDescription("Dumps a terrain streaming tree's heightfield nodes (bounds + chunk ids) as JSON.")]
    public class DumpTerrainNodesCommand : Command
    {
        [CommandArgument(Description = "The streamingtree resource, e.g. levels/mp_001/terrain/mp001_terrain/mp001_terrain.streamingtree")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_terrain_nodes <streamingtree-resource> <destination.json>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource) || s_Resource.FirstVariant == null)
            {
                p_Writer.WriteLine($"Could not find terrain resource ({Name}).");
                return false;
            }

            var s_Reader = EngineInterfaceRegistry.Create<ITerrainHeightfield>(s_Mounter.GetEngineType());

            if (!s_Reader.ReadHeightfield(s_Resource.FirstVariant, s_Mounter, out var s_Heightfield) || s_Heightfield == null)
            {
                p_Writer.WriteLine("No heightfield tree in this streaming tree.");
                return false;
            }

            var s_Nodes = new List<object>();

            foreach (var s_Node in s_Heightfield.Nodes)
            {
                s_Nodes.Add(new
                {
                    depth = s_Node.Depth,
                    min = s_Node.Min,
                    max = s_Node.Max,
                    samplesPerMeter = s_Node.SamplesPerMeter,
                    embedded = s_Node.Embedded.Length,
                    // The samples themselves, where the tree carries them inline.
                    data = s_Node.Embedded.Length > 0 ? System.Convert.ToBase64String(s_Node.Embedded) : null,
                    flags = s_Node.Flags
                });
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
            {
                resource = Name,
                samplesPerSide = s_Heightfield.SamplesPerSide,
                worldSizeY = s_Heightfield.WorldSizeY,
                worldScaleY = s_Heightfield.WorldScaleY,
                nodes = s_Nodes
            }));

            p_Writer.WriteLine($"Terrain nodes for {Name} written to {Destination.FullName} ({s_Nodes.Count} nodes).");

            return true;
        }

    }
}
