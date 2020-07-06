using RimeLib.Serialization.Ebx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    class Fb2EbxWriter
    {
        private FrostbitePartition m_Partition;
        private string m_OutputPath;

        public Fb2EbxWriter(FrostbitePartition p_Partition, string p_Path, bool p_Overwrite = true)
        {
            m_Partition = p_Partition;

            if (File.Exists(p_Path) && p_Overwrite)
                File.Delete(p_Path);
            else
                throw new FileNotFoundException($"File: {p_Path} exists.");

            m_OutputPath = p_Path;
        }

        public bool Serialize(bool p_BigEndian = false)
        {
            // First we need to satisfy each dependency/field in the header
            var s_Header = new StreamingPartitionHeader
            {
                
            };

            // First we start at the primary instance and scale out
            var s_PrimaryInstance = m_Partition.PrimaryInstance;

            // TODO: Check to ensure that we have not already serialized this partition

            // TODO: Then we need to iterate through each of the imported partitions and serialize those
            // (recursively, dependency chain)

            // TODO: We need to serialize all instances, (and their referenced partitions)
            
            // TODO: Build each instance into a proper binary format

            // TODO: Serialize arrays, exports, import tables

            // TODO: Verify

            // TODO: Save file
            return true;
        }
    }
}
