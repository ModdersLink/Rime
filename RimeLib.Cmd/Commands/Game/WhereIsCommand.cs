using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Which bundle and superbundle a partition or resource actually lives in.
    ///
    /// What is available at runtime is decided by the bundles a level mounts, and nothing else here
    /// answers "where does this come from". Without it, finding the shaderdb that holds a given
    /// shader means guessing names per level -- which fails exactly where a level draws with another
    /// level's assets, and that is common (MP_001's terrain is SP_Sniper's, its wire lights are
    /// COOP_009's).
    /// </summary>
    [CommandDescription("Reports the bundle and superbundle a partition or resource is contained in.")]
    public class WhereIsCommand : Command
    {
        [CommandArgument(Description = "Partition or resource name, e.g. levels/coop_009/architecture/wirelightsblink")]
        public string? Name { get; set; }

        // Written to a FILE, not just the console: the REPL's output is consumed by whatever is
        // driving it, so a console-only answer cannot be read back by a tool.
        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("Usage: where_is <partition-or-resource-name>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Found = false;
            var s_Rows = new System.Collections.Generic.List<object>();

            if (s_Mounter.TryGetPartition(Name!, out var s_Partition))
            {
                foreach (var s_Variant in s_Partition.Variants)
                {
                    p_Writer.WriteLine($"partition\t{s_Variant.GetContainedSuperbundle()}\t{s_Variant.GetContainedBundle() ?? "(none)"}");
                    s_Rows.Add(new { kind = "partition", superbundle = s_Variant.GetContainedSuperbundle(), bundle = s_Variant.GetContainedBundle() });
                    s_Found = true;
                }
            }

            if (s_Mounter.TryGetResource(Name!, out var s_Resource))
            {
                foreach (var s_Variant in s_Resource.Variants)
                {
                    p_Writer.WriteLine($"resource\t{s_Variant.GetContainedSuperbundle()}\t{s_Variant.GetContainedBundle() ?? "(none)"}");
                    s_Rows.Add(new { kind = "resource", superbundle = s_Variant.GetContainedSuperbundle(), bundle = s_Variant.GetContainedBundle() });
                    s_Found = true;
                }
            }

            if (!s_Found)
                p_Writer.WriteLine($"Not mounted: {Name}");

            if (Destination != null)
                File.WriteAllText(Destination.FullName,
                    Newtonsoft.Json.JsonConvert.SerializeObject(new { name = Name, found = s_Found, places = s_Rows }));

            return s_Found;
        }
    }
}
