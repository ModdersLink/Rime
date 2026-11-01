using System;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Enlighten.Frostbite2_0;
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

            var s_Dump = Parse(s_Type, s_Data);

            if (s_Dump is null)
            {
                p_Writer.WriteLine($"{Name} is a {s_Type}, which is not an Enlighten resource this reads.");
                return false;
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(s_Dump));
            p_Writer.WriteLine($"Enlighten {s_Type} for {Name} written to {Destination.FullName}.");

            return true;
        }

        /// <summary>
        /// Does serialising <paramref name="p_Object"/> give back exactly <paramref name="p_Original"/>?
        /// </summary>
        private static bool ReEncodes(IFbSerializable p_Object, byte[] p_Original)
        {
            if (!p_Object.Serialize(out var s_Written) || s_Written == null)
                return false;

            if (s_Written.Length != p_Original.Length)
                return false;

            for (var i = 0; i < s_Written.Length; ++i)
            {
                if (s_Written[i] != p_Original[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// The structured read for one Enlighten resource, or null if this is not a type that is
        /// parsed.
        ///
        /// Null is not a failure everywhere it is seen: <see cref="ResourceType.EnlightenSystem"/>
        /// is Enlighten's own radiosity data and nothing here decodes it. A caller carrying the
        /// bytes verbatim can still carry one; a caller wanting fields cannot.
        /// </summary>
        internal static object? Parse(ResourceType p_Type, byte[] p_Data)
        {
            switch (p_Type)
            {
                case ResourceType.EnlightenDatabase:
                    return DumpDatabase(p_Data);

                case ResourceType.EnlightenProbeSet:
                    return DumpProbeSet(p_Data);

                case ResourceType.EnlightenShaderDatabase:
                    return DumpShaderDatabase(p_Data);

                case ResourceType.StaticEnlightenDatabase:
                    return DumpStaticDatabase(p_Data);

                default:
                    return null;
            }
        }

        internal static object DumpDatabase(byte[] p_Data)
        {
            var s_Database = new EnlightenDatabase();
            s_Database.Deserialize(p_Data);

            return new
            {
                type = "EnlightenDatabase",
                enabled = s_Database.Enabled,
                dynamicDataEnable = s_Database.DynamicDataEnable,
                outputAtlasWidth = s_Database.OutputAtlasWidth,
                outputAtlasHeight = s_Database.OutputAtlasHeight,
                // The systems and probe sets are named here and shipped as their own resources, so
                // this list is also what a bundle has to carry alongside the database.
                systemNames = s_Database.SystemNames,
                probeSetNames = s_Database.ProbeSetNames,
                probeCount = s_Database.ProbeCount,
                terrainLightMaps = s_Database.TerrainLightMaps.ConvertAll(p_Map => (object)new
                {
                    min = p_Map.WorldBoundingBox.min,
                    max = p_Map.WorldBoundingBox.max,
                    uvTransform = p_Map.UVTransform,
                    uvTranslation = p_Map.UVTranslation
                }),
                // Each instance ties one baked lightmap to one placed object, by guid and
                // transform. Move that object and the instance still points where it used to be:
                // this is the record that says a bake cannot survive an edit to the geometry.
                lightMapInstances = s_Database.LightMapInstances.ConvertAll(p_Instance => (object)new
                {
                    guid = p_Instance.Guid.ToString(),
                    transform = p_Instance.Transform,
                    uvTransform = p_Instance.UVTransform,
                    uvTranslation = p_Instance.UVTranslation
                }),
                trailingBytes = s_Database.TrailingData.Length,
                reencodesExactly = ReEncodes(s_Database, p_Data)
            };
        }

        internal static object DumpProbeSet(byte[] p_Data)
        {
            var s_ProbeSet = new EnlightenProbeSet();
            s_ProbeSet.Deserialize(p_Data);

            return new
            {
                type = "EnlightenProbeSet",
                transform = s_ProbeSet.Transform,
                inverseTransform = s_ProbeSet.InverseTransform,
                min = s_ProbeSet.BoundingBox.min,
                max = s_ProbeSet.BoundingBox.max,
                blendDistance = s_ProbeSet.BlendDistance,
                dim = s_ProbeSet.Dim,
                priority = s_ProbeSet.Priority,
                probeCount = s_ProbeSet.ProbeCount,
                globalOffset = s_ProbeSet.GlobalOffset,
                staticProbeSet = s_ProbeSet.StaticProbeSet,
                dynamicDataEnable = s_ProbeSet.DynamicDataEnable,
                indirection = s_ProbeSet.Indirection,
                positions = s_ProbeSet.Positions,
                validIndices = s_ProbeSet.ValidIndices,
                reencodesExactly = ReEncodes(s_ProbeSet, p_Data)
            };
        }

        internal static object DumpStaticDatabase(byte[] p_Data)
        {
            var s_Static = new StaticEnlightenDatabase();
            s_Static.Deserialize(p_Data);

            return new
            {
                type = "StaticEnlightenDatabase",
                enabled = s_Static.Enabled,
                outputAtlasWidth = s_Static.OutputAtlasWidth,
                outputAtlasHeight = s_Static.OutputAtlasHeight,
                // The coefficients themselves are the bulk of the resource and mean nothing read
                // one by one, so the dump reports how many there are and proves it can write them
                // back rather than printing 2707 sets of sixteen floats.
                probeCount = s_Static.Probes.Count,
                reencodesExactly = ReEncodes(s_Static, p_Data)
            };
        }

        internal static object DumpShaderDatabase(byte[] p_Data)
        {
            var s_Shaders = new EnlightenShaderDatabase();
            s_Shaders.Deserialize(p_Data);

            return new
            {
                type = "EnlightenShaderDatabase",
                materials = s_Shaders.Materials.ConvertAll(p_Material => (object)new
                {
                    color = p_Material.Color,
                    guid = p_Material.Guid.ToString(),
                    shaderId = p_Material.ShaderId,
                    emissive = p_Material.Emissive
                }),
                reencodesExactly = ReEncodes(s_Shaders, p_Data)
            };
        }
    }
}
