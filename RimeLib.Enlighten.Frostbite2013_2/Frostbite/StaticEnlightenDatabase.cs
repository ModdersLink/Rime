using System.IO;
using System.Linq;
using RimeLib.Enlighten.Frostbite2_0;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 EnlightenStaticDatabase: the Frostbite 2 database as a relocatable image (atlas
/// size and a RelocArray of the probes) with its one-entry relocation table. Reading takes whether
/// it is enabled and the sizes from <see cref="Cookie"/>; writing sets them.
/// </summary>
public class StaticEnlightenDatabase : Frostbite2_0.StaticEnlightenDatabase
{
    private const int c_HeaderSize = 0x20;

    /// <summary>The whole payload of a disabled database.</summary>
    private const uint c_Disabled = 0xDEADBEEF;

    /// <summary>Where the probes pointer sits, after the atlas size and the array's count: the relocation table's one entry.</summary>
    private const uint c_ProbesPointer = 12;

    public EnlightenStaticDatabaseCookie Cookie { get; set; } = new();

    /// <summary>
    /// Reads the payload <see cref="Cookie"/> describes: for a disabled database a single marker
    /// word, else the image and its relocation table, whose one entry is the probes pointer.
    /// </summary>
    public override void Deserialize(RimeReader p_Reader)
    {
        Enabled = Cookie.Enabled != 0;
        if (!Enabled)
        {
            if (p_Reader.ReadUInt32() != c_Disabled)
                throw new InvalidDataException("a disabled static database with a payload");
            return;
        }

        var s_Start = p_Reader.Position;
        OutputAtlasWidth = p_Reader.ReadUInt32();
        OutputAtlasHeight = p_Reader.ReadUInt32();
        var s_Probes = new RelocArray<StaticEnlightenProbe>(p_Reader);
        if (s_Probes.BaseAddress != c_HeaderSize || p_Reader.ReadUInt32() != 0 || p_Reader.ReadUInt64() != 0)
            throw new InvalidDataException("the probes do not follow the header");

        Probes = s_Probes.Get.ToList();

        p_Reader.Seek(s_Start + Cookie.DataSize, SeekOrigin.Begin);
        if (Cookie.RelocSize != sizeof(uint) || p_Reader.ReadUInt32() != c_ProbesPointer)
            throw new InvalidDataException("the relocation table is not the probes pointer alone");
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        Cookie.Enabled = Enabled ? 1u : 0u;
        if (!Enabled)
        {
            p_Writer.Write(c_Disabled);
            Cookie.DataSize = 0;
            Cookie.RelocSize = 0;
            return true;
        }

        var s_Start = p_Writer.Position;
        p_Writer.Write(OutputAtlasWidth);
        p_Writer.Write(OutputAtlasHeight);
        new RelocArray<StaticEnlightenProbe> { Count = (uint)Probes.Count, BaseAddress = c_HeaderSize }.Serialize(p_Writer);
        p_Writer.WriteNullBytes((uint)(c_HeaderSize - (p_Writer.Position - s_Start)));

        foreach (var s_Probe in Probes)
            s_Probe.Serialize(p_Writer);

        Cookie.DataSize = (uint)(p_Writer.Position - s_Start);
        Cookie.RelocSize = sizeof(uint);
        p_Writer.Write(c_ProbesPointer);
        return true;
    }
}
