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
	public enum ShaderInstancingMethod : int
	{
		ShaderInstancingMethod_None = 0,
		ShaderInstancingMethod_ObjectTransform4x3Half = 1,
		ShaderInstancingMethod_ObjectTransform4x3InstanceData4x1Half = 2,
		ShaderInstancingMethod_ObjectTransform4x3InstanceData4x2Half = 3,
		ShaderInstancingMethod_WorldTransform4x3Float = 4,
		ShaderInstancingMethod_ObjectTranslationScaleHalf = 5,
		ShaderInstancingMethod_ObjectTranslationScaleHalfInstanceData4x1Half = 6,
		ShaderInstancingMethod_ObjectTranslationScaleHalfInstanceData4x2Half = 7,
		ShaderInstancingMethod_VertexAnimation = 8,
		ShaderInstancingMethod_DxBuffer = 9,
		ShaderInstancingMethodCount = 10
	}

}
