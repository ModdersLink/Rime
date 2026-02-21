using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Content.Frostbite;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds all referenced resources that are not in the current bundle.")]
    public class ResolveResourceDependenciesCommand : Command
    {
        private HashSet<string> m_ResolvedKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbBuildingContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbBuildingContext.Parent!;

            var s_Mounters = s_BaseContext.GetMounters();
            if (s_Mounters.Count == 0)
            {
                p_Writer.WriteLine("Error: No game mounter found.");
                return false;
            }
            var s_Mounter = s_Mounters.Values.First();

            m_ResolvedKeys.Clear();
            var s_Resources = s_BundleContext.GetResources();
            foreach (var s_Res in s_Resources)
            {
                m_ResolvedKeys.Add($"{s_Res.Key}:{(ResourceType)s_Res.Value.GetResourceType()}");
            }

            p_Writer.WriteLine("Resolving resource dependencies...");

            var s_Partitions = s_BundleContext.GetPartitions().ToList();
            foreach (var s_PartitionEntry in s_Partitions)
            {
                var s_Partition = PartitionRegistry.Partitions.FirstOrDefault(p => p.Name.Equals(s_PartitionEntry.Key, StringComparison.OrdinalIgnoreCase));
                if (s_Partition == null) continue;

                if (s_Partition.Name == "animations/antanimations") continue;

                foreach (var s_Instance in s_Partition.Instances)
                {
                    ResolveInstanceResources(s_Instance, s_BundleContext, s_Mounter, p_Writer);
                }
            }

            p_Writer.WriteLine($"Done resolving resources. Total resources in bundle: {s_BundleContext.GetResources().Count}");
            return true;
        }

        private void ResolveInstanceResources(DataContainerBase? p_Instance, BundleBuildingContext p_Context, IEngineMounter p_Mounter, TextWriter p_Writer)
        {
            if (p_Instance == null) return;
            var s_Type = p_Instance.GetType();
            var s_TypeName = s_Type.Name;

            // Texture
            if (s_TypeName == "TextureAsset" || s_TypeName == "NoiseTextureAsset" || s_TypeName == "RenderTextureAsset" || s_TypeName == "TextureAssetBase")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.DxTexture, p_Context, p_Mounter, p_Writer);
            }
            // Mesh
            else if (s_TypeName == "MeshAsset" || s_TypeName == "CompositeMeshAsset" || s_TypeName == "RigidMeshAsset" || s_TypeName == "SkinnedMeshAsset")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.MeshSet, p_Context, p_Mounter, p_Writer);

                var s_OccluderEnable = s_Type.GetProperty("OccluderMeshEnable")?.GetValue(p_Instance) as bool? ?? false;
                if (s_OccluderEnable)
                {
                    AddResourceByNameFromProperty(p_Instance, "Name", "_occluder", ResourceType.OccluderMesh, p_Context, p_Mounter, p_Writer);
                }
            }
            // Animation
            else if (s_TypeName == "TransformPartPropertyTrackData")
            {
                AddResourceByNameFromProperty(p_Instance, "ResourceName", ResourceType.AnimTrackData, p_Context, p_Mounter, p_Writer);
            }
            else if (s_TypeName == "AntPackageAsset")
            {
                // AntPackageAsset name points to an AssetBank resource in Venice.
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.AssetBank, p_Context, p_Mounter, p_Writer);

                // Also add the streaming chunk if it has one
                var s_Guid = s_Type.GetProperty("StreamingGuid")?.GetValue(p_Instance) as GUID;
                if (s_Guid is not null && s_Guid != GUID.Empty)
                {
                    if (p_Mounter.TryGetChunk(s_Guid, out var s_Chunk))
                    {
                        var s_ResName = s_Type.GetProperty("Name")?.GetValue(p_Instance) as string;
                        var s_Variant = s_Chunk.FirstVariant;

                        if (!string.IsNullOrEmpty(s_ResName))
                        {
                            var s_ResNameHash = (int)RimeLib.Frostbite.Utils.HashQuick(s_ResName);
                            var s_FoundVariant = s_Chunk.Variants.FirstOrDefault(v => v.GetAssetNameHash() == s_ResNameHash);
                            if (s_FoundVariant != null)
                                s_Variant = s_FoundVariant;
                        }

                        p_Context.AddChunk(s_Guid, s_Variant);
                        p_Writer.WriteLine($"Added AntPackage chunk: {s_Guid}");
                    }
                }
            }
            // Enlighten
            else if (s_TypeName == "EnlightenDataAsset")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.EnlightenDatabase, p_Context, p_Mounter, p_Writer);
            }
            else if (s_TypeName == "EnlightenShaderDatabaseAsset")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.EnlightenShaderDatabase, p_Context, p_Mounter, p_Writer);
            }
            else if (s_TypeName == "StaticEnlightenData")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.StaticEnlightenDatabase, p_Context, p_Mounter, p_Writer);
            }
            // Havok
            else if (s_TypeName == "HavokAsset")
            {
                var s_ExtAssets = s_Type.GetProperty("ExternalAssets")?.GetValue(p_Instance);

                if (s_ExtAssets != null && s_ExtAssets is System.Collections.IEnumerable s_Enum && s_Enum.OfType<object>().Count() > 0)
                {
                    AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.HavokPhysicsData, p_Context, p_Mounter, p_Writer);
                }
                else
                {
                    AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.HavokDestructionPhysicsData, p_Context, p_Mounter, p_Writer);
                }
            }
            else if (s_TypeName == "RagdollAsset")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.RagdollResource, p_Context, p_Mounter, p_Writer);
            }
            // UI
            else if (s_TypeName == "UIAsset")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.SwfMovie, p_Context, p_Mounter, p_Writer);
            }
            // Terrain
            else if (s_TypeName == "TerrainData")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.Terrain, p_Context, p_Mounter, p_Writer);
                AddResourceByNameFromProperty(p_Instance, "Name", ".streamingtree", ResourceType.TerrainStreamingTree, p_Context, p_Mounter, p_Writer);
                AddResourceByNameFromProperty(p_Instance, "Name", ".visual", ResourceType.VisualTerrain, p_Context, p_Mounter, p_Writer);
                AddResourceByNameFromProperty(p_Instance, "Name", ".decals", ResourceType.TerrainDecals, p_Context, p_Mounter, p_Writer);
            }
        }

        private void AddResourceByNameFromProperty(object p_Instance, string p_PropName, string p_Suffix, ResourceType p_Type, BundleBuildingContext p_Context, IEngineMounter p_Mounter, TextWriter p_Writer)
        {
            var s_Name = p_Instance.GetType().GetProperty(p_PropName)?.GetValue(p_Instance) as string;
            if (!string.IsNullOrEmpty(s_Name))
            {
                AddResourceByName($"{s_Name.ToLowerInvariant()}{p_Suffix}", p_Type, p_Context, p_Mounter, p_Writer);
            }
        }

        private void AddResourceByNameFromProperty(object p_Instance, string p_PropName, ResourceType p_Type, BundleBuildingContext p_Context, IEngineMounter p_Mounter, TextWriter p_Writer)
        {
            var s_Name = p_Instance.GetType().GetProperty(p_PropName)?.GetValue(p_Instance) as string;
            if (!string.IsNullOrEmpty(s_Name))
            {
                AddResourceByName(s_Name.ToLowerInvariant(), p_Type, p_Context, p_Mounter, p_Writer);
            }
        }

        private void AddResourceByName(string p_Name, ResourceType p_Type, BundleBuildingContext p_Context, IEngineMounter p_Mounter, TextWriter p_Writer)
        {
            var s_Key = $"{p_Name}:{p_Type}";
            if (m_ResolvedKeys.Contains(s_Key)) return;

            if (p_Mounter.TryGetResource(p_Name, out var s_Resource))
            {
                if (s_Resource.FirstVariant.GetResourceType() == p_Type)
                {
                    p_Context.AddResource(p_Name, s_Resource.FirstVariant);
                    p_Writer.WriteLine($"Added resource: {p_Name} (Type: {p_Type})");
                    m_ResolvedKeys.Add(s_Key);
                }
            }
        }
    }
}
