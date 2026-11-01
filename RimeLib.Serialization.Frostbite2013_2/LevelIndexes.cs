using RimeLib.Frostbite;

namespace RimeLib.Serialization.Frostbite2013_2;

/// <summary>
/// Frostbite 2013.2 indexes: each bundle's MeshVariationDatabase, and the NetworkRegistryAsset each
/// level and sub-world has as a partition of its own (`*_networkregistry_win32`); there is no
/// RegistryContainer in this engine.
/// </summary>
public class LevelIndexes : ILevelIndexes
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2013_2 };
    }

    public string? GetPartitionIndexKind(DataContainerBase p_PrimaryInstance)
    {
        return p_PrimaryInstance switch
        {
            fb.Render.MeshVariationDatabase => "MeshVariationDatabase",
            fb.Entity.NetworkRegistryAsset => "NetworkRegistryAsset",
            _ => null,
        };
    }

    public IEnumerable<(string Kind, IEnumerable<CtrRefBase> Entries)> GetEmbeddedIndexes(DataContainerBase p_Instance)
    {
        yield break;
    }

    public IEnumerable<CtrRefBase> GetIndexEntries(DatabasePartitionBase p_Partition)
    {
        switch (p_Partition.PrimaryInstance)
        {
            case fb.Render.MeshVariationDatabase s_Database:
                foreach (var s_Entry in s_Database.Entries)
                {
                    if (s_Entry?.Mesh != null && !s_Entry.Mesh.IsNull())
                        yield return s_Entry.Mesh;
                }
                break;

            case fb.Entity.NetworkRegistryAsset s_Registry:
                foreach (var s_Object in s_Registry.Objects)
                {
                    if (!s_Object.IsNull())
                        yield return s_Object;
                }
                break;
        }
    }
}
