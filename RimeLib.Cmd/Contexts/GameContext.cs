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
    /// <summary>
    /// 
    /// </summary>
    public class GameContext : ExecutionContext
    {
        // Game context id, if there are multiple game context this determines which one is assigned to which game
        protected int m_Id;

        // Frostbite engine mounter interface (this can be different implementations based on Frostbite revision)
        protected IEngineMounter m_Mounter;

        /// <summary>
        /// GameContext constructor
        /// </summary>
        /// <param name="p_Parent">Parent execution context</param>
        /// <param name="p_Id">Id of this mounted game context</param>
        /// <param name="p_Mounter">Frostbite engine mounter interface for this version of fb</param>
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
            RegisterCommand<ListResourcesOfTypeCommand>();
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

        /// <summary>
        /// Mount a superbundle by name
        /// </summary>
        /// <param name="p_Name">Name of superbundle to mount</param>
        /// <param name="p_AutoMount">Automatically mount contained bundles</param>
        internal void MountSuperbundle(string p_Name, bool p_AutoMount)
        {
            m_Mounter.MountSuperbundle(p_Name, p_AutoMount).Wait();
        }

        /// <summary>
        /// Mount a bundle by name
        /// </summary>
        /// <param name="p_Name">Name of bundle to mount</param>
        internal void MountBundle(string p_Name)
        {
            m_Mounter.MountBundle(p_Name).Wait();
        }

        /// <summary>
        /// Gets an enumerable of all available superbundles
        /// </summary>
        /// <returns>Enumerable of superbundle names</returns>
        internal IEnumerable<string> GetAvailableSuperbundles()
        {
            return m_Mounter.GetAvailableSuperbundles();
        }

        /// <summary>
        /// Gets an enumerable of all available bundles
        /// </summary>
        /// <returns>Enumerable of bundle names</returns>
        internal IEnumerable<string> GetAvailableBundles()
        {
            return m_Mounter.GetAvailableBundles();
        }

        /// <summary>
        /// Gets an enumerable of all MOUNTED superbundles
        /// </summary>
        /// <returns>Enumerable of mounted superbundles</returns>
        internal IEnumerable<string> GetMountedSuperbundles()
        {
            return m_Mounter.GetMountedSuperbundles();
        }

        /// <summary>
        /// Gets an enumerable of all MOUNTED bundles
        /// </summary>
        /// <returns>Enumerable of mounted bundles</returns>
        internal IEnumerable<string> GetMountedBundles()
        {
            return m_Mounter.GetMountedBundles();
        }

        /// <summary>
        /// Dumps a specific chunk based on GUID
        /// </summary>
        /// <param name="p_Guid">Input GUID of the chunk to dump</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <exception cref="Exception">If the chunk is not found, exception will be thrown</exception>
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

        /// <summary>
        /// Dumps a specific resource tag
        /// </summary>
        /// <param name="p_Name">Name of the resource</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <exception cref="Exception">If the resource is not found, exception will be thrown</exception>
        internal void DumpResource(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            using var s_Reader = s_Resource.FirstVariant.GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        /// <summary>
        /// Dumps a partition
        /// </summary>
        /// <param name="p_Name">Name of the partition to dump</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <exception cref="Exception">If the partition does not exist, exception will be thrown</exception>
        internal void DumpPartition(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetPartition(p_Name, out var s_Partition))
                throw new Exception($"Could not find partition with name '{p_Name}'.");

            using var s_Reader = s_Partition.FirstVariant.GetReader();
            using var s_FileStream = File.Create(p_Destination.FullName);

            s_Reader.CopyTo(s_FileStream);
        }

        /// <summary>
        /// Dumps a partition as json
        /// </summary>
        /// <param name="p_Name">Name of partition to dump</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <param name="p_Formatting">Formatting type, indented or not</param>
        /// <exception cref="Exception">If the partition does not exist, exception will be thrown</exception>
        internal void DumpPartitionJson(string p_Name, FileInfo p_Destination, Formatting p_Formatting)
        {
            if (!m_Mounter.TryGetPartition(p_Name, out var s_PartitionObject))
                throw new Exception($"Could not find partition with name '{p_Name}'.");

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(m_Mounter.GetEngineType());

            var s_Partition = s_Converter.FromPartitionObject(p_Name, s_PartitionObject.FirstVariant);
            s_Partition.ToJsonFile(p_Destination.FullName, p_Formatting);
        }

        /// <summary>
        /// Dumps a texture as Direct Draw Surface (.dds) format
        /// </summary>
        /// <param name="p_Name">Name of texture to dump</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <exception cref="Exception">If the texture resource name is not found, exception will be thrown</exception>
        internal void DumpTexture(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(m_Mounter.GetEngineType());
      
            var s_FileStream = File.Create(p_Destination.FullName);
            using var s_Writer = new RimeWriter(s_FileStream);

            s_Converter.ConvertToDDS(s_Resource.FirstVariant!, m_Mounter, s_Writer);
        }

        /// <summary>
        /// Get the chunks of a specified bundle
        /// </summary>
        /// <param name="p_Bundle">Bundle name</param>
        /// <returns>Enumerable of GUIDs for each of the bundle chunks</returns>
        internal IEnumerable<GUID> GetBundleChunks(string p_Bundle)
        {
            return m_Mounter.GetChunksInBundle(p_Bundle);
        }

        /// <summary>
        /// Gets the resources of a specified bundle
        /// </summary>
        /// <param name="p_Bundle">Bundle name</param>
        /// <returns>Enumerable of resource names for each of the bundle resources</returns>
        internal IEnumerable<string> GetBundleResources(string p_Bundle)
        {
            return m_Mounter.GetResourcesInBundle(p_Bundle);
        }

        /// <summary>
        /// Gets the available bundle partitions
        /// </summary>
        /// <param name="p_Bundle">Enumerable of bundle partition names</param>
        /// <returns></returns>
        internal IEnumerable<string> GetBundlePartitions(string p_Bundle)
        {
            return m_Mounter.GetPartitionsInBundle(p_Bundle);
        }

        /// <summary>
        /// Gets the mounted chunks
        /// </summary>
        /// <returns>Enumerable of chunk GUIDs</returns>
        internal IEnumerable<GUID> GetMountedChunks()
        {
            return m_Mounter.GetChunks().Keys;
        }

        /// <summary>
        /// Get the mounted resources
        /// </summary>
        /// <returns>Enumerable of resource names</returns>
        internal IEnumerable<string> GetMountedResources()
        {
            return m_Mounter.GetResources().Keys;
        }

        /// <summary>
        /// Get the mounted partitions
        /// </summary>
        /// <returns>Enumerable of mounted partition names</returns>
        internal IEnumerable<string> GetMountedPartitions()
        {
            return m_Mounter.GetPartitions().Keys;
        }

        /// <summary>
        /// Gets a dictionary of GUID <-> Mounted chunk variations
        /// </summary>
        /// <returns>Dictionary<GUID, IMountedObject<IChunkVariant></returns>
        internal IReadOnlyDictionary<GUID, IMountedObject<IChunkVariant>> GetMountedChunkVariations()
        {
            return m_Mounter.GetChunks();
        }

        /// <summary>
        /// Gets a dictionary of resource name <-> Mounted resource variations
        /// </summary>
        /// <returns>Dictionary<string, IMountedObject<IResourceVariant>></returns>
        internal IReadOnlyDictionary<string, IMountedObject<IResourceVariant>> GetMountedResourceVariations()
        {
            return m_Mounter.GetResources();
        }
    }
}
