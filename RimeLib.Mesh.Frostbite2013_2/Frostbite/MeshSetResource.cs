using System;
using RimeLib.IO;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace RimeLib.Mesh.Frostbite2013_2.Frostbite;

/// <summary>
/// A MeshSet resource: a relocatable image of the layout and its meshes (pointers are 64-bit image
/// offsets), the embedded data of meshes without a chunk, then the relocation table.
/// </summary>
public class MeshSetResource
{
    public const int HeaderSize = 0x70;
    public const int SubsetSize = 0xC0;
    public const int MaxLodCount = 6;
    public const int CategoryCount = 4;

    /// <summary>The last meta word: the MeshSetLayout size and the largest MeshLayout size.</summary>
    public const uint LayoutSizes = HeaderSize | (0xC0u << 16);

    public Vector3 BoundingBoxMin { get; set; }
    public Vector3 BoundingBoxMax { get; set; }
    public List<Lod> Lods { get; set; } = new();
    public string Name { get; set; } = string.Empty;

    /// <summary>A suffix of <see cref="Name"/>, or null for no pointer.</summary>
    public string? ShortName { get; set; }

    public uint NameHash { get; set; }
    public uint MeshType { get; set; }
    public uint Flags { get; set; }
    public ushort TotalSubsetCount { get; set; }

    /// <summary>Vertex and index data stored in the resource instead of a chunk.</summary>
    public byte[] EmbeddedData { get; set; } = Array.Empty<byte>();

    public class Lod
    {
        /// <summary>0 rigid, 1 skinned, 2 composite; it decides the layout size and its arrays.</summary>
        public uint Type { get; set; }

        public uint MaxStreamInstanceCount { get; set; }
        public List<Subset> Subsets { get; set; } = new();
        public byte[][] CategorySubsetIndices { get; set; } = new byte[CategoryCount][];
        public uint Flags { get; set; }
        public uint IndexBufferFormat { get; set; }
        public uint IndexDataSize { get; set; }
        public uint VertexDataSize { get; set; }
        public uint EdgePartitionBufferSize { get; set; }
        public Guid DataChunkId { get; set; }
        public uint AuxVertexIndexDataOffset { get; set; }

        /// <summary>
        /// Whether m_embeddedEdgeData is set. The pipeline points it where the layouts' bone or
        /// part arrays begin, which is where <see cref="EmbeddedData"/> begins only when the mesh
        /// has none.
        /// </summary>
        public bool HasEmbeddedEdgeData { get; set; }

        /// <summary>"Mesh:" and <see cref="Name"/>; the name and short name are stored as its suffixes.</summary>
        public string ShaderDebugName { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public uint NameHash { get; set; }

        /// <summary>Skinned: m_boneCount entries each.</summary>
        public uint[] BoneIndexArray { get; set; } = Array.Empty<uint>();
        public uint[] BoneShortNameArray { get; set; } = Array.Empty<uint>();

        /// <summary>Composite: m_partCount boxes (min, max) and transforms.</summary>
        public Vector4[] PartBoundingBoxes { get; set; } = Array.Empty<Vector4>();
        public Matrix4x4[] PartTransforms { get; set; } = Array.Empty<Matrix4x4>();

        /// <summary>Composite: a 24-byte part mask per subset.</summary>
        public byte[][] SubsetPartIndices { get; set; } = Array.Empty<byte[]>();

        public int LayoutSize => Type switch
        {
            0 => 0xA0,
            1 => 0xB0,
            2 => 0xC0,
            _ => throw new InvalidDataException($"unknown mesh type {Type}"),
        };

        /// <summary>m_boneCount or m_partCount.</summary>
        public int UnionCount => Type switch
        {
            1 => BoneIndexArray.Length,
            2 => PartTransforms.Length,
            _ => 0,
        };
    }

