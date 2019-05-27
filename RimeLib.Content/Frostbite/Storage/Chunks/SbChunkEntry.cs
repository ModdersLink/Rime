using System;
using System.Collections.Generic;
using System.Text;
using RimeLib.Content.Frostbite.Storage.Sb;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite.Storage.Chunks
{
    class SbChunkEntry : ChunkEntry
    {
        public SbChunkEntry(GUID p_Id, long p_Offset, long p_Size, SuperbundleEntry p_ContainedSb) : 
            base(p_Id)
        {
        }

        public override RimeReader GetReader()
        {
            throw new NotImplementedException();
        }
    }
}
