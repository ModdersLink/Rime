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
	[ContainerType(16, 224)]
	public class OutdoorLightComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 SunColor { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec2 CloudShadowSpeed { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec3 SkyColor { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public Vec3 GroundColor { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float SunRotationY { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float SunRotationX { get; set; }

		[ContainerField(168), JsonProperty(Order = 168)]
		public Realm Realm { get; set; } = new();

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float SkyLightAngleFactor { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float SunSpecularScale { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float SkyEnvmapShadowScale { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float SunShadowHeightScale { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float CloudShadowCoverage { get; set; }

		[ContainerField(192), JsonProperty(Order = 192)]
		public CtrRef<TextureAsset> CloudShadowTexture { get; set; } = new();

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public float TranslucencyDistortion { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float CloudShadowSize { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float TranslucencyAmbient { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float CloudShadowExponent { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float TranslucencyScale { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float TranslucencyPower { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public bool Enable { get; set; }

		[ContainerField(221), LayoutImmutable, Blittable, JsonProperty(Order = 221)]
		public bool CloudShadowEnable { get; set; }

	}
}
