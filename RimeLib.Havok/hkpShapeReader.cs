using System.Numerics;
using RimeLib.IO;

namespace RimeLib.Havok;

/// <summary>
/// Reads hkpBoxShape / hkpConvexVerticesShape / hkpConvexTranslateShape out of a packfile's data
/// section.
///
/// The offsets are the 32-bit pointer layout, which is the instance BF3 ships and the one Rime's
/// transform reader already walks. They were measured against real resources rather than taken from
/// a header: a box's half-extents sit at +32 with the x component repeated in w, and a convex hull's
/// vertices are hkFourTransposedPoints -- four points as three vectors (all x, then all y, then all
/// z), which is why vertex counts are padded to a multiple of four.
/// </summary>
public static class hkpShapeReader
{
    // hkpConvexShape
    private const int c_RadiusOffset = 16;

    // hkpConvexTranslateShape / hkpConvexTransformShape share hkpConvexTransformShapeBase, so the
    // child pointer sits at the same place in both.
    private const int c_ChildOffset = 24;
    private const int c_TranslationOffset = 32;

    // hkpConvexTransformShape: an hkTransform, which is three rotation COLUMNS then the
    // translation. MEASURED on BigRadioTower's 67 transforms -- the three vectors at +32, +48 and
    // +64 are unit length and their determinant is 1, and the fourth is the only one that is not,
    // which is what a rigid transform looks like and what a mis-read offset would not.
    private const int c_TransformRotationOffset = 32;
    private const int c_TransformTranslationOffset = 80;

    // hkpCylinderShape. Sizes confirm the layout: 96 bytes = 32 of header and radii, then four
    // vectors, of which the last two are the unit perpendiculars this does not need.
    private const int c_CylinderRadiusOffset = 20;

    // hkpCylinderShape and hkpCapsuleShape both put the axis ends here; the capsule is 64 bytes,
    // which is exactly the header plus these two and nothing else.
    private const int c_VertexAOffset = 32;
    private const int c_VertexBOffset = 48;

    // hkpBoxShape
    private const int c_HalfExtentsOffset = 32;

    // hkpConvexVerticesShape. Havok 2012 puts m_useSpuBuffer before the planes.
    private const int c_RotatedVerticesOffset = 64;
    private const int c_VertexCountOffset = 76;
    private const int c_PlanesOffset = 80;
    private const int c_ConnectivityOffset = 92;
    private const int c_PlanesOffset2012 = 84;
    private const int c_ConnectivityOffset2012 = 96;

    // hkpStorageExtendedMeshShapeMeshSubpartStorage. Its hkArrays start at +8 with a 12-byte
    // stride (pointer, size, capacity), and the payloads sit inline after a 112-byte header.
    private const int c_SubpartVerticesSlot = 8;

    // The index array is in one of three slots depending on how wide the indices are, and BF3 uses
    // all three: 61 subparts store 8-bit indices, 7 store 16-bit and 24 store 32-bit.
    private static readonly int[] s_SubpartIndexSlots = { 20, 32, 44 };

    /// <summary>Four points held as three vectors: 12 floats.</summary>
    private const int c_FourTransposedPoints = 48;

    /// <summary>The reader, moved to <paramref name="p_At"/>.</summary>
    private static LimitedRimeReader At(LimitedRimeReader p_Reader, long p_At)
    {
        p_Reader.Seek(p_At, SeekOrigin.Begin);
        return p_Reader;
    }

    public static hkpCollisionShape ReadBox(LimitedRimeReader p_Reader, long p_DataStart,
                                            long p_Offset)
    {
        return new hkpCollisionShape
        {
            Kind = "box",
            Offset = p_Offset,
            Radius = At(p_Reader, p_DataStart + p_Offset + c_RadiusOffset).ReadSingle(),
            HalfExtents = At(p_Reader, p_DataStart + p_Offset + c_HalfExtentsOffset).ReadVector3()
        };
    }

