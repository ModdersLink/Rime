using System.Numerics;
using fb;
using RimeLib.Content.Mounting;
using RimeLib.Math;
using RimeLib.Mesh;
using RimeLib.Serialization;
using SharpGLTF.Scenes;
using SharpGLTF.Transforms;

namespace RimeLib.Toolkit.Frostbite2_0;

public class LevelMeshConverter
{
    private readonly Dictionary<string, List<LinearTransform>> m_MeshLocations = new();
    private readonly List<KeyValuePair<LightBuilder, LinearTransform>> m_Lights = [];
    private IEngineMounter m_Mounter;
    private TextWriter m_Writer;

    public LevelMeshConverter(IEngineMounter p_Mounter, TextWriter p_Writer)
    {
        m_Mounter = p_Mounter;
        m_Writer = p_Writer;
    }

    private void HandleVehicleBlueprint(VehicleBlueprint p_Blueprint, LinearTransform p_Transform)
    {
        m_Writer.WriteLine($"{p_Blueprint.Name} located at ({p_Transform.trans})");
    }

    private void HandleSoldierBlueprint(SoldierBlueprint p_Blueprint, LinearTransform p_Transform)
    {
        m_Writer.WriteLine($"{p_Blueprint.Name} located at ({p_Transform.trans})");
    }

    private void HandleSpatialPrefabBlueprint(SpatialPrefabBlueprint p_Blueprint, LinearTransform p_TransformBase)
    {
        m_Writer.WriteLine($"{p_Blueprint.Name} located at ({p_TransformBase.trans})");

        HandlePrefabBlueprint(p_Blueprint, p_TransformBase);
    }

    private static LinearTransform LinearTransform_Mul(LinearTransform a, LinearTransform b)
    {
        return new LinearTransform
        {
            right =
            {
                x = a.right.x * b.right.x + a.up.x * b.right.y + a.forward.x * b.right.z,
                y = a.right.y * b.right.x + a.up.y * b.right.y + a.forward.y * b.right.z,
                z = a.right.z * b.right.x + a.up.z * b.right.y + a.forward.z * b.right.z
            },
            up =
            {
                x = a.right.x * b.up.x + a.up.x * b.up.y + a.forward.x * b.up.z,
                y = a.right.y * b.up.x + a.up.y * b.up.y + a.forward.y * b.up.z,
                z = a.right.z * b.up.x + a.up.z * b.up.y + a.forward.z * b.up.z
            },
            forward =
            {
                x = a.right.x * b.forward.x + a.up.x * b.forward.y + a.forward.x * b.forward.z,
                y = a.right.y * b.forward.x + a.up.y * b.forward.y + a.forward.y * b.forward.z,
                z = a.right.z * b.forward.x + a.up.z * b.forward.y + a.forward.z * b.forward.z
            },
            trans =
            {
                // Combine translations
                x = a.right.x * b.trans.x + a.up.x * b.trans.y + a.forward.x * b.trans.z + a.trans.x,
                y = a.right.y * b.trans.x + a.up.y * b.trans.y + a.forward.y * b.trans.z + a.trans.y,
                z = a.right.z * b.trans.x + a.up.z * b.trans.y + a.forward.z * b.trans.z + a.trans.z
            }
        };
    }

