using System.Collections.Generic;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>A packfile's root object: named, typed references to its contents.</summary>
public sealed class HkRootLevelContainer : HkObject
{
    public override string ClassName => "hkRootLevelContainer";

    public sealed record NamedVariant(string? Name, string? ClassName, HkObject? Variant);

    public List<NamedVariant> NamedVariants { get; set; } = [];

    // Not an hkReferencedObject: the root has no object header.
    internal override void Write(HkWriter p_Writer) =>
        p_Writer.WriteArray(NamedVariants, p_Writer.PointerSize, (p_Element, p_Variant) =>
        {
            p_Element.WriteString(p_Variant.Name);
            p_Element.WriteString(p_Variant.ClassName);
            p_Element.WriteObject(p_Variant.Variant);
        });

    internal override void Read(HkReader p_Reader) =>
        NamedVariants = p_Reader.ReadArray(p_Reader.PointerSize, p_Element =>
            new NamedVariant(p_Element.ReadString(), p_Element.ReadString(), p_Element.ReadObject()));
}

/// <summary>Frostbite's container of a physics resource's shapes, one per part, and its constraints.</summary>
public sealed class HavokPhysicsContainer : HkObject
{
    public override string ClassName => "HavokPhysicsContainer";

    public List<HkpShape> Shapes { get; set; } = [];

    /// <summary>The constraints between parts: none, but for the one breakable vent BF3 ships.</summary>
    public List<HkObject> Constraints { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteObjects(Shapes);
        p_Writer.WriteObjects(Constraints);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Shapes = p_Reader.ReadObjects<HkpShape>();
        Constraints = p_Reader.ReadObjects<HkObject>();
        p_Reader.EndClass();
    }
}
