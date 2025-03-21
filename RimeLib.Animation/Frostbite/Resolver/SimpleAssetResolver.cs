using RimeLib.Animation.EA.Resolver;
using RimeLib.Animation.EA.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.Frostbite.Resolver
{
    public class SimpleAssetResolver
        : IAssetResolver
    {

        public Dictionary<uint, AntObject> ObjectMap = new();

        public void RegisterObject(AntObject p_Object)
        {
            ObjectMap.Add(p_Object.InstanceId.SimpleReferenceIndex, p_Object);
        }

        public AntObject? ResolveObject(AntGuid p_Guid)
        {
            if (ObjectMap.TryGetValue(p_Guid.SimpleReferenceIndex, out var s_Object))
                return s_Object;

            return null;
        }

    }
}
