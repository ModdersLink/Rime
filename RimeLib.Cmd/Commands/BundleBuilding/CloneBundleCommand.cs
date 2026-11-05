using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using Newtonsoft.Json;
using RimeLib.Content.Mounting;
using System.Collections.Generic;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Clones an existing bundle and lets you modify it.")]
    public class CloneBundleCommand : Command
    {
        [CommandArgument(Description = "The name of the bundle.")]
        public string? Bundle { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game the bundle is in.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BaseContext = (BaseContext)p_Context.Parent!.Parent!;
            if (!(s_BaseContext).TryGetMounterById(Id, out var s_Mounter))
            {
                p_Writer.WriteLine($"Could not find a mounted game with the specified id '{Id}'. Use the 'list_games' command to see a list of currently mounted games.");
                return false;
            }

            // Create a new GameContext to get the content of the bundle.
            var s_GameContext = new GameContext(s_BaseContext, p_Id: Id, p_Mounter: s_Mounter!);
            var s_BundleBuildingContext = (BundleBuildingContext)p_Context;

            // Each object as this bundle ships it, not as the first bundle that has it does.
            // Chunks
            var s_Chunks = s_GameContext.GetBundleChunksWithHash(Bundle!).ToList();
            foreach (var s_Chunk in s_Chunks)
            {
                if (!s_Mounter!.TryGetChunk(s_Chunk.Guid, out var s_ChunkObject))
                {
                    p_Writer.WriteLine($"Could not find chunk with ({s_Chunk.Guid.ToString("D")}).");
                    return false;
                }

                var s_Variant = s_ChunkObject.Variants.FirstOrDefault(p_Variant => p_Variant.GetAssetNameHash() == s_Chunk.AssetNameHash && p_Variant.IsInBundle(Bundle!))
                    ?? s_ChunkObject.Variants.FirstOrDefault(p_Variant => p_Variant.GetAssetNameHash() == s_Chunk.AssetNameHash);
                if (s_Variant == null)
                {
                    p_Writer.Write($"Could not find chunk variant of ({s_Chunk.Guid.ToString("D")}) with h32 ({s_Chunk.AssetNameHash}).\n");
                    s_Variant = s_ChunkObject.FirstVariant;
                }

                s_BundleBuildingContext.AddChunk(s_Chunk.Guid, s_Variant);
            }

            // Resources
            var s_Resources = s_GameContext.GetBundleResources(Bundle!).ToList();
            foreach (var s_Resource in s_Resources)
            {
                if (!s_Mounter!.TryGetResource(s_Resource.Name, out var s_ResourceObject))
                {
                    p_Writer.WriteLine($"Could not get the resource of ({s_Resource.Name}).");
                    return false;
                }

                s_BundleBuildingContext.AddResource(s_Resource.Name, s_ResourceObject.VariantIn(Bundle!));
            }

            // Partitions
            var s_PartitionList = new List<IMountedObject>();
            var s_Partitions = s_GameContext.GetBundlePartitions(Bundle!).ToList();
            foreach (var s_Partition in s_Partitions)
            {
                if (!s_Mounter!.TryGetPartition(s_Partition, out IMountedObject? p_MountedPartition))
                {
                    p_Writer.WriteLine($"Could not get partition of ({s_Partition}).");
                    return false;
                }

                s_BundleBuildingContext.AddPartition(p_MountedPartition.OriginalName, p_MountedPartition.VariantIn(Bundle!));
            }

            // Dbx entries, where the engine mounts them, in the bundle's order.
            var s_Dbx = s_Mounter!.GetDbxPartitions();
            foreach (var s_Name in s_Mounter.GetDbxPartitionsInBundle(Bundle!))
            {
                if (s_Dbx.TryGetValue(s_Name.ToLowerInvariant(), out var s_DbxObject))
                    s_BundleBuildingContext.AddDbx(s_Name, s_DbxObject.VariantIn(Bundle!));
            }

            return true;
        }
    }
}
