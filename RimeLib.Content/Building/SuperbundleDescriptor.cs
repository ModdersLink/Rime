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

        internal SuperbundleDescriptor(string p_SbName)
        {
            SuperbundleName = p_SbName;

            Chunks = new Dictionary<GUID, IChunkObject>();
            Bundles = new Dictionary<string, BundleDescriptor>();
        }
    }
}
