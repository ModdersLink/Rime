///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
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
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint HeightQueryCacheSize { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint ModifiersCapacity { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint IntersectingModifiersMax { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float ModifierDepthFactor { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float ModifierSlopeMax { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public bool ModifiersEnable { get; set; }

	}
}