    public class Subset
    {
        public string MaterialName { get; set; } = string.Empty;
        public uint MaterialIndex { get; set; }
        public uint PrimitiveCount { get; set; }
        public uint StartIndex { get; set; }
        public uint VertexOffset { get; set; }
        public uint VertexCount { get; set; }
        public byte VertexStride { get; set; }
        public byte PrimitiveType { get; set; }
        public byte BonesPerVertex { get; set; }
        public byte BoneCount { get; set; }

        /// <summary><see cref="BoneCount"/> indices, or null when the pointer is null.</summary>
        public ushort[]? BoneIndices { get; set; }

        /// <summary>All 16 elements and 4 streams as stored, unused ones included.</summary>
        public GeometryElement[] Elements { get; set; } = new GeometryElement[16];
        public GeometryStream[] Streams { get; set; } = new GeometryStream[4];
        public byte ElementCount { get; set; }
        public byte StreamCount { get; set; }

        public float[] TexCoordsPerMeter { get; set; } = new float[6];

        /// <summary>The last 44 bytes, which the engine fills at runtime; stored as found.</summary>
        public byte[] Reserved { get; set; } = new byte[ReservedSize];

        public const int ReservedSize = 44;
    }

    public record struct GeometryElement(byte Usage, byte Format, byte Offset, byte StreamIndex);

    public record struct GeometryStream(byte Stride, byte Classification);

