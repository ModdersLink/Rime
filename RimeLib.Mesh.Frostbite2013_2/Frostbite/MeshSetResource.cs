using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

namespace RimeLib.Mesh.Frostbite2013_2.Frostbite;

/// <summary>
/// A whole MeshSet resource: a relocatable image of the MeshSetLayout, its mesh layouts, their
/// subsets and everything they point to, then the embedded vertex and index data of meshes that
/// have no chunk, then the offsets of every pointer in the image.
/// </summary>
/// <remarks>
/// Pointers are 64-bit image offsets. The image is laid out as the pipeline lays it out: header,
/// layouts, subsets, bone indices, strings, category subset indices, then each layout's bone or
/// part arrays; the relocation table lists the pointers layout by layout, field by field.
/// </remarks>
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
        var s_DataSize = (int)BinaryPrimitives.ReadUInt32LittleEndian(p_Meta);
        var s_EmbeddedSize = (int)BinaryPrimitives.ReadUInt32LittleEndian(p_Meta.AsSpan(4));
        var d = new ReadOnlySpan<byte>(p_Data, 0, s_DataSize);
        var s_Data = p_Data;

        uint U32(int p_Offset) => BinaryPrimitives.ReadUInt32LittleEndian(s_Data.AsSpan(p_Offset));
        float F32(int p_Offset) => BinaryPrimitives.ReadSingleLittleEndian(s_Data.AsSpan(p_Offset));
        int Ptr(int p_Offset)
        {
            var s_Value = BinaryPrimitives.ReadUInt64LittleEndian(s_Data.AsSpan(p_Offset));
            if (s_Value > (ulong)s_DataSize)
                throw new InvalidDataException($"pointer at 0x{p_Offset:x} leaves the image");
            return (int)s_Value;
        }
        string Str(int p_Offset)
        {
            var s_End = Array.IndexOf(s_Data, (byte)0, p_Offset);
            return Encoding.UTF8.GetString(s_Data, p_Offset, s_End - p_Offset);
        }
        Vector3 Vec3(int p_Offset) => new(F32(p_Offset), F32(p_Offset + 4), F32(p_Offset + 8));
        Vector4 Vec4(int p_Offset) => new(F32(p_Offset), F32(p_Offset + 4), F32(p_Offset + 8), F32(p_Offset + 12));

        var s_Set = new MeshSetResource
        {
            BoundingBoxMin = Vec3(0x00),
            BoundingBoxMax = Vec3(0x10),
            NameHash = U32(0x60),
            MeshType = U32(0x64),
            Flags = U32(0x68),
            TotalSubsetCount = BinaryPrimitives.ReadUInt16LittleEndian(d[0x6E..]),
            EmbeddedData = p_Data.AsSpan(s_DataSize, s_EmbeddedSize).ToArray(),
        };
        s_Set.Name = Str(Ptr(0x50));
        if (Ptr(0x58) is var s_Short and not 0)
            s_Set.ShortName = Str(s_Short);

        var s_LodCount = BinaryPrimitives.ReadUInt16LittleEndian(d[0x6C..]);
        for (var i = 0; i < s_LodCount; ++i)
        {
            var l = Ptr(0x20 + 8 * i);
            var s_Lod = new Lod
            {
                Type = U32(l),
                MaxStreamInstanceCount = U32(l + 0x04),
                Flags = U32(l + 0x44),
                IndexBufferFormat = U32(l + 0x48),
                IndexDataSize = U32(l + 0x4C),
                VertexDataSize = U32(l + 0x50),
                EdgePartitionBufferSize = U32(l + 0x54),
                DataChunkId = new Guid(d.Slice(l + 0x58, 16)),
                AuxVertexIndexDataOffset = U32(l + 0x68),
                HasEmbeddedEdgeData = Ptr(l + 0x6C) != 0,
                ShaderDebugName = Str(Ptr(l + 0x74)),
                Name = Str(Ptr(l + 0x7C)),
                ShortName = Str(Ptr(l + 0x84)),
                NameHash = U32(l + 0x8C),
            };
            if (Ptr(l + 0x90) != 0)
                throw new InvalidDataException("a mesh layout with m_data set");

            for (var k = 0; k < CategoryCount; ++k)
                s_Lod.CategorySubsetIndices[k] = d.Slice(Ptr(l + 0x18 + 12 * k), (int)U32(l + 0x14 + 12 * k)).ToArray();

            var s_SubsetCount = (int)U32(l + 0x08);
            var s_Subsets = Ptr(l + 0x0C);
            for (var j = 0; j < s_SubsetCount; ++j)
            {
                var o = s_Subsets + SubsetSize * j;
                if (Ptr(o) != 0)
                    throw new InvalidDataException("a subset with geometryDeclarations set");

                var s_Subset = new Subset
                {
                    MaterialName = Str(Ptr(o + 0x08)),
                    MaterialIndex = U32(o + 0x10),
                    PrimitiveCount = U32(o + 0x14),
                    StartIndex = U32(o + 0x18),
                    VertexOffset = U32(o + 0x1C),
                    VertexCount = U32(o + 0x20),
                    VertexStride = d[o + 0x24],
                    PrimitiveType = d[o + 0x25],
                    BonesPerVertex = d[o + 0x26],
                    BoneCount = d[o + 0x27],
                    ElementCount = d[o + 0x78],
                    StreamCount = d[o + 0x79],
                    Reserved = d.Slice(o + 0x94, Subset.ReservedSize).ToArray(),
                };
                if (d[o + 0x7A] != 0 || d[o + 0x7B] != 0)
                    throw new InvalidDataException("geometry declaration padding is not zero");

                if (Ptr(o + 0x28) is var s_Bones and not 0)
                {
                    s_Subset.BoneIndices = new ushort[s_Subset.BoneCount];
                    for (var b = 0; b < s_Subset.BoneCount; ++b)
                        s_Subset.BoneIndices[b] = BinaryPrimitives.ReadUInt16LittleEndian(d[(s_Bones + 2 * b)..]);
                }

                for (var e = 0; e < 16; ++e)
                    s_Subset.Elements[e] = new GeometryElement(d[o + 0x30 + 4 * e], d[o + 0x31 + 4 * e], d[o + 0x32 + 4 * e], d[o + 0x33 + 4 * e]);
                for (var s = 0; s < 4; ++s)
                    s_Subset.Streams[s] = new GeometryStream(d[o + 0x70 + 2 * s], d[o + 0x71 + 2 * s]);
                for (var t = 0; t < 6; ++t)
                    s_Subset.TexCoordsPerMeter[t] = F32(o + 0x7C + 4 * t);

                s_Lod.Subsets.Add(s_Subset);
            }

            var s_Count = (int)U32(l + 0x98);
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
                    s_Lod.PartTransforms = new Matrix4x4[s_Count];
                    for (var p = 0; p < 2 * s_Count; ++p)
                        s_Lod.PartBoundingBoxes[p] = Vec4(s_Boxes + 16 * p);
                    for (var p = 0; p < s_Count; ++p)
                    {
                        var t = s_Transforms + 64 * p;
                        s_Lod.PartTransforms[p] = new Matrix4x4(
                            F32(t), F32(t + 4), F32(t + 8), F32(t + 12),
                            F32(t + 16), F32(t + 20), F32(t + 24), F32(t + 28),
                            F32(t + 32), F32(t + 36), F32(t + 40), F32(t + 44),
                            F32(t + 48), F32(t + 52), F32(t + 56), F32(t + 60));
                    }
                    s_Lod.SubsetPartIndices = new byte[s_SubsetCount][];
                    for (var j = 0; j < s_SubsetCount; ++j)
                        s_Lod.SubsetPartIndices[j] = d.Slice(s_Masks + 24 * j, 24).ToArray();
                    break;
                default:
                    if (s_Count != 0)
                        throw new InvalidDataException("a rigid mesh layout with a bone or part count");
                    break;
            }

            s_Set.Lods.Add(s_Lod);
        }

        return s_Set;

        uint[] ReadU32s(int p_Offset, int p_Count)
        {
            var s_Values = new uint[p_Count];
            for (var i = 0; i < p_Count; ++i)
                s_Values[i] = U32(p_Offset + 4 * i);
            return s_Values;
        }
    }

    /// <summary>The resource and its meta (image size, embedded data size, relocation table size, layout sizes).</summary>
    public (byte[] Data, byte[] Meta) Write()
    {
        var s_Image = new ImageWriter();
        s_Image.Skip(HeaderSize);

        var s_LodOffsets = new int[Lods.Count];
        for (var i = 0; i < Lods.Count; ++i)
            s_LodOffsets[i] = s_Image.Skip(Lods[i].LayoutSize);

        var s_SubsetOffsets = new int[Lods.Count];
        for (var i = 0; i < Lods.Count; ++i)
            s_SubsetOffsets[i] = s_Image.Skip(SubsetSize * Lods[i].Subsets.Count);

        var s_BoneOffsets = new int[Lods.Count][];
        for (var i = 0; i < Lods.Count; ++i)
        {
            s_BoneOffsets[i] = new int[Lods[i].Subsets.Count];
            for (var j = 0; j < Lods[i].Subsets.Count; ++j)
            {
                s_BoneOffsets[i][j] = s_Image.Position;
                foreach (var s_Bone in Lods[i].Subsets[j].BoneIndices ?? Array.Empty<ushort>())
                    s_Image.Append16(s_Bone);
            }
        }
        s_Image.Align(16);

        var s_MaterialOffsets = new int[Lods.Count][];
        var s_DebugNameOffsets = new int[Lods.Count];
        for (var i = 0; i < Lods.Count; ++i)
        {
            s_MaterialOffsets[i] = new int[Lods[i].Subsets.Count];
            for (var j = 0; j < Lods[i].Subsets.Count; ++j)
                s_MaterialOffsets[i][j] = s_Image.AppendString(Lods[i].Subsets[j].MaterialName);

            var s_Lod = Lods[i];
            if (!s_Lod.ShaderDebugName.EndsWith(s_Lod.Name, StringComparison.Ordinal) || !s_Lod.Name.EndsWith(s_Lod.ShortName, StringComparison.Ordinal))
                throw new InvalidDataException($"layout {i}: the name must end the shader debug name and the short name the name");
            s_DebugNameOffsets[i] = s_Image.AppendString(s_Lod.ShaderDebugName);
        }

        if (ShortName != null && !Name.EndsWith(ShortName, StringComparison.Ordinal))
            throw new InvalidDataException("the short name must end the name");
        var s_NameOffset = s_Image.AppendString(Name);
        s_Image.Align(16);

        var s_CategoryOffsets = new int[Lods.Count][];
        for (var i = 0; i < Lods.Count; ++i)
        {
            s_CategoryOffsets[i] = new int[CategoryCount];
            for (var k = 0; k < CategoryCount; ++k)
                s_CategoryOffsets[i][k] = s_Image.Append(Lods[i].CategorySubsetIndices[k]);
        }
        s_Image.Align(16);

        var s_ArraysOffset = s_Image.Position;
        var s_UnionOffsets = new int[Lods.Count][];
        for (var i = 0; i < Lods.Count; ++i)
        {
            var s_Lod = Lods[i];
            switch (s_Lod.Type)
            {
                case 1:
                    if (s_Lod.BoneShortNameArray.Length != s_Lod.BoneIndexArray.Length)
                        throw new InvalidDataException($"layout {i}: the bone arrays differ in length");
                    s_Image.Align(4);
                    var s_Indices = s_Image.Position;
                    foreach (var s_Value in s_Lod.BoneIndexArray)
                        s_Image.Append32(s_Value);
                    var s_Names = s_Image.Position;
                    foreach (var s_Value in s_Lod.BoneShortNameArray)
                        s_Image.Append32(s_Value);
                    s_UnionOffsets[i] = new[] { s_Indices, s_Names };
                    break;
                case 2:
                    if (s_Lod.PartBoundingBoxes.Length != 2 * s_Lod.PartTransforms.Length || s_Lod.SubsetPartIndices.Length != s_Lod.Subsets.Count)
                        throw new InvalidDataException($"layout {i}: the part arrays do not match the part and subset counts");
                    s_Image.Align(16);
                    var s_Boxes = s_Image.Position;
                    foreach (var s_Value in s_Lod.PartBoundingBoxes)
                        s_Image.AppendVector4(s_Value);
                    s_Image.Align(16);
                    var s_Transforms = s_Image.Position;
                    foreach (var s_Value in s_Lod.PartTransforms)
                        s_Image.AppendMatrix(s_Value);
                    var s_Masks = s_Image.Position;
                    foreach (var s_Mask in s_Lod.SubsetPartIndices)
                    {
                        if (s_Mask.Length != 24)
                            throw new InvalidDataException($"layout {i}: a subset part mask is not 24 bytes");
                        s_Image.Append(s_Mask);
                    }
                    s_UnionOffsets[i] = new[] { s_Boxes, s_Transforms, s_Masks };
                    break;
                default:
                    s_UnionOffsets[i] = Array.Empty<int>();
                    break;
            }
        }
        s_Image.Align(16);
        var s_DataSize = s_Image.Position;

        s_Image.PutVector3(0x00, BoundingBoxMin);
        s_Image.PutVector3(0x10, BoundingBoxMax);

        for (var i = 0; i < Lods.Count; ++i)
        {
            var s_Lod = Lods[i];
            var l = s_LodOffsets[i];
            s_Image.Put32(l, s_Lod.Type);
            s_Image.Put32(l + 0x04, s_Lod.MaxStreamInstanceCount);
            s_Image.Put32(l + 0x08, (uint)s_Lod.Subsets.Count);
            s_Image.PutPointer(l + 0x0C, s_SubsetOffsets[i]);

            for (var j = 0; j < s_Lod.Subsets.Count; ++j)
            {
                var s_Subset = s_Lod.Subsets[j];
                var o = s_SubsetOffsets[i] + SubsetSize * j;
                s_Image.PutPointer(o + 0x08, s_MaterialOffsets[i][j]);
                s_Image.Put32(o + 0x10, s_Subset.MaterialIndex);
                s_Image.Put32(o + 0x14, s_Subset.PrimitiveCount);
                s_Image.Put32(o + 0x18, s_Subset.StartIndex);
                s_Image.Put32(o + 0x1C, s_Subset.VertexOffset);
                s_Image.Put32(o + 0x20, s_Subset.VertexCount);
                s_Image.Put8(o + 0x24, s_Subset.VertexStride);
                s_Image.Put8(o + 0x25, s_Subset.PrimitiveType);
                s_Image.Put8(o + 0x26, s_Subset.BonesPerVertex);
                s_Image.Put8(o + 0x27, s_Subset.BoneCount);
                if (s_Subset.BoneIndices != null)
                {
                    if (s_Subset.BoneIndices.Length != s_Subset.BoneCount)
                        throw new InvalidDataException($"layout {i} subset {j}: the bone count does not match its indices");
                    s_Image.PutPointer(o + 0x28, s_BoneOffsets[i][j]);
                }

                for (var e = 0; e < 16; ++e)
                {
                    var s_Element = s_Subset.Elements[e];
                    s_Image.Put8(o + 0x30 + 4 * e, s_Element.Usage);
                    s_Image.Put8(o + 0x31 + 4 * e, s_Element.Format);
                    s_Image.Put8(o + 0x32 + 4 * e, s_Element.Offset);
                    s_Image.Put8(o + 0x33 + 4 * e, s_Element.StreamIndex);
                }
                for (var s = 0; s < 4; ++s)
                {
                    s_Image.Put8(o + 0x70 + 2 * s, s_Subset.Streams[s].Stride);
                    s_Image.Put8(o + 0x71 + 2 * s, s_Subset.Streams[s].Classification);
                }
                s_Image.Put8(o + 0x78, s_Subset.ElementCount);
                s_Image.Put8(o + 0x79, s_Subset.StreamCount);
                for (var t = 0; t < 6; ++t)
                    s_Image.PutFloat(o + 0x7C + 4 * t, s_Subset.TexCoordsPerMeter[t]);
                s_Image.Put(o + 0x94, s_Subset.Reserved);
            }

            for (var k = 0; k < CategoryCount; ++k)
            {
                s_Image.Put32(l + 0x14 + 12 * k, (uint)s_Lod.CategorySubsetIndices[k].Length);
                s_Image.PutPointer(l + 0x18 + 12 * k, s_CategoryOffsets[i][k]);
            }

            s_Image.Put32(l + 0x44, s_Lod.Flags);
            s_Image.Put32(l + 0x48, s_Lod.IndexBufferFormat);
            s_Image.Put32(l + 0x4C, s_Lod.IndexDataSize);
            s_Image.Put32(l + 0x50, s_Lod.VertexDataSize);
            s_Image.Put32(l + 0x54, s_Lod.EdgePartitionBufferSize);
            s_Image.Put(l + 0x58, s_Lod.DataChunkId.ToByteArray());
            s_Image.Put32(l + 0x68, s_Lod.AuxVertexIndexDataOffset);
            if (s_Lod.HasEmbeddedEdgeData)
                s_Image.PutPointer(l + 0x6C, s_ArraysOffset);

            var s_Debug = s_DebugNameOffsets[i];
            s_Image.PutPointer(l + 0x74, s_Debug);
            s_Image.PutPointer(l + 0x7C, s_Debug + Encoding.UTF8.GetByteCount(s_Lod.ShaderDebugName) - Encoding.UTF8.GetByteCount(s_Lod.Name));
            s_Image.PutPointer(l + 0x84, s_Debug + Encoding.UTF8.GetByteCount(s_Lod.ShaderDebugName) - Encoding.UTF8.GetByteCount(s_Lod.ShortName));
            s_Image.Put32(l + 0x8C, s_Lod.NameHash);

            s_Image.Put32(l + 0x98, (uint)s_Lod.UnionCount);
            for (var k = 0; k < s_UnionOffsets[i].Length; ++k)
                s_Image.PutPointer(l + 0x9C + 8 * k, s_UnionOffsets[i][k]);
        }

        for (var i = 0; i < Lods.Count; ++i)
            s_Image.PutPointer(0x20 + 8 * i, s_LodOffsets[i]);
        s_Image.PutPointer(0x50, s_NameOffset);
        if (ShortName != null)
            s_Image.PutPointer(0x58, s_NameOffset + Encoding.UTF8.GetByteCount(Name) - Encoding.UTF8.GetByteCount(ShortName));
        s_Image.Put32(0x60, NameHash);
        s_Image.Put32(0x64, MeshType);
        s_Image.Put32(0x68, Flags);
        s_Image.Put16(0x6C, (ushort)Lods.Count);
        s_Image.Put16(0x6E, TotalSubsetCount);

        s_Image.Append(EmbeddedData);
        var s_RelocationSize = 4 * s_Image.Pointers.Count;
        foreach (var s_Pointer in s_Image.Pointers)
            s_Image.Append32((uint)s_Pointer);

        var s_Meta = new byte[16];
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta, (uint)s_DataSize);
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta.AsSpan(4), (uint)EmbeddedData.Length);
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta.AsSpan(8), (uint)s_RelocationSize);
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta.AsSpan(12), LayoutSizes);
        return (s_Image.ToArray(), s_Meta);
    }

    /// <summary>
    /// A growing image: regions are appended, fields put at known offsets, and pointers recorded in
    /// the order they are put, which is the order of the relocation table.
    /// </summary>
    private sealed class ImageWriter
    {
        private readonly List<byte> m_Bytes = new();
        public List<int> Pointers { get; } = new();

        public int Position => m_Bytes.Count;

        public int Skip(int p_Size)
        {
            var s_Offset = Position;
            m_Bytes.AddRange(new byte[p_Size]);
            return s_Offset;
        }

        public void Align(int p_Alignment)
        {
            while (m_Bytes.Count % p_Alignment != 0)
                m_Bytes.Add(0);
        }

        public int Append(ReadOnlySpan<byte> p_Bytes)
        {
            var s_Offset = Position;
            foreach (var s_Byte in p_Bytes)
                m_Bytes.Add(s_Byte);
            return s_Offset;
        }

        public int AppendString(string p_Value)
        {
            var s_Offset = Append(Encoding.UTF8.GetBytes(p_Value));
            m_Bytes.Add(0);
            return s_Offset;
        }

        public void Append16(ushort p_Value)
        {
            Span<byte> s_Bytes = stackalloc byte[2];
            BinaryPrimitives.WriteUInt16LittleEndian(s_Bytes, p_Value);
            Append(s_Bytes);
        }

        public void Append32(uint p_Value)
        {
            Span<byte> s_Bytes = stackalloc byte[4];
            BinaryPrimitives.WriteUInt32LittleEndian(s_Bytes, p_Value);
            Append(s_Bytes);
        }

        public void AppendFloat(float p_Value) => Append32(BitConverter.SingleToUInt32Bits(p_Value));

        public void AppendVector4(Vector4 p_Value)
        {
            AppendFloat(p_Value.X);
            AppendFloat(p_Value.Y);
            AppendFloat(p_Value.Z);
            AppendFloat(p_Value.W);
        }

        public void AppendMatrix(Matrix4x4 p_Value)
        {
            for (var r = 0; r < 4; ++r)
            for (var c = 0; c < 4; ++c)
                AppendFloat(p_Value[r, c]);
        }

        public void Put(int p_Offset, ReadOnlySpan<byte> p_Bytes)
        {
            for (var i = 0; i < p_Bytes.Length; ++i)
                m_Bytes[p_Offset + i] = p_Bytes[i];
        }

        public void Put8(int p_Offset, byte p_Value) => m_Bytes[p_Offset] = p_Value;

        public void Put16(int p_Offset, ushort p_Value)
        {
            Span<byte> s_Bytes = stackalloc byte[2];
            BinaryPrimitives.WriteUInt16LittleEndian(s_Bytes, p_Value);
            Put(p_Offset, s_Bytes);
        }

        public void Put32(int p_Offset, uint p_Value)
        {
            Span<byte> s_Bytes = stackalloc byte[4];
            BinaryPrimitives.WriteUInt32LittleEndian(s_Bytes, p_Value);
            Put(p_Offset, s_Bytes);
        }

        public void PutFloat(int p_Offset, float p_Value) => Put32(p_Offset, BitConverter.SingleToUInt32Bits(p_Value));

        public void PutVector3(int p_Offset, Vector3 p_Value)
        {
            PutFloat(p_Offset, p_Value.X);
            PutFloat(p_Offset + 4, p_Value.Y);
            PutFloat(p_Offset + 8, p_Value.Z);
        }

        public void PutPointer(int p_Offset, int p_Target)
        {
            Span<byte> s_Bytes = stackalloc byte[8];
            BinaryPrimitives.WriteUInt64LittleEndian(s_Bytes, (ulong)p_Target);
            Put(p_Offset, s_Bytes);
            Pointers.Add(p_Offset);
        }

        public byte[] ToArray() => m_Bytes.ToArray();
    }
}
