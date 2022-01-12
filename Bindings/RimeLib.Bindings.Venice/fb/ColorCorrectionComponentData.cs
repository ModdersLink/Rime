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
	[ContainerType(16, 160)]
	public class ColorCorrectionComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Contrast { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Saturation { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Brightness { get; set; } = new();

		[ContainerField(144)]
		public Realm Realm { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public float Hue { get; set; }

		[ContainerField(152)]
		public CtrRef<TextureAsset> ColorGradingTexture { get; set; } = new();

		[ContainerField(156), LayoutImmutable, Blittable]
		public bool ColorGradingEnable { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

	}
}
