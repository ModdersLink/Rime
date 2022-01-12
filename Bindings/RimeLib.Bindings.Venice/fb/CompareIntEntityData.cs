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
	public class CompareIntEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public int A { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int B { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool TriggerOnPropertyChange { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool TriggerOnStart { get; set; }

	}
}
