using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using RimeLib.Cmd.Commands.BundleBuilding;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Extensions;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.Serialization;
using RimeLib.Shader;
using RimeLib.Terrain.Resources;
using RimeLib.Texture.Generation;
using RimeLib.Utils;

namespace RimeLib.Cmd.Contexts
{
    public class BundleBuildingContext : ExecutionContext
    {
        /// <summary>
        /// TODO: Move this
        /// </summary>
        internal class ResourceFileReader : SbBuildingContext.FileReader, IResourceObject
        {
            private readonly ResourceType m_ResourceType;
            private readonly ResourceRef m_ResourceId;

            public ResourceFileReader(string p_Path, ResourceType p_ResourceType, string p_Name) : base(p_Path)
            {
                m_ResourceType = p_ResourceType;
                m_ResourceId = new ResourceRef(p_Name, this);
            }

            public ResourceType GetResourceType()
            {
                return m_ResourceType;
            }

            public bool TryGetMeta([NotNullWhen(true)] out byte[]? p_Meta)
            {
                p_Meta = null;
                return false;
            }

            public ResourceRef GetId(string? p_Name = null)
            {
                return m_ResourceId;
            }
        }

        /// <summary>
        /// TODO: Move this
        /// </summary>
        internal class ResourceMemoryReader : SbBuildingContext.MemoryReader, IResourceObject
        {
            private readonly ResourceType m_ResourceType;
            private readonly ResourceRef m_ResourceId;
            private readonly byte[]? m_Meta;

            public ResourceMemoryReader(byte[] p_Data, ResourceType p_ResourceType, string p_Name, byte[]? p_Meta = null) : base(p_Data)
            {
                m_ResourceType = p_ResourceType;
                m_ResourceId = new ResourceRef(p_Name, this);
                m_Meta = p_Meta;
            }

            public ResourceType GetResourceType()
            {
                return m_ResourceType;
            }

            public bool TryGetMeta([NotNullWhen(true)] out byte[]? p_Meta)
            {
                p_Meta = m_Meta;
                return m_Meta != null;
            }
            
            public ResourceRef GetId(string? p_Name = null)
            {
                return m_ResourceId;
            }
        }

        /// <summary>
        /// TODO: Move this
        /// </summary>
        internal class ChunkMemoryReader : SbBuildingContext.MemoryReader, IChunkObject
        {
            private readonly string m_AssetName;

            public ChunkMemoryReader(byte[] p_Data, string p_AssetName) : base(p_Data)
            {
                m_AssetName = p_AssetName;
            }

            public bool TryGetMeta([NotNullWhen(true)] out DbObject? p_Meta)
            {
                p_Meta = null;
                return false;
            }

            public uint GetRangeStart()
            {
                return 0;
            }

            public uint GetRangeEnd()
            {
                return (uint)GetSize();
            }

            public uint GetLogicalOffset()
            {
                return 0;
            }

            public uint GetLogicalSize()
            {
                return (uint)GetSize();
            }

            public int? GetAssetNameHash()
            {
                return (int)Frostbite.Utils.HashQuick(m_AssetName);
            }
        }

        protected readonly string m_BundleName;

        protected BundleBuilder m_Builder;

        protected fb.RegistryContainer? m_GeneratedRegistry;

