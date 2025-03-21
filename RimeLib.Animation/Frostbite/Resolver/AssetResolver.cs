using RimeLib.Animation.EA.Resolver;
using RimeLib.Animation.EA.Types;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.Frostbite.Resolver
{
    public class AssetResolver
        : IAssetResolver
    {
        protected static AssetResolver? _instance = null;
        public static AssetResolver Instance => _instance ??= new AssetResolver();


        public static ConcurrentDictionary<uint, AntObject> StaticObjects { get; set; } = new();
        public static ConcurrentDictionary<uint, AntObject> BundleObjects { get; set; } = new();

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
            {
                if (StaticObjects.TryGetValue(p_Guid.StaticReference, out var s_StaticObject))
                    return s_StaticObject;

                return null;
            }

            if (BundleObjects.TryGetValue(p_Guid.ReferenceIndex, out var s_BundleObject))
                return s_BundleObject;

            return null;
        }
    }
}
