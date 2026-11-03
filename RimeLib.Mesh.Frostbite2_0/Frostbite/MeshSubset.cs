using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite
{
    /// <summary>
    /// A part of a mesh LOD drawn with one material (fb::MeshSubset), 0x94 bytes. A later engine
    /// appends fields of its own after <see cref="TexCoordRatios"/>.
    /// </summary>
    public class MeshSubset : IFbSerializable
    {
        public const int Frostbite2Size = 0x94;

        /// <summary>m_geometryDeclarations, a pointer the engine fills at runtime.</summary>
        public ulong GeometryDeclarations { get; set; }

        public RelocPtr<string> MaterialName { get; set; } = new();
        public uint MaterialIndex { get; set; }
        public uint PrimitiveCount { get; set; }
        public uint StartIndex { get; set; }
        public uint VertexOffset { get; set; }
        public uint VertexCount { get; set; }
        public byte VertexStride { get; set; }
        public PrimitiveType PrimitiveType { get; set; }
        public byte BonesPerVertex { get; set; }
        public byte BoneCount { get; set; }
        public RelocPtrArray<ushort> BoneIndices { get; set; } = new();
        public GeometryDeclarationDesc GeometryDeclarationDesc { get; set; } = new();

        /// <summary>Six ratios, one per texture coordinate set.</summary>
        public Array<float> TexCoordRatios { get; set; } = new();

        /// <summary>The bytes a subset takes in this engine's MeshSet.</summary>
        public virtual int Size => Frostbite2Size;

        public MeshSubset()
        {
        }

        public MeshSubset(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
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
            BoneIndices = new RelocPtrArray<ushort>(p_Reader, BoneCount);
            GeometryDeclarationDesc = new GeometryDeclarationDesc(p_Reader);

            TexCoordRatios = new Array<float>();
            for (var i = 0; i < 6; ++i)
                TexCoordRatios.Add(p_Reader.ReadSingle());

            DeserializeTail(p_Reader);
        }

        /// <summary>The fields a later engine appends.</summary>
        protected virtual void DeserializeTail(RimeReader p_Reader)
        {
        }

        protected virtual void SerializeTail(RimeWriter p_Writer)
        {
        }

        /// <summary>Writes the subset; its pointers are the slots, whose targets the MeshSet places.</summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(GeometryDeclarations);
            MaterialName.Serialize(p_Writer);
            p_Writer.Write(MaterialIndex);
            p_Writer.Write(PrimitiveCount);
            p_Writer.Write(StartIndex);
            p_Writer.Write(VertexOffset);
            p_Writer.Write(VertexCount);
            p_Writer.Write(VertexStride);
            p_Writer.Write((byte)PrimitiveType);
            p_Writer.Write(BonesPerVertex);
            p_Writer.Write(BoneCount);
            BoneIndices.Serialize(p_Writer);
            GeometryDeclarationDesc.Serialize(p_Writer);

            foreach (var s_Ratio in TexCoordRatios.AsList)
                p_Writer.Write(s_Ratio);

            SerializeTail(p_Writer);
            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data) =>
            throw new NotSupportedException("A mesh subset is written as part of its MeshSet.");

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }
    }
}
