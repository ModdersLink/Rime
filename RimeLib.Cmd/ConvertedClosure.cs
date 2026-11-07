using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Animation.Frostbite;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.Havok;
using RimeLib.IO;
using RimeLib.Mesh.Sets;
using RimeLib.Shader;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;
using RimeLib.Terrain.Resources;
using RimeLib.Texture.Images;

namespace RimeLib.Cmd
{
    /// <summary>
    /// The partitions a root reaches in a game of another engine, converted to the engine of the
    /// bundle being built and added to it. Every partition is converted before any is written, as
    /// some fields depend on others. Partitions the level's bundle, the superbundle's first to convert,
    /// converted are referenced, not added again; references to partitions the closure leaves out are left null.
    /// Physics, destruction, mesh, texture, occluder and terrain resources are converted to the bundle's engine with the
    /// chunks they stream from, keeping their ids, which the partitions refer to them by; other
    /// resources and chunks are counted, not converted.
    /// </summary>
    internal sealed class ConvertedClosure
    {
        public sealed record Result(int Partitions, int Skipped, int Resources, int ConvertedResources, int Chunks, IReadOnlyList<string> Unresolved);

        private readonly BundleBuildingContext m_Context;
        private readonly IEngineMounter m_Mounter;
        private readonly AssetReferenceScanner m_Scanner;
        private readonly IPartitionConverter m_Reader;
        private readonly string[] m_SkipPrefixes;

        /// <summary>Skipped prefixes whose partitions the target game supplies itself, under the same name and GUID.</summary>
        private readonly string[] m_TargetOwnPrefixes;
        private readonly (string From, string To)? m_Move;

        /// <summary>
        /// Per source MeshSet, the vertex layouts subsets are repacked to, by LOD and subset index,
        /// for their shader to have a solution for them.
        /// </summary>
        private readonly Dictionary<string, Dictionary<(int Lod, int Subset), VertexLayout>> m_Layouts = new(StringComparer.OrdinalIgnoreCase);

        public ConversionReport Report { get; private set; } = new();

        /// <summary>Where to write each converted partition as JSON, if anywhere.</summary>
        public DirectoryInfo? Dump { get; set; }

        private ConvertedClosure(BundleBuildingContext p_Context, IEngineMounter p_Mounter, string[] p_SkipPrefixes, (string From, string To)? p_Move)
        {
            m_Context = p_Context;
            m_Mounter = p_Mounter;
            // A prefix marked '+' is the target's own: skipped, its partitions shipped from the target game.
            m_SkipPrefixes = p_SkipPrefixes.Select(p_P => p_P.TrimStart('+')).ToArray();
            m_TargetOwnPrefixes = p_SkipPrefixes.Where(p_P => p_P.StartsWith('+')).Select(p_P => p_P[1..]).ToArray();
            m_Move = p_Move;
            m_Reader = EngineInterfaceRegistry.Create<IPartitionConverter>(p_Mounter.GetEngineType());
            m_Scanner = new AssetReferenceScanner(p_Mounter, m_Reader, null, null) { BindMeshVariationTextures = false };
        }

        /// <summary>
        /// A closure over the bundle being built, from the game mounted as <paramref name="p_Id"/>.
        /// Null, with the reason written to <paramref name="p_Log"/>, when there is no such game or it
        /// is of the bundle's own engine.
        /// </summary>
        /// <param name="p_Move">Names, and strings naming them, starting with From are moved under To.</param>
        public static ConvertedClosure? Create(BundleBuildingContext p_Context, int p_Id, IReadOnlyList<string> p_SkipPrefixes, (string From, string To)? p_Move, TextWriter p_Log)
        {
            var s_SbBuildingContext = (SbBuildingContext)p_Context.Parent!;
            var s_BaseContext = (BaseContext)s_SbBuildingContext.Parent!;

            if (!s_BaseContext.GetMounters().TryGetValue(p_Id, out var s_Mounter))
            {
                p_Log.WriteLine($"Id ({p_Id}) is not valid, ensure you mounted a game first.");
                return null;
            }

            if (s_Mounter.GetEngineType() == s_SbBuildingContext.EngineType)
            {
                p_Log.WriteLine($"The game mounted as {p_Id} is of the bundle's own engine; reference_existing_partition adds its content as it is.");
                return null;
            }

            return new ConvertedClosure(p_Context, s_Mounter, p_SkipPrefixes.ToArray(), p_Move);
        }

