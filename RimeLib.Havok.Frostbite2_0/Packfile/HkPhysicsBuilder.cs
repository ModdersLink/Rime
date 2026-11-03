using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using RimeLib.Havok.Frostbite2_0.Mopp;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>
/// Builds the Havok 2010 objects of a physics resource from its shapes, one container shape per root, the way BF3's
/// own are made: a convex shape placed by a translate or transform wrapper (or, where a placement
/// scales it, with the placement baked in), several of them in a list, behind a MOPP where the list
/// is long, and triangles in a compressed mesh behind a MOPP. Leaves under instances, a static
/// model group's members, go into an extended mesh with a shape subpart per instance, over child
/// shapes the instances share.
/// </summary>
public static class HkPhysicsBuilder
{
    /// <summary>A list longer than this gets a MOPP over its children, as BF3's long lists have.</summary>
    private const int c_ListMoppThreshold = 4;

    /// <summary>How many children a list holds: one bit each in its eight words of enabled children.</summary>
    private const int c_ListCapacity = 8 * 32;

    /// <summary>The user data BF3 gives the shapes that hold other shapes.</summary>
    private const ulong c_ContainerUserData = 0xFFFFFFFF;

    /// <summary>What BF3's compressed meshes give for the error of quantising chunk vertices.</summary>
    private const float c_QuantisationError = 0.001f;

    public static HkRootLevelContainer Build(IReadOnlyList<hkpCollisionShape> p_Shapes)
    {
        var s_Container = new HavokPhysicsContainer();
        var s_RootCount = p_Shapes.Select(p_S => p_S.Root + 1).DefaultIfEmpty(0).Max();
        for (var s_Root = 0; s_Root < s_RootCount; ++s_Root)
            s_Container.Shapes.Add(Root(p_Shapes.Where(p_S => p_S.Root == s_Root).ToList()));

        return new HkRootLevelContainer
        {
            NamedVariants = [new HkRootLevelContainer.NamedVariant("PhysicsContainer", s_Container.ClassName, s_Container)],
        };
    }

    private static HkpShape Root(List<hkpCollisionShape> p_Leaves)
    {
        if (p_Leaves.Any(p_L => p_L.Instance != null))
            return p_Leaves.All(p_L => p_L.Instance != null)
                ? Instances(p_Leaves)
                : throw new NotSupportedException("A container shape with leaves both under instances and not.");

        var s_Convex = p_Leaves.Where(p_L => p_L.Kind != "mesh").Select(p_L => Convex(p_L, p_L.Placement)).ToList<HkpShape>();
        var s_Meshes = p_Leaves.Where(p_L => p_L.Kind == "mesh" && p_L.Indices.Count > 0).ToList();

        if (s_Meshes.Count > 0)
            s_Convex.Insert(0, Mesh(s_Meshes));

        return s_Convex.Count switch
        {
            0 => throw new ArgumentException("A container shape with no leaves under it."),
            1 => s_Convex[0],
            _ => List(s_Convex),
        };
    }

    private static Vector4 Point(Vector3 p_Value) => new(p_Value, 0f);

    private static float LargestScale(hkpPlacement p_Placement) =>
        MathF.Max(MathF.Abs(p_Placement.Scale.X), MathF.Max(MathF.Abs(p_Placement.Scale.Y), MathF.Abs(p_Placement.Scale.Z)));

