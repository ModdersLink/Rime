using System.Collections.Generic;
using System.IO;
using System.Numerics;
using RimeLib.Havok.Frostbite2_0.Mopp;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>A MOPP: the byte code of the bounding volume tree over a shape collection's children.</summary>
public sealed class HkpMoppCode : HkObject
{
    public override string ClassName => "hkpMoppCode";

    /// <summary>Where the tree's integer space starts, and in w the scale from it to the shape's.</summary>
    public Vector4 Offset { get; set; }
    public List<MoppInstruction> Instructions { get; set; } = [];
    public sbyte BuildType { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(Offset);
        p_Writer.WriteArray(MoppInstruction.Encode(Instructions), 1, (p_Element, p_Byte) => p_Element.Write(p_Byte));
        p_Writer.Write((byte)BuildType);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        Offset = p_Reader.ReadVector4();
        Instructions = MoppInstruction.Decode(p_Reader.ReadArray(1, p_Element => p_Element.ReadByte()));
        BuildType = (sbyte)p_Reader.ReadByte();
        p_Reader.EndClass();
    }
}

/// <summary>A shape collection behind a MOPP, which finds the children a query reaches.</summary>
public sealed class HkpMoppBvTreeShape : HkpShape
{
    public override string ClassName => "hkpMoppBvTreeShape";

    /// <summary>
    /// Pointer-sized members between the base class and the child that the SDK's header does not
    /// declare: BF3's build has four, zero in every file, so the child sits 16 bytes (32 with 8-byte
    /// pointers) further on.
    /// </summary>
    private const int c_UnnamedSlots = 4;

    public byte BvTreeType { get; set; }
    public HkpMoppCode? Code { get; set; }

    /// <summary>What the loader copies out of the code again; kept as stored.</summary>
    public uint MoppDataSize { get; set; }
    public Vector4 CodeInfoCopy { get; set; }

    public HkpShape? Child { get; set; }

    /// <summary>The child's size in bytes, which the loader computes again; kept as stored.</summary>
    public int ChildSize { get; set; }

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(BvTreeType);
        p_Writer.EndClass();
        p_Writer.WriteObject(Code);
        p_Writer.WritePointerSlot();
        p_Writer.Write(MoppDataSize);
        p_Writer.Write(CodeInfoCopy);
        p_Writer.EndClass();
        for (var i = 0; i < c_UnnamedSlots; ++i)
            p_Writer.WritePointerSlot();
        p_Writer.WritePointerSlot();
        p_Writer.WriteObject(Child);
        p_Writer.Write(ChildSize);
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        BvTreeType = p_Reader.ReadByte();
        p_Reader.EndClass();
        Code = p_Reader.ReadObject<HkpMoppCode>();
        p_Reader.SkipPointerSlot();
        MoppDataSize = p_Reader.ReadUInt32();
        CodeInfoCopy = p_Reader.ReadVector4();
        p_Reader.EndClass();
        for (var i = 0; i < c_UnnamedSlots; ++i)
            p_Reader.SkipPointerSlot();
        p_Reader.SkipPointerSlot();
        Child = p_Reader.ReadObject<HkpShape>();
        ChildSize = p_Reader.ReadInt32();
        p_Reader.EndClass();
    }
}

/// <summary>
/// A triangle mesh in chunks of 16-bit vertices relative to each chunk's offset, with triangles
/// that do not fit a chunk kept apart, as BF3's static collision is.
/// </summary>
public sealed class HkpCompressedMeshShape : HkpShapeCollection
{
    public override string ClassName => "hkpCompressedMeshShape";

    /// <summary>hkQsTransform: translation, rotation as a quaternion, scale.</summary>
    public sealed record QsTransform(Vector4 Translation, Vector4 Rotation, Vector4 Scale);

    /// <summary>
    /// 16-bit members BF3's build of a big triangle has before its transform index that the SDK's
    /// header does not declare; zero in every one. The welding info before them is aligned to the
    /// pointer size, as a chunk's reference is.
    /// </summary>
    private const int c_BigTriangleUnnamedHalves = 2;

    public sealed record BigTriangle(ushort A, ushort B, ushort C, uint Material, ushort WeldingInfo, ushort TransformIndex);

    public sealed record Chunk(Vector4 Offset, List<ushort> Vertices, List<ushort> Indices, List<ushort> StripLengths,
        List<ushort> WeldingInfo, uint MaterialInfo, ushort Reference, ushort TransformIndex);