        /// <summary>Converts the named partitions and their closure, and adds them to the bundle.</summary>
        public Result Add(IEnumerable<string> p_Roots, TextWriter p_Log)
        {
            p_Roots = p_Roots.ToList();
            var s_Parsed = new Dictionary<string, DatabasePartitionBase>(StringComparer.OrdinalIgnoreCase);
            var s_Seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var s_Queue = new Queue<string>(p_Roots.Select(p_R => p_R.ToLowerInvariant()));
            var s_Resources = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var s_Chunks = new Dictionary<GUID, string>();
            var s_Unresolved = new List<string>();
            var s_Skipped = 0;
            var s_TargetOwn = new Dictionary<string, GUID>(StringComparer.OrdinalIgnoreCase);

            var s_SbContext = (SbBuildingContext)m_Context.Parent!;
            var s_Earlier = s_SbContext.ConvertedPartitions;
            s_SbContext.SharedConversionBundle ??= m_Context.BundleName;
            var s_Shares = string.Equals(s_SbContext.SharedConversionBundle, m_Context.BundleName, StringComparison.OrdinalIgnoreCase);
            var s_Conversion = PartitionConversion.Between(m_Mounter.GetEngineType(), s_SbContext.EngineType);
            while (s_Queue.TryDequeue(out var s_Name))
            {
                if (!s_Seen.Add(s_Name) || s_Earlier.ContainsKey(s_Name))
                    continue;

                if (m_SkipPrefixes.Any(p_P => s_Name.StartsWith(p_P, StringComparison.OrdinalIgnoreCase)))
                {
                    s_Skipped++;
                    if (m_TargetOwnPrefixes.Any(p_P => s_Name.StartsWith(p_P, StringComparison.OrdinalIgnoreCase)) && TargetOwn(s_Name) is { } s_Own)
                        s_TargetOwn[s_Name] = s_Own;
                    continue;
                }

                if (!m_Mounter.TryGetPartition(s_Name, out var s_Partition))
                {
                    s_Unresolved.Add($"partition {s_Name}");
                    continue;
                }

                var s_References = m_Scanner.ScanPartition(s_Name, s_Partition.FirstVariant);
                if (s_References.Parsed == null)
                {
                    s_Unresolved.AddRange(s_References.Problems);
                    continue;
                }

                var s_Type = s_References.Parsed.PrimaryInstance.GetType().Name;
                if (s_ResourceAssets.TryGetValue(s_Type, out var s_Converts) && !s_Converts(m_Mounter.GetEngineType()))
                {
                    s_Skipped++;
                    p_Log.WriteLine($"SKIP {s_Name}: a {s_Type} keeps its data in a resource that is not converted");
                    continue;
                }

                // The target draws a converted debris cluster's composite parts without their transforms.
                if (s_References.Parsed.Instances.Any(p_I => p_I.GetType().Name == "DebrisClusterData"))
                {
                    s_Skipped++;
                    p_Log.WriteLine($"SKIP {s_Name}: debris clusters are not converted");
                    continue;
                }

                if (s_Conversion.Rules.HeldByReferrers.Contains(s_Type))
                {
                    s_Skipped++;
                    p_Log.WriteLine($"SKIP {s_Name}: what references a {s_Type} holds what it says");
                    continue;
                }

                s_Parsed[s_Name] = s_References.Parsed;
                s_Resources.UnionWith(s_References.Resources.Where(p_R => m_Mounter.TryGetResource(p_R, out _)));
                foreach (var s_Chunk in s_References.Chunks)
                    s_Chunks.TryAdd(s_Chunk.Id, s_Name);
                foreach (var s_Next in s_References.Partitions)
                    s_Queue.Enqueue(s_Next);
            }

            s_Conversion.ShippedPartitions = s_Parsed.Values.Select(p_P => p_P.PartitionGuid).Concat(s_Earlier.Values.Select(p_P => p_P.PartitionGuid))
                .Concat(s_TargetOwn.Values).ToHashSet();
            s_Conversion.Strings = Moved;
            // A resource the target names is named as it ships: moved, in lower case as bundles keep it.
            s_Conversion.ResourceNames = p_Ref => m_Mounter.TryGetResource(p_Ref, out var s_Named)
                && s_Named.FirstVariant.GetResourceType() is var s_Type && ResourceConverters.Ships(s_Type)
                    ? Moved(s_Named.OriginalName).ToLowerInvariant()
                    : null;
            var s_Materials = Materials(s_Conversion.Rules, p_Roots, p_Log);
            if (s_Materials != null)
            {
                var s_SourceRules = EngineInterfaceRegistry.Create<IMaterialGridRules>(m_Mounter.GetEngineType());
                s_Conversion.Values = (p_Value, p_Type) =>
                    s_SourceRules.TryGetPackedMaterial(p_Value, _ => null, out var s_Packed) && s_Materials.TryMap(s_Packed, out _, out var s_Value)
                    && p_Type.IsInstanceOfType(s_Value)
                        ? s_Value
                        : null;
            }

            s_Conversion.SourcePartitions = p_Guid => m_Mounter.TryGetPartitionByGuid(p_Guid, out var s_Name, out var s_Mounted)
                ? m_Reader.FromPartitionObject(s_Name, s_Mounted.FirstVariant)
                : null;

            var s_Converted = new List<(string Name, DatabasePartitionBase Partition)>();
            foreach (var (s_Name, s_Source) in s_Parsed)
            {
                try
                {
                    s_Converted.Add((s_Name, s_Conversion.Convert(s_Source)));
                }
                catch (InvalidDataException s_Ex)
                {
                    s_Unresolved.Add($"partition {s_Name} not converted: {s_Ex.Message}");
                }
            }

            var s_EarlierByGuid = s_Earlier.Values.ToDictionary(p_P => p_P.PartitionGuid);
            s_Conversion.DeriveAcross(s_Converted.Select(p_C => p_C.Partition).ToList(), p_Guid => s_EarlierByGuid.GetValueOrDefault(p_Guid));
            AddRegistries(s_Conversion, s_Converted, p_Log);
            ExcludeSkippedSubWorlds(s_Converted, p_Log);
            DropEmptyReferences(s_Converted, p_Log);
            var s_StandInShaders = RebindShaders(s_Converted, p_Log);

            var s_Writer = EngineInterfaceRegistry.Create<IPartitionGenerator>(((SbBuildingContext)m_Context.Parent!).EngineType);
            foreach (var (s_Name, s_Partition) in s_Converted)
            {
                var s_Stream = new MemoryStream();
                using (var s_RimeWriter = new RimeWriter(s_Stream))
                    s_Writer.Generate(s_Partition, s_RimeWriter);

                var s_Target = s_Partition.Name.ToLowerInvariant();
                if (Dump != null)
                {
                    var s_File = new FileInfo(Path.Combine(Dump.FullName, s_Target + ".json"));
                    s_File.Directory!.Create();
                    s_Partition.ToJsonFile(s_File.FullName, Newtonsoft.Json.Formatting.Indented);
                }

                m_Context.AddPartition(s_Target, new BundlePartitionVariant(new SbBuildingContext.MemoryReader(s_Stream.ToArray()), m_Context.BundleName));
                if (s_Shares)
                    s_Earlier[s_Name] = s_Partition;
                p_Log.WriteLine(s_Target == s_Name ? $"PART {s_Name}" : $"PART {s_Target} <- {s_Name}");
            }

            Report = s_Conversion.Report;
            var s_ConvertedResources = AddResources(s_Resources, s_Unresolved, p_Log);
            AddTargetPartitions(s_StandInShaders.Concat(s_TargetOwn.Keys).ToList(), p_Log);
            // The game waits for a chunk it cannot find rather than failing, so each one left is listed by what names it.
            var s_ChunksLeft = s_Chunks.Where(p_C => !m_Context.GetChunks().ContainsKey(p_C.Key)).ToList();
            foreach (var s_Group in s_ChunksLeft.GroupBy(p_C => string.Join('/', p_C.Value.Split('/').Take(2))).OrderByDescending(p_G => p_G.Count()))
                p_Log.WriteLine($"CHUNKS LEFT {s_Group.Count()} named by {s_Group.Key}/..., e.g. {s_Group.First().Value}");
            return new Result(s_Converted.Count, s_Skipped, s_Resources.Count, s_ConvertedResources, s_ChunksLeft.Count, s_Unresolved);
        }

        /// <summary>
        /// Adds each resource among the resources whose type is converted, in the bundle's engine and
        /// under its moved name, with the chunks it streams from. How many it added.
        /// </summary>
        private int AddResources(IEnumerable<string> p_Resources, List<string> p_Unresolved, TextWriter p_Log)
        {
            var s_Converters = new ResourceConverters(this);
            var s_Added = 0;
            var s_Left = new SortedDictionary<string, int>(StringComparer.Ordinal);

            foreach (var s_Name in p_Resources.Order(StringComparer.OrdinalIgnoreCase))
            {
                if (!m_Mounter.TryGetResource(s_Name, out var s_Resource))
                    continue;

                var s_Variant = s_Resource.FirstVariant;
                var s_Type = s_Variant.GetResourceType();
                var s_Target = Moved(s_Name);
                try
                {
                    if (s_Converters.Terrain(s_Variant, s_Target.ToLowerInvariant(), p_Log) is { } s_Terrain)
                    {
                        if (s_Terrain.Count == 0)
                            s_Left[s_Type.ToString()] = s_Left.GetValueOrDefault(s_Type.ToString()) + 1;
                        foreach (var s_Converted in s_Terrain)
                        {
                            m_Context.AddGeneratedResource(s_Converted.Name, s_Converted.Data, s_Converted.Type, null);
                            p_Log.WriteLine($"RES {s_Converted.Name} ({s_Converted.Type}) <- {s_Name}");
                            ++s_Added;
                        }
                        continue;
                    }

                    if (s_Converters.Convert(s_Type, s_Name, s_Target.ToLowerInvariant(), s_Variant, p_Log) is not var (s_Data, s_Meta, s_Chunks))
                    {
                        s_Left[s_Type.ToString()] = s_Left.GetValueOrDefault(s_Type.ToString()) + 1;
                        ((SbBuildingContext)m_Context.Parent!).UnconvertedResources[s_Resource.OriginalName] = s_Type;
                        continue;
                    }

                    m_Context.AddResource(s_Target, new ReplacedResource(s_Variant, s_Data, s_Target, s_Meta));
                    foreach (var (s_Id, s_Chunk) in s_Chunks)
                        m_Context.AddChunk(s_Id, s_Chunk);
                    p_Log.WriteLine(s_Target == s_Name ? $"RES {s_Name}" : $"RES {s_Target} <- {s_Name}");
                    ++s_Added;
                }
                catch (Exception s_Ex) when (s_Ex is NotSupportedException or InvalidDataException or ArgumentException or KeyNotFoundException)
                {
                    p_Unresolved.Add($"resource {s_Name} not converted: {s_Ex.Message}");
                }
            }

            p_Log.WriteLine($"Resources not converted yet: {string.Join(", ", s_Left.Select(p_L => $"{p_L.Value} {p_L.Key}"))}");
            return s_Added;
        }

        /// <summary>
        /// A resource in the bundle's engine: physics built again in its Havok from the shapes,
        /// destruction converted class by class, meshes and textures fitted to its codecs, animation
        /// banks in its layouts and controllers. Each comes
        /// with the chunks it streams from, under their ids, whose meta names the moved resource.
        /// </summary>
        private sealed class ResourceConverters
        {
            private readonly ConvertedClosure m_Closure;
            private readonly EngineType m_Target;
            private readonly IHavokConverter m_Havok;
            private readonly IHavokDestructionConverter? m_Destruction;
            private readonly IHavokObjectModel m_Model;
            private readonly IHavokMaterials m_Materials;
            private readonly IMeshSetCodec m_MeshFrom;
            private readonly IMeshSetCodec m_MeshTo;
            private readonly ITextureCodec m_TextureFrom;
            private readonly ITextureCodec m_TextureTo;
            private readonly IChunkMetaWriter m_ChunkMeta;
            private readonly ITerrainConverter? m_Terrain;
            private readonly IAnimationBankConverter? m_Animation;
            private readonly Lazy<HashSet<string>> m_TextureGroups;

