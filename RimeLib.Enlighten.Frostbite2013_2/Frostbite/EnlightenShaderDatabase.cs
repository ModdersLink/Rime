using System.IO;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 EnlightenShaderDatabase: the Frostbite 2 database without its count, which
/// moved to the cookie. Reading takes the count from <see cref="Cookie"/>; writing sets it.
/// </summary>
public class EnlightenShaderDatabase : Frostbite2_0.EnlightenShaderDatabase
{
    public EnlightenShaderDatabaseCookie Cookie { get; set; } = new();

    /// <summary>Reads the materials the cookie counts.</summary>
    public override void Deserialize(RimeReader p_Reader)
    {
        MaterialCount = Cookie.NumMaterials;
        if (Cookie.DataSize != (long)EnlightenMaterial.Size * MaterialCount)
            throw new InvalidDataException($"A shader database cookie of {Cookie.DataSize} bytes for {MaterialCount} materials.");

        Materials.Clear();
        for (var i = 0; i < MaterialCount; ++i)
            Materials.Add(new EnlightenMaterial(p_Reader));
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        var s_Start = p_Writer.Position;
        MaterialCount = (uint)Materials.Count;
        foreach (var s_Material in Materials)
            s_Material.Serialize(p_Writer);

        Cookie.NumMaterials = MaterialCount;
        Cookie.DataSize = (uint)(p_Writer.Position - s_Start);
        return true;
    }
}
