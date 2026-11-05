using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2_0
{
    /// <summary>
    /// The decal shaders of a level's TerrainDecals, to draw other decals with. Frostbite 2 compiles
    /// terrain decal shaders per level and looks them up by name, so decals from elsewhere can only draw
    /// with shaders a level of its own has. A decal takes the shader whose name says most alike what it
    /// draws (road, dirt, tracks, ...); a 3d shader's 2d counterpart is the 2d shader of the block that
    /// covers the same decal cell at the same position in the template.
    /// </summary>
    public sealed class TemplateDecalShaders
    {
        private sealed record Shader(string Name, string ZOnlyName, HashSet<string> Words, HashSet<string> Kinds, uint Primitives);

        // Words that say what a decal draws, grouped by the surface they draw.
        private static readonly Dictionary<string, string[]> s_Kinds = new()
        {
            ["paved"] = ["road", "roads", "tarmac", "asphalt", "street", "highway", "parking", "concrete", "pavement", "sidewalk", "yellow", "line", "lines", "marking", "markings", "stripe", "crosswalk"],
            ["dirt"] = ["dirt", "mud", "gravel", "trail", "path", "sand", "earth", "ground", "offroad", "rubble"],
            ["tracks"] = ["track", "tracks", "tire", "tiretrack", "tyre", "tank", "tanktracks", "skid"],
            ["snow"] = ["snow", "ice", "frost"],
            ["grass"] = ["grass", "moss", "leaves", "foliage"],
            ["footprint"] = ["footprint", "footprints", "foot", "yeti", "steps"],
            ["water"] = ["water", "puddle", "wet"],
        };

        private static readonly HashSet<string> s_Ignored = ["ss", "decal", "decals", "decal2d", "decal3d", "2d", "3d", "shader", "shaders", "levels", "terrain"];

        private readonly Dictionary<DecalGeometryKind, List<Shader>> m_Shaders = new();
        private readonly Dictionary<string, Shader> m_Counterparts2d = new(StringComparer.OrdinalIgnoreCase);
        private readonly IReadOnlyList<(string Pattern, string Shader)> m_Overrides;

        /// <param name="p_Overrides">
        /// Shaders chosen by hand: a decal whose shader name contains a pattern takes its shader, first
        /// match first; an empty shader leaves the decal out.
        /// </param>
        public TemplateDecalShaders(TerrainDecalsResource p_Template, IReadOnlyList<(string Pattern, string Shader)>? p_Overrides = null)
        {
            m_Overrides = p_Overrides ?? [];

            foreach (var (s_Kind, s_Geometry) in new[] { (DecalGeometryKind.Decal2d, p_Template.Geometry2d), (DecalGeometryKind.Decal3d, p_Template.Geometry3d) })
            {
                m_Shaders[s_Kind] = s_Geometry.Blocks
                    .GroupBy(p_Block => p_Block.SurfaceShaderName, StringComparer.OrdinalIgnoreCase)
                    .Select(p_Group =>
                    {
                        var s_Words = Words(p_Group.Key);
                        return new Shader(p_Group.Key, p_Group.First().ZOnlySurfaceShaderName, s_Words, KindsOf(s_Words),
                            (uint)p_Group.Sum(p_Block => p_Block.PrimitiveCount));
                    })
                    .ToList();
            }

            var s_Blocks2d = p_Template.Geometry2d.Blocks;
            var s_Blocks3d = p_Template.Geometry3d.Blocks;
            for (var i = 0; i < System.Math.Min(s_Blocks2d.Count, s_Blocks3d.Count); ++i)
            {
                var (s_Block2d, s_Block3d) = (s_Blocks2d[i], s_Blocks3d[i]);
                if (s_Block2d.BoundingBox2[0] != s_Block3d.BoundingBox2[0] || s_Block2d.BoundingBox2[2] != s_Block3d.BoundingBox2[2])
                    continue;

                m_Counterparts2d.TryAdd(s_Block3d.SurfaceShaderName, Find(DecalGeometryKind.Decal2d, s_Block2d.SurfaceShaderName)!);
            }
        }

        /// <summary>All shaders of a kind of geometry, by name.</summary>
        public IEnumerable<string> Names(DecalGeometryKind p_Kind) => m_Shaders[p_Kind].Select(p_Shader => p_Shader.Name);

        /// <summary>
        /// The shader, and its z-only shader, a decal drawn with <paramref name="p_Shader"/> in a
        /// geometry of <paramref name="p_Kind"/> draws with; none when no shader is alike.
        /// </summary>
        public (string Shader, string ZOnlyShader)? Match(DecalGeometryKind p_Kind, string p_Shader)
        {
            if (!m_Shaders.TryGetValue(p_Kind, out var s_Shaders))
                return null;

            foreach (var (s_Pattern, s_Override) in m_Overrides)
            {
                if (!p_Shader.Contains(s_Pattern, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (s_Override.Length == 0)
                    return null;

                return Find(p_Kind, s_Override) is { } s_Chosen ? (s_Chosen.Name, s_Chosen.ZOnlyName) : null;
            }

            var s_Words = Words(p_Shader);
            var s_Kinds = KindsOf(s_Words);
            var s_Best = s_Shaders
                .Select(p_Candidate => (Shader: p_Candidate, Score: Score(s_Words, s_Kinds, p_Candidate)))
                .Where(p_Scored => p_Scored.Score > 0)
                .OrderByDescending(p_Scored => p_Scored.Score)
                .ThenByDescending(p_Scored => p_Scored.Shader.Primitives)
                .Select(p_Scored => p_Scored.Shader)
                .FirstOrDefault();

            return s_Best == null ? null : (s_Best.Name, s_Best.ZOnlyName);
        }

        /// <summary>The 2d shader that draws a 3d shader's decals far away; none when the template has none.</summary>
        public (string Shader, string ZOnlyShader)? Counterpart2d(string p_Shader3d) =>
            m_Counterparts2d.TryGetValue(p_Shader3d, out var s_Shader) ? (s_Shader.Name, s_Shader.ZOnlyName) : null;

        private Shader? Find(DecalGeometryKind p_Kind, string p_Name) =>
            m_Shaders[p_Kind].FirstOrDefault(p_Shader => string.Equals(p_Shader.Name, p_Name, StringComparison.OrdinalIgnoreCase));

        /// <summary>Words in common and kinds of surface in common, less half a point per kind the candidate draws and the decal does not.</summary>
        private static double Score(HashSet<string> p_Words, HashSet<string> p_Kinds, Shader p_Candidate) =>
            p_Words.Count(p_Candidate.Words.Contains)
            + p_Kinds.Count(p_Candidate.Kinds.Contains)
            - 0.5 * p_Candidate.Kinds.Count(p_Kind => !p_Kinds.Contains(p_Kind));

        private static HashSet<string> KindsOf(HashSet<string> p_Words) =>
            s_Kinds.Where(p_Kind => p_Kind.Value.Any(p_Words.Contains)).Select(p_Kind => p_Kind.Key).ToHashSet();

        /// <summary>
        /// The words of a shader's own name, split at underscores and case changes, without numbers and
        /// without the words of its folder, which name its level.
        /// </summary>
        private static HashSet<string> Words(string p_Shader)
        {
            var s_Slash = p_Shader.LastIndexOf('/');
            var s_Folder = Split(s_Slash < 0 ? "" : p_Shader[..s_Slash]);
            return Split(p_Shader[(s_Slash + 1)..])
                .Where(p_Word => !s_Folder.Contains(p_Word) && !s_Ignored.Contains(p_Word) && !p_Word.All(char.IsDigit))
                .ToHashSet();
        }

        private static HashSet<string> Split(string p_Text) =>
            Regex.Split(Regex.Replace(p_Text, "([a-z])([A-Z])", "$1_$2"), "[^A-Za-z0-9]+")
                .Where(p_Word => p_Word.Length > 0)
                .Select(p_Word => p_Word.ToLowerInvariant())
                .ToHashSet();
    }
}
