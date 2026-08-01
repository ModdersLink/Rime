using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Removes every partition, and the resources named after it, that the given game bundles already contain. A mesh registered twice, by the level's MVDB and by ours, hangs the client.")]
    internal class StripTargetDupsCommand : Command
    {
        // Those partitions load from the level itself, so shipping a copy duplicates the partition
        // guid at load. That is harmless for most of them, and it also shrinks the bundle, but a
        // duplicated mesh is not: its variation table gets registered twice, once by the level's MVDB
        // and once by ours, and the client freezes.
        //
        // Run this after the resolve commands and before mvdb_add_all or mvdb_add_entry, so the MVDB
        // is built from what actually ships.
        [CommandArgument(Description = "Comma-separated bundle names whose contents should not be shipped.")]
        public string? Bundles { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = p_Context as BundleBuildingContext;
            if (s_BundleContext == null || string.IsNullOrWhiteSpace(Bundles))
            {
                p_Writer.WriteLine("usage (bundle ctx): strip_target_dups <bundle1,bundle2,...>");
                return false;
            }

            var s_SbBuildingContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbBuildingContext.Parent!;
            var s_Mounter = s_BaseContext.GetMounters().Values.FirstOrDefault();
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("strip_target_dups: no mounter found.");
                return false;
            }

            var s_Targets = new HashSet<string>(
                Bundles.Split(',').Select(p_B => p_B.Trim().ToLowerInvariant()).Where(p_B => p_B.Length > 0));

            var s_Contained = new HashSet<string>();
            foreach (var s_Bundle in s_Targets)
            {
                try
                {
                    foreach (var s_Name in s_Mounter.GetPartitionsInBundle(s_Bundle))
                        s_Contained.Add(s_Name.ToLowerInvariant());
                }
                catch
                {
                    p_Writer.WriteLine($"strip_target_dups: WARN could not enumerate bundle '{s_Bundle}' (not mounted / wrong name?)");
                }
            }

            if (s_Contained.Count == 0)
            {
                p_Writer.WriteLine("strip_target_dups: target bundles yielded 0 partitions, nothing stripped (check names).");
                return false;
            }

            int s_PartitionCount = 0, s_ResourceCount = 0;
            foreach (var s_Kv in s_BundleContext.GetPartitions().ToList())
            {
                if (!s_Contained.Contains(s_Kv.Key.ToLowerInvariant()))
                    continue;

                s_BundleContext.RemovePartition(s_Kv.Key);
                s_PartitionCount++;
                p_Writer.WriteLine($"STRIP-DUP {s_Kv.Key}");
            }

            // A MeshSet, HavokPhysicsData or DxTexture resource shares its partition's name.
            foreach (var s_Kv in s_BundleContext.GetResources().ToList())
            {
                if (!s_Contained.Contains(s_Kv.Key.ToLowerInvariant()))
                    continue;

                s_BundleContext.RemoveResource(s_Kv.Key);
                s_ResourceCount++;
            }

            p_Writer.WriteLine($"strip_target_dups: removed {s_PartitionCount} partition(s) and {s_ResourceCount} resource(s) already contained in [{string.Join(", ", s_Targets)}].");
            return true;
        }
    }
}
