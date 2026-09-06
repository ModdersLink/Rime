using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Terrain.Resources;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Does the VisualTerrain WRITER reproduce the bytes the game ships, and does an edit made
    /// through it actually land?
    ///
    /// Both halves matter and neither is enough alone. A writer that round-trips but drops edits
    /// looks perfect here and loses every change; a writer that carries edits but cannot reproduce
    /// the original is rewriting fields it was only meant to pass through, and the level stops
    /// loading for reasons nothing points at. So this reads the shipped resource, writes it
    /// straight back and compares byte for byte, and THEN changes one scattering density through
    /// the same writer and reads it back to confirm the change is there and nothing else moved.
    ///
    /// Every count reported is asserted non-zero. This project has been burned by checks that
    /// passed because nothing was emitted -- a level with no layers and no scattering would
    /// otherwise "round trip" perfectly.
    /// </summary>
    [CommandDescription("Round-trips a VisualTerrain resource through the writer and reports byte identity, then proves an edit survives.")]
    public class CheckVisualTerrainCommand : Command
    {
        [CommandArgument(Description = "The visual terrain resource, e.g. levels/mp_001/terrain/mp_001.visual")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Optional .json file to write the full result to.", Optional = true)]
        public FileInfo? Destination { get; set; }

        /// <summary>Serves bytes held in memory under another resource's type, meta and id.</summary>
        private class MemoryResource : IResourceObject
        {
            private readonly IResourceObject m_Original;
            private readonly byte[] m_Data;

            public MemoryResource(IResourceObject p_Original, byte[] p_Data)
            {
                m_Original = p_Original;
                m_Data = p_Data;
            }

            public ResourceType GetResourceType() => m_Original.GetResourceType();

            public bool TryGetMeta([NotNullWhen(true)] out byte[]? p_Meta) => m_Original.TryGetMeta(out p_Meta);

            public ResourceRef GetId(string? p_Name = null)
            {
                try { return m_Original.GetId(p_Name); }
                catch { return new ResourceRef(p_Name ?? string.Empty, this); }
            }

            public RimeReader GetReader() => new RimeReader(new MemoryStream(m_Data, false));

            public long GetSize() => m_Data.Length;
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("Usage: check_visual_terrain <visual-terrain-resource> [destination.json]");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource) || s_Resource.FirstVariant == null)
            {
                p_Writer.WriteLine($"Could not find visual terrain resource ({Name}).");
                return false;
            }

            var s_Variant = s_Resource.FirstVariant;
            var s_Terrain = EngineInterfaceRegistry.Create<IVisualTerrain>(s_Mounter.GetEngineType());

            if (!s_Terrain.RoundTripVisualTerrain(s_Variant, out var s_Original, out var s_Rebuilt)
                || s_Original == null || s_Rebuilt == null)
            {
                p_Writer.WriteLine($"{Name}: the writer refused to serialize this resource.");
                return false;
            }

            var s_Identical = 0;
            var s_Compared = System.Math.Min(s_Original.Length, s_Rebuilt.Length);
            long s_FirstDiff = -1;

            for (var i = 0; i < s_Compared; i++)
            {
                if (s_Original[i] == s_Rebuilt[i])
                {
                    s_Identical++;
                    continue;
                }

                if (s_FirstDiff < 0)
                    s_FirstDiff = i;
            }

            var s_ByteExact = s_Original.Length == s_Rebuilt.Length && s_FirstDiff < 0;

            // What the resource actually holds. Reported so a green verdict cannot come from an
            // empty resource, and asserted below.
            if (!s_Terrain.ReadVisualTerrain(s_Variant, s_Mounter, out var s_Info) || s_Info == null)
            {
                p_Writer.WriteLine($"{Name}: round trip measured but the resource would not read back.");
                return false;
            }

            var s_Empty = s_Info.LayerCount == 0 || s_Info.Draws.Count == 0;

            // ---- the edit probe ----------------------------------------------------------------
            // A density that no shipped type uses, so "the edit landed" cannot be confused with
            // "the value was already that".
            const float c_ProbeDensity = 1234.5f;

            var s_EditApplied = false;
            var s_EditReadBack = false;
            var s_EditIsolated = false;
            string? s_EditError = null;
            var s_UnchangedFields = 0;

            if (s_Info.Scattering.Count > 0)
            {
                var s_Edits = JsonConvert.DeserializeObject<VisualTerrainInfo>(
                    JsonConvert.SerializeObject(s_Info))!;

                s_Edits.Draws.Clear();
                s_Edits.LayerVirtualTexture.Clear();
                s_Edits.Scattering[0].Density = c_ProbeDensity;

                s_EditApplied = s_Terrain.WriteVisualTerrain(s_Variant, s_Edits, out var s_EditedBytes, out s_EditError)
                                && s_EditedBytes != null;

                if (s_EditApplied)
                {
                    var s_Edited = new MemoryResource(s_Variant, s_EditedBytes!);

                    if (s_Terrain.ReadVisualTerrain(s_Edited, s_Mounter, out var s_After) && s_After != null
                        && s_After.Scattering.Count == s_Info.Scattering.Count)
                    {
                        s_EditReadBack = s_After.Scattering[0].Density == c_ProbeDensity;

                        // Everything the edit did NOT name has to come back as it went in. Counted
                        // rather than short-circuited so the number is reportable.
                        s_EditIsolated = true;

                        for (var i = 0; i < s_After.Scattering.Count; i++)
                        {
                            var s_Before = JsonConvert.SerializeObject(s_Info.Scattering[i]);
                            var s_Now = JsonConvert.SerializeObject(s_After.Scattering[i]);

                            if (i == 0)
                                continue;

                            if (s_Before == s_Now)
                                s_UnchangedFields++;
                            else
                                s_EditIsolated = false;
                        }
                    }
                }
            }

            var s_Result = new
            {
                name = Name,
                shippedBytes = s_Original.Length,
                rebuiltBytes = s_Rebuilt.Length,
                identicalBytes = s_Identical,
                firstDiff = s_FirstDiff,
                byteExact = s_ByteExact,
                layers = s_Info.LayerCount,
                scatteringTypes = s_Info.Scattering.Count,
                draws = s_Info.Draws.Count,
                editApplied = s_EditApplied,
                editReadBack = s_EditReadBack,
                editIsolated = s_EditIsolated,
                untouchedScatteringTypes = s_UnchangedFields,
                editError = s_EditError,
                // An empty resource makes every other number above meaningless, so it is a
                // first-class part of the verdict rather than something the caller must notice.
                empty = s_Empty
            };

            if (Destination != null)
                File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(s_Result, Formatting.Indented));

            p_Writer.WriteLine($"{Name}: {s_Identical}/{s_Original.Length} byte(s) identical "
                               + $"(rebuilt {s_Rebuilt.Length}, firstDiff {s_FirstDiff}), "
                               + $"{s_Info.LayerCount} layer(s), {s_Info.Scattering.Count} scattering type(s), "
                               + $"{s_Info.Draws.Count} draw(s); "
                               + $"edit applied={s_EditApplied} readBack={s_EditReadBack} "
                               + $"isolated={s_EditIsolated} ({s_UnchangedFields} untouched)"
                               + (s_EditError != null ? $" error={s_EditError}" : string.Empty));

            if (s_Empty)
                p_Writer.WriteLine($"{Name}: NO CONTENT -- the resource has no layers or no draws, so a "
                                   + "byte-exact round trip proves nothing here.");

            return s_ByteExact && !s_Empty;
        }
    }
}
