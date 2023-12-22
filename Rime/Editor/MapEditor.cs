using RimeLib.Content.Mounting;
using System;
using System.Collections.Generic;

namespace Rime.Editor
{
    internal class MapEditor
    {

        public List<dynamic> m_Instances = new List<dynamic>();

        private IEngineMounter m_Mounter;

        public MapEditor(IEngineMounter p_Mounter)
        {
            m_Mounter = p_Mounter;
        }

        public List<string> GetMountedLevels()
        {
            var s_AvailableBundles = m_Mounter.GetAvailableBundles();
            var s_MountedBundles = m_Mounter.GetMountedBundles();

            throw new NotImplementedException();
        }
    }
}
