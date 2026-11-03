using System.Collections.Generic;
using System.Numerics;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>hkpShape: what every collision shape starts with.</summary>
public abstract class HkpShape : HkObject
{
    /// <summary>What the game keeps with the shape; Frostbite numbers a part's shapes with it.</summary>
    public ulong UserData { get; set; }

    /// <summary>The shape type, which the loader sets again; kept as stored.</summary>
    public uint Type { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteUlong(UserData);
        p_Writer.Write(Type);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        UserData = p_Reader.ReadUlong();
        Type = p_Reader.ReadUInt32();
        p_Reader.EndClass();
    }
}

/// <summary>hkpConvexShape: a shape with a convex radius, the shell collision keeps around it.</summary>
public abstract class HkpConvexShape : HkpShape
{
    public float Radius { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(Radius);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Radius = p_Reader.ReadSingle();
        p_Reader.EndClass();
    }
}

public sealed class HkpBoxShape : HkpConvexShape
{
    public override string ClassName => "hkpBoxShape";

    public Vector4 HalfExtents { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(HalfExtents);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        HalfExtents = p_Reader.ReadVector4();
        p_Reader.EndClass();
    }
}

public sealed class HkpSphereShape : HkpConvexShape
{
    public override string ClassName => "hkpSphereShape";
}

public sealed class HkpCapsuleShape : HkpConvexShape
{
    public override string ClassName => "hkpCapsuleShape";

    public Vector4 VertexA { get; set; }
    public Vector4 VertexB { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(VertexA);
        p_Writer.Write(VertexB);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        VertexA = p_Reader.ReadVector4();
        VertexB = p_Reader.ReadVector4();
        p_Reader.EndClass();
    }
}

public sealed class HkpCylinderShape : HkpConvexShape
{
    public override string ClassName => "hkpCylinderShape";

    public float CylinderRadius { get; set; }
    public float CylinderBaseRadiusFactorForHeightFieldCollisions { get; set; }
    public Vector4 VertexA { get; set; }
    public Vector4 VertexB { get; set; }
    public Vector4 Perpendicular1 { get; set; }
    public Vector4 Perpendicular2 { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(CylinderRadius);
        p_Writer.Write(CylinderBaseRadiusFactorForHeightFieldCollisions);
        p_Writer.Write(VertexA);
        p_Writer.Write(VertexB);
        p_Writer.Write(Perpendicular1);
        p_Writer.Write(Perpendicular2);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        CylinderRadius = p_Reader.ReadSingle();
        CylinderBaseRadiusFactorForHeightFieldCollisions = p_Reader.ReadSingle();
        VertexA = p_Reader.ReadVector4();
        VertexB = p_Reader.ReadVector4();
        Perpendicular1 = p_Reader.ReadVector4();
        Perpendicular2 = p_Reader.ReadVector4();
        p_Reader.EndClass();
    }
}

/// <summary>A convex hull: its vertices four at a time, transposed, and the planes that bound it.</summary>
public sealed class HkpConvexVerticesShape : HkpConvexShape
{
    public override string ClassName => "hkpConvexVerticesShape";

    /// <summary>Four vertices: their x coordinates, their y coordinates and their z coordinates.</summary>
    public sealed record FourVectors(Vector4 X, Vector4 Y, Vector4 Z);

    public Vector4 AabbHalfExtents { get; set; }
    public Vector4 AabbCenter { get; set; }
    public List<FourVectors> RotatedVertices { get; set; } = [];
    public int VertexCount { get; set; }
    public List<Vector4> PlaneEquations { get; set; } = [];
    public HkpConvexVerticesConnectivity? Connectivity { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(AabbHalfExtents);
        p_Writer.Write(AabbCenter);
        p_Writer.WriteArray(RotatedVertices, 16, (p_Element, p_Four) =>
        {
            p_Element.Write(p_Four.X);
            p_Element.Write(p_Four.Y);
            p_Element.Write(p_Four.Z);
        });
        p_Writer.Write(VertexCount);
        p_Writer.WriteArray(PlaneEquations, 16, (p_Element, p_Plane) => p_Element.Write(p_Plane));
        p_Writer.WriteObject(Connectivity);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        AabbHalfExtents = p_Reader.ReadVector4();
        AabbCenter = p_Reader.ReadVector4();
        RotatedVertices = p_Reader.ReadArray(16, p_Element => new FourVectors(p_Element.ReadVector4(), p_Element.ReadVector4(), p_Element.ReadVector4()));
        VertexCount = p_Reader.ReadInt32();
        PlaneEquations = p_Reader.ReadArray(16, p_Element => p_Element.ReadVector4());
        Connectivity = p_Reader.ReadObject<HkpConvexVerticesConnectivity>();
        p_Reader.EndClass();
    }
}

/// <summary>A hull's faces: the vertex indices of each face, in turn, and how many each has.</summary>
public sealed class HkpConvexVerticesConnectivity : HkObject
{
    public override string ClassName => "hkpConvexVerticesConnectivity";

