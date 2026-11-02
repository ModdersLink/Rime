using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Texture.Frostbite2013_2.Frostbite;

namespace RimeLib.Texture.Frostbite2013_2;

public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.DxTexture, ResourceType.AtlasTexture];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        if (p_Type == ResourceType.AtlasTexture)
            return AtlasTexture.Read(p_Data).Write();

        var s_Texture = new DxTexture();
        s_Texture.Deserialize(p_Data);
        if (!s_Texture.Serialize(out var s_Written))
            throw new InvalidDataException("the texture writer refused");
        return s_Written;
    }
}
