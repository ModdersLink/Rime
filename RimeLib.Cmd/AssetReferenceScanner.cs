using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Mesh;
using RimeLib.Serialization;
using RimeLib.Serialization.Attributes;
using RimeLib.Texture;

namespace RimeLib.Cmd
{
    /// <summary>
    /// Finds what a single partition or resource references, without following it any further.
    ///
    /// The references come in three layers. A closure that stops after the first one still crashes:
    ///  1. EBX instance fields: other partitions, resources named after an Asset, chunk guids.
    ///  2. Chunk guids read out of a resource payload (MeshSet lods, DxTexture mips).
    ///  3. Resource names read out of a resource payload (terrain, Enlighten).
    /// A mesh partition additionally binds the texture partitions its MeshVariationDatabase entries
    /// name, which nothing in the EBX itself refers to.
    ///
    /// Everything goes through the engine interfaces, so this works for any engine whose support
    /// assemblies are loaded. <see cref="MeshVariationDbIndex"/> has to be built for the texture
    /// bindings to be found.
    /// </summary>
    internal sealed class AssetReferenceScanner
    {
        /// <summary>The outgoing references of one item.</summary>
        internal sealed class References
        {
            /// <summary>Partition names. A guid that does not resolve is kept as the guid text.</summary>
            public List<string> Partitions { get; } = new();

            /// <summary>
            /// Resource names. Names derived from an instance's Name are speculative (every bind the
            /// engine performs off Asset.Name is tried), so most of them do not exist; check before use.
            /// </summary>
            public List<string> Resources { get; } = new();

            /// <summary>Chunk guids, with the asset name that owns them when a payload named them.</summary>
            public List<(GUID Id, string? AssetName, string Origin)> Chunks { get; } = new();

            /// <summary>Resource names a payload listed, for logging. Also contained in <see cref="Resources"/>.</summary>
            public List<string> PayloadResources { get; } = new();

            /// <summary>Why something could not be scanned completely.</summary>
            public List<string> Problems { get; } = new();

            /// <summary>The partition's primary instance type, or the resource type.</summary>
            public string? TypeName { get; set; }

            /// <summary>The parsed partition, for callers that need more than its references.</summary>
            public DatabasePartitionBase? Parsed { get; set; }
        }

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

        /// <summary>Whether a mesh partition binds the textures its MeshVariationDatabase entries name.</summary>
        public bool BindMeshVariationTextures { get; init; } = true;

        private readonly IEngineMounter m_Mounter;
        private readonly IPartitionConverter m_PartitionConverter;
        private readonly ITextureConverter? m_TextureConverter;
        private readonly IMeshConverter? m_MeshConverter;

        public AssetReferenceScanner(IEngineMounter p_Mounter, IPartitionConverter p_PartitionConverter,
            ITextureConverter? p_TextureConverter, IMeshConverter? p_MeshConverter)
        {
            m_Mounter = p_Mounter;
            m_PartitionConverter = p_PartitionConverter;
            m_TextureConverter = p_TextureConverter;
            m_MeshConverter = p_MeshConverter;
        }

        /// <summary>Layer 1 for every instance of a partition, plus its MeshVariationDatabase texture bindings.</summary>
        /// <param name="p_Name">The partition's name.</param>
        /// <param name="p_Variant">The variant to read.</param>
        /// <param name="p_SkipInstance">Instances to leave out, e.g. a RegistryContainer whose entries a caller treats separately.</param>
        public References ScanPartition(string p_Name, IObjectVariant p_Variant, Func<DataContainerBase, bool>? p_SkipInstance = null)
        {
            var s_References = new References();

            try
            {
                var s_Parsed = PartitionCache.Parse(m_PartitionConverter, p_Name, p_Variant);
                s_References.TypeName = s_Parsed.PrimaryInstance?.GetType().Name;
                s_References.Parsed = s_Parsed;

                foreach (var s_Instance in s_Parsed.Instances)
                {
                    if (s_Instance != null && p_SkipInstance != null && p_SkipInstance(s_Instance))
                        continue;

                    WalkInstance(s_Instance, $"{p_Name}#{s_Instance?.GetType().Name}", s_References);
                }

                if (BindMeshVariationTextures)
                    CollectMeshVariationTextures(p_Name, s_Parsed.PartitionGuid, s_References);
            }
            catch (Exception s_Ex)
            {
                s_References.Problems.Add($"partition {p_Name} could not be parsed: {s_Ex.Message}");
            }

            return s_References;
        }

        /// <summary>Layers 2 and 3 for a resource.</summary>
        public References ScanResource(string p_Name, IResourceVariant p_Variant)
        {
            var s_Type = p_Variant.GetResourceType();
            var s_References = new References { TypeName = s_Type.ToString() };

            CollectPayloadChunks(p_Name, p_Variant, s_Type, s_References);
            CollectPayloadNames(p_Name, p_Variant, s_Type, s_References);

            return s_References;
        }

        /// <summary>
        /// The textures a mesh partition's MeshVariationDatabase entries bind. Nothing in the EBX
        /// names these, so this index is the only way a closure walk reaches them.
        /// </summary>
        private void CollectMeshVariationTextures(string p_Name, GUID p_PartitionGuid, References p_References)
        {
            if (!MeshVariationDbIndex.TryGetTexturePartitions(p_PartitionGuid, out var s_Textures))
                return;

            foreach (var s_Texture in s_Textures)
            {
                if (!m_Mounter.TryGetPartitionByGuid(s_Texture, out var s_TextureName, out _))
                {
                    p_References.Problems.Add($"MVDB texture partition {s_Texture} bound by a mesh in {p_Name}");
                    continue;
                }

                p_References.Partitions.Add(s_TextureName);
            }
        }

