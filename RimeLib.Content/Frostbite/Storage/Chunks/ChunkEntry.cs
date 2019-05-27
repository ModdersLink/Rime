using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite.Storage.Chunks
{
    public abstract class ChunkEntry
    {
        public GUID Id { get; set; }

        protected ChunkEntry(GUID p_Id)
        {
            Id = p_Id;
        }

        public abstract RimeReader GetReader();
    }
}
