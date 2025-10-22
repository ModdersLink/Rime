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

using fb.Render;
using fb.Core;
using fb.Entity;

namespace fb.Emitter;

[ContainerType(16, 256)]
public class EmitterTemplateData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<ProcessorData> RootProcessor { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint MaxCount { get; set; } = 50;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 WorldAlignmentDirection { get; set; } = new()
	{
		z = 0.000f,
		y = 1.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float Lifetime { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float TimeScale { get; set; } = 1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint LifetimeFrameCount { get; set; } = 0;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public EmittableType EmittableType { get; set; } = fb.Emitter.EmittableType.EmittableType_Quad;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public EmittableAlignment EmittableAlignment { get; set; } = fb.Emitter.EmittableAlignment.EmittableAlignment_Screen;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float MotionStretchMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float MotionStretchLengthClamp { get; set; } = 100.000f;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float VertexPixelLightingBlendFactor { get; set; } = 0.700f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float GlobalLocalNormalBlendFactor { get; set; } = 0.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float SoftParticlesFadeDistanceMultiplier { get; set; } = 0.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float LightWrapAroundFactor { get; set; } = 0.500f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float BentNormalFactor { get; set; } = 1.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float LightMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float BendingFactor { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float CameraBias { get; set; } = 0.000f;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public SurfaceShaderInstanceDataStruct Shader { get; set; } = new();
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public EmitterDrawOrder EmitterDrawOrder { get; set; } = fb.Emitter.EmitterDrawOrder.EmitterDrawOrder_Default;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float ParticleCullingFactor { get; set; } = 0.800f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float MinSpawnDistance { get; set; } = 0.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float MaxSpawnDistance { get; set; } = 0.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float MinScreenArea { get; set; } = 1.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float MeshCullingDistance { get; set; } = 0.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float DistanceScaleLength { get; set; } = 0.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float DistanceScaleNearValue { get; set; } = 1.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float DistanceScaleFarValue { get; set; } = 1.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float SpeedNormalizationValue { get; set; } = 50.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float WindSpeedNormalizationValue { get; set; } = 50.000f;
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public RefArray<EffectParameter> PerParticleEffectParameters { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float CullFadeNearDistance { get; set; } = 0.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float CullFadeNearRange { get; set; } = 0.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float CullFadeFarDistance { get; set; } = 0.000f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public float CullFadeFarRange { get; set; } = 0.000f;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public bool RepeatParticleSpawning { get; set; } = false;
	
	[ContainerField(0xe9), LayoutImmutable, Blittable, JsonProperty(Order = 233)]
	public bool FollowSpawnSource { get; set; } = false;
	
	[ContainerField(0xea), LayoutImmutable, Blittable, JsonProperty(Order = 234)]
	public bool KillParticlesWithEmitter { get; set; } = false;
	
	[ContainerField(0xeb), LayoutImmutable, Blittable, JsonProperty(Order = 235)]
	public bool ExclusionVolumeCullEnable { get; set; } = false;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public bool Emissive { get; set; } = false;
	
	[ContainerField(0xed), LayoutImmutable, Blittable, JsonProperty(Order = 237)]
	public bool Opaque { get; set; } = true;
	
	[ContainerField(0xee), LayoutImmutable, Blittable, JsonProperty(Order = 238)]
	public bool ForceNiceSorting { get; set; } = false;
	
	[ContainerField(0xef), LayoutImmutable, Blittable, JsonProperty(Order = 239)]
	public bool LocalSpace { get; set; } = false;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public bool CameraSpace { get; set; } = false;
	
	[ContainerField(0xf1), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
	public bool TransparencySunShadowEnable { get; set; } = false;
	
	[ContainerField(0xf2), LayoutImmutable, Blittable, JsonProperty(Order = 242)]
	public bool CastPlanarReflectionEnable { get; set; } = false;
	
	[ContainerField(0xf3), LayoutImmutable, Blittable, JsonProperty(Order = 243)]
	public bool ForceFullRes { get; set; } = false;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public bool FogFade { get; set; } = true;
	
	[ContainerField(0xf5), LayoutImmutable, Blittable, JsonProperty(Order = 245)]
	public bool AcceptGlobalParameter1 { get; set; } = false;
	
	[ContainerField(0xf6), LayoutImmutable, Blittable, JsonProperty(Order = 246)]
	public bool AcceptGlobalParameter2 { get; set; } = false;
	
	[ContainerField(0xf7), LayoutImmutable, Blittable, JsonProperty(Order = 247)]
	public bool AcceptGlobalParameter3 { get; set; } = false;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public bool UseOfCustomParamRandomSpawnValuesEnabled { get; set; } = false;
	
	[ContainerField(0xf9), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
	public bool EmitterWindEvaluationEnable { get; set; } = false;
	
	[ContainerField(0xfa), LayoutImmutable, Blittable, JsonProperty(Order = 250)]
	public bool EmittableWindEvaluationEnable { get; set; } = false;
	
	[ContainerField(0xfb), LayoutImmutable, Blittable, JsonProperty(Order = 251)]
	public bool GroupEmittersWithSameBaseTextureOnly { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(RootProcessor));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MaxCount);
		p_Writer.WriteNullBytes(4);
		WorldAlignmentDirection.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Lifetime);
		p_Writer.Write(TimeScale);
		p_Writer.Write(LifetimeFrameCount);
		p_Writer.Write((int) EmittableType);
		p_Writer.Write((int) EmittableAlignment);
		p_Writer.Write(MotionStretchMultiplier);
		p_Writer.Write(MotionStretchLengthClamp);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(VertexPixelLightingBlendFactor);
		p_Writer.Write(GlobalLocalNormalBlendFactor);
		p_Writer.Write(SoftParticlesFadeDistanceMultiplier);
		p_Writer.Write(LightWrapAroundFactor);
		p_Writer.Write(BentNormalFactor);
		p_Writer.Write(LightMultiplier);
		p_Writer.Write(BendingFactor);
		p_Writer.Write(CameraBias);
		Shader.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) EmitterDrawOrder);
		p_Writer.Write(ParticleCullingFactor);
		p_Writer.Write(MinSpawnDistance);
		p_Writer.Write(MaxSpawnDistance);
		p_Writer.Write(MinScreenArea);
		p_Writer.Write(MeshCullingDistance);
		p_Writer.Write(DistanceScaleLength);
		p_Writer.Write(DistanceScaleNearValue);
		p_Writer.Write(DistanceScaleFarValue);
		p_Writer.Write(SpeedNormalizationValue);
		p_Writer.Write(WindSpeedNormalizationValue);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PerParticleEffectParameters = p_EbxWriter.GetArrayWriter(PerParticleEffectParameters.GetType(), PerParticleEffectParameters.Count);
		p_Writer.Write(s_PerParticleEffectParameters.ArrayIndex);
		foreach (var s_Entry in PerParticleEffectParameters)
		{
			s_PerParticleEffectParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CullFadeNearDistance);
		p_Writer.Write(CullFadeNearRange);
		p_Writer.Write(CullFadeFarDistance);
		p_Writer.Write(CullFadeFarRange);
		p_Writer.Write(RepeatParticleSpawning);
		p_Writer.Write(FollowSpawnSource);
		p_Writer.Write(KillParticlesWithEmitter);
		p_Writer.Write(ExclusionVolumeCullEnable);
		p_Writer.Write(Emissive);
		p_Writer.Write(Opaque);
		p_Writer.Write(ForceNiceSorting);
		p_Writer.Write(LocalSpace);
		p_Writer.Write(CameraSpace);
		p_Writer.Write(TransparencySunShadowEnable);
		p_Writer.Write(CastPlanarReflectionEnable);
		p_Writer.Write(ForceFullRes);
		p_Writer.Write(FogFade);
		p_Writer.Write(AcceptGlobalParameter1);
		p_Writer.Write(AcceptGlobalParameter2);
		p_Writer.Write(AcceptGlobalParameter3);
		p_Writer.Write(UseOfCustomParamRandomSpawnValuesEnabled);
		p_Writer.Write(EmitterWindEvaluationEnable);
		p_Writer.Write(EmittableWindEvaluationEnable);
		p_Writer.Write(GroupEmittersWithSameBaseTextureOnly);
		p_Writer.WriteNullBytes(4);
	}
}

