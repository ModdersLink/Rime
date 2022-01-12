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
	[ContainerType(4, 32)]
	public class TerrainSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint HeightQueryCacheSize { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ModifiersCapacity { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint IntersectingModifiersMax { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float ModifierDepthFactor { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float ModifierSlopeMax { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool ModifiersEnable { get; set; }

	}
}
