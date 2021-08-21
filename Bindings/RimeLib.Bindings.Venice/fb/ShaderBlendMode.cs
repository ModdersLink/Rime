///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
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
