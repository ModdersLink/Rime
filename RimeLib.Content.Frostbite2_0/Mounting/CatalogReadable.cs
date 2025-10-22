using RimeLib.Content.Frostbite2_0.Frostbite.Cas;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2_0.Mounting
{
    internal class CatalogReadable : IReadableObjectWithHash
    {
        protected Catalog m_Catalog;
        protected Sha1 m_Hash;
        protected bool m_Compressed;
        protected long m_CompressedSize;
        protected Sha1? m_CompressedHash;

        public CatalogReadable(Catalog p_Catalog, Sha1 p_Hash, bool p_Compressed)
        {
            m_Catalog = p_Catalog;
            m_Hash = p_Hash;
            m_Compressed = p_Compressed;
            
            // TODO: Remove this hack once we have from scratch building working
            if (m_Catalog.ContainsEntry(m_Hash))
            {
                m_CompressedSize = m_Catalog[m_Hash].FileSize;
                m_CompressedHash = m_Hash;
            }
            else if (m_Catalog.AuthoritativeCatalog is not null && m_Catalog.AuthoritativeCatalog.ContainsEntry(m_Hash))
            {
                m_CompressedSize = m_Catalog.AuthoritativeCatalog[m_Hash].FileSize;
                m_CompressedHash = m_Hash;
            }
        }

        public RimeReader GetReader()
        {
            var s_Reader = m_Catalog.ReadEntry(m_Hash);

            // If we're compressed, wrap in a Zlib reader.
            if (m_Compressed)
            {
                s_Reader = new ZlibRimeReader(s_Reader);

                // Wrap this inside a limited reader as well.
                s_Reader = new LimitedRimeReader(s_Reader, s_Reader.Length);;
            }

            return s_Reader;
        }

        public long GetCompressedSize()
        {
            return m_CompressedSize;
        }

        public Sha1? GetCompressedHash()
        {
            return m_CompressedHash;
        }

        public long GetSize()
        {
            if (!m_Compressed)
                return m_Catalog[m_Hash].FileSize;

            using var s_Reader = GetReader();
            return s_Reader.Length;
        }

        public Sha1? GetSha1()
        {
            if (m_Compressed)
                return null;

            return m_Hash;
        }
    }
}
