using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using fb;
using Newtonsoft.Json;
using RimeLib.Cmd.Commands.Game;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Havok.Frostbite2_0;
using RimeLib.IO;
using RimeLib.Mesh;
using RimeLib.Serialization;
using RimeLib.Texture;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Scenes;
using SharpGLTF.Schema2;
using SharpGLTF.Transforms;
using Vector4 = System.Numerics.Vector4;

namespace RimeLib.Cmd.Contexts
{
    /// <summary>
    /// 
    /// </summary>
    public class GameContext : ExecutionContext
    {
        // Game context id, if there are multiple game context this determines which one is assigned to which game
        protected int m_Id;

        // Frostbite engine mounter interface (this can be different implementations based on Frostbite revision)
        protected IEngineMounter m_Mounter;

        /// <summary>
        /// GameContext constructor
        /// </summary>
        /// <param name="p_Parent">Parent execution context</param>
        /// <param name="p_Id">Id of this mounted game context</param>
        /// <param name="p_Mounter">Frostbite engine mounter interface for this version of fb</param>
        public GameContext(BaseContext p_Parent, int p_Id, IEngineMounter p_Mounter)
        {
            Parent = p_Parent;
            m_Id = p_Id;
            m_Mounter = p_Mounter;

            RegisterCommand<ListSbCommand>();
            RegisterCommand<MountSbCommand>();
            RegisterCommand<MountStandaloneSbCommand>();
            RegisterCommand<ListMountedSbCommand>();
            RegisterCommand<ListBundlesCommand>();
            RegisterCommand<MountBundleCommand>();
            RegisterCommand<MountAllBundlesCommand>();
            RegisterCommand<ListMountedBundlesCommand>();
            RegisterCommand<ListChunksCommand>();
            RegisterCommand<ListDuplicateChunksCommand>();
            RegisterCommand<ListResourcesCommand>();
            RegisterCommand<ListResourcesOfTypeCommand>();
            RegisterCommand<ListPartitionsCommand>();
            RegisterCommand<ListSbChunksCommand>();
            RegisterCommand<ListBundleChunksCommand>();
            RegisterCommand<ListBundleResourcesCommand>();
            RegisterCommand<ListBundlePartitionsCommand>();
            RegisterCommand<DumpChunkCommand>();
            RegisterCommand<DumpResourceCommand>();
            RegisterCommand<DumpPartitionCommand>();
            RegisterCommand<DumpPartitionJsonCommand>();
            RegisterCommand<DumpTextureCommand>();
            RegisterCommand<DumpMeshCommand>();
            RegisterCommand<DumpLevelMeshesCommand>();
        }

        public override string GetShortDescription()
        {
            return $"{m_Id} - {m_Mounter.GetGamePath()} - {m_Mounter.GetEngineType()}";
        }

        public override string GetLongDescription()
        {
            var s_Text = "Mounted Game Context\n\n";
            s_Text += $"Game ID: {m_Id}\n";
            s_Text += $"Game Path: {m_Mounter.GetGamePath()}\n";
            s_Text += $"Game Engine: {m_Mounter.GetEngineType()}";
            return s_Text;
        }

        /// <summary>
        /// Mount a superbundle by name
        /// </summary>
        /// <param name="p_Name">Name of superbundle to mount</param>
        /// <param name="p_AutoMount">Automatically mount contained bundles</param>
        internal void MountSuperbundle(string p_Name, bool p_AutoMount)
        {
            m_Mounter.MountSuperbundle(p_Name, p_AutoMount).Wait();
        }

        /// <summary>
        /// Mount a superbundle by path
        /// </summary>
        /// <param name="p_Name">Name of superbundle to mount</param>
        /// <param name="p_Path">Path to superbundle</param>
        /// <param name="p_AutoMount">Automatically mount contained bundles</param>
        internal void MountStandaloneSuperbundle(string p_Name, string p_Path, bool p_AutoMount)
        {
            m_Mounter.MountStandaloneSuperbundle(p_Name, p_Path, p_AutoMount).Wait();
        }

        /// <summary>
        /// Mount a bundle by name
        /// </summary>
        /// <param name="p_Name">Name of bundle to mount</param>
        internal void MountBundle(string p_Name)
        {
            m_Mounter.MountBundle(p_Name).Wait();
        }

        /// <summary>
        /// Gets an enumerable of all available superbundles
        /// </summary>
        /// <returns>Enumerable of superbundle names</returns>
        internal IEnumerable<string> GetAvailableSuperbundles()
        {
            return m_Mounter.GetAvailableSuperbundles();
        }

        /// <summary>
        /// Gets an enumerable of all available bundles
        /// </summary>
        /// <returns>Enumerable of bundle names</returns>
        internal IEnumerable<string> GetAvailableBundles()
        {
            return m_Mounter.GetAvailableBundles();
        }

