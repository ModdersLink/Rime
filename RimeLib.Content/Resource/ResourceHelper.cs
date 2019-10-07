using RimeLib.Content.Mounting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Content.Resource
{
    public class ResourceHelper
    {

        public static bool LoadResource( IEngineMounter p_Mounter, IResourceVariant p_ResourceRefrence, out IResource? p_OutResource )
        {
            var s_Loader = ResourceLoaderRegistry.FindLoader( p_ResourceRefrence.GetResourceType( ), p_Mounter.GetSupportedEngine( ) );


            if ( s_Loader == null )
            {
                p_OutResource = null;
                return false;
            }
            
            return s_Loader.Load( p_Mounter, p_ResourceRefrence.GetReader( ), out p_OutResource );
        }
    }
}
