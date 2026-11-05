using RimeLib.Frostbite;

namespace RimeLib.Texture
{
    /// <summary>Makes a texture stream its top mips, so only the mips from a given one stay resident.</summary>
    public interface ITextureMipCap : IEngineInterface
    {
        /// <summary>The number of header bytes a texture resource starts with.</summary>
        int HeaderSize { get; }

        /// <summary>
        /// The texture header with streaming set and the first resident mip raised to
        /// <paramref name="p_FirstMip"/>, and a line saying what changed. Throws when the texture has
        /// no such mip.
        /// </summary>
        byte[] CapResidentMips(byte[] p_Header, int p_FirstMip, out string p_Change);
    }
}
