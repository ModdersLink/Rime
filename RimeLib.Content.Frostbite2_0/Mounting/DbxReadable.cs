using RimeLib.Content.Frostbite2_0.Frostbite.Bundles;
using RimeLib.Content.Frostbite2_0.Frostbite.Cas;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2_0.Mounting
{
    /// <summary>
    /// A cas bundle's dbx entry. The game's catalogs do not hold the dbx blobs, so this keeps the
    /// entry itself, which a cas build copies as the game's bundle lists it.
    /// </summary>
    internal class DbxReadable : IReadableObjectWithHash
    {
        private readonly Catalog? m_Catalog;

        public CasBundle.Dbx Entry { get; }

        public DbxReadable(CasBundle.Dbx p_Entry, Catalog? p_Catalog)
        {
            Entry = p_Entry;
            m_Catalog = p_Catalog;
        }

        public RimeReader GetReader()
        {
            if (Entry.InlineData != null)
                return new InlineReadable(Entry.InlineData, Entry.Hash, Entry.OriginalSize != Entry.Size).GetReader();
            if (m_Catalog == null || !m_Catalog.ContainsEntry(Entry.Hash))
                throw new System.IO.FileNotFoundException($"The dbx '{Entry.Name}' is not in the game's catalogs.");
            return new CatalogReadable(m_Catalog, Entry.Hash, Entry.OriginalSize != Entry.Size).GetReader();
        }

        public long GetSize() => Entry.OriginalSize ?? Entry.Size;

        public Sha1? GetSha1() => Entry.Hash;
    }
}
