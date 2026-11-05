using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2_0;

public class EnlightenShaderDatabase : IFbSerializable
{
    public uint MaterialCount;
    public List<EnlightenMaterial> Materials { get; set; } = new List<EnlightenMaterial>();

    public EnlightenShaderDatabase()
    {

    }

    public EnlightenShaderDatabase(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    /// <summary>
    /// The exact inverse of <see cref="Deserialize(RimeReader)"/>. The count written is the list's
    /// own, not the <see cref="MaterialCount"/> read from the source: a caller that adds or removes
    /// a material would otherwise write a header that disagrees with the body, and the reader
    /// following it walks off the end.
    /// </summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        MaterialCount = (uint) Materials.Count;
        p_Writer.Write(MaterialCount);

        foreach (var s_Material in Materials)
            if (!s_Material.Serialize(p_Writer))
                return false;

        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        if (Serialize(s_Writer))
        {
            p_Data = s_Stream.ToArray();
            return true;
        }

        p_Data = null;
        return false;
    }

    public void Deserialize(RimeReader p_Reader)
    {
        MaterialCount = p_Reader.ReadUInt32();
        Materials = new List<EnlightenMaterial>((int) MaterialCount);

        // Add, not an indexer: the constructor above sets CAPACITY, and the list is still empty, so
        // assigning to Materials[i] throws before the first material is ever read.
        for (var i = 0; i < MaterialCount; i++)
            Materials.Add(new EnlightenMaterial(p_Reader));
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}