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
public enum ShaderRenderMode : int
{
	ShaderRenderMode_Default = 0,
	ShaderRenderMode_DynamicEnvmap = 1,
	ShaderRenderMode_ZOnly = 2,
	ShaderRenderMode_DeferredShadingGBufferLayout0 = 3,
	ShaderRenderMode_DeferredShadingGBufferLayout1 = 4,
	ShaderRenderMode_DeferredShadingGBufferLayout2 = 5,
	ShaderRenderMode_DeferredShadingGBufferLayout3 = 6,
	ShaderRenderMode_DeferredShadingEmissive = 7,
	ShaderRenderMode_DeferredShadingUnlit = 8,
	ShaderRenderMode_VelocityVector = 9,
	ShaderRenderMode_DistortionVector = 10,
	ShaderRenderMode_AmbientOcclusionVolume = 11,
	ShaderRenderMode_DebugMulti = 12,
	ShaderRenderModeCount = 13,
}

