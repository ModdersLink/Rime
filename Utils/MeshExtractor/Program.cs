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
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using SharpGLTF.Scenes;
using System.Linq;

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
            }).WithNotParsed(p_Err => { Environment.Exit(1); });
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

                Environment.Exit(1);
            }
        }

        private static async void DumpFiles(Options p_Options)
        {
            var s_Mounter = EngineMounterRegistry.Create(p_Options.EngineType);

            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, true, EngineType.Frostbite2_0);

            if (!p_Options.Quiet)
                Console.WriteLine($"Everythingis now mounted! Starting model conversion.");

            /*foreach (var p_Pair in s_Mounter.GetResources())
            {
                var l_Name = p_Pair.Key;
                var l_MountedObject = p_Pair.Value;

                foreach (var l_Variant in l_MountedObject.Variants)
                {
                    if (l_Variant.GetResourceType() != RimeLib.Content.Frostbite.ResourceType.MeshSet)
                        continue;

                    // Dump the mesh
                    DumpMesh(s_Mounter, p_Options, l_Name, l_MountedObject);
                }
            }*/

            // TODO: Speed this up
            // Uncomment below once debugging is done
            Parallel.ForEach(s_Mounter.GetResources(), p_Pair =>
            {
                var l_Name = p_Pair.Key;
                var l_MountedObject = p_Pair.Value;

                foreach (var l_Variant in l_MountedObject.Variants)
                {
                    if (l_Variant.GetResourceType() != RimeLib.Content.Frostbite.ResourceType.MeshSet)
                        continue;

                    // Dump the mesh
                    DumpMesh3(s_Mounter, p_Options, l_Name, l_MountedObject);
                }
            });
        }

        private static void DumpMesh2<T>(IEngineMounter p_Mounter, Options p_Options, string p_FilePath, IMountedObject<T> p_Object) where T : IObjectVariant
        {
            // Construct a full path to this object and make sure its directory exists.
            var s_Path = Path.Join(p_Options.OutputPath, p_FilePath + ".gltf").Normalize();

            // See if the output directory exists, if not create it
            var s_Directory = Path.GetDirectoryName(s_Path);
            if (!Directory.Exists(s_Directory))
                Directory.CreateDirectory(s_Directory);

            // Logging
            if (!p_Options.Quiet)
                Console.WriteLine($"Exporting {s_Path}.gltf");

            // Get a reader to the object.
            var s_Variant = p_Object.FirstVariant;
            using var s_Reader = s_Variant.GetReader();

            var s_Data = s_Reader.ReadBytes((int)s_Reader.Length);

            using var s_Reader2 = new RimeReader(new MemoryStream(s_Data), RimeLib.IO.Conversion.Endianness.LittleEndian);
            var s_MeshSetLayout = new MeshSetLayout(s_Reader2);

            // Create a plain off-white material
            var s_RedMaterial = new MaterialBuilder().WithMetallicRoughnessShader().WithChannelParam(KnownChannel.BaseColor, new System.Numerics.Vector4(1, 0, 0, 1));

            // Create a new mesh
            var s_Mesh = new MeshBuilder<VertexPosition>(s_MeshSetLayout.Name.Object);

            // Get our primitives
            var s_Primitive = s_Mesh.UsePrimitive(s_RedMaterial);
            
        }

        private static void DumpMesh3<T>(IEngineMounter p_Mounter, Options p_Options, string p_FilePath, IMountedObject<T> p_Object) where T : IObjectVariant
        {
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
            using var s_Reader = s_Variant.GetReader();

            var s_Data = s_Reader.ReadBytes((int)s_Reader.Length);

            //File.WriteAllBytes(s_Path, s_Data);

            using var s_Reader2 = new RimeReader(new MemoryStream(s_Data), RimeLib.IO.Conversion.Endianness.LittleEndian);
            var s_MeshSetLayout = new MeshSetLayout(s_Reader2);

            

            // Create a new model
            var s_Model = ModelRoot.CreateModel();
            s_Model.Asset.Generator = "Generated by RimeLib (c) 2020";
            s_Model.Asset.Copyright = "Exported by Rime (c) kiwidoggie productions 2017-2020, models copyright respective ip owners, not for redistribution";

            // Create a default scene
            var s_Scene = s_Model.UseScene("default");

            // Create a default material for testing
            // TODO: Create proper material creation
            var s_DebugMaterial = new MaterialBuilder("debug");

            var s_CurrentLod = 0;
            for (var l_LodIndex = 0; l_LodIndex < s_MeshSetLayout.LodCount; ++l_LodIndex)
            {
                var l_Lod = s_MeshSetLayout.Lods[l_LodIndex];
                var l_MeshLayout = l_Lod.Object;
                if (l_MeshLayout == null)
                {
                    s_CurrentLod++;
                    continue;
                }

                var l_DataChunkId = l_MeshLayout.DataChunkId;
                if (!p_Mounter.TryGetChunk(l_DataChunkId, out IMountedObject<IChunkVariant> p_Chunk))
                {
                    if (!p_Options.Quiet)
                        Console.WriteLine($"could not find data: {BitConverter.ToString(l_DataChunkId.Id)}");

                    continue;
                }

                

                // Each of the subsets can be one part
                var s_Subsets = l_MeshLayout.Subsets.Get;
                for (var l_SubsetIndex = 0; l_SubsetIndex < s_Subsets.Length; ++l_SubsetIndex)
                {
                    var l_Subset = s_Subsets[l_SubsetIndex];

                    var l_GeometryDesc = l_Subset.GeometryDeclarationDesc;

                    // This holds how large 1 entry is in the array
                    var l_VertexStride = l_Subset.VertexStride;

                    // This is a primitive type
                    var l_PrimitiveType = l_Subset.PrimitiveType;

                    // TODO: Determine wtf this reader is open to
                    using var l_IncomingDataReader = p_Chunk.FirstVariant.GetReader();
                    var l_ReaderData = l_IncomingDataReader.ReadBytes((int)l_IncomingDataReader.Length);
                    var l_Reader = new BinaryReader(new MemoryStream(l_ReaderData));

#if DEBUG
                    // If we are debugging, dump the raw format out to file
                    //File.WriteAllBytes($"{l_MeshLayout.ShortName.Object}_subset{l_SubsetIndex}.bin", l_ReaderData);
#endif

                    // Read out all of the vertex data, it will be described by the GeometryDesc
                    var l_VertexDataList = new List<byte[]>();
                    for (var l_VertexIndex = 0; l_VertexIndex < l_Subset.VertexCount; ++l_VertexIndex)
                        l_VertexDataList.Add(l_Reader.ReadBytes(l_VertexStride));

                    // Hold all of the vertex information
                    var l_VertexList = new List<Dictionary<VertexElementUsage, dynamic>>();
                    var l_PrimitiveList = new List<(ushort, ushort, ushort)>();

                    // Iterate through each vertex data (sizeof(VertexData) == Stride)
                    foreach (var l_VertexData in l_VertexDataList)
                    {
                        // Create a new reader to the vertex data specifically
                        using var l_VertexReader = new BinaryReader(new MemoryStream(l_VertexData));

                        // This dictionary is how we will parse each element from the vertex data
                        var l_Dict = new Dictionary<VertexElementUsage, dynamic>();
                        foreach (var l_Element in l_GeometryDesc.Elements)
                        {
                            // Iterate each element and check the format and set to the usage
                            // There should not be more than one of the same kind of usage here
                            switch (l_Element.Format)
                            {
                                case VertexElementFormat.VertexElementFormat_None:
                                    break;

                                // Halfs
                                case VertexElementFormat.VertexElementFormat_Half:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = RimeMath.HalfToFloat(l_VertexReader.ReadUInt16());
                                    break;
                                case VertexElementFormat.VertexElementFormat_Half2:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()));
                                    break;
                                case VertexElementFormat.VertexElementFormat_Half3:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()));
                                    break;
                                case VertexElementFormat.VertexElementFormat_Half4:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()));
                                    break;
                                case VertexElementFormat.VertexElementFormat_UByte4:
                                case VertexElementFormat.VertexElementFormat_UByte4N:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = l_VertexReader.ReadBytes(4);
                                    break;

                                // Floats
                                case VertexElementFormat.VertexElementFormat_Float:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = l_VertexReader.ReadSingle();
                                    break;
                                case VertexElementFormat.VertexElementFormat_Float2:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle());
                                    break;
                                case VertexElementFormat.VertexElementFormat_Float3:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle());
                                    break;
                                case VertexElementFormat.VertexElementFormat_Float4:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle());
                                    break;
                                default:
                                    Console.WriteLine($"Unknown Format usage {l_Element.Format}");
                                    throw new Exception($"Unknown format usage {l_Element.Format}");
                            }
                        }

                        l_VertexList.Add(l_Dict);
                    }

                    // Read out all of the primitives
                    l_Reader.BaseStream.Seek(l_MeshLayout.VertexDataSize, SeekOrigin.Begin);

                    switch (l_PrimitiveType)
                    {
                        case RimeLib.Mesh.Frostbite.PrimitiveType.PrimitiveType_TriangleList:
                            for (var l_PrimitiveIndex = 0; l_PrimitiveIndex < l_Subset.PrimitiveCount; ++l_PrimitiveIndex)
                                l_PrimitiveList.Add((l_Reader.ReadUInt16(), l_Reader.ReadUInt16(), l_Reader.ReadUInt16()));
                            break;
                        default:
                            Console.WriteLine($"primitive type {l_PrimitiveType} not implemented");
                            throw new NotImplementedException($"primitive type {l_PrimitiveType} not implemented");
                    }

                    // Create a new GLTF mesh
                    var s_Mesh = new MeshBuilder<VertexPosition, VertexTexture1>(l_MeshLayout.Name.Object);

                    //var s_Mesh = s_Model.CreateMesh(l_MeshLayout.Name.Object);

                    var s_Primitive = s_Mesh.UsePrimitive(s_DebugMaterial);

                    for (var i = 0; i < l_PrimitiveList.Count; ++i)
                    {
                        var l_PrimitiveIndices = l_PrimitiveList[i];

                        var l_FirstIndex = l_PrimitiveIndices.Item1;
                        if (l_FirstIndex >= l_VertexList.Count)
                            continue;

                        var l_FirstVertex = l_VertexList[l_FirstIndex];
                        if (!l_FirstVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic l_FirstVertexPos))
                            continue;

                        if (!l_FirstVertex.TryGetValue(VertexElementUsage.VertexElementUsage_TexCoord0, out dynamic l_FirstVertexTexture))
                            continue;

                        var l_SecondIndex = l_PrimitiveIndices.Item2;
                        if (l_SecondIndex >= l_VertexList.Count)
                            continue;

                        var l_SecondVertex = l_VertexList[l_SecondIndex];
                        if (!l_SecondVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic l_SecondVertexPos))
                            continue;

                        if (!l_SecondVertex.TryGetValue(VertexElementUsage.VertexElementUsage_TexCoord0, out dynamic l_SecondVertexTexture))
                            continue;

                        var l_ThirdIndex = l_PrimitiveIndices.Item3;
                        if (l_ThirdIndex >= l_VertexList.Count)
                            continue;

                        var l_ThirdVertex = l_VertexList[l_ThirdIndex];
                        if (!l_ThirdVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic l_ThirdVertexPos))
                            continue;

                        if (!l_ThirdVertex.TryGetValue(VertexElementUsage.VertexElementUsage_TexCoord0, out dynamic l_ThirdVertexTexture))
                            continue;

                        var l_FirstPosition = new VertexPosition(l_FirstVertexPos.Item1, l_FirstVertexPos.Item2, l_FirstVertexPos.Item3);
                        var l_FirstTexture = new VertexTexture1(new System.Numerics.Vector2(l_FirstVertexTexture.Item1, l_FirstVertexTexture.Item2));

                        var l_SecondPosition = new VertexPosition(l_SecondVertexPos.Item1, l_SecondVertexPos.Item2, l_SecondVertexPos.Item3);
                        var l_SecondTexture = new VertexTexture1(new System.Numerics.Vector2(l_SecondVertexTexture.Item1, l_SecondVertexTexture.Item2));

                        var l_ThirdPosition = new VertexPosition(l_ThirdVertexPos.Item1, l_ThirdVertexPos.Item2, l_ThirdVertexPos.Item3);
                        var l_ThirdTexture = new VertexTexture1(new System.Numerics.Vector2(l_ThirdVertexTexture.Item1, l_ThirdVertexTexture.Item2));

                        s_Primitive.AddTriangle((l_FirstPosition, l_FirstTexture), (l_SecondPosition, l_SecondTexture), (l_ThirdPosition, l_ThirdTexture));
                    }

                    //foreach (var l_Vertex in l_VertexList)
                    //{
                    //    foreach (VertexElementUsage l_Usage in Enum.GetValues(typeof(VertexElementUsage)))
                    //    {
                    //        if (!l_Vertex.TryGetValue(l_Usage, out dynamic l_OutData))
                    //            continue;

                    //        switch (l_Usage)
                    //        {
                    //            case VertexElementUsage.VertexElementUsage_Pos:

                    //                s_Writer.WriteLine($"v {l_OutData.Item1} {l_OutData.Item2} {l_OutData.Item3}");
                    //                break;
                    //            case VertexElementUsage.VertexElementUsage_Normal:
                    //                s_Writer.WriteLine($"vn {l_OutData.Item1} {l_OutData.Item2} {l_OutData.Item3}");
                    //                break;
                    //            case VertexElementUsage.VertexElementUsage_Tangent:
                    //                s_Writer.WriteLine($"# Tangent: {l_OutData.Item1} {l_OutData.Item2} {l_OutData.Item3} {l_OutData.Item4}");
                    //                break;
                    //            case VertexElementUsage.VertexElementUsage_BoneIndices:
                    //                s_Writer.WriteLine($"# bone indicies: {BitConverter.ToString(l_OutData)}");
                    //                break;
                    //            case VertexElementUsage.VertexElementUsage_Binormal:
                    //                s_Writer.WriteLine($"# binormal: {l_OutData.Item1} {l_OutData.Item2} {l_OutData.Item3} {l_OutData.Item4}");
                    //                break;
                    //            case VertexElementUsage.VertexElementUsage_BinormalSign:
                    //                s_Writer.WriteLine($"# binormal sign: {l_OutData}");
                    //                break;
                    //            case VertexElementUsage.VertexElementUsage_TexCoord0:
                    //            case VertexElementUsage.VertexElementUsage_TexCoord1:
                    //            case VertexElementUsage.VertexElementUsage_TexCoord2:
                    //            case VertexElementUsage.VertexElementUsage_TexCoord3:
                    //            case VertexElementUsage.VertexElementUsage_TexCoord4:
                    //            case VertexElementUsage.VertexElementUsage_TexCoord5:
                    //            case VertexElementUsage.VertexElementUsage_TexCoord6:
                    //            case VertexElementUsage.VertexElementUsage_TexCoord7:
                    //                s_Writer.WriteLine($"vn {l_OutData.Item1} {l_OutData.Item2}");
                    //                break;
                    //            case VertexElementUsage.VertexElementUsage_Color0:
                    //            case VertexElementUsage.VertexElementUsage_Color1:
                    //                s_Writer.WriteLine($"# color {BitConverter.ToString(l_OutData)}");
                    //                break;
                    //            case VertexElementUsage.VertexElementUsage_BoneWeights:
                    //                s_Writer.WriteLine($"# bone weights {BitConverter.ToString(l_OutData)}");
                    //                break;
                    //            case VertexElementUsage.VertexElementUsage_RadiosityTexCoord:
                    //                s_Writer.WriteLine($"vn {l_OutData.Item1} {l_OutData.Item2}");
                    //                break;
                    //            case VertexElementUsage.VertexElementUsage_SubMaterialIndex:
                    //                s_Writer.WriteLine($"# sub-material index {BitConverter.ToString(l_OutData)}");
                    //                break;
                    //            default:
                    //                Console.WriteLine($"usage type {l_Usage} not implemented");
                    //                throw new NotImplementedException($"usage type {l_Usage} not implemented");

                    //        }
                    //    }
                    //}

                    //foreach (var l_Index in l_PrimitiveList)
                    //    s_Writer.WriteLine($"f {l_Index.Item1 + 1} {l_Index.Item2 + 1} {l_Index.Item3 + 1}");

                    l_Reader.Close();

                    s_Model.CreateMesh(s_Mesh);

                    s_Model.UseScene("default").CreateNode().WithMesh(s_Model.LogicalMeshes.First());

                    s_Model.SaveGLTF($@"D:\Data\Projects\RimeLibLite\Utils\MeshExtractor\bin\Debug\netcoreapp3.0\{l_MeshLayout.ShortName.Object}.gltf", new WriteSettings() { JsonIndented = true });
                }

                

                //var s_ObjData = s_Writer.ToString();

                //var s_OutputPath = Path.Join(p_Options.OutputPath, p_FilePath + $"lod{l_LodIndex}.obj").Normalize();
                //File.WriteAllText(s_OutputPath, s_ObjData);

                s_CurrentLod++;
            }


        }

        private static void DumpMesh<T>(IEngineMounter p_Mounter, Options p_Options, string p_FilePath, IMountedObject<T> p_Object) where T : IObjectVariant
        {
            // Construct a full path to this object and make sure its directory exists.
            var s_Path = Path.Join(p_Options.OutputPath, p_FilePath + ".bin").Normalize();

            var s_Directory = Path.GetDirectoryName(s_Path);
            
            if (!Directory.Exists(s_Directory))
                Directory.CreateDirectory(s_Directory);

            if (!p_Options.Quiet)
                Console.WriteLine("/" + p_FilePath + ".obj");

            // Get a reader to the object.
            var s_Variant = p_Object.FirstVariant;
            using var s_Reader = s_Variant.GetReader();

            var s_Data = s_Reader.ReadBytes((int)s_Reader.Length);

            File.WriteAllBytes(s_Path, s_Data);

            using var s_Reader2 = new RimeReader(new MemoryStream(s_Data), RimeLib.IO.Conversion.Endianness.LittleEndian);
            var s_MeshSetLayout = new MeshSetLayout(s_Reader2);

            var s_CurrentLod = 0;
            

            for (var l_LodIndex = 0; l_LodIndex < s_MeshSetLayout.LodCount; ++l_LodIndex)
            {
                var l_Lod = s_MeshSetLayout.Lods[l_LodIndex];

                using var s_Writer = new StringWriter();

                var l_MeshLayout = l_Lod.Object;
                if (l_MeshLayout == null)
                {
                    s_CurrentLod++;
                    continue;
                }

                s_Writer.WriteLine($"# Automatically generated file");
                s_Writer.WriteLine($"# Name: {l_MeshLayout.Name.Object}");
                s_Writer.WriteLine($"# ChunkId: {l_MeshLayout.DataChunkId}");
                s_Writer.WriteLine($"# Lod: {s_CurrentLod}");

                var l_DataChunkId = l_MeshLayout.DataChunkId;

                if (!p_Mounter.TryGetChunk(l_DataChunkId, out IMountedObject<IChunkVariant> p_Chunk))
                    continue;


                // Each of the subsets can be one part
                var s_Subsets = l_MeshLayout.Subsets.Get;
                for (var l_SubsetIndex = 0; l_SubsetIndex < s_Subsets.Length; ++l_SubsetIndex)
                {
                    var l_Subset = s_Subsets[l_SubsetIndex];

                    var l_GeometryDesc = l_Subset.GeometryDeclarationDesc;

                    // This holds how large 1 entry is in the array
                    var l_VertexStride = l_Subset.VertexStride;

                    // This is a primitive type
                    var l_PrimitiveType = l_Subset.PrimitiveType;

                    // TODO: Determine wtf this reader is open to
                    using var l_IncomingDataReader = p_Chunk.FirstVariant.GetReader();
                    var l_ReaderData = l_IncomingDataReader.ReadBytes((int)l_IncomingDataReader.Length);
                    var l_Reader = new BinaryReader(new MemoryStream(l_ReaderData));

#if DEBUG
                    // If we are debugging, dump the raw format out to file
                    File.WriteAllBytes($"{l_MeshLayout.ShortName.Object}_subset{l_SubsetIndex}.bin", l_ReaderData);
#endif

                    // Read out all of the vertex data, it will be described by the GeometryDesc
                    var l_VertexDataList = new List<byte[]>();
                    for (var l_VertexIndex = 0; l_VertexIndex < l_Subset.VertexCount; ++l_VertexIndex)
                        l_VertexDataList.Add(l_Reader.ReadBytes(l_VertexStride));

                    // Hold all of the vertex information
                    var l_VertexList = new List<Dictionary<VertexElementUsage, dynamic>>();
                    var l_PrimitiveList = new List<(ushort, ushort, ushort)>();

                    // Iterate through each vertex data (sizeof(VertexData) == Stride)
                    foreach (var l_VertexData in l_VertexDataList)
                    {
                        // Create a new reader to the vertex data specifically
                        using var l_VertexReader = new BinaryReader(new MemoryStream(l_VertexData));

                        // This dictionary is how we will parse each element from the vertex data
                        var l_Dict = new Dictionary<VertexElementUsage, dynamic>();
                        foreach (var l_Element in l_GeometryDesc.Elements)
                        {
                            // Iterate each element and check the format and set to the usage
                            // There should not be more than one of the same kind of usage here
                            switch (l_Element.Format)
                            {
                                case VertexElementFormat.VertexElementFormat_None:
                                    break;

                                    // Halfs
                                case VertexElementFormat.VertexElementFormat_Half:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = RimeMath.HalfToFloat(l_VertexReader.ReadUInt16());
                                    break;
                                case VertexElementFormat.VertexElementFormat_Half2:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()));
                                    break;
                                case VertexElementFormat.VertexElementFormat_Half3:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()));
                                    break;
                                case VertexElementFormat.VertexElementFormat_Half4:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()), RimeMath.HalfToFloat(l_VertexReader.ReadUInt16()));
                                    break;
                                case VertexElementFormat.VertexElementFormat_UByte4:
                                case VertexElementFormat.VertexElementFormat_UByte4N:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = l_VertexReader.ReadBytes(4);
                                    break;

                                    // Floats
                                case VertexElementFormat.VertexElementFormat_Float:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = l_VertexReader.ReadSingle();
                                    break;
                                case VertexElementFormat.VertexElementFormat_Float2:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle());
                                    break;
                                case VertexElementFormat.VertexElementFormat_Float3:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle());
                                    break;
                                case VertexElementFormat.VertexElementFormat_Float4:
                                    l_VertexReader.BaseStream.Seek(l_Element.Offset, SeekOrigin.Begin);
                                    l_Dict[l_Element.Usage] = (l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle(), l_VertexReader.ReadSingle());
                                    break;
                                default:
                                    Console.WriteLine($"Unknown Format usage {l_Element.Format}");
                                    throw new Exception($"Unknown format usage {l_Element.Format}");
                            }
                        }

                        l_VertexList.Add(l_Dict);
                    }

                    // Read out all of the primitives
                    l_Reader.BaseStream.Seek(l_MeshLayout.VertexDataSize, SeekOrigin.Begin);

                    switch (l_PrimitiveType)
                    {
                        case RimeLib.Mesh.Frostbite.PrimitiveType.PrimitiveType_TriangleList:
                            for (var l_PrimitiveIndex = 0; l_PrimitiveIndex < l_Subset.PrimitiveCount; ++l_PrimitiveIndex)
                                l_PrimitiveList.Add((l_Reader.ReadUInt16(), l_Reader.ReadUInt16(), l_Reader.ReadUInt16()));
                            break;
                        default:
                            Console.WriteLine($"primitive type {l_PrimitiveType} not implemented");
                            throw new NotImplementedException($"primitive type {l_PrimitiveType} not implemented");
                    }

                    

                    // Write out all of the information we have gathered so far
                    s_Writer.WriteLine($"# Subset Primitve Type: {l_Subset.PrimitiveType}");
                    s_Writer.WriteLine($"# Subset Primitive Count: {l_Subset.PrimitiveCount}");
                    s_Writer.WriteLine($"# Subset Vertex Count: {l_Subset.VertexCount}");

                    s_Writer.WriteLine($"g {l_MeshLayout.Name.Object}");
                    s_Writer.WriteLine($"usemtl {l_Subset.MaterialName.Object}");

                    foreach (var l_Vertex in l_VertexList)
                    {
                        foreach (VertexElementUsage l_Usage in Enum.GetValues(typeof(VertexElementUsage)))
                        {
                            if (!l_Vertex.TryGetValue(l_Usage, out dynamic l_OutData))
                                continue;

                            switch (l_Usage)
                            {
                                case VertexElementUsage.VertexElementUsage_Pos:
                                    s_Writer.WriteLine($"v {l_OutData.Item1} {l_OutData.Item2} {l_OutData.Item3}");
                                    break;
                                case VertexElementUsage.VertexElementUsage_Normal:
                                    s_Writer.WriteLine($"vn {l_OutData.Item1} {l_OutData.Item2} {l_OutData.Item3}");
                                    break;
                                case VertexElementUsage.VertexElementUsage_Tangent:
                                    s_Writer.WriteLine($"# Tangent: {l_OutData.Item1} {l_OutData.Item2} {l_OutData.Item3} {l_OutData.Item4}");
                                    break;
                                case VertexElementUsage.VertexElementUsage_BoneIndices:
                                    s_Writer.WriteLine($"# bone indicies: {BitConverter.ToString(l_OutData)}");
                                    break;
                                case VertexElementUsage.VertexElementUsage_Binormal:
                                    s_Writer.WriteLine($"# binormal: {l_OutData.Item1} {l_OutData.Item2} {l_OutData.Item3} {l_OutData.Item4}");
                                    break;
                                case VertexElementUsage.VertexElementUsage_BinormalSign:
                                    s_Writer.WriteLine($"# binormal sign: {l_OutData}");
                                    break;
                                case VertexElementUsage.VertexElementUsage_TexCoord0:
                                case VertexElementUsage.VertexElementUsage_TexCoord1:
                                case VertexElementUsage.VertexElementUsage_TexCoord2:
                                case VertexElementUsage.VertexElementUsage_TexCoord3:
                                case VertexElementUsage.VertexElementUsage_TexCoord4:
                                case VertexElementUsage.VertexElementUsage_TexCoord5:
                                case VertexElementUsage.VertexElementUsage_TexCoord6:
                                case VertexElementUsage.VertexElementUsage_TexCoord7:
                                    s_Writer.WriteLine($"vn {l_OutData.Item1} {l_OutData.Item2}");
                                    break;
                                case VertexElementUsage.VertexElementUsage_Color0:
                                case VertexElementUsage.VertexElementUsage_Color1:
                                    s_Writer.WriteLine($"# color {BitConverter.ToString(l_OutData)}");
                                    break;
                                case VertexElementUsage.VertexElementUsage_BoneWeights:
                                    s_Writer.WriteLine($"# bone weights {BitConverter.ToString(l_OutData)}");
                                    break;
                                case VertexElementUsage.VertexElementUsage_RadiosityTexCoord:
                                    s_Writer.WriteLine($"vn {l_OutData.Item1} {l_OutData.Item2}");
                                    break;
                                case VertexElementUsage.VertexElementUsage_SubMaterialIndex:
                                    s_Writer.WriteLine($"# sub-material index {BitConverter.ToString(l_OutData)}");
                                    break;
                                default:
                                    Console.WriteLine($"usage type {l_Usage} not implemented");
                                    throw new NotImplementedException($"usage type {l_Usage} not implemented");

                            }
                        }
                    }

                    foreach (var l_Index in l_PrimitiveList)
                        s_Writer.WriteLine($"f {l_Index.Item1 + 1} {l_Index.Item2 + 1} {l_Index.Item3 + 1}");

                    l_Reader.Close();
                }

                var s_ObjData = s_Writer.ToString();

                var s_OutputPath = Path.Join(p_Options.OutputPath, p_FilePath + $"lod{l_LodIndex}.obj").Normalize();
                File.WriteAllText(s_OutputPath, s_ObjData);

                s_CurrentLod++;
            }

            
        }
    }
}
