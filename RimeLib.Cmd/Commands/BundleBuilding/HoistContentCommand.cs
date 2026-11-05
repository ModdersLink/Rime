using System;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Adds content that a sub-world reaches to this bundle. A level's main bundle carries some
    /// systems' assets for all of its gamemodes (the UI flow, effects), while each gamemode bundle
    /// carries the rest of what it reaches itself.
    /// </summary>
    [CommandDescription("Adds the partitions of the given types that a sub-world's partition reaches, with their closure.")]
    public class HoistContentCommand : Command
    {
        [CommandArgument(Description = "The sub-world's partition, e.g. levels/mp_subway/rush.")]
        public string? Partition { get; set; }

        [CommandArgument(Description = "Comma-separated primary instance type names; a trailing * matches a prefix, e.g. UI*,EffectBlueprint.")]
        public string? Types { get; set; }

        [CommandArgument(Description = "The id of the mounted game.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbContext.Parent!;
            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_Mounter) || s_Mounter.GetEngineType() != s_SbContext.EngineType)
            {
                p_Writer.WriteLine($"Id ({Id}) is not a mounted game of this engine.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Partition) || !s_Mounter.TryGetPartition(Partition.ToLowerInvariant(), out _))
            {
                p_Writer.WriteLine($"Could not find partition ({Partition}).");
                return false;
            }

            var s_Patterns = (Types ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            bool Matches(string p_Type) => s_Patterns.Any(p_P => p_P.EndsWith('*')
                ? p_Type.StartsWith(p_P[..^1], StringComparison.Ordinal)
                : p_Type == p_P);

            var s_Root = Partition.ToLowerInvariant();
            var s_Closure = new RegistryDeriver(s_Mounter).ReachedContent(s_Root).Closure;
            var s_Hoisted = s_Closure.Partitions
                .Where(p_P => p_P.Key != s_Root && p_P.Value.PrimaryInstance != null && Matches(p_P.Value.PrimaryInstance.GetType().Name))
                .Select(p_P => p_P.Key)
                .Where(p_N => !s_BundleContext.GetPartitions().ContainsKey(p_N))
                .OrderBy(p_N => p_N, StringComparer.Ordinal).ToList();

            if (PartitionClosure.Create((BundleBuildingContext)p_Context, Id, [], TextWriter.Null) is not { } s_Adder)
            {
                p_Writer.WriteLine($"No game {Id} of this bundle's engine is mounted to add their closure from.");
                return false;
            }

            s_Adder.AddAll(s_Hoisted, p_Writer);

            p_Writer.WriteLine($"{s_Hoisted.Count} partition(s) of '{Partition}' matching '{Types}' not yet in the bundle, added unless a dependency carries them.");
            return true;
        }
    }
}
