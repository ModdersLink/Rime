using System.Linq;
using fb.Entity;
using fb.VeniceShared;
using RimeLib.Frostbite;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Serialization.Frostbite2013_2;

/// <summary>
/// A minimap texture asset's root tile, which shows the whole map, over the box the partition
/// keeps: its texture runs with x along u and z along v.
/// </summary>
public class MinimapSource : IMinimapSource
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public (InstanceRef Texture, MinimapFrame Frame)? Read(DatabasePartitionBase p_Partition)
    {
        if (p_Partition.PrimaryInstance is not Minimap2DTextureAsset s_Asset
            || s_Asset.RootTileIndex < 0 || s_Asset.RootTileIndex >= s_Asset.Tiles.Count
            || s_Asset.Tiles[s_Asset.RootTileIndex].Texture is not { } s_Root || s_Root.IsNull()
            || p_Partition.Instances.OfType<OBBData>().FirstOrDefault() is not { } s_Box)
            return null;

        var s_Center = s_Box.Transform.trans;
        var s_Size = 2f * System.Math.Max(s_Box.HalfExtents.x, s_Box.HalfExtents.z);
        return (new InstanceRef(s_Root.PartitionGuid, PartitionConversion.InstanceGuid(s_Root.PartitionGuid, s_Root.InstanceId)),
            new MinimapFrame(s_Center.x, s_Center.z, s_Size, 1, 1));
    }
}
