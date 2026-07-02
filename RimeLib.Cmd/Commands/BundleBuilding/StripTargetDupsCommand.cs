using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Target-aware dedup: removes from this bundle every partition (and its same-named resources) that is ALREADY CONTAINED in one of the given game bundles (comma-separated, e.g. win32/levels/mp_017/mp_017,win32/levels/mp_017/cql = the target level's base + played gamemode). Those partitions load from the level itself, so shipping a copy DUPLICATES the partition guid at load — harmless for most, but a duplicated MESH whose variation table is registered twice (level MVDB + ours) HANGS the client (the m1a2_screen_mesh freeze). Also shrinks the bundle. Prints STRIP-DUP lines. Run AFTER resolve, BEFORE mvdb_add_*.")]
    internal class StripTargetDupsCommand : Command
    {
        [CommandArgument(Description = "Comma-separated bundle names whose contents should not be shipped (target base + gamemode).")]
        public string? Bundles { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = p_Context as BundleBuildingContext;
            if (s_Ctx == null || string.IsNullOrWhiteSpace(Bundles))
            {
                p_Writer.WriteLine("usage (bundle ctx): strip_target_dups <bundle1,bundle2,...>");
                return false;
            }

            var s_SbCtx = (SbBuildingContext)s_Ctx.Parent!;
            var s_BaseCtx = (BaseContext)s_SbCtx.Parent!;
            var s_Mounter = s_BaseCtx.GetMounters().Values.FirstOrDefault();
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("strip_target_dups: no mounter found.");
                return false;
            }

            var s_Targets = new HashSet<string>(
                Bundles.Split(',').Select(p_B => p_B.Trim().ToLowerInvariant()).Where(p_B => p_B.Length > 0));

            // set of partition names contained in the target bundles
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
                p_Writer.WriteLine("strip_target_dups: target bundles yielded 0 partitions — nothing stripped (check names).");
                return false;
            }

            int s_Parts = 0, s_Res = 0;
            foreach (var s_Kv in s_Ctx.GetPartitions().ToList())
            {
                var s_Name = s_Kv.Key.ToLowerInvariant();
                if (!s_Contained.Contains(s_Name))
                    continue;
                s_Ctx.RemovePartition(s_Kv.Key);
                s_Parts++;
                p_Writer.WriteLine($"STRIP-DUP {s_Kv.Key}");
            }
            // resources belonging to stripped partitions (MeshSet/HavokPhysicsData/DxTexture share the
            // partition's name or prefix it, e.g. .../m1a2_screen_mesh + ..._physics_0_win32).
            foreach (var s_Kv in s_Ctx.GetResources().ToList())
            {
                var s_Name = s_Kv.Key.ToLowerInvariant();
                if (s_Contained.Contains(s_Name))
                {
                    s_Ctx.RemoveResource(s_Kv.Key);
                    s_Res++;
                }
            }

            p_Writer.WriteLine($"strip_target_dups: removed {s_Parts} partition(s) + {s_Res} resource(s) already contained in [{string.Join(", ", s_Targets)}].");
            return true;
        }
    }
}
