using System.Collections.Generic;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Content.Scaleform;
using RimeLib.Frostbite;

namespace RimeLib.Content.Frostbite2013_2.Resources
{
    public class ResourceStructs : IResourceStructs
    {
        public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2013_2 };

        public IReadOnlyCollection<ResourceType> Types { get; } = new[] { ResourceType.CompiledLuaResource, ResourceType.SwfMovie };

        public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta) => p_Type == ResourceType.SwfMovie
            ? SwfFile.Read(p_Data).Write()
            : CompiledLuaResource.Read(p_Data).Write();
    }
}
