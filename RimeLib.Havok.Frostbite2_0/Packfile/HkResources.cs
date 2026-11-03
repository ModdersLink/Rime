using System.Collections.Generic;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>A named tree of resource handles, as a destruction resource keeps its breakable bodies.</summary>
public sealed class HkMemoryResourceContainer : HkObject
{
    public override string ClassName => "hkMemoryResourceContainer";

    public string? Name { get; set; }
    public HkMemoryResourceContainer? Parent { get; set; }
    public List<HkMemoryResourceHandle> ResourceHandles { get; set; } = [];
    public List<HkMemoryResourceContainer> Children { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteString(Name);
        p_Writer.WriteObject(Parent);
        p_Writer.WriteObjects(ResourceHandles);
        p_Writer.WriteObjects(Children);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Name = p_Reader.ReadString();
        Parent = p_Reader.ReadObject<HkMemoryResourceContainer>();
        ResourceHandles = p_Reader.ReadObjects<HkMemoryResourceHandle>();
        Children = p_Reader.ReadObjects<HkMemoryResourceContainer>();
        p_Reader.EndClass();
    }
}

/// <summary>A named reference to one object of a resource container.</summary>
public sealed class HkMemoryResourceHandle : HkObject
{
    public override string ClassName => "hkMemoryResourceHandle";

    public sealed record ExternalLink(string? MemberName, string? ExternalId);

    public HkObject? Variant { get; set; }
    public string? Name { get; set; }
    public List<ExternalLink> References { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.WriteObject(Variant);
        p_Writer.WriteString(Name);
        p_Writer.WriteArray(References, p_Writer.PointerSize, (p_E, p_L) =>
        {
            p_E.WriteString(p_L.MemberName);
            p_E.WriteString(p_L.ExternalId);
        });
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Variant = p_Reader.ReadObject();
        Name = p_Reader.ReadString();
        References = p_Reader.ReadArray(p_Reader.PointerSize, p_E => new ExternalLink(p_E.ReadString(), p_E.ReadString()));
        p_Reader.EndClass();
    }
}
