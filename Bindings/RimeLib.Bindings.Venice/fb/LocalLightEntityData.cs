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
	public class LocalLightEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color { get; set; } = new();

		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ParticleColorScale { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EnlightenColorScale { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float Radius { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float Intensity { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float AttenuationOffset { get; set; }

		[ContainerField(140)]
		public EnlightenColorMode EnlightenColorMode { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool EnlightenEnable { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable]
		public bool SpecularEnable { get; set; }

	}
}