        public BundleBuildingContext(SbBuildingContext p_Parent, string p_BundleName)
        {
            Parent = p_Parent;
            m_BundleName = p_BundleName;

            m_Builder = BundleBuilder.Create(m_BundleName);

            RegisterCommand<AddChunkCommand>();
            RegisterCommand<AddExistingChunkCommand>();
            RegisterCommand<AddCasChunkCommand>();
            RegisterCommand<RemoveChunkCommand>();
            RegisterCommand<ListChunksCommand>();
            RegisterCommand<AddResourceCommand>();
            RegisterCommand<AddExistingResourceCommand>();
            RegisterCommand<ReplaceResourceCommand>();
            RegisterCommand<ReplaceResourceAsCommand>();
            RegisterCommand<RemoveResourceCommand>();

            if (EngineInterfaceRegistry.IsSupported<ITerrainDecalsConverter>(p_Parent.EngineType))
                RegisterCommand<ReplaceTerrainDecalsCommand>();

            RegisterCommand<ListResourcesCommand>();
            RegisterCommand<AddPartitionCommand>();
            RegisterCommand<AddRawPartitionCommand>();
            RegisterCommand<RaiseWaterPhysicsCommand>();
            RegisterCommand<ClonePartitionFreshCommand>();
            RegisterCommand<MeshVariationDbAddEntryCommand>();
            RegisterCommand<MeshVariationDbAddAllCommand>();
            RegisterCommand<StripSbLevelChunksCommand>();
            RegisterCommand<CapTextureCommand>();

            var s_EngineType = p_Parent.EngineType;

            if (EngineInterfaceRegistry.IsSupported<IPartitionConverter>(s_EngineType) &&
                EngineInterfaceRegistry.IsSupported<IPartitionGenerator>(s_EngineType))
            {
                RegisterCommand<AddJsonPartitionCommand>();
            }

            if (EngineInterfaceRegistry.IsSupported<IPartitionConverter>(s_EngineType))
            {
                RegisterCommand<ReferenceExistingPartitionCommand>();
            }

            RegisterCommand<RemovePartitionCommand>();
            RegisterCommand<ListPartitionsCommand>();

            if (EngineInterfaceRegistry.IsSupported<ITextureGenerator>(s_EngineType))
            {
                RegisterCommand<AddDdsTextureCommand>();
            }

            RegisterCommand<BuildCommand>();
            RegisterCommand<CloneBundleCommand>();
            RegisterCommand<AddDependencyBundleCommand>();
            RegisterCommand<AddDependencySuperbundleCommand>();
            RegisterCommand<AddScenarioBundleCommand>();

            if (EngineInterfaceRegistry.IsSupported<IShaderResolver>(s_EngineType))
            {
                RegisterCommand<ResolveShaderTexturesCommand>();
            }

            RegisterCommand<ExportBundleContentsCommand>();
            RegisterCommand<GenerateRegistryContainerCommand>();
            RegisterCommand<CompareRegistryContainersCommand>();
            RegisterCommand<EmitSubworldRegistryCommand>();
            RegisterCommand<KeepOnlyPartitionCommand>();
        }

        public bool Cas()
        {
            var s_SbBuildingContext = Parent as SbBuildingContext;
            if (s_SbBuildingContext == null)
                throw new System.Exception();

            return s_SbBuildingContext.Cas();
        }

        public override string GetShortDescription()
        {
            var s_Chunks = m_Builder.GetChunks().Count;
            var s_Resources = m_Builder.GetResources().Count;
            var s_Partitions = m_Builder.GetPartitions().Count;

            return $"building bundle - {m_BundleName} - {s_Chunks} chunk{(s_Chunks == 1 ? "" : "s")} - {s_Resources} resource{(s_Resources == 1 ? "" : "s")} - {s_Partitions} partition{(s_Partitions == 1 ? "" : "s")}";
        }

        public override string GetLongDescription()
        {
            var s_Chunks = m_Builder.GetChunks().Count;
            var s_Resources = m_Builder.GetResources().Count;
            var s_Partitions = m_Builder.GetPartitions().Count;

            var s_Text = "Bundle Builder\n\n";
            s_Text += $"Bundle name: {m_BundleName}\n";
            s_Text += $"Chunks added: {s_Chunks}\n";
            s_Text += $"Resources added: {s_Resources}\n";
            s_Text += $"Partitions added: {s_Partitions}\n";

            return s_Text;
        }

        internal void AddChunk(GUID p_Guid, FileInfo p_File, string p_AssetName)
        {
            m_Builder.WithChunk(p_Guid, new SbBuildingContext.ChunkFileReader(p_File.FullName, p_AssetName));
        }

        internal void AddChunk(GUID p_Guid, FileInfo p_File, int p_AssetHash)
        {
            m_Builder.WithChunk(p_Guid, new SbBuildingContext.ChunkFileReader(p_File.FullName, p_AssetHash));
        }

