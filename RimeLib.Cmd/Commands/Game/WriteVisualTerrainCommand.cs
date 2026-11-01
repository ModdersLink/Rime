using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib;
using RimeLib.Terrain.Resources;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Rebuilds a level's VisualTerrain resource with edited terrain layers and mesh scattering,
    /// and writes it out as a file that replace_resource can ship.
    ///
    /// This is the leg that was missing: scattering and layers could be read and round-tripped
    /// through USD with nothing changed, but there was no way back into the game because every
    /// writer under Frostbite/VisualTerrain threw. The edits are applied ONTO the shipped resource
    /// rather than the resource being built from the JSON alone -- the dump is a lossy view (it
    /// carries none of the mask-scale draw methods and most of the header), so rebuilding from it
    /// would quietly drop them.
    ///
    /// A scattering entry is addressed by (Layer, Index), not by mesh name: a layer may grow the
    /// same mesh twice, and the mesh name may itself be what was edited.
    /// </summary>
    [CommandDescription("Rebuilds a VisualTerrain resource with the layer and scattering edits in a dump_visual_terrain-shaped JSON.")]
    public class WriteVisualTerrainCommand : Command
    {
        [CommandArgument(Description = "The visual terrain resource to rebuild, e.g. levels/mp_001/terrain/mp_001.visual")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The edits, in the shape dump_visual_terrain writes.")]
        public FileInfo? Edits { get; set; }

        [CommandArgument(Description = "The rebuilt resource file.")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Edits is null || Destination is null)
            {
                p_Writer.WriteLine("Usage: write_visual_terrain <visual-terrain-resource> <edits.json> <destination>");
                return false;
            }

            if (!Edits.Exists)
            {
                p_Writer.WriteLine($"Could not find the edits JSON ({Edits.FullName}).");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource) || s_Resource.FirstVariant == null)
            {
                p_Writer.WriteLine($"Could not find visual terrain resource ({Name}).");
                return false;
            }

            var s_Edits = JsonConvert.DeserializeObject<VisualTerrainInfo>(File.ReadAllText(Edits.FullName));

            if (s_Edits == null)
            {
                p_Writer.WriteLine("Failed to parse the visual terrain JSON.");
                return false;
            }

            // An edits file that names nothing would produce a byte-identical resource and read as
            // success. That is a caller mistake worth naming, not a no-op worth accepting silently.
            if (s_Edits.Scattering.Count == 0 && s_Edits.LayerVirtualTexture.Count == 0 && s_Edits.Draws.Count == 0)
            {
                p_Writer.WriteLine("The edits JSON carries no scattering, no layer flags and no draws -- nothing to apply.");
                return false;
            }

            var s_Terrain = EngineInterfaceRegistry.Create<IVisualTerrain>(s_Mounter.GetEngineType());

            if (!s_Terrain.WriteVisualTerrain(s_Resource.FirstVariant, s_Edits, out var s_Data, out var s_Error)
                || s_Data == null)
            {
                p_Writer.WriteLine($"Could not rebuild {Name}: {s_Error ?? "unknown error"}.");
                return false;
            }

            if (Destination.Directory != null && !Destination.Directory.Exists)
                Destination.Directory.Create();

            File.WriteAllBytes(Destination.FullName, s_Data);

            p_Writer.WriteLine($"{Name} rebuilt to {Destination.FullName} ({s_Data.Length} bytes, "
                               + $"{s_Edits.Scattering.Count} scattering type(s), "
                               + $"{s_Edits.LayerVirtualTexture.Count} layer flag(s), "
                               + $"{s_Edits.Draws.Count} draw(s) applied).");

            return true;
        }
    }
}
