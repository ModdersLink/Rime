using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization;

public static class PartitionRegistry
{
    private static readonly ConcurrentDictionary<GUID, DatabasePartitionBase> m_PartitionMap = new();
    public static IEnumerable<DatabasePartitionBase> Partitions => m_PartitionMap.Values;

    public delegate void PartitionRegisteredDelegate(DatabasePartitionBase p_Partition);
    public static event PartitionRegisteredDelegate? OnPartitionRegistered;

    public static void ParseAndRegisterAllPartitions(IEngineMounter p_Mounter)
    {
        var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(p_Mounter.GetEngineType());

        //// TODO: Make async instead.
        Parallel.ForEach(p_Mounter.GetPartitions(), (s_Kvp) =>
        {
            Task.Run(() =>
            {
                var (s_Name, s_PartitionObj) = s_Kvp;
                var s_Partition = s_Converter.FromPartitionObject(s_Name, s_PartitionObj.FirstVariant);
                RegisterPartition(s_Partition);
                if (OnPartitionRegistered != null)
                    OnPartitionRegistered(s_Partition);
            });

        });
    }

    public static void ClearRegisteredPartitions()
    {
        m_PartitionMap.Clear();
    }

    public static void RegisterPartition(DatabasePartitionBase p_Partition)
    {
        m_PartitionMap.AddOrUpdate(p_Partition.PartitionGuid, (_) => p_Partition, (_, _) => p_Partition);
    }

    public static bool TryGetPartition(GUID p_PartitionGuid, [NotNullWhen(true)] out DatabasePartitionBase? p_Partition)
    {
        return m_PartitionMap.TryGetValue(p_PartitionGuid, out p_Partition);
    }

    public static bool TryGetInstance(GUID p_PartitionGuid, DataContainerId p_Id, [NotNullWhen(true)] out DataContainerBase? p_Instance)
    {
        return p_Id switch
        {
            DataContainerId.Guid s_Id => TryGetInstance(p_PartitionGuid, s_Id.Id, out p_Instance),
            DataContainerId.Index s_Id => TryGetInstance(p_PartitionGuid, s_Id.Id, out p_Instance),
            _ => throw new Exception($"Unsupported data container id: {p_Id}")
        };
    }

    public static bool TryGetInstance(GUID p_PartitionGuid, GUID p_InstanceGuid, [NotNullWhen(true)] out DataContainerBase? p_Instance)
    {
        p_Instance = null;

        if (!m_PartitionMap.TryGetValue(p_PartitionGuid, out var s_Partition))
            return false;
        
        foreach (var s_Instance in s_Partition.Instances)
        {
            if (s_Instance.InstanceId is not DataContainerId.Guid s_InstanceId || s_InstanceId.Id != p_InstanceGuid) 
                continue;

            p_Instance = s_Instance;
            return true;
        }

        return false;
    }

    public static bool TryGetInstance(GUID p_PartitionGuid, long p_InstanceIndex, [NotNullWhen(true)] out DataContainerBase? p_Instance)
    {
        p_Instance = null;

        if (!m_PartitionMap.TryGetValue(p_PartitionGuid, out var s_Partition))
            return false;
        
        foreach (var s_Instance in s_Partition.Instances)
        {
            if (s_Instance.InstanceId is not DataContainerId.Index s_InstanceId || s_InstanceId.Id != p_InstanceIndex)
                continue;

            p_Instance = s_Instance;
            return true;
        }

        return false;
    }
}