    private void HandlePrefabBlueprint(PrefabBlueprint p_Blueprint, LinearTransform p_TransformBase)
    {
        m_Writer.WriteLine($"PrefabBlueprint {p_Blueprint.Name} located at ({p_TransformBase.trans})");

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
                    var s_NewTransform = LinearTransform_Mul(p_TransformBase, s_ObjectTransform);

                    switch (s_ReferenceObjectData.Blueprint.Get())
                    {
                        case SpatialPrefabBlueprint s_SpatialPrefabBlueprint:
                            HandleSpatialPrefabBlueprint(s_SpatialPrefabBlueprint, s_NewTransform);
                            break;
                        case ObjectBlueprint s_ObjectBlueprint:
                            HandleObjectBlueprint(s_ObjectBlueprint, s_NewTransform);
                            break;
                        default:
                            m_Writer.WriteLine($"UNHANDLED OBJECT: {s_Object.TypeName}");
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
                    m_Writer.WriteLine($"UNKNOWN HANDLED OBJECT {s_Object.TypeName}.");
                    break;
            }
        }
    }

    private void HandleObjectBlueprint(ObjectBlueprint p_Blueprint, LinearTransform p_Transform)
    {
        var s_Object = p_Blueprint.Object.Get();
        if (s_Object is null)
        {
            m_Writer.WriteLine($"No object found for {p_Blueprint.Name}.");
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
                m_Writer.WriteLine($"ObjectBlueprintPoint: {s_Object.TypeName}");
                break;
        }


        m_Writer.WriteLine(
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

    private void HandleReferenceObjectData(ReferenceObjectData p_ReferenceObjectData, bool p_IncludeExcluded = false)
    {
        // Exclusion check
        if (p_ReferenceObjectData.Excluded && !p_IncludeExcluded)
        {
            m_Writer.WriteLine($"Skipping reference object data ({p_ReferenceObjectData.InstanceId}).");
            return;
        }

        // Check to see if we have any blueprint
        if (p_ReferenceObjectData.Blueprint.Get() is null)
        {
            m_Writer.WriteLine($"Skipping blueprint data ({p_ReferenceObjectData.InstanceId}).");
            return;
        }

        var s_BlueprintTransform = p_ReferenceObjectData.BlueprintTransform;

        // If we have a blueprint break out based on supported types
        switch (p_ReferenceObjectData.Blueprint.Get())
        {
            case VehicleBlueprint s_VehicleBlueprint:
                HandleVehicleBlueprint(s_VehicleBlueprint, s_BlueprintTransform);
                break;
            case SoldierBlueprint s_SoldierBlueprint:
                HandleSoldierBlueprint(s_SoldierBlueprint, s_BlueprintTransform);
                break;
            case SpatialPrefabBlueprint s_SpatialPrefabBlueprint:
                // s_SpatialPrefabBlueprint.blueprintTransform.trans + objects.trans
                HandleSpatialPrefabBlueprint(s_SpatialPrefabBlueprint, s_BlueprintTransform);
                break;
            case PrefabBlueprint s_PrefabBlueprint:
                HandlePrefabBlueprint(s_PrefabBlueprint, s_BlueprintTransform);
                break;
            case ObjectBlueprint s_ObjectBlueprint:
                HandleObjectBlueprint(s_ObjectBlueprint, s_BlueprintTransform);
                break;
            default:
                m_Writer.WriteLine($"UNKNOWN BLUEPRINT TYPE: {p_ReferenceObjectData.Blueprint.Instance?.TypeName}");
                break;
        }
    }

    private void HandleRoadData(RoadData p_RoadData)
    {
        m_Writer.WriteLine($"Parsing RoadData ({p_RoadData.InstanceId}), PointCount: ({p_RoadData.Points.Count}).");

        // TODO: Handle RoadData points in a GLTF spline
    }

    private void HandlePointLightEntity(PointLightEntityData p_PointLightEntityData)
    {
        m_Writer.WriteLine(
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

    private void HandleSpotLightEntity(SpotLightEntityData p_SpotLightEntityData)
    {
        m_Writer.WriteLine(
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
                    HandleReferenceObjectData(s_ReferenceObjectData);
                    break;
                case RoadData s_RoadData:
                    HandleRoadData(s_RoadData);
                    break;
                case PointLightEntityData s_PointLightEntityData:
                    HandlePointLightEntity(s_PointLightEntityData);
                    break;
                case SpotLightEntityData s_SpotLightEntityData:
                    HandleSpotLightEntity(s_SpotLightEntityData);
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
        /*(Vector4 rotation, Vector3 position)[] s_List = SubwayTransforms.mp_subway_transforms;

        for (var s_Index = 0; s_Index < p_Data.MemberDatas.Count; s_Index++)
        {
            var s_MemberData = p_Data.MemberDatas[s_Index];
        }*/

        /*
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
        }*/
    }

    internal bool ExportLevelMesh(string p_LevelPartitionName, out SceneBuilder? p_OutSceneBuilder, FileInfo? p_HavokTransforms = null)
    {
        // Required
        p_OutSceneBuilder = null;
        
        // If we do not have any partitions loaded, load them
        if (!PartitionRegistry.Partitions.Any())
            PartitionRegistry.ParseAndRegisterAllPartitions(m_Mounter!);

        // Clear out any existing lights/meshes that may have been there before
        m_Lights.Clear();
        m_MeshLocations.Clear();

        // Try and get the requested partition
        var s_LevelPartition = PartitionRegistry.Partitions.FirstOrDefault(p_Partition =>
            p_Partition.Name.Equals(p_LevelPartitionName, StringComparison.InvariantCultureIgnoreCase));

        // Check that we got any partition
        if (s_LevelPartition is null)
        {
            m_Writer.WriteLine($"Partition {p_LevelPartitionName} not found.");
            return false;
        }

        // Check that the primary instance is LevelData
        if (s_LevelPartition.PrimaryInstance is not LevelData s_LevelData)
        {
            m_Writer.WriteLine($"Partition {p_LevelPartitionName} LevelData not found.");
            return false;
        }

        // Get the level description
        var s_LevelDescription = s_LevelData.LevelDescription;

        // Write out some basic information
        m_Writer.WriteLine($"Level {s_LevelDescription.Name} MP: {s_LevelDescription.IsMultiplayer}");

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
                    HandleWorldPart(s_WorldPartReference, m_Writer);
                    break;
                case SubWorldReferenceObjectData s_SubWorldReference:
                    HandleSubWorld(s_SubWorldReference, m_Writer);
                    break;
                case StaticModelGroupEntityData s_StaticModelGroup:
                    HandleStaticModelGroupEntity(s_StaticModelGroup, m_Writer);
                    break;
                default:
                    m_Writer.WriteLine($"UNKNOWN LEVEL OBJECT: {s_LevelObject.TypeName}");
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
                m_Writer.WriteLine($"Skipping {s_MeshPair.Key} could not find resource.");
                continue;
            }

            // Create a new mesh converter
            var s_Converter = EngineInterfaceRegistry.Create<IMeshConverter>(m_Mounter.GetEngineType());

            var s_MeshBuilders = s_Converter.ConvertToMeshBuilders(s_Resource.FirstVariant, m_Mounter);
            if (s_MeshBuilders.Count == 0)
            {
                m_Writer.WriteLine($"Skipping {s_MeshPair.Key} NO MESHES WERE BUILT");
                continue;
            }

            foreach (var s_Location in s_MeshPair.Value)
            {
                // No fucking clue if this is correct
                foreach (var s_MeshBuilder in s_MeshBuilders)
                    s_SceneBuilder.AddRigidMesh(s_MeshBuilder, BasisToMatrix(s_Location));
            }
        }

        p_OutSceneBuilder = s_SceneBuilder;
        return true;
    }

    private static AffineTransform BasisToMatrix(LinearTransform p_Transform)
    {
        var s_Quat = RimeMath.FromUpRightForward(new Vector3(p_Transform.up.x, p_Transform.up.y, p_Transform.up.z),
            new Vector3(p_Transform.right.x, p_Transform.right.y, p_Transform.right.z),
            new Vector3(p_Transform.forward.x, p_Transform.forward.y, p_Transform.forward.z));

        return new AffineTransform(s_Quat, new Vector3(p_Transform.trans.x, p_Transform.trans.y, p_Transform.trans.z));
    }
}