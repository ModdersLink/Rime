using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds an existing partition and its whole dependency closure, skipping whatever the dependency bundles already carry.")]
    internal class ReferenceExistingPartitionCommand : Command
    {
        [CommandArgument(Description = "The name of the partition.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.", Optional = true)]
        public int Id { get; set; } = 1;

        [CommandArgument(Description = "Fail when a reference cannot be resolved. An unresolved reference is a crash at load, not a missing detail, so this defaults to true.", Optional = true)]
        public bool Strict { get; set; } = true;

        [CommandArgument(Description = "Comma-separated partition name prefixes to leave out of the closure, e.g. 'characters/'.", Optional = true)]
        public string? SkipPrefixes { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("usage: reference_existing_partition <name> [id] [strict] [skip_prefixes]");
                return false;
            }

            var s_Prefixes = string.IsNullOrWhiteSpace(SkipPrefixes)
                ? Array.Empty<string>()
                : SkipPrefixes!.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            if (PartitionClosure.Create((BundleBuildingContext)p_Context, Id, s_Prefixes, p_Writer) is not { } s_Closure)
                return false;

            var s_Result = s_Closure.Add(Name!);

            p_Writer.WriteLine($"Closure of '{Name}': +{s_Result.Partitions} partition(s), +{s_Result.Resources} resource(s), +{s_Result.Chunks} chunk(s), {s_Result.Skipped} already covered{(s_Result.Walked > 0 ? $", {s_Result.Walked} of those walked" : "")}.");

            if (s_Result.Meshes > 0)
                p_Writer.WriteLine($"{s_Result.Meshes} mesh(es) added, with the textures their MeshVariationDatabase entries bind.");

            if (s_Result.Unresolved.Count == 0)
                return true;

            p_Writer.WriteLine($"{s_Result.Unresolved.Count} unresolved reference(s):");
            foreach (var s_Line in s_Result.Unresolved)
                p_Writer.WriteLine($"  {s_Line}");

            if (!Strict)
                return true;

            p_Writer.WriteLine("Refusing to continue. Mount the superbundle that holds them, or pass strict=false to build anyway.");
            return false;
        }
    }
}