    /// <summary>A convex leaf as BF3 has it: placed by a wrapper, or with a scaling placement baked into it.</summary>
    private static HkpConvexShape Convex(hkpCollisionShape p_Leaf, hkpPlacement p_Placement)
    {
        var s_Placement = p_Placement;
        switch (p_Leaf.Kind)
        {
            case "box":
            {
                // BF3's boxes keep their smallest half extent in w.
                var s_HalfExtents = Vector3.Abs(p_Leaf.HalfExtents * s_Placement.Scale);
                return Placed(new HkpBoxShape
                {
                    UserData = p_Leaf.UserData,
                    Radius = p_Leaf.Radius,
                    HalfExtents = new Vector4(s_HalfExtents, MathF.Min(s_HalfExtents.X, MathF.Min(s_HalfExtents.Y, s_HalfExtents.Z))),
                }, s_Placement, p_Leaf.UserData);
            }

            case "sphere":
                return Placed(new HkpSphereShape { UserData = p_Leaf.UserData, Radius = p_Leaf.Radius * LargestScale(s_Placement) }, s_Placement, p_Leaf.UserData);

            case "capsule":
            {
                // The ends carry the radius in w, as BF3's do.
                var s_Radius = p_Leaf.Radius * LargestScale(s_Placement);
                return new HkpCapsuleShape
                {
                    UserData = p_Leaf.UserData,
                    Radius = s_Radius,
                    VertexA = new Vector4(s_Placement.Apply(p_Leaf.VertexA), s_Radius),
                    VertexB = new Vector4(s_Placement.Apply(p_Leaf.VertexB), s_Radius),
                };
            }

            case "cylinder":
                return Cylinder(p_Leaf, s_Placement);

            case "convex":
                return Hull(p_Leaf, s_Placement);

            default:
                throw new NotSupportedException($"A {p_Leaf.Kind} shape has no Havok 2010 counterpart.");
        }
    }

    /// <summary>A shape centred on its origin, behind the wrapper that puts it where the placement does.</summary>
    private static HkpConvexShape Placed(HkpConvexShape p_Shape, hkpPlacement p_Placement, uint p_UserData)
    {
        var s_Rotation = Rotation(p_Placement);
        if (s_Rotation == (Vector3.UnitX, Vector3.UnitY, Vector3.UnitZ))
        {
            return p_Placement.Translation == Vector3.Zero
                ? p_Shape
                : new HkpConvexTranslateShape { UserData = p_UserData, Radius = p_Shape.Radius, Child = p_Shape, Translation = Point(p_Placement.Translation) };
        }

        return new HkpConvexTransformShape
        {
            UserData = p_UserData,
            Radius = p_Shape.Radius,
            Child = p_Shape,
            Column0 = Point(s_Rotation.X),
            Column1 = Point(s_Rotation.Y),
            Column2 = Point(s_Rotation.Z),
            Translation = Point(p_Placement.Translation),
        };
    }

    /// <summary>
    /// The placement's rotation alone: its columns with the scale divided out, sign included, so a
    /// mirroring scale leaves a rotation and the symmetric shape it places is unchanged.
    /// </summary>
    private static (Vector3 X, Vector3 Y, Vector3 Z) Rotation(hkpPlacement p_Placement) =>
        (p_Placement.Column0 / p_Placement.Scale.X, p_Placement.Column1 / p_Placement.Scale.Y, p_Placement.Column2 / p_Placement.Scale.Z);

    private static HkpCylinderShape Cylinder(hkpCollisionShape p_Leaf, hkpPlacement p_Placement)
    {
        var s_A = p_Placement.Apply(p_Leaf.VertexA);
        var s_B = p_Placement.Apply(p_Leaf.VertexB);
        var s_CylinderRadius = p_Leaf.CylinderRadius * LargestScale(p_Placement);

        // Two unit vectors at right angles to the axis and to each other, as Havok keeps them.
        var s_Axis = Vector3.Normalize(s_B - s_A);
        var s_Other = MathF.Abs(s_Axis.X) < 0.9f ? Vector3.UnitX : Vector3.UnitY;
        var s_Perpendicular1 = Vector3.Normalize(Vector3.Cross(s_Axis, s_Other));
        var s_Perpendicular2 = Vector3.Cross(s_Axis, s_Perpendicular1);

        return new HkpCylinderShape
        {
            UserData = p_Leaf.UserData,
            Radius = p_Leaf.Radius,
            CylinderRadius = s_CylinderRadius,
            CylinderBaseRadiusFactorForHeightFieldCollisions = 0.8f,
            VertexA = new Vector4(s_A, s_CylinderRadius),
            VertexB = new Vector4(s_B, s_CylinderRadius),
            Perpendicular1 = Point(s_Perpendicular1),
            Perpendicular2 = Point(s_Perpendicular2),
        };
    }

