using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using Newtonsoft.Json;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Clones an existing bundle and lets you modify it.")]
    public class CloneBundleCommand : Command
    {
        [CommandArgument(Description = "The name of the bundle.")]
        public string? Bundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            // TODO: don't hardcode path
            string s_Path = @"/home/txt/Documents/Code/rime/build_test/tempdir";
            // Expects to have a mounted game already.
            // Mount the game with the Id 1.
            var s_BaseContext = (BaseContext)p_Context.Parent!.Parent!;
            if (!(s_BaseContext).TryGetMounterById(1, out var s_Mounter))
            {
                p_Writer.WriteLine($"Could not find a mounted game with the specified id '{1}'. Use the 'list_games' command to see a list of currently mounted games.");
                return false;
            }

            // Create a new GameContext to get the content of the bundle.
            var s_GameContext = new GameContext(s_BaseContext, p_Id: 1, p_Mounter: s_Mounter!);
            var s_BundleBuildingContext = (BundleBuildingContext)p_Context;

            // Chunks
            var s_Chunks = s_GameContext.GetBundleChunksWithHash(Bundle!).ToList();
            foreach (var s_Chunk in s_Chunks)
            {
                FileInfo s_FileInfo = new FileInfo(Path.Join(s_Path, s_Chunk.Guid.ToString() + ".chunk"));
                s_GameContext.DumpChunk(s_Chunk.Guid, s_FileInfo);
                s_BundleBuildingContext.AddChunk(s_Chunk.Guid, s_FileInfo, s_Chunk.AssetNameHash);
            }

            // Resources
            var s_Resources = s_GameContext.GetBundleResources(Bundle!).ToList();
            foreach (var s_Resource in s_Resources)
            {
                FileInfo s_FileInfo = new FileInfo(Path.Join(s_Path, s_Resource.Name + "." + s_Resource.ResourceType.ToString()));
                s_GameContext.DumpResource(s_Resource.Name, s_FileInfo);
                s_BundleBuildingContext.AddResource(s_Resource.Name, s_Resource.ResourceType, s_FileInfo);
            }

            // Partitions
            var s_Partitions = s_GameContext.GetBundlePartitions(Bundle!).ToList();
            foreach (var s_Partition in s_Partitions)
            {
                FileInfo s_FileInfo = new FileInfo(Path.Join(s_Path, s_Partition + ".json"));
                s_GameContext.DumpPartitionJson(s_Partition, s_FileInfo, Formatting.Indented);
                s_BundleBuildingContext.AddJsonPartition(s_Partition, s_FileInfo);
            }

            return true;
        }
    }
}
