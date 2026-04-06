using RimeLib.Content.Mounting;

namespace RimeLib.Havok
{
    public interface IHavokConverter : IEngineInterface
    {
        IEnumerable<hkpTransform> GetTransforms(IResourceObject p_Resource, IEngineMounter p_Mounter);
    }
}
