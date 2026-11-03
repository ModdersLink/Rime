using System;
using System.Collections.Generic;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>
/// An object of a Havok 2010 packfile's data section: an hkReferencedObject, whose header (the
/// virtual table pointer, memory size and flags, reference count) every class starts with.
/// Each class reads and writes its members in declaration order, its base class's first, for
/// either pointer size.
/// </summary>
public abstract class HkObject
{
    /// <summary>The Havok class name, as the class names section and the virtual fixups give it.</summary>
    public abstract string ClassName { get; }

    public ushort MemSizeAndFlags { get; set; }
    public ushort ReferenceCount { get; set; }

    internal virtual void Write(HkWriter p_Writer)
    {
        p_Writer.WritePointerSlot();
        p_Writer.Write(MemSizeAndFlags);
        p_Writer.Write(ReferenceCount);
        p_Writer.EndClass();
    }

    internal virtual void Read(HkReader p_Reader)
    {
        p_Reader.SkipPointerSlot();
        MemSizeAndFlags = p_Reader.ReadUInt16();
        ReferenceCount = p_Reader.ReadUInt16();
        p_Reader.EndClass();
    }
}

/// <summary>The Havok 2010 classes this models, by name, with the signature BF3's packfiles give each.</summary>
public static class HkClasses
{
    private static readonly Dictionary<string, (uint Signature, Func<HkObject> Create)> s_Classes = new(StringComparer.Ordinal)
    {
        ["hkRootLevelContainer"] = (0x2772c11e, () => new HkRootLevelContainer()),
        ["HavokPhysicsContainer"] = (0x71817d59, () => new HavokPhysicsContainer()),
        ["hkpBoxShape"] = (0x3444d2d5, () => new HkpBoxShape()),
        ["hkpSphereShape"] = (0x0795d9fa, () => new HkpSphereShape()),
        ["hkpCapsuleShape"] = (0xdd0b1fd3, () => new HkpCapsuleShape()),
        ["hkpCylinderShape"] = (0x3e463c3a, () => new HkpCylinderShape()),
        ["hkpConvexVerticesShape"] = (0x44ff20d2, () => new HkpConvexVerticesShape()),
        ["hkpConvexVerticesConnectivity"] = (0x63d38e9c, () => new HkpConvexVerticesConnectivity()),
        ["hkpConvexTranslateShape"] = (0x5ba0a5f7, () => new HkpConvexTranslateShape()),
        ["hkpConvexTransformShape"] = (0xae3e5017, () => new HkpConvexTransformShape()),
        ["hkpListShape"] = (0xa1937cbd, () => new HkpListShape()),
    };

    /// <summary>
    /// The reflection classes every packfile lists first, though it holds none of them, with their
    /// signatures.
    /// </summary>
    public static IReadOnlyList<(string Name, uint Signature)> Reflection { get; } =
    [
        ("hkClass", 0x75585ef6),
        ("hkClassMember", 0x5c7ea4c2),
        ("hkClassEnum", 0x8a3609cf),
        ("hkClassEnumItem", 0xce6f8a6c),
    ];

    public static bool IsModelled(string p_Name) => s_Classes.ContainsKey(p_Name);

    public static uint Signature(string p_Name) => s_Classes.TryGetValue(p_Name, out var s_Class)
        ? s_Class.Signature
        : throw new NotSupportedException($"Havok class {p_Name} is not modelled.");

    public static HkObject Create(string p_Name) => s_Classes.TryGetValue(p_Name, out var s_Class)
        ? s_Class.Create()
        : throw new NotSupportedException($"Havok class {p_Name} is not modelled.");
}
