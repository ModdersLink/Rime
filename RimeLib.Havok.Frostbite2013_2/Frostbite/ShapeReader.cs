using System.Collections.Generic;
using System.IO;
using System.Numerics;
using RimeLib.Havok;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2013_2.Frostbite;

/// <summary>
/// The collision shapes of a Havok 2012.2 packfile (Frostbite 2013.2). The shapes Havok 2010
/// already had read as there, except that hkpConvexVerticesShape puts m_useSpuBuffer before its
/// planes and hkpConvexTransformShape holds an hkQsTransform; hkpStaticCompoundShape and
/// hkpBvCompressedMeshShape are new.
/// </summary>
public class ShapeReader : Frostbite2_0.Frostbite.ShapeReader
{
    protected override int PlanesOffset => 84;
    protected override int ConnectivityOffset => 96;

    // Havok 2012: hkpConvexTransformShape holds an hkQsTransform (translation, rotation quaternion,
    // scale) at +32 and an extra scale at +80, in place of Havok 2010's hkTransform.
    private const int c_QsTransformOffset = 32;

    /// <summary>An hkQsTransform as a placement: translation, rotation quaternion (x, y, z, w), scale.</summary>
    public static hkpPlacement ReadQsTransform(LimitedRimeReader p_Reader, long p_At)
    {
        var s_Translation = At(p_Reader, p_At).ReadVector3();
        p_Reader.Seek(p_At + 16, SeekOrigin.Begin);
        float x = p_Reader.ReadSingle(), y = p_Reader.ReadSingle(), z = p_Reader.ReadSingle(), w = p_Reader.ReadSingle();
        var s_Scale = At(p_Reader, p_At + 32).ReadVector3();

        return hkpPlacement.FromQsTransform(s_Translation, new Quaternion(x, y, z, w), s_Scale);
    }

    public override (hkpPlacement Placement, long Child)? ReadTransformShape(
        LimitedRimeReader p_Reader, long p_DataStart, long p_Offset, IReadOnlyDictionary<long, long> p_ObjectOffsets)
    {
        if (!p_ObjectOffsets.TryGetValue(p_Offset + c_ChildOffset, out var s_Child))
            return null;

        return (ReadQsTransform(p_Reader, p_DataStart + p_Offset + c_QsTransformOffset), s_Child);
    }

    // hkpStaticCompoundShape: hkArray<Instance> at +32; an Instance is an hkQsTransform, the child
    // shape pointer, filter info, child filter info mask and user data, 64 bytes.
    private const int c_CompoundInstancesOffset = 32;
    private const int c_CompoundInstanceSize = 64;
    private const int c_CompoundInstanceShapeOffset = 48;

    /// <summary>The instances of an hkpStaticCompoundShape: each one's placement and child shape.</summary>
    public override List<(hkpPlacement Placement, long Child, long Instance)>? ReadStaticCompound(
        LimitedRimeReader p_Reader, long p_DataStart, long p_Offset,
        IReadOnlyDictionary<long, long> p_ArrayOffsets, IReadOnlyDictionary<long, long> p_ObjectOffsets)
    {
        var s_Result = new List<(hkpPlacement, long, long)>();
        var s_Count = At(p_Reader, p_DataStart + p_Offset + c_CompoundInstancesOffset + 4).ReadUInt32();
        if (s_Count == 0 || !p_ArrayOffsets.TryGetValue(p_Offset + c_CompoundInstancesOffset, out var s_Instances))
            return s_Result;

        for (var i = 0; i < s_Count; ++i)
        {
            var s_Instance = s_Instances + i * c_CompoundInstanceSize;
            if (p_ObjectOffsets.TryGetValue(s_Instance + c_CompoundInstanceShapeOffset, out var s_Child))
                s_Result.Add((ReadQsTransform(p_Reader, p_DataStart + s_Instance), s_Child, s_Instance));
        }

        return s_Result;
    }

    // hkpBvCompressedMeshShape: its hkpBvCompressedMeshShapeTree inline at +80, an
    // hkcdStaticMeshTree<CommonConfig<u32, u64, 11, 21>> over hkcdStaticMeshTreeBase.
    private const int c_MeshTreeOffset = 80;
    private const int c_TreeDomainOffset = 16;
    private const int c_TreeSectionsOffset = 60;
    private const int c_TreePrimitivesOffset = 72;
    private const int c_TreeSharedVerticesIndexOffset = 84;
    private const int c_TreePackedVerticesOffset = 96;
    private const int c_TreeSharedVerticesOffset = 108;

    // hkcdStaticMeshTreeBase::Section, 96 bytes: its own tree (domain at +16), the codec (origin and
    // scale, six floats), the first packed vertex, and three ranges packed as offset << 8 in the
    // upper bits: the primitives' and data runs' low byte is their count, the shared vertices' the
    // section's packed vertex count, with the shared count in its own byte.
    private const int c_SectionSize = 96;
    private const int c_SectionCodecOffset = 48;
    private const int c_SectionFirstPackedVertexOffset = 72;
    private const int c_SectionSharedVerticesOffset = 76;
    private const int c_SectionPrimitivesOffset = 80;
    private const int c_SectionNumPackedVerticesOffset = 88;
    private const int c_SectionNumSharedIndicesOffset = 89;

    // Tolerance for a decoded vertex outside its section's box: quantisation and float rounding.
    private const float c_DomainTolerance = 0.05f;

