using RimeLib.Content.Venice.Frostbite.Cas;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Venice.Mounting
{
    internal class CatalogReadable : IReadableObjectWithHash
    {
        protected Catalog m_Catalog;
        protected Sha1 m_Hash;
        protected bool m_Compressed;

        public CatalogReadable(Catalog p_Catalog, Sha1 p_Hash, bool p_Compressed)
        {
            m_Catalog = p_Catalog;
            m_Hash = p_Hash;
            m_Compressed = p_Compressed;
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