        internal void AddChunk(GUID p_Guid, IChunkObject p_Object)
        {
            m_Builder.WithChunk(p_Guid, p_Object);
        }

        internal void RemoveChunk(GUID p_Guid)
        {
            m_Builder.RemoveChunk(p_Guid);
        }

        internal IReadOnlyDictionary<GUID, IChunkObject> GetChunks()
        {
            return m_Builder.GetChunks();
        }

        internal void AddResource(string p_Name, ResourceType p_Type, FileInfo p_File)
        {
            m_Builder.WithResource(p_Name, new ResourceFileReader(p_File.FullName, p_Type, p_Name));
        }

        internal void AddResource(string p_Name, IResourceObject p_Object)
        {
            m_Builder.WithResource(p_Name, p_Object);
        }

        internal void RemoveResource(string p_Name)
        {
            m_Builder.RemoveResource(p_Name);
        }

        internal IReadOnlyDictionary<string, IResourceObject> GetResources()
        {
            return m_Builder.GetResources();
        }

        internal void AddPartition(string p_Name, FileInfo p_File)
        {
            m_Builder.WithPartition(p_Name, new SbBuildingContext.FileReader(p_File.FullName));
        }

        internal void AddPartition(string p_Name, IObjectVariant p_Partition)
        {
            m_Builder.WithPartition(p_Name, p_Partition);
        }

        internal void AddJsonPartition(string p_Name, FileInfo p_File)
        {
            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(((SbBuildingContext)Parent!).EngineType);
            var s_Generator = EngineInterfaceRegistry.Create<IPartitionGenerator>(((SbBuildingContext)Parent!).EngineType);

            using var s_JsonReader = p_File.OpenText();
            var s_Partition = s_Converter.FromJsonStream(s_JsonReader);

            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);
            s_Generator.Generate(s_Partition, s_Writer);

            m_Builder.WithPartition(p_Name, new SbBuildingContext.MemoryReader(s_Stream.ToArray()));
        }

        // Injects a raw EBX partition binary byte for byte, bypassing the JSON converter, so the exact
        // structure the game built is preserved and the partition still realizes.
        internal void AddRawPartition(string p_Name, FileInfo p_File)
        {
            m_Builder.WithPartition(p_Name, new SbBuildingContext.MemoryReader(File.ReadAllBytes(p_File.FullName)));
        }

        internal void AddRawPartitionBytes(string p_Name, byte[] p_Data)
        {
            m_Builder.WithPartition(p_Name, new SbBuildingContext.MemoryReader(p_Data));
        }

        internal void RemovePartition(string p_Name)
        {
            m_Builder.RemovePartition(p_Name);
        }

        internal void SetGeneratedRegistry(fb.RegistryContainer p_Registry)
        {
            m_GeneratedRegistry = p_Registry;
        }

        internal fb.RegistryContainer? GetGeneratedRegistry()
        {
            return m_GeneratedRegistry;
        }

        /// <summary>
        /// TODO: Move this
        ///
        /// A mini MVDB goes in through AddRawPartitionBytes, and a MemoryReader is not an IObjectVariant,
        /// so generate_registry_container cannot parse it and never collects it. mvdb_add_all leaves the
        /// sliced MVDB's partition and primary instance guids here instead, for emit_subworld_registry to
        /// put in the SubWorld's AssetRegistry.
        /// </summary>
        private readonly List<(GUID Part, GUID Inst)> m_MeshVariationDbRegistryRefs = [];

        internal void AddMeshVariationDbRegistryRef(GUID p_Part, GUID p_Inst)
        {
            m_MeshVariationDbRegistryRefs.Add((p_Part, p_Inst));
        }

        internal IReadOnlyList<(GUID Part, GUID Inst)> GetMvdbRegistryRefs()
        {
            return m_MeshVariationDbRegistryRefs;
        }

        internal IReadOnlyDictionary<string, IReadableObject> GetPartitions()
        {
            return m_Builder.GetPartitions();
        }

