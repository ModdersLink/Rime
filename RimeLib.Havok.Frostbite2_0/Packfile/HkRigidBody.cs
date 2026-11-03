using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>
/// A rigid body, as a breakable body's physics: hkpWorldObject's collidable and properties,
/// hkpEntity's material and motion. Members a packfile does not save are pointer slots the reader
/// requires to be null and the writer leaves null; the rest are kept as stored.
/// </summary>
public sealed class HkpRigidBody : HkObject
{
    public override string ClassName => "hkpRigidBody";

    /// <summary>hkpProperty: a key and a 64-bit value, kept as two words.</summary>
    public sealed record Property(uint Key, uint AlignmentPadding, uint ValueLow, uint ValueHigh);

    // hkpWorldObject
    public ulong UserData { get; set; }

    // hkpLinkedCollidable: hkpCdBody, hkpCollidable
    public HkpShape? Shape { get; set; }
    public uint ShapeKey { get; set; }
    public byte OwnerOffset { get; set; }
    public byte ForceCollideOntoPpu { get; set; }
    public ushort ShapeSizeOnSpu { get; set; }
    public uint BroadPhaseId { get; set; }
    public byte BroadPhaseType { get; set; }
    public byte BroadPhaseOwnerOffset { get; set; }
    public byte ObjectQualityType { get; set; }
    public uint CollisionFilterInfo { get; set; }

    /// <summary>hkpCollidable::BoundingVolumeData before its pointers: min, expansions, max and child counts, as stored.</summary>
    public uint[] BoundingVolumeMin { get; set; } = new uint[3];
    public byte[] BoundingVolumeExpansionMin { get; set; } = new byte[4];
    public uint[] BoundingVolumeMax { get; set; } = new uint[3];
    public byte[] BoundingVolumeExpansionMax { get; set; } = new byte[4];
    public ushort NumChildShapeAabbs { get; set; }
    public ushort CapacityChildShapeAabbs { get; set; }
    public float AllowedPenetrationDepth { get; set; }

    // hkpWorldObject
    public uint MultiThreadCheckThreadId { get; set; }
    public int MultiThreadCheckStackTraceId { get; set; }
    public ushort MultiThreadCheckMarkCount { get; set; }
    public ushort MultiThreadCheckMarkBitStack { get; set; }
    public string? Name { get; set; }
    public List<Property> Properties { get; set; } = [];

    // hkpEntity
    public byte ResponseType { get; set; }
    public ushort RollingFrictionMultiplier { get; set; }
    public float Friction { get; set; }
    public float Restitution { get; set; }
    public float DamageMultiplier { get; set; }
    public uint SolverData { get; set; }
    public ushort StorageIndex { get; set; }
    public ushort ContactPointCallbackDelay { get; set; }
    public ushort ConstraintsMasterCapacity { get; set; }
    public byte AutoRemoveLevel { get; set; }
    public byte NumShapeKeysInContactPointProperties { get; set; }
    public byte ResponseModifierFlags { get; set; }
    public uint Uid { get; set; }
    public ushort SpuCollisionCallbackCapacity { get; set; }
    public byte SpuCollisionCallbackEventFilter { get; set; }
    public byte SpuCollisionCallbackUserFilter { get; set; }

    // hkpMaxSizeMotion: an hkReferencedObject of its own
    public ushort MotionMemSizeAndFlags { get; set; }
    public ushort MotionReferenceCount { get; set; }
    public byte MotionType { get; set; }
    public byte DeactivationIntegrateCounter { get; set; }
    public ushort[] DeactivationNumInactiveFrames { get; set; } = new ushort[2];

    /// <summary>hkMotionState's transform (four columns), swept transform (five vectors) and delta angle.</summary>
    public Vector4[] MotionStateVectors { get; set; } = new Vector4[10];

    public float ObjectRadius { get; set; }
    public ushort LinearDamping { get; set; }
    public ushort AngularDamping { get; set; }
    public ushort TimeFactor { get; set; }
    public byte MaxLinearVelocity { get; set; }
    public byte MaxAngularVelocity { get; set; }
    public byte DeactivationClass { get; set; }
    public Vector4 InertiaAndMassInv { get; set; }
    public Vector4 LinearVelocity { get; set; }
    public Vector4 AngularVelocity { get; set; }
    public Vector4[] DeactivationRefPosition { get; set; } = new Vector4[2];
    public uint[] DeactivationRefOrientation { get; set; } = new uint[2];
    public ushort SavedQualityTypeIndex { get; set; }
    public ushort GravityFactor { get; set; }

