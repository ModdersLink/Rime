using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Frostbite2013_2;

/// <summary>
/// Frostbite 2013.2 registry rules, as measured on retail levels with analyze_registry and
/// derive_registry. Every bundle has one list, the NetworkRegistryAsset of its
/// <c>_networkregistry_win32</c> partition, and it covers the networked content that bundle ships,
/// reached by the level or not; content of other bundles is in their registries. Bit 0 of
/// <c>DataBusData.Flags</c> is what Frostbite 2 calls <c>NeedNetworkId</c>. Unlike Frostbite 2,
/// object variations and event syncs are not listed.
/// </summary>
public class RegistryRules : IRegistryRules
{
    private const string c_Registry = "NetworkRegistryAsset";
    private const ushort c_NeedNetworkId = 1;

    public bool CoversBundle => true;

    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2013_2 };
    }

    public IEnumerable<(string Kind, CtrRefBase Entry)> GetEntries(IReadOnlyList<DataContainerBase> p_Closure, Func<CtrRefBase, DataContainerBase?> p_Resolve)
    {
        foreach (var s_Instance in p_Closure)
        {
            if (s_Instance.Partition != null && IsListed(s_Instance, p_Resolve))
                yield return (c_Registry, Self(s_Instance));
        }
    }

    public IEnumerable<string> GetSubWorldBundles(DataContainerBase p_Instance)
    {
        if (p_Instance is fb.Entity.SubWorldReferenceObjectData s_SubWorld && !string.IsNullOrEmpty(s_SubWorld.BundleName))
            yield return s_SubWorld.BundleName;
    }

    public DataContainerBase CreateRegistry(IReadOnlyDictionary<string, List<CtrRefBase>> p_Entries)
    {
        var s_Registry = new fb.Entity.NetworkRegistryAsset { InstanceId = new DataContainerId.Guid(GUID.Empty) };
        foreach (var s_Entry in p_Entries.GetValueOrDefault(c_Registry) ?? new List<CtrRefBase>())
            s_Registry.Objects.Add(new CtrRef<fb.Core.DataContainer>(s_Entry.PartitionGuid, s_Entry.InstanceId));
        return s_Registry;
    }

    public string GetRegistryPartitionName(string p_LevelPartition) => $"{p_LevelPartition}_networkregistry_win32";

    public void SetRegistry(DatabasePartitionBase p_Partition, IReadOnlyDictionary<string, List<CtrRefBase>> p_Entries)
    {
        var s_Registry = (fb.Entity.NetworkRegistryAsset)p_Partition.PrimaryInstance;
        s_Registry.Objects.Clear();
        foreach (var s_Entry in p_Entries.GetValueOrDefault(c_Registry) ?? new List<CtrRefBase>())
            s_Registry.Objects.Add(new CtrRef<fb.Core.DataContainer>(s_Entry.PartitionGuid, s_Entry.InstanceId));
    }

    public bool IsDescriptionOnly(DataContainerBase p_Instance)
    {
        return p_Instance is fb.Entity.InterfaceDescriptorData or fb.Core.DynamicDataContainer;
    }

    public IEnumerable<string> GetLevelBundles(string p_LevelPartition)
    {
        yield return $"win32/{p_LevelPartition}";
    }

    private static bool IsListed(DataContainerBase p_Instance, Func<CtrRefBase, DataContainerBase?> p_Resolve)
    {
        switch (p_Instance)
        {
            case fb.Entity.SubWorldData:
                return false;
            case fb.Entity.Blueprint s_Blueprint:
                return NeedsNetworkId(s_Blueprint);
            case fb.Entity.SubWorldReferenceObjectData s_SubWorld:
                // A sub-world by bundle name; the one without a bundle (a blueprint instead) is not.
                return !string.IsNullOrEmpty(s_SubWorld.BundleName);
            case fb.GameShared.SpawnReferenceObjectData:
                return true;
            case fb.Entity.ReferenceObjectData s_Reference:
                return p_Resolve(s_Reference.Blueprint) is fb.Entity.Blueprint s_Target && NeedsNetworkId(s_Target) && s_Target is not fb.GameShared.LevelData;
            case fb.GameShared.UnlockAssetBase or fb.GameShared.CharacterCustomizationAsset:
                return true;
            default:
                return IsNetworkedEntity(p_Instance);
        }
    }

    private static bool NeedsNetworkId(fb.Entity.Blueprint p_Blueprint) => (p_Blueprint.Flags & c_NeedNetworkId) != 0;

    private static bool IsNetworkedEntity(DataContainerBase p_Instance)
    {
        return p_Instance switch
        {
            fb.Debris.DebrisClusterData s_Debris => !s_Debris.ClientSideOnly,
            fb.GameShared.BulletEntityData => false,
            fb.SoldierShared.WeaponEntityData or fb.GameShared.ControllableEntityData or fb.GameShared.ProjectileEntityData
                or fb.Venice.VehicleProjectileEntityData or fb.SoldierShared.PickupEntityData or fb.GameShared.BangerEntityData
                or fb.Vegetation.VegetationBaseEntityData
                or fb.Entity.SyncedBoolEntityData or fb.Entity.SyncedIntEntityData or fb.Entity.SyncedFloatEntityData
                or fb.GameShared.SyncedSequenceEntityData or fb.Entity.SyncedTransformEntityData
                or fb.GameShared.ObjectiveEntityData or fb.VeniceShared.CapturePointEntityData or fb.GameShared.MapMarkerEntityData
                or fb.GameShared.CombatAreaTriggerEntityData or fb.GameShared.GameInteractionEntityData
                or fb.Venice.LifeCounterEntityData or fb.VeniceShared.TicketCounterEntityData or fb.Venice.KillCounterEntityData or fb.Venice.GetPlayerNameEntityData
                or fb.VeniceShared.PreRoundEntityData or fb.VeniceShared.RoundOverEntityData or fb.Venice.CoopLobbyEntityData
                or fb.Venice.TrackPlayerEntityData or fb.VeniceShared.CommanderEntityData or fb.GameShared.PlayAnimationData => true,
            _ => false,
        };
    }

    private static CtrRefBase Self(DataContainerBase p_Instance) => new(p_Instance.Partition!.PartitionGuid, p_Instance.InstanceId);
}
