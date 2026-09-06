using RimeLib.Content.Mounting;

namespace RimeLib.Havok
{
    public interface IHavokConverter : IEngineInterface
    {
        IEnumerable<hkpTransform> GetTransforms(IResourceObject p_Resource, IEngineMounter p_Mounter);

        /// <summary>
        /// Every collision shape in the resource. Writing collision already worked; without this the
        /// game's own collision could be carried but never edited.
        /// </summary>
        IEnumerable<hkpCollisionShape> GetShapes(IResourceObject p_Resource, IEngineMounter p_Mounter);

        /// <summary>
        /// The Frostbite part metadata around the packfiles. Without it a rebuild cannot be
        /// byte-identical: the shapes are only half the file.
        /// </summary>
        hkpPhysicsWrapper GetWrapper(IResourceObject p_Resource, IEngineMounter p_Mounter);
    }
}
