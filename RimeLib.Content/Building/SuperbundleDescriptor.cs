using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Building
{
    public class SuperbundleDescriptor
    {
        public string SuperbundleName { get; }

        public Dictionary<GUID, IChunkObject> Chunks { get; }

        public Dictionary<string, BundleDescriptor> Bundles { get; }

        public bool Cas { get; }

        internal SuperbundleDescriptor(string p_SbName, bool p_Cas = false)
        {
            SuperbundleName = p_SbName;

            Chunks = new Dictionary<GUID, IChunkObject>();
            Bundles = new Dictionary<string, BundleDescriptor>();
            Cas = p_Cas;
        }
    }
}
