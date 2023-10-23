using RimeLib.Ant.EA.Resolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Types
{
    public abstract class IdRefBase
    {
        public IAssetResolver? Resolver { get; set; } = null;

        public AntGuid RefrenceId { get; set; } = new();

        // TODO: add assetbank refrence??

        public bool IsNullRef => RefrenceId == AntGuid.c_NullGuid;

#if DEBUG
        protected AntObject? ResolvedObject => Resolver?.ResolveObject(RefrenceId);
#endif
    }
}
