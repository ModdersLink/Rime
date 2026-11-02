using System.Collections.Generic;
using System.IO;
using System.Numerics;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2013_2.Frostbite;

/// <summary>
/// An EnlightenStaticDatabase resource: a relocatable EnlightenStaticDatabaseData (atlas size and
/// a pointer to the probes) with its one-entry relocation table. The meta is the cookie: enabled,
/// image size, relocation table size and a last word stored as found.
/// </summary>
public class EnlightenStaticDatabase
{
    private const int c_HeaderSize = 0x20;

    /// <summary>The whole payload of a disabled database.</summary>
    private const uint c_Disabled = 0xDEADBEEF;

    /// <summary>Where the probes pointer sits, the one entry of the relocation table.</summary>
    private const uint c_ProbesPointer = 12;

    public bool Enabled { get; set; }
    public uint OutputAtlasWidth { get; set; }
    public uint OutputAtlasHeight { get; set; }

    /// <summary>One ShProbe each: the red, green, blue and occlusion coefficients.</summary>
    public List<ShProbe> Probes { get; set; } = new();

    public uint CookiePad { get; set; }

    public record struct ShProbe(Vector4 R, Vector4 G, Vector4 B, Vector4 O);

    public static EnlightenStaticDatabase Read(byte[] p_Data, byte[] p_Meta)
    {
        using var s_Meta = new RimeReader(new MemoryStream(p_Meta, false));
        var s_Database = new EnlightenStaticDatabase { Enabled = s_Meta.ReadUInt32() != 0 };
        s_Meta.Seek(12, SeekOrigin.Begin);
        s_Database.CookiePad = s_Meta.ReadUInt32();

        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        if (!s_Database.Enabled)
        {
            if (p_Data.Length != 4 || s_Reader.ReadUInt32() != c_Disabled)
                throw new InvalidDataException("a disabled static database with a payload");
            return s_Database;
        }

        s_Database.OutputAtlasWidth = s_Reader.ReadUInt32();
        s_Database.OutputAtlasHeight = s_Reader.ReadUInt32();
        var s_Count = (int)s_Reader.ReadUInt32();
        if (s_Reader.ReadUInt64() != c_HeaderSize || s_Reader.ReadUInt32() != 0 || s_Reader.ReadUInt64() != 0)
            throw new InvalidDataException("the probes do not follow the header");

        for (var i = 0; i < s_Count; ++i)
            s_Database.Probes.Add(new ShProbe(s_Reader.ReadVector4(), s_Reader.ReadVector4(), s_Reader.ReadVector4(), s_Reader.ReadVector4()));

        return s_Database;
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
                s_Writer.Write(OutputAtlasWidth);
                s_Writer.Write(OutputAtlasHeight);
                s_Writer.Write((uint)Probes.Count);
                s_Writer.Write((ulong)c_HeaderSize);
                s_Writer.WriteNullBytes(c_HeaderSize - 20);

                foreach (var (s_R, s_G, s_B, s_O) in Probes)
                {
                    s_Writer.Write(s_R);
                    s_Writer.Write(s_G);
                    s_Writer.Write(s_B);
                    s_Writer.Write(s_O);
                }

                s_DataSize = (int)s_Writer.Position;
                s_Writer.Write(c_ProbesPointer);
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
