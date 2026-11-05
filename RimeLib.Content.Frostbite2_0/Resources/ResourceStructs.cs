using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Content.Scaleform;
using RimeLib.Frostbite;

namespace RimeLib.Content.Frostbite2_0.Resources
{
    /// <summary>The SWF and GFx movies, which BF3 and BF4 ship as the movie itself.</summary>
    public class ResourceStructs : IResourceStructs
    {
        public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0, EngineType.Frostbite2013_2 };

        public IReadOnlyCollection<ResourceType> Types { get; } = new[] { ResourceType.SwfMovie };

        public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
        {
            var s_Movie = new SwfFile();
            s_Movie.Deserialize(p_Data);
            if (!s_Movie.Serialize(out var s_Written))
                throw new InvalidDataException("the movie writer refused");
            return s_Written;
        }
    }
}
