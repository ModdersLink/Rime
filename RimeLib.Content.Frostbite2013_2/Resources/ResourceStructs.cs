using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

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
            s_Lua.Deserialize(p_Data);
            if (!s_Lua.Serialize(out var s_Written))
                throw new InvalidDataException("the compiled Lua writer refused");
            return s_Written;
        }
    }
}
