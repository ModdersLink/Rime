using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Mesh;
using RimeLib.Serialization;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Derives a level partition's registries from its closure with the engine's registry rules and
    /// compares them with the shipped ones, entry by entry.
    /// </summary>
    [CommandDescription("Derives the registries of a level partition (LevelData or SubWorldData) from its closure and compares them with the shipped registries.")]
    public class DeriveRegistryCommand : Command
    {
        [CommandArgument(Description = "The level partition, e.g. levels/mp_subway/rush.")]
        public string? Partition { get; set; }

        [CommandArgument(Description = "Where to write the JSON report of every missing and extra entry.", Optional = true)]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "Network registry partition to compare with when the registries are not embedded (BF4). Default: <partition>_networkregistry_win32.", Optional = true)]
        public string? RegistryPartition { get; set; }

        private IEngineMounter m_Mounter = null!;
        private IPartitionConverter m_Converter = null!;
        private AssetReferenceScanner m_Scanner = null!;
        private ILevelIndexes m_Indexes = null!;
        private IRegistryRules m_Rules = null!;

        private readonly Dictionary<string, (string Partition, DataContainerBase Instance)> m_Instances = new();
        private readonly Dictionary<GUID, string?> m_PartitionNames = new();
        private readonly Dictionary<string, GUID> m_KeyPartitions = new();
        private readonly Dictionary<string, HashSet<string>> m_ReferencedBy = new();
        private readonly Dictionary<string, List<string>> m_ReferencesOf = new();
        private readonly Dictionary<string, string> m_ReachedFrom = new(StringComparer.OrdinalIgnoreCase);

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Partition))
            {
                p_Writer.WriteLine("usage: derive_registry <partition> [destination.json] [registry_partition]");
                return false;
            }

            m_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Engine = m_Mounter.GetEngineType();
            m_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Engine);
            m_Indexes = EngineInterfaceRegistry.Create<ILevelIndexes>(s_Engine);
            m_Rules = EngineInterfaceRegistry.Create<IRegistryRules>(s_Engine);
            m_Scanner = new AssetReferenceScanner(m_Mounter, m_Converter, TryCreate<ITextureConverter>(s_Engine), TryCreate<IMeshConverter>(s_Engine));

            var s_Root = Partition!.ToLowerInvariant();
            if (!m_Mounter.TryGetPartition(s_Root, out _))
            {
                p_Writer.WriteLine($"No partition named '{Partition}'.");
                return false;
            }

            var s_Closure = BuildClosure(s_Root, RegistryPartition);
            if (s_Closure.Registries.Count == 0)
            {
                p_Writer.WriteLine($"No registry found for {s_Root}.");
                return false;
            }

            var s_Derived = Derive(s_Closure);
            var s_Own = s_Derived.ToDictionary(p_P => p_P.Key, p_P => p_P.Value.ToList());
            var s_PerSubWorld = new Dictionary<string, Dictionary<string, List<string>>>();
            p_Writer.WriteLine($"{s_Root}: closure of {s_Closure.Partitions.Count} partitions.");

            // The level's own registry also lists what its sub-worlds' registries list, as far as it
            // ships in a bundle loaded with the level.
            var s_LevelBundles = m_Rules.GetLevelBundles(s_Root).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var s_SubWorlds = s_Closure.Instances.SelectMany(m_Rules.GetSubWorldBundles)
                .Select(p_B => p_B.ToLowerInvariant()).Where(p_B => p_B != s_Root).Distinct().ToList();
            foreach (var s_SubWorld in s_SubWorlds)
            {
                if (!m_Mounter.TryGetPartition(s_SubWorld, out _))
                {
                    p_Writer.WriteLine($"  sub-world {s_SubWorld}: no partition of that name.");
                    continue;
                }

                var s_SubClosure = BuildClosure(s_SubWorld, null);
                var s_SubDerived = Derive(s_SubClosure);
                s_PerSubWorld[s_SubWorld] = s_SubDerived;
                p_Writer.WriteLine($"  sub-world {s_SubWorld}: closure of {s_SubClosure.Partitions.Count} partitions, {s_SubDerived.Values.Sum(p_L => p_L.Count)} entries.");

                foreach (var (s_Kind, s_Entries) in s_SubDerived)
                {
                    if (!s_Derived.TryGetValue(s_Kind, out var s_Into))
                        s_Derived[s_Kind] = s_Into = new List<string>();
                    var s_Have = s_Into.ToHashSet();
                    s_Into.AddRange(s_Entries.Where(p_E => s_Have.Add(p_E) && ShipsIn(p_E, s_LevelBundles)));
                }
            }

            var s_Report = new List<object>();
            foreach (var (s_Kind, s_Entries) in s_Closure.Registries)
            {
                var s_Shipped = s_Entries.Select(p_E => Key(p_E.PartitionGuid, p_E.InstanceId)).ToList();
                var s_Ours = s_Derived.GetValueOrDefault(s_Kind) ?? new List<string>();
                var s_ShippedSet = s_Shipped.ToHashSet();
                var s_OursSet = s_Ours.ToHashSet();

                var s_Missing = s_Shipped.Where(p_K => !s_OursSet.Contains(p_K)).Distinct().Select(Describe).ToList();
                var s_Extra = s_Ours.Where(p_K => !s_ShippedSet.Contains(p_K)).Select(Describe).ToList();

                p_Writer.WriteLine();
                p_Writer.WriteLine($"--- {s_Kind}: shipped {s_Shipped.Count} ({s_ShippedSet.Count} distinct), derived {s_Ours.Count}, matching {s_ShippedSet.Count(s_OursSet.Contains)}");
                WriteGroups(p_Writer, "missing", s_Missing);
                WriteGroups(p_Writer, "extra", s_Extra);

                // How far the order agrees: entries of both lists, in shipped order versus ours.
                var s_Common = s_Shipped.Where(s_OursSet.Contains).Distinct().ToList();
                var s_OurOrder = s_Ours.Where(s_ShippedSet.Contains).ToList();
                p_Writer.WriteLine($"    order: {(s_Common.SequenceEqual(s_OurOrder) ? "same" : $"differs ({s_Common.Zip(s_OurOrder).Count(p_P => p_P.First != p_P.Second)} positions)")}");

                s_Report.Add(new { Registry = s_Kind, Shipped = s_Shipped.Count, Derived = s_Ours.Count, Missing = s_Missing.Select(Detail).ToList(), Extra = s_Extra.Select(Detail).ToList() });
            }

            if (Destination != null)
            {
                File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
                {
                    Partition = s_Root,
                    Registries = s_Report,
                    Shipped = s_Closure.Registries.ToDictionary(p_R => p_R.Kind, p_R => p_R.Entries.Select(p_E => Key(p_E.PartitionGuid, p_E.InstanceId)).ToList()),
                    Own = s_Own,
                    SubWorlds = s_PerSubWorld,
                    Names = m_KeyPartitions.Keys.ToDictionary(p_K => p_K, p_K =>
                    {
                        var (s_Type, s_Name, _) = Describe(p_K);
                        var s_Bundles = m_Mounter.TryGetPartition(s_Name, out var s_P) ? s_P.Variants.Select(p_V => p_V.GetContainedBundle()?.ToString()).ToList() : new List<string?>();
                        return new { Type = s_Type, Partition = s_Name, Bundles = s_Bundles };
                    }),
                }, Formatting.Indented));
                p_Writer.WriteLine($"Report written to {Destination.FullName}.");
            }

            return true;
        }

        private bool ShipsIn(string p_Key, HashSet<string> p_Bundles)
        {
            var (_, s_Name, _) = Describe(p_Key);
            return m_Mounter.TryGetPartition(s_Name, out var s_Partition) &&
                s_Partition.Variants.Any(p_V => p_V.GetContainedBundle() is { } s_Bundle && p_Bundles.Contains(s_Bundle));
        }

        private LevelClosure BuildClosure(string p_Root, string? p_RegistryPartition)
        {
            var s_Closure = LevelClosure.Build(m_Mounter, m_Scanner, m_Indexes, Parse, p_Root, p_RegistryPartition);
            foreach (var (s_To, s_From) in s_Closure.ReachedFrom)
                m_ReachedFrom.TryAdd(s_To, s_From);
            foreach (var (s_Name, s_Parsed) in s_Closure.Partitions)
            {
                foreach (var s_Instance in s_Parsed.Instances)
                {
                    if (s_Instance == null || m_Indexes.GetEmbeddedIndexes(s_Instance).Any())
                        continue;
                    var s_Targets = m_ReferencesOf[Key(s_Parsed.PartitionGuid, s_Instance.InstanceId)] = new List<string>();
                    foreach (var (s_Field, s_Ref) in AnalyzeRegistryCommand.References(s_Instance, s_Instance.GetType().Name, 0))
                    {
                        var s_Target = Key(s_Ref.PartitionGuid, s_Ref.InstanceId);
                        if (!m_Rules.IsDescriptionOnly(s_Instance))
                            s_Targets.Add(s_Target);
                        if (!m_ReferencedBy.TryGetValue(s_Target, out var s_By))
                            m_ReferencedBy[s_Target] = s_By = new HashSet<string>();
                        s_By.Add($"{s_Name} {s_Field}");
                    }
                }

                m_PartitionNames[s_Parsed.PartitionGuid] = s_Name;
                foreach (var s_Instance in s_Parsed.Instances)
                {
                    if (s_Instance != null)
                        m_Instances[Key(s_Parsed.PartitionGuid, s_Instance.InstanceId)] = (s_Name, s_Instance);
                }
            }

            return s_Closure;
        }

        /// <summary>The entries the rules give for a closure, per registry, in closure order.</summary>
        private Dictionary<string, List<string>> Derive(LevelClosure p_Closure)
        {
            var s_Result = new Dictionary<string, List<string>>();
            var s_Seen = new HashSet<(string, string)>();

            // Only what the level reaches: a partition can be in the closure for one instance (a
            // flattened copy of a prefab borrowing its tracks) while the rest of it is unused. A
            // partition whose primary instance is reached counts whole, since destruction prefabs
            // place loose reference objects that nothing in the partition references. The registries
            // themselves are not content (they have no outgoing references here), nor are the values
            // an interface descriptor holds.
            var s_ByPartition = p_Closure.Partitions.Values.Where(p_P => p_P.PrimaryInstance != null)
                .ToDictionary(p_P => Key(p_P.PartitionGuid, p_P.PrimaryInstance.InstanceId),
                    p_P => p_P.Instances.Where(p_I => p_I != null).Select(p_I => Key(p_P.PartitionGuid, p_I.InstanceId)).ToList());
            var s_Reached = new HashSet<string>();
            var s_Queue = new Queue<string>();

            void Reach(string p_Key)
            {
                if (!s_Reached.Add(p_Key))
                    return;

                s_Queue.Enqueue(p_Key);
                foreach (var s_Sibling in s_ByPartition.GetValueOrDefault(p_Key) ?? new List<string>())
                    Reach(s_Sibling);
            }

            if (p_Closure.Partitions.TryGetValue(p_Closure.Root, out var s_RootPartition) && s_RootPartition.PrimaryInstance != null)
                Reach(Key(s_RootPartition.PartitionGuid, s_RootPartition.PrimaryInstance.InstanceId));

            while (s_Queue.Count > 0)
            {
                foreach (var s_Next in m_ReferencesOf.GetValueOrDefault(s_Queue.Dequeue()) ?? new List<string>())
                    Reach(s_Next);
            }

            var s_Content = p_Closure.Partitions.Values
                .SelectMany(p_P => p_P.Instances.Where(p_I => p_I != null && s_Reached.Contains(Key(p_P.PartitionGuid, p_I.InstanceId))))
                .Where(p_I => !m_Indexes.GetEmbeddedIndexes(p_I).Any()).ToList();

            foreach (var (s_Kind, s_Entry) in m_Rules.GetEntries(s_Content, Resolve))
            {
                var s_Key = Key(s_Entry.PartitionGuid, s_Entry.InstanceId);
                if (!s_Seen.Add((s_Kind, s_Key)))
                    continue;

                if (!s_Result.TryGetValue(s_Kind, out var s_List))
                    s_Result[s_Kind] = s_List = new List<string>();
                s_List.Add(s_Key);
            }

            return s_Result;
        }

        private DataContainerBase? Resolve(CtrRefBase p_Ref)
        {
            if (p_Ref.IsNull())
                return null;

            return m_Instances.TryGetValue(Key(p_Ref.PartitionGuid, p_Ref.InstanceId), out var s_Found) ? s_Found.Instance : p_Ref.Get();
        }

        /// <summary>"type partition", parsing the partition when it is outside every closure seen.</summary>
        private (string Type, string Partition, string Key) Describe(string p_Key)
        {
            if (!m_Instances.TryGetValue(p_Key, out var s_Found))
            {
                var s_Guid = m_KeyPartitions[p_Key];
                if (!m_PartitionNames.TryGetValue(s_Guid, out var s_Name))
                {
                    s_Name = m_Mounter.TryGetPartitionByGuid(s_Guid, out var s_Resolved, out _) ? s_Resolved.ToLowerInvariant() : null;
                    m_PartitionNames[s_Guid] = s_Name;
                    if (s_Name != null && Parse(s_Name) is { } s_Parsed)
                    {
                        foreach (var s_Instance in s_Parsed.Instances)
                        {
                            if (s_Instance != null)
                                m_Instances.TryAdd(Key(s_Parsed.PartitionGuid, s_Instance.InstanceId), (s_Name, s_Instance));
                        }
                    }
                }

                if (!m_Instances.TryGetValue(p_Key, out s_Found))
                    return ("unresolved", s_Name ?? p_Key, p_Key);
            }

            return (s_Found.Instance.GetType().Name, s_Found.Partition, p_Key);
        }

        private List<string> Chain(string p_Partition)
        {
            var s_Chain = new List<string>();
            for (var s_At = p_Partition; m_ReachedFrom.TryGetValue(s_At, out var s_From) && s_Chain.Count < 12; s_At = s_From)
                s_Chain.Add(s_From);
            return s_Chain;
        }

        private object Detail((string Type, string Partition, string Key) p_Entry)
        {
            var s_Instance = m_Instances.TryGetValue(p_Entry.Key, out var s_Found) ? s_Found.Instance : null;
            var s_Flags = s_Instance?.GetType().GetProperties().Where(p_P => p_P.PropertyType == typeof(bool))
                .Select(p_P => $"{p_P.Name}={p_P.GetValue(s_Instance)}");
            return new
            {
                p_Entry.Type,
                p_Entry.Partition,
                p_Entry.Key,
                Flags = s_Flags == null ? null : string.Join(" ", s_Flags),
                ReferencedBy = m_ReferencedBy.GetValueOrDefault(p_Entry.Key)?.Take(10).ToList(),
                ReachedFrom = Chain(p_Entry.Partition),
            };
        }

        private static void WriteGroups(TextWriter p_Writer, string p_Label, List<(string Type, string Partition, string Key)> p_Entries)
        {
            if (p_Entries.Count == 0)
                return;

            p_Writer.WriteLine($"    {p_Label}: {p_Entries.Count}");
            foreach (var s_Group in p_Entries.GroupBy(p_E => p_E.Type).OrderByDescending(p_G => p_G.Count()))
            {
                var s_Examples = s_Group.Select(p_E => p_E.Partition).Distinct().Take(4);
                p_Writer.WriteLine($"      {s_Group.Key,-40} {s_Group.Count(),5}  e.g. {string.Join(", ", s_Examples)}");
            }
        }

        private DatabasePartitionBase? Parse(string p_Name)
        {
            if (!m_Mounter.TryGetPartition(p_Name, out var s_Mounted))
                return null;

            try
            {
                return m_Converter.FromPartitionObject(p_Name, s_Mounted.FirstVariant);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string Key(GUID p_Partition, DataContainerId p_Instance)
        {
            var s_Key = $"{p_Partition}/{p_Instance}".ToLowerInvariant();
            m_KeyPartitions.TryAdd(s_Key, p_Partition);
            return s_Key;
        }

        private static T? TryCreate<T>(EngineType p_Engine) where T : class, IEngineInterface
        {
            try
            {
                return EngineInterfaceRegistry.Create<T>(p_Engine);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
