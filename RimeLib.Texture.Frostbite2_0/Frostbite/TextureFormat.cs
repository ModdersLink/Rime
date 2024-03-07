namespace RimeLib.Texture.Frostbite2_0.Frostbite;

public enum TextureFormat : uint
{
    TextureFormat_DXT1,
    TextureFormat_DXT3,
    TextureFormat_DXT5,
    TextureFormat_DXT5A,
    TextureFormat_DXN,
    TextureFormat_RGB565,
    TextureFormat_RGB888,
    TextureFormat_ARGB1555,
    TextureFormat_ARGB4444,
    TextureFormat_ARGB8888,
    TextureFormat_L8,
    TextureFormat_L16,
    TextureFormat_ABGR16,
    TextureFormat_ABGR16F,
    TextureFormat_ABGR32F,
    TextureFormat_R16F,
    TextureFormat_R32F,
    TextureFormat_NormalDXN,
    TextureFormat_NormalDXT1,
    TextureFormat_NormalDXT5,
    TextureFormat_NormalDXT5RGA,
    TextureFormat_RG8,
    TextureFormat_GR16,
    TextureFormat_GR16F,
    TextureFormat_D16,
    TextureFormat_D24S8,
    TextureFormat_D24FS8,
    TextureFormat_D32F,
    TextureFormat_ABGR32,
    TextureFormat_GR32F,
    TextureFormat_A2R10G10B10,
    TextureFormat_Unknown,
}


public static class TextureFormatExtension
{
	public static TextureFormat110 ToTextureFormat110(this TextureFormat p_Format) =>
		p_Format switch
		{
			TextureFormat.TextureFormat_DXT1 => TextureFormat110.TextureFormat_DXT1,
			TextureFormat.TextureFormat_DXT3 => TextureFormat110.TextureFormat_DXT3,
			TextureFormat.TextureFormat_DXT5 => TextureFormat110.TextureFormat_DXT5,
			TextureFormat.TextureFormat_DXT5A => TextureFormat110.TextureFormat_DXT5A,
			TextureFormat.TextureFormat_DXN => TextureFormat110.TextureFormat_DXN,
			TextureFormat.TextureFormat_RGB565 => TextureFormat110.TextureFormat_RGB565,
			TextureFormat.TextureFormat_RGB888 => TextureFormat110.TextureFormat_RGB888,
			TextureFormat.TextureFormat_ARGB1555 => TextureFormat110.TextureFormat_ARGB1555,
			TextureFormat.TextureFormat_ARGB4444 => TextureFormat110.TextureFormat_ARGB4444,
			TextureFormat.TextureFormat_ARGB8888 => TextureFormat110.TextureFormat_ARGB8888,
			TextureFormat.TextureFormat_L8 => TextureFormat110.TextureFormat_L8,
			TextureFormat.TextureFormat_L16 => TextureFormat110.TextureFormat_L16,
			TextureFormat.TextureFormat_ABGR16 => TextureFormat110.TextureFormat_ABGR16,
			TextureFormat.TextureFormat_ABGR16F => TextureFormat110.TextureFormat_ABGR16F,
			TextureFormat.TextureFormat_ABGR32F => TextureFormat110.TextureFormat_ABGR32F,
			TextureFormat.TextureFormat_R16F => TextureFormat110.TextureFormat_R16F,
			TextureFormat.TextureFormat_R32F => TextureFormat110.TextureFormat_R32F,
			TextureFormat.TextureFormat_NormalDXN => TextureFormat110.TextureFormat_NormalDXN,
			TextureFormat.TextureFormat_NormalDXT1 => TextureFormat110.TextureFormat_NormalDXT1,
			TextureFormat.TextureFormat_NormalDXT5 => TextureFormat110.TextureFormat_NormalDXT5,
			TextureFormat.TextureFormat_NormalDXT5RGA => TextureFormat110.TextureFormat_NormalDXT5RGA,
			TextureFormat.TextureFormat_RG8 => TextureFormat110.TextureFormat_RG8,
			TextureFormat.TextureFormat_GR16 => TextureFormat110.TextureFormat_GR16,
			TextureFormat.TextureFormat_GR16F => TextureFormat110.TextureFormat_GR16F,
			TextureFormat.TextureFormat_D16 => TextureFormat110.TextureFormat_D16,
			TextureFormat.TextureFormat_D24S8 => TextureFormat110.TextureFormat_D24S8,
			TextureFormat.TextureFormat_D24FS8 => TextureFormat110.TextureFormat_D24FS8,
			TextureFormat.TextureFormat_D32F => TextureFormat110.TextureFormat_D32F,
			TextureFormat.TextureFormat_ABGR32 => TextureFormat110.TextureFormat_ABGR32,
			TextureFormat.TextureFormat_GR32F => TextureFormat110.TextureFormat_GR32F,
			TextureFormat.TextureFormat_A2R10G10B10 => TextureFormat110.TextureFormat_A2R10G10B10,
			TextureFormat.TextureFormat_Unknown => TextureFormat110.TextureFormat_Unknown,
			_ => TextureFormat110.TextureFormat_Unknown
		};
}