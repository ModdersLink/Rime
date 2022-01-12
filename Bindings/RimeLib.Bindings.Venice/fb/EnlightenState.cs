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
	public class EnlightenState : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxGroundColor { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxSunLightColor { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxBackLightColor { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxSkyColor { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public float SunScale { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float OutputScale { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float BounceScale { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float SkyBoxSunLightColorSize { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float SkyBoxBackLightRotationY { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float SkyBoxBackLightColorSize { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float SkyBoxBackLightRotationX { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool SkyBoxEnable { get; set; }

	}
}
