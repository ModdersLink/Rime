using System.Collections.Generic;
using System.Numerics;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>
/// A shape collection of subparts: triangle subparts over vertex and index data, and shape
/// subparts, each a set of convex shapes in one placement. BF3's static model groups are one, with
/// a shape subpart per member over shapes the members share.
/// </summary>
public class HkpExtendedMeshShape : HkpShapeCollection
{
    public override string ClassName => "hkpExtendedMeshShape";

    /// <summary>What both kinds of subpart start with. Its pointers are not saved, so they are zero in a packfile.</summary>
    public abstract class Subpart
    {
        public byte Type { get; set; }
        public byte MaterialIndexStridingType { get; set; }
        public ushort MaterialIndexStriding { get; set; }
        public ushort NumMaterials { get; set; }
        public ulong UserData { get; set; }

        /// <summary>A subpart holds vectors, so it starts 16-aligned.</summary>
        internal void WriteSubpart(HkWriter p_Writer)
        {
            p_Writer.Align(16);
            p_Writer.Write(Type);
            p_Writer.Write(MaterialIndexStridingType);
            p_Writer.Write((ushort)0);
            p_Writer.WritePointerSlot();
            p_Writer.Write(MaterialIndexStriding);
            p_Writer.Write(NumMaterials);
            p_Writer.WritePointerSlot();
            p_Writer.WriteUlong(UserData);
        }

        internal void ReadSubpart(HkReader p_Reader)
        {
            p_Reader.Align(16);
            Type = p_Reader.ReadByte();
            MaterialIndexStridingType = p_Reader.ReadByte();
            p_Reader.ReadUInt16();
            p_Reader.SkipPointerSlot();
            MaterialIndexStriding = p_Reader.ReadUInt16();
            NumMaterials = p_Reader.ReadUInt16();
            p_Reader.SkipPointerSlot();
            UserData = p_Reader.ReadUlong();
        }
    }

    /// <summary>Triangles over vertex and index data the packfile does not hold, in a scaled placement.</summary>
    public sealed class TrianglesSubpart : Subpart
    {
        public int NumTriangleShapes { get; set; }
        public int NumVertices { get; set; }
        public ushort VertexStriding { get; set; }
        public int TriangleOffset { get; set; }
        public ushort IndexStriding { get; set; }
        public byte StridingType { get; set; }
        public byte FlipAlternateTriangles { get; set; }
        public Vector4 Extrusion { get; set; }
        public Vector4 Translation { get; set; }
        public Vector4 Rotation { get; set; }
        public Vector4 Scale { get; set; }

        internal void Write(HkWriter p_Writer)
        {
            WriteSubpart(p_Writer);
            p_Writer.Write(NumTriangleShapes);
            p_Writer.WritePointerSlot();
            p_Writer.Write(NumVertices);
            p_Writer.WritePointerSlot();
            p_Writer.Write(VertexStriding);
            p_Writer.Write(TriangleOffset);
            p_Writer.Write(IndexStriding);
            p_Writer.Write(StridingType);
            p_Writer.Write(FlipAlternateTriangles);
            p_Writer.Write(Extrusion);
            p_Writer.Write(Translation);
            p_Writer.Write(Rotation);
            p_Writer.Write(Scale);
        }

        internal static TrianglesSubpart Read(HkReader p_Reader)
        {
            var s_Subpart = new TrianglesSubpart();
            s_Subpart.ReadSubpart(p_Reader);
            s_Subpart.NumTriangleShapes = p_Reader.ReadInt32();
            p_Reader.SkipPointerSlot();
            s_Subpart.NumVertices = p_Reader.ReadInt32();
            p_Reader.SkipPointerSlot();
            s_Subpart.VertexStriding = p_Reader.ReadUInt16();
            s_Subpart.TriangleOffset = p_Reader.ReadInt32();
            s_Subpart.IndexStriding = p_Reader.ReadUInt16();
            s_Subpart.StridingType = p_Reader.ReadByte();
            s_Subpart.FlipAlternateTriangles = p_Reader.ReadByte();
            s_Subpart.Extrusion = p_Reader.ReadVector4();
            s_Subpart.Translation = p_Reader.ReadVector4();
            s_Subpart.Rotation = p_Reader.ReadVector4();
            s_Subpart.Scale = p_Reader.ReadVector4();
            return s_Subpart;
        }
    }

