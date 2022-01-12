///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
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
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 PointLightIntensity { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PointLightPivot { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PointLightColor { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public uint MaxCount { get; set; }

		[ContainerField(68), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(72), LayoutImmutable, Blittable]
		public float TimeScale { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public uint LifetimeFrameCount { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float Lifetime { get; set; }

		[ContainerField(84)]
		public CtrRef<ProcessorData> RootProcessor { get; set; } = new();

		[ContainerField(88), LayoutImmutable, Blittable]
		public float VisibleAfterDistance { get; set; }

		[ContainerField(92)]
		public List<float> ZOcclusionLookup { get; set; } = new();

		[ContainerField(96)]
		public EmittableType EmittableType { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public float DistanceScaleNearValue { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float PointLightRadius { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float VertexPixelLightingBlendFactor { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float GlobalLocalNormalBlendFactor { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float SoftParticlesFadeDistanceMultiplier { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float LightWrapAroundFactor { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float LightMultiplier { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float DistanceScaleFarValue { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float PointLightRandomIntensityMin { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float MeshCullingDistance { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float PointLightRandomIntensityMax { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float MaxSpawnDistance { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float MinScreenArea { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float DistanceScaleLength { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float PointLightMaxClamp { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float ParticleCullingFactor { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float PointLightMinClamp { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public bool FollowSpawnSource { get; set; }

		[ContainerField(173), LayoutImmutable, Blittable]
		public bool RepeatParticleSpawning { get; set; }

		[ContainerField(174), LayoutImmutable, Blittable]
		public bool Emissive { get; set; }

		[ContainerField(175), LayoutImmutable, Blittable]
		public bool ExclusionVolumeCullEnable { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public bool TransparencySunShadowEnable { get; set; }

		[ContainerField(177), LayoutImmutable, Blittable]
		public bool ForceFullRes { get; set; }

		[ContainerField(178), LayoutImmutable, Blittable]
		public bool LocalSpace { get; set; }

		[ContainerField(179), LayoutImmutable, Blittable]
		public bool Opaque { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public bool ActAsPointLight { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable]
		public bool KillParticlesWithEmitter { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable]
		public bool ForceNiceSorting { get; set; }

	}
}
