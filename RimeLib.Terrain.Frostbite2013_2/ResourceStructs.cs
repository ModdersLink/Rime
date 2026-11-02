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
        byte[]? s_Written;
        switch (p_Type)
        {
            case ResourceType.VisualTerrain:
                var s_Terrain = new VisualTerrain();
                s_Terrain.Deserialize(p_Data);
                s_Terrain.Serialize(out s_Written);
                return s_Written;
            case ResourceType.TerrainLayerCombinations:
                var s_Combinations = new TerrainLayerCombinations();
                s_Combinations.Deserialize(p_Data);
                s_Combinations.Serialize(out s_Written);
                return s_Written;
            case ResourceType.TerrainStreamingTree:
                var s_Tree = new TerrainStreamingTree();
                s_Tree.Deserialize(p_Data);
                if (!s_Tree.Serialize(out s_Written))
                    throw new InvalidDataException("the streaming tree writer refused");
                return s_Written;
            default:
                var s_Converter = new TerrainDecalsConverter();
                Resources.TerrainDecalsResource s_Decals;
                using (var s_Reader = new RimeReader(new MemoryStream(p_Data, false)))
                    s_Decals = s_Converter.Read(s_Reader);
                var s_Stream = new MemoryStream();
                using (var s_Writer = new RimeWriter(s_Stream))
                    s_Converter.Write(s_Writer, s_Decals);
                return s_Stream.ToArray();
        }
    }
}