    public static hkpCollisionShape ReadConvex(LimitedRimeReader p_Reader, long p_DataStart,
                                               long p_Offset,
                                               IReadOnlyDictionary<long, long> p_ArrayOffsets,
                                               IReadOnlyDictionary<long, long>? p_ObjectOffsets = null,
                                               bool p_Havok2012 = false)
    {
        var c_PlanesOffset = p_Havok2012 ? c_PlanesOffset2012 : hkpShapeReader.c_PlanesOffset;
        var c_ConnectivityOffset = p_Havok2012 ? c_ConnectivityOffset2012 : hkpShapeReader.c_ConnectivityOffset;

        var s_Shape = new hkpCollisionShape
        {
            Kind = "convex",
            Offset = p_Offset,
            Radius = At(p_Reader, p_DataStart + p_Offset + c_RadiusOffset).ReadSingle(),

            // A null connectivity pointer has no fixup, so the fixup table is the record of whether
            // there is one -- reading the slot itself would only ever see the zero the relocation
            // has not been applied to.
            HasConnectivity = p_ObjectOffsets != null
                              && p_ObjectOffsets.ContainsKey(p_Offset + c_ConnectivityOffset)
        };

        // Planes first: hkArray is pointer then count, and the count lives one pointer in.
        var s_PlaneCount = At(p_Reader, p_DataStart + p_Offset + c_PlanesOffset + 4).ReadUInt32();

        if (s_PlaneCount > 0 && p_ArrayOffsets.TryGetValue(p_Offset + c_PlanesOffset,
                                                           out var s_PlanesAt))
        {
            for (var i = 0; i < s_PlaneCount; i++)
            {
                p_Reader.Seek(p_DataStart + s_PlanesAt + i * 16, SeekOrigin.Begin);
                s_Shape.Planes.Add(new Vector4(p_Reader.ReadSingle(), p_Reader.ReadSingle(),
                                               p_Reader.ReadSingle(), p_Reader.ReadSingle()));
            }
        }

        var s_Count = At(p_Reader, p_DataStart + p_Offset + c_VertexCountOffset).ReadUInt32();

        if (s_Count == 0 || !p_ArrayOffsets.TryGetValue(p_Offset + c_RotatedVerticesOffset,
                                                        out var s_Blocks))
            return s_Shape;

        // Padded to a multiple of four, because that is how the SIMD layout stores them.
        var s_BlockCount = (s_Count + 3) / 4;

        for (var i = 0; i < s_BlockCount; i++)
        {
            p_Reader.Seek(p_DataStart + s_Blocks + i * c_FourTransposedPoints, SeekOrigin.Begin);

            var s_X = new[] { p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle() };
            var s_Y = new[] { p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle() };
            var s_Z = new[] { p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle() };

            for (var k = 0; k < 4 && s_Shape.Vertices.Count < s_Count; k++)
                s_Shape.Vertices.Add(new Vector3(s_X[k], s_Y[k], s_Z[k]));
        }

        return s_Shape;
    }

    /// <summary>
    /// hkpCylinderShape: a barrel between two points.
    ///
    /// The convex radius and the CYLINDER radius are two different numbers 0.16 and 3.81 apart on
    /// BigRadioTower's masts, so they are kept apart here too.
    /// </summary>
    public static hkpCollisionShape ReadCylinder(LimitedRimeReader p_Reader, long p_DataStart,
                                                 long p_Offset)
    {
        return new hkpCollisionShape
        {
            Kind = "cylinder",
            Offset = p_Offset,
            Radius = At(p_Reader, p_DataStart + p_Offset + c_RadiusOffset).ReadSingle(),
            CylinderRadius = At(p_Reader, p_DataStart + p_Offset + c_CylinderRadiusOffset).ReadSingle(),
            VertexA = At(p_Reader, p_DataStart + p_Offset + c_VertexAOffset).ReadVector3(),
            VertexB = At(p_Reader, p_DataStart + p_Offset + c_VertexBOffset).ReadVector3()
        };
    }

