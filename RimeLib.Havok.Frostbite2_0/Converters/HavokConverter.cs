using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite;

namespace RimeLib.Havok.Frostbite2_0.Converters;

public class HavokConverter : HavokPhysicsDataConverter
{
    public override EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };
}
