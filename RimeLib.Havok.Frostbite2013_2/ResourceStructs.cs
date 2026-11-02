using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2013_2;

public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.HavokPhysicsData];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        if (!new HavokPhysicsData(s_Reader).Serialize(out var s_Written) || s_Written == null)
            throw new InvalidDataException("the physics data writer refused");
        return s_Written;
    }
}
