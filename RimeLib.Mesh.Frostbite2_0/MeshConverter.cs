using fb;
using RimeLib.Content.Mounting;
using RimeLib.Extensions;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Mesh.Frostbite;
using SharpGLTF.Schema2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RimeLib.Mesh.Frostbite2_0
{
    public class MeshConverter : IMeshConverter
    {
        /// <summary>
        /// This class holds mesh data being read in and is stored in our own format so we can streamline the exporting process.
        /// Credits: Ma_rv, IceBloc
        /// </summary>
        public sealed class InternalMesh
        {
            public string Name = "";
            public bool IsSkinned;
            public List<Vertex> Vertices = new();
            public List<(int A, int B, int C)> Faces = new();

            public InternalMesh() { }
        }

        /// <summary>
        /// Stores vertex attributes for each element.
        /// Credits: Ma_rv, IceBloc
        /// </summary>
        public struct Vertex
        {
            public float PositionX;
            public float PositionY;
            public float PositionZ;
            public float NormalX;
            public float NormalY;
            public float NormalZ;
            public float TexCoordX;
            public float TexCoordY;
            public float BoneIndexA;
            public float BoneIndexB;
            public float BoneIndexC;
            public float BoneIndexD;
            public float BoneWeightA;
            public float BoneWeightB;
            public float BoneWeightC;
            public float BoneWeightD;
        }

        public void ConvertToBlender(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public void ConvertToGltf(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public void ConvertToObj(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_Writer)
        {
            using var s_MeshReader = p_Resource.GetReader();
            var s_MeshData = s_MeshReader.ToArray();
            using var s_TempMeshReader = new RimeReader(new MemoryStream(s_MeshData));
            var s_MeshSet = new MeshSetLayout(s_TempMeshReader);

            var s_ConvertedMeshes = ConvertToInternal(s_MeshSet, p_Mounter);

            for (var l_MeshIndex = 0; l_MeshIndex < s_ConvertedMeshes.Count; ++l_MeshIndex)
                ExportOBJ(s_ConvertedMeshes.ElementAt(l_MeshIndex), p_Writer);
            
        }

        public void ConvertToText(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public EngineType[] GetSupportedEngines()
        {
            return new[] { EngineType.Frostbite2_0 };
        }


        internal static List<InternalMesh> ConvertToInternal(MeshSetLayout p_MeshSet, IEngineMounter p_Mounter)
        {
            List<InternalMesh> s_MeshList = new();

            // For each LOD.
            for (var i = 0; i < p_MeshSet.LodCount; i++)
            {
                var s_LodPtr = p_MeshSet.Lods[i];
                var s_Lod = s_LodPtr.Object;
                var s_LodChunkId = s_Lod.DataChunkId;

                if (!p_Mounter.TryGetChunk(s_LodChunkId, out var s_Chunk))
                    return new();

                using var s_TempLodReader = s_Chunk.FirstVariant.GetReader();
                var s_LodData = s_TempLodReader.ToArray();
                using var s_LodReader = new RimeReader(new MemoryStream(s_LodData));
                s_LodReader.Endianness = Endianness.LittleEndian;

                // For each MeshSubset.
                for (var l_SubsetIndex = 0; l_SubsetIndex < s_Lod.Subsets.Get.Length; l_SubsetIndex++)
                {
                    var l_Subset = s_Lod.Subsets.Get[l_SubsetIndex];
                    InternalMesh s_Mesh = new()
                    {
                        Name = l_Subset.MaterialName.Object + "_LOD" + i,
                        IsSkinned = false // TODO
                    };

                    var l_IndexStartOffset = s_Lod.VertexDataSize;

                    // Start reading vertices.
                    s_LodReader.Seek(l_Subset.VertexOffset, SeekOrigin.Begin);

                    for (int l_VertexIndex = 0; l_VertexIndex < l_Subset.VertexCount; l_VertexIndex++)
                    {
                        Vertex l_Vertex = new();

                        var l_PosElement = l_Subset.GeometryDeclarationDesc.GetByUsage(VertexElementUsage.VertexElementUsage_Pos);
                        if (l_PosElement is null)
                            throw new Exception("Geometry declaration descriptor position is missing.");

                        var l_NorElement =
                            l_Subset.GeometryDeclarationDesc.GetByUsage(VertexElementUsage.VertexElementUsage_Normal);
                        var l_UV0Element =
                            l_Subset.GeometryDeclarationDesc.GetByUsage(VertexElementUsage.VertexElementUsage_TexCoord0);

                        var l_Position = l_PosElement.Read(s_LodReader, l_Subset.VertexStride);
                        var l_Normals = l_NorElement == null
                            ? new Vector4()
                            : l_NorElement.Read(s_LodReader, l_Subset.VertexStride);
                        var texcoord = l_UV0Element == null
                            ? new Vector4()
                            : l_UV0Element.Read(s_LodReader, l_Subset.VertexStride);

                        // We're done reading the current vertex, move up the stream.
                        s_LodReader.Seek(l_Subset.VertexStride, SeekOrigin.Current);

                        l_Vertex.PositionX = l_Position.X;
                        l_Vertex.PositionY = l_Position.Y;
                        l_Vertex.PositionZ = l_Position.Z;
                        l_Vertex.NormalX = l_Normals.X;
                        l_Vertex.NormalY = l_Normals.Y;
                        l_Vertex.NormalZ = l_Normals.Z;
                        l_Vertex.TexCoordX = texcoord.X;
                        l_Vertex.TexCoordY = 1.0f - texcoord.Y;

                        s_Mesh.Vertices.Add(l_Vertex);
                    }

                    // Read face indices.
                    s_LodReader.Seek(l_IndexStartOffset + (l_Subset.StartIndex * 2), SeekOrigin.Begin);

                    for (int l_PrimitiveIndex = 0; l_PrimitiveIndex < l_Subset.PrimitiveCount; l_PrimitiveIndex++)
                    {
                        int l_FaceX = s_LodReader.ReadUInt16();
                        int l_FaceY = s_LodReader.ReadUInt16();
                        int l_FaceZ = s_LodReader.ReadUInt16();

                        s_Mesh.Faces.Add((l_FaceX, l_FaceY, l_FaceZ));
                    }

                    s_MeshList.Add(s_Mesh);
                }
            }

            return s_MeshList;
        }

        internal static void ExportOBJ(InternalMesh p_Mesh, RimeWriter p_Writer)
        {
            // using TextWriter s_Writer = new StreamWriter(File.OpenWrite($"{p_DestinationPath}.obj"));

            // Write object name.
            p_Writer.Write($"o {p_Mesh.Name}");

            // Loop through each vertex.
            for (int i = 0; i < p_Mesh.Vertices.Count; i++)
            {
                // Write the position data.
                p_Writer.Write($"v {p_Mesh.Vertices[i].PositionX} {p_Mesh.Vertices[i].PositionY} {p_Mesh.Vertices[i].PositionZ}");
                // Write the normal data.
                p_Writer.Write($"vn {p_Mesh.Vertices[i].NormalX} {p_Mesh.Vertices[i].NormalY} {p_Mesh.Vertices[i].NormalZ}");
                // Write the UV data.
                p_Writer.Write($"vt {p_Mesh.Vertices[i].TexCoordX} {p_Mesh.Vertices[i].TexCoordY}");
            }
            // Loop through each face index.
            for (int i = 0; i < p_Mesh.Faces.Count; i++)
            {
                // Get the current face (for readability).
                var f = p_Mesh.Faces[i];
                // Write three face indices (Format: pos/norm/uv).
                p_Writer.Write($"f {f.A + 1}/{f.A + 1}/{f.A + 1} {f.B + 1}/{f.B + 1}/{f.B + 1} {f.C + 1}/{f.C + 1}/{f.C + 1}");
            }
        }
    }
}
