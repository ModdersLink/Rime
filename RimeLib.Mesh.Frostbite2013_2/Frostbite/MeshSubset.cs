using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using fb.Render;

namespace RimeLib.Mesh.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 (Battlefield 4) mesh subset.
/// </summary>
/// <remarks>
/// The Frostbite 2 subset layout followed by 44 more bytes; subsets are stored back to back, so
/// without them every subset after the first is read from the wrong place.
/// </remarks>
public class MeshSubset : IFbSerializable
{
    public const int Size = 0xC0;
    public const int TrailingSize = 44;

    public ulong GeometryDeclarations { get; set; } // RelocPtr
    public RelocPtr<string> MaterialName { get; set; } = new();
    public uint MaterialIndex { get; set; }
    public uint PrimitiveCount { get; set; }
    public uint StartIndex { get; set; }
    public uint VertexOffset { get; set; }
    public uint VertexCount { get; set; }
    public byte VertexStride { get; set; }
    public PrimitiveType PrimitiveType { get; set; }
    public byte BonesPerVertex { get; set; }
    public byte BoneCount { get; set; }
    public RelocPtrArray<ushort> BoneIndices { get; set; } = new();
    public GeometryDeclarationDesc GeometryDeclarationDesc { get; set; } = new();
    public Array<float> TexCoordRatios { get; set; } = new(); // float[6]

    /// <summary>The <see cref="TrailingSize"/> bytes after the ratios, by default those most subsets end in.</summary>
    public byte[] Trailing { get; set; } = Convert.FromHexString("000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFFFFFFFFFF00000000");

    public MeshSubset()
    {
    }

    public MeshSubset(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        GeometryDeclarations = p_Reader.ReadUInt64();
        MaterialName = new RelocPtr<string>(p_Reader);
        MaterialIndex = p_Reader.ReadUInt32();
        PrimitiveCount = p_Reader.ReadUInt32();
        StartIndex = p_Reader.ReadUInt32();
        VertexOffset = p_Reader.ReadUInt32();
        VertexCount = p_Reader.ReadUInt32();
        VertexStride = p_Reader.ReadUByte();
        PrimitiveType = (PrimitiveType)p_Reader.ReadUByte();
        BonesPerVertex = p_Reader.ReadUByte();
        BoneCount = p_Reader.ReadUByte();
        BoneIndices = new RelocPtrArray<ushort>(p_Reader, BoneCount);
        GeometryDeclarationDesc = new GeometryDeclarationDesc(p_Reader);

        for (var i = 0; i < 6; ++i)
            TexCoordRatios.Add(p_Reader.ReadSingle());

        Trailing = p_Reader.ReadBytes(TrailingSize);
    }

    public void Deserialize(byte[] p_Data) => Deserialize(new RimeReader(new MemoryStream(p_Data)));

    /// <summary>Writes the subset; the pointers are the slots, whose targets the MeshSet places.</summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(GeometryDeclarations);
        MaterialName.Serialize(p_Writer);
        p_Writer.Write(MaterialIndex);
        p_Writer.Write(PrimitiveCount);
        p_Writer.Write(StartIndex);
        p_Writer.Write(VertexOffset);
        p_Writer.Write(VertexCount);
        p_Writer.Write(VertexStride);
        p_Writer.Write((byte)PrimitiveType);
        p_Writer.Write(BonesPerVertex);
        p_Writer.Write(BoneCount);
        BoneIndices.Serialize(p_Writer);
        GeometryDeclarationDesc.Serialize(p_Writer);

        foreach (var s_Ratio in TexCoordRatios.AsList)
            p_Writer.Write(s_Ratio);

        p_Writer.Write(Trailing);
        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data) =>
        throw new NotSupportedException("A mesh subset is written as part of its MeshSet.");
}
