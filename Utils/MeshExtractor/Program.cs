using CommandLine;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Math;
using RimeLib.Mesh.Frostbite;
using RimeLib.Mesh.Frostbite.Helpers;
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
using SharpGLTF.Scenes;
using System.Linq;
using System.Numerics;
using System.Text.Json;
using RimeLib.Mesh.Frostbite.Fb2;
using SharpGLTF.Runtime;
using RimeLib.Frostbite.Core;

namespace MeshExtractor
{
    class Program
    {
        internal class Options
        {
            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;

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
                LoadContentAssembly(p_Options);
                DumpFiles(p_Options);

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

        private static async void DumpFiles(Options p_Options)
        {
            var s_Mounter = EngineMounterRegistry.Create(p_Options.EngineType);

            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, true, EngineType.Frostbite2_0);
            //await s_Mounter.MountSuperbundle("Win32/Chunks0", true);
            //await s_Mounter.MountSuperbundle("Win32/Chunks1", true);
            //await s_Mounter.MountSuperbundle("Win32/Chunks2", true);
            //await s_Mounter.MountSuperbundle("Win32/MpChunks", true);
            //await s_Mounter.MountSuperbundle("Win32/Xp2Chunks", true);
            //await s_Mounter.MountSuperbundle("Win32/Levels/XP2_Factory/XP2_Factory", true);

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
            var s_Resources = s_Mounter.GetResources();
            foreach (var s_Resource in s_Resources)
            {
                var s_Name = s_Resource.Key;
                var s_MountedObject = s_Resource.Value;

                foreach (var s_Variant in s_MountedObject.Variants)
                {
                    if (s_Variant.GetResourceType() != RimeLib.Content.Frostbite.ResourceType.MeshSet)
                        continue;

                    DumpMesh(s_Mounter, p_Options, s_Name, s_MountedObject);
                }
            }
#endif
        }

