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
    public RelocArray<Vec3> PartTranslations { get; set; } = new RelocArray<Vec3>();
    public RelocArray<AxisAlignedBox> LocalAabbs { get; set; } = new RelocArray<AxisAlignedBox>();
    public RelocArray<byte> MaterialIndices { get; set; } = new RelocArray<byte>();
    public RelocArray<uint> MaterialFlagsAndIndices { get; set; } = new RelocArray<uint>();
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
        p_Writer.Write(PartCount);
        p_Writer.Write(PartTranslations.BaseAddress);
        p_Writer.Write(LocalAabbs.BaseAddress);
        p_Writer.Write(MaterialIndices.BaseAddress);
        p_Writer.Write(MaterialFlagsAndIndices.BaseAddress);
        p_Writer.Write(Scale);
        p_Writer.Write(MaterialCountUsed);
        p_Writer.Write(HighestMaterialIndex);
        p_Writer.Write(Padding);

        return true;
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
        PartTranslations = new RelocArray<Vec3>(p_Reader);
        LocalAabbs = new RelocArray<AxisAlignedBox>(p_Reader);
        MaterialIndices = new RelocArray<byte>(p_Reader);
        MaterialFlagsAndIndices = new RelocArray<uint>(p_Reader);
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