    /// <summary>hkpCapsuleShape: a cylinder whose ends are the convex radius rounded off.</summary>
    public static hkpCollisionShape ReadCapsule(LimitedRimeReader p_Reader, long p_DataStart,
                                                long p_Offset)
    {
        return new hkpCollisionShape
        {
            Kind = "capsule",
            Offset = p_Offset,
            Radius = At(p_Reader, p_DataStart + p_Offset + c_RadiusOffset).ReadSingle(),
            VertexA = At(p_Reader, p_DataStart + p_Offset + c_VertexAOffset).ReadVector3(),
            VertexB = At(p_Reader, p_DataStart + p_Offset + c_VertexBOffset).ReadVector3()
        };
    }

    /// <summary>hkpSphereShape: 32 bytes, and the convex radius IS the sphere.</summary>
    public static hkpCollisionShape ReadSphere(LimitedRimeReader p_Reader, long p_DataStart,
                                               long p_Offset)
    {
        return new hkpCollisionShape
        {
            Kind = "sphere",
            Offset = p_Offset,
            Radius = At(p_Reader, p_DataStart + p_Offset + c_RadiusOffset).ReadSingle()
        };
    }

    /// <summary>
    /// The triangle mesh inside an hkpStorageExtendedMeshShapeMeshSubpartStorage, or null if what
    /// is there does not check out.
    ///
    /// Nothing about the element width is assumed. An hkArray's payload is inline and the next
    /// payload begins where this one ends, so the array's FOOTPRINT is known, and the element size
    /// is the one of 4, 2 or 1 that the footprint fits with only 16-byte alignment left over. It is
    /// then required that every index addresses a vertex that exists -- so a wrong width is
    /// rejected instead of producing confident garbage. MEASURED: all 92 subpart storages BF3 ships
    /// decode, 0 rejected, 14,017 vertices and 16,306 triangles.
    /// </summary>
    public static hkpCollisionShape? ReadStorageMesh(LimitedRimeReader p_Reader, long p_DataStart,
                                                     long p_Offset, long p_ObjectEnd,
                                                     IReadOnlyDictionary<long, long> p_ArrayOffsets)
    {
        // Where each of this object's inline payloads begins, in order, so one payload's end is the
        // next one's start.
        var s_Payloads = p_ArrayOffsets.Where(p => p.Key >= p_Offset && p.Key < p_ObjectEnd)
                                       .Select(p => p.Value).Distinct().OrderBy(o => o).ToList();

        long EndOf(long p_Payload)
        {
            foreach (var l_Start in s_Payloads)
                if (l_Start > p_Payload)
                    return l_Start;

            return p_ObjectEnd;
        }

        if (!p_ArrayOffsets.TryGetValue(p_Offset + c_SubpartVerticesSlot, out var s_VerticesAt))
            return null;

        var s_VertexCount = (int) At(p_Reader, p_DataStart + p_Offset + c_SubpartVerticesSlot + 4).ReadUInt32();

        if (s_VertexCount <= 0 || EndOf(s_VerticesAt) - s_VerticesAt < (long) s_VertexCount * 16)
            return null;

        var s_Shape = new hkpCollisionShape { Kind = "mesh", Offset = p_Offset };

        for (var i = 0; i < s_VertexCount; ++i)
            s_Shape.Vertices.Add(At(p_Reader, p_DataStart + s_VerticesAt + i * 16).ReadVector3());

        foreach (var l_Slot in s_SubpartIndexSlots)
        {
            if (!p_ArrayOffsets.TryGetValue(p_Offset + l_Slot, out var s_IndicesAt))
                continue;

            var s_Count = (int) At(p_Reader, p_DataStart + p_Offset + l_Slot + 4).ReadUInt32();

            // Four indices per triangle, of which three are corners.
            if (s_Count <= 0 || s_Count % 4 != 0)
                continue;

            var s_Span = EndOf(s_IndicesAt) - s_IndicesAt;

            foreach (var l_Width in new[] { 4, 2, 1 })
            {
                if ((long) s_Count * l_Width > s_Span || s_Span - (long) s_Count * l_Width >= 16)
                    continue;

                var s_Indices = new List<int>(s_Count);
                var s_InRange = true;

                for (var i = 0; i < s_Count; ++i)
                {
                    p_Reader.Seek(p_DataStart + s_IndicesAt + (long) i * l_Width, SeekOrigin.Begin);

                    var s_Index = l_Width switch
                    {
                        4 => (int) p_Reader.ReadUInt32(),
                        2 => p_Reader.ReadUInt16(),
                        _ => p_Reader.ReadUByte()
                    };

                    if (s_Index >= s_VertexCount)
                    {
                        s_InRange = false;
                        break;
                    }

                    s_Indices.Add(s_Index);
                }

                if (!s_InRange)
                    continue;

                for (var i = 0; i + 3 < s_Indices.Count + 1; i += 4)
                {
                    s_Shape.Indices.Add(s_Indices[i]);
                    s_Shape.Indices.Add(s_Indices[i + 1]);
                    s_Shape.Indices.Add(s_Indices[i + 2]);
                }

                return s_Shape;
            }
        }

        return null;
    }

