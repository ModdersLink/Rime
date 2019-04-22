using System.Collections.Generic;
using Chunk = RimeLib.Content.Frostbite.Bundles.Entries.Chunk;
using Dbx = RimeLib.Content.Frostbite.Bundles.Entries.Dbx;
using EBX = RimeLib.Content.Frostbite.Bundles.Entries.EBX;
using FrostbiteResource = RimeLib.Content.Frostbite.Content.FrostbiteResource;
using Resource = RimeLib.Content.Frostbite.Bundles.Entries.Resource;

namespace RimeLib.Content.Frostbite.Bundles
{
    /// <summary>
    /// Base class for a Frostbite bundle
    /// </summary>
    public abstract class BundleBase
    {
        /// <summary>
        /// List of ebx entries
        /// </summary>
        protected readonly List<EBX> m_EBX = new List<EBX>();

        /// <summary>
        /// List of ebx entries
        /// </summary>
        protected readonly List<Dbx> m_DBX = new List<Dbx>();

        /// <summary>
        /// List of resource entries
        /// </summary>
        protected readonly List<Resource> m_Resources = new List<Resource>();

        /// <summary>
        /// List of chunk entries
        /// </summary>
        protected readonly List<Chunk> m_Chunks = new List<Chunk>();

        /// <summary>
        /// Bundle entry
        /// </summary>
        public BundleEntry Entry { get; set; }

        /// <summary>
        /// Bundle path
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Chunk entires within this bundle
        /// </summary>
        public Chunk[] ChunkEntries => m_Chunks.ToArray();

        /// <summary>
        /// Ebx entries within this bundle
        /// </summary>
        public EBX[] PartitionEntries => m_EBX.ToArray();

        /// <summary>
        /// Dbx Entries within this bundle, these were deprecated in Frostbite 2 and no longer used.
        /// </summary>
        public Dbx[] DbxEntries => m_DBX.ToArray();

        /// <summary>
        /// Resources in this bundle
        /// </summary>
        public Resource[] ResourceEntries => m_Resources.ToArray();
        
        public List<FrostbiteResource> Resources { get; set; }

        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>Path or the default ToString.</returns>
        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(Path) ? base.ToString() : Path;
        }
    }
}
