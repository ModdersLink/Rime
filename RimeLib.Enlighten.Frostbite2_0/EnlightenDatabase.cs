using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2_0;

public class EnlightenDatabase : IFbSerializable
{
    public bool Enabled;
    public bool DynamicDataEnable;

    public uint OutputAtlasWidth;
    public uint OutputAtlasHeight;

    public uint SystemNameCount;
    public List<string> SystemNames { get; set; } = new List<string>();

    public uint TerrainLightMapCount;
    public List<EnlightenTerrainLightmap> TerrainLightMaps { get; set; } = new List<EnlightenTerrainLightmap>();

    public uint LightMapInstanceCount;
    public List<LightMapInstance> LightMapInstances { get; set; } = new List<LightMapInstance>();

    public uint ProbeSetNamesCount;
    public List<string> ProbeSetNames { get; set; } = new List<string>();

    public uint ProbeCount;

    /// <summary>
    /// Whatever follows the fields above, kept verbatim so the round trip is exact.
    ///
    /// The payload ends with at least one byte this format is not understood well enough to name
    /// (the old reader consumed it as an unexplained pad). Rather than guess at it, or drop it and
    /// write a resource a byte shorter than the one that was read, it travels as opaque bytes. If
    /// it is later identified, it becomes a field and this shrinks -- the round trip does not
    /// change either way.
    ///
    /// This assumes the reader holds the WHOLE resource payload, which is how an
    /// <see cref="RimeLib.Content.Frostbite.ResourceType.EnlightenDatabase"/> resource is read.
    /// </summary>
    public byte[] TrailingData { get; set; } = System.Array.Empty<byte>();

    public EnlightenDatabase()
    {

    }

    public EnlightenDatabase(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    /// <summary>
    /// The exact inverse of <see cref="Deserialize(RimeReader)"/>.
    ///
    /// Counts are taken from the lists rather than from the count fields read out of the source, so
    /// that adding or removing a lightmap does not leave a header disagreeing with its body.
    /// </summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Enabled);

        // A disabled database stops here, and writing the rest of the fields would produce a
        // payload the game does not expect to find.
        if (!Enabled)
        {
            p_Writer.Write(TrailingData);
            return true;
        }

        p_Writer.Write(DynamicDataEnable);

        p_Writer.Write(OutputAtlasWidth);
        p_Writer.Write(OutputAtlasHeight);

        SystemNameCount = (uint) SystemNames.Count;
        p_Writer.Write(SystemNameCount);

        foreach (var s_Name in SystemNames)
            p_Writer.WriteNullTerminatedString(s_Name);

        TerrainLightMapCount = (uint) TerrainLightMaps.Count;
        p_Writer.Write(TerrainLightMapCount);

        foreach (var s_LightMap in TerrainLightMaps)
            if (!s_LightMap.Serialize(p_Writer))
                return false;

        LightMapInstanceCount = (uint) LightMapInstances.Count;
        p_Writer.Write(LightMapInstanceCount);

        foreach (var s_Instance in LightMapInstances)
            if (!s_Instance.Serialize(p_Writer))
                return false;

        ProbeSetNamesCount = (uint) ProbeSetNames.Count;
        p_Writer.Write(ProbeSetNamesCount);

        foreach (var s_Name in ProbeSetNames)
            p_Writer.WriteNullTerminatedString(s_Name);

        p_Writer.Write(ProbeCount);
        p_Writer.Write(TrailingData);

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

        // A disabled database has no payload past this byte -- everything below would be read out
        // of whatever happens to follow.
        if (!Enabled)
        {
            TrailingData = ReadToEnd(p_Reader);
            return;
        }

        DynamicDataEnable = p_Reader.ReadBool();

        OutputAtlasWidth = p_Reader.ReadUInt32();
        OutputAtlasHeight = p_Reader.ReadUInt32();

        // Every loop below Adds rather than assigning through an indexer. The lists are constructed
        // with a CAPACITY and are still empty, so an indexed assignment throws on the first
        // element -- which is why nothing had ever successfully read a non-empty database.
        SystemNameCount = p_Reader.ReadUInt32();
        SystemNames = new List<string>((int) SystemNameCount);
        for (var i = 0; i < SystemNameCount; i++)
            SystemNames.Add(p_Reader.ReadNullTerminatedString());

        TerrainLightMapCount = p_Reader.ReadUInt32();
        TerrainLightMaps = new List<EnlightenTerrainLightmap>((int) TerrainLightMapCount);
        for (var i = 0; i < TerrainLightMapCount; i++)
            TerrainLightMaps.Add(new EnlightenTerrainLightmap(p_Reader));

        LightMapInstanceCount = p_Reader.ReadUInt32();
        LightMapInstances = new List<LightMapInstance>((int) LightMapInstanceCount);
        for (var i = 0; i < LightMapInstanceCount; i++)
            LightMapInstances.Add(new LightMapInstance(p_Reader));

        ProbeSetNamesCount = p_Reader.ReadUInt32();
        ProbeSetNames = new List<string>((int) ProbeSetNamesCount);
        for (var i = 0; i < ProbeSetNamesCount; i++)
            ProbeSetNames.Add(p_Reader.ReadNullTerminatedString());

        ProbeCount = p_Reader.ReadUInt32();

        TrailingData = ReadToEnd(p_Reader);
    }

    /// <summary>Everything left in the payload, or an empty array if the reader cannot say.</summary>
    private static byte[] ReadToEnd(RimeReader p_Reader)
    {
        if (!p_Reader.CanSeek)
            return System.Array.Empty<byte>();

        var s_Remaining = p_Reader.Length - p_Reader.Position;

        if (s_Remaining <= 0)
            return System.Array.Empty<byte>();

        return p_Reader.ReadBytes((int) s_Remaining);
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}