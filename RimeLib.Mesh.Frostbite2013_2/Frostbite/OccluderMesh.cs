using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2013_2.Frostbite;

/// <summary>
/// An OccluderMesh resource (OccluderMeshData): a 64-byte header, then a part mask per triangle
/// (their count rounded up to even with a zero mask), the vertices (four floats each) and the
/// 16-bit indices, padded to 16 bytes.
/// </summary>
public class OccluderMesh
{
    private const int c_HeaderSize = 64;

    /// <summary>Min, then max, each four floats.</summary>
    public Vector4[] BoundingBox { get; set; } = new Vector4[2];

    public uint DoubleSided { get; set; }
    public uint HighPriority { get; set; }
    public uint IsConservative { get; set; }
    public uint CoverageValue { get; set; }

    /// <summary>One per triangle: three 64-bit masks.</summary>
    public List<ulong[]> PartMasks { get; set; } = new();

    public List<Vector4> Vertices { get; set; } = new();
    public List<ushort> Indices { get; set; } = new();

    public static OccluderMesh Read(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        var s_Mesh = new OccluderMesh { BoundingBox = { [0] = s_Reader.ReadVector4(), [1] = s_Reader.ReadVector4() } };

        var s_VertexCount = s_Reader.ReadUInt16();
        var s_IndexCount = s_Reader.ReadUInt16();
        var s_VertexDataOffset = s_Reader.ReadUInt32();
        var s_IndexDataOffset = s_Reader.ReadUInt32();
        var s_PartMaskOffset = s_Reader.ReadUInt32();
        s_Mesh.DoubleSided = s_Reader.ReadUInt32();
        s_Mesh.HighPriority = s_Reader.ReadUInt32();
        s_Mesh.IsConservative = s_Reader.ReadUInt32();
        s_Mesh.CoverageValue = s_Reader.ReadUInt32();

        s_Reader.Seek(s_PartMaskOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_IndexCount / 3; ++i)
            s_Mesh.PartMasks.Add(new[] { s_Reader.ReadUInt64(), s_Reader.ReadUInt64(), s_Reader.ReadUInt64() });

        s_Reader.Seek(s_VertexDataOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_VertexCount; ++i)
            s_Mesh.Vertices.Add(s_Reader.ReadVector4());

        s_Reader.Seek(s_IndexDataOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_IndexCount; ++i)
            s_Mesh.Indices.Add(s_Reader.ReadUInt16());

        return s_Mesh;
    }

    public byte[] Write()
    {
        if (PartMasks.Count != Indices.Count / 3)
            throw new InvalidDataException($"{Indices.Count / 3} triangle(s) take as many part masks, not {PartMasks.Count}.");

        var s_PartMaskOffset = c_HeaderSize;
        var s_MaskSlots = (PartMasks.Count + 1) & ~1;
        var s_VertexDataOffset = s_PartMaskOffset + s_MaskSlots * 24;
        var s_IndexDataOffset = s_VertexDataOffset + Vertices.Count * 16;

        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
        {
            s_Writer.Write(BoundingBox[0]);
            s_Writer.Write(BoundingBox[1]);
            s_Writer.Write((ushort)Vertices.Count);
            s_Writer.Write((ushort)Indices.Count);
            s_Writer.Write((uint)s_VertexDataOffset);
            s_Writer.Write((uint)s_IndexDataOffset);
            s_Writer.Write((uint)s_PartMaskOffset);
            s_Writer.Write(DoubleSided);
            s_Writer.Write(HighPriority);
            s_Writer.Write(IsConservative);
            s_Writer.Write(CoverageValue);

            foreach (var s_Mask in PartMasks)
            foreach (var s_Value in s_Mask)
                s_Writer.Write(s_Value);
            for (var i = PartMasks.Count; i < s_MaskSlots; ++i)
                s_Writer.Write(new byte[24]);
            foreach (var s_Vertex in Vertices)
                s_Writer.Write(s_Vertex);
            foreach (var s_Index in Indices)
                s_Writer.Write(s_Index);

            while (s_Stream.Length % 16 != 0)
                s_Writer.Write((byte)0);
        }

        return s_Stream.ToArray();
    }
}
