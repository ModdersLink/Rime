using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Strips the bundle down to one EBX partition, dropping every other partition plus all resources and chunks. Turns a resolved closure bundle into a small sidecar.")]
    public class KeepOnlyPartitionCommand : Command
    {
        // The closure had to be resolved for generate_registry_container to enumerate the guids, but
        // the emitted SubWorldData references the real mesh, MVDB and blueprint partitions by guid,
        // and those ship in a separate bundle that loads alongside this one. Referencing by guid means
        // the sidecar needs no chunks or resources of its own, so dropping them leaves a bundle the
        // engine can realize on its own terms.
        [CommandArgument(Description = "The one partition name to keep, e.g. levels/vehmenu/m1abrams.")]
        public string? Name { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("name is required.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;

            var s_Keep = Name!.Trim();
            var s_PartitionNames = s_BundleContext.GetPartitions().Select(p_P => p_P.Key).ToList();
            if (!s_PartitionNames.Any(p_N => string.Equals(p_N, s_Keep, StringComparison.OrdinalIgnoreCase)))
            {
                p_Writer.WriteLine($"keep_only_partition: partition '{s_Keep}' is not in this bundle. Aborting.");
                return false;
            }

            var s_Partitions = 0;
            foreach (var s_Name in s_PartitionNames)
            {
                if (string.Equals(s_Name, s_Keep, StringComparison.OrdinalIgnoreCase)) continue;
                s_BundleContext.RemovePartition(s_Name);
                s_Partitions++;
            }

            var s_Resources = s_BundleContext.GetResources().Select(p_R => p_R.Key).ToList();
            foreach (var s_Name in s_Resources)
                s_BundleContext.RemoveResource(s_Name);

            var s_Chunks = s_BundleContext.GetChunks().Select(p_C => p_C.Key).ToList();
            foreach (var s_Id in s_Chunks)
                s_BundleContext.RemoveChunk(s_Id);

            p_Writer.WriteLine($"keep_only_partition '{s_Keep}': removed {s_Partitions} partition(s), {s_Resources.Count} resource(s), {s_Chunks.Count} chunk(s).");
            return true;
        }
    }
}
