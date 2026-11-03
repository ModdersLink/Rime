using System.IO;
using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite2_0.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

public class HavokObjectModel : IHavokObjectModel
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public byte[] Rewrite(byte[] p_Resource)
    {
        var s_Physics = new HavokPhysicsData(new RimeReader(new MemoryStream(p_Resource)));
        s_Physics.HavokInstance32 = HkPackfile.Write(HkPackfile.Read(s_Physics.HavokInstance32), 4);
        s_Physics.HavokInstance64 = HkPackfile.Write(HkPackfile.Read(s_Physics.HavokInstance64), 8);

        if (!s_Physics.Serialize(out var s_Data))
            throw new InvalidDataException("The physics resource could not be written.");
        return s_Data;
    }
}