            public ResourceConverters(ConvertedClosure p_Closure)
            {
                m_Closure = p_Closure;
                var s_SbContext = (SbBuildingContext)p_Closure.m_Context.Parent!;
                var s_Source = p_Closure.m_Mounter.GetEngineType();
                m_Target = s_SbContext.EngineType;
                m_Havok = EngineInterfaceRegistry.Create<IHavokConverter>(s_Source);
                m_Destruction = EngineInterfaceRegistry.IsSupported<IHavokDestructionConverter>(s_Source)
                    ? EngineInterfaceRegistry.Create<IHavokDestructionConverter>(s_Source)
                    : null;
                m_Model = EngineInterfaceRegistry.Create<IHavokObjectModel>(m_Target);
                m_Materials = EngineInterfaceRegistry.Create<IHavokMaterials>(m_Target);
                m_MeshFrom = EngineInterfaceRegistry.Create<IMeshSetCodec>(s_Source);
                m_MeshTo = EngineInterfaceRegistry.Create<IMeshSetCodec>(m_Target);
                m_TextureFrom = EngineInterfaceRegistry.Create<ITextureCodec>(s_Source);
                m_TextureTo = EngineInterfaceRegistry.Create<ITextureCodec>(m_Target);
                m_ChunkMeta = EngineInterfaceRegistry.Create<IChunkMetaWriter>(m_Target);
                m_Terrain = EngineInterfaceRegistry.IsSupported<ITerrainConverter>(s_Source) ? EngineInterfaceRegistry.Create<ITerrainConverter>(s_Source) : null;
                m_Animation = EngineInterfaceRegistry.IsSupported<IAnimationBankConverter>(s_Source) ? EngineInterfaceRegistry.Create<IAnimationBankConverter>(s_Source) : null;

                // Streaming groups are the target game's, so a texture of a group it lacks gets the nearest it has.
                var s_TargetGame = p_Closure.TargetGame()?.Game;
                m_TextureGroups = new Lazy<HashSet<string>>(() => s_TargetGame == null ? [] : MountedTextures.Groups(s_TargetGame, m_TextureTo));
            }

            /// <summary>
            /// The resources a terrain resource becomes in the target's engine, which may be of other
            /// types and names (Frostbite 2 keeps its terrain resource where this engine keeps its visual
            /// terrain); null for a resource that is not terrain or a source without a terrain converter.
            /// </summary>
            public IReadOnlyList<ConvertedTerrainResource>? Terrain(IResourceVariant p_Variant, string p_Target, TextWriter p_Log) =>
                m_Terrain != null && p_Variant.GetResourceType() is ResourceType.TerrainStreamingTree or ResourceType.VisualTerrain
                    or ResourceType.TerrainLayerCombinations or ResourceType.TerrainDecals
                    ? m_Terrain.Convert(p_Variant, p_Target, m_Closure.m_Mounter, m_Target, Material, p_Log)
                    : null;

            /// <summary>Whether a resource of the type ships in the target under its moved name, which <see cref="Convert"/> gives it.</summary>
            public static bool Ships(ResourceType p_Type) => p_Type is ResourceType.HavokPhysicsData or ResourceType.HavokDestructionPhysicsData
                or ResourceType.MeshSet or ResourceType.DxTexture or ResourceType.OccluderMesh or ResourceType.AnimTrackData or ResourceType.AssetBank;

            /// <summary>The resource's payload, meta and chunks in the target's engine; null for a type not converted yet.</summary>
            /// <param name="p_Target">The moved name, in lower case as bundles keep it.</param>
            public (byte[] Data, byte[]? Meta, IReadOnlyList<(GUID Id, IChunkObject Chunk)> Chunks)? Convert(ResourceType p_Type, string p_Name, string p_Target, IResourceVariant p_Variant, TextWriter p_Log)
            {
                switch (p_Type)
                {
                    case ResourceType.HavokPhysicsData:
                        return Physics(m_Model.Rewrite(MountedTextures.Read(p_Variant), m_Havok.GetShapes(p_Variant, m_Closure.m_Mounter).ToList()));
                    case ResourceType.HavokDestructionPhysicsData when m_Destruction != null:
                        return Physics(m_Destruction.Convert(MountedTextures.Read(p_Variant), m_Target, out _));
                    case ResourceType.MeshSet:
                        return Mesh(p_Name, p_Target, p_Variant);
                    case ResourceType.DxTexture:
                        return Texture(p_Name, p_Target, p_Variant);
                    case ResourceType.OccluderMesh or ResourceType.AnimTrackData:
                        return AsItIs(p_Type, p_Variant);
                    case ResourceType.AssetBank when m_Animation != null:
                        return (m_Animation.Convert(MountedTextures.Read(p_Variant), m_Target, p_Log), null, []);
                    default:
                        return null;
                }
            }

            /// <summary>A resource the target lays out alike, as it is with its meta: the target reads and writes it back unchanged.</summary>
            private (byte[], byte[]?, IReadOnlyList<(GUID, IChunkObject)>) AsItIs(ResourceType p_Type, IResourceVariant p_Variant)
            {
                var s_Data = MountedTextures.Read(p_Variant);
                p_Variant.TryGetMeta(out var s_Meta);
                if (!ResourceTypeProviders.ByType<IResourceStructs>(m_Target, p_P => p_P.Types).TryGetValue(p_Type, out var s_Structs)
                    || !s_Structs.RoundTrip(p_Type, s_Data, s_Meta).AsSpan().SequenceEqual(s_Data))
                    throw new NotSupportedException($"the target does not read this {p_Type} as it is");

                return (s_Data, null, []);
            }

            /// <summary>A packed material as the target's pair, the default's where it does not map, or as it is without a mapping.</summary>
            private uint Material(uint p_Packed) =>
                ((SbBuildingContext)m_Closure.m_Context.Parent!).ConvertedMaterials is not { } s_Mapping ? p_Packed
                : s_Mapping.TryMap(p_Packed, out var s_Mapped, out _) ? s_Mapped
                : s_Mapping.DefaultPacked;

            /// <summary>Physics with the header's packed materials as the target's pairs, the default's where one does not map.</summary>
            private (byte[], byte[]?, IReadOnlyList<(GUID, IChunkObject)>) Physics(byte[] p_Written)
            {
                if (((SbBuildingContext)m_Closure.m_Context.Parent!).ConvertedMaterials is { } s_Mapping)
                {
                    var s_Default = s_Mapping.DefaultPacked;
                    p_Written = m_Materials.WithMaterialFlagsAndIndices(p_Written,
                        p_Packed => s_Mapping.TryMap(p_Packed, out var s_Mapped, out _) ? s_Mapped : s_Default);
                }

                return (p_Written, m_Model.Meta(p_Written), []);
            }

            /// <summary>
            /// The MeshSet fitted to the target and renamed with its LODs, the subsets the closure
            /// gave a layout repacked to it; the kept LODs' chunks as they are, the repacked ones' written again.
            /// </summary>
            private (byte[], byte[]?, IReadOnlyList<(GUID, IChunkObject)>) Mesh(string p_Name, string p_Target, IResourceVariant p_Variant)
            {
                if (!p_Variant.TryGetMeta(out var s_Meta))
                    throw new InvalidDataException("a MeshSet without meta");

                var s_Model = m_MeshFrom.Decode(new MeshSetPayload(MountedTextures.Read(p_Variant), s_Meta));
                var s_Fitted = MeshSetConversion.Renamed(MeshSetConversion.ToEngine(s_Model, m_MeshTo, out _), m_Closure.Moved);
                var s_Repacked = new Dictionary<GUID, byte[]>();
                if (m_Closure.m_Layouts.TryGetValue(p_Name, out var s_Layouts))
                    s_Fitted = Repacked(s_Fitted, s_Layouts, s_Repacked);

                var s_Written = m_MeshTo.Encode(s_Fitted);
                var s_Chunks = s_Fitted.Lods.Where(p_L => p_L.ChunkId != GUID.Empty).Select(p_L => p_L.ChunkId).Distinct()
                    .Select(p_Id => (p_Id, Chunk(p_Id, s_Repacked.GetValueOrDefault(p_Id), p_Target))).ToList();
                return (s_Written.Data, s_Written.Meta, s_Chunks);
            }

