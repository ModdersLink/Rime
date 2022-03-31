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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ShaderTextureDecompression : int
	{
		ShaderTextureDecompression_None = 0,
		ShaderTextureDecompression_NormalAG = 1,
		ShaderTextureDecompression_NormalRG = 2,
		ShaderTextureDecompression_NormalRGA = 3,
		ShaderTextureDecompression_RGBE = 4,
		ShaderTextureDecompression_SrgbToLinear = 5,
		ShaderTextureDecompression_NormalRGorAG = 6
	}

}