    /// <summary>A convex hull with its placement baked into its vertices and planes.</summary>
    private static HkpConvexVerticesShape Hull(hkpCollisionShape p_Leaf, hkpPlacement p_Placement)
    {
        var s_Vertices = p_Leaf.Vertices.Select(p_Placement.Apply).ToList();
        var (s_Min, s_Max) = (s_Vertices.Aggregate(Vector3.Min), s_Vertices.Aggregate(Vector3.Max));

        // A plane n.p + w = 0 under p' = A p + t has normal A^-T n.
        var s_Linear = new Matrix4x4(
            p_Placement.Column0.X, p_Placement.Column0.Y, p_Placement.Column0.Z, 0,
            p_Placement.Column1.X, p_Placement.Column1.Y, p_Placement.Column1.Z, 0,
            p_Placement.Column2.X, p_Placement.Column2.Y, p_Placement.Column2.Z, 0,
            0, 0, 0, 1);
        if (!Matrix4x4.Invert(s_Linear, out var s_Inverse))
            throw new ArgumentException("A hull whose placement cannot be inverted.");

        var s_Planes = p_Leaf.Planes.Select(p_Plane =>
        {
            var s_Normal = new Vector3(p_Plane.X, p_Plane.Y, p_Plane.Z);
            var s_OnPlane = p_Placement.Apply(-p_Plane.W * s_Normal / s_Normal.LengthSquared());
            var s_Placed = Vector3.Normalize(Vector3.TransformNormal(s_Normal, Matrix4x4.Transpose(s_Inverse)));
            return new Vector4(s_Placed, -Vector3.Dot(s_Placed, s_OnPlane));
        }).ToList();

        // Four vertices per entry, transposed; the last one repeats to fill the last entry.
        var s_Four = new List<HkpConvexVerticesShape.FourVectors>();
        for (var i = 0; i < s_Vertices.Count; i += 4)
        {
            var s_Group = Enumerable.Range(i, 4).Select(p_J => s_Vertices[System.Math.Min(p_J, s_Vertices.Count - 1)]).ToArray();
            s_Four.Add(new HkpConvexVerticesShape.FourVectors(
                new Vector4(s_Group[0].X, s_Group[1].X, s_Group[2].X, s_Group[3].X),
                new Vector4(s_Group[0].Y, s_Group[1].Y, s_Group[2].Y, s_Group[3].Y),
                new Vector4(s_Group[0].Z, s_Group[1].Z, s_Group[2].Z, s_Group[3].Z)));
        }

        return new HkpConvexVerticesShape
        {
            UserData = p_Leaf.UserData,
            Radius = p_Leaf.Radius,
            AabbHalfExtents = Point((s_Max - s_Min) / 2),
            AabbCenter = Point((s_Max + s_Min) / 2),
            RotatedVertices = s_Four,
            VertexCount = s_Vertices.Count,
            PlaneEquations = s_Planes,
        };
    }

    /// <summary>The bits of an extended mesh's shape keys, below the top one, that number the subpart, as in BF3's.</summary>
    private const int c_SubpartIndexBits = 16;

    /// <summary>
    /// Havok's flags for a shape subpart whose translation and rotation are both set, kept in the
    /// translation's w as the integer bits of 0x3F000000 | flags.
    /// </summary>
    private const int c_SubpartPlacementSet = 0x3F000003;

