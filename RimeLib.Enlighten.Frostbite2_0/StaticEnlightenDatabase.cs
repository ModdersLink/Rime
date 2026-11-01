using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2_0;

/// <summary>
/// The baked probe coefficients a level ships: the light itself, where
/// <see cref="EnlightenDatabase"/> and <see cref="EnlightenProbeSet"/> describe where it goes.
///
/// The layout is a thirteen-byte header -- a flag, the atlas the bake was made against, and a probe
/// count -- followed by that many probes of sixty-four bytes each, with nothing else in the file.
/// MEASURED across all 72 of BF3's static databases: every one is exactly
/// <c>13 + probeCount * 64</c> bytes, and the count agrees with the one the level's
/// <see cref="EnlightenDatabase"/> reports (MP_001: 2707 probes, 173261 bytes).
/// </summary>
public class StaticEnlightenDatabase : IFbSerializable
{
    public bool Enabled { get; set; }

    /// <summary>The atlas the bake was made against; matches the containing database's.</summary>
    public uint OutputAtlasWidth { get; set; }
    public uint OutputAtlasHeight { get; set; }

    public List<StaticEnlightenProbe> Probes { get; set; } = new();

    public StaticEnlightenDatabase()
    {

    }

    public StaticEnlightenDatabase(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Enabled);
        p_Writer.Write(OutputAtlasWidth);
        p_Writer.Write(OutputAtlasHeight);
        p_Writer.Write((uint) Probes.Count);

        foreach (var s_Probe in Probes)
            if (!s_Probe.Serialize(p_Writer))
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
        Enabled = p_Reader.ReadBool();
        OutputAtlasWidth = p_Reader.ReadUInt32();
        OutputAtlasHeight = p_Reader.ReadUInt32();

        var s_ProbeCount = p_Reader.ReadUInt32();
        Probes = new List<StaticEnlightenProbe>((int) s_ProbeCount);

        for (var i = 0; i < s_ProbeCount; i++)
            Probes.Add(new StaticEnlightenProbe(p_Reader));
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}
