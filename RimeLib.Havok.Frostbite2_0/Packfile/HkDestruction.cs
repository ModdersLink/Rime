using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>
/// An hkSmallArray the packfile keeps empty: its pointer, size and capacity, of which only the
/// capacity's flags are stored.
/// </summary>
internal static class HkSmallArray
{
    public static void Write(HkWriter p_Writer, ushort p_CapacityAndFlags)
    {
        p_Writer.WritePointerSlot();
        p_Writer.Write((ushort)0);
        p_Writer.Write(p_CapacityAndFlags);
    }

    public static ushort Read(HkReader p_Reader)
    {
        p_Reader.SkipPointerSlot();
        if (p_Reader.ReadUInt16() != 0)
            throw new InvalidDataException("An hkSmallArray with elements, which BF3's packfiles do not have.");
        return p_Reader.ReadUInt16();
    }
}

/// <summary>Properties of a breakable shape or body: objects by key.</summary>
public sealed record HkdProperty(int Key, HkObject? Object);

internal static class HkdProperties
{
    public static void Write(HkWriter p_Writer, IReadOnlyList<HkdProperty> p_Properties) =>
        p_Writer.WriteArray(p_Properties, p_Writer.PointerSize, (p_E, p_P) =>
        {
            p_E.Write(p_P.Key);
            p_E.WriteObject(p_P.Object);
        });

    public static List<HkdProperty> Read(HkReader p_Reader) =>
        p_Reader.ReadArray(p_Reader.PointerSize, p_E => new HkdProperty(p_E.ReadInt32(), p_E.ReadObject()));
}

/// <summary>A child of a breakable shape, in its parent's space.</summary>
public sealed record HkdShapeInstance(Vector4 Rotation, Vector4 Translation, HkdBreakableShape? Shape, byte Damage, byte Flags,
    ushort TempControllerData, float DistanceToDestructionPoint, byte ForceFixed, ushort ParentUid);

/// <summary>A shape that breaks: its mass properties, children, physics and graphics shapes, and properties.</summary>
public class HkdBreakableShape : HkObject
{
    public override string ClassName => "hkdBreakableShape";

    public byte TypeAndFlags { get; set; }
    public byte ConnectivityType { get; set; }
    public byte FlexibleJointType { get; set; }
    public byte QualityType { get; set; }
    public HkdBreakableShape? Parent { get; set; }
    public Vector4 ComAndMass { get; set; }

    /// <summary>The inertia and other values, as eight halves.</summary>
    public ushort[] InertiaAndValues { get; set; } = new ushort[8];

    public uint MajorAxisSpace { get; set; }
    public List<HkdShapeInstance> Children { get; set; } = [];
    public HkpShape? PhysicsShape { get; set; }
    public HkObject? Geometry { get; set; }
    public HkObject? GraphicsShape { get; set; }
    public List<HkdProperty> ObjectProperties { get; set; } = [];
    public float Strength { get; set; }
    public ulong UserData { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(TypeAndFlags);
        p_Writer.Write(ConnectivityType);
        p_Writer.Write(FlexibleJointType);
        p_Writer.Write(QualityType);
        p_Writer.WriteObject(Parent);
        p_Writer.Write(ComAndMass);
        p_Writer.Align(16);
        foreach (var s_Half in InertiaAndValues)
            p_Writer.Write(s_Half);
        p_Writer.Write(MajorAxisSpace);
        p_Writer.WriteArray(Children, 16, (p_E, p_C) =>
        {
            p_E.Write(p_C.Rotation);
            p_E.Write(p_C.Translation);
            p_E.WriteObject(p_C.Shape);
            p_E.Write(p_C.Damage);
            p_E.Write(p_C.Flags);
            p_E.Write(p_C.TempControllerData);
            p_E.Write(p_C.DistanceToDestructionPoint);
            p_E.Write(p_C.ForceFixed);
            p_E.Write(p_C.ParentUid);
        });
        p_Writer.WriteObject(PhysicsShape);
        p_Writer.WriteObject(Geometry);
        p_Writer.WriteObject(GraphicsShape);
        HkdProperties.Write(p_Writer, ObjectProperties);
        p_Writer.Write(Strength);
        p_Writer.WriteUlong(UserData);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        TypeAndFlags = p_Reader.ReadByte();
        ConnectivityType = p_Reader.ReadByte();
        FlexibleJointType = p_Reader.ReadByte();
        QualityType = p_Reader.ReadByte();
        Parent = p_Reader.ReadObject<HkdBreakableShape>();
        ComAndMass = p_Reader.ReadVector4();
        p_Reader.Align(16);
        for (var i = 0; i < InertiaAndValues.Length; ++i)
            InertiaAndValues[i] = p_Reader.ReadUInt16();
        MajorAxisSpace = p_Reader.ReadUInt32();
        Children = p_Reader.ReadArray(16, p_E => new HkdShapeInstance(p_E.ReadVector4(), p_E.ReadVector4(), p_E.ReadObject<HkdBreakableShape>(),
            p_E.ReadByte(), p_E.ReadByte(), p_E.ReadUInt16(), p_E.ReadSingle(), p_E.ReadByte(), p_E.ReadUInt16()));
        PhysicsShape = p_Reader.ReadObject<HkpShape>();
        Geometry = p_Reader.ReadObject();
        GraphicsShape = p_Reader.ReadObject();
        ObjectProperties = HkdProperties.Read(p_Reader);
        Strength = p_Reader.ReadSingle();
        UserData = p_Reader.ReadUlong();
        p_Reader.EndClass();
    }
}