    public List<ushort> VertexIndices { get; set; } = [];
    public List<byte> VerticesPerFace { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteArray(VertexIndices, 2, (p_Element, p_Index) => p_Element.Write(p_Index));
        p_Writer.WriteArray(VerticesPerFace, 1, (p_Element, p_Count) => p_Element.Write(p_Count));
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        VertexIndices = p_Reader.ReadArray(2, p_Element => p_Element.ReadUInt16());
        VerticesPerFace = p_Reader.ReadArray(1, p_Element => p_Element.ReadByte());
        p_Reader.EndClass();
    }
}

/// <summary>hkpConvexTransformShapeBase: a convex shape placed by a wrapper, held through a single-shape container.</summary>
public abstract class HkpConvexWrapperShape : HkpConvexShape
{
    public HkpShape? Child { get; set; }

    /// <summary>The child's size in bytes, which the loader computes again; kept as stored.</summary>
    public int ChildShapeSize { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WritePointerSlot();
        p_Writer.WriteObject(Child);
        p_Writer.Write(ChildShapeSize);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        p_Reader.SkipPointerSlot();
        Child = p_Reader.ReadObject<HkpShape>();
        ChildShapeSize = p_Reader.ReadInt32();
        p_Reader.EndClass();
    }
}

public sealed class HkpConvexTranslateShape : HkpConvexWrapperShape
{
    public override string ClassName => "hkpConvexTranslateShape";

    public Vector4 Translation { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(Translation);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Translation = p_Reader.ReadVector4();
        p_Reader.EndClass();
    }
}

public sealed class HkpConvexTransformShape : HkpConvexWrapperShape
{
    public override string ClassName => "hkpConvexTransformShape";

    /// <summary>The rotation's three columns, then the translation, as hkTransform stores them.</summary>
    public Vector4 Column0 { get; set; }
    public Vector4 Column1 { get; set; }
    public Vector4 Column2 { get; set; }
    public Vector4 Translation { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(Column0);
        p_Writer.Write(Column1);
        p_Writer.Write(Column2);
        p_Writer.Write(Translation);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Column0 = p_Reader.ReadVector4();
        Column1 = p_Reader.ReadVector4();
        Column2 = p_Reader.ReadVector4();
        Translation = p_Reader.ReadVector4();
        p_Reader.EndClass();
    }
}

/// <summary>hkpShapeCollection: a shape of child shapes, which it hands out through a shape container.</summary>
public abstract class HkpShapeCollection : HkpShape
{
    public bool DisableWelding { get; set; }
    public byte CollectionType { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WritePointerSlot();
        p_Writer.Write(DisableWelding);
        p_Writer.Write(CollectionType);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        p_Reader.SkipPointerSlot();
        DisableWelding = p_Reader.ReadBool();
        CollectionType = p_Reader.ReadByte();
        p_Reader.EndClass();
    }
}

/// <summary>A list of child shapes, each with its collision filter, inside one bounding box.</summary>
public sealed class HkpListShape : HkpShapeCollection
{
    public override string ClassName => "hkpListShape";

    public sealed record ChildInfo(HkpShape? Shape, uint CollisionFilterInfo, int ShapeSize, int ChildShapeCount);

    public List<ChildInfo> Children { get; set; } = [];
    public ushort Flags { get; set; }
    public ushort DisabledChildCount { get; set; }
    public Vector4 AabbHalfExtents { get; set; }
    public Vector4 AabbCenter { get; set; }

    /// <summary>A bit per child, for the first 256, of which are enabled.</summary>
    public uint[] EnabledChildren { get; set; } = new uint[8];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteArray(Children, 16, (p_Element, p_Child) =>
        {
            p_Element.WriteObject(p_Child.Shape);
            p_Element.Write(p_Child.CollisionFilterInfo);
            p_Element.Write(p_Child.ShapeSize);
            p_Element.Write(p_Child.ChildShapeCount);
        });
        p_Writer.Write(Flags);
        p_Writer.Write(DisabledChildCount);
        p_Writer.Write(AabbHalfExtents);
        p_Writer.Write(AabbCenter);
        foreach (var s_Bits in EnabledChildren)
            p_Writer.Write(s_Bits);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Children = p_Reader.ReadArray(16, p_Element => new ChildInfo(
            p_Element.ReadObject<HkpShape>(), p_Element.ReadUInt32(), p_Element.ReadInt32(), p_Element.ReadInt32()));
        Flags = p_Reader.ReadUInt16();
        DisabledChildCount = p_Reader.ReadUInt16();
        AabbHalfExtents = p_Reader.ReadVector4();
        AabbCenter = p_Reader.ReadVector4();
        for (var i = 0; i < EnabledChildren.Length; ++i)
            EnabledChildren[i] = p_Reader.ReadUInt32();
        p_Reader.EndClass();
    }
}
