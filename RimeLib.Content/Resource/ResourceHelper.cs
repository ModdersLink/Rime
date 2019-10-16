using RimeLib.Content.Mounting;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Content.Resource
{
    public class ResourceHelper
    {

        public static bool LoadResource(IEngineMounter p_Mounter, IResourceVariant p_ResourceRefrence, out IResource? p_OutResource)
        {
            var s_Loader = ResourceLoaderRegistry.FindLoader( p_ResourceRefrence.GetResourceType( ), p_Mounter.GetSupportedEngine( ) );


            if (s_Loader == null)
            {
                p_OutResource = null;
                return false;
            }

            using (var s_Reader = new RimeReader(p_ResourceRefrence.GetReader()))
                return s_Loader.Load(p_Mounter, s_Reader, p_ResourceRefrence.GetSize(), out p_OutResource);
        }
    }
}
