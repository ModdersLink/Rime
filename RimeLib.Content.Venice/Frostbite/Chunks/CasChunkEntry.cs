using RimeLib.Content.Venice.Frostbite.Cas;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Venice.Frostbite.Chunks
{
    class CasChunkEntry : ChunkEntry
    {
        public Sha1 Hash { get; set; }

        public Catalog ContainedCatalog { get; set; }

        public CasChunkEntry(GUID p_Id, Sha1 p_Hash, Catalog p_Catalog) : 
            base(p_Id)
        {
            Hash = p_Hash;
            ContainedCatalog = p_Catalog;
        }

        public override RimeReader GetReader()
        {
            return ContainedCatalog.ReadEntry(Hash);
        }

        public override long GetSize()
        {
            return ContainedCatalog[Hash].FileSize;
        }
    }
}
