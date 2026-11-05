using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Enlighten.Frostbite2_0;

public class ResourceCookies : IResourceCookies
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public IReadOnlyCollection<ResourceType> Types { get; } =
        [ResourceType.EnlightenProbeSet];

    public ResourceCookie Read(ResourceType p_Type, byte[] p_Meta) => p_Type switch
    {
        ResourceType.EnlightenProbeSet => ResourceCookie.Read<EnlightenProbeSetCookie>(p_Meta),
        _ => throw new InvalidDataException($"{p_Type} has no cookie here"),
    };
}
