using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite;

namespace RimeLib.Serialization.Frostbite2_0;

/// <summary>
/// Frostbite 2 indexes: each bundle's MeshVariationDatabase, and the RegistryContainer that LevelData
/// and every SubWorldData carry.
/// </summary>
public class LevelIndexes : ILevelIndexes
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2_0 };
    }

    public string? GetPartitionIndexKind(DataContainerBase p_PrimaryInstance)
    {
        return p_PrimaryInstance is fb.MeshVariationDatabase ? "MeshVariationDatabase" : null;
    }

    public IEnumerable<(string Kind, IEnumerable<CtrRefBase> Entries)> GetEmbeddedIndexes(DataContainerBase p_Instance)
    {
        if (p_Instance is not fb.RegistryContainer s_Registry)
            yield break;

        yield return ("RegistryContainer.EntityRegistry", s_Registry.EntityRegistry);
        yield return ("RegistryContainer.AssetRegistry", s_Registry.AssetRegistry);
        yield return ("RegistryContainer.BlueprintRegistry", s_Registry.BlueprintRegistry);
        yield return ("RegistryContainer.ReferenceObjectRegistry", s_Registry.ReferenceObjectRegistry);
    }

    public IEnumerable<CtrRefBase> GetIndexEntries(DatabasePartitionBase p_Partition)
    {
        if (p_Partition.PrimaryInstance is not fb.MeshVariationDatabase s_Database)
            yield break;

        // The entries are instances of the same partition, referenced from the database.
        var s_Instances = p_Partition.Instances.Where(p_I => p_I != null)
            .GroupBy(p_I => p_I.InstanceId).ToDictionary(p_G => p_G.Key, p_G => p_G.First());

        foreach (var s_EntryRef in s_Database.Entries)
        {
            if (s_EntryRef.IsNull() || !s_Instances.TryGetValue(s_EntryRef.InstanceId, out var s_Instance))
                continue;

            if (s_Instance is fb.MeshVariationDatabaseEntry s_Entry && !s_Entry.Mesh.IsNull())
                yield return s_Entry.Mesh;
        }
    }
}
