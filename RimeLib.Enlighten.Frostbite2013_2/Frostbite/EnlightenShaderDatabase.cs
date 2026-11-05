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

    /// <summary>Reads the database from its payload and its meta, each from the reader's position.</summary>
    public void Deserialize(RimeReader p_Data, RimeReader p_Meta)
    {
        var s_Size = p_Meta.ReadUInt32();
        MaterialCount = p_Meta.ReadUInt32();
        var s_Remaining = p_Data.Length - p_Data.Position;
        if (s_Size != s_Remaining || s_Remaining != (long)EnlightenMaterial.Size * MaterialCount)
            throw new InvalidDataException("the shader database size does not match its material count");

        CookiePadding = [p_Meta.ReadUInt32(), p_Meta.ReadUInt32()];
        Deserialize(p_Data);
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

    /// <summary>Writes the payload and its meta.</summary>
    public bool Serialize(RimeWriter p_Data, RimeWriter p_Meta)
    {
        var s_Start = p_Data.Position;
        Serialize(p_Data);

        p_Meta.Write((uint)(p_Data.Position - s_Start));
        p_Meta.Write(MaterialCount);
        p_Meta.Write(CookiePadding[0]);
        p_Meta.Write(CookiePadding[1]);
        return true;
    }
}
