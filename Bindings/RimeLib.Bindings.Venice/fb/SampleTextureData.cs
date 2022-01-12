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
	[ContainerType(16, 80)]
	public class SampleTextureData : 
		EvaluatorData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 TextureDimensions { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ColorIntensityMax { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ColorIntensityMin { get; set; } = new();

		[ContainerField(64)]
		public List<Vec4> GradientData { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable]
		public float TextureOriginU { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float TextureOriginV { get; set; }

	}
}
