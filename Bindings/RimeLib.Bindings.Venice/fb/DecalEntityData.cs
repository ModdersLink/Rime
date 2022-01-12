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
	[ContainerType(16, 128)]
	public class DecalEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();

		[ContainerField(100)]
		public DecalAtlasTile AtlasTile { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public sbyte MaterialIndex { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable]
		public sbyte SortingPriority { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable]
		public bool Projected { get; set; }

	}
}
