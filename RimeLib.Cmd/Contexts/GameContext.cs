using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using RimeLib.Cmd.Commands.Emulator;
using RimeLib.Cmd.Commands.Game;
using RimeLib.Terrain.Resources;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Content.Scaleform;
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

        internal IEngineMounter GetMounter() => m_Mounter;

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
            RegisterCommand<DumpShaderDbCommand>();
                RegisterCommand<DumpShaderTexturesCommand>();
                RegisterCommand<WhereIsCommand>();
                RegisterCommand<DumpShaderBytecodeCommand>();
                RegisterCommand<DumpEbxLayoutCommand>();
                RegisterCommand<ListResourcesOfTypeJsonCommand>();
            RegisterCommand<DumpShaderSolutionsCommand>();
            RegisterCommand<DumpMeshVariationDbVariationsCommand>();
                RegisterCommand<DumpMeshTexturesCommand>();
            RegisterCommand<ListPartitionsCommand>();
            RegisterCommand<ListSbChunksCommand>();
            RegisterCommand<ListBundleChunksCommand>();
            RegisterCommand<ListBundleResourcesCommand>();
            RegisterCommand<ListBundlePartitionsCommand>();
            RegisterCommand<DumpChunkCommand>();
            RegisterCommand<DumpResourceCommand>();
            RegisterCommand<DumpBundleChunkMetaCommand>();
            RegisterCommand<ListSbBundlesCommand>();
            RegisterCommand<DumpResourceWithChunksCommand>();
            RegisterCommand<DumpSwfJsonCommand>();
            RegisterCommand<DumpPartitionCommand>();
            RegisterCommand<DumpPartitionByGuidCommand>();
            RegisterCommand<DumpAnimTrackDataCommand>();
            RegisterCommand<BuildCasCatalogCommand>();
            RegisterCommand<MountExternalCatCommand>();

            var s_EngineType = m_Mounter.GetEngineType();

            if (EngineInterfaceRegistry.IsSupported<IPartitionConverter>(s_EngineType))
            {
                RegisterCommand<EmulateLuaCommand>();
                RegisterCommand<DumpPartitionJsonCommand>();
                RegisterCommand<DumpPartitionJsonByGuidCommand>();
                RegisterCommand<DumpMountedPartitionsJsonCommand>();
                RegisterCommand<DumpSkeletonCommand>();
                RegisterCommand<DumpAnimationBankCommand>();
                RegisterCommand<DumpSoundWaveCommand>();
            }

            if (EngineInterfaceRegistry.IsSupported<ITextureConverter>(s_EngineType))
            {
                RegisterCommand<DumpTextureCommand>();
            }

            if (EngineInterfaceRegistry.IsSupported<ITerrainDecalsConverter>(s_EngineType))
            {
                RegisterCommand<DumpTerrainDecalsJsonCommand>();
                RegisterCommand<DumpTerrainNodesCommand>();
                RegisterCommand<DumpEnlightenCommand>();
                RegisterCommand<DumpLevelEnlightenCommand>();
                RegisterCommand<CompareResourceCommand>();
                RegisterCommand<CompareResourcesCommand>();
            }

            if (EngineInterfaceRegistry.IsSupported<IVisualTerrain>(s_EngineType))
            {
                RegisterCommand<DumpVisualTerrainCommand>();
                RegisterCommand<DumpCollisionShapesCommand>();
            }

            if (EngineInterfaceRegistry.IsSupported<IMeshConverter>(s_EngineType))
            {
                RegisterCommand<DumpMeshCommand>();

                if (EngineInterfaceRegistry.IsSupported<IToolKit>(s_EngineType) && EngineInterfaceRegistry.IsSupported<IPartitionConverter>(s_EngineType))
                {
                    RegisterCommand<DumpLevelMeshesCommand>();
                    RegisterCommand<DumpLevelPlacementsCommand>();
                }
            }
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
        /// Dumps a SwfMovie (Scaleform .gfx) resource's structure as JSON: header
        /// fields plus the tag table (each tag's type, offset, length and raw hex
        /// body). Tag bodies are NOT field-decoded — for full editable XML use ffdec
        /// (-swf2xml) on the dumped .gfx. Useful for quickly inspecting which tags a
        /// movie contains (DefineEditText, PlaceObject3, DefineSprite, etc.).
        /// </summary>
        /// <param name="p_Name">Name of the SwfMovie resource.</param>
        /// <param name="p_Destination">Destination .json file to write.</param>
        /// <exception cref="Exception">If the resource is missing or not a SwfMovie.</exception>
        internal void DumpSwfJson(string p_Name, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            var s_Variant = s_Resource.FirstVariant;
            if (s_Variant.GetResourceType() != ResourceType.SwfMovie)
                throw new Exception($"Resource '{p_Name}' is not a SwfMovie (it is {s_Variant.GetResourceType()}).");

            using var s_Reader = s_Variant.GetReader();
            var s_Swf = new SwfFile(s_Reader);

            var s_Tags = new List<object>();
            for (var i = 0; i < s_Swf.Tags.Count; ++i)
            {
                var s_Tag = s_Swf.Tags[i];
                s_Tags.Add(new
                {
                    index = i,
                    tag = s_Tag.Tag.ToString(),
                    tagId = (int)s_Tag.Tag,
                    offset = s_Tag.Offset,
                    length = s_Tag.Data.Length,
                    dataHex = Convert.ToHexString(s_Tag.Data),
                });
            }

            var s_Doc = new
            {
                name = p_Name,
                version = s_Swf.Version,
                compressed = s_Swf.IsCompressed,
                stripped = s_Swf.IsStripped,
                fps = s_Swf.Fps,
                frameCount = s_Swf.FrameCount,
                rect = new { left = s_Swf.Rect.X, top = s_Swf.Rect.Y, right = s_Swf.Rect.Z, bottom = s_Swf.Rect.W },
                tagCount = s_Swf.Tags.Count,
                tags = s_Tags,
            };

            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

            File.WriteAllText(p_Destination.FullName, JsonConvert.SerializeObject(s_Doc, Formatting.Indented));
        }

        /// <summary>
        /// Dumps a TerrainDecals (.decals) resource's full structure as JSON: header,
        /// the three geometries (2d/3d/water) with their blocks, decoded vertices and
        /// indices. Reading the resource and writing it back is byte-identical to vanilla.
        /// </summary>
        /// <param name="p_Name">Name of the TerrainDecals resource.</param>
        /// <param name="p_Destination">Destination .json file to write.</param>
        /// <param name="p_Formatting">JSON formatting (whitespace only; does not affect rebuild).</param>
        /// <exception cref="Exception">If the resource is missing or not a TerrainDecals.</exception>
        internal void DumpTerrainDecalsJson(string p_Name, FileInfo p_Destination, Formatting p_Formatting)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            var s_Variant = s_Resource.FirstVariant;
            if (s_Variant.GetResourceType() != ResourceType.TerrainDecals)
                throw new Exception($"Resource '{p_Name}' is not a TerrainDecals (it is {s_Variant.GetResourceType()}).");

            using var s_Reader = s_Variant.GetReader();
            var s_Converter = EngineInterfaceRegistry.Create<ITerrainDecalsConverter>(m_Mounter.GetEngineType());
            var s_Decals = s_Converter.Read(s_Reader);

            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

            File.WriteAllText(p_Destination.FullName, JsonConvert.SerializeObject(
                s_Decals, p_Formatting, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
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
        /// Dumps a partition
        /// </summary>
        /// <param name="p_GUID">Guid of the partition to dump</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <exception cref="Exception">If the partition does not exist, exception will be thrown</exception>
        internal void DumpPartitionByGuid(GUID p_GUID, FileInfo p_Destination)
        {
            if (!m_Mounter.TryGetPartitionByGuid(p_GUID, out var Name, out var s_Partition))
                throw new Exception($"Could not find partition with GUID '{p_GUID.ToString("D")}'.");

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
        /// Dumps a partition as json
        /// </summary>
        /// <param name="p_GUID">Guid of partition to dump</param>
        /// <param name="p_Destination">Destination file to write</param>
        /// <param name="p_Formatting">Formatting type, indented or not</param>
        /// <exception cref="Exception">If the partition does not exist, exception will be thrown</exception>
        internal void DumpPartitionJsonByGuid(GUID p_GUID, FileInfo p_Destination, Formatting p_Formatting)
        {
            if (!m_Mounter.TryGetPartitionByGuid(p_GUID, out var s_Name, out var s_PartitionObject))
                throw new Exception($"Could not find partition with GUID '{p_GUID.ToString("D")}'.");

            // Ensure that the directory of the destination file exists
            if (p_Destination.Directory != null && !Directory.Exists(p_Destination.Directory.FullName))
                Directory.CreateDirectory(p_Destination.Directory.FullName);

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(m_Mounter.GetEngineType());

            var s_Partition = s_Converter.FromPartitionObject(s_Name, s_PartitionObject.FirstVariant);
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

        internal void DumpResourceWithChunks(string p_Name, DirectoryInfo p_Destination)
        {
            // Get all resources
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                throw new Exception($"Could not find resource with name '{p_Name}'.");

            var s_Variant = s_Resource.FirstVariant;

            // Ensure that the directory of the destination file exists
            if (!Directory.Exists(p_Destination.FullName))
                Directory.CreateDirectory(p_Destination.FullName);

            var s_ResourceName = new FileInfo(Path.Combine(p_Destination.FullName, $"{s_Resource.OriginalName}.{s_Variant.GetResourceType()}"));
            if (s_ResourceName.Directory != null && !Directory.Exists(s_ResourceName.Directory.FullName))
                Directory.CreateDirectory(s_ResourceName.Directory.FullName);

            switch (s_Variant.GetResourceType())
            {
                 case ResourceType.MeshSet:
                    if (!EngineInterfaceRegistry.IsSupported<IMeshConverter>(m_Mounter.GetEngineType()))
                    {
                        throw new NotImplementedException($"Dumping mesh resources with chunks is not yet implemented for engine type '{m_Mounter.GetEngineType()}'.");
                    }

                    var s_MeshConverter = EngineInterfaceRegistry.Create<IMeshConverter>(m_Mounter.GetEngineType());
                    Dictionary<string, GUID> s_MeshChunks = s_MeshConverter.GetChunkGuids(s_Variant);

                    foreach (var s_MeshChunk in s_MeshChunks)
                        DumpChunk(s_MeshChunk.Value, new FileInfo(Path.Combine(p_Destination.FullName, s_MeshChunk.Key + ".chunk")));

                    Console.WriteLine("Mesh Resource Name: " + s_Resource.OriginalName);
                    Console.WriteLine("Chunks:");
                    foreach (var s_MeshChunk in s_MeshChunks)
                        Console.WriteLine($" - {s_MeshChunk.Key}: {s_MeshChunk.Value}");

                    break;
                case ResourceType.DxTexture:
                case ResourceType.Ps3Texture:
                case ResourceType.ITexture:
                    if (!EngineInterfaceRegistry.IsSupported<ITextureConverter>(m_Mounter.GetEngineType()))
                    {
                        throw new NotImplementedException($"Dumping texture resources with chunks is not yet implemented for engine type '{m_Mounter.GetEngineType()}'.");
                    }

                    var s_TextureConverter = EngineInterfaceRegistry.Create<ITextureConverter>(m_Mounter.GetEngineType());
                    var s_TextureChunk = s_TextureConverter.GetTextureChunkId(s_Variant);
                    DumpChunk(s_TextureChunk, new FileInfo(Path.Combine(p_Destination.FullName, s_Resource.OriginalName + ".chunk")));

                    Console.WriteLine("Texture Resource Name: " + s_Resource.OriginalName);
                    Console.WriteLine("Chunk: " + s_TextureChunk);

                    break;
                default:
                    throw new NotImplementedException($"Dumping resources with chunks is not yet implemented for resource type '{s_Variant.GetResourceType()}'.");
            }

            using var s_Reader = s_Variant.GetReader();
            using var s_FileStream = File.Create(s_ResourceName.FullName);
            s_Reader.CopyTo(s_FileStream);
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
        /// <summary>
        /// Writes where every mesh in a level sits, as JSON:
        ///   { "level": name, "meshes": { "<resource>": [ [right(3), up(3), forward(3), trans(3)], ... ] } }
        ///
        /// This is the placement data that is NOT in EBX: a level's StaticModelGroup members carry
        /// an InstanceCount but usually no InstanceTransforms, because the per-instance transforms
        /// live in the level's Havok physics asset. The walk resolves them the same way the mesh
        /// export does, and skips loading any geometry.
        /// </summary>
        internal bool DumpLevelPlacements(string p_LevelPartition, FileInfo p_Destination, TextWriter p_Writer)
        {
            var s_Toolkit = EngineInterfaceRegistry.Create<IToolKit>(m_Mounter.GetEngineType());

            if (!s_Toolkit.Initialize(m_Mounter, p_Writer))
            {
                p_Writer.WriteLine("Failed to initialize toolkit.");
                return false;
            }

            if (!s_Toolkit.ConvertLevelPlacements(p_LevelPartition, out var s_Placements) || s_Placements is null)
            {
                p_Writer.WriteLine("Failed to resolve level placements.");
                return false;
            }

            var s_Json = new StringBuilder();
            s_Json.Append("{\"level\":");
            s_Json.Append(JsonConvert.SerializeObject(p_LevelPartition));
            s_Json.Append(",\"meshes\":{");

            var s_FirstMesh = true;

            foreach (var s_Pair in s_Placements)
            {
                if (!s_FirstMesh)
                    s_Json.Append(',');

                s_FirstMesh = false;

                s_Json.Append(JsonConvert.SerializeObject(s_Pair.Key));
                s_Json.Append(":[");

                var s_FirstTransform = true;

                foreach (var s_Transform in s_Pair.Value)
                {
                    if (!s_FirstTransform)
                        s_Json.Append(',');

                    s_FirstTransform = false;

                    s_Json.Append('[');

                    for (var i = 0; i < s_Transform.Length; i++)
                    {
                        if (i > 0)
                            s_Json.Append(',');

                        s_Json.Append(s_Transform[i].ToString(CultureInfo.InvariantCulture));
                    }

                    s_Json.Append(']');
                }

                s_Json.Append(']');
            }

            s_Json.Append("}}");

            File.WriteAllText(p_Destination.FullName, s_Json.ToString());
            p_Writer.WriteLine($"Placements for {p_LevelPartition} written to {p_Destination.FullName} ({s_Placements.Count} meshes).");

            return true;
        }

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
                    s_Model.SaveGLB(p_OutputDestination.FullName, new WriteSettings { JsonIndented = true });
                    break;
                case MeshConverterType.Obj:
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
