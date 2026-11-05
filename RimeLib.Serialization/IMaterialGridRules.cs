using System;
using System.Collections.Generic;
using RimeLib.Frostbite;

namespace RimeLib.Serialization;

/// <summary>
/// An engine's material grids (MaterialGridData): which global material indices a grid has rows for,
/// and building a grid from others. Every retail grid is a consistent piece of one global grid, so a
/// grid can be assembled from the rows and relations of others.
/// </summary>
public interface IMaterialGridRules : IEngineInterface
{
    /// <summary>The global material indices a grid has rows for, its default material included.</summary>
    IReadOnlyCollection<uint> GetMaterials(DatabasePartitionBase p_Grid);

    /// <summary>
    /// Rebuilds <paramref name="p_Target"/> (keeping its primary instance, default material and
    /// material pairs) from the rows and relations of <paramref name="p_Sources"/>, for the given
    /// global material indices (all of the sources' when null). Relation data is copied in under
    /// new instance ids. Returns how many material pairs no source relates; those take the relation
    /// of the row material with the default material.
    /// </summary>
    int Merge(DatabasePartitionBase p_Target, IReadOnlyList<DatabasePartitionBase> p_Sources, ISet<uint>? p_Materials);

    /// <summary>
    /// Every relation and material property of a grid as text, by global material index pair (a
    /// property as the pair of an index with itself under <c>uint.MaxValue</c>), independent of
    /// rows and instance ids, to compare grids.
    /// </summary>
    IReadOnlyDictionary<(uint, uint), string> Describe(DatabasePartitionBase p_Grid);

    /// <summary>
    /// Whether an EBX value is a material reference, and the packed material value it stands for:
    /// a MaterialContainerPair reference (Frostbite 2) or a MaterialDecl (Frostbite 2013.2).
    /// </summary>
    bool TryGetPackedMaterial(object p_Value, Func<CtrRefBase, DataContainerBase?> p_Resolve, out uint p_Packed);

    /// <summary>
    /// The global material indices a packed material value names (a material and a property), as
    /// EBX, Havok physics data and terrain material trees store it.
    /// </summary>
    IReadOnlyCollection<uint> GetMaterials(uint p_Packed, Func<string, DatabasePartitionBase?> p_Parse);

    /// <summary>A global material index's name, where the game ships one.</summary>
    string? GetMaterialName(uint p_Material, Func<string, DatabasePartitionBase?> p_Parse);

    /// <summary>The material and the property a packed material value names, where it names a pair.</summary>
    bool TryUnpack(uint p_Packed, Func<string, DatabasePartitionBase?> p_Parse, out uint p_Material, out uint p_Property);

    /// <summary>
    /// A material and a property as this engine stores the pair: the packed value Havok physics data
    /// keeps, and the EBX value (a MaterialContainerPair reference or a MaterialDecl). False where
    /// the engine has no such pair.
    /// </summary>
    bool TryPack(uint p_Material, uint p_Property, Func<string, DatabasePartitionBase?> p_Parse, out uint p_Packed, out object p_Value);
}
