using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Numerics;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite;

/// <summary>
/// An OccluderMesh resource: a 64-byte header, then a part mask per triangle (their count rounded
/// up to even with a zero mask), the vertices (four floats each) and the 16-bit indices, padded to
/// 16 bytes.
/// </summary>
public class OccluderMeshData : IFbSerializable
{
    private const int c_HeaderSize = 64;

    /// <summary>Min, then max, each four floats.</summary>
    public Vector4[] BoundingBox { get; set; } = new Vector4[2];

    public uint DoubleSided { get; set; }
    public uint HighPriority { get; set; }
    public uint IsConservative { get; set; }
    public uint CoverageValue { get; set; }

    /// <summary>One per triangle.</summary>
    public List<OccluderPartMask> PartMasks { get; set; } = new();

    public List<Vector4> Vertices { get; set; } = new();
    public List<ushort> Indices { get; set; } = new();

    public OccluderMeshData()
    {
    }

    public OccluderMeshData(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_Start = p_Reader.Position;
        BoundingBox = [p_Reader.ReadVector4(), p_Reader.ReadVector4()];

        var s_VertexCount = p_Reader.ReadUInt16();
        var s_IndexCount = p_Reader.ReadUInt16();
        var s_VertexDataOffset = p_Reader.ReadUInt32();
        var s_IndexDataOffset = p_Reader.ReadUInt32();
        var s_PartMaskOffset = p_Reader.ReadUInt32();
        DoubleSided = p_Reader.ReadUInt32();
        HighPriority = p_Reader.ReadUInt32();
        IsConservative = p_Reader.ReadUInt32();
        CoverageValue = p_Reader.ReadUInt32();

        p_Reader.Seek(s_Start + s_PartMaskOffset, SeekOrigin.Begin);
        PartMasks = new List<OccluderPartMask>(s_IndexCount / 3);
        for (var i = 0; i < s_IndexCount / 3; ++i)
            PartMasks.Add(new OccluderPartMask(p_Reader));

        p_Reader.Seek(s_Start + s_VertexDataOffset, SeekOrigin.Begin);
        Vertices = new List<Vector4>(s_VertexCount);
        for (var i = 0; i < s_VertexCount; ++i)
            Vertices.Add(p_Reader.ReadVector4());

        p_Reader.Seek(s_Start + s_IndexDataOffset, SeekOrigin.Begin);
        Indices = new List<ushort>(s_IndexCount);
        for (var i = 0; i < s_IndexCount; ++i)
            Indices.Add(p_Reader.ReadUInt16());
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        if (PartMasks.Count != Indices.Count / 3)
            throw new InvalidDataException($"{Indices.Count / 3} triangle(s) take as many part masks, not {PartMasks.Count}.");

        var s_PartMaskOffset = c_HeaderSize;
        var s_MaskSlots = (PartMasks.Count + 1) & ~1;
        var s_VertexDataOffset = s_PartMaskOffset + s_MaskSlots * OccluderPartMask.Size;
        var s_IndexDataOffset = s_VertexDataOffset + Vertices.Count * 16;

        var s_Start = p_Writer.Position;
        p_Writer.Write(BoundingBox[0]);
        p_Writer.Write(BoundingBox[1]);
        p_Writer.Write((ushort)Vertices.Count);
        p_Writer.Write((ushort)Indices.Count);
        p_Writer.Write((uint)s_VertexDataOffset);
        p_Writer.Write((uint)s_IndexDataOffset);
        p_Writer.Write((uint)s_PartMaskOffset);
        p_Writer.Write(DoubleSided);
        p_Writer.Write(HighPriority);
        p_Writer.Write(IsConservative);
        p_Writer.Write(CoverageValue);

        foreach (var s_Mask in PartMasks)
            s_Mask.Serialize(p_Writer);
        for (var i = PartMasks.Count; i < s_MaskSlots; ++i)
            p_Writer.Write(new byte[OccluderPartMask.Size]);
        foreach (var s_Vertex in Vertices)
            p_Writer.Write(s_Vertex);
        foreach (var s_Index in Indices)
            p_Writer.Write(s_Index);

        while ((p_Writer.Position - s_Start) % 16 != 0)
            p_Writer.Write((byte)0);
        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            Serialize(s_Writer);

        p_Data = s_Stream.ToArray();
        return true;
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
    }
}
