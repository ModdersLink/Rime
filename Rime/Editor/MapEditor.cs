using fb;
using Rime.Utils;
using RimeLib.Content.Mounting;
using RimeLib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rime.Editor
{
    internal class MapEditor
    {
        
        public List<dynamic> m_Instances = new List<dynamic>();

        private IEngineMounter m_Mounter;
        private Logger m_Logger;

        public MapEditor(IEngineMounter p_Mounter, Logger p_Logger)
        {
            m_Mounter = p_Mounter;
            m_Logger = p_Logger;

            PartitionRegistry.ParseAndRegisterAllPartitions(p_Mounter);

            var s_MountedLevels = GetMountedLevels();
        }

        public List<string> GetMountedLevels()
        {
            var s_LevelDataPartitions = PartitionRegistry.Partitions.Where(p_Partition => p_Partition.PrimaryInstance is LevelData);

            return s_LevelDataPartitions.Select(p_Partition => p_Partition.Name).ToList();
        }
    }
}
