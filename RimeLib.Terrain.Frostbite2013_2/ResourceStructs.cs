using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Terrain.Frostbite2013_2.Frostbite;

namespace RimeLib.Terrain.Frostbite2013_2;

public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } =
        [ResourceType.VisualTerrain, ResourceType.TerrainLayerCombinations, ResourceType.TerrainDecals, ResourceType.TerrainStreamingTree];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        switch (p_Type)
        {
            case ResourceType.VisualTerrain:
                return RoundTrip(new VisualTerrain(), p_Data);
            case ResourceType.TerrainLayerCombinations:
                return RoundTrip(new TerrainLayerCombinations(), p_Data);
            case ResourceType.TerrainStreamingTree:
                return RoundTrip(new TerrainStreamingTree(), p_Data);
            case ResourceType.TerrainDecals:
                var s_Converter = new TerrainDecalsConverter();
                Resources.TerrainDecalsResource s_Decals;
                using (var s_Reader = new RimeReader(new MemoryStream(p_Data, false)))
                    s_Decals = s_Converter.Read(s_Reader);
                var s_Stream = new MemoryStream();
                using (var s_Writer = new RimeWriter(s_Stream))
                    s_Converter.Write(s_Writer, s_Decals);
                return s_Stream.ToArray();
            default:
                throw new InvalidDataException($"{p_Type} is not a terrain resource");
        }
    }

    private static byte[] RoundTrip(IFbSerializable p_Struct, byte[] p_Data)
    {
        p_Struct.Deserialize(p_Data);
        if (!p_Struct.Serialize(out var s_Written))
            throw new InvalidDataException($"the {p_Struct.GetType().Name} writer refused");
        return s_Written;
    }
}
