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
    [CommandDescription("Adds all referenced resources that are not in the current bundle. Optional 2nd arg = comma-separated name PREFIXES whose TEXTURE resources/chunks are skipped (e.g. 'characters/' — BF3 character textures are TextureArrays consumed via the CHARACTER streaming pool, whose per-source installer mod bundles never register: shipping them = null-deref in the streaming worker the moment the mesh draws; leaving them out = the mesh draws textureless/invisible, harmless).")]
    public class ResolveResourceDependenciesCommand : Command
    {
        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; } = 1;

        [CommandArgument(Description = "Optional comma-separated name prefixes: skip TEXTURE resource/chunk adds for matching names (e.g. characters/).", Optional = true)]
        public string? SkipPrefixes { get; set; }

        private string[] m_Skip = System.Array.Empty<string>();

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

            m_Skip = string.IsNullOrWhiteSpace(SkipPrefixes)
                ? System.Array.Empty<string>()
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

            // Texture. TextureArrayAsset (e.g. Vehicles/Common/Textures/Dust_D — the vehicle glass/
            // optics dust array) subclasses TextureAsset and was silently SKIPPED here → its resource
            // never shipped → null SRV (+0x29bdb1) the moment a cockpit glass shader sampled it.
            if (s_TypeName == "TextureAsset" || s_TypeName == "NoiseTextureAsset" || s_TypeName == "RenderTextureAsset" || s_TypeName == "TextureAssetBase" || s_TypeName == "TextureArrayAsset")
            {
                if (m_Skip.Length > 0)
                {
                    var s_TexName = s_Type.GetProperty("Name")?.GetValue(p_Instance) as string;
                    if (!string.IsNullOrEmpty(s_TexName))
                    {
                        var s_Low = s_TexName.ToLowerInvariant();
                        foreach (var s_P in m_Skip)
                        {
                            if (s_Low.StartsWith(s_P, StringComparison.OrdinalIgnoreCase))
                            {
                                p_Writer.WriteLine($"Skipped texture (prefix {s_P}): {s_Low}");
                                return;
                            }
                        }
                    }
                }
                AddResourceByNameFromProperty(p_Instance, "Name", ResourceType.DxTexture, p_Context, p_Mounter, p_Writer);
                // DICE-parity (2026-07-15): a retail bundle ALWAYS pairs the texture header with its
                // pixel chunk in the SAME bundle — possibly TAIL-RANGED (small mips persistent,
                // logicalOffset + chunkMeta { h32, firstMip }; the top mips stream from the catalog).
                // Without this the bundle carries the header but no pixel data at all.
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
            // Sound (SoundWaveAsset = the actual audio; same Chunks[] shape as SoundDataAsset — vehicles
            // reference these for engine/idle/passby sounds; without them the audio component null-derefs).
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
                            // Prefer a variant that carries chunk meta (asset-name-hash). Some bundles
                            // reference the same sound chunk WITHOUT meta (FirstVariant), which then
                            // fails final serialization ("chunk with no asset name hash"). The chunk
                            // data is identical across variants (same GUID), so the metad one is safe.
                            var s_Variant = s_Chunk.Variants.FirstOrDefault(v => v.GetAssetNameHash() != null) ?? s_Chunk.FirstVariant;
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
                var s_Variant = s_Resource.FirstVariant;
                // DICE-parity (2026-07-15): texture headers must re-emit as IDATA like every retail
                // cas bundle does (74k+ DxTexture idata variants). FirstVariant may be catalog/
                // noncas-backed and re-emits as a bare SHA1 ref that may not be catalog-backed at
                // all (headers never get cataloged) -> the engine has no payload for the header.
                if (p_Type == ResourceType.DxTexture
                    && p_Mounter is RimeLib.Content.Frostbite2_0.Mounting.EngineMounter s_EM
                    && s_EM.TryGetInlineResourceVariant(p_Name, out var s_Inline))
                    s_Variant = s_Inline;
                p_Context.AddResource(p_Name, s_Variant);
                p_Writer.WriteLine($"Added resource: {p_Name} (Type: {s_Variant.GetResourceType()})");
                m_ResolvedKeys.Add(s_Key);
            }
        }

        private readonly HashSet<string> m_TexChunksDone = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        /// <summary>DICE-parity: add the texture's pixel chunk exactly as the retail source bundle
        /// carries it (ranged persistent mips + chunkMeta {h32, firstMip}); the top mips stream from
        /// the catalog like retail. Chunk id read from the mounted 128-byte DxTexture header.</summary>
        private void AddTextureChunkFromProperty(object p_Instance, BundleBuildingContext p_Context, IEngineMounter p_Mounter, TextWriter p_Writer)
        {
            var s_Name = p_Instance.GetType().GetProperty("Name")?.GetValue(p_Instance) as string;
            if (string.IsNullOrEmpty(s_Name)) return;
            s_Name = s_Name.ToLowerInvariant();
            if (m_TexChunksDone.Contains(s_Name)) return;
            m_TexChunksDone.Add(s_Name);

            if (p_Mounter is not RimeLib.Content.Frostbite2_0.Mounting.EngineMounter s_EM) return;
            if (!p_Mounter.TryGetResource(s_Name, out var s_Res)) return;

            byte[] s_Header;
            try
            {
                using var s_R = s_Res.FirstVariant.GetReader();
                if (s_R.Length < 128) return;
                s_Header = s_R.ReadBytes(128);
            }
            catch { return; }

            var s_SbCtx = (SbBuildingContext)p_Context.Parent!;
            ITextureConverter s_Converter;
            try
            {
                s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(s_SbCtx.EngineType);
            }
            catch (Exception s_Ex)
            {
                // Missing texture support assembly must NOT kill the whole REPL/session — warn once.
                p_Writer.WriteLine($"WARN: texture chunk resolve unavailable ({s_Ex.Message}) — is RimeLib.Texture.Frostbite2_0.dll next to RimeREPL.exe?");
                return;
            }
            var s_Probe = new BundleBuildingContext.ResourceMemoryReader(s_Header, ResourceType.DxTexture, s_Name);
            var s_ChunkId = s_Converter.GetTextureChunkId(s_Probe);
            if (s_ChunkId == GUID.Empty) return;   // non-chunked texture (payload fully in the resource)

            if (s_EM.TryGetTextureChunkRetailVariant(s_ChunkId, s_Name, out var s_ChunkVariant))
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
