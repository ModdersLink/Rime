///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ShaderSkinningMethod : int
	{
		ShaderSkinningMethod_None = 0,
		ShaderSkinningMethod_Linear1Bone = 1,
		ShaderSkinningMethod_Linear2Bone = 2,
		ShaderSkinningMethod_Linear4Bone = 4,
		ShaderSkinningMethod_Linear8Bone = 8,
		ShaderSkinningMethod_Null = 9,
		ShaderSkinningMethod_DualQuaternion4Bone = 10
	}

}
