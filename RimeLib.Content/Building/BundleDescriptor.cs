using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Building
{
    /// <summary>
    /// Rime descriptor for bundles
    /// </summary>
    public class BundleDescriptor
    {
        /// <summary>
        /// Bundle name
        /// </summary>
        public string BundleName { get; }

        /// <summary>
        /// Resources
        /// </summary>
        public Dictionary<string, IResourceObject> Resources { get; }

        /// <summary>
        /// Chunks
        /// </summary>
        public Dictionary<GUID, IChunkObject> Chunks { get; }

        /// <summary>
        /// Ebx Partitions
        /// </summary>
        public Dictionary<string, IReadableObject> Partitions { get; }

        /// <summary>
        /// Constructor for creating a new bundle
        /// </summary>
        /// <param name="p_BundleName">Bundle name</param>
        internal BundleDescriptor(string p_BundleName)
        {
            BundleName = p_BundleName;

            Resources = new Dictionary<string, IResourceObject>();
            Chunks = new Dictionary<GUID, IChunkObject>();
            Partitions = new Dictionary<string, IReadableObject>();
        }
    }
}
