using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Frostbite2_0;

/// <summary>
/// Frostbite 2 registry rules, as measured on retail levels with analyze_registry: networked entity
/// data, unlocks, variations and customizations, the skinned meshes unlocks point at, blueprints
/// that need a network id and the reference objects of such blueprints.
/// </summary>
public class RegistryRules : IRegistryRules
{
    private const string c_Entities = "RegistryContainer.EntityRegistry";
    private const string c_Assets = "RegistryContainer.AssetRegistry";
    private const string c_Blueprints = "RegistryContainer.BlueprintRegistry";
    private const string c_ReferenceObjects = "RegistryContainer.ReferenceObjectRegistry";

    public bool CoversBundle => false;

    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2_0 };
    }

    public IEnumerable<(string Kind, CtrRefBase Entry)> GetEntries(IReadOnlyList<DataContainerBase> p_Closure, Func<CtrRefBase, DataContainerBase?> p_Resolve)
    {
        var s_Listed = new HashSet<string>();
        foreach (var s_Instance in p_Closure)
        {
            foreach (var s_Entry in GetEntries(s_Instance, p_Resolve))
            {
                if (s_Entry.Kind is c_Entities or c_ReferenceObjects)
                    s_Listed.Add(Key(s_Entry.Entry));
                yield return s_Entry;
            }
        }

        // A prefab without a network id of its own (world parts above all) is listed when it holds a
        // listed object itself, or objects that are networked without being in a registry (test
        // soldiers), or when an event from outside starts one of its model animations (building
        // collapses; cloth animations started by the prefab itself don't count); and with it every reference object that places it. Listing a
        // reference object can list the prefab holding it, so this runs to a fixed point.
        var s_Prefabs = p_Closure.OfType<fb.PrefabBlueprint>().Where(p_P => !p_P.NeedNetworkId && p_P.Partition != null).ToList();
        var s_References = p_Closure.OfType<fb.ReferenceObjectData>().Where(p_R => p_R.Partition != null && !s_Listed.Contains(Key(Self(p_R)))).ToList();
        var s_ListedPrefabs = new HashSet<string>();
        for (var s_Changed = true; s_Changed;)
        {
            s_Changed = false;
            foreach (var s_Prefab in s_Prefabs)
            {
                var s_Self = Self(s_Prefab);
                if (s_ListedPrefabs.Contains(Key(s_Self)) ||
                    !(s_Prefab.Objects.Any(p_O => s_Listed.Contains(Key(p_O)) || p_Resolve(p_O) is fb.SoldierTestEntityData) || StartsAnimationFromOutside(s_Prefab, p_Resolve)))
                    continue;

                s_ListedPrefabs.Add(Key(s_Self));
                s_Changed = true;
                yield return (c_Blueprints, s_Self);
            }

            foreach (var s_Reference in s_References)
            {
                var s_Self = Self(s_Reference);
                if (s_Listed.Contains(Key(s_Self)) || !s_ListedPrefabs.Contains(Key(s_Reference.Blueprint)))
                    continue;

                s_Listed.Add(Key(s_Self));
                s_Changed = true;
                yield return (c_ReferenceObjects, s_Self);
            }
        }
    }

    /// <summary>An event from the prefab's interface (from outside, e.g. destruction) starts a model animation.</summary>
    private static bool StartsAnimationFromOutside(fb.PrefabBlueprint p_Prefab, Func<CtrRefBase, DataContainerBase?> p_Resolve)
    {
        return !p_Prefab.Descriptor.IsNull() && p_Prefab.EventConnections.Any(p_C =>
            p_C.Source.InstanceId.Equals(p_Prefab.Descriptor.InstanceId) && p_Resolve(p_C.Target) is fb.ModelAnimationEntityData);
    }

    private static CtrRefBase Self(DataContainerBase p_Instance) => new(p_Instance.Partition!.PartitionGuid, p_Instance.InstanceId);

    private static string Key(CtrRefBase p_Ref) => $"{p_Ref.PartitionGuid}/{p_Ref.InstanceId}";

    private static IEnumerable<(string Kind, CtrRefBase Entry)> GetEntries(DataContainerBase p_Instance, Func<CtrRefBase, DataContainerBase?> p_Resolve)
    {
        if (p_Instance.Partition == null)
            yield break;

        var s_Self = new CtrRefBase(p_Instance.Partition.PartitionGuid, p_Instance.InstanceId);

        if (IsNetworkedEntity(p_Instance))
            yield return (c_Entities, s_Self);

        if (p_Instance is fb.UnlockAssetBase or fb.ObjectVariation or fb.CharacterCustomizationAsset)
            yield return (c_Assets, s_Self);

        // Skinned meshes are listed only when an unlock points at them.
        if (p_Instance is fb.UnlockAsset s_Unlock)
        {
            foreach (var s_Linked in s_Unlock.LinkedTo)
            {
                switch (p_Resolve(s_Linked))
                {
                    case fb.SkinnedMeshAsset:
                        yield return (c_Assets, s_Linked);
                        break;
                    case fb.BlueprintAndVariationPair s_Pair when p_Resolve(s_Pair.BaseAsset) is fb.SkinnedMeshAsset:
                        yield return (c_Assets, s_Pair.BaseAsset);
                        break;
                }
            }
        }

        if (p_Instance is fb.Blueprint { NeedNetworkId: true })
            yield return (c_Blueprints, s_Self);

        // Spawn points and sub-world references have no blueprint of their own to ask; they are always
        // listed. The level's reference to itself (LevelData.LevelReference) is not.
        if (p_Instance is fb.ReferenceObjectData s_Reference &&
            (p_Instance is fb.SpawnReferenceObjectData or fb.SubWorldReferenceObjectData ||
             p_Resolve(s_Reference.Blueprint) is fb.Blueprint { NeedNetworkId: true } and not fb.LevelData))
            yield return (c_ReferenceObjects, s_Self);
    }

    public IEnumerable<string> GetSubWorldBundles(DataContainerBase p_Instance)
    {
        if (p_Instance is fb.SubWorldReferenceObjectData s_SubWorld && !string.IsNullOrEmpty(s_SubWorld.BundleName))
            yield return s_SubWorld.BundleName;
    }

    public DataContainerBase CreateRegistry(IReadOnlyDictionary<string, List<CtrRefBase>> p_Entries)
    {
        RefArray<fb.DataContainer> List(string p_Kind)
        {
            var s_List = new RefArray<fb.DataContainer>();
            foreach (var s_Entry in p_Entries.GetValueOrDefault(p_Kind) ?? new List<CtrRefBase>())
                s_List.Add(new CtrRef<fb.DataContainer>(s_Entry.PartitionGuid, s_Entry.InstanceId));
            return s_List;
        }

        return new fb.RegistryContainer
        {
            InstanceId = new DataContainerId.Guid(GUID.Empty),
            EntityRegistry = List(c_Entities),
            AssetRegistry = List(c_Assets),
            BlueprintRegistry = List(c_Blueprints),
            ReferenceObjectRegistry = List(c_ReferenceObjects),
        };
    }

    public bool IsDescriptionOnly(DataContainerBase p_Instance)
    {
        return p_Instance is fb.InterfaceDescriptorData;
    }

    public IEnumerable<string> GetLevelBundles(string p_LevelPartition)
    {
        yield return $"win32/{p_LevelPartition}";
        yield return $"win32/{p_LevelPartition}_settings_win32";
    }

    private static bool IsNetworkedEntity(DataContainerBase p_Instance)
    {
        return p_Instance switch
        {
            fb.DebrisClusterData s_Debris => !s_Debris.ClientSideOnly,
            fb.BulletEntityData => false,
            fb.WeaponEntityData or fb.ControllableEntityData or fb.ProjectileEntityData or fb.VehicleProjectileEntityData
                or fb.PickupEntityData or fb.BangerEntityData or fb.VegetationBaseEntityData
                or fb.SyncedBoolEntityData or fb.SyncedSequenceEntityData or fb.SyncedTransformEntityData or fb.EventSyncEntityData
                or fb.CoopLobbyEntityData
                or fb.ObjectiveEntityData or fb.CapturePointEntityData or fb.MapMarkerEntityData or fb.CombatAreaTriggerEntityData
                or fb.GameInteractionEntityData or fb.LifeCounterEntityData or fb.TicketCounterEntityData
                or fb.PreRoundEntityData or fb.RoundOverEntityData => true,
            _ => false,
        };
    }
}
