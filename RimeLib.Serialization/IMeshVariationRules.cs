using System.Collections.Generic;
using System.Numerics;
using RimeLib.Frostbite;

namespace RimeLib.Serialization;

/// <summary>
/// A material slot of a mesh variation entry: the mesh material, the material variation and the
/// textures the entry itself binds, by parameter name.
/// </summary>
public sealed record MeshVariationMaterial(CtrRefBase Material, CtrRefBase MaterialVariation, IReadOnlyList<(string Name, CtrRefBase Texture)> Textures);

/// <summary>A surface shader instance: its shader and the textures and vectors it sets, by parameter name.</summary>
public sealed record ShaderInstanceModel(CtrRefBase Shader, IReadOnlyList<(string Name, CtrRefBase Texture)> Textures, IReadOnlyList<(string Name, Vector4 Value)> Vectors);

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

    /// <summary>The redirect entries of a mesh variation database partition, as <see cref="ReadEntries"/> gives its entries.</summary>
    IEnumerable<(CtrRefBase Mesh, uint VariationHash, object Entry)> ReadRedirectEntries(DatabasePartitionBase p_Partition);

    bool IsMesh(DataContainerBase p_Instance);

    /// <summary>Whether a bundle whose database would have no entries ships none.</summary>
    bool OmitsEmptyDatabase => false;

    /// <summary>What each material of an entry draws with: its material variation if it has one, else the material.</summary>
    IEnumerable<CtrRefBase> GetDrawnMaterials(object p_Entry);

    /// <summary>The name hash a variation is looked up by, or null when the instance is not a variation.</summary>
    uint? GetVariationHash(DataContainerBase p_Instance);

    /// <summary>What an entry binds (materials, material variations, textures), as text, to compare entries of different databases.</summary>
    string Fingerprint(object p_Entry);

    /// <summary>The textures an entry binds; the only place a shipped mesh's texture bindings exist.</summary>
    IEnumerable<CtrRefBase> GetTextures(object p_Entry);

    /// <summary>An entry's material slots, in the order a mesh subset's material index counts them.</summary>
    IReadOnlyList<MeshVariationMaterial> GetMaterials(object p_Entry);

    /// <summary>The shader instance of a mesh material or a mesh material variation, or null for other instances.</summary>
    ShaderInstanceModel? GetShaderInstance(DataContainerBase p_Instance);

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

    /// <summary>
    /// Adds entries and redirect entries (read from another database with <see cref="ReadEntries"/>
    /// and <see cref="ReadRedirectEntries"/>) to a database after its own.
    /// </summary>
    void AddEntries(DatabasePartitionBase p_Database, IReadOnlyList<object> p_Entries, IReadOnlyList<object> p_Redirects);

    /// <summary>Whether a mesh used with a variation also gets its plain entry (Frostbite 2013.2), or only when used plainly.</summary>
    bool PlainEntryWithVariations { get; }
}