    /// <summary>
    /// Decodes an hkpBvCompressedMeshShape into a mesh. Packed vertices are 11, 11 and 10 bits against
    /// the section's origin and scale, shared ones 21, 21 and 22 bits across the tree's domain. A
    /// primitive is four indices into the section's packed then shared vertices (a triangle repeats
    /// its third). Null when an index or vertex falls outside its section, as a mis-read layout does.
    /// </summary>
    public override hkpCollisionShape? ReadBvCompressedMesh(LimitedRimeReader p_Reader, long p_DataStart, long p_Offset,
        IReadOnlyDictionary<long, long> p_ArrayOffsets)
    {
        var s_Tree = p_Offset + c_MeshTreeOffset;
        long? Array(int p_Slot) => p_ArrayOffsets.TryGetValue(s_Tree + p_Slot, out var s_At) ? s_At : null;
        uint Count(int p_Slot) => At(p_Reader, p_DataStart + s_Tree + p_Slot + 4).ReadUInt32();

        var s_Shape = new hkpCollisionShape { Kind = "mesh", Offset = p_Offset };
        var s_SectionCount = Count(c_TreeSectionsOffset);
        if (s_SectionCount == 0)
            return s_Shape;

        if (Array(c_TreeSectionsOffset) is not { } s_Sections || Array(c_TreePrimitivesOffset) is not { } s_Primitives)
            return null;

        var s_DomainMin = At(p_Reader, p_DataStart + s_Tree + c_TreeDomainOffset).ReadVector3();
        var s_DomainMax = At(p_Reader, p_DataStart + s_Tree + c_TreeDomainOffset + 16).ReadVector3();
        var s_SharedScale = (s_DomainMax - s_DomainMin) / new Vector3((1 << 21) - 1, (1 << 21) - 1, (1 << 22) - 1);
        var s_PackedVertices = Array(c_TreePackedVerticesOffset);
        var s_SharedIndex = Array(c_TreeSharedVerticesIndexOffset);
        var s_SharedVertices = Array(c_TreeSharedVerticesOffset);

        for (var i = 0; i < s_SectionCount; ++i)
        {
            var s_Section = p_DataStart + s_Sections + i * c_SectionSize;
            var s_Min = At(p_Reader, s_Section + c_TreeDomainOffset).ReadVector3() - new Vector3(c_DomainTolerance);
            var s_Max = At(p_Reader, s_Section + c_TreeDomainOffset + 16).ReadVector3() + new Vector3(c_DomainTolerance);
            var s_Origin = At(p_Reader, s_Section + c_SectionCodecOffset).ReadVector3();
            var s_Scale = At(p_Reader, s_Section + c_SectionCodecOffset + 12).ReadVector3();
            var s_FirstPacked = At(p_Reader, s_Section + c_SectionFirstPackedVertexOffset).ReadUInt32();
            var s_Shared = At(p_Reader, s_Section + c_SectionSharedVerticesOffset).ReadUInt32();
            var s_Prims = At(p_Reader, s_Section + c_SectionPrimitivesOffset).ReadUInt32();
            p_Reader.Seek(s_Section + c_SectionNumPackedVerticesOffset, SeekOrigin.Begin);
            var s_PackedCount = (int)p_Reader.ReadUByte();
            var s_SharedCount = (int)p_Reader.ReadUByte();

            var s_Base = s_Shape.Vertices.Count;
            for (var j = 0; j < s_PackedCount; ++j)
            {
                if (s_PackedVertices == null)
                    return null;
                var v = At(p_Reader, p_DataStart + s_PackedVertices.Value + (s_FirstPacked + j) * 4).ReadUInt32();
                s_Shape.Vertices.Add(s_Origin + new Vector3(v & 0x7FF, (v >> 11) & 0x7FF, v >> 22) * s_Scale);
            }

            for (var j = 0; j < s_SharedCount; ++j)
            {
                if (s_SharedIndex == null || s_SharedVertices == null)
                    return null;
                p_Reader.Seek(p_DataStart + s_SharedIndex.Value + ((s_Shared >> 8) + j) * 2, SeekOrigin.Begin);
                var s_Index = p_Reader.ReadUInt16();
                p_Reader.Seek(p_DataStart + s_SharedVertices.Value + s_Index * 8L, SeekOrigin.Begin);
                var v = p_Reader.ReadUInt64();
                s_Shape.Vertices.Add(s_DomainMin + new Vector3(v & 0x1FFFFF, (v >> 21) & 0x1FFFFF, v >> 42) * s_SharedScale);
            }

            for (var j = s_Base; j < s_Shape.Vertices.Count; ++j)
            {
                var s_V = s_Shape.Vertices[j];
                if (s_V.X < s_Min.X || s_V.Y < s_Min.Y || s_V.Z < s_Min.Z || s_V.X > s_Max.X || s_V.Y > s_Max.Y || s_V.Z > s_Max.Z)
                    return null;
            }

            var s_SectionVertices = s_Shape.Vertices.Count - s_Base;
            for (var j = 0; j < (s_Prims & 0xFF); ++j)
            {
                p_Reader.Seek(p_DataStart + s_Primitives + ((s_Prims >> 8) + j) * 4, SeekOrigin.Begin);
                int a = p_Reader.ReadUByte(), b = p_Reader.ReadUByte(), c = p_Reader.ReadUByte(), d = p_Reader.ReadUByte();

                // An unused primitive slot is filled with DE AD DE AD.
                if (a == 0xDE && b == 0xAD && c == 0xDE && d == 0xAD)
                    continue;

                if (a >= s_SectionVertices || b >= s_SectionVertices || c >= s_SectionVertices || d >= s_SectionVertices)
                    return null;

                s_Shape.Indices.AddRange(new[] { s_Base + a, s_Base + b, s_Base + c });
                if (c != d)
                    s_Shape.Indices.AddRange(new[] { s_Base + a, s_Base + c, s_Base + d });
            }
        }

        return s_Shape;
    }

}
