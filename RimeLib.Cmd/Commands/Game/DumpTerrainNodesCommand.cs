using System.Collections.Generic;
using System.IO;
using RimeLib.Terrain.Frostbite;
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
                    indexX = s_Node.IndexX,
                    indexY = s_Node.IndexY,
                    leaf = s_Node.Leaf,
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
                nodeBorderWidth = s_Heightfield.NodeBorderWidth,
                worldSizeY = s_Heightfield.WorldSizeY,
                worldScaleY = s_Heightfield.WorldScaleY,
                hasMaterialTree = s_Heightfield.HasMaterialTree,
                rasterTrees = s_Heightfield.RasterTrees,
                materialPairIndices = s_Heightfield.MaterialPairIndices,
                backgroundMaterialIndex = s_Heightfield.BackgroundMaterialIndex,
                materialSamplesPerSide = s_Heightfield.MaterialSamplesPerSide,
                maskSamplesPerSide = s_Heightfield.MaskSamplesPerSide,
                // The head of the mask tree's own bytes. Its node parse consumes 39 of ~1.35 MB,
                // so the header layout it assumes is wrong; this is the evidence needed to fix it.
                maskRawLength = s_Heightfield.MaskRaw.Length,
                maskRawHead = System.Convert.ToBase64String(s_Heightfield.MaskRaw),
                maskConsumed = s_Heightfield.MaskConsumed,
                streamNodes = s_Heightfield.StreamNodes.ConvertAll(p_Node => (object)new
                {
                    depth = p_Node.Depth,
                    indexX = p_Node.IndexX,
                    indexY = p_Node.IndexY,
                    lod0Chunk = p_Node.Lod0Chunk,
                    lod0Size = p_Node.Lod0Size,
                    lod1Chunk = p_Node.Lod1Chunk,
                    lod1Size = p_Node.Lod1Size,
                    leaf = p_Node.Leaf,
                    min = p_Node.Min,
                    max = p_Node.Max
                }),
                maskNodes = s_Heightfield.MaskNodes.ConvertAll(p_Node => (object)new
                {
                    level = p_Node.Level,
                    indexX = p_Node.IndexX,
                    indexY = p_Node.IndexY,
                    min = p_Node.Min,
                    max = p_Node.Max,
                    samplesPerSide = s_Heightfield.MaskSamplesPerSide,
                    samples = System.Convert.ToBase64String(p_Node.Rle)
                }),
                materialNodes = s_Heightfield.MaterialNodes.ConvertAll(p_Node =>
                {
                    // Decoded here rather than handed over encoded: every consumer wanted the
                    // samples, and each was reimplementing the same run-length walk to get them.
                    // One material index per sample, indexing materialPairIndices.
                    var s_MatSide = (int)s_Heightfield.MaterialSamplesPerSide;
                    var s_Packed = TerrainRle.Decode(p_Node.Rle, p_Node.LineSizes,
                        TerrainRle.BytesPerLine(s_MatSide));

                    return (object)new
                    {
                        level = p_Node.Level,
                        indexX = p_Node.IndexX,
                        indexY = p_Node.IndexY,
                        min = p_Node.Min,
                        max = p_Node.Max,
                        samplesPerSide = s_Heightfield.MaterialSamplesPerSide,
                        // Null when the run-length walk did not land exactly on a line boundary,
                        // so a caller sees "this did not decode" instead of a plausible-looking
                        // buffer that is quietly wrong.
                        samples = s_Packed == null
                            ? null
                            : System.Convert.ToBase64String(
                                TerrainRle.UnpackRows(s_Packed, s_MatSide, p_Node.LineSizes.Length))
                    };
                }),
                destructionSamplesPerSide = s_Heightfield.DestructionSamplesPerSide,
                destructionNodes = s_Heightfield.DestructionNodes.ConvertAll(p_Node =>
                {
                    var s_Side = (int)s_Heightfield.DestructionSamplesPerSide;
                    var s_Depths = TerrainRle.Decode(p_Node.Rle, p_Node.LineSizes,
                        TerrainRle.BytesPerLine(s_Side));

                    return (object)new
                    {
                        level = p_Node.Level,
                        indexX = p_Node.IndexX,
                        indexY = p_Node.IndexY,
                        min = p_Node.Min,
                        max = p_Node.Max,
                        samplesPerSide = s_Side,
                        samples = s_Depths == null
                            ? null
                            : System.Convert.ToBase64String(
                                TerrainRle.UnpackRows(s_Depths, s_Side, p_Node.LineSizes.Length))
                    };
                }),
                nodes = s_Nodes
            }));

            p_Writer.WriteLine($"Terrain nodes for {Name} written to {Destination.FullName} ({s_Nodes.Count} nodes).");

            return true;
        }

    }
}
