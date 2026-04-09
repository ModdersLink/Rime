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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 4)]
	public enum WorldViewMode : int
	{
		WorldViewMode_Default = 0,
		WorldViewMode_RawLinear = 1,
		WorldViewMode_RawLinearAlpha = 2,
		WorldViewMode_Diffuse = 3,
		WorldViewMode_Specular = 4,
		WorldViewMode_Emissive = 5,
		WorldViewMode_Normal = 6,
		WorldViewMode_Smoothness = 7,
		WorldViewMode_Material = 8,
		WorldViewMode_Light = 9,
		WorldViewMode_LightDiffuse = 10,
		WorldViewMode_LightSpecular = 11,
		WorldViewMode_LightIndirect = 12,
		WorldViewMode_LightTranslucency = 13,
		WorldViewMode_LightOverdraw = 14,
		WorldViewMode_SkyVisibility = 15,
		WorldViewMode_SkyVisibilityRaw = 16,
		WorldViewMode_Overdraw = 17,
		WorldViewMode_DynamicAO = 18,
		WorldViewMode_Occluders = 19,
		WorldViewMode_RadiosityLightMaps = 20,
		WorldViewMode_RadiosityDiffuseColor = 21,
		WorldViewMode_RadiosityTargetUV = 22,
		WorldViewMode_VelocityVector = 23,
		WorldViewMode_DistortionVector = 24
	}

}
