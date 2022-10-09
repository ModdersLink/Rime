using System.Diagnostics.CodeAnalysis;
using fb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Havok.Frostbite2_0;

public class HavokPhysicsData : IFbSerializable
{
    public uint PartCount { get; set; }
    // public RelocArray<Vec3> PartTranslations { get; set; } = new RelocArray<Vec3>();
    public List<Vec3> PartTranslations { get; set; } = new();
    // TODO: Wait for RelocArray/Ptr to be unfucked, manually parse for now
    // public RelocArray<AxisAlignedBox> LocalAabbs { get; set; } = new RelocArray<AxisAlignedBox>();
    public List<AxisAlignedBox> LocalAabbs { get; set; } = new();
    // public RelocArray<byte> MaterialIndices { get; set; } = new RelocArray<byte>();
    public List<byte> MaterialIndices { get; set; } = new();
    // public RelocArray<uint> MaterialFlagsAndIndices { get; set; } = new RelocArray<uint>();
    public List<uint> MaterialFlagsAndIndices { get; set; } = new();
    public float Scale { get; set; }
    public byte MaterialCountUsed { get; set; }
    public byte HighestMaterialIndex { get; set; }
    public ushort Padding { get; set; }

    public HavokPhysicsData()
    {

    }

    /// <summary>
    /// Loaded Constructor
    /// This will read out the HavokPhysicsData structure at an opened stream where the position is at a HavokPhysicsData structure in the data
    /// </summary>
    /// <param name="p_Reader">Reference to an IceReader class</param>
    public HavokPhysicsData(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        // TODO: Pending re-write of relocptr/array
        throw new NotImplementedException();
        //p_Writer.Write(PartCount);
        //p_Writer.Write(PartTranslations.BaseAddress);
        //p_Writer.Write(LocalAabbs.BaseAddress);
        //p_Writer.Write(MaterialIndices.BaseAddress);
        //p_Writer.Write(MaterialFlagsAndIndices.BaseAddress);
        //p_Writer.Write(Scale);
        //p_Writer.Write(MaterialCountUsed);
        //p_Writer.Write(HighestMaterialIndex);
        //p_Writer.Write(Padding);

        //return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;

        using (var s_Stream = new MemoryStream())
        {
            using var s_Writer = new RimeWriter(s_Stream);

            if (!Serialize(s_Writer))
                return false;

            p_Data = s_Stream.ToArray();
        }

        return true;
    }

    public void Deserialize(RimeReader p_Reader)
    {
        PartCount = p_Reader.ReadUInt32();

        // Manually parse this out until we can fix the hack
        var s_PartTranslationsCount = p_Reader.ReadUInt32();
        var s_PartTranslationsOffset = p_Reader.ReadInt64();

        var s_Position = p_Reader.Position;
        p_Reader.Seek(s_PartTranslationsOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_PartTranslationsCount; i++)
        {
            PartTranslations.Add(new Vec3
            {
                x = p_Reader.ReadSingle(),
                y = p_Reader.ReadSingle(),
                z = p_Reader.ReadSingle(),
            });
            // Vec3 has padding
            p_Reader.ReadSingle();
        }
        p_Reader.Seek(s_Position, SeekOrigin.Begin);

        // PartTranslations = new RelocArray<Vec3>(p_Reader);

        var s_LocalAabbsCount = p_Reader.ReadUInt32();
        var s_LocalAabbsOffset = p_Reader.ReadInt64();

        s_Position = p_Reader.Position;
        p_Reader.Seek(s_LocalAabbsOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_LocalAabbsCount; i++)
        {
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

            LocalAabbs.Add(new AxisAlignedBox
            {
                min = s_Min,
                max = s_Max,
            });
        }
        p_Reader.Seek(s_Position,SeekOrigin.Begin);

        // LocalAabbs = new RelocArray<AxisAlignedBox>(p_Reader);

        var s_MaterialIndicesCount = p_Reader.ReadUInt32();
        var s_MaterialIndicesOffset = p_Reader.ReadInt64();

        s_Position = p_Reader.Position;
        p_Reader.Seek(s_MaterialIndicesOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_MaterialIndicesCount; i++)
            MaterialIndices.Add(p_Reader.ReadUByte());

        p_Reader.Seek(s_Position, SeekOrigin.Begin);

        // MaterialIndices = new RelocArray<byte>(p_Reader);

        var s_MaterialFlagAndIndicesCount = p_Reader.ReadUInt32();
        var s_MateiralFlagAndIndciesOffset = p_Reader.ReadInt64();
        s_Position = p_Reader.Position;
        p_Reader.Seek(s_MateiralFlagAndIndciesOffset, SeekOrigin.Begin);
        for (var i = 0; i < s_MaterialFlagAndIndicesCount; ++i)
            MaterialFlagsAndIndices.Add(p_Reader.ReadUInt32());

        p_Reader.Seek(s_Position, SeekOrigin.Begin);

        // MaterialFlagsAndIndices = new RelocArray<uint>(p_Reader);

        Scale = p_Reader.ReadSingle();
        MaterialCountUsed = p_Reader.ReadUByte();
        HighestMaterialIndex = p_Reader.ReadUByte();
        Padding = p_Reader.ReadUInt16();
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}