using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite
{
    /// <summary>
    /// Venice (Battlefield 3) Mesh layout
    /// </summary>
    public class MeshLayout : IFbSerializable
    {
        /// <summary>
        /// Flags for the mesh layout
        /// </summary>
        [Flags]
        public enum MeshLayoutFlags
        {
            /// <summary>
            /// Is this a base level of detail
            /// </summary>
            IsBaseLod = 0x1,

            /// <summary>
            /// Is streaming enabled
            /// </summary>
            StreamingEnable = 0x40,

            /// <summary>
            /// Is stream instancing enabled
            /// </summary>
            StreamInstancingEnable = 0x10,

            /// <summary>
            /// Vertex animation enabled
            /// </summary>
            VertexAnimationEnable = 0x80,

            /// <summary>
            /// Is the data available
            /// </summary>
            IsDataAvailable = 0x20000000,
        };

        /// <summary>
        /// Mesh Type
        /// </summary>
        public MeshType Type { get; set; }
        //public uint m_subsetCount { get; set; } // Testing removal and converting below to RelocArray to auto-read

        /// <summary>
        /// Subsets within this layout
        /// </summary>
        public RelocArray<MeshSubset> Subsets { get; set; } = new RelocArray<MeshSubset>(); // RelocPtr

        /// <summary>
        /// Category subset indices
        /// </summary>
        public RelocArray<byte>[] CategorySubsetIndices { get; set; } = new RelocArray<byte>[4]; // Len4

        /// <summary>
        /// Mesh layout flags
        /// </summary>
        public MeshLayoutFlags Flags { get; set; }

        /// <summary>
        /// Index buffer format
        /// </summary>
        public IndexBufferFormat IndexBufferFormat { get; set; }

        /// <summary>
        /// Index data size
        /// </summary>
        public uint IndexDataSize { get; set; }

        /// <summary>
        /// Vertex data size
        /// </summary>
        public uint VertexDataSize { get; set; }

        /// <summary>
        /// Unknown what this really does...
        /// </summary>
        public uint EdgePartitionBufferSize { get; set; }

        /// <summary>
        /// Guid that contains the chunk data
        /// </summary>
        public GUID DataChunkId { get; set; } = Guid.Empty;

        /// <summary>
        /// Vertex index data offset
        /// </summary>
        public uint AuxVertexIndexDataOffset { get; set; }

        /// <summary>
        /// Unknown what this really does
        /// </summary>
        public RelocPtr<byte> EmbeddedEdgeData { get; set; } = new RelocPtr<byte>(); // RelocPtr

        /// <summary>
        /// Shader debug name
        /// </summary>
        public RelocPtr<string> ShaderDebugName { get; set; } = new RelocPtr<string>(); // RelocPtr

        /// <summary>
        /// Full name of the mesh
        /// </summary>
        public RelocPtr<string> Name { get; set; } = new RelocPtr<string>(); // RelocPtr

        /// <summary>
        /// Short name of the mesh
        /// </summary>
        public RelocPtr<string> ShortName { get; set; } = new RelocPtr<string>(); // RelocPtr

        /// <summary>
        /// Name hash
        /// </summary>
        public uint NameHash { get; set; }

        /// <summary>
        /// RelocPtr to the data
        /// </summary>
        public ulong Data { get; set; } // RelocPtr

        /// <summary>
        /// Count of parts to this mesh
        /// </summary>
        public uint PartCount { get; set; }

        /// <summary>
        /// This could be the bone index array or the parts bounding boxes, who knows
        /// </summary>
        public RelocPtr<uint> BoneIndexArrayPartBoundingBoxes { get; set; } = new RelocPtr<uint>(); // RelocPtr

        /// <summary>
        /// This could be the bones short name or the part transforms, who knows
        /// </summary>
        public RelocPtr<uint> BoneShortNameArrayPartTransforms { get; set; } = new RelocPtr<uint>(); // RelocPtr

        /// <summary>
        /// Subset's parts indices
        /// </summary>
        public ulong SubsetPartIndices { get; set; } // RelocPtr

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeshLayout()
        {

        }

        /// <summary>
        /// Constructor that reads out a mesh layout from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the mesh layout</param>
        public MeshLayout(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Writes the mesh layout to an opened writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position of the mesh layout</param>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((uint)Type);

            Subsets.Serialize(p_Writer);

            foreach (var s_Indices in CategorySubsetIndices)
                s_Indices.Serialize(p_Writer);

            p_Writer.Write((uint)Flags);
            p_Writer.Write((uint)IndexBufferFormat);
            p_Writer.Write(IndexDataSize);
            p_Writer.Write(VertexDataSize);
            p_Writer.Write(EdgePartitionBufferSize);
            p_Writer.Write(DataChunkId.Id);
            p_Writer.Write(AuxVertexIndexDataOffset);
            p_Writer.Write(EmbeddedEdgeData.BaseAddress);
            p_Writer.Write(ShaderDebugName.BaseAddress);
            p_Writer.Write(Name.BaseAddress);
            p_Writer.Write(ShortName.BaseAddress);
            p_Writer.Write(NameHash);
            p_Writer.Write(Data);
            p_Writer.Write(PartCount);
            p_Writer.Write(BoneIndexArrayPartBoundingBoxes.BaseAddress);
            p_Writer.Write(BoneShortNameArrayPartTransforms.BaseAddress);
            p_Writer.Write(SubsetPartIndices);

            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Deserialize(RimeReader p_Reader)
        {
            Type = (MeshType)p_Reader.ReadUInt32();
            //m_subsetCount = p_Reader.ReadUInt32();
            Subsets = new RelocArray<MeshSubset>(p_Reader);

            CategorySubsetIndices = new RelocArray<byte>[4];

            for (var i = 0; i < 4; ++i)
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
            PartCount = p_Reader.ReadUInt32();
            BoneIndexArrayPartBoundingBoxes = new RelocPtr<uint>(p_Reader);
            BoneShortNameArrayPartTransforms = new RelocPtr<uint>(p_Reader);
            SubsetPartIndices = p_Reader.ReadUInt64();
        }

        /// <inheritdoc />
        public void Deserialize(byte[] p_Data)
        {
            Deserialize(new RimeReader(new MemoryStream(p_Data)));
        }
    }
}
