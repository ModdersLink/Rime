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
using System.Runtime.InteropServices;

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

                // Hold all of our data
                byte[] s_VertexChunkData = null;
                byte[] s_PrimitiveChunkData = null;
                byte[] s_ChunkData = null;

                using (var s_ChunkReader = p_Chunk.FirstVariant.GetReader())
                    s_ChunkData = s_ChunkReader.ReadBytes((int)s_ChunkReader.Length);

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
