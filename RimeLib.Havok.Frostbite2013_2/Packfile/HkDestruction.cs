using System;
using System.Collections.Generic;
using System.Numerics;
using RimeLib.Havok.Frostbite2_0.Packfile;

namespace RimeLib.Havok.Frostbite2013_2.Packfile;

/// <summary>
/// Havok 2012's packfile classes, where they differ from Havok 2010's: a breakable shape and body
/// keep their physics shape, material, controller and breakable shape in hkpBreakableShape and
/// hkpBreakableBody bases. Other classes BF4's destruction resources share with BF3's are read with
/// Havok 2010's; the rest, shapes and the physics container holding them among them, are left
/// unread, to be read by offset.
/// </summary>
public static class HkClasses2012
{
    private static readonly Dictionary<string, Func<HkObject>> s_Classes = new(StringComparer.Ordinal)
    {
        ["hkRootLevelContainer"] = () => new HkRootLevelContainer(),
        ["hkMemoryResourceContainer"] = () => new HkMemoryResourceContainer(),
        ["hkMemoryResourceHandle"] = () => new HkMemoryResourceHandle(),
        ["HavokGraphicsShape"] = () => new HavokGraphicsShape(),
        ["hkdPropertyFlagSet"] = () => new HkdPropertyFlagSet(),
        ["hkdStringObject"] = () => new HkdStringObject(),
        ["hkdBreakableBody"] = () => new HkdBreakableBody2012(),
        ["hkdBreakableShape"] = () => new HkdBreakableShape2012(),
        ["hkdCompoundBreakableShape"] = () => new HkdCompoundBreakableShape2012(),
        ["hkpSimpleBreakableMaterial"] = () => new HkpSimpleBreakableMaterial(),
        ["hkdBuildingController"] = () => new HkdBuildingController2012(),
        ["hkdBreakableShapeActionList"] = () => new HkdBreakableShapeActionList2012(),
        ["hkdBreakableShapeConnectionList"] = () => new HkdBreakableShapeConnectionList2012(),
        ["hkdDebrisFracture"] = () => new HkdDebrisFracture2012(),
        ["hkdExplosionForceAction"] = () => new HkdExplosionForceAction2012(),
        ["hkdDecorateFractureFaceAction"] = () => new HkdDecorateFractureFaceAction2012(),
        ["hkdDecorateFractureFaceActionShapeDecorationInfo"] = () => new HkdDecorateFractureFaceActionShapeDecorationInfo2012(),
        ["hkdDecorateFractureFaceActionGlobalDecorationData"] = () => new HkdDecorateFractureFaceActionGlobalDecorationData2012(),
    };

    /// <summary>The object of a class: modelled where its layout is known, otherwise left unread with its offset.</summary>
    public static HkObject Create(string p_ClassName, int p_Offset) =>
        s_Classes.TryGetValue(p_ClassName, out var s_Create) ? s_Create() : new HkUnreadObject(p_ClassName, p_Offset);
}

/// <summary>A breakable shape's material: its strength and kind.</summary>
public sealed class HkpSimpleBreakableMaterial : HkObject
{
    public override string ClassName => "hkpSimpleBreakableMaterial";

    public float Strength { get; set; }
    public int TypeAndFlags { get; set; }
    public HkObject? Properties { get; set; }

    protected override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(Strength);
        p_Writer.Write(TypeAndFlags);
        p_Writer.WriteObject(Properties);
        p_Writer.EndClass();
    }

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Strength = p_Reader.ReadSingle();
        TypeAndFlags = p_Reader.ReadInt32();
        Properties = p_Reader.ReadObject();
        p_Reader.EndClass();
    }
}

/// <summary>A Havok 2012 breakable shape: hkpBreakableShape's physics shape and material, then hkdBreakableShape's.</summary>
public class HkdBreakableShape2012 : HkObject
{
    public override string ClassName => "hkdBreakableShape";

    public HkObject? PhysicsShape { get; set; }
    public HkObject? Material { get; set; }
    public byte TypeAndFlags { get; set; }
    public byte ConnectivityType { get; set; }
    public byte FlexibleJointType { get; set; }
    public byte QualityType { get; set; }
    public HkdBreakableShape2012? Parent { get; set; }
    public uint MajorAxisSpace { get; set; }
    public HkObject? Geometry { get; set; }
    public Vector4 ComAndMass { get; set; }
    public ushort[] InertiaAndValues { get; set; } = new ushort[8];
    public List<Child> Children { get; set; } = [];
    public HkObject? GraphicsShape { get; set; }
    public List<HkdProperty> ObjectProperties { get; set; } = [];
    public ulong UserData { get; set; }