            /// <summary>The MeshSet with each subset that has a layout repacked to it, and the chunks of the LODs repacked, by id.</summary>
            private MeshSetModel Repacked(MeshSetModel p_Model, Dictionary<(int Lod, int Subset), VertexLayout> p_Layouts, Dictionary<GUID, byte[]> p_Chunks)
            {
                var s_Lods = p_Model.Lods.ToList();
                for (var l = 0; l < s_Lods.Count; ++l)
                {
                    var s_Lod = s_Lods[l];
                    if (s_Lod.ChunkId == GUID.Empty || p_Chunks.ContainsKey(s_Lod.ChunkId)
                        || !Enumerable.Range(0, s_Lod.Subsets.Count).Any(i => p_Layouts.ContainsKey((l, i)))
                        || s_Lod.Subsets.Any(p_S => VertexLayout.OneStream(p_S) == null))
                        continue;

                    var s_Layouts = s_Lod.Subsets.Select((p_S, i) => p_Layouts.TryGetValue((l, i), out var s_Layout) ? s_Layout : VertexLayout.Of(p_S)).ToList();
                    var s_Chunk = MountedTextures.Read(MountedTextures.WholeChunk(m_Closure.m_Mounter, s_Lod.ChunkId));
                    (s_Lods[l], p_Chunks[s_Lod.ChunkId]) = VertexRepacking.Repack(s_Lod, s_Chunk, s_Layouts, out _);
                }

                return p_Model with { Lods = s_Lods };
            }

            /// <summary>
            /// The texture in the target's formats and streaming groups under the moved name, its chunk
            /// written again where the format changes and as it is otherwise.
            /// </summary>
            private (byte[], byte[]?, IReadOnlyList<(GUID, IChunkObject)>) Texture(string p_Name, string p_Target, IResourceVariant p_Variant)
            {
                var s_Header = MountedTextures.Read(p_Variant);
                var s_Image = m_TextureFrom.Decode(p_Name, s_Header, []);
                if (TextureConversion.NeedsData(s_Image.Format, m_TextureTo.Formats))
                    s_Image = m_TextureFrom.Decode(p_Name, s_Header, MountedTextures.Read(MountedTextures.WholeChunk(m_Closure.m_Mounter, s_Image.ChunkId)));

                var s_Fitted = TextureConversion.ToFormats(s_Image, m_TextureTo.Formats).Copy();
                s_Fitted.Group = TextureConversion.ToGroups(s_Image.Group, m_TextureGroups.Value);
                // An on-demand texture streams from a pool the target creates only for its own such textures.
                s_Fitted.Options &= ~TextureOptions.OnDemandLoaded;
                var s_Written = m_TextureTo.Encode(s_Fitted, p_Target);
                if (s_Fitted.ChunkId == GUID.Empty)
                    return (s_Written.Header, s_Written.Meta, []);

                return (s_Written.Header, s_Written.Meta, [(s_Fitted.ChunkId, Chunk(s_Fitted.ChunkId, s_Written.Chunk.Length > 0 ? s_Written.Chunk : null, p_Target))]);
            }

            /// <summary>
            /// The chunk, from the source or as given, with the source's meta (a texture's first mip)
            /// naming the resource it belongs to by its moved name.
            /// </summary>
            private IChunkObject Chunk(GUID p_Id, byte[]? p_Data, string p_Resource)
            {
                var s_Source = MountedTextures.WholeChunk(m_Closure.m_Mounter, p_Id);
                int? s_FirstMip = s_Source.TryGetMeta(out var s_Meta) && s_Meta.TryGetByKey<DbObject>("meta", out var s_Inner)
                    && s_Inner!.Value.TryGetByKey<int>("firstMip", out var s_Mip) ? s_Mip!.Value : null;
                var s_Hash = (int)Frostbite.Utils.HashQuick(p_Resource);
                return new MemoryChunk(p_Data ?? MountedTextures.Read(s_Source), m_ChunkMeta.Create(s_Hash, s_FirstMip), s_Hash);
            }
        }

        /// <summary>
        /// The mapping of the source's materials to the target's, made once per superbundle from the
        /// grid of the level the closure is in and the target game mounted beside the source; none
        /// where either is missing or the source has no rules to name its materials.
        /// </summary>
        private MaterialMapping? Materials(ConversionRules p_Rules, IEnumerable<string> p_Roots, TextWriter p_Log)
        {
            var s_SbContext = (SbBuildingContext)m_Context.Parent!;
            if (s_SbContext.ConvertedMaterials != null || p_Rules.MaterialKeywords.Count == 0)
                return s_SbContext.ConvertedMaterials;

            var s_TargetMounter = TargetGame()?.Game;
            var s_Level = p_Roots.Select(p_R => p_R.Split('/')).Where(p_P => p_P.Length > 3).Select(p_P => string.Join('/', p_P.Take(3)) + '/').FirstOrDefault();
            var s_GridName = s_Level == null ? null : m_Mounter.GetPartitions().Keys
                .FirstOrDefault(p_N => p_N.StartsWith(s_Level, StringComparison.OrdinalIgnoreCase) && p_N.Contains("materialgrid", StringComparison.OrdinalIgnoreCase));
            if (s_TargetMounter == null || s_GridName == null || !m_Mounter.TryGetPartition(s_GridName, out var s_Grid))
            {
                p_Log.WriteLine("Materials are not mapped: mount the target game beside the source, with the level's material grid.");
                return null;
            }

            var s_TargetReader = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SbContext.EngineType);
            DatabasePartitionBase? Source(string p_Name) => m_Mounter.TryGetPartition(p_Name, out var s_P) ? m_Reader.FromPartitionObject(p_Name, s_P.FirstVariant) : null;
            DatabasePartitionBase? Target(string p_Name) => s_TargetMounter.TryGetPartition(p_Name, out var s_P) ? s_TargetReader.FromPartitionObject(p_Name, s_P.FirstVariant) : null;

            s_SbContext.ConvertedMaterials = new MaterialMapping(
                EngineInterfaceRegistry.Create<IMaterialGridRules>(m_Mounter.GetEngineType()), Source, m_Reader.FromPartitionObject(s_GridName, s_Grid.FirstVariant),
                p_Guid => m_Mounter.TryGetPartitionByGuid(p_Guid, out var s_Name, out _) ? s_Name : null,
                EngineInterfaceRegistry.Create<IMaterialGridRules>(s_SbContext.EngineType), Target, p_Rules.MaterialKeywords);
            p_Log.WriteLine($"Materials mapped from {s_GridName} by its rows' assets.");
            return s_SbContext.ConvertedMaterials;
        }

        /// <summary>
        /// Gives each converted sub-world that has no RegistryContainer the one its source's network
        /// registry makes, over the objects the bundle has.
        /// </summary>
        private void AddRegistries(PartitionConversion p_Conversion, List<(string Name, DatabasePartitionBase Partition)> p_Converted, TextWriter p_Log)
        {
            var s_Target = EngineInterfaceRegistry.Create<IEbxTypeLibrary>(((SbBuildingContext)m_Context.Parent!).EngineType);
            var s_ConvertedInstances = p_Converted.ToDictionary(p_C => p_C.Partition.PartitionGuid,
                p_C => p_C.Partition.Instances.Select(p_I => p_I.InstanceId).ToHashSet());
            var s_Sources = new Dictionary<GUID, Dictionary<DataContainerId, DataContainerBase>?>();

            DataContainerBase? Source(CtrRefBase p_Ref)
            {
                if (!s_Sources.TryGetValue(p_Ref.PartitionGuid, out var s_Instances))
                    s_Sources[p_Ref.PartitionGuid] = s_Instances = p_Conversion.SourcePartitions?.Invoke(p_Ref.PartitionGuid)?.Instances.ToDictionary(p_I => p_I.InstanceId);
                return s_Instances?.GetValueOrDefault(p_Ref.InstanceId);
            }

            bool Kept(CtrRefBase p_Ref) =>
                p_Conversion.ShippedPartitions?.Contains(p_Ref.PartitionGuid) == true
                && Source(p_Ref) is { } s_Instance && p_Conversion.Converts(s_Instance.GetType())
                && (!s_ConvertedInstances.TryGetValue(p_Ref.PartitionGuid, out var s_Ids)
                    || s_Ids.Contains(new DataContainerId.Guid(PartitionConversion.InstanceGuid(p_Ref.PartitionGuid, p_Ref.InstanceId))));

            if (p_Conversion.Rules.NetworkRegistrySuffix is not { } s_Suffix)
                return;

            for (var i = 0; i < p_Converted.Count; ++i)
            {
                var (s_Name, s_Partition) = p_Converted[i];
                if (!NetworkRegistries.Lacks(s_Partition) || !m_Mounter.TryGetPartition(s_Name + s_Suffix, out var s_Registry))
                    continue;

                var s_Source = m_Reader.FromPartitionObject(s_Name + s_Suffix, s_Registry.FirstVariant);
                p_Converted[i] = (s_Name, NetworkRegistries.WithRegistry(s_Target, s_Partition, s_Source, p_R => Source(p_R)?.GetType(), Kept, p_Conversion.Report, out var s_Registered));
                var s_Networked = AddNetworkedEntities(p_Converted[i].Partition, p_Converted);
                p_Log.WriteLine($"REG {s_Name}: {s_Registered} object(s) from {s_Name + s_Suffix}; the target's rules add {s_Networked}");
            }
        }

