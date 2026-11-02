using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2_0.Mounting
{
    /// <summary>Chunk meta (h32, then meta with firstMip), laid out the same in Frostbite 2 and 2013.2.</summary>
    public class ChunkMetaWriter : IChunkMetaWriter
    {
        public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0, EngineType.Frostbite2013_2 };

        public DbObject Create(int? p_AssetNameHash, int? p_FirstMip)
        {
            var s_Entry = new ChunkEntry.ChunkMetaEntry();
            if (p_AssetNameHash.HasValue)
                s_Entry.AssetNameHash = p_AssetNameHash.Value;
            s_Entry.Payload.FirstMip = p_FirstMip;
            return DbObjectConverter.ToDbObject(s_Entry);
        }
    }
}
