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
	[ContainerType(4, 28)]
	public class RandomDelayEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinDelay { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxDelay { get; set; }

		[ContainerField(20)]
		public Realm Realm { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool RunOnce { get; set; }

	}
}