        /// <summary>
        /// Lists in the sub-world's registry what the target's rules list over the converted
        /// partitions that the source's registry does not name: a server gives an unlisted object
        /// network id 0, which no client resolves. What it added, by list.
        /// </summary>
        private string AddNetworkedEntities(DatabasePartitionBase p_SubWorld, List<(string Name, DatabasePartitionBase Partition)> p_Converted)
        {
            var s_Engine = ((SbBuildingContext)m_Context.Parent!).EngineType;
            if (!EngineInterfaceRegistry.IsSupported<IRegistryRules>(s_Engine)
                || p_SubWorld.Instances.FirstOrDefault(p_I => p_I.GetType().Name == "RegistryContainer") is not { } s_Container)
                return "none";

            var s_Instances = p_Converted.SelectMany(p_C => p_C.Partition.Instances).Where(p_I => p_I.Partition != null).ToList();
            var s_ById = p_Converted.SelectMany(p_C => p_C.Partition.Instances.Select(p_I => (p_C.Partition.PartitionGuid, p_I)))
                .GroupBy(p_P => $"{p_P.PartitionGuid}/{p_P.p_I.InstanceId}").ToDictionary(p_G => p_G.Key, p_G => p_G.First().p_I);
            DataContainerBase? Resolve(CtrRefBase p_Ref) => s_ById.GetValueOrDefault($"{p_Ref.PartitionGuid}/{p_Ref.InstanceId}");

            var s_Added = new SortedDictionary<string, int>(StringComparer.Ordinal);
            var s_Listed = new Dictionary<string, HashSet<string>>();
            // What breaking objects spawn: a server ghosts these with their entity network id.
            var s_Spawned = p_Converted.Where(p_C => p_C.Partition.PrimaryInstance.GetType().Name == "ObjectBlueprint")
                .SelectMany(p_C => p_C.Partition.Instances.Where(p_I => p_I.GetType().Name == "ReferenceObjectData")
                    .Select(p_I => ("RegistryContainer.EntityRegistry", new CtrRefBase(p_C.Partition.PartitionGuid, p_I.InstanceId))));
            foreach (var (s_Kind, s_Entry) in EngineInterfaceRegistry.Create<IRegistryRules>(s_Engine).GetEntries(s_Instances, Resolve).Concat(s_Spawned))
            {
                var s_Field = s_Kind[(s_Kind.LastIndexOf('.') + 1)..];
                if (s_Container.GetType().GetProperty(s_Field)?.GetValue(s_Container) is not IList s_List)
                    continue;

                if (!s_Listed.TryGetValue(s_Field, out var s_Keys))
                    s_Listed[s_Field] = s_Keys = s_List.OfType<CtrRefBase>().Select(p_R => $"{p_R.PartitionGuid}/{p_R.InstanceId}").ToHashSet();
                if (!s_Keys.Add($"{s_Entry.PartitionGuid}/{s_Entry.InstanceId}"))
                    continue;

                var s_Element = s_List.GetType().GetInterfaces().First(p_I => p_I.IsGenericType && p_I.GetGenericTypeDefinition() == typeof(IList<>)).GetGenericArguments()[0];
                var s_Ref = (CtrRefBase)Activator.CreateInstance(s_Element)!;
                s_Ref.SetValue(s_Entry.PartitionGuid, s_Entry.InstanceId);
                s_List.Add(s_Ref);
                s_Added[s_Field] = s_Added.GetValueOrDefault(s_Field) + 1;
            }

            return s_Added.Count == 0 ? "none" : string.Join(", ", s_Added.Select(p_A => $"{p_A.Value} {p_A.Key}"));
        }

        /// <summary>
        /// Excludes each reference to a sub-world the closure skips by prefix: the game would otherwise
        /// load its bundle, which is named as its sub-world is, and this superbundle does not have.
        /// </summary>
        private void ExcludeSkippedSubWorlds(List<(string Name, DatabasePartitionBase Partition)> p_Converted, TextWriter p_Log)
        {
            var s_Skipped = m_SkipPrefixes.Select(Moved).ToList();
            foreach (var (s_Name, s_Partition) in p_Converted)
            {
                foreach (var s_Instance in s_Partition.Instances.Where(p_I => p_I.GetType().Name == "SubWorldReferenceObjectData"))
                {
                    var s_Type = s_Instance.GetType();
                    if (s_Type.GetProperty("BundleName")?.GetValue(s_Instance) is not string { Length: > 0 } s_Bundle
                        || !s_Skipped.Any(p_P => s_Bundle.StartsWith(p_P, StringComparison.OrdinalIgnoreCase)))
                        continue;

                    // Excluded alone still has the game load an autoloaded sub-world's bundle.
                    s_Type.GetProperty("Excluded")!.SetValue(s_Instance, true);
                    s_Type.GetProperty("AutoLoad")!.SetValue(s_Instance, false);
                    p_Log.WriteLine($"EXCLUDED sub-world {s_Bundle} in {s_Name}");
                }
            }
        }

        /// <summary>The fields an object is nothing without: a reference object's blueprint, a terrain's asset, a mesh's, a radiosity's data, an animation's set.</summary>
        private static readonly string[] s_EssentialAssets = ["Blueprint", "TerrainAsset", "Mesh", "EnlightenData", "AnimationSet", "Sound"];

        /// <summary>
        /// Assets whose data is in a resource only some engines convert, with whether a source engine
        /// does: an animation set's clips are in an ANT bank. Where it does not, the asset is left out
        /// with what refers to it. No engine converts a static Enlighten database.
        /// </summary>
        private static readonly Dictionary<string, Func<EngineType, bool>> s_ResourceAssets = new()
        {
            ["AntAnimationSetAsset"] = EngineInterfaceRegistry.IsSupported<IAnimationBankConverter>,
            ["StaticEnlightenData"] = _ => false,
        };

        /// <summary>
        /// Takes each object whose essential asset the closure left out, a vehicle spawn without its
        /// vehicle say, out of every list that names it, directly (a world's objects, connections) or
        /// in an element (a static model group's members): the game creates every listed object,
        /// excluded or not, and would use what it has not got.
        /// </summary>
        private static void DropEmptyReferences(List<(string Name, DatabasePartitionBase Partition)> p_Converted, TextWriter p_Log)
        {
            static bool Empty(DataContainerBase p_Instance) =>
                s_EssentialAssets.Any(p_F => p_Instance.GetType().GetProperty(p_F)?.GetValue(p_Instance) is CtrRefBase { } s_Asset && s_Asset.IsNull())
                && p_Instance.GetType().GetProperty("BundleName")?.GetValue(p_Instance) is not string { Length: > 0 };

            static string Key(GUID p_Partition, DataContainerId p_Id) => $"{p_Partition}/{PartitionConversion.InstanceGuid(p_Partition, p_Id)}";

            var s_Empty = p_Converted.SelectMany(p_C => p_C.Partition.Instances.Where(Empty)
                    .Select(p_I => (Key: Key(p_C.Partition.PartitionGuid, p_I.InstanceId), Type: p_I.GetType().Name)))
                .ToDictionary(p_E => p_E.Key, p_E => p_E.Type);
            if (s_Empty.Count == 0)
                return;

            string? EmptyNamed(object? p_Value) => p_Value switch
            {
                CtrRefBase s_Ref when !s_Ref.IsNull() => s_Empty.GetValueOrDefault(Key(s_Ref.PartitionGuid, s_Ref.InstanceId)),
                EbxSerializable s_Element and not DataContainerBase => s_Element.GetType().GetProperties()
                    .Where(p_P => typeof(CtrRefBase).IsAssignableFrom(p_P.PropertyType))
                    .Select(p_P => EmptyNamed(p_P.GetValue(s_Element))).FirstOrDefault(p_T => p_T != null),
                _ => null,
            };

            var s_Dropped = new SortedDictionary<string, int>(StringComparer.Ordinal);
            foreach (var s_Instance in p_Converted.SelectMany(p_C => p_C.Partition.Instances))
            {
                foreach (var s_Property in s_Instance.GetType().GetProperties())
                {
                    if (s_Property.GetIndexParameters().Length > 0 || s_Property.GetValue(s_Instance) is not IList s_List)
                        continue;

                    for (var i = s_List.Count - 1; i >= 0; --i)
                    {
                        if (EmptyNamed(s_List[i]) is not { } s_Type)
                            continue;

                        s_List.RemoveAt(i);
                        var s_What = $"{s_Type} in {s_Instance.GetType().Name}.{s_Property.Name}";
                        s_Dropped[s_What] = s_Dropped.GetValueOrDefault(s_What) + 1;
                    }
                }
            }

            foreach (var (s_What, s_Count) in s_Dropped)
                p_Log.WriteLine($"DROPPED {s_Count} {s_What} without its asset");
        }

