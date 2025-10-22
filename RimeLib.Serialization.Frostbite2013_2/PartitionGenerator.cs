using System;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Serialization.Frostbite2013_2.Ebx;

namespace RimeLib.Serialization.Frostbite2013_2;

public class PartitionGenerator : IPartitionGenerator
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2013_2 };
    }

    public void Generate(DatabasePartitionBase p_Partition, RimeWriter p_ResourceWriter)
    {
        if (p_Partition is not DatabasePartition s_Partition)
            throw new ArgumentException("Cannot generate a partition resource from a partition created for a different engine type.", nameof(p_Partition));

        throw new NotImplementedException();
        // var s_Writer = new EbxWriter();
        // s_Writer.Serialize(p_ResourceWriter, s_Partition);
    }
}
