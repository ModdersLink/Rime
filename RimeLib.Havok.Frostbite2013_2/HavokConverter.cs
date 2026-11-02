using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite;

namespace RimeLib.Havok.Frostbite2013_2;

/// <summary>BF4's HavokPhysicsData: Frostbite 2's container around Havok 2012.2 packfiles.</summary>
public class HavokConverter : HavokPhysicsDataConverter
{
    public override EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2013_2 };
}
