using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Mesh;
using RimeLib.Serialization;
using RimeLib.Texture;

namespace RimeLib.Cmd
{
    /// <summary>
    /// Derives a level partition's registries with the engine's <see cref="IRegistryRules"/>: from the
    /// content the level reaches (Frostbite 2), or from everything its bundle ships (Frostbite 2013.2).
    /// Partitions are read from an optional override first (a bundle being built), then from the
    /// mounted game.
    /// </summary>
    internal class RegistryDeriver
    {
        public IEngineMounter Mounter { get; }
        public IRegistryRules Rules { get; }

        /// <summary>Every instance parsed so far, by key, with its partition name.</summary>
        public Dictionary<string, (string Partition, DataContainerBase Instance)> Instances { get; } = new();

        /// <summary>For each instance key, the "partition Type.Field" places that reference it.</summary>
        public Dictionary<string, HashSet<string>> ReferencedBy { get; } = new();

        /// <summary>For each closure partition, the partition that first referenced it.</summary>
        public Dictionary<string, string> ReachedFrom { get; } = new(StringComparer.OrdinalIgnoreCase);

        public Dictionary<GUID, string?> PartitionNames { get; } = new();

        private readonly IPartitionConverter m_Converter;
        private readonly ILevelIndexes m_Indexes;
        private readonly AssetReferenceScanner m_Scanner;
        private readonly Func<string, IObjectVariant?>? m_Override;
        private readonly IEnumerable<string>? m_OwnBundlePartitions;
        private readonly Dictionary<string, CtrRefBase> m_KeyReferences = new();
        private readonly Dictionary<string, List<string>> m_ReferencesOf = new();
        private readonly Dictionary<string, List<string>> m_ReferrersOf = new();

        /// <summary>The instances (by key) an instance references, from the closures read so far.</summary>
        public IReadOnlyList<string> ReferencesOf(string p_Key) => m_ReferencesOf.GetValueOrDefault(p_Key) ?? (IReadOnlyList<string>)Array.Empty<string>();

        /// <summary>The instances (by key) that reference an instance, from the closures read so far.</summary>
        public IReadOnlyList<string> ReferrersOf(string p_Key) => m_ReferrersOf.GetValueOrDefault(p_Key) ?? (IReadOnlyList<string>)Array.Empty<string>();

        /// <param name="p_Override">Partitions to read instead of the mounted ones, by lowercase name.</param>
        /// <param name="p_OwnBundlePartitions">The partitions of the level's bundle, when not the mounted bundle.</param>
        public RegistryDeriver(IEngineMounter p_Mounter, Func<string, IObjectVariant?>? p_Override = null, IEnumerable<string>? p_OwnBundlePartitions = null)
        {
            Mounter = p_Mounter;
            var s_Engine = p_Mounter.GetEngineType();
            m_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Engine);
            m_Indexes = EngineInterfaceRegistry.Create<ILevelIndexes>(s_Engine);
            Rules = EngineInterfaceRegistry.Create<IRegistryRules>(s_Engine);
            m_Scanner = new AssetReferenceScanner(p_Mounter, m_Converter, TryCreate<ITextureConverter>(s_Engine), TryCreate<IMeshConverter>(s_Engine));
            m_Override = p_Override;
            m_OwnBundlePartitions = p_OwnBundlePartitions;
        }

        public class Result
        {
            public LevelClosure Closure { get; init; } = null!;

            /// <summary>The derived entries per registry kind, as instance keys, sub-worlds included.</summary>
            public Dictionary<string, List<string>> Entries { get; init; } = new();

            /// <summary>The level partition's own entries, before the sub-worlds' are added.</summary>
            public Dictionary<string, List<string>> Own { get; init; } = new();

            public Dictionary<string, Dictionary<string, List<string>>> SubWorlds { get; } = new();
        }

