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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ShaderBlendMode : int
	{
		ShaderBlendMode_Lerp = 0,
		ShaderBlendMode_Additive = 1,
		ShaderBlendMode_Multiply = 2,
		ShaderBlendMode_LerpPremultiplied = 3,
		ShaderBlendMode_DecalLerpNoSpec = 4,
		ShaderBlendMode_DecalLerpNormal = 5,
		ShaderBlendMode_DecalLerpNormalMultiplyDiffuse = 6,
		ShaderBlendMode_DecalLerpDiffuse = 7,
		ShaderBlendMode_DecalLerpDiffuseNoSpec = 8
	}

}
