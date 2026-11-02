using System.Collections.Generic;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Mesh.Frostbite2013_2.Frostbite;

namespace RimeLib.Mesh.Frostbite2013_2;

public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.OccluderMesh];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta) => OccluderMesh.Read(p_Data).Write();
}
