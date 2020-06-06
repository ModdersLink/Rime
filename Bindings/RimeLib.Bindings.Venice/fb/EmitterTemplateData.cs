///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class EmitterTemplateData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 PointLightIntensity { get; set; } = new Vec4(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PointLightPivot { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PointLightColor { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public uint MaxCount { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable]
		public string Name { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float TimeScale { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public uint LifetimeFrameCount { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float Lifetime { get; set; } // 0x50 (80)
		
		[ContainerField(84)]
		public CtrRef<ProcessorData> RootProcessor { get; set; } = new CtrRef<ProcessorData>(); // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float VisibleAfterDistance { get; set; } // 0x58 (88)
		
		[ContainerField(92)]
		public List<float> ZOcclusionLookup { get; set; } = new List<float>(); // 0x5C (92)
		
		[ContainerField(96)]
		public EmittableType EmittableType { get; set; } = new EmittableType(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float DistanceScaleNearValue { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float PointLightRadius { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float VertexPixelLightingBlendFactor { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float GlobalLocalNormalBlendFactor { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float SoftParticlesFadeDistanceMultiplier { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float LightWrapAroundFactor { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float LightMultiplier { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float DistanceScaleFarValue { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float PointLightRandomIntensityMin { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float MeshCullingDistance { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float PointLightRandomIntensityMax { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float MaxSpawnDistance { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float MinScreenArea { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float DistanceScaleLength { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float PointLightMaxClamp { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float ParticleCullingFactor { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float PointLightMinClamp { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public bool FollowSpawnSource { get; set; } // 0xAC (172)
		
		[ContainerField(173), LayoutImmutable, Blittable]
		public bool RepeatParticleSpawning { get; set; } // 0xAD (173)
		
		[ContainerField(174), LayoutImmutable, Blittable]
		public bool Emissive { get; set; } // 0xAE (174)
		
		[ContainerField(175), LayoutImmutable, Blittable]
		public bool ExclusionVolumeCullEnable { get; set; } // 0xAF (175)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public bool TransparencySunShadowEnable { get; set; } // 0xB0 (176)
		
		[ContainerField(177), LayoutImmutable, Blittable]
		public bool ForceFullRes { get; set; } // 0xB1 (177)
		
		[ContainerField(178), LayoutImmutable, Blittable]
		public bool LocalSpace { get; set; } // 0xB2 (178)
		
		[ContainerField(179), LayoutImmutable, Blittable]
		public bool Opaque { get; set; } // 0xB3 (179)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public bool ActAsPointLight { get; set; } // 0xB4 (180)
		
		[ContainerField(181), LayoutImmutable, Blittable]
		public bool KillParticlesWithEmitter { get; set; } // 0xB5 (181)
		
		[ContainerField(182), LayoutImmutable, Blittable]
		public bool ForceNiceSorting { get; set; } // 0xB6 (182)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2449280824:
					PointLightIntensity = (Vec4) p_Value;
					break;

				case 2839277155:
					PointLightPivot = (Vec3) p_Value;
					break;

				case 2852380970:
					PointLightColor = (Vec3) p_Value;
					break;

				case 415061138:
					MaxCount = (uint) p_Value;
					break;

				case 2088949890:
					Name = (string) p_Value;
					break;

				case 169511528:
					TimeScale = (float) p_Value;
					break;

				case 2205246824:
					LifetimeFrameCount = (uint) p_Value;
					break;

				case 2450521238:
					Lifetime = (float) p_Value;
					break;

				case 3988805269:
					RootProcessor = (CtrRef<ProcessorData>) p_Value;
					break;

				case 2130300524:
					VisibleAfterDistance = (float) p_Value;
					break;

				case 3071713232:
					ZOcclusionLookup = (List<float>) p_Value;
					break;

				case 3808538518:
					EmittableType = (EmittableType) Enum.ToObject(typeof(EmittableType), p_Value);
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 4151251565:
					DistanceScaleNearValue = (float) p_Value;
					break;

				case 3261781711:
					PointLightRadius = (float) p_Value;
					break;

				case 2828867447:
					VertexPixelLightingBlendFactor = (float) p_Value;
					break;

				case 3400652860:
					GlobalLocalNormalBlendFactor = (float) p_Value;
					break;

				case 2725694050:
					SoftParticlesFadeDistanceMultiplier = (float) p_Value;
					break;

				case 372734881:
					LightWrapAroundFactor = (float) p_Value;
					break;

				case 3252516944:
					LightMultiplier = (float) p_Value;
					break;

				case 1407092256:
					DistanceScaleFarValue = (float) p_Value;
					break;

				case 1255152585:
					PointLightRandomIntensityMin = (float) p_Value;
					break;

				case 2057455619:
					MeshCullingDistance = (float) p_Value;
					break;

				case 1255152855:
					PointLightRandomIntensityMax = (float) p_Value;
					break;

				case 3656506569:
					MaxSpawnDistance = (float) p_Value;
					break;

				case 81136980:
					MinScreenArea = (float) p_Value;
					break;

				case 2372975298:
					DistanceScaleLength = (float) p_Value;
					break;

				case 1762540112:
					PointLightMaxClamp = (float) p_Value;
					break;

				case 1653196586:
					ParticleCullingFactor = (float) p_Value;
					break;

				case 1507153422:
					PointLightMinClamp = (float) p_Value;
					break;

				case 1782450290:
					FollowSpawnSource = (bool) p_Value;
					break;

				case 2147054397:
					RepeatParticleSpawning = (bool) p_Value;
					break;

				case 782359646:
					Emissive = (bool) p_Value;
					break;

				case 3245605062:
					ExclusionVolumeCullEnable = (bool) p_Value;
					break;

				case 3351532450:
					TransparencySunShadowEnable = (bool) p_Value;
					break;

				case 3014404943:
					ForceFullRes = (bool) p_Value;
					break;

				case 4045017420:
					LocalSpace = (bool) p_Value;
					break;

				case 2892752538:
					Opaque = (bool) p_Value;
					break;

				case 443059219:
					ActAsPointLight = (bool) p_Value;
					break;

				case 2140513492:
					KillParticlesWithEmitter = (bool) p_Value;
					break;

				case 318607267:
					ForceNiceSorting = (bool) p_Value;
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
				case 2449280824:
					return PointLightIntensity;

				case 2839277155:
					return PointLightPivot;

				case 2852380970:
					return PointLightColor;

				case 415061138:
					return MaxCount;

				case 2088949890:
					return Name;

				case 169511528:
					return TimeScale;

				case 2205246824:
					return LifetimeFrameCount;

				case 2450521238:
					return Lifetime;

				case 3988805269:
					return RootProcessor;

				case 2130300524:
					return VisibleAfterDistance;

				case 3071713232:
					return ZOcclusionLookup;

				case 3808538518:
					return EmittableType;

				case 2088783990:
					return Mesh;

				case 4151251565:
					return DistanceScaleNearValue;

				case 3261781711:
					return PointLightRadius;

				case 2828867447:
					return VertexPixelLightingBlendFactor;

				case 3400652860:
					return GlobalLocalNormalBlendFactor;

				case 2725694050:
					return SoftParticlesFadeDistanceMultiplier;

				case 372734881:
					return LightWrapAroundFactor;

				case 3252516944:
					return LightMultiplier;

				case 1407092256:
					return DistanceScaleFarValue;

				case 1255152585:
					return PointLightRandomIntensityMin;

				case 2057455619:
					return MeshCullingDistance;

				case 1255152855:
					return PointLightRandomIntensityMax;

				case 3656506569:
					return MaxSpawnDistance;

				case 81136980:
					return MinScreenArea;

				case 2372975298:
					return DistanceScaleLength;

				case 1762540112:
					return PointLightMaxClamp;

				case 1653196586:
					return ParticleCullingFactor;

				case 1507153422:
					return PointLightMinClamp;

				case 1782450290:
					return FollowSpawnSource;

				case 2147054397:
					return RepeatParticleSpawning;

				case 782359646:
					return Emissive;

				case 3245605062:
					return ExclusionVolumeCullEnable;

				case 3351532450:
					return TransparencySunShadowEnable;

				case 3014404943:
					return ForceFullRes;

				case 4045017420:
					return LocalSpace;

				case 2892752538:
					return Opaque;

				case 443059219:
					return ActAsPointLight;

				case 2140513492:
					return KillParticlesWithEmitter;

				case 318607267:
					return ForceNiceSorting;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2449280824:
					return typeof(EmitterTemplateData).GetProperty(nameof(PointLightIntensity));

				case 2839277155:
					return typeof(EmitterTemplateData).GetProperty(nameof(PointLightPivot));

				case 2852380970:
					return typeof(EmitterTemplateData).GetProperty(nameof(PointLightColor));

				case 415061138:
					return typeof(EmitterTemplateData).GetProperty(nameof(MaxCount));

				case 2088949890:
					return typeof(EmitterTemplateData).GetProperty(nameof(Name));

				case 169511528:
					return typeof(EmitterTemplateData).GetProperty(nameof(TimeScale));

				case 2205246824:
					return typeof(EmitterTemplateData).GetProperty(nameof(LifetimeFrameCount));

				case 2450521238:
					return typeof(EmitterTemplateData).GetProperty(nameof(Lifetime));

				case 3988805269:
					return typeof(EmitterTemplateData).GetProperty(nameof(RootProcessor));

				case 2130300524:
					return typeof(EmitterTemplateData).GetProperty(nameof(VisibleAfterDistance));

				case 3071713232:
					return typeof(EmitterTemplateData).GetProperty(nameof(ZOcclusionLookup));

				case 3808538518:
					return typeof(EmitterTemplateData).GetProperty(nameof(EmittableType));

				case 2088783990:
					return typeof(EmitterTemplateData).GetProperty(nameof(Mesh));

				case 4151251565:
					return typeof(EmitterTemplateData).GetProperty(nameof(DistanceScaleNearValue));

				case 3261781711:
					return typeof(EmitterTemplateData).GetProperty(nameof(PointLightRadius));

				case 2828867447:
					return typeof(EmitterTemplateData).GetProperty(nameof(VertexPixelLightingBlendFactor));

				case 3400652860:
					return typeof(EmitterTemplateData).GetProperty(nameof(GlobalLocalNormalBlendFactor));

				case 2725694050:
					return typeof(EmitterTemplateData).GetProperty(nameof(SoftParticlesFadeDistanceMultiplier));

				case 372734881:
					return typeof(EmitterTemplateData).GetProperty(nameof(LightWrapAroundFactor));

				case 3252516944:
					return typeof(EmitterTemplateData).GetProperty(nameof(LightMultiplier));

				case 1407092256:
					return typeof(EmitterTemplateData).GetProperty(nameof(DistanceScaleFarValue));

				case 1255152585:
					return typeof(EmitterTemplateData).GetProperty(nameof(PointLightRandomIntensityMin));

				case 2057455619:
					return typeof(EmitterTemplateData).GetProperty(nameof(MeshCullingDistance));

				case 1255152855:
					return typeof(EmitterTemplateData).GetProperty(nameof(PointLightRandomIntensityMax));

				case 3656506569:
					return typeof(EmitterTemplateData).GetProperty(nameof(MaxSpawnDistance));

				case 81136980:
					return typeof(EmitterTemplateData).GetProperty(nameof(MinScreenArea));

				case 2372975298:
					return typeof(EmitterTemplateData).GetProperty(nameof(DistanceScaleLength));

				case 1762540112:
					return typeof(EmitterTemplateData).GetProperty(nameof(PointLightMaxClamp));

				case 1653196586:
					return typeof(EmitterTemplateData).GetProperty(nameof(ParticleCullingFactor));

				case 1507153422:
					return typeof(EmitterTemplateData).GetProperty(nameof(PointLightMinClamp));

				case 1782450290:
					return typeof(EmitterTemplateData).GetProperty(nameof(FollowSpawnSource));

				case 2147054397:
					return typeof(EmitterTemplateData).GetProperty(nameof(RepeatParticleSpawning));

				case 782359646:
					return typeof(EmitterTemplateData).GetProperty(nameof(Emissive));

				case 3245605062:
					return typeof(EmitterTemplateData).GetProperty(nameof(ExclusionVolumeCullEnable));

				case 3351532450:
					return typeof(EmitterTemplateData).GetProperty(nameof(TransparencySunShadowEnable));

				case 3014404943:
					return typeof(EmitterTemplateData).GetProperty(nameof(ForceFullRes));

				case 4045017420:
					return typeof(EmitterTemplateData).GetProperty(nameof(LocalSpace));

				case 2892752538:
					return typeof(EmitterTemplateData).GetProperty(nameof(Opaque));

				case 443059219:
					return typeof(EmitterTemplateData).GetProperty(nameof(ActAsPointLight));

				case 2140513492:
					return typeof(EmitterTemplateData).GetProperty(nameof(KillParticlesWithEmitter));

				case 318607267:
					return typeof(EmitterTemplateData).GetProperty(nameof(ForceNiceSorting));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
