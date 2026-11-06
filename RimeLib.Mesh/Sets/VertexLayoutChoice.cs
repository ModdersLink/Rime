using System.Collections.Generic;
using System.Linq;

namespace RimeLib.Mesh.Sets;

/// <summary>Picks the layout a subset's vertices fit best of the ones a shader was built for.</summary>
public static class VertexLayoutChoice
{
    /// <summary>
    /// The candidate that leaves fewest of its elements without a source (they would be zero), then
    /// drops fewest of the subset's usages, then converts fewest formats; the first of equal ones.
    /// None when there is no candidate.
    /// </summary>
    public static VertexLayout? Closest(VertexLayout p_Subset, IEnumerable<VertexLayout> p_Candidates)
    {
        var s_Source = p_Subset.Elements.GroupBy(p_E => p_E.Usage).ToDictionary(p_G => p_G.Key, p_G => p_G.First().Format);
        return p_Candidates
            .Select((p_Layout, i) =>
            {
                var s_Usages = p_Layout.Elements.Select(p_E => p_E.Usage).ToHashSet();
                return (Layout: p_Layout, Index: i,
                    Missing: p_Layout.Elements.Count(p_E => !s_Source.ContainsKey(p_E.Usage)),
                    Dropped: s_Source.Keys.Count(p_U => !s_Usages.Contains(p_U)),
                    Converted: p_Layout.Elements.Count(p_E => s_Source.TryGetValue(p_E.Usage, out var s_Format) && s_Format != p_E.Format));
            })
            .OrderBy(p_C => p_C.Missing)
            .ThenBy(p_C => p_C.Dropped)
            .ThenBy(p_C => p_C.Converted)
            .ThenBy(p_C => p_C.Index)
            .Select(p_C => p_C.Layout)
            .FirstOrDefault();
    }
}
