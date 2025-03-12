using RimeLib.Animation.EA.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Resolver
{
    public interface IAssetResolver
    {

        void RegisterObject(AntObject p_Object);

        AntObject? ResolveObject(AntGuid p_Guid);
    }
}