        /// <summary>The mounted game of the bundle's engine, which the converted content may use content of.</summary>
        private (int Id, IEngineMounter Game)? TargetGame()
        {
            var s_SbContext = (SbBuildingContext)m_Context.Parent!;
            foreach (var (s_Id, s_Game) in ((BaseContext)s_SbContext.Parent!).GetMounters())
            {
                if (s_Game.GetEngineType() == s_SbContext.EngineType)
                    return (s_Id, s_Game);
            }

            return null;
        }

        /// <summary>
        /// Points each converted mesh material at a target shader for the same kind of mesh like its
        /// own, by the parameters their materials set, or at the most used diffuse shader where none
        /// is alike; also a target shader of the source's own that draws fewer subsets than a stand-in.
        /// The target shaders it points them at, by partition name.
        /// </summary>
        private IReadOnlyList<string> RebindShaders(List<(string Name, DatabasePartitionBase Partition)> p_Converted, TextWriter p_Log)
        {
            var s_SbContext = (SbBuildingContext)m_Context.Parent!;
            if (TargetGame() is not var (_, s_Game))
            {
                p_Log.WriteLine("Shaders are not rebound: mount the target game beside the source.");
                return [];
            }

            var s_Bindings = EngineInterfaceRegistry.Create<IShaderBindings>(s_SbContext.EngineType);
            var s_Pools = s_SbContext.ShaderStandIns ??= MountedShaders.ByMesh(s_Game, s_Bindings);
            // A shader no target shader is alike to stands in by the most used one that takes a diffuse texture.
            const string c_Diffuse = "Diffuse";

            var s_Used = new MaterialShaders();
            var s_UsedBy = new Dictionary<string, MaterialShaders> { [MountedShaders.c_Skinned] = new(), [MountedShaders.c_Composite] = new() };
            foreach (var (_, s_Partition) in p_Converted)
            {
                s_Used.Add(s_Bindings, s_Partition);
                if (s_UsedBy.TryGetValue(s_Partition.PrimaryInstance.GetType().Name, out var s_Kind))
                    s_Kind.Add(s_Bindings, s_Partition);
            }

            // A shader stands in by one the target draws the same kind of mesh with, as only those
            // have the skinned or composite permutations; by any mesh's where none is alike.
            var s_Skinned = s_UsedBy[MountedShaders.c_Skinned].ByShader();
            var s_Composite = s_UsedBy[MountedShaders.c_Composite].ByShader();
            string Kind(InstanceRef p_Shader) => s_Skinned.ContainsKey(p_Shader) ? MountedShaders.c_Skinned
                : s_Composite.ContainsKey(p_Shader) ? MountedShaders.c_Composite : MountedShaders.c_Rigid;
            ShaderStandIns Pool(InstanceRef p_Shader, ShaderParameters p_Parameters) =>
                s_Pools[Kind(p_Shader)].Choose(p_Parameters) != null ? s_Pools[Kind(p_Shader)] : s_Pools[""];

            // A shader draws a subset only with a solution for its vertex declaration, so of the
            // alike stand-ins the one with a declaration of most subsets' elements is taken.
            var s_To = EngineInterfaceRegistry.Create<IMeshSetCodec>(s_SbContext.EngineType);
            var s_Declarations = new SolutionLayouts(ShaderDatabaseIndex.Get(s_Game), s_Game, s_To);
            var s_Subsets = ConvertedSubsets(p_Converted, s_Bindings, s_To).ToLookup(p_S => p_S.Shader);
            bool Fits(InstanceRef p_StandIn, ConvertedSubset p_Subset) =>
                s_Declarations.Draws(p_StandIn, p_Subset.Declaration) || p_Subset.Repackable && s_Declarations.Fits(p_StandIn, p_Subset) != null;
            int Draws(InstanceRef p_StandIn, InstanceRef p_Shader) => s_Subsets[p_Shader].Count(p_S => Fits(p_StandIn, p_S));
            // Whether a subset draws with a shader as it is or repacked to any layout the shader has a solution for.
            bool Reaches(InstanceRef p_StandIn, ConvertedSubset p_Subset) =>
                Fits(p_StandIn, p_Subset) || p_Subset.Repackable && s_Declarations.Closest(p_StandIn, p_Subset) != null;
            int Reached(InstanceRef p_StandIn, InstanceRef p_Shader) => s_Subsets[p_Shader].Count(p_S => Reaches(p_StandIn, p_S));

            var s_Picks = new Dictionary<InstanceRef, ShaderStandIn>();
            var s_Alike = new Dictionary<InstanceRef, InstanceRef>();
            int s_Plainly = 0, s_Owned = 0;
            foreach (var (s_Shader, (s_Parameters, _)) in s_Used.ByShader())
            {
                var s_From = Pool(s_Shader, s_Parameters);
                if (s_Game.TryGetPartitionByGuid(s_Shader.Partition, out _, out _))
                {
                    // The target's own shader stays unless a stand-in draws more of its subsets.
                    var s_Own = Reached(s_Shader, s_Shader);
                    if (s_Own < s_Subsets[s_Shader].Count() && s_From.Choose(s_Parameters, p_S => Reached(p_S, s_Shader)) is { } s_Better
                        && Reached(s_Better.Shader, s_Shader) > s_Own)
                    {
                        s_Picks[s_Shader] = s_Better;
                        s_Alike[s_Shader] = s_Shader;
                        ++s_Owned;
                    }

                    continue;
                }

                if (s_From.Choose(s_Parameters, p_S => Draws(p_S, s_Shader)) is { } s_StandIn)
                {
                    s_Picks[s_Shader] = s_StandIn;
                    s_Alike[s_Shader] = s_From.Choose(s_Parameters)!.Shader;
                }
                else if ((s_Pools[Kind(s_Shader)].MostUsed(c_Diffuse) ?? s_Pools[""].MostUsed(c_Diffuse)) is { } s_Plain)
                {
                    s_Picks[s_Shader] = s_Plain;
                    s_Alike[s_Shader] = s_Plain.Shader;
                    ++s_Plainly;
                }
            }

            foreach (var (s_Shader, s_Pick) in s_Picks.OrderBy(p_P => Name(m_Mounter, p_P.Key), StringComparer.Ordinal))
                p_Log.WriteLine($"STANDIN {Name(m_Mounter, s_Shader)} -> {Name(s_Game, s_Pick.Shader)} (alike {s_Pick.Similarity:0.00}, " +
                    $"draws {Draws(s_Pick.Shader, s_Shader)}/{s_Subsets[s_Shader].Count()} subset(s) as they are)");

            // Subsets whose declaration their shader has no solution for are repacked to the layout
            // of a declaration it has: the same elements in another stride, or the closest.
            int s_All = 0, s_AsAlike = 0, s_AsPicked = 0, s_Repacked = 0, s_Drawn = 0;
            foreach (var s_Group in s_Subsets)
            {
                var s_Shader = s_Picks.TryGetValue(s_Group.Key, out var s_Pick) ? s_Pick.Shader
                    : s_Game.TryGetPartitionByGuid(s_Group.Key.Partition, out _, out _) ? s_Group.Key : null;
                if (s_Shader == null)
                    continue;

                var s_AlikeShader = s_Alike.GetValueOrDefault(s_Group.Key, s_Shader);
                foreach (var s_Subset in s_Group)
                {
                    ++s_All;
                    if (s_Declarations.Draws(s_AlikeShader, s_Subset.Declaration))
                        ++s_AsAlike;
                    if (s_Declarations.Draws(s_Shader, s_Subset.Declaration))
                    {
                        ++s_AsPicked;
                        ++s_Drawn;
                        continue;
                    }

                    if (!s_Subset.Repackable || (s_Declarations.Fits(s_Shader, s_Subset) ?? s_Declarations.Closest(s_Shader, s_Subset)) is not { } s_Layout)
                        continue;

                    if (!m_Layouts.TryGetValue(s_Subset.Mesh, out var s_Mesh))
                        m_Layouts[s_Subset.Mesh] = s_Mesh = new Dictionary<(int, int), VertexLayout>();
                    s_Mesh[(s_Subset.Lod, s_Subset.Index)] = s_Layout;
                    ++s_Repacked;
                    if (s_Declarations.Draws(s_Shader, s_To.DeclarationHash(s_Subset.Subset with { Elements = s_Layout.Elements, VertexStride = s_Layout.Stride, Streams = [new VertexStream(s_Layout.Stride, VertexClassification.PerVertex)] })))
                        ++s_Drawn;
                }
            }

            p_Log.WriteLine($"Shaders: of {s_All} converted mesh subset(s), their shader has a solution for {s_AsAlike} with the most alike stand-ins, {s_AsPicked} as picked, " +
                $"and {s_Drawn} with {s_Repacked} repacked to a layout it has one for.");
            // A translated shader keeps its own shader and parameters: it draws with its stand-in's solutions, so
            // its subsets were repacked like the stand-in's above, but its materials are not pointed at it.
            var s_Translated = s_SbContext.ShaderTranslator is { } s_Translator
                ? TranslateShaders(s_Picks, s_Alike, s_Game, s_Translator, p_Log)
                : new HashSet<InstanceRef>();
            var s_StandingIn = s_Picks.Where(p_P => !s_Translated.Contains(p_P.Key)).ToDictionary(p_P => p_P.Key, p_P => p_P.Value);

            var s_Dropped = p_Converted.Sum(p_C => s_Bindings.Rebind(p_C.Partition, s_StandingIn).Count);
            p_Log.WriteLine($"Shaders: {s_StandingIn.Count} stood in for, {s_Translated.Count} translated, {s_Plainly} of them by the most used diffuse shader, {s_Owned} of the target's own for drawing more; " +
                $"{s_Skinned.Count} used by skinned meshes, {s_Composite.Count} by composite ones; {s_Dropped} parameter(s) the stand-ins do not take dropped.");
            return s_StandingIn.Values.Select(p_S => s_Game.TryGetPartitionByGuid(p_S.Shader.Partition, out var s_Name, out _) ? s_Name : null)
                .OfType<string>().Distinct(StringComparer.OrdinalIgnoreCase).ToList();
        }

