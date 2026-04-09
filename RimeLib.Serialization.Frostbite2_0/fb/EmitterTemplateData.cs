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
	[ContainerType(16, 192)]
	public partial class EmitterTemplateData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec4 _PointLightIntensity = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _PointLightPivot = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec3 _PointLightColor = new();

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private uint _MaxCount;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, JsonProperty(Order = 68)]
		private string _Name = string.Empty;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _TimeScale;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private uint _LifetimeFrameCount;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _Lifetime;

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private CtrRef<ProcessorData> _RootProcessor = new();

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _VisibleAfterDistance;

		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private List<float> _ZOcclusionLookup = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private EmittableType _EmittableType = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private CtrRef<MeshAsset> _Mesh = new();

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _DistanceScaleNearValue;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _PointLightRadius;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _VertexPixelLightingBlendFactor;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _GlobalLocalNormalBlendFactor;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _SoftParticlesFadeDistanceMultiplier;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _LightWrapAroundFactor;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _LightMultiplier;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _DistanceScaleFarValue;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _PointLightRandomIntensityMin;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _MeshCullingDistance;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _PointLightRandomIntensityMax;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _MaxSpawnDistance;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _MinScreenArea;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private float _DistanceScaleLength;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _PointLightMaxClamp;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _ParticleCullingFactor;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _PointLightMinClamp;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private bool _FollowSpawnSource;

		[ObservableProperty]
		[property: ContainerField(173), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
		private bool _RepeatParticleSpawning;

		[ObservableProperty]
		[property: ContainerField(174), LayoutImmutable, Blittable, JsonProperty(Order = 174)]
		private bool _Emissive;

		[ObservableProperty]
		[property: ContainerField(175), LayoutImmutable, Blittable, JsonProperty(Order = 175)]
		private bool _ExclusionVolumeCullEnable;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private bool _TransparencySunShadowEnable;

		[ObservableProperty]
		[property: ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		private bool _ForceFullRes;

		[ObservableProperty]
		[property: ContainerField(178), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
		private bool _LocalSpace;

		[ObservableProperty]
		[property: ContainerField(179), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
		private bool _Opaque;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private bool _ActAsPointLight;

		[ObservableProperty]
		[property: ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		private bool _KillParticlesWithEmitter;

		[ObservableProperty]
		[property: ContainerField(182), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
		private bool _ForceNiceSorting;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
			PointLightIntensity.Serialize(p_Writer, p_EbxWriter);
			PointLightPivot.Serialize(p_Writer, p_EbxWriter);
			PointLightColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaxCount);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(TimeScale);
			p_Writer.Write(LifetimeFrameCount);
			p_Writer.Write(Lifetime);
			p_Writer.Write(p_EbxWriter.WriteImport(RootProcessor));
			p_Writer.Write(VisibleAfterDistance);
			(RimeWriter Writer, uint ArrayIndex) s_ZOcclusionLookup = p_EbxWriter.GetArrayWriter(ZOcclusionLookup.GetType(), ZOcclusionLookup.Count);
			p_Writer.Write(s_ZOcclusionLookup.ArrayIndex);
			foreach (var s_Entry in ZOcclusionLookup)
			{
				s_ZOcclusionLookup.Writer.Write(s_Entry);
			}
			p_Writer.Write((int) EmittableType);
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(DistanceScaleNearValue);
			p_Writer.Write(PointLightRadius);
			p_Writer.Write(VertexPixelLightingBlendFactor);
			p_Writer.Write(GlobalLocalNormalBlendFactor);
			p_Writer.Write(SoftParticlesFadeDistanceMultiplier);
			p_Writer.Write(LightWrapAroundFactor);
			p_Writer.Write(LightMultiplier);
			p_Writer.Write(DistanceScaleFarValue);
			p_Writer.Write(PointLightRandomIntensityMin);
			p_Writer.Write(MeshCullingDistance);
			p_Writer.Write(PointLightRandomIntensityMax);
			p_Writer.Write(MaxSpawnDistance);
			p_Writer.Write(MinScreenArea);
			p_Writer.Write(DistanceScaleLength);
			p_Writer.Write(PointLightMaxClamp);
			p_Writer.Write(ParticleCullingFactor);
			p_Writer.Write(PointLightMinClamp);
			p_Writer.Write(FollowSpawnSource);
			p_Writer.Write(RepeatParticleSpawning);
			p_Writer.Write(Emissive);
			p_Writer.Write(ExclusionVolumeCullEnable);
			p_Writer.Write(TransparencySunShadowEnable);
			p_Writer.Write(ForceFullRes);
			p_Writer.Write(LocalSpace);
			p_Writer.Write(Opaque);
			p_Writer.Write(ActAsPointLight);
			p_Writer.Write(KillParticlesWithEmitter);
			p_Writer.Write(ForceNiceSorting);
			p_Writer.WriteNullBytes(9);
		}
	}
}
