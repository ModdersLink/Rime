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
    public uint[] Dim { get; set; } = new Dim[3];
    public uint Priority { get; set; }
    public uint ProbeCount { get; set; }
    public uint GlobalOffset { get; set; }
    public byte StaticProbeSet { get; set; } // unsigned
    public bool DynamicDataEnable { get; set; }
    public ushort Padding_ { get; set; }
    public List<uint> Indirection { get; set; } = new();
    //public RelocPtr<uint> Indirection { get; set; }
    public List<Vec3> Positions { get; set; } = new();
    //public RelocPtr<Vec3> Positions { get; set; }
    public List<int> ValidIndices { get; set; } = new();
    //public RelocPtr<int> ValidIndices { get; set; }
    //public RelocPtr<EnlightenRawData> EnlightenData { get; set; }
    public ulong EnlightenData { get; set; }

    public EnlightenProbeSet()
    {

    }

    public EnlightenProbeSet(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        return true;
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
        p_Reader.ReadSingle();

        var s_Up = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        p_Reader.ReadSingle();

        var s_Forward = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        p_Reader.ReadSingle();

        var s_Trans = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        p_Reader.ReadSingle();

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
        p_Reader.ReadSingle();

        var s_InverseUp = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        p_Reader.ReadSingle();

        var s_InverseForward = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        p_Reader.ReadSingle();

        var s_InverseTrans = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        p_Reader.ReadSingle();

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
        p_Reader.ReadSingle();

        var s_Max = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };
        p_Reader.ReadSingle();

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

        // Indirection
        var s_IndirectionCount = p_Reader.ReadUInt32();
        var s_IndirectionOffset = p_Reader.ReadInt64();

        var s_Position = p_Reader.Position;
        p_Reader.Seek(s_IndirectionOffset, SeekOrigin.Begin);

        for (var i = 0; i < s_IndirectionCount; i++)
            Indirection.Add(p_Reader.ReadUInt32());

        p_Reader.Seek(s_Position, SeekOrigin.Begin);

        // Positions
        var s_PositionsCount = p_Reader.ReadUInt32();
        var s_PositionsOffset = p_Reader.ReadInt64();

        s_Position = p_Reader.Position;
        p_Reader.Seek(s_PositionsOffset, SeekOrigin.Begin);

        for (var i = 0; i < s_PositionsCount; i++)
        {
            Positions.Add(new Vec3
            {
                x = p_Reader.ReadSingle(),
                y = p_Reader.ReadSingle(),
                z = p_Reader.ReadSingle()
            });
            p_Reader.ReadSingle();
        }

        p_Reader.Seek(s_Position, SeekOrigin.Begin);

        // ValidIndices
        var s_ValidIndicesCount = p_Reader.ReadUInt32();
        var s_ValidIndicesOffset = p_Reader.ReadInt64();

        s_Position = p_Reader.Position;
        p_Reader.Seek(s_ValidIndicesOffset, SeekOrigin.Begin);

        for (var i = 0; i < s_ValidIndicesCount; i++)
            ValidIndices.Add(p_Reader.ReadInt32());

        p_Reader.Seek(s_Position, SeekOrigin.Begin);

        // TODO: use EnlightenRawData
        EnlightenData = p_Reader.ReadUInt64();
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}