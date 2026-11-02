using System.IO;
using System.Linq;
using RimeLib.Enlighten.Frostbite2_0;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 EnlightenStaticDatabase: the Frostbite 2 database as a relocatable image (atlas
/// size and a RelocArray of the probes) with its one-entry relocation table. The meta is the
/// cookie: enabled, image size, relocation table size and a last word stored as found.
/// </summary>
public class StaticEnlightenDatabase : Frostbite2_0.StaticEnlightenDatabase
{
    private const int c_HeaderSize = 0x20;

    /// <summary>The whole payload of a disabled database.</summary>
    private const uint c_Disabled = 0xDEADBEEF;

    public uint CookiePad { get; set; }

    /// <summary>Where <see cref="Serialize"/> wrote the probes pointer, the relocation table's one entry.</summary>
    private long m_ProbesPointer;

    public static StaticEnlightenDatabase Read(byte[] p_Data, byte[] p_Meta)
    {
        using var s_Meta = new RimeReader(new MemoryStream(p_Meta, false));
        var s_Database = new StaticEnlightenDatabase { Enabled = s_Meta.ReadUInt32() != 0 };
        s_Meta.Seek(12, SeekOrigin.Begin);
        s_Database.CookiePad = s_Meta.ReadUInt32();

        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        if (!s_Database.Enabled)
        {
            if (p_Data.Length != 4 || s_Reader.ReadUInt32() != c_Disabled)
                throw new InvalidDataException("a disabled static database with a payload");
            return s_Database;
        }

        s_Database.Deserialize(s_Reader);
        return s_Database;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        OutputAtlasWidth = p_Reader.ReadUInt32();
        OutputAtlasHeight = p_Reader.ReadUInt32();
        var s_Probes = new RelocArray<StaticEnlightenProbe>(p_Reader);
        if (s_Probes.BaseAddress != c_HeaderSize || p_Reader.ReadUInt32() != 0 || p_Reader.ReadUInt64() != 0)
            throw new InvalidDataException("the probes do not follow the header");

        Probes = s_Probes.Get.ToList();
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(OutputAtlasWidth);
        p_Writer.Write(OutputAtlasHeight);

        // The pointer follows the count in the slot.
        m_ProbesPointer = p_Writer.Position + sizeof(uint);
        new RelocArray<StaticEnlightenProbe> { Count = (uint)Probes.Count, BaseAddress = c_HeaderSize }.Serialize(p_Writer);
        p_Writer.WriteNullBytes((uint)(c_HeaderSize - p_Writer.Position));

        foreach (var s_Probe in Probes)
            s_Probe.Serialize(p_Writer);

        return true;
    }

    /// <summary>The resource and its meta.</summary>
    public (byte[] Data, byte[] Meta) Write()
    {
        var s_Data = new MemoryStream();
        var s_DataSize = 0;
        using (var s_Writer = new RimeWriter(s_Data))
        {
            if (!Enabled)
            {
                s_Writer.Write(c_Disabled);
            }
            else
            {
                Serialize(s_Writer);
                s_DataSize = (int)s_Writer.Position;
                s_Writer.Write((uint)m_ProbesPointer);
            }
        }

        var s_Meta = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Meta))
        {
            s_Writer.Write(Enabled ? 1u : 0u);
            s_Writer.Write((uint)s_DataSize);
            s_Writer.Write(Enabled ? 4u : 0u);
            s_Writer.Write(CookiePad);
        }

        return (s_Data.ToArray(), s_Meta.ToArray());
    }
}
