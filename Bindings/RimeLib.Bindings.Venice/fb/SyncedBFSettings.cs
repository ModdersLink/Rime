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

		public static void Deserialize(SyncedBFSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.GameModeCounterModifier = p_Reader.ReadSingle();
			p_Instance.UnlicensedUnlocksUnlocked = p_Reader.ReadBool();
			p_Instance.NoMinimap = p_Reader.ReadBool();
			p_Instance.NoHud = p_Reader.ReadBool();
			p_Instance.NoMinimapSpotting = p_Reader.ReadBool();
			p_Instance.No3dSpotting = p_Reader.ReadBool();
			p_Instance.NoNameTag = p_Reader.ReadBool();
			p_Instance.OnlySquadLeaderSpawn = p_Reader.ReadBool();
			p_Instance.TeamSwitchingAllowed = p_Reader.ReadBool();
			p_Instance.MemoryDefragUI = p_Reader.ReadBool();
			p_Instance.MemoryGarbageCollectHavok = p_Reader.ReadBool();
			p_Instance.MemoryDefragGlobal = p_Reader.ReadBool();
			p_Instance.AllUnlocksUnlocked = p_Reader.ReadBool();
		}

	}
}