        public Result Derive(string p_Root, string? p_RegistryPartition, TextWriter p_Log)
        {
            var s_Root = p_Root.ToLowerInvariant();
            var s_Closure = BuildClosure(s_Root, p_RegistryPartition);
            var s_Derived = Rules.CoversBundle ? DeriveFromBundle(s_Root, p_Log) : DeriveFromClosure(s_Closure);
            var s_Result = new Result { Closure = s_Closure, Entries = s_Derived, Own = s_Derived.ToDictionary(p_P => p_P.Key, p_P => p_P.Value.ToList()) };
            if (Rules.CoversBundle)
                return s_Result;

            p_Log.WriteLine($"{s_Root}: closure of {s_Closure.Partitions.Count} partitions.");

            // The level's own registry also lists what its sub-worlds' registries list, as far as it
            // ships in a bundle loaded with the level.
            var s_LevelBundles = Rules.GetLevelBundles(s_Root).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var s_SubWorlds = s_Closure.Instances.SelectMany(Rules.GetSubWorldBundles)
                .Select(p_B => p_B.ToLowerInvariant()).Where(p_B => p_B != s_Root).Distinct().ToList();

            foreach (var s_SubWorld in s_SubWorlds)
            {
                if (GetVariant(s_SubWorld) == null)
                {
                    p_Log.WriteLine($"  sub-world {s_SubWorld}: no partition of that name.");
                    continue;
                }

                var s_SubClosure = BuildClosure(s_SubWorld, null);
                var s_SubDerived = DeriveFromClosure(s_SubClosure);
                s_Result.SubWorlds[s_SubWorld] = s_SubDerived;
                p_Log.WriteLine($"  sub-world {s_SubWorld}: closure of {s_SubClosure.Partitions.Count} partitions, {s_SubDerived.Values.Sum(p_L => p_L.Count)} entries.");

                foreach (var (s_Kind, s_Entries) in s_SubDerived)
                {
                    if (!s_Derived.TryGetValue(s_Kind, out var s_Into))
                        s_Derived[s_Kind] = s_Into = new List<string>();
                    var s_Have = s_Into.ToHashSet();
                    s_Into.AddRange(s_Entries.Where(p_E => s_Have.Add(p_E) && ShipsIn(p_E, s_LevelBundles)));
                }
            }

            return s_Result;
        }

        /// <summary>A derived entry as a reference.</summary>
        public CtrRefBase ToReference(string p_Key) => m_KeyReferences[p_Key];

        public string Key(GUID p_Partition, DataContainerId p_Instance)
        {
            var s_Key = $"{p_Partition}/{p_Instance}".ToLowerInvariant();
            if (!m_KeyReferences.ContainsKey(s_Key))
                m_KeyReferences[s_Key] = new CtrRefBase(p_Partition, p_Instance);
            return s_Key;
        }

        public IEnumerable<string> Keys => m_KeyReferences.Keys;

        /// <summary>The name of the partition an entry is in, looking it up in the mounted game if needed.</summary>
        public string? PartitionName(string p_Key)
        {
            if (Instances.TryGetValue(p_Key, out var s_Found))
                return s_Found.Partition;

            var s_Guid = m_KeyReferences[p_Key].PartitionGuid;
            if (!PartitionNames.TryGetValue(s_Guid, out var s_Name))
                PartitionNames[s_Guid] = s_Name = Mounter.TryGetPartitionByGuid(s_Guid, out var s_Resolved, out _) ? s_Resolved.ToLowerInvariant() : null;

            return s_Name;
        }

        public IObjectVariant? GetVariant(string p_Name)
        {
            if (m_Override?.Invoke(p_Name) is { } s_Override)
                return s_Override;

            return Mounter.TryGetPartition(p_Name, out var s_Mounted) ? s_Mounted.FirstVariant : null;
        }

        /// <summary>The partition parsed, shared with the other readers of a build_level run; not to be changed.</summary>
        public DatabasePartitionBase? Parse(string p_Name) => Parse(p_Name, true);

        /// <summary>A copy of the partition of its own, for a caller that fills it in.</summary>
        public DatabasePartitionBase? ParseCopy(string p_Name) => Parse(p_Name, false);

