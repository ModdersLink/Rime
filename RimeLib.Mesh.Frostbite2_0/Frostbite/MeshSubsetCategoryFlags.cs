using System;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite
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
