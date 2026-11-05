using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Enlighten.Frostbite2013_2.Frostbite;
using RimeLib.Frostbite;

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

        byte[] s_Data;
        ResourceCookie s_Cookie;
        if (p_Type == ResourceType.EnlightenStaticDatabase)
        {
            var s_Database = new StaticEnlightenDatabase { Cookie = ResourceCookie.Read<EnlightenStaticDatabaseCookie>(p_Meta) };
            s_Database.Deserialize(p_Data);
            s_Database.Serialize(out s_Data!);
            s_Cookie = s_Database.Cookie;
        }
        else
        {
            var s_Database = new EnlightenShaderDatabase { Cookie = ResourceCookie.Read<EnlightenShaderDatabaseCookie>(p_Meta) };
            s_Database.Deserialize(p_Data);
            s_Database.Serialize(out s_Data!);
            s_Cookie = s_Database.Cookie;
        }

        var s_Meta = s_Cookie.ToArray();
        if (!s_Meta.AsSpan().SequenceEqual(p_Meta))
            throw new InvalidDataException($"meta {Convert.ToHexString(p_Meta)} written as {Convert.ToHexString(s_Meta)}");
        return s_Data;
    }
}
