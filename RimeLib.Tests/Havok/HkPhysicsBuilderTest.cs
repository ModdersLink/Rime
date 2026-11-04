using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using RimeLib.Havok;
using RimeLib.Havok.Frostbite2_0.Mopp;
using RimeLib.Havok.Frostbite2_0.Packfile;
using Xunit;

namespace RimeLib.Tests.Havok;

public class HkPhysicsBuilderTest
{
    private static readonly hkpPlacement s_Turned = hkpPlacement.FromQsTransform(
        new Vector3(1, 2, 3), Quaternion.CreateFromAxisAngle(Vector3.UnitZ, MathF.PI / 2), new Vector3(2, 1, 1));

    private static HkpShape Only(IReadOnlyList<hkpCollisionShape> p_Shapes) =>
        Assert.Single(((HavokPhysicsContainer)HkPhysicsBuilder.Build(p_Shapes).NamedVariants[0].Variant!).Shapes);

    private static hkpCollisionShape Box(hkpPlacement p_Placement, int p_Root = 0) => new()
    {
        Kind = "box", Radius = 0.01f, HalfExtents = new Vector3(1, 2, 3), Placement = p_Placement, Root = p_Root,
    };

    [Fact]
    public void GivesEachListChildAPartOfItsResource()
    {
        // More boxes than a list holds, of two parts, and a mesh of each part beside them.
        var s_Leaves = Enumerable.Range(0, 600).Select(p_I =>
        {
            var s_Box = Box(hkpPlacement.FromTranslation(new Vector3(p_I, 0, 0)));
            s_Box.UserData = (uint)(p_I % 2);
            return s_Box;
        }).ToList();
        s_Leaves.AddRange(Enumerable.Range(0, 2).Select(p_Part => new hkpCollisionShape
        {
            Kind = "mesh", Vertices = [Vector3.Zero, Vector3.UnitX, Vector3.UnitZ], Indices = [0, 1, 2],
            Placement = hkpPlacement.FromTranslation(Vector3.Zero), UserData = (uint)p_Part,
        }));

        var s_Children = new List<HkpShape>();
        void Collect(HkpShape? p_Shape)
        {
            if (p_Shape is HkpMoppBvTreeShape s_Tree)
                Collect(s_Tree.Child);
            else if (p_Shape is HkpListShape s_List)
                foreach (var s_Child in s_List.Children)
                {
                    s_Children.Add(s_Child.Shape!);
                    Collect(s_Child.Shape);
                }
        }

        Collect(Only(s_Leaves));
        Assert.Equal(600, s_Children.Count(p_C => p_C is HkpConvexShape));
        Assert.Equal(2, s_Children.Count(p_C => p_C is HkpMoppBvTreeShape { Child: HkpCompressedMeshShape }));
        Assert.All(s_Children, p_C => Assert.True(p_C.UserData < 2));
    }

    [Fact]
    public void PlacesARotatedBoxWithItsScaleInItsHalfExtents()
    {
        var s_Transform = Assert.IsType<HkpConvexTransformShape>(Only([Box(s_Turned)]));
        var s_Box = Assert.IsType<HkpBoxShape>(s_Transform.Child);

        Assert.Equal(new Vector4(2, 2, 3, 2), s_Box.HalfExtents);
        Assert.Equal(new Vector4(1, 2, 3, 0), s_Transform.Translation);
        Assert.True(Vector4.Distance(new Vector4(0, 1, 0, 0), s_Transform.Column0) < 1e-6f);
    }

    [Fact]
    public void PlacesAnUnrotatedBoxByTranslation()
    {
        var s_Translate = Assert.IsType<HkpConvexTranslateShape>(Only([Box(hkpPlacement.FromTranslation(new Vector3(4, 5, 6)))]));
        Assert.IsType<HkpBoxShape>(s_Translate.Child);
        Assert.Equal(new Vector4(4, 5, 6, 0), s_Translate.Translation);
    }

    [Fact]
    public void BakesAPlacementIntoAHullsVerticesAndPlanes()
    {
        // A unit cube: six planes n.p + w = 0 with outward normals.
        var s_Corners = Enumerable.Range(0, 8).Select(p_I => new Vector3(p_I & 1, (p_I >> 1) & 1, (p_I >> 2) & 1)).ToList();
        var s_Planes = new List<Vector4>
        {
            new(1, 0, 0, -1), new(-1, 0, 0, 0), new(0, 1, 0, -1), new(0, -1, 0, 0), new(0, 0, 1, -1), new(0, 0, -1, 0),
        };
        var s_Hull = Assert.IsType<HkpConvexVerticesShape>(Only([new hkpCollisionShape
        {
            Kind = "convex", Vertices = s_Corners, Planes = s_Planes, Placement = s_Turned,
        }]));

        Assert.Equal(8, s_Hull.VertexCount);
        var s_Placed = s_Corners.Select(s_Turned.Apply).ToList();
        foreach (var s_Plane in s_Hull.PlaneEquations)
        {
            var s_Distances = s_Placed.Select(p_P => Vector3.Dot(new Vector3(s_Plane.X, s_Plane.Y, s_Plane.Z), p_P) + s_Plane.W).ToList();
            Assert.All(s_Distances, p_D => Assert.True(p_D < 1e-5f));
            Assert.Equal(4, s_Distances.Count(p_D => p_D > -1e-5f));
        }
    }

