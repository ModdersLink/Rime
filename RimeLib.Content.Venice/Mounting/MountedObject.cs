using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Content.Venice.Mounting
{
    internal class MountedObject : IMountedObject
    {
        protected readonly IReadableObject m_Readable;
        protected readonly HashSet<string> m_ContainedBundles = new HashSet<string>();
        protected readonly HashSet<string> m_ContainedSuperbundles = new HashSet<string>();

        public MountedObject(IReadableObject p_Readable)
        {
            m_Readable = p_Readable;
        }

        public RimeReader GetReader()
        {
            return m_Readable.GetReader();
        }

        public IEnumerable<string> GetContainedBundles()
        {
            return m_ContainedBundles;
        }

        public IEnumerable<string> GetContainedSuperbundles()
        {
            return m_ContainedSuperbundles;
        }

        public void AddToBundle(string p_Bundle)
        {
            m_ContainedBundles.Add(p_Bundle.ToLowerInvariant());
        }

        public void RemoveFromBundle(string p_Bundle)
        {
            m_ContainedBundles.Remove(p_Bundle);
        }

        public void AddToSuperbundle(string p_Superbundle)
        {
            m_ContainedSuperbundles.Add(p_Superbundle.ToLowerInvariant());
        }

        public void RemoveFromSuperbundle(string p_Superbundle)
        {
            m_ContainedSuperbundles.Remove(p_Superbundle);
        }
    }
}