    /// <summary>A child shape in its parent's space.</summary>
    public sealed record Child(Vector4 Rotation, Vector4 Translation, HkdBreakableShape2012? Shape, byte Damage, byte Flags,
        ushort TempControllerData, float DistanceToDestructionPoint, byte ForceFixed, ushort ParentUid);

    protected override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteObject(PhysicsShape);
        p_Writer.WriteObject(Material);
        p_Writer.EndClass();
        p_Writer.Write(TypeAndFlags);
        p_Writer.Write(ConnectivityType);
        p_Writer.Write(FlexibleJointType);
        p_Writer.Write(QualityType);
        p_Writer.WriteObject(Parent);
        p_Writer.Write(MajorAxisSpace);
        p_Writer.WriteObject(Geometry);
        p_Writer.Write(ComAndMass);
        foreach (var s_Half in InertiaAndValues)
            p_Writer.Write(s_Half);
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
        p_Writer.WriteObject(GraphicsShape);
        HkdProperties.Write(p_Writer, ObjectProperties);
        p_Writer.WriteUlong(UserData);
        p_Writer.EndClass();
    }

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        PhysicsShape = p_Reader.ReadObject();
        Material = p_Reader.ReadObject();
        p_Reader.EndClass();
        TypeAndFlags = p_Reader.ReadByte();
        ConnectivityType = p_Reader.ReadByte();
        FlexibleJointType = p_Reader.ReadByte();
        QualityType = p_Reader.ReadByte();
        Parent = p_Reader.ReadObject<HkdBreakableShape2012>();
        MajorAxisSpace = p_Reader.ReadUInt32();
        Geometry = p_Reader.ReadObject();
        ComAndMass = p_Reader.ReadVector4();
        for (var i = 0; i < InertiaAndValues.Length; ++i)
            InertiaAndValues[i] = p_Reader.ReadUInt16();
        Children = p_Reader.ReadArray(16, p_E => new Child(p_E.ReadVector4(), p_E.ReadVector4(), p_E.ReadObject<HkdBreakableShape2012>(),
            p_E.ReadByte(), p_E.ReadByte(), p_E.ReadUInt16(), p_E.ReadSingle(), p_E.ReadByte(), p_E.ReadUInt16()));
        GraphicsShape = p_Reader.ReadObject();
        ObjectProperties = HkdProperties.Read(p_Reader);
        UserData = p_Reader.ReadUlong();
        p_Reader.EndClass();
    }
}

/// <summary>A Havok 2012 breakable shape of breakable children.</summary>
public sealed class HkdCompoundBreakableShape2012 : HkdBreakableShape2012
{
    public override string ClassName => "hkdCompoundBreakableShape";

    public HkdBreakableShape2012? RootBreakableShape { get; set; }
    public bool UseChildrenBreakableThreshold { get; set; }
    public int UnusedPaddingCompound { get; set; }

    protected override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteObject(RootBreakableShape);
        p_Writer.Write(UseChildrenBreakableThreshold);
        p_Writer.WritePointerSlot();
        p_Writer.Write(UnusedPaddingCompound);
        p_Writer.EndClass();
    }

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        RootBreakableShape = p_Reader.ReadObject<HkdBreakableShape2012>();
        UseChildrenBreakableThreshold = p_Reader.ReadBool();
        p_Reader.SkipPointerSlot();
        UnusedPaddingCompound = p_Reader.ReadInt32();
        p_Reader.EndClass();
    }
}

/// <summary>A Havok 2012 breakable body: hkpBreakableBody's controller, shape and flags, then hkdBreakableBody's.</summary>
public sealed class HkdBreakableBody2012 : HkObject
{
    public override string ClassName => "hkdBreakableBody";

    public HkObject? Controller { get; set; }
    public HkdBreakableShape2012? BreakableShape { get; set; }
    public byte BodyTypeAndFlags { get; set; }
    public ushort ConstraintStrength { get; set; }
    public HkObject? PhysicsBody { get; set; }
    public HkObject? GraphicsBody { get; set; }
    public List<HkdProperty> ObjectProperties { get; set; } = [];
    public ushort ListenersCapacity { get; set; }
    public HkObject? FixedConnectivity { get; set; }
    public ushort DecorationsCapacity { get; set; }

