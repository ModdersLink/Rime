using fb;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using System;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Generates a new RegistryContainer by looping through all partitions in the bundle and collecting networked entities, assets, blueprints, and reference objects.")]
    public class GenerateRegistryContainerCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_Partitions = s_BundleContext.GetPartitions();

            if (s_Partitions.Count == 0)
            {
                p_Writer.WriteLine("No partitions found in the bundle.");
                return true;
            }

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbContext.EngineType);
            var s_Registry = new RegistryContainer { InstanceId = new DataContainerId.Guid(GUID.Empty) };

            foreach (var s_PartitionEntry in s_Partitions)
            {
                var s_Name = s_PartitionEntry.Key;
                var s_Object = s_PartitionEntry.Value;

                try
                {
                    var s_Partition = s_Converter.FromPartitionObject(s_Name, (IObjectVariant)s_Object);
                    foreach (var s_Instance in s_Partition.Instances)
                    {
                        if (s_Instance is not DataContainer s_DataContainer)
                            continue;

                        if (s_DataContainer is Blueprint s_Blueprint && s_Blueprint.NeedNetworkId)
                        {
                            // BlueprintRegistry
                            var s_BlueprintRef = new CtrRef<DataContainer>(s_Partition.PartitionGuid, ((DataContainerId.Guid)s_Blueprint.InstanceId).Id);
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
                            var s_CtrRef = new CtrRef<DataContainer>(s_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
                            if (!s_Registry.EntityRegistry.Any(x => x.InstanceId == s_CtrRef.InstanceId))
                                s_Registry.EntityRegistry.Add(s_CtrRef);
                        }

                        // AssetRegistry
                        if (s_DataContainer is UnlockAssetBase || s_DataContainer is CharacterCustomizationAsset)
                        {
                            var s_Ref = new CtrRef<DataContainer>(s_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
                            if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                                s_Registry.AssetRegistry.Add(s_Ref);
                        }

                        // AssetRegistry: a SubWorld's registry has to carry the MeshVariationDatabase so
                        // Level:RegisterEntityResources feeds it into the mesh-variation index at load. A
                        // prepended MVDB binds at runtime but never reaches that index.
                        if (s_DataContainer is MeshVariationDatabase)
                        {
                            var s_Ref = new CtrRef<DataContainer>(s_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
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
                            var s_UiRef = new CtrRef<DataContainer>(s_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
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
                                var s_Ref = new CtrRef<DataContainer>(s_Partition.PartitionGuid, ((DataContainerId.Guid)s_RefObject.InstanceId).Id);
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
                catch (Exception s_Exception)
                {
                    p_Writer.WriteLine($"Warning: Failed to parse partition '{s_Name}': {s_Exception.Message}");
                }
            }

            s_BundleContext.SetGeneratedRegistry(s_Registry);

            // NOTE: AssetRegistry and EntityRegistry seem to be perfect now.
            // The BlueprintRegistry and ReferenceObjectRegistry are not always matching the original ones, but they probably don't have to.
            // It is very close if you ignore all the WorldPartReferenceObjectDatas and WorldPartDatas.

            p_Writer.WriteLine($"RegistryContainer successfully generated and stored in context.");
            p_Writer.WriteLine($"- Entities: {s_Registry.EntityRegistry.Count}");
            p_Writer.WriteLine($"- Assets: {s_Registry.AssetRegistry.Count}");
            p_Writer.WriteLine($"- Blueprints: {s_Registry.BlueprintRegistry.Count}");
            p_Writer.WriteLine($"- ReferenceObjects: {s_Registry.ReferenceObjectRegistry.Count}");

            return true;
        }
    }
}