    public static MeshSetResource Read(byte[] p_Data, byte[] p_Meta)
    {
        using var s_Meta = new RimeReader(new MemoryStream(p_Meta, false));
        var s_DataSize = s_Meta.ReadInt32();
        var s_EmbeddedSize = s_Meta.ReadInt32();

        using var r = new RimeReader(new MemoryStream(p_Data, 0, s_DataSize, false));

        RimeReader At(long p_Offset)
        {
            r.Seek(p_Offset, SeekOrigin.Begin);
            return r;
        }

        int Ptr(long p_Offset)
        {
            var s_Value = At(p_Offset).ReadUInt64();
            if (s_Value > (ulong)s_DataSize)
                throw new InvalidDataException($"pointer at 0x{p_Offset:x} leaves the image");
            return (int)s_Value;
        }

        string Str(long p_Offset) => At(p_Offset).ReadNullTerminatedString();

        var s_Set = new MeshSetResource
        {
            BoundingBoxMin = At(0x00).ReadVector3(),
            BoundingBoxMax = At(0x10).ReadVector3(),
            NameHash = At(0x60).ReadUInt32(),
            MeshType = r.ReadUInt32(),
            Flags = r.ReadUInt32(),
            EmbeddedData = p_Data.AsSpan(s_DataSize, s_EmbeddedSize).ToArray(),
        };
        var s_LodCount = r.ReadUInt16();
        s_Set.TotalSubsetCount = r.ReadUInt16();
        s_Set.Name = Str(Ptr(0x50));
        if (Ptr(0x58) is var s_Short and not 0)
            s_Set.ShortName = Str(s_Short);

        for (var i = 0; i < s_LodCount; ++i)
        {
            var l = Ptr(0x20 + 8 * i);
            var s_Lod = new Lod { Type = At(l).ReadUInt32(), MaxStreamInstanceCount = r.ReadUInt32() };
            var s_SubsetCount = r.ReadInt32();

            var s_CategoryCounts = new uint[CategoryCount];
            var s_CategoryOffsets = new int[CategoryCount];
            for (var k = 0; k < CategoryCount; ++k)
            {
                s_CategoryCounts[k] = At(l + 0x14 + 12 * k).ReadUInt32();
                s_CategoryOffsets[k] = Ptr(l + 0x18 + 12 * k);
            }

            s_Lod.Flags = At(l + 0x44).ReadUInt32();
            s_Lod.IndexBufferFormat = r.ReadUInt32();
            s_Lod.IndexDataSize = r.ReadUInt32();
            s_Lod.VertexDataSize = r.ReadUInt32();
            s_Lod.EdgePartitionBufferSize = r.ReadUInt32();
            s_Lod.DataChunkId = r.ReadGuid();
            s_Lod.AuxVertexIndexDataOffset = r.ReadUInt32();
            s_Lod.HasEmbeddedEdgeData = Ptr(l + 0x6C) != 0;
            s_Lod.ShaderDebugName = Str(Ptr(l + 0x74));
            s_Lod.Name = Str(Ptr(l + 0x7C));
            s_Lod.ShortName = Str(Ptr(l + 0x84));
            s_Lod.NameHash = At(l + 0x8C).ReadUInt32();
            if (Ptr(l + 0x90) != 0)
                throw new InvalidDataException("a mesh layout with m_data set");

            for (var k = 0; k < CategoryCount; ++k)
                s_Lod.CategorySubsetIndices[k] = At(s_CategoryOffsets[k]).ReadBytes((int)s_CategoryCounts[k]);

            var s_Subsets = Ptr(l + 0x0C);
            for (var j = 0; j < s_SubsetCount; ++j)
                s_Lod.Subsets.Add(ReadSubset(s_Subsets + SubsetSize * j));

            var s_Count = (int)At(l + 0x98).ReadUInt32();
            switch (s_Lod.Type)
            {
                case 1:
                    s_Lod.BoneIndexArray = ReadU32s(Ptr(l + 0x9C), s_Count);
                    s_Lod.BoneShortNameArray = ReadU32s(Ptr(l + 0xA4), s_Count);
                    break;
                case 2:
                    var s_Boxes = Ptr(l + 0x9C);
                    var s_Transforms = Ptr(l + 0xA4);
                    var s_Masks = Ptr(l + 0xAC);
                    s_Lod.PartBoundingBoxes = new Vector4[2 * s_Count];
                    At(s_Boxes);
                    for (var p = 0; p < 2 * s_Count; ++p)
                        s_Lod.PartBoundingBoxes[p] = r.ReadVector4();
                    s_Lod.PartTransforms = new Matrix4x4[s_Count];
                    At(s_Transforms);
                    for (var p = 0; p < s_Count; ++p)
                        s_Lod.PartTransforms[p] = r.ReadMatrix4x4();
                    s_Lod.SubsetPartIndices = new byte[s_SubsetCount][];
                    At(s_Masks);
                    for (var j = 0; j < s_SubsetCount; ++j)
                        s_Lod.SubsetPartIndices[j] = r.ReadBytes(24);
                    break;
                default:
                    if (s_Count != 0)
                        throw new InvalidDataException("a rigid mesh layout with a bone or part count");
                    break;
            }

            s_Set.Lods.Add(s_Lod);
        }

        return s_Set;

        Subset ReadSubset(int o)
        {
            if (Ptr(o) != 0)
                throw new InvalidDataException("a subset with geometryDeclarations set");

            var s_Subset = new Subset { MaterialName = Str(Ptr(o + 0x08)) };
            At(o + 0x10);
            s_Subset.MaterialIndex = r.ReadUInt32();
            s_Subset.PrimitiveCount = r.ReadUInt32();
            s_Subset.StartIndex = r.ReadUInt32();
            s_Subset.VertexOffset = r.ReadUInt32();
            s_Subset.VertexCount = r.ReadUInt32();
            s_Subset.VertexStride = r.ReadUByte();
            s_Subset.PrimitiveType = r.ReadUByte();
            s_Subset.BonesPerVertex = r.ReadUByte();
            s_Subset.BoneCount = r.ReadUByte();

            if (Ptr(o + 0x28) is var s_Bones and not 0)
            {
                s_Subset.BoneIndices = new ushort[s_Subset.BoneCount];
                At(s_Bones);
                for (var b = 0; b < s_Subset.BoneCount; ++b)
                    s_Subset.BoneIndices[b] = r.ReadUInt16();
            }

            At(o + 0x30);
            for (var e = 0; e < 16; ++e)
                s_Subset.Elements[e] = new GeometryElement(r.ReadUByte(), r.ReadUByte(), r.ReadUByte(), r.ReadUByte());
            for (var s = 0; s < 4; ++s)
                s_Subset.Streams[s] = new GeometryStream(r.ReadUByte(), r.ReadUByte());
            s_Subset.ElementCount = r.ReadUByte();
            s_Subset.StreamCount = r.ReadUByte();
            if (r.ReadUInt16() != 0)
                throw new InvalidDataException("geometry declaration padding is not zero");
            for (var t = 0; t < 6; ++t)
                s_Subset.TexCoordsPerMeter[t] = r.ReadSingle();
            s_Subset.Reserved = r.ReadBytes(Subset.ReservedSize);
            return s_Subset;
        }

        uint[] ReadU32s(int p_Offset, int p_Count)
        {
            At(p_Offset);
            var s_Values = new uint[p_Count];
            for (var i = 0; i < p_Count; ++i)
                s_Values[i] = r.ReadUInt32();
            return s_Values;
        }
    }

