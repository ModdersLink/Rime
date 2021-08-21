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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 192)]
	public class EmitterTemplateData : 
		DataContainer
	{
		protected Vec4 m_PointLightIntensity = new Vec4();
		[ContainerField(Name: "PointLightIntensity", Offset: 16, NameHash: 2449280824, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 PointLightIntensity { get { return m_PointLightIntensity; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(PointLightIntensity), this, m_PointLightIntensity, value)) m_PointLightIntensity = value; } } // 0x10 (16)
		
		protected Vec3 m_PointLightPivot = new Vec3();
		[ContainerField(Name: "PointLightPivot", Offset: 32, NameHash: 2839277155, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PointLightPivot { get { return m_PointLightPivot; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(PointLightPivot), this, m_PointLightPivot, value)) m_PointLightPivot = value; } } // 0x20 (32)
		
		protected Vec3 m_PointLightColor = new Vec3();
		[ContainerField(Name: "PointLightColor", Offset: 48, NameHash: 2852380970, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PointLightColor { get { return m_PointLightColor; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(PointLightColor), this, m_PointLightColor, value)) m_PointLightColor = value; } } // 0x30 (48)
		
		protected uint m_MaxCount = new uint();
		[ContainerField(Name: "MaxCount", Offset: 64, NameHash: 415061138, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxCount { get { return m_MaxCount; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(MaxCount), this, m_MaxCount, value)) m_MaxCount = value; } } // 0x40 (64)
		
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 68, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x44 (68)
		
		protected float m_TimeScale = new float();
		[ContainerField(Name: "TimeScale", Offset: 72, NameHash: 169511528, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeScale { get { return m_TimeScale; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(TimeScale), this, m_TimeScale, value)) m_TimeScale = value; } } // 0x48 (72)
		
		protected uint m_LifetimeFrameCount = new uint();
		[ContainerField(Name: "LifetimeFrameCount", Offset: 76, NameHash: 2205246824, Flags: 49421), LayoutImmutable, Blittable]
		public uint LifetimeFrameCount { get { return m_LifetimeFrameCount; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(LifetimeFrameCount), this, m_LifetimeFrameCount, value)) m_LifetimeFrameCount = value; } } // 0x4C (76)
		
		protected float m_Lifetime = new float();
		[ContainerField(Name: "Lifetime", Offset: 80, NameHash: 2450521238, Flags: 49469), LayoutImmutable, Blittable]
		public float Lifetime { get { return m_Lifetime; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(Lifetime), this, m_Lifetime, value)) m_Lifetime = value; } } // 0x50 (80)
		
		protected CtrRef<ProcessorData> m_RootProcessor = new CtrRef<ProcessorData>();
		[ContainerField(Name: "RootProcessor", Offset: 84, NameHash: 3988805269, Flags: 53)]
		public CtrRef<ProcessorData> RootProcessor { get { return m_RootProcessor; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(RootProcessor), this, m_RootProcessor, value)) m_RootProcessor = value; } } // 0x54 (84)
		
		protected float m_VisibleAfterDistance = new float();
		[ContainerField(Name: "VisibleAfterDistance", Offset: 88, NameHash: 2130300524, Flags: 49469), LayoutImmutable, Blittable]
		public float VisibleAfterDistance { get { return m_VisibleAfterDistance; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(VisibleAfterDistance), this, m_VisibleAfterDistance, value)) m_VisibleAfterDistance = value; } } // 0x58 (88)
		
		protected List<float> m_ZOcclusionLookup = new List<float>();
		[ContainerField(Name: "ZOcclusionLookup", Offset: 92, NameHash: 3071713232, Flags: 65)]
		public List<float> ZOcclusionLookup { get { return m_ZOcclusionLookup; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(ZOcclusionLookup), this, m_ZOcclusionLookup, value)) m_ZOcclusionLookup = value; } } // 0x5C (92)
		
		protected EmittableType m_EmittableType = new EmittableType();
		[ContainerField(Name: "EmittableType", Offset: 96, NameHash: 3808538518, Flags: 137)]
		public EmittableType EmittableType { get { return m_EmittableType; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(EmittableType), this, m_EmittableType, value)) m_EmittableType = value; } } // 0x60 (96)
		
		protected CtrRef<MeshAsset> m_Mesh = new CtrRef<MeshAsset>();
		[ContainerField(Name: "Mesh", Offset: 100, NameHash: 2088783990, Flags: 53)]
		public CtrRef<MeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x64 (100)
		
		protected float m_DistanceScaleNearValue = new float();
		[ContainerField(Name: "DistanceScaleNearValue", Offset: 104, NameHash: 4151251565, Flags: 49469), LayoutImmutable, Blittable]
		public float DistanceScaleNearValue { get { return m_DistanceScaleNearValue; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(DistanceScaleNearValue), this, m_DistanceScaleNearValue, value)) m_DistanceScaleNearValue = value; } } // 0x68 (104)
		
		protected float m_PointLightRadius = new float();
		[ContainerField(Name: "PointLightRadius", Offset: 108, NameHash: 3261781711, Flags: 49469), LayoutImmutable, Blittable]
		public float PointLightRadius { get { return m_PointLightRadius; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(PointLightRadius), this, m_PointLightRadius, value)) m_PointLightRadius = value; } } // 0x6C (108)
		
		protected float m_VertexPixelLightingBlendFactor = new float();
		[ContainerField(Name: "VertexPixelLightingBlendFactor", Offset: 112, NameHash: 2828867447, Flags: 49469), LayoutImmutable, Blittable]
		public float VertexPixelLightingBlendFactor { get { return m_VertexPixelLightingBlendFactor; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(VertexPixelLightingBlendFactor), this, m_VertexPixelLightingBlendFactor, value)) m_VertexPixelLightingBlendFactor = value; } } // 0x70 (112)
		
		protected float m_GlobalLocalNormalBlendFactor = new float();
		[ContainerField(Name: "GlobalLocalNormalBlendFactor", Offset: 116, NameHash: 3400652860, Flags: 49469), LayoutImmutable, Blittable]
		public float GlobalLocalNormalBlendFactor { get { return m_GlobalLocalNormalBlendFactor; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(GlobalLocalNormalBlendFactor), this, m_GlobalLocalNormalBlendFactor, value)) m_GlobalLocalNormalBlendFactor = value; } } // 0x74 (116)
		
		protected float m_SoftParticlesFadeDistanceMultiplier = new float();
		[ContainerField(Name: "SoftParticlesFadeDistanceMultiplier", Offset: 120, NameHash: 2725694050, Flags: 49469), LayoutImmutable, Blittable]
		public float SoftParticlesFadeDistanceMultiplier { get { return m_SoftParticlesFadeDistanceMultiplier; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(SoftParticlesFadeDistanceMultiplier), this, m_SoftParticlesFadeDistanceMultiplier, value)) m_SoftParticlesFadeDistanceMultiplier = value; } } // 0x78 (120)
		
		protected float m_LightWrapAroundFactor = new float();
		[ContainerField(Name: "LightWrapAroundFactor", Offset: 124, NameHash: 372734881, Flags: 49469), LayoutImmutable, Blittable]
		public float LightWrapAroundFactor { get { return m_LightWrapAroundFactor; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(LightWrapAroundFactor), this, m_LightWrapAroundFactor, value)) m_LightWrapAroundFactor = value; } } // 0x7C (124)
		
		protected float m_LightMultiplier = new float();
		[ContainerField(Name: "LightMultiplier", Offset: 128, NameHash: 3252516944, Flags: 49469), LayoutImmutable, Blittable]
		public float LightMultiplier { get { return m_LightMultiplier; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(LightMultiplier), this, m_LightMultiplier, value)) m_LightMultiplier = value; } } // 0x80 (128)
		
		protected float m_DistanceScaleFarValue = new float();
		[ContainerField(Name: "DistanceScaleFarValue", Offset: 132, NameHash: 1407092256, Flags: 49469), LayoutImmutable, Blittable]
		public float DistanceScaleFarValue { get { return m_DistanceScaleFarValue; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(DistanceScaleFarValue), this, m_DistanceScaleFarValue, value)) m_DistanceScaleFarValue = value; } } // 0x84 (132)
		
		protected float m_PointLightRandomIntensityMin = new float();
		[ContainerField(Name: "PointLightRandomIntensityMin", Offset: 136, NameHash: 1255152585, Flags: 49469), LayoutImmutable, Blittable]
		public float PointLightRandomIntensityMin { get { return m_PointLightRandomIntensityMin; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(PointLightRandomIntensityMin), this, m_PointLightRandomIntensityMin, value)) m_PointLightRandomIntensityMin = value; } } // 0x88 (136)
		
		protected float m_MeshCullingDistance = new float();
		[ContainerField(Name: "MeshCullingDistance", Offset: 140, NameHash: 2057455619, Flags: 49469), LayoutImmutable, Blittable]
		public float MeshCullingDistance { get { return m_MeshCullingDistance; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(MeshCullingDistance), this, m_MeshCullingDistance, value)) m_MeshCullingDistance = value; } } // 0x8C (140)
		
		protected float m_PointLightRandomIntensityMax = new float();
		[ContainerField(Name: "PointLightRandomIntensityMax", Offset: 144, NameHash: 1255152855, Flags: 49469), LayoutImmutable, Blittable]
		public float PointLightRandomIntensityMax { get { return m_PointLightRandomIntensityMax; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(PointLightRandomIntensityMax), this, m_PointLightRandomIntensityMax, value)) m_PointLightRandomIntensityMax = value; } } // 0x90 (144)
		
		protected float m_MaxSpawnDistance = new float();
		[ContainerField(Name: "MaxSpawnDistance", Offset: 148, NameHash: 3656506569, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSpawnDistance { get { return m_MaxSpawnDistance; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(MaxSpawnDistance), this, m_MaxSpawnDistance, value)) m_MaxSpawnDistance = value; } } // 0x94 (148)
		
		protected float m_MinScreenArea = new float();
		[ContainerField(Name: "MinScreenArea", Offset: 152, NameHash: 81136980, Flags: 49469), LayoutImmutable, Blittable]
		public float MinScreenArea { get { return m_MinScreenArea; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(MinScreenArea), this, m_MinScreenArea, value)) m_MinScreenArea = value; } } // 0x98 (152)
		
		protected float m_DistanceScaleLength = new float();
		[ContainerField(Name: "DistanceScaleLength", Offset: 156, NameHash: 2372975298, Flags: 49469), LayoutImmutable, Blittable]
		public float DistanceScaleLength { get { return m_DistanceScaleLength; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(DistanceScaleLength), this, m_DistanceScaleLength, value)) m_DistanceScaleLength = value; } } // 0x9C (156)
		
		protected float m_PointLightMaxClamp = new float();
		[ContainerField(Name: "PointLightMaxClamp", Offset: 160, NameHash: 1762540112, Flags: 49469), LayoutImmutable, Blittable]
		public float PointLightMaxClamp { get { return m_PointLightMaxClamp; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(PointLightMaxClamp), this, m_PointLightMaxClamp, value)) m_PointLightMaxClamp = value; } } // 0xA0 (160)
		
		protected float m_ParticleCullingFactor = new float();
		[ContainerField(Name: "ParticleCullingFactor", Offset: 164, NameHash: 1653196586, Flags: 49469), LayoutImmutable, Blittable]
		public float ParticleCullingFactor { get { return m_ParticleCullingFactor; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(ParticleCullingFactor), this, m_ParticleCullingFactor, value)) m_ParticleCullingFactor = value; } } // 0xA4 (164)
		
		protected float m_PointLightMinClamp = new float();
		[ContainerField(Name: "PointLightMinClamp", Offset: 168, NameHash: 1507153422, Flags: 49469), LayoutImmutable, Blittable]
		public float PointLightMinClamp { get { return m_PointLightMinClamp; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(PointLightMinClamp), this, m_PointLightMinClamp, value)) m_PointLightMinClamp = value; } } // 0xA8 (168)
		
		protected bool m_FollowSpawnSource = new bool();
		[ContainerField(Name: "FollowSpawnSource", Offset: 172, NameHash: 1782450290, Flags: 49325), LayoutImmutable, Blittable]
		public bool FollowSpawnSource { get { return m_FollowSpawnSource; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(FollowSpawnSource), this, m_FollowSpawnSource, value)) m_FollowSpawnSource = value; } } // 0xAC (172)
		
		protected bool m_RepeatParticleSpawning = new bool();
		[ContainerField(Name: "RepeatParticleSpawning", Offset: 173, NameHash: 2147054397, Flags: 49325), LayoutImmutable, Blittable]
		public bool RepeatParticleSpawning { get { return m_RepeatParticleSpawning; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(RepeatParticleSpawning), this, m_RepeatParticleSpawning, value)) m_RepeatParticleSpawning = value; } } // 0xAD (173)
		
		protected bool m_Emissive = new bool();
		[ContainerField(Name: "Emissive", Offset: 174, NameHash: 782359646, Flags: 49325), LayoutImmutable, Blittable]
		public bool Emissive { get { return m_Emissive; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(Emissive), this, m_Emissive, value)) m_Emissive = value; } } // 0xAE (174)
		
		protected bool m_ExclusionVolumeCullEnable = new bool();
		[ContainerField(Name: "ExclusionVolumeCullEnable", Offset: 175, NameHash: 3245605062, Flags: 49325), LayoutImmutable, Blittable]
		public bool ExclusionVolumeCullEnable { get { return m_ExclusionVolumeCullEnable; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(ExclusionVolumeCullEnable), this, m_ExclusionVolumeCullEnable, value)) m_ExclusionVolumeCullEnable = value; } } // 0xAF (175)
		
		protected bool m_TransparencySunShadowEnable = new bool();
		[ContainerField(Name: "TransparencySunShadowEnable", Offset: 176, NameHash: 3351532450, Flags: 49325), LayoutImmutable, Blittable]
		public bool TransparencySunShadowEnable { get { return m_TransparencySunShadowEnable; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(TransparencySunShadowEnable), this, m_TransparencySunShadowEnable, value)) m_TransparencySunShadowEnable = value; } } // 0xB0 (176)
		
		protected bool m_ForceFullRes = new bool();
		[ContainerField(Name: "ForceFullRes", Offset: 177, NameHash: 3014404943, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceFullRes { get { return m_ForceFullRes; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(ForceFullRes), this, m_ForceFullRes, value)) m_ForceFullRes = value; } } // 0xB1 (177)
		
		protected bool m_LocalSpace = new bool();
		[ContainerField(Name: "LocalSpace", Offset: 178, NameHash: 4045017420, Flags: 49325), LayoutImmutable, Blittable]
		public bool LocalSpace { get { return m_LocalSpace; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(LocalSpace), this, m_LocalSpace, value)) m_LocalSpace = value; } } // 0xB2 (178)
		
		protected bool m_Opaque = new bool();
		[ContainerField(Name: "Opaque", Offset: 179, NameHash: 2892752538, Flags: 49325), LayoutImmutable, Blittable]
		public bool Opaque { get { return m_Opaque; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(Opaque), this, m_Opaque, value)) m_Opaque = value; } } // 0xB3 (179)
		
		protected bool m_ActAsPointLight = new bool();
		[ContainerField(Name: "ActAsPointLight", Offset: 180, NameHash: 443059219, Flags: 49325), LayoutImmutable, Blittable]
		public bool ActAsPointLight { get { return m_ActAsPointLight; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(ActAsPointLight), this, m_ActAsPointLight, value)) m_ActAsPointLight = value; } } // 0xB4 (180)
		
		protected bool m_KillParticlesWithEmitter = new bool();
		[ContainerField(Name: "KillParticlesWithEmitter", Offset: 181, NameHash: 2140513492, Flags: 49325), LayoutImmutable, Blittable]
		public bool KillParticlesWithEmitter { get { return m_KillParticlesWithEmitter; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(KillParticlesWithEmitter), this, m_KillParticlesWithEmitter, value)) m_KillParticlesWithEmitter = value; } } // 0xB5 (181)
		
		protected bool m_ForceNiceSorting = new bool();
		[ContainerField(Name: "ForceNiceSorting", Offset: 182, NameHash: 318607267, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceNiceSorting { get { return m_ForceNiceSorting; } set { if (OnPropertyChanging("EmitterTemplateData." + nameof(ForceNiceSorting), this, m_ForceNiceSorting, value)) m_ForceNiceSorting = value; } } // 0xB6 (182)
		
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
