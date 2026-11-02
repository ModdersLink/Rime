using System.Collections.Generic;
using RimeLib.Frostbite;

namespace RimeLib.Serialization;

/// <summary>
/// How an engine's mesh variation databases are laid out: the entries a database holds, keyed by
/// mesh and variation name hash, and which assets are meshes and variations.
/// </summary>
public interface IMeshVariationRules : IEngineInterface
{
    /// <summary>The entries of a mesh variation database partition, empty when it is not one.</summary>
    IEnumerable<(CtrRefBase Mesh, uint VariationHash, object Entry)> ReadEntries(DatabasePartitionBase p_Partition);

    /// <summary>The entries a database redirects (shares from another), as mesh and variation hash.</summary>
    IEnumerable<(CtrRefBase Mesh, uint VariationHash)> ReadRedirects(DatabasePartitionBase p_Partition);

    bool IsMesh(DataContainerBase p_Instance);

    /// <summary>Whether a bundle whose database would have no entries ships none.</summary>
    bool OmitsEmptyDatabase => false;

    /// <summary>What each material of an entry draws with: its material variation if it has one, else the material.</summary>
    IEnumerable<CtrRefBase> GetDrawnMaterials(object p_Entry);

    /// <summary>The name hash a variation is looked up by, or null when the instance is not a variation.</summary>
    uint? GetVariationHash(DataContainerBase p_Instance);

    /// <summary>What an entry binds (materials, material variations, textures), as text, to compare entries of different databases.</summary>
    string Fingerprint(object p_Entry);

    /// <summary>
    /// What an instance places with which variation: the meshes under each placed asset or entity
    /// are used with that variation hash (0 for none). Static model groups pick a variation per
    /// instance by hash; unlocks pair an asset with a variation. Empty for other instances.
    /// </summary>
    IEnumerable<(CtrRefBase Placed, uint VariationHash)> GetPlacements(DataContainerBase p_Instance, System.Func<CtrRefBase, DataContainerBase?> p_Resolve);

    /// <summary>
    /// Whether an instance uses the meshes it references without the mesh variation database (mesh
    /// particle emitters), so that use gives the mesh no entry.
    /// </summary>
    bool UsesMeshesUnvaried(DataContainerBase p_Instance);

    /// <summary>
    /// Replaces a database's entries with the given ones (read from other databases with
    /// <see cref="ReadEntries"/>) and drops its redirects, keeping its primary instance.
    /// </summary>
    void SetEntries(DatabasePartitionBase p_Database, IReadOnlyList<object> p_Entries);

    /// <summary>Whether a mesh used with a variation also gets its plain entry (Frostbite 2013.2), or only when used plainly.</summary>
    bool PlainEntryWithVariations { get; }
}