/// <summary>A breakable shape of breakable children, with the shape it breaks from.</summary>
public sealed class HkdCompoundBreakableShape : HkdBreakableShape
{
    public override string ClassName => "hkdCompoundBreakableShape";

    public HkdBreakableShape? RootBreakableShape { get; set; }
    public bool UseChildrenBreakableThreshold { get; set; }
    public int UnusedPaddingCompound { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteObject(RootBreakableShape);
        p_Writer.Write(UseChildrenBreakableThreshold);
        p_Writer.WritePointerSlot();
        p_Writer.Write(UnusedPaddingCompound);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        RootBreakableShape = p_Reader.ReadObject<HkdBreakableShape>();
        UseChildrenBreakableThreshold = p_Reader.ReadBool();
        p_Reader.SkipPointerSlot();
        UnusedPaddingCompound = p_Reader.ReadInt32();
        p_Reader.EndClass();
    }
}

/// <summary>What breaks in the world: a rigid body, its breakable shape and the controller deciding how.</summary>
public sealed class HkdBreakableBody : HkObject
{
    public override string ClassName => "hkdBreakableBody";

    public byte BodyTypeAndFlags { get; set; }
    public ushort ConstraintStrength { get; set; }
    public HkpRigidBody? PhysicsBody { get; set; }
    public HkdBreakableShape? BreakableShape { get; set; }
    public HkdController? Controller { get; set; }
    public HkObject? GraphicsBody { get; set; }
    public List<HkdProperty> ObjectProperties { get; set; } = [];
    public ushort ListenersCapacity { get; set; }
    public HkObject? FixedConnectivity { get; set; }
    public ushort DecorationsCapacity { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(BodyTypeAndFlags);
        p_Writer.Write(ConstraintStrength);
        p_Writer.WritePointerSlot();
        p_Writer.WriteObject(PhysicsBody);
        p_Writer.WriteObject(BreakableShape);
        p_Writer.WriteObject(Controller);
        p_Writer.WriteObject(GraphicsBody);
        HkdProperties.Write(p_Writer, ObjectProperties);
        HkSmallArray.Write(p_Writer, ListenersCapacity);
        p_Writer.WriteObject(FixedConnectivity);
        HkSmallArray.Write(p_Writer, DecorationsCapacity);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        BodyTypeAndFlags = p_Reader.ReadByte();
        ConstraintStrength = p_Reader.ReadUInt16();
        p_Reader.SkipPointerSlot();
        PhysicsBody = p_Reader.ReadObject<HkpRigidBody>();
        BreakableShape = p_Reader.ReadObject<HkdBreakableShape>();
        Controller = p_Reader.ReadObject<HkdController>();
        GraphicsBody = p_Reader.ReadObject();
        ObjectProperties = HkdProperties.Read(p_Reader);
        ListenersCapacity = HkSmallArray.Read(p_Reader);
        FixedConnectivity = p_Reader.ReadObject();
        DecorationsCapacity = HkSmallArray.Read(p_Reader);
        p_Reader.EndClass();
    }
}

