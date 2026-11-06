using System;
using RimeLib.Frostbite;
using RimeLib.Texture.Frostbite2_0.Frostbite;

namespace RimeLib.Texture.Frostbite2_0;

/// <summary>Caps a <see cref="DxTexture"/>: sets <see cref="TextureFlags.Streaming"/> and raises MipmapBaseIndex.</summary>
public class TextureMipCap : ITextureMipCap
{
    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    public int HeaderSize => 128;

    public byte[] CapResidentMips(byte[] p_Header, int p_FirstMip, out string p_Change)
    {
        var s_Texture = new DxTexture();
        s_Texture.Deserialize(p_Header);

        if (p_FirstMip >= s_Texture.MipmapCount)
            throw new ArgumentException($"the texture has {s_Texture.MipmapCount} mips, so it cannot be capped at {p_FirstMip}.", nameof(p_FirstMip));

        var s_OldFlags = s_Texture.Flags;
        var s_OldBase = s_Texture.MipmapBaseIndex;
        s_Texture.Flags |= TextureFlags.Streaming;
        s_Texture.MipmapBaseIndex = (byte)p_FirstMip;

        if (!s_Texture.Serialize(out byte[]? s_Header))
            throw new InvalidOperationException("the texture header did not serialize.");

        p_Change = $"flags 0x{(uint)s_OldFlags:X} to 0x{(uint)s_Texture.Flags:X}, mipBase {s_OldBase} to {p_FirstMip} (of {s_Texture.MipmapCount})";
        return s_Header;
    }
}
