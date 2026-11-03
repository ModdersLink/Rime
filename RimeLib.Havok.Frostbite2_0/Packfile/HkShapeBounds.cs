using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using RimeLib.Havok.Frostbite2_0.Mopp;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>The bounding boxes of convex shapes, meshes and lists of them, their convex radius included.</summary>
public static class HkShapeBounds
{
    /// <summary>The shape's bounds, or none for a shape this cannot bound.</summary>
    public static (Vector3 Min, Vector3 Max)? Of(HkpShape p_Shape) => p_Shape switch
    {
        HkpBoxShape s_Box => Around(Vector3.Zero, Xyz(s_Box.HalfExtents) + new Vector3(s_Box.Radius)),
        HkpSphereShape s_Sphere => Around(Vector3.Zero, new Vector3(s_Sphere.Radius)),
        HkpCapsuleShape s_Capsule => Grow(Span(Xyz(s_Capsule.VertexA), Xyz(s_Capsule.VertexB)), s_Capsule.Radius),
        HkpCylinderShape s_Cylinder => Grow(Span(Xyz(s_Cylinder.VertexA), Xyz(s_Cylinder.VertexB)), s_Cylinder.CylinderRadius + s_Cylinder.Radius),
        HkpConvexVerticesShape s_Hull => Around(Xyz(s_Hull.AabbCenter), Xyz(s_Hull.AabbHalfExtents) + new Vector3(s_Hull.Radius)),
        HkpConvexTranslateShape { Child: { } s_Child } s_Translate => Of(s_Child) is var (s_Min, s_Max)
            ? (s_Min + Xyz(s_Translate.Translation), s_Max + Xyz(s_Translate.Translation))
            : null,
        HkpConvexTransformShape { Child: { } s_Child } s_Transform => Of(s_Child) is { } s_Bounds ? Transformed(s_Bounds, s_Transform) : null,
        HkpListShape s_List => Around(Xyz(s_List.AabbCenter), Xyz(s_List.AabbHalfExtents)),
        HkpCompressedMeshShape s_Mesh => Grow((Xyz(s_Mesh.BoundsMin), Xyz(s_Mesh.BoundsMax)), s_Mesh.Radius),
        HkpMoppBvTreeShape { Child: { } s_Child } => Of(s_Child),
        _ => null,
    };

    /// <summary>A compressed mesh's big triangles as a MOPP finds them: keyed by their index, with their bounds.</summary>
    public static List<MoppPrimitive> OfBigTriangles(HkpCompressedMeshShape p_Mesh)
    {
        Vector3 At(int p_Index) => Xyz(p_Mesh.BigVertices[p_Index]);
        return p_Mesh.BigTriangles.Select((p_T, p_Key) =>
        {
            var (s_A, s_B, s_C) = (At(p_T.A), At(p_T.B), At(p_T.C));
            return new MoppPrimitive((uint)p_Key, Vector3.Min(s_A, Vector3.Min(s_B, s_C)), Vector3.Max(s_A, Vector3.Max(s_B, s_C)));
        }).ToList();
    }

    private static Vector3 Xyz(Vector4 p_Vector) => new(p_Vector.X, p_Vector.Y, p_Vector.Z);

    private static (Vector3, Vector3) Around(Vector3 p_Centre, Vector3 p_HalfExtents) => (p_Centre - p_HalfExtents, p_Centre + p_HalfExtents);

    private static (Vector3, Vector3) Span(Vector3 p_A, Vector3 p_B) => (Vector3.Min(p_A, p_B), Vector3.Max(p_A, p_B));

    private static (Vector3, Vector3) Grow((Vector3 Min, Vector3 Max) p_Bounds, float p_By) =>
        (p_Bounds.Min - new Vector3(p_By), p_Bounds.Max + new Vector3(p_By));

    /// <summary>The bounds of the child's box's corners as the transform places them.</summary>
    private static (Vector3, Vector3) Transformed((Vector3 Min, Vector3 Max) p_Bounds, HkpConvexTransformShape p_Transform)
    {
        var (s_Min, s_Max) = (new Vector3(float.MaxValue), new Vector3(float.MinValue));
        for (var s_Corner = 0; s_Corner < 8; ++s_Corner)
        {
            var s_Local = new Vector3(
                (s_Corner & 1) == 0 ? p_Bounds.Min.X : p_Bounds.Max.X,
                (s_Corner & 2) == 0 ? p_Bounds.Min.Y : p_Bounds.Max.Y,
                (s_Corner & 4) == 0 ? p_Bounds.Min.Z : p_Bounds.Max.Z);
            var s_Placed = Xyz(p_Transform.Column0) * s_Local.X + Xyz(p_Transform.Column1) * s_Local.Y
                + Xyz(p_Transform.Column2) * s_Local.Z + Xyz(p_Transform.Translation);
            (s_Min, s_Max) = (Vector3.Min(s_Min, s_Placed), Vector3.Max(s_Max, s_Placed));
        }

        return (s_Min, s_Max);
    }
}