/// <summary>What decides how a breakable body breaks.</summary>
public abstract class HkdController : HkObject
{
    public byte Type { get; set; }
    public HkObject? InsideDecisionFunctor { get; set; }
    public ushort ListenersCapacity { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(Type);
        p_Writer.WriteObject(InsideDecisionFunctor);
        HkSmallArray.Write(p_Writer, ListenersCapacity);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Type = p_Reader.ReadByte();
        InsideDecisionFunctor = p_Reader.ReadObject();
        ListenersCapacity = HkSmallArray.Read(p_Reader);
        p_Reader.EndClass();
    }
}

public sealed class HkdBuildingController : HkdController
{
    public override string ClassName => "hkdBuildingController";
}

/// <summary>Which of a breakable body's shape keys each child shape has.</summary>
public sealed class HkdBreakableBodyShapeKeyToChildMap : HkObject
{
    public override string ClassName => "hkdBreakableBodyShapeKeyToChildMap";

    public sealed record ShapeKeyToChild(List<uint> Keys, HkdBreakableShape? Child);

    public List<ShapeKeyToChild> ShapeKeyToChildren { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteArray(ShapeKeyToChildren, p_Writer.PointerSize, (p_E, p_M) =>
        {
            p_E.WriteArray(p_M.Keys, 4, (p_K, p_Key) => p_K.Write(p_Key));
            p_E.WriteObject(p_M.Child);
        });
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        ShapeKeyToChildren = p_Reader.ReadArray(p_Reader.PointerSize, p_E =>
            new ShapeKeyToChild(p_E.ReadArray(4, p_K => p_K.ReadUInt32()), p_E.ReadObject<HkdBreakableShape>()));
        p_Reader.EndClass();
    }
}

/// <summary>Where breakable shapes touch, which decides what holds together.</summary>
public sealed class HkdBreakableShapeConnectionList : HkObject
{
    public override string ClassName => "hkdBreakableShapeConnectionList";

    public sealed record Connection(Vector4 PivotA, Vector4 PivotB, Vector4 SeparatingNormal, float ContactArea,
        HkdBreakableShape? A, HkdBreakableShape? B);

    public List<Connection> Connections { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteArray(Connections, 16, (p_E, p_C) =>
        {
            p_E.Write(p_C.PivotA);
            p_E.Write(p_C.PivotB);
            p_E.Write(p_C.SeparatingNormal);
            p_E.Write(p_C.ContactArea);
            p_E.WriteObject(p_C.A);
            p_E.WriteObject(p_C.B);
            p_E.WritePointerSlot();
        });
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Connections = p_Reader.ReadArray(16, p_E =>
        {
            var s_Connection = new Connection(p_E.ReadVector4(), p_E.ReadVector4(), p_E.ReadVector4(), p_E.ReadSingle(),
                p_E.ReadObject<HkdBreakableShape>(), p_E.ReadObject<HkdBreakableShape>());
            p_E.SkipPointerSlot();
            return s_Connection;
        });
        p_Reader.EndClass();
    }
}

/// <summary>The actions a breakable shape runs when it breaks.</summary>
public sealed class HkdBreakableShapeActionList : HkObject
{
    public override string ClassName => "hkdBreakableShapeActionList";

    public List<HkdAction> Actions { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteObjects(Actions);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Actions = p_Reader.ReadObjects<HkdAction>();
        p_Reader.EndClass();
    }
}