    public ushort ContactListenersCapacity { get; set; }
    public ushort ActionsCapacity { get; set; }
    public uint NpData { get; set; }

    /// <summary>
    /// A breakable body's rigid body as BF3's are: unmoving unless <paramref name="p_MotionType"/>
    /// says otherwise, at the origin, with BF3's material, damping and the one property they carry.
    /// </summary>
    public static HkpRigidBody ForBreakableBody(HkpShape p_Shape, float p_ObjectRadius, byte p_MotionType)
    {
        const ushort c_HalfOne = 0x3F80;
        const ushort c_HalfAngularDamping = 0x3D4C;
        const ushort c_InactiveFrames = 0xC000;

        var s_Body = new HkpRigidBody
        {
            Shape = p_Shape,
            ShapeKey = uint.MaxValue,
            ForceCollideOntoPpu = 8,
            BroadPhaseType = 1,
            AllowedPenetrationDepth = float.MaxValue,
            Properties = [new Property(0x2001, 0, 0, 0)],
            ResponseType = 1,
            Friction = 0.5f,
            Restitution = 0.4f,
            DamageMultiplier = 1,
            StorageIndex = ushort.MaxValue,
            ContactPointCallbackDelay = ushort.MaxValue,
            NumShapeKeysInContactPointProperties = 2,
            Uid = uint.MaxValue,
            SpuCollisionCallbackEventFilter = 3,
            SpuCollisionCallbackUserFilter = 1,
            MotionType = p_MotionType,
            DeactivationIntegrateCounter = 15,
            DeactivationNumInactiveFrames = [c_InactiveFrames, c_InactiveFrames],
            ObjectRadius = p_ObjectRadius,
            AngularDamping = c_HalfAngularDamping,
            TimeFactor = c_HalfOne,
            MaxLinearVelocity = 127,
            MaxAngularVelocity = 127,
            DeactivationClass = 1,
            GravityFactor = c_HalfOne,
            NpData = uint.MaxValue,
        };

        // The motion state's transform, swept transform and delta angle: identity, unrotated, at rest.
        s_Body.MotionStateVectors[0] = Vector4.UnitX;
        s_Body.MotionStateVectors[1] = Vector4.UnitY;
        s_Body.MotionStateVectors[2] = Vector4.UnitZ;
        s_Body.MotionStateVectors[6] = Vector4.UnitW;
        s_Body.MotionStateVectors[7] = Vector4.UnitW;
        return s_Body;
    }

    protected internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WritePointerSlot();
        p_Writer.WriteUlong(UserData);

        p_Writer.WriteObject(Shape);
        p_Writer.Write(ShapeKey);
        p_Writer.WritePointerSlot();
        p_Writer.WritePointerSlot();
        p_Writer.Write(OwnerOffset);
        p_Writer.Write(ForceCollideOntoPpu);
        p_Writer.Write(ShapeSizeOnSpu);
        p_Writer.Write(BroadPhaseId);
        p_Writer.Write(BroadPhaseType);
        p_Writer.Write(BroadPhaseOwnerOffset);
        p_Writer.Write(ObjectQualityType);
        p_Writer.Write(CollisionFilterInfo);
        foreach (var s_Value in BoundingVolumeMin)
            p_Writer.Write(s_Value);
        foreach (var s_Value in BoundingVolumeExpansionMin)
            p_Writer.Write(s_Value);
        foreach (var s_Value in BoundingVolumeMax)
            p_Writer.Write(s_Value);
        foreach (var s_Value in BoundingVolumeExpansionMax)
            p_Writer.Write(s_Value);
        p_Writer.Write(NumChildShapeAabbs);
        p_Writer.Write(CapacityChildShapeAabbs);
        p_Writer.WritePointerSlot();
        p_Writer.WritePointerSlot();
        p_Writer.Write(AllowedPenetrationDepth);
        p_Writer.WriteArray(new List<int>(), p_Writer.PointerSize, (_, _) => { });

        p_Writer.Write(MultiThreadCheckThreadId);
        p_Writer.Write(MultiThreadCheckStackTraceId);
        p_Writer.Write(MultiThreadCheckMarkCount);
        p_Writer.Write(MultiThreadCheckMarkBitStack);
        p_Writer.WriteString(Name);
        p_Writer.WriteArray(Properties, 8, (p_E, p_P) =>
        {
            p_E.Write(p_P.Key);
            p_E.Write(p_P.AlignmentPadding);
            p_E.Write(p_P.ValueLow);
            p_E.Write(p_P.ValueHigh);
        });
        p_Writer.WritePointerSlot();

