using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Serialization;

namespace RimeLib.Cmd
{
    /// <summary>
    /// The partitions a level partition (LevelData or SubWorldData) reaches through references, with
    /// the registries it carries. Index lists (registries, mesh variation databases) are not followed,
    /// so what they list belongs to the closure only when content references it too.
    /// </summary>
    internal class LevelClosure
    {
        public string Root { get; }

        /// <summary>Closure partitions by name, parsed.</summary>
        public Dictionary<string, DatabasePartitionBase> Partitions { get; } = new(StringComparer.OrdinalIgnoreCase);

        /// <summary>For each closure partition but the root, the partition that first referenced it.</summary>
        public Dictionary<string, string> ReachedFrom { get; } = new(StringComparer.OrdinalIgnoreCase);

        /// <summary>The registries of the root: embedded ones, or (BF4) the network registry partition.</summary>
        public List<(string Kind, List<CtrRefBase> Entries)> Registries { get; } = new();

        private LevelClosure(string p_Root)
        {
            Root = p_Root;
        }

        public IEnumerable<DataContainerBase> Instances => Partitions.Values.SelectMany(p_P => p_P.Instances).Where(p_I => p_I != null);

        /// <param name="p_GetPartition">Looks a partition up by lowercase name.</param>
        /// <param name="p_Walk">False to read only the root and its registries, not what it references.</param>
        public static LevelClosure Build(Func<string, IObjectVariant?> p_GetPartition, AssetReferenceScanner p_Scanner, ILevelIndexes p_Indexes,
            Func<string, DatabasePartitionBase?> p_Parse, string p_Root, string? p_RegistryPartition = null, bool p_Walk = true)
        {
            var s_Closure = new LevelClosure(p_Root.ToLowerInvariant());
            var s_Seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { s_Closure.Root };
            var s_Level = new List<string> { s_Closure.Root };

            while (s_Level.Count > 0)
            {
                // Partitions scan independently: each level of the walk is scanned in parallel, then
                // taken in order, so the result is that of walking them one at a time.
                var s_Scanned = new AssetReferenceScanner.References?[s_Level.Count];
                var s_Current = s_Level;
                System.Threading.Tasks.Parallel.For(0, s_Current.Count, i =>
                {
                    if (p_GetPartition(s_Current[i]) is { } s_Variant)
                        s_Scanned[i] = p_Scanner.ScanPartition(s_Current[i], s_Variant, p_I => p_Indexes.GetEmbeddedIndexes(p_I).Any());
                });

                s_Level = new List<string>();
                for (var s_Index = 0; s_Index < s_Current.Count; s_Index++)
                {
                    var s_Name = s_Current[s_Index];
                    if (s_Scanned[s_Index] is not { Parsed: not null } s_References)
                        continue;

                    s_Closure.Partitions[s_Name] = s_References.Parsed;

                    if (s_Name == s_Closure.Root)
                    {
                        foreach (var s_Instance in s_References.Parsed.Instances)
                        foreach (var (s_Kind, s_Entries) in p_Indexes.GetEmbeddedIndexes(s_Instance))
                            s_Closure.Registries.Add((s_Kind, s_Entries.ToList()));
                    }

                    if (!p_Walk || p_Indexes.GetPartitionIndexKind(s_References.Parsed.PrimaryInstance) != null)
                        continue;

                    foreach (var s_Next in s_References.Partitions)
                    {
                        if (!s_Seen.Add(s_Next))
                            continue;

                        s_Closure.ReachedFrom[s_Next] = s_Name;
                        s_Level.Add(s_Next);
                    }
                }
            }

            // Registries that are partitions of their own (BF4).
            if (s_Closure.Registries.Count == 0)
            {
                var s_RegistryName = (p_RegistryPartition ?? $"{s_Closure.Root}_networkregistry_win32").ToLowerInvariant();
                if (p_Parse(s_RegistryName) is { } s_Registry && p_Indexes.GetPartitionIndexKind(s_Registry.PrimaryInstance) is { } s_Kind)
                    s_Closure.Registries.Add((s_Kind, p_Indexes.GetIndexEntries(s_Registry).ToList()));
            }

            return s_Closure;
        }
    }
}
