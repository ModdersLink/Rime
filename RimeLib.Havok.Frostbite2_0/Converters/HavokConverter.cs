using System.Collections.Generic;
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
}
