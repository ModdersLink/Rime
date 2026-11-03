using System.Linq;
using RimeLib.Frostbite;
using RimeLib.Terrain.Frostbite2013_2.Frostbite;
using RimeLib.Terrain.Resources;
using BaseTree = RimeLib.Terrain.Frostbite2_0.TerrainStreamingTree;

namespace RimeLib.Terrain.Frostbite2013_2;

/// <summary>Frostbite 2's heightfield reader over BF4's streaming tree, whose mask keeps its samples per subtile.</summary>
public class TerrainHeightfieldReader : Frostbite2_0.TerrainHeightfieldReader
{
    public override EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    protected override BaseTree CreateTree() => new TerrainStreamingTree();

    /// <summary>One entry per subtile with samples: the subtile's own coverage and its flat samples.</summary>
    protected override void ReadMask(BaseTree p_Tree, TerrainHeightfield p_Heightfield)
    {
        if (p_Tree.TerrainMaskTree is not TerrainMaskTree s_Mask)
            return;

        p_Heightfield.MaskRaw = s_Mask.Raw;
        p_Heightfield.MaskConsumed = s_Mask.Raw.Length;
        p_Heightfield.MaskSamplesPerSide = s_Mask.TileSamplesPerSide;
        p_Heightfield.MaskRewritesExactly = RewritesExactly(s_Mask, s_Mask.Raw);
        p_Heightfield.MaskRewriteInfo = $"nodes={s_Mask.Nodes.Count} subtiles={s_Mask.SubtileCount}";

        foreach (var s_Node in s_Mask.Nodes)
        foreach (var s_Subtile in s_Node.Subtiles.Where(p_S => p_S.Samples.Length > 0))
        {
            p_Heightfield.MaskNodes.Add(new TerrainMaterialSamples
            {
                Level = s_Node.ID.Level,
                IndexX = s_Node.ID.IndexX,
                IndexY = s_Node.ID.IndexY,
                Min = [s_Subtile.WorldCoverage[0], s_Subtile.WorldCoverage[1]],
                Max = [s_Subtile.WorldCoverage[2], s_Subtile.WorldCoverage[3]],
                Rle = s_Subtile.Samples,
                LineSizes = [],
            });
        }
    }
}
