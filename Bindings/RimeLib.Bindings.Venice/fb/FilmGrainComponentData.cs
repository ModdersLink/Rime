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
	[ContainerType(16, 144)]
	public class FilmGrainComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ColorScale { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 TextureScale { get; set; } = new();

		[ContainerField(120)]
		public Realm Realm { get; set; } = new();

		[ContainerField(124)]
		public CtrRef<TextureAsset> Texture { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool LinearFilteringEnable { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable]
		public bool RandomEnable { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

	}
}