    /// <summary>
    /// Convex shapes in one rigid placement. Havok keeps which parts of the placement are set in
    /// the translation's w, as the integer bits of 0x3F000000 | flags.
    /// </summary>
    public sealed class ShapesSubpart : Subpart
    {
        public List<HkpConvexShape> ChildShapes { get; set; } = [];
        public Vector4 Rotation { get; set; }
        public Vector4 Translation { get; set; }

        internal void Write(HkWriter p_Writer)
        {
            WriteSubpart(p_Writer);
            p_Writer.WriteObjects(ChildShapes);
            p_Writer.Write(Rotation);
            p_Writer.Write(Translation);
        }

        internal static ShapesSubpart Read(HkReader p_Reader)
        {
            var s_Subpart = new ShapesSubpart();
            s_Subpart.ReadSubpart(p_Reader);
            s_Subpart.ChildShapes = p_Reader.ReadObjects<HkpConvexShape>();
            s_Subpart.Rotation = p_Reader.ReadVector4();
            s_Subpart.Translation = p_Reader.ReadVector4();
            return s_Subpart;
        }
    }

    /// <summary>The one triangle subpart Havok embeds in the shape when there is a single one; unused in BF3's.</summary>
    public TrianglesSubpart EmbeddedTrianglesSubpart { get; set; } = new();

    public Vector4 AabbHalfExtents { get; set; }
    public Vector4 AabbCenter { get; set; }

    /// <summary>How many bits of a shape key, below its top bit, number the subpart.</summary>
    public int NumBitsForSubpartIndex { get; set; }

    public List<TrianglesSubpart> TrianglesSubparts { get; set; } = [];
    public List<ShapesSubpart> ShapesSubparts { get; set; } = [];
    public List<ushort> WeldingInfo { get; set; } = [];
    public byte WeldingType { get; set; }
    public uint DefaultCollisionFilterInfo { get; set; }

    /// <summary>The number of child shapes, which Havok caches.</summary>
    public int CachedNumChildShapes { get; set; }

    public float TriangleRadius { get; set; }

    protected internal override void Write(HkWriter p_Writer)
    {
        base.Write(p_Writer);
        EmbeddedTrianglesSubpart.Write(p_Writer);
        p_Writer.Write(AabbHalfExtents);
        p_Writer.Write(AabbCenter);
        p_Writer.WritePointerSlot();
        p_Writer.Write(NumBitsForSubpartIndex);
        p_Writer.WriteArray(TrianglesSubparts, 16, (p_E, p_S) => p_S.Write(p_E));
        p_Writer.WriteArray(ShapesSubparts, 16, (p_E, p_S) => p_S.Write(p_E));
        p_Writer.WriteArray(WeldingInfo, 2, (p_E, p_V) => p_E.Write(p_V));
        p_Writer.Write(WeldingType);
        p_Writer.Write(DefaultCollisionFilterInfo);
        p_Writer.Write(CachedNumChildShapes);
        p_Writer.Write(TriangleRadius);
        p_Writer.Write(0);
        p_Writer.EndClass();
    }

    protected internal override void Read(HkReader p_Reader)
    {
        base.Read(p_Reader);
        EmbeddedTrianglesSubpart = TrianglesSubpart.Read(p_Reader);
        AabbHalfExtents = p_Reader.ReadVector4();
        AabbCenter = p_Reader.ReadVector4();
        p_Reader.SkipPointerSlot();
        NumBitsForSubpartIndex = p_Reader.ReadInt32();
        TrianglesSubparts = p_Reader.ReadArray(16, TrianglesSubpart.Read);
        ShapesSubparts = p_Reader.ReadArray(16, ShapesSubpart.Read);
        WeldingInfo = p_Reader.ReadArray(2, p_E => p_E.ReadUInt16());
        WeldingType = p_Reader.ReadByte();
        DefaultCollisionFilterInfo = p_Reader.ReadUInt32();
        CachedNumChildShapes = p_Reader.ReadInt32();
        TriangleRadius = p_Reader.ReadSingle();
        p_Reader.ReadInt32();
        p_Reader.EndClass();
    }
}
