using RimeLib.Ant.EA.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Resolver
{
    public interface IAssetResolver
    {

        void RegisterObject(AntObject p_Object);

        AntObject? ResolveObject(AntGuid p_Guid);
    }
}
