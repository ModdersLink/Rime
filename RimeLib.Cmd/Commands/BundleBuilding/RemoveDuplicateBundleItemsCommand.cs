using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Removes all partitions, resources, and chunks that are already in any of the dependency bundles.")]
    public class RemoveDuplicateBundleItemsCommand : Command
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

            var s_DepBundles = s_BundleContext.GetDependencyBundles().ToList();
            var s_DepSuperbundles = s_BundleContext.GetDependencySuperbundles().ToList();

            if (s_DepBundles.Count == 0 && s_DepSuperbundles.Count == 0)
            {
                p_Writer.WriteLine("No dependency bundles or superbundles found to check against.");
                return true;
            }

            p_Writer.WriteLine("Removing duplicate items from dependency bundles...");

            int s_RemovedPartitions = 0;
            int s_RemovedResources = 0;
            int s_RemovedChunks = 0;

            foreach (var s_DepBndl in s_DepBundles)
            {
                try
                {
                    // Partitions
                    var s_BndlPartitions = s_Mounter.GetPartitionsInBundle(s_DepBndl);
                    foreach (var s_Part in s_BndlPartitions)
                    {
                        if (s_BundleContext.GetPartitions().ContainsKey(s_Part))
                        {
                            s_BundleContext.RemovePartition(s_Part);
                            p_Writer.WriteLine($"Removed duplicate partition: {s_Part} (Found in {s_DepBndl})");
                            s_RemovedPartitions++;
                        }
                    }

                    // Resources
                    var s_BndlResources = s_Mounter.GetResourcesInBundle(s_DepBndl);
                    foreach (var s_Res in s_BndlResources)
                    {
                        if (s_BundleContext.GetResources().ContainsKey(s_Res.Name))
                        {
                            s_BundleContext.RemoveResource(s_Res.Name);
                            p_Writer.WriteLine($"Removed duplicate resource: {s_Res.Name} (Found in {s_DepBndl})");
                            s_RemovedResources++;
                        }
                    }

                    // Chunks
                    var s_BndlChunks = s_Mounter.GetChunksInBundle(s_DepBndl);
                    foreach (var s_Chunk in s_BndlChunks)
                    {
                        if (s_BundleContext.GetChunks().ContainsKey(s_Chunk))
                        {
                            s_BundleContext.RemoveChunk(s_Chunk);
                            p_Writer.WriteLine($"Removed duplicate chunk: {s_Chunk} (Found in {s_DepBndl})");
                            s_RemovedChunks++;
                        }
                    }
                }
                catch (Exception s_Ex)
                {
                    p_Writer.WriteLine($"Warning: Failed to fetch items for dependency bundle '{s_DepBndl}': {s_Ex.Message}");
                }
            }

            p_Writer.WriteLine("Removing duplicate chunks from dependency superbundles...");

            foreach (var s_DepSuperbndl in s_DepSuperbundles)
            {
                try
                {
                    // Chunks
                    var s_SbChunks = s_Mounter.GetChunksInSuperbundle(s_DepSuperbndl);
                    foreach (var s_Chunk in s_SbChunks)
                    {
                        if (s_BundleContext.GetChunks().ContainsKey(s_Chunk))
                        {
                            s_BundleContext.RemoveChunk(s_Chunk);
                            p_Writer.WriteLine($"Removed duplicate chunk: {s_Chunk} (Found in superbundle {s_DepSuperbndl})");
                            s_RemovedChunks++;
                        }
                    }
                }
                catch (Exception s_Ex)
                {
                    p_Writer.WriteLine($"Warning: Failed to fetch items for dependency superbundle '{s_DepSuperbndl}': {s_Ex.Message}");
                }
            }

            p_Writer.WriteLine($"Finished removing duplicates.");
            p_Writer.WriteLine($"Removed {s_RemovedPartitions} partitions, {s_RemovedResources} resources, and {s_RemovedChunks} chunks.");

            return true;
        }
    }
}