    /// <summary>
    /// The rotation, translation and child of an hkpConvexTransformShape, or null if the child
    /// resolves to nothing.
    /// </summary>
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

    public static (hkpPlacement Placement, long Child)? ReadQsTransformShape(
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
    public static List<(hkpPlacement Placement, long Child, long Instance)> ReadStaticCompound(
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
    /// Decodes an hkpBvCompressedMeshShape into a mesh. Each section stores its vertices quantised:
    /// packed vertices in 11, 11 and 10 bits against the section's origin and scale, shared vertices
    /// in 21, 21 and 22 bits across the whole tree's domain. A primitive is four vertex indices into
    /// the section's packed then shared vertices; a triangle repeats its third index, and an unused
    /// slot is DE AD DE AD. Null when a
    /// primitive indexes past its vertices or a vertex falls outside its section's box, which is
    /// what a mis-read layout produces.
    /// </summary>
    public static hkpCollisionShape? ReadBvCompressedMesh(LimitedRimeReader p_Reader, long p_DataStart, long p_Offset,
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

    public static (hkpPlacement Placement, long Child)? ReadTransform(
        LimitedRimeReader p_Reader, long p_DataStart, long p_Offset,
        IReadOnlyDictionary<long, long> p_ObjectOffsets)
    {
        if (!p_ObjectOffsets.TryGetValue(p_Offset + c_ChildOffset, out var s_Child))
            return null;

        var s_At = p_DataStart + p_Offset + c_TransformRotationOffset;

        // 16 apart because each column is an hkVector4 whose w is padding.
        var s_Placement = new hkpPlacement(
            At(p_Reader, s_At).ReadVector3(),
            At(p_Reader, s_At + 16).ReadVector3(),
            At(p_Reader, s_At + 32).ReadVector3(),
            At(p_Reader, p_DataStart + p_Offset + c_TransformTranslationOffset).ReadVector3());

        return (s_Placement, s_Child);
    }

    /// <summary>The translation and the child this wrapper places, or null if it resolves to nothing.</summary>
    public static (Vector3 Centre, float Radius, long Child)? ReadTranslate(
        LimitedRimeReader p_Reader, long p_DataStart, long p_Offset,
        IReadOnlyDictionary<long, long> p_ObjectOffsets)
    {
        if (!p_ObjectOffsets.TryGetValue(p_Offset + c_ChildOffset, out var s_Child))
            return null;

        return (At(p_Reader, p_DataStart + p_Offset + c_TranslationOffset).ReadVector3(),
                At(p_Reader, p_DataStart + p_Offset + c_RadiusOffset).ReadSingle(),
                s_Child);
    }
}
