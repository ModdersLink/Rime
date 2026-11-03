using System.Collections.Generic;
using System.Linq;

namespace RimeLib.Mesh.Sets;

/// <summary>
/// Fits a MeshSet to another engine. LODs past the engine's last are dropped, as are vertex
/// elements of a usage the engine does not name; their bytes stay in the vertex data, which keeps
/// its layout, so the chunks are used as they are.
/// </summary>
public static class MeshSetConversion
{
    /// <param name="p_Dropped">Each LOD and vertex usage dropped, by name.</param>
    public static MeshSetModel ToEngine(MeshSetModel p_Model, IMeshSetCodec p_Codec, out IReadOnlyList<string> p_Dropped)
    {
        var s_Dropped = new List<string>();
        if (p_Model.Lods.Count > p_Codec.MaxLodCount)
            s_Dropped.Add($"LODs past {p_Codec.MaxLodCount}");

        var s_Lods = p_Model.Lods.Take(p_Codec.MaxLodCount).Select(p_Lod => p_Lod with
        {
            Subsets = p_Lod.Subsets.Select(p_Subset => p_Subset with
            {
                Elements = p_Subset.Elements.Where(p_Element =>
                {
                    if (p_Codec.Usages.Contains(p_Element.Usage))
                        return true;

                    s_Dropped.Add($"usage {p_Element.Usage}");
                    return false;
                }).ToList(),
            }).ToList(),
        }).ToList();

        p_Dropped = s_Dropped.Distinct().ToList();
        return p_Model with { Lods = s_Lods };
    }
}
