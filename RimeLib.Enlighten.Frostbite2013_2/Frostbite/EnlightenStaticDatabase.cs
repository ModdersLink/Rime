using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

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

    public bool Enabled { get; set; }
    public uint OutputAtlasWidth { get; set; }
    public uint OutputAtlasHeight { get; set; }

    /// <summary>One ShProbe each: the red, green, blue and occlusion coefficients.</summary>
    public List<ShProbe> Probes { get; set; } = new();

    public uint CookiePad { get; set; }

    public record struct ShProbe(Vector4 R, Vector4 G, Vector4 B, Vector4 O);

    public static EnlightenStaticDatabase Read(byte[] p_Data, byte[] p_Meta)
    {
        var s_Database = new EnlightenStaticDatabase
        {
            Enabled = BinaryPrimitives.ReadUInt32LittleEndian(p_Meta) != 0,
            CookiePad = BinaryPrimitives.ReadUInt32LittleEndian(p_Meta.AsSpan(12)),
        };

        if (!s_Database.Enabled)
        {
            if (p_Data.Length != 4 || BinaryPrimitives.ReadUInt32LittleEndian(p_Data) != c_Disabled)
                throw new InvalidDataException("a disabled static database with a payload");
            return s_Database;
        }

        var d = new ReadOnlySpan<byte>(p_Data);
        s_Database.OutputAtlasWidth = BinaryPrimitives.ReadUInt32LittleEndian(d);
        s_Database.OutputAtlasHeight = BinaryPrimitives.ReadUInt32LittleEndian(d[4..]);
        var s_Count = (int)BinaryPrimitives.ReadUInt32LittleEndian(d[8..]);
        if (BinaryPrimitives.ReadUInt64LittleEndian(d[12..]) != c_HeaderSize || d[20..c_HeaderSize].IndexOfAnyExcept((byte)0) >= 0)
            throw new InvalidDataException("the probes do not follow the header");

        for (var i = 0; i < s_Count; ++i)
        {
            var o = c_HeaderSize + 64 * i;
            s_Database.Probes.Add(new ShProbe(Vec4(d, o), Vec4(d, o + 16), Vec4(d, o + 32), Vec4(d, o + 48)));
        }

        return s_Database;
    }

    private static Vector4 Vec4(ReadOnlySpan<byte> p_Data, int p_Offset) => new(
        BinaryPrimitives.ReadSingleLittleEndian(p_Data[p_Offset..]),
        BinaryPrimitives.ReadSingleLittleEndian(p_Data[(p_Offset + 4)..]),
        BinaryPrimitives.ReadSingleLittleEndian(p_Data[(p_Offset + 8)..]),
        BinaryPrimitives.ReadSingleLittleEndian(p_Data[(p_Offset + 12)..]));

    /// <summary>The resource and its meta.</summary>
    public (byte[] Data, byte[] Meta) Write()
    {
        var s_Meta = new byte[16];
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta.AsSpan(12), CookiePad);

        if (!Enabled)
        {
            var s_Disabled = new byte[4];
            BinaryPrimitives.WriteUInt32LittleEndian(s_Disabled, c_Disabled);
            return (s_Disabled, s_Meta);
        }

        var s_DataSize = c_HeaderSize + 64 * Probes.Count;
        var s_Data = new byte[s_DataSize + 4];
        var d = s_Data.AsSpan();
        BinaryPrimitives.WriteUInt32LittleEndian(d, OutputAtlasWidth);
        BinaryPrimitives.WriteUInt32LittleEndian(d[4..], OutputAtlasHeight);
        BinaryPrimitives.WriteUInt32LittleEndian(d[8..], (uint)Probes.Count);
        BinaryPrimitives.WriteUInt64LittleEndian(d[12..], c_HeaderSize);

        for (var i = 0; i < Probes.Count; ++i)
        {
            var o = c_HeaderSize + 64 * i;
            var (s_R, s_G, s_B, s_O) = Probes[i];
            WriteVec4(d, o, s_R);
            WriteVec4(d, o + 16, s_G);
            WriteVec4(d, o + 32, s_B);
            WriteVec4(d, o + 48, s_O);
        }

        // The relocation table: the probes pointer.
        BinaryPrimitives.WriteUInt32LittleEndian(d[s_DataSize..], 12);

        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta, 1);
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta.AsSpan(4), (uint)s_DataSize);
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta.AsSpan(8), 4);
        return (s_Data, s_Meta);
    }

    private static void WriteVec4(Span<byte> p_Data, int p_Offset, Vector4 p_Value)
    {
        BinaryPrimitives.WriteSingleLittleEndian(p_Data[p_Offset..], p_Value.X);
        BinaryPrimitives.WriteSingleLittleEndian(p_Data[(p_Offset + 4)..], p_Value.Y);
        BinaryPrimitives.WriteSingleLittleEndian(p_Data[(p_Offset + 8)..], p_Value.Z);
        BinaryPrimitives.WriteSingleLittleEndian(p_Data[(p_Offset + 12)..], p_Value.W);
    }
}