        /// <summary>
        /// Gets an enumerable of all MOUNTED superbundles
        /// </summary>
        /// <returns>Enumerable of mounted superbundles</returns>
        internal IEnumerable<string> GetMountedSuperbundles()
        {
            return m_Mounter.GetMountedSuperbundles();
        }

        /// <summary>
        /// Gets an enumerable of all MOUNTED bundles
        /// </summary>
        /// <returns>Enumerable of mounted bundles</returns>
        internal IEnumerable<string> GetMountedBundles()
        {
            return m_Mounter.GetMountedBundles();
        }

        /// <summary>
        /// Dumps a specific chunk based on GUID
        /// </summary>
        /// <param name="p_Guid">Input GUID of the chunk to dump</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <exception cref="Exception">If the chunk is not found, exception will be thrown</exception>
        internal void DumpChunk(GUID p_Guid, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetChunk(p_Guid, out var s_Chunk))
                throw new Exception($"Could not find chunk with id '{p_Guid.ToString("D")}'.");

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

            // TODO: this is causing issues when cloning (noncas) bundles.
            // Here we look for the first chunk variant with logical offset 0.
            // That's because variants with non-0 offsets can be partial mips, etc.
            using var s_Reader = s_Chunk.Variants.First(p_Variant => true).GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        /// <summary>
        /// Dumps a specific resource tag
        /// </summary>
        /// <param name="p_Name">Name of the resource</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <exception cref="Exception">If the resource is not found, exception will be thrown</exception>
        internal void DumpResource(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

            using var s_Reader = s_Resource.FirstVariant.GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        /// <summary>
        /// Dumps a partition
        /// </summary>
        /// <param name="p_Name">Name of the partition to dump</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <exception cref="Exception">If the partition does not exist, exception will be thrown</exception>
        internal void DumpPartition(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetPartition(p_Name, out var s_Partition))
                throw new Exception($"Could not find partition with name '{p_Name}'.");

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

            using var s_Reader = s_Partition.FirstVariant.GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        /// <summary>
        /// Dumps a partition as json
        /// </summary>
        /// <param name="p_Name">Name of partition to dump</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <param name="p_Formatting">Formatting type, indented or not</param>
        /// <exception cref="Exception">If the partition does not exist, exception will be thrown</exception>
        internal void DumpPartitionJson(string p_Name, FileInfo p_Destination, Formatting p_Formatting)
        {
            if (!m_Mounter.TryGetPartition(p_Name, out var s_PartitionObject))
                throw new Exception($"Could not find partition with name '{p_Name}'.");

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(m_Mounter.GetEngineType());

            var s_Partition = s_Converter.FromPartitionObject(p_Name, s_PartitionObject.FirstVariant);
            s_Partition.ToJsonFile(p_Destination.FullName, p_Formatting);
        }

        /// <summary>
        /// Dumps a texture as Direct Draw Surface (.dds) format
        /// </summary>
        /// <param name="p_Name">Name of texture to dump</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <exception cref="Exception">If the texture resource name is not found, exception will be thrown</exception>
        internal void DumpTexture(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(m_Mounter.GetEngineType());

            var s_FileStream = File.Create(p_Destination.FullName);
            using var s_Writer = new RimeWriter(s_FileStream);

            s_Converter.ConvertToDDS(s_Resource.FirstVariant!, m_Mounter, s_Writer);
        }

        /// <summary>
        /// Get the chunks of a specified superbundle
        /// </summary>
        /// <param name="p_Superbundle">Superbundle name</param>
        /// <returns>Enumerable of GUIDs for each of the superbundle chunks</returns>
        internal IEnumerable<GUID> GetSuperbundleChunks(string p_Superbundle)
        {
            return m_Mounter.GetChunksInSuperbundle(p_Superbundle);
        }

        /// <summary>
        /// Get the chunks of a specified bundle
        /// </summary>
        /// <param name="p_Bundle">Bundle name</param>
        /// <returns>Enumerable of GUIDs for each of the bundle chunks</returns>
        internal IEnumerable<GUID> GetBundleChunks(string p_Bundle)
        {
            return m_Mounter.GetChunksInBundle(p_Bundle);
        }

        /// <summary>
        /// Get the chunks (with asset name hash) of a specified bundle. (Only non cas bundles.)
        /// </summary>
        /// <param name="p_Bundle">Bundle name</param>
        /// <returns>Enumerable of GUIDs for each of the bundle chunks</returns>
        internal IEnumerable<(GUID Guid, int AssetNameHash)> GetBundleChunksWithHash(string p_Bundle)
        {
            return m_Mounter.GetChunksWithHashInBundle(p_Bundle);
        }

        /// <summary>
        /// Gets the resources of a specified bundle
        /// </summary>
        /// <param name="p_Bundle">Bundle name</param>
        /// <returns>Enumerable of resource names for each of the bundle resources</returns>
        internal IEnumerable<(string Name, ResourceType ResourceType)> GetBundleResources(string p_Bundle)
        {
            return m_Mounter.GetResourcesInBundle(p_Bundle);
        }

        /// <summary>
        /// Gets the available bundle partitions
        /// </summary>
        /// <param name="p_Bundle">Enumerable of bundle partition names</param>
        /// <returns></returns>
        internal IEnumerable<string> GetBundlePartitions(string p_Bundle)
        {
            return m_Mounter.GetPartitionsInBundle(p_Bundle);
        }

        /// <summary>
        /// Gets the mounted chunks
        /// </summary>
        /// <returns>Enumerable of chunk GUIDs</returns>
        internal IEnumerable<GUID> GetMountedChunks()
        {
            return m_Mounter.GetChunks().Keys;
        }

        /// <summary>
        /// Get the mounted resources
        /// </summary>
        /// <returns>Enumerable of resource names</returns>
        internal IEnumerable<string> GetMountedResources()
        {
            return m_Mounter.GetResources().Keys;
        }

        /// <summary>
        /// Get the mounted partitions
        /// </summary>
        /// <returns>Enumerable of mounted partition names</returns>
        internal IEnumerable<string> GetMountedPartitions()
        {
            return m_Mounter.GetPartitions().Keys;
        }

        /// <summary>
        /// Gets a dictionary of GUID <-> Mounted chunk variations
        /// </summary>
        /// <returns>Dictionary<GUID, IMountedObject<IChunkVariant></returns>
        internal IReadOnlyDictionary<GUID, IMountedObject<IChunkVariant>> GetMountedChunkVariations()
        {
            return m_Mounter.GetChunks();
        }

        /// <summary>
        /// Gets a dictionary of resource name <-> Mounted resource variations
        /// </summary>
        /// <returns>Dictionary<string, IMountedObject<IResourceVariant>></returns>
        internal IReadOnlyDictionary<string, IMountedObject<IResourceVariant>> GetMountedResourceVariations()
        {
            return m_Mounter.GetResources();
        }

        /// <summary>
        /// Dumps a specified mesh in a specific format
        /// </summary>
        /// <param name="p_Type">Output mesh type (gltf, obj, etc.)</param>
        /// <param name="p_Name">Name of the MeshSet resource</param>
        /// <param name="p_Destination">Output file destination</param>
        /// <exception cref="NotImplementedException">If the format isn't supported</exception>
        internal void DumpMesh(MeshConverterType p_Type, string p_Name, FileInfo p_Destination)
        {
            // Get all resources
            var s_Resources = m_Mounter.GetResources();

            // Filter out by name
            var s_MeshResources = s_Resources.Where(p_Resource => p_Resource.Key == p_Name);

            // Iterate over all results
            foreach (var s_MeshResource in s_MeshResources)
            {
                // Get the name of the mesh
                var s_Name = s_MeshResource.Key;

                // Get the resource
                var s_Resource = s_MeshResource.Value;

                // Get the variant
                var s_Variant = s_Resource.FirstVariant;

                // Sanity check
                if (s_Variant.GetResourceType() != ResourceType.MeshSet)
                    continue;

                // Create a new mesh converter
                var s_Converter = EngineInterfaceRegistry.Create<IMeshConverter>(m_Mounter.GetEngineType());

                switch (p_Type)
                {
                    case MeshConverterType.Gltf:
                        s_Converter.ConvertToGltf(s_Variant, m_Mounter, p_Destination.FullName);
                        break;
                    case MeshConverterType.Obj:
                    case MeshConverterType.BlenderScript:
                    default:
                        throw new NotImplementedException($"Unknown mesh converter type '{p_Type}'.");
                }
            }
        }

        private Dictionary<string, List<LinearTransform>> m_MeshLocations = new();
        private List<KeyValuePair<LightBuilder, LinearTransform>> m_Lights = [];

        private void HandleVehicleBlueprint(VehicleBlueprint p_Blueprint, LinearTransform p_Transform,
            TextWriter p_Writer)
        {
            p_Writer.WriteLine($"{p_Blueprint.Name} located at ({p_Transform.trans})");
        }

        private void HandleSoldierBlueprint(SoldierBlueprint p_Blueprint, LinearTransform p_Transform,
            TextWriter p_Writer)
        {
            p_Writer.WriteLine($"{p_Blueprint.Name} located at ({p_Transform.trans})");
        }

        private void HandleSpatialPrefabBlueprint(SpatialPrefabBlueprint p_Blueprint, LinearTransform p_TransformBase,
            TextWriter p_Writer)
        {
            p_Writer.WriteLine($"{p_Blueprint.Name} located at ({p_TransformBase.trans})");

            HandlePrefabBlueprint(p_Blueprint, p_TransformBase, p_Writer);
        }

        private void HandlePrefabBlueprint(PrefabBlueprint p_Blueprint, LinearTransform p_TransformBase,
            TextWriter p_Writer)
        {
            p_Writer.WriteLine($"PrefabBlueprint {p_Blueprint.Name} located at ({p_TransformBase.trans})");

            foreach (var s_ObjectRef in p_Blueprint.Objects)
            {
                var s_Object = s_ObjectRef.Get();
                if (s_Object is null)
                    continue;

                switch (s_Object)
                {
                    case ReferenceObjectData s_ReferenceObjectData:
                        var s_ObjectTransform = s_ReferenceObjectData.BlueprintTransform;
                        // I have no idea if this is how this is calculated, yolo?
                        var s_NewTransform = new LinearTransform
                        {
                            forward = new Vec3
                            {
                                x = s_ObjectTransform.forward.x + p_TransformBase.forward.x,
                                y = s_ObjectTransform.forward.y + p_TransformBase.forward.y,
                                z = s_ObjectTransform.forward.z + p_TransformBase.forward.z,
                            },
                            right = new Vec3
                            {
                                x = s_ObjectTransform.right.x + p_TransformBase.right.x,
                                y = s_ObjectTransform.right.y + p_TransformBase.right.y,
                                z = s_ObjectTransform.right.z + p_TransformBase.right.z,
                            },
                            up = new Vec3
                            {
                                x = s_ObjectTransform.up.x + p_TransformBase.up.x,
                                y = s_ObjectTransform.up.y + p_TransformBase.up.y,
                                z = s_ObjectTransform.up.z + p_TransformBase.up.z,
                            },
                            trans = new Vec3
                            {
                                x = s_ObjectTransform.trans.x + p_TransformBase.trans.x,
                                y = s_ObjectTransform.trans.y + p_TransformBase.trans.y,
                                z = s_ObjectTransform.trans.z + p_TransformBase.trans.z
                            }
                        };

                        switch (s_ReferenceObjectData.Blueprint.Get())
                        {
                            case SpatialPrefabBlueprint s_SpatialPrefabBlueprint:
                                HandleSpatialPrefabBlueprint(s_SpatialPrefabBlueprint, s_NewTransform, p_Writer);
                                break;
                            case ObjectBlueprint s_ObjectBlueprint:
                                HandleObjectBlueprint(s_ObjectBlueprint, s_NewTransform, p_Writer);
                                break;
                            default:
                                p_Writer.WriteLine($"UNHANDLED OBJECT: {s_Object.TypeName}");
                                break;
                        }

                        break;
                    case PointLightEntityData s_PointLightEntityData:
                        break;
                    case SpotLightEntityData s_SpotLightEntityData:
                        break;
                    case RandomEventEntityData:
                    case ObjectVariationSwitchEntityData:
                    case AreaProximityEntityData:
                    case SyncedBoolEntityData:
                    case DelayEntityData:
                    case CameraEntityData:
                    case MixerEntityData:
                    case IrReverbEntityData:
                    case SoundAreaEntityData:
                    case MathOpEntityData:
                    case FloatEntityData:
                    case VolumeVectorShapeData:
                    case BoolEntityData:
                    case OBBData:
                    case SequenceEntityData:
                    case GeometryTriggerEntityData:
                    case LocatorEntityData:
                    case SoundEntityData:
                    case RandomDelayEntityData:
                    case ModelAnimationEntityData:
                        break;
                    default:
                        p_Writer.WriteLine($"UNKNOWN HANDLED OBJECT {s_Object.TypeName}.");
                        break;
                }
            }
        }

        private void HandleObjectBlueprint(ObjectBlueprint p_Blueprint, LinearTransform p_Transform,
            TextWriter p_Writer)
        {
            var s_Object = p_Blueprint.Object.Get();
            if (s_Object is null)
            {
                p_Writer.WriteLine($"No object found for {p_Blueprint.Name}.");
                return;
            }

            var s_MeshName = p_Blueprint.Name;

            switch (s_Object)
            {
                case StaticModelEntityData s_StaticModelEntityData:
                    s_MeshName = s_StaticModelEntityData.Mesh.Get()?.Name ?? s_MeshName;
                    break;
                case DynamicModelEntityData s_DynamicModelEntityData:
                    s_MeshName = s_DynamicModelEntityData.Mesh.Get()?.Name ?? s_MeshName;
                    break;
                case MeshProxyEntityData s_MeshProxyEntityData:
                    s_MeshName = s_MeshProxyEntityData.Mesh.Get()?.Name ?? s_MeshName;
                    break;
                case VegetationTreeEntityData s_VegetationTreeEntityData:
                    s_MeshName = s_VegetationTreeEntityData.Mesh.Get()?.Name ?? s_MeshName;
                    break;
                case BreakableModelEntityData s_BreakableModelEntityData:
                    s_MeshName = s_BreakableModelEntityData.Mesh.Get()?.Name ?? s_MeshName;
                    break;
                case EffectEntityData:
                    // Ignored
                    break;
                default:
                    p_Writer.WriteLine($"ObjectBlueprintPoint: {s_Object.TypeName}");
                    break;
            }


            p_Writer.WriteLine(
                $"ObjectBlueprint {p_Blueprint.Name} located at ({p_Transform.trans}) OBJECT: {s_Object.TypeName}.");

            if (m_MeshLocations.TryGetValue(s_MeshName, out var s_MeshLocations))
            {
                s_MeshLocations.Add(p_Transform);
            }
            else
            {
                m_MeshLocations.Add(s_MeshName, new List<LinearTransform>
                {
                    p_Transform
                });
            }
        }

        private void HandleReferenceObjectData(ReferenceObjectData p_ReferenceObjectData, TextWriter p_Writer,
            bool p_IncludeExcluded = false)
        {
            // Exclusion check
            if (p_ReferenceObjectData.Excluded && !p_IncludeExcluded)
            {
                p_Writer.WriteLine($"Skipping reference object data ({p_ReferenceObjectData.InstanceId}).");
                return;
            }

            // Check to see if we have any blueprint
            if (p_ReferenceObjectData.Blueprint.Get() is null)
            {
                p_Writer.WriteLine($"Skipping blueprint data ({p_ReferenceObjectData.InstanceId}).");
                return;
            }

            var s_BlueprintTransform = p_ReferenceObjectData.BlueprintTransform;

            // If we have a blueprint break out based on supported types
            switch (p_ReferenceObjectData.Blueprint.Get())
            {
                case VehicleBlueprint s_VehicleBlueprint:
                    HandleVehicleBlueprint(s_VehicleBlueprint, s_BlueprintTransform, p_Writer);
                    break;
                case SoldierBlueprint s_SoldierBlueprint:
                    HandleSoldierBlueprint(s_SoldierBlueprint, s_BlueprintTransform, p_Writer);
                    break;
                case SpatialPrefabBlueprint s_SpatialPrefabBlueprint:
                    // s_SpatialPrefabBlueprint.blueprintTransform.trans + objects.trans
                    HandleSpatialPrefabBlueprint(s_SpatialPrefabBlueprint, s_BlueprintTransform, p_Writer);
                    break;
                case PrefabBlueprint s_PrefabBlueprint:
                    HandlePrefabBlueprint(s_PrefabBlueprint, s_BlueprintTransform, p_Writer);
                    break;
                case ObjectBlueprint s_ObjectBlueprint:
                    HandleObjectBlueprint(s_ObjectBlueprint, s_BlueprintTransform, p_Writer);
                    break;
                default:
                    p_Writer.WriteLine($"UNKNOWN BLUEPRINT TYPE: {p_ReferenceObjectData.Blueprint.Instance?.TypeName}");
                    break;
            }
        }

        private void HandleRoadData(RoadData p_RoadData, TextWriter p_Writer)
        {
            p_Writer.WriteLine($"Parsing RoadData ({p_RoadData.InstanceId}), PointCount: ({p_RoadData.Points.Count}).");

            // TODO: Handle RoadData points in a GLTF spline
        }

        private void HandlePointLightEntity(PointLightEntityData p_PointLightEntityData, TextWriter p_Writer)
        {
            p_Writer.WriteLine(
                $"PointLight: {p_PointLightEntityData.TypeName} located at {p_PointLightEntityData.Transform.trans}");

            var s_PointLight = new LightBuilder.Point
            {
                Color = new Vector3(p_PointLightEntityData.Color.x, p_PointLightEntityData.Color.y,
                    p_PointLightEntityData.Color.z),
                Intensity = p_PointLightEntityData.Intensity,
                Name = $"Instance_{p_PointLightEntityData.InstanceId}",
                Range = p_PointLightEntityData.Radius // Not sure if this matches 1:1
            };

            m_Lights.Add(
                new KeyValuePair<LightBuilder, LinearTransform>(s_PointLight, p_PointLightEntityData.Transform));
        }

        private void HandleSpotLightEntity(SpotLightEntityData p_SpotLightEntityData, TextWriter p_Writer)
        {
            p_Writer.WriteLine(
                $"SpotLight: {p_SpotLightEntityData.TypeName} located at {p_SpotLightEntityData.Transform.trans}");

            var s_SpotLight = new LightBuilder.Spot
            {
                Color = new Vector3(p_SpotLightEntityData.Color.x, p_SpotLightEntityData.Color.y,
                    p_SpotLightEntityData.Color.z),
                Intensity = p_SpotLightEntityData.Intensity,
                Name = $"Instance_{p_SpotLightEntityData.InstanceId}",
                Range = p_SpotLightEntityData.Radius // Not sure if this matches 1:1
            };

            m_Lights.Add(new KeyValuePair<LightBuilder, LinearTransform>(s_SpotLight, p_SpotLightEntityData.Transform));
        }

        /// <summary>
        /// Helper function for parsing through WorldPartReferenceObjectData
        /// </summary>
        /// <param name="p_Data">WorldPartReferenceObjectData (from LevelData.Objects)</param>
        /// <param name="p_Writer">Output text writer</param>
        /// <param name="p_IncludeExcluded">Do we want to include WorldPartReferenceObjectData.excluded anyway?</param>
        /// <exception cref="InvalidDataException"></exception>
        private void HandleWorldPart(WorldPartReferenceObjectData p_Data, TextWriter p_Writer,
            bool p_IncludeExcluded = false)
        {
            // Skip handling this WorldPartData if it's excluded
            if (p_Data.Excluded && !p_IncludeExcluded)
            {
                p_Writer.WriteLine($"Skipping excluded WorldPartReferenceObjectData ({p_Data.InstanceId}).");
                return;
            }

            // Cast and check for WorldPartData
            if (p_Data.Blueprint.Get() is not WorldPartData s_WorldPartData)
            {
                // If we did not get a WorldPartData skip it
                p_Writer.WriteLine($"WorldPartReferenceObjectData.blueprint is not WorldPartData");
#if DEBUG
                throw new InvalidDataException("WorldPartReferenceObjectData.blueprint is not WorldPartData");
#endif
                return;
            }

            // Debug logging
            p_Writer.WriteLine($"Parsing ({s_WorldPartData.Name})...");

            // Iterate each object in this list
            foreach (var s_ObjectRef in s_WorldPartData.Objects)
            {
                var s_Object = s_ObjectRef.Get();
                if (s_Object is null)
                    continue;

                switch (s_Object)
                {
                    // TODO
                    // ReferenceObjectData
                    // RoadData
                    case ReferenceObjectData s_ReferenceObjectData:
                        HandleReferenceObjectData(s_ReferenceObjectData, p_Writer);
                        break;
                    case RoadData s_RoadData:
                        HandleRoadData(s_RoadData, p_Writer);
                        break;
                    case PointLightEntityData s_PointLightEntityData:
                        HandlePointLightEntity(s_PointLightEntityData, p_Writer);
                        break;
                    case SpotLightEntityData s_SpotLightEntityData:
                        HandleSpotLightEntity(s_SpotLightEntityData, p_Writer);
                        break;
                    case GeometryTriggerEntityData:
                    case SequenceEntityData:
                    case PlayerFilterEntityData:
                    case DecalEntityData:
                    case OccluderVolumeEntityData:
                    case SoldierTestEntityData:
                    case TestPointEntityData:
                    case PredestructionEntityData:
                    case TerrainQuadDecalData:
                        break;
                    default:
                        p_Writer.WriteLine($"UNHANDLED WorldPartData.Object ({s_Object.TypeName}).");
                        break;


                    // Useless
                    // AreaProximityEntityData
                    // SequenceEntityData
                    // EffectReferenceObjectData
                    // VolumeVectorShapeData
                    // OOBData
                    // LocatorEntityData
                    // MixerEntityData
                    // MathOpEntityData
                    // SoundAreaEntityData
                    // IrReverbEntityData
                    // FloatEntityData
                    // LightProbeVolumeData
                    // DelayEntityData
                    // DecalEntityData (maybe want to include this in the future)
                    // TestPointEntityData
                    // SoldierTestEntityData
                    // OccluderVolumeEntityData
                    // GeometryTriggerEntityData
                    // PlayerFilterEntityData
                }
            }
        }

        private void HandleSubWorld(SubWorldReferenceObjectData p_Data, TextWriter p_Writer)
        {
            // Debug logging
            p_Writer.WriteLine($"Parsing SubWorld ({p_Data.BundleName}).");

            // I have not come across where this was actually used (yet)
            if (p_Data.Blueprint is null)
            {
                // p_Writer.WriteLine($"{p_Data.BundleName} blueprint is null.");
                return;
            }


        }

        private void HandleStaticModelGroupEntity(StaticModelGroupEntityData p_Data, TextWriter p_Writer)
        {
            // Get the physics data
            var s_PhysicsData = p_Data.PhysicsData.Get();
            if (s_PhysicsData is null)
            {
                p_Writer.WriteLine($"ERR: COULD NOT GET PHYSICS DATA FOR ({p_Data.InstanceId}).");
                return;
            }
            
            // Get the physics asset
            var s_PhysicsAsset = s_PhysicsData.Asset.Get();
            if (s_PhysicsAsset is null)
            {
                p_Writer.WriteLine($"ERR: COULD NOT GET PHYSICS ASSET FOR ({s_PhysicsData.InstanceId}).");
                return;
            }
            
            // Logging purposes to feed into log processing later
            p_Writer.WriteLine($"PhysicsAsset Type: {s_PhysicsAsset.TypeName}");

            var s_ResourceName = s_PhysicsAsset.Name;
            if (!m_Mounter.TryGetResource(s_ResourceName, out var s_Resource))
            {
                p_Writer.WriteLine($"Could not find asset ({s_ResourceName}).");
                return;
            }

            using var s_ResourceReader = s_Resource.FirstVariant.GetReader();
            var s_Data = s_ResourceReader.ReadBytes((int)s_ResourceReader.Length);

            var s_HavokPhysicsData = new HavokPhysicsData(new RimeReader(new MemoryStream(s_Data)));
            
            //File.WriteAllBytes("physics.bin", s_ResourceReader.ReadBytes((int)s_ResourceReader.Length));

            throw new NotImplementedException();
            
            foreach (var s_MemberData in p_Data.MemberDatas)
            {
                var s_MeshEntityType = s_MemberData.MeshEntityType.Get();
                var s_MemberType = s_MemberData.MemberType.Get();

                switch (s_MemberType)
                {
                    case StaticModelEntityData s_MeshAsset:
                        break;
                }

                switch (s_MeshEntityType)
                {
                    case CompositeMeshEntityData s_CompositeMeshEntityData:
                        break;
                    case RigidMeshEntityData s_RigidMeshEntityData:
                        break;
                }
            }
        }

        internal void ExportLevelMesh(string p_LevelPartitionName, FileInfo p_Destination, TextWriter p_Writer)
        {
            // If we do not have any partitions loaded, load them
            if (!PartitionRegistry.Partitions.Any())
                PartitionRegistry.ParseAndRegisterAllPartitions(m_Mounter);
            
            // Clear out any existing lights/meshes that may have been there before
            m_Lights.Clear();
            m_MeshLocations.Clear();

            // Try and get the requested partition
            var s_LevelPartition = PartitionRegistry.Partitions.FirstOrDefault(p_Partition =>
                p_Partition.Name.Equals(p_LevelPartitionName, StringComparison.InvariantCultureIgnoreCase));

            // Check that we got any partition
            if (s_LevelPartition is null)
            {
                p_Writer.WriteLine($"Partition {p_LevelPartitionName} not found.");
                return;
            }

            // Check that the primary instance is LevelData
            if (s_LevelPartition.PrimaryInstance is not LevelData s_LevelData)
            {
                p_Writer.WriteLine($"Partition {p_LevelPartitionName} LevelData not found.");
                return;
            }

            // Get the level description
            var s_LevelDescription = s_LevelData.LevelDescription;

            // Write out some basic information
            p_Writer.WriteLine($"Level {s_LevelDescription.Name} MP: {s_LevelDescription.IsMultiplayer}");

            // Iterate all the LevelData.objects
            foreach (var s_LevelObjects in s_LevelData.Objects)
            {
                // Get the level object
                var s_LevelObject = s_LevelObjects.Get();

                // Validate level object
                if (s_LevelObject is null)
                    continue;

                // Determine level object type
                switch (s_LevelObject)
                {
                    case WorldPartReferenceObjectData s_WorldPartReference:
                        HandleWorldPart(s_WorldPartReference, p_Writer);
                        break;
                    case SubWorldReferenceObjectData s_SubWorldReference:
                        HandleSubWorld(s_SubWorldReference, p_Writer);
                        break;
                    case StaticModelGroupEntityData s_StaticModelGroup:
                        HandleStaticModelGroupEntity(s_StaticModelGroup, p_Writer);
                        break;
                    default:
                        p_Writer.WriteLine($"UNKNOWN LEVEL OBJECT: {s_LevelObject.TypeName}");
                        break;
                }
            }

            // Create a new scene
            var s_SceneBuilder = new SceneBuilder(p_LevelPartitionName);

            // Iterate and add all the lights
            foreach (var s_LightBuilder in m_Lights)
            {
                // No fucking clue if this is correct
                s_SceneBuilder.AddLight(s_LightBuilder.Key, BasisToMatrix(s_LightBuilder.Value));
            }



            // Go through all mesh transforms
            foreach (var s_MeshPair in m_MeshLocations)
            {
                // Try and get the MeshSet resource
                if (!m_Mounter.TryGetResource(s_MeshPair.Key, out var s_Resource))
                {
                    p_Writer.WriteLine($"Skipping {s_MeshPair.Key} could not find resource.");
                    continue;
                }

                // Create a new mesh converter
                var s_Converter = EngineInterfaceRegistry.Create<IMeshConverter>(m_Mounter.GetEngineType());

                var s_MeshBuilders = s_Converter.ConvertToGltf(s_Resource.FirstVariant, m_Mounter);
                if (s_MeshBuilders.Count == 0)
                {
                    p_Writer.WriteLine($"Skipping {s_MeshPair.Key} NO MESHES WERE BUILT");
                    continue;
                }

                foreach (var s_Location in s_MeshPair.Value)
                {
                    // No fucking clue if this is correct
                    foreach (var s_MeshBuilder in s_MeshBuilders)
                        s_SceneBuilder.AddRigidMesh(s_MeshBuilder, BasisToMatrix(s_Location));
                }
            }

            var s_FinalModel = s_SceneBuilder.ToGltf2();

            //s_FinalModel.SaveAsWavefront(p_Destination.FullName + ".obj");
            s_FinalModel.SaveGLTF(p_Destination.FullName);
            //s_FinalModel.SaveGLB(p_Destination.FullName + ".glb");
        }

        /*private static Matrix4x4 BasisToMatrix(LinearTransform p_Transform)
        {
            AffineTransform p_AffineTransform;
            p_AffineTransform.
            /*return new Matrix4x4(p_Transform.forward.x, p_Transform.forward.y, p_Transform.forward.z, 0f,
                p_Transform.right.x, p_Transform.right.y, p_Transform.right.z, 0f,
                p_Transform.up.x, p_Transform.up.y, p_Transform.up.z, 0f,
                p_Transform.trans.x, p_Transform.trans.y, p_Transform.trans.z, 1f);

            return new Matrix4x4(p_Transform.right.x, p_Transform.up.x, p_Transform.forward.x, 0f,
                p_Transform.right.y, p_Transform.up.y, p_Transform.forward.y, 0f,
                p_Transform.right.z, p_Transform.up.z, p_Transform.forward.z, 0f,
                p_Transform.trans.x, p_Transform.trans.y, p_Transform.trans.z, 1f);

            /*return BasisToMatrix(new Vector3(p_Transform.forward.x, p_Transform.forward.y, p_Transform.forward.z),
                new Vector3(p_Transform.right.x, p_Transform.right.y, p_Transform.right.z),
                new Vector3(p_Transform.up.x, p_Transform.up.y, p_Transform.up.z),
                new Vector3(p_Transform.trans.x, p_Transform.trans.y, p_Transform.trans.z));
        }*/

        private static AffineTransform BasisToMatrix(LinearTransform p_Transform)
        {
            var s_Quat = FromUpRightForward(new Vector3(p_Transform.up.x, p_Transform.up.y, p_Transform.up.z),
                new Vector3(p_Transform.right.x, p_Transform.right.y, p_Transform.right.z),
                new Vector3(p_Transform.forward.x, p_Transform.forward.y, p_Transform.forward.z));
            
            return new AffineTransform(s_Quat, new Vector3(p_Transform.trans.x, p_Transform.trans.y, p_Transform.trans.z));
        }

        /// <summary>
        /// Convert Up/Right/Forward basis vectors to a Quaternion.
        /// - forwardIsLookDir=true: your Forward points where you look (use -Z in RH frames).
        /// - inputsAreColumns=true: vectors are basis COLUMNS (glTF-style). false = basis ROWS (DX-style).
        /// </summary>
        public static Quaternion FromUpRightForward(
            Vector3 up, Vector3 right, Vector3 forward,
            bool forwardIsLookDir = false,
            bool inputsAreColumns = true,
            bool orthonormalize = true)
        {
            // Choose Z basis according to your convention
            var z = forwardIsLookDir ? -forward : forward; // glTF camera looks along -Z
            var x = right;
            var y = up;

            if (orthonormalize)
            {
                // Enforce orthonormal, right-handed basis
                z = SafeNormalize(z);
                x = SafeNormalize(x);

                // y from z×x, then x from y×z (keeps x ⟂ y ⟂ z)
                y = SafeNormalize(Vector3.Cross(z, x));
                x = SafeNormalize(Vector3.Cross(y, z));

                // Ensure right-handedness: (x×y)·z > 0
                if (Vector3.Dot(Vector3.Cross(x, y), z) < 0f) x = -x;
            }
            else
            {
                x = SafeNormalize(x);
                y = SafeNormalize(y);
                z = SafeNormalize(z);
            }

            // Build rotation matrix for System.Numerics (row-major)
            Matrix4x4 m;
            if (inputsAreColumns)
            {
                // Axes as COLUMNS ⇒ fill by columns across rows
                m = new Matrix4x4(
                    x.X, y.X, z.X, 0f,
                    x.Y, y.Y, z.Y, 0f,
                    x.Z, y.Z, z.Z, 0f,
                    0f, 0f, 0f, 1f
                );
            }
            else
            {
                // Axes as ROWS
                m = new Matrix4x4(
                    x.X, x.Y, x.Z, 0f,
                    y.X, y.Y, y.Z, 0f,
                    z.X, z.Y, z.Z, 0f,
                    0f, 0f, 0f, 1f
                );
            }

            return Quaternion.CreateFromRotationMatrix(m);
        }

        private static Vector3 SafeNormalize(Vector3 v)
        {
            var len = v.Length();
            return len > 1e-8f ? v / len : Vector3.UnitX; // fallback axis if degenerate
        }
    }
}
