using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace RimeLib.Enlighten.Frostbite2013_2.Frostbite;

/// <summary>
/// An EnlightenShaderDatabase resource: an array of 48-byte EnlightenMaterials. The meta is the
/// cookie: the data size, the material count and two padding words stored as found.
/// </summary>
public class EnlightenShaderDatabase
{
    private const int c_MaterialSize = 48;

    public List<EnlightenMaterial> Materials { get; set; } = new();

    public uint[] CookiePadding { get; set; } = new uint[2];

    /// <summary>The albedo colour, the material's guid, its shader id and whether it is emissive.</summary>
    public record struct EnlightenMaterial(Vector3 Color, Guid Guid, ulong ShaderId, bool Emissive);

    public static EnlightenShaderDatabase Read(byte[] p_Data, byte[] p_Meta)
    {
        var s_Count = (int)BinaryPrimitives.ReadUInt32LittleEndian(p_Meta.AsSpan(4));
        if (BinaryPrimitives.ReadUInt32LittleEndian(p_Meta) != p_Data.Length || p_Data.Length != c_MaterialSize * s_Count)
            throw new InvalidDataException("the shader database size does not match its material count");

        var s_Database = new EnlightenShaderDatabase
        {
            CookiePadding = [BinaryPrimitives.ReadUInt32LittleEndian(p_Meta.AsSpan(8)), BinaryPrimitives.ReadUInt32LittleEndian(p_Meta.AsSpan(12))],
        };

        for (var i = 0; i < s_Count; ++i)
        {
            var d = p_Data.AsSpan(c_MaterialSize * i, c_MaterialSize);
            if (d[12..16].IndexOfAnyExcept((byte)0) >= 0 || d[41..].IndexOfAnyExcept((byte)0) >= 0 || d[40] > 1)
                throw new InvalidDataException($"material {i} has padding that is not zero");

            s_Database.Materials.Add(new EnlightenMaterial(
                new Vector3(BinaryPrimitives.ReadSingleLittleEndian(d), BinaryPrimitives.ReadSingleLittleEndian(d[4..]), BinaryPrimitives.ReadSingleLittleEndian(d[8..])),
                new Guid(d[16..32]),
                BinaryPrimitives.ReadUInt64LittleEndian(d[32..]),
                d[40] != 0));
        }

        return s_Database;
    }

    /// <summary>The resource and its meta.</summary>
    public (byte[] Data, byte[] Meta) Write()
    {
        var s_Data = new byte[c_MaterialSize * Materials.Count];
        for (var i = 0; i < Materials.Count; ++i)
        {
            var d = s_Data.AsSpan(c_MaterialSize * i, c_MaterialSize);
            var s_Material = Materials[i];
            BinaryPrimitives.WriteSingleLittleEndian(d, s_Material.Color.X);
            BinaryPrimitives.WriteSingleLittleEndian(d[4..], s_Material.Color.Y);
            BinaryPrimitives.WriteSingleLittleEndian(d[8..], s_Material.Color.Z);
            s_Material.Guid.TryWriteBytes(d[16..32]);
            BinaryPrimitives.WriteUInt64LittleEndian(d[32..], s_Material.ShaderId);
            d[40] = s_Material.Emissive ? (byte)1 : (byte)0;
        }

        var s_Meta = new byte[16];
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta, (uint)s_Data.Length);
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta.AsSpan(4), (uint)Materials.Count);
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta.AsSpan(8), CookiePadding[0]);
        BinaryPrimitives.WriteUInt32LittleEndian(s_Meta.AsSpan(12), CookiePadding[1]);
        return (s_Data, s_Meta);
    }
}
