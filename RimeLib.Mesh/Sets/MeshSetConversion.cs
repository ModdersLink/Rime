using System;
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

    /// <summary>
    /// The MeshSet under the names <paramref name="p_Rename"/> gives its own and its LODs': each
    /// hash follows its name, hashed as the original's is (in lower case, or as it is).
    /// </summary>
    public static MeshSetModel Renamed(MeshSetModel p_Model, Func<string, string> p_Rename)
    {
        var s_Name = p_Rename(p_Model.Name);
        if (s_Name == p_Model.Name)
            return p_Model;

        return p_Model with
        {
            Name = s_Name,
            NameHash = Rehashed(p_Model.NameHash, p_Model.Name, s_Name),
            Lods = p_Model.Lods.Select(p_Lod =>
            {
                var s_LodName = p_Rename(p_Lod.Name);
                return p_Lod with
                {
                    Name = s_LodName,
                    NameHash = Rehashed(p_Lod.NameHash, p_Lod.Name, s_LodName),
                    ShaderDebugName = p_Lod.ShaderDebugName.EndsWith(p_Lod.Name, StringComparison.Ordinal)
                        ? p_Lod.ShaderDebugName[..^p_Lod.Name.Length] + s_LodName
                        : p_Lod.ShaderDebugName,
                };
            }).ToList(),
        };
    }

    /// <summary>The new name's hash, in lower case where the old name's could be either.</summary>
    private static uint Rehashed(uint p_Hash, string p_Name, string p_NewName) =>
        p_Hash == Frostbite.Utils.HashQuickLowerCase(p_Name) ? Frostbite.Utils.HashQuickLowerCase(p_NewName)
        : p_Hash == Frostbite.Utils.HashQuick(p_Name) ? Frostbite.Utils.HashQuick(p_NewName)
        : p_Hash;
}