    [Fact]
    public void FindsEachTriangleOfAMeshThroughItsMopp()
    {
        var s_Vertices = new List<Vector3>();
        var s_Indices = new List<int>();
        for (var x = 0; x < 20; ++x)
            for (var z = 0; z < 20; ++z)
            {
                s_Indices.AddRange([s_Vertices.Count, s_Vertices.Count + 1, s_Vertices.Count + 2]);
                s_Vertices.AddRange([new Vector3(x, MathF.Sin(x + z), z), new Vector3(x + 1, 0, z), new Vector3(x, 0, z + 1)]);
            }

        var s_Tree = Assert.IsType<HkpMoppBvTreeShape>(Only([new hkpCollisionShape { Kind = "mesh", Vertices = s_Vertices, Indices = s_Indices, Placement = s_Turned }]));
        var s_Mesh = Assert.IsType<HkpCompressedMeshShape>(s_Tree.Child);
        Assert.Equal(400, s_Mesh.BigTriangles.Count);

        var s_Offset = s_Tree.Code!.Offset;
        foreach (var s_Triangle in HkShapeBounds.OfBigTriangles(s_Mesh))
        {
            var s_Box = MoppBuilder.ToBox(s_Triangle, new Vector3(s_Offset.X, s_Offset.Y, s_Offset.Z), s_Offset.W);
            Assert.Contains(s_Triangle.Key, new MoppQuery(s_Tree.Code.Instructions).Query(s_Box));
        }
    }

    [Fact]
    public void NestsMoreChildrenThanAListHolds()
    {
        var s_Boxes = Enumerable.Range(0, 600).Select(p_I => Box(hkpPlacement.FromTranslation(new Vector3(p_I * 10, 0, 0)))).ToList();
        var s_Top = Only(s_Boxes);

        static int Leaves(HkpShape p_Shape) => p_Shape switch
        {
            HkpMoppBvTreeShape s_Mopp => Leaves(s_Mopp.Child!),
            HkpListShape s_List => s_List.Children.Count <= 256 ? s_List.Children.Sum(p_C => Leaves(p_C.Shape!)) : int.MinValue,
            _ => 1,
        };
        Assert.Equal(600, Leaves(s_Top));
    }

    [Fact]
    public void BuildsAContainerShapePerRootAndWritesThem()
    {
        var s_Root = HkPhysicsBuilder.Build([Box(hkpPlacement.Identity), Box(s_Turned, 1), Box(hkpPlacement.Identity, 1)]);
        var s_Container = (HavokPhysicsContainer)s_Root.NamedVariants[0].Variant!;

        Assert.IsType<HkpBoxShape>(s_Container.Shapes[0]);
        Assert.IsType<HkpListShape>(s_Container.Shapes[1]);
        foreach (byte s_PointerSize in new byte[] { 4, 8 })
        {
            var s_Read = HkPackfile.Read(HkPackfile.Write(s_Root, s_PointerSize));
            Assert.Equal(2, ((HavokPhysicsContainer)s_Read.NamedVariants[0].Variant!).Shapes.Count);
        }
    }

    [Fact]
    public void SharesTheChildShapesOfInstancesInAnExtendedMesh()
    {
        var s_Members = Enumerable.Range(0, 3).Select(p_I => new hkpShapeInstance
        {
            Index = p_I,
            Placement = hkpPlacement.FromQsTransform(new Vector3(p_I * 20, 0, 0), Quaternion.CreateFromAxisAngle(Vector3.UnitY, p_I), new Vector3(p_I == 2 ? 2 : 1)),
            FirstPart = p_I * 2,
            PartCount = 2,
        }).ToList();
        var s_Local = hkpPlacement.FromTranslation(new Vector3(0, 1, 0));
        var s_Leaves = s_Members.SelectMany(p_M => new[] { 0, 1 }.Select(p_Part => new hkpCollisionShape
        {
            Kind = "box", HalfExtents = Vector3.One, Offset = 64 + p_Part, UserData = (uint)p_Part, Instance = p_M,
            LocalPlacement = s_Local, Placement = p_M.Placement.Compose(s_Local),
        })).ToList();

        var s_Tree = Assert.IsType<HkpMoppBvTreeShape>(Only(s_Leaves));
        var s_Mesh = Assert.IsType<HkpExtendedMeshShape>(s_Tree.Child);

        Assert.Equal([0ul, 2ul, 4ul], s_Mesh.ShapesSubparts.Select(p_S => p_S.UserData));
        Assert.Same(s_Mesh.ShapesSubparts[0].ChildShapes[1], s_Mesh.ShapesSubparts[1].ChildShapes[1]);
        Assert.NotSame(s_Mesh.ShapesSubparts[0].ChildShapes[1], s_Mesh.ShapesSubparts[2].ChildShapes[1]);
        Assert.Equal(new Vector4(2, 2, 2, 2), ((HkpBoxShape)((HkpConvexTranslateShape)s_Mesh.ShapesSubparts[2].ChildShapes[0]).Child!).HalfExtents);

        var s_Offset = s_Tree.Code!.Offset;
        foreach (var s_Child in HkShapeBounds.OfShapesSubparts(s_Mesh))
        {
            var s_Box = MoppBuilder.ToBox(s_Child, new Vector3(s_Offset.X, s_Offset.Y, s_Offset.Z), s_Offset.W);
            Assert.Contains(s_Child.Key, new MoppQuery(s_Tree.Code.Instructions).Query(s_Box));
        }

        var s_Read = HkPackfile.Read(HkPackfile.Write(HkPhysicsBuilder.Build(s_Leaves), 8));
        var s_ReadMesh = (HkpExtendedMeshShape)((HkpMoppBvTreeShape)((HavokPhysicsContainer)s_Read.NamedVariants[0].Variant!).Shapes[0]).Child!;
        Assert.Same(s_ReadMesh.ShapesSubparts[0].ChildShapes[0], s_ReadMesh.ShapesSubparts[1].ChildShapes[0]);
    }
}
