using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Mesh.Frostbite.Fb2
{
    [Flags]
    public enum MeshSubsetCategoryFlags
    {
        Opaque = 0x1,
        Transparent = 0x2,
        TransparentDecal = 0x4,
        ZOnly = 0x8,
        DynamicEnvmap = 0x10,
        PlanarReflection = 0x20,
        Normal = 0x7,
        All = 0x3F
    }
}