/// <summary>Something a breakable shape does when it breaks.</summary>
public abstract class HkdAction : HkObject
{
    public byte InheritanceType { get; set; }
    public byte ExecutionType { get; set; }
    public ushort Padding { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(InheritanceType);
        p_Writer.Write(ExecutionType);
        p_Writer.Write(Padding);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        InheritanceType = p_Reader.ReadByte();
        ExecutionType = p_Reader.ReadByte();
        Padding = p_Reader.ReadUInt16();
        p_Reader.EndClass();
    }
}

/// <summary>Pushes the pieces of a broken shape away from a centre.</summary>
public sealed class HkdExplosionForceAction : HkdAction
{
    public override string ClassName => "hkdExplosionForceAction";

    public Vector4 ExplosionCenter { get; set; }
    public byte ExplosionCenterSpace { get; set; }
    public Vector4 Velocity { get; set; }
    public float ExpandingVelocity { get; set; }
    public float VirtMass { get; set; }
    public float AngularImpulseFactor { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(ExplosionCenter);
        p_Writer.Write(ExplosionCenterSpace);
        p_Writer.Write(Velocity);
        p_Writer.Write(ExpandingVelocity);
        p_Writer.Write(VirtMass);
        p_Writer.Write(AngularImpulseFactor);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        ExplosionCenter = p_Reader.ReadVector4();
        ExplosionCenterSpace = p_Reader.ReadByte();
        Velocity = p_Reader.ReadVector4();
        ExpandingVelocity = p_Reader.ReadSingle();
        VirtMass = p_Reader.ReadSingle();
        AngularImpulseFactor = p_Reader.ReadSingle();
        p_Reader.EndClass();
    }
}

/// <summary>Decorations, by shape, density and spacing, along one kind of fracture face.</summary>
public sealed record HkdFractureFaceInfo(HkdBreakableShape? Decorations, float Density, float Gap, float SpinAngle, float XShift, float XRandomShift)
{
    internal void Write(HkWriter p_Writer)
    {
        p_Writer.WriteObject(Decorations);
        p_Writer.Write(Density);
        p_Writer.Write(Gap);
        p_Writer.Write(SpinAngle);
        p_Writer.Write(XShift);
        p_Writer.Write(XRandomShift);
    }

    internal static HkdFractureFaceInfo Read(HkReader p_Reader) => new(p_Reader.ReadObject<HkdBreakableShape>(),
        p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle());
}

/// <summary>Places decoration shapes along the faces a fracture opens.</summary>
public sealed class HkdDecorateFractureFaceAction : HkdAction
{
    public override string ClassName => "hkdDecorateFractureFaceAction";

    public sealed record CornerDecorationInfo(HkdBreakableShape? Decorations, float Density, float MinimumDistance, float MaximumVerticalShift);