        p_Writer.Write(ResponseType);
        p_Writer.Write(RollingFrictionMultiplier);
        p_Writer.Write(Friction);
        p_Writer.Write(Restitution);
        p_Writer.WritePointerSlot();
        p_Writer.Write(DamageMultiplier);
        p_Writer.WritePointerSlot();
        p_Writer.Write(SolverData);
        p_Writer.Write(StorageIndex);
        p_Writer.Write(ContactPointCallbackDelay);
        HkSmallArray.Write(p_Writer, ConstraintsMasterCapacity);
        p_Writer.WriteArray(new List<int>(), p_Writer.PointerSize, (_, _) => { });
        p_Writer.WriteArray(new List<int>(), 1, (_, _) => { });
        p_Writer.WritePointerSlot();
        p_Writer.Write(AutoRemoveLevel);
        p_Writer.Write(NumShapeKeysInContactPointProperties);
        p_Writer.Write(ResponseModifierFlags);
        p_Writer.Write(Uid);
        p_Writer.WritePointerSlot();
        p_Writer.Write(SpuCollisionCallbackCapacity);
        p_Writer.Write(SpuCollisionCallbackEventFilter);
        p_Writer.Write(SpuCollisionCallbackUserFilter);

        p_Writer.Align(16);
        p_Writer.WritePointerSlot();
        p_Writer.Write(MotionMemSizeAndFlags);
        p_Writer.Write(MotionReferenceCount);
        // The motion's hkReferencedObject ends at pointer alignment.
        p_Writer.Align(p_Writer.PointerSize);
        p_Writer.Write(MotionType);
        p_Writer.Write(DeactivationIntegrateCounter);
        foreach (var s_Value in DeactivationNumInactiveFrames)
            p_Writer.Write(s_Value);
        foreach (var s_Vector in MotionStateVectors)
            p_Writer.Write(s_Vector);
        p_Writer.Write(ObjectRadius);
        p_Writer.Write(LinearDamping);
        p_Writer.Write(AngularDamping);
        p_Writer.Write(TimeFactor);
        p_Writer.Write(MaxLinearVelocity);
        p_Writer.Write(MaxAngularVelocity);
        p_Writer.Write(DeactivationClass);
        p_Writer.Write(InertiaAndMassInv);
        p_Writer.Write(LinearVelocity);
        p_Writer.Write(AngularVelocity);
        foreach (var s_Vector in DeactivationRefPosition)
            p_Writer.Write(s_Vector);
        foreach (var s_Value in DeactivationRefOrientation)
            p_Writer.Write(s_Value);
        p_Writer.WritePointerSlot();
        p_Writer.Write(SavedQualityTypeIndex);
        p_Writer.Write(GravityFactor);
        // The motion holds vectors, so its size is a multiple of 16.
        p_Writer.Align(16);

