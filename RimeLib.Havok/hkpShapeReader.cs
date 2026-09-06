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

    // hkpConvexTranslateShape
    private const int c_ChildOffset = 24;
    private const int c_TranslationOffset = 32;

    // hkpBoxShape
    private const int c_HalfExtentsOffset = 32;

    // hkpConvexVerticesShape
    private const int c_RotatedVerticesOffset = 64;
    private const int c_VertexCountOffset = 76;
    private const int c_PlanesOffset = 80;

    /// <summary>Four points held as three vectors: 12 floats.</summary>
    private const int c_FourTransposedPoints = 48;

    private static Vector3 ReadVector3(LimitedRimeReader p_Reader, long p_At)
    {
        p_Reader.Seek(p_At, SeekOrigin.Begin);

        return new Vector3(p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle());
    }

    private static float ReadSingleAt(LimitedRimeReader p_Reader, long p_At)
    {
        p_Reader.Seek(p_At, SeekOrigin.Begin);

        return p_Reader.ReadSingle();
    }

    private static uint ReadUInt32At(LimitedRimeReader p_Reader, long p_At)
    {
        p_Reader.Seek(p_At, SeekOrigin.Begin);

        return p_Reader.ReadUInt32();
    }

    public static hkpCollisionShape ReadBox(LimitedRimeReader p_Reader, long p_DataStart,
                                            long p_Offset)
    {
        return new hkpCollisionShape
        {
            Kind = "box",
            Offset = p_Offset,
            Radius = ReadSingleAt(p_Reader, p_DataStart + p_Offset + c_RadiusOffset),
            HalfExtents = ReadVector3(p_Reader, p_DataStart + p_Offset + c_HalfExtentsOffset)
        };
    }

    public static hkpCollisionShape ReadConvex(LimitedRimeReader p_Reader, long p_DataStart,
                                               long p_Offset,
                                               IReadOnlyDictionary<long, long> p_ArrayOffsets)
    {
        var s_Shape = new hkpCollisionShape
        {
            Kind = "convex",
            Offset = p_Offset,
            Radius = ReadSingleAt(p_Reader, p_DataStart + p_Offset + c_RadiusOffset)
        };

        // Planes first: hkArray is pointer then count, and the count lives one pointer in.
        var s_PlaneCount = ReadUInt32At(p_Reader, p_DataStart + p_Offset + c_PlanesOffset + 4);

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

        var s_Count = ReadUInt32At(p_Reader, p_DataStart + p_Offset + c_VertexCountOffset);

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

    /// <summary>The translation and the child this wrapper places, or null if it resolves to nothing.</summary>
    public static (Vector3 Centre, float Radius, long Child)? ReadTranslate(
        LimitedRimeReader p_Reader, long p_DataStart, long p_Offset,
        IReadOnlyDictionary<long, long> p_ObjectOffsets)
    {
        if (!p_ObjectOffsets.TryGetValue(p_Offset + c_ChildOffset, out var s_Child))
            return null;

        return (ReadVector3(p_Reader, p_DataStart + p_Offset + c_TranslationOffset),
                ReadSingleAt(p_Reader, p_DataStart + p_Offset + c_RadiusOffset),
                s_Child);
    }
}