        /// <summary>
        /// Translates each stood-in source shader's g-buffer pixel shader onto every g-buffer solution of its
        /// stand-in (the render path the translator speaks, DX11) and records those with any solution translated
        /// for add_translated_shaders. A solution whose translation would lose its lightmap keeps the stand-in's.
        /// The source shaders translated.
        /// </summary>
        private HashSet<InstanceRef> TranslateShaders(IReadOnlyDictionary<InstanceRef, ShaderStandIn> p_Picks, IReadOnlyDictionary<InstanceRef, InstanceRef> p_Alike,
            IEngineMounter p_Game, string p_Translator, TextWriter p_Log)
        {
            const string c_RenderPath = "ShaderRenderPath_Dx11";
            var s_Translated = new HashSet<InstanceRef>();
            if (!EngineInterfaceRegistry.IsSupported<IShaderSolutionReader>(m_Mounter.GetEngineType()) ||
                !EngineInterfaceRegistry.IsSupported<IShaderSolutionReader>(p_Game.GetEngineType()))
            {
                p_Log.WriteLine("Shaders are not translated: their solutions are not read for these engines.");
                return s_Translated;
            }

            var s_SourceIndex = ShaderDatabaseIndex.Get(m_Mounter);
            var s_TargetIndex = ShaderDatabaseIndex.Get(p_Game);
            var s_SourceReader = EngineInterfaceRegistry.Create<IShaderSolutionReader>(m_Mounter.GetEngineType());
            var s_TargetReader = EngineInterfaceRegistry.Create<IShaderSolutionReader>(p_Game.GetEngineType());
            var s_Loaded = new Dictionary<string, byte[]>(StringComparer.OrdinalIgnoreCase);

            // The DX11 solutions of a shader that write the g-buffer, and the database it is in.
            // The source level's own databases first: another level's holds the shader compiled for its own use, and
            // that compile is not the one this level's materials draw with.
            var s_SourceLevel = m_Move is var (s_MoveFrom, _) ? s_MoveFrom.ToLowerInvariant() : null;

            (string Database, List<ShaderSolutionPixel> GBuffer)? GBuffer(ShaderDatabaseIndex p_Index, IShaderSolutionReader p_Reader, uint p_Key)
            {
                var s_Databases = p_Index == s_SourceIndex && s_SourceLevel != null
                    ? p_Index.Databases.OrderBy(p_D => p_D.Name.StartsWith(s_SourceLevel, StringComparison.Ordinal) ? 0 : 1).ToList()
                    : p_Index.Databases;
                foreach (var (s_Name, s_Load, s_Keys) in s_Databases)
                {
                    if (!s_Keys.Contains(p_Key))
                        continue;

                    if (!s_Loaded.TryGetValue(s_Name, out var s_Data))
                        s_Loaded[s_Name] = s_Data = s_Load();

                    var s_Pixels = p_Reader.GetPixelShaders(s_Data, p_Key)
                        .Where(p_P => p_P.RenderPath == c_RenderPath && ShaderTranslation.Outputs(p_P.Bytecode) == 4).ToList();
                    return (s_Name, s_Pixels);
                }

                return null;
            }

            var s_SbContext = (SbBuildingContext)m_Context.Parent!;
            var s_Jobs = new List<ShaderTranslation.Job>();
            var s_Plans = new List<(InstanceRef Shader, string Database, string Name, uint Key, int SourceSolution, uint TemplateKey, List<(int Solution, int Job)> Targets)>();
            foreach (var (s_Shader, s_StandIn) in p_Picks)
            {
                // A stand-in for the target's own shader draws more of its subsets; there is nothing to translate.
                if (p_Alike.TryGetValue(s_Shader, out var s_Alike) && s_Alike == s_Shader)
                    continue;

                var s_Name = Name(m_Mounter, s_Shader);
                var s_Key = s_SourceIndex.Builder.GetShaderKey(s_Name);
                var s_TemplateKey = s_TargetIndex.Builder.GetShaderKey(Name(p_Game, s_StandIn.Shader));

                // A translated shader keeps its name, so the database holds one entry for it, drawn with one
                // stand-in's solutions: an earlier bundle's translation serves this one when it is onto the
                // stand-in this bundle's meshes were fitted to. Onto another, those meshes may have a layout it
                // has no solution for, and are not drawn; they keep their stand-in.
                var s_Moved = Moved(s_Name).ToLowerInvariant();
                if (s_SbContext.TranslatedShaders.FirstOrDefault(p_T => p_T.Shader.Name == s_Moved) is { Shader: { } s_Earlier })
                {
                    if (s_Earlier.TemplateKey == s_TemplateKey)
                        s_Translated.Add(s_Shader);
                    else
                        p_Log.WriteLine($"STANDIN KEPT {s_Name}: translated onto another stand-in by an earlier bundle, this one's meshes are fitted to {Name(p_Game, s_StandIn.Shader)}");
                    continue;
                }
                if (GBuffer(s_SourceIndex, s_SourceReader, s_Key) is not var (s_Database, s_Sources) || s_Sources.Count == 0 ||
                    GBuffer(s_TargetIndex, s_TargetReader, s_TemplateKey) is not var (_, s_Templates) || s_Templates.Count == 0)
                    continue;

                var s_Targets = new List<(int, int)>();
                foreach (var s_Template in s_Templates)
                {
                    s_Targets.Add((s_Template.Index, s_Jobs.Count));
                    s_Jobs.Add(new ShaderTranslation.Job(s_Sources[0].Bytecode, s_Template.Bytecode));
                }

                s_Plans.Add((s_Shader, s_Database, s_Name, s_Key, s_Sources[0].Index, s_TemplateKey, s_Targets));
            }

            var s_Results = ShaderTranslation.Run(p_Translator, s_Jobs, p_Log);
            foreach (var s_Plan in s_Plans)
            {
                var s_Pixels = new Dictionary<int, byte[]>();
                foreach (var (s_Solution, s_Job) in s_Plan.Targets)
                {
                    if (s_Results[s_Job] is { LightmapTermMissing: false } s_Result)
                        s_Pixels[s_Solution] = s_Result.Bytecode;
                }

                p_Log.WriteLine(s_Pixels.Count == 0
                    ? $"STANDIN KEPT {s_Plan.Name}: none of its stand-in's {s_Plan.Targets.Count} g-buffer solution(s) translated"
                    : $"TRANSLATED {s_Plan.Name}: {s_Pixels.Count} of its stand-in's {s_Plan.Targets.Count} g-buffer solution(s)");
                if (s_Pixels.Count == 0)
                    continue;

                s_Translated.Add(s_Plan.Shader);
                s_SbContext.TranslatedShaders.Add((s_Plan.Database, m_Mounter, s_Plan.Name, m_Move,
                    new TranslatedShader(Moved(s_Plan.Name).ToLowerInvariant(), s_Plan.Key, s_Plan.SourceSolution, s_Plan.TemplateKey, c_RenderPath, s_Pixels)));
            }

            return s_Translated;
        }

