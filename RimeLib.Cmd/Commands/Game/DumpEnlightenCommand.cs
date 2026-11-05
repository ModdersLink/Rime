using System;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Enlighten;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Writes an Enlighten resource as JSON: the global-illumination bake a level carries.
    ///
    /// Handles the four Enlighten resource types that hold structure rather than pixels -- the
    /// database (its lightmap instances and the systems and probe sets it names), a probe set (its
    /// grid and probe positions), the shader database (its per-material colours) and the static
    /// database (the baked probe coefficients). The lightmap TEXTURES those reference are ordinary
    /// textures and come out through dump_texture.
    ///
    /// Every dump reports <c>reencodesExactly</c>: whether serialising what was just read gives
    /// back the shipped bytes. Enlighten data is a BAKE -- it describes light for the geometry that
    /// was there when it was computed -- so the only defensible thing a tool can do with it is
    /// carry it unchanged. Measuring that here, with the original bytes still in hand, is what
    /// separates carrying it from approximating it.
    /// </summary>
    [CommandDescription("Dumps an Enlighten database, probe set or shader database as JSON.")]
    public class DumpEnlightenCommand : Command
    {
        [CommandArgument(Description = "The Enlighten resource, e.g. levels/mp_001/lighting/enlighten_mp_001")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_enlighten <resource> <destination.json>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Codec = Require<IEnlightenCodec>(s_Mounter.GetEngineType(), p_Writer);
            if (s_Codec == null)
                return false;

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource) || s_Resource.FirstVariant == null)
            {
                p_Writer.WriteLine($"Could not find Enlighten resource ({Name}).");
                return false;
            }

            var s_Variant = s_Resource.FirstVariant;
            var s_Type = s_Variant.GetResourceType();

            byte[] s_Data;

            using (var s_Source = s_Variant.GetReader())
                s_Data = s_Source.ReadBytes((int)s_Source.Length);

            var s_Dump = s_Codec.Dump(s_Type, s_Data);

            if (s_Dump is null)
            {
                p_Writer.WriteLine($"{Name} is a {s_Type}, which is not an Enlighten resource this reads.");
                return false;
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(s_Dump.Fields));
            p_Writer.WriteLine($"Enlighten {s_Type} for {Name} written to {Destination.FullName}.");

            return true;
        }
    }
}
