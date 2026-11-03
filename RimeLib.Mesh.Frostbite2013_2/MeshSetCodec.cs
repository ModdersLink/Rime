using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using fb.Core;
using fb.Render;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Mesh.Frostbite2013_2.Frostbite;
using RimeLib.Mesh.Sets;
using Matrix4x4 = System.Numerics.Matrix4x4;
using MeshLayoutCookie = RimeLib.Mesh.Frostbite2_0.Frostbite.MeshLayoutCookie;
using Vector3 = System.Numerics.Vector3;
using Vector4 = System.Numerics.Vector4;

namespace RimeLib.Mesh.Frostbite2013_2;

/// <summary>
/// Reads and writes Frostbite 2013.2 MeshSets as <see cref="MeshSetModel"/>s. A subset's trailing
/// bytes and the unused slots of its vertex declaration are not in the model; they come from the
/// template's subset at the same place.
/// </summary>
public class MeshSetCodec : IMeshSetCodec
{
    /// <summary>A slot the writer points at what it places, if the slot is not null.</summary>
    private const ulong Placed = 1;

    private static readonly HashSet<VertexUsage> s_Usages = Enum.GetValues<VertexUsage>()
        .Where(p_Usage => EngineEnums.TryToEngine<VertexElementUsage>(p_Usage, out _))
        .ToHashSet();

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public int MaxLodCount => MeshSetLayout.MaxLodCount;

    public IReadOnlyCollection<VertexUsage> Usages => s_Usages;

    public MeshSetModel Decode(MeshSetPayload p_Payload)
    {
        var s_Set = Read(p_Payload);
        var s_Layout = s_Set.Layout;
        var s_Lods = s_Set.Lods;
        if (s_Layout.Lods.Skip(s_Lods.Count).Any(p_Lod => p_Lod.BaseAddress != 0))
            throw new InvalidDataException("a LOD pointer past the LOD count");
        if (s_Layout.TotalSubsetCount != s_Lods.Sum(p_Lod => p_Lod.Subsets.Count))
            throw new InvalidDataException($"a total subset count of {s_Layout.TotalSubsetCount} for {s_Lods.Sum(p_Lod => p_Lod.Subsets.Count)} subsets");

        return new MeshSetModel
        {
            Name = Required(s_Layout.Name, "MeshSet name"),
            ShortName = s_Layout.ShortName.Object,
            NameHash = s_Layout.NameHash,
            Kind = EngineEnums.ToModel<MeshKind>(s_Layout.MeshType),
            Flags = (MeshFlags)(uint)s_Layout.Flags,
            BoundsMin = ToVector(s_Layout.BoundingBox.min),
            BoundsMax = ToVector(s_Layout.BoundingBox.max),
            Lods = s_Lods.Select(DecodeLod).ToList(),
            EmbeddedData = s_Set.EmbeddedData,
        };
    }

    public MeshSetPayload Encode(MeshSetModel p_Model, MeshSetPayload? p_Template = null)
    {
        if (p_Model.Lods.Count > MaxLodCount)
            throw new InvalidDataException($"{p_Model.Lods.Count} LODs, of which this engine's MeshSet holds {MaxLodCount}");

        var s_Template = p_Template == null ? null : Read(p_Template).Lods;
        var s_Lods = p_Model.Lods.Select((p_Lod, i) => EncodeLod(p_Lod, s_Template?.ElementAtOrDefault(i))).ToList();
        var s_Set = new MeshSetResource
        {
            Layout = new MeshSetLayout
            {
                MeshType = EngineEnums.ToEngine<MeshType>(p_Model.Kind),
                Flags = (MeshLayoutFlags)p_Model.Flags,
                LodCount = (ushort)s_Lods.Count,
                TotalSubsetCount = (ushort)s_Lods.Sum(p_Lod => p_Lod.Subsets.Count),
                BoundingBox = new AxisAlignedBox { min = ToVec3(p_Model.BoundsMin), max = ToVec3(p_Model.BoundsMax) },
                Lods = Enumerable.Range(0, MaxLodCount)
                    .Select(i => i < s_Lods.Count ? new RelocPtr<MeshLayout>(s_Lods[i]) : new RelocPtr<MeshLayout>())
                    .ToArray(),
                Name = new RelocPtr<string>(p_Model.Name),
                ShortName = p_Model.ShortName == null ? new RelocPtr<string>() : new RelocPtr<string>(p_Model.ShortName),
                NameHash = p_Model.NameHash,
            },
            EmbeddedData = p_Model.EmbeddedData,
        };

        s_Set.Serialize(out var s_Data);
        return new MeshSetPayload(s_Data!, s_Set.Cookie.ToArray());
    }

