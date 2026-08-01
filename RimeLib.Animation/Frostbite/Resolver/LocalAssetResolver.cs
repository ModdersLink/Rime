using System.Collections.Concurrent;
using RimeLib.Animation.EA.Resolver;
using RimeLib.Animation.EA.Types;

namespace RimeLib.Animation.Frostbite.Resolver
{
    /// <summary>
    /// Per-bank variant of <see cref="AssetResolver"/>, with the same static and bundle reference
    /// semantics but instance-level maps, so several banks load side by side without their reference
    /// indices colliding. AssetResolver.Instance keeps its maps on the class, where the first
    /// registration wins and two banks cross-contaminate each other's resolution.
    /// </summary>
    public class LocalAssetResolver
        : IAssetResolver
    {
        public ConcurrentDictionary<uint, AntObject> StaticObjects { get; } = new();
        public ConcurrentDictionary<uint, AntObject> BundleObjects { get; } = new();

        public void RegisterObject(AntObject p_Object)
        {
            if (p_Object.InstanceId.IsStaticReference)
            {
                StaticObjects.TryAdd(p_Object.InstanceId.StaticReference, p_Object);
                return;
            }

            BundleObjects.TryAdd(p_Object.InstanceId.ReferenceIndex, p_Object);
        }

        public AntObject? ResolveObject(AntGuid p_Guid)
        {
            if (p_Guid.IsStaticReference)
                return StaticObjects.TryGetValue(p_Guid.StaticReference, out var s_Static) ? s_Static : null;

            return BundleObjects.TryGetValue(p_Guid.ReferenceIndex, out var s_Bundle) ? s_Bundle : null;
        }
    }
}
