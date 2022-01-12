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
	[ContainerType(16, 240)]
	public class SkyEffectState : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayerSunColor { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float PanoramicTileFactor { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float SunSize { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float SkyGradientScale { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float SunScale { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float PanoramicUVMinX { get; set; }

		[ContainerField(52)]
		public CtrRef<TextureAsset> SkyGradientTexture { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public float PanoramicUVMinY { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float PanoramicUVMaxY { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float PanoramicUVMaxX { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float PanoramicRotation { get; set; }

		[ContainerField(72)]
		public CtrRef<TextureAsset> PanoramicTexture { get; set; } = new();

		[ContainerField(76)]
		public CtrRef<TextureAsset> PanoramicAlphaTexture { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public float WindDirection { get; set; }

		[ContainerField(84)]
		public CtrRef<TextureAsset> CloudLayerMaskTexture { get; set; } = new();

		[ContainerField(96)]
		public SkyCloudLayer CloudLayer1 { get; set; } = new();

		[ContainerField(160)]
		public SkyCloudLayer CloudLayer2 { get; set; } = new();

		[ContainerField(224)]
		public CtrRef<TextureAsset> StaticEnvmapTexture { get; set; } = new();

		[ContainerField(228), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

	}
}
