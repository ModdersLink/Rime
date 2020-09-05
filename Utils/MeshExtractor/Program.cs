using CommandLine;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Math;
using RimeLib.Mesh.Frostbite;
using SharpGLTF.Geometry;
using SharpGLTF.Materials;
using SharpGLTF.Schema2;
using SharpGLTF.Geometry.VertexTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using fb;
using VertexElementUsage = RimeLib.Mesh.Frostbite.VertexElementUsage;
using VertexElementFormat = RimeLib.Mesh.Frostbite.VertexElementFormat;
using MeshSubsetCategory = RimeLib.Mesh.Frostbite.Fb2.MeshSubsetCategory;
using MeshType = RimeLib.Mesh.Frostbite.MeshType;
using SharpGLTF.Scenes;
using SharpGLTF.Transforms;
using System.Data.SqlTypes;

namespace MeshExtractor
{
    class Program
    {
        internal class Options
        {
            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = true;

            [Value(0, MetaName = "gamePath", Required = true, HelpText = "The path of the game to be whose content you want to extract.")]
            public string GamePath { get; set; } = "";

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]
            public EngineType EngineType { get; set; }

            [Value(2, MetaName = "outPath", Required = true, HelpText = "The output directory where the extracted files will be put into.")]
            public string OutputPath { get; set; } = "";
        }

        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                // Load Frostbite2_0 assemblies
                LoadContentAssembly(p_Options);

                // Load the Venice bindings
                LoadBindingsAssembly(p_Options);

                // Mount the entire game
                Mount(p_Options, out IEngineMounter s_Mounter);

                // Load all of the ebx files
                //LoadEbx(p_Options, s_Mounter);

                // Skeletoms
                //DumpSkeletons(p_Options, s_Mounter);

                // Dump all of the files + skels
                DumpFiles(p_Options, s_Mounter);