    public byte DecorateWhat { get; set; }
    public byte DecorationPivot { get; set; }
    public Vector4 UpDir { get; set; }
    public byte AlignDecorations { get; set; }
    public HkdBreakableShape? ControlShapes { get; set; }
    public Vector4[] ControlShapesTransform { get; set; } = new Vector4[4];
    public float MinFractureLength { get; set; }
    public float LinearTolerance { get; set; }
    public float AngularTolerance { get; set; }
    public byte DecorationsStorage { get; set; }
    public bool KeepFixedDecorations { get; set; }
    public byte ProtrusionTest { get; set; }
    public float MaxProtrusion { get; set; }
    public float FixupDistance { get; set; }
    public bool EqualizeGaps { get; set; }
    public float VertGridDist { get; set; }
    public float VertGridOffset { get; set; }
    public float HorGridDist { get; set; }
    public float HorGridOffset { get; set; }
    public HkdFractureFaceInfo? Top { get; set; }
    public HkdFractureFaceInfo? Bottom { get; set; }
    public HkdFractureFaceInfo? Side { get; set; }
    public HkdFractureFaceInfo? Flat { get; set; }
    public CornerDecorationInfo? Corner { get; set; }
    public int NumCornerDecorationAttempts { get; set; }
    public float BorderOverlap { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(DecorateWhat);
        p_Writer.Write(DecorationPivot);
        p_Writer.Write(UpDir);
        p_Writer.Write(AlignDecorations);
        p_Writer.WriteObject(ControlShapes);
        foreach (var s_Column in ControlShapesTransform)
            p_Writer.Write(s_Column);
        p_Writer.Write(MinFractureLength);
        p_Writer.Write(LinearTolerance);
        p_Writer.Write(AngularTolerance);
        p_Writer.Write(DecorationsStorage);
        p_Writer.Write(KeepFixedDecorations);
        p_Writer.Write(ProtrusionTest);
        p_Writer.Write(MaxProtrusion);
        p_Writer.Write(FixupDistance);
        p_Writer.Write(EqualizeGaps);
        p_Writer.Write(VertGridDist);
        p_Writer.Write(VertGridOffset);
        p_Writer.Write(HorGridDist);
        p_Writer.Write(HorGridOffset);
        Top!.Write(p_Writer);
        Bottom!.Write(p_Writer);
        Side!.Write(p_Writer);
        Flat!.Write(p_Writer);
        p_Writer.WriteObject(Corner!.Decorations);
        p_Writer.Write(Corner.Density);
        p_Writer.Write(Corner.MinimumDistance);
        p_Writer.Write(Corner.MaximumVerticalShift);
        p_Writer.WritePointerSlot();
        p_Writer.Write(NumCornerDecorationAttempts);
        p_Writer.Write(BorderOverlap);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        DecorateWhat = p_Reader.ReadByte();
        DecorationPivot = p_Reader.ReadByte();
        UpDir = p_Reader.ReadVector4();
        AlignDecorations = p_Reader.ReadByte();
        ControlShapes = p_Reader.ReadObject<HkdBreakableShape>();
        for (var i = 0; i < ControlShapesTransform.Length; ++i)
            ControlShapesTransform[i] = p_Reader.ReadVector4();
        MinFractureLength = p_Reader.ReadSingle();
        LinearTolerance = p_Reader.ReadSingle();
        AngularTolerance = p_Reader.ReadSingle();
        DecorationsStorage = p_Reader.ReadByte();
        KeepFixedDecorations = p_Reader.ReadBool();
        ProtrusionTest = p_Reader.ReadByte();
        MaxProtrusion = p_Reader.ReadSingle();
        FixupDistance = p_Reader.ReadSingle();
        EqualizeGaps = p_Reader.ReadBool();
        VertGridDist = p_Reader.ReadSingle();
        VertGridOffset = p_Reader.ReadSingle();
        HorGridDist = p_Reader.ReadSingle();
        HorGridOffset = p_Reader.ReadSingle();
        Top = HkdFractureFaceInfo.Read(p_Reader);
        Bottom = HkdFractureFaceInfo.Read(p_Reader);
        Side = HkdFractureFaceInfo.Read(p_Reader);
        Flat = HkdFractureFaceInfo.Read(p_Reader);
        Corner = new CornerDecorationInfo(p_Reader.ReadObject<HkdBreakableShape>(), p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle());
        p_Reader.SkipPointerSlot();
        NumCornerDecorationAttempts = p_Reader.ReadInt32();
        BorderOverlap = p_Reader.ReadSingle();
        p_Reader.EndClass();
    }
}

/// <summary>Which decorations a shape has where it meets another, out of the shared data.</summary>
public sealed class HkdDecorateFractureFaceActionShapeDecorationInfo : HkObject
{
    public override string ClassName => "hkdDecorateFractureFaceActionShapeDecorationInfo";

    public sealed record ConnectionDecoration(HkdAction? OwningAction, HkdBreakableShape? OtherShape, ushort StartIndex, ushort NumDecorations);

    public List<ConnectionDecoration> ConnectionDecorations { get; set; } = [];
    public HkdDecorateFractureFaceActionGlobalDecorationData? SharedData { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteArray(ConnectionDecorations, p_Writer.PointerSize, (p_E, p_C) =>
        {
            p_E.WriteObject(p_C.OwningAction);
            p_E.WriteObject(p_C.OtherShape);
            p_E.Write(p_C.StartIndex);
            p_E.Write(p_C.NumDecorations);
        });
        p_Writer.WriteObject(SharedData);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        ConnectionDecorations = p_Reader.ReadArray(p_Reader.PointerSize, p_E =>
            new ConnectionDecoration(p_E.ReadObject<HkdAction>(), p_E.ReadObject<HkdBreakableShape>(), p_E.ReadUInt16(), p_E.ReadUInt16()));
        SharedData = p_Reader.ReadObject<HkdDecorateFractureFaceActionGlobalDecorationData>();
        p_Reader.EndClass();
    }
}

