namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>Frostbite 2's colour tree, where a node neither pruned nor with data ends after those two flags.</summary>
public class TerrainColorTree : Frostbite2_0.Frostbite.TerrainColor.TerrainColorTree
{
    protected override bool EmptyNodeEnds => true;
}