                Console.WriteLine("Content successfully extracted. Press any key to exit...");
                Console.ReadKey();
            }).WithNotParsed(p_Err => { System.Environment.Exit(1); });
        }

        private static void LoadContentAssembly(Options p_Options)
        {
            var s_AssemblyName = "RimeLib.Content." + p_Options.EngineType;

            try
            {
                if (!p_Options.Quiet)
                    Console.WriteLine("Loading engine content support assembly.");

                Assembly.Load(s_AssemblyName);
            }
            catch
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Failed to load supporting engine assembly ({s_AssemblyName}.dll). This means that the engine is not supported or that you are missing required files.");

                System.Environment.Exit(1);
            }
        }

        private static void LoadBindingsAssembly(Options p_Options)
        {
            var s_AssemblyName = "RimeLib.Bindings.Venice";

            try
            {
                if (!p_Options.Quiet)
                    Console.WriteLine("Loading engine bindings support assembly.");

                var s_Bindings = Assembly.Load(s_AssemblyName);

                var s_ExportedTypes = s_Bindings.GetExportedTypes();

                foreach (var s_Type in s_ExportedTypes)
                {
                    if (!typeof(FrostbiteContainer).IsAssignableFrom(s_Type) &&
                        !s_Type.IsEnum)
                        continue;

                    ContainerRegistry.RegisterType(s_Type);
                }
            }
            catch
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Failed to load supporting engine assembly ({s_AssemblyName}.dll). This means that the engine is not supported or that you are missing required files.");

                System.Environment.Exit(1);
            }
        }

        private static void Mount(Options p_Options, out IEngineMounter p_Mounter)
        {
            p_Mounter = EngineMounterRegistry.Create(p_Options.EngineType);

            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            /*
             * s_Context!.ProcessCommand("mount_sb win32/xp1chunks true", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/xp4chunks true", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/mpchunks true", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/levels/xp1_002/xp1_002 false", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/levels/xp4_quake/xp4_quake false", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_sb win32/levels/sp_bank/sp_bank false", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/xp1_002/xp1_002", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/xp1_002/CQ_S", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/XP4_Quake/XP4_Quake", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/XP4_Quake/DeathMatch", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/XP4_Quake/TeamDeathMatch", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/SP_Bank/SP_Bank", s_Out, out s_Context);
            s_Context!.ProcessCommand("mount_bundle win32/levels/SP_Bank/Passage_CUTSCENE", s_Out, out s_Context);*/

            p_Mounter.Mount(p_Options.GamePath, false, EngineType.Frostbite2_0).Wait();
            p_Mounter.MountSuperbundle("Win32/Chunks0", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Chunks1", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Chunks2", true).Wait();
            p_Mounter.MountSuperbundle("Win32/MpChunks", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Xp2Chunks", true).Wait();
            //p_Mounter.MountSuperbundle("Win32/Levels/XP2_Factory/XP2_Factory", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Levels/XP1_002/XP1_002", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Levels/XP4_Quake/XP4_Quake", true).Wait();
            p_Mounter.MountSuperbundle("Win32/Levels/SP_Bank/SP_Bank", true).Wait();

            if (!p_Options.Quiet)
                Console.WriteLine($"Everythingis now mounted! Starting model conversion.");
        }

        private static List<FrostbitePartition> m_FoundPartitions = new List<FrostbitePartition>();
        private static void LoadEbx(Options p_Options, IEngineMounter p_Mounter)
        {
            var s_Partitions = p_Mounter.GetPartitions();

            Parallel.ForEach(s_Partitions, p_PartitionPair =>
            {
                var s_PartitionName = p_PartitionPair.Key;

                var s_PartitionObject = p_PartitionPair.Value;

                using var s_PartitionReader = s_PartitionObject.FirstVariant.GetReader();
                

                var s_Reader = new Fb2EbxReader();

                var s_Partition = s_Reader.ParsePartition(s_PartitionName, s_PartitionReader);
                if (s_Partition == null)
                    return;

                PartitionRegistry.RegisterPartition(s_Partition);

                //if (s_Partition.PrimaryInstance.ContainerTypeName == "LevelData")
                //{
                //    s_PartitionReader.Seek(0, SeekOrigin.Begin);
                //    File.WriteAllBytes(s_PartitionName.Replace('/', '-'), s_PartitionReader.ReadBytes((int)s_PartitionReader.Length));
                //}
                if (s_Partition.PrimaryInstance.ContainerTypeName == "SkeletonAsset")

                {
                    if (!p_Options.Quiet)
                        Console.WriteLine($"Found SkeletonAsset {s_PartitionName}.");

                    lock (m_FoundPartitions)
                        m_FoundPartitions.Add(s_Partition);

                    DumpSkeleton(p_Options, p_Mounter, s_Partition.PrimaryInstance as SkeletonAsset);

                    // SpatialPrefabBlueprint 79F80F0B-6991-7DFD-D824-47B945670B5A #primary instance
                    // ReferenceObjectData 10073372-4B09-4113-8333-52AC228733A4
                    // SpatialPrefabBlueprint 079B28B4-38F8-C4AF-41CA-BFDDBD3974B4 #primary instance
                    // ModelAnimationEntityData 60918322-4B59-4645-BFD5-3C332474EA21
                    // AntAnimationSetAsset 7A4FD994-D1A3-6B47-7EAB-B587E6962714 #primary instance
                    // SkeletonAsset 45F06B70-19A9-7A8E-CE22-B6408DF92DE8 #primary instance

                    // ObjectBlueprint 11CADBE5-146C-7A74-F54D-83CF8782EEE3 #primary instance
                    // StaticModelEntityData 1A8767FE-BF3A-11E0-A8C3-D9944A861423
                    // 



                    // SoldierEntityData A9FFE6B4-257F-4FE8-A950-B323B50D2112
                    // SoldierBodyComponentData 1C721510-AD42-4AFD-B613-04DC37D0FC1F
                    // AntAnimatableComponentData 83CB9E70-3D9A-4C34-B8D6-787CEADBD8A3
                    // MasterSkeletonAsset 7B0E0D54-7382-D1BA-7E73-2C418DA0D7F3 #primary instance
                    // MasterSkeleton animations/skeletons/venice1pske01/34256E97-1049-FC24-90D8-4D551517E3AC

                }
            });
        }

        internal struct Skeleton
        {
            public string WeaponBoneName;
            public string HeadBoneName;
            public string HipBoneName;
            public string CameraBoneName;

            public List<Bone> Bones;
        }
        internal struct Bone
        {
            public int Index;
            public string Name;
            public LinearTransform LocalPose;
            public LinearTransform ModelPose;
        }
        private static async void DumpSkeleton(Options p_Options, IEngineMounter p_Mounter, SkeletonAsset p_Asset)
        {
            if (p_Asset.Name != "Animations/Skeletons/VeniceAntSke01")
                return;

            if (!p_Options.Quiet)
            {
                Console.WriteLine($"Dumping skeleton: {p_Asset.Name}.");
            }

            var s_IndexMap = new Dictionary<string, long>();

            
            var s_LocalPoses = p_Asset.LocalPose;
            var s_ModelPoses = p_Asset.ModelPose;
            var s_Hierachy = p_Asset.Hierarchy;
            var s_BoneNames = p_Asset.BoneNames;
            // Check an assumptions that we have
            if (s_LocalPoses.Count != s_ModelPoses.Count)
                throw new Exception();

            if (s_ModelPoses.Count != s_Hierachy.Count)
                throw new Exception();

            if (s_BoneNames.Count != s_LocalPoses.Count)
                throw new Exception();

            var s_Bones = new List<Bone>();
            for (var s_Index = 0; s_Index < s_Hierachy.Count; ++s_Index)
            {
                var s_BoneName = s_BoneNames[s_Index];
                var s_ModelPose = s_ModelPoses[s_Index];
                var s_LocalPose = s_LocalPoses[s_Index];

                var s_BoneIndex = s_Hierachy[s_Index];

                s_Bones.Add(new Bone
                {
                    Index = s_BoneIndex,
                    LocalPose = s_LocalPose,
                    ModelPose = s_ModelPose,
                    Name = s_BoneName
                });
            }

            // Create a new GLTF model
            var s_Model = ModelRoot.CreateModel();
            s_Model.Asset.Generator = "Generated by RimeLib (c) 2020";
            s_Model.Asset.Copyright = "Exported by Rime (c) kiwidoggie productions 2017-2020, models copyright respective ip owners, not for redistribution";

            var s_RootNode = s_Model.CreateLogicalNode();
            // Create a default scene
            var s_Scene = s_Model.UseScene("default");

            for (var s_Index = 0; s_Index < s_Hierachy.Count; ++s_Index)
            {
                var s_BoneIndex = s_Hierachy[s_Index];
                var s_Bone = s_Bones.FirstOrDefault(p_Bone => p_Bone.Index == s_BoneIndex);

                if (s_Bone.Index == -1)
                {
                    // Set the main skeleton bone name
                    s_RootNode.Name = s_Bone.Name;
                    continue;
                }

                // Otherwise we continue on creating the skeleton
                var s_BoneNode = s_RootNode.CreateNode(s_Bone.Name);
                s_BoneNode.LocalTransform = AffineTransform.Create(s_Bone.ModelPose.ToMatrix4x4() * 39);

                Console.WriteLine($"Parsing {s_Bone.Name} at model: {s_Bone.ModelPose.Trans} local: {s_Bone.LocalPose.Trans}.\n");
            }

            s_Model.SaveGLTF("./out.bin", new WriteSettings
            {
                JsonIndented = true
            });
        }

        private static async void DumpSkeletons(Options p_Options, IEngineMounter p_Mounter)
        {
            var s_Model = ModelRoot.CreateModel();

            var s_Node = s_Model.CreateLogicalNode();
            s_Node.Name = "Skinned mesh node";
            //s_Node.Skin = new Skin();

            // B3A18B07-B794-4C3F-98C6-3A0C13E0EC47
            //var s_StaticModelEntityData = PartitionRegistry.LookupPartition(new GUID("B3A18B07-B794-4C3F-98C6-3A0C13E0EC47"));
            var s_WeaponBluerint = m_FoundPartitions.FirstOrDefault(p_Partition => p_Partition.Name.Contains("AN94")).PrimaryInstance as SoldierWeaponBlueprint;

            var s_SoldierWeaponDataPartition = PartitionRegistry.LookupPartition(s_WeaponBluerint.Object.PartitionGuid);

            var s_SoldierWeaponData = s_SoldierWeaponDataPartition.Instances.FirstOrDefault(p_Instance => p_Instance.InstanceGuid == s_WeaponBluerint.Object.InstanceGuid) as SoldierWeaponData;

            
            var s_WeaponStates = s_SoldierWeaponData.WeaponStates;

            var s_AnimationData = PartitionRegistry.GetPartitionContainer(s_SoldierWeaponData.AnimationData) as AntPackageAsset;

            
            if (!p_Mounter.TryGetChunk(s_AnimationData.StreamingGuid, out IMountedObject<IChunkVariant> p_Chunk))
            {
                Debug.WriteLine("could not get chunk");
                return; 
            }

            // WorldPartData 15E8F838-BD58-4515-89CE-970BC57C33ED #primary instance
            //  member D0FA1E68-9BF4-495D-92B3-8856F30EDCB0
            // AnimationSet animations/characters/coop/d2_buildings/coopsign_rig_animset/09D8973D-8BF3-E39E-8022-209D364753FD
            // SkeletonAsset animations/characters/coop/d2_buildings/coopsign_skeleton/4A18D3F3-EC16-CAB3-E2EF-B048F9126B80

            using var s_Reader = p_Chunk.FirstVariant.GetReader();
            var s_ReaderData = s_Reader.ReadBytes((int)s_Reader.Length);

            for (var s_WeaponStateIndex = 0; s_WeaponStateIndex < s_WeaponStates.Count; ++s_WeaponStateIndex)
            {
                var s_WeaponState = s_WeaponStates[s_WeaponStateIndex];

                var s_SkinnedMeshAsset = PartitionRegistry.GetPartitionContainer(s_WeaponState.Mesh1p) as SkinnedMeshAsset;

                var s_SkinnedMeshAssetName = s_SkinnedMeshAsset.Name;


                var s_AnimationConfiguration = s_WeaponState.AnimationConfiguration;

            }
            //s_SoldierWeaponData.PrimaryInstance;
        }

        private static async void DumpFiles(Options p_Options, IEngineMounter p_Mounter)
        {
            //if (!p_Options.Quiet)
            //    Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            //await p_Mounter.Mount(p_Options.GamePath, false, EngineType.Frostbite2_0);
            //await p_Mounter.MountSuperbundle("Win32/Chunks0", true);
            //await p_Mounter.MountSuperbundle("Win32/Chunks1", true);
            //await p_Mounter.MountSuperbundle("Win32/Chunks2", true);
            //await p_Mounter.MountSuperbundle("Win32/MpChunks", true);
            //await p_Mounter.MountSuperbundle("Win32/Xp2Chunks", true);
            //await p_Mounter.MountSuperbundle("Win32/Levels/XP2_Factory/XP2_Factory", true);

            if (!p_Options.Quiet)
                Console.WriteLine($"Everythingis now mounted! Starting model conversion.");

            // Uncomment below once debugging is done
#if _BUSTED
            Parallel.ForEach(s_Mounter.GetResources(), p_Pair =>
            {
                var s_Name = p_Pair.Key;
                var s_MountedObject = p_Pair.Value;

                foreach (var s_Variant in s_MountedObject.Variants)
                {
                    if (s_Variant.GetResourceType() != RimeLib.Content.Frostbite.ResourceType.MeshSet)
                        continue;

                    // Dump the mesh
                    DumpMesh3(s_Mounter, p_Options, s_Name, s_MountedObject);
                }
            });
#else
            var s_Resources = p_Mounter.GetResources();
            foreach (var s_Resource in s_Resources)
            {
                var s_Name = s_Resource.Key;
                var s_MountedObject = s_Resource.Value;

                var s_Variant = s_MountedObject.FirstVariant;
                if (s_Variant.GetResourceType() != RimeLib.Content.Frostbite.ResourceType.MeshSet)
                    continue;

                DumpMesh(p_Mounter, p_Options, s_Name, s_MountedObject);

                //foreach (var s_Variant in s_MountedObject.Variants)
                //{
                //    if (s_Variant.GetResourceType() != RimeLib.Content.Frostbite.ResourceType.MeshSet)
                //        continue;

                //    DumpMesh(p_Mounter, p_Options, s_Name, s_MountedObject);
                //}
            }
#endif
        }

        public static List<string> m_SeenGuids = new List<string>();

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }

        private static void ParseRigidMesh(IEngineMounter p_Mounter, MeshSetLayout p_Layout, Options p_Options = null)
        {
            var s_BoundingBox = p_Layout.BoundingBox;

            if (!p_Options?.Quiet ?? false)
                Console.WriteLine($"Bounding Box: {s_BoundingBox}");

            // Create a new GLTF model
            var s_Model = ModelRoot.CreateModel();
            s_Model.Asset.Generator = "Generated by RimeLib (c) 2020";
            s_Model.Asset.Copyright = "Exported by Rime (c) kiwidoggie productions 2017-2020, models copyright respective ip owners, not for redistribution";

            // Create a default scene
            var s_Scene = s_Model.UseScene("default");

            

            // Hold a new random for randomized colors
            var s_Random = new Random();

            // Iterate through each of the level of details objects
            for (var s_LodIndex = 0; s_LodIndex < p_Layout.LodCount; ++s_LodIndex)
            {

                // Get the level of detail object
                var s_Lod = p_Layout.Lods[s_LodIndex].Object;
                if (s_Lod == null)
                    throw new Exception("could not get lod");

                // Debug information
                var s_LodName = s_Lod.Name.Object;
                if (!p_Options?.Quiet ?? false)
                    Console.WriteLine($"Dumping rigid mesh ({s_LodName}) lod {s_LodIndex}");

                // Debug checking to make sure assumptions are correct
                if (s_Lod.CategorySubsetIndices.Length != (int)RimeLib.Mesh.Frostbite.Fb2.MeshSubsetCategory.Count)
                    throw new Exception("category subset indicies don't match the count");

                // Get the data chunk
                var s_DataChunkId = s_Lod.DataChunkId;
                if (!p_Mounter.TryGetChunk(s_DataChunkId, out IMountedObject<IChunkVariant> p_Chunk))
                {
                    if (!p_Options.Quiet)
                        Console.WriteLine($"could not find data: {BitConverter.ToString(s_DataChunkId.Id)}");

                    continue;
                }

                if (s_LodName.Contains("venom"))
                {

                    // Parse this 9MB text file >_>
                    var s_Text = File.ReadAllText(@"C:\Users\gamedev\Downloads\message(1).txt");

                    var s_SectionSplit = s_Text.Split("[D]", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var s_Section in s_SectionSplit)
                    {
                        var s_StartIndex = s_Section.IndexOf('\'');
                        var s_EndIndex = s_Section.LastIndexOf('\'');

                        var s_Name = s_Section.Substring(s_StartIndex, s_EndIndex - s_StartIndex);
                        s_Name = s_Name.Replace("'", "");
                        if (s_Name != s_LodName)
                            continue;

                        var s_DataIndex = s_Section.LastIndexOf("Data: ");

                        var s_DataString = s_Section.Substring(s_DataIndex + "Data: ".Length).Replace("\r\n", "");
                        //var s_Data = StringToByteArray(s_DataString);


                        using var s_Reader = p_Chunk.FirstVariant.GetReader();

                        var s_ReaderData = s_Reader.ReadBytes((int)s_Reader.Length);

                        var s_F = ByteArrayToString(s_ReaderData);

                        var s_Equal = s_DataString == s_F;

                        for (int i = 0; i < Math.Min(s_F.Length, s_DataString.Length); ++i)
                        {
                            if (s_F[i] != s_DataString[i])
                                throw new Exception();
                        }
                        if (!s_Equal)
                            throw new Exception();
                    }
                }

                if (m_SeenGuids.Contains(s_DataChunkId.ToString()))
                    throw new Exception("dupe found");
                m_SeenGuids.Add(s_DataChunkId.ToString());

                //Console.WriteLine($"{s_Lod.Name.Object} {s_DataChunkId}");

                // Hold all of our data
                byte[] s_VertexChunkData = null;
                byte[] s_PrimitiveChunkData = null;
                byte[] s_ChunkData = null;

                using (var s_ChunkReader = p_Chunk.FirstVariant.GetReader())
                    s_ChunkData = s_ChunkReader.ReadBytes((int)s_ChunkReader.Length);

                long s_TotalVertexCount = 0;
                // Read out all vertex and primitive chunk data
                using (var s_DataChunkReader = new RimeReader(new MemoryStream(s_ChunkData)))
                {
                    // Read out all vertitices
                    s_VertexChunkData = s_DataChunkReader.ReadBytes((int)s_Lod.VertexDataSize);

#if DO_NOT_IGNORE_PADDING
                    // TODO: Implement a check
                    if (s_Lod.IndexDataSize != (s_DataChunkReader.Length - s_DataChunkReader.Position))
                        throw new Exception("data is leftover"); // This will trigger if the data is not aligned, the rest are usually 00's
#endif

                    // Read out all of the primitive data
                    s_PrimitiveChunkData = s_DataChunkReader.ReadBytes((int)s_Lod.IndexDataSize);

#if DO_NOT_IGNORE_PADDING
                    // TODO: Implement a check
                    // Verify that we are at the end of *all* chunk data
                    if (s_DataChunkReader.Position != s_DataChunkReader.Length)
                        throw new Exception("there is leftover data in the chunk reader");
#endif
                }

                var s_SubsetsDict = new Dictionary<MeshSubset, List<byte[]>>();

                var s_SubsetsList = new List<MeshSubset>();
                var s_VertexDataList = new List<byte[]>();
                var s_CurrentVertexCount = 0;
                var s_CurrentVertexSize = 0;

                // Parse out all of the verticies
                using (var s_VertexReader = new RimeReader(new MemoryStream(s_VertexChunkData)))
                {
                    var s_VertexBitmask = new bool[s_VertexChunkData.Length];

                    // Iterate through each of the subsets in the lod
                    for (var s_SubsetIndex = 0; s_SubsetIndex < s_Lod.Subsets.Count; ++s_SubsetIndex)
                    {
                        // Get the subset
                        var s_Subset = s_Lod.Subsets.Get[s_SubsetIndex];

                        // Get the vertex stride, this should be the same as the current stream (elements per vertex) size
                        var s_VertexStride = s_Subset.VertexStride;

                        s_VertexReader.Seek(s_Subset.VertexOffset, SeekOrigin.Begin);

                        // Hold a list for all of our vertex data
                        var s_Set = new List<byte[]>();

                        // Iterate through each of the verticies
                        for (var s_VertexIndex = 0; s_VertexIndex < s_Subset.VertexCount; ++s_VertexIndex)
                        {
                            for (var i = 0; i < s_VertexStride; ++i)
                                s_VertexBitmask[s_VertexReader.Position + i] = true;

                            // Read out the vertex information
                            var s_Bytes = s_VertexReader.ReadBytes(s_VertexStride);

                            // Add this array of bytes (of size vertex stride)
                            s_VertexDataList.Add(s_Bytes);
                            s_Set.Add(s_Bytes);

                            s_CurrentVertexCount++;
                            s_CurrentVertexSize += s_VertexStride;
                        }

                        s_SubsetsDict.Add(s_Subset, s_Set);
                        s_SubsetsList.Add(s_Subset);
                    }

#if DO_NOT_IGNORE_PADDING
                    // Validate that we have read all of the data
                    if (s_VertexReader.Position != s_VertexReader.Length)
                        throw new Exception("there is leftover unread vertex data");


                    // Verify that we have read all of the vertex data
                    if (s_VertexReader.Position != s_CurrentVertexSize)
                        throw new Exception("vertex stride left leftover data");
#endif
                    var s_Any = s_VertexBitmask.Any(p_Bit => p_Bit == false);
                }

                // Hold the subset + parsed vertex information
                var s_ParsedSubsets = new Dictionary<MeshSubset, List<Dictionary<VertexElementUsage, dynamic>>>();

                // Iterate through each of the subsets + the raw data
                for (var s_SubsetIndex = 0; s_SubsetIndex < s_SubsetsDict.Count; s_SubsetIndex++)
                {
                    // Get the subset and data pair
                    var s_SubsetsPair = s_SubsetsDict.ElementAt(s_SubsetIndex);

                    var s_SubsetKey = s_SubsetsPair.Key;
                    var s_SubsetValue = s_SubsetsPair.Value;

                    // Get the geometry descriptor
                    var s_GeometryDesc = s_SubsetKey.GeometryDeclarationDesc;

                    // Iterate all vertices that are for this model
                    if (s_SubsetValue.Count != s_SubsetKey.VertexCount)
                        throw new Exception("vertex count does not match number of verts read");

                    // Parse all of the data
                    var s_VerticiesNiceList = new List<Dictionary<VertexElementUsage, dynamic>>();
                    for (var s_VertexIndex = 0; s_VertexIndex < s_SubsetValue.Count; ++s_VertexIndex)
                    {
                        var s_VertexData = s_SubsetValue[s_VertexIndex];

                        using var s_VertexReader = new RimeReader(new MemoryStream(s_VertexData));

                        var s_Dict = new Dictionary<VertexElementUsage, dynamic>();

                        for (var s_ElementIndex = 0; s_ElementIndex < s_GeometryDesc.ElementCount; ++s_ElementIndex)
                        {
                            var s_Element = s_GeometryDesc.Elements[s_ElementIndex];
                            s_VertexReader.Seek(s_Element.Offset, SeekOrigin.Begin);

                            // Iterate each element and check the format and set to the usage
                            // There should not be more than one of the same kind of usage here
                            switch (s_Element.Format)
                            {
                                case VertexElementFormat.VertexElementFormat_None:
                                    break;
                                // Halfs
                                case VertexElementFormat.VertexElementFormat_Half:
                                    s_Dict[s_Element.Usage] = RimeMath.HalfToFloat(s_VertexReader.ReadUInt16());
                                    break;
                                case VertexElementFormat.VertexElementFormat_Half2:
                                    s_Dict[s_Element.Usage] = (RimeMath.HalfToFloat(s_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(s_VertexReader.ReadUInt16()));
                                    break;
                                case VertexElementFormat.VertexElementFormat_Half3:
                                    s_Dict[s_Element.Usage] = (RimeMath.HalfToFloat(s_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(s_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(s_VertexReader.ReadUInt16()));
                                    break;
                                case VertexElementFormat.VertexElementFormat_Half4:
                                    s_Dict[s_Element.Usage] = (RimeMath.HalfToFloat(s_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(s_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(s_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(s_VertexReader.ReadUInt16()));
                                    break;

                                // Bytes
                                case VertexElementFormat.VertexElementFormat_UByteN:
                                    s_Dict[s_Element.Usage] = s_VertexReader.ReadByte();
                                    break;
                                case VertexElementFormat.VertexElementFormat_Byte4: // Should be signed byte
                                case VertexElementFormat.VertexElementFormat_Byte4N:
                                    s_Dict[s_Element.Usage] = s_VertexReader.ReadBytes(4);
                                    break;
                                case VertexElementFormat.VertexElementFormat_UByte4:
                                case VertexElementFormat.VertexElementFormat_UByte4N:
                                    s_Dict[s_Element.Usage] = s_VertexReader.ReadBytes(4);
                                    break;

                                // Floats
                                case VertexElementFormat.VertexElementFormat_Float:
                                    s_Dict[s_Element.Usage] = s_VertexReader.ReadSingle();
                                    break;
                                case VertexElementFormat.VertexElementFormat_Float2:
                                    s_Dict[s_Element.Usage] = (s_VertexReader.ReadSingle(), s_VertexReader.ReadSingle());
                                    break;
                                case VertexElementFormat.VertexElementFormat_Float3:
                                    s_Dict[s_Element.Usage] = (s_VertexReader.ReadSingle(), s_VertexReader.ReadSingle(), s_VertexReader.ReadSingle());
                                    break;
                                case VertexElementFormat.VertexElementFormat_Float4:
                                    s_Dict[s_Element.Usage] = (s_VertexReader.ReadSingle(), s_VertexReader.ReadSingle(), s_VertexReader.ReadSingle(), s_VertexReader.ReadSingle());
                                    break;
                                default:
                                    Console.WriteLine($"Unknown Format usage {s_Element.Format}");
                                    throw new Exception($"Unknown format usage {s_Element.Format}");
                            }
                        }

                        s_VerticiesNiceList.Add(s_Dict);
                    }

                    // Verify that we have parsed all of the verticies
                    if (s_VerticiesNiceList.Count != s_SubsetKey.VertexCount)
                        throw new Exception("asdasdas");

                    // Add to the new map of subset + parsed vertitices
                    s_ParsedSubsets.Add(s_SubsetKey, s_VerticiesNiceList);
                }

                // Now order the mesh subset category + (subset + parsed vert data)
                var s_Categories = new Dictionary<MeshSubsetCategory, List<KeyValuePair<MeshSubset, List<Dictionary<VertexElementUsage, dynamic>>>>>();
                for (var s_CategoryIndex = 0; s_CategoryIndex < s_Lod.CategorySubsetIndices.Length; ++s_CategoryIndex)
                {
                    // Get the list of subsets per-category
                    var s_SubsetIndicies = s_Lod.CategorySubsetIndices[s_CategoryIndex].Get;

                    // Hold a list of subsets + parsed verts
                    var s_SubsetPairList = new List<KeyValuePair<MeshSubset, List<Dictionary<VertexElementUsage, dynamic>>>>();
                    foreach (var s_SubsetIndex in s_SubsetIndicies)
                    {
                        // Example: Opaque = 0x1, 0x2 (subset index)
                        var s_SubsetPair = s_ParsedSubsets.ElementAt(s_SubsetIndex);

                        s_SubsetPairList.Add(s_SubsetPair);
                    }

                    // Add to the dictionary for subset category, (subsets + vertex data)[]
                    s_Categories.Add((MeshSubsetCategory)s_CategoryIndex, s_SubsetPairList);
                }

                // We only want to get the opaque meshes, TODO: Iterate through everything
                var s_Ret = s_Categories[MeshSubsetCategory.Opaque];

                // TODO: Hold list of subset + parsed verts + primitives
                
                // Open up a reader for our primitives
                using (var s_IndexReader = new RimeReader(new MemoryStream(s_PrimitiveChunkData)))
                {
                    // Iterate each subset pair
                    foreach (var s_SubsetPair in s_Ret)
                    {
                        // Get the subset
                        var s_SubsetKey = s_SubsetPair.Key;
                        var s_SubsetValue = s_SubsetPair.Value;

                        // Calculate the start offset in the index buffer
                        var s_SubsetStartIndex = s_SubsetKey.StartIndex;

                        // Validate the start offset
                        var s_SubsetStartOffset = Marshal.SizeOf<ushort>() * s_SubsetStartIndex;
                        if (s_SubsetStartOffset >= s_IndexReader.Length)
                            throw new Exception("subset start offset");

                        // Calculate and verify the end offset (that it's in-bounds)
                        var s_SubsetEndOffset = (Marshal.SizeOf<ushort>() * 3) * s_SubsetKey.PrimitiveCount; // * 3 for X, Y, Z
                        if (s_SubsetEndOffset > s_IndexReader.Length)
                            throw new Exception("subset end offset");
                        
                        // Hold our index list
                        var s_PrimitiveList = new List<(ushort, ushort, ushort)>();
                        switch (s_SubsetKey.PrimitiveType)
                        {
                            // If we are parsing a triangle list, then read out the X, Y, Z indices
                            case RimeLib.Mesh.Frostbite.PrimitiveType.PrimitiveType_TriangleList:
                                s_IndexReader.Seek(s_SubsetStartOffset, SeekOrigin.Begin);
                                for (var s_PrimitiveIndex = 0; s_PrimitiveIndex < s_SubsetKey.PrimitiveCount; ++s_PrimitiveIndex)
                                    s_PrimitiveList.Add((s_IndexReader.ReadUInt16(), s_IndexReader.ReadUInt16(), s_IndexReader.ReadUInt16()));
                                    break;
                            default:
                                throw new Exception("unimplemented primitive type");
                        }

                        // Continue with creating the gltf format
                        var s_RandomColor = new Vector4((float)s_Random.NextDouble(), (float)s_Random.NextDouble(), (float)s_Random.NextDouble(), 1.0f);
                        var s_DebugMaterial = new MaterialBuilder(s_SubsetKey.MaterialName.Object ?? "")
                            .WithMetallicRoughnessShader().WithChannelParam(KnownChannel.BaseColor, s_RandomColor);

                        // Create a new GLTF mesh
                        var s_Mesh = new MeshBuilder<VertexPosition, VertexTexture1>($"{MeshSubsetCategory.Opaque}_{s_Lod.ShortName.Object}");
                        var s_Primitive = s_Mesh.UsePrimitive(s_DebugMaterial);

                        // Iterate through all primitives
                        for (var s_PrimitiveIndex = 0; s_PrimitiveIndex < s_PrimitiveList.Count; ++s_PrimitiveIndex)
                        {
                            var s_PrimitiveIndices = s_PrimitiveList[s_PrimitiveIndex];

                            var s_FirstIndex = s_PrimitiveIndices.Item1;
                            if (s_FirstIndex > s_SubsetValue.Count)
                                throw new Exception("first index oob");

                            var s_FirstVertex = s_SubsetValue[s_FirstIndex];
                            if (!s_FirstVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic s_FirstVertexPos))
                                continue;


                            var s_SecondIndex = s_PrimitiveIndices.Item2;
                            if (s_SecondIndex > s_SubsetValue.Count)
                                throw new Exception("second index oob");

                            var s_SecondVertex = s_SubsetValue[s_SecondIndex];
                            if (!s_SecondVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic s_SecondVertexPos))
                                continue;

                            var s_ThirdIndex = s_PrimitiveIndices.Item3;
                            if (s_ThirdIndex > s_SubsetValue.Count)
                                throw new Exception("third index oob");

                            var s_ThirdVertex = s_SubsetValue[s_ThirdIndex];
                            if (!s_ThirdVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic s_ThirdVertexPos))
                                continue;


                            var s_FirstPosition = new VertexPosition(s_FirstVertexPos.Item1, s_FirstVertexPos.Item2, s_FirstVertexPos.Item3);
                            var s_SecondPosition = new VertexPosition(s_SecondVertexPos.Item1, s_SecondVertexPos.Item2, s_SecondVertexPos.Item3);
                            var s_ThirdPosition = new VertexPosition(s_ThirdVertexPos.Item1, s_ThirdVertexPos.Item2, s_ThirdVertexPos.Item3);


                            if (s_FirstVertex.TryGetValue(VertexElementUsage.VertexElementUsage_TexCoord0, out dynamic s_FirstVertexTexture) &&
                                s_SecondVertex.TryGetValue(VertexElementUsage.VertexElementUsage_TexCoord0, out dynamic s_SecondVertexTexture) &&
                                s_ThirdVertex.TryGetValue(VertexElementUsage.VertexElementUsage_TexCoord0, out dynamic s_ThirdVertexTexture))
                            {
                                var s_FirstTexture = new VertexTexture1(new System.Numerics.Vector2(s_FirstVertexTexture.Item1, s_FirstVertexTexture.Item2));
                                var s_SecondTexture = new VertexTexture1(new System.Numerics.Vector2(s_SecondVertexTexture.Item1, s_SecondVertexTexture.Item2));
                                var s_ThirdTexture = new VertexTexture1(new System.Numerics.Vector2(s_ThirdVertexTexture.Item1, s_ThirdVertexTexture.Item2));

                                s_Primitive.AddTriangle((s_FirstPosition, s_FirstTexture), (s_SecondPosition, s_SecondTexture), (s_ThirdPosition, s_ThirdTexture));
                            }
                            else
                            {
                                //Console.WriteLine("No texcoords");
                                s_Primitive.AddTriangle(s_FirstPosition, s_SecondPosition, s_ThirdPosition);
                            }
                        }
                        //var s_BaseAddress = s_Lod.BoneShortNameArrayPartTransforms.BaseAddress;
                        // s_ChunkReader.Seek((long)s_BaseAddress, SeekOrigin.Begin);

                        //var l_MatrixTransform = new Matrix44(s_ChunkReader);

                        //var s_Transform = new RimeLib.Frostbite.Core.
                        //s_SceneBuilder.AddRigidMesh(s_Mesh, l_MatrixTransform.ToMatrix4x4());

                        s_Model.CreateMesh(s_Mesh);
                    }
                }

                foreach (var s_Mesh in s_Model.LogicalMeshes)
                    s_Model.UseScene("default").CreateNode().WithMesh(s_Mesh);

                var s_ModelPath = Path.Join(p_Options?.OutputPath ?? "./", p_Layout.Name.Object);
                var s_ModelDirectory = Path.GetDirectoryName(s_ModelPath);

                Directory.CreateDirectory(s_ModelDirectory);

                s_Model.SaveGLTF(s_ModelPath, new WriteSettings() { JsonIndented = true });

            }
        }

        private static void DumpMesh<T>(IEngineMounter p_Mounter, Options p_Options, string p_FilePath, IMountedObject<T> p_Object) where T : IObjectVariant
        {
            /*if (p_FilePath.ToLower() != "levels/xp2_factory/objects/roofwindows_base_middle_01_mesh" &&
                p_FilePath.ToLower() != "levels/xp2_factory/objects/roofwindows_base_middle_02_mesh" &&
                p_FilePath.ToLower() != "levels/xp2_factory/objects/roofwindows_base_left_01_mesh" &&
                p_FilePath.ToLower() != "levels/xp2_factory/objects/roofwindows_base_right_01_mesh")
                return;*/

            //if (p_FilePath.ToLower() != "vehicles/common/russianscreen1_mesh".ToLower())
            //    return;

            // Construct a full path to this object and make sure its directory exists.
            var s_Path = Path.Join(p_Options.OutputPath, p_FilePath + ".bin").Normalize();

            if (!p_Options.Quiet)
                Console.WriteLine("/" + p_FilePath + ".obj");

            // Get a reader to the object.
            var s_Variant = p_Object.FirstVariant;
            using var s_MeshSetReader = s_Variant.GetReader();

            var s_MeshSetData = s_MeshSetReader.ReadBytes((int)s_MeshSetReader.Length);

            using var s_MeshSetLayoutReader = new RimeReader(new MemoryStream(s_MeshSetData), RimeLib.IO.Conversion.Endianness.LittleEndian);
            var s_MeshSetLayout = new MeshSetLayout(s_MeshSetLayoutReader);

            switch (s_MeshSetLayout.MeshType)
            {
                case MeshType.MeshType_Rigid:
                    ParseRigidMesh(p_Mounter, s_MeshSetLayout, p_Options);
                    break;
                case MeshType.MeshType_Composite:
                    ParseRigidMesh(p_Mounter, s_MeshSetLayout, p_Options);
                    break;
                case MeshType.MeshType_Skinned:
                    ParseRigidMesh(p_Mounter, s_MeshSetLayout, p_Options);
                    break;
            }
        }
    }
}