        private DatabasePartitionBase? Parse(string p_Name, bool p_Shared)
        {
            if (GetVariant(p_Name) is not { } s_Variant)
                return null;

            try
            {
                return p_Shared ? PartitionCache.Parse(m_Converter, p_Name, s_Variant) : m_Converter.FromPartitionObject(p_Name, s_Variant);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool ShipsIn(string p_Key, HashSet<string> p_Bundles)
        {
            return PartitionName(p_Key) is { } s_Name && Mounter.TryGetPartition(s_Name, out var s_Partition) &&
                s_Partition.Variants.Any(p_V => p_V.GetContainedBundle() is { } s_Bundle && p_Bundles.Contains(s_Bundle));
        }

        private LevelClosure BuildClosure(string p_Root, string? p_RegistryPartition)
        {
            // Registries that cover their bundle need only the root and its registries.
            var s_Closure = LevelClosure.Build(GetVariant, m_Scanner, m_Indexes, Parse, p_Root, p_RegistryPartition, !Rules.CoversBundle);
            Index(s_Closure);
            return s_Closure;
        }

        /// <summary>Records a closure's instances and the references between them.</summary>
        private void Index(LevelClosure p_Closure)
        {
            foreach (var (s_To, s_From) in p_Closure.ReachedFrom)
                ReachedFrom.TryAdd(s_To, s_From);

            foreach (var (s_Name, s_Parsed) in p_Closure.Partitions)
            {
                PartitionNames[s_Parsed.PartitionGuid] = s_Name;
                foreach (var s_Instance in s_Parsed.Instances)
                {
                    if (s_Instance == null)
                        continue;

                    var s_Key = Key(s_Parsed.PartitionGuid, s_Instance.InstanceId);
                    Instances[s_Key] = (s_Name, s_Instance);

                    // The registries themselves are not content: nothing is reached through them.
                    if (m_Indexes.GetEmbeddedIndexes(s_Instance).Any())
                        continue;

                    var s_Targets = m_ReferencesOf[s_Key] = new List<string>();
                    foreach (var (s_Field, s_Ref) in Commands.Game.AnalyzeRegistryCommand.References(s_Instance, s_Instance.GetType().Name, 0))
                    {
                        var s_Target = Key(s_Ref.PartitionGuid, s_Ref.InstanceId);
                        if (!Rules.IsDescriptionOnly(s_Instance))
                        {
                            s_Targets.Add(s_Target);
                            if (!m_ReferrersOf.TryGetValue(s_Target, out var s_Referrers))
                                m_ReferrersOf[s_Target] = s_Referrers = new List<string>();
                            s_Referrers.Add(s_Key);
                        }
                        if (!ReferencedBy.TryGetValue(s_Target, out var s_By))
                            ReferencedBy[s_Target] = s_By = new HashSet<string>();
                        s_By.Add($"{s_Name} {s_Field}");
                    }
                }
            }

        }

        /// <summary>The entries the rules give for everything the level's own bundle ships.</summary>
        private Dictionary<string, List<string>> DeriveFromBundle(string p_Root, TextWriter p_Log)
        {
            var s_Bundle = Rules.GetLevelBundles(p_Root).First();
            var s_Content = new List<DataContainerBase>();
            var s_Count = 0;

            foreach (var s_Name in (m_OwnBundlePartitions ?? Mounter.GetPartitionsInBundle(s_Bundle)).Select(p_N => p_N.ToLowerInvariant()))
            {
                var s_Parsed = Parse(s_Name);
                if (s_Parsed == null || (s_Parsed.PrimaryInstance != null && m_Indexes.GetPartitionIndexKind(s_Parsed.PrimaryInstance) != null))
                    continue;

                ++s_Count;
                PartitionNames[s_Parsed.PartitionGuid] = s_Name;
                foreach (var s_Instance in s_Parsed.Instances)
                {
                    if (s_Instance == null)
                        continue;

                    Instances.TryAdd(Key(s_Parsed.PartitionGuid, s_Instance.InstanceId), (s_Name, s_Instance));
                    s_Content.Add(s_Instance);
                }
            }

            p_Log.WriteLine($"{s_Bundle}: {s_Count} partitions.");
            return Collect(Rules.GetEntries(s_Content, Resolve));
        }

        /// <summary>The entries the rules give for the content a closure's root reaches, in closure order.</summary>
        private Dictionary<string, List<string>> DeriveFromClosure(LevelClosure p_Closure)
        {
            return Collect(Rules.GetEntries(Reached(p_Closure), Resolve));
        }

        /// <summary>
        /// The content a level partition reaches (see <see cref="Reached"/>), with the closure it was
        /// found in.
        /// </summary>
        /// <param name="p_WholePartitions">Whether a partition whose primary instance is reached counts whole.</param>
        /// <param name="p_DontFollow">Instances whose references are not followed.</param>
        /// <param name="p_NotAsSibling">Instances not reached just for being in a partition that counts whole.</param>
        public (LevelClosure Closure, List<DataContainerBase> Content) ReachedContent(string p_Root, bool p_WholePartitions = true,
            Func<DataContainerBase, bool>? p_DontFollow = null, Func<string, bool>? p_NotAsSibling = null)
        {
            var s_Closure = LevelClosure.Build(GetVariant, m_Scanner, m_Indexes, Parse, p_Root.ToLowerInvariant());
            Index(s_Closure);
            return (s_Closure, Reached(s_Closure, p_WholePartitions, p_DontFollow, p_NotAsSibling));
        }

        /// <summary>The content reached from a closure already read, with other options.</summary>
        public List<DataContainerBase> ReachedContent(LevelClosure p_Closure, bool p_WholePartitions, Func<DataContainerBase, bool>? p_DontFollow, Func<string, bool>? p_NotAsSibling)
        {
            return Reached(p_Closure, p_WholePartitions, p_DontFollow, p_NotAsSibling);
        }

        /// <summary>The instances a closure's root reaches, in closure order, without the registries.</summary>
        private List<DataContainerBase> Reached(LevelClosure p_Closure, bool p_WholePartitions = true, Func<DataContainerBase, bool>? p_DontFollow = null,
            Func<string, bool>? p_NotAsSibling = null)
        {
            // Only what the level reaches: a partition can be in the closure for one instance (a
            // flattened copy of a prefab borrowing its tracks) while the rest of it is unused. A
            // partition whose primary instance is reached counts whole, since destruction prefabs
            // place loose reference objects that nothing in the partition references. Nothing is
            // reached through the registries or through the values an interface descriptor holds.
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
                if (!p_WholePartitions)
                    return;
                foreach (var s_Sibling in s_ByPartition.GetValueOrDefault(p_Key) ?? new List<string>())
                {
                    if (p_NotAsSibling == null || !p_NotAsSibling(s_Sibling))
                        Reach(s_Sibling);
                }
            }

            if (p_Closure.Partitions.TryGetValue(p_Closure.Root, out var s_RootPartition) && s_RootPartition.PrimaryInstance != null)
                Reach(Key(s_RootPartition.PartitionGuid, s_RootPartition.PrimaryInstance.InstanceId));

            while (s_Queue.Count > 0)
            {
                var s_At = s_Queue.Dequeue();
                if (p_DontFollow != null && Instances.TryGetValue(s_At, out var s_Instance) && p_DontFollow(s_Instance.Instance))
                    continue;
                foreach (var s_Next in m_ReferencesOf.GetValueOrDefault(s_At) ?? new List<string>())
                    Reach(s_Next);
            }

            return p_Closure.Partitions.Values
                .SelectMany(p_P => p_P.Instances.Where(p_I => p_I != null && s_Reached.Contains(Key(p_P.PartitionGuid, p_I.InstanceId))))
                .Where(p_I => !m_Indexes.GetEmbeddedIndexes(p_I).Any()).ToList();
        }

        private Dictionary<string, List<string>> Collect(IEnumerable<(string Kind, CtrRefBase Entry)> p_Entries)
        {
            var s_Result = new Dictionary<string, List<string>>();
            var s_Seen = new HashSet<(string, string)>();

            foreach (var (s_Kind, s_Entry) in p_Entries)
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

        public DataContainerBase? Resolve(CtrRefBase p_Ref)
        {
            if (p_Ref.IsNull())
                return null;

            var s_Key = Key(p_Ref.PartitionGuid, p_Ref.InstanceId);
            if (Instances.TryGetValue(s_Key, out var s_Found))
                return s_Found.Instance;

            // Outside what was read so far (a blueprint in a shared bundle): read its partition.
            if (!PartitionNames.ContainsKey(p_Ref.PartitionGuid) && PartitionName(s_Key) is { } s_Name && Parse(s_Name) is { } s_Parsed)
            {
                foreach (var s_Instance in s_Parsed.Instances)
                {
                    if (s_Instance != null)
                        Instances.TryAdd(Key(s_Parsed.PartitionGuid, s_Instance.InstanceId), (s_Name, s_Instance));
                }
            }

            return Instances.TryGetValue(s_Key, out s_Found) ? s_Found.Instance : p_Ref.Get();
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
