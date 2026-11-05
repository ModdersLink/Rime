using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Enlighten.Frostbite2013_2.Frostbite;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2013_2;

public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } =
        [ResourceType.EnlightenStaticDatabase, ResourceType.EnlightenShaderDatabase];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        if (p_Meta == null)
            throw new InvalidDataException($"{p_Type} without meta");

        var s_DataStream = new MemoryStream();
        var s_MetaStream = new MemoryStream();
        using (var s_DataReader = new RimeReader(new MemoryStream(p_Data, false)))
        using (var s_MetaReader = new RimeReader(new MemoryStream(p_Meta, false)))
        using (var s_DataWriter = new RimeWriter(s_DataStream))
        using (var s_MetaWriter = new RimeWriter(s_MetaStream))
        {
            if (p_Type == ResourceType.EnlightenStaticDatabase)
            {
                var s_Database = new StaticEnlightenDatabase();
                s_Database.Deserialize(s_DataReader, s_MetaReader);
                s_Database.Serialize(s_DataWriter, s_MetaWriter);
            }
            else
            {
                var s_Database = new EnlightenShaderDatabase();
                s_Database.Deserialize(s_DataReader, s_MetaReader);
                s_Database.Serialize(s_DataWriter, s_MetaWriter);
            }
        }

        var s_Data = s_DataStream.ToArray();
        var s_Meta = s_MetaStream.ToArray();
        if (!s_Meta.AsSpan().SequenceEqual(p_Meta))
            throw new InvalidDataException($"meta {Convert.ToHexString(p_Meta)} written as {Convert.ToHexString(s_Meta)}");
        return s_Data;
    }
}
