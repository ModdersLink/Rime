using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Serialization.Frostbite2013_2
{
    public class PartitionGenerator : IPartitionGenerator
    {
        public void Generate(DatabasePartitionBase p_Partition, RimeWriter p_ResourceWriter)
        {
            throw new NotImplementedException();
        }

        public EngineType[] GetSupportedEngines()
        {
            return [EngineType.Frostbite2013_2];
        }
    }
}
