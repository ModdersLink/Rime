using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Content.Venice.Frostbite.Chunks
{
    public abstract class ChunkEntry : IReadableObject
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

        protected ChunkEntry(GUID p_Id)
        {
            Id = p_Id;
        }

        public abstract RimeReader GetReader();
    }
}
