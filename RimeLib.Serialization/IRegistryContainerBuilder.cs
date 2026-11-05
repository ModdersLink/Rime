using System.Collections.Generic;
using RimeLib.Frostbite;

namespace RimeLib.Serialization;

/// <summary>The four registries of a registry container, as references to what each lists.</summary>
public sealed class RegistryContainerModel
{
    public List<CtrRefBase> Entities { get; } = new();
    public List<CtrRefBase> Assets { get; } = new();
    public List<CtrRefBase> Blueprints { get; } = new();
    public List<CtrRefBase> ReferenceObjects { get; } = new();
}

/// <summary>
/// Builds a registry container from the partitions a bundle carries, by the instance types that
/// need registering, and wraps one in a sub-world partition a mod loader can register.
/// </summary>
public interface IRegistryContainerBuilder : IEngineInterface
{
    /// <summary>An empty registry container.</summary>
    DataContainerBase Create();

    /// <summary>
    /// Adds to a container from <see cref="Create"/> what a partition's instances register:
    /// networked entities, assets and variations, blueprints that need a network id and their
    /// reference objects.
    /// </summary>
    void Add(DataContainerBase p_Registry, DatabasePartitionBase p_Partition);

    /// <summary>What a registry container lists, or null when the instance is not one.</summary>
    RegistryContainerModel? Read(DataContainerBase p_Instance);

    /// <summary>A partition whose sub-world's registry container lists the given entries.</summary>
    DatabasePartitionBase CreateSubWorld(string p_PartitionName, string p_SubWorldName, RegistryContainerModel p_Registry);
}
