using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Mesh.Frostbite2_0.Frostbite;

namespace RimeLib.Mesh.Frostbite2_0;

public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0, EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.OccluderMesh];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        var s_Mesh = new OccluderMeshData();
        s_Mesh.Deserialize(p_Data);
        if (!s_Mesh.Serialize(out var s_Written))
            throw new InvalidDataException("the occluder mesh writer refused");
        return s_Written;
    }
}
