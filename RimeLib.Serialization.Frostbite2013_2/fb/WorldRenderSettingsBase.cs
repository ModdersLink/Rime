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

using fb.Core;

namespace fb.WorldRender;

[ContainerType(16, 336)]
public class WorldRenderSettingsBase
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float CullScreenAreaScale { get; set; } = 1.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float ViewportScale { get; set; } = 1.000f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 MotionBlurClearColor { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 DynamicEnvmapDefaultPosition { get; set; } = new()
	{
		z = 70.000f,
		y = 3.000f,
		x = 18.000f,
	};
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float ShadowViewportScale { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float ShadowmapMinFov { get; set; } = -1.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float ShadowmapSizeZScale { get; set; } = 1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint ShadowmapResolution { get; set; } = 608;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint ShadowmapQuality { get; set; } = 1;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float ShadowmapPoissonFilterScale { get; set; } = 3.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint ShadowmapSliceCount { get; set; } = 4;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float ShadowmapSliceSchemeWeight { get; set; } = 0.800f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float ShadowmapFirstSliceScale { get; set; } = 1.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float ShadowmapViewDistance { get; set; } = 100.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float ShadowmapExtrusionLength { get; set; } = 400.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float ShadowmapTransitionBlendAmount { get; set; } = 0.030f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float MotionBlurScale { get; set; } = 1.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float MotionBlurFixedShutterTime { get; set; } = 0.008f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float MotionBlurMax { get; set; } = 0.100f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float MotionBlurRadialBlurMax { get; set; } = 0.060f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float MotionBlurNoiseScale { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public uint MotionBlurQuality { get; set; } = 1;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public uint MotionBlurDebugMode { get; set; } = 0;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public uint MotionBlurMaxSampleCount { get; set; } = 20;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float ForceMotionBlurDepthCutoff { get; set; } = -1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float ForceMotionBlurCutoffGradientScale { get; set; } = -1.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float MotionBlurDepthCheckThreshold { get; set; } = 0.050f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float MotionBlurDepthCheckMaxDistance { get; set; } = 5.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public uint MultisampleCount { get; set; } = 1;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float MultisampleThreshold { get; set; } = 0.100f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public int OnlyShadowmapSlice { get; set; } = -1;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public WorldViewMode ViewMode { get; set; } = WorldViewMode.WorldViewMode_Default;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float XenonHdrColorScale { get; set; } = 1.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float XenonHdrColorScaleFactor { get; set; } = 0.050f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float SkyEnvmapFilterWidth { get; set; } = 1.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public uint SkyEnvmapResolution { get; set; } = 128;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public int DrawDebugSkyEnvmapMipLevel { get; set; } = 0;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public MipmapFilterMode SkyEnvmapFilterMode { get; set; } = MipmapFilterMode.MipmapFilterMode_Poisson13Clamped;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public uint SkyEnvmapSidesPerFrameCount { get; set; } = 1;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float DynamicEnvmapFilterWidth { get; set; } = 1.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public uint DynamicEnvmapResolution { get; set; } = 256;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public int DrawDebugDynamicEnvmapMipLevel { get; set; } = 0;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public MipmapFilterMode DynamicEnvmapFilterMode { get; set; } = MipmapFilterMode.MipmapFilterMode_Poisson13Clamped;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public uint HudTextureWidth { get; set; } = 512;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public uint HudTextureHeight { get; set; } = 512;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public bool ShadowmapsEnable { get; set; } = true;
	
	[ContainerField(0xe5), LayoutImmutable, Blittable, JsonProperty(Order = 229)]
	public bool TransparencyShadowmapsEnable { get; set; } = false;
	
	[ContainerField(0xe6), LayoutImmutable, Blittable, JsonProperty(Order = 230)]
	public bool TransparencyShadowmapsHalfRes { get; set; } = false;
	
	[ContainerField(0xe7), LayoutImmutable, Blittable, JsonProperty(Order = 231)]
	public bool ShadowmapFixedMovementEnable { get; set; } = true;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public bool ShadowmapFixedDepthEnable { get; set; } = false;
	
	[ContainerField(0xe9), LayoutImmutable, Blittable, JsonProperty(Order = 233)]
	public bool ShadowmapViewDistanceScaleEnable { get; set; } = true;
	
	[ContainerField(0xea), LayoutImmutable, Blittable, JsonProperty(Order = 234)]
	public bool ShadowmapCullVolumeEnable { get; set; } = false;
	
	[ContainerField(0xeb), LayoutImmutable, Blittable, JsonProperty(Order = 235)]
	public bool ShadowmapAccumEnable { get; set; } = true;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public bool ShadowmapAccumBilinearEnable { get; set; } = true;
	
	[ContainerField(0xed), LayoutImmutable, Blittable, JsonProperty(Order = 237)]
	public bool ShadowmapTransitionBlendEnable { get; set; } = true;
	
	[ContainerField(0xee), LayoutImmutable, Blittable, JsonProperty(Order = 238)]
	public bool Ps3ShadowmapTilingEnable { get; set; } = true;
	
	[ContainerField(0xef), LayoutImmutable, Blittable, JsonProperty(Order = 239)]
	public bool Ps3Shadowmap16BitEnable { get; set; } = true;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public bool Ps3SpotLightShadowmap16BitEnable { get; set; } = true;
	
	[ContainerField(0xf1), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
	public bool DxShadowmap16BitEnable { get; set; } = true;
	
	[ContainerField(0xf2), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
	public bool DxSpotLightShadowmap16BitEnable { get; set; } = true;
	
	[ContainerField(0xf3), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
	public bool ApplyShadowmapsEnable { get; set; } = true;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public bool GenerateShadowmapsEnable { get; set; } = true;
	
	[ContainerField(0xf5), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
	public bool SimpleShadowmapsEnable { get; set; } = false;
	
	[ContainerField(0xf6), LayoutImmutable, Blittable, JsonProperty(Order = 246)]
	public bool EmitterShadowingBlendToggle { get; set; } = false;
	
	[ContainerField(0xf7), LayoutImmutable, Blittable, JsonProperty(Order = 247)]
	public bool EmitterShadowingManySamplesToggle { get; set; } = false;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public bool DxLinearDepth32BitFormatEnable { get; set; } = true;
	
	[ContainerField(0xf9), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
	public bool DxDepthBuffer32BitEnable { get; set; } = false;
	
	[ContainerField(0xfa), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
	public bool MotionBlurEnable { get; set; } = false;
	
	[ContainerField(0xfb), LayoutImmutable, Blittable, JsonProperty(Order = 251)]
	public bool MotionBlurForceOn { get; set; } = false;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public bool MotionBlurOptimalStableVelocityFormula { get; set; } = true;
	
	[ContainerField(0xfd), LayoutImmutable, Blittable, JsonProperty(Order = 253)]
	public bool MotionBlurStencilPassEnable { get; set; } = false;
	
	[ContainerField(0xfe), LayoutImmutable, Blittable, JsonProperty(Order = 254)]
	public bool MotionBlurGeometryPassEnable { get; set; } = true;
	
	[ContainerField(0xff), LayoutImmutable, Blittable, JsonProperty(Order = 255)]
	public bool MotionBlurBackgroundPassEnable { get; set; } = true;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public bool MotionBlurCenteredEnable { get; set; } = false;
	
	[ContainerField(0x101), LayoutImmutable, Blittable, JsonProperty(Order = 257)]
	public bool DrawDebugMultisampleClassify { get; set; } = false;
	
	[ContainerField(0x102), LayoutImmutable, Blittable, JsonProperty(Order = 258)]
	public bool DrawTransparent { get; set; } = true;
	
	[ContainerField(0x103), LayoutImmutable, Blittable, JsonProperty(Order = 259)]
	public bool DrawTransparentDecal { get; set; } = true;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x105), LayoutImmutable, Blittable, JsonProperty(Order = 261)]
	public bool HdrEnable { get; set; } = true;
	
	[ContainerField(0x106), LayoutImmutable, Blittable, JsonProperty(Order = 262)]
	public bool ReadOnlyDepthEnable { get; set; } = true;
	
	[ContainerField(0x107), LayoutImmutable, Blittable, JsonProperty(Order = 263)]
	public bool ConsoleRenderTargetPoolSharingEnable { get; set; } = true;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public bool Ps3RenderTargetPoolGBufferOffsetEnable { get; set; } = false;
	
	[ContainerField(0x109), LayoutImmutable, Blittable, JsonProperty(Order = 265)]
	public bool FastHdrEnable { get; set; } = false;
	
	[ContainerField(0x10a), LayoutImmutable, Blittable, JsonProperty(Order = 266)]
	public bool XenonFloatDepthBufferEnable { get; set; } = true;
	
	[ContainerField(0x10b), LayoutImmutable, Blittable, JsonProperty(Order = 267)]
	public bool Ps3HdrClearEnable { get; set; } = false;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public bool Ps3TilingEnable { get; set; } = true;
	
	[ContainerField(0x10d), LayoutImmutable, Blittable, JsonProperty(Order = 269)]
	public bool Ps3ZCullEnable { get; set; } = true;
	
	[ContainerField(0x10e), LayoutImmutable, Blittable, JsonProperty(Order = 270)]
	public bool Ps3SCullEnable { get; set; } = true;
	
	[ContainerField(0x10f), LayoutImmutable, Blittable, JsonProperty(Order = 271)]
	public bool Ps3ColorCompressionEnable { get; set; } = false;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public bool Ps3TiledHalfTargetEnable { get; set; } = true;
	
	[ContainerField(0x111), LayoutImmutable, Blittable, JsonProperty(Order = 273)]
	public bool Ps3TiledSSAOTargetsEnable { get; set; } = false;
	
	[ContainerField(0x112), LayoutImmutable, Blittable, JsonProperty(Order = 274)]
	public bool FinalPostEnable { get; set; } = true;
	
	[ContainerField(0x113), LayoutImmutable, Blittable, JsonProperty(Order = 275)]
	public bool OutputGammaCorrectionEnable { get; set; } = true;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public bool ScreenEffectEnable { get; set; } = true;
	
	[ContainerField(0x115), LayoutImmutable, Blittable, JsonProperty(Order = 277)]
	public bool DrawLightSources { get; set; } = false;
	
	[ContainerField(0x116), LayoutImmutable, Blittable, JsonProperty(Order = 278)]
	public bool DrawSolidBoundingBoxes { get; set; } = false;
	
	[ContainerField(0x117), LayoutImmutable, Blittable, JsonProperty(Order = 279)]
	public bool DrawLineBoundingBoxes { get; set; } = false;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public bool DrawBoundingSpheres { get; set; } = false;
	
	[ContainerField(0x119), LayoutImmutable, Blittable, JsonProperty(Order = 281)]
	public bool DrawFrustums { get; set; } = false;
	
	[ContainerField(0x11a), LayoutImmutable, Blittable, JsonProperty(Order = 282)]
	public bool DrawDebugShadowmaps { get; set; } = false;
	
	[ContainerField(0x11b), LayoutImmutable, Blittable, JsonProperty(Order = 283)]
	public bool DrawDebugSpotLightShadowmaps { get; set; } = false;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public bool DrawDebugSkyEnvmap { get; set; } = false;
	
	[ContainerField(0x11d), LayoutImmutable, Blittable, JsonProperty(Order = 285)]
	public bool DrawDebugVelocityBuffer { get; set; } = false;
	
	[ContainerField(0x11e), LayoutImmutable, Blittable, JsonProperty(Order = 286)]
	public bool DrawDebugZBufferEnable { get; set; } = false;
	
	[ContainerField(0x11f), LayoutImmutable, Blittable, JsonProperty(Order = 287)]
	public bool DrawDebugHalfResEnvironment { get; set; } = false;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public bool DrawDebugDistortion { get; set; } = false;
	
	[ContainerField(0x121), LayoutImmutable, Blittable, JsonProperty(Order = 289)]
	public bool DrawDebugVisibleEntityTypes { get; set; } = false;
	
	[ContainerField(0x122), LayoutImmutable, Blittable, JsonProperty(Order = 290)]
	public bool DrawDebugSkyTextures { get; set; } = false;
	
	[ContainerField(0x123), LayoutImmutable, Blittable, JsonProperty(Order = 291)]
	public bool DrawDebugMarschnerTextures { get; set; } = false;
	
	[ContainerField(0x124), LayoutImmutable, Blittable, JsonProperty(Order = 292)]
	public bool DrawDebugDof { get; set; } = false;
	
	[ContainerField(0x125), LayoutImmutable, Blittable, JsonProperty(Order = 293)]
	public bool DrawDebugDofFullscreen { get; set; } = false;
	
	[ContainerField(0x126), LayoutImmutable, Blittable, JsonProperty(Order = 294)]
	public bool DrawDebugHalfResHdrTargets { get; set; } = false;
	
	[ContainerField(0x127), LayoutImmutable, Blittable, JsonProperty(Order = 295)]
	public bool WireframeEnable { get; set; } = false;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public bool ZPassEnable { get; set; } = true;
	
	[ContainerField(0x129), LayoutImmutable, Blittable, JsonProperty(Order = 297)]
	public bool OccluderMeshZPrepassEnable { get; set; } = false;
	
	[ContainerField(0x12a), LayoutImmutable, Blittable, JsonProperty(Order = 298)]
	public bool OccluderMeshZPrepassDebugEnable { get; set; } = false;
	
	[ContainerField(0x12b), LayoutImmutable, Blittable, JsonProperty(Order = 299)]
	public bool HalfResEnable { get; set; } = true;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public bool ForceFullResEnable { get; set; } = false;
	
	[ContainerField(0x12d), LayoutImmutable, Blittable, JsonProperty(Order = 301)]
	public bool HalfResLensFlaresEnable { get; set; } = true;
	
	[ContainerField(0x12e), LayoutImmutable, Blittable, JsonProperty(Order = 302)]
	public bool ForegroundEnable { get; set; } = true;
	
	[ContainerField(0x12f), LayoutImmutable, Blittable, JsonProperty(Order = 303)]
	public bool ForegroundDepthClearEnable { get; set; } = true;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public bool ForegroundZPassEnable { get; set; } = true;
	
	[ContainerField(0x131), LayoutImmutable, Blittable, JsonProperty(Order = 305)]
	public bool ForegroundTransparentEnable { get; set; } = true;
	
	[ContainerField(0x132), LayoutImmutable, Blittable, JsonProperty(Order = 306)]
	public bool BilateralHalfResCompositeEnable { get; set; } = true;
	
	[ContainerField(0x133), LayoutImmutable, Blittable, JsonProperty(Order = 307)]
	public bool TiledHalfResCompositeEnable { get; set; } = true;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public bool TiledHalfResStencilOccludersEnable { get; set; } = true;
	
	[ContainerField(0x135), LayoutImmutable, Blittable, JsonProperty(Order = 309)]
	public bool SkyEnable { get; set; } = true;
	
	[ContainerField(0x136), LayoutImmutable, Blittable, JsonProperty(Order = 310)]
	public bool SkyFogEnable { get; set; } = true;
	
	[ContainerField(0x137), LayoutImmutable, Blittable, JsonProperty(Order = 311)]
	public bool SkyHeightFogEnable { get; set; } = true;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public bool SkyForwardScatteringEnable { get; set; } = true;
	
	[ContainerField(0x139), LayoutImmutable, Blittable, JsonProperty(Order = 313)]
	public bool DistortionEnable { get; set; } = true;
	
	[ContainerField(0x13a), LayoutImmutable, Blittable, JsonProperty(Order = 314)]
	public bool DistortionHalfResEnable { get; set; } = true;
	
	[ContainerField(0x13b), LayoutImmutable, Blittable, JsonProperty(Order = 315)]
	public bool Distortion8BitEnable { get; set; } = false;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public bool DistortionTilingEnable { get; set; } = true;
	
	[ContainerField(0x13d), LayoutImmutable, Blittable, JsonProperty(Order = 317)]
	public bool StaticEnvmapEnable { get; set; } = true;
	
	[ContainerField(0x13e), LayoutImmutable, Blittable, JsonProperty(Order = 318)]
	public bool CustomEnvmapEnable { get; set; } = true;
	
	[ContainerField(0x13f), LayoutImmutable, Blittable, JsonProperty(Order = 319)]
	public bool CustomEnvmapMipmapClampEnable { get; set; } = false;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public bool SkyEnvmapEnable { get; set; } = true;
	
	[ContainerField(0x141), LayoutImmutable, Blittable, JsonProperty(Order = 321)]
	public bool SkyEnvmapMipmapGenEnable { get; set; } = true;
	
	[ContainerField(0x142), LayoutImmutable, Blittable, JsonProperty(Order = 322)]
	public bool SkyEnvmapUpdateEnable { get; set; } = true;
	
	[ContainerField(0x143), LayoutImmutable, Blittable, JsonProperty(Order = 323)]
	public bool SkyEnvmapForceUpdateEnable { get; set; } = false;
	
	[ContainerField(0x144), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
	public bool SkyEnvmapUse8BitTexture { get; set; } = true;
	
	[ContainerField(0x145), LayoutImmutable, Blittable, JsonProperty(Order = 325)]
	public bool DynamicEnvmapEnable { get; set; } = false;
	
	[ContainerField(0x146), LayoutImmutable, Blittable, JsonProperty(Order = 326)]
	public bool DynamicEnvmapMipmapGenEnable { get; set; } = true;
	
	[ContainerField(0x147), LayoutImmutable, Blittable, JsonProperty(Order = 327)]
	public bool DrawDebugDynamicEnvmap { get; set; } = false;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public bool HairCoverageEnable { get; set; } = false;
	
	[ContainerField(0x149), LayoutImmutable, Blittable, JsonProperty(Order = 329)]
	public bool SetupJobEnable { get; set; } = true;
	
	[ContainerField(0x14a), LayoutImmutable, Blittable, JsonProperty(Order = 330)]
	public bool FinishSyncJobsFirstEnable { get; set; } = false;
	
	[ContainerField(0x14b), LayoutImmutable, Blittable, JsonProperty(Order = 331)]
	public bool PrepareDispatchListJobEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CullScreenAreaScale);
		p_Writer.Write(ViewportScale);
		p_Writer.WriteNullBytes(8);
		MotionBlurClearColor.Serialize(p_Writer, p_EbxWriter);
		DynamicEnvmapDefaultPosition.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ShadowViewportScale);
		p_Writer.Write(ShadowmapMinFov);
		p_Writer.Write(ShadowmapSizeZScale);
		p_Writer.Write(ShadowmapResolution);
		p_Writer.Write(ShadowmapQuality);
		p_Writer.Write(ShadowmapPoissonFilterScale);
		p_Writer.Write(ShadowmapSliceCount);
		p_Writer.Write(ShadowmapSliceSchemeWeight);
		p_Writer.Write(ShadowmapFirstSliceScale);
		p_Writer.Write(ShadowmapViewDistance);
		p_Writer.Write(ShadowmapExtrusionLength);
		p_Writer.Write(ShadowmapTransitionBlendAmount);
		p_Writer.Write(MotionBlurScale);
		p_Writer.Write(MotionBlurFixedShutterTime);
		p_Writer.Write(MotionBlurMax);
		p_Writer.Write(MotionBlurRadialBlurMax);
		p_Writer.Write(MotionBlurNoiseScale);
		p_Writer.Write(MotionBlurQuality);
		p_Writer.Write(MotionBlurDebugMode);
		p_Writer.Write(MotionBlurMaxSampleCount);
		p_Writer.Write(ForceMotionBlurDepthCutoff);
		p_Writer.Write(ForceMotionBlurCutoffGradientScale);
		p_Writer.Write(MotionBlurDepthCheckThreshold);
		p_Writer.Write(MotionBlurDepthCheckMaxDistance);
		p_Writer.Write(MultisampleCount);
		p_Writer.Write(MultisampleThreshold);
		p_Writer.Write(OnlyShadowmapSlice);
		p_Writer.Write((int) ViewMode);
		p_Writer.Write(XenonHdrColorScale);
		p_Writer.Write(XenonHdrColorScaleFactor);
		p_Writer.Write(SkyEnvmapFilterWidth);
		p_Writer.Write(SkyEnvmapResolution);
		p_Writer.Write(DrawDebugSkyEnvmapMipLevel);
		p_Writer.Write((int) SkyEnvmapFilterMode);
		p_Writer.Write(SkyEnvmapSidesPerFrameCount);
		p_Writer.Write(DynamicEnvmapFilterWidth);
		p_Writer.Write(DynamicEnvmapResolution);
		p_Writer.Write(DrawDebugDynamicEnvmapMipLevel);
		p_Writer.Write((int) DynamicEnvmapFilterMode);
		p_Writer.Write(HudTextureWidth);
		p_Writer.Write(HudTextureHeight);
		p_Writer.Write(ShadowmapsEnable);
		p_Writer.Write(TransparencyShadowmapsEnable);
		p_Writer.Write(TransparencyShadowmapsHalfRes);
		p_Writer.Write(ShadowmapFixedMovementEnable);
		p_Writer.Write(ShadowmapFixedDepthEnable);
		p_Writer.Write(ShadowmapViewDistanceScaleEnable);
		p_Writer.Write(ShadowmapCullVolumeEnable);
		p_Writer.Write(ShadowmapAccumEnable);
		p_Writer.Write(ShadowmapAccumBilinearEnable);
		p_Writer.Write(ShadowmapTransitionBlendEnable);
		p_Writer.Write(Ps3ShadowmapTilingEnable);
		p_Writer.Write(Ps3Shadowmap16BitEnable);
		p_Writer.Write(Ps3SpotLightShadowmap16BitEnable);
		p_Writer.Write(DxShadowmap16BitEnable);
		p_Writer.Write(DxSpotLightShadowmap16BitEnable);
		p_Writer.Write(ApplyShadowmapsEnable);
		p_Writer.Write(GenerateShadowmapsEnable);
		p_Writer.Write(SimpleShadowmapsEnable);
		p_Writer.Write(EmitterShadowingBlendToggle);
		p_Writer.Write(EmitterShadowingManySamplesToggle);
		p_Writer.Write(DxLinearDepth32BitFormatEnable);
		p_Writer.Write(DxDepthBuffer32BitEnable);
		p_Writer.Write(MotionBlurEnable);
		p_Writer.Write(MotionBlurForceOn);
		p_Writer.Write(MotionBlurOptimalStableVelocityFormula);
		p_Writer.Write(MotionBlurStencilPassEnable);
		p_Writer.Write(MotionBlurGeometryPassEnable);
		p_Writer.Write(MotionBlurBackgroundPassEnable);
		p_Writer.Write(MotionBlurCenteredEnable);
		p_Writer.Write(DrawDebugMultisampleClassify);
		p_Writer.Write(DrawTransparent);
		p_Writer.Write(DrawTransparentDecal);
		p_Writer.Write(Enable);
		p_Writer.Write(HdrEnable);
		p_Writer.Write(ReadOnlyDepthEnable);
		p_Writer.Write(ConsoleRenderTargetPoolSharingEnable);
		p_Writer.Write(Ps3RenderTargetPoolGBufferOffsetEnable);
		p_Writer.Write(FastHdrEnable);
		p_Writer.Write(XenonFloatDepthBufferEnable);
		p_Writer.Write(Ps3HdrClearEnable);
		p_Writer.Write(Ps3TilingEnable);
		p_Writer.Write(Ps3ZCullEnable);
		p_Writer.Write(Ps3SCullEnable);
		p_Writer.Write(Ps3ColorCompressionEnable);
		p_Writer.Write(Ps3TiledHalfTargetEnable);
		p_Writer.Write(Ps3TiledSSAOTargetsEnable);
		p_Writer.Write(FinalPostEnable);
		p_Writer.Write(OutputGammaCorrectionEnable);
		p_Writer.Write(ScreenEffectEnable);
		p_Writer.Write(DrawLightSources);
		p_Writer.Write(DrawSolidBoundingBoxes);
		p_Writer.Write(DrawLineBoundingBoxes);
		p_Writer.Write(DrawBoundingSpheres);
		p_Writer.Write(DrawFrustums);
		p_Writer.Write(DrawDebugShadowmaps);
		p_Writer.Write(DrawDebugSpotLightShadowmaps);
		p_Writer.Write(DrawDebugSkyEnvmap);
		p_Writer.Write(DrawDebugVelocityBuffer);
		p_Writer.Write(DrawDebugZBufferEnable);
		p_Writer.Write(DrawDebugHalfResEnvironment);
		p_Writer.Write(DrawDebugDistortion);
		p_Writer.Write(DrawDebugVisibleEntityTypes);
		p_Writer.Write(DrawDebugSkyTextures);
		p_Writer.Write(DrawDebugMarschnerTextures);
		p_Writer.Write(DrawDebugDof);
		p_Writer.Write(DrawDebugDofFullscreen);
		p_Writer.Write(DrawDebugHalfResHdrTargets);
		p_Writer.Write(WireframeEnable);
		p_Writer.Write(ZPassEnable);
		p_Writer.Write(OccluderMeshZPrepassEnable);
		p_Writer.Write(OccluderMeshZPrepassDebugEnable);
		p_Writer.Write(HalfResEnable);
		p_Writer.Write(ForceFullResEnable);
		p_Writer.Write(HalfResLensFlaresEnable);
		p_Writer.Write(ForegroundEnable);
		p_Writer.Write(ForegroundDepthClearEnable);
		p_Writer.Write(ForegroundZPassEnable);
		p_Writer.Write(ForegroundTransparentEnable);
		p_Writer.Write(BilateralHalfResCompositeEnable);
		p_Writer.Write(TiledHalfResCompositeEnable);
		p_Writer.Write(TiledHalfResStencilOccludersEnable);
		p_Writer.Write(SkyEnable);
		p_Writer.Write(SkyFogEnable);
		p_Writer.Write(SkyHeightFogEnable);
		p_Writer.Write(SkyForwardScatteringEnable);
		p_Writer.Write(DistortionEnable);
		p_Writer.Write(DistortionHalfResEnable);
		p_Writer.Write(Distortion8BitEnable);
		p_Writer.Write(DistortionTilingEnable);
		p_Writer.Write(StaticEnvmapEnable);
		p_Writer.Write(CustomEnvmapEnable);
		p_Writer.Write(CustomEnvmapMipmapClampEnable);
		p_Writer.Write(SkyEnvmapEnable);
		p_Writer.Write(SkyEnvmapMipmapGenEnable);
		p_Writer.Write(SkyEnvmapUpdateEnable);
		p_Writer.Write(SkyEnvmapForceUpdateEnable);
		p_Writer.Write(SkyEnvmapUse8BitTexture);
		p_Writer.Write(DynamicEnvmapEnable);
		p_Writer.Write(DynamicEnvmapMipmapGenEnable);
		p_Writer.Write(DrawDebugDynamicEnvmap);
		p_Writer.Write(HairCoverageEnable);
		p_Writer.Write(SetupJobEnable);
		p_Writer.Write(FinishSyncJobsFirstEnable);
		p_Writer.Write(PrepareDispatchListJobEnable);
		p_Writer.WriteNullBytes(4);
	}
}