    private static MeshSetResource Read(MeshSetPayload p_Payload)
    {
        var s_Set = new MeshSetResource { Cookie = ResourceCookie.Read<MeshLayoutCookie>(p_Payload.Meta) };
        s_Set.Deserialize(p_Payload.Data);
        return s_Set;
    }

    private static MeshLodModel DecodeLod(MeshLayout p_Lod)
    {
        Check(p_Lod.CategorySubsetIndices.All(p_Indices => p_Indices.Get.Length == p_Indices.Count), "category subset indices without their array");

        var s_Count = (int)p_Lod.BoneOrPartCount;
        switch (p_Lod.Type)
        {
            case MeshType.MeshType_Skinned:
                Check(p_Lod.BoneIndexArray.Get.Length == s_Count && p_Lod.BoneShortNameArray.Get.Length == s_Count, "bone arrays without their bones");
                break;
            case MeshType.MeshType_Composite:
                Check(p_Lod.PartTransforms.Get.Length == s_Count && p_Lod.PartBoundingBoxes.Get.Length == 2 * s_Count
                    && p_Lod.SubsetPartIndices.Get.Length == MeshLayout.PartMaskSize * p_Lod.Subsets.Count, "part arrays without their parts");
                break;
        }

        return new MeshLodModel
        {
            Kind = EngineEnums.ToModel<MeshKind>(p_Lod.Type),
            MaxStreamInstanceCount = p_Lod.MaxInstances,
            Subsets = p_Lod.Subsets.Get.Select(DecodeSubset).ToList(),
            CategorySubsetIndices = p_Lod.CategorySubsetIndices.Select(p_Indices => p_Indices.Get).ToList(),
            Flags = (MeshFlags)(uint)p_Lod.Flags,
            IndexSize = p_Lod.IndexBufferFormat switch
            {
                IndexBufferFormat.IndexBufferFormat_16Bit => 2,
                IndexBufferFormat.IndexBufferFormat_32Bit => 4,
                _ => throw new InvalidDataException($"index buffer format {p_Lod.IndexBufferFormat}"),
            },
            IndexDataSize = p_Lod.IndexDataSize,
            VertexDataSize = p_Lod.VertexDataSize,
            EdgePartitionBufferSize = p_Lod.EdgePartitionBufferSize,
            ChunkId = p_Lod.DataChunkId,
            AuxVertexIndexDataOffset = p_Lod.AuxVertexIndexDataOffset,
            HasEmbeddedEdgeData = p_Lod.EmbeddedEdgeData.BaseAddress != 0,
            ShaderDebugName = Required(p_Lod.ShaderDebugName, "shader debug name"),
            Name = Required(p_Lod.Name, "LOD name"),
            ShortName = Required(p_Lod.ShortName, "LOD short name"),
            NameHash = p_Lod.NameHash,
            Bones = p_Lod.BoneIndexArray.Get,
            BoneShortNames = p_Lod.BoneShortNameArray.Get,
            PartBoundingBoxes = p_Lod.PartBoundingBoxes.Get,
            PartTransforms = p_Lod.PartTransforms.Get,
            SubsetPartIndices = p_Lod.SubsetPartIndices.Get,
        };
    }