        private static void ParseRigidMesh(IEngineMounter p_Mounter, MeshSetLayout p_Layout, Options p_Options = null)
        {
            var s_BoundingBox = p_Layout.BoundingBox;

            if (!p_Options?.Quiet ?? false)
                Console.WriteLine($"Bounding Box: {s_BoundingBox}");
            // Create a new model
            var s_Model = ModelRoot.CreateModel();
            s_Model.Asset.Generator = "Generated by RimeLib (c) 2020";
            s_Model.Asset.Copyright = "Exported by Rime (c) kiwidoggie productions 2017-2020, models copyright respective ip owners, not for redistribution";

            // Create a default scene
            var s_Scene = s_Model.UseScene("default");

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

                // Hold all of the vertex information
                var s_VertexList = new List<Dictionary<VertexElementUsage, dynamic>>();
                var s_PrimitiveList = new List<(ushort, ushort, ushort)>();

                using (var s_DataChunkReader = p_Chunk.FirstVariant.GetReader())
                {
                    using var s_ChunkReader = new RimeReader(new MemoryStream(s_DataChunkReader.ReadBytes((int)s_DataChunkReader.Length)));

                    // Iterate through each of the subset categories
                    for (var s_SubsetCategoryIndex = MeshSubsetCategory.Opaque; s_SubsetCategoryIndex < MeshSubsetCategory.Count; ++s_SubsetCategoryIndex)
                    {
                        // Get the subset for the specific subset category
                        var s_Subset = s_Lod.Subsets.Get[(int)s_SubsetCategoryIndex];
                        if (s_Subset == null)
                            throw new Exception("could not get subset");

                        var s_GeometryDesc = s_Subset.GeometryDeclarationDesc;

                        var s_VertexStride = s_Subset.VertexStride;

                        // Go to the index of our vertex offset
                        s_ChunkReader.Seek(s_Subset.VertexOffset, SeekOrigin.Begin);

                        // Read out all of the vertex data, it will be described by the GeometryDesc
                        var s_VertexDataList = new List<byte[]>();
                        for (var s_VertexIndex = 0; s_VertexIndex < s_Subset.VertexCount; ++s_VertexIndex)
                            s_VertexDataList.Add(s_ChunkReader.ReadBytes(s_VertexStride));

                        

                        // Iterate through each vertex data (sizeof(VertexData) == Stride)
                        foreach (var s_VertexData in s_VertexDataList)
                        {
                            // Create a new reader to the vertex data specifically
                            using var s_VertexReader = new RimeReader(new MemoryStream(s_VertexData));

                            // This dictionary is how we will parse each element from the vertex data
                            var s_Dict = new Dictionary<VertexElementUsage, dynamic>();
                            foreach (var s_Element in s_GeometryDesc.Elements)
                            {
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

                            s_VertexList.Add(s_Dict);
                        }

                        // Check that we are at the primtive start
                        if (s_ChunkReader.Position != s_Subset.VertexOffset + (s_Subset.VertexCount * s_Subset.VertexStride))
                            throw new Exception("check this");

                        switch (s_Subset.PrimitiveType)
                        {
                            case RimeLib.Mesh.Frostbite.PrimitiveType.PrimitiveType_TriangleList:
                                for (var s_PrimitiveIndex = 0; s_PrimitiveIndex < s_Subset.PrimitiveCount; ++s_PrimitiveIndex)
                                    s_PrimitiveList.Add((s_ChunkReader.ReadUInt16(), s_ChunkReader.ReadUInt16(), s_ChunkReader.ReadUInt16()));
                                break;
                            default:
                                throw new Exception("not implemented");
                        }

                        // Continue with creating the gltf format
                        var s_Random = new Random();
                        var s_RandomColor = new Vector4((float)s_Random.NextDouble(), (float)s_Random.NextDouble(), (float)s_Random.NextDouble(), 1.0f);
                        var s_DebugMaterial = new MaterialBuilder(s_Subset.MaterialName.Object ?? "")
                            .WithMetallicRoughnessShader().WithChannelParam(KnownChannel.BaseColor, s_RandomColor);

                        // Create a new GLTF mesh
                        var s_Mesh = new MeshBuilder<VertexPosition, VertexTexture1>($"{s_SubsetCategoryIndex}_{s_Lod.ShortName.Object}");
                        var s_Primitive = s_Mesh.UsePrimitive(s_DebugMaterial);

                        for (var i = 0; i < s_PrimitiveList.Count; ++i)
                        {
                            var s_PrimitiveIndices = s_PrimitiveList[i];

                            var s_FirstIndex = s_PrimitiveIndices.Item1;
                            if (s_FirstIndex > s_VertexList.Count)
                                continue;

                            var s_FirstVertex = s_VertexList[s_FirstIndex];
                            if (!s_FirstVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic s_FirstVertexPos))
                                continue;


                            var s_SecondIndex = s_PrimitiveIndices.Item2;
                            if (s_SecondIndex > s_VertexList.Count)
                                continue;

                            var s_SecondVertex = s_VertexList[s_SecondIndex];
                            if (!s_SecondVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic s_SecondVertexPos))
                                continue;

                            var s_ThirdIndex = s_PrimitiveIndices.Item3;
                            if (s_ThirdIndex > s_VertexList.Count)
                                continue;

                            var s_ThirdVertex = s_VertexList[s_ThirdIndex];
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
                                Console.WriteLine("No texcoords");
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

                    foreach (var s_Mesh in s_Model.LogicalMeshes)
                        s_Model.UseScene("default").CreateNode().WithMesh(s_Mesh);

                    var s_ModelPath = Path.Join(p_Options?.OutputPath ?? "./", p_Layout.ShortName.Object);
                    var s_ModelDirectory = Path.GetDirectoryName(s_ModelPath);

                    Directory.CreateDirectory(s_ModelDirectory);

                    s_Model.SaveGLTF("./output.gltf", new WriteSettings() { JsonIndented = true });
                }
            }
        }

