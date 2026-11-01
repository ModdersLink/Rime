using System;

namespace RimeLib.Terrain.Frostbite;

/// <summary>The bits of <see cref="RasterTreeNode.Flags"/>.</summary>
[Flags]
public enum RasterTreeNodeFlags : ushort
{
    LockedForUnload = 1,
    LockedForLoad = 2,
    LockedPersistent = 4,
    Disabled = 8,
    CanBeStreamedIn = 16,
    StreamedIn = 32,
    SecondLodCanBeStreamedIn = 64,
    SecondLodStreamedIn = 128,
    Pruned = 256,
}
