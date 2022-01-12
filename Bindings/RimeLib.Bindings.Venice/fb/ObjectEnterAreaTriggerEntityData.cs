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
	public class ObjectEnterAreaTriggerEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public UpdatePass UpdatePass { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; }

	}
}
