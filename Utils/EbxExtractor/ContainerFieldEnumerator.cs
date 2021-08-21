using RimeLib.Frostbite.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EbxExtractor
{
    class ContainerFieldEnumerator
    {
        protected dynamic m_Container;

        public PropertyInfo[] m_ContainerProperties;

        public ContainerFieldEnumerator(FrostbiteContainer p_Container)
        {
            // Initialize the container field
            m_Container = p_Container;
        }
    }
}
