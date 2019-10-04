using RimeLib.Content.Venice.Frostbite.Cas;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Venice.Mounting
{
    internal class CatalogReadable : IReadableObject
    {
        protected Catalog m_Catalog;
        protected Sha1 m_Hash;

        public CatalogReadable(Catalog p_Catalog, Sha1 p_Hash)
        {
            m_Catalog = p_Catalog;
            m_Hash = p_Hash;
        }

        public RimeReader GetReader()
        {
            return m_Catalog.ReadEntry(m_Hash);
        }
    }
}
