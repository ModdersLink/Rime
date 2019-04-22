using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Frostbite.Bundles.Entries
{
    /// <summary>
    /// Base class for a Entry within a bundle
    /// </summary>
    public abstract class EntryBase
    {
        /// <summary>
        /// Hash of the entry
        /// </summary>
        public Sha1 Hash { get; set; }

        /// <summary>
        /// Size of the entry
        /// </summary>
        public virtual long Size => m_Data?.Length ?? m_DataSize;

        /// <summary>
        /// Is this entry compressed
        /// </summary>
        public virtual bool Compressed => m_Compressed;

        /// <summary>
        /// Internal storage for the actual entry data
        /// </summary>
        protected byte[] m_Data;

        /// <summary>
        /// Internal data offset
        /// </summary>
        protected long m_DataOffset;

        /// <summary>
        /// Internal data size
        /// </summary>
        protected long m_DataSize;

        /// <summary>
        /// Internal is the entry compressed
        /// </summary>
        protected bool m_Compressed;

        /// <summary>
        /// Internal Bundle that contains this entry
        /// </summary>
        protected BundleBase m_ContainedBundle;

        /// <summary>
        /// Entry's data offset
        /// </summary>
        public long DataOffset => m_DataOffset;

        /// <summary>
        /// Entry's data size
        /// </summary>
        public long DataSize => m_DataSize;

        /// <summary>
        /// Bundle that contains this entry
        /// </summary>
        public BundleBase ContainedBundle => m_ContainedBundle;

        /// <summary>
        /// Default constructor
        /// </summary>
        protected EntryBase()
        {
            m_ContainedBundle = null;
            m_Data = null;
            m_DataOffset = 0;
            m_DataSize = 0;
            m_Compressed = false;
        }

        /// <summary>
        /// Reads the data for this entry if available
        /// </summary>
        /// <returns>Data of the entry, or null if the entry needs to be retrieved from sb/bundle/cas</returns>
        public virtual byte[] Read()
        {
            return m_Data;
        }

        /// <summary>
        /// Decodes entry data, function does nothing
        /// </summary>
        /// <param name="p_Data">Data to decode</param>
        /// <returns>Inputted data</returns>
        public virtual byte[] Decode(byte[] p_Data)
        {
            return p_Data;
        }
    }
}
