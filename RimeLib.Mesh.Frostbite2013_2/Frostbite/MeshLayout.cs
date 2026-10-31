using System.Diagnostics.CodeAnalysis;
using fb.Core;
using fb.Render;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 (Battlefield 4) mesh LOD.
/// </summary>
/// <remarks>
/// The Frostbite 2 LOD layout with a MaxInstances field after the mesh type.
/// </remarks>
public class MeshLayout : IFbSerializable
{
    public MeshType Type { get; set; }
    public uint MaxInstances { get; set; }
    public RelocArray<MeshSubset> Subsets { get; set; } = new();
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

    public MeshLayout()
    {
    }

    public MeshLayout(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Type = (MeshType)p_Reader.ReadUInt32();
        MaxInstances = p_Reader.ReadUInt32();
        Subsets = new RelocArray<MeshSubset>(p_Reader);

        CategorySubsetIndices = new RelocArray<byte>[(int)MeshSubsetCategory.MeshSubsetCategoryCount];
        for (var i = 0; i < CategorySubsetIndices.Length; ++i)
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

    public bool Serialize(RimeWriter p_Writer) =>
        throw new NotSupportedException("Writing a Frostbite 2013.2 mesh LOD is not supported.");

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data) =>
        throw new NotSupportedException("Writing a Frostbite 2013.2 mesh LOD is not supported.");
}