    protected override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteObject(Controller);
        p_Writer.WriteObject(BreakableShape);
        p_Writer.Write(BodyTypeAndFlags);
        p_Writer.Write(ConstraintStrength);
        p_Writer.EndClass();
        p_Writer.WritePointerSlot();
        p_Writer.WriteObject(PhysicsBody);
        p_Writer.WriteObject(GraphicsBody);
        HkdProperties.Write(p_Writer, ObjectProperties);
        HkSmallArray.Write(p_Writer, ListenersCapacity);
        p_Writer.WriteObject(FixedConnectivity);
        HkSmallArray.Write(p_Writer, DecorationsCapacity);
        p_Writer.EndClass();
    }

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Controller = p_Reader.ReadObject();
        BreakableShape = p_Reader.ReadObject<HkdBreakableShape2012>();
        BodyTypeAndFlags = p_Reader.ReadByte();
        ConstraintStrength = p_Reader.ReadUInt16();
        p_Reader.EndClass();
        p_Reader.SkipPointerSlot();
        PhysicsBody = p_Reader.ReadObject();
        GraphicsBody = p_Reader.ReadObject();
        ObjectProperties = HkdProperties.Read(p_Reader);
        ListenersCapacity = HkSmallArray.Read(p_Reader);
        FixedConnectivity = p_Reader.ReadObject();
        DecorationsCapacity = HkSmallArray.Read(p_Reader);
        p_Reader.EndClass();
    }
}

/// <summary>A Havok 2012 building controller: hkpBreakableBody::Controller's breaking impulse, hkdController's, and its physics shape type.</summary>
public sealed class HkdBuildingController2012 : HkObject
{
    public override string ClassName => "hkdBuildingController";

    public float BreakingImpulse { get; set; }
    public byte Type { get; set; }
    public HkObject? InsideDecisionFunctor { get; set; }
    public ushort ListenersCapacity { get; set; }
    public HkObject? DynamicFractureBridge { get; set; }
    public byte PhysicsShapeType { get; set; }

    protected override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(BreakingImpulse);
        p_Writer.EndClass();
        p_Writer.Write(Type);
        p_Writer.WriteObject(InsideDecisionFunctor);
        HkSmallArray.Write(p_Writer, ListenersCapacity);
        p_Writer.WriteObject(DynamicFractureBridge);
        p_Writer.EndClass();
        p_Writer.Write(PhysicsShapeType);
        p_Writer.EndClass();
    }

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        BreakingImpulse = p_Reader.ReadSingle();
        p_Reader.EndClass();
        Type = p_Reader.ReadByte();
        InsideDecisionFunctor = p_Reader.ReadObject();
        ListenersCapacity = HkSmallArray.Read(p_Reader);
        DynamicFractureBridge = p_Reader.ReadObject();
        p_Reader.EndClass();
        PhysicsShapeType = p_Reader.ReadByte();
        p_Reader.EndClass();
    }
}

/// <summary>The actions a Havok 2012 breakable shape runs when it breaks.</summary>
public sealed class HkdBreakableShapeActionList2012 : HkObject
{
    public override string ClassName => "hkdBreakableShapeActionList";

    public List<HkObject> Actions { get; set; } = [];

    protected override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteObjects(Actions);
        p_Writer.EndClass();
    }

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Actions = p_Reader.ReadObjects<HkObject>();
        p_Reader.EndClass();
    }
}

/// <summary>Where Havok 2012 breakable shapes touch.</summary>
public sealed class HkdBreakableShapeConnectionList2012 : HkObject
{
    public override string ClassName => "hkdBreakableShapeConnectionList";

    public sealed record Connection(Vector4 PivotA, Vector4 PivotB, Vector4 SeparatingNormal, float ContactArea, HkObject? A, HkObject? B);

    public List<Connection> Connections { get; set; } = [];

    protected override void Write(HkWriter p_Writer)
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

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Connections = p_Reader.ReadArray(16, p_E =>
        {
            var s_Connection = new Connection(p_E.ReadVector4(), p_E.ReadVector4(), p_E.ReadVector4(), p_E.ReadSingle(), p_E.ReadObject(), p_E.ReadObject());
            p_E.SkipPointerSlot();
            return s_Connection;
        });
        p_Reader.EndClass();
    }
}

