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
using RimeLib.Mesh.Frostbite;
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

        // A named instance is tried as a resource with each of these appended. Every one is a real
        // bind the engine performs off Asset.Name. The ones that do not apply to a given name simply
        // miss, so there is no need to know which type wants which.
        //
        // Lowercase because that is how a manifest spells a name. The binary has them as
        // `_occluderMesh`, `/ShaderDb` and `.Visual`. `.streamingtree` and `.decals` are the odd
        // ones out: their authoritative names live inside the VisualTerrain payload, which layer 3
        // reads. They stay here as a fallback, because the convention only usually matches.
        private static readonly string[] c_NameSuffixes =
        {
            "",
            "_occludermesh",
            "/shaderdb",
            ".visual",
            ".streamingtree",
            ".decals",
        };

        private readonly Queue<string> m_PartitionQueue = new();
        private readonly Queue<string> m_ResourceQueue = new();
        // AssetName picks the variant, and is set only for a chunk named by a resource payload.
        // Origin is for the log, so a chunk traces back to whatever asked for it.
        private readonly Queue<(GUID Id, string? AssetName, string Origin)> m_ChunkQueue = new();

        private readonly HashSet<string> m_SeenPartitions = new(StringComparer.OrdinalIgnoreCase);
        private readonly HashSet<string> m_SeenResources = new(StringComparer.OrdinalIgnoreCase);
        private readonly HashSet<GUID> m_SeenChunks = new();

        private readonly List<string> m_Unresolved = new();

        private readonly HashSet<string> m_ExcludedPartitions = new(StringComparer.OrdinalIgnoreCase);
        private readonly HashSet<string> m_ExcludedResources = new(StringComparer.OrdinalIgnoreCase);
        private string[] m_SkipPrefixes = Array.Empty<string>();

        // The instance being walked, so a chunk found by the guid sweep can name what asked for it.
        private string m_Origin = string.Empty;

        private BundleBuildingContext m_Context = null!;
        private IEngineMounter m_Mounter = null!;
        private IPartitionConverter m_PartitionConverter = null!;
        private ITextureConverter? m_TextureConverter;
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

            p_Writer.WriteLine($"Closure of '{Name}': +{m_AddedPartitions} partition(s), +{m_AddedResources} resource(s), +{m_AddedChunks} chunk(s), {m_Skipped} already covered.");

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
            foreach (var s_Bundle in m_Context.GetDependencyBundles())
                AddBundleCoverage(s_Bundle, m_ExcludedPartitions, m_ExcludedResources);

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

            // A dependency bundle is self-contained, so its copy brings its own closure and there is
            // nothing left to walk here.
            if (m_ExcludedPartitions.Contains(p_Name))
            {
                m_Skipped++;
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
            m_Writer.WriteLine($"PART {p_Name}");

            try
            {
                var s_Parsed = m_PartitionConverter.FromPartitionObject(p_Name, s_Variant);

                foreach (var s_Instance in s_Parsed.Instances)
                {
                    m_Origin = $"{p_Name}#{s_Instance?.GetType().Name}";
                    WalkInstance(s_Instance);
                }

                CollectMeshVariationTextures(p_Name, s_Parsed.PartitionGuid);
            }
            catch (Exception s_Ex)
            {
                m_Unresolved.Add($"partition {p_Name} could not be parsed: {s_Ex.Message}");
            }
        }

        /// <summary>
        /// The textures a mesh partition's MeshVariationDatabase entries bind. Nothing in the EBX
        /// names these, so this index is the only way a closure walk reaches them.
        /// </summary>
        private void CollectMeshVariationTextures(string p_Name, GUID p_PartitionGuid)
        {
            if (!MeshVariationDbIndex.TryGetTexturePartitions(p_PartitionGuid, out var s_Textures))
                return;

            foreach (var s_Texture in s_Textures)
            {
                if (!m_Mounter.TryGetPartitionByGuid(s_Texture, out var s_TextureName, out _))
                {
                    m_Unresolved.Add($"MVDB texture partition {s_Texture} bound by a mesh in {p_Name}");
                    continue;
                }

                m_PartitionQueue.Enqueue(s_TextureName);
            }
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

            CollectPayloadChunks(p_Name, s_Variant, s_Type);
            CollectPayloadNames(p_Name, s_Variant, s_Type);
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

        /// <summary>
        /// Layer 3: the resource names a resource holds inside its own payload. An EBX walk cannot
        /// reach these, and neither can a chunk-guid walk, so a level with terrain or Enlighten is
        /// under-resolved without them.
        /// </summary>
        private void CollectPayloadNames(string p_Name, IResourceVariant p_Variant, ResourceType p_Type)
        {
            if (!ResourcePayloadDependencies.Handles(p_Type))
                return;

            byte[] s_Data;
            try
            {
                using var s_Source = p_Variant.GetReader();
                s_Data = s_Source.ReadBytes((int)s_Source.Length);
            }
            catch (Exception s_Ex)
            {
                m_Unresolved.Add($"resource {p_Name} ({p_Type}) payload could not be read: {s_Ex.Message}");
                return;
            }

            var s_Payload = ResourcePayloadDependencies.Read(p_Type, s_Data);

            if (s_Payload.Error != null)
            {
                m_Unresolved.Add($"resource {p_Name} ({p_Type}) payload could not be walked: {s_Payload.Error}");
                return;
            }

            foreach (var s_Resource in s_Payload.ResourceNames)
            {
                m_ResourceQueue.Enqueue(s_Resource);
                m_Writer.WriteLine($"PAY  {p_Name} -> res {s_Resource}");
            }

            foreach (var s_Partition in s_Payload.PartitionNames)
                m_PartitionQueue.Enqueue(s_Partition);

            foreach (var s_Chunk in s_Payload.ChunkIds)
                m_ChunkQueue.Enqueue((s_Chunk, p_Name, $"{p_Name} payload"));
        }

        /// <summary>Layer 2: the chunk guids a resource reads out of its own payload.</summary>
        private void CollectPayloadChunks(string p_Name, IResourceVariant p_Variant, ResourceType p_Type)
        {
            try
            {
                if (p_Type == ResourceType.DxTexture || p_Type == ResourceType.Ps3Texture)
                {
                    if (m_TextureConverter == null)
                        return;

                    // A non-chunked texture keeps its whole payload in the resource.
                    var s_ChunkId = m_TextureConverter.GetTextureChunkId(p_Variant);
                    if (s_ChunkId != GUID.Empty)
                        m_ChunkQueue.Enqueue((s_ChunkId, p_Name, p_Name));
                }
                else if (p_Type == ResourceType.MeshSet)
                {
                    m_AddedMeshes++;

                    using var s_Source = p_Variant.GetReader();
                    var s_Data = s_Source.ReadBytes((int)s_Source.Length);
                    using var s_Reader = new RimeReader(new MemoryStream(s_Data));

                    var s_Layout = new MeshSetLayout(s_Reader);

                    // MeshSetLayout has its own flag set. Bit 0 is StreamingEnable here, but
                    // IsBaseLod on a MeshLayout. With it clear there is no chunk and the geometry
                    // sits inline.
                    if (((uint)s_Layout.Flags & 1) == 0)
                        return;

                    // Every lod, not just the base one. IsBaseLod decides when a lod is pulled, not
                    // whether. The streaming manager reads m_dataChunkId for arbitrary lods later,
                    // so a missing non-base chunk fails at stream-in instead of at level load.
                    for (var i = 0; i < s_Layout.LodCount; ++i)
                    {
                        var s_Lod = s_Layout.Lods[i].Object;
                        if (s_Lod != null && s_Lod.DataChunkId != GUID.Empty)
                            m_ChunkQueue.Enqueue((s_Lod.DataChunkId, p_Name, $"{p_Name} lod{i}"));
                    }
                }
            }
            catch (Exception s_Ex)
            {
                m_Unresolved.Add($"resource {p_Name} ({p_Type}) payload could not be read for chunks: {s_Ex.Message}");
            }
        }

        /// <summary>Layer 1: everything an instance names, by reference, by resource name or by chunk guid.</summary>
        private void WalkInstance(DataContainerBase? p_Instance)
        {
            if (p_Instance == null)
                return;

            CollectFields(p_Instance);

            var s_Type = p_Instance.GetType();

            if (s_Type.GetProperty("Name")?.GetValue(p_Instance) is string s_Name && s_Name.Length > 0)
            {
                var s_Lower = s_Name.ToLowerInvariant();

                foreach (var s_Suffix in c_NameSuffixes)
                    m_ResourceQueue.Enqueue($"{s_Lower}{s_Suffix}");
            }

            if (s_Type.GetProperty("ResourceName")?.GetValue(p_Instance) is string s_ResourceName && s_ResourceName.Length > 0)
                m_ResourceQueue.Enqueue(s_ResourceName.ToLowerInvariant());
        }

        /// <summary>
        /// Walks the reflected fields of an instance or a nested struct, collecting partition
        /// references and chunk guids.
        ///
        /// Guids are matched against the mounted chunk table instead of a list of known chunk
        /// fields. Most guid fields hold partition or instance ids, which are not in that table, so
        /// the table does the classifying and nothing has to be listed by hand.
        /// </summary>
        private void CollectFields(object? p_Object)
        {
            if (p_Object == null)
                return;

            var s_Properties = p_Object.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p_P => p_P.GetCustomAttribute<ContainerFieldAttribute>() != null);

            foreach (var s_Property in s_Properties)
            {
                object? s_Value;
                try
                {
                    s_Value = s_Property.GetValue(p_Object);
                }
                catch
                {
                    continue;
                }

                CollectValue(s_Value);
            }
        }

        private void CollectValue(object? p_Value)
        {
            switch (p_Value)
            {
                case null:
                    return;

                case CtrRefBase s_Ref:
                    if (!s_Ref.IsNull())
                        m_PartitionQueue.Enqueue(ResolvePartitionName(s_Ref.PartitionGuid));
                    return;

                case GUID s_Guid:
                    if (s_Guid != GUID.Empty && m_Mounter.TryGetChunk(s_Guid, out _))
                        m_ChunkQueue.Enqueue((s_Guid, null, m_Origin));
                    return;

                case string:
                    return;

                case EbxSerializable s_Serializable:
                    CollectFields(s_Serializable);
                    return;

                case IEnumerable s_Enumerable:
                    foreach (var s_Item in s_Enumerable)
                        CollectValue(s_Item);
                    return;
            }
        }

        private string ResolvePartitionName(GUID p_Guid)
        {
            if (m_Mounter.TryGetPartitionByGuid(p_Guid, out var s_Name, out _))
                return s_Name;

            // Return the guid as the name, so the miss is reported once on the same path as every
            // other miss, instead of being counted here and lost when the reference shows up again.
            return p_Guid.ToString();
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
