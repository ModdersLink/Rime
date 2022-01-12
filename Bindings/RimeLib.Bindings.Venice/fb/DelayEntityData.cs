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
	public class DelayEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Delay { get; set; }

		[ContainerField(16)]
		public Realm Realm { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool RunOnce { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool RemoveDuplicateEvents { get; set; }

	}
}
