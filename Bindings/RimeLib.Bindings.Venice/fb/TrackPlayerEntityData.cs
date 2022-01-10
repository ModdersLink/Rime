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
	public class TrackPlayerEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float SnapHeightOffsetY { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool RandomizeTracker { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable]
		public bool SnapHeightOnKilledDestroyed { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable]
		public bool CheckPlayerAlive { get; set; }

		[ContainerField(103), LayoutImmutable, Blittable]
		public bool EnforceSharedCombatArea { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool UpdateFlagComponent { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool TrackMultiplePlayers { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable]
		public bool Reseted { get; set; }

		public static void Deserialize(TrackPlayerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SnapHeightOffsetY = p_Reader.ReadSingle();
			p_Instance.RandomizeTracker = p_Reader.ReadBool();
			p_Instance.SnapHeightOnKilledDestroyed = p_Reader.ReadBool();
			p_Instance.CheckPlayerAlive = p_Reader.ReadBool();
			p_Instance.EnforceSharedCombatArea = p_Reader.ReadBool();
			p_Instance.UpdateFlagComponent = p_Reader.ReadBool();
			p_Instance.TrackMultiplePlayers = p_Reader.ReadBool();
			p_Instance.Reseted = p_Reader.ReadBool();
			p_Reader.Seek(5, SeekOrigin.Current);
		}

	}
}
