using System;
using RimeLib.Content.Venice.Frostbite.Sb;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Venice.Frostbite.Chunks
{
    class SbChunkEntry : ChunkEntry
    {
        public SbChunkEntry(GUID p_Id, long p_Offset, long p_Size, SuperbundleEntry p_ContainedSb) : 
            base(p_Id)
        {
            // TODO
        }

        public override RimeReader GetReader()
        {
            throw new NotImplementedException();
        }
    }
}
