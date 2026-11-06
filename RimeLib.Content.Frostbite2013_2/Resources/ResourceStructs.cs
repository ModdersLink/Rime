using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2013_2.Resources
{
    /// <summary>The compiled Lua resources BF4 adds.</summary>
    public class ResourceStructs : IResourceStructs
    {
        public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2013_2 };

        public IReadOnlyCollection<ResourceType> Types { get; } = new[] { ResourceType.CompiledLuaResource };

        public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
        {
            var s_Lua = new CompiledLuaResource();
            using (var s_Reader = new RimeReader(new MemoryStream(p_Data, false)))
                s_Lua.Deserialize(s_Reader);

            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
            {
                if (!s_Lua.Serialize(s_Writer))
                    throw new InvalidDataException("the compiled Lua writer refused");
            }

            return s_Stream.ToArray();
        }
    }
}
