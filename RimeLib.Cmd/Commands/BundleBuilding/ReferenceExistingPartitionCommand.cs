using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Mesh;
using RimeLib.Serialization;
using RimeLib.Serialization.Attributes;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Adds one existing partition and everything the game reaches for once it loads.
    ///
    /// The closure has three layers. A bundle that stops after the first one still crashes:
    ///  1. EBX instance fields: other partitions, resources named after an Asset, chunk guids.
    ///  2. Chunk guids read out of a resource payload (MeshSet lods, DxTexture mips).
    ///  3. Resource names read out of a resource payload (terrain, Enlighten).
    ///
    /// Anything a dependency bundle already carries is skipped, so the level's own copy wins and
    /// nothing is registered twice.
    /// </summary>
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

        private readonly Queue<string> m_PartitionQueue = new();
        private readonly Queue<string> m_ResourceQueue = new();
        // AssetName picks the variant, and is set only for a chunk named by a resource payload.
        // Origin is for the log, so a chunk traces back to whatever asked for it.
        private readonly Queue<(GUID Id, string? AssetName, string Origin)> m_ChunkQueue = new();

        private readonly HashSet<string> m_SeenPartitions = new(StringComparer.OrdinalIgnoreCase);
        // The partition that first referenced each queued one, for the log.
        private readonly Dictionary<string, string> m_ReferencedFrom = new(StringComparer.OrdinalIgnoreCase);
        private readonly HashSet<string> m_SeenResources = new(StringComparer.OrdinalIgnoreCase);
        private readonly HashSet<GUID> m_SeenChunks = new();

        private readonly List<string> m_Unresolved = new();

        private readonly HashSet<string> m_ExcludedPartitions = new(StringComparer.OrdinalIgnoreCase);
        private readonly HashSet<string> m_ExcludedResources = new(StringComparer.OrdinalIgnoreCase);

        // Excluded partitions whose references are still walked: those only walked dependency
        // bundles carry.
        private readonly HashSet<string> m_WalkedPartitions = new(StringComparer.OrdinalIgnoreCase);
        private int m_Walked;
        private string[] m_SkipPrefixes = Array.Empty<string>();


        private BundleBuildingContext m_Context = null!;
        private IEngineMounter m_Mounter = null!;
        private IPartitionConverter m_PartitionConverter = null!;
        private ITextureConverter? m_TextureConverter;
        private IMeshConverter? m_MeshConverter;
        private AssetReferenceScanner m_Scanner = null!;
        private TextWriter m_Writer = null!;

        private int m_AddedPartitions;
        private int m_AddedResources;
        private int m_AddedChunks;
        private int m_AddedMeshes;
        private int m_Skipped;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("usage: reference_existing_partition <name> [id] [strict] [skip_prefixes]");
                return false;
            }

            m_Context = (BundleBuildingContext)p_Context;
            m_Writer = p_Writer;

            var s_SbBuildingContext = (SbBuildingContext)m_Context.Parent!;
            var s_BaseContext = (BaseContext)s_SbBuildingContext.Parent!;

            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_Mounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first.");
                return false;
            }

            if (s_Mounter.GetEngineType() != s_SbBuildingContext.EngineType)
            {
                p_Writer.WriteLine($"Cross-engine support has not been added, ({s_Mounter.GetEngineType()} != {s_SbBuildingContext.EngineType})");
                return false;
            }

            m_Mounter = s_Mounter;
            m_PartitionConverter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Mounter.GetEngineType());

            try
            {
                m_TextureConverter = EngineInterfaceRegistry.Create<ITextureConverter>(s_SbBuildingContext.EngineType);
            }
            catch (Exception s_Ex)
            {
                // Without it every texture ships its header and no pixels, so warn instead of
                // quietly building a bundle of blank textures.
                p_Writer.WriteLine($"WARN: no texture converter ({s_Ex.Message}). Texture chunks will not be resolved.");
            }

            try
            {
                m_MeshConverter = EngineInterfaceRegistry.Create<IMeshConverter>(s_SbBuildingContext.EngineType);
            }
            catch (Exception s_Ex)
            {
                // Same as textures: without it every mesh ships without its streamed geometry.
                p_Writer.WriteLine($"WARN: no mesh converter ({s_Ex.Message}). Mesh chunks will not be resolved.");
            }

            m_Scanner = new AssetReferenceScanner(m_Mounter, m_PartitionConverter, m_TextureConverter, m_MeshConverter)
            {
                BindMeshVariationTextures = m_Context.BindMeshVariationTextures,
            };

            m_SkipPrefixes = string.IsNullOrWhiteSpace(SkipPrefixes)
                ? Array.Empty<string>()
                : SkipPrefixes!.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            WarnOnPartialMount(p_Writer);

            CollectExclusions();
            MeshVariationDbIndex.Build(m_Mounter, p_Writer);

            // What earlier commands already put in the bundle counts as done, so a second run for
            // another partition does not re-walk the first one's closure.
            m_SeenPartitions.UnionWith(m_Context.GetPartitions().Keys);
            m_SeenResources.UnionWith(m_Context.GetResources().Keys);
            m_SeenChunks.UnionWith(m_Context.GetChunks().Keys);

            var s_Root = Name!.ToLowerInvariant();

            // The named partition is what was asked for, so it goes in even if it is already seen.
            m_SeenPartitions.Remove(s_Root);
            m_PartitionQueue.Enqueue(s_Root);

            while (m_PartitionQueue.Count > 0 || m_ResourceQueue.Count > 0 || m_ChunkQueue.Count > 0)
            {
                while (m_PartitionQueue.Count > 0)
                    ProcessPartition(m_PartitionQueue.Dequeue());

                while (m_ResourceQueue.Count > 0)
                    ProcessResource(m_ResourceQueue.Dequeue());

                while (m_ChunkQueue.Count > 0)
                {
                    var (s_Id, s_AssetName, s_Origin) = m_ChunkQueue.Dequeue();
                    ProcessChunk(s_Id, s_AssetName, s_Origin);
                }
            }

            p_Writer.WriteLine($"Closure of '{Name}': +{m_AddedPartitions} partition(s), +{m_AddedResources} resource(s), +{m_AddedChunks} chunk(s), {m_Skipped} already covered{(m_Walked > 0 ? $", {m_Walked} of those walked" : "")}.");

            if (m_AddedMeshes > 0)
                p_Writer.WriteLine($"{m_AddedMeshes} mesh(es) added, with the textures their MeshVariationDatabase entries bind.");

            if (m_Unresolved.Count > 0)
            {
                p_Writer.WriteLine($"{m_Unresolved.Count} unresolved reference(s):");
                foreach (var s_Line in m_Unresolved)
                    p_Writer.WriteLine($"  {s_Line}");

                if (Strict)
                {
                    p_Writer.WriteLine("Refusing to continue. Mount the superbundle that holds them, or pass strict=false to build anyway.");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// A partial mount makes the closure wrong in two ways, and only one of them is visible.
        /// A referenced partition in an unmounted superbundle is reported as unresolved, which strict
        /// mode catches. A MeshVariationDatabase in an unmounted superbundle is simply absent from the
        /// index, so the meshes it binds ship without their textures and nothing reports it.
        /// </summary>
        private void WarnOnPartialMount(TextWriter p_Writer)
        {
            var s_Mounted = m_Mounter.GetMountedSuperbundles().Count();
            var s_Available = m_Mounter.GetAvailableSuperbundles().Count();

            if (s_Mounted >= s_Available)
                return;

            p_Writer.WriteLine($"WARN: {s_Mounted} of {s_Available} superbundles mounted. References and mesh textures outside them cannot be found. Mount the game with automount for a complete closure.");
        }

        /// <summary>
        /// A dependency bundle is declared loaded before ours, so everything it carries is already
        /// there and a second copy registers it twice.
        ///
        /// Chunks are deliberately not excluded. A bundle-resident chunk resolves through a hash
        /// table the engine builds per bundle, so a chunk in the level's bundle is not reachable
        /// from ours, and a miss on that path hangs retail instead of failing.
        /// </summary>
        private void CollectExclusions()
        {
            var s_Walked = m_Context.GetWalkedDependencyBundles();
            var s_SelfContained = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var s_Bundle in m_Context.GetDependencyBundles())
            {
                AddBundleCoverage(s_Bundle, m_ExcludedPartitions, m_ExcludedResources);
                if (s_Walked.Contains(s_Bundle))
                    AddBundleCoverage(s_Bundle, m_WalkedPartitions, new HashSet<string>());
                else
                    AddBundleCoverage(s_Bundle, s_SelfContained, new HashSet<string>());
            }
            m_WalkedPartitions.ExceptWith(s_SelfContained);

            CollectScenarioExclusions();

            if (m_ExcludedPartitions.Count > 0 || m_ExcludedResources.Count > 0)
                m_Writer.WriteLine($"Dependency bundles cover {m_ExcludedPartitions.Count} partition(s) and {m_ExcludedResources.Count} resource(s).");
        }

        /// <summary>
        /// Scenarios are mutually exclusive loadouts, so only what every one of them carries is
        /// certain to be there. That is the intersection, not the union: anything a single scenario
        /// lacks has to ship, or the bundle breaks on that one.
        /// </summary>
        private void CollectScenarioExclusions()
        {
            var s_Scenarios = m_Context.GetScenarios();

            if (s_Scenarios.Count == 0)
                return;

            HashSet<string>? s_Shared = null;
            HashSet<string>? s_SharedResources = null;

            foreach (var s_Scenario in s_Scenarios)
            {
                var s_Partitions = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                var s_Resources = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                foreach (var s_Bundle in s_Scenario.Value)
                {
                    if (!BundleExists(s_Bundle, s_Scenario.Key))
                        continue;

                    AddBundleCoverage(s_Bundle, s_Partitions, s_Resources);
                }

                if (s_Shared == null)
                {
                    s_Shared = s_Partitions;
                    s_SharedResources = s_Resources;
                    continue;
                }

                s_Shared.IntersectWith(s_Partitions);
                s_SharedResources!.IntersectWith(s_Resources);
            }

            m_ExcludedPartitions.UnionWith(s_Shared!);
            m_ExcludedResources.UnionWith(s_SharedResources!);

            m_Writer.WriteLine(
                $"{s_Scenarios.Count} scenario(s) all carry {s_Shared!.Count} partition(s) and {s_SharedResources!.Count} resource(s).");
        }

        /// <summary>
        /// An unknown bundle enumerates as empty rather than failing, which would silently empty the
        /// intersection and turn the whole gate off. A named scenario bundle has to exist.
        /// </summary>
        private bool BundleExists(string p_Bundle, string p_Scenario)
        {
            if (m_Mounter.GetAvailableBundles().Contains(p_Bundle, StringComparer.OrdinalIgnoreCase))
                return true;

            if (m_Mounter.GetAvailableSuperbundles().Contains(p_Bundle, StringComparer.OrdinalIgnoreCase))
            {
                m_Writer.WriteLine(
                    $"WARN: scenario '{p_Scenario}' names superbundle '{p_Bundle}', which is not a bundle. Only some of a superbundle's bundles load at once. Name the bundles that load.");
            }
            else
            {
                m_Writer.WriteLine($"WARN: scenario '{p_Scenario}' names unknown bundle '{p_Bundle}'.");
            }

            return false;
        }

        private void AddBundleCoverage(string p_Bundle, HashSet<string> p_Partitions, HashSet<string> p_Resources)
        {
            try
            {
                foreach (var s_Partition in m_Mounter.GetPartitionsInBundle(p_Bundle))
                    p_Partitions.Add(s_Partition);

                foreach (var s_Resource in m_Mounter.GetResourcesInBundle(p_Bundle))
                    p_Resources.Add(s_Resource.Name);
            }
            catch (Exception s_Ex)
            {
                m_Writer.WriteLine($"WARN: could not enumerate dependency bundle '{p_Bundle}': {s_Ex.Message}");
            }
        }

        private void ProcessPartition(string p_Name)
        {
            if (!m_SeenPartitions.Add(p_Name))
                return;

            if (IsSkippedByPrefix(p_Name))
            {
                m_Skipped++;
                return;
            }

            // A self-contained dependency bundle brings its own closure, so there is nothing left to
            // walk here. A walked one does not: its content's references still ship with us.
            if (m_ExcludedPartitions.Contains(p_Name))
            {
                m_Skipped++;
                if (m_WalkedPartitions.Contains(p_Name) && m_Mounter.TryGetPartition(p_Name, out var s_Walked))
                {
                    m_Walked++;
                    Enqueue(m_Scanner.ScanPartition(p_Name, s_Walked.FirstVariant), p_Name);
                }
                return;
            }

            if (!m_Mounter.TryGetPartition(p_Name, out var s_Partition))
            {
                m_Unresolved.Add($"partition {p_Name}");
                return;
            }

            var s_Variant = m_Context.Cas()
                ? s_Partition.Variants.FirstOrDefault(p_V => p_V.Cas && p_V.GetContainedBundle() != null) ?? s_Partition.FirstVariant
                : s_Partition.FirstVariant;

            m_Context.AddPartition(p_Name, s_Variant);
            m_AddedPartitions++;
            m_Writer.WriteLine(m_ReferencedFrom.TryGetValue(p_Name, out var s_From) ? $"PART {p_Name} <- {s_From}" : $"PART {p_Name}");

            Enqueue(m_Scanner.ScanPartition(p_Name, s_Variant), p_Name);
        }

        private void ProcessResource(string p_Name)
        {
            if (!m_SeenResources.Add(p_Name))
                return;

            if (IsSkippedByPrefix(p_Name) || m_ExcludedResources.Contains(p_Name))
            {
                m_Skipped++;
                return;
            }

            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
            {
                // Most names tried here are speculative suffixes, so a miss is normal and not worth
                // reporting.
                return;
            }

            var s_Variant = m_Context.Cas()
                ? s_Resource.Variants.FirstOrDefault(p_V => p_V.Cas && p_V.GetContainedBundle() != null) ?? s_Resource.FirstVariant
                : s_Resource.Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() != null) ?? s_Resource.FirstVariant;

            m_Context.AddResource(p_Name, s_Variant);
            m_AddedResources++;

            var s_Type = s_Variant.GetResourceType();
            m_Writer.WriteLine($"RES  {p_Name} ({s_Type})");

            if (s_Type == ResourceType.MeshSet)
                m_AddedMeshes++;

            var s_References = m_Scanner.ScanResource(p_Name, s_Variant);

            foreach (var s_PayloadResource in s_References.PayloadResources)
                m_Writer.WriteLine($"PAY  {p_Name} -> res {s_PayloadResource}");

            Enqueue(s_References, $"res {p_Name}");
        }

        private void ProcessChunk(GUID p_Id, string? p_AssetName, string p_Origin)
        {
            if (!m_SeenChunks.Add(p_Id))
                return;

            if (!m_Mounter.TryGetChunk(p_Id, out var s_Chunk))
            {
                m_Unresolved.Add($"chunk {p_Id} (from {p_Origin})");
                return;
            }

            // The variant that carries the owner's name hash is the one the game's own bundle ships.
            // It is ranged to exactly the slice that resource asks for. Any other variant is a
            // different slice of the same payload and reads the wrong bytes.
            IChunkVariant? s_Variant = null;
            if (!string.IsNullOrEmpty(p_AssetName))
            {
                var s_Hash = (int)RimeLib.Frostbite.Utils.HashQuick(p_AssetName!);
                s_Variant = s_Chunk.Variants.FirstOrDefault(p_V => p_V.GetAssetNameHash() == s_Hash);
            }

            s_Variant ??= s_Chunk.Variants.FirstOrDefault(p_V => p_V.GetAssetNameHash() != null) ?? s_Chunk.FirstVariant;

            m_Context.AddChunk(p_Id, s_Variant);
            m_AddedChunks++;
            m_Writer.WriteLine($"CHNK {p_Id} <- {p_Origin}");
        }

        /// <summary>Queues everything one scanned item references, and records what it could not scan.</summary>
        private void Enqueue(AssetReferenceScanner.References p_References, string? p_From)
        {
            foreach (var s_Partition in p_References.Partitions)
            {
                if (p_From != null)
                    m_ReferencedFrom.TryAdd(s_Partition, p_From);
                m_PartitionQueue.Enqueue(s_Partition);
            }

            foreach (var s_Resource in p_References.Resources)
                m_ResourceQueue.Enqueue(s_Resource);

            foreach (var s_Chunk in p_References.Chunks)
                m_ChunkQueue.Enqueue(s_Chunk);

            m_Unresolved.AddRange(p_References.Problems);
        }

        private bool IsSkippedByPrefix(string p_Name)
        {
            foreach (var s_Prefix in m_SkipPrefixes)
            {
                if (p_Name.StartsWith(s_Prefix, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }
    }
}
