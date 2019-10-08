using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Building
{
    public class BundleDescriptor
    {
        public string BundleName { get; }

        public Dictionary<string, IResourceObject> Resources { get; }

        public Dictionary<GUID, IChunkObject> Chunks { get; }

        public Dictionary<string, IReadableObject> Partitions { get; }

        internal BundleDescriptor(string p_BundleName)
        {
            BundleName = p_BundleName;

            Resources = new Dictionary<string, IResourceObject>();
            Chunks = new Dictionary<GUID, IChunkObject>();
            Partitions = new Dictionary<string, IReadableObject>();
        }
    }
}