        HkSmallArray.Write(p_Writer, ContactListenersCapacity);
        HkSmallArray.Write(p_Writer, ActionsCapacity);
        p_Writer.WritePointerSlot();
        p_Writer.WritePointerSlot();
        p_Writer.Write(NpData);
        p_Writer.EndClass();
    }

    protected internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        p_Reader.SkipPointerSlot();
        UserData = p_Reader.ReadUlong();

        Shape = p_Reader.ReadObject<HkpShape>();
        ShapeKey = p_Reader.ReadUInt32();
        p_Reader.SkipPointerSlot();
        p_Reader.SkipPointerSlot();
        OwnerOffset = p_Reader.ReadByte();
        ForceCollideOntoPpu = p_Reader.ReadByte();
        ShapeSizeOnSpu = p_Reader.ReadUInt16();
        BroadPhaseId = p_Reader.ReadUInt32();
        BroadPhaseType = p_Reader.ReadByte();
        BroadPhaseOwnerOffset = p_Reader.ReadByte();
        ObjectQualityType = p_Reader.ReadByte();
        CollisionFilterInfo = p_Reader.ReadUInt32();
        for (var i = 0; i < 3; ++i)
            BoundingVolumeMin[i] = p_Reader.ReadUInt32();
        for (var i = 0; i < 4; ++i)
            BoundingVolumeExpansionMin[i] = p_Reader.ReadByte();
        for (var i = 0; i < 3; ++i)
            BoundingVolumeMax[i] = p_Reader.ReadUInt32();
        for (var i = 0; i < 4; ++i)
            BoundingVolumeExpansionMax[i] = p_Reader.ReadByte();
        NumChildShapeAabbs = p_Reader.ReadUInt16();
        CapacityChildShapeAabbs = p_Reader.ReadUInt16();
        p_Reader.SkipPointerSlot();
        p_Reader.SkipPointerSlot();
        AllowedPenetrationDepth = p_Reader.ReadSingle();
        if (p_Reader.ReadArray(p_Reader.PointerSize, p_E => 0).Count != 0)
            throw new InvalidDataException("A rigid body with collision entries, which a packfile does not save.");

        MultiThreadCheckThreadId = p_Reader.ReadUInt32();
        MultiThreadCheckStackTraceId = p_Reader.ReadInt32();
        MultiThreadCheckMarkCount = p_Reader.ReadUInt16();
        MultiThreadCheckMarkBitStack = p_Reader.ReadUInt16();
        Name = p_Reader.ReadString();
        Properties = p_Reader.ReadArray(8, p_E => new Property(p_E.ReadUInt32(), p_E.ReadUInt32(), p_E.ReadUInt32(), p_E.ReadUInt32()));
        p_Reader.SkipPointerSlot();

        ResponseType = p_Reader.ReadByte();
        RollingFrictionMultiplier = p_Reader.ReadUInt16();
        Friction = p_Reader.ReadSingle();
        Restitution = p_Reader.ReadSingle();
        p_Reader.SkipPointerSlot();
        DamageMultiplier = p_Reader.ReadSingle();
        p_Reader.SkipPointerSlot();
        SolverData = p_Reader.ReadUInt32();
        StorageIndex = p_Reader.ReadUInt16();
        ContactPointCallbackDelay = p_Reader.ReadUInt16();
        ConstraintsMasterCapacity = HkSmallArray.Read(p_Reader);
        if (p_Reader.ReadArray(p_Reader.PointerSize, p_E => 0).Count != 0 || p_Reader.ReadArray(1, p_E => 0).Count != 0)
            throw new InvalidDataException("A rigid body with constraints, which BF3's destruction packfiles do not have.");
        p_Reader.SkipPointerSlot();
        AutoRemoveLevel = p_Reader.ReadByte();
        NumShapeKeysInContactPointProperties = p_Reader.ReadByte();
        ResponseModifierFlags = p_Reader.ReadByte();
        Uid = p_Reader.ReadUInt32();
        p_Reader.SkipPointerSlot();
        SpuCollisionCallbackCapacity = p_Reader.ReadUInt16();
        SpuCollisionCallbackEventFilter = p_Reader.ReadByte();
        SpuCollisionCallbackUserFilter = p_Reader.ReadByte();

        p_Reader.Align(16);
        p_Reader.SkipPointerSlot();
        MotionMemSizeAndFlags = p_Reader.ReadUInt16();
        MotionReferenceCount = p_Reader.ReadUInt16();
        p_Reader.Align(p_Reader.PointerSize);
        MotionType = p_Reader.ReadByte();
        DeactivationIntegrateCounter = p_Reader.ReadByte();
        for (var i = 0; i < 2; ++i)
            DeactivationNumInactiveFrames[i] = p_Reader.ReadUInt16();
        for (var i = 0; i < MotionStateVectors.Length; ++i)
            MotionStateVectors[i] = p_Reader.ReadVector4();
        ObjectRadius = p_Reader.ReadSingle();
        LinearDamping = p_Reader.ReadUInt16();
        AngularDamping = p_Reader.ReadUInt16();
        TimeFactor = p_Reader.ReadUInt16();
        MaxLinearVelocity = p_Reader.ReadByte();
        MaxAngularVelocity = p_Reader.ReadByte();
        DeactivationClass = p_Reader.ReadByte();
        InertiaAndMassInv = p_Reader.ReadVector4();
        LinearVelocity = p_Reader.ReadVector4();
        AngularVelocity = p_Reader.ReadVector4();
        for (var i = 0; i < 2; ++i)
            DeactivationRefPosition[i] = p_Reader.ReadVector4();
        for (var i = 0; i < 2; ++i)
            DeactivationRefOrientation[i] = p_Reader.ReadUInt32();
        p_Reader.SkipPointerSlot();
        SavedQualityTypeIndex = p_Reader.ReadUInt16();
        GravityFactor = p_Reader.ReadUInt16();
        p_Reader.Align(16);

        ContactListenersCapacity = HkSmallArray.Read(p_Reader);
        ActionsCapacity = HkSmallArray.Read(p_Reader);
        p_Reader.SkipPointerSlot();
        p_Reader.SkipPointerSlot();
        NpData = p_Reader.ReadUInt32();
        p_Reader.EndClass();
    }
}