/// <summary>Havok 2012's debris fracture: hkdFracture's, then the debris template, control shapes and placement.</summary>
public sealed class HkdDebrisFracture2012 : HkObject
{
    public override string ClassName => "hkdDebrisFracture";

    public float RootToLeafRatio { get; set; }
    public float MinimumSize { get; set; }
    public float MaxDistanceForConnection { get; set; }
    public byte Type { get; set; }
    public byte RefitPhysicsShapes { get; set; }
    public bool FlattenHierarchy { get; set; }
    public HkObject? ChildFracture { get; set; }
    public HkObject? TemplateDebris { get; set; }
    public uint MaxNumPieces { get; set; }
    public byte InsertType { get; set; }
    public HkObject? ControlShapes { get; set; }
    public Vector4[] ControlShapesTransform { get; set; } = new Vector4[4];
    public byte PositionSource { get; set; }
    public byte GenerationType { get; set; }
    public float Gap { get; set; }
    public float Density { get; set; }

    protected override void Write(HkWriter p_Writer)
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
        p_Writer.WriteObject(TemplateDebris);
        p_Writer.Write(MaxNumPieces);
        p_Writer.Write(InsertType);
        p_Writer.WriteObject(ControlShapes);
        foreach (var s_Column in ControlShapesTransform)
            p_Writer.Write(s_Column);
        p_Writer.Write(PositionSource);
        p_Writer.Write(GenerationType);
        p_Writer.Write(Gap);
        p_Writer.Write(Density);
        p_Writer.EndClass();
    }

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        RootToLeafRatio = p_Reader.ReadSingle();
        MinimumSize = p_Reader.ReadSingle();
        MaxDistanceForConnection = p_Reader.ReadSingle();
        Type = p_Reader.ReadByte();
        RefitPhysicsShapes = p_Reader.ReadByte();
        FlattenHierarchy = p_Reader.ReadBool();
        ChildFracture = p_Reader.ReadObject();
        p_Reader.EndClass();
        TemplateDebris = p_Reader.ReadObject();
        MaxNumPieces = p_Reader.ReadUInt32();
        InsertType = p_Reader.ReadByte();
        ControlShapes = p_Reader.ReadObject();
        for (var i = 0; i < ControlShapesTransform.Length; ++i)
            ControlShapesTransform[i] = p_Reader.ReadVector4();
        PositionSource = p_Reader.ReadByte();
        GenerationType = p_Reader.ReadByte();
        Gap = p_Reader.ReadSingle();
        Density = p_Reader.ReadSingle();
        p_Reader.EndClass();
    }
}

/// <summary>Havok 2012's explosion force action, laid out as Havok 2010's.</summary>
public sealed class HkdExplosionForceAction2012 : HkObject
{
    public override string ClassName => "hkdExplosionForceAction";

    public byte InheritanceType { get; set; }
    public byte ExecutionType { get; set; }
    public ushort Padding { get; set; }
    public Vector4 ExplosionCenter { get; set; }
    public byte ExplosionCenterSpace { get; set; }
    public Vector4 Velocity { get; set; }
    public float ExpandingVelocity { get; set; }
    public float VirtMass { get; set; }
    public float AngularImpulseFactor { get; set; }

    protected override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(InheritanceType);
        p_Writer.Write(ExecutionType);
        p_Writer.Write(Padding);
        p_Writer.EndClass();
        p_Writer.Write(ExplosionCenter);
        p_Writer.Write(ExplosionCenterSpace);
        p_Writer.Write(Velocity);
        p_Writer.Write(ExpandingVelocity);
        p_Writer.Write(VirtMass);
        p_Writer.Write(AngularImpulseFactor);
        p_Writer.EndClass();
    }

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        InheritanceType = p_Reader.ReadByte();
        ExecutionType = p_Reader.ReadByte();
        Padding = p_Reader.ReadUInt16();
        p_Reader.EndClass();
        ExplosionCenter = p_Reader.ReadVector4();
        ExplosionCenterSpace = p_Reader.ReadByte();
        Velocity = p_Reader.ReadVector4();
        ExpandingVelocity = p_Reader.ReadSingle();
        VirtMass = p_Reader.ReadSingle();
        AngularImpulseFactor = p_Reader.ReadSingle();
        p_Reader.EndClass();
    }
}

