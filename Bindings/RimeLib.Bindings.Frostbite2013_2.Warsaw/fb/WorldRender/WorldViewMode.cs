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


namespace fb.WorldRender;

[ContainerType(1, 4)]
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
	WorldViewMode_SubSurfaceScattering = 9,
	WorldViewMode_Light = 10,
	WorldViewMode_LightDiffuse = 11,
	WorldViewMode_LightSpecular = 12,
	WorldViewMode_LightIndirect = 13,
	WorldViewMode_LightTranslucency = 14,
	WorldViewMode_LightOverdraw = 15,
	WorldViewMode_ShadowMask = 16,
	WorldViewMode_SkyVisibility = 17,
	WorldViewMode_SkyVisibilityRaw = 18,
	WorldViewMode_Overdraw = 19,
	WorldViewMode_OverdrawDepthTest = 20,
	WorldViewMode_DynamicAO = 21,
	WorldViewMode_Occluders = 22,
	WorldViewMode_RadiosityLightMaps = 23,
	WorldViewMode_RadiosityDiffuseColor = 24,
	WorldViewMode_RadiosityTargetUV = 25,
	WorldViewMode_VelocityVector = 26,
	WorldViewMode_DistortionVector = 27,
	WorldViewMode_HairAnisoDir = 28,
	WorldViewMode_HairSpecular = 29,
	WorldViewMode_HairAnisoShift = 30,
	WorldViewMode_HairSmoothness = 31,
	WorldViewMode_HairCoverageX = 32,
	WorldViewMode_HairCoverageY = 33,
}

