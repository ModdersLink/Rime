using System;
using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Building
{
    public class SuperbundleDescriptor
    {
        public string SuperbundleName { get; }

        // Cas builds only. Answers whether the player's own catalog already holds the payload frame
        // with this sha1, which lets the serializer emit an embedded noncas source as a bare ref
        // instead of an inline copy. Left null, nothing is assumed to be catalog-backed.
        public Func<Sha1, bool>? CatalogProbe { get; set; }

        public Dictionary<GUID, IChunkObject> Chunks { get; }

        // Emitted in the toc chunk list as bare id and sha1 refs, with no payload in the superbundle.
        // This is how a vanilla cas superbundle carries its streaming chunks, such as the terrain, and
        // a level superbundle override that lacks them hangs the game while it loads the terrain.
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
