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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[MemberInfoFlag(137), ContainerSize(4), ContainerEnum]
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
