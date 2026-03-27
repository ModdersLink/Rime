using fb;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;
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

                            // EntityRegistry
                            if (s_DataContainer is ObjectBlueprint s_ObjectBlueprint)
                            {
                                var s_EntityRef = new CtrRef<DataContainer>(s_ObjectBlueprint.Object.PartitionGuid, ((DataContainerId.Guid)s_ObjectBlueprint.Object.InstanceId).Id);
                                if (!s_Registry.EntityRegistry.Any(x => x.InstanceId == s_EntityRef.InstanceId))
                                    s_Registry.EntityRegistry.Add(s_EntityRef);
                            }
                        }

                        // EntityRegistry special
                        if (s_DataContainer is PickupEntityAsset s_PickupEntityAsset)
                        {
                            var s_PickupEntityRef = new CtrRef<DataContainer>(s_PickupEntityAsset.Data.PartitionGuid, ((DataContainerId.Guid)s_PickupEntityAsset.Data.InstanceId).Id);
                            if (!s_Registry.EntityRegistry.Any(x => x.InstanceId == s_PickupEntityRef.InstanceId))
                                s_Registry.EntityRegistry.Add(s_PickupEntityRef);
                        }

                        // EntityRegistry special
                        if (s_DataContainer is VehicleProjectileEntityData)
                        {
                            var s_Ref = new CtrRef<DataContainer>(s_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
                            if (!s_Registry.EntityRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                                s_Registry.EntityRegistry.Add(s_Ref);
                        }

                        // AssetRegistry
                        if (s_DataContainer is UnlockAssetBase || s_DataContainer is CharacterCustomizationAsset || s_DataContainer is ObjectVariation)
                        {
                            var s_Ref = new CtrRef<DataContainer>(s_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
                            if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                                s_Registry.AssetRegistry.Add(s_Ref);
                        }

                        // TODO: figure out how to exclude 1p meshes
                        //if (s_DataContainer is SkinnedMeshAsset s_SkinnedMeshAsset)
                        //{
                        //    if (s_BundleContext.GetResources().ContainsKey(s_SkinnedMeshAsset.Name.ToLowerInvariant()))
                        //    {
                        //        var s_Ref = new CtrRef<DataContainer>(s_Partition.PartitionGuid, ((DataContainerId.Guid)s_DataContainer.InstanceId).Id);
                        //        if (!s_Registry.AssetRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                        //            s_Registry.AssetRegistry.Add(s_Ref);
                        //    }
                        //}

                        // ReferenceObjectRegistry
                        if (s_DataContainer is ReferenceObjectData s_RefObject)
                        {
                            var s_BlueprintObj = s_RefObject.Blueprint.Get();
                            if (s_BlueprintObj != null && s_BlueprintObj.NeedNetworkId)
                            {
                                var s_Ref = new CtrRef<DataContainer>(s_Partition.PartitionGuid, ((DataContainerId.Guid)s_RefObject.InstanceId).Id);
                                if (!s_Registry.ReferenceObjectRegistry.Any(x => x.InstanceId == s_Ref.InstanceId))
                                    s_Registry.ReferenceObjectRegistry.Add(s_Ref);
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

            p_Writer.WriteLine($"RegistryContainer successfully generated and stored in context.");
            p_Writer.WriteLine($"- Entities: {s_Registry.EntityRegistry.Count}");
            p_Writer.WriteLine($"- Assets: {s_Registry.AssetRegistry.Count}");
            p_Writer.WriteLine($"- Blueprints: {s_Registry.BlueprintRegistry.Count}");
            p_Writer.WriteLine($"- ReferenceObjects: {s_Registry.ReferenceObjectRegistry.Count}");

            return true;
        }
    }
}