/// <summary>Havok 2012's decorations along one kind of fracture face, with random spin and flip.</summary>
public sealed record HkdFractureFaceInfo2012(HkObject? Decorations, float Density, float Gap, float SpinAngle, float RandomSpinAngle,
    bool AllowRandomFlipX, float XShift, float XRandomShift)
{
    internal void Write(HkWriter p_Writer)
    {
        p_Writer.WriteObject(Decorations);
        p_Writer.Write(Density);
        p_Writer.Write(Gap);
        p_Writer.Write(SpinAngle);
        p_Writer.Write(RandomSpinAngle);
        p_Writer.Write(AllowRandomFlipX);
        p_Writer.Write(XShift);
        p_Writer.Write(XRandomShift);
    }

    internal static HkdFractureFaceInfo2012 Read(HkReader p_Reader) => new(p_Reader.ReadObject(), p_Reader.ReadSingle(), p_Reader.ReadSingle(),
        p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadBool(), p_Reader.ReadSingle(), p_Reader.ReadSingle());
}

/// <summary>Havok 2012's decorate fracture face action, with padding, weighting and edge options Havok 2010's lacks.</summary>
public sealed class HkdDecorateFractureFaceAction2012 : HkObject
{
    public override string ClassName => "hkdDecorateFractureFaceAction";

    public byte InheritanceType { get; set; }
    public byte ExecutionType { get; set; }
    public ushort Padding { get; set; }
    public byte DecorateWhat { get; set; }
    public byte DecorationPivot { get; set; }
    public Vector4 UpDir { get; set; }
    public byte AlignDecorations { get; set; }
    public HkObject? ControlShapes { get; set; }
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
    public float OuterDecorationPadding { get; set; }
    public float InnerDecorationPadding { get; set; }
    public bool PrioritizeBiggerDecorations { get; set; }
    public float RandomWeightModifier { get; set; }
    public float VertGridDist { get; set; }
    public float VertGridOffset { get; set; }
    public float HorGridDist { get; set; }
    public float HorGridOffset { get; set; }
    public HkdFractureFaceInfo2012? Top { get; set; }
    public HkdFractureFaceInfo2012? Bottom { get; set; }
    public HkdFractureFaceInfo2012? Side { get; set; }
    public HkdFractureFaceInfo2012? Flat { get; set; }
    public HkObject? CornerDecorations { get; set; }
    public float CornerDensity { get; set; }
    public float CornerMinimumDistance { get; set; }
    public float CornerMaximumVerticalShift { get; set; }
    public int NumCornerDecorationAttempts { get; set; }
    public float BorderOverlap { get; set; }
    public bool ForceBorderOnEdges { get; set; }
    public float MaxAngleBetweenEdges { get; set; }

    protected override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(InheritanceType);
        p_Writer.Write(ExecutionType);
        p_Writer.Write(Padding);
        p_Writer.EndClass();
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
        p_Writer.Write(OuterDecorationPadding);
        p_Writer.Write(InnerDecorationPadding);
        p_Writer.Write(PrioritizeBiggerDecorations);
        p_Writer.Write(RandomWeightModifier);
        p_Writer.Write(VertGridDist);
        p_Writer.Write(VertGridOffset);
        p_Writer.Write(HorGridDist);
        p_Writer.Write(HorGridOffset);
        Top!.Write(p_Writer);
        Bottom!.Write(p_Writer);
        Side!.Write(p_Writer);
        Flat!.Write(p_Writer);
        p_Writer.WriteObject(CornerDecorations);
        p_Writer.Write(CornerDensity);
        p_Writer.Write(CornerMinimumDistance);
        p_Writer.Write(CornerMaximumVerticalShift);
        p_Writer.WritePointerSlot();
        p_Writer.Write(NumCornerDecorationAttempts);
        p_Writer.Write(BorderOverlap);
        p_Writer.Write(ForceBorderOnEdges);
        p_Writer.Write(MaxAngleBetweenEdges);
        p_Writer.EndClass();
    }

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        InheritanceType = p_Reader.ReadByte();
        ExecutionType = p_Reader.ReadByte();
        Padding = p_Reader.ReadUInt16();
        p_Reader.EndClass();
        DecorateWhat = p_Reader.ReadByte();
        DecorationPivot = p_Reader.ReadByte();
        UpDir = p_Reader.ReadVector4();
        AlignDecorations = p_Reader.ReadByte();
        ControlShapes = p_Reader.ReadObject();
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
        OuterDecorationPadding = p_Reader.ReadSingle();
        InnerDecorationPadding = p_Reader.ReadSingle();
        PrioritizeBiggerDecorations = p_Reader.ReadBool();
        RandomWeightModifier = p_Reader.ReadSingle();
        VertGridDist = p_Reader.ReadSingle();
        VertGridOffset = p_Reader.ReadSingle();
        HorGridDist = p_Reader.ReadSingle();
        HorGridOffset = p_Reader.ReadSingle();
        Top = HkdFractureFaceInfo2012.Read(p_Reader);
        Bottom = HkdFractureFaceInfo2012.Read(p_Reader);
        Side = HkdFractureFaceInfo2012.Read(p_Reader);
        Flat = HkdFractureFaceInfo2012.Read(p_Reader);
        CornerDecorations = p_Reader.ReadObject();
        CornerDensity = p_Reader.ReadSingle();
        CornerMinimumDistance = p_Reader.ReadSingle();
        CornerMaximumVerticalShift = p_Reader.ReadSingle();
        p_Reader.SkipPointerSlot();
        NumCornerDecorationAttempts = p_Reader.ReadInt32();
        BorderOverlap = p_Reader.ReadSingle();
        ForceBorderOnEdges = p_Reader.ReadBool();
        MaxAngleBetweenEdges = p_Reader.ReadSingle();
        p_Reader.EndClass();
    }
}