/// <summary>The decoration templates and their placements, shared by the shapes of a resource.</summary>
public sealed class HkdDecorateFractureFaceActionGlobalDecorationData : HkObject
{
    public override string ClassName => "hkdDecorateFractureFaceActionGlobalDecorationData";

    public sealed record CompressedPlacement(ushort BoundingBoxIndex, uint Position, uint Rotation);

    public List<HkdBreakableShape> Templates { get; set; } = [];
    public List<Vector4> BoundingBoxes { get; set; } = [];

    /// <summary>Rotation then translation of each raw placement.</summary>
    public List<(Vector4 Rotation, Vector4 Translation)> RawTransforms { get; set; } = [];

    /// <summary>Three columns of four halves each per half-precision placement.</summary>
    public List<ushort[]> HalfTransforms { get; set; } = [];

    public List<CompressedPlacement> CompressedPlacements { get; set; } = [];
    public List<ushort> IndexBuffer { get; set; } = [];
    public List<ushort> GraphicsRanges { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteObjects(Templates);
        p_Writer.WriteArray(BoundingBoxes, 16, (p_E, p_V) => p_E.Write(p_V));
        p_Writer.WriteArray(RawTransforms, 16, (p_E, p_T) =>
        {
            p_E.Write(p_T.Rotation);
            p_E.Write(p_T.Translation);
        });
        p_Writer.WriteArray(HalfTransforms, 2, (p_E, p_T) =>
        {
            foreach (var s_Half in p_T)
                p_E.Write(s_Half);
        });
        p_Writer.WriteArray(CompressedPlacements, 4, (p_E, p_P) =>
        {
            p_E.Write(p_P.BoundingBoxIndex);
            p_E.Write(p_P.Position);
            p_E.Write(p_P.Rotation);
        });
        p_Writer.WriteArray(IndexBuffer, 2, (p_E, p_V) => p_E.Write(p_V));
        p_Writer.WriteArray(GraphicsRanges, 2, (p_E, p_V) => p_E.Write(p_V));
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Templates = p_Reader.ReadObjects<HkdBreakableShape>();
        BoundingBoxes = p_Reader.ReadArray(16, p_E => p_E.ReadVector4());
        RawTransforms = p_Reader.ReadArray(16, p_E => (p_E.ReadVector4(), p_E.ReadVector4()));
        HalfTransforms = p_Reader.ReadArray(2, p_E =>
        {
            var s_Halves = new ushort[12];
            for (var i = 0; i < s_Halves.Length; ++i)
                s_Halves[i] = p_E.ReadUInt16();
            return s_Halves;
        });
        CompressedPlacements = p_Reader.ReadArray(4, p_E => new CompressedPlacement(p_E.ReadUInt16(), p_E.ReadUInt32(), p_E.ReadUInt32()));
        IndexBuffer = p_Reader.ReadArray(2, p_E => p_E.ReadUInt16());
        GraphicsRanges = p_Reader.ReadArray(2, p_E => p_E.ReadUInt16());
        p_Reader.EndClass();
    }
}

/// <summary>How a breakable shape breaks.</summary>
public abstract class HkdFracture : HkObject
{
    public float RootToLeafRatio { get; set; }
    public float MinimumSize { get; set; }
    public float MaxDistanceForConnection { get; set; }
    public byte Type { get; set; }
    public byte RefitPhysicsShapes { get; set; }
    public bool FlattenHierarchy { get; set; }
    public HkdFracture? ChildFracture { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(RootToLeafRatio);
        p_Writer.Write(MinimumSize);
        p_Writer.Write(MaxDistanceForConnection);
        p_Writer.Write(Type);
        p_Writer.Write(RefitPhysicsShapes);
        p_Writer.Write(FlattenHierarchy);
        p_Writer.WriteObject(ChildFracture);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        RootToLeafRatio = p_Reader.ReadSingle();
        MinimumSize = p_Reader.ReadSingle();
        MaxDistanceForConnection = p_Reader.ReadSingle();
        Type = p_Reader.ReadByte();
        RefitPhysicsShapes = p_Reader.ReadByte();
        FlattenHierarchy = p_Reader.ReadBool();
        ChildFracture = p_Reader.ReadObject<HkdFracture>();
        p_Reader.EndClass();
    }
}

