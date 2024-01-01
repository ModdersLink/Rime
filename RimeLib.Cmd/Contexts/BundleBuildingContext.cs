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
using RimeLib.Texture.Generation;
using RimeLib.Utils;

namespace RimeLib.Cmd.Contexts
{
    public class BundleBuildingContext : ExecutionContext
    {
        internal class ResourceFileReader : SbBuildingContext.FileReader, IResourceObject
        {
            private readonly ResourceType m_ResourceType;

            public ResourceFileReader(string p_Path, ResourceType p_ResourceType) :
                base(p_Path)
            {
                m_ResourceType = p_ResourceType;
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
        }
        
        internal class ResourceMemoryReader : SbBuildingContext.MemoryReader, IResourceObject
        {
            private readonly ResourceType m_ResourceType;

            public ResourceMemoryReader(byte[] p_Data, ResourceType p_ResourceType) : base(p_Data)
            {
                m_ResourceType = p_ResourceType;
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

            public uint GetLogicalOffset()
            {
                return 0;
            }

            public int? GetAssetNameHash()
            {
                return (int) Frostbite.Utils.HashQuick(m_AssetName);
            }
        }

        protected readonly string m_BundleName;

        protected BundleBuilder m_Builder;

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
            RegisterCommand<RemoveResourceCommand>();
            RegisterCommand<ListResourcesCommand>();
            RegisterCommand<AddPartitionCommand>();
            RegisterCommand<AddJsonPartitionCommand>();
            RegisterCommand<RemovePartitionCommand>();
            RegisterCommand<ListPartitionsCommand>();
            RegisterCommand<AddDdsTextureCommand>();
            RegisterCommand<BuildCommand>();
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
            m_Builder.WithResource(p_Name, new ResourceFileReader(p_File.FullName, p_Type));
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

        internal void AddJsonPartition(string p_Name, FileInfo p_File)
        {
            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(((SbBuildingContext) Parent!).EngineType);
            var s_Generator = EngineInterfaceRegistry.Create<IPartitionGenerator>(((SbBuildingContext) Parent!).EngineType);

            using var s_JsonReader = p_File.OpenText();
            var s_Partition = s_Converter.FromJsonStream(s_JsonReader);

            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);
            s_Generator.Generate(s_Partition, s_Writer);
            
            m_Builder.WithPartition(p_Name, new SbBuildingContext.MemoryReader(s_Stream.ToArray()));
        }

        internal void RemovePartition(string p_Name)
        {
            m_Builder.RemovePartition(p_Name);
        }

        internal IReadOnlyDictionary<string, IReadableObject> GetPartitions()
        {
            return m_Builder.GetPartitions();
        }

        // TODO: This should probably be moved somewhere else
        internal void AddDDSTexture(FileInfo p_File, TextureAttributes p_Attributes)
        {
            var s_TextureGenerator = EngineInterfaceRegistry.Create<ITextureGenerator>(((SbBuildingContext) Parent!).EngineType);

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
                new ResourceMemoryReader(s_ResourceMemoryStream.ToArray(), s_TextureGenerator.GetTargetResourceType())
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
