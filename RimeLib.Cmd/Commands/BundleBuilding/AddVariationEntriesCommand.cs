using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Copies into a bundle's mesh variation database the entries and redirect entries of a mounted
    /// game's database whose mesh the bundle ships, and that it has no entry for yet. The game draws a mesh only with an entry for it, so a database converted from another
    /// engine gains the entries of the game's own meshes the bundle ships. What the entries bind is
    /// added with its closure.
    /// </summary>
    [CommandDescription("Copies a mounted game's mesh variation database entries for the meshes this bundle ships into a database of the bundle.")]
    public class AddVariationEntriesCommand : Command
    {
        [CommandArgument(Description = "The bundle's mesh variation database, e.g. levels/mp_prison/mp_prison/meshvariationdb_win32.")]
        public string? Partition { get; set; }

        [CommandArgument(Description = "The game's database to copy from, e.g. levels/mp_subway/mp_subway/meshvariationdb_win32.")]
        public string? Source { get; set; }

        [CommandArgument(Description = "The id of the mounted game.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Partition) || string.IsNullOrWhiteSpace(Source))
            {
                p_Writer.WriteLine("usage: add_variation_entries <partition> <source> [id]");
                return false;
            }

            var s_Bundle = (BundleBuildingContext)p_Context;
            var s_Sb = (SbBuildingContext)s_Bundle.Parent!;
            if (!((BaseContext)s_Sb.Parent!).GetMounters().TryGetValue(Id, out var s_Game) || s_Game.GetEngineType() != s_Sb.EngineType)
            {
                p_Writer.WriteLine($"Id ({Id}) is not a mounted game of this engine.");
                return false;
            }

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Sb.EngineType);
            var s_Rules = EngineInterfaceRegistry.Create<IMeshVariationRules>(s_Sb.EngineType);
            var s_Name = Partition!.ToLowerInvariant();
            var s_Variants = BundlePartitionVariant.All(s_Bundle);
            if (!s_Variants.TryGetValue(s_Name, out var s_Variant))
            {
                p_Writer.WriteLine($"The bundle has no partition '{Partition}'.");
                return false;
            }

            if (!s_Game.TryGetPartition(Source!.ToLowerInvariant(), out var s_Mounted))
            {
                p_Writer.WriteLine($"Game {Id} has no partition '{Source}'.");
                return false;
            }

            if (PartitionClosure.Create(s_Bundle, Id, [], TextWriter.Null) is not { } s_Closure)
            {
                p_Writer.WriteLine($"No game {Id} of this bundle's engine is mounted to add their closure from.");
                return false;
            }

            var s_Database = s_Converter.FromPartitionObject(s_Name, s_Variant);
            var s_SourceDb = s_Converter.FromPartitionObject(Source!.ToLowerInvariant(),
                s_Mounted.Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() != null) ?? s_Mounted.FirstVariant);

            // The meshes the bundle ships itself: a dependency bundle's meshes have their entries
            // there, and a mesh registered twice freezes the client.
            bool Ships(CtrRefBase p_Mesh) => !p_Mesh.IsNull() && s_Game.TryGetPartitionByGuid(p_Mesh.PartitionGuid, out var s_Mesh, out _)
                && s_Variants.ContainsKey(s_Mesh.ToLowerInvariant());

            var s_Known = s_Rules.ReadEntries(s_Database).Select(p_E => (p_E.Mesh.PartitionGuid, p_E.VariationHash))
                .Concat(s_Rules.ReadRedirects(s_Database).Select(p_E => (p_E.Mesh.PartitionGuid, p_E.VariationHash))).ToHashSet();
            List<object> Copied(IEnumerable<(CtrRefBase Mesh, uint VariationHash, object Entry)> p_Entries) =>
                p_Entries.Where(p_E => Ships(p_E.Mesh) && s_Known.Add((p_E.Mesh.PartitionGuid, p_E.VariationHash))).Select(p_E => p_E.Entry).ToList();
            var s_Entries = Copied(s_Rules.ReadEntries(s_SourceDb));
            var s_Redirects = Copied(s_Rules.ReadRedirectEntries(s_SourceDb));
            if (s_Entries.Count + s_Redirects.Count == 0)
            {
                p_Writer.WriteLine($"'{Source}' has no entry for a mesh the bundle ships that '{s_Name}' lacks.");
                return true;
            }

            s_Rules.AddEntries(s_Database, s_Entries, s_Redirects);
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                EngineInterfaceRegistry.Create<IPartitionGenerator>(s_Sb.EngineType).Generate(s_Database, s_Writer);

            // Read it back, so a database that doesn't parse never reaches the bundle.
            var s_Bytes = s_Stream.ToArray();
            var s_Reread = s_Converter.FromPartitionObject(s_Name, new BundlePartitionVariant(new SbBuildingContext.MemoryReader(s_Bytes), s_Bundle.BundleName));
            var s_Expected = s_Rules.ReadEntries(s_Database).Count();
            if (s_Rules.ReadEntries(s_Reread).Count() != s_Expected)
            {
                p_Writer.WriteLine($"The database reads back without its {s_Expected} entries; left as it was.");
                return false;
            }

            s_Bundle.RemovePartition(s_Name);
            s_Bundle.AddRawPartitionBytes(s_Name, s_Bytes);

            var s_Needed = s_Entries.Concat(s_Redirects)
                .SelectMany(p_E => Game.AnalyzeRegistryCommand.References(p_E, p_E.GetType().Name, 0))
                .Select(p_R => p_R.Ref.PartitionGuid).Distinct()
                .Select(p_G => s_Game.TryGetPartitionByGuid(p_G, out var s_N, out _) ? s_N.ToLowerInvariant() : null)
                .OfType<string>().Where(p_N => !s_Bundle.GetPartitions().ContainsKey(p_N))
                .OrderBy(p_N => p_N, StringComparer.Ordinal).ToList();
            s_Closure.AddAll(s_Needed, p_Writer);

            p_Writer.WriteLine($"'{s_Name}' gained {s_Entries.Count} entr(ies) and {s_Redirects.Count} redirect(s) from '{Source}'; " +
                $"{s_Needed.Count} partition(s) they bind added with their closure.");
            return true;
        }
    }
}
