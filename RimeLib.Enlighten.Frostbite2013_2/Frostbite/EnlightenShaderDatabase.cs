using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using RimeLib.IO;

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
        using var s_Meta = new RimeReader(new MemoryStream(p_Meta, false));
        var s_Size = s_Meta.ReadUInt32();
        var s_Count = (int)s_Meta.ReadUInt32();
        if (s_Size != p_Data.Length || p_Data.Length != c_MaterialSize * s_Count)
            throw new InvalidDataException("the shader database size does not match its material count");

        var s_Database = new EnlightenShaderDatabase { CookiePadding = [s_Meta.ReadUInt32(), s_Meta.ReadUInt32()] };

        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        for (var i = 0; i < s_Count; ++i)
        {
            var s_Color = s_Reader.ReadVector3();
            var s_ColorPad = s_Reader.ReadUInt32();
            var s_Guid = s_Reader.ReadGuid();
            var s_ShaderId = s_Reader.ReadUInt64();
            var s_Emissive = s_Reader.ReadUByte();
            var s_Pad = s_Reader.ReadBytes(7);
            if (s_ColorPad != 0 || s_Emissive > 1 || Array.Exists(s_Pad, p_B => p_B != 0))
                throw new InvalidDataException($"material {i} has padding that is not zero");

            s_Database.Materials.Add(new EnlightenMaterial(s_Color, s_Guid, s_ShaderId, s_Emissive != 0));
        }

        return s_Database;
    }

    /// <summary>The resource and its meta.</summary>
    public (byte[] Data, byte[] Meta) Write()
    {
        var s_Data = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Data))
        {
            foreach (var s_Material in Materials)
            {
                s_Writer.Write(s_Material.Color);
                s_Writer.Write(0u);
                s_Writer.Write(s_Material.Guid);
                s_Writer.Write(s_Material.ShaderId);
                s_Writer.Write(s_Material.Emissive);
                s_Writer.WriteNullBytes(7);
            }
        }

        var s_Meta = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Meta))
        {
            s_Writer.Write((uint)(c_MaterialSize * Materials.Count));
            s_Writer.Write((uint)Materials.Count);
            s_Writer.Write(CookiePadding[0]);
            s_Writer.Write(CookiePadding[1]);
        }

        return (s_Data.ToArray(), s_Meta.ToArray());
    }
}
