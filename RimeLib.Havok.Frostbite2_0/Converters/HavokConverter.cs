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
        // TODO: fix this ghetto workaround to read correctly. Seems to be ZlibRimeReader related. Errored when dumping levels/xp5_002/xp5_002 (BF3).
        using var s_ResourceReader = p_Resource.GetReader();
        var s_Data = s_ResourceReader.ReadBytes((int)s_ResourceReader.Length);

        var s_HavokPhysicsData = new HavokPhysicsData(new RimeReader(new MemoryStream(s_Data)));
        return s_HavokPhysicsData.GetTransforms();
    }
}
