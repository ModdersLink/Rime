using System;
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

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.OccluderMesh, ResourceType.MeshSet];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        if (p_Type == ResourceType.MeshSet)
        {
            if (p_Meta == null)
                throw new InvalidDataException("a MeshSet without meta");

            var s_Set = new MeshSetResource { Cookie = ResourceCookie.Read<MeshLayoutCookie>(p_Meta) };
            s_Set.Deserialize(p_Data);
            s_Set.Serialize(out var s_Data);
            var s_WrittenMeta = s_Set.Cookie.ToArray();
            if (!s_WrittenMeta.AsSpan().SequenceEqual(p_Meta))
                throw new InvalidDataException($"meta {Convert.ToHexString(p_Meta)} written as {Convert.ToHexString(s_WrittenMeta)}");
            return s_Data!;
        }

        var s_Mesh = new OccluderMeshData();
        s_Mesh.Deserialize(p_Data);
        if (!s_Mesh.Serialize(out var s_Written))
            throw new InvalidDataException("the occluder mesh writer refused");
        return s_Written;
    }
}
