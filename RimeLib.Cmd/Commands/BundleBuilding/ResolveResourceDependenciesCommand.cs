using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;
using RimeLib.Content.Frostbite;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    // TODO: rename command to something like ResolveTypeDependenciesCommand
    [CommandDescription("Adds all referenced resources that are not in the current bundle.")]
    public class ResolveResourceDependenciesCommand : Command
    {
        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; } = 1;

        [CommandArgument(Description = "Comma-separated name prefixes whose textures to skip, e.g. 'characters/'. Shipping those crashes the streaming worker; skipping them just leaves the mesh untextured.", Optional = true)]
        public string? SkipPrefixes { get; set; }

        private string[] m_SkipPrefixes = Array.Empty<string>();

        private readonly HashSet<string> m_TextureChunksDone = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

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

            m_SkipPrefixes = string.IsNullOrWhiteSpace(SkipPrefixes)
                ? Array.Empty<string>()
                : SkipPrefixes!.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

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

            // Texture. TextureArrayAsset subclasses TextureAsset, so without naming it here its
            // resource never ships and the shader that samples it gets a null SRV.
            if (s_TypeName == "TextureAsset" || s_TypeName == "NoiseTextureAsset" || s_TypeName == "RenderTextureAsset" || s_TypeName == "TextureAssetBase" || s_TypeName == "TextureArrayAsset")
            {
                if (m_SkipPrefixes.Length > 0)
                {
                    var s_TextureName = s_Type.GetProperty("Name")?.GetValue(p_Instance) as string;
                    if (!string.IsNullOrEmpty(s_TextureName))
                    {
                        var s_Lower = s_TextureName.ToLowerInvariant();
                        foreach (var s_Prefix in m_SkipPrefixes)
                        {
                            if (s_Lower.StartsWith(s_Prefix, StringComparison.OrdinalIgnoreCase))
                            {
                                p_Writer.WriteLine($"Skipped texture (prefix {s_Prefix}): {s_Lower}");
                                return;
                            }
                        }
                    }
                }

                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.DxTexture, p_Context, p_Mounter, p_Writer);

                // A retail bundle always carries the texture's pixel chunk next to its header, so
                // without this the bundle would ship the header and no pixel data at all.
                AddTextureChunkFromProperty(p_Instance, p_Context, p_Mounter, p_Writer);
            }
            // Mesh
            else if (s_TypeName == "MeshAsset" || s_TypeName == "CompositeMeshAsset" || s_TypeName == "RigidMeshAsset" || s_TypeName == "SkinnedMeshAsset")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.MeshSet, p_Context, p_Mounter, p_Writer);

                var s_OccluderEnable = s_Type.GetProperty("OccluderMeshEnable")?.GetValue(p_Instance) as bool? ?? false;
                if (s_OccluderEnable)
                {
                    AddResourceByNameFromProperty(p_Instance, "Name", "_occludermesh", ResourceType.OccluderMesh, p_Context, p_Mounter, p_Writer);
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
            else if (s_TypeName == "AntAnimationSetAsset")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.AssetBank, p_Context, p_Mounter, p_Writer);
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
            else if (s_TypeName == "HavokAsset" || s_TypeName == "GroupHavokAsset" || s_TypeName == "WaterAsset")
            {
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.HavokPhysicsData, p_Context, p_Mounter, p_Writer);
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
            // Movie
            else if (s_TypeName == "MovieTextureAsset")
            {
                var s_ChunkGuid = s_Type.GetProperty("ChunkGuid")?.GetValue(p_Instance) as GUID;
                if (s_ChunkGuid is not null && s_ChunkGuid != GUID.Empty)
                {
                    if (p_Mounter.TryGetChunk(s_ChunkGuid, out var s_Chunk))
                    {
                        p_Context.AddChunk(s_ChunkGuid, s_Chunk.FirstVariant);
                        p_Writer.WriteLine($"Added MovieTexture chunk: {s_ChunkGuid}");
                    }
                }

                var s_SubtitleChunkGuid = s_Type.GetProperty("SubtitleChunkGuid")?.GetValue(p_Instance) as GUID;
                if (s_SubtitleChunkGuid is not null && s_SubtitleChunkGuid != GUID.Empty)
                {
                    if (p_Mounter.TryGetChunk(s_SubtitleChunkGuid, out var s_SubtitleChunk))
                    {
                        p_Context.AddChunk(s_SubtitleChunkGuid, s_SubtitleChunk.FirstVariant);
                        p_Writer.WriteLine($"Added MovieTexture subtitle chunk: {s_SubtitleChunkGuid}");
                    }
                }
            }
            // UI Text Database
            else if (s_TypeName == "UITextDatabase")
            {
                var s_BinaryChunk = s_Type.GetProperty("BinaryChunk")?.GetValue(p_Instance) as GUID;
                if (s_BinaryChunk is not null && s_BinaryChunk != GUID.Empty)
                {
                    if (p_Mounter.TryGetChunk(s_BinaryChunk, out var s_Chunk))
                    {
                        p_Context.AddChunk(s_BinaryChunk, s_Chunk.FirstVariant);
                        p_Writer.WriteLine($"Added UITextDatabase binary chunk: {s_BinaryChunk}");
                    }
                }

                var s_HistogramChunk = s_Type.GetProperty("HistogramChunk")?.GetValue(p_Instance) as GUID;
                if (s_HistogramChunk is not null && s_HistogramChunk != GUID.Empty)
                {
                    if (p_Mounter.TryGetChunk(s_HistogramChunk, out var s_Chunk))
                    {
                        p_Context.AddChunk(s_HistogramChunk, s_Chunk.FirstVariant);
                        p_Writer.WriteLine($"Added UITextDatabase histogram chunk: {s_HistogramChunk}");
                    }
                }
            }
            // Level
            else if (s_TypeName == "LevelData")
            {
                var s_BlobInfo = s_Type.GetProperty("PathfindingBlobInfo")?.GetValue(p_Instance);
                if (s_BlobInfo != null)
                {
                    var s_BlobId = s_BlobInfo.GetType().GetProperty("BlobId")?.GetValue(s_BlobInfo) as GUID;
                    if (s_BlobId is not null && s_BlobId != GUID.Empty)
                    {
                        if (p_Mounter.TryGetChunk(s_BlobId, out var s_Chunk))
                        {
                            p_Context.AddChunk(s_BlobId, s_Chunk.FirstVariant);
                            p_Writer.WriteLine($"Added LevelData pathfinding blob chunk: {s_BlobId}");
                        }
                    }
                }

                AddResourceByNameFromProperty(p_Instance, "Name", "/shaderdb", ResourceType.IShaderDatabase, p_Context, p_Mounter, p_Writer);
            }
            // Sound. SoundWaveAsset holds the actual audio and has the same Chunks shape as
            // SoundDataAsset; vehicles reference it for engine, idle and passby sounds, and without it
            // the audio component null-derefs.
            else if (s_TypeName == "SoundDataAsset" || s_TypeName == "SoundWaveAsset")
            {
                var s_Chunks = s_Type.GetProperty("Chunks")?.GetValue(p_Instance) as System.Collections.IEnumerable;
                if (s_Chunks != null)
                {
                    foreach (var s_ChunkEntry in s_Chunks)
                    {
                        var s_ChunkId = s_ChunkEntry.GetType().GetProperty("ChunkId")?.GetValue(s_ChunkEntry) as GUID;
                        if (s_ChunkId is null || s_ChunkId == GUID.Empty) continue;

                        if (p_Mounter.TryGetChunk(s_ChunkId, out var s_Chunk))
                        {
                            // Some bundles reference the same sound chunk without an asset name hash,
                            // which then fails serialization. The data is identical across variants, so
                            // preferring one that carries the hash is safe.
                            var s_Variant = s_Chunk.Variants.FirstOrDefault(p_V => p_V.GetAssetNameHash() != null) ?? s_Chunk.FirstVariant;
                            p_Context.AddChunk(s_ChunkId, s_Variant);
                            p_Writer.WriteLine($"Added SoundData chunk: {s_ChunkId}");
                        }
                    }
                }
            }
            // Terrain
            else if (s_TypeName == "TerrainData")
            {
                // TODO: should also include the .decals partition which has a TerrainDecalsData. same goes for .streamingtree with a TerrainStreamingTreeAsset.
                // TODO: there are a lot of terrain partitions that need to be added somehow
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
                p_Context.AddResource(p_Name, s_Resource.FirstVariant);
                p_Writer.WriteLine($"Added resource: {p_Name} (Type: {s_Resource.FirstVariant.GetResourceType()})");
                m_ResolvedKeys.Add(s_Key);
            }
        }

        /// <summary>Adds the texture's pixel chunk the way the retail source bundle carries it, with the
        /// persistent mips ranged in and the top mips left to stream from the catalog. The chunk id comes
        /// from the mounted 128-byte DxTexture header.</summary>
        private void AddTextureChunkFromProperty(object p_Instance, BundleBuildingContext p_Context, IEngineMounter p_Mounter, TextWriter p_Writer)
        {
            var s_Name = p_Instance.GetType().GetProperty("Name")?.GetValue(p_Instance) as string;
            if (string.IsNullOrEmpty(s_Name)) return;

            s_Name = s_Name.ToLowerInvariant();
            if (!m_TextureChunksDone.Add(s_Name)) return;

            if (p_Mounter is not RimeLib.Content.Frostbite2_0.Mounting.EngineMounter s_EngineMounter) return;
            if (!p_Mounter.TryGetResource(s_Name, out var s_Resource)) return;

            byte[] s_Header;
            try
            {
                using var s_Reader = s_Resource.FirstVariant.GetReader();
                if (s_Reader.Length < 128) return;
                s_Header = s_Reader.ReadBytes(128);
            }
            catch { return; }

            var s_SbBuildingContext = (SbBuildingContext)p_Context.Parent!;
            ITextureConverter s_Converter;
            try
            {
                s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(s_SbBuildingContext.EngineType);
            }
            catch (Exception s_Ex)
            {
                // A missing texture assembly must not take down the whole session.
                p_Writer.WriteLine($"WARN: texture chunk resolve unavailable ({s_Ex.Message}). Is RimeLib.Texture.Frostbite2_0.dll next to RimeREPL.exe?");
                return;
            }

            var s_Probe = new BundleBuildingContext.ResourceMemoryReader(s_Header, ResourceType.DxTexture, s_Name);
            var s_ChunkId = s_Converter.GetTextureChunkId(s_Probe);

            // A non-chunked texture keeps its whole payload in the resource.
            if (s_ChunkId == GUID.Empty) return;

            if (s_EngineMounter.TryGetTextureChunkRetailVariant(s_ChunkId, s_Name, out var s_ChunkVariant))
            {
                p_Context.AddChunk(s_ChunkId, s_ChunkVariant);
                p_Writer.WriteLine($"Added texture chunk (retail-ranged): {s_Name} -> {s_ChunkId}");
            }
            else if (p_Mounter.TryGetChunk(s_ChunkId, out var s_ChunkObj))
            {
                p_Context.AddChunk(s_ChunkId, s_ChunkObj.FirstVariant);
                p_Writer.WriteLine($"Added texture chunk (no h32 variant, FirstVariant): {s_Name} -> {s_ChunkId}");
            }
        }
    }
}