    /// <summary>
    /// Leaves under instances as an extended mesh behind a MOPP: a shape subpart per instance, in
    /// the instance's rigid placement and keeping its first part, over the leaves placed within it.
    /// A leaf placed alike in two instances is one child shape; an instance's scale, which a
    /// subpart cannot hold, goes into its children.
    /// </summary>
    private static HkpShape Instances(List<hkpCollisionShape> p_Leaves)
    {
        var s_Shared = new Dictionary<(long, Vector3, Vector3, Vector3, Vector3), HkpConvexShape>();
        var s_Mesh = new HkpExtendedMeshShape
        {
            CollectionType = 1,
            NumBitsForSubpartIndex = c_SubpartIndexBits,
            WeldingType = 6,
            TriangleRadius = 0.05f,
            EmbeddedTrianglesSubpart = new HkpExtendedMeshShape.TrianglesSubpart
            {
                MaterialIndexStridingType = 1, NumMaterials = 1, NumTriangleShapes = -1, NumVertices = -1, TriangleOffset = -1,
                Rotation = new Vector4(0, 0, 0, 1), Scale = Vector4.One,
            },
        };

        foreach (var s_Group in p_Leaves.GroupBy(p_L => p_L.Instance!).OrderBy(p_G => p_G.Key.Index))
        {
            var s_Instance = s_Group.Key;
            var s_Rotation = s_Instance.Placement.Rotation ?? Quaternion.CreateFromRotationMatrix(RotationMatrix(s_Instance.Placement));
            var s_Scale = hkpPlacement.FromQsTransform(Vector3.Zero, Quaternion.Identity, Snapped(s_Instance.Placement.Scale));

            var s_Children = new List<HkpConvexShape>();
            foreach (var s_Leaf in s_Group)
            {
                var s_Placement = s_Scale.Compose(s_Leaf.LocalPlacement);
                var s_Key = (s_Leaf.Offset, s_Placement.Column0, s_Placement.Column1, s_Placement.Column2, s_Placement.Translation);
                if (!s_Shared.TryGetValue(s_Key, out var s_Child))
                    s_Shared[s_Key] = s_Child = Convex(s_Leaf, s_Placement);
                s_Children.Add(s_Child);
            }

            s_Mesh.ShapesSubparts.Add(new HkpExtendedMeshShape.ShapesSubpart
            {
                Type = 1,
                MaterialIndexStridingType = 1,
                NumMaterials = 1,
                UserData = (ulong)s_Instance.FirstPart,
                ChildShapes = s_Children,
                Rotation = new Vector4(s_Rotation.X, s_Rotation.Y, s_Rotation.Z, s_Rotation.W),
                Translation = new Vector4(s_Instance.Placement.Translation, BitConverter.Int32BitsToSingle(c_SubpartPlacementSet)),
            });
        }

        if (s_Mesh.ShapesSubparts.Count >= 1 << (31 - c_SubpartIndexBits))
            throw new NotSupportedException($"{s_Mesh.ShapesSubparts.Count} instances, more than an extended mesh's shape keys number.");

        var s_Primitives = HkShapeBounds.OfShapesSubparts(s_Mesh);
        var (s_Min, s_Max) = (s_Primitives.Select(p_P => p_P.Min).Aggregate(Vector3.Min), s_Primitives.Select(p_P => p_P.Max).Aggregate(Vector3.Max));
        s_Mesh.AabbHalfExtents = Point((s_Max - s_Min) / 2);
        s_Mesh.AabbCenter = Point((s_Max + s_Min) / 2);
        s_Mesh.CachedNumChildShapes = s_Primitives.Count;
        return Mopp(s_Mesh, s_Primitives);
    }

    /// <summary>How far from one a scale is still rounding, which would otherwise keep instances from sharing children.</summary>
    private const float c_ScaleTolerance = 1e-4f;

    private static Vector3 Snapped(Vector3 p_Scale) => new(Snapped(p_Scale.X), Snapped(p_Scale.Y), Snapped(p_Scale.Z));

    private static float Snapped(float p_Scale) => MathF.Abs(p_Scale - 1) < c_ScaleTolerance ? 1 : p_Scale;

    /// <summary>The rotation of a placement given by its columns, for one that carries no quaternion.</summary>
    private static Matrix4x4 RotationMatrix(hkpPlacement p_Placement)
    {
        var (s_X, s_Y, s_Z) = Rotation(p_Placement);
        return new Matrix4x4(s_X.X, s_X.Y, s_X.Z, 0, s_Y.X, s_Y.Y, s_Y.Z, 0, s_Z.X, s_Z.Y, s_Z.Z, 0, 0, 0, 0, 1);
    }

