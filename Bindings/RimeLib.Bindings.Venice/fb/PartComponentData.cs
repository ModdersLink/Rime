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
	public class PartComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public RefArray<HealthStateData> HealthStates { get; set; } = new();

		[ContainerField(100)]
		public RefArray<PartLinkData> PartLinks { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool IsSupported { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool IsFragile { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable]
		public bool IsNetworkable { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable]
		public bool IsWindow { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool AnimatePhysics { get; set; }

	}
}
