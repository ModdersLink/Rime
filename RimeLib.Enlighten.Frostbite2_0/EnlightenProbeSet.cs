using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2_0;

public class EnlightenProbeSet : IFbSerializable
{
    public LinearTransform Transform { get; set; } = new LinearTransform();
    public LinearTransform InverseTransform { get; set; } = new LinearTransform();
    public AxisAlignedBox BoundingBox { get; set; } = new AxisAlignedBox();
    public float BlendDistance { get; set; }
    public uint[] Dim { get; set; } = new uint[3];
    public uint Priority { get; set; }
    public uint ProbeCount { get; set; }
    public uint GlobalOffset { get; set; }
    public byte StaticProbeSet { get; set; } // unsigned
    public bool DynamicDataEnable { get; set; }
    public ushort Padding_ { get; set; }
    /// <summary>
    /// One entry per cell of the <see cref="Dim"/> grid, or null where the pointer is null.
    ///
    /// The count is NOT stored: it is dim.x * dim.y * dim.z. MEASURED on MP_001's probe set 100,
    /// whose dim is (2,2,2) and whose indirection array is exactly the eight entries 0..7.
    /// </summary>
    public List<uint>? Indirection { get; set; }

    /// <summary>
    /// <see cref="ProbeCount"/> probe positions, or null where the pointer is null.
    ///
    /// Null with a non-zero probe count is normal rather than a contradiction -- of MP_001's 159
    /// probe sets, some carry positions and some carry only the indirection grid.
    /// </summary>
    public List<Vec3>? Positions { get; set; }

    /// <summary>
    /// One index per probe, or null where the pointer is null.
    ///
    /// Like <see cref="Positions"/> the count is <see cref="ProbeCount"/>. MEASURED on
    /// sp_valley's forest probe sets, the only ones in the game that use this pointer: probe set 11
    /// has eight probes and thirty-two bytes of indices.
    /// </summary>
    public List<int>? ValidIndices { get; set; }

    //public RelocPtr<EnlightenRawData> EnlightenData { get; set; }
    public ulong EnlightenData { get; set; }

    /// <summary>
    /// The fourth float of each 16-byte slot the reader steps over: four for
    /// <see cref="Transform"/>, four for <see cref="InverseTransform"/>, then min and max of
    /// <see cref="BoundingBox"/>. Ten in that order.
    ///
    /// The on-disk struct stores each of those vectors 16-byte aligned, so a lane follows every
    /// Vec3. <see cref="LinearTransform"/> and <see cref="AxisAlignedBox"/> are built from Vec3
    /// and have nowhere to put them, so they are kept here VERBATIM and written back unchanged --
    /// preserved rather than interpreted. What they mean is not established, and a writer that
    /// assumed the usual 0/0/0/1 homogeneous convention would be guessing.
    /// </summary>
    public float[] VectorLanes { get; set; } = new float[10];

    /// <summary>The same lane after each entry of <see cref="Positions"/>, one per position.</summary>
    public List<float> PositionLanes { get; set; } = new();

    /// <summary>
    /// The pointer slots as they were read, so a rewrite reproduces them exactly.
    ///
    /// They are FILE OFFSETS, and their values matter beyond which arrays exist: an EMPTY array
    /// still has a non-null pointer, aimed at the end of the data region. Rebuilding them from the
    /// lists alone would turn that into a null and change the bytes.
    /// </summary>
    public long IndirectionOffset { get => IndirectionOffsetField; set => IndirectionOffsetField = value; }
    private long IndirectionOffsetField;
    public long PositionsOffset { get => PositionsOffsetField; set => PositionsOffsetField = value; }
    private long PositionsOffsetField;
    public long ValidIndicesOffset { get => ValidIndicesOffsetField; set => ValidIndicesOffsetField = value; }
    private long ValidIndicesOffsetField;

    /// <summary>
    /// Everything from the end of the arrays to the end of the resource: the relocation table,
    /// which lists the offset of each non-null pointer slot for the loader to patch, and anything
    /// a pointer this reader does not parse was aiming at.
    ///
    /// Kept whole rather than modelled. The table is derivable from which pointers are non-null,
    /// but deriving it would mean asserting that nothing else lives back there, and this is a bake
    /// that only needs carrying intact.
    /// </summary>
    public byte[] UnparsedData { get; set; } = System.Array.Empty<byte>();

    public EnlightenProbeSet()
    {

    }

