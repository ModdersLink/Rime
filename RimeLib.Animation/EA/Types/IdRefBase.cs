using RimeLib.Animation.EA.Resolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Types
{
    public abstract class IdRefBase
    {
        public IAssetResolver? Resolver { get; set; } = null;

        public AntGuid ReferenceId { get; set; } = new();

        // TODO: add assetbank reference??

        public bool IsNullRef => ReferenceId == AntGuid.c_NullGuid;

#if DEBUG
        protected AntObject? ResolvedObject => Resolver?.ResolveObject(ReferenceId);
#endif
    }
}
