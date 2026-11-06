using RimeLib.IO;
using RimeLib.Terrain.Frostbite2_0.Frostbite;
using RimeLib.Terrain.Frostbite2_0.Frostbite.Destruction;
using RimeLib.Terrain.Frostbite2_0.Frostbite.TerrainMaterial;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>
/// Frostbite 2's streaming tree with the skip level count before the node count. The material and
/// destruction depth trees are Frostbite 2's; the heightfield, mask and colour trees are this
/// engine's own.
/// </summary>
public class TerrainStreamingTree : Frostbite2_0.TerrainStreamingTree
{
    public uint SkipLevels { get; set; }

    protected override RasterTree? CreateRasterTree(RasterTree.RasterTreeTypes p_Type) => p_Type switch
    {
        RasterTree.RasterTreeTypes.HeightfieldTreeType => new HeightfieldTree(),
        RasterTree.RasterTreeTypes.TerrainMaskTreeType => new TerrainMaskTree(),
        RasterTree.RasterTreeTypes.TerrainColorTreeType => new TerrainColorTree(),
        RasterTree.RasterTreeTypes.TerrainMaterialTreeType => new TerrainMaterialTree(),
        RasterTree.RasterTreeTypes.DestructionDepthTreeType => new DestructionDepthTree(),
        _ => null,
    };

    protected override void DeserializeLevels(RimeReader p_Reader) => SkipLevels = p_Reader.ReadUInt32();

    protected override void SerializeLevels(RimeWriter p_Writer) => p_Writer.Write(SkipLevels);
}
