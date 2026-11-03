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
            Assert.Contains(s_Triangle.Key, MoppQuery.Query(s_Tree.Code.Instructions, s_Box));
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
}
