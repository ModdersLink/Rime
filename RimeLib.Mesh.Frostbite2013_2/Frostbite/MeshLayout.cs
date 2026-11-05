using System.Diagnostics.CodeAnalysis;
using Matrix4x4 = System.Numerics.Matrix4x4;
using Vector4 = System.Numerics.Vector4;
using fb.Core;
using fb.Render;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 (Battlefield 4) mesh LOD.
/// </summary>
/// <remarks>
/// The Frostbite 2 LOD layout with a MaxInstances field after the mesh type. It ends in a bone or
/// part count and, by mesh type, the arrays that count sizes.
/// </remarks>
public class MeshLayout : IFbSerializable
{
    /// <summary>The bytes a part mask takes per subset.</summary>
    public const int PartMaskSize = 24;

    public MeshType Type { get; set; }
    public uint MaxInstances { get; set; }
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

    public int Size => Type switch
    {
        MeshType.MeshType_Rigid => 0xA0,
        MeshType.MeshType_Skinned => 0xB0,
        MeshType.MeshType_Composite => 0xC0,
        _ => throw new InvalidDataException($"unknown mesh type {Type}"),
    };

    public MeshLayout()
    {
    }

    public MeshLayout(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Type = (MeshType)p_Reader.ReadUInt32();
        MaxInstances = p_Reader.ReadUInt32();
        Subsets = new RelocArray<MeshSubset>(p_Reader);

        CategorySubsetIndices = new RelocArray<byte>[(int)MeshSubsetCategory.MeshSubsetCategoryCount];
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

    public void Deserialize(byte[] p_Data) => Deserialize(new RimeReader(new MemoryStream(p_Data)));

    /// <summary>Writes the layout, padded to <see cref="Size"/>; the MeshSet places what its pointers point at.</summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        var s_Start = p_Writer.Position;
        p_Writer.Write((uint)Type);
        p_Writer.Write(MaxInstances);
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
}
