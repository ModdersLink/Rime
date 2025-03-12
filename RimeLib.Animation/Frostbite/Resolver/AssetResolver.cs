using RimeLib.Animation.EA.Resolver;
using RimeLib.Animation.EA.Types;
using System;
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


#if DEBUG
        public static SortedDictionary<uint, AntObject> StaticObjects { get; set; } = new();
        public static SortedDictionary<uint, AntObject> BundleObjects { get; set; } = new();

#else
        public static Dictionary<uint, AntObject> StaticObjects { get; set; } = new();
        public static Dictionary<uint, AntObject> BundleObjects { get; set; } = new();
#endif

        public void RegisterObject(AntObject p_Object)
        {
            if (p_Object.InstanceId.IsStaticRefrence)
            {
                StaticObjects.Add(p_Object.InstanceId.StaticRefrence, p_Object);
                return;
            }


            BundleObjects.Add(p_Object.InstanceId.RefrenceIndex, p_Object);
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
