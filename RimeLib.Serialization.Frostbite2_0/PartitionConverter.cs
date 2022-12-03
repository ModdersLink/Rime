using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace RimeLib.Serialization.Frostbite2_0;

public class PartitionConverter : IPartitionConverter
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2_0 };
    }

    public DatabasePartitionBase FromPartitionObject(string p_Name, IObjectVariant p_Object)
    {
        using var s_Reader = new EbxReader();
        return s_Reader.ParsePartition(p_Name, p_Object);
    }

    public DatabasePartitionBase FromJsonString(string p_JsonString)
    {
        return DatabasePartition.FromJsonString(p_JsonString);
    }

    public DatabasePartitionBase FromJsonStream(TextReader p_JsonReader)
    {
        return DatabasePartition.FromJsonStream(p_JsonReader);
    }
}
