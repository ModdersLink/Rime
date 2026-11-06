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

        var s_Stream = new MemoryStream();
        ResourceCookie s_Cookie;
        using (var s_MetaReader = new RimeReader(new MemoryStream(p_Meta, false)))
        using (var s_Reader = new RimeReader(new MemoryStream(p_Data, false)))
        using (var s_Writer = new RimeWriter(s_Stream))
        {
            if (p_Type == ResourceType.EnlightenStaticDatabase)
            {
                var s_Database = new StaticEnlightenDatabase { Cookie = new EnlightenStaticDatabaseCookie() };
                s_Database.Cookie.Deserialize(s_MetaReader);
                s_Database.Deserialize(s_Reader);
                s_Database.Serialize(s_Writer);
                s_Cookie = s_Database.Cookie;
            }
            else
            {
                var s_Database = new EnlightenShaderDatabase { Cookie = new EnlightenShaderDatabaseCookie() };
                s_Database.Cookie.Deserialize(s_MetaReader);
                s_Database.Deserialize(s_Reader);
                s_Database.Serialize(s_Writer);
                s_Cookie = s_Database.Cookie;
            }
        }

        var s_Data = s_Stream.ToArray();
        var s_Meta = s_Cookie.ToArray();
        if (!s_Meta.AsSpan().SequenceEqual(p_Meta))
            throw new InvalidDataException($"meta {Convert.ToHexString(p_Meta)} written as {Convert.ToHexString(s_Meta)}");
        return s_Data;
    }
}
