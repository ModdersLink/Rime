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
	[ContainerType(16, 208)]
	public class SpotLightEntityData : 
		LocalLightEntityData
	{
		[ContainerField(160)]
		public SpotLightShape Shape { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable]
		public float ConeInnerAngle { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float ConeOuterAngle { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float FrustumFov { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float FrustumAspect { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float OrthoWidth { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float OrthoHeight { get; set; }

		[ContainerField(188)]
		public CtrRef<TextureAsset> Texture { get; set; } = new();

		[ContainerField(192)]
		public QualityLevel CastShadowsMinLevel { get; set; } = new();

		[ContainerField(196), LayoutImmutable, Blittable]
		public bool CastShadowsEnable { get; set; }

	}
}
