using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Types
{
    public class IdRef<T> 
        : IdRefBase
        where T : AntObject
    {

        public T? Object => Resolver?.ResolveObject(RefrenceId) as T;
    }
}
