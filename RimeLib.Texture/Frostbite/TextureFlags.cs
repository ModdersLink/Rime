using System;

namespace RimeLib.Texture.Frostbite
{
    /// <summary>
    /// Texture flags
    /// </summary>
    [Flags]
    public enum TextureFlags : ushort
    {
        /// <summary>
        /// Texture is streaming
        /// </summary>
        Streaming = 0x1,

        /// <summary>
        /// Contains SRGB Gamma
        /// </summary>
        SrgbGamma = 0x2,

        /// <summary>
        /// CPU Resource
        /// </summary>
        CpuResource = 0x4,

        /// <summary>
        /// Loaded on demand
        /// </summary>
        OnDemandLoaded = 0x8,

        /// <summary>
        /// Mutable
        /// </summary>
        Mutable = 0x10,

        /// <summary>
        /// Do not skip mip maps
        /// </summary>
        NoSkipmip = 0x20,

        /// <summary>
        /// Xenon (Xbox 360) packed mip maps
        /// </summary>
        XenonPackedMipmaps = 0x100,

        /// <summary>
        /// Cell memory (PlayStation 3)
        /// </summary>
        Ps3MemoryCell = 0x100,

        /// <summary>
        /// Rsx memory (PlayStation 3)
        /// </summary>
        Ps3MemoryRsx = 0x200,

        /// <summary>
        /// Streaming Always
        /// </summary>
        StreamingAlways = 0x400,

        /// <summary>
        /// Swizzled Data
        /// </summary>
        SwizzledData = 0x800,


        /// <summary>
        /// UnknownFlag | Only seen on consoles
        /// </summary>
        UnknownFlag = 0x1000,

    }
}
