using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Commands.Game;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Mesh;
using RimeLib.Serialization;
using RimeLib.Texture;
using RimeLib.Toolkit;
using SharpGLTF.Schema2;

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
            RegisterCommand<MountStandaloneSbCommand>();
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
            RegisterCommand<ListSbChunksCommand>();
            RegisterCommand<ListBundleChunksCommand>();
            RegisterCommand<ListBundleResourcesCommand>();
            RegisterCommand<ListBundlePartitionsCommand>();
            RegisterCommand<DumpChunkCommand>();
            RegisterCommand<DumpResourceCommand>();
            RegisterCommand<DumpPartitionCommand>();
            RegisterCommand<DumpPartitionJsonCommand>();
            RegisterCommand<DumpTextureCommand>();
            RegisterCommand<DumpMeshCommand>();
            RegisterCommand<DumpLevelMeshesCommand>();
            RegisterCommand<DumpMeshChunksCommand>();
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
        /// Mount a superbundle by path
        /// </summary>
        /// <param name="p_Name">Name of superbundle to mount</param>
        /// <param name="p_Path">Path to superbundle</param>
        /// <param name="p_AutoMount">Automatically mount contained bundles</param>
        internal void MountStandaloneSuperbundle(string p_Name, string p_Path, bool p_AutoMount)
        {
            m_Mounter.MountStandaloneSuperbundle(p_Name, p_Path, p_AutoMount).Wait();
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

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

            // TODO: this is causing issues when cloning (noncas) bundles.
            // Here we look for the first chunk variant with logical offset 0.
            // That's because variants with non-0 offsets can be partial mips, etc.
            using var s_Reader = s_Chunk.Variants.First(p_Variant => true).GetReader();
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

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

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

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

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

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

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

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(m_Mounter.GetEngineType());

            var s_FileStream = File.Create(p_Destination.FullName);
            using var s_Writer = new RimeWriter(s_FileStream);

            s_Converter.ConvertToDDS(s_Resource.FirstVariant!, m_Mounter, s_Writer);
        }

        /// <summary>
        /// Get the chunks of a specified superbundle
        /// </summary>
        /// <param name="p_Superbundle">Superbundle name</param>
        /// <returns>Enumerable of GUIDs for each of the superbundle chunks</returns>
        internal IEnumerable<GUID> GetSuperbundleChunks(string p_Superbundle)
        {
            return m_Mounter.GetChunksInSuperbundle(p_Superbundle);
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
        /// Get the chunks (with asset name hash) of a specified bundle. (Only non cas bundles.)
        /// </summary>
        /// <param name="p_Bundle">Bundle name</param>
        /// <returns>Enumerable of GUIDs for each of the bundle chunks</returns>
        internal IEnumerable<(GUID Guid, int AssetNameHash)> GetBundleChunksWithHash(string p_Bundle)
        {
            return m_Mounter.GetChunksWithHashInBundle(p_Bundle);
        }

        /// <summary>
        /// Gets the resources of a specified bundle
        /// </summary>
        /// <param name="p_Bundle">Bundle name</param>
        /// <returns>Enumerable of resource names for each of the bundle resources</returns>
        internal IEnumerable<(string Name, ResourceType ResourceType)> GetBundleResources(string p_Bundle)
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

        /// <summary>
        /// Dumps a specified mesh in a specific format
        /// </summary>
        /// <param name="p_Type">Output mesh type (gltf, obj, etc.)</param>
        /// <param name="p_Name">Name of the MeshSet resource</param>
        /// <param name="p_Destination">Output file destination</param>
        /// <exception cref="NotImplementedException">If the format isn't supported</exception>
        internal void DumpMesh(MeshConverterType p_Type, string p_Name, FileInfo p_Destination)
        {
            // Get all resources
            var s_Resources = m_Mounter.GetResources();

            // Filter out by name
            var s_MeshResources = s_Resources.Where(p_Resource => p_Resource.Key == p_Name);

            // Iterate over all results
            foreach (var s_MeshResource in s_MeshResources)
            {
                // Get the name of the mesh
                var s_Name = s_MeshResource.Key;

                // Get the resource
                var s_Resource = s_MeshResource.Value;

                // Get the variant
                var s_Variant = s_Resource.FirstVariant;

                // Sanity check
                if (s_Variant.GetResourceType() != ResourceType.MeshSet)
                    continue;

                // Create a new mesh converter
                var s_Converter = EngineInterfaceRegistry.Create<IMeshConverter>(m_Mounter.GetEngineType());

                switch (p_Type)
                {
                    case MeshConverterType.Gltf:
                        s_Converter.ConvertToGltf(s_Variant, m_Mounter, p_Destination.FullName);
                        break;
                    case MeshConverterType.Glb:
                        s_Converter.ConvertToGlb(s_Variant, m_Mounter, p_Destination.FullName);
                        break;
                    case MeshConverterType.Obj:
                        s_Converter.ConvertToObj(s_Variant, m_Mounter, p_Destination.FullName);
                        break;
                    case MeshConverterType.BlenderScript:
                    default:
                        throw new NotImplementedException($"Unknown mesh converter type '{p_Type}'.");
                }
            }
        }


        internal void DumpMeshChunks(string p_Name)
        {
            // Get all resources
            var s_Resources = m_Mounter.GetResources();

            // Filter out by name
            var s_MeshResources = s_Resources.Where(p_Resource => p_Resource.Key == p_Name);

            // Iterate over all results
            foreach (var s_MeshResource in s_MeshResources)
            {
                // Get the name of the mesh
                var s_Name = s_MeshResource.Key;

                // Get the resource
                var s_Resource = s_MeshResource.Value;

                // Get the variant
                var s_Variant = s_Resource.FirstVariant;

                // Sanity check
                if (s_Variant.GetResourceType() != ResourceType.MeshSet)
                    continue;

                // Create a new mesh converter
                var s_Converter = EngineInterfaceRegistry.Create<IMeshConverter>(m_Mounter.GetEngineType());

                s_Converter.GetMeshChunks(s_Variant, m_Mounter);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_Format"></param>
        /// <param name="p_LevelPartition"></param>
        /// <param name="p_OutputDestination"></param>
        /// <param name="p_InputTransforms"></param>
        /// <param name="p_Writer"></param>
        /// <exception cref="NotImplementedException"></exception>
        internal void DumpLevelMesh(MeshConverterType p_Format, string p_LevelPartition, FileInfo p_OutputDestination, FileInfo? p_InputTransforms, TextWriter p_Writer)
        {
            var s_Toolkit = EngineInterfaceRegistry.Create<IToolKit>(m_Mounter.GetEngineType());

            if (!s_Toolkit.Initialize(m_Mounter, p_Writer))
            {
                p_Writer.WriteLine($"Failed to initialize toolkit.");
                return;
            }

            if (!s_Toolkit.ConvertLevelMesh(p_LevelPartition, out var s_SceneBuilder))
            {
                p_Writer.WriteLine($"Failed to convert level mesh.");
                return;
            }

            var s_Model = s_SceneBuilder!.ToGltf2();
            
            switch (p_Format)
            {
                case MeshConverterType.Gltf:
                    s_Model.SaveGLTF(p_OutputDestination.FullName, new WriteSettings() { JsonIndented = true });
                    break;
                case MeshConverterType.Glb:
                    s_Model.SaveGLB(p_OutputDestination.FullName, new WriteSettings {  JsonIndented = true });
                    break;
                case  MeshConverterType.Obj:
                    s_Model.SaveAsWavefront(p_OutputDestination.FullName);
                    break;
                default:
                    p_Writer.WriteLine($"Failed to convert level mesh, unsupported format '{p_Format}'.");
                    return;
            }

            p_Writer.WriteLine($"Level converted to {p_Format} at {p_OutputDestination.FullName}.");
        }
    }
}
