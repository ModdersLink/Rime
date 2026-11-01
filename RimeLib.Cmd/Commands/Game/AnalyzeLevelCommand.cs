using System;
using System.Collections;
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
using RimeLib.Shader;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Works out where everything in a level's main bundle comes from.
    ///
    /// Every partition and resource of every bundle in the level superbundle is scanned for what it
    /// references (the same layers reference_existing_partition follows), and the edges are turned
    /// around. Two kinds of edge are kept apart:
    ///  - content: something uses the item (a mesh its shader, a blueprint its mesh, ...);
    ///  - index: an aggregate lists the item on behalf of others (a RegistryContainer, a
    ///    MeshVariationDatabase, a shader database).
    /// Each main-bundle item is then classified by the content that needs it (the main bundle's own,
    /// or only sub-bundles'), by the indexes that merely list it, or as a root nothing in the level
    /// refers to, which the engine or game code loads by name.
    ///
    /// The aggregates are broken down entry by entry as well: each registry and mesh variation entry
    /// is traced to the bundle that holds what it points at, each shader to the bundles using it.
    /// </summary>
    [CommandDescription("Reports where every item in a level's main bundle comes from: whether the main bundle's own content needs it, only sub-bundles' content, only an index (registry, mesh variation or shader database), or nothing in the level. Breaks those indexes down entry by entry and writes the full report as JSON.")]
    public class AnalyzeLevelCommand : Command
    {
        [CommandArgument(Description = "The level superbundle, e.g. win32/levels/mp_subway/mp_subway. It is mounted if it is not yet.")]
        public string? Superbundle { get; set; }

        [CommandArgument(Description = "Where to write the JSON report.")]
        public FileInfo? Destination { get; set; }

        private IEngineMounter m_Mounter = null!;

        // Items are keyed "ebx:<name>", "res:<name>" and "chunk:<guid>", lowercase.
        private readonly Dictionary<string, HashSet<string>> m_ItemBundles = new();
        private readonly Dictionary<string, string?> m_ItemTypes = new();
        private readonly Dictionary<string, HashSet<string>> m_ContentRefs = new();
        private readonly Dictionary<string, HashSet<(string From, string Kind)>> m_IndexRefs = new();
        private readonly List<string> m_Problems = new();

        // Everything each scanned item references, in or outside the level, for the closure walks.
        private readonly Dictionary<string, HashSet<string>> m_Forward = new();
        private AssetReferenceScanner m_Scanner = null!;
        private ILevelIndexes? m_Indexes;

        // Partitions that are indexes as a whole (mesh variation databases, network registries), by kind.
        private readonly Dictionary<string, string> m_IndexPartitions = new();

        // Level items nothing in the level refers to, by the partitions outside the level that import
        // them, each as "name [type] (superbundle)".
        private readonly Dictionary<string, List<string>> m_OutsideImporters = new();
        private IPartitionConverter m_Converter = null!;

        // Level items nothing in the level references once parsed, by the level partitions whose
        // import table lists them anyway (a parse gap).
        private readonly Dictionary<string, List<string>> m_ImportedButNotParsed = new();

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Superbundle) || Destination == null)
            {
                p_Writer.WriteLine("usage: analyze_level <superbundle> <destination.json>");
                return false;
            }

            m_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Engine = m_Mounter.GetEngineType();

            var s_Superbundle = m_Mounter.GetAvailableSuperbundles()
                .FirstOrDefault(p_Sb => p_Sb.Equals(Superbundle, StringComparison.OrdinalIgnoreCase));
            if (s_Superbundle == null)
            {
                p_Writer.WriteLine($"No superbundle named '{Superbundle}'.");
                return false;
            }

            if (!m_Mounter.GetMountedSuperbundles().Contains(s_Superbundle.ToLowerInvariant()))
            {
                p_Writer.WriteLine($"Mounting {s_Superbundle}...");
                m_Mounter.MountSuperbundle(s_Superbundle, true).Wait();
            }

            var s_Bundles = m_Mounter.GetBundlesInSuperbundle(s_Superbundle).Select(p_B => p_B.ToLowerInvariant()).Distinct().ToList();
            var s_MainBundle = s_Bundles.FirstOrDefault(p_B => p_B == s_Superbundle.ToLowerInvariant());
            if (s_MainBundle == null)
            {
                p_Writer.WriteLine($"{s_Superbundle} has no bundle of its own name, so there is no main bundle to analyze.");
                return false;
            }

            var s_PartitionConverter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Engine);
            var s_Scanner = new AssetReferenceScanner(m_Mounter, s_PartitionConverter,
                TryCreate<ITextureConverter>(s_Engine, p_Writer), TryCreate<IMeshConverter>(s_Engine, p_Writer));
            m_Scanner = s_Scanner;
            m_Converter = s_PartitionConverter;
            m_Indexes = TryCreate<ILevelIndexes>(s_Engine, p_Writer);

            MeshVariationDbIndex.Build(m_Mounter, p_Writer);

            // 1. Which bundles of the level hold which items.
            foreach (var s_Bundle in s_Bundles)
            {
                foreach (var s_Partition in m_Mounter.GetPartitionsInBundle(s_Bundle))
                    AddItem($"ebx:{s_Partition.ToLowerInvariant()}", s_Bundle);

                foreach (var (s_Name, s_Type) in m_Mounter.GetResourcesInBundle(s_Bundle))
                {
                    AddItem($"res:{s_Name.ToLowerInvariant()}", s_Bundle);
                    m_ItemTypes[$"res:{s_Name.ToLowerInvariant()}"] = s_Type.ToString();
                }

                foreach (var s_Chunk in m_Mounter.GetChunksInBundle(s_Bundle))
                    AddItem($"chunk:{s_Chunk.ToString().ToLowerInvariant()}", s_Bundle);
            }

            p_Writer.WriteLine($"{s_Bundles.Count} bundles, {m_ItemBundles.Count} distinct items. Scanning references...");

            // 2. What each item references, content and index edges apart.
            var s_Aggregates = new List<AggregateBreakdown>();
            var s_ShaderDatabases = new List<string>();
            var s_Scanned = 0;

            foreach (var s_Key in m_ItemBundles.Keys.ToList())
            {
                if (s_Key.StartsWith("ebx:"))
                {
                    var s_Name = s_Key[4..];
                    if (!m_Mounter.TryGetPartition(s_Name, out var s_Partition))
                        continue;

                    var s_Variant = PickVariant(s_Partition.Variants, m_ItemBundles[s_Key]) ?? s_Partition.FirstVariant;
                    // Embedded index lists (a RegistryContainer) are left out of the content scan and
                    // recorded as index edges by BreakDownPartition.
                    var s_References = s_Scanner.ScanPartition(s_Name, s_Variant, p_I => m_Indexes?.GetEmbeddedIndexes(p_I).Any() == true);
                    m_ItemTypes[s_Key] = s_References.TypeName;

                    // A whole-partition index (a mesh variation database lists meshes, materials and
                    // textures; a network registry lists objects) references on behalf of others.
                    var s_IndexKind = s_References.Parsed?.PrimaryInstance is { } s_Primary ? m_Indexes?.GetPartitionIndexKind(s_Primary) : null;
                    if (s_IndexKind != null)
                        m_IndexPartitions[s_Key] = s_IndexKind;

                    AddEdges(s_Key, s_References, s_IndexKind);

                    if (s_References.Parsed != null)
                        s_Aggregates.AddRange(BreakDownPartition(s_Key, s_References.Parsed));
                }
                else if (s_Key.StartsWith("res:"))
                {
                    var s_Name = s_Key[4..];
                    if (!m_Mounter.TryGetResource(s_Name, out var s_Resource))
                        continue;

                    var s_Variant = PickVariant(s_Resource.Variants, m_ItemBundles[s_Key]) ?? s_Resource.FirstVariant;
                    AddEdges(s_Key, s_Scanner.ScanResource(s_Name, s_Variant), null);

                    if (m_ItemTypes.GetValueOrDefault(s_Key) is "IShaderDatabase" or "DxShaderDatabase")
                        s_ShaderDatabases.Add(s_Name);
                }

                if (++s_Scanned % 2000 == 0)
                    p_Writer.WriteLine($"  {s_Scanned} scanned");
            }

            // The shader databases list their shaders and the textures those bind.
            var s_ShaderNames = ReadShaderDatabases(s_Engine, s_ShaderDatabases, p_Writer);

            // Who outside the level imports what nothing in the level refers to.
            FindOutsideImporters(s_Engine, p_Writer);

            // 3. The main bundle's items, by what needs them.
            var s_Origins = new List<ItemOrigin>();
            foreach (var s_Item in m_ItemBundles.Where(p_I => p_I.Value.Contains(s_MainBundle)).Select(p_I => p_I.Key).OrderBy(p_K => p_K))
            {
                var s_ContentBundles = BundlesOf(m_ContentRefs.GetValueOrDefault(s_Item));
                var s_Indexes = m_IndexRefs.TryGetValue(s_Item, out var s_I)
                    ? s_I.SelectMany(p_R => m_ItemBundles[p_R.From].Select(p_B => $"{p_R.Kind} in {p_B}")).Distinct().OrderBy(p_X => p_X).ToList()
                    : new List<string>();

                string s_Origin;
                if (s_ContentBundles.Contains(s_MainBundle))
                    s_Origin = "main content";
                else if (s_ContentBundles.Count > 0)
                    s_Origin = "sub-bundle content only";
                else if (s_Indexes.Count > 0)
                    s_Origin = "listed by an index only";
                else if (m_OutsideImporters.ContainsKey(s_Item))
                    s_Origin = ImportedByShared(s_Item) ? "root, imported by a shared superbundle" : "root, imported only by other levels";
                else
                    s_Origin = "root";

                s_Origins.Add(new ItemOrigin
                {
                    Item = s_Item,
                    Type = m_ItemTypes.GetValueOrDefault(s_Item),
                    Origin = s_Origin,
                    NeededBy = s_ContentBundles,
                    ListedBy = s_Indexes,
                    AlsoIn = m_ItemBundles[s_Item].Where(p_B => p_B != s_MainBundle).OrderBy(p_B => p_B).ToList(),
                    OtherSuperbundles = OtherSuperbundles(s_Item, s_Superbundle),
                    ImportedBy = m_OutsideImporters.GetValueOrDefault(s_Item) ?? new List<string>(),
                });
            }

            // 5. Coverage: per bundle, what the closure of its own level partition reaches, and what is left.
            p_Writer.WriteLine("Walking closures for coverage...");
            var s_Coverage = s_Bundles.Select(p_B => Coverage(p_B)).ToList();
            AttributeToOtherBundles(s_Coverage);

            // 6. Each shader of each shader database, by who uses its shader asset. After the closure
            // walks, so content outside the level that the level loads (weapons, soldiers, ...) counts.
            foreach (var (s_Database, s_Shaders) in s_ShaderNames)
                s_Aggregates.Add(BreakDownShaders(s_Database, s_Shaders));

            var s_Report = new
            {
                Superbundle = s_Superbundle,
                MainBundle = s_MainBundle,
                Bundles = s_Bundles,
                MainBundleItems = s_Origins,
                Aggregates = s_Aggregates,
                Coverage = s_Coverage,
                Problems = m_Problems,
            };

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(s_Report, Formatting.Indented));

            WriteSummary(p_Writer, s_MainBundle, s_Origins, s_Aggregates);
            WriteCoverage(p_Writer, s_Coverage);
            p_Writer.WriteLine($"Full report written to {Destination.FullName}.");

            return true;
        }

        private void AddItem(string p_Key, string p_Bundle)
        {
            if (!m_ItemBundles.TryGetValue(p_Key, out var s_Bundles))
                m_ItemBundles[p_Key] = s_Bundles = new HashSet<string>();

            s_Bundles.Add(p_Bundle);
        }

        /// <summary>Records what an item references, as content edges, or as index edges of the given kind.</summary>
        private void AddEdges(string p_From, AssetReferenceScanner.References p_References, string? p_IndexKind)
        {
            var s_Targets = new HashSet<string>();

            foreach (var s_Partition in p_References.Partitions)
                s_Targets.Add($"ebx:{s_Partition.ToLowerInvariant()}");

            // Resource names include speculative ones; only those that are items count.
            foreach (var s_Resource in p_References.Resources)
                s_Targets.Add($"res:{s_Resource.ToLowerInvariant()}");

            foreach (var s_Chunk in p_References.Chunks)
                s_Targets.Add($"chunk:{s_Chunk.Id.ToString().ToLowerInvariant()}");

            foreach (var s_Target in s_Targets)
                AddEdge(p_From, s_Target, p_IndexKind);

            m_Problems.AddRange(p_References.Problems);
        }

        private void AddEdge(string p_From, string p_To, string? p_IndexKind)
        {
            if (p_To == p_From)
                return;

            // Speculative resource names only count when such a resource exists.
            if (m_ItemBundles.ContainsKey(p_To) || !p_To.StartsWith("res:") || m_Mounter.TryGetResource(p_To[4..], out _))
            {
                if (!m_Forward.TryGetValue(p_From, out var s_Targets))
                    m_Forward[p_From] = s_Targets = new HashSet<string>();
                s_Targets.Add(p_To);
            }

            if (!m_ItemBundles.ContainsKey(p_To))
                return;

            if (p_IndexKind == null)
            {
                if (!m_ContentRefs.TryGetValue(p_To, out var s_From))
                    m_ContentRefs[p_To] = s_From = new HashSet<string>();
                s_From.Add(p_From);
            }
            else
            {
                if (!m_IndexRefs.TryGetValue(p_To, out var s_From))
                    m_IndexRefs[p_To] = s_From = new HashSet<(string, string)>();
                s_From.Add((p_From, p_IndexKind));
            }
        }

        /// <summary>
        /// Everything reachable from a root, across the whole game: the level's items use the edges
        /// already scanned, anything outside the level is scanned when the walk reaches it.
        /// </summary>
        private void ExtendClosure(HashSet<string> s_Seen, IEnumerable<string> p_Roots)
        {
            var s_Queue = new Queue<string>();
            foreach (var s_Root in p_Roots)
                if (s_Seen.Add(s_Root))
                    s_Queue.Enqueue(s_Root);

            while (s_Queue.Count > 0)
            {
                var s_Key = s_Queue.Dequeue();

                if (!m_Forward.ContainsKey(s_Key) && !m_ItemBundles.ContainsKey(s_Key))
                    ScanOutsideItem(s_Key);

                if (!m_Forward.TryGetValue(s_Key, out var s_Targets))
                    continue;

                foreach (var s_Target in s_Targets)
                    if (s_Seen.Add(s_Target))
                        s_Queue.Enqueue(s_Target);
            }
        }

        private void ScanOutsideItem(string p_Key)
        {
            AssetReferenceScanner.References? s_References = null;

            if (p_Key.StartsWith("ebx:") && m_Mounter.TryGetPartition(p_Key[4..], out var s_Partition))
                s_References = m_Scanner.ScanPartition(p_Key[4..], s_Partition.FirstVariant);
            else if (p_Key.StartsWith("res:") && m_Mounter.TryGetResource(p_Key[4..], out var s_Resource))
                s_References = m_Scanner.ScanResource(p_Key[4..], s_Resource.FirstVariant);

            if (s_References != null)
                AddEdges(p_Key, s_References, null);
            else
                m_Forward[p_Key] = new HashSet<string>();
        }

        /// <summary>
        /// A bundle's coverage, built up from the roots the engine reaches without a reference, one
        /// kind at a time so each step shows what it explains:
        ///  1. its level partition (LevelData, or a sub-world's SubWorldData), named like the bundle;
        ///  2. its mesh variation databases, which are found by name;
        ///  3. its shader databases;
        ///  4. its entry points: items nothing in the level refers to, split by who outside the level
        ///     imports them: a shared superbundle (loaded with that), only other levels (a leftover
        ///     here), or nothing in the game.
        /// Whatever is still left is then checked against the other bundles' closures (content a
        /// bundle supplies for another), and the rest is unexplained.
        /// </summary>
        private BundleCoverage Coverage(string p_Bundle)
        {
            var s_Items = m_ItemBundles.Where(p_I => p_I.Value.Contains(p_Bundle)).Select(p_I => p_I.Key).ToList();
            var s_Slash = p_Bundle.IndexOf('/');
            var s_LevelPartition = $"ebx:{(s_Slash >= 0 ? p_Bundle[(s_Slash + 1)..] : p_Bundle)}";

            var s_Result = new BundleCoverage { Bundle = p_Bundle, Items = s_Items.Count };
            var s_Closure = new HashSet<string>();

            void Stage(string p_Name, List<string> p_Roots)
            {
                ExtendClosure(s_Closure, p_Roots);
                s_Result.Stages.Add(new CoverageStage
                {
                    Name = p_Name, Roots = p_Roots.Count, CoveredAfter = s_Items.Count(s_Closure.Contains),
                    RootTypes = p_Roots.GroupBy(p_R => $"{p_R.Split(':')[0]} {m_ItemTypes.GetValueOrDefault(p_R) ?? "?"}")
                        .OrderByDescending(p_G => p_G.Count()).ToDictionary(p_G => p_G.Key, p_G => p_G.Count()),
                    RootSamples = p_Roots.OrderBy(p_R => p_R).Take(200).ToList(),
                });
            }

            Stage("level partition", s_Items.Contains(s_LevelPartition) ? new List<string> { s_LevelPartition } : new List<string>());
            Stage("index partitions, found by name (mesh variation databases, network registries)", s_Items.Where(m_IndexPartitions.ContainsKey).ToList());
            Stage("shader databases", s_Items.Where(p_I => m_ItemTypes.GetValueOrDefault(p_I) is "IShaderDatabase" or "DxShaderDatabase").ToList());
            var s_EntryPoints = s_Items.Where(p_I => !s_Closure.Contains(p_I) && !m_ContentRefs.ContainsKey(p_I) && !m_IndexRefs.ContainsKey(p_I)).ToList();
            Stage("entry points imported by a shared (non-level) superbundle", s_EntryPoints.Where(ImportedByShared).ToList());
            Stage("entry points imported only by other levels (not loaded with this one)", s_EntryPoints.Where(p_I => m_OutsideImporters.ContainsKey(p_I) && !ImportedByShared(p_I)).ToList());
            Stage("entry points nothing in the game imports", s_EntryPoints.Where(p_I => !m_OutsideImporters.ContainsKey(p_I)).ToList());

            s_Result.Closure = s_Closure;
            s_Result.Uncovered = s_Items.Where(p_I => !s_Closure.Contains(p_I)).OrderBy(p_I => p_I).Select(Detail).ToList();
            return s_Result;
        }

        /// <summary>Splits each bundle's remainder into what another bundle's closure needs and what is unexplained.</summary>
        private static void AttributeToOtherBundles(List<BundleCoverage> p_Coverage)
        {
            foreach (var s_Bundle in p_Coverage)
            {
                foreach (var s_Item in s_Bundle.Uncovered)
                {
                    s_Item.SuppliedFor = p_Coverage.Where(p_Other => p_Other != s_Bundle && p_Other.Closure.Contains(s_Item.Item))
                        .Select(p_Other => p_Other.Bundle).OrderBy(p_B => p_B).ToList();
                }
            }
        }

        private UncoveredItem Detail(string p_Item)
        {
            return new UncoveredItem
            {
                Item = p_Item,
                Type = m_ItemTypes.GetValueOrDefault(p_Item),
                NeededBy = BundlesOf(m_ContentRefs.GetValueOrDefault(p_Item)),
                ListedBy = m_IndexRefs.TryGetValue(p_Item, out var s_I)
                    ? s_I.SelectMany(p_R => m_ItemBundles[p_R.From].Select(p_B => $"{p_R.Kind} in {p_B}")).Distinct().OrderBy(p_X => p_X).ToList()
                    : new List<string>(),
            };
        }

        private static void WriteCoverage(TextWriter p_Writer, List<BundleCoverage> p_Coverage)
        {
            p_Writer.WriteLine();
            p_Writer.WriteLine("=== coverage: each bundle, built up from the roots the engine reaches without a reference");

            foreach (var s_Bundle in p_Coverage.OrderByDescending(p_C => p_C.Uncovered.Count(p_U => p_U.SuppliedFor.Count == 0)))
            {
                var s_Unexplained = s_Bundle.Uncovered.Where(p_U => p_U.SuppliedFor.Count == 0).ToList();
                p_Writer.WriteLine($"--- {s_Bundle.Bundle}: {s_Bundle.Items} items, {s_Unexplained.Count} unexplained");

                var s_Previous = 0;
                foreach (var s_Stage in s_Bundle.Stages)
                {
                    p_Writer.WriteLine($"    {s_Stage.CoveredAfter - s_Previous,6}  covered by {s_Stage.Name} ({s_Stage.Roots} root(s))");
                    s_Previous = s_Stage.CoveredAfter;
                }

                foreach (var s_For in s_Bundle.Uncovered.Where(p_U => p_U.SuppliedFor.Count > 0)
                             .GroupBy(p_U => string.Join(", ", p_U.SuppliedFor.Take(3)) + (p_U.SuppliedFor.Count > 3 ? ", ..." : ""))
                             .OrderByDescending(p_G => p_G.Count()).Take(6))
                    p_Writer.WriteLine($"    {s_For.Count(),6}  supplied for {s_For.Key}");

                if (s_Unexplained.Count == 0)
                    continue;

                p_Writer.WriteLine($"    {s_Unexplained.Count,6}  unexplained:");
                foreach (var s_ByType in s_Unexplained.GroupBy(p_U => $"{p_U.Item.Split(':')[0]} {p_U.Type ?? "?"}").OrderByDescending(p_G => p_G.Count()).Take(6))
                    p_Writer.WriteLine($"           {s_ByType.Count(),6}  {s_ByType.Key}");

                foreach (var s_Hint in s_Unexplained
                             .Select(p_U => p_U.NeededBy.Count > 0 ? "needed by content in: " + string.Join(", ", p_U.NeededBy.Take(3)) + (p_U.NeededBy.Count > 3 ? ", ..." : "")
                                 : p_U.ListedBy.Count > 0 ? "listed by: " + string.Join(", ", p_U.ListedBy.Take(2)) + (p_U.ListedBy.Count > 2 ? ", ..." : "")
                                 : "nothing in the level refers to it")
                             .GroupBy(p_H => p_H).OrderByDescending(p_G => p_G.Count()).Take(5))
                    p_Writer.WriteLine($"           {s_Hint.Count(),6}  {(s_Hint.Key.Length > 140 ? s_Hint.Key[..137] + "..." : s_Hint.Key)}");
            }
        }

        /// <summary>The level bundles holding these items; items outside the level count as "outside the level".</summary>
        private List<string> BundlesOf(HashSet<string>? p_Items)
        {
            return p_Items == null
                ? new List<string>()
                : p_Items.SelectMany(p_I => m_ItemBundles.TryGetValue(p_I, out var s_B) ? s_B : (IEnumerable<string>)new[] { "outside the level" })
                    .Distinct().OrderBy(p_B => p_B).ToList();
        }

        private static T? PickVariant<T>(IEnumerable<T> p_Variants, HashSet<string> p_Bundles) where T : class, IObjectVariant
        {
            return p_Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() is { } s_B && p_Bundles.Contains(s_B.ToLowerInvariant()));
        }

        private List<string> OtherSuperbundles(string p_Item, string p_Superbundle)
        {
            IEnumerable<IObjectVariant> s_Variants = Enumerable.Empty<IObjectVariant>();

            if (p_Item.StartsWith("ebx:") && m_Mounter.TryGetPartition(p_Item[4..], out var s_P))
                s_Variants = s_P.Variants;
            else if (p_Item.StartsWith("res:") && m_Mounter.TryGetResource(p_Item[4..], out var s_R))
                s_Variants = s_R.Variants;

            return s_Variants.Select(p_V => p_V.GetContainedSuperbundle())
                .Where(p_Sb => !p_Sb.Equals(p_Superbundle, StringComparison.OrdinalIgnoreCase))
                .Distinct(StringComparer.OrdinalIgnoreCase).OrderBy(p_Sb => p_Sb).ToList();
        }

        /// <summary>Where the partition an entry points at lives, relative to the bundles that hold the aggregate.</summary>
        private string Classify(string? p_TargetPartition, HashSet<string> p_OwnerBundles)
        {
            if (p_TargetPartition == null)
                return "unresolved";

            if (!m_ItemBundles.TryGetValue($"ebx:{p_TargetPartition.ToLowerInvariant()}", out var s_Bundles))
                return "outside the level";

            if (s_Bundles.Overlaps(p_OwnerBundles))
                return "same bundle";

            return "other bundle: " + string.Join(", ", s_Bundles.OrderBy(p_B => p_B));
        }

        /// <summary>
        /// A partition's indexes, entry by entry: embedded lists (recorded as index edges here, since
        /// the content scan leaves them out) and, for a whole-partition index, what each entry is about.
        /// </summary>
        private IEnumerable<AggregateBreakdown> BreakDownPartition(string p_Key, DatabasePartitionBase p_Partition)
        {
            if (m_Indexes == null)
                yield break;

            var s_Owner = m_ItemBundles[p_Key];

            foreach (var s_Instance in p_Partition.Instances)
            {
                if (s_Instance == null)
                    continue;

                foreach (var (s_Kind, s_Entries) in m_Indexes.GetEmbeddedIndexes(s_Instance))
                {
                    var s_Breakdown = new AggregateBreakdown { Aggregate = $"{p_Key[4..]} {s_Kind}", OwnerBundles = s_Owner.OrderBy(p_B => p_B).ToList() };

                    foreach (var s_Ref in s_Entries)
                    {
                        if (s_Ref.IsNull())
                            continue;

                        var s_Target = ResolvePartition(s_Ref.PartitionGuid);
                        s_Breakdown.Count(Classify(s_Target, s_Owner));

                        if (s_Target != null)
                            AddEdge(p_Key, $"ebx:{s_Target.ToLowerInvariant()}", s_Kind);
                    }

                    yield return s_Breakdown;
                }
            }

            if (p_Partition.PrimaryInstance is { } s_Primary && m_Indexes.GetPartitionIndexKind(s_Primary) is { } s_PartitionKind)
            {
                var s_Breakdown = new AggregateBreakdown { Aggregate = $"{p_Key[4..]} {s_PartitionKind} entries", OwnerBundles = s_Owner.OrderBy(p_B => p_B).ToList() };

                foreach (var s_Ref in m_Indexes.GetIndexEntries(p_Partition))
                    s_Breakdown.Count(Classify(ResolvePartition(s_Ref.PartitionGuid), s_Owner));

                yield return s_Breakdown;
            }
        }

        /// <summary>
        /// Reads each shader database's shader names, and records the database as an index of its
        /// shaders' assets and of the textures it binds.
        /// </summary>
        private List<(string Database, ISet<string> Shaders)> ReadShaderDatabases(EngineType p_Engine, List<string> p_Databases, TextWriter p_Writer)
        {
            var s_Result = new List<(string, ISet<string>)>();
            if (p_Databases.Count == 0)
                return s_Result;

            var s_Resolver = TryCreate<IShaderResolver>(p_Engine, p_Writer);
            if (s_Resolver == null)
                return s_Result;

            foreach (var s_Database in p_Databases)
            {
                var s_Key = $"res:{s_Database}";
                if (!m_Mounter.TryGetResource(s_Database, out var s_Resource))
                    continue;

                try
                {
                    s_Resolver.Initialize(PickVariant(s_Resource.Variants, m_ItemBundles[s_Key]) ?? s_Resource.FirstVariant, m_Mounter);
                    var s_Shaders = s_Resolver.GetShaderNames();

                    foreach (var s_Shader in s_Shaders)
                        AddEdge(s_Key, $"ebx:{s_Shader.ToLowerInvariant()}", "ShaderDatabase");

                    foreach (var s_Texture in s_Resolver.GetTextureNames())
                    {
                        AddEdge(s_Key, $"ebx:{s_Texture.ToLowerInvariant()}", "ShaderDatabase");
                        AddEdge(s_Key, $"res:{s_Texture.ToLowerInvariant()}", "ShaderDatabase");
                    }

                    s_Result.Add((s_Database, s_Shaders));
                }
                catch (Exception s_Ex)
                {
                    m_Problems.Add($"shader database {s_Database} could not be read: {s_Ex.Message}");
                }
            }

            return s_Result;
        }

        /// <summary>
        /// Each shader, by the bundles whose content uses the shader asset of that name. A shader with
        /// no asset of its name is generated, e.g. a terrain permutation.
        /// </summary>
        private AggregateBreakdown BreakDownShaders(string p_Database, ISet<string> p_Shaders)
        {
            var s_Owner = m_ItemBundles[$"res:{p_Database}"];
            var s_Breakdown = new AggregateBreakdown { Aggregate = $"{p_Database} shaders, by the bundles whose content uses each", OwnerBundles = s_Owner.OrderBy(p_B => p_B).ToList() };

            foreach (var s_Shader in p_Shaders)
            {
                var s_Key = $"ebx:{s_Shader.ToLowerInvariant()}";
                if (!m_Mounter.TryGetPartition(s_Shader.ToLowerInvariant(), out _))
                {
                    s_Breakdown.Count("generated (no shader asset of that name)");
                    continue;
                }

                var s_Users = UsersOf(m_ContentRefs.GetValueOrDefault(s_Key));

                if (s_Users.Count == 0)
                    s_Breakdown.Count(s_Shader.Contains("__") ? "generated permutation, used by no content (name <shader>__<permutation>)" : "used by no content found");
                else if (s_Users.Any(s_Owner.Contains))
                    s_Breakdown.Count("used by the same bundle's content");
                else if (s_Users.All(p_U => p_U.StartsWith("outside: ")))
                    s_Breakdown.Count("used only by content outside the level: " + string.Join(", ", s_Users.Select(p_U => p_U[9..]).Take(4)) + (s_Users.Count > 4 ? ", ..." : ""));
                else
                    s_Breakdown.Count("used only by: " + string.Join(", ", s_Users.Take(4)) + (s_Users.Count > 4 ? ", ..." : ""));
            }

            return s_Breakdown;
        }

        /// <summary>Level bundles holding these items; items outside the level by their superbundle, as "outside: sb".</summary>
        private List<string> UsersOf(HashSet<string>? p_Items)
        {
            if (p_Items == null)
                return new List<string>();

            return p_Items.SelectMany<string, string>(p_I =>
            {
                if (m_ItemBundles.TryGetValue(p_I, out var s_Bundles))
                    return s_Bundles;

                IObjectVariant? s_Variant = null;
                if (p_I.StartsWith("ebx:") && m_Mounter.TryGetPartition(p_I[4..], out var s_P)) s_Variant = s_P.FirstVariant;
                else if (p_I.StartsWith("res:") && m_Mounter.TryGetResource(p_I[4..], out var s_R)) s_Variant = s_R.FirstVariant;

                return new[] { "outside: " + (s_Variant?.GetContainedSuperbundle() ?? "?") };
            }).Distinct().OrderBy(p_B => p_B).ToList();
        }

        /// <summary>
        /// Reads the import table of every mounted partition (header only, no parse) and records, for
        /// each partition of the level nothing in the level refers to, the partitions outside the
        /// level that import it. Mount the whole game first, or importers in unmounted superbundles
        /// are missed.
        /// </summary>
        private void FindOutsideImporters(EngineType p_Engine, TextWriter p_Writer)
        {
            var s_Candidates = m_ItemBundles.Keys.Where(p_K => p_K.StartsWith("ebx:") && !m_ContentRefs.ContainsKey(p_K) && !m_IndexRefs.ContainsKey(p_K)).ToHashSet();
            if (s_Candidates.Count == 0)
                return;

            var s_Reader = TryCreate<IPartitionImportReader>(p_Engine, p_Writer);
            if (s_Reader == null)
                return;

            var s_Partitions = m_Mounter.GetPartitions().ToList();
            p_Writer.WriteLine($"Reading the imports of {s_Partitions.Count} mounted partitions...");

            var s_Read = new (GUID? Guid, IReadOnlyCollection<GUID>? Imports)[s_Partitions.Count];
            System.Threading.Tasks.Parallel.For(0, s_Partitions.Count, i =>
            {
                try
                {
                    var (s_Guid, s_Imports) = s_Reader.ReadImports(s_Partitions[i].Value.FirstVariant);
                    s_Read[i] = (s_Guid, s_Imports);
                }
                catch (Exception)
                {
                    // Unreadable headers are counted below.
                }
            });

            var s_CandidateGuids = new Dictionary<GUID, string>();
            for (var i = 0; i < s_Partitions.Count; i++)
            {
                var s_Key = $"ebx:{s_Partitions[i].Key.ToLowerInvariant()}";
                if (s_Read[i].Guid is { } s_Guid && s_Candidates.Contains(s_Key))
                    s_CandidateGuids[s_Guid] = s_Key;
            }

            var s_Unreadable = 0;
            var s_Types = new Dictionary<string, string>();
            for (var i = 0; i < s_Partitions.Count; i++)
            {
                if (s_Read[i].Imports is not { } s_Imports)
                {
                    s_Unreadable++;
                    continue;
                }

                var s_Name = s_Partitions[i].Key.ToLowerInvariant();
                if (m_ItemBundles.ContainsKey($"ebx:{s_Name}"))
                {
                    // A level partition whose import table lists the item although its parsed data
                    // has no reference to it: the parse dropped the field that holds the reference.
                    foreach (var s_Import in s_Imports)
                    {
                        if (s_CandidateGuids.TryGetValue(s_Import, out var s_Missed) && s_Missed != $"ebx:{s_Name}")
                        {
                            if (!m_ImportedButNotParsed.TryGetValue(s_Missed, out var s_By))
                                m_ImportedButNotParsed[s_Missed] = s_By = new List<string>();
                            s_By.Add(s_Name);
                        }
                    }

                    continue;
                }

                foreach (var s_Import in s_Imports)
                {
                    if (!s_CandidateGuids.TryGetValue(s_Import, out var s_Target))
                        continue;

                    if (!s_Types.TryGetValue(s_Name, out var s_Type))
                    {
                        var s_Variant = s_Partitions[i].Value.FirstVariant;
                        try
                        {
                            s_Type = m_Converter.FromPartitionObject(s_Name, s_Variant).PrimaryInstance?.GetType().Name ?? "?";
                        }
                        catch (Exception)
                        {
                            s_Type = "?";
                        }

                        s_Type = $"{s_Name} [{s_Type}] ({s_Variant.GetContainedSuperbundle()?.ToLowerInvariant()})";
                        s_Types[s_Name] = s_Type;
                    }

                    if (!m_OutsideImporters.TryGetValue(s_Target, out var s_List))
                        m_OutsideImporters[s_Target] = s_List = new List<string>();
                    s_List.Add(s_Type);
                }
            }

            p_Writer.WriteLine($"  {m_OutsideImporters.Count} of {s_Candidates.Count} unreferenced level partitions are imported from outside the level" +
                               (s_Unreadable > 0 ? $"; {s_Unreadable} headers could not be read" : ""));

            if (m_ImportedButNotParsed.Count > 0)
            {
                p_Writer.WriteLine($"  {m_ImportedButNotParsed.Count} are imported by level partitions whose parsed data has no reference to them (parse gaps), importers:");
                foreach (var s_Group in m_ImportedButNotParsed.SelectMany(p_P => p_P.Value).GroupBy(p_X => p_X).OrderByDescending(p_G => p_G.Count()).Take(15))
                    p_Writer.WriteLine($"    {s_Group.Count(),6}  {s_Group.Key} [{m_ItemTypes.GetValueOrDefault($"ebx:{s_Group.Key}") ?? "?"}]");
                foreach (var (s_Item, s_By) in m_ImportedButNotParsed)
                    m_Problems.Add($"{s_Item} is in the import table of {string.Join(", ", s_By.Take(3))} but no parsed field references it");
            }
        }

        /// <summary>Whether a partition outside every level superbundle imports the item.</summary>
        private bool ImportedByShared(string p_Item)
        {
            return m_OutsideImporters.TryGetValue(p_Item, out var s_Importers) &&
                   s_Importers.Any(p_I => !p_I[p_I.LastIndexOf(" (", StringComparison.Ordinal)..].Contains("levels/", StringComparison.OrdinalIgnoreCase));
        }

        private string? ResolvePartition(GUID p_Guid)
        {
            return m_Mounter.TryGetPartitionByGuid(p_Guid, out var s_Name, out _) ? s_Name : null;
        }

        private static T? TryCreate<T>(EngineType p_Engine, TextWriter p_Writer) where T : class, IEngineInterface
        {
            try
            {
                return EngineInterfaceRegistry.Create<T>(p_Engine);
            }
            catch (Exception s_Ex)
            {
                p_Writer.WriteLine($"WARN: no {typeof(T).Name} for {p_Engine} ({s_Ex.Message}); its part of the analysis is skipped.");
                return null;
            }
        }

        private static void WriteSummary(TextWriter p_Writer, string p_MainBundle, List<ItemOrigin> p_Origins, List<AggregateBreakdown> p_Aggregates)
        {
            p_Writer.WriteLine();
            p_Writer.WriteLine($"=== {p_MainBundle}: {p_Origins.Count} items, by what needs them");

            foreach (var s_Group in p_Origins.GroupBy(p_O => p_O.Origin).OrderBy(p_G => p_G.Key))
            {
                p_Writer.WriteLine($"--- {s_Group.Key}: {s_Group.Count()}");

                foreach (var s_ByType in s_Group.GroupBy(p_O => $"{p_O.Item.Split(':')[0]} {p_O.Type ?? "?"}").OrderByDescending(p_G => p_G.Count()).Take(10))
                    p_Writer.WriteLine($"    {s_ByType.Count(),6}  {s_ByType.Key}");

                if (s_Group.Key == "sub-bundle content only")
                {
                    p_Writer.WriteLine("    needed by:");
                    foreach (var s_ByBundle in s_Group.SelectMany(p_O => p_O.NeededBy).GroupBy(p_B => p_B).OrderByDescending(p_G => p_G.Count()).Take(20))
                        p_Writer.WriteLine($"    {s_ByBundle.Count(),6}  {s_ByBundle.Key}");
                }

                if (s_Group.Key == "listed by an index only")
                {
                    p_Writer.WriteLine("    listed by:");
                    foreach (var s_ByIndex in s_Group.SelectMany(p_O => p_O.ListedBy).GroupBy(p_X => p_X).OrderByDescending(p_G => p_G.Count()).Take(20))
                        p_Writer.WriteLine($"    {s_ByIndex.Count(),6}  {s_ByIndex.Key}");
                }

                if (s_Group.Key.StartsWith("root, imported"))
                {
                    p_Writer.WriteLine("    imported by [type] (superbundle):");
                    foreach (var s_ByImporter in s_Group.SelectMany(p_O => p_O.ImportedBy.Select(p_I => p_I[(p_I.IndexOf(" [", StringComparison.Ordinal) + 1)..]).Distinct())
                                 .GroupBy(p_X => p_X).OrderByDescending(p_G => p_G.Count()).Take(20))
                        p_Writer.WriteLine($"    {s_ByImporter.Count(),6}  {s_ByImporter.Key}");
                }

                if (s_Group.Key.StartsWith("root"))
                {
                    p_Writer.WriteLine("    by name prefix:");
                    foreach (var s_ByPrefix in s_Group.GroupBy(p_O => string.Join("/", p_O.Item.Split(':', 2)[1].Split('/').Take(2))).OrderByDescending(p_G => p_G.Count()).Take(15))
                        p_Writer.WriteLine($"    {s_ByPrefix.Count(),6}  {s_ByPrefix.Key}");
                }
            }

            p_Writer.WriteLine();
            p_Writer.WriteLine("=== aggregates, entry by entry");
            foreach (var s_Aggregate in p_Aggregates.Where(p_A => p_A.Entries.Count > 0))
            {
                p_Writer.WriteLine($"--- {s_Aggregate.Aggregate}  [in {string.Join(", ", s_Aggregate.OwnerBundles)}]");
                foreach (var (s_Class, s_Count) in s_Aggregate.Entries.OrderByDescending(p_E => p_E.Value).Take(6))
                    p_Writer.WriteLine($"    {s_Count,6}  {(s_Class.Length > 160 ? s_Class[..157] + "..." : s_Class)}");
            }
        }

        private class BundleCoverage
        {
            public string Bundle { get; set; } = "";
            public int Items { get; set; }
            public List<CoverageStage> Stages { get; set; } = new();
            public List<UncoveredItem> Uncovered { get; set; } = new();

            [JsonIgnore]
            public HashSet<string> Closure { get; set; } = new();
        }

        private class CoverageStage
        {
            public string Name { get; set; } = "";
            public int Roots { get; set; }
            public int CoveredAfter { get; set; }
            public Dictionary<string, int> RootTypes { get; set; } = new();
            public List<string> RootSamples { get; set; } = new();
        }

        private class UncoveredItem
        {
            public string Item { get; set; } = "";
            public string? Type { get; set; }
            public List<string> NeededBy { get; set; } = new();
            public List<string> ListedBy { get; set; } = new();
            public List<string> SuppliedFor { get; set; } = new();
        }

        private class ItemOrigin
        {
            public string Item { get; set; } = "";
            public string? Type { get; set; }
            public string Origin { get; set; } = "";
            public List<string> NeededBy { get; set; } = new();
            public List<string> ListedBy { get; set; } = new();
            public List<string> AlsoIn { get; set; } = new();
            public List<string> OtherSuperbundles { get; set; } = new();
            public List<string> ImportedBy { get; set; } = new();
        }

        private class AggregateBreakdown
        {
            public string Aggregate { get; set; } = "";
            public List<string> OwnerBundles { get; set; } = new();
            public Dictionary<string, int> Entries { get; set; } = new();

            public void Count(string p_Class) => Entries[p_Class] = Entries.GetValueOrDefault(p_Class) + 1;
        }
    }
}
