using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Commands.Game;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization;
using RimeLib.Texture;

namespace RimeLib.Cmd.Contexts
{
    public class GameContext : ExecutionContext
    {
        protected int m_Id;
        protected IEngineMounter m_Mounter;

        public GameContext(BaseContext p_Parent, int p_Id, IEngineMounter p_Mounter)
        {
            Parent = p_Parent;
            m_Id = p_Id;
            m_Mounter = p_Mounter;

            RegisterCommand<ListSbCommand>();
            RegisterCommand<MountSbCommand>();
            RegisterCommand<ListMountedSbCommand>();
            RegisterCommand<ListBundlesCommand>();
            RegisterCommand<MountBundleCommand>();
            RegisterCommand<MountAllBundlesCommand>();
            RegisterCommand<ListMountedBundlesCommand>();
            RegisterCommand<ListChunksCommand>();
            RegisterCommand<ListDuplicateChunksCommand>();
            RegisterCommand<ListResourcesCommand>();
            RegisterCommand<ListPartitionsCommand>();
            RegisterCommand<ListBundleChunksCommand>();
            RegisterCommand<ListBundleResourcesCommand>();
            RegisterCommand<ListBundlePartitionsCommand>();
            RegisterCommand<DumpChunkCommand>();
            RegisterCommand<DumpResourceCommand>();
            RegisterCommand<DumpPartitionCommand>();
            RegisterCommand<DumpPartitionJsonCommand>();
            RegisterCommand<DumpTextureCommand>();
        }

        public override string GetShortDescription()
        {
            return $"{m_Id} - {m_Mounter.GetGamePath()} - {m_Mounter.GetEngineType()}";
        }

        public override string GetLongDescription()
        {
            var s_Text = "Mounted Game Context\n\n";
            s_Text += $"Game ID: {m_Id}\n";
            s_Text += $"Game Path: {m_Mounter.GetGamePath()}\n";
            s_Text += $"Game Engine: {m_Mounter.GetEngineType()}";
            return s_Text;
        }

        internal void MountSuperbundle(string p_Name, bool p_AutoMount)
        {
            m_Mounter.MountSuperbundle(p_Name, p_AutoMount).Wait();
        }

        internal void MountBundle(string p_Name)
        {
            m_Mounter.MountBundle(p_Name).Wait();
        }

        internal IEnumerable<string> GetAvailableSuperbundles()
        {
            return m_Mounter.GetAvailableSuperbundles();
        }

        internal IEnumerable<string> GetAvailableBundles()
        {
            return m_Mounter.GetAvailableBundles();
        }

        internal IEnumerable<string> GetMountedSuperbundles()
        {
            return m_Mounter.GetMountedSuperbundles();
        }

        internal IEnumerable<string> GetMountedBundles()
        {
            return m_Mounter.GetMountedBundles();
        }

        internal void DumpChunk(GUID p_Guid, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetChunk(p_Guid, out var s_Chunk))
                throw new Exception($"Could not find chunk with id '{p_Guid.ToString("D")}'.");

            // Here we look for the first chunk variant with logical offset 0.
            // That's because variants with non-0 offsets can be partial mips, etc.
            using var s_Reader = s_Chunk.Variants.First(p_Variant => p_Variant.GetLogicalOffset() == 0).GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        internal void DumpResource(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            using var s_Reader = s_Resource.FirstVariant.GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        internal void DumpPartition(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetPartition(p_Name, out var s_Partition))
                throw new Exception($"Could not find partition with name '{p_Name}'.");

            using var s_Reader = s_Partition.FirstVariant.GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        internal void DumpPartitionJson(string p_Name, FileInfo p_Destination, Formatting p_Formatting)
        {
            if (!m_Mounter.TryGetPartition(p_Name, out var s_PartitionObject))
                throw new Exception($"Could not find partition with name '{p_Name}'.");

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(m_Mounter.GetEngineType());

            var s_Partition = s_Converter.FromPartitionObject(p_Name, s_PartitionObject.FirstVariant);
            s_Partition.ToJsonFile(p_Destination.FullName, p_Formatting);
        }

        internal void DumpTexture(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(m_Mounter.GetEngineType());
      
            var s_FileStream = File.Create(p_Destination.FullName);
            using var s_Writer = new RimeWriter(s_FileStream);

            s_Converter.ConvertToDDS(s_Resource.FirstVariant!, m_Mounter, s_Writer);
        }

        internal IEnumerable<GUID> GetBundleChunks(string p_Bundle)
        {
            return m_Mounter.GetChunksInBundle(p_Bundle);
        }

        internal IEnumerable<string> GetBundleResources(string p_Bundle)
        {
            return m_Mounter.GetResourcesInBundle(p_Bundle);
        }

        internal IEnumerable<string> GetBundlePartitions(string p_Bundle)
        {
            return m_Mounter.GetPartitionsInBundle(p_Bundle);
        }

        internal IEnumerable<GUID> GetMountedChunks()
        {
            return m_Mounter.GetChunks().Keys;
        }

        internal IEnumerable<string> GetMountedResources()
        {
            return m_Mounter.GetResources().Keys;
        }

        internal IEnumerable<string> GetMountedPartitions()
        {
            return m_Mounter.GetPartitions().Keys;
        }

        internal IReadOnlyDictionary<GUID, IMountedObject<IChunkVariant>> GetMountedChunkVariations()
        {
            return m_Mounter.GetChunks();
        }

        internal IReadOnlyDictionary<string, IMountedObject<IResourceVariant>> GetMountedResourceVariations()
        {
            return m_Mounter.GetResources();
        }
    }
}
