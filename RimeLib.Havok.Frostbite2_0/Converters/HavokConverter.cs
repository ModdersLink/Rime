using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite2_0.Frostbite;

namespace RimeLib.Havok.Frostbite2_0.Converters;

/// <summary>
/// Reads HavokPhysicsData resources: the Frostbite header and both Havok packfiles. A later engine
/// whose Havok lays shapes out differently derives from this and brings its own shape reader.
/// </summary>
public class HavokConverter : IHavokConverter, IHavokMaterials
{
    public virtual EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    /// <summary>How this engine's Havok lays its shapes out.</summary>
    protected virtual ShapeReader CreateShapeReader() => new();

    private HavokPhysicsData Read(IResourceObject p_Resource)
    {
        using var s_Reader = p_Resource.GetReader();
        return new HavokPhysicsData(s_Reader);
    }

    public IEnumerable<hkpTransform> GetTransforms(IResourceObject p_Resource, IEngineMounter p_Mounter) => Read(p_Resource).GetTransforms();

    public IEnumerable<hkpCollisionShape> GetShapes(IResourceObject p_Resource, IEngineMounter p_Mounter) => Read(p_Resource).GetShapes(CreateShapeReader());

    public IReadOnlyList<uint> GetMaterialFlagsAndIndices(IResourceObject p_Resource) => Read(p_Resource).MaterialFlagsAndIndices;

    public hkpPhysicsWrapper GetWrapper(IResourceObject p_Resource, IEngineMounter p_Mounter)
    {
        var s_PhysicsData = Read(p_Resource);

        return new hkpPhysicsWrapper
        {
            PartCount = s_PhysicsData.PartCount,
            Scale = s_PhysicsData.Scale,
            MaterialCountUsed = s_PhysicsData.MaterialCountUsed,
            HighestMaterialIndex = s_PhysicsData.HighestMaterialIndex,
            PartTranslations = s_PhysicsData.PartTranslations.Select(p_T => new Vector3(p_T.X, p_T.Y, p_T.Z)).ToList(),
            LocalAabbs = s_PhysicsData.LocalAabbs.Select(p_A => new[] { p_A.Min.X, p_A.Min.Y, p_A.Min.Z, p_A.Max.X, p_A.Max.Y, p_A.Max.Z }).ToList(),
            MaterialIndices = s_PhysicsData.MaterialIndices.ToList(),
            MaterialFlagsAndIndices = s_PhysicsData.MaterialFlagsAndIndices.ToList(),
        };
    }
}
