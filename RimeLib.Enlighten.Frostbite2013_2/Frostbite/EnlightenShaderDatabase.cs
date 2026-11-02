using System.IO;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 EnlightenShaderDatabase: the Frostbite 2 database without its count, which
/// moved to the meta (the cookie: data size, material count and two padding words stored as found).
/// </summary>
public class EnlightenShaderDatabase : Frostbite2_0.EnlightenShaderDatabase
{
    public uint[] CookiePadding { get; set; } = new uint[2];

    public static EnlightenShaderDatabase Read(byte[] p_Data, byte[] p_Meta)
    {
        using var s_Meta = new RimeReader(new MemoryStream(p_Meta, false));
        var s_Size = s_Meta.ReadUInt32();
        var s_Database = new EnlightenShaderDatabase { MaterialCount = s_Meta.ReadUInt32() };
        if (s_Size != p_Data.Length || p_Data.Length != EnlightenMaterial.Size * s_Database.MaterialCount)
            throw new InvalidDataException("the shader database size does not match its material count");

        s_Database.CookiePadding = [s_Meta.ReadUInt32(), s_Meta.ReadUInt32()];

        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        s_Database.Deserialize(s_Reader);
        return s_Database;
    }

    /// <summary>Reads <see cref="Frostbite2_0.EnlightenShaderDatabase.MaterialCount"/> materials, the count the meta gave.</summary>
    public override void Deserialize(RimeReader p_Reader)
    {
        Materials.Clear();
        for (var i = 0; i < MaterialCount; ++i)
            Materials.Add(new EnlightenMaterial(p_Reader));
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        MaterialCount = (uint)Materials.Count;
        foreach (var s_Material in Materials)
            s_Material.Serialize(p_Writer);
        return true;
    }

    /// <summary>The resource and its meta.</summary>
    public (byte[] Data, byte[] Meta) Write()
    {
        var s_Data = new MemoryStream();
        var s_DataSize = 0u;
        using (var s_Writer = new RimeWriter(s_Data))
        {
            Serialize(s_Writer);
            s_DataSize = (uint)s_Writer.Position;
        }

        var s_Meta = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Meta))
        {
            s_Writer.Write(s_DataSize);
            s_Writer.Write(MaterialCount);
            s_Writer.Write(CookiePadding[0]);
            s_Writer.Write(CookiePadding[1]);
        }

        return (s_Data.ToArray(), s_Meta.ToArray());
    }
}
