using RimeLib.Content.Venice.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Content.Venice.Frostbite.Chunks
{
    public abstract class ChunkEntry : IReadableObjectWithHash
    {
        public class ChunkMetaPayload : DbObjectSerializable
        {
            [DbObjectField("firstMip")]
            public int? FirstMip { get; set; }
        }

        public class ChunkMeta : DbObjectSerializable
        {
            [DbObjectField("h32")]
            public int AssetNameHash { get; set; }
            
            [DbObjectField("meta")]
            public ChunkMetaPayload Payload { get; set; } = new ChunkMetaPayload();
        }

        public GUID Id { get; set; }
        public bool Compressed { get; }

        protected ChunkEntry(GUID p_Id)
        {
            Id = p_Id;
            Compressed = Id.HasCompressionFlag();
        }

        public abstract RimeReader GetReader();
        public abstract long GetSize();
        public abstract Sha1? GetSha1();
    }
}
