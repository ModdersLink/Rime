using RimeLib.IO;

namespace RimeLib.Serialization;

public interface IPartitionGenerator : IEngineInterface
{
    public void Generate(DatabasePartitionBase p_Partition, RimeWriter p_ResourceWriter);
}
