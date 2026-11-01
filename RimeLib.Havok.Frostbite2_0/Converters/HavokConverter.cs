using System.Collections.Generic;
using System.Linq;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0.Converters;

public class HavokConverter : IHavokConverter
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2_0 };
    }

    public IEnumerable<hkpTransform> GetTransforms(IResourceObject p_Resource, IEngineMounter p_Mounter)
    {
        using var s_Reader = p_Resource.GetReader();
        var s_PhysicsData = new HavokPhysicsData(s_Reader);
        return s_PhysicsData.GetTransforms();
    }

    public IEnumerable<hkpCollisionShape> GetShapes(IResourceObject p_Resource, IEngineMounter p_Mounter)
    {
        using var s_Reader = p_Resource.GetReader();
        var s_PhysicsData = new HavokPhysicsData(s_Reader);
        return s_PhysicsData.GetShapes();
    }

    public hkpPhysicsWrapper GetWrapper(IResourceObject p_Resource, IEngineMounter p_Mounter)
    {
        using var s_Reader = p_Resource.GetReader();
        var s_PhysicsData = new HavokPhysicsData(s_Reader);

        return new hkpPhysicsWrapper
        {
            PartCount = s_PhysicsData.PartCount,
            Scale = s_PhysicsData.Scale,
            MaterialCountUsed = s_PhysicsData.MaterialCountUsed,
            HighestMaterialIndex = s_PhysicsData.HighestMaterialIndex,
            PartTranslations = s_PhysicsData.PartTranslations
                .Select(t => new System.Numerics.Vector3(t.x, t.y, t.z)).ToList(),
            LocalAabbs = s_PhysicsData.LocalAabbs
                .Select(a => new[] { a.min.x, a.min.y, a.min.z, a.max.x, a.max.y, a.max.z }).ToList(),
            MaterialIndices = s_PhysicsData.MaterialIndices.ToList(),
            MaterialFlagsAndIndices = s_PhysicsData.MaterialFlagsAndIndices.ToList()
        };
    }
}
