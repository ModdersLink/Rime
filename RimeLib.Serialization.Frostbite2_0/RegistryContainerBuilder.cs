using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using fb;
using Newtonsoft.Json;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Frostbite2_0;

/// <summary>Frostbite 2 registry containers (fb::RegistryContainer) and the SubWorldData that carries one.</summary>
public class RegistryContainerBuilder : IRegistryContainerBuilder
{
    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    public DataContainerBase Create() => new RegistryContainer { InstanceId = new DataContainerId.Guid(GUID.Empty) };

    public void Add(DataContainerBase p_Registry, DatabasePartitionBase p_Partition)
    {
        var s_Registry = (RegistryContainer)p_Registry;

        foreach (var s_Instance in p_Partition.Instances)
        {
            if (s_Instance is not DataContainer s_DataContainer)
                continue;

            if (s_DataContainer is Blueprint s_Blueprint && s_Blueprint.NeedNetworkId)
            {
                // BlueprintRegistry
                var s_BlueprintRef = new CtrRef<DataContainer>(p_Partition.PartitionGuid, ((DataContainerId.Guid)s_Blueprint.InstanceId).Id);
                if (!s_Registry.BlueprintRegistry.Any(x => x.InstanceId == s_BlueprintRef.InstanceId))
                    s_Registry.BlueprintRegistry.Add(s_BlueprintRef);
            }

            // EntityRegistry
            if (s_DataContainer is BangerEntityData ||
                s_DataContainer is CapturePointEntityData ||
                s_DataContainer is CombatAreaTriggerEntityData ||
                s_DataContainer is ControllableEntityData ||
                (s_DataContainer is DebrisClusterData s_DebrisClusterData && s_DebrisClusterData.ClientSideOnly == false) ||
                s_DataContainer is GameInteractionEntityData ||
                s_DataContainer is MapMarkerEntityData ||
                s_DataContainer is PickupEntityData ||
                s_DataContainer is PreRoundEntityData ||
                (s_DataContainer is ProjectileEntityData && s_DataContainer is not BulletEntityData) ||
                s_DataContainer is RoundOverEntityData ||
                s_DataContainer is SyncedBoolEntityData ||
                s_DataContainer is SyncedSequenceEntityData ||
                s_DataContainer is TicketCounterEntityData ||
                s_DataContainer is VegetationBaseEntityData ||
                s_DataContainer is VehicleProjectileEntityData ||
                s_DataContainer is WeaponEntityData)
            {
                var s_CtrRef = new CtrRef<DataContainer>(p_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
                if (!s_Registry.EntityRegistry.Any(x => x.InstanceId == s_CtrRef.InstanceId))
                    s_Registry.EntityRegistry.Add(s_CtrRef);
            }

            // AssetRegistry
            if (s_DataContainer is UnlockAssetBase || s_DataContainer is CharacterCustomizationAsset)
            {
                var s_Ref = new CtrRef<DataContainer>(p_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
                if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                    s_Registry.AssetRegistry.Add(s_Ref);
            }

            // AssetRegistry: a SubWorld's registry has to carry the MeshVariationDatabase so
            // Level:RegisterEntityResources feeds it into the mesh-variation index at load. A
            // prepended MVDB binds at runtime but never reaches that index.
            if (s_DataContainer is MeshVariationDatabase)
            {
                var s_Ref = new CtrRef<DataContainer>(p_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
                if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                    s_Registry.AssetRegistry.Add(s_Ref);
            }

            // AssetRegistry: a vehicle's interior HUD, screens and FLIR come from the UI assets
            // and the HUD LogicPrefabBlueprint. On a map that has no such vehicle these load but
            // nothing activates them unless the registry carries them. Matching on TypeName
            // avoids naming every concrete UI class. LogicPrefabBlueprint has NeedNetworkId
            // false, so the BlueprintRegistry rule above skips it.
            var s_TypeName = s_DataContainer.TypeName;
            var s_IsUiAsset = s_TypeName.StartsWith("UI", StringComparison.Ordinal)
                && (s_TypeName.EndsWith("Asset", StringComparison.Ordinal) || s_TypeName.EndsWith("CompData", StringComparison.Ordinal));
            if (s_IsUiAsset || s_DataContainer is LogicPrefabBlueprint)
            {
                var s_UiRef = new CtrRef<DataContainer>(p_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
                if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_UiRef.InstanceId))
                    s_Registry.AssetRegistry.Add(s_UiRef);
            }

            // AssetRegistry
            if (s_DataContainer is UnlockAsset s_Unlock)
            {
                foreach (var s_AssetRef in s_Unlock.LinkedTo)
                {
                    var s_Asset = s_AssetRef.Get();
                    if (s_Asset == null)
                        continue;

                    if (s_Asset is ObjectVariation || s_Asset is SkinnedMeshAsset)
                    {
                        var s_Ref = new CtrRef<DataContainer>(s_AssetRef.PartitionGuid, ((DataContainerId.Guid)s_AssetRef.InstanceId).Id);
                        if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                            s_Registry.AssetRegistry.Add(s_Ref);
                    }

                    if (s_Asset is BlueprintAndVariationPair s_Pair)
                    {
                        if (s_Pair.Variation.Get() != null)
                        {
                            var s_Ref = new CtrRef<DataContainer>(s_Pair.Variation.PartitionGuid, ((DataContainerId.Guid)s_Pair.Variation.InstanceId).Id);
                            if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                                s_Registry.AssetRegistry.Add(s_Ref);
                        }
                        if (s_Pair.BaseAsset.Get() != null && s_Pair.BaseAsset.Get() is SkinnedMeshAsset)
                        {
                            var s_Ref = new CtrRef<DataContainer>(s_Pair.BaseAsset.PartitionGuid, ((DataContainerId.Guid)s_Pair.BaseAsset.InstanceId).Id);
                            if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                                s_Registry.AssetRegistry.Add(s_Ref);
                        }
                    }
                }
            }

            // AssetRegistry
            if (s_DataContainer is CustomizeSoldierData s_CustomizeSoldierData)
            {
                foreach (var s_Visual in s_CustomizeSoldierData.VisualGroups)
                {
                    foreach (var s_UnlockRef in s_Visual.Visual)
                    {
                        var s_VisualUnlock = s_UnlockRef.Get();

                        if (s_VisualUnlock == null)
                            continue;

                        foreach (var s_AssetRef in s_VisualUnlock.LinkedTo)
                        {
                            var s_Asset = s_AssetRef.Get();
                            if (s_Asset == null)
                                continue;

                            if (s_Asset is ObjectVariation || s_Asset is SkinnedMeshAsset)
                            {
                                var s_Ref = new CtrRef<DataContainer>(s_AssetRef.PartitionGuid, ((DataContainerId.Guid)s_AssetRef.InstanceId).Id);
                                if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                                    s_Registry.AssetRegistry.Add(s_Ref);
                            }

                            if (s_Asset is BlueprintAndVariationPair s_Pair)
                            {
                                if (s_Pair.Variation.Get() != null)
                                {
                                    var s_Ref = new CtrRef<DataContainer>(s_Pair.Variation.PartitionGuid, ((DataContainerId.Guid)s_Pair.Variation.InstanceId).Id);
                                    if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                                        s_Registry.AssetRegistry.Add(s_Ref);
                                }
                                if (s_Pair.BaseAsset.Get() != null && s_Pair.BaseAsset.Get() is SkinnedMeshAsset)
                                {
                                    var s_Ref = new CtrRef<DataContainer>(s_Pair.BaseAsset.PartitionGuid, ((DataContainerId.Guid)s_Pair.BaseAsset.InstanceId).Id);
                                    if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                                        s_Registry.AssetRegistry.Add(s_Ref);
                                }
                            }
                        }
                    }
                }
            }

            if (s_DataContainer is ReferenceObjectData s_RefObject)
            {
                var s_BlueprintObj = s_RefObject.Blueprint.Get();
                if ((s_BlueprintObj == null && s_RefObject.TypeName != "ReferenceObjectData") || (s_BlueprintObj != null && s_BlueprintObj.NeedNetworkId && s_BlueprintObj is not LevelData))
                {
                    // ReferenceObjectRegistry
                    var s_Ref = new CtrRef<DataContainer>(p_Partition.PartitionGuid, ((DataContainerId.Guid)s_RefObject.InstanceId).Id);
                    if (!s_Registry.ReferenceObjectRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                        s_Registry.ReferenceObjectRegistry.Add(s_Ref);
                }

                if (s_RefObject.ObjectVariation.Get() != null)
                {
                    // AssetRegistry
                    var s_Ref = new CtrRef<DataContainer>(s_RefObject.ObjectVariation.PartitionGuid, ((DataContainerId.Guid)s_RefObject.ObjectVariation.InstanceId).Id);
                    if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                        s_Registry.AssetRegistry.Add(s_Ref);
                }
            }

            // AssetRegistry
            if (s_DataContainer is ObjectVariationSwitchEntityData s_ObjectVariationSwitchEntityData)
            {
                if (s_ObjectVariationSwitchEntityData.Variation1.Get() != null)
                {
                    var s_Ref = new CtrRef<DataContainer>(s_ObjectVariationSwitchEntityData.Variation1.PartitionGuid, ((DataContainerId.Guid)s_ObjectVariationSwitchEntityData.Variation1.InstanceId).Id);
                    if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                        s_Registry.AssetRegistry.Add(s_Ref);
                }
                if (s_ObjectVariationSwitchEntityData.Variation2.Get() != null)
                {
                    var s_Ref = new CtrRef<DataContainer>(s_ObjectVariationSwitchEntityData.Variation2.PartitionGuid, ((DataContainerId.Guid)s_ObjectVariationSwitchEntityData.Variation2.InstanceId).Id);
                    if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                        s_Registry.AssetRegistry.Add(s_Ref);
                }
            }
        }
    }

    public RegistryContainerModel? Read(DataContainerBase p_Instance)
    {
        if (p_Instance is not RegistryContainer s_Registry)
            return null;

        var s_Model = new RegistryContainerModel();
        s_Model.Entities.AddRange(s_Registry.EntityRegistry);
        s_Model.Assets.AddRange(s_Registry.AssetRegistry);
        s_Model.Blueprints.AddRange(s_Registry.BlueprintRegistry);
        s_Model.ReferenceObjects.AddRange(s_Registry.ReferenceObjectRegistry);
        return s_Model;
    }

    public DatabasePartitionBase CreateSubWorld(string p_PartitionName, string p_SubWorldName, RegistryContainerModel p_Registry)
    {
        // The loader resolves the SubWorld by name, so these guids are internal only, but they still
        // have to be unique across the level's loaded partitions or two sidecars collide.
        var s_PartGuid = new GUID(Guid.NewGuid());
        var s_SubWorldGuid = new GUID(Guid.NewGuid());
        var s_DescriptorGuid = new GUID(Guid.NewGuid());
        var s_RegistryGuid = new GUID(Guid.NewGuid());

        var s_Entities = Refs(p_Registry.Entities);
        var s_Assets = Refs(p_Registry.Assets);
        var s_Blueprints = Refs(p_Registry.Blueprints);
        var s_RefObjects = Refs(p_Registry.ReferenceObjects);

        var s_SubWorld = new Dictionary<string, object?>
        {
            ["$type"] = "SubWorldData",
            ["Name"] = p_SubWorldName,
            ["PropertyConnections"] = Array.Empty<object>(),
            ["LinkConnections"] = Array.Empty<object>(),
            ["EventConnections"] = Array.Empty<object>(),
            ["Descriptor"] = MakeRef(s_PartGuid, s_DescriptorGuid),
            ["NeedNetworkId"] = false,
            ["InterfaceHasConnections"] = false,
            ["AlwaysCreateEntityBusClient"] = false,
            ["AlwaysCreateEntityBusServer"] = false,
            ["Objects"] = Array.Empty<object>(),
            ["RegistryContainer"] = MakeRef(s_PartGuid, s_RegistryGuid),
            ["IsWin32SubLevel"] = true,
            ["IsXenonSubLevel"] = true,
            ["IsPs3SubLevel"] = true,
            ["RememberStateOnStreamOut"] = false,
        };

        var s_Descriptor = new Dictionary<string, object?>
        {
            ["$type"] = "InterfaceDescriptorData",
            ["Fields"] = Array.Empty<object>(),
            ["InputEvents"] = Array.Empty<object>(),
            ["OutputEvents"] = Array.Empty<object>(),
            ["InputLinks"] = Array.Empty<object>(),
            ["OutputLinks"] = Array.Empty<object>(),
        };

        var s_RegistryContainer = new Dictionary<string, object?>
        {
            ["$type"] = "RegistryContainer",
            ["EntityRegistry"] = s_Entities,
            ["AssetRegistry"] = s_Assets,
            ["BlueprintRegistry"] = s_Blueprints,
            ["ReferenceObjectRegistry"] = s_RefObjects,
        };

        var s_Json = JsonConvert.SerializeObject(new
        {
            PartitionGuid = s_PartGuid.ToString(),
            PrimaryInstanceGuid = s_SubWorldGuid.ToString(),
            Name = p_PartitionName,
            Instances = new Dictionary<string, object?>
            {
                [s_SubWorldGuid.ToString()] = s_SubWorld,
                [s_DescriptorGuid.ToString()] = s_Descriptor,
                [s_RegistryGuid.ToString()] = s_RegistryContainer,
            },
        }, Formatting.Indented);

        using var s_JsonReader = new StringReader(s_Json);
        return new PartitionConverter().FromJsonStream(s_JsonReader);
    }

    private static object MakeRef(GUID p_Partition, GUID p_Instance) => new
    {
        PartitionGuid = p_Partition.ToString(),
        InstanceGuid = p_Instance.ToString(),
    };

    private static List<object> Refs(IEnumerable<CtrRefBase> p_Refs) =>
        p_Refs.Where(p_R => p_R.InstanceId is DataContainerId.Guid)
            .Select(p_R => MakeRef(p_R.PartitionGuid, ((DataContainerId.Guid)p_R.InstanceId).Id)).ToList();
}
