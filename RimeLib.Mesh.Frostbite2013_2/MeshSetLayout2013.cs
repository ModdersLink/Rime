using System.Diagnostics.CodeAnalysis;
using fb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Mesh.Frostbite;

namespace RimeLib.Mesh.Frostbite2013_2;

// The Frostbite 2013.2 (Battlefield 4) MeshSet resource layout.
//
// It is close to the Frostbite 2 one in RimeLib.Mesh/Frostbite/Fb2, which is what this engine's
// converter used to read with, but not equal, and every difference throws the reader off:
//  - the MeshSet header is ordered differently (bounding box and LOD pointers first, counts last)
//    and has six LOD slots,
//  - a LOD has a MaxInstances field after its mesh type,
//  - a subset is followed by 44 more bytes.
// Matches Frosty's MeshSet reader for its Battlefield 4 profile. Property names follow the Fb2
// classes so the converter reads both the same way.

/// <summary>
/// A Frostbite 2013.2 MeshSet resource header.
/// </summary>
public class MeshSetLayout2013 : IFbSerializable
{
    public const int MaxLodCount = 6;

    public AxisAlignedBox BoundingBox { get; set; }
    public RelocPtr<MeshLayout2013>[] Lods { get; set; } = new RelocPtr<MeshLayout2013>[MaxLodCount];
    public RelocPtr<string> Name { get; set; } = new();
    public RelocPtr<string> ShortName { get; set; } = new();
    public uint NameHash { get; set; }
    public MeshType MeshType { get; set; }
    public MeshLayoutFlags Flags { get; set; }
    public ushort LodCount { get; set; }
    public ushort TotalSubsetCount { get; set; }

    public MeshSetLayout2013()
    {
    }

    public MeshSetLayout2013(RimeReader p_Reader)
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
            Lods[i] = new RelocPtr<MeshLayout2013>(p_Reader);

        Name = new RelocPtr<string>(p_Reader);
        ShortName = new RelocPtr<string>(p_Reader);
        NameHash = p_Reader.ReadUInt32();
        MeshType = (MeshType)p_Reader.ReadUInt32();
        Flags = (MeshLayoutFlags)p_Reader.ReadUInt32();
        LodCount = p_Reader.ReadUInt16();
        TotalSubsetCount = p_Reader.ReadUInt16();
    }

    public void Deserialize(byte[] p_Data) => Deserialize(new RimeReader(new MemoryStream(p_Data)));
    public bool Serialize(RimeWriter p_Writer) => throw new NotSupportedException("Writing a Frostbite 2013.2 MeshSet is not supported.");
    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data) => throw new NotSupportedException("Writing a Frostbite 2013.2 MeshSet is not supported.");
}

/// <summary>
/// A Frostbite 2013.2 mesh LOD: the Fb2 layout with a MaxInstances field after the type.
/// </summary>
public class MeshLayout2013 : IFbSerializable
{
    public MeshType Type { get; set; }
    public uint MaxInstances { get; set; }
    public RelocArray<MeshSubset2013> Subsets { get; set; } = new();
    public RelocArray<byte>[] CategorySubsetIndices { get; set; } = Array.Empty<RelocArray<byte>>();
    public MeshLayoutFlags Flags { get; set; }
    public IndexBufferFormat IndexBufferFormat { get; set; }
    public uint IndexDataSize { get; set; }
    public uint VertexDataSize { get; set; }
    public uint EdgePartitionBufferSize { get; set; }
    public GUID DataChunkId { get; set; } = GUID.Empty;
    public uint AuxVertexIndexDataOffset { get; set; }
    public RelocPtr<byte> EmbeddedEdgeData { get; set; } = new();
    public RelocPtr<string> ShaderDebugName { get; set; } = new();
    public RelocPtr<string> Name { get; set; } = new();
    public RelocPtr<string> ShortName { get; set; } = new();
    public uint NameHash { get; set; }

    public MeshLayout2013()
    {
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Type = (MeshType)p_Reader.ReadUInt32();
        MaxInstances = p_Reader.ReadUInt32();
        Subsets = new RelocArray<MeshSubset2013>(p_Reader);

        CategorySubsetIndices = new RelocArray<byte>[4];
        for (var i = 0; i < 4; ++i)
            CategorySubsetIndices[i] = new RelocArray<byte>(p_Reader);

        Flags = (MeshLayoutFlags)p_Reader.ReadUInt32();
        IndexBufferFormat = (IndexBufferFormat)p_Reader.ReadUInt32();
        IndexDataSize = p_Reader.ReadUInt32();
        VertexDataSize = p_Reader.ReadUInt32();
        EdgePartitionBufferSize = p_Reader.ReadUInt32();
        DataChunkId = new GUID(p_Reader);
        AuxVertexIndexDataOffset = p_Reader.ReadUInt32();
        EmbeddedEdgeData = new RelocPtr<byte>(p_Reader);
        ShaderDebugName = new RelocPtr<string>(p_Reader);
        Name = new RelocPtr<string>(p_Reader);
        ShortName = new RelocPtr<string>(p_Reader);
        NameHash = p_Reader.ReadUInt32();
        // The remaining fields (data pointer, bone/part data) are not needed for export.
    }

    public void Deserialize(byte[] p_Data) => Deserialize(new RimeReader(new MemoryStream(p_Data)));
    public bool Serialize(RimeWriter p_Writer) => throw new NotSupportedException("Writing a Frostbite 2013.2 mesh LOD is not supported.");
    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data) => throw new NotSupportedException("Writing a Frostbite 2013.2 mesh LOD is not supported.");
}

/// <summary>
/// A Frostbite 2013.2 mesh subset: the Fb2 subset followed by 44 more bytes.
/// </summary>
public class MeshSubset2013 : MeshSubset, IFbSerializable
{
    public const int TrailingSize = 44;

    public byte[] Trailing { get; set; } = Array.Empty<byte>();

    public MeshSubset2013()
    {
    }

    // Re-implements IFbSerializable.Deserialize so RelocArray, which calls it through the
    // interface, reads the trailing bytes too and the next subset starts in the right place.
    public new void Deserialize(RimeReader p_Reader)
    {
        base.Deserialize(p_Reader);
        Trailing = p_Reader.ReadBytes(TrailingSize);
    }
}
