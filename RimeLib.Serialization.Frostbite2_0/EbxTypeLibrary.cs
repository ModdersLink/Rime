using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using fb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Conversion;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace RimeLib.Serialization.Frostbite2_0;

public class EbxTypeLibrary : IEbxTypeLibrary
{
    private static readonly Lazy<FrozenDictionary<string, Type>> s_Types = new(() =>
        typeof(DataContainer).Assembly.GetTypes()
            .Where(p_Type => p_Type.GetCustomAttribute<ContainerTypeAttribute>() != null)
            .ToFrozenDictionary(p_Type => p_Type.Name, StringComparer.Ordinal));

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public Type? FindType(string p_Name) => s_Types.Value.GetValueOrDefault(p_Name);

    public DatabasePartitionBase CreatePartition(string p_Name, GUID p_PartitionGuid, GUID p_PrimaryInstanceGuid, IReadOnlyList<DataContainerBase> p_Instances)
    {
        var s_Partition = new DatabasePartition { Name = p_Name, PartitionGuid = p_PartitionGuid, PrimaryInstanceGuid = p_PrimaryInstanceGuid };
        foreach (var s_Instance in p_Instances)
        {
            if (s_Instance is not DataContainer s_Container || s_Instance.InstanceId is not DataContainerId.Guid s_Id)
                throw new InvalidDataException($"a {s_Instance.GetType().Name} that is not a Frostbite 2 container with a GUID");

            s_Container.Partition = s_Partition;
            s_Partition.InstanceMap.Add(s_Id.Id, s_Container);
        }

        if (!s_Partition.InstanceMap.ContainsKey(p_PrimaryInstanceGuid))
            throw new InvalidDataException($"a primary instance {p_PrimaryInstanceGuid} the partition does not hold");
        return s_Partition;
    }
}
