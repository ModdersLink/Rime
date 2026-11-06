using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Content.Scaleform;
using RimeLib.Frostbite;
using RimeLib.IO;

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
            using (var s_Reader = new RimeReader(new MemoryStream(p_Data, false)))
                s_Movie.Deserialize(s_Reader);

            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
            {
                if (!s_Movie.Serialize(s_Writer))
                    throw new InvalidDataException("the movie writer refused");
            }

            return s_Stream.ToArray();
        }
    }
}
