using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using RimeLib.Enlighten.Frostbite2_0;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 EnlightenStaticDatabase: a relocatable image (atlas size and a RelocArray of
/// Frostbite 2's <see cref="StaticEnlightenProbe"/>) with its one-entry relocation table. The meta
/// is the cookie: enabled, image size, relocation table size and a last word stored as found.
/// </summary>
public class StaticEnlightenDatabase : IFbSerializable
{
    private const int c_HeaderSize = 0x20;

    /// <summary>The whole payload of a disabled database.</summary>
    private const uint c_Disabled = 0xDEADBEEF;

    public bool Enabled { get; set; }

    /// <summary>The atlas the bake was made against.</summary>
    public uint OutputAtlasWidth { get; set; }
    public uint OutputAtlasHeight { get; set; }

    public List<StaticEnlightenProbe> Probes { get; set; } = new();

    public uint CookiePad { get; set; }

    /// <summary>Where <see cref="Serialize"/> wrote the probes pointer, the relocation table's one entry.</summary>
    private long m_ProbesPointer;

    /// <summary>Reads the database from its payload and its meta, each from the reader's position.</summary>
    public void Deserialize(RimeReader p_Data, RimeReader p_Meta)
    {
        Enabled = p_Meta.ReadUInt32() != 0;
        // The image and relocation table sizes, which writing works out.
        p_Meta.Seek(8, SeekOrigin.Current);
        CookiePad = p_Meta.ReadUInt32();

        if (!Enabled)
        {
            if (p_Data.Length - p_Data.Position != 4 || p_Data.ReadUInt32() != c_Disabled)
                throw new InvalidDataException("a disabled static database with a payload");
            return;
        }

        Deserialize(p_Data);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        OutputAtlasWidth = p_Reader.ReadUInt32();
        OutputAtlasHeight = p_Reader.ReadUInt32();
        var s_Probes = new RelocArray<StaticEnlightenProbe>(p_Reader);
        if (s_Probes.BaseAddress != c_HeaderSize || p_Reader.ReadUInt32() != 0 || p_Reader.ReadUInt64() != 0)
            throw new InvalidDataException("the probes do not follow the header");

        Probes = s_Probes.Get.ToList();
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        var s_Start = p_Writer.Position;
        p_Writer.Write(OutputAtlasWidth);
        p_Writer.Write(OutputAtlasHeight);

        // The pointer follows the count in the slot.
        m_ProbesPointer = p_Writer.Position - s_Start + sizeof(uint);
        new RelocArray<StaticEnlightenProbe> { Count = (uint)Probes.Count, BaseAddress = c_HeaderSize }.Serialize(p_Writer);
        p_Writer.WriteNullBytes((uint)(c_HeaderSize - (p_Writer.Position - s_Start)));

        foreach (var s_Probe in Probes)
            s_Probe.Serialize(p_Writer);

        return true;
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);
        Serialize(s_Writer);
        p_Data = s_Stream.ToArray();
        return true;
    }

    /// <summary>Writes the payload and its meta.</summary>
    public bool Serialize(RimeWriter p_Data, RimeWriter p_Meta)
    {
        var s_DataSize = 0u;
        if (!Enabled)
        {
            p_Data.Write(c_Disabled);
        }
        else
        {
            var s_Start = p_Data.Position;
            Serialize(p_Data);
            s_DataSize = (uint)(p_Data.Position - s_Start);
            p_Data.Write((uint)m_ProbesPointer);
        }

        p_Meta.Write(Enabled ? 1u : 0u);
        p_Meta.Write(s_DataSize);
        p_Meta.Write(Enabled ? 4u : 0u);
        p_Meta.Write(CookiePad);
        return true;
    }
}
