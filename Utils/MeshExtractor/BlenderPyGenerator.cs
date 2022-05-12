using fb;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Math;
using RimeLib.Mesh.Frostbite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VertexElementFormat = RimeLib.Mesh.Frostbite.VertexElementFormat;
using VertexElementUsage = RimeLib.Mesh.Frostbite.VertexElementUsage;

namespace MeshExtractor
{
    internal class BlenderPyGenerator
    {
        internal class BlenderObject
        {
            public string Name { get; set; }
            public int LodIndex { get; set; }
            public MeshSubsetCategory SubsetCategory { get; set; }
            public List<BlenderObject> Subets { get; protected set; } = new List<BlenderObject>();
        }
        private List<Vec3> m_Verticies = new List<Vec3>();
        private TextWriter m_Writer = new StreamWriter(new MemoryStream());

        private readonly IEngineMounter m_Mounter;
        private readonly MeshSetLayout m_Layout;

        internal BlenderPyGenerator(IEngineMounter p_Mounter, MeshSetLayout p_Layout)
        {
            m_Mounter = p_Mounter;
            m_Layout = p_Layout;
        }

        public void ParseMesh()
        {
            var s_MeshList = new List<BlenderObject>();

            for (var s_LodIndex = 0; s_LodIndex < m_Layout.LodCount; s_LodIndex++)
            {
                var s_Lod = m_Layout.Lods[s_LodIndex].Object;

                ParseLod(s_Lod);
                
                
            }
        }