    public EnlightenProbeSet(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    /// <summary>
    /// The exact inverse of <see cref="Deserialize(RimeReader)"/>.
    ///
    /// The three arrays are addressed the way the reader reads them: a count, then an ABSOLUTE
    /// offset into the stream. So the fixed part goes out first with the offsets left blank, the
    /// payloads follow it, and each offset is then patched in place -- there is no way to know
    /// where an array lands until the ones before it have been written.
    ///
    /// Absolute means from the start of the stream, not from the start of this struct: the reader
    /// seeks <see cref="SeekOrigin.Begin"/>, so a probe set written into the middle of a larger
    /// stream records offsets that are correct for that stream.
    /// </summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        WriteVec3(p_Writer, Transform.right, VectorLanes[0]);
        WriteVec3(p_Writer, Transform.up, VectorLanes[1]);
        WriteVec3(p_Writer, Transform.forward, VectorLanes[2]);
        WriteVec3(p_Writer, Transform.trans, VectorLanes[3]);

        WriteVec3(p_Writer, InverseTransform.right, VectorLanes[4]);
        WriteVec3(p_Writer, InverseTransform.up, VectorLanes[5]);
        WriteVec3(p_Writer, InverseTransform.forward, VectorLanes[6]);
        WriteVec3(p_Writer, InverseTransform.trans, VectorLanes[7]);

        WriteVec3(p_Writer, BoundingBox.min, VectorLanes[8]);
        WriteVec3(p_Writer, BoundingBox.max, VectorLanes[9]);

        p_Writer.Write(BlendDistance);

        p_Writer.Write(Dim[0]);
        p_Writer.Write(Dim[1]);
        p_Writer.Write(Dim[2]);

        p_Writer.Write(Priority);
        p_Writer.Write(ProbeCount);
        p_Writer.Write(GlobalOffset);
        p_Writer.Write(StaticProbeSet);
        p_Writer.Write(DynamicDataEnable);
        p_Writer.Write(Padding_);

        var s_IndirectionSlot = p_Writer.Position;
        p_Writer.Write(IndirectionOffsetField);
        var s_PositionsSlot = p_Writer.Position;
        p_Writer.Write(PositionsOffsetField);
        var s_ValidIndicesSlot = p_Writer.Position;
        p_Writer.Write(ValidIndicesOffsetField);

        p_Writer.Write(EnlightenData);

        // Each array is written AT the offset its pointer already holds, rather than packed one
        // after another and the pointers patched to match. The arrays are not contiguous -- in
        // sp_valley's forest sets the positions end at 352 and the indirection grid does not start
        // until 384 -- so packing them moves everything after the first gap and rewrites offsets
        // the loader's relocation table still refers to by their old values.
        //
        // A probe set built from nothing, with no offsets to preserve, gets them laid out in field
        // order after the header. That is enough to write a well-formed resource, but note what
        // this class is for: Enlighten data is a BAKE, computed against the geometry that was there
        // at bake time. Carrying one unchanged is meaningful; synthesising one is not, and neither
        // this nor anything else in Rime can recompute the lighting it describes.
        var s_At = p_Writer.Position;

        s_At = WriteArray(p_Writer, s_IndirectionSlot, ref IndirectionOffsetField, s_At,
            Indirection == null ? null : () =>
            {
                foreach (var s_Value in Indirection)
                    p_Writer.Write(s_Value);
            });

        s_At = WriteArray(p_Writer, s_PositionsSlot, ref PositionsOffsetField, s_At,
            Positions == null ? null : () =>
            {
                for (var i = 0; i < Positions.Count; ++i)
                    WriteVec3(p_Writer, Positions[i], i < PositionLanes.Count ? PositionLanes[i] : 0.0f);
            });

        s_At = WriteArray(p_Writer, s_ValidIndicesSlot, ref ValidIndicesOffsetField, s_At,
            ValidIndices == null ? null : () =>
            {
                foreach (var s_Value in ValidIndices)
                    p_Writer.Write(s_Value);
            });

        p_Writer.Seek(s_At, SeekOrigin.Begin);
        p_Writer.Write(UnparsedData);
        return true;
    }

    /// <summary>A Vec3 followed by the 16-byte-alignment lane that trails it on disk.</summary>
    private static void WriteVec3(RimeWriter p_Writer, Vec3 p_Value, float p_Lane)
    {
        p_Writer.Write(p_Value.x);
        p_Writer.Write(p_Value.y);
        p_Writer.Write(p_Value.z);
        p_Writer.Write(p_Lane);
    }

