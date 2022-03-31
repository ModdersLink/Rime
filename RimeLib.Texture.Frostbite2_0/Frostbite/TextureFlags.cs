using System;

namespace RimeLib.Texture.Frostbite2_0.Frostbite;

[Flags]
public enum TextureFlags : ushort
{
    Streaming = 1 << 0,
    SrgbGamma = 1 << 1,
    CpuResource = 1 << 2,
    OnDemandLoaded = 1 << 3,
    Mutable = 1 << 4,
    NoSkipmip = 1 << 5,
    XenonPackedMipmaps = 1 << 8,
    Ps3MemoryCell = 1 << 8,
    Ps3MemoryRsx = 1 << 9,
    StreamingAlways = 1 << 10,
    SwizzledData = 1 << 11,
    UnknownFlag = 1 << 12,
}