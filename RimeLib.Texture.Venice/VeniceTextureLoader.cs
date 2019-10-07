
using System;
using System.Collections.Generic;
using System.Text;

using RimeLib.Frostbite;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Resource;
using RimeLib.Content.Resource.Attributes;
using RimeLib.IO;
using RimeLib.Content.Mounting;

namespace RimeLib.Texture.Venice
{
    [ResourceLoader( ResourceType.DxTexture, EngineType.Frostbite2_0 )]
    public class VeniceTextureLoader : IResourceLoader
    {
        public VeniceTextureLoader( )
        {
        }

        public bool Load( IEngineMounter p_Mounter, RimeReader p_Reader, out IResource p_Resource )
        {
            p_Resource = new VeniceTexture( p_Reader );
            
            return true;
        }
    }
}