        private static void DumpMesh<T>(IEngineMounter p_Mounter, Options p_Options, string p_FilePath, IMountedObject<T> p_Object) where T : IObjectVariant
        {
            /*if (p_FilePath.ToLower() != "levels/xp2_factory/objects/roofwindows_base_middle_01_mesh" &&
                p_FilePath.ToLower() != "levels/xp2_factory/objects/roofwindows_base_middle_02_mesh" &&
                p_FilePath.ToLower() != "levels/xp2_factory/objects/roofwindows_base_left_01_mesh" &&
                p_FilePath.ToLower() != "levels/xp2_factory/objects/roofwindows_base_right_01_mesh")
                return;*/

            if (p_FilePath.ToLower() != "vehicles/common/russianscreen1_mesh")
                return;

            // Construct a full path to this object and make sure its directory exists.
            var s_Path = Path.Join(p_Options.OutputPath, p_FilePath + ".bin").Normalize();

            // If the output directory does not exist, create it
            var s_Directory = Path.GetDirectoryName(s_Path);
            if (!Directory.Exists(s_Directory))
                Directory.CreateDirectory(s_Directory);

            if (!p_Options.Quiet)
                Console.WriteLine("/" + p_FilePath + ".obj");

            // Get a reader to the object.
            var s_Variant = p_Object.FirstVariant;
            using var s_MeshSetReader = s_Variant.GetReader();

            var s_MeshSetData = s_MeshSetReader.ReadBytes((int)s_MeshSetReader.Length);


            using var s_MeshSetLayoutReader = new RimeReader(new MemoryStream(s_MeshSetData), RimeLib.IO.Conversion.Endianness.LittleEndian);
            var s_MeshSetLayout = new MeshSetLayout(s_MeshSetLayoutReader);

            var s_TotalSubsetCount = s_MeshSetLayout.TotalSubsetCount;

            switch (s_MeshSetLayout.MeshType)
            {
                case MeshType.MeshType_Rigid:
                    ParseRigidMesh(p_Mounter, s_MeshSetLayout);
                    break;
                case MeshType.MeshType_Composite:
                    break;
                case MeshType.MeshType_Skinned:
                    break;
            }

            // Create a new model
            var s_Model = ModelRoot.CreateModel();
            s_Model.Asset.Generator = "Generated by RimeLib (c) 2020";
            s_Model.Asset.Copyright = "Exported by Rime (c) kiwidoggie productions 2017-2020, models copyright respective ip owners, not for redistribution";

            var s_CurrentLod = 0;
            for (var s_LodIndex = 0; s_LodIndex < s_MeshSetLayout.LodCount; ++s_LodIndex)
            {
                var s_Lod = s_MeshSetLayout.Lods[s_LodIndex];
                var s_MeshLayout = s_Lod.Object;
                if (s_MeshLayout == null)
                {
                    s_CurrentLod++;
                    continue;
                }

                var s_DataChunkId = s_MeshLayout.DataChunkId;
                if (!p_Mounter.TryGetChunk(s_DataChunkId, out IMountedObject<IChunkVariant> p_Chunk))
                {
                    if (!p_Options.Quiet)
                        Console.WriteLine($"could not find data: {BitConverter.ToString(s_DataChunkId.Id)}");

                    continue;
                }

                // Create a new GLTF mesh
                var s_Mesh = new MeshBuilder<VertexPosition, VertexTexture1>(s_MeshLayout.Name.Object);

                // TODO: Determine wtf this reader is open to
                using var s_ChunkReader = p_Chunk.FirstVariant.GetReader();
                var s_ChunkData = s_ChunkReader.ReadBytes((int)s_ChunkReader.Length);
                var s_ChunkDataReader = new BinaryReader(new MemoryStream(s_ChunkData));
                long s_IndexOffset = s_MeshLayout.VertexDataSize;

                if (s_MeshLayout.AuxVertexIndexDataOffset != 0xffffffff)
                    throw new Exception("check this data");

                // Each of the subsets can be one part
                var s_Subsets = s_MeshLayout.Subsets.Get;
                for (var s_SubsetIndex = 0; s_SubsetIndex < s_Subsets.Length; ++s_SubsetIndex)
                {
                    var s_Subset = s_Subsets[s_SubsetIndex];

                    var s_GeometryDesc = s_Subset.GeometryDeclarationDesc;

                    // This holds how large 1 entry is in the array
                    var s_VertexStride = s_Subset.VertexStride;

                    // This is a primitive type
                    var s_PrimitiveType = s_Subset.PrimitiveType;

                    // Seek to the start of the vertex data
                    s_ChunkDataReader.BaseStream.Seek(s_Subset.VertexOffset, SeekOrigin.Begin);

                    // Read out all of the vertex data, it will be described by the GeometryDesc
                    var s_VertexDataList = new List<byte[]>();
                    for (var s_VertexIndex = 0; s_VertexIndex < s_Subset.VertexCount; ++s_VertexIndex)
                        s_VertexDataList.Add(s_ChunkDataReader.ReadBytes(s_VertexStride));

                    // Hold all of the vertex information
                    var s_VertexList = new List<Dictionary<VertexElementUsage, dynamic>>();
                    var s_PrimitiveList = new List<(ushort, ushort, ushort)>();

                    // Iterate through each vertex data (sizeof(VertexData) == Stride)
                    foreach (var s_VertexData in s_VertexDataList)
                    {
                        // Create a new reader to the vertex data specifically
                        using var s_VertexReader = new RimeReader(new MemoryStream(s_VertexData));

                        // This dictionary is how we will parse each element from the vertex data
                        var s_Dict = new Dictionary<VertexElementUsage, dynamic>();
                        foreach (var s_Element in s_GeometryDesc.Elements)
                        {
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

                        s_VertexList.Add(s_Dict);
                    }

                    // IndexOffset = 0x00000000000087a0
                    // Position = 0x00000000000045e0
                    // Length = 0x000000000000afd0
                    // Length - IndexOffset = 0x2830
                    // 0x230 / 0x6 = 0x6B2
                    // s_Subset.PrimitiveCount = 0x000003b3

                    // IndexOffset = 0x0000000000009dd2
                    // Positition = 0x00000000000062e0
                    // Length = 0x000000000000afd0
                    // Length - IndexOffset = 0x11FE

                    var s_Json = JsonSerializer.Serialize(s_Subset, new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });
                    var s_LodJson = JsonSerializer.Serialize(s_Lod, new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                    // Debugging code
                    //File.WriteAllText($"Lod{s_LodIndex}_{s_SubsetIndex}.json", s_LodJson);
                    //File.WriteAllText($"{s_SubsetIndex}.json", s_Json);

                    if (s_ChunkDataReader.BaseStream.Length - s_IndexOffset <= s_Subset.PrimitiveCount * 0x6)
                        throw new Exception();

                    s_ChunkDataReader.BaseStream.Seek(s_IndexOffset, SeekOrigin.Begin);

                    switch (s_PrimitiveType)
                    {
                        case RimeLib.Mesh.Frostbite.PrimitiveType.PrimitiveType_TriangleList:
                            for (var s_PrimitiveIndex = 0; s_PrimitiveIndex < s_Subset.PrimitiveCount; ++s_PrimitiveIndex)
                            {
                                s_PrimitiveList.Add((s_ChunkDataReader.ReadUInt16(), s_ChunkDataReader.ReadUInt16(), s_ChunkDataReader.ReadUInt16()));
                            }

                            break;
                        default:
                            Console.WriteLine($"primitive type {s_PrimitiveType} not implemented");
                            throw new NotImplementedException($"primitive type {s_PrimitiveType} not implemented");
                    }

                    s_IndexOffset = s_ChunkDataReader.BaseStream.Position;

                    if (s_Subset.MaterialName.Object == "")
                        continue;


                    var s_Random = new Random();
                    var s_RandomColor = new Vector4((float)s_Random.NextDouble(), (float)s_Random.NextDouble(), (float)s_Random.NextDouble(), 1.0f);
                    var s_DebugMaterial = new MaterialBuilder(s_Subset.MaterialName.Object)
                        .WithMetallicRoughnessShader().WithChannelParam(KnownChannel.BaseColor, s_RandomColor);

                    var s_Primitive = s_Mesh.UsePrimitive(s_DebugMaterial);

                    if (s_PrimitiveList.Count != s_Subset.PrimitiveCount)
                        throw new Exception("prim count fucked up");

                    if (s_VertexList.Count != s_Subset.VertexCount)
                        throw new Exception("vertex count fucked up");

                    Console.WriteLine($"Dumping subset {s_Subset.MaterialName.Object}");

                    for (var i = 0; i < s_PrimitiveList.Count; ++i)
                    {
                        var s_PrimitiveIndices = s_PrimitiveList[i];

                        var s_FirstIndex = s_PrimitiveIndices.Item1;
                        if (s_FirstIndex > s_VertexList.Count)
                            continue;

                        var s_FirstVertex = s_VertexList[s_FirstIndex];
                        if (!s_FirstVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic s_FirstVertexPos))
                            continue;


                        var s_SecondIndex = s_PrimitiveIndices.Item2;
                        if (s_SecondIndex > s_VertexList.Count)
                            continue;

                        var s_SecondVertex = s_VertexList[s_SecondIndex];
                        if (!s_SecondVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic s_SecondVertexPos))
                            continue;

                        var s_ThirdIndex = s_PrimitiveIndices.Item3;
                        if (s_ThirdIndex > s_VertexList.Count)
                            continue;

                        var s_ThirdVertex = s_VertexList[s_ThirdIndex];
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
                            Console.WriteLine("No texcoords");
                            s_Primitive.AddTriangle(s_FirstPosition, s_SecondPosition, s_ThirdPosition);
                        }
                    }
                }

                s_ChunkDataReader.Close();

                //var s_ObjData = s_Writer.ToString();

                //var s_OutputPath = Path.Join(p_Options.OutputPath, p_FilePath + $"lod{s_LodIndex}.obj").Normalize();
                //File.WriteAllText(s_OutputPath, s_ObjData);

                s_CurrentLod++;

                s_Model.CreateMesh(s_Mesh);
                break;
            }

            foreach (var s_Mesh in s_Model.LogicalMeshes)
                s_Model.UseScene("default").CreateNode().WithMesh(s_Mesh);

            var s_ModelPath = Path.Join(p_Options.OutputPath, p_FilePath + ".gltf");
            var s_ModelDirectory = Path.GetDirectoryName(s_ModelPath);

            Directory.CreateDirectory(s_ModelDirectory);

            s_Model.SaveGLTF(s_ModelPath, new WriteSettings() { JsonIndented = true });
        }
    }
}