        /// <summary>The name of the partition of an instance, or its GUID where the game has none.</summary>
        private static string Name(IEngineMounter p_Game, InstanceRef p_Ref) =>
            p_Game.TryGetPartitionByGuid(p_Ref.Partition, out var s_Name, out _) ? s_Name : p_Ref.Partition.ToString();

        /// <summary>A subset of a converted MeshSet as the target writes it, with its material's shader and its vertex declaration's hash.</summary>
        /// <param name="Repackable">Whether its vertices are in one stream of a LOD's chunk, which can be repacked.</param>
        private sealed record ConvertedSubset(string Mesh, int Lod, int Index, InstanceRef Shader, MeshSubsetModel Subset, uint Declaration, bool Repackable);

        /// <summary>The subsets of the converted mesh assets' MeshSets whose material has a shader.</summary>
        private IEnumerable<ConvertedSubset> ConvertedSubsets(List<(string Name, DatabasePartitionBase Partition)> p_Converted, IShaderBindings p_Bindings, IMeshSetCodec p_To)
        {
            var s_From = EngineInterfaceRegistry.Create<IMeshSetCodec>(m_Mounter.GetEngineType());
            foreach (var (s_Name, s_Partition) in p_Converted)
            {
                var s_Shaders = p_Bindings.MeshShaders(s_Partition);
                if (s_Shaders.Count == 0 || !m_Mounter.TryGetResource(s_Name, out var s_Resource)
                    || s_Resource.FirstVariant.GetResourceType() != ResourceType.MeshSet || !s_Resource.FirstVariant.TryGetMeta(out var s_Meta))
                    continue;

                MeshSetModel s_Model;
                try
                {
                    s_Model = MeshSetConversion.ToEngine(s_From.Decode(new MeshSetPayload(MountedTextures.Read(s_Resource.FirstVariant), s_Meta)), p_To, out _);
                }
                catch (Exception s_Ex) when (s_Ex is InvalidDataException or NotSupportedException)
                {
                    continue;
                }

                for (var l = 0; l < s_Model.Lods.Count; ++l)
                {
                    var s_Lod = s_Model.Lods[l];
                    for (var i = 0; i < s_Lod.Subsets.Count; ++i)
                    {
                        var s_Subset = s_Lod.Subsets[i];
                        if (s_Subset.MaterialIndex < s_Shaders.Count && s_Shaders[(int)s_Subset.MaterialIndex] is { } s_Shader)
                            yield return new ConvertedSubset(s_Name, l, i, s_Shader, s_Subset, p_To.DeclarationHash(s_Subset),
                                s_Lod.ChunkId != GUID.Empty && VertexLayout.OneStream(s_Subset) != null);
                    }
                }
            }
        }

        /// <summary>The vertex layouts the target's shaders have solutions for, from its mounted shader databases.</summary>
        private sealed class SolutionLayouts(ShaderDatabaseIndex p_Index, IEngineMounter p_Game, IMeshSetCodec p_Codec)
        {
            private readonly Dictionary<GUID, uint?> m_Keys = new();
            private readonly Dictionary<uint, VertexLayout?> m_Layouts = new();

            /// <summary>Whether the shader has a solution for the declaration.</summary>
            public bool Draws(InstanceRef p_Shader, uint p_Declaration) => Key(p_Shader) is { } s_Key && p_Index.Declarations.Draws(s_Key, p_Declaration);

            /// <summary>The layout of a declaration the shader has a solution for with the subset's elements, if any.</summary>
            public VertexLayout? Fits(InstanceRef p_Shader, ConvertedSubset p_Subset) =>
                Draws(p_Shader, p_Subset.Declaration) ? VertexLayout.OneStream(p_Subset.Subset)
                : Layouts(p_Shader).FirstOrDefault(p_L => p_L.Elements.SequenceEqual(p_Subset.Subset.Elements));

            /// <summary>The layout of a declaration the shader has a solution for that the subset's vertices fit best.</summary>
            public VertexLayout? Closest(InstanceRef p_Shader, ConvertedSubset p_Subset) =>
                VertexLayout.OneStream(p_Subset.Subset) is { } s_Own ? VertexLayoutChoice.Closest(s_Own, Layouts(p_Shader)) : null;

            private uint? Key(InstanceRef p_Shader)
            {
                if (!m_Keys.TryGetValue(p_Shader.Partition, out var s_Key))
                    m_Keys[p_Shader.Partition] = s_Key = p_Game.TryGetPartitionByGuid(p_Shader.Partition, out var s_Name, out _) ? p_Index.Builder.GetShaderKey(s_Name) : null;
                return s_Key;
            }

            /// <summary>The one-stream layouts of the declarations the shader has solutions for, in hash order.</summary>
            private IEnumerable<VertexLayout> Layouts(InstanceRef p_Shader)
            {
                if (Key(p_Shader) is not { } s_Key || !p_Index.Declarations.ByShader.TryGetValue(s_Key, out var s_Hashes))
                    yield break;

                foreach (var s_Hash in s_Hashes.Order())
                {
                    if (!m_Layouts.TryGetValue(s_Hash, out var s_Layout))
                    {
                        m_Layouts[s_Hash] = s_Layout = p_Index.Declarations.Declarations.TryGetValue(s_Hash, out var s_Bytes)
                            && p_Codec.ReadDeclaration(s_Bytes) is var (s_Elements, s_Streams)
                            ? VertexLayout.OneStream(s_Elements, s_Streams)
                            : null;
                    }

                    if (s_Layout != null)
                        yield return s_Layout;
                }
            }
        }

        /// <summary>
        /// The GUID of a source partition the target game has itself, under the same name and GUID,
        /// so references to it hold in the target; none where the target has no such partition.
        /// </summary>
        private GUID? TargetOwn(string p_Name)
        {
            if (TargetGame() is not var (_, s_Game) || !s_Game.TryGetPartition(p_Name, out var s_Target) || !m_Mounter.TryGetPartition(p_Name, out var s_Source))
                return null;

            var s_SourceGuid = m_Reader.FromPartitionObject(p_Name, s_Source.FirstVariant).PartitionGuid;
            var s_TargetGuid = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Game.GetEngineType()).FromPartitionObject(p_Name, s_Target.FirstVariant).PartitionGuid;
            return s_SourceGuid == s_TargetGuid ? s_SourceGuid : null;
        }

        /// <summary>Adds partitions of the target game, with their closure, that the converted content refers to.</summary>
        private void AddTargetPartitions(IReadOnlyList<string> p_Names, TextWriter p_Log)
        {
            if (p_Names.Count == 0 || TargetGame() is not var (s_Id, _)
                || PartitionClosure.Create(m_Context, s_Id, [], TextWriter.Null) is not { } s_Closure)
                return;

            s_Closure.AddAll(p_Names, p_Log);
        }

        /// <summary>The string with a leading name to move put under its new name.</summary>
        private string Moved(string p_String) =>
            m_Move is var (s_From, s_To) && p_String.StartsWith(s_From, StringComparison.OrdinalIgnoreCase)
                ? s_To + p_String[s_From.Length..]
                : p_String;
    }
}
