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
	[ContainerType(16, 112)]
	public class OutdoorLightEffectState : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyColor { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 GroundColor { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SunColor { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 CloudShadowSpeed { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable]
		public float SunRotationX { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float SunRotationY { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float SkyLightAngleFactor { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float SunShadowHeightScale { get; set; }

		[ContainerField(88)]
		public CtrRef<TextureAsset> CloudShadowTexture { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable]
		public float CloudShadowSize { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float CloudShadowExponent { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float CloudShadowCoverage { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool CloudShadowEnable { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

	}
}
