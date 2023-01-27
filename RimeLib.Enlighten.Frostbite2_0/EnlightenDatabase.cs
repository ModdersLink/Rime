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
    public string[] SystemNames = string.Empty[0];

    public uint TerrainLightMapCount;
    EnlightenTerrainLightmap[] TerrainLightMaps = new EnlightenTerrainLightmap[0];

    public uint LightMapInstanceCount;
    LightMapInstance[] LightMapInstances = new LightMapInstance[0];

    public uint ProbeSetNamesCount;
    public string[] ProbeSetNames = string.Empty[0];

    public uint ProbeCount;

    public EnlightenDatabase()
    {

    }

    public EnlightenDatabase(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
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
        DynamicDataEnable = p_Reader.ReadBool();

        OutputAtlasWidth = p_Reader.ReadUInt32();
        OutputAtlasHeight = p_Reader.ReadUInt32();

        SystemNameCount = p_Reader.ReadUInt32();
        for (var i = 0; i < SystemNameCount; i++)
            SystemNames[i] = p_Reader.ReadNullTerminatedString();

        TerrainLightMapCount = p_Reader.ReadUInt32();
        TerrainLightMaps = new EnlightenTerrainLightmap[TerrainLightMapCount];
        for (var i = 0; i < TerrainLightMapCount; i++)
            TerrainLightMaps[i] = new EnlightenTerrainLightmap(p_Reader);

        LightMapInstanceCount = p_Reader.ReadUInt32();
        LightMapInstances = new LightMapInstance[LightMapInstanceCount];
        for (var i = 0; i < LightMapInstanceCount; i++)
            LightMapInstances[i] = new LightMapInstance(p_Reader);

        ProbeSetNamesCount = p_Reader.ReadUInt32();
        for (var i = 0; i < ProbeSetNamesCount; i++)
            ProbeSetNames[i] = p_Reader.ReadNullTerminatedString();

        ProbeCount = p_Reader.ReadUInt32();

        // TODO: figure out what this pad is.
        var s_Pad = p_Reader.ReadUByte();
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}