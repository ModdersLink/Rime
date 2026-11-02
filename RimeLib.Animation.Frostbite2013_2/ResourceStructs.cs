using System.Collections.Generic;
using System.IO;
using RimeLib.Animation.Frostbite;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Animation.Frostbite2013_2;

public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.AnimTrackData];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        var s_Track = new AnimTrackData();
        s_Track.Deserialize(p_Data);
        if (!s_Track.Serialize(out var s_Written))
            throw new InvalidDataException("the animation track writer refused");
        return s_Written;
    }
}
