using System;
using RimeLib.Content.Frostbite.Content;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Mounting
{
    public class ContentMounter
    {
        public ContentMounter(EngineType p_Engine)
        {
            throw new NotImplementedException();
        }

        /*public async Task<bool> Mount(string p_GamePath)
        {
            return false;
        }*/

        public RimeReader GetChunk(GUID p_GUID)
        {
            throw new NotImplementedException();
        }

        public FrostbiteResource GetResource(string p_Path)
        {
            throw new NotImplementedException();
        }

        public RimeReader GetPartition(string p_Path)
        {
            throw new NotImplementedException();
        }
    }
}
