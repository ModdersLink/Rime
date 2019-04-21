using System;
using System.Collections.Generic;
using RimeLib.Frostbite.Bundles.Entries;
using RimeLib.Frostbite.Content;

namespace RimeLib.Frostbite.Bundles
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
        public String Path { get; set; }

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
