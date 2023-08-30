using RimeLib.Ant.EA.Resolver;
using RimeLib.Ant.EA.Types;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.Frostbite.Resolver
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
            if (p_Object.InstanceId.IsStaticRefrence)
            {
                StaticObjects.TryAdd(p_Object.InstanceId.StaticRefrence, p_Object);
                return;
            }


            BundleObjects.TryAdd(p_Object.InstanceId.RefrenceIndex, p_Object);
        }

        public AntObject? ResolveObject(AntGuid p_Guid)
        {
            if (p_Guid.IsStaticRefrence)
            {
                if (StaticObjects.TryGetValue(p_Guid.StaticRefrence, out var s_StaticObject))
                    return s_StaticObject;

                return null;
            }

            if (BundleObjects.TryGetValue(p_Guid.RefrenceIndex, out var s_BundleObject))
                return s_BundleObject;

            return null;
        }
    }
}
