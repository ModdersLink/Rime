
using System;
using System.Collections.Generic;
using System.Text;

using RimeLib.Frostbite;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Resource;
using RimeLib.Content.Resource.Attributes;
using RimeLib.IO;
using RimeLib.Content.Mounting;
using System.Diagnostics;

namespace RimeLib.Texture.Venice
{
    [ResourceLoader( ResourceType.DxTexture, EngineType.Frostbite2_0 )]
    public class FB2TextureLoader : IResourceLoader
    {
        public FB2TextureLoader( )
        {
        }

        public bool Load( IEngineMounter p_Mounter, RimeReader p_Reader, long p_Size, out IResource p_Resource )
        {

            Debug.WriteLine( p_Reader.Endianness );

            p_Resource = null;

            try
            {

                p_Resource = new FB2Texture( p_Mounter, p_Reader );
                return true;
            }
            catch
            {
            }
            
            return p_Resource != null;
        }
    }
}
