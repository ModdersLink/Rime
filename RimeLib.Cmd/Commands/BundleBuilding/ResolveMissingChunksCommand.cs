using System;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Mesh.Frostbite;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Resolves missing chunk dependencies for dxtextures and meshes in the current bundle.")]
    public class ResolveMissingChunksCommand : Command
    {
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

            var s_Resources = s_BundleContext.GetResources().ToList();
            int s_AddedChunks = 0;

            foreach (var s_Res in s_Resources)
            {
                var s_Type = s_Res.Value.GetResourceType();
                GUID s_ChunkId = GUID.Empty;

                try
                {
                    if (s_Type == ResourceType.DxTexture || s_Type == ResourceType.Ps3Texture)
                    {
                        var s_TextureConverter = EngineInterfaceRegistry.Create<ITextureConverter>(s_SbBuildingContext.EngineType);
                        s_ChunkId = s_TextureConverter.GetTextureChunkId(s_Res.Value);
                    }
                    else if (s_Type == ResourceType.MeshSet)
                    {
                        using var s_Reader1 = s_Res.Value.GetReader();
                        var s_Data = s_Reader1.ReadBytes((int)s_Reader1.Length);
                        using var s_Reader = new RimeReader(new MemoryStream(s_Data));

                        var s_MeshSetLayout = new MeshSetLayout(s_Reader);

                        for (var i = 0; i < s_MeshSetLayout.LodCount; i++)
                        {
                            var s_Lod = s_MeshSetLayout.Lods[i].Object;
                            if (s_Lod != null && s_Lod.DataChunkId != GUID.Empty && (s_Lod.Flags & MeshLayout.MeshLayoutFlags.IsBaseLod) != 0)
                            {
                                if (!s_BundleContext.GetChunks().ContainsKey(s_Lod.DataChunkId))
                                {
                                    if (s_Mounter.TryGetChunk(s_Lod.DataChunkId, out var s_ChunkObj))
                                    {
                                        var s_ResNameHash = (int)RimeLib.Frostbite.Utils.HashQuick(s_Res.Key);
                                        var s_Variant = s_ChunkObj.Variants.FirstOrDefault(v => v.GetAssetNameHash() == s_ResNameHash)
                                                     ?? s_ChunkObj.FirstVariant;

                                        s_BundleContext.AddChunk(s_Lod.DataChunkId, s_Variant);
                                        p_Writer.WriteLine($"Added missing mesh chunk: {s_Lod.DataChunkId} for resource {s_Res.Key}");
                                        s_AddedChunks++;
                                    }
                                    else
                                    {
                                        p_Writer.WriteLine($"Warning: Missing mesh chunk {s_Lod.DataChunkId} for resource {s_Res.Key} not found in mounter.");
                                    }
                                }
                            }
                        }
                    }

                    if (s_ChunkId != GUID.Empty && !s_BundleContext.GetChunks().ContainsKey(s_ChunkId))
                    {
                        if (s_Mounter.TryGetChunk(s_ChunkId, out var s_ChunkObj))
                        {
                            // Prefer the CAS variant (SHA1 reference into the game's shared cas -> the built
                            // bundle references it instead of inlining the bytes = tiny, DICE's way). Fall back
                            // to a bundle-contained (inline) variant only if no cas variant exists.
                            var s_Variant = s_ChunkObj.Variants.FirstOrDefault(v => v.Cas)
                                         ?? s_ChunkObj.Variants.FirstOrDefault(v => v.GetContainedBundle() != null)
                                         ?? s_ChunkObj.FirstVariant;

                            s_BundleContext.AddChunk(s_ChunkId, s_Variant);
                            p_Writer.WriteLine($"Added missing texture chunk: {s_ChunkId} for resource {s_Res.Key}");
                            s_AddedChunks++;
                        }
                        else
                        {
                            p_Writer.WriteLine($"Warning: Missing texture chunk {s_ChunkId} for resource {s_Res.Key} not found in mounter.");
                        }
                    }
                }
                catch (Exception p_Ex)
                {
                    p_Writer.WriteLine($"Error resolving chunks for {s_Res.Key}: {p_Ex.Message}");
                }
            }

            p_Writer.WriteLine($"Done tracking down missing chunks. Added {s_AddedChunks} missing chunks to bundle.");
            return true;
        }
    }
}
