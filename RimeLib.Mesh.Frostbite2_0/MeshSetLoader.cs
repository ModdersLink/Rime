using RimeLib.Content.Mounting;
using RimeLib.Mesh.Frostbite;
using System;

namespace RimeLib.Mesh.Frostbite2_0
{
    public class MeshSetLoader
    {
        MeshSetLayout m_Layout;

        public MeshSetLoader(IResourceVariant p_Resource, IEngineMounter p_Mounter)
        {
            if (p_Mounter.GetEngineType() != RimeLib.Frostbite.EngineType.Frostbite2_0)
                return;

            using var s_Reader = p_Resource.GetReader();

            m_Layout = new MeshSetLayout(s_Reader);
        }
    }
}
