using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Serialization;

public interface IPartitionConverter : IEngineInterface
{
    public DatabasePartitionBase FromPartitionObject(string p_Name, IObjectVariant p_Object);
    public DatabasePartitionBase FromJsonString(string p_JsonString);
    public DatabasePartitionBase FromJsonStream(TextReader p_JsonReader);
}
