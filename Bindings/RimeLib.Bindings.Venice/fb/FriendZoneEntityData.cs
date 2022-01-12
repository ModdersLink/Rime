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
	public class FriendZoneEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int EnemyWeight { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int FriendlyWeight { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int CorpsTimeout { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public int CorpsWeight { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public bool CountCorpsesForAllTeams { get; set; }

		[ContainerField(29), LayoutImmutable, Blittable]
		public bool InitialZoneRandomized { get; set; }

	}
}
