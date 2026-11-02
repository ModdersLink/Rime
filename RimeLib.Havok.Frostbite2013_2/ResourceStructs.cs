using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite2013_2.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2013_2;

/// <summary>The Havok resources BF4 adds; the rest are BF3's.</summary>
public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.HavokClothPhysicsData];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        if (!new HavokClothPhysicsData(s_Reader).Serialize(out var s_Written))
            throw new InvalidDataException("the cloth writer refused");
        return s_Written;
    }
}