        public List<Dictionary<VertexElementUsage, dynamic>> ParseVerts(List<byte[]> p_VertexData, MeshSubset p_Subset)
        {
            var s_GeometryDesc = p_Subset.GeometryDeclarationDesc;


            var s_VerticesList = new List<Dictionary<VertexElementUsage, dynamic>>();
            

            // iterate over each vertex data
            for (var s_Index = 0; s_Index < p_VertexData.Count; ++s_Index)
            {
                var s_Dict = new Dictionary<VertexElementUsage, dynamic>();

                using var s_VertexReader = new RimeReader(new MemoryStream(p_VertexData[s_Index]));

                foreach (var s_Element in s_GeometryDesc.Elements)
                {
                    s_VertexReader.Seek(s_Element.Offset, SeekOrigin.Begin);

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

                s_VerticesList.Add(s_Dict);
            }

            return s_VerticesList;
        }

        public List<Dictionary<VertexElementUsage, dynamic>> ParseSubset(RimeReader p_VertexReader, MeshSubset p_Subset)
        {
            var s_DataList = new List<byte[]>();

            var s_Stride = p_Subset.VertexStride;

            // Read out all of the vertex data
            for (var s_Index = 0; s_Index < p_Subset.VertexCount; ++s_Index)
                s_DataList.Add(p_VertexReader.ReadBytes(s_Stride));

            if (s_DataList.Count != p_Subset.VertexCount)
                throw new Exception();

            return ParseVerts(s_DataList, p_Subset);
        }

        public Dictionary<MeshSubsetCategory, List<Dictionary<VertexElementUsage, dynamic>>> ParseCategories(List<byte[]> p_CategorySubsetIndices, List<Dictionary<VertexElementUsage, dynamic>> p_Verts)
        {
            var s_Categories = new Dictionary<MeshSubsetCategory, List<Dictionary<VertexElementUsage, dynamic>>>();

            // Iterate all of the categories
            for (var s_CategoryIndex = 0; s_CategoryIndex < p_CategorySubsetIndices.Count; ++s_CategoryIndex)
            {
                // Get the list of subsets per-category
                var s_SubsetIndicies = p_CategorySubsetIndices[s_CategoryIndex];

                // Hold a list of subsets + parsed verts
                var s_SubsetPairList = new List<Dictionary<VertexElementUsage, dynamic>>();
                foreach (var s_SubsetIndex in s_SubsetIndicies)
                {
                    // Example: Opaque = 0x1, 0x2 (subset index)
                    var s_SubsetPair = p_Verts[s_SubsetIndex];

                    s_SubsetPairList.Add(s_SubsetPair);
                }

                // Add to the dictionary for subset category, (subsets + vertex data)[]
                s_Categories.Add((MeshSubsetCategory)s_CategoryIndex, s_SubsetPairList);
            }

            return s_Categories;
        }

        public void ParseLod(MeshLayout p_Lod)
        {
            // Get the lods name
            var s_Name = p_Lod.Name.Object;

            var s_LodChunkId = p_Lod.DataChunkId;
            if (!m_Mounter.TryGetChunk(s_LodChunkId, out IMountedObject<IChunkVariant> p_Chunk))
                return; // Could not find any data

            using var s_LodReader = p_Chunk.FirstVariant.GetReader();

            var s_VertexData = s_LodReader.ReadBytes((int)p_Lod.VertexDataSize);
            var s_PrimitiveData = s_LodReader.ReadBytes((int)p_Lod.IndexDataSize);

            using var s_VertexReader = new RimeReader(new MemoryStream(s_VertexData));
            using var s_IndexReader = new RimeReader(new MemoryStream(s_PrimitiveData));

            //// Iterate through each subset in the lod
            //var s_SubsetList = new List<BlenderObject>();
            //var s_Subsets = p_Lod.Subsets;
            //for (var s_SubsetIndex = 0; s_SubsetIndex < s_Subsets.Count; ++s_SubsetIndex)
            //{
            //    // Get the subset
            //    var s_Subset = s_Subsets.Get[s_SubsetIndex];

            //    var s_VertsList = ParseSubset(s_VertexReader, s_Subset);

            //    //var s_Categories = new Dictionary<MeshSubsetCategory, List<Dictionary<VertexElementUsage, dynamic>>>();

            //    // Now order the mesh subset category + (subset + parsed vert data)
            //    var s_Categories = new Dictionary<MeshSubsetCategory, List<Dictionary<VertexElementUsage, dynamic>>>();
            //    for (var s_CategoryIndex = 0; s_CategoryIndex < p_Lod.CategorySubsetIndices.Length; ++s_CategoryIndex)
            //    {
            //        // Get the list of subsets per-category
            //        var s_SubsetIndicies = p_Lod.CategorySubsetIndices[s_CategoryIndex].Get;

            //        // Hold a list of subsets + parsed verts
            //        var s_SubsetPairList = new List<Dictionary<VertexElementUsage, dynamic>>();
            //        foreach (var s_SubsetIndexX in s_SubsetIndicies)
            //        {
            //            // Example: Opaque = 0x1, 0x2 (subset index)
            //            var s_SubsetPair = s_VertsList[s_SubsetIndexX];

            //            s_SubsetPairList.Add(s_SubsetPair);
            //        }

            //        // Add to the dictionary for subset category, (subsets + vertex data)[]
            //        s_Categories.Add((MeshSubsetCategory)s_CategoryIndex, s_SubsetPairList);
            //    }

            //    for (var s_CategoryIndex = 0; s_CategoryIndex < s_Categories.Count; ++s_CategoryIndex)
            //    {
            //        if (!s_Categories.TryGetValue((MeshSubsetCategory)s_CategoryIndex, out var p_Ret))
            //            throw new InvalidDataException();

            //        foreach (var s_SubsetPair in p_Ret)
            //        {
            //            // Get the subset
            //            var s_SubsetKey = p_Lod;
            //            var s_SubsetValue = s_SubsetPair;

            //            // Calculate the start offset in the index buffer
            //            var s_SubsetStartIndex = s_SubsetKey.StartIndex;

            //            // Validate the start offset
            //            var s_SubsetStartOffset = Marshal.SizeOf<ushort>() * s_SubsetStartIndex;
            //            if (s_SubsetStartOffset >= s_IndexReader.Length)
            //                throw new Exception("subset start offset");

            //            // Calculate and verify the end offset (that it's in-bounds)
            //            var s_SubsetEndOffset = (Marshal.SizeOf<ushort>() * 3) * s_SubsetKey.PrimitiveCount; // * 3 for X, Y, Z
            //            if (s_SubsetEndOffset > s_IndexReader.Length)
            //                throw new Exception("subset end offset");

            //            // Hold our index list
            //            var s_PrimitiveList = new List<(ushort, ushort, ushort)>();
            //            switch (s_SubsetKey.PrimitiveType)
            //            {
            //                // If we are parsing a triangle list, then read out the X, Y, Z indices
            //                case RimeLib.Mesh.Frostbite.PrimitiveType.PrimitiveType_TriangleList:
            //                    s_IndexReader.Seek(s_SubsetStartOffset, SeekOrigin.Begin);
            //                    for (var s_PrimitiveIndex = 0; s_PrimitiveIndex < s_SubsetKey.PrimitiveCount; ++s_PrimitiveIndex)
            //                        s_PrimitiveList.Add((s_IndexReader.ReadUInt16(), s_IndexReader.ReadUInt16(), s_IndexReader.ReadUInt16()));
            //                    break;
            //                default:
            //                    throw new Exception("unimplemented primitive type");
            //            }

            //            // Continue with creating the gltf format
            //            var s_RandomColor = new Vector4((float)s_Random.NextDouble(), (float)s_Random.NextDouble(), (float)s_Random.NextDouble(), 1.0f);
            //            var s_DebugMaterial = new MaterialBuilder(s_SubsetKey.MaterialName.Object ?? "")
            //                .WithMetallicRoughnessShader().WithChannelParam(KnownChannel.BaseColor, s_RandomColor);

            //            // Create a new GLTF mesh
            //            var s_Mesh = new MeshBuilder<VertexPosition, VertexTexture1>($"{MeshSubsetCategory.Opaque}_{s_Lod.ShortName.Object}");
            //            var s_Primitive = s_Mesh.UsePrimitive(s_DebugMaterial);

            //            // Iterate through all primitives
            //            for (var s_PrimitiveIndex = 0; s_PrimitiveIndex < s_PrimitiveList.Count; ++s_PrimitiveIndex)
            //            {
            //                var s_PrimitiveIndices = s_PrimitiveList[s_PrimitiveIndex];

            //                var s_FirstIndex = s_PrimitiveIndices.Item1;
            //                if (s_FirstIndex > s_SubsetValue.Count)
            //                    throw new Exception("first index oob");

            //                var s_FirstVertex = s_SubsetValue[s_FirstIndex];
            //                if (!s_FirstVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic s_FirstVertexPos))
            //                    continue;


            //                var s_SecondIndex = s_PrimitiveIndices.Item2;
            //                if (s_SecondIndex > s_SubsetValue.Count)
            //                    throw new Exception("second index oob");

            //                var s_SecondVertex = s_SubsetValue[s_SecondIndex];
            //                if (!s_SecondVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic s_SecondVertexPos))
            //                    continue;

            //                var s_ThirdIndex = s_PrimitiveIndices.Item3;
            //                if (s_ThirdIndex > s_SubsetValue.Count)
            //                    throw new Exception("third index oob");

            //                var s_ThirdVertex = s_SubsetValue[s_ThirdIndex];
            //                if (!s_ThirdVertex.TryGetValue(VertexElementUsage.VertexElementUsage_Pos, out dynamic s_ThirdVertexPos))
            //                    continue;


            //                var s_FirstPosition = new VertexPosition(s_FirstVertexPos.Item1, s_FirstVertexPos.Item2, s_FirstVertexPos.Item3);
            //                var s_SecondPosition = new VertexPosition(s_SecondVertexPos.Item1, s_SecondVertexPos.Item2, s_SecondVertexPos.Item3);
            //                var s_ThirdPosition = new VertexPosition(s_ThirdVertexPos.Item1, s_ThirdVertexPos.Item2, s_ThirdVertexPos.Item3);


            //                if (s_FirstVertex.TryGetValue(VertexElementUsage.VertexElementUsage_TexCoord0, out dynamic s_FirstVertexTexture) &&
            //                    s_SecondVertex.TryGetValue(VertexElementUsage.VertexElementUsage_TexCoord0, out dynamic s_SecondVertexTexture) &&
            //                    s_ThirdVertex.TryGetValue(VertexElementUsage.VertexElementUsage_TexCoord0, out dynamic s_ThirdVertexTexture))
            //                {
            //                    var s_FirstTexture = new VertexTexture1(new System.Numerics.Vector2(s_FirstVertexTexture.Item1, s_FirstVertexTexture.Item2));
            //                    var s_SecondTexture = new VertexTexture1(new System.Numerics.Vector2(s_SecondVertexTexture.Item1, s_SecondVertexTexture.Item2));
            //                    var s_ThirdTexture = new VertexTexture1(new System.Numerics.Vector2(s_ThirdVertexTexture.Item1, s_ThirdVertexTexture.Item2));

            //                    s_Primitive.AddTriangle((s_FirstPosition, s_FirstTexture), (s_SecondPosition, s_SecondTexture), (s_ThirdPosition, s_ThirdTexture));
            //                }
            //                else
            //                {
            //                    //Console.WriteLine("No texcoords");
            //                    s_Primitive.AddTriangle(s_FirstPosition, s_SecondPosition, s_ThirdPosition);
            //                }
            //            }


            //        }
            //    }
            //}

            //var s_BlenderObject = new BlenderObject
            //{
            //    LodIndex = s_LodIndex,
            //    Name = s_Name
            //};
        }

        static string WritePrimtiveList(List<(ushort, ushort, ushort)> p_PrimitiveList)
        {
            StringBuilder s_Builder = new StringBuilder();

            for (int i = 0; i < p_PrimitiveList.Count; i++)
                s_Builder.AppendLine($"{p_PrimitiveList[i].ToString().Replace('(', '[').Replace(')', ']')}{(i < p_PrimitiveList.Count ? "," : "")}");

            return s_Builder.ToString();
        }

        static string GenerateBlenderScript(string p_Name, List<(ushort, ushort, ushort)> p_PrimitiveList)
        {
            var p_Primtives = new List<string>();
            var p_Vertices = new List<string>();
            var s_Format =
                $@"
                # Created by Rime Frostbite Tools - {DateTime.Now} - {p_Name}
                #
                # Mesh Information:
                #   Name: {p_Name}
                #   VertexCount: {p_Vertices}
                #   PrimitiveCount: {p_Primtives.Count}
                #   Exported by Rime (c) kiwidoggie productions 2022, models copyright respective IP owners, NOT for redistribution

                import bpy

                # Verticies
                #
                vertices = [
                    (0, 0, 0),
                ]

                # Edges (unused)
                #
                edges = [ ]

                # Faces
                #
                faces = [ { WritePrimtiveList(p_PrimitiveList) } ]

                # Create a new mesh
                {p_Name}_mesh = bpy.data.meshes.new('{p_Name}_mesh')

                # Assign our data from python
                {p_Name}_mesh.from_pydata(vertices, edges, faces)

                # Update the mesh
                {p_Name}_mesh.update()

                # Create a new blender object for this mesh
                {p_Name}_object = bpy.data.objects.new('{p_Name}_object', {p_Name}_mesh)

                # Create a new scene collection, this can be an entire 'set' containing all subsets
                {p_Name}_collection = bpy.data.collections.new('{p_Name}_collection')

                # Link the collection
                bpy.context.scene.collection.children.link({p_Name}_collection)

                # Link the object to this collection
                NAME_collection.objects.link({p_Name}_object)
                ";

            return s_Format;
        }
    }
}
