using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
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
using RimeLib.Texture.Generation;
using RimeLib.Utils;

namespace RimeLib.Cmd.Contexts
{
    public class BundleBuildingContext : ExecutionContext
    {
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

        internal class ResourceMemoryReader : SbBuildingContext.MemoryReader, IResourceObject
        {
            private readonly ResourceType m_ResourceType;
            private readonly ResourceRef m_ResourceId;

            public ResourceMemoryReader(byte[] p_Data, ResourceType p_ResourceType, string p_Name) : base(p_Data)
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
            RegisterCommand<RemoveChunkCommand>();
            RegisterCommand<ListChunksCommand>();
            RegisterCommand<AddResourceCommand>();
            RegisterCommand<AddExistingResourceCommand>();
            RegisterCommand<ReplaceResourceCommand>();
            RegisterCommand<ReplaceResourceAsCommand>();
            RegisterCommand<RemoveResourceCommand>();

            if (EngineInterfaceRegistry.IsSupported<RimeLib.Terrain.Resources.ITerrainDecalsConverter>(
                ((SbBuildingContext)p_Parent).EngineType))
            {
                RegisterCommand<ReplaceTerrainDecalsCommand>();
            }
            RegisterCommand<ListResourcesCommand>();
            RegisterCommand<AddPartitionCommand>();
            RegisterCommand<AddExistingPartitionCommand>();
            RegisterCommand<AddRawPartitionCommand>();
            RegisterCommand<RaiseWaterPhysicsCommand>();
            RegisterCommand<ClonePartitionFreshCommand>();

            var s_EngineType = ((SbBuildingContext)p_Parent).EngineType;

            if (EngineInterfaceRegistry.IsSupported<IPartitionConverter>(s_EngineType) && 
                EngineInterfaceRegistry.IsSupported<IPartitionGenerator>(s_EngineType))
            {
                RegisterCommand<AddJsonPartitionCommand>();
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

            if (EngineInterfaceRegistry.IsSupported<IPartitionConverter>(s_EngineType))
            {
                RegisterCommand<ResolvePartitionDependenciesCommand>();
            }

            RegisterCommand<ResolveResourceDependenciesCommand>();

            if (EngineInterfaceRegistry.IsSupported<IShaderResolver>(s_EngineType))
            {
                RegisterCommand<ResolveShaderTexturesCommand>();
            }

            RegisterCommand<RemoveDuplicateBundleItemsCommand>();
            RegisterCommand<ResolveMissingChunksCommand>();
            RegisterCommand<ExportBundleContentsCommand>();
            RegisterCommand<GenerateRegistryContainerCommand>();
            RegisterCommand<CompareRegistryContainersCommand>();
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

        internal void AddRawPartition(string p_Name, FileInfo p_File)
        {
            // Inject a raw EBX partition binary (from dump_partition) byte-for-byte, bypassing
            // the JSON converter — preserves the exact game-built structure (so it realizes).
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
                new ResourceMemoryReader(s_ResourceMemoryStream.ToArray(), s_TextureGenerator.GetTargetResourceType(), p_Attributes.Name)
            );

            foreach (var (s_Id, s_ChunkStream) in s_Chunks)
            {
                m_Builder.WithChunk(s_Id, new ChunkMemoryReader(s_ChunkStream.ToArray(), p_Attributes.Name));
                s_ChunkStream.Dispose();
            }
        }

        internal BundleDescriptor Build()
        {
            return m_Builder.Build();
        }
    }
}
