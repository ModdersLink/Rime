using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RimeLib.Serialization
{
    /// <summary>
    /// Rime's central PartitionRegistry that contains all loaded FrostbitePartitions
    /// </summary>
    public static class PartitionRegistry
    {
        private static readonly ConcurrentDictionary<GUID, FrostbitePartition> m_Partitions;

        /// <summary>
        /// All partitions that are loaded
        /// </summary>
        public static IEnumerable<FrostbitePartition> Partitions => m_Partitions.Values;

        static PartitionRegistry()
        {
            m_Partitions = new ConcurrentDictionary<GUID, FrostbitePartition>();
        }

        /// <summary>
        /// Adds a partition to the registry
        /// </summary>
        /// <param name="p_Partition">Partition to add, or update partition to the registry</param>
        public static void RegisterPartition(FrostbitePartition p_Partition)
        {
            m_Partitions.AddOrUpdate(p_Partition.PartitionGuid, p_Partition, (p_K, p_V) => p_Partition);
        }

        /// <summary>
        /// Remove a partition from the registry
        /// </summary>
        /// <param name="p_Partition">Partition to remove</param>
        /// <returns>True on success, false otherwise</returns>
        public static bool RemovePartition(FrostbitePartition p_Partition)
        {
            return RemovePartition(p_Partition.PartitionGuid);
        }

        /// <summary>
        /// Remove partition by guid
        /// </summary>
        /// <param name="p_Guid">Partition ID to remove</param>
        /// <returns>True on success, false otherwise</returns>
        public static bool RemovePartition(GUID p_Guid)
        {
            FrostbitePartition s_Partition;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            return m_Partitions.TryRemove(p_Guid, out s_Partition);
#pragma warning restore IDE0059 // Unnecessary assignment of a value
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }

        /// <summary>
        /// Removes all partitions from the registry
        /// </summary>
        /// <returns>True</returns>
        public static bool RemoveAllPartitions()
        {
            m_Partitions.Clear();
            return true;
        }

        /// <summary>
        /// Finds a partition based on guid
        /// </summary>
        /// <param name="p_Guid">Id to look up</param>
        /// <returns>Partition or null</returns>
        public static FrostbitePartition? LookupPartition(GUID p_Guid)
        {
            FrostbitePartition? s_Partition;

            if (!m_Partitions.TryGetValue(p_Guid, out s_Partition))
                return null;

            return s_Partition;
        }

        /// <summary>
        /// Looks up a partition based on name
        /// </summary>
        /// <param name="p_Path">Name of the partition</param>
        /// <returns>Partition, or null if not found</returns>
        public static FrostbitePartition? LookupPartition(string p_Path)
        {
            var s_Path = p_Path.ToLower();
            return m_Partitions.Values.FirstOrDefault(p_Partition => p_Partition.Name.ToLower() == s_Path);
        }

        /// <summary>
        /// Gets a partition container via CtrRef
        /// </summary>
        /// <param name="p_Reference">Reference to get</param>
        /// <returns>DataContainer on success, null otherwise</returns>
        public static DataContainer? GetPartitionContainer(CtrRefBase p_Reference)
        {
            var l_Partition = LookupPartition(p_Reference.PartitionGuid);

            return l_Partition?.LookupContainer(p_Reference.InstanceGuid);
        }
    }
}
