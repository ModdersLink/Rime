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
	public enum ShaderRenderMode : int
	{
		ShaderRenderMode_Default = 0,
		ShaderRenderMode_DynamicEnvmap = 1,
		ShaderRenderMode_ZOnly = 2,
		ShaderRenderMode_DeferredShadingGBufferLayout0 = 3,
		ShaderRenderMode_DeferredShadingGBufferLayout1 = 4,
		ShaderRenderMode_DeferredShadingEmissive = 5,
		ShaderRenderMode_DeferredShadingUnlit = 6,
		ShaderRenderMode_VelocityVector = 7,
		ShaderRenderMode_DistortionVector = 8,
		ShaderRenderMode_AmbientOcclusionVolume = 9,
		ShaderRenderMode_DebugSimple = 10,
		ShaderRenderMode_DebugMulti = 11,
		ShaderRenderMode_DebugOverdraw = 12,
		ShaderRenderMode_DebugShaderCost = 13,
		ShaderRenderModeCount = 14
	}

}
