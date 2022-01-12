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
	public class SyncedBFSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float GameModeCounterModifier { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UnlicensedUnlocksUnlocked { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable]
		public bool NoMinimap { get; set; }

		[ContainerField(18), LayoutImmutable, Blittable]
		public bool NoHud { get; set; }

		[ContainerField(19), LayoutImmutable, Blittable]
		public bool NoMinimapSpotting { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool No3dSpotting { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool NoNameTag { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool OnlySquadLeaderSpawn { get; set; }

		[ContainerField(23), LayoutImmutable, Blittable]
		public bool TeamSwitchingAllowed { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool MemoryDefragUI { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool MemoryGarbageCollectHavok { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable]
		public bool MemoryDefragGlobal { get; set; }

		[ContainerField(27), LayoutImmutable, Blittable]
		public bool AllUnlocksUnlocked { get; set; }

	}
}
