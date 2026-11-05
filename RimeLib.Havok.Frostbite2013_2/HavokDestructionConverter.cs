using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite2_0.Frostbite;
using RimeLib.Havok.Frostbite2_0.Packfile;
using RimeLib.Havok.Frostbite2013_2.Packfile;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2013_2;

/// <summary>BF4's destruction resources in BF3's Havok 2010.</summary>
public class HavokDestructionConverter : IHavokDestructionConverter
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public byte[] Convert(byte[] p_Resource, EngineType p_Target, out IReadOnlyDictionary<string, int> p_Dropped)
    {
        if (p_Target != EngineType.Frostbite2_0)
            throw new NotSupportedException($"Destruction is built in Havok 2010 for Frostbite 2 only, not for {p_Target}.");

        var s_Root = DestructionConversion.Convert(new HavokPhysicsData(new RimeReader(new MemoryStream(p_Resource))), out var s_Dropped);
        p_Dropped = s_Dropped;
        return HkPackfile.Rewrite(p_Resource, s_Root);
    }
}
