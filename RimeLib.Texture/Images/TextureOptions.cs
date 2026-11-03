using System;

namespace RimeLib.Texture.Images;

/// <summary>How the engine loads and samples a texture: the platform-independent texture flags.</summary>
[Flags]
public enum TextureOptions
{
    None = 0,
    Streaming = 1 << 0,
    SrgbGamma = 1 << 1,
    CpuResource = 1 << 2,
    OnDemandLoaded = 1 << 3,
    Mutable = 1 << 4,
    NoSkipMip = 1 << 5,
    StreamingAlways = 1 << 10,
}
