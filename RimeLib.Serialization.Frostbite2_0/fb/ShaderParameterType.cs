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
	public enum ShaderParameterType : int
	{
		ShaderParameterType_Bool = 0,
		ShaderParameterType_Int = 1,
		ShaderParameterType_Scalar = 2,
		ShaderParameterType_Vec2 = 3,
		ShaderParameterType_Vec3 = 4,
		ShaderParameterType_Vec4 = 5,
		ShaderParameterType_Color = 6,
		ShaderParameterType_TextureSlice = 7,
		ShaderParameterTypeCount = 8
	}

}
