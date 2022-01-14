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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 192)]
	public class EmitterTemplateData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec4 PointLightIntensity { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 PointLightPivot { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 PointLightColor { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public uint MaxCount { get; set; }

		[ContainerField(68), LayoutImmutable, JsonProperty(Order = 68)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float TimeScale { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public uint LifetimeFrameCount { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float Lifetime { get; set; }

		[ContainerField(84), JsonProperty(Order = 84)]
		public CtrRef<ProcessorData> RootProcessor { get; set; } = new();

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float VisibleAfterDistance { get; set; }

		[ContainerField(92), JsonProperty(Order = 92)]
		public List<float> ZOcclusionLookup { get; set; } = new();

		[ContainerField(96), JsonProperty(Order = 96)]
		public EmittableType EmittableType { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float DistanceScaleNearValue { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float PointLightRadius { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float VertexPixelLightingBlendFactor { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float GlobalLocalNormalBlendFactor { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float SoftParticlesFadeDistanceMultiplier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float LightWrapAroundFactor { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float LightMultiplier { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float DistanceScaleFarValue { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float PointLightRandomIntensityMin { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float MeshCullingDistance { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float PointLightRandomIntensityMax { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float MaxSpawnDistance { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float MinScreenArea { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public float DistanceScaleLength { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float PointLightMaxClamp { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float ParticleCullingFactor { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float PointLightMinClamp { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public bool FollowSpawnSource { get; set; }

		[ContainerField(173), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
		public bool RepeatParticleSpawning { get; set; }

		[ContainerField(174), LayoutImmutable, Blittable, JsonProperty(Order = 174)]
		public bool Emissive { get; set; }

		[ContainerField(175), LayoutImmutable, Blittable, JsonProperty(Order = 175)]
		public bool ExclusionVolumeCullEnable { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public bool TransparencySunShadowEnable { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
		public bool ForceFullRes { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
		public bool LocalSpace { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
		public bool Opaque { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public bool ActAsPointLight { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		public bool KillParticlesWithEmitter { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
		public bool ForceNiceSorting { get; set; }

	}
}
