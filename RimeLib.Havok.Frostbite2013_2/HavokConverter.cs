using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite2013_2.Frostbite;

namespace RimeLib.Havok.Frostbite2013_2;

/// <summary>BF4's HavokPhysicsData: Frostbite 2's container around Havok 2012.2 packfiles.</summary>
public class HavokConverter : Frostbite2_0.Converters.HavokConverter
{
    public override EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2013_2 };

    protected override Frostbite2_0.Frostbite.ShapeReader CreateShapeReader() => new ShapeReader();
}
