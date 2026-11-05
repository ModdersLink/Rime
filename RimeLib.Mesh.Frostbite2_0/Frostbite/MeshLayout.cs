using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using Matrix4x4 = System.Numerics.Matrix4x4;
using Vector4 = System.Numerics.Vector4;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite
{
    /// <summary>
    /// A mesh LOD (fb::MeshLayout). It ends in a bone or part count and, by mesh type, the arrays
    /// that count sizes; the layout is padded to 16 bytes.
    /// </summary>
    public class MeshLayout : IFbSerializable
    {
        /// <summary>The bytes a part mask takes per subset.</summary>
        public const int PartMaskSize = 24;

        public MeshType Type { get; set; }
        public RelocArray<MeshSubset> Subsets { get; set; } = new();
        public RelocArray<byte>[] CategorySubsetIndices { get; set; } = Array.Empty<RelocArray<byte>>();
        public MeshLayoutFlags Flags { get; set; }
        public IndexBufferFormat IndexBufferFormat { get; set; }
        public uint IndexDataSize { get; set; }
        public uint VertexDataSize { get; set; }
        public uint EdgePartitionBufferSize { get; set; }
        public GUID DataChunkId { get; set; } = GUID.Empty;
        public uint AuxVertexIndexDataOffset { get; set; }
        public RelocPtr<byte> EmbeddedEdgeData { get; set; } = new();
        public RelocPtr<string> ShaderDebugName { get; set; } = new();
        public RelocPtr<string> Name { get; set; } = new();
        public RelocPtr<string> ShortName { get; set; } = new();
        public uint NameHash { get; set; }

        /// <summary>m_data, a pointer the engine fills at runtime.</summary>
        public ulong Data { get; set; }

        /// <summary>m_boneCount (skinned) or m_partCount (composite).</summary>
        public uint BoneOrPartCount { get; set; }

        public RelocPtrArray<uint> BoneIndexArray { get; set; } = new();
        public RelocPtrArray<uint> BoneShortNameArray { get; set; } = new();

        /// <summary>Two per part: min and max.</summary>
        public RelocPtrArray<Vector4> PartBoundingBoxes { get; set; } = new();

        public RelocPtrArray<Matrix4x4> PartTransforms { get; set; } = new();

        /// <summary><see cref="PartMaskSize"/> bytes per subset.</summary>
        public RelocPtrArray<byte> SubsetPartIndices { get; set; } = new();

        /// <summary>The bytes a later engine adds after the mesh type.</summary>
        protected virtual int TypeExtraSize => 0;

        /// <summary>The bytes the layout takes: its fields, padded to 16.</summary>
        public int Size
        {
            get
            {
                var s_Arrays = Type switch
                {
                    MeshType.MeshType_Rigid => 0,
                    MeshType.MeshType_Skinned => 16,
                    MeshType.MeshType_Composite => 24,
                    _ => throw new InvalidDataException($"unknown mesh type {Type}"),
                };
                return (152 + TypeExtraSize + s_Arrays + 15) & ~15;
            }
        }

        public MeshLayout()
        {
        }

        public MeshLayout(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>The fields a later engine adds after the mesh type.</summary>
        protected virtual void DeserializeAfterType(RimeReader p_Reader)
        {
        }

        protected virtual void SerializeAfterType(RimeWriter p_Writer)
        {
        }

        /// <summary>A subset of this engine's layout.</summary>
        protected virtual RelocArray<MeshSubset> ReadSubsets(RimeReader p_Reader) => new(p_Reader);

        public void Deserialize(RimeReader p_Reader)
        {
            Type = (MeshType)p_Reader.ReadUInt32();
            DeserializeAfterType(p_Reader);
            Subsets = ReadSubsets(p_Reader);

            CategorySubsetIndices = new RelocArray<byte>[(int)MeshSubsetCategory.Count];
            for (var i = 0; i < CategorySubsetIndices.Length; ++i)
                CategorySubsetIndices[i] = new RelocArray<byte>(p_Reader);

            Flags = (MeshLayoutFlags)p_Reader.ReadUInt32();
            IndexBufferFormat = (IndexBufferFormat)p_Reader.ReadUInt32();
            IndexDataSize = p_Reader.ReadUInt32();
            VertexDataSize = p_Reader.ReadUInt32();
            EdgePartitionBufferSize = p_Reader.ReadUInt32();
            DataChunkId = new GUID(p_Reader);
            AuxVertexIndexDataOffset = p_Reader.ReadUInt32();
            EmbeddedEdgeData = new RelocPtr<byte>(p_Reader);
            ShaderDebugName = new RelocPtr<string>(p_Reader);
            Name = new RelocPtr<string>(p_Reader);
            ShortName = new RelocPtr<string>(p_Reader);
            NameHash = p_Reader.ReadUInt32();
            Data = p_Reader.ReadUInt64();
            BoneOrPartCount = p_Reader.ReadUInt32();

            switch (Type)
            {
                case MeshType.MeshType_Skinned:
                    BoneIndexArray = new RelocPtrArray<uint>(p_Reader, BoneOrPartCount);
                    BoneShortNameArray = new RelocPtrArray<uint>(p_Reader, BoneOrPartCount);
                    break;
                case MeshType.MeshType_Composite:
                    PartBoundingBoxes = new RelocPtrArray<Vector4>(p_Reader, 2 * BoneOrPartCount);
                    PartTransforms = new RelocPtrArray<Matrix4x4>(p_Reader, BoneOrPartCount);
                    SubsetPartIndices = new RelocPtrArray<byte>(p_Reader, (uint)(PartMaskSize * Subsets.Count));
                    break;
            }
        }

        /// <summary>Writes the layout, padded to <see cref="Size"/>; the MeshSet places what its pointers point at.</summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            var s_Start = p_Writer.Position;
            p_Writer.Write((uint)Type);
            SerializeAfterType(p_Writer);
            Subsets.Serialize(p_Writer);
            foreach (var s_Indices in CategorySubsetIndices)
                s_Indices.Serialize(p_Writer);

            p_Writer.Write((uint)Flags);
            p_Writer.Write((uint)IndexBufferFormat);
            p_Writer.Write(IndexDataSize);
            p_Writer.Write(VertexDataSize);
            p_Writer.Write(EdgePartitionBufferSize);
            DataChunkId.Serialize(p_Writer);
            p_Writer.Write(AuxVertexIndexDataOffset);
            EmbeddedEdgeData.Serialize(p_Writer);
            ShaderDebugName.Serialize(p_Writer);
            Name.Serialize(p_Writer);
            ShortName.Serialize(p_Writer);
            p_Writer.Write(NameHash);
            p_Writer.Write(Data);
            p_Writer.Write(BoneOrPartCount);

            switch (Type)
            {
                case MeshType.MeshType_Skinned:
                    BoneIndexArray.Serialize(p_Writer);
                    BoneShortNameArray.Serialize(p_Writer);
                    break;
                case MeshType.MeshType_Composite:
                    PartBoundingBoxes.Serialize(p_Writer);
                    PartTransforms.Serialize(p_Writer);
                    SubsetPartIndices.Serialize(p_Writer);
                    break;
            }

            p_Writer.WriteNullBytes((uint)(s_Start + Size - p_Writer.Position));
            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data) =>
            throw new NotSupportedException("A mesh layout is written as part of its MeshSet.");

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }
    }
}
