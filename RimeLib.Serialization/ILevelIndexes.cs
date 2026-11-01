using System.Collections.Generic;
using RimeLib.Frostbite;

namespace RimeLib.Serialization;

/// <summary>
/// Which assets of an engine are indexes: assets that list other assets on behalf of other content
/// (registries, mesh variation databases), as opposed to content that uses what it references. The
/// engine reads an index as a set to register or bind, so a reference from one says "this is
/// registered here", not "this needs that".
/// </summary>
public interface ILevelIndexes : IEngineInterface
{
    /// <summary>
    /// The kind of index a whole partition is, judged by its primary instance (a mesh variation
    /// database, a network registry), or null when it is not one.
    /// </summary>
    string? GetPartitionIndexKind(DataContainerBase p_PrimaryInstance);

    /// <summary>
    /// The index lists an instance of an otherwise ordinary partition holds, as kind and entries
    /// (for example a RegistryContainer inside LevelData). Empty when it holds none.
    /// </summary>
    IEnumerable<(string Kind, IEnumerable<CtrRefBase> Entries)> GetEmbeddedIndexes(DataContainerBase p_Instance);

    /// <summary>
    /// For a whole-partition index: the asset each entry is about (the mesh of a mesh variation
    /// entry, the object of a registry), for breaking the index down entry by entry.
    /// </summary>
    IEnumerable<CtrRefBase> GetIndexEntries(DatabasePartitionBase p_Partition);
}
