using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Enlighten.Frostbite2013_2.Frostbite;

namespace RimeLib.Enlighten.Frostbite2013_2;

public class ResourceCookies : IResourceCookies
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } =
        [ResourceType.EnlightenDatabase, ResourceType.EnlightenStaticDatabase, ResourceType.EnlightenShaderDatabase];

    public ResourceCookie Read(ResourceType p_Type, byte[] p_Meta) => p_Type switch
    {
        ResourceType.EnlightenDatabase => ResourceCookie.Read<EnlightenDatabaseCookie>(p_Meta),
        ResourceType.EnlightenStaticDatabase => ResourceCookie.Read<EnlightenStaticDatabaseCookie>(p_Meta),
        ResourceType.EnlightenShaderDatabase => ResourceCookie.Read<EnlightenShaderDatabaseCookie>(p_Meta),
        _ => throw new InvalidDataException($"{p_Type} has no cookie here"),
    };
}