        /// <summary>
        /// Layer 3: the resource names a resource holds inside its own payload. An EBX walk cannot
        /// reach these, and neither can a chunk-guid walk, so a level with terrain or Enlighten is
        /// under-resolved without them.
        /// </summary>
        private void CollectPayloadNames(string p_Name, IResourceVariant p_Variant, ResourceType p_Type, References p_References)
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
                p_References.Problems.Add($"resource {p_Name} ({p_Type}) payload could not be read: {s_Ex.Message}");
                return;
            }

            var s_Payload = ResourcePayloadDependencies.Read(p_Type, s_Data);

            if (s_Payload.Error != null)
            {
                p_References.Problems.Add($"resource {p_Name} ({p_Type}) payload could not be walked: {s_Payload.Error}");
                return;
            }

            foreach (var s_Resource in s_Payload.ResourceNames)
            {
                p_References.Resources.Add(s_Resource);
                p_References.PayloadResources.Add(s_Resource);

                // A name in a payload names the asset as well as the resource: terrain's
                // TerrainDecalsData and TerrainStreamingTreeAsset partitions hold nothing but the
                // name the VisualTerrain and Terrain payloads use, and nothing else refers to them.
                if (m_Mounter.TryGetPartition(s_Resource, out _))
                    p_References.Partitions.Add(s_Resource);
            }

            p_References.Partitions.AddRange(s_Payload.PartitionNames);

            foreach (var s_Chunk in s_Payload.ChunkIds)
                p_References.Chunks.Add((s_Chunk, p_Name, $"{p_Name} payload"));
        }

        /// <summary>Layer 2: the chunk guids a resource reads out of its own payload.</summary>
        private void CollectPayloadChunks(string p_Name, IResourceVariant p_Variant, ResourceType p_Type, References p_References)
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
                        p_References.Chunks.Add((s_ChunkId, p_Name, p_Name));
                }
                else if (p_Type == ResourceType.MeshSet)
                {
                    if (m_MeshConverter == null)
                        return;

                    foreach (var (s_Lod, s_ChunkId) in m_MeshConverter.GetLodChunkIds(p_Variant))
                        p_References.Chunks.Add((s_ChunkId, p_Name, $"{p_Name} lod{s_Lod}"));
                }
            }
            catch (Exception s_Ex)
            {
                p_References.Problems.Add($"resource {p_Name} ({p_Type}) payload could not be read for chunks: {s_Ex.Message}");
            }
        }

        /// <summary>Layer 1: everything an instance names, by reference, by resource name or by chunk guid.</summary>
        private void WalkInstance(DataContainerBase? p_Instance, string p_Origin, References p_References)
        {
            if (p_Instance == null)
                return;

            CollectFields(p_Instance, p_Origin, p_References);

            var s_Type = p_Instance.GetType();

            if (s_Type.GetProperty("Name")?.GetValue(p_Instance) is string s_Name && s_Name.Length > 0)
            {
                var s_Lower = s_Name.ToLowerInvariant();

                foreach (var s_Suffix in c_NameSuffixes)
                    p_References.Resources.Add($"{s_Lower}{s_Suffix}");
            }

            if (s_Type.GetProperty("ResourceName")?.GetValue(p_Instance) is string s_ResourceName && s_ResourceName.Length > 0)
                p_References.Resources.Add(s_ResourceName.ToLowerInvariant());
        }

        /// <summary>
        /// Walks the reflected fields of an instance or a nested struct, collecting partition
        /// references and chunk guids.
        ///
        /// Guids are matched against the mounted chunk table instead of a list of known chunk
        /// fields. Most guid fields hold partition or instance ids, which are not in that table, so
        /// the table does the classifying and nothing has to be listed by hand.
        /// </summary>
        private void CollectFields(object? p_Object, string p_Origin, References p_References)
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

                CollectValue(s_Value, p_Origin, p_References);
            }
        }

        private void CollectValue(object? p_Value, string p_Origin, References p_References)
        {
            switch (p_Value)
            {
                case null:
                    return;

                case CtrRefBase s_Ref:
                    if (!s_Ref.IsNull())
                        p_References.Partitions.Add(ResolvePartitionName(s_Ref.PartitionGuid));
                    return;

                case ResourceRef s_ResourceRef:
                    // Newer engines reference resources by id rather than by an asset's name.
                    if (s_ResourceRef.Id != 0 && m_Mounter.TryGetResource(s_ResourceRef, out var s_Resource))
                        p_References.Resources.Add(s_Resource.OriginalName.ToLowerInvariant());
                    return;

                case GUID s_Guid:
                    if (s_Guid != GUID.Empty && m_Mounter.TryGetChunk(s_Guid, out _))
                        p_References.Chunks.Add((s_Guid, null, p_Origin));
                    return;

                case string:
                    return;

                case EbxSerializable s_Serializable:
                    CollectFields(s_Serializable, p_Origin, p_References);
                    return;

                case IEnumerable s_Enumerable:
                    foreach (var s_Item in s_Enumerable)
                        CollectValue(s_Item, p_Origin, p_References);
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
    }
}
