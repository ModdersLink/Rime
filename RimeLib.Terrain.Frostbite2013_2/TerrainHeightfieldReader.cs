using RimeLib.Frostbite;
using RimeLib.Terrain.Frostbite2013_2.Frostbite;
using RimeLib.Terrain.Resources;
using BaseTree = RimeLib.Terrain.Frostbite2_0.TerrainStreamingTree;

namespace RimeLib.Terrain.Frostbite2013_2;

/// <summary>Frostbite 2's heightfield reader over this engine's streaming tree.</summary>
public class TerrainHeightfieldReader : Frostbite2_0.TerrainHeightfieldReader
{
    public override EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    protected override BaseTree CreateTree() => new TerrainStreamingTree();
}
