using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Havok.Frostbite2_0;

public class ResourceCookies : IResourceCookies
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0, EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } =
        [ResourceType.HavokPhysicsData, ResourceType.RagdollResource];

    public ResourceCookie Read(ResourceType p_Type, byte[] p_Meta) => p_Type switch
    {
        ResourceType.HavokPhysicsData => ResourceCookie.Read<HavokResourceCookie>(p_Meta),
        ResourceType.RagdollResource => ResourceCookie.Read<RagdollResourceCookie>(p_Meta),
        _ => throw new InvalidDataException($"{p_Type} has no cookie here"),
    };
}
