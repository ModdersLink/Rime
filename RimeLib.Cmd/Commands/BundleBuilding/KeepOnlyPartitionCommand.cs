using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Strips the bundle down to a SINGLE EBX partition: removes EVERY other partition plus " +
        "ALL resources and chunks. Use to turn a fully-resolved closure bundle (needed so generate_registry_container " +
        "could enumerate the guids) into a tiny sidecar carrying ONLY the emitted SubWorldData partition, which " +
        "references the real mesh/MVDB/blueprint partitions BY GUID (they live in a separate bundle that is loaded/" +
        "prepended alongside). A SubWorld that references-by-guid needs no chunks/resources of its own, so dropping " +
        "them yields a self-contained sub-level bundle the engine can unambiguously SWROD-realize (feeding its " +
        "registryContainer -> the load-time mesh-variation index).")]
    public class KeepOnlyPartitionCommand : Command
    {
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
            var s_PartNames = s_BundleContext.GetPartitions().Select(p_P => p_P.Key).ToList();
            if (!s_PartNames.Any(p_N => string.Equals(p_N, s_Keep, StringComparison.OrdinalIgnoreCase)))
            {
                p_Writer.WriteLine($"keep_only_partition: partition '{s_Keep}' is not in this bundle (nothing kept). Aborting.");
                return false;
            }

            int s_RemovedP = 0, s_RemovedR = 0, s_RemovedC = 0;
            foreach (var s_N in s_PartNames)
            {
                if (string.Equals(s_N, s_Keep, StringComparison.OrdinalIgnoreCase)) continue;
                s_BundleContext.RemovePartition(s_N);
                s_RemovedP++;
            }

            foreach (var s_R in s_BundleContext.GetResources().Select(p_R => p_R.Key).ToList())
            {
                s_BundleContext.RemoveResource(s_R);
                s_RemovedR++;
            }

            foreach (var s_C in s_BundleContext.GetChunks().Select(p_C => p_C.Key).ToList())
            {
                s_BundleContext.RemoveChunk(s_C);
                s_RemovedC++;
            }

            p_Writer.WriteLine($"keep_only_partition '{s_Keep}': removed {s_RemovedP} partition(s), {s_RemovedR} resource(s), {s_RemovedC} chunk(s). Bundle now holds 1 partition.");
            return true;
        }
    }
}
