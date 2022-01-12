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
	[ContainerType(4, 24)]
	public class RandomMultiEventEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public List<float> RandomEventWeight { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool UniformDistribution { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool ResetOutputsWhenAllHasTriggered { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool DisableOutputOnTrigger { get; set; }

	}
}
