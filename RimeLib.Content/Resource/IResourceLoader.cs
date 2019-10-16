using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Content.Resource
{
    public interface IResourceLoader
    {
        bool Load(IEngineMounter p_Mounter, RimeReader p_Reader, long p_Size, out IResource p_Resource);
    }
}