    /// <summary>
    /// What BF3's build of a chunk holds after its transform index, a member the SDK's header does
    /// not declare, in every chunk. The reference and transform index before it are aligned to the
    /// pointer size, which the header does not explain either.
    /// </summary>
    private const uint c_ChunkTrailer = 0xFFFFFFFF;

    public sealed record ConvexPiece(Vector4 Offset, List<ushort> Vertices, List<byte> FaceVertices, List<ushort> FaceOffsets,
        ushort Reference, ushort TransformIndex);

    public sealed record NamedMaterial(uint FilterInfo, string? Name);

    public int BitsPerIndex { get; set; }
    public int BitsPerWIndex { get; set; }
    public int WIndexMask { get; set; }
    public int IndexMask { get; set; }
    public float Radius { get; set; }
    public byte WeldingType { get; set; }
    public byte MaterialType { get; set; }
    public List<uint> Materials { get; set; } = [];
    public List<ushort> Materials16 { get; set; } = [];
    public List<byte> Materials8 { get; set; } = [];
    public List<QsTransform> Transforms { get; set; } = [];
    public List<Vector4> BigVertices { get; set; } = [];
    public List<BigTriangle> BigTriangles { get; set; } = [];
    public List<Chunk> Chunks { get; set; } = [];
    public List<ConvexPiece> ConvexPieces { get; set; } = [];
    public float Error { get; set; }
    public Vector4 BoundsMin { get; set; }
    public Vector4 BoundsMax { get; set; }
    public uint DefaultCollisionFilterInfo { get; set; }
    public ushort MaterialStriding { get; set; }
    public ushort MaterialCount { get; set; }
    public List<NamedMaterial> NamedMaterials { get; set; } = [];

    internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        p_Writer.Write(BitsPerIndex);
        p_Writer.Write(BitsPerWIndex);
        p_Writer.Write(WIndexMask);
        p_Writer.Write(IndexMask);
        p_Writer.Write(Radius);
        p_Writer.Write(WeldingType);
        p_Writer.Write(MaterialType);
        p_Writer.WriteArray(Materials, 4, (p_E, p_V) => p_E.Write(p_V));
        p_Writer.WriteArray(Materials16, 2, (p_E, p_V) => p_E.Write(p_V));
        p_Writer.WriteArray(Materials8, 1, (p_E, p_V) => p_E.Write(p_V));
        p_Writer.WriteArray(Transforms, 16, (p_E, p_T) =>
        {
            p_E.Write(p_T.Translation);
            p_E.Write(p_T.Rotation);
            p_E.Write(p_T.Scale);
        });
        p_Writer.WriteArray(BigVertices, 16, (p_E, p_V) => p_E.Write(p_V));
        p_Writer.WriteArray(BigTriangles, p_Writer.PointerSize, (p_E, p_T) =>
        {
            p_E.Write(p_T.A);
            p_E.Write(p_T.B);
            p_E.Write(p_T.C);
            p_E.Write(p_T.Material);
            p_E.Align(p_E.PointerSize);
            p_E.Write(p_T.WeldingInfo);
            for (var i = 0; i < c_BigTriangleUnnamedHalves; ++i)
                p_E.Write((ushort)0);
            p_E.Write(p_T.TransformIndex);
        });
        p_Writer.WriteArray(Chunks, 16, (p_E, p_C) =>
        {
            p_E.Write(p_C.Offset);
            p_E.WriteArray(p_C.Vertices, 2, (p_V, p_X) => p_V.Write(p_X));
            p_E.WriteArray(p_C.Indices, 2, (p_V, p_X) => p_V.Write(p_X));
            p_E.WriteArray(p_C.StripLengths, 2, (p_V, p_X) => p_V.Write(p_X));
            p_E.WriteArray(p_C.WeldingInfo, 2, (p_V, p_X) => p_V.Write(p_X));
            p_E.Write(p_C.MaterialInfo);
            p_E.Align(p_E.PointerSize);
            p_E.Write(p_C.Reference);
            p_E.Write(p_C.TransformIndex);
            p_E.Write(c_ChunkTrailer);
        });
        p_Writer.WriteArray(ConvexPieces, 16, (p_E, p_P) =>
        {
            p_E.Write(p_P.Offset);
            p_E.WriteArray(p_P.Vertices, 2, (p_V, p_X) => p_V.Write(p_X));
            p_E.WriteArray(p_P.FaceVertices, 1, (p_V, p_X) => p_V.Write(p_X));
            p_E.WriteArray(p_P.FaceOffsets, 2, (p_V, p_X) => p_V.Write(p_X));
            p_E.Write(p_P.Reference);
            p_E.Write(p_P.TransformIndex);
        });
        p_Writer.Write(Error);
        p_Writer.Write(BoundsMin);
        p_Writer.Write(BoundsMax);
        p_Writer.Write(DefaultCollisionFilterInfo);
        p_Writer.WritePointerSlot();
        p_Writer.Write(MaterialStriding);
        p_Writer.Write(MaterialCount);
        p_Writer.WriteArray(NamedMaterials, p_Writer.PointerSize, (p_E, p_M) =>
        {
            p_E.Write(p_M.FilterInfo);
            p_E.WriteString(p_M.Name);
        });
        p_Writer.EndClass();
    }

    internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        BitsPerIndex = p_Reader.ReadInt32();
        BitsPerWIndex = p_Reader.ReadInt32();
        WIndexMask = p_Reader.ReadInt32();
        IndexMask = p_Reader.ReadInt32();
        Radius = p_Reader.ReadSingle();
        WeldingType = p_Reader.ReadByte();
        MaterialType = p_Reader.ReadByte();
        Materials = p_Reader.ReadArray(4, p_E => p_E.ReadUInt32());
        Materials16 = p_Reader.ReadArray(2, p_E => p_E.ReadUInt16());
        Materials8 = p_Reader.ReadArray(1, p_E => p_E.ReadByte());
        Transforms = p_Reader.ReadArray(16, p_E => new QsTransform(p_E.ReadVector4(), p_E.ReadVector4(), p_E.ReadVector4()));
        BigVertices = p_Reader.ReadArray(16, p_E => p_E.ReadVector4());
        BigTriangles = p_Reader.ReadArray(p_Reader.PointerSize, p_E =>
        {
            var (s_A, s_B, s_C) = (p_E.ReadUInt16(), p_E.ReadUInt16(), p_E.ReadUInt16());
            var (s_Material, s_Welding) = (p_E.ReadUInt32(), p_E.AlignedTo(p_E.PointerSize).ReadUInt16());
            for (var i = 0; i < c_BigTriangleUnnamedHalves; ++i)
                if (p_E.ReadUInt16() != 0)
                    throw new InvalidDataException("A big triangle with a value BF3's do not have before its transform index.");
            return new BigTriangle(s_A, s_B, s_C, s_Material, s_Welding, p_E.ReadUInt16());
        });
        Chunks = p_Reader.ReadArray(16, p_E =>
        {
            var s_Chunk = new Chunk(p_E.ReadVector4(),
                p_E.ReadArray(2, p_V => p_V.ReadUInt16()), p_E.ReadArray(2, p_V => p_V.ReadUInt16()),
                p_E.ReadArray(2, p_V => p_V.ReadUInt16()), p_E.ReadArray(2, p_V => p_V.ReadUInt16()),
                p_E.ReadUInt32(), p_E.AlignedTo(p_E.PointerSize).ReadUInt16(), p_E.ReadUInt16());
            if (p_E.ReadUInt32() is var s_Trailer && s_Trailer != c_ChunkTrailer)
                throw new InvalidDataException($"A compressed mesh chunk ends in 0x{s_Trailer:X8}, where BF3's end in 0x{c_ChunkTrailer:X8}.");
            return s_Chunk;
        });
        ConvexPieces = p_Reader.ReadArray(16, p_E => new ConvexPiece(p_E.ReadVector4(),
            p_E.ReadArray(2, p_V => p_V.ReadUInt16()), p_E.ReadArray(1, p_V => p_V.ReadByte()),
            p_E.ReadArray(2, p_V => p_V.ReadUInt16()), p_E.ReadUInt16(), p_E.ReadUInt16()));
        Error = p_Reader.ReadSingle();
        BoundsMin = p_Reader.ReadVector4();
        BoundsMax = p_Reader.ReadVector4();
        DefaultCollisionFilterInfo = p_Reader.ReadUInt32();
        p_Reader.SkipPointerSlot();
        MaterialStriding = p_Reader.ReadUInt16();
        MaterialCount = p_Reader.ReadUInt16();
        NamedMaterials = p_Reader.ReadArray(p_Reader.PointerSize, p_E => new NamedMaterial(p_E.ReadUInt32(), p_E.ReadString()));
        p_Reader.EndClass();
    }
}
