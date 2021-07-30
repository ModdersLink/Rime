using RimeLib.Content.Mounting;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture
{
    public class TextureHelper
    {

        public static bool LoadTexture(IEngineMounter p_Mounter, IResourceVariant p_ResourceRefrence, out TextureBase? p_OutResource)
        {
            var s_Loader = TextureLoaderRegistry.FindLoader( p_Mounter.GetEngineType( ) );


            if (s_Loader == null)
            {
                p_OutResource = null;
                return false;
            }

            return s_Loader.Load(p_Mounter, p_ResourceRefrence, out p_OutResource);
        }
    }
}
