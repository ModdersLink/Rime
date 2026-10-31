using System.Diagnostics.CodeAnalysis;
using fb.Core;
using fb.Render;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 (Battlefield 4) MeshSet resource header.
/// </summary>
/// <remarks>
/// Ordered differently from the Frostbite 2 header: bounding box and six LOD pointers first,
/// counts last.
/// </remarks>
public class MeshSetLayout : IFbSerializable
{
    public const int MaxLodCount = 6;

    public AxisAlignedBox BoundingBox { get; set; } = new();
    public RelocPtr<MeshLayout>[] Lods { get; set; } = new RelocPtr<MeshLayout>[MaxLodCount];
    public RelocPtr<string> Name { get; set; } = new();
    public RelocPtr<string> ShortName { get; set; } = new();
    public uint NameHash { get; set; }
    public MeshType MeshType { get; set; }
    public MeshLayoutFlags Flags { get; set; }
    public ushort LodCount { get; set; }
    public ushort TotalSubsetCount { get; set; }

    public MeshSetLayout()
    {
    }

    public MeshSetLayout(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_Min = new Vec3 { x = p_Reader.ReadSingle(), y = p_Reader.ReadSingle(), z = p_Reader.ReadSingle() };
        p_Reader.ReadSingle(); // padding
        var s_Max = new Vec3 { x = p_Reader.ReadSingle(), y = p_Reader.ReadSingle(), z = p_Reader.ReadSingle() };
        p_Reader.ReadSingle(); // padding
        BoundingBox = new AxisAlignedBox { min = s_Min, max = s_Max };

        for (var i = 0; i < MaxLodCount; ++i)
            Lods[i] = new RelocPtr<MeshLayout>(p_Reader);

        Name = new RelocPtr<string>(p_Reader);
        ShortName = new RelocPtr<string>(p_Reader);
        NameHash = p_Reader.ReadUInt32();
        MeshType = (MeshType)p_Reader.ReadUInt32();
        Flags = (MeshLayoutFlags)p_Reader.ReadUInt32();
        LodCount = p_Reader.ReadUInt16();
        TotalSubsetCount = p_Reader.ReadUInt16();
    }

    public void Deserialize(byte[] p_Data) => Deserialize(new RimeReader(new MemoryStream(p_Data)));

    public bool Serialize(RimeWriter p_Writer) =>
        throw new NotSupportedException("Writing a Frostbite 2013.2 MeshSet is not supported.");

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data) =>
        throw new NotSupportedException("Writing a Frostbite 2013.2 MeshSet is not supported.");
}
