using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 EnlightenShaderDatabase: its materials and nothing else, as the count is in
/// the cookie. Reading takes the count from <see cref="Cookie"/>; writing sets it.
/// </summary>
public class EnlightenShaderDatabase : IFbSerializable
{
    public List<EnlightenMaterial> Materials { get; set; } = new();

    public EnlightenShaderDatabaseCookie Cookie { get; set; } = new();

    /// <summary>Reads the materials the cookie counts.</summary>
    public void Deserialize(RimeReader p_Reader)
    {
        var s_Count = Cookie.NumMaterials;
        if (Cookie.DataSize != (long)EnlightenMaterial.Size * s_Count)
            throw new InvalidDataException($"A shader database cookie of {Cookie.DataSize} bytes for {s_Count} materials.");

        Materials.Clear();
        for (var i = 0; i < s_Count; ++i)
            Materials.Add(new EnlightenMaterial(p_Reader));
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        var s_Start = p_Writer.Position;
        foreach (var s_Material in Materials)
            s_Material.Serialize(p_Writer);

        Cookie.NumMaterials = (uint)Materials.Count;
        Cookie.DataSize = (uint)(p_Writer.Position - s_Start);
        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);
        Serialize(s_Writer);
        p_Data = s_Stream.ToArray();
        return true;
    }
}