    /// <summary>The resource and its meta (image size, embedded data size, relocation table size, layout sizes).</summary>
    /// <summary>
    /// Lays the image out in the pipeline's order: header, layouts, subsets, bone indices, strings,
    /// category subset indices, then each layout's bone or part arrays.
    /// </summary>
    public (byte[] Data, byte[] Meta) Write()
    {
        var s_Stream = new MemoryStream();
        using var w = new RimeWriter(s_Stream);

        // Pointers in the order they are written, which is the order of the relocation table.
        var s_Pointers = new List<int>();

        int Reserve(int p_Size)
        {
            var s_Offset = (int)w.Position;
            w.WriteNullBytes((uint)p_Size);
            return s_Offset;
        }

        int Here() => (int)w.Position;

        // Fields are filled in at their offsets once the regions they point at are laid out.
        RimeWriter At(long p_Offset)
        {
            w.Seek(p_Offset, SeekOrigin.Begin);
            return w;
        }

        void Pointer(long p_At, int p_Target)
        {
            At(p_At).Write((ulong)p_Target);
            s_Pointers.Add((int)p_At);
        }

        Reserve(HeaderSize);

        var s_LodOffsets = Lods.Select(p_L => Reserve(p_L.LayoutSize)).ToArray();
        var s_SubsetOffsets = Lods.Select(p_L => Reserve(SubsetSize * p_L.Subsets.Count)).ToArray();

        var s_BoneOffsets = new int[Lods.Count][];
        for (var i = 0; i < Lods.Count; ++i)
        {
            s_BoneOffsets[i] = new int[Lods[i].Subsets.Count];
            for (var j = 0; j < Lods[i].Subsets.Count; ++j)
            {
                s_BoneOffsets[i][j] = Here();
                foreach (var s_Bone in Lods[i].Subsets[j].BoneIndices ?? Array.Empty<ushort>())
                    w.Write(s_Bone);
            }
        }
        w.Align(16);

        var s_MaterialOffsets = new int[Lods.Count][];
        var s_DebugNameOffsets = new int[Lods.Count];
        for (var i = 0; i < Lods.Count; ++i)
        {
            var s_Lod = Lods[i];
            s_MaterialOffsets[i] = new int[s_Lod.Subsets.Count];
            for (var j = 0; j < s_Lod.Subsets.Count; ++j)
            {
                s_MaterialOffsets[i][j] = Here();
                w.WriteNullTerminatedString(s_Lod.Subsets[j].MaterialName);
            }

            if (!s_Lod.ShaderDebugName.EndsWith(s_Lod.Name, StringComparison.Ordinal) || !s_Lod.Name.EndsWith(s_Lod.ShortName, StringComparison.Ordinal))
                throw new InvalidDataException($"layout {i}: the name must end the shader debug name and the short name the name");
            s_DebugNameOffsets[i] = Here();
            w.WriteNullTerminatedString(s_Lod.ShaderDebugName);
        }

        if (ShortName != null && !Name.EndsWith(ShortName, StringComparison.Ordinal))
            throw new InvalidDataException("the short name must end the name");
        var s_NameOffset = Here();
        w.WriteNullTerminatedString(Name);
        w.Align(16);

        var s_CategoryOffsets = new int[Lods.Count][];
        for (var i = 0; i < Lods.Count; ++i)
        {
            s_CategoryOffsets[i] = new int[CategoryCount];
            for (var k = 0; k < CategoryCount; ++k)
            {
                s_CategoryOffsets[i][k] = Here();
                w.Write(Lods[i].CategorySubsetIndices[k]);
            }
        }
        w.Align(16);

        var s_ArraysOffset = Here();
        var s_UnionOffsets = new int[Lods.Count][];
        for (var i = 0; i < Lods.Count; ++i)
        {
            var s_Lod = Lods[i];
            switch (s_Lod.Type)
            {
                case 1:
                    if (s_Lod.BoneShortNameArray.Length != s_Lod.BoneIndexArray.Length)
                        throw new InvalidDataException($"layout {i}: the bone arrays differ in length");
                    w.Align(4);
                    var s_Indices = Here();
                    foreach (var s_Value in s_Lod.BoneIndexArray)
                        w.Write(s_Value);
                    var s_Names = Here();
                    foreach (var s_Value in s_Lod.BoneShortNameArray)
                        w.Write(s_Value);
                    s_UnionOffsets[i] = new[] { s_Indices, s_Names };
                    break;
                case 2:
                    if (s_Lod.PartBoundingBoxes.Length != 2 * s_Lod.PartTransforms.Length || s_Lod.SubsetPartIndices.Length != s_Lod.Subsets.Count)
                        throw new InvalidDataException($"layout {i}: the part arrays do not match the part and subset counts");
                    w.Align(16);
                    var s_Boxes = Here();
                    foreach (var s_Value in s_Lod.PartBoundingBoxes)
                        w.Write(s_Value);
                    w.Align(16);
                    var s_Transforms = Here();
                    foreach (var s_Value in s_Lod.PartTransforms)
                        w.Write(s_Value);
                    var s_Masks = Here();
                    foreach (var s_Mask in s_Lod.SubsetPartIndices)
                    {
                        if (s_Mask.Length != 24)
                            throw new InvalidDataException($"layout {i}: a subset part mask is not 24 bytes");
                        w.Write(s_Mask);
                    }
                    s_UnionOffsets[i] = new[] { s_Boxes, s_Transforms, s_Masks };
                    break;
                default:
                    s_UnionOffsets[i] = Array.Empty<int>();
                    break;
            }
        }
        w.Align(16);
        var s_DataSize = Here();

        At(0x00).Write(BoundingBoxMin);
        At(0x10).Write(BoundingBoxMax);

        for (var i = 0; i < Lods.Count; ++i)
        {
            var s_Lod = Lods[i];
            var l = s_LodOffsets[i];
            At(l).Write(s_Lod.Type);
            w.Write(s_Lod.MaxStreamInstanceCount);
            w.Write((uint)s_Lod.Subsets.Count);
            Pointer(l + 0x0C, s_SubsetOffsets[i]);

            for (var j = 0; j < s_Lod.Subsets.Count; ++j)
                WriteSubset(s_Lod.Subsets[j], s_SubsetOffsets[i] + SubsetSize * j, s_MaterialOffsets[i][j], s_BoneOffsets[i][j], i, j);

            for (var k = 0; k < CategoryCount; ++k)
            {
                At(l + 0x14 + 12 * k).Write((uint)s_Lod.CategorySubsetIndices[k].Length);
                Pointer(l + 0x18 + 12 * k, s_CategoryOffsets[i][k]);
            }

            At(l + 0x44).Write(s_Lod.Flags);
            w.Write(s_Lod.IndexBufferFormat);
            w.Write(s_Lod.IndexDataSize);
            w.Write(s_Lod.VertexDataSize);
            w.Write(s_Lod.EdgePartitionBufferSize);
            w.Write(s_Lod.DataChunkId);
            w.Write(s_Lod.AuxVertexIndexDataOffset);
            if (s_Lod.HasEmbeddedEdgeData)
                Pointer(l + 0x6C, s_ArraysOffset);

            var s_Debug = s_DebugNameOffsets[i];
            var s_DebugLength = Encoding.UTF8.GetByteCount(s_Lod.ShaderDebugName);
            Pointer(l + 0x74, s_Debug);
            Pointer(l + 0x7C, s_Debug + s_DebugLength - Encoding.UTF8.GetByteCount(s_Lod.Name));
            Pointer(l + 0x84, s_Debug + s_DebugLength - Encoding.UTF8.GetByteCount(s_Lod.ShortName));
            At(l + 0x8C).Write(s_Lod.NameHash);

            At(l + 0x98).Write((uint)s_Lod.UnionCount);
            for (var k = 0; k < s_UnionOffsets[i].Length; ++k)
                Pointer(l + 0x9C + 8 * k, s_UnionOffsets[i][k]);
        }

        for (var i = 0; i < Lods.Count; ++i)
            Pointer(0x20 + 8 * i, s_LodOffsets[i]);
        Pointer(0x50, s_NameOffset);
        if (ShortName != null)
            Pointer(0x58, s_NameOffset + Encoding.UTF8.GetByteCount(Name) - Encoding.UTF8.GetByteCount(ShortName));
        At(0x60).Write(NameHash);
        w.Write(MeshType);
        w.Write(Flags);
        w.Write((ushort)Lods.Count);
        w.Write(TotalSubsetCount);

        At(s_DataSize).Write(EmbeddedData);
        foreach (var s_Pointer in s_Pointers)
            w.Write((uint)s_Pointer);

        var s_MetaStream = new MemoryStream();
        using (var s_Meta = new RimeWriter(s_MetaStream))
        {
            s_Meta.Write((uint)s_DataSize);
            s_Meta.Write((uint)EmbeddedData.Length);
            s_Meta.Write((uint)(4 * s_Pointers.Count));
            s_Meta.Write(LayoutSizes);
        }

        w.Flush();
        return (s_Stream.ToArray(), s_MetaStream.ToArray());

        void WriteSubset(Subset p_Subset, int o, int p_Material, int p_Bones, int i, int j)
        {
            Pointer(o + 0x08, p_Material);
            At(o + 0x10).Write(p_Subset.MaterialIndex);
            w.Write(p_Subset.PrimitiveCount);
            w.Write(p_Subset.StartIndex);
            w.Write(p_Subset.VertexOffset);
            w.Write(p_Subset.VertexCount);
            w.Write(p_Subset.VertexStride);
            w.Write(p_Subset.PrimitiveType);
            w.Write(p_Subset.BonesPerVertex);
            w.Write(p_Subset.BoneCount);
            if (p_Subset.BoneIndices != null)
            {
                if (p_Subset.BoneIndices.Length != p_Subset.BoneCount)
                    throw new InvalidDataException($"layout {i} subset {j}: the bone count does not match its indices");
                Pointer(o + 0x28, p_Bones);
            }

            At(o + 0x30);
            foreach (var s_Element in p_Subset.Elements)
            {
                w.Write(s_Element.Usage);
                w.Write(s_Element.Format);
                w.Write(s_Element.Offset);
                w.Write(s_Element.StreamIndex);
            }
            foreach (var s_Stream in p_Subset.Streams)
            {
                w.Write(s_Stream.Stride);
                w.Write(s_Stream.Classification);
            }
            w.Write(p_Subset.ElementCount);
            w.Write(p_Subset.StreamCount);
            w.Write((ushort)0);
            foreach (var s_Value in p_Subset.TexCoordsPerMeter)
                w.Write(s_Value);
            w.Write(p_Subset.Reserved);
        }
    }
}
