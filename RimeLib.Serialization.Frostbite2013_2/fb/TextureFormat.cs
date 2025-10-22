///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;


namespace fb.Render;

[ContainerType(1, 4)]
public enum TextureFormat : int
{
	TextureFormat_DXT1 = 0,
	TextureFormat_DXT1A = 1,
	TextureFormat_DXT3 = 2,
	TextureFormat_DXT5 = 3,
	TextureFormat_DXT5A = 4,
	TextureFormat_DXN = 5,
	TextureFormat_BC7 = 6,
	TextureFormat_RGB565 = 7,
	TextureFormat_RGB888 = 8,
	TextureFormat_ARGB1555 = 9,
	TextureFormat_ARGB4444 = 10,
	TextureFormat_ARGB8888 = 11,
	TextureFormat_L8 = 12,
	TextureFormat_L16 = 13,
	TextureFormat_ABGR16 = 14,
	TextureFormat_ABGR16F = 15,
	TextureFormat_ABGR32F = 16,
	TextureFormat_R16F = 17,
	TextureFormat_R32F = 18,
	TextureFormat_NormalDXN = 19,
	TextureFormat_NormalDXT1 = 20,
	TextureFormat_NormalDXT5 = 21,
	TextureFormat_NormalDXT5RGA = 22,
	TextureFormat_RG8 = 23,
	TextureFormat_GR16 = 24,
	TextureFormat_GR16F = 25,
	TextureFormat_D16 = 26,
	TextureFormat_D24S8 = 27,
	TextureFormat_D24FS8 = 28,
	TextureFormat_D32F = 29,
	TextureFormat_D32FS8 = 30,
	TextureFormat_S8 = 31,
	TextureFormat_ABGR32 = 32,
	TextureFormat_GR32F = 33,
	TextureFormat_A2R10G10B10 = 34,
	TextureFormat_R11G11B10F = 35,
	TextureFormat_ABGR16_SNORM = 36,
	TextureFormat_ABGR16_UINT = 37,
	TextureFormat_L16_UINT = 38,
	TextureFormat_L32 = 39,
	TextureFormat_GR16_UINT = 40,
	TextureFormat_GR32_UINT = 41,
	TextureFormat_R9G9B9E5F = 42,
	TextureFormat_Unknown = 43,
}