    /// <summary>The triangles of the meshes, placed, as a compressed mesh of big triangles behind a MOPP.</summary>
    private static HkpShape Mesh(List<hkpCollisionShape> p_Meshes)
    {
        var s_Vertices = new List<Vector4>();
        var s_Triangles = new List<HkpCompressedMeshShape.BigTriangle>();
        foreach (var s_Leaf in p_Meshes)
        {
            var s_Base = s_Vertices.Count;
            s_Vertices.AddRange(s_Leaf.Vertices.Select(p_V => Point(s_Leaf.Placement.Apply(p_V))));
            for (var i = 0; i + 2 < s_Leaf.Indices.Count; i += 3)
                s_Triangles.Add(new HkpCompressedMeshShape.BigTriangle(
                    (ushort)(s_Base + s_Leaf.Indices[i]), (ushort)(s_Base + s_Leaf.Indices[i + 1]), (ushort)(s_Base + s_Leaf.Indices[i + 2]),
                    s_Leaf.UserData, 0, 0xFFFF));
        }

        if (s_Vertices.Count > ushort.MaxValue)
            throw new NotSupportedException($"A mesh of {s_Vertices.Count} vertices, more than a big triangle can index.");

        var s_Mesh = new HkpCompressedMeshShape
        {
            UserData = c_ContainerUserData,
            CollectionType = 6,
            BitsPerIndex = 17,
            BitsPerWIndex = 18,
            WIndexMask = 0x3FFFF,
            IndexMask = 0x1FFFF,
            Radius = p_Meshes.Max(p_M => p_M.Radius),
            WeldingType = 6,
            MaterialType = 1,
            BigVertices = s_Vertices,
            BigTriangles = s_Triangles,
            Error = c_QuantisationError,
            BoundsMin = s_Vertices.Aggregate(Vector4.Min),
            BoundsMax = s_Vertices.Aggregate(Vector4.Max),
            MaterialStriding = 4,
        };

        return Mopp(s_Mesh, HkShapeBounds.OfBigTriangles(s_Mesh));
    }

    /// <summary>
    /// Several shapes in a list, behind a MOPP over them where there are many; more than a list
    /// holds go into lists of their own first.
    /// </summary>
    private static HkpShape List(List<HkpShape> p_Children)
    {
        if (p_Children.Count > c_ListCapacity)
            return List(p_Children.Chunk(c_ListCapacity).Select(p_Chunk => p_Chunk.Length == 1 ? p_Chunk[0] : List([.. p_Chunk])).ToList());

        var s_Bounds = p_Children.Select(p_C => HkShapeBounds.Of(p_C)
            ?? throw new NotSupportedException($"A {p_C.ClassName} in a list cannot be bounded.")).ToList();
        var (s_Min, s_Max) = (s_Bounds.Select(p_B => p_B.Min).Aggregate(Vector3.Min), s_Bounds.Select(p_B => p_B.Max).Aggregate(Vector3.Max));

        var s_List = new HkpListShape
        {
            UserData = c_ContainerUserData,
            Children = p_Children.Select(p_C => new HkpListShape.ChildInfo(p_C, 0, 0, 0)).ToList(),
            // BF3's lists keep the largest convex radius of their children in w, and 1 in the centre's.
            AabbHalfExtents = new Vector4((s_Max - s_Min) / 2, p_Children.Max(p_C => p_C is HkpConvexShape s_Convex ? s_Convex.Radius : 0f)),
            AabbCenter = new Vector4((s_Max + s_Min) / 2, 1f),
            EnabledChildren = Enumerable.Repeat(0xFFFFFFFFu, c_ListCapacity / 32).ToArray(),
        };

        return p_Children.Count > c_ListMoppThreshold
            ? Mopp(s_List, s_Bounds.Select((p_B, p_Key) => new MoppPrimitive((uint)p_Key, p_B.Min, p_B.Max)).ToList())
            : s_List;
    }

    private static HkpMoppBvTreeShape Mopp(HkpShape p_Child, List<MoppPrimitive> p_Primitives)
    {
        var (s_Offset, s_Code) = MoppBuilder.Build(p_Primitives);
        return new HkpMoppBvTreeShape
        {
            UserData = c_ContainerUserData,
            Code = new HkpMoppCode { Offset = s_Offset, Instructions = s_Code, BuildType = 1 },
            Child = p_Child,
        };
    }
}
