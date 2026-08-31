using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Terrain.Frostbite;
using RimeLib.Terrain.Frostbite.Heightfield;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2_0;

public class TerrainHeightfieldReader : ITerrainHeightfield
{
    public EngineType[] GetSupportedEngines()
    {
        return [EngineType.Frostbite2_0];
    }

    public bool ReadHeightfield(IResourceObject p_Resource, IEngineMounter p_Mounter, out TerrainHeightfield? p_Heightfield)
    {
        p_Heightfield = null;

        var s_Tree = new TerrainStreamingTree();

        using (var s_Stream = p_Resource.GetReader())
        using (var s_Reader = new RimeReader(s_Stream))
            s_Tree.Deserialize(s_Reader);

        if (s_Tree.RasterTrees[(int)RasterTree.RasterTreeTypes.HeightfieldTreeType] is not HeightfieldTree s_Heightfield ||
            s_Heightfield.RootNode == null)
            return false;

        p_Heightfield = new TerrainHeightfield
        {
            SamplesPerSide = s_Heightfield.NodeSamplesPerSide,
            WorldSizeY = s_Heightfield.WorldSizeY,
            WorldScaleY = s_Heightfield.WorldScaleY
        };

        if (s_Heightfield.RootNode is HeightfieldTreeNode s_Root)
            Walk(s_Root, 0, p_Heightfield.Nodes);

        return true;
    }

    private static void Walk(HeightfieldTreeNode p_Node, int p_Depth, List<TerrainHeightfieldNode> p_Out)
    {
        p_Out.Add(new TerrainHeightfieldNode
        {
            Depth = p_Depth,
            Min = [p_Node.BoundingBox.min.x, p_Node.BoundingBox.min.y, p_Node.BoundingBox.min.z],
            Max = [p_Node.BoundingBox.max.x, p_Node.BoundingBox.max.y, p_Node.BoundingBox.max.z],
            SamplesPerMeter = p_Node.SamplesPerMeter,
            Embedded = p_Node.EmbeddedData,
            Flags = p_Node.Flags
        });

        foreach (var s_Child in p_Node.Children)
        {
            if (s_Child is HeightfieldTreeNode s_Node)
                Walk(s_Node, p_Depth + 1, p_Out);
        }
    }
}