/// <summary>Breaks a shape into copies of a debris template.</summary>
public sealed class HkdDebrisFracture : HkdFracture
{
    public override string ClassName => "hkdDebrisFracture";

    public HkdBreakableShape? TemplateDebris { get; set; }
    public byte InsertType { get; set; }

    /// <summary>The three bytes after the insert type, padding in BF3's layout, which its tool leaves set; kept as stored.</summary>
    public byte[] InsertTypePadding { get; set; } = new byte[3];

    public float Gap { get; set; }
    public float Density { get; set; }
    public uint MaxNumPieces { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteObject(TemplateDebris);
        p_Writer.Write(InsertType);
        foreach (var s_Byte in InsertTypePadding)
            p_Writer.Write(s_Byte);
        p_Writer.Write(Gap);
        p_Writer.Write(Density);
        p_Writer.Write(MaxNumPieces);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        TemplateDebris = p_Reader.ReadObject<HkdBreakableShape>();
        InsertType = p_Reader.ReadByte();
        for (var i = 0; i < InsertTypePadding.Length; ++i)
            InsertTypePadding[i] = p_Reader.ReadByte();
        Gap = p_Reader.ReadSingle();
        Density = p_Reader.ReadSingle();
        MaxNumPieces = p_Reader.ReadUInt32();
        p_Reader.EndClass();
    }
}

/// <summary>A string kept as a breakable shape's property.</summary>
public sealed class HkdStringObject : HkObject
{
    public override string ClassName => "hkdStringObject";

    public string? String { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteString(String);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        String = p_Reader.ReadString();
        p_Reader.EndClass();
    }
}

/// <summary>Flags kept as a breakable shape's property: values by key.</summary>
public sealed class HkdPropertyFlagSet : HkObject
{
    public override string ClassName => "hkdPropertyFlagSet";

    public sealed record Property(uint Key, uint AlignmentPadding, uint ValueLow, uint ValueHigh);

    public List<Property> Properties { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteArray(Properties, 8, (p_E, p_P) =>
        {
            p_E.Write(p_P.Key);
            p_E.Write(p_P.AlignmentPadding);
            p_E.Write(p_P.ValueLow);
            p_E.Write(p_P.ValueHigh);
        });
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Properties = p_Reader.ReadArray(8, p_E => new Property(p_E.ReadUInt32(), p_E.ReadUInt32(), p_E.ReadUInt32(), p_E.ReadUInt32()));
        p_Reader.EndClass();
    }
}

/// <summary>Frostbite's graphics shape of a breakable shape: which parts of the mesh it shows.</summary>
public sealed class HavokGraphicsShape : HkObject
{
    public override string ClassName => "HavokGraphicsShape";

    public sealed record DisplayPart(ushort Index, int PartType);

    public byte Type { get; set; }
    public int NumChildTransforms { get; set; }
    public List<DisplayPart> DisplayParts { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(Type);
        p_Writer.Write(NumChildTransforms);
        p_Writer.EndClass();
        p_Writer.WriteArray(DisplayParts, 4, (p_E, p_P) =>
        {
            p_E.Write(p_P.Index);
            p_E.Write(p_P.PartType);
        });
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Type = p_Reader.ReadByte();
        NumChildTransforms = p_Reader.ReadInt32();
        p_Reader.EndClass();
        DisplayParts = p_Reader.ReadArray(4, p_E => new DisplayPart(p_E.ReadUInt16(), p_E.ReadInt32()));
        p_Reader.EndClass();
    }
}