    private static MeshLayout EncodeLod(MeshLodModel p_Lod, MeshLayout? p_Template)
    {
        var s_Type = EngineEnums.ToEngine<MeshType>(p_Lod.Kind);
        var s_Count = p_Lod.Kind switch
        {
            MeshKind.Skinned => p_Lod.Bones.Length,
            MeshKind.Composite => p_Lod.PartTransforms.Length,
            _ => 0,
        };
        Check(p_Lod.CategorySubsetIndices.Count == (int)MeshSubsetCategory.MeshSubsetCategoryCount, $"{p_Lod.CategorySubsetIndices.Count} subset categories");
        Check(p_Lod.Kind != MeshKind.Skinned || p_Lod.BoneShortNames.Length == s_Count, "a skinned LOD whose bones and bone short names differ in count");
        Check(p_Lod.Kind != MeshKind.Composite || (p_Lod.PartBoundingBoxes.Length == 2 * s_Count
            && p_Lod.SubsetPartIndices.Length == MeshLayout.PartMaskSize * p_Lod.Subsets.Count), "a composite LOD without bounds for each part or a part mask for each subset");

        return new MeshLayout
        {
            Type = s_Type,
            MaxInstances = p_Lod.MaxStreamInstanceCount,
            Subsets = new RelocArray<MeshSubset>(p_Lod.Subsets.Select((p_Subset, i) => EncodeSubset(p_Subset, p_Template?.Subsets.Get.ElementAtOrDefault(i)))),
            CategorySubsetIndices = p_Lod.CategorySubsetIndices.Select(p_Indices => new RelocArray<byte>(p_Indices)).ToArray(),
            Flags = (MeshLayoutFlags)p_Lod.Flags,
            IndexBufferFormat = p_Lod.IndexSize switch
            {
                2 => IndexBufferFormat.IndexBufferFormat_16Bit,
                4 => IndexBufferFormat.IndexBufferFormat_32Bit,
                _ => throw new InvalidDataException($"{p_Lod.IndexSize} byte indices"),
            },
            IndexDataSize = p_Lod.IndexDataSize,
            VertexDataSize = p_Lod.VertexDataSize,
            EdgePartitionBufferSize = p_Lod.EdgePartitionBufferSize,
            DataChunkId = p_Lod.ChunkId,
            AuxVertexIndexDataOffset = p_Lod.AuxVertexIndexDataOffset,
            EmbeddedEdgeData = new RelocPtr<byte> { BaseAddress = p_Lod.HasEmbeddedEdgeData ? Placed : 0 },
            ShaderDebugName = new RelocPtr<string>(p_Lod.ShaderDebugName),
            Name = new RelocPtr<string>(p_Lod.Name),
            ShortName = new RelocPtr<string>(p_Lod.ShortName),
            NameHash = p_Lod.NameHash,
            BoneOrPartCount = (uint)s_Count,
            BoneIndexArray = new RelocPtrArray<uint> { Get = p_Lod.Bones },
            BoneShortNameArray = new RelocPtrArray<uint> { Get = p_Lod.BoneShortNames },
            PartBoundingBoxes = new RelocPtrArray<Vector4> { Get = p_Lod.PartBoundingBoxes },
            PartTransforms = new RelocPtrArray<Matrix4x4> { Get = p_Lod.PartTransforms },
            SubsetPartIndices = new RelocPtrArray<byte> { Get = p_Lod.SubsetPartIndices },
        };
    }

