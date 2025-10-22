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
public enum ShaderInstancingMethod : int
{
	ShaderInstancingMethod_None = 0,
	ShaderInstancingMethod_ObjectTransform4x3Half = 1,
	ShaderInstancingMethod_ObjectTransform4x3InstanceData4x1Half = 2,
	ShaderInstancingMethod_ObjectTransform4x3InstanceData4x2Half = 3,
	ShaderInstancingMethod_WorldTransform4x3Float = 4,
	ShaderInstancingMethod_WorldTransform4x3FloatInstanceData4x2Half = 5,
	ShaderInstancingMethod_ObjectTranslationScaleHalf = 6,
	ShaderInstancingMethod_ObjectTranslationScaleHalfInstanceData4x1Half = 7,
	ShaderInstancingMethod_ObjectTranslationScaleHalfInstanceData4x2Half = 8,
	ShaderInstancingMethod_PositionStream = 9,
	ShaderInstancingMethod_DxBuffer = 10,
	ShaderInstancingMethod_DxBufferInstanceData4x1Float = 11,
	ShaderInstancingMethodCount = 12,
}

