using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Mesh.Frostbite2013_2.Frostbite;

namespace RimeLib.Mesh.Frostbite2013_2;

public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.MeshSet];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        if (p_Meta == null)
            throw new InvalidDataException("a MeshSet without meta");
        var (s_Data, s_Meta) = MeshSetResource.Read(p_Data, p_Meta).Write();
        if (!s_Meta.AsSpan().SequenceEqual(p_Meta))
            throw new InvalidDataException($"meta {Convert.ToHexString(p_Meta)} written as {Convert.ToHexString(s_Meta)}");
        return s_Data;
    }
}