    private static MeshSubsetModel DecodeSubset(MeshSubset p_Subset)
    {
        return new MeshSubsetModel
        {
            MaterialName = Required(p_Subset.MaterialName, "material name"),
            MaterialIndex = p_Subset.MaterialIndex,
            PrimitiveCount = p_Subset.PrimitiveCount,
            StartIndex = p_Subset.StartIndex,
            VertexOffset = p_Subset.VertexOffset,
            VertexCount = p_Subset.VertexCount,
            VertexStride = p_Subset.VertexStride,
            Primitive = EngineEnums.ToModel<MeshPrimitive>(p_Subset.PrimitiveType),
            BonesPerVertex = p_Subset.BonesPerVertex,
            BoneCount = p_Subset.BoneCount,
            BoneIndices = p_Subset.BoneIndices.BaseAddress != 0 ? p_Subset.BoneIndices.Get : null,
            Elements = p_Subset.GeometryDeclarationDesc.Elements
                .Select(p_E => new VertexElement(EngineEnums.ToModel<VertexUsage>(p_E.Usage), EngineEnums.ToModel<VertexFormat>(p_E.Format), p_E.Offset, p_E.StreamIndex))
                .ToList(),
            Streams = p_Subset.GeometryDeclarationDesc.Streams
                .Select(p_S => new VertexStream(p_S.Stride, EngineEnums.ToModel<VertexClassification>(p_S.Classification)))
                .ToList(),
            TexCoordRatios = p_Subset.TexCoordRatios.AsArray,
        };
    }

    private static MeshSubset EncodeSubset(MeshSubsetModel p_Subset, MeshSubset? p_Template)
    {
        Check(p_Subset.TexCoordRatios.Length == 6, $"{p_Subset.TexCoordRatios.Length} texture coordinate ratios");
        Check(p_Subset.BoneIndices == null || p_Subset.BoneIndices.Length == p_Subset.BoneCount, $"{p_Subset.BoneIndices?.Length} bone indices for {p_Subset.BoneCount} bones");

        var s_Subset = new MeshSubset
        {
            MaterialName = new RelocPtr<string>(p_Subset.MaterialName),
            MaterialIndex = p_Subset.MaterialIndex,
            PrimitiveCount = p_Subset.PrimitiveCount,
            StartIndex = p_Subset.StartIndex,
            VertexOffset = p_Subset.VertexOffset,
            VertexCount = p_Subset.VertexCount,
            VertexStride = p_Subset.VertexStride,
            PrimitiveType = EngineEnums.ToEngine<PrimitiveType>(p_Subset.Primitive),
            BonesPerVertex = p_Subset.BonesPerVertex,
            BoneCount = p_Subset.BoneCount,
            BoneIndices = p_Subset.BoneIndices == null
                ? new RelocPtrArray<ushort>()
                : new RelocPtrArray<ushort> { BaseAddress = Placed, Get = p_Subset.BoneIndices },
            GeometryDeclarationDesc = new GeometryDeclarationDesc
            {
                Elements = p_Subset.Elements.Select(p_E => new GeometryDeclarationDesc.Element
                {
                    Usage = EngineEnums.ToEngine<VertexElementUsage>(p_E.Usage),
                    Format = EngineEnums.ToEngine<VertexElementFormat>(p_E.Format),
                    Offset = p_E.Offset,
                    StreamIndex = p_E.StreamIndex,
                }).ToList(),
                Streams = p_Subset.Streams.Select(p_S => new GeometryDeclarationDesc.Stream
                {
                    Stride = p_S.Stride,
                    Classification = EngineEnums.ToEngine<VertexElementClassification>(p_S.Classification),
                }).ToList(),
            },
            TexCoordRatios = new Array<float>(p_Subset.TexCoordRatios.ToList()),
        };

        if (p_Template != null)
        {
            s_Subset.Trailing = p_Template.Trailing;
            s_Subset.GeometryDeclarationDesc.UnusedElements = p_Template.GeometryDeclarationDesc.UnusedElements;
            s_Subset.GeometryDeclarationDesc.UnusedStreams = p_Template.GeometryDeclarationDesc.UnusedStreams;
        }

        return s_Subset;
    }

    private static string Required(RelocPtr<string> p_String, string p_What) =>
        p_String.Object ?? throw new InvalidDataException($"a MeshSet without a {p_What}");

    private static void Check(bool p_Condition, string p_What)
    {
        if (!p_Condition)
            throw new InvalidDataException(p_What);
    }

    private static Vector3 ToVector(Vec3 p_Vec) => new(p_Vec.x, p_Vec.y, p_Vec.z);

    private static Vec3 ToVec3(Vector3 p_Vector) => new() { x = p_Vector.X, y = p_Vector.Y, z = p_Vector.Z };
}