/// <summary>Which decorations a Havok 2012 shape has where it meets another.</summary>
public sealed class HkdDecorateFractureFaceActionShapeDecorationInfo2012 : HkObject
{
    public override string ClassName => "hkdDecorateFractureFaceActionShapeDecorationInfo";

    public sealed record ConnectionDecoration(HkObject? OwningAction, HkObject? OtherShape, ushort StartIndex, ushort NumDecorations);

    public List<ConnectionDecoration> ConnectionDecorations { get; set; } = [];
    public HkObject? SharedData { get; set; }

    protected override void Write(HkWriter p_Writer)
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

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        ConnectionDecorations = p_Reader.ReadArray(p_Reader.PointerSize, p_E =>
            new ConnectionDecoration(p_E.ReadObject(), p_E.ReadObject(), p_E.ReadUInt16(), p_E.ReadUInt16()));
        SharedData = p_Reader.ReadObject();
        p_Reader.EndClass();
    }
}

/// <summary>Havok 2012's decoration templates and placements, laid out as Havok 2010's.</summary>
public sealed class HkdDecorateFractureFaceActionGlobalDecorationData2012 : HkObject
{
    public override string ClassName => "hkdDecorateFractureFaceActionGlobalDecorationData";

    public List<HkObject> Templates { get; set; } = [];
    public List<Vector4> BoundingBoxes { get; set; } = [];
    public List<(Vector4 Rotation, Vector4 Translation)> RawTransforms { get; set; } = [];
    public List<ushort[]> HalfTransforms { get; set; } = [];
    public List<HkdDecorateFractureFaceActionGlobalDecorationData.CompressedPlacement> CompressedPlacements { get; set; } = [];
    public List<ushort> IndexBuffer { get; set; } = [];
    public List<ushort> GraphicsRanges { get; set; } = [];

    protected override void Write(HkWriter p_Writer)
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

    protected override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Templates = p_Reader.ReadObjects<HkObject>();
        BoundingBoxes = p_Reader.ReadArray(16, p_E => p_E.ReadVector4());
        RawTransforms = p_Reader.ReadArray(16, p_E => (p_E.ReadVector4(), p_E.ReadVector4()));
        HalfTransforms = p_Reader.ReadArray(2, p_E =>
        {
            var s_Halves = new ushort[12];
            for (var i = 0; i < s_Halves.Length; ++i)
                s_Halves[i] = p_E.ReadUInt16();
            return s_Halves;
        });
        CompressedPlacements = p_Reader.ReadArray(4, p_E =>
            new HkdDecorateFractureFaceActionGlobalDecorationData.CompressedPlacement(p_E.ReadUInt16(), p_E.ReadUInt32(), p_E.ReadUInt32()));
        IndexBuffer = p_Reader.ReadArray(2, p_E => p_E.ReadUInt16());
        GraphicsRanges = p_Reader.ReadArray(2, p_E => p_E.ReadUInt16());
        p_Reader.EndClass();
    }
}
