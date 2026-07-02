using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Building
{
    public class SuperbundleDescriptor
    {
        public string SuperbundleName { get; }

        public Dictionary<GUID, IChunkObject> Chunks { get; }

        // CAS toc chunks: emitted in the toc chunk list as { id, sha1 } refs (NO payload in the sb).
        // This is how vanilla CAS superbundles carry their sb-level streaming chunks (terrain etc.) —
        // needed to build a complete level-sb override (a clone missing these hangs 'Loading terrain').
        public Dictionary<GUID, Sha1> CasTocChunks { get; }

        public Dictionary<string, BundleDescriptor> Bundles { get; }

        public bool Cas { get; }

        internal SuperbundleDescriptor(string p_SbName, bool p_Cas = false)
        {
            SuperbundleName = p_SbName;

            Chunks = new Dictionary<GUID, IChunkObject>();
            CasTocChunks = new Dictionary<GUID, Sha1>();
            Bundles = new Dictionary<string, BundleDescriptor>();
            Cas = p_Cas;
        }
    }
}