    /// <summary>
    /// Writes one array at the offset its pointer already holds, or -- when there is none, as for a
    /// probe set built rather than read -- at <paramref name="p_End"/>, patching the slot to match.
    /// </summary>
    /// <returns>The far end of everything written so far.</returns>
    private static long WriteArray(RimeWriter p_Writer, long p_Slot, ref long p_Offset, long p_End,
        System.Action? p_Write)
    {
        if (p_Write == null)
            return p_End;

        if (p_Offset == 0)
        {
            p_Offset = p_End;
            p_Writer.Seek(p_Slot, SeekOrigin.Begin);
            p_Writer.Write(p_Offset);
        }

        p_Writer.Seek(p_Offset, SeekOrigin.Begin);
        p_Write();

        return System.Math.Max(p_End, p_Writer.Position);
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        if (Serialize(s_Writer))
        {
            p_Data = s_Stream.ToArray();
            return true;
        }

        p_Data = null;
        return false;
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_Right = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        VectorLanes[0] = p_Reader.ReadSingle();      // see VectorLanes: kept, not interpreted

        var s_Up = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        VectorLanes[1] = p_Reader.ReadSingle();

        var s_Forward = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        VectorLanes[2] = p_Reader.ReadSingle();

        var s_Trans = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        VectorLanes[3] = p_Reader.ReadSingle();

        Transform = new LinearTransform
        {
            right = s_Right,
            up = s_Up,
            forward = s_Forward,
            trans = s_Trans
        };

        var s_InverseRight = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        VectorLanes[4] = p_Reader.ReadSingle();

        var s_InverseUp = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        VectorLanes[5] = p_Reader.ReadSingle();

        var s_InverseForward = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        VectorLanes[6] = p_Reader.ReadSingle();

        var s_InverseTrans = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        VectorLanes[7] = p_Reader.ReadSingle();

        InverseTransform = new LinearTransform
        {
            right = s_InverseRight,
            up = s_InverseUp,
            forward = s_InverseForward,
            trans = s_InverseTrans
        };

        var s_Min = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        VectorLanes[8] = p_Reader.ReadSingle();

        var s_Max = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        VectorLanes[9] = p_Reader.ReadSingle();

        BoundingBox = new AxisAlignedBox
        {
            min = s_Min,
            max = s_Max,
        };

        BlendDistance = p_Reader.ReadSingle();

        Dim = new uint[3];
        Dim[0] = p_Reader.ReadUInt32();
        Dim[1] = p_Reader.ReadUInt32();
        Dim[2] = p_Reader.ReadUInt32();

        Priority = p_Reader.ReadUInt32();
        ProbeCount = p_Reader.ReadUInt32();
        GlobalOffset = p_Reader.ReadUInt32();
        StaticProbeSet = p_Reader.ReadUByte();
        DynamicDataEnable = p_Reader.ReadBool();
        Padding_ = p_Reader.ReadUInt16();

        // The three arrays are addressed by BARE pointers -- an offset each, with no count
        // beside it. The counts come from fields already read: the indirection grid is
        // dim.x*dim.y*dim.z entries and the positions are ProbeCount of them. The old reader
        // expected a count in front of every offset, which shifted the walk by four bytes and sent
        // the first seek somewhere past the end of the resource.
        IndirectionOffsetField = p_Reader.ReadInt64();
        PositionsOffsetField = p_Reader.ReadInt64();
        ValidIndicesOffsetField = p_Reader.ReadInt64();
        EnlightenData = p_Reader.ReadUInt64();

        var s_DataEnd = p_Reader.Position;

        if (IndirectionOffset != 0)
        {
            p_Reader.Seek(IndirectionOffset, SeekOrigin.Begin);
            var s_Cells = (long) Dim[0] * Dim[1] * Dim[2];
            Indirection = new List<uint>((int) s_Cells);

            for (var i = 0L; i < s_Cells; i++)
                Indirection.Add(p_Reader.ReadUInt32());

            s_DataEnd = System.Math.Max(s_DataEnd, p_Reader.Position);
        }

        if (PositionsOffset != 0)
        {
            p_Reader.Seek(PositionsOffset, SeekOrigin.Begin);
            Positions = new List<Vec3>((int) ProbeCount);

            for (var i = 0; i < ProbeCount; i++)
            {
                Positions.Add(new Vec3
                {
                    x = p_Reader.ReadSingle(),
                    y = p_Reader.ReadSingle(),
                    z = p_Reader.ReadSingle()
                });
                PositionLanes.Add(p_Reader.ReadSingle());
            }

            s_DataEnd = System.Math.Max(s_DataEnd, p_Reader.Position);
        }

        if (ValidIndicesOffset != 0)
        {
            p_Reader.Seek(ValidIndicesOffset, SeekOrigin.Begin);
            ValidIndices = new List<int>((int) ProbeCount);

            for (var i = 0; i < ProbeCount; i++)
                ValidIndices.Add(p_Reader.ReadInt32());

            s_DataEnd = System.Math.Max(s_DataEnd, p_Reader.Position);
        }

        p_Reader.Seek(s_DataEnd, SeekOrigin.Begin);

        if (p_Reader.CanSeek && p_Reader.Length > s_DataEnd)
            UnparsedData = p_Reader.ReadBytes((int) (p_Reader.Length - s_DataEnd));
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}