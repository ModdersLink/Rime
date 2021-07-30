using System.IO;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite
{
    /// <summary>
    /// Implementation of fb::MeshSubset
    /// Sizeof MeshSubset = 148 or 0x94
    /// </summary>
    public class MeshSubset : IFbSerializable
    {
        /// <summary>
        /// Geometry declarations
        /// </summary>
        public ulong GeometryDeclarations { get; set; } // RelocPtr

        /// <summary>
        /// Material name
        /// </summary>
        public RelocPtr<string> MaterialName { get; set; } = new RelocPtr<string>(); // RelocPtr

        /// <summary>
        /// Material index
        /// </summary>
        public uint MaterialIndex { get; set; }

        /// <summary>
        /// Primitive (face) count
        /// </summary>
        public uint PrimitiveCount { get; set; }

        /// <summary>
        /// Start index
        /// </summary>
        public uint StartIndex { get; set; }

        /// <summary>
        /// Vertex offset
        /// </summary>
        public uint VertexOffset { get; set; }

        /// <summary>
        /// Verticies count
        /// </summary>
        public uint VertexCount { get; set; }

        /// <summary>
        /// Stride of vertices (how many bits per "chunk")
        /// </summary>
        public byte VertexStride { get; set; }

        /// <summary>
        /// Primitive type
        /// </summary>
        public PrimitiveType PrimitiveType { get; set; }

        /// <summary>
        /// Bones per vertex
        /// </summary>
        public byte BonesPerVertex { get; set; }

        /// <summary>
        /// Bone count
        /// </summary>
        public byte BoneCount { get; set; }

        /// <summary>
        /// Bone indicies
        /// </summary>
        public RelocPtr<ushort> BoneIndices { get; set; } = new RelocPtr<ushort>(); // RelocPtr

        /// <summary>
        /// Geometry declaration descriptor
        /// </summary>
        public GeometryDeclarationDesc GeometryDeclarationDesc { get; set; } = new GeometryDeclarationDesc();

        /// <summary>
        /// Texture coordinate ratios
        /// </summary>
        public Array<float> TexCoordRatios { get; set; } = new Array<float>(); // float[6]

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeshSubset()
        {

        }

        /// <summary>
        /// Constructor that reads a mesh subset from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a MeshSubset</param>
        public MeshSubset(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Writes a meshsubset to an opened writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position of a MeshSubset</param>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(GeometryDeclarations); // 0
            p_Writer.Write(MaterialName.BaseAddress);
            p_Writer.Write(MaterialIndex);
            p_Writer.Write(PrimitiveCount);
            p_Writer.Write(StartIndex);
            p_Writer.Write(VertexOffset);
            p_Writer.Write(VertexCount);
            p_Writer.Write(VertexStride);
            p_Writer.Write((byte)PrimitiveType);
            p_Writer.Write(BonesPerVertex);
            p_Writer.Write(BoneCount);
            p_Writer.Write(BoneIndices.BaseAddress);

            if (!GeometryDeclarationDesc.Serialize(p_Writer))
                return false;

            for (var i = 0; i < 6; ++i)
                p_Writer.Write(TexCoordRatios[i]);

            return true;
        }

        public bool Serialize(out byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            GeometryDeclarations = p_Reader.ReadUInt64();
            MaterialName = new RelocPtr<string>(p_Reader);
            MaterialIndex = p_Reader.ReadUInt32();
            PrimitiveCount = p_Reader.ReadUInt32();
            StartIndex = p_Reader.ReadUInt32();
            VertexOffset = p_Reader.ReadUInt32();
            VertexCount = p_Reader.ReadUInt32();
            VertexStride = p_Reader.ReadUByte();
            PrimitiveType = (PrimitiveType)p_Reader.ReadUByte();
            BonesPerVertex = p_Reader.ReadUByte();
            BoneCount = p_Reader.ReadUByte();
            BoneIndices = new RelocPtr<ushort>(p_Reader);
            GeometryDeclarationDesc = new GeometryDeclarationDesc(p_Reader);

            for (var i = 0; i < 6; ++i)
                TexCoordRatios.Add(p_Reader.ReadSingle());
        }

        public void Deserialize(byte[] p_Data)
        {
            Deserialize(new RimeReader(new MemoryStream(p_Data)));
        }
    }
}
