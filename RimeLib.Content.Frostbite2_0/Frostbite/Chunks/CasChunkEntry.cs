using RimeLib.Content.Frostbite2_0.Frostbite.Cas;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2_0.Frostbite.Chunks
{
    class CasChunkEntry : ChunkEntry
    {
        public Sha1 Hash { get; set; }

        public Catalog ContainedCatalog { get; set; }

        public long PayloadSize => ContainedCatalog[Hash].FileSize;

        public CasChunkEntry(GUID p_Id, Sha1 p_Hash, Catalog p_Catalog) :
            base(p_Id)
        {
            Hash = p_Hash;
            ContainedCatalog = p_Catalog;
        }

        public override RimeReader GetReader()
        {
            var s_Reader = ContainedCatalog.ReadEntry(Hash);

            // If we're compressed, wrap in a Zlib reader.
            if (Compressed)
            {
                s_Reader = new ZlibRimeReader(s_Reader);

                // Wrap this inside a limited reader as well.
                s_Reader = new LimitedRimeReader(s_Reader, s_Reader.Length);
            }

            return s_Reader;
        }

        public override long GetSize()
        {
            if (!Compressed)
                return ContainedCatalog[Hash].FileSize;

            using var s_Reader = GetReader();
            return s_Reader.Length;
        }

        public override Sha1? GetSha1()
        {
            if (Compressed)
                return null;

            return Hash;
        }
    }
}
