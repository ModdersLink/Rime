using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Serialization.Frostbite2013_2
{
    internal class PartitionConverter : IPartitionConverter
    {
        public DatabasePartitionBase FromJsonStream(TextReader p_JsonReader)
        {
            throw new NotImplementedException();
        }

        public DatabasePartitionBase FromJsonString(string p_JsonString)
        {
            throw new NotImplementedException();
        }

        public DatabasePartitionBase FromPartitionObject(string p_Name, IObjectVariant p_Object)
        {
            throw new NotImplementedException();
        }

        public EngineType[] GetSupportedEngines()
        {
            throw new NotImplementedException();
        }
    }
}
