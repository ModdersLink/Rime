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
public enum ShaderConstantFunction : int
{
	ShaderConstantFunction_ViewMatrix = 0,
	ShaderConstantFunction_ViewProjMatrix = 1,
	ShaderConstantFunction_WorldViewMatrix = 2,
	ShaderConstantFunction_WorldViewProjMatrix = 3,
	ShaderConstantFunction_CrViewProjMatrix = 4,
	ShaderConstantFunction_CrWorldViewProjMatrix = 5,
	ShaderConstantFunction_CameraPos = 6,
	ShaderConstantFunction_PrevViewProjMatrix = 7,
	ShaderConstantFunction_PrevWorldViewProjMatrix = 8,
	ShaderConstantFunction_WorldMatrix = 9,
	ShaderConstantFunction_PrevWorldMatrix = 10,
	ShaderConstantFunction_BoneVectors = 11,
	ShaderConstantFunction_PrevBoneVectors = 12,
	ShaderConstantFunction_LightProbeShR = 13,
	ShaderConstantFunction_LightProbeShG = 14,
	ShaderConstantFunction_LightProbeShB = 15,
	ShaderConstantFunction_LightProbeShO = 16,
	ShaderConstantFunction_LightMapUvTransform = 17,
	ShaderConstantFunction_LightMapUvTranslation = 18,
	ShaderConstantFunction_LightMapIrradianceTexture = 19,
	ShaderConstantFunction_LightMapIrradianceChromaTexture = 20,
	ShaderConstantFunction_LightMapIrradianceLumaTexture = 21,
	ShaderConstantFunction_LightMapDirectionTexture = 22,
	ShaderConstantFunction_LightMapSkyVisibilityTexture = 23,
	ShaderConstantFunction_DepthBufferTexture = 24,
	ShaderConstantFunction_ProjectionKxKyKzKw = 25,
	ShaderConstantFunction_Time = 26,
	ShaderConstantFunction_ScreenSize = 27,
	ShaderConstantFunction_OutdoorLightDir = 28,
	ShaderConstantFunction_OutdoorLightHemisphereDir = 29,
	ShaderConstantFunction_OutdoorLightKeyColor = 30,
	ShaderConstantFunction_OutdoorLightKeySpecularColorAndHemisphereVisibility = 31,
	ShaderConstantFunction_OutdoorLightTopColor = 32,
	ShaderConstantFunction_OutdoorLightBottomColor = 33,
	ShaderConstantFunction_OutdoorLightShadowTransform = 34,
	ShaderConstantFunction_OutdoorLightShadowmapSizeAndInvSize = 35,
	ShaderConstantFunction_OutdoorLightShadowmapTexture = 36,
	ShaderConstantFunction_OutdoorLightTransparencyShadowmapTexture = 37,
	ShaderConstantFunction_OutdoorLightSkyEnvmap = 38,
	ShaderConstantFunction_OutdoorLightCustomEnvmap = 39,
	ShaderConstantFunction_OutdoorLightDynamicEnvmap = 40,
	ShaderConstantFunction_OutdoorLightTopColorEnvmap = 41,
	ShaderConstantFunction_OutdoorLightBottomColorEnvmap = 42,
	ShaderConstantFunction_OutdoorLightKeyColorEnvmap = 43,
	ShaderConstantFunction_OutdoorLightEnvmapsMipmapCount = 44,
	ShaderConstantFunction_OutdoorLightSkyEnvmap8BitTexInvScale = 45,
	ShaderConstantFunction_OutdoorLightCustomEnvmapScaleAmbient = 46,
	ShaderConstantFunction_TransparentStartAndSlopeAndClamp = 47,
	ShaderConstantFunction_TransparentCurve = 48,
	ShaderConstantFunction_BestFitNormalScaleTexture = 49,
	ShaderConstantFunction_SceneTexture = 50,
	ShaderConstantFunction_ColorScale = 51,
	ShaderConstantFunction_DebugNonFiniteColor = 52,
	ShaderConstantFunction_XenonInstancingIndexCount = 53,
	ShaderConstantFunction_Ps3ClipPlane = 54,
	ShaderConstantFunction_DxVectorBufferOffsets = 55,
	ShaderConstantFunction_DistortionMaxValue = 56,
	ShaderConstantFunction_SubSurfaceScatteringMaxWidth = 57,
	ShaderConstantFunction_ObjectScale = 58,
	ShaderConstantFunction_ObjectWorldPosition = 59,
	ShaderConstantFunction_UserData0 = 60,
	ShaderConstantFunction_UserData1 = 61,
	ShaderConstantFunctionCount = 62,
}

