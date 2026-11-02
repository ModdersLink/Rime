using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Havok.Frostbite2_0.Converters;

public class HavokMaterials : IHavokMaterials
{
    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    public IReadOnlyList<uint> GetMaterialFlagsAndIndices(IResourceObject p_Resource)
    {
        using var s_Reader = p_Resource.GetReader();
        return new HavokPhysicsData(s_Reader).MaterialFlagsAndIndices;
    }
}
