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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 576)]
	public class WorldRenderSettings : 
		DataContainer
	{
		protected Vec3 m_DynamicEnvmapDefaultPosition = new Vec3();
		[ContainerField(Name: "DynamicEnvmapDefaultPosition", Offset: 16, NameHash: 2442804067, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DynamicEnvmapDefaultPosition { get { return m_DynamicEnvmapDefaultPosition; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DynamicEnvmapDefaultPosition), this, m_DynamicEnvmapDefaultPosition, value)) m_DynamicEnvmapDefaultPosition = value; } } // 0x10 (16)
		
		protected Vec3 m_SubSurfaceColor = new Vec3();
		[ContainerField(Name: "SubSurfaceColor", Offset: 32, NameHash: 1116837929, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SubSurfaceColor { get { return m_SubSurfaceColor; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SubSurfaceColor), this, m_SubSurfaceColor, value)) m_SubSurfaceColor = value; } } // 0x20 (32)
		
		protected float m_ViewportScale = new float();
		[ContainerField(Name: "ViewportScale", Offset: 48, NameHash: 372747593, Flags: 49469), LayoutImmutable, Blittable]
		public float ViewportScale { get { return m_ViewportScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ViewportScale), this, m_ViewportScale, value)) m_ViewportScale = value; } } // 0x30 (48)
		
		protected float m_ShadowMinScreenArea = new float();
		[ContainerField(Name: "ShadowMinScreenArea", Offset: 52, NameHash: 1763892754, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowMinScreenArea { get { return m_ShadowMinScreenArea; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowMinScreenArea), this, m_ShadowMinScreenArea, value)) m_ShadowMinScreenArea = value; } } // 0x34 (52)
		
		protected float m_ShadowViewportScale = new float();
		[ContainerField(Name: "ShadowViewportScale", Offset: 56, NameHash: 1275076751, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowViewportScale { get { return m_ShadowViewportScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowViewportScale), this, m_ShadowViewportScale, value)) m_ShadowViewportScale = value; } } // 0x38 (56)
		
		protected uint m_FxaaQuality = new uint();
		[ContainerField(Name: "FxaaQuality", Offset: 60, NameHash: 1713753686, Flags: 49421), LayoutImmutable, Blittable]
		public uint FxaaQuality { get { return m_FxaaQuality; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(FxaaQuality), this, m_FxaaQuality, value)) m_FxaaQuality = value; } } // 0x3C (60)
		
		protected float m_CullScreenAreaScale = new float();
		[ContainerField(Name: "CullScreenAreaScale", Offset: 64, NameHash: 989651568, Flags: 49469), LayoutImmutable, Blittable]
		public float CullScreenAreaScale { get { return m_CullScreenAreaScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(CullScreenAreaScale), this, m_CullScreenAreaScale, value)) m_CullScreenAreaScale = value; } } // 0x40 (64)
		
		protected float m_PlanarReflectionCullFOV = new float();
		[ContainerField(Name: "PlanarReflectionCullFOV", Offset: 68, NameHash: 3291231915, Flags: 49469), LayoutImmutable, Blittable]
		public float PlanarReflectionCullFOV { get { return m_PlanarReflectionCullFOV; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(PlanarReflectionCullFOV), this, m_PlanarReflectionCullFOV, value)) m_PlanarReflectionCullFOV = value; } } // 0x44 (68)
		
		protected uint m_GenericEntityMaxVisibleEntityCount = new uint();
		[ContainerField(Name: "GenericEntityMaxVisibleEntityCount", Offset: 72, NameHash: 3254270605, Flags: 49421), LayoutImmutable, Blittable]
		public uint GenericEntityMaxVisibleEntityCount { get { return m_GenericEntityMaxVisibleEntityCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(GenericEntityMaxVisibleEntityCount), this, m_GenericEntityMaxVisibleEntityCount, value)) m_GenericEntityMaxVisibleEntityCount = value; } } // 0x48 (72)
		
		protected float m_ShadowmapSizeZScale = new float();
		[ContainerField(Name: "ShadowmapSizeZScale", Offset: 76, NameHash: 3508619736, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowmapSizeZScale { get { return m_ShadowmapSizeZScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapSizeZScale), this, m_ShadowmapSizeZScale, value)) m_ShadowmapSizeZScale = value; } } // 0x4C (76)
		
		protected uint m_ShadowmapResolution = new uint();
		[ContainerField(Name: "ShadowmapResolution", Offset: 80, NameHash: 3880013969, Flags: 49421), LayoutImmutable, Blittable]
		public uint ShadowmapResolution { get { return m_ShadowmapResolution; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapResolution), this, m_ShadowmapResolution, value)) m_ShadowmapResolution = value; } } // 0x50 (80)
		
		protected uint m_ShadowmapQuality = new uint();
		[ContainerField(Name: "ShadowmapQuality", Offset: 84, NameHash: 4159686514, Flags: 49421), LayoutImmutable, Blittable]
		public uint ShadowmapQuality { get { return m_ShadowmapQuality; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapQuality), this, m_ShadowmapQuality, value)) m_ShadowmapQuality = value; } } // 0x54 (84)
		
		protected float m_ShadowmapPoissonFilterScale = new float();
		[ContainerField(Name: "ShadowmapPoissonFilterScale", Offset: 88, NameHash: 3460109328, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowmapPoissonFilterScale { get { return m_ShadowmapPoissonFilterScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapPoissonFilterScale), this, m_ShadowmapPoissonFilterScale, value)) m_ShadowmapPoissonFilterScale = value; } } // 0x58 (88)
		
		protected uint m_ShadowmapSliceCount = new uint();
		[ContainerField(Name: "ShadowmapSliceCount", Offset: 92, NameHash: 1754397676, Flags: 49421), LayoutImmutable, Blittable]
		public uint ShadowmapSliceCount { get { return m_ShadowmapSliceCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapSliceCount), this, m_ShadowmapSliceCount, value)) m_ShadowmapSliceCount = value; } } // 0x5C (92)
		
		protected float m_ShadowmapSliceSchemeWeight = new float();
		[ContainerField(Name: "ShadowmapSliceSchemeWeight", Offset: 96, NameHash: 4103828218, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowmapSliceSchemeWeight { get { return m_ShadowmapSliceSchemeWeight; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapSliceSchemeWeight), this, m_ShadowmapSliceSchemeWeight, value)) m_ShadowmapSliceSchemeWeight = value; } } // 0x60 (96)
		
		protected float m_ShadowmapFirstSliceScale = new float();
		[ContainerField(Name: "ShadowmapFirstSliceScale", Offset: 100, NameHash: 2040081677, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowmapFirstSliceScale { get { return m_ShadowmapFirstSliceScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapFirstSliceScale), this, m_ShadowmapFirstSliceScale, value)) m_ShadowmapFirstSliceScale = value; } } // 0x64 (100)
		
		protected float m_ShadowmapViewDistance = new float();
		[ContainerField(Name: "ShadowmapViewDistance", Offset: 104, NameHash: 1554572465, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowmapViewDistance { get { return m_ShadowmapViewDistance; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapViewDistance), this, m_ShadowmapViewDistance, value)) m_ShadowmapViewDistance = value; } } // 0x68 (104)
		
		protected uint m_PlanarReflectionWidth = new uint();
		[ContainerField(Name: "PlanarReflectionWidth", Offset: 108, NameHash: 1134551908, Flags: 49421), LayoutImmutable, Blittable]
		public uint PlanarReflectionWidth { get { return m_PlanarReflectionWidth; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(PlanarReflectionWidth), this, m_PlanarReflectionWidth, value)) m_PlanarReflectionWidth = value; } } // 0x6C (108)
		
		protected float m_ShadowmapExtrusionLength = new float();
		[ContainerField(Name: "ShadowmapExtrusionLength", Offset: 112, NameHash: 658753014, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowmapExtrusionLength { get { return m_ShadowmapExtrusionLength; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapExtrusionLength), this, m_ShadowmapExtrusionLength, value)) m_ShadowmapExtrusionLength = value; } } // 0x70 (112)
		
		protected float m_ShadowmapMinScreenArea = new float();
		[ContainerField(Name: "ShadowmapMinScreenArea", Offset: 116, NameHash: 2714094958, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowmapMinScreenArea { get { return m_ShadowmapMinScreenArea; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapMinScreenArea), this, m_ShadowmapMinScreenArea, value)) m_ShadowmapMinScreenArea = value; } } // 0x74 (116)
		
		protected float m_TempPlanarReflectionY = new float();
		[ContainerField(Name: "TempPlanarReflectionY", Offset: 120, NameHash: 2965318295, Flags: 49469), LayoutImmutable, Blittable]
		public float TempPlanarReflectionY { get { return m_TempPlanarReflectionY; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(TempPlanarReflectionY), this, m_TempPlanarReflectionY, value)) m_TempPlanarReflectionY = value; } } // 0x78 (120)
		
		protected float m_SubSurfaceRolloffKeyLight = new float();
		[ContainerField(Name: "SubSurfaceRolloffKeyLight", Offset: 124, NameHash: 1376512303, Flags: 49469), LayoutImmutable, Blittable]
		public float SubSurfaceRolloffKeyLight { get { return m_SubSurfaceRolloffKeyLight; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SubSurfaceRolloffKeyLight), this, m_SubSurfaceRolloffKeyLight, value)) m_SubSurfaceRolloffKeyLight = value; } } // 0x7C (124)
		
		protected int m_FxaaForceVendor = new int();
		[ContainerField(Name: "FxaaForceVendor", Offset: 128, NameHash: 3453976226, Flags: 49405), LayoutImmutable, Blittable]
		public int FxaaForceVendor { get { return m_FxaaForceVendor; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(FxaaForceVendor), this, m_FxaaForceVendor, value)) m_FxaaForceVendor = value; } } // 0x80 (128)
		
		protected uint m_PlanarReflectionHeight = new uint();
		[ContainerField(Name: "PlanarReflectionHeight", Offset: 132, NameHash: 2870536605, Flags: 49421), LayoutImmutable, Blittable]
		public uint PlanarReflectionHeight { get { return m_PlanarReflectionHeight; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(PlanarReflectionHeight), this, m_PlanarReflectionHeight, value)) m_PlanarReflectionHeight = value; } } // 0x84 (132)
		
		protected float m_LightIntensityScale = new float();
		[ContainerField(Name: "LightIntensityScale", Offset: 136, NameHash: 4224101580, Flags: 49469), LayoutImmutable, Blittable]
		public float LightIntensityScale { get { return m_LightIntensityScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightIntensityScale), this, m_LightIntensityScale, value)) m_LightIntensityScale = value; } } // 0x88 (136)
		
		protected float m_LightLodSpecularFadeAreaEnd = new float();
		[ContainerField(Name: "LightLodSpecularFadeAreaEnd", Offset: 140, NameHash: 340957037, Flags: 49469), LayoutImmutable, Blittable]
		public float LightLodSpecularFadeAreaEnd { get { return m_LightLodSpecularFadeAreaEnd; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightLodSpecularFadeAreaEnd), this, m_LightLodSpecularFadeAreaEnd, value)) m_LightLodSpecularFadeAreaEnd = value; } } // 0x8C (140)
		
		protected float m_ShadowmapMinFov = new float();
		[ContainerField(Name: "ShadowmapMinFov", Offset: 144, NameHash: 4182219946, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowmapMinFov { get { return m_ShadowmapMinFov; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapMinFov), this, m_ShadowmapMinFov, value)) m_ShadowmapMinFov = value; } } // 0x90 (144)
		
		protected float m_LightLodSpecularFadeAreaStart = new float();
		[ContainerField(Name: "LightLodSpecularFadeAreaStart", Offset: 148, NameHash: 1941638882, Flags: 49469), LayoutImmutable, Blittable]
		public float LightLodSpecularFadeAreaStart { get { return m_LightLodSpecularFadeAreaStart; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightLodSpecularFadeAreaStart), this, m_LightLodSpecularFadeAreaStart, value)) m_LightLodSpecularFadeAreaStart = value; } } // 0x94 (148)
		
		protected float m_LightLodRadiusFactor = new float();
		[ContainerField(Name: "LightLodRadiusFactor", Offset: 152, NameHash: 2574597545, Flags: 49469), LayoutImmutable, Blittable]
		public float LightLodRadiusFactor { get { return m_LightLodRadiusFactor; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightLodRadiusFactor), this, m_LightLodRadiusFactor, value)) m_LightLodRadiusFactor = value; } } // 0x98 (152)
		
		protected float m_LightForceIntensity = new float();
		[ContainerField(Name: "LightForceIntensity", Offset: 156, NameHash: 1015351721, Flags: 49469), LayoutImmutable, Blittable]
		public float LightForceIntensity { get { return m_LightForceIntensity; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightForceIntensity), this, m_LightForceIntensity, value)) m_LightForceIntensity = value; } } // 0x9C (156)
		
		protected float m_LightLodFadeArea = new float();
		[ContainerField(Name: "LightLodFadeArea", Offset: 160, NameHash: 3993094733, Flags: 49469), LayoutImmutable, Blittable]
		public float LightLodFadeArea { get { return m_LightLodFadeArea; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightLodFadeArea), this, m_LightLodFadeArea, value)) m_LightLodFadeArea = value; } } // 0xA0 (160)
		
		protected float m_LightLodMinArea = new float();
		[ContainerField(Name: "LightLodMinArea", Offset: 164, NameHash: 1014960449, Flags: 49469), LayoutImmutable, Blittable]
		public float LightLodMinArea { get { return m_LightLodMinArea; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightLodMinArea), this, m_LightLodMinArea, value)) m_LightLodMinArea = value; } } // 0xA4 (164)
		
		protected int m_DrawDebugDynamicEnvmapMipLevel = new int();
		[ContainerField(Name: "DrawDebugDynamicEnvmapMipLevel", Offset: 168, NameHash: 1647206466, Flags: 49405), LayoutImmutable, Blittable]
		public int DrawDebugDynamicEnvmapMipLevel { get { return m_DrawDebugDynamicEnvmapMipLevel; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugDynamicEnvmapMipLevel), this, m_DrawDebugDynamicEnvmapMipLevel, value)) m_DrawDebugDynamicEnvmapMipLevel = value; } } // 0xA8 (168)
		
		protected uint m_MaxDecalVolumeCount = new uint();
		[ContainerField(Name: "MaxDecalVolumeCount", Offset: 172, NameHash: 1711167253, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxDecalVolumeCount { get { return m_MaxDecalVolumeCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MaxDecalVolumeCount), this, m_MaxDecalVolumeCount, value)) m_MaxDecalVolumeCount = value; } } // 0xAC (172)
		
		protected float m_MotionBlurScale = new float();
		[ContainerField(Name: "MotionBlurScale", Offset: 176, NameHash: 922077962, Flags: 49469), LayoutImmutable, Blittable]
		public float MotionBlurScale { get { return m_MotionBlurScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MotionBlurScale), this, m_MotionBlurScale, value)) m_MotionBlurScale = value; } } // 0xB0 (176)
		
		protected float m_MotionBlurMax = new float();
		[ContainerField(Name: "MotionBlurMax", Offset: 180, NameHash: 1677064646, Flags: 49469), LayoutImmutable, Blittable]
		public float MotionBlurMax { get { return m_MotionBlurMax; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MotionBlurMax), this, m_MotionBlurMax, value)) m_MotionBlurMax = value; } } // 0xB4 (180)
		
		protected float m_MotionBlurNoiseScale = new float();
		[ContainerField(Name: "MotionBlurNoiseScale", Offset: 184, NameHash: 4082261780, Flags: 49469), LayoutImmutable, Blittable]
		public float MotionBlurNoiseScale { get { return m_MotionBlurNoiseScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MotionBlurNoiseScale), this, m_MotionBlurNoiseScale, value)) m_MotionBlurNoiseScale = value; } } // 0xB8 (184)
		
		protected uint m_MotionBlurQuality = new uint();
		[ContainerField(Name: "MotionBlurQuality", Offset: 188, NameHash: 3278537567, Flags: 49421), LayoutImmutable, Blittable]
		public uint MotionBlurQuality { get { return m_MotionBlurQuality; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MotionBlurQuality), this, m_MotionBlurQuality, value)) m_MotionBlurQuality = value; } } // 0xBC (188)
		
		protected uint m_MaxSpotLightShadowCount = new uint();
		[ContainerField(Name: "MaxSpotLightShadowCount", Offset: 192, NameHash: 2418772786, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxSpotLightShadowCount { get { return m_MaxSpotLightShadowCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MaxSpotLightShadowCount), this, m_MaxSpotLightShadowCount, value)) m_MaxSpotLightShadowCount = value; } } // 0xC0 (192)
		
		protected MipmapFilterMode m_DynamicEnvmapFilterMode = new MipmapFilterMode();
		[ContainerField(Name: "DynamicEnvmapFilterMode", Offset: 196, NameHash: 3729378162, Flags: 137)]
		public MipmapFilterMode DynamicEnvmapFilterMode { get { return m_DynamicEnvmapFilterMode; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DynamicEnvmapFilterMode), this, m_DynamicEnvmapFilterMode, value)) m_DynamicEnvmapFilterMode = value; } } // 0xC4 (196)
		
		protected uint m_MotionBlurMaxSampleCount = new uint();
		[ContainerField(Name: "MotionBlurMaxSampleCount", Offset: 200, NameHash: 1447314883, Flags: 49421), LayoutImmutable, Blittable]
		public uint MotionBlurMaxSampleCount { get { return m_MotionBlurMaxSampleCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MotionBlurMaxSampleCount), this, m_MotionBlurMaxSampleCount, value)) m_MotionBlurMaxSampleCount = value; } } // 0xC8 (200)
		
		protected uint m_MotionBlurFrameAverageCount = new uint();
		[ContainerField(Name: "MotionBlurFrameAverageCount", Offset: 204, NameHash: 1914506031, Flags: 49421), LayoutImmutable, Blittable]
		public uint MotionBlurFrameAverageCount { get { return m_MotionBlurFrameAverageCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MotionBlurFrameAverageCount), this, m_MotionBlurFrameAverageCount, value)) m_MotionBlurFrameAverageCount = value; } } // 0xCC (204)
		
		protected float m_MotionBlurMaxFrameTime = new float();
		[ContainerField(Name: "MotionBlurMaxFrameTime", Offset: 208, NameHash: 771939886, Flags: 49469), LayoutImmutable, Blittable]
		public float MotionBlurMaxFrameTime { get { return m_MotionBlurMaxFrameTime; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MotionBlurMaxFrameTime), this, m_MotionBlurMaxFrameTime, value)) m_MotionBlurMaxFrameTime = value; } } // 0xD0 (208)
		
		protected float m_ForceMotionBlurDepthCutoff = new float();
		[ContainerField(Name: "ForceMotionBlurDepthCutoff", Offset: 212, NameHash: 3772079119, Flags: 49469), LayoutImmutable, Blittable]
		public float ForceMotionBlurDepthCutoff { get { return m_ForceMotionBlurDepthCutoff; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ForceMotionBlurDepthCutoff), this, m_ForceMotionBlurDepthCutoff, value)) m_ForceMotionBlurDepthCutoff = value; } } // 0xD4 (212)
		
		protected float m_ForceMotionBlurCutoffGradientScale = new float();
		[ContainerField(Name: "ForceMotionBlurCutoffGradientScale", Offset: 216, NameHash: 3044262524, Flags: 49469), LayoutImmutable, Blittable]
		public float ForceMotionBlurCutoffGradientScale { get { return m_ForceMotionBlurCutoffGradientScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ForceMotionBlurCutoffGradientScale), this, m_ForceMotionBlurCutoffGradientScale, value)) m_ForceMotionBlurCutoffGradientScale = value; } } // 0xD8 (216)
		
		protected uint m_MultisampleCount = new uint();
		[ContainerField(Name: "MultisampleCount", Offset: 220, NameHash: 1049323753, Flags: 49421), LayoutImmutable, Blittable]
		public uint MultisampleCount { get { return m_MultisampleCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MultisampleCount), this, m_MultisampleCount, value)) m_MultisampleCount = value; } } // 0xDC (220)
		
		protected float m_MultisampleThreshold = new float();
		[ContainerField(Name: "MultisampleThreshold", Offset: 224, NameHash: 3044955837, Flags: 49469), LayoutImmutable, Blittable]
		public float MultisampleThreshold { get { return m_MultisampleThreshold; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MultisampleThreshold), this, m_MultisampleThreshold, value)) m_MultisampleThreshold = value; } } // 0xE0 (224)
		
		protected uint m_MaxPointLightCount = new uint();
		[ContainerField(Name: "MaxPointLightCount", Offset: 228, NameHash: 2623363008, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxPointLightCount { get { return m_MaxPointLightCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MaxPointLightCount), this, m_MaxPointLightCount, value)) m_MaxPointLightCount = value; } } // 0xE4 (228)
		
		protected uint m_ReflectionEnvmapSize = new uint();
		[ContainerField(Name: "ReflectionEnvmapSize", Offset: 232, NameHash: 2418170502, Flags: 49421), LayoutImmutable, Blittable]
		public uint ReflectionEnvmapSize { get { return m_ReflectionEnvmapSize; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ReflectionEnvmapSize), this, m_ReflectionEnvmapSize, value)) m_ReflectionEnvmapSize = value; } } // 0xE8 (232)
		
		protected float m_SpotLightNearPlane = new float();
		[ContainerField(Name: "SpotLightNearPlane", Offset: 236, NameHash: 4277463821, Flags: 49469), LayoutImmutable, Blittable]
		public float SpotLightNearPlane { get { return m_SpotLightNearPlane; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SpotLightNearPlane), this, m_SpotLightNearPlane, value)) m_SpotLightNearPlane = value; } } // 0xEC (236)
		
		protected float m_SpotLightShadowmapPoissonFilterScale = new float();
		[ContainerField(Name: "SpotLightShadowmapPoissonFilterScale", Offset: 240, NameHash: 984299638, Flags: 49469), LayoutImmutable, Blittable]
		public float SpotLightShadowmapPoissonFilterScale { get { return m_SpotLightShadowmapPoissonFilterScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SpotLightShadowmapPoissonFilterScale), this, m_SpotLightShadowmapPoissonFilterScale, value)) m_SpotLightShadowmapPoissonFilterScale = value; } } // 0xF0 (240)
		
		protected int m_OnlyShadowmapSlice = new int();
		[ContainerField(Name: "OnlyShadowmapSlice", Offset: 244, NameHash: 883213115, Flags: 49405), LayoutImmutable, Blittable]
		public int OnlyShadowmapSlice { get { return m_OnlyShadowmapSlice; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OnlyShadowmapSlice), this, m_OnlyShadowmapSlice, value)) m_OnlyShadowmapSlice = value; } } // 0xF4 (244)
		
		protected WorldViewMode m_ViewMode = new WorldViewMode();
		[ContainerField(Name: "ViewMode", Offset: 248, NameHash: 381898379, Flags: 137)]
		public WorldViewMode ViewMode { get { return m_ViewMode; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ViewMode), this, m_ViewMode, value)) m_ViewMode = value; } } // 0xF8 (248)
		
		protected uint m_SpotLightShadowmapResolution = new uint();
		[ContainerField(Name: "SpotLightShadowmapResolution", Offset: 252, NameHash: 2435232759, Flags: 49421), LayoutImmutable, Blittable]
		public uint SpotLightShadowmapResolution { get { return m_SpotLightShadowmapResolution; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SpotLightShadowmapResolution), this, m_SpotLightShadowmapResolution, value)) m_SpotLightShadowmapResolution = value; } } // 0xFC (252)
		
		protected QualityLevel m_SpotLightShadomapLevel = new QualityLevel();
		[ContainerField(Name: "SpotLightShadomapLevel", Offset: 256, NameHash: 2998747480, Flags: 137)]
		public QualityLevel SpotLightShadomapLevel { get { return m_SpotLightShadomapLevel; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SpotLightShadomapLevel), this, m_SpotLightShadomapLevel, value)) m_SpotLightShadomapLevel = value; } } // 0x100 (256)
		
		protected uint m_SpotLightShadowmapQuality = new uint();
		[ContainerField(Name: "SpotLightShadowmapQuality", Offset: 260, NameHash: 4007866708, Flags: 49421), LayoutImmutable, Blittable]
		public uint SpotLightShadowmapQuality { get { return m_SpotLightShadowmapQuality; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SpotLightShadowmapQuality), this, m_SpotLightShadowmapQuality, value)) m_SpotLightShadowmapQuality = value; } } // 0x104 (260)
		
		protected int m_OnlyLightTileY = new int();
		[ContainerField(Name: "OnlyLightTileY", Offset: 264, NameHash: 1921288514, Flags: 49405), LayoutImmutable, Blittable]
		public int OnlyLightTileY { get { return m_OnlyLightTileY; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OnlyLightTileY), this, m_OnlyLightTileY, value)) m_OnlyLightTileY = value; } } // 0x108 (264)
		
		protected int m_OnlyLightTileX = new int();
		[ContainerField(Name: "OnlyLightTileX", Offset: 268, NameHash: 1921288515, Flags: 49405), LayoutImmutable, Blittable]
		public int OnlyLightTileX { get { return m_OnlyLightTileX; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OnlyLightTileX), this, m_OnlyLightTileX, value)) m_OnlyLightTileX = value; } } // 0x10C (268)
		
		protected float m_XenonHdrColorScale = new float();
		[ContainerField(Name: "XenonHdrColorScale", Offset: 272, NameHash: 2994673228, Flags: 49469), LayoutImmutable, Blittable]
		public float XenonHdrColorScale { get { return m_XenonHdrColorScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonHdrColorScale), this, m_XenonHdrColorScale, value)) m_XenonHdrColorScale = value; } } // 0x110 (272)
		
		protected float m_XenonHdrColorScaleFactor = new float();
		[ContainerField(Name: "XenonHdrColorScaleFactor", Offset: 276, NameHash: 357430561, Flags: 49469), LayoutImmutable, Blittable]
		public float XenonHdrColorScaleFactor { get { return m_XenonHdrColorScaleFactor; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonHdrColorScaleFactor), this, m_XenonHdrColorScaleFactor, value)) m_XenonHdrColorScaleFactor = value; } } // 0x114 (276)
		
		protected uint m_Ps3LightTileJobMaxFbTileCount = new uint();
		[ContainerField(Name: "Ps3LightTileJobMaxFbTileCount", Offset: 280, NameHash: 1822791039, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3LightTileJobMaxFbTileCount { get { return m_Ps3LightTileJobMaxFbTileCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3LightTileJobMaxFbTileCount), this, m_Ps3LightTileJobMaxFbTileCount, value)) m_Ps3LightTileJobMaxFbTileCount = value; } } // 0x118 (280)
		
		protected int m_OnlyLightTileIndex = new int();
		[ContainerField(Name: "OnlyLightTileIndex", Offset: 284, NameHash: 3383060069, Flags: 49405), LayoutImmutable, Blittable]
		public int OnlyLightTileIndex { get { return m_OnlyLightTileIndex; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OnlyLightTileIndex), this, m_OnlyLightTileIndex, value)) m_OnlyLightTileIndex = value; } } // 0x11C (284)
		
		protected uint m_Ps3LightTileJobCount = new uint();
		[ContainerField(Name: "Ps3LightTileJobCount", Offset: 288, NameHash: 3257825371, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3LightTileJobCount { get { return m_Ps3LightTileJobCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3LightTileJobCount), this, m_Ps3LightTileJobCount, value)) m_Ps3LightTileJobCount = value; } } // 0x120 (288)
		
		protected uint m_Ps3LightTileJobPriority = new uint();
		[ContainerField(Name: "Ps3LightTileJobPriority", Offset: 292, NameHash: 2438614122, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3LightTileJobPriority { get { return m_Ps3LightTileJobPriority; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3LightTileJobPriority), this, m_Ps3LightTileJobPriority, value)) m_Ps3LightTileJobPriority = value; } } // 0x124 (292)
		
		protected uint m_XenonLightTileMaxLineLightCount = new uint();
		[ContainerField(Name: "XenonLightTileMaxLineLightCount", Offset: 296, NameHash: 2351028858, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonLightTileMaxLineLightCount { get { return m_XenonLightTileMaxLineLightCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonLightTileMaxLineLightCount), this, m_XenonLightTileMaxLineLightCount, value)) m_XenonLightTileMaxLineLightCount = value; } } // 0x128 (296)
		
		protected uint m_XenonLightTileMaxSpotLightCount = new uint();
		[ContainerField(Name: "XenonLightTileMaxSpotLightCount", Offset: 300, NameHash: 429843884, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonLightTileMaxSpotLightCount { get { return m_XenonLightTileMaxSpotLightCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonLightTileMaxSpotLightCount), this, m_XenonLightTileMaxSpotLightCount, value)) m_XenonLightTileMaxSpotLightCount = value; } } // 0x12C (300)
		
		protected uint m_XenonLightTileConstantBufferSize = new uint();
		[ContainerField(Name: "XenonLightTileConstantBufferSize", Offset: 304, NameHash: 2424724230, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonLightTileConstantBufferSize { get { return m_XenonLightTileConstantBufferSize; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonLightTileConstantBufferSize), this, m_XenonLightTileConstantBufferSize, value)) m_XenonLightTileConstantBufferSize = value; } } // 0x130 (304)
		
		protected uint m_XenonLightTileMaxPointLightCount = new uint();
		[ContainerField(Name: "XenonLightTileMaxPointLightCount", Offset: 308, NameHash: 2040884056, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonLightTileMaxPointLightCount { get { return m_XenonLightTileMaxPointLightCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonLightTileMaxPointLightCount), this, m_XenonLightTileMaxPointLightCount, value)) m_XenonLightTileMaxPointLightCount = value; } } // 0x134 (308)
		
		protected uint m_MaxDestructionVolumeCount = new uint();
		[ContainerField(Name: "MaxDestructionVolumeCount", Offset: 312, NameHash: 3613038148, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxDestructionVolumeCount { get { return m_MaxDestructionVolumeCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MaxDestructionVolumeCount), this, m_MaxDestructionVolumeCount, value)) m_MaxDestructionVolumeCount = value; } } // 0x138 (312)
		
		protected float m_DynamicEnvmapFilterWidth = new float();
		[ContainerField(Name: "DynamicEnvmapFilterWidth", Offset: 316, NameHash: 2780479095, Flags: 49469), LayoutImmutable, Blittable]
		public float DynamicEnvmapFilterWidth { get { return m_DynamicEnvmapFilterWidth; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DynamicEnvmapFilterWidth), this, m_DynamicEnvmapFilterWidth, value)) m_DynamicEnvmapFilterWidth = value; } } // 0x13C (316)
		
		protected float m_LightTileMinArea = new float();
		[ContainerField(Name: "LightTileMinArea", Offset: 320, NameHash: 2423538194, Flags: 49469), LayoutImmutable, Blittable]
		public float LightTileMinArea { get { return m_LightTileMinArea; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightTileMinArea), this, m_LightTileMinArea, value)) m_LightTileMinArea = value; } } // 0x140 (320)
		
		protected uint m_DynamicEnvmapResolution = new uint();
		[ContainerField(Name: "DynamicEnvmapResolution", Offset: 324, NameHash: 1892805023, Flags: 49421), LayoutImmutable, Blittable]
		public uint DynamicEnvmapResolution { get { return m_DynamicEnvmapResolution; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DynamicEnvmapResolution), this, m_DynamicEnvmapResolution, value)) m_DynamicEnvmapResolution = value; } } // 0x144 (324)
		
		protected ShaderGBufferLayout m_GBufferLayout = new ShaderGBufferLayout();
		[ContainerField(Name: "GBufferLayout", Offset: 328, NameHash: 923722776, Flags: 137)]
		public ShaderGBufferLayout GBufferLayout { get { return m_GBufferLayout; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(GBufferLayout), this, m_GBufferLayout, value)) m_GBufferLayout = value; } } // 0x148 (328)
		
		protected int m_DrawDebugSkyEnvmapMipLevel = new int();
		[ContainerField(Name: "DrawDebugSkyEnvmapMipLevel", Offset: 332, NameHash: 1631282070, Flags: 49405), LayoutImmutable, Blittable]
		public int DrawDebugSkyEnvmapMipLevel { get { return m_DrawDebugSkyEnvmapMipLevel; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugSkyEnvmapMipLevel), this, m_DrawDebugSkyEnvmapMipLevel, value)) m_DrawDebugSkyEnvmapMipLevel = value; } } // 0x14C (332)
		
		protected float m_DecalVolumeScale = new float();
		[ContainerField(Name: "DecalVolumeScale", Offset: 336, NameHash: 4202430106, Flags: 49469), LayoutImmutable, Blittable]
		public float DecalVolumeScale { get { return m_DecalVolumeScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DecalVolumeScale), this, m_DecalVolumeScale, value)) m_DecalVolumeScale = value; } } // 0x150 (336)
		
		protected uint m_LightOverdrawMaxLayerCount = new uint();
		[ContainerField(Name: "LightOverdrawMaxLayerCount", Offset: 340, NameHash: 3901576513, Flags: 49421), LayoutImmutable, Blittable]
		public uint LightOverdrawMaxLayerCount { get { return m_LightOverdrawMaxLayerCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightOverdrawMaxLayerCount), this, m_LightOverdrawMaxLayerCount, value)) m_LightOverdrawMaxLayerCount = value; } } // 0x154 (340)
		
		protected float m_LightRadiusScale = new float();
		[ContainerField(Name: "LightRadiusScale", Offset: 344, NameHash: 2395431963, Flags: 49469), LayoutImmutable, Blittable]
		public float LightRadiusScale { get { return m_LightRadiusScale; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightRadiusScale), this, m_LightRadiusScale, value)) m_LightRadiusScale = value; } } // 0x158 (344)
		
		protected float m_LightAttenuationThreshold = new float();
		[ContainerField(Name: "LightAttenuationThreshold", Offset: 348, NameHash: 1982068814, Flags: 49469), LayoutImmutable, Blittable]
		public float LightAttenuationThreshold { get { return m_LightAttenuationThreshold; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightAttenuationThreshold), this, m_LightAttenuationThreshold, value)) m_LightAttenuationThreshold = value; } } // 0x15C (348)
		
		protected uint m_Ps3LightTileMethod = new uint();
		[ContainerField(Name: "Ps3LightTileMethod", Offset: 352, NameHash: 3693875840, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3LightTileMethod { get { return m_Ps3LightTileMethod; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3LightTileMethod), this, m_Ps3LightTileMethod, value)) m_Ps3LightTileMethod = value; } } // 0x160 (352)
		
		protected float m_Ps3LightTileJobYieldGranularity = new float();
		[ContainerField(Name: "Ps3LightTileJobYieldGranularity", Offset: 356, NameHash: 1369534961, Flags: 49469), LayoutImmutable, Blittable]
		public float Ps3LightTileJobYieldGranularity { get { return m_Ps3LightTileJobYieldGranularity; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3LightTileJobYieldGranularity), this, m_Ps3LightTileJobYieldGranularity, value)) m_Ps3LightTileJobYieldGranularity = value; } } // 0x164 (356)
		
		protected uint m_OutdoorLightTileBatchCount = new uint();
		[ContainerField(Name: "OutdoorLightTileBatchCount", Offset: 360, NameHash: 3807845992, Flags: 49421), LayoutImmutable, Blittable]
		public uint OutdoorLightTileBatchCount { get { return m_OutdoorLightTileBatchCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OutdoorLightTileBatchCount), this, m_OutdoorLightTileBatchCount, value)) m_OutdoorLightTileBatchCount = value; } } // 0x168 (360)
		
		protected uint m_XenonDrawDebugLightTileGridMode = new uint();
		[ContainerField(Name: "XenonDrawDebugLightTileGridMode", Offset: 364, NameHash: 357937911, Flags: 49421), LayoutImmutable, Blittable]
		public uint XenonDrawDebugLightTileGridMode { get { return m_XenonDrawDebugLightTileGridMode; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonDrawDebugLightTileGridMode), this, m_XenonDrawDebugLightTileGridMode, value)) m_XenonDrawDebugLightTileGridMode = value; } } // 0x16C (364)
		
		protected float m_LightStencilMinArea = new float();
		[ContainerField(Name: "LightStencilMinArea", Offset: 368, NameHash: 1614588396, Flags: 49469), LayoutImmutable, Blittable]
		public float LightStencilMinArea { get { return m_LightStencilMinArea; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightStencilMinArea), this, m_LightStencilMinArea, value)) m_LightStencilMinArea = value; } } // 0x170 (368)
		
		protected uint m_MaxSpotLightCount = new uint();
		[ContainerField(Name: "MaxSpotLightCount", Offset: 372, NameHash: 1180048180, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxSpotLightCount { get { return m_MaxSpotLightCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MaxSpotLightCount), this, m_MaxSpotLightCount, value)) m_MaxSpotLightCount = value; } } // 0x174 (372)
		
		protected MipmapFilterMode m_SkyEnvmapFilterMode = new MipmapFilterMode();
		[ContainerField(Name: "SkyEnvmapFilterMode", Offset: 376, NameHash: 3938625702, Flags: 137)]
		public MipmapFilterMode SkyEnvmapFilterMode { get { return m_SkyEnvmapFilterMode; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyEnvmapFilterMode), this, m_SkyEnvmapFilterMode, value)) m_SkyEnvmapFilterMode = value; } } // 0x178 (376)
		
		protected float m_SkyEnvmapFilterWidth = new float();
		[ContainerField(Name: "SkyEnvmapFilterWidth", Offset: 380, NameHash: 1142320547, Flags: 49469), LayoutImmutable, Blittable]
		public float SkyEnvmapFilterWidth { get { return m_SkyEnvmapFilterWidth; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyEnvmapFilterWidth), this, m_SkyEnvmapFilterWidth, value)) m_SkyEnvmapFilterWidth = value; } } // 0x17C (380)
		
		protected uint m_GBufferTestCount = new uint();
		[ContainerField(Name: "GBufferTestCount", Offset: 384, NameHash: 518179735, Flags: 49421), LayoutImmutable, Blittable]
		public uint GBufferTestCount { get { return m_GBufferTestCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(GBufferTestCount), this, m_GBufferTestCount, value)) m_GBufferTestCount = value; } } // 0x180 (384)
		
		protected uint m_SkyEnvmapResolution = new uint();
		[ContainerField(Name: "SkyEnvmapResolution", Offset: 388, NameHash: 2394614219, Flags: 49421), LayoutImmutable, Blittable]
		public uint SkyEnvmapResolution { get { return m_SkyEnvmapResolution; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyEnvmapResolution), this, m_SkyEnvmapResolution, value)) m_SkyEnvmapResolution = value; } } // 0x184 (388)
		
		protected uint m_SkyEnvmapSidesPerFrameCount = new uint();
		[ContainerField(Name: "SkyEnvmapSidesPerFrameCount", Offset: 392, NameHash: 1555842164, Flags: 49421), LayoutImmutable, Blittable]
		public uint SkyEnvmapSidesPerFrameCount { get { return m_SkyEnvmapSidesPerFrameCount; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyEnvmapSidesPerFrameCount), this, m_SkyEnvmapSidesPerFrameCount, value)) m_SkyEnvmapSidesPerFrameCount = value; } } // 0x188 (392)
		
		protected float m_SubSurfaceRolloffLocalLight = new float();
		[ContainerField(Name: "SubSurfaceRolloffLocalLight", Offset: 396, NameHash: 2057182293, Flags: 49469), LayoutImmutable, Blittable]
		public float SubSurfaceRolloffLocalLight { get { return m_SubSurfaceRolloffLocalLight; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SubSurfaceRolloffLocalLight), this, m_SubSurfaceRolloffLocalLight, value)) m_SubSurfaceRolloffLocalLight = value; } } // 0x18C (396)
		
		protected int m_OnlyTileIndex = new int();
		[ContainerField(Name: "OnlyTileIndex", Offset: 400, NameHash: 4080551099, Flags: 49405), LayoutImmutable, Blittable]
		public int OnlyTileIndex { get { return m_OnlyTileIndex; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OnlyTileIndex), this, m_OnlyTileIndex, value)) m_OnlyTileIndex = value; } } // 0x190 (400)
		
		protected bool m_OccluderMeshZPrepassEnable = new bool();
		[ContainerField(Name: "OccluderMeshZPrepassEnable", Offset: 404, NameHash: 1868101726, Flags: 49325), LayoutImmutable, Blittable]
		public bool OccluderMeshZPrepassEnable { get { return m_OccluderMeshZPrepassEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OccluderMeshZPrepassEnable), this, m_OccluderMeshZPrepassEnable, value)) m_OccluderMeshZPrepassEnable = value; } } // 0x194 (404)
		
		protected bool m_OccluderMeshZPrepassDebugEnable = new bool();
		[ContainerField(Name: "OccluderMeshZPrepassDebugEnable", Offset: 405, NameHash: 3504488559, Flags: 49325), LayoutImmutable, Blittable]
		public bool OccluderMeshZPrepassDebugEnable { get { return m_OccluderMeshZPrepassDebugEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OccluderMeshZPrepassDebugEnable), this, m_OccluderMeshZPrepassDebugEnable, value)) m_OccluderMeshZPrepassDebugEnable = value; } } // 0x195 (405)
		
		protected bool m_WireframeEnable = new bool();
		[ContainerField(Name: "WireframeEnable", Offset: 406, NameHash: 1610721584, Flags: 49325), LayoutImmutable, Blittable]
		public bool WireframeEnable { get { return m_WireframeEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(WireframeEnable), this, m_WireframeEnable, value)) m_WireframeEnable = value; } } // 0x196 (406)
		
		protected bool m_HalfResEnable = new bool();
		[ContainerField(Name: "HalfResEnable", Offset: 407, NameHash: 593088739, Flags: 49325), LayoutImmutable, Blittable]
		public bool HalfResEnable { get { return m_HalfResEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(HalfResEnable), this, m_HalfResEnable, value)) m_HalfResEnable = value; } } // 0x197 (407)
		
		protected bool m_HalfResLensFlaresEnable = new bool();
		[ContainerField(Name: "HalfResLensFlaresEnable", Offset: 408, NameHash: 4061822776, Flags: 49325), LayoutImmutable, Blittable]
		public bool HalfResLensFlaresEnable { get { return m_HalfResLensFlaresEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(HalfResLensFlaresEnable), this, m_HalfResLensFlaresEnable, value)) m_HalfResLensFlaresEnable = value; } } // 0x198 (408)
		
		protected bool m_ZPassEnable = new bool();
		[ContainerField(Name: "ZPassEnable", Offset: 409, NameHash: 4286745103, Flags: 49325), LayoutImmutable, Blittable]
		public bool ZPassEnable { get { return m_ZPassEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ZPassEnable), this, m_ZPassEnable, value)) m_ZPassEnable = value; } } // 0x199 (409)
		
		protected bool m_ForegroundEnable = new bool();
		[ContainerField(Name: "ForegroundEnable", Offset: 410, NameHash: 1970522271, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForegroundEnable { get { return m_ForegroundEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ForegroundEnable), this, m_ForegroundEnable, value)) m_ForegroundEnable = value; } } // 0x19A (410)
		
		protected bool m_TiledHalfResCompositeEnable = new bool();
		[ContainerField(Name: "TiledHalfResCompositeEnable", Offset: 411, NameHash: 2587067910, Flags: 49325), LayoutImmutable, Blittable]
		public bool TiledHalfResCompositeEnable { get { return m_TiledHalfResCompositeEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(TiledHalfResCompositeEnable), this, m_TiledHalfResCompositeEnable, value)) m_TiledHalfResCompositeEnable = value; } } // 0x19B (411)
		
		protected bool m_ForegroundZPassEnable = new bool();
		[ContainerField(Name: "ForegroundZPassEnable", Offset: 412, NameHash: 3501185556, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForegroundZPassEnable { get { return m_ForegroundZPassEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ForegroundZPassEnable), this, m_ForegroundZPassEnable, value)) m_ForegroundZPassEnable = value; } } // 0x19C (412)
		
		protected bool m_DrawDebugVelocityBuffer = new bool();
		[ContainerField(Name: "DrawDebugVelocityBuffer", Offset: 413, NameHash: 2582875939, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugVelocityBuffer { get { return m_DrawDebugVelocityBuffer; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugVelocityBuffer), this, m_DrawDebugVelocityBuffer, value)) m_DrawDebugVelocityBuffer = value; } } // 0x19D (413)
		
		protected bool m_ForegroundDepthClearEnable = new bool();
		[ContainerField(Name: "ForegroundDepthClearEnable", Offset: 414, NameHash: 1792351467, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForegroundDepthClearEnable { get { return m_ForegroundDepthClearEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ForegroundDepthClearEnable), this, m_ForegroundDepthClearEnable, value)) m_ForegroundDepthClearEnable = value; } } // 0x19E (414)
		
		protected bool m_ForegroundAsMainEnable = new bool();
		[ContainerField(Name: "ForegroundAsMainEnable", Offset: 415, NameHash: 3412436838, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForegroundAsMainEnable { get { return m_ForegroundAsMainEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ForegroundAsMainEnable), this, m_ForegroundAsMainEnable, value)) m_ForegroundAsMainEnable = value; } } // 0x19F (415)
		
		protected bool m_CustomEnvmapEnable = new bool();
		[ContainerField(Name: "CustomEnvmapEnable", Offset: 416, NameHash: 942753814, Flags: 49325), LayoutImmutable, Blittable]
		public bool CustomEnvmapEnable { get { return m_CustomEnvmapEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(CustomEnvmapEnable), this, m_CustomEnvmapEnable, value)) m_CustomEnvmapEnable = value; } } // 0x1A0 (416)
		
		protected bool m_SkyEnvmapEnable = new bool();
		[ContainerField(Name: "SkyEnvmapEnable", Offset: 417, NameHash: 24872004, Flags: 49325), LayoutImmutable, Blittable]
		public bool SkyEnvmapEnable { get { return m_SkyEnvmapEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyEnvmapEnable), this, m_SkyEnvmapEnable, value)) m_SkyEnvmapEnable = value; } } // 0x1A1 (417)
		
		protected bool m_DrawDebugVisibleEntityTypes = new bool();
		[ContainerField(Name: "DrawDebugVisibleEntityTypes", Offset: 418, NameHash: 1503612810, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugVisibleEntityTypes { get { return m_DrawDebugVisibleEntityTypes; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugVisibleEntityTypes), this, m_DrawDebugVisibleEntityTypes, value)) m_DrawDebugVisibleEntityTypes = value; } } // 0x1A2 (418)
		
		protected bool m_DrawDebugHalfResEnvironment = new bool();
		[ContainerField(Name: "DrawDebugHalfResEnvironment", Offset: 419, NameHash: 4269064774, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugHalfResEnvironment { get { return m_DrawDebugHalfResEnvironment; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugHalfResEnvironment), this, m_DrawDebugHalfResEnvironment, value)) m_DrawDebugHalfResEnvironment = value; } } // 0x1A3 (419)
		
		protected bool m_DrawSolidBoundingBoxes = new bool();
		[ContainerField(Name: "DrawSolidBoundingBoxes", Offset: 420, NameHash: 774505577, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawSolidBoundingBoxes { get { return m_DrawSolidBoundingBoxes; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawSolidBoundingBoxes), this, m_DrawSolidBoundingBoxes, value)) m_DrawSolidBoundingBoxes = value; } } // 0x1A4 (420)
		
		protected bool m_BilateralHalfResCompositeEnable = new bool();
		[ContainerField(Name: "BilateralHalfResCompositeEnable", Offset: 421, NameHash: 744838686, Flags: 49325), LayoutImmutable, Blittable]
		public bool BilateralHalfResCompositeEnable { get { return m_BilateralHalfResCompositeEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(BilateralHalfResCompositeEnable), this, m_BilateralHalfResCompositeEnable, value)) m_BilateralHalfResCompositeEnable = value; } } // 0x1A5 (421)
		
		protected bool m_ForegroundTransparentEnable = new bool();
		[ContainerField(Name: "ForegroundTransparentEnable", Offset: 422, NameHash: 103034393, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForegroundTransparentEnable { get { return m_ForegroundTransparentEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ForegroundTransparentEnable), this, m_ForegroundTransparentEnable, value)) m_ForegroundTransparentEnable = value; } } // 0x1A6 (422)
		
		protected bool m_TiledHalfResStencilOccludersEnable = new bool();
		[ContainerField(Name: "TiledHalfResStencilOccludersEnable", Offset: 423, NameHash: 3104302735, Flags: 49325), LayoutImmutable, Blittable]
		public bool TiledHalfResStencilOccludersEnable { get { return m_TiledHalfResStencilOccludersEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(TiledHalfResStencilOccludersEnable), this, m_TiledHalfResStencilOccludersEnable, value)) m_TiledHalfResStencilOccludersEnable = value; } } // 0x1A7 (423)
		
		protected bool m_SkyEnvmapUpdateEnable = new bool();
		[ContainerField(Name: "SkyEnvmapUpdateEnable", Offset: 424, NameHash: 1443363541, Flags: 49325), LayoutImmutable, Blittable]
		public bool SkyEnvmapUpdateEnable { get { return m_SkyEnvmapUpdateEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyEnvmapUpdateEnable), this, m_SkyEnvmapUpdateEnable, value)) m_SkyEnvmapUpdateEnable = value; } } // 0x1A8 (424)
		
		protected bool m_SkyEnvmapForceUpdateEnable = new bool();
		[ContainerField(Name: "SkyEnvmapForceUpdateEnable", Offset: 425, NameHash: 2268461288, Flags: 49325), LayoutImmutable, Blittable]
		public bool SkyEnvmapForceUpdateEnable { get { return m_SkyEnvmapForceUpdateEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyEnvmapForceUpdateEnable), this, m_SkyEnvmapForceUpdateEnable, value)) m_SkyEnvmapForceUpdateEnable = value; } } // 0x1A9 (425)
		
		protected bool m_SkyEnvmapUse8BitTexture = new bool();
		[ContainerField(Name: "SkyEnvmapUse8BitTexture", Offset: 426, NameHash: 486850942, Flags: 49325), LayoutImmutable, Blittable]
		public bool SkyEnvmapUse8BitTexture { get { return m_SkyEnvmapUse8BitTexture; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyEnvmapUse8BitTexture), this, m_SkyEnvmapUse8BitTexture, value)) m_SkyEnvmapUse8BitTexture = value; } } // 0x1AA (426)
		
		protected bool m_DynamicEnvmapEnable = new bool();
		[ContainerField(Name: "DynamicEnvmapEnable", Offset: 427, NameHash: 2364859152, Flags: 49325), LayoutImmutable, Blittable]
		public bool DynamicEnvmapEnable { get { return m_DynamicEnvmapEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DynamicEnvmapEnable), this, m_DynamicEnvmapEnable, value)) m_DynamicEnvmapEnable = value; } } // 0x1AB (427)
		
		protected bool m_ScreenEffectEnable = new bool();
		[ContainerField(Name: "ScreenEffectEnable", Offset: 428, NameHash: 2601139327, Flags: 49325), LayoutImmutable, Blittable]
		public bool ScreenEffectEnable { get { return m_ScreenEffectEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ScreenEffectEnable), this, m_ScreenEffectEnable, value)) m_ScreenEffectEnable = value; } } // 0x1AC (428)
		
		protected bool m_DrawDebugZBufferEnable = new bool();
		[ContainerField(Name: "DrawDebugZBufferEnable", Offset: 429, NameHash: 1169913743, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugZBufferEnable { get { return m_DrawDebugZBufferEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugZBufferEnable), this, m_DrawDebugZBufferEnable, value)) m_DrawDebugZBufferEnable = value; } } // 0x1AD (429)
		
		protected bool m_MotionBlurStencilPassEnable = new bool();
		[ContainerField(Name: "MotionBlurStencilPassEnable", Offset: 430, NameHash: 2767114856, Flags: 49325), LayoutImmutable, Blittable]
		public bool MotionBlurStencilPassEnable { get { return m_MotionBlurStencilPassEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MotionBlurStencilPassEnable), this, m_MotionBlurStencilPassEnable, value)) m_MotionBlurStencilPassEnable = value; } } // 0x1AE (430)
		
		protected bool m_FinalPostEnable = new bool();
		[ContainerField(Name: "FinalPostEnable", Offset: 431, NameHash: 3552597328, Flags: 49325), LayoutImmutable, Blittable]
		public bool FinalPostEnable { get { return m_FinalPostEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(FinalPostEnable), this, m_FinalPostEnable, value)) m_FinalPostEnable = value; } } // 0x1AF (431)
		
		protected bool m_DrawDebugQuarterShadowmaps = new bool();
		[ContainerField(Name: "DrawDebugQuarterShadowmaps", Offset: 432, NameHash: 1883382345, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugQuarterShadowmaps { get { return m_DrawDebugQuarterShadowmaps; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugQuarterShadowmaps), this, m_DrawDebugQuarterShadowmaps, value)) m_DrawDebugQuarterShadowmaps = value; } } // 0x1B0 (432)
		
		protected bool m_DrawDebugSkyEnvmap = new bool();
		[ContainerField(Name: "DrawDebugSkyEnvmap", Offset: 433, NameHash: 1029929588, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugSkyEnvmap { get { return m_DrawDebugSkyEnvmap; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugSkyEnvmap), this, m_DrawDebugSkyEnvmap, value)) m_DrawDebugSkyEnvmap = value; } } // 0x1B1 (433)
		
		protected bool m_DxShadowmap16BitEnable = new bool();
		[ContainerField(Name: "DxShadowmap16BitEnable", Offset: 434, NameHash: 3461804538, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxShadowmap16BitEnable { get { return m_DxShadowmap16BitEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DxShadowmap16BitEnable), this, m_DxShadowmap16BitEnable, value)) m_DxShadowmap16BitEnable = value; } } // 0x1B2 (434)
		
		protected bool m_DrawDebugTransShadowmap = new bool();
		[ContainerField(Name: "DrawDebugTransShadowmap", Offset: 435, NameHash: 3838688308, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugTransShadowmap { get { return m_DrawDebugTransShadowmap; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugTransShadowmap), this, m_DrawDebugTransShadowmap, value)) m_DrawDebugTransShadowmap = value; } } // 0x1B3 (435)
		
		protected bool m_DrawDebugSpotLightShadowmaps = new bool();
		[ContainerField(Name: "DrawDebugSpotLightShadowmaps", Offset: 436, NameHash: 2380030875, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugSpotLightShadowmaps { get { return m_DrawDebugSpotLightShadowmaps; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugSpotLightShadowmaps), this, m_DrawDebugSpotLightShadowmaps, value)) m_DrawDebugSpotLightShadowmaps = value; } } // 0x1B4 (436)
		
		protected bool m_DrawShadowFrustums = new bool();
		[ContainerField(Name: "DrawShadowFrustums", Offset: 437, NameHash: 2870709294, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawShadowFrustums { get { return m_DrawShadowFrustums; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawShadowFrustums), this, m_DrawShadowFrustums, value)) m_DrawShadowFrustums = value; } } // 0x1B5 (437)
		
		protected bool m_DrawDebugShadowmaps = new bool();
		[ContainerField(Name: "DrawDebugShadowmaps", Offset: 438, NameHash: 3102950941, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugShadowmaps { get { return m_DrawDebugShadowmaps; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugShadowmaps), this, m_DrawDebugShadowmaps, value)) m_DrawDebugShadowmaps = value; } } // 0x1B6 (438)
		
		protected bool m_SkyEnable = new bool();
		[ContainerField(Name: "SkyEnable", Offset: 439, NameHash: 4052097317, Flags: 49325), LayoutImmutable, Blittable]
		public bool SkyEnable { get { return m_SkyEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyEnable), this, m_SkyEnable, value)) m_SkyEnable = value; } } // 0x1B7 (439)
		
		protected bool m_DrawBoundingSpheres = new bool();
		[ContainerField(Name: "DrawBoundingSpheres", Offset: 440, NameHash: 815981309, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawBoundingSpheres { get { return m_DrawBoundingSpheres; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawBoundingSpheres), this, m_DrawBoundingSpheres, value)) m_DrawBoundingSpheres = value; } } // 0x1B8 (440)
		
		protected bool m_DrawFrustums = new bool();
		[ContainerField(Name: "DrawFrustums", Offset: 441, NameHash: 2141195304, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawFrustums { get { return m_DrawFrustums; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawFrustums), this, m_DrawFrustums, value)) m_DrawFrustums = value; } } // 0x1B9 (441)
		
		protected bool m_StaticEnvmapEnable = new bool();
		[ContainerField(Name: "StaticEnvmapEnable", Offset: 442, NameHash: 959292189, Flags: 49325), LayoutImmutable, Blittable]
		public bool StaticEnvmapEnable { get { return m_StaticEnvmapEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(StaticEnvmapEnable), this, m_StaticEnvmapEnable, value)) m_StaticEnvmapEnable = value; } } // 0x1BA (442)
		
		protected bool m_SkyFogEnable = new bool();
		[ContainerField(Name: "SkyFogEnable", Offset: 443, NameHash: 3354775883, Flags: 49325), LayoutImmutable, Blittable]
		public bool SkyFogEnable { get { return m_SkyFogEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyFogEnable), this, m_SkyFogEnable, value)) m_SkyFogEnable = value; } } // 0x1BB (443)
		
		protected bool m_DrawLineBoundingBoxes = new bool();
		[ContainerField(Name: "DrawLineBoundingBoxes", Offset: 444, NameHash: 320578522, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawLineBoundingBoxes { get { return m_DrawLineBoundingBoxes; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawLineBoundingBoxes), this, m_DrawLineBoundingBoxes, value)) m_DrawLineBoundingBoxes = value; } } // 0x1BC (444)
		
		protected bool m_DrawDebugDestructionVolumes = new bool();
		[ContainerField(Name: "DrawDebugDestructionVolumes", Offset: 445, NameHash: 3877557809, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugDestructionVolumes { get { return m_DrawDebugDestructionVolumes; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugDestructionVolumes), this, m_DrawDebugDestructionVolumes, value)) m_DrawDebugDestructionVolumes = value; } } // 0x1BD (445)
		
		protected bool m_LensFlaresEnable = new bool();
		[ContainerField(Name: "LensFlaresEnable", Offset: 446, NameHash: 3334093503, Flags: 49325), LayoutImmutable, Blittable]
		public bool LensFlaresEnable { get { return m_LensFlaresEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LensFlaresEnable), this, m_LensFlaresEnable, value)) m_LensFlaresEnable = value; } } // 0x1BE (446)
		
		protected bool m_DrawDebugLensFlareOccluders = new bool();
		[ContainerField(Name: "DrawDebugLensFlareOccluders", Offset: 447, NameHash: 242868074, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLensFlareOccluders { get { return m_DrawDebugLensFlareOccluders; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugLensFlareOccluders), this, m_DrawDebugLensFlareOccluders, value)) m_DrawDebugLensFlareOccluders = value; } } // 0x1BF (447)
		
		protected bool m_DrawDebugLensFlares = new bool();
		[ContainerField(Name: "DrawDebugLensFlares", Offset: 448, NameHash: 2716428527, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLensFlares { get { return m_DrawDebugLensFlares; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugLensFlares), this, m_DrawDebugLensFlares, value)) m_DrawDebugLensFlares = value; } } // 0x1C0 (448)
		
		protected bool m_LensFlareOcclusionEnable = new bool();
		[ContainerField(Name: "LensFlareOcclusionEnable", Offset: 449, NameHash: 1840684577, Flags: 49325), LayoutImmutable, Blittable]
		public bool LensFlareOcclusionEnable { get { return m_LensFlareOcclusionEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LensFlareOcclusionEnable), this, m_LensFlareOcclusionEnable, value)) m_LensFlareOcclusionEnable = value; } } // 0x1C1 (449)
		
		protected bool m_DrawDebugWorldOcclusions = new bool();
		[ContainerField(Name: "DrawDebugWorldOcclusions", Offset: 450, NameHash: 1836462056, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugWorldOcclusions { get { return m_DrawDebugWorldOcclusions; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugWorldOcclusions), this, m_DrawDebugWorldOcclusions, value)) m_DrawDebugWorldOcclusions = value; } } // 0x1C2 (450)
		
		protected bool m_CloudShadowEnable = new bool();
		[ContainerField(Name: "CloudShadowEnable", Offset: 451, NameHash: 380549299, Flags: 49325), LayoutImmutable, Blittable]
		public bool CloudShadowEnable { get { return m_CloudShadowEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(CloudShadowEnable), this, m_CloudShadowEnable, value)) m_CloudShadowEnable = value; } } // 0x1C3 (451)
		
		protected bool m_OverrideDynamicAO = new bool();
		[ContainerField(Name: "OverrideDynamicAO", Offset: 452, NameHash: 4100682570, Flags: 49325), LayoutImmutable, Blittable]
		public bool OverrideDynamicAO { get { return m_OverrideDynamicAO; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OverrideDynamicAO), this, m_OverrideDynamicAO, value)) m_OverrideDynamicAO = value; } } // 0x1C4 (452)
		
		protected bool m_DrawDebugDynamicAO = new bool();
		[ContainerField(Name: "DrawDebugDynamicAO", Offset: 453, NameHash: 2076410863, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugDynamicAO { get { return m_DrawDebugDynamicAO; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugDynamicAO), this, m_DrawDebugDynamicAO, value)) m_DrawDebugDynamicAO = value; } } // 0x1C5 (453)
		
		protected bool m_EmissiveEnable = new bool();
		[ContainerField(Name: "EmissiveEnable", Offset: 454, NameHash: 3278293887, Flags: 49325), LayoutImmutable, Blittable]
		public bool EmissiveEnable { get { return m_EmissiveEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(EmissiveEnable), this, m_EmissiveEnable, value)) m_EmissiveEnable = value; } } // 0x1C6 (454)
		
		protected bool m_UnlitEnable = new bool();
		[ContainerField(Name: "UnlitEnable", Offset: 455, NameHash: 1089017582, Flags: 49325), LayoutImmutable, Blittable]
		public bool UnlitEnable { get { return m_UnlitEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(UnlitEnable), this, m_UnlitEnable, value)) m_UnlitEnable = value; } } // 0x1C7 (455)
		
		protected bool m_SkyEnvmapMipmapGenEnable = new bool();
		[ContainerField(Name: "SkyEnvmapMipmapGenEnable", Offset: 456, NameHash: 1514667872, Flags: 49325), LayoutImmutable, Blittable]
		public bool SkyEnvmapMipmapGenEnable { get { return m_SkyEnvmapMipmapGenEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyEnvmapMipmapGenEnable), this, m_SkyEnvmapMipmapGenEnable, value)) m_SkyEnvmapMipmapGenEnable = value; } } // 0x1C8 (456)
		
		protected bool m_DrawLightSources = new bool();
		[ContainerField(Name: "DrawLightSources", Offset: 457, NameHash: 2462812853, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawLightSources { get { return m_DrawLightSources; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawLightSources), this, m_DrawLightSources, value)) m_DrawLightSources = value; } } // 0x1C9 (457)
		
		protected bool m_GBufferClearEnable = new bool();
		[ContainerField(Name: "GBufferClearEnable", Offset: 458, NameHash: 1575849658, Flags: 49325), LayoutImmutable, Blittable]
		public bool GBufferClearEnable { get { return m_GBufferClearEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(GBufferClearEnable), this, m_GBufferClearEnable, value)) m_GBufferClearEnable = value; } } // 0x1CA (458)
		
		protected bool m_DxGBufferLight16BitEnable = new bool();
		[ContainerField(Name: "DxGBufferLight16BitEnable", Offset: 459, NameHash: 108346297, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxGBufferLight16BitEnable { get { return m_DxGBufferLight16BitEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DxGBufferLight16BitEnable), this, m_DxGBufferLight16BitEnable, value)) m_DxGBufferLight16BitEnable = value; } } // 0x1CB (459)
		
		protected bool m_DxGBufferNormal16BitEnable = new bool();
		[ContainerField(Name: "DxGBufferNormal16BitEnable", Offset: 460, NameHash: 1352763380, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxGBufferNormal16BitEnable { get { return m_DxGBufferNormal16BitEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DxGBufferNormal16BitEnable), this, m_DxGBufferNormal16BitEnable, value)) m_DxGBufferNormal16BitEnable = value; } } // 0x1CC (460)
		
		protected bool m_GBufferAlphaTestSimpleEnable = new bool();
		[ContainerField(Name: "GBufferAlphaTestSimpleEnable", Offset: 461, NameHash: 4261956399, Flags: 49325), LayoutImmutable, Blittable]
		public bool GBufferAlphaTestSimpleEnable { get { return m_GBufferAlphaTestSimpleEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(GBufferAlphaTestSimpleEnable), this, m_GBufferAlphaTestSimpleEnable, value)) m_GBufferAlphaTestSimpleEnable = value; } } // 0x1CD (461)
		
		protected bool m_SpecularLightingEnable = new bool();
		[ContainerField(Name: "SpecularLightingEnable", Offset: 462, NameHash: 4059295125, Flags: 49325), LayoutImmutable, Blittable]
		public bool SpecularLightingEnable { get { return m_SpecularLightingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SpecularLightingEnable), this, m_SpecularLightingEnable, value)) m_SpecularLightingEnable = value; } } // 0x1CE (462)
		
		protected bool m_SkinLightingEnable = new bool();
		[ContainerField(Name: "SkinLightingEnable", Offset: 463, NameHash: 1314853573, Flags: 49325), LayoutImmutable, Blittable]
		public bool SkinLightingEnable { get { return m_SkinLightingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkinLightingEnable), this, m_SkinLightingEnable, value)) m_SkinLightingEnable = value; } } // 0x1CF (463)
		
		protected bool m_TranslucencyLightingEnable = new bool();
		[ContainerField(Name: "TranslucencyLightingEnable", Offset: 464, NameHash: 2183602155, Flags: 49325), LayoutImmutable, Blittable]
		public bool TranslucencyLightingEnable { get { return m_TranslucencyLightingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(TranslucencyLightingEnable), this, m_TranslucencyLightingEnable, value)) m_TranslucencyLightingEnable = value; } } // 0x1D0 (464)
		
		protected bool m_DynamicEnvmapLightingEnable = new bool();
		[ContainerField(Name: "DynamicEnvmapLightingEnable", Offset: 465, NameHash: 498214414, Flags: 49325), LayoutImmutable, Blittable]
		public bool DynamicEnvmapLightingEnable { get { return m_DynamicEnvmapLightingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DynamicEnvmapLightingEnable), this, m_DynamicEnvmapLightingEnable, value)) m_DynamicEnvmapLightingEnable = value; } } // 0x1D1 (465)
		
		protected bool m_OutdoorLightEnable = new bool();
		[ContainerField(Name: "OutdoorLightEnable", Offset: 466, NameHash: 430661890, Flags: 49325), LayoutImmutable, Blittable]
		public bool OutdoorLightEnable { get { return m_OutdoorLightEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OutdoorLightEnable), this, m_OutdoorLightEnable, value)) m_OutdoorLightEnable = value; } } // 0x1D2 (466)
		
		protected bool m_PointLightsEnable = new bool();
		[ContainerField(Name: "PointLightsEnable", Offset: 467, NameHash: 4141437477, Flags: 49325), LayoutImmutable, Blittable]
		public bool PointLightsEnable { get { return m_PointLightsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(PointLightsEnable), this, m_PointLightsEnable, value)) m_PointLightsEnable = value; } } // 0x1D3 (467)
		
		protected bool m_LineLightsEnable = new bool();
		[ContainerField(Name: "LineLightsEnable", Offset: 468, NameHash: 3741175111, Flags: 49325), LayoutImmutable, Blittable]
		public bool LineLightsEnable { get { return m_LineLightsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LineLightsEnable), this, m_LineLightsEnable, value)) m_LineLightsEnable = value; } } // 0x1D4 (468)
		
		protected bool m_ConeLightsEnable = new bool();
		[ContainerField(Name: "ConeLightsEnable", Offset: 469, NameHash: 3836085742, Flags: 49325), LayoutImmutable, Blittable]
		public bool ConeLightsEnable { get { return m_ConeLightsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ConeLightsEnable), this, m_ConeLightsEnable, value)) m_ConeLightsEnable = value; } } // 0x1D5 (469)
		
		protected bool m_SpotLightsEnable = new bool();
		[ContainerField(Name: "SpotLightsEnable", Offset: 470, NameHash: 3322632337, Flags: 49325), LayoutImmutable, Blittable]
		public bool SpotLightsEnable { get { return m_SpotLightsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SpotLightsEnable), this, m_SpotLightsEnable, value)) m_SpotLightsEnable = value; } } // 0x1D6 (470)
		
		protected bool m_LightProbesEnable = new bool();
		[ContainerField(Name: "LightProbesEnable", Offset: 471, NameHash: 2698387843, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightProbesEnable { get { return m_LightProbesEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightProbesEnable), this, m_LightProbesEnable, value)) m_LightProbesEnable = value; } } // 0x1D7 (471)
		
		protected bool m_LightStencilMethodEnable = new bool();
		[ContainerField(Name: "LightStencilMethodEnable", Offset: 472, NameHash: 2357499407, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightStencilMethodEnable { get { return m_LightStencilMethodEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightStencilMethodEnable), this, m_LightStencilMethodEnable, value)) m_LightStencilMethodEnable = value; } } // 0x1D8 (472)
		
		protected bool m_LightVolumeMethodEnable = new bool();
		[ContainerField(Name: "LightVolumeMethodEnable", Offset: 473, NameHash: 4215208333, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightVolumeMethodEnable { get { return m_LightVolumeMethodEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightVolumeMethodEnable), this, m_LightVolumeMethodEnable, value)) m_LightVolumeMethodEnable = value; } } // 0x1D9 (473)
		
		protected bool m_LightVolumeDepthTestEnable = new bool();
		[ContainerField(Name: "LightVolumeDepthTestEnable", Offset: 474, NameHash: 2053389737, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightVolumeDepthTestEnable { get { return m_LightVolumeDepthTestEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightVolumeDepthTestEnable), this, m_LightVolumeDepthTestEnable, value)) m_LightVolumeDepthTestEnable = value; } } // 0x1DA (474)
		
		protected bool m_OutputGammaCorrectionEnable = new bool();
		[ContainerField(Name: "OutputGammaCorrectionEnable", Offset: 475, NameHash: 1247904586, Flags: 49325), LayoutImmutable, Blittable]
		public bool OutputGammaCorrectionEnable { get { return m_OutputGammaCorrectionEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OutputGammaCorrectionEnable), this, m_OutputGammaCorrectionEnable, value)) m_OutputGammaCorrectionEnable = value; } } // 0x1DB (475)
		
		protected bool m_DrawDebugMultisampleClassify = new bool();
		[ContainerField(Name: "DrawDebugMultisampleClassify", Offset: 476, NameHash: 2597933379, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugMultisampleClassify { get { return m_DrawDebugMultisampleClassify; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugMultisampleClassify), this, m_DrawDebugMultisampleClassify, value)) m_DrawDebugMultisampleClassify = value; } } // 0x1DC (476)
		
		protected bool m_OutdoorKeyLightEnable = new bool();
		[ContainerField(Name: "OutdoorKeyLightEnable", Offset: 477, NameHash: 3309610805, Flags: 49325), LayoutImmutable, Blittable]
		public bool OutdoorKeyLightEnable { get { return m_OutdoorKeyLightEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OutdoorKeyLightEnable), this, m_OutdoorKeyLightEnable, value)) m_OutdoorKeyLightEnable = value; } } // 0x1DD (477)
		
		protected bool m_OutdoorSkyLightEnable = new bool();
		[ContainerField(Name: "OutdoorSkyLightEnable", Offset: 478, NameHash: 3067691555, Flags: 49325), LayoutImmutable, Blittable]
		public bool OutdoorSkyLightEnable { get { return m_OutdoorSkyLightEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OutdoorSkyLightEnable), this, m_OutdoorSkyLightEnable, value)) m_OutdoorSkyLightEnable = value; } } // 0x1DE (478)
		
		protected bool m_OutdoorLightSpecularEnable = new bool();
		[ContainerField(Name: "OutdoorLightSpecularEnable", Offset: 479, NameHash: 4075788653, Flags: 49325), LayoutImmutable, Blittable]
		public bool OutdoorLightSpecularEnable { get { return m_OutdoorLightSpecularEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OutdoorLightSpecularEnable), this, m_OutdoorLightSpecularEnable, value)) m_OutdoorLightSpecularEnable = value; } } // 0x1DF (479)
		
		protected bool m_OutdoorLightTilingEnable = new bool();
		[ContainerField(Name: "OutdoorLightTilingEnable", Offset: 480, NameHash: 916476147, Flags: 49325), LayoutImmutable, Blittable]
		public bool OutdoorLightTilingEnable { get { return m_OutdoorLightTilingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OutdoorLightTilingEnable), this, m_OutdoorLightTilingEnable, value)) m_OutdoorLightTilingEnable = value; } } // 0x1E0 (480)
		
		protected bool m_OutdoorLightTileRenderEnable = new bool();
		[ContainerField(Name: "OutdoorLightTileRenderEnable", Offset: 481, NameHash: 2607928252, Flags: 49325), LayoutImmutable, Blittable]
		public bool OutdoorLightTileRenderEnable { get { return m_OutdoorLightTileRenderEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OutdoorLightTileRenderEnable), this, m_OutdoorLightTileRenderEnable, value)) m_OutdoorLightTileRenderEnable = value; } } // 0x1E1 (481)
		
		protected bool m_OutdoorLightTileBlendEnable = new bool();
		[ContainerField(Name: "OutdoorLightTileBlendEnable", Offset: 482, NameHash: 2912986711, Flags: 49325), LayoutImmutable, Blittable]
		public bool OutdoorLightTileBlendEnable { get { return m_OutdoorLightTileBlendEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OutdoorLightTileBlendEnable), this, m_OutdoorLightTileBlendEnable, value)) m_OutdoorLightTileBlendEnable = value; } } // 0x1E2 (482)
		
		protected bool m_OutdoorLightTileSimpleShaderEnable = new bool();
		[ContainerField(Name: "OutdoorLightTileSimpleShaderEnable", Offset: 483, NameHash: 3559242705, Flags: 49325), LayoutImmutable, Blittable]
		public bool OutdoorLightTileSimpleShaderEnable { get { return m_OutdoorLightTileSimpleShaderEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OutdoorLightTileSimpleShaderEnable), this, m_OutdoorLightTileSimpleShaderEnable, value)) m_OutdoorLightTileSimpleShaderEnable = value; } } // 0x1E3 (483)
		
		protected bool m_Ps3TiledHalfTargetEnable = new bool();
		[ContainerField(Name: "Ps3TiledHalfTargetEnable", Offset: 484, NameHash: 3181214902, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TiledHalfTargetEnable { get { return m_Ps3TiledHalfTargetEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3TiledHalfTargetEnable), this, m_Ps3TiledHalfTargetEnable, value)) m_Ps3TiledHalfTargetEnable = value; } } // 0x1E4 (484)
		
		protected bool m_XenonOutdoorLightTilingEnable = new bool();
		[ContainerField(Name: "XenonOutdoorLightTilingEnable", Offset: 485, NameHash: 4098755329, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonOutdoorLightTilingEnable { get { return m_XenonOutdoorLightTilingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonOutdoorLightTilingEnable), this, m_XenonOutdoorLightTilingEnable, value)) m_XenonOutdoorLightTilingEnable = value; } } // 0x1E5 (485)
		
		protected bool m_XenonPointLightsTilingEnable = new bool();
		[ContainerField(Name: "XenonPointLightsTilingEnable", Offset: 486, NameHash: 1965396134, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonPointLightsTilingEnable { get { return m_XenonPointLightsTilingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonPointLightsTilingEnable), this, m_XenonPointLightsTilingEnable, value)) m_XenonPointLightsTilingEnable = value; } } // 0x1E6 (486)
		
		protected bool m_XenonSpotLightsTilingEnable = new bool();
		[ContainerField(Name: "XenonSpotLightsTilingEnable", Offset: 487, NameHash: 1124054354, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonSpotLightsTilingEnable { get { return m_XenonSpotLightsTilingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonSpotLightsTilingEnable), this, m_XenonSpotLightsTilingEnable, value)) m_XenonSpotLightsTilingEnable = value; } } // 0x1E7 (487)
		
		protected bool m_XenonLineLightsTilingEnable = new bool();
		[ContainerField(Name: "XenonLineLightsTilingEnable", Offset: 488, NameHash: 251521284, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonLineLightsTilingEnable { get { return m_XenonLineLightsTilingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonLineLightsTilingEnable), this, m_XenonLineLightsTilingEnable, value)) m_XenonLineLightsTilingEnable = value; } } // 0x1E8 (488)
		
		protected bool m_XenonAsyncLightJobsEnable = new bool();
		[ContainerField(Name: "XenonAsyncLightJobsEnable", Offset: 489, NameHash: 415268666, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonAsyncLightJobsEnable { get { return m_XenonAsyncLightJobsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonAsyncLightJobsEnable), this, m_XenonAsyncLightJobsEnable, value)) m_XenonAsyncLightJobsEnable = value; } } // 0x1E9 (489)
		
		protected bool m_XenonLightTileDownsampleSpecularCheckEnable = new bool();
		[ContainerField(Name: "XenonLightTileDownsampleSpecularCheckEnable", Offset: 490, NameHash: 2247224033, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonLightTileDownsampleSpecularCheckEnable { get { return m_XenonLightTileDownsampleSpecularCheckEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonLightTileDownsampleSpecularCheckEnable), this, m_XenonLightTileDownsampleSpecularCheckEnable, value)) m_XenonLightTileDownsampleSpecularCheckEnable = value; } } // 0x1EA (490)
		
		protected bool m_XenonLightTileCpuPointLightCullingEnable = new bool();
		[ContainerField(Name: "XenonLightTileCpuPointLightCullingEnable", Offset: 491, NameHash: 3217869342, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonLightTileCpuPointLightCullingEnable { get { return m_XenonLightTileCpuPointLightCullingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonLightTileCpuPointLightCullingEnable), this, m_XenonLightTileCpuPointLightCullingEnable, value)) m_XenonLightTileCpuPointLightCullingEnable = value; } } // 0x1EB (491)
		
		protected bool m_Ps3TiledSSAOTargetsEnable = new bool();
		[ContainerField(Name: "Ps3TiledSSAOTargetsEnable", Offset: 492, NameHash: 146196904, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TiledSSAOTargetsEnable { get { return m_Ps3TiledSSAOTargetsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3TiledSSAOTargetsEnable), this, m_Ps3TiledSSAOTargetsEnable, value)) m_Ps3TiledSSAOTargetsEnable = value; } } // 0x1EC (492)
		
		protected bool m_Ps3SCullEnable = new bool();
		[ContainerField(Name: "Ps3SCullEnable", Offset: 493, NameHash: 3556523217, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3SCullEnable { get { return m_Ps3SCullEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3SCullEnable), this, m_Ps3SCullEnable, value)) m_Ps3SCullEnable = value; } } // 0x1ED (493)
		
		protected bool m_Ps3ColorCompressionEnable = new bool();
		[ContainerField(Name: "Ps3ColorCompressionEnable", Offset: 494, NameHash: 1639633735, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3ColorCompressionEnable { get { return m_Ps3ColorCompressionEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3ColorCompressionEnable), this, m_Ps3ColorCompressionEnable, value)) m_Ps3ColorCompressionEnable = value; } } // 0x1EE (494)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 495, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x1EF (495)
		
		protected bool m_Ps3TilingEnable = new bool();
		[ContainerField(Name: "Ps3TilingEnable", Offset: 496, NameHash: 5401221, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3TilingEnable { get { return m_Ps3TilingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3TilingEnable), this, m_Ps3TilingEnable, value)) m_Ps3TilingEnable = value; } } // 0x1F0 (496)
		
		protected bool m_Ps3DepthBoundsLightCullingEnable = new bool();
		[ContainerField(Name: "Ps3DepthBoundsLightCullingEnable", Offset: 497, NameHash: 3033595312, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3DepthBoundsLightCullingEnable { get { return m_Ps3DepthBoundsLightCullingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3DepthBoundsLightCullingEnable), this, m_Ps3DepthBoundsLightCullingEnable, value)) m_Ps3DepthBoundsLightCullingEnable = value; } } // 0x1F1 (497)
		
		protected bool m_Ps3ZCullEnable = new bool();
		[ContainerField(Name: "Ps3ZCullEnable", Offset: 498, NameHash: 3239977624, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3ZCullEnable { get { return m_Ps3ZCullEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3ZCullEnable), this, m_Ps3ZCullEnable, value)) m_Ps3ZCullEnable = value; } } // 0x1F2 (498)
		
		protected bool m_ConsoleRenderTargetPoolSharingEnable = new bool();
		[ContainerField(Name: "ConsoleRenderTargetPoolSharingEnable", Offset: 499, NameHash: 1444307324, Flags: 49325), LayoutImmutable, Blittable]
		public bool ConsoleRenderTargetPoolSharingEnable { get { return m_ConsoleRenderTargetPoolSharingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ConsoleRenderTargetPoolSharingEnable), this, m_ConsoleRenderTargetPoolSharingEnable, value)) m_ConsoleRenderTargetPoolSharingEnable = value; } } // 0x1F3 (499)
		
		protected bool m_XenonFloatDepthBufferEnable = new bool();
		[ContainerField(Name: "XenonFloatDepthBufferEnable", Offset: 500, NameHash: 1905490891, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonFloatDepthBufferEnable { get { return m_XenonFloatDepthBufferEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonFloatDepthBufferEnable), this, m_XenonFloatDepthBufferEnable, value)) m_XenonFloatDepthBufferEnable = value; } } // 0x1F4 (500)
		
		protected bool m_Ps3LightTileJobYieldEnable = new bool();
		[ContainerField(Name: "Ps3LightTileJobYieldEnable", Offset: 501, NameHash: 2197108900, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3LightTileJobYieldEnable { get { return m_Ps3LightTileJobYieldEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3LightTileJobYieldEnable), this, m_Ps3LightTileJobYieldEnable, value)) m_Ps3LightTileJobYieldEnable = value; } } // 0x1F5 (501)
		
		protected bool m_Ps3HdrClearEnable = new bool();
		[ContainerField(Name: "Ps3HdrClearEnable", Offset: 502, NameHash: 2730638227, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3HdrClearEnable { get { return m_Ps3HdrClearEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3HdrClearEnable), this, m_Ps3HdrClearEnable, value)) m_Ps3HdrClearEnable = value; } } // 0x1F6 (502)
		
		protected bool m_XenonFastHdrEnable = new bool();
		[ContainerField(Name: "XenonFastHdrEnable", Offset: 503, NameHash: 519764264, Flags: 49325), LayoutImmutable, Blittable]
		public bool XenonFastHdrEnable { get { return m_XenonFastHdrEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(XenonFastHdrEnable), this, m_XenonFastHdrEnable, value)) m_XenonFastHdrEnable = value; } } // 0x1F7 (503)
		
		protected bool m_ShadowmapViewDistanceScaleEnable = new bool();
		[ContainerField(Name: "ShadowmapViewDistanceScaleEnable", Offset: 504, NameHash: 2533957960, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShadowmapViewDistanceScaleEnable { get { return m_ShadowmapViewDistanceScaleEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapViewDistanceScaleEnable), this, m_ShadowmapViewDistanceScaleEnable, value)) m_ShadowmapViewDistanceScaleEnable = value; } } // 0x1F8 (504)
		
		protected bool m_Ps3RenderTargetPoolGBufferOffsetEnable = new bool();
		[ContainerField(Name: "Ps3RenderTargetPoolGBufferOffsetEnable", Offset: 505, NameHash: 1147234777, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3RenderTargetPoolGBufferOffsetEnable { get { return m_Ps3RenderTargetPoolGBufferOffsetEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3RenderTargetPoolGBufferOffsetEnable), this, m_Ps3RenderTargetPoolGBufferOffsetEnable, value)) m_Ps3RenderTargetPoolGBufferOffsetEnable = value; } } // 0x1F9 (505)
		
		protected bool m_HdrEnable = new bool();
		[ContainerField(Name: "HdrEnable", Offset: 506, NameHash: 1387874714, Flags: 49325), LayoutImmutable, Blittable]
		public bool HdrEnable { get { return m_HdrEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(HdrEnable), this, m_HdrEnable, value)) m_HdrEnable = value; } } // 0x1FA (506)
		
		protected bool m_SpotLightShadowmapEnable = new bool();
		[ContainerField(Name: "SpotLightShadowmapEnable", Offset: 507, NameHash: 735168888, Flags: 49325), LayoutImmutable, Blittable]
		public bool SpotLightShadowmapEnable { get { return m_SpotLightShadowmapEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SpotLightShadowmapEnable), this, m_SpotLightShadowmapEnable, value)) m_SpotLightShadowmapEnable = value; } } // 0x1FB (507)
		
		protected bool m_SimpleShadowmapsEnable = new bool();
		[ContainerField(Name: "SimpleShadowmapsEnable", Offset: 508, NameHash: 2195346787, Flags: 49325), LayoutImmutable, Blittable]
		public bool SimpleShadowmapsEnable { get { return m_SimpleShadowmapsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SimpleShadowmapsEnable), this, m_SimpleShadowmapsEnable, value)) m_SimpleShadowmapsEnable = value; } } // 0x1FC (508)
		
		protected bool m_DrawTransparent = new bool();
		[ContainerField(Name: "DrawTransparent", Offset: 509, NameHash: 3651089763, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawTransparent { get { return m_DrawTransparent; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawTransparent), this, m_DrawTransparent, value)) m_DrawTransparent = value; } } // 0x1FD (509)
		
		protected bool m_DrawTransparentDecal = new bool();
		[ContainerField(Name: "DrawTransparentDecal", Offset: 510, NameHash: 954292812, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawTransparentDecal { get { return m_DrawTransparentDecal; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawTransparentDecal), this, m_DrawTransparentDecal, value)) m_DrawTransparentDecal = value; } } // 0x1FE (510)
		
		protected bool m_ShadowmapFixedDepthEnable = new bool();
		[ContainerField(Name: "ShadowmapFixedDepthEnable", Offset: 511, NameHash: 3040423717, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShadowmapFixedDepthEnable { get { return m_ShadowmapFixedDepthEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapFixedDepthEnable), this, m_ShadowmapFixedDepthEnable, value)) m_ShadowmapFixedDepthEnable = value; } } // 0x1FF (511)
		
		protected bool m_DrawDebugDynamicEnvmap = new bool();
		[ContainerField(Name: "DrawDebugDynamicEnvmap", Offset: 512, NameHash: 4284307744, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugDynamicEnvmap { get { return m_DrawDebugDynamicEnvmap; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugDynamicEnvmap), this, m_DrawDebugDynamicEnvmap, value)) m_DrawDebugDynamicEnvmap = value; } } // 0x200 (512)
		
		protected bool m_MotionBlurGeometryPassEnable = new bool();
		[ContainerField(Name: "MotionBlurGeometryPassEnable", Offset: 513, NameHash: 609671128, Flags: 49325), LayoutImmutable, Blittable]
		public bool MotionBlurGeometryPassEnable { get { return m_MotionBlurGeometryPassEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MotionBlurGeometryPassEnable), this, m_MotionBlurGeometryPassEnable, value)) m_MotionBlurGeometryPassEnable = value; } } // 0x201 (513)
		
		protected bool m_DxLinearDepth32BitFormatEnable = new bool();
		[ContainerField(Name: "DxLinearDepth32BitFormatEnable", Offset: 514, NameHash: 353279157, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxLinearDepth32BitFormatEnable { get { return m_DxLinearDepth32BitFormatEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DxLinearDepth32BitFormatEnable), this, m_DxLinearDepth32BitFormatEnable, value)) m_DxLinearDepth32BitFormatEnable = value; } } // 0x202 (514)
		
		protected bool m_DynamicEnvmapMipmapGenEnable = new bool();
		[ContainerField(Name: "DynamicEnvmapMipmapGenEnable", Offset: 515, NameHash: 661192244, Flags: 49325), LayoutImmutable, Blittable]
		public bool DynamicEnvmapMipmapGenEnable { get { return m_DynamicEnvmapMipmapGenEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DynamicEnvmapMipmapGenEnable), this, m_DynamicEnvmapMipmapGenEnable, value)) m_DynamicEnvmapMipmapGenEnable = value; } } // 0x203 (515)
		
		protected bool m_MotionBlurEnable = new bool();
		[ContainerField(Name: "MotionBlurEnable", Offset: 516, NameHash: 1384583315, Flags: 49325), LayoutImmutable, Blittable]
		public bool MotionBlurEnable { get { return m_MotionBlurEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MotionBlurEnable), this, m_MotionBlurEnable, value)) m_MotionBlurEnable = value; } } // 0x204 (516)
		
		protected bool m_ColoredShadowmapSlicesEnable = new bool();
		[ContainerField(Name: "ColoredShadowmapSlicesEnable", Offset: 517, NameHash: 4228439617, Flags: 49325), LayoutImmutable, Blittable]
		public bool ColoredShadowmapSlicesEnable { get { return m_ColoredShadowmapSlicesEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ColoredShadowmapSlicesEnable), this, m_ColoredShadowmapSlicesEnable, value)) m_ColoredShadowmapSlicesEnable = value; } } // 0x205 (517)
		
		protected bool m_DxDeferredCsPathEnable = new bool();
		[ContainerField(Name: "DxDeferredCsPathEnable", Offset: 518, NameHash: 3732955238, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxDeferredCsPathEnable { get { return m_DxDeferredCsPathEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DxDeferredCsPathEnable), this, m_DxDeferredCsPathEnable, value)) m_DxDeferredCsPathEnable = value; } } // 0x206 (518)
		
		protected bool m_DrawDebugGBuffer = new bool();
		[ContainerField(Name: "DrawDebugGBuffer", Offset: 519, NameHash: 1319030707, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugGBuffer { get { return m_DrawDebugGBuffer; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugGBuffer), this, m_DrawDebugGBuffer, value)) m_DrawDebugGBuffer = value; } } // 0x207 (519)
		
		protected bool m_DrawDebugLightSources = new bool();
		[ContainerField(Name: "DrawDebugLightSources", Offset: 520, NameHash: 2851277444, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightSources { get { return m_DrawDebugLightSources; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugLightSources), this, m_DrawDebugLightSources, value)) m_DrawDebugLightSources = value; } } // 0x208 (520)
		
		protected bool m_DrawDebugLightShadowSources = new bool();
		[ContainerField(Name: "DrawDebugLightShadowSources", Offset: 521, NameHash: 2743133634, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightShadowSources { get { return m_DrawDebugLightShadowSources; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugLightShadowSources), this, m_DrawDebugLightShadowSources, value)) m_DrawDebugLightShadowSources = value; } } // 0x209 (521)
		
		protected bool m_DrawDebugLightStats = new bool();
		[ContainerField(Name: "DrawDebugLightStats", Offset: 522, NameHash: 2758934155, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightStats { get { return m_DrawDebugLightStats; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugLightStats), this, m_DrawDebugLightStats, value)) m_DrawDebugLightStats = value; } } // 0x20A (522)
		
		protected bool m_DrawDebugLightTiles = new bool();
		[ContainerField(Name: "DrawDebugLightTiles", Offset: 523, NameHash: 2762953485, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightTiles { get { return m_DrawDebugLightTiles; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugLightTiles), this, m_DrawDebugLightTiles, value)) m_DrawDebugLightTiles = value; } } // 0x20B (523)
		
		protected bool m_DrawDebugLightTileVolumes = new bool();
		[ContainerField(Name: "DrawDebugLightTileVolumes", Offset: 524, NameHash: 2679360389, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileVolumes { get { return m_DrawDebugLightTileVolumes; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugLightTileVolumes), this, m_DrawDebugLightTileVolumes, value)) m_DrawDebugLightTileVolumes = value; } } // 0x20C (524)
		
		protected bool m_DrawDebugLightTileFbGrid = new bool();
		[ContainerField(Name: "DrawDebugLightTileFbGrid", Offset: 525, NameHash: 191247138, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileFbGrid { get { return m_DrawDebugLightTileFbGrid; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugLightTileFbGrid), this, m_DrawDebugLightTileFbGrid, value)) m_DrawDebugLightTileFbGrid = value; } } // 0x20D (525)
		
		protected bool m_DrawDebugLightTileGrid = new bool();
		[ContainerField(Name: "DrawDebugLightTileGrid", Offset: 526, NameHash: 1206975558, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileGrid { get { return m_DrawDebugLightTileGrid; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugLightTileGrid), this, m_DrawDebugLightTileGrid, value)) m_DrawDebugLightTileGrid = value; } } // 0x20E (526)
		
		protected bool m_DrawDebugLightTileSources = new bool();
		[ContainerField(Name: "DrawDebugLightTileSources", Offset: 527, NameHash: 1808094512, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugLightTileSources { get { return m_DrawDebugLightTileSources; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugLightTileSources), this, m_DrawDebugLightTileSources, value)) m_DrawDebugLightTileSources = value; } } // 0x20F (527)
		
		protected bool m_ApplyShadowmapsEnable = new bool();
		[ContainerField(Name: "ApplyShadowmapsEnable", Offset: 528, NameHash: 3574633209, Flags: 49325), LayoutImmutable, Blittable]
		public bool ApplyShadowmapsEnable { get { return m_ApplyShadowmapsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ApplyShadowmapsEnable), this, m_ApplyShadowmapsEnable, value)) m_ApplyShadowmapsEnable = value; } } // 0x210 (528)
		
		protected bool m_GenerateShadowmapsEnable = new bool();
		[ContainerField(Name: "GenerateShadowmapsEnable", Offset: 529, NameHash: 935873350, Flags: 49325), LayoutImmutable, Blittable]
		public bool GenerateShadowmapsEnable { get { return m_GenerateShadowmapsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(GenerateShadowmapsEnable), this, m_GenerateShadowmapsEnable, value)) m_GenerateShadowmapsEnable = value; } } // 0x211 (529)
		
		protected bool m_DxSpotLightShadowmap16BitEnable = new bool();
		[ContainerField(Name: "DxSpotLightShadowmap16BitEnable", Offset: 530, NameHash: 1505079004, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxSpotLightShadowmap16BitEnable { get { return m_DxSpotLightShadowmap16BitEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DxSpotLightShadowmap16BitEnable), this, m_DxSpotLightShadowmap16BitEnable, value)) m_DxSpotLightShadowmap16BitEnable = value; } } // 0x212 (530)
		
		protected bool m_Ps3Shadowmap16BitEnable = new bool();
		[ContainerField(Name: "Ps3Shadowmap16BitEnable", Offset: 531, NameHash: 1210230998, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3Shadowmap16BitEnable { get { return m_Ps3Shadowmap16BitEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3Shadowmap16BitEnable), this, m_Ps3Shadowmap16BitEnable, value)) m_Ps3Shadowmap16BitEnable = value; } } // 0x213 (531)
		
		protected bool m_Ps3SpotLightShadowmap16BitEnable = new bool();
		[ContainerField(Name: "Ps3SpotLightShadowmap16BitEnable", Offset: 532, NameHash: 93128048, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3SpotLightShadowmap16BitEnable { get { return m_Ps3SpotLightShadowmap16BitEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3SpotLightShadowmap16BitEnable), this, m_Ps3SpotLightShadowmap16BitEnable, value)) m_Ps3SpotLightShadowmap16BitEnable = value; } } // 0x214 (532)
		
		protected bool m_GenericEntityRendererEnable = new bool();
		[ContainerField(Name: "GenericEntityRendererEnable", Offset: 533, NameHash: 3722054547, Flags: 49325), LayoutImmutable, Blittable]
		public bool GenericEntityRendererEnable { get { return m_GenericEntityRendererEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(GenericEntityRendererEnable), this, m_GenericEntityRendererEnable, value)) m_GenericEntityRendererEnable = value; } } // 0x215 (533)
		
		protected bool m_SetupJobEnable = new bool();
		[ContainerField(Name: "SetupJobEnable", Offset: 534, NameHash: 2809035620, Flags: 49325), LayoutImmutable, Blittable]
		public bool SetupJobEnable { get { return m_SetupJobEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SetupJobEnable), this, m_SetupJobEnable, value)) m_SetupJobEnable = value; } } // 0x216 (534)
		
		protected bool m_ShadowmapAccumBilinearEnable = new bool();
		[ContainerField(Name: "ShadowmapAccumBilinearEnable", Offset: 535, NameHash: 3053945073, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShadowmapAccumBilinearEnable { get { return m_ShadowmapAccumBilinearEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapAccumBilinearEnable), this, m_ShadowmapAccumBilinearEnable, value)) m_ShadowmapAccumBilinearEnable = value; } } // 0x217 (535)
		
		protected bool m_LightWidthEnable = new bool();
		[ContainerField(Name: "LightWidthEnable", Offset: 536, NameHash: 1310979964, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightWidthEnable { get { return m_LightWidthEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightWidthEnable), this, m_LightWidthEnable, value)) m_LightWidthEnable = value; } } // 0x218 (536)
		
		protected bool m_LightIntensityNormalizationEnable = new bool();
		[ContainerField(Name: "LightIntensityNormalizationEnable", Offset: 537, NameHash: 2426904168, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightIntensityNormalizationEnable { get { return m_LightIntensityNormalizationEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightIntensityNormalizationEnable), this, m_LightIntensityNormalizationEnable, value)) m_LightIntensityNormalizationEnable = value; } } // 0x219 (537)
		
		protected bool m_LightCullEnable = new bool();
		[ContainerField(Name: "LightCullEnable", Offset: 538, NameHash: 1558282924, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightCullEnable { get { return m_LightCullEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightCullEnable), this, m_LightCullEnable, value)) m_LightCullEnable = value; } } // 0x21A (538)
		
		protected bool m_LightDepthCullEnable = new bool();
		[ContainerField(Name: "LightDepthCullEnable", Offset: 539, NameHash: 3065319457, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightDepthCullEnable { get { return m_LightDepthCullEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightDepthCullEnable), this, m_LightDepthCullEnable, value)) m_LightDepthCullEnable = value; } } // 0x21B (539)
		
		protected bool m_LightNormalCullEnable = new bool();
		[ContainerField(Name: "LightNormalCullEnable", Offset: 540, NameHash: 2049659007, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightNormalCullEnable { get { return m_LightNormalCullEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightNormalCullEnable), this, m_LightNormalCullEnable, value)) m_LightNormalCullEnable = value; } } // 0x21C (540)
		
		protected bool m_LightConeCullEnable = new bool();
		[ContainerField(Name: "LightConeCullEnable", Offset: 541, NameHash: 3640240491, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightConeCullEnable { get { return m_LightConeCullEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightConeCullEnable), this, m_LightConeCullEnable, value)) m_LightConeCullEnable = value; } } // 0x21D (541)
		
		protected bool m_LightTileOverlayEnable = new bool();
		[ContainerField(Name: "LightTileOverlayEnable", Offset: 542, NameHash: 2508672340, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightTileOverlayEnable { get { return m_LightTileOverlayEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightTileOverlayEnable), this, m_LightTileOverlayEnable, value)) m_LightTileOverlayEnable = value; } } // 0x21E (542)
		
		protected bool m_Ps3ShadowmapTilingEnable = new bool();
		[ContainerField(Name: "Ps3ShadowmapTilingEnable", Offset: 543, NameHash: 1756923903, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3ShadowmapTilingEnable { get { return m_Ps3ShadowmapTilingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(Ps3ShadowmapTilingEnable), this, m_Ps3ShadowmapTilingEnable, value)) m_Ps3ShadowmapTilingEnable = value; } } // 0x21F (543)
		
		protected bool m_LightAttenuationThresholdEnable = new bool();
		[ContainerField(Name: "LightAttenuationThresholdEnable", Offset: 544, NameHash: 3010075503, Flags: 49325), LayoutImmutable, Blittable]
		public bool LightAttenuationThresholdEnable { get { return m_LightAttenuationThresholdEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(LightAttenuationThresholdEnable), this, m_LightAttenuationThresholdEnable, value)) m_LightAttenuationThresholdEnable = value; } } // 0x220 (544)
		
		protected bool m_SkyVisibilityEnvmapScalingEnable = new bool();
		[ContainerField(Name: "SkyVisibilityEnvmapScalingEnable", Offset: 545, NameHash: 3650245535, Flags: 49325), LayoutImmutable, Blittable]
		public bool SkyVisibilityEnvmapScalingEnable { get { return m_SkyVisibilityEnvmapScalingEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(SkyVisibilityEnvmapScalingEnable), this, m_SkyVisibilityEnvmapScalingEnable, value)) m_SkyVisibilityEnvmapScalingEnable = value; } } // 0x221 (545)
		
		protected bool m_ZBufferShadowTestEnable = new bool();
		[ContainerField(Name: "ZBufferShadowTestEnable", Offset: 546, NameHash: 1654494478, Flags: 49325), LayoutImmutable, Blittable]
		public bool ZBufferShadowTestEnable { get { return m_ZBufferShadowTestEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ZBufferShadowTestEnable), this, m_ZBufferShadowTestEnable, value)) m_ZBufferShadowTestEnable = value; } } // 0x222 (546)
		
		protected bool m_ShadowmapsEnable = new bool();
		[ContainerField(Name: "ShadowmapsEnable", Offset: 547, NameHash: 3081289741, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShadowmapsEnable { get { return m_ShadowmapsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapsEnable), this, m_ShadowmapsEnable, value)) m_ShadowmapsEnable = value; } } // 0x223 (547)
		
		protected bool m_ShadowmapAccumEnable = new bool();
		[ContainerField(Name: "ShadowmapAccumEnable", Offset: 548, NameHash: 504767143, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShadowmapAccumEnable { get { return m_ShadowmapAccumEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapAccumEnable), this, m_ShadowmapAccumEnable, value)) m_ShadowmapAccumEnable = value; } } // 0x224 (548)
		
		protected bool m_ShadowmapCullVolumeEnable = new bool();
		[ContainerField(Name: "ShadowmapCullVolumeEnable", Offset: 549, NameHash: 2203514112, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShadowmapCullVolumeEnable { get { return m_ShadowmapCullVolumeEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapCullVolumeEnable), this, m_ShadowmapCullVolumeEnable, value)) m_ShadowmapCullVolumeEnable = value; } } // 0x225 (549)
		
		protected bool m_OpaqueSortBySolutionEnable = new bool();
		[ContainerField(Name: "OpaqueSortBySolutionEnable", Offset: 550, NameHash: 3545910115, Flags: 49325), LayoutImmutable, Blittable]
		public bool OpaqueSortBySolutionEnable { get { return m_OpaqueSortBySolutionEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(OpaqueSortBySolutionEnable), this, m_OpaqueSortBySolutionEnable, value)) m_OpaqueSortBySolutionEnable = value; } } // 0x226 (550)
		
		protected bool m_MainOpaqueZPassEnable = new bool();
		[ContainerField(Name: "MainOpaqueZPassEnable", Offset: 551, NameHash: 1636817275, Flags: 49325), LayoutImmutable, Blittable]
		public bool MainOpaqueZPassEnable { get { return m_MainOpaqueZPassEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(MainOpaqueZPassEnable), this, m_MainOpaqueZPassEnable, value)) m_MainOpaqueZPassEnable = value; } } // 0x227 (551)
		
		protected bool m_DrawDebugDecalVolumes = new bool();
		[ContainerField(Name: "DrawDebugDecalVolumes", Offset: 552, NameHash: 2986167328, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugDecalVolumes { get { return m_DrawDebugDecalVolumes; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugDecalVolumes), this, m_DrawDebugDecalVolumes, value)) m_DrawDebugDecalVolumes = value; } } // 0x228 (552)
		
		protected bool m_PlanarReflectionEnable = new bool();
		[ContainerField(Name: "PlanarReflectionEnable", Offset: 553, NameHash: 2671877731, Flags: 49325), LayoutImmutable, Blittable]
		public bool PlanarReflectionEnable { get { return m_PlanarReflectionEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(PlanarReflectionEnable), this, m_PlanarReflectionEnable, value)) m_PlanarReflectionEnable = value; } } // 0x229 (553)
		
		protected bool m_TransparencyShadowmapsEnable = new bool();
		[ContainerField(Name: "TransparencyShadowmapsEnable", Offset: 554, NameHash: 3061910277, Flags: 49325), LayoutImmutable, Blittable]
		public bool TransparencyShadowmapsEnable { get { return m_TransparencyShadowmapsEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(TransparencyShadowmapsEnable), this, m_TransparencyShadowmapsEnable, value)) m_TransparencyShadowmapsEnable = value; } } // 0x22A (554)
		
		protected bool m_DynamicCullDrawOccludedBoxesEnable = new bool();
		[ContainerField(Name: "DynamicCullDrawOccludedBoxesEnable", Offset: 555, NameHash: 2516195767, Flags: 49325), LayoutImmutable, Blittable]
		public bool DynamicCullDrawOccludedBoxesEnable { get { return m_DynamicCullDrawOccludedBoxesEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DynamicCullDrawOccludedBoxesEnable), this, m_DynamicCullDrawOccludedBoxesEnable, value)) m_DynamicCullDrawOccludedBoxesEnable = value; } } // 0x22B (555)
		
		protected bool m_PlanarReflectionBlur = new bool();
		[ContainerField(Name: "PlanarReflectionBlur", Offset: 556, NameHash: 1985957131, Flags: 49325), LayoutImmutable, Blittable]
		public bool PlanarReflectionBlur { get { return m_PlanarReflectionBlur; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(PlanarReflectionBlur), this, m_PlanarReflectionBlur, value)) m_PlanarReflectionBlur = value; } } // 0x22C (556)
		
		protected bool m_DrawDebugPlanarReflectionCullFrustum = new bool();
		[ContainerField(Name: "DrawDebugPlanarReflectionCullFrustum", Offset: 557, NameHash: 564945563, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugPlanarReflectionCullFrustum { get { return m_DrawDebugPlanarReflectionCullFrustum; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugPlanarReflectionCullFrustum), this, m_DrawDebugPlanarReflectionCullFrustum, value)) m_DrawDebugPlanarReflectionCullFrustum = value; } } // 0x22D (557)
		
		protected bool m_FreezePlanarReflectionCullFrustum = new bool();
		[ContainerField(Name: "FreezePlanarReflectionCullFrustum", Offset: 558, NameHash: 3746596769, Flags: 49325), LayoutImmutable, Blittable]
		public bool FreezePlanarReflectionCullFrustum { get { return m_FreezePlanarReflectionCullFrustum; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(FreezePlanarReflectionCullFrustum), this, m_FreezePlanarReflectionCullFrustum, value)) m_FreezePlanarReflectionCullFrustum = value; } } // 0x22E (558)
		
		protected bool m_PlanarReflectionDebugCullMode = new bool();
		[ContainerField(Name: "PlanarReflectionDebugCullMode", Offset: 559, NameHash: 3399148678, Flags: 49325), LayoutImmutable, Blittable]
		public bool PlanarReflectionDebugCullMode { get { return m_PlanarReflectionDebugCullMode; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(PlanarReflectionDebugCullMode), this, m_PlanarReflectionDebugCullMode, value)) m_PlanarReflectionDebugCullMode = value; } } // 0x22F (559)
		
		protected bool m_ShadowmapFixedMovementEnable = new bool();
		[ContainerField(Name: "ShadowmapFixedMovementEnable", Offset: 560, NameHash: 1299347787, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShadowmapFixedMovementEnable { get { return m_ShadowmapFixedMovementEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ShadowmapFixedMovementEnable), this, m_ShadowmapFixedMovementEnable, value)) m_ShadowmapFixedMovementEnable = value; } } // 0x230 (560)
		
		protected bool m_DecalVolumeEnable = new bool();
		[ContainerField(Name: "DecalVolumeEnable", Offset: 561, NameHash: 1009689091, Flags: 49325), LayoutImmutable, Blittable]
		public bool DecalVolumeEnable { get { return m_DecalVolumeEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DecalVolumeEnable), this, m_DecalVolumeEnable, value)) m_DecalVolumeEnable = value; } } // 0x231 (561)
		
		protected bool m_DrawDebugPlanarReflection = new bool();
		[ContainerField(Name: "DrawDebugPlanarReflection", Offset: 562, NameHash: 1620291507, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawDebugPlanarReflection { get { return m_DrawDebugPlanarReflection; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DrawDebugPlanarReflection), this, m_DrawDebugPlanarReflection, value)) m_DrawDebugPlanarReflection = value; } } // 0x232 (562)
		
		protected bool m_FxaaEnable = new bool();
		[ContainerField(Name: "FxaaEnable", Offset: 563, NameHash: 3263642426, Flags: 49325), LayoutImmutable, Blittable]
		public bool FxaaEnable { get { return m_FxaaEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(FxaaEnable), this, m_FxaaEnable, value)) m_FxaaEnable = value; } } // 0x233 (563)
		
		protected bool m_DynamicCullSpuJobEnable = new bool();
		[ContainerField(Name: "DynamicCullSpuJobEnable", Offset: 564, NameHash: 633481110, Flags: 49325), LayoutImmutable, Blittable]
		public bool DynamicCullSpuJobEnable { get { return m_DynamicCullSpuJobEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DynamicCullSpuJobEnable), this, m_DynamicCullSpuJobEnable, value)) m_DynamicCullSpuJobEnable = value; } } // 0x234 (564)
		
		protected bool m_DynamicCullZBufferTestEnable = new bool();
		[ContainerField(Name: "DynamicCullZBufferTestEnable", Offset: 565, NameHash: 4122507627, Flags: 49325), LayoutImmutable, Blittable]
		public bool DynamicCullZBufferTestEnable { get { return m_DynamicCullZBufferTestEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(DynamicCullZBufferTestEnable), this, m_DynamicCullZBufferTestEnable, value)) m_DynamicCullZBufferTestEnable = value; } } // 0x235 (565)
		
		protected bool m_ViewFxEnable = new bool();
		[ContainerField(Name: "ViewFxEnable", Offset: 566, NameHash: 326459607, Flags: 49325), LayoutImmutable, Blittable]
		public bool ViewFxEnable { get { return m_ViewFxEnable; } set { if (OnPropertyChanging("WorldRenderSettings." + nameof(ViewFxEnable), this, m_ViewFxEnable, value)) m_ViewFxEnable = value; } } // 0x236 (566)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2442804067:
					DynamicEnvmapDefaultPosition = (Vec3) p_Value;
					break;

				case 1116837929:
					SubSurfaceColor = (Vec3) p_Value;
					break;

				case 372747593:
					ViewportScale = (float) p_Value;
					break;

				case 1763892754:
					ShadowMinScreenArea = (float) p_Value;
					break;

				case 1275076751:
					ShadowViewportScale = (float) p_Value;
					break;

				case 1713753686:
					FxaaQuality = (uint) p_Value;
					break;

				case 989651568:
					CullScreenAreaScale = (float) p_Value;
					break;

				case 3291231915:
					PlanarReflectionCullFOV = (float) p_Value;
					break;

				case 3254270605:
					GenericEntityMaxVisibleEntityCount = (uint) p_Value;
					break;

				case 3508619736:
					ShadowmapSizeZScale = (float) p_Value;
					break;

				case 3880013969:
					ShadowmapResolution = (uint) p_Value;
					break;

				case 4159686514:
					ShadowmapQuality = (uint) p_Value;
					break;

				case 3460109328:
					ShadowmapPoissonFilterScale = (float) p_Value;
					break;

				case 1754397676:
					ShadowmapSliceCount = (uint) p_Value;
					break;

				case 4103828218:
					ShadowmapSliceSchemeWeight = (float) p_Value;
					break;

				case 2040081677:
					ShadowmapFirstSliceScale = (float) p_Value;
					break;

				case 1554572465:
					ShadowmapViewDistance = (float) p_Value;
					break;

				case 1134551908:
					PlanarReflectionWidth = (uint) p_Value;
					break;

				case 658753014:
					ShadowmapExtrusionLength = (float) p_Value;
					break;

				case 2714094958:
					ShadowmapMinScreenArea = (float) p_Value;
					break;

				case 2965318295:
					TempPlanarReflectionY = (float) p_Value;
					break;

				case 1376512303:
					SubSurfaceRolloffKeyLight = (float) p_Value;
					break;

				case 3453976226:
					FxaaForceVendor = (int) p_Value;
					break;

				case 2870536605:
					PlanarReflectionHeight = (uint) p_Value;
					break;

				case 4224101580:
					LightIntensityScale = (float) p_Value;
					break;

				case 340957037:
					LightLodSpecularFadeAreaEnd = (float) p_Value;
					break;

				case 4182219946:
					ShadowmapMinFov = (float) p_Value;
					break;

				case 1941638882:
					LightLodSpecularFadeAreaStart = (float) p_Value;
					break;

				case 2574597545:
					LightLodRadiusFactor = (float) p_Value;
					break;

				case 1015351721:
					LightForceIntensity = (float) p_Value;
					break;

				case 3993094733:
					LightLodFadeArea = (float) p_Value;
					break;

				case 1014960449:
					LightLodMinArea = (float) p_Value;
					break;

				case 1647206466:
					DrawDebugDynamicEnvmapMipLevel = (int) p_Value;
					break;

				case 1711167253:
					MaxDecalVolumeCount = (uint) p_Value;
					break;

				case 922077962:
					MotionBlurScale = (float) p_Value;
					break;

				case 1677064646:
					MotionBlurMax = (float) p_Value;
					break;

				case 4082261780:
					MotionBlurNoiseScale = (float) p_Value;
					break;

				case 3278537567:
					MotionBlurQuality = (uint) p_Value;
					break;

				case 2418772786:
					MaxSpotLightShadowCount = (uint) p_Value;
					break;

				case 3729378162:
					DynamicEnvmapFilterMode = (MipmapFilterMode) Enum.ToObject(typeof(MipmapFilterMode), p_Value);
					break;

				case 1447314883:
					MotionBlurMaxSampleCount = (uint) p_Value;
					break;

				case 1914506031:
					MotionBlurFrameAverageCount = (uint) p_Value;
					break;

				case 771939886:
					MotionBlurMaxFrameTime = (float) p_Value;
					break;

				case 3772079119:
					ForceMotionBlurDepthCutoff = (float) p_Value;
					break;

				case 3044262524:
					ForceMotionBlurCutoffGradientScale = (float) p_Value;
					break;

				case 1049323753:
					MultisampleCount = (uint) p_Value;
					break;

				case 3044955837:
					MultisampleThreshold = (float) p_Value;
					break;

				case 2623363008:
					MaxPointLightCount = (uint) p_Value;
					break;

				case 2418170502:
					ReflectionEnvmapSize = (uint) p_Value;
					break;

				case 4277463821:
					SpotLightNearPlane = (float) p_Value;
					break;

				case 984299638:
					SpotLightShadowmapPoissonFilterScale = (float) p_Value;
					break;

				case 883213115:
					OnlyShadowmapSlice = (int) p_Value;
					break;

				case 381898379:
					ViewMode = (WorldViewMode) Enum.ToObject(typeof(WorldViewMode), p_Value);
					break;

				case 2435232759:
					SpotLightShadowmapResolution = (uint) p_Value;
					break;

				case 2998747480:
					SpotLightShadomapLevel = (QualityLevel) Enum.ToObject(typeof(QualityLevel), p_Value);
					break;

				case 4007866708:
					SpotLightShadowmapQuality = (uint) p_Value;
					break;

				case 1921288514:
					OnlyLightTileY = (int) p_Value;
					break;

				case 1921288515:
					OnlyLightTileX = (int) p_Value;
					break;

				case 2994673228:
					XenonHdrColorScale = (float) p_Value;
					break;

				case 357430561:
					XenonHdrColorScaleFactor = (float) p_Value;
					break;

				case 1822791039:
					Ps3LightTileJobMaxFbTileCount = (uint) p_Value;
					break;

				case 3383060069:
					OnlyLightTileIndex = (int) p_Value;
					break;

				case 3257825371:
					Ps3LightTileJobCount = (uint) p_Value;
					break;

				case 2438614122:
					Ps3LightTileJobPriority = (uint) p_Value;
					break;

				case 2351028858:
					XenonLightTileMaxLineLightCount = (uint) p_Value;
					break;

				case 429843884:
					XenonLightTileMaxSpotLightCount = (uint) p_Value;
					break;

				case 2424724230:
					XenonLightTileConstantBufferSize = (uint) p_Value;
					break;

				case 2040884056:
					XenonLightTileMaxPointLightCount = (uint) p_Value;
					break;

				case 3613038148:
					MaxDestructionVolumeCount = (uint) p_Value;
					break;

				case 2780479095:
					DynamicEnvmapFilterWidth = (float) p_Value;
					break;

				case 2423538194:
					LightTileMinArea = (float) p_Value;
					break;

				case 1892805023:
					DynamicEnvmapResolution = (uint) p_Value;
					break;

				case 923722776:
					GBufferLayout = (ShaderGBufferLayout) Enum.ToObject(typeof(ShaderGBufferLayout), p_Value);
					break;

				case 1631282070:
					DrawDebugSkyEnvmapMipLevel = (int) p_Value;
					break;

				case 4202430106:
					DecalVolumeScale = (float) p_Value;
					break;

				case 3901576513:
					LightOverdrawMaxLayerCount = (uint) p_Value;
					break;

				case 2395431963:
					LightRadiusScale = (float) p_Value;
					break;

				case 1982068814:
					LightAttenuationThreshold = (float) p_Value;
					break;

				case 3693875840:
					Ps3LightTileMethod = (uint) p_Value;
					break;

				case 1369534961:
					Ps3LightTileJobYieldGranularity = (float) p_Value;
					break;

				case 3807845992:
					OutdoorLightTileBatchCount = (uint) p_Value;
					break;

				case 357937911:
					XenonDrawDebugLightTileGridMode = (uint) p_Value;
					break;

				case 1614588396:
					LightStencilMinArea = (float) p_Value;
					break;

				case 1180048180:
					MaxSpotLightCount = (uint) p_Value;
					break;

				case 3938625702:
					SkyEnvmapFilterMode = (MipmapFilterMode) Enum.ToObject(typeof(MipmapFilterMode), p_Value);
					break;

				case 1142320547:
					SkyEnvmapFilterWidth = (float) p_Value;
					break;

				case 518179735:
					GBufferTestCount = (uint) p_Value;
					break;

				case 2394614219:
					SkyEnvmapResolution = (uint) p_Value;
					break;

				case 1555842164:
					SkyEnvmapSidesPerFrameCount = (uint) p_Value;
					break;

				case 2057182293:
					SubSurfaceRolloffLocalLight = (float) p_Value;
					break;

				case 4080551099:
					OnlyTileIndex = (int) p_Value;
					break;

				case 1868101726:
					OccluderMeshZPrepassEnable = (bool) p_Value;
					break;

				case 3504488559:
					OccluderMeshZPrepassDebugEnable = (bool) p_Value;
					break;

				case 1610721584:
					WireframeEnable = (bool) p_Value;
					break;

				case 593088739:
					HalfResEnable = (bool) p_Value;
					break;

				case 4061822776:
					HalfResLensFlaresEnable = (bool) p_Value;
					break;

				case 4286745103:
					ZPassEnable = (bool) p_Value;
					break;

				case 1970522271:
					ForegroundEnable = (bool) p_Value;
					break;

				case 2587067910:
					TiledHalfResCompositeEnable = (bool) p_Value;
					break;

				case 3501185556:
					ForegroundZPassEnable = (bool) p_Value;
					break;

				case 2582875939:
					DrawDebugVelocityBuffer = (bool) p_Value;
					break;

				case 1792351467:
					ForegroundDepthClearEnable = (bool) p_Value;
					break;

				case 3412436838:
					ForegroundAsMainEnable = (bool) p_Value;
					break;

				case 942753814:
					CustomEnvmapEnable = (bool) p_Value;
					break;

				case 24872004:
					SkyEnvmapEnable = (bool) p_Value;
					break;

				case 1503612810:
					DrawDebugVisibleEntityTypes = (bool) p_Value;
					break;

				case 4269064774:
					DrawDebugHalfResEnvironment = (bool) p_Value;
					break;

				case 774505577:
					DrawSolidBoundingBoxes = (bool) p_Value;
					break;

				case 744838686:
					BilateralHalfResCompositeEnable = (bool) p_Value;
					break;

				case 103034393:
					ForegroundTransparentEnable = (bool) p_Value;
					break;

				case 3104302735:
					TiledHalfResStencilOccludersEnable = (bool) p_Value;
					break;

				case 1443363541:
					SkyEnvmapUpdateEnable = (bool) p_Value;
					break;

				case 2268461288:
					SkyEnvmapForceUpdateEnable = (bool) p_Value;
					break;

				case 486850942:
					SkyEnvmapUse8BitTexture = (bool) p_Value;
					break;

				case 2364859152:
					DynamicEnvmapEnable = (bool) p_Value;
					break;

				case 2601139327:
					ScreenEffectEnable = (bool) p_Value;
					break;

				case 1169913743:
					DrawDebugZBufferEnable = (bool) p_Value;
					break;

				case 2767114856:
					MotionBlurStencilPassEnable = (bool) p_Value;
					break;

				case 3552597328:
					FinalPostEnable = (bool) p_Value;
					break;

				case 1883382345:
					DrawDebugQuarterShadowmaps = (bool) p_Value;
					break;

				case 1029929588:
					DrawDebugSkyEnvmap = (bool) p_Value;
					break;

				case 3461804538:
					DxShadowmap16BitEnable = (bool) p_Value;
					break;

				case 3838688308:
					DrawDebugTransShadowmap = (bool) p_Value;
					break;

				case 2380030875:
					DrawDebugSpotLightShadowmaps = (bool) p_Value;
					break;

				case 2870709294:
					DrawShadowFrustums = (bool) p_Value;
					break;

				case 3102950941:
					DrawDebugShadowmaps = (bool) p_Value;
					break;

				case 4052097317:
					SkyEnable = (bool) p_Value;
					break;

				case 815981309:
					DrawBoundingSpheres = (bool) p_Value;
					break;

				case 2141195304:
					DrawFrustums = (bool) p_Value;
					break;

				case 959292189:
					StaticEnvmapEnable = (bool) p_Value;
					break;

				case 3354775883:
					SkyFogEnable = (bool) p_Value;
					break;

				case 320578522:
					DrawLineBoundingBoxes = (bool) p_Value;
					break;

				case 3877557809:
					DrawDebugDestructionVolumes = (bool) p_Value;
					break;

				case 3334093503:
					LensFlaresEnable = (bool) p_Value;
					break;

				case 242868074:
					DrawDebugLensFlareOccluders = (bool) p_Value;
					break;

				case 2716428527:
					DrawDebugLensFlares = (bool) p_Value;
					break;

				case 1840684577:
					LensFlareOcclusionEnable = (bool) p_Value;
					break;

				case 1836462056:
					DrawDebugWorldOcclusions = (bool) p_Value;
					break;

				case 380549299:
					CloudShadowEnable = (bool) p_Value;
					break;

				case 4100682570:
					OverrideDynamicAO = (bool) p_Value;
					break;

				case 2076410863:
					DrawDebugDynamicAO = (bool) p_Value;
					break;

				case 3278293887:
					EmissiveEnable = (bool) p_Value;
					break;

				case 1089017582:
					UnlitEnable = (bool) p_Value;
					break;

				case 1514667872:
					SkyEnvmapMipmapGenEnable = (bool) p_Value;
					break;

				case 2462812853:
					DrawLightSources = (bool) p_Value;
					break;

				case 1575849658:
					GBufferClearEnable = (bool) p_Value;
					break;

				case 108346297:
					DxGBufferLight16BitEnable = (bool) p_Value;
					break;

				case 1352763380:
					DxGBufferNormal16BitEnable = (bool) p_Value;
					break;

				case 4261956399:
					GBufferAlphaTestSimpleEnable = (bool) p_Value;
					break;

				case 4059295125:
					SpecularLightingEnable = (bool) p_Value;
					break;

				case 1314853573:
					SkinLightingEnable = (bool) p_Value;
					break;

				case 2183602155:
					TranslucencyLightingEnable = (bool) p_Value;
					break;

				case 498214414:
					DynamicEnvmapLightingEnable = (bool) p_Value;
					break;

				case 430661890:
					OutdoorLightEnable = (bool) p_Value;
					break;

				case 4141437477:
					PointLightsEnable = (bool) p_Value;
					break;

				case 3741175111:
					LineLightsEnable = (bool) p_Value;
					break;

				case 3836085742:
					ConeLightsEnable = (bool) p_Value;
					break;

				case 3322632337:
					SpotLightsEnable = (bool) p_Value;
					break;

				case 2698387843:
					LightProbesEnable = (bool) p_Value;
					break;

				case 2357499407:
					LightStencilMethodEnable = (bool) p_Value;
					break;

				case 4215208333:
					LightVolumeMethodEnable = (bool) p_Value;
					break;

				case 2053389737:
					LightVolumeDepthTestEnable = (bool) p_Value;
					break;

				case 1247904586:
					OutputGammaCorrectionEnable = (bool) p_Value;
					break;

				case 2597933379:
					DrawDebugMultisampleClassify = (bool) p_Value;
					break;

				case 3309610805:
					OutdoorKeyLightEnable = (bool) p_Value;
					break;

				case 3067691555:
					OutdoorSkyLightEnable = (bool) p_Value;
					break;

				case 4075788653:
					OutdoorLightSpecularEnable = (bool) p_Value;
					break;

				case 916476147:
					OutdoorLightTilingEnable = (bool) p_Value;
					break;

				case 2607928252:
					OutdoorLightTileRenderEnable = (bool) p_Value;
					break;

				case 2912986711:
					OutdoorLightTileBlendEnable = (bool) p_Value;
					break;

				case 3559242705:
					OutdoorLightTileSimpleShaderEnable = (bool) p_Value;
					break;

				case 3181214902:
					Ps3TiledHalfTargetEnable = (bool) p_Value;
					break;

				case 4098755329:
					XenonOutdoorLightTilingEnable = (bool) p_Value;
					break;

				case 1965396134:
					XenonPointLightsTilingEnable = (bool) p_Value;
					break;

				case 1124054354:
					XenonSpotLightsTilingEnable = (bool) p_Value;
					break;

				case 251521284:
					XenonLineLightsTilingEnable = (bool) p_Value;
					break;

				case 415268666:
					XenonAsyncLightJobsEnable = (bool) p_Value;
					break;

				case 2247224033:
					XenonLightTileDownsampleSpecularCheckEnable = (bool) p_Value;
					break;

				case 3217869342:
					XenonLightTileCpuPointLightCullingEnable = (bool) p_Value;
					break;

				case 146196904:
					Ps3TiledSSAOTargetsEnable = (bool) p_Value;
					break;

				case 3556523217:
					Ps3SCullEnable = (bool) p_Value;
					break;

				case 1639633735:
					Ps3ColorCompressionEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 5401221:
					Ps3TilingEnable = (bool) p_Value;
					break;

				case 3033595312:
					Ps3DepthBoundsLightCullingEnable = (bool) p_Value;
					break;

				case 3239977624:
					Ps3ZCullEnable = (bool) p_Value;
					break;

				case 1444307324:
					ConsoleRenderTargetPoolSharingEnable = (bool) p_Value;
					break;

				case 1905490891:
					XenonFloatDepthBufferEnable = (bool) p_Value;
					break;

				case 2197108900:
					Ps3LightTileJobYieldEnable = (bool) p_Value;
					break;

				case 2730638227:
					Ps3HdrClearEnable = (bool) p_Value;
					break;

				case 519764264:
					XenonFastHdrEnable = (bool) p_Value;
					break;

				case 2533957960:
					ShadowmapViewDistanceScaleEnable = (bool) p_Value;
					break;

				case 1147234777:
					Ps3RenderTargetPoolGBufferOffsetEnable = (bool) p_Value;
					break;

				case 1387874714:
					HdrEnable = (bool) p_Value;
					break;

				case 735168888:
					SpotLightShadowmapEnable = (bool) p_Value;
					break;

				case 2195346787:
					SimpleShadowmapsEnable = (bool) p_Value;
					break;

				case 3651089763:
					DrawTransparent = (bool) p_Value;
					break;

				case 954292812:
					DrawTransparentDecal = (bool) p_Value;
					break;

				case 3040423717:
					ShadowmapFixedDepthEnable = (bool) p_Value;
					break;

				case 4284307744:
					DrawDebugDynamicEnvmap = (bool) p_Value;
					break;

				case 609671128:
					MotionBlurGeometryPassEnable = (bool) p_Value;
					break;

				case 353279157:
					DxLinearDepth32BitFormatEnable = (bool) p_Value;
					break;

				case 661192244:
					DynamicEnvmapMipmapGenEnable = (bool) p_Value;
					break;

				case 1384583315:
					MotionBlurEnable = (bool) p_Value;
					break;

				case 4228439617:
					ColoredShadowmapSlicesEnable = (bool) p_Value;
					break;

				case 3732955238:
					DxDeferredCsPathEnable = (bool) p_Value;
					break;

				case 1319030707:
					DrawDebugGBuffer = (bool) p_Value;
					break;

				case 2851277444:
					DrawDebugLightSources = (bool) p_Value;
					break;

				case 2743133634:
					DrawDebugLightShadowSources = (bool) p_Value;
					break;

				case 2758934155:
					DrawDebugLightStats = (bool) p_Value;
					break;

				case 2762953485:
					DrawDebugLightTiles = (bool) p_Value;
					break;

				case 2679360389:
					DrawDebugLightTileVolumes = (bool) p_Value;
					break;

				case 191247138:
					DrawDebugLightTileFbGrid = (bool) p_Value;
					break;

				case 1206975558:
					DrawDebugLightTileGrid = (bool) p_Value;
					break;

				case 1808094512:
					DrawDebugLightTileSources = (bool) p_Value;
					break;

				case 3574633209:
					ApplyShadowmapsEnable = (bool) p_Value;
					break;

				case 935873350:
					GenerateShadowmapsEnable = (bool) p_Value;
					break;

				case 1505079004:
					DxSpotLightShadowmap16BitEnable = (bool) p_Value;
					break;

				case 1210230998:
					Ps3Shadowmap16BitEnable = (bool) p_Value;
					break;

				case 93128048:
					Ps3SpotLightShadowmap16BitEnable = (bool) p_Value;
					break;

				case 3722054547:
					GenericEntityRendererEnable = (bool) p_Value;
					break;

				case 2809035620:
					SetupJobEnable = (bool) p_Value;
					break;

				case 3053945073:
					ShadowmapAccumBilinearEnable = (bool) p_Value;
					break;

				case 1310979964:
					LightWidthEnable = (bool) p_Value;
					break;

				case 2426904168:
					LightIntensityNormalizationEnable = (bool) p_Value;
					break;

				case 1558282924:
					LightCullEnable = (bool) p_Value;
					break;

				case 3065319457:
					LightDepthCullEnable = (bool) p_Value;
					break;

				case 2049659007:
					LightNormalCullEnable = (bool) p_Value;
					break;

				case 3640240491:
					LightConeCullEnable = (bool) p_Value;
					break;

				case 2508672340:
					LightTileOverlayEnable = (bool) p_Value;
					break;

				case 1756923903:
					Ps3ShadowmapTilingEnable = (bool) p_Value;
					break;

				case 3010075503:
					LightAttenuationThresholdEnable = (bool) p_Value;
					break;

				case 3650245535:
					SkyVisibilityEnvmapScalingEnable = (bool) p_Value;
					break;

				case 1654494478:
					ZBufferShadowTestEnable = (bool) p_Value;
					break;

				case 3081289741:
					ShadowmapsEnable = (bool) p_Value;
					break;

				case 504767143:
					ShadowmapAccumEnable = (bool) p_Value;
					break;

				case 2203514112:
					ShadowmapCullVolumeEnable = (bool) p_Value;
					break;

				case 3545910115:
					OpaqueSortBySolutionEnable = (bool) p_Value;
					break;

				case 1636817275:
					MainOpaqueZPassEnable = (bool) p_Value;
					break;

				case 2986167328:
					DrawDebugDecalVolumes = (bool) p_Value;
					break;

				case 2671877731:
					PlanarReflectionEnable = (bool) p_Value;
					break;

				case 3061910277:
					TransparencyShadowmapsEnable = (bool) p_Value;
					break;

				case 2516195767:
					DynamicCullDrawOccludedBoxesEnable = (bool) p_Value;
					break;

				case 1985957131:
					PlanarReflectionBlur = (bool) p_Value;
					break;

				case 564945563:
					DrawDebugPlanarReflectionCullFrustum = (bool) p_Value;
					break;

				case 3746596769:
					FreezePlanarReflectionCullFrustum = (bool) p_Value;
					break;

				case 3399148678:
					PlanarReflectionDebugCullMode = (bool) p_Value;
					break;

				case 1299347787:
					ShadowmapFixedMovementEnable = (bool) p_Value;
					break;

				case 1009689091:
					DecalVolumeEnable = (bool) p_Value;
					break;

				case 1620291507:
					DrawDebugPlanarReflection = (bool) p_Value;
					break;

				case 3263642426:
					FxaaEnable = (bool) p_Value;
					break;

				case 633481110:
					DynamicCullSpuJobEnable = (bool) p_Value;
					break;

				case 4122507627:
					DynamicCullZBufferTestEnable = (bool) p_Value;
					break;

				case 326459607:
					ViewFxEnable = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2442804067:
					return DynamicEnvmapDefaultPosition;

				case 1116837929:
					return SubSurfaceColor;

				case 372747593:
					return ViewportScale;

				case 1763892754:
					return ShadowMinScreenArea;

				case 1275076751:
					return ShadowViewportScale;

				case 1713753686:
					return FxaaQuality;

				case 989651568:
					return CullScreenAreaScale;

				case 3291231915:
					return PlanarReflectionCullFOV;

				case 3254270605:
					return GenericEntityMaxVisibleEntityCount;

				case 3508619736:
					return ShadowmapSizeZScale;

				case 3880013969:
					return ShadowmapResolution;

				case 4159686514:
					return ShadowmapQuality;

				case 3460109328:
					return ShadowmapPoissonFilterScale;

				case 1754397676:
					return ShadowmapSliceCount;

				case 4103828218:
					return ShadowmapSliceSchemeWeight;

				case 2040081677:
					return ShadowmapFirstSliceScale;

				case 1554572465:
					return ShadowmapViewDistance;

				case 1134551908:
					return PlanarReflectionWidth;

				case 658753014:
					return ShadowmapExtrusionLength;

				case 2714094958:
					return ShadowmapMinScreenArea;

				case 2965318295:
					return TempPlanarReflectionY;

				case 1376512303:
					return SubSurfaceRolloffKeyLight;

				case 3453976226:
					return FxaaForceVendor;

				case 2870536605:
					return PlanarReflectionHeight;

				case 4224101580:
					return LightIntensityScale;

				case 340957037:
					return LightLodSpecularFadeAreaEnd;

				case 4182219946:
					return ShadowmapMinFov;

				case 1941638882:
					return LightLodSpecularFadeAreaStart;

				case 2574597545:
					return LightLodRadiusFactor;

				case 1015351721:
					return LightForceIntensity;

				case 3993094733:
					return LightLodFadeArea;

				case 1014960449:
					return LightLodMinArea;

				case 1647206466:
					return DrawDebugDynamicEnvmapMipLevel;

				case 1711167253:
					return MaxDecalVolumeCount;

				case 922077962:
					return MotionBlurScale;

				case 1677064646:
					return MotionBlurMax;

				case 4082261780:
					return MotionBlurNoiseScale;

				case 3278537567:
					return MotionBlurQuality;

				case 2418772786:
					return MaxSpotLightShadowCount;

				case 3729378162:
					return DynamicEnvmapFilterMode;

				case 1447314883:
					return MotionBlurMaxSampleCount;

				case 1914506031:
					return MotionBlurFrameAverageCount;

				case 771939886:
					return MotionBlurMaxFrameTime;

				case 3772079119:
					return ForceMotionBlurDepthCutoff;

				case 3044262524:
					return ForceMotionBlurCutoffGradientScale;

				case 1049323753:
					return MultisampleCount;

				case 3044955837:
					return MultisampleThreshold;

				case 2623363008:
					return MaxPointLightCount;

				case 2418170502:
					return ReflectionEnvmapSize;

				case 4277463821:
					return SpotLightNearPlane;

				case 984299638:
					return SpotLightShadowmapPoissonFilterScale;

				case 883213115:
					return OnlyShadowmapSlice;

				case 381898379:
					return ViewMode;

				case 2435232759:
					return SpotLightShadowmapResolution;

				case 2998747480:
					return SpotLightShadomapLevel;

				case 4007866708:
					return SpotLightShadowmapQuality;

				case 1921288514:
					return OnlyLightTileY;

				case 1921288515:
					return OnlyLightTileX;

				case 2994673228:
					return XenonHdrColorScale;

				case 357430561:
					return XenonHdrColorScaleFactor;

				case 1822791039:
					return Ps3LightTileJobMaxFbTileCount;

				case 3383060069:
					return OnlyLightTileIndex;

				case 3257825371:
					return Ps3LightTileJobCount;

				case 2438614122:
					return Ps3LightTileJobPriority;

				case 2351028858:
					return XenonLightTileMaxLineLightCount;

				case 429843884:
					return XenonLightTileMaxSpotLightCount;

				case 2424724230:
					return XenonLightTileConstantBufferSize;

				case 2040884056:
					return XenonLightTileMaxPointLightCount;

				case 3613038148:
					return MaxDestructionVolumeCount;

				case 2780479095:
					return DynamicEnvmapFilterWidth;

				case 2423538194:
					return LightTileMinArea;

				case 1892805023:
					return DynamicEnvmapResolution;

				case 923722776:
					return GBufferLayout;

				case 1631282070:
					return DrawDebugSkyEnvmapMipLevel;

				case 4202430106:
					return DecalVolumeScale;

				case 3901576513:
					return LightOverdrawMaxLayerCount;

				case 2395431963:
					return LightRadiusScale;

				case 1982068814:
					return LightAttenuationThreshold;

				case 3693875840:
					return Ps3LightTileMethod;

				case 1369534961:
					return Ps3LightTileJobYieldGranularity;

				case 3807845992:
					return OutdoorLightTileBatchCount;

				case 357937911:
					return XenonDrawDebugLightTileGridMode;

				case 1614588396:
					return LightStencilMinArea;

				case 1180048180:
					return MaxSpotLightCount;

				case 3938625702:
					return SkyEnvmapFilterMode;

				case 1142320547:
					return SkyEnvmapFilterWidth;

				case 518179735:
					return GBufferTestCount;

				case 2394614219:
					return SkyEnvmapResolution;

				case 1555842164:
					return SkyEnvmapSidesPerFrameCount;

				case 2057182293:
					return SubSurfaceRolloffLocalLight;

				case 4080551099:
					return OnlyTileIndex;

				case 1868101726:
					return OccluderMeshZPrepassEnable;

				case 3504488559:
					return OccluderMeshZPrepassDebugEnable;

				case 1610721584:
					return WireframeEnable;

				case 593088739:
					return HalfResEnable;

				case 4061822776:
					return HalfResLensFlaresEnable;

				case 4286745103:
					return ZPassEnable;

				case 1970522271:
					return ForegroundEnable;

				case 2587067910:
					return TiledHalfResCompositeEnable;

				case 3501185556:
					return ForegroundZPassEnable;

				case 2582875939:
					return DrawDebugVelocityBuffer;

				case 1792351467:
					return ForegroundDepthClearEnable;

				case 3412436838:
					return ForegroundAsMainEnable;

				case 942753814:
					return CustomEnvmapEnable;

				case 24872004:
					return SkyEnvmapEnable;

				case 1503612810:
					return DrawDebugVisibleEntityTypes;

				case 4269064774:
					return DrawDebugHalfResEnvironment;

				case 774505577:
					return DrawSolidBoundingBoxes;

				case 744838686:
					return BilateralHalfResCompositeEnable;

				case 103034393:
					return ForegroundTransparentEnable;

				case 3104302735:
					return TiledHalfResStencilOccludersEnable;

				case 1443363541:
					return SkyEnvmapUpdateEnable;

				case 2268461288:
					return SkyEnvmapForceUpdateEnable;

				case 486850942:
					return SkyEnvmapUse8BitTexture;

				case 2364859152:
					return DynamicEnvmapEnable;

				case 2601139327:
					return ScreenEffectEnable;

				case 1169913743:
					return DrawDebugZBufferEnable;

				case 2767114856:
					return MotionBlurStencilPassEnable;

				case 3552597328:
					return FinalPostEnable;

				case 1883382345:
					return DrawDebugQuarterShadowmaps;

				case 1029929588:
					return DrawDebugSkyEnvmap;

				case 3461804538:
					return DxShadowmap16BitEnable;

				case 3838688308:
					return DrawDebugTransShadowmap;

				case 2380030875:
					return DrawDebugSpotLightShadowmaps;

				case 2870709294:
					return DrawShadowFrustums;

				case 3102950941:
					return DrawDebugShadowmaps;

				case 4052097317:
					return SkyEnable;

				case 815981309:
					return DrawBoundingSpheres;

				case 2141195304:
					return DrawFrustums;

				case 959292189:
					return StaticEnvmapEnable;

				case 3354775883:
					return SkyFogEnable;

				case 320578522:
					return DrawLineBoundingBoxes;

				case 3877557809:
					return DrawDebugDestructionVolumes;

				case 3334093503:
					return LensFlaresEnable;

				case 242868074:
					return DrawDebugLensFlareOccluders;

				case 2716428527:
					return DrawDebugLensFlares;

				case 1840684577:
					return LensFlareOcclusionEnable;

				case 1836462056:
					return DrawDebugWorldOcclusions;

				case 380549299:
					return CloudShadowEnable;

				case 4100682570:
					return OverrideDynamicAO;

				case 2076410863:
					return DrawDebugDynamicAO;

				case 3278293887:
					return EmissiveEnable;

				case 1089017582:
					return UnlitEnable;

				case 1514667872:
					return SkyEnvmapMipmapGenEnable;

				case 2462812853:
					return DrawLightSources;

				case 1575849658:
					return GBufferClearEnable;

				case 108346297:
					return DxGBufferLight16BitEnable;

				case 1352763380:
					return DxGBufferNormal16BitEnable;

				case 4261956399:
					return GBufferAlphaTestSimpleEnable;

				case 4059295125:
					return SpecularLightingEnable;

				case 1314853573:
					return SkinLightingEnable;

				case 2183602155:
					return TranslucencyLightingEnable;

				case 498214414:
					return DynamicEnvmapLightingEnable;

				case 430661890:
					return OutdoorLightEnable;

				case 4141437477:
					return PointLightsEnable;

				case 3741175111:
					return LineLightsEnable;

				case 3836085742:
					return ConeLightsEnable;

				case 3322632337:
					return SpotLightsEnable;

				case 2698387843:
					return LightProbesEnable;

				case 2357499407:
					return LightStencilMethodEnable;

				case 4215208333:
					return LightVolumeMethodEnable;

				case 2053389737:
					return LightVolumeDepthTestEnable;

				case 1247904586:
					return OutputGammaCorrectionEnable;

				case 2597933379:
					return DrawDebugMultisampleClassify;

				case 3309610805:
					return OutdoorKeyLightEnable;

				case 3067691555:
					return OutdoorSkyLightEnable;

				case 4075788653:
					return OutdoorLightSpecularEnable;

				case 916476147:
					return OutdoorLightTilingEnable;

				case 2607928252:
					return OutdoorLightTileRenderEnable;

				case 2912986711:
					return OutdoorLightTileBlendEnable;

				case 3559242705:
					return OutdoorLightTileSimpleShaderEnable;

				case 3181214902:
					return Ps3TiledHalfTargetEnable;

				case 4098755329:
					return XenonOutdoorLightTilingEnable;

				case 1965396134:
					return XenonPointLightsTilingEnable;

				case 1124054354:
					return XenonSpotLightsTilingEnable;

				case 251521284:
					return XenonLineLightsTilingEnable;

				case 415268666:
					return XenonAsyncLightJobsEnable;

				case 2247224033:
					return XenonLightTileDownsampleSpecularCheckEnable;

				case 3217869342:
					return XenonLightTileCpuPointLightCullingEnable;

				case 146196904:
					return Ps3TiledSSAOTargetsEnable;

				case 3556523217:
					return Ps3SCullEnable;

				case 1639633735:
					return Ps3ColorCompressionEnable;

				case 2342790116:
					return Enable;

				case 5401221:
					return Ps3TilingEnable;

				case 3033595312:
					return Ps3DepthBoundsLightCullingEnable;

				case 3239977624:
					return Ps3ZCullEnable;

				case 1444307324:
					return ConsoleRenderTargetPoolSharingEnable;

				case 1905490891:
					return XenonFloatDepthBufferEnable;

				case 2197108900:
					return Ps3LightTileJobYieldEnable;

				case 2730638227:
					return Ps3HdrClearEnable;

				case 519764264:
					return XenonFastHdrEnable;

				case 2533957960:
					return ShadowmapViewDistanceScaleEnable;

				case 1147234777:
					return Ps3RenderTargetPoolGBufferOffsetEnable;

				case 1387874714:
					return HdrEnable;

				case 735168888:
					return SpotLightShadowmapEnable;

				case 2195346787:
					return SimpleShadowmapsEnable;

				case 3651089763:
					return DrawTransparent;

				case 954292812:
					return DrawTransparentDecal;

				case 3040423717:
					return ShadowmapFixedDepthEnable;

				case 4284307744:
					return DrawDebugDynamicEnvmap;

				case 609671128:
					return MotionBlurGeometryPassEnable;

				case 353279157:
					return DxLinearDepth32BitFormatEnable;

				case 661192244:
					return DynamicEnvmapMipmapGenEnable;

				case 1384583315:
					return MotionBlurEnable;

				case 4228439617:
					return ColoredShadowmapSlicesEnable;

				case 3732955238:
					return DxDeferredCsPathEnable;

				case 1319030707:
					return DrawDebugGBuffer;

				case 2851277444:
					return DrawDebugLightSources;

				case 2743133634:
					return DrawDebugLightShadowSources;

				case 2758934155:
					return DrawDebugLightStats;

				case 2762953485:
					return DrawDebugLightTiles;

				case 2679360389:
					return DrawDebugLightTileVolumes;

				case 191247138:
					return DrawDebugLightTileFbGrid;

				case 1206975558:
					return DrawDebugLightTileGrid;

				case 1808094512:
					return DrawDebugLightTileSources;

				case 3574633209:
					return ApplyShadowmapsEnable;

				case 935873350:
					return GenerateShadowmapsEnable;

				case 1505079004:
					return DxSpotLightShadowmap16BitEnable;

				case 1210230998:
					return Ps3Shadowmap16BitEnable;

				case 93128048:
					return Ps3SpotLightShadowmap16BitEnable;

				case 3722054547:
					return GenericEntityRendererEnable;

				case 2809035620:
					return SetupJobEnable;

				case 3053945073:
					return ShadowmapAccumBilinearEnable;

				case 1310979964:
					return LightWidthEnable;

				case 2426904168:
					return LightIntensityNormalizationEnable;

				case 1558282924:
					return LightCullEnable;

				case 3065319457:
					return LightDepthCullEnable;

				case 2049659007:
					return LightNormalCullEnable;

				case 3640240491:
					return LightConeCullEnable;

				case 2508672340:
					return LightTileOverlayEnable;

				case 1756923903:
					return Ps3ShadowmapTilingEnable;

				case 3010075503:
					return LightAttenuationThresholdEnable;

				case 3650245535:
					return SkyVisibilityEnvmapScalingEnable;

				case 1654494478:
					return ZBufferShadowTestEnable;

				case 3081289741:
					return ShadowmapsEnable;

				case 504767143:
					return ShadowmapAccumEnable;

				case 2203514112:
					return ShadowmapCullVolumeEnable;

				case 3545910115:
					return OpaqueSortBySolutionEnable;

				case 1636817275:
					return MainOpaqueZPassEnable;

				case 2986167328:
					return DrawDebugDecalVolumes;

				case 2671877731:
					return PlanarReflectionEnable;

				case 3061910277:
					return TransparencyShadowmapsEnable;

				case 2516195767:
					return DynamicCullDrawOccludedBoxesEnable;

				case 1985957131:
					return PlanarReflectionBlur;

				case 564945563:
					return DrawDebugPlanarReflectionCullFrustum;

				case 3746596769:
					return FreezePlanarReflectionCullFrustum;

				case 3399148678:
					return PlanarReflectionDebugCullMode;

				case 1299347787:
					return ShadowmapFixedMovementEnable;

				case 1009689091:
					return DecalVolumeEnable;

				case 1620291507:
					return DrawDebugPlanarReflection;

				case 3263642426:
					return FxaaEnable;

				case 633481110:
					return DynamicCullSpuJobEnable;

				case 4122507627:
					return DynamicCullZBufferTestEnable;

				case 326459607:
					return ViewFxEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2442804067:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapDefaultPosition));

				case 1116837929:
					return typeof(WorldRenderSettings).GetProperty(nameof(SubSurfaceColor));

				case 372747593:
					return typeof(WorldRenderSettings).GetProperty(nameof(ViewportScale));

				case 1763892754:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowMinScreenArea));

				case 1275076751:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowViewportScale));

				case 1713753686:
					return typeof(WorldRenderSettings).GetProperty(nameof(FxaaQuality));

				case 989651568:
					return typeof(WorldRenderSettings).GetProperty(nameof(CullScreenAreaScale));

				case 3291231915:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionCullFOV));

				case 3254270605:
					return typeof(WorldRenderSettings).GetProperty(nameof(GenericEntityMaxVisibleEntityCount));

				case 3508619736:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapSizeZScale));

				case 3880013969:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapResolution));

				case 4159686514:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapQuality));

				case 3460109328:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapPoissonFilterScale));

				case 1754397676:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapSliceCount));

				case 4103828218:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapSliceSchemeWeight));

				case 2040081677:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapFirstSliceScale));

				case 1554572465:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapViewDistance));

				case 1134551908:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionWidth));

				case 658753014:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapExtrusionLength));

				case 2714094958:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapMinScreenArea));

				case 2965318295:
					return typeof(WorldRenderSettings).GetProperty(nameof(TempPlanarReflectionY));

				case 1376512303:
					return typeof(WorldRenderSettings).GetProperty(nameof(SubSurfaceRolloffKeyLight));

				case 3453976226:
					return typeof(WorldRenderSettings).GetProperty(nameof(FxaaForceVendor));

				case 2870536605:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionHeight));

				case 4224101580:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightIntensityScale));

				case 340957037:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightLodSpecularFadeAreaEnd));

				case 4182219946:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapMinFov));

				case 1941638882:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightLodSpecularFadeAreaStart));

				case 2574597545:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightLodRadiusFactor));

				case 1015351721:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightForceIntensity));

				case 3993094733:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightLodFadeArea));

				case 1014960449:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightLodMinArea));

				case 1647206466:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugDynamicEnvmapMipLevel));

				case 1711167253:
					return typeof(WorldRenderSettings).GetProperty(nameof(MaxDecalVolumeCount));

				case 922077962:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurScale));

				case 1677064646:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurMax));

				case 4082261780:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurNoiseScale));

				case 3278537567:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurQuality));

				case 2418772786:
					return typeof(WorldRenderSettings).GetProperty(nameof(MaxSpotLightShadowCount));

				case 3729378162:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapFilterMode));

				case 1447314883:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurMaxSampleCount));

				case 1914506031:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurFrameAverageCount));

				case 771939886:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurMaxFrameTime));

				case 3772079119:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForceMotionBlurDepthCutoff));

				case 3044262524:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForceMotionBlurCutoffGradientScale));

				case 1049323753:
					return typeof(WorldRenderSettings).GetProperty(nameof(MultisampleCount));

				case 3044955837:
					return typeof(WorldRenderSettings).GetProperty(nameof(MultisampleThreshold));

				case 2623363008:
					return typeof(WorldRenderSettings).GetProperty(nameof(MaxPointLightCount));

				case 2418170502:
					return typeof(WorldRenderSettings).GetProperty(nameof(ReflectionEnvmapSize));

				case 4277463821:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightNearPlane));

				case 984299638:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightShadowmapPoissonFilterScale));

				case 883213115:
					return typeof(WorldRenderSettings).GetProperty(nameof(OnlyShadowmapSlice));

				case 381898379:
					return typeof(WorldRenderSettings).GetProperty(nameof(ViewMode));

				case 2435232759:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightShadowmapResolution));

				case 2998747480:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightShadomapLevel));

				case 4007866708:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightShadowmapQuality));

				case 1921288514:
					return typeof(WorldRenderSettings).GetProperty(nameof(OnlyLightTileY));

				case 1921288515:
					return typeof(WorldRenderSettings).GetProperty(nameof(OnlyLightTileX));

				case 2994673228:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonHdrColorScale));

				case 357430561:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonHdrColorScaleFactor));

				case 1822791039:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileJobMaxFbTileCount));

				case 3383060069:
					return typeof(WorldRenderSettings).GetProperty(nameof(OnlyLightTileIndex));

				case 3257825371:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileJobCount));

				case 2438614122:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileJobPriority));

				case 2351028858:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileMaxLineLightCount));

				case 429843884:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileMaxSpotLightCount));

				case 2424724230:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileConstantBufferSize));

				case 2040884056:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileMaxPointLightCount));

				case 3613038148:
					return typeof(WorldRenderSettings).GetProperty(nameof(MaxDestructionVolumeCount));

				case 2780479095:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapFilterWidth));

				case 2423538194:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightTileMinArea));

				case 1892805023:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapResolution));

				case 923722776:
					return typeof(WorldRenderSettings).GetProperty(nameof(GBufferLayout));

				case 1631282070:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugSkyEnvmapMipLevel));

				case 4202430106:
					return typeof(WorldRenderSettings).GetProperty(nameof(DecalVolumeScale));

				case 3901576513:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightOverdrawMaxLayerCount));

				case 2395431963:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightRadiusScale));

				case 1982068814:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightAttenuationThreshold));

				case 3693875840:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileMethod));

				case 1369534961:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileJobYieldGranularity));

				case 3807845992:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightTileBatchCount));

				case 357937911:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonDrawDebugLightTileGridMode));

				case 1614588396:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightStencilMinArea));

				case 1180048180:
					return typeof(WorldRenderSettings).GetProperty(nameof(MaxSpotLightCount));

				case 3938625702:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapFilterMode));

				case 1142320547:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapFilterWidth));

				case 518179735:
					return typeof(WorldRenderSettings).GetProperty(nameof(GBufferTestCount));

				case 2394614219:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapResolution));

				case 1555842164:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapSidesPerFrameCount));

				case 2057182293:
					return typeof(WorldRenderSettings).GetProperty(nameof(SubSurfaceRolloffLocalLight));

				case 4080551099:
					return typeof(WorldRenderSettings).GetProperty(nameof(OnlyTileIndex));

				case 1868101726:
					return typeof(WorldRenderSettings).GetProperty(nameof(OccluderMeshZPrepassEnable));

				case 3504488559:
					return typeof(WorldRenderSettings).GetProperty(nameof(OccluderMeshZPrepassDebugEnable));

				case 1610721584:
					return typeof(WorldRenderSettings).GetProperty(nameof(WireframeEnable));

				case 593088739:
					return typeof(WorldRenderSettings).GetProperty(nameof(HalfResEnable));

				case 4061822776:
					return typeof(WorldRenderSettings).GetProperty(nameof(HalfResLensFlaresEnable));

				case 4286745103:
					return typeof(WorldRenderSettings).GetProperty(nameof(ZPassEnable));

				case 1970522271:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForegroundEnable));

				case 2587067910:
					return typeof(WorldRenderSettings).GetProperty(nameof(TiledHalfResCompositeEnable));

				case 3501185556:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForegroundZPassEnable));

				case 2582875939:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugVelocityBuffer));

				case 1792351467:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForegroundDepthClearEnable));

				case 3412436838:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForegroundAsMainEnable));

				case 942753814:
					return typeof(WorldRenderSettings).GetProperty(nameof(CustomEnvmapEnable));

				case 24872004:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapEnable));

				case 1503612810:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugVisibleEntityTypes));

				case 4269064774:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugHalfResEnvironment));

				case 774505577:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawSolidBoundingBoxes));

				case 744838686:
					return typeof(WorldRenderSettings).GetProperty(nameof(BilateralHalfResCompositeEnable));

				case 103034393:
					return typeof(WorldRenderSettings).GetProperty(nameof(ForegroundTransparentEnable));

				case 3104302735:
					return typeof(WorldRenderSettings).GetProperty(nameof(TiledHalfResStencilOccludersEnable));

				case 1443363541:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapUpdateEnable));

				case 2268461288:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapForceUpdateEnable));

				case 486850942:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapUse8BitTexture));

				case 2364859152:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapEnable));

				case 2601139327:
					return typeof(WorldRenderSettings).GetProperty(nameof(ScreenEffectEnable));

				case 1169913743:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugZBufferEnable));

				case 2767114856:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurStencilPassEnable));

				case 3552597328:
					return typeof(WorldRenderSettings).GetProperty(nameof(FinalPostEnable));

				case 1883382345:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugQuarterShadowmaps));

				case 1029929588:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugSkyEnvmap));

				case 3461804538:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxShadowmap16BitEnable));

				case 3838688308:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugTransShadowmap));

				case 2380030875:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugSpotLightShadowmaps));

				case 2870709294:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawShadowFrustums));

				case 3102950941:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugShadowmaps));

				case 4052097317:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnable));

				case 815981309:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawBoundingSpheres));

				case 2141195304:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawFrustums));

				case 959292189:
					return typeof(WorldRenderSettings).GetProperty(nameof(StaticEnvmapEnable));

				case 3354775883:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyFogEnable));

				case 320578522:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawLineBoundingBoxes));

				case 3877557809:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugDestructionVolumes));

				case 3334093503:
					return typeof(WorldRenderSettings).GetProperty(nameof(LensFlaresEnable));

				case 242868074:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLensFlareOccluders));

				case 2716428527:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLensFlares));

				case 1840684577:
					return typeof(WorldRenderSettings).GetProperty(nameof(LensFlareOcclusionEnable));

				case 1836462056:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugWorldOcclusions));

				case 380549299:
					return typeof(WorldRenderSettings).GetProperty(nameof(CloudShadowEnable));

				case 4100682570:
					return typeof(WorldRenderSettings).GetProperty(nameof(OverrideDynamicAO));

				case 2076410863:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugDynamicAO));

				case 3278293887:
					return typeof(WorldRenderSettings).GetProperty(nameof(EmissiveEnable));

				case 1089017582:
					return typeof(WorldRenderSettings).GetProperty(nameof(UnlitEnable));

				case 1514667872:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyEnvmapMipmapGenEnable));

				case 2462812853:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawLightSources));

				case 1575849658:
					return typeof(WorldRenderSettings).GetProperty(nameof(GBufferClearEnable));

				case 108346297:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxGBufferLight16BitEnable));

				case 1352763380:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxGBufferNormal16BitEnable));

				case 4261956399:
					return typeof(WorldRenderSettings).GetProperty(nameof(GBufferAlphaTestSimpleEnable));

				case 4059295125:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpecularLightingEnable));

				case 1314853573:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkinLightingEnable));

				case 2183602155:
					return typeof(WorldRenderSettings).GetProperty(nameof(TranslucencyLightingEnable));

				case 498214414:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapLightingEnable));

				case 430661890:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightEnable));

				case 4141437477:
					return typeof(WorldRenderSettings).GetProperty(nameof(PointLightsEnable));

				case 3741175111:
					return typeof(WorldRenderSettings).GetProperty(nameof(LineLightsEnable));

				case 3836085742:
					return typeof(WorldRenderSettings).GetProperty(nameof(ConeLightsEnable));

				case 3322632337:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightsEnable));

				case 2698387843:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightProbesEnable));

				case 2357499407:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightStencilMethodEnable));

				case 4215208333:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightVolumeMethodEnable));

				case 2053389737:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightVolumeDepthTestEnable));

				case 1247904586:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutputGammaCorrectionEnable));

				case 2597933379:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugMultisampleClassify));

				case 3309610805:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorKeyLightEnable));

				case 3067691555:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorSkyLightEnable));

				case 4075788653:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightSpecularEnable));

				case 916476147:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightTilingEnable));

				case 2607928252:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightTileRenderEnable));

				case 2912986711:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightTileBlendEnable));

				case 3559242705:
					return typeof(WorldRenderSettings).GetProperty(nameof(OutdoorLightTileSimpleShaderEnable));

				case 3181214902:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3TiledHalfTargetEnable));

				case 4098755329:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonOutdoorLightTilingEnable));

				case 1965396134:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonPointLightsTilingEnable));

				case 1124054354:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonSpotLightsTilingEnable));

				case 251521284:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLineLightsTilingEnable));

				case 415268666:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonAsyncLightJobsEnable));

				case 2247224033:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileDownsampleSpecularCheckEnable));

				case 3217869342:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonLightTileCpuPointLightCullingEnable));

				case 146196904:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3TiledSSAOTargetsEnable));

				case 3556523217:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3SCullEnable));

				case 1639633735:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3ColorCompressionEnable));

				case 2342790116:
					return typeof(WorldRenderSettings).GetProperty(nameof(Enable));

				case 5401221:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3TilingEnable));

				case 3033595312:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3DepthBoundsLightCullingEnable));

				case 3239977624:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3ZCullEnable));

				case 1444307324:
					return typeof(WorldRenderSettings).GetProperty(nameof(ConsoleRenderTargetPoolSharingEnable));

				case 1905490891:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonFloatDepthBufferEnable));

				case 2197108900:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3LightTileJobYieldEnable));

				case 2730638227:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3HdrClearEnable));

				case 519764264:
					return typeof(WorldRenderSettings).GetProperty(nameof(XenonFastHdrEnable));

				case 2533957960:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapViewDistanceScaleEnable));

				case 1147234777:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3RenderTargetPoolGBufferOffsetEnable));

				case 1387874714:
					return typeof(WorldRenderSettings).GetProperty(nameof(HdrEnable));

				case 735168888:
					return typeof(WorldRenderSettings).GetProperty(nameof(SpotLightShadowmapEnable));

				case 2195346787:
					return typeof(WorldRenderSettings).GetProperty(nameof(SimpleShadowmapsEnable));

				case 3651089763:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawTransparent));

				case 954292812:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawTransparentDecal));

				case 3040423717:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapFixedDepthEnable));

				case 4284307744:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugDynamicEnvmap));

				case 609671128:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurGeometryPassEnable));

				case 353279157:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxLinearDepth32BitFormatEnable));

				case 661192244:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicEnvmapMipmapGenEnable));

				case 1384583315:
					return typeof(WorldRenderSettings).GetProperty(nameof(MotionBlurEnable));

				case 4228439617:
					return typeof(WorldRenderSettings).GetProperty(nameof(ColoredShadowmapSlicesEnable));

				case 3732955238:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxDeferredCsPathEnable));

				case 1319030707:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugGBuffer));

				case 2851277444:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightSources));

				case 2743133634:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightShadowSources));

				case 2758934155:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightStats));

				case 2762953485:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightTiles));

				case 2679360389:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightTileVolumes));

				case 191247138:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightTileFbGrid));

				case 1206975558:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightTileGrid));

				case 1808094512:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugLightTileSources));

				case 3574633209:
					return typeof(WorldRenderSettings).GetProperty(nameof(ApplyShadowmapsEnable));

				case 935873350:
					return typeof(WorldRenderSettings).GetProperty(nameof(GenerateShadowmapsEnable));

				case 1505079004:
					return typeof(WorldRenderSettings).GetProperty(nameof(DxSpotLightShadowmap16BitEnable));

				case 1210230998:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3Shadowmap16BitEnable));

				case 93128048:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3SpotLightShadowmap16BitEnable));

				case 3722054547:
					return typeof(WorldRenderSettings).GetProperty(nameof(GenericEntityRendererEnable));

				case 2809035620:
					return typeof(WorldRenderSettings).GetProperty(nameof(SetupJobEnable));

				case 3053945073:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapAccumBilinearEnable));

				case 1310979964:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightWidthEnable));

				case 2426904168:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightIntensityNormalizationEnable));

				case 1558282924:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightCullEnable));

				case 3065319457:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightDepthCullEnable));

				case 2049659007:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightNormalCullEnable));

				case 3640240491:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightConeCullEnable));

				case 2508672340:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightTileOverlayEnable));

				case 1756923903:
					return typeof(WorldRenderSettings).GetProperty(nameof(Ps3ShadowmapTilingEnable));

				case 3010075503:
					return typeof(WorldRenderSettings).GetProperty(nameof(LightAttenuationThresholdEnable));

				case 3650245535:
					return typeof(WorldRenderSettings).GetProperty(nameof(SkyVisibilityEnvmapScalingEnable));

				case 1654494478:
					return typeof(WorldRenderSettings).GetProperty(nameof(ZBufferShadowTestEnable));

				case 3081289741:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapsEnable));

				case 504767143:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapAccumEnable));

				case 2203514112:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapCullVolumeEnable));

				case 3545910115:
					return typeof(WorldRenderSettings).GetProperty(nameof(OpaqueSortBySolutionEnable));

				case 1636817275:
					return typeof(WorldRenderSettings).GetProperty(nameof(MainOpaqueZPassEnable));

				case 2986167328:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugDecalVolumes));

				case 2671877731:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionEnable));

				case 3061910277:
					return typeof(WorldRenderSettings).GetProperty(nameof(TransparencyShadowmapsEnable));

				case 2516195767:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicCullDrawOccludedBoxesEnable));

				case 1985957131:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionBlur));

				case 564945563:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugPlanarReflectionCullFrustum));

				case 3746596769:
					return typeof(WorldRenderSettings).GetProperty(nameof(FreezePlanarReflectionCullFrustum));

				case 3399148678:
					return typeof(WorldRenderSettings).GetProperty(nameof(PlanarReflectionDebugCullMode));

				case 1299347787:
					return typeof(WorldRenderSettings).GetProperty(nameof(ShadowmapFixedMovementEnable));

				case 1009689091:
					return typeof(WorldRenderSettings).GetProperty(nameof(DecalVolumeEnable));

				case 1620291507:
					return typeof(WorldRenderSettings).GetProperty(nameof(DrawDebugPlanarReflection));

				case 3263642426:
					return typeof(WorldRenderSettings).GetProperty(nameof(FxaaEnable));

				case 633481110:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicCullSpuJobEnable));

				case 4122507627:
					return typeof(WorldRenderSettings).GetProperty(nameof(DynamicCullZBufferTestEnable));

				case 326459607:
					return typeof(WorldRenderSettings).GetProperty(nameof(ViewFxEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
