using System.Collections.Generic;
using System.IO;
using System.Numerics;
using RimeLib.Havok;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0.Frostbite;

/// <summary>
/// Reads the collision shapes of a Havok 2010.2 packfile's data section (Frostbite 2). An engine
/// whose Havok lays a shape out differently derives from this and overrides it.
///
/// The offsets are the 32-bit pointer layout, which is the instance BF3 ships and the one Rime's
/// transform reader already walks. They were measured against real resources rather than taken from
/// a header: a box's half-extents sit at +32 with the x component repeated in w, and a convex hull's
/// vertices are hkFourTransposedPoints -- four points as three vectors (all x, then all y, then all
/// z), which is why vertex counts are padded to a multiple of four.
/// </summary>
public class ShapeReader
{
    // hkpConvexShape
    private const int c_RadiusOffset = 16;

    // hkpConvexTranslateShape / hkpConvexTransformShape share hkpConvexTransformShapeBase, so the
    // child pointer sits at the same place in both.
    protected const int c_ChildOffset = 24;
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

    // hkpConvexVerticesShape
    private const int c_RotatedVerticesOffset = 64;
    private const int c_VertexCountOffset = 76;

    /// <summary>Where hkpConvexVerticesShape's planes and connectivity arrays sit.</summary>
    protected virtual int PlanesOffset => 80;
    protected virtual int ConnectivityOffset => 92;

    /// <summary>Where hkpShape's user data sits: after the object header, and in Havok 2012 after the type bytes too.</summary>
    public virtual int UserDataOffset => 8;

    // hkpStorageExtendedMeshShapeMeshSubpartStorage. Its hkArrays start at +8 with a 12-byte
    // stride (pointer, size, capacity), and the payloads sit inline after a 112-byte header.
    private const int c_SubpartVerticesSlot = 8;

    // The index array is in one of three slots depending on how wide the indices are, and BF3 uses
    // all three: 61 subparts store 8-bit indices, 7 store 16-bit and 24 store 32-bit.
    private static readonly int[] s_SubpartIndexSlots = { 20, 32, 44 };

    /// <summary>Four points held as three vectors: 12 floats.</summary>
    private const int c_FourTransposedPoints = 48;

    /// <summary>The reader, moved to <paramref name="p_At"/>.</summary>
    protected static LimitedRimeReader At(LimitedRimeReader p_Reader, long p_At)
    {
        p_Reader.Seek(p_At, SeekOrigin.Begin);
        return p_Reader;
    }

    public hkpCollisionShape ReadBox(LimitedRimeReader p_Reader, long p_DataStart,
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

    public hkpCollisionShape ReadConvex(LimitedRimeReader p_Reader, long p_DataStart,
                                               long p_Offset,
                                               IReadOnlyDictionary<long, long> p_ArrayOffsets,
                                               IReadOnlyDictionary<long, long>? p_ObjectOffsets = null)
    {
        var s_Shape = new hkpCollisionShape
        {
            Kind = "convex",
            Offset = p_Offset,
            Radius = At(p_Reader, p_DataStart + p_Offset + c_RadiusOffset).ReadSingle(),

            // A null connectivity pointer has no fixup, so the fixup table is the record of whether
            // there is one -- reading the slot itself would only ever see the zero the relocation
            // has not been applied to.
            HasConnectivity = p_ObjectOffsets != null
                              && p_ObjectOffsets.ContainsKey(p_Offset + ConnectivityOffset)
        };

        // Planes first: hkArray is pointer then count, and the count lives one pointer in.
        var s_PlaneCount = At(p_Reader, p_DataStart + p_Offset + PlanesOffset + 4).ReadUInt32();

        if (s_PlaneCount > 0 && p_ArrayOffsets.TryGetValue(p_Offset + PlanesOffset,
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
    public hkpCollisionShape ReadCylinder(LimitedRimeReader p_Reader, long p_DataStart,
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
    public hkpCollisionShape ReadCapsule(LimitedRimeReader p_Reader, long p_DataStart,
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
    public hkpCollisionShape ReadSphere(LimitedRimeReader p_Reader, long p_DataStart,
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
    public hkpCollisionShape? ReadStorageMesh(LimitedRimeReader p_Reader, long p_DataStart,
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
    /// The placement and child of an hkpConvexTransformShape: Havok 2010 stores an hkTransform.
    /// </summary>
    public virtual (hkpPlacement Placement, long Child)? ReadTransformShape(
        LimitedRimeReader p_Reader, long p_DataStart, long p_Offset, IReadOnlyDictionary<long, long> p_ObjectOffsets)
        => ReadTransform(p_Reader, p_DataStart, p_Offset, p_ObjectOffsets);

    /// <summary>The instances of an hkpStaticCompoundShape, which Havok 2010 does not have; null when not read.</summary>
    public virtual List<(hkpPlacement Placement, long Child, long Instance)>? ReadStaticCompound(
        LimitedRimeReader p_Reader, long p_DataStart, long p_Offset,
        IReadOnlyDictionary<long, long> p_ArrayOffsets, IReadOnlyDictionary<long, long> p_ObjectOffsets) => null;

    /// <summary>An hkpBvCompressedMeshShape, which Havok 2010 does not have; null when not read.</summary>
    public virtual hkpCollisionShape? ReadBvCompressedMesh(LimitedRimeReader p_Reader, long p_DataStart, long p_Offset,
        IReadOnlyDictionary<long, long> p_ArrayOffsets) => null;

    /// <summary>
    /// The rotation, translation and child of an hkpConvexTransformShape, or null if the child
    /// resolves to nothing.
    /// </summary>
    public (hkpPlacement Placement, long Child)? ReadTransform(
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
    public (Vector3 Centre, float Radius, long Child)? ReadTranslate(
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
