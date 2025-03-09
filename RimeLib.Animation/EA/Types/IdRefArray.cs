using RimeLib.Animation.EA.Resolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Types
{
    public class IdRefArray<T> : List<IdRef<T>>
        where T : AntObject
    {
        public void AddRef(AntGuid p_Ref, IAssetResolver? p_Resolver)
        {
            var s_Ref = new IdRef<T>();
            s_Ref.RefrenceId = p_Ref;
            s_Ref.Resolver = p_Resolver;

            Add(s_Ref);
        }
    }
}