        internal void AddDependencyBundle(string p_BundleName)
        {
            m_Builder.WithDependencyBundle(p_BundleName);
        }

        internal IEnumerable<string> GetDependencyBundles()
        {
            return m_Builder.Build().DependencyBundles;
        }

        // Scenarios never reach the builder. They only bound the closure, so they live here rather
        // than in the bundle being emitted.
        private readonly Dictionary<string, HashSet<string>> m_Scenarios = new(StringComparer.OrdinalIgnoreCase);

        internal void AddScenarioBundle(string p_Scenario, string p_BundleName)
        {
            if (!m_Scenarios.TryGetValue(p_Scenario, out var s_Bundles))
                m_Scenarios[p_Scenario] = s_Bundles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            s_Bundles.Add(p_BundleName);
        }

        internal IReadOnlyDictionary<string, HashSet<string>> GetScenarios()
        {
            return m_Scenarios;
        }

        internal void AddDependencySuperbundle(string p_SuperbundleName)
        {
            m_Builder.WithDependencySuperbundle(p_SuperbundleName);
        }

        internal IEnumerable<string> GetDependencySuperbundles()
        {
            return m_Builder.Build().DependencySuperbundles;
        }

        // TODO: This should probably be moved somewhere else
        internal void AddDDSTexture(FileInfo p_File, TextureAttributes p_Attributes)
        {
            var s_TextureGenerator = EngineInterfaceRegistry.Create<ITextureGenerator>(((SbBuildingContext)Parent!).EngineType);

            // A regenerated texture has to keep the original's TextureGroup, held as a char[16] at
            // offset 112 of the 128-byte header. "Default" is not a group the game knows, and the
            // mesh texture bind path never uploads a texture whose group it cannot pool.
            try
            {
                var s_BaseContext = (BaseContext)((SbBuildingContext)Parent!).Parent!;
                var s_Mounter = s_BaseContext.GetMounters().Values.FirstOrDefault();
                if (s_Mounter != null && s_Mounter.TryGetResource(p_Attributes.Name, out var s_Original))
                {
                    using var s_OriginalReader = s_Original.FirstVariant.GetReader();
                    if (s_OriginalReader.Length >= 128)
                    {
                        var s_Header = s_OriginalReader.ReadBytes(128);
                        var s_GroupEnd = Array.IndexOf(s_Header, (byte)0, 112, 16);
                        if (s_GroupEnd < 0) s_GroupEnd = 128;

                        var s_Group = Encoding.ASCII.GetString(s_Header, 112, s_GroupEnd - 112);
                        if (!string.IsNullOrWhiteSpace(s_Group))
                            p_Attributes.TextureGroup = s_Group;
                    }
                }
            }
            catch { }

            var s_ResourceMemoryStream = new MemoryStream();
            using var s_ResourceWriter = new RimeWriter(s_ResourceMemoryStream);

            using var s_DDSReader = new RimeReader(File.OpenRead(p_File.FullName));
            s_TextureGenerator.GenerateFromDDS(
                s_DDSReader,
                p_Attributes,
                s_ResourceWriter,
                out var s_Chunks
            );

            m_Builder.WithResource(
                p_Attributes.Name,
                // Every original DxTexture entry carries 16 zero bytes of meta rather than none.
                new ResourceMemoryReader(s_ResourceMemoryStream.ToArray(), s_TextureGenerator.GetTargetResourceType(), p_Attributes.Name, new byte[16])
            );

            foreach (var (s_Id, s_ChunkStream) in s_Chunks)
            {
                m_Builder.WithChunk(s_Id, new ChunkMemoryReader(s_ChunkStream.ToArray(), p_Attributes.Name));
                s_ChunkStream.Dispose();
            }
        }

        internal void AddGeneratedResource(string p_Name, byte[] p_Data, ResourceType p_Type, byte[]? p_Meta)
        {
            m_Builder.WithResource(p_Name, new ResourceMemoryReader(p_Data, p_Type, p_Name, p_Meta));
        }

        internal BundleDescriptor Build()
        {
            return m_Builder.Build();
        }
    }
}
