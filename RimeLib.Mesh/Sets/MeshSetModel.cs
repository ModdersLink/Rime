using System;
using System.Collections.Generic;
using System.Numerics;
using GUID = RimeLib.Frostbite.Core.GUID;

namespace RimeLib.Mesh.Sets;

public enum MeshKind
{
    Rigid,
    Skinned,
    Composite,
}

public enum MeshPrimitive
{
    PointList,
    LineList,
    LineStrip,
    TriangleList,
    TriangleStrip,
    QuadList,
    RectList,
}

public enum VertexClassification
{
    PerVertex,
    PerInstance,
    Index,
}

/// <summary>A mesh's flags (fb::MeshLayoutFlags), whose bits are the same in every engine.</summary>
[Flags]
public enum MeshFlags : uint
{
    IsBaseLod = 0x1,
    StreamInstancingEnable = 0x10,
    StreamingEnable = 0x40,
    VertexAnimationEnable = 0x80,
    IsDataAvailable = 0x20000000,
}

/// <summary>
/// A MeshSet independent of the engine it is stored for: its LODs, their subsets and vertex
/// declarations. The vertex and index data stays where the engine keeps it, in each LOD's chunk or
/// in <see cref="EmbeddedData"/>.
/// </summary>
public sealed record MeshSetModel
{
    public required string Name { get; init; }

    /// <summary>A suffix of <see cref="Name"/>, or none.</summary>
    public string? ShortName { get; init; }

    public uint NameHash { get; init; }
    public MeshKind Kind { get; init; }
    public MeshFlags Flags { get; init; }
    public Vector3 BoundsMin { get; init; }
    public Vector3 BoundsMax { get; init; }
    public required IReadOnlyList<MeshLodModel> Lods { get; init; }

    /// <summary>Vertex and index data of the LODs without a chunk.</summary>
    public byte[] EmbeddedData { get; init; } = Array.Empty<byte>();
}

/// <summary>One LOD of a <see cref="MeshSetModel"/> (fb::MeshLayout).</summary>
public sealed record MeshLodModel
{
    /// <summary>The instance count of an engine without such a limit.</summary>
    public const uint NoInstanceLimit = 0xFFFF;

    public MeshKind Kind { get; init; }
    public uint MaxStreamInstanceCount { get; init; } = NoInstanceLimit;
    public required IReadOnlyList<MeshSubsetModel> Subsets { get; init; }

    /// <summary>Per subset category (opaque, transparent, transparent decal, z-only), the indices of its subsets.</summary>
    public required IReadOnlyList<byte[]> CategorySubsetIndices { get; init; }

    public MeshFlags Flags { get; init; }

    /// <summary>The bytes an index takes: 2 or 4.</summary>
    public int IndexSize { get; init; } = 2;

    public uint IndexDataSize { get; init; }
    public uint VertexDataSize { get; init; }
    public uint EdgePartitionBufferSize { get; init; }
    public GUID ChunkId { get; init; } = GUID.Empty;
    public uint AuxVertexIndexDataOffset { get; init; }

    /// <summary>Whether the LOD points at embedded edge data, which starts where the bone or part arrays do.</summary>
    public bool HasEmbeddedEdgeData { get; init; }

    /// <summary>Ends in <see cref="Name"/>, which ends in <see cref="ShortName"/>.</summary>
    public required string ShaderDebugName { get; init; }

    public required string Name { get; init; }
    public required string ShortName { get; init; }
    public uint NameHash { get; init; }

    /// <summary>A skinned LOD's bone ids and the hashes of their short names, one per bone.</summary>
    public uint[] Bones { get; init; } = Array.Empty<uint>();

    public uint[] BoneShortNames { get; init; } = Array.Empty<uint>();

    /// <summary>A composite LOD's part bounds, a min and a max per part.</summary>
    public Vector4[] PartBoundingBoxes { get; init; } = Array.Empty<Vector4>();

    public Matrix4x4[] PartTransforms { get; init; } = Array.Empty<Matrix4x4>();

    /// <summary>A composite LOD's part mask per subset.</summary>
    public byte[] SubsetPartIndices { get; init; } = Array.Empty<byte>();
}

/// <summary>A part of a LOD drawn with one material (fb::MeshSubset).</summary>
public sealed record MeshSubsetModel
{
    public required string MaterialName { get; init; }
    public uint MaterialIndex { get; init; }
    public uint PrimitiveCount { get; init; }
    public uint StartIndex { get; init; }
    public uint VertexOffset { get; init; }
    public uint VertexCount { get; init; }
    public byte VertexStride { get; init; }
    public MeshPrimitive Primitive { get; init; } = MeshPrimitive.TriangleList;
    public byte BonesPerVertex { get; init; }
    public byte BoneCount { get; init; }

    /// <summary><see cref="BoneCount"/> indices, or none where the subset points at none, which some with a bone count do.</summary>
    public ushort[]? BoneIndices { get; init; }
    public required IReadOnlyList<VertexElement> Elements { get; init; }
    public required IReadOnlyList<VertexStream> Streams { get; init; }

    /// <summary>One ratio per texture coordinate set, six in all.</summary>
    public required float[] TexCoordRatios { get; init; }
}

public sealed record VertexElement(VertexUsage Usage, VertexFormat Format, byte Offset, byte StreamIndex);

public sealed record VertexStream(byte Stride, VertexClassification Classification);
