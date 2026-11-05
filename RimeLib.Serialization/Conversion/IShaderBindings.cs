using System.Collections.Generic;

namespace RimeLib.Serialization.Conversion;

/// <summary>The surface shaders an engine's mesh materials use, and pointing them at others.</summary>
public interface IShaderBindings : IEngineInterface
{
    /// <summary>Each mesh material of the partition that sets its shader inline.</summary>
    IEnumerable<MaterialBinding> Materials(DatabasePartitionBase p_Partition);

    /// <summary>The texture parameters the partition's mesh variation database entries set, per mesh material.</summary>
    IEnumerable<(InstanceRef Material, IEnumerable<string> Textures)> VariationTextures(DatabasePartitionBase p_Partition);

    /// <summary>
    /// The shader of each material of the partition's mesh asset, in the order its mesh's subsets
    /// index them: none for a material without one, and none at all for a partition without a mesh asset.
    /// </summary>
    IReadOnlyList<InstanceRef?> MeshShaders(DatabasePartitionBase p_Partition);

    /// <summary>
    /// Points each mesh material whose shader has a stand-in at it, dropping the parameters the
    /// stand-in does not take, and returns the dropped parameters' names.
    /// </summary>
    IReadOnlyList<string> Rebind(DatabasePartitionBase p_Partition, IReadOnlyDictionary<InstanceRef, ShaderStandIn> p_StandIns);
}
