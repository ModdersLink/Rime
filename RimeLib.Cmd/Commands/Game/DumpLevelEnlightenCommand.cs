using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Every Enlighten resource one level ships, in a single JSON: the structured read where there
    /// is one, and the shipped bytes verbatim in all cases.
    ///
    /// <see cref="DumpEnlightenCommand"/> dumps one resource by name, which is fine for looking at
    /// a probe set and useless for carrying a level: the names are only discoverable from the
    /// database's own <c>probeSetNames</c>, so a caller cannot ask for them until it has already
    /// mounted and read. MP_001 alone names 159 probe sets. Following that list here means one
    /// mount answers the whole question.
    ///
    /// Each resource carries its payload base64'd. That is the point rather than a fallback: an
    /// Enlighten bake describes light for the geometry that was there when it was computed, so
    /// nothing downstream can regenerate one, and the only honest thing to carry is the bytes. The
    /// parsed fields ride alongside so the data can be inspected and placed, not so it can be
    /// rebuilt from them.
    ///
    /// <see cref="ResourceType.EnlightenSystem"/> is included with payload and no fields. Nothing
    /// in Rime decodes Enlighten's radiosity data, and a level that carries every other Enlighten
    /// resource and silently drops those is carrying an incomplete bake.
    /// </summary>
    [CommandDescription("Dumps every Enlighten resource belonging to one level as a single JSON, payloads included.")]
    public class DumpLevelEnlightenCommand : Command
    {
        [CommandArgument(Description = "The level, e.g. mp_001 -- or a full resource-name prefix if it contains a slash")]
        public string? Level { get; set; }

        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        /// <summary>
        /// The resource types this considers Enlighten. Deliberately a list rather than a name
        /// test: <c>levels/mp_001/lighting/</c> also holds textures, and a lightmap texture comes
        /// out through dump_texture like any other.
        /// </summary>
        private static readonly ResourceType[] s_EnlightenTypes =
        {
            ResourceType.EnlightenDatabase,
            ResourceType.EnlightenProbeSet,
            ResourceType.EnlightenShaderDatabase,
            ResourceType.EnlightenSystem,
            ResourceType.StaticEnlightenDatabase,
            ResourceType.EnlightenStaticDatabase,
        };

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Level) || Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_level_enlighten <level> <destination.json>");
                return false;
            }

            var s_Prefix = Level!.Contains('/') ? Level! : "levels/" + Level + "/";
            var s_Resources = ((GameContext)p_Context).GetMountedResourceVariations();

            var s_Rows = new List<object>();
            var s_Counts = new Dictionary<string, int>();
            long s_PayloadBytes = 0;
            var s_Checked = 0;
            var s_Exact = 0;

            foreach (var s_Resource in s_Resources)
            {
                if (!s_Resource.Key.StartsWith(s_Prefix, StringComparison.OrdinalIgnoreCase))
                    continue;

                var s_Variant = s_Resource.Value.FirstVariant;

                if (s_Variant == null)
                    continue;

                var s_Type = s_Variant.GetResourceType();

                if (Array.IndexOf(s_EnlightenTypes, s_Type) < 0)
                    continue;

                byte[] s_Data;

                using (var s_Source = s_Variant.GetReader())
                    s_Data = s_Source.ReadBytes((int)s_Source.Length);

                // Parse returns null for the types nothing here decodes; the payload still goes out.
                var s_Parsed = DumpEnlightenCommand.Parse(s_Type, s_Data);
                bool? s_ReEncodes = null;

                if (s_Parsed != null)
                {
                    // Read off the anonymous object rather than re-serialising: the parse already
                    // measured this against the original bytes and there is one answer, not two.
                    var s_Field = s_Parsed.GetType().GetProperty("reencodesExactly");
                    s_ReEncodes = s_Field?.GetValue(s_Parsed) as bool?;
                    s_Checked += 1;

                    if (s_ReEncodes == true)
                        s_Exact += 1;
                }

                // The 16-byte resource meta is not in the payload and is needed to put the resource
                // back into a bundle, so it travels with it.
                string? s_Meta = null;

                if (s_Variant.TryGetMeta(out var s_MetaBytes) && s_MetaBytes.Length > 0)
                    s_Meta = Convert.ToHexString(s_MetaBytes);

                s_Counts[s_Type.ToString()] = s_Counts.TryGetValue(s_Type.ToString(), out var s_N) ? s_N + 1 : 1;
                s_PayloadBytes += s_Data.Length;

                s_Rows.Add(new
                {
                    name = s_Resource.Key,
                    type = s_Type.ToString(),
                    length = s_Data.Length,
                    meta = s_Meta,
                    payload = Convert.ToBase64String(s_Data),
                    reencodesExactly = s_ReEncodes,
                    data = s_Parsed,
                });
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
            {
                level = Level,
                prefix = s_Prefix,
                counts = s_Counts,
                resourceCount = s_Rows.Count,
                payloadBytes = s_PayloadBytes,
                reencodeChecked = s_Checked,
                reencodeExact = s_Exact,
                resources = s_Rows,
            }));

            p_Writer.WriteLine(string.Format(
                "dump_level_enlighten: {0} resource(s), {1} payload byte(s), reencode {2}/{3} exact -> {4}",
                s_Rows.Count, s_PayloadBytes, s_Exact, s_Checked, Destination.FullName));

            return s_Rows.Count > 0;
        }
    }
}
