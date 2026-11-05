using System.Collections.Generic;
using System.IO;
using RimeLib.Animation.Frostbite2_0.Frostbite;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Animation.Frostbite2_0;

/// <summary>AnimTrackData is laid out the same in Frostbite 2 and 2013.2.</summary>
public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0, EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.AnimTrackData];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        var s_Track = new AnimTrackData();
        using (var s_Reader = new RimeReader(new MemoryStream(p_Data, false)))
            s_Track.Deserialize(s_Reader);

        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
        {
            if (!s_Track.Serialize(s_Writer))
                throw new InvalidDataException("the animation track writer refused");
        }

        return s_Stream.ToArray();
    }
}
