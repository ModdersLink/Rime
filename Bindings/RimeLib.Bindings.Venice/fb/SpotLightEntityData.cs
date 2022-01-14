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
	[ContainerType(16, 208)]
	public class SpotLightEntityData : 
		LocalLightEntityData
	{
		[ContainerField(160), JsonProperty(Order = 160)]
		public SpotLightShape Shape { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float ConeInnerAngle { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float ConeOuterAngle { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float FrustumFov { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float FrustumAspect { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float OrthoWidth { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float OrthoHeight { get; set; }

		[ContainerField(188), JsonProperty(Order = 188)]
		public CtrRef<TextureAsset> Texture { get; set; } = new();

		[ContainerField(192), JsonProperty(Order = 192)]
		public QualityLevel CastShadowsMinLevel { get; set; } = new();

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public bool CastShadowsEnable { get; set; }

	}
}
