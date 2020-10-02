using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;
using System;
using System.Diagnostics;

namespace RimeLib.Serialization
{
    public class Serialization
    {
        // The partition we are serializing
        private readonly FrostbitePartition m_Partition;

        /// <summary>
        /// Creates a new serialization instance
        /// </summary>
        /// <param name="p_Partition">Partition to serialize</param>
        public Serialization(FrostbitePartition p_Partition)
        {
            m_Partition = p_Partition;

            ParsePartition();
        }

        private void ParsePartition()
        {
            // Get the C# type for this partition container
            var s_ContainerType = m_Partition.GetType();
            if (s_ContainerType == null)
            {
                Debug.WriteLine($"Could not find container type for {m_Partition.Name}.");
                return;
            }

            // Iterate each "whole object"
            foreach (var s_PartitionInstance in m_Partition.Instances)
            {
                // Parse each instance
                ParseInstance(s_PartitionInstance);
            }
        }

        private void ParseInstance(DataContainer p_Instance)
        {
            var s_TypeDescriptor = p_Instance.GetTypeDescriptor();

            s_TypeDescriptor.LayoutDescriptor = 0;
        }
    }
}
