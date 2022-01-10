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
	[ContainerType(16, 416)]
	public class CharacterSpawnReferenceObjectData : 
		SpawnReferenceObjectData
	{
		[ContainerField(384)]
		public PlayerSpawnType PlayerType { get; set; } = new();

		[ContainerField(388), LayoutImmutable, Blittable]
		public uint VehicleEntryIndex { get; set; }

		[ContainerField(392)]
		public CtrRef<SoldierSpawnTemplateData> Template { get; set; } = new();

		[ContainerField(396), LayoutImmutable, Blittable]
		public float HumanTargetPreference { get; set; }

		[ContainerField(400)]
		public UIHudIcon MinimapIcon { get; set; } = new();

		[ContainerField(404), LayoutImmutable, Blittable]
		public bool AllowFallbackOnNextAvailabeVehicleEntry { get; set; }

		[ContainerField(405), LayoutImmutable, Blittable]
		public bool CheckMaxPlayersInVehicle { get; set; }

		[ContainerField(406), LayoutImmutable, Blittable]
		public bool AffectMinimapPosition { get; set; }

		[ContainerField(407), LayoutImmutable, Blittable]
		public bool IsTarget { get; set; }

		[ContainerField(408), LayoutImmutable, Blittable]
		public bool IgnoreVehicleIcon { get; set; }

		public static void Deserialize(CharacterSpawnReferenceObjectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PlayerType = (PlayerSpawnType) p_Reader.ReadInt32();
			p_Instance.VehicleEntryIndex = p_Reader.ReadUInt32();
			p_Instance.Template.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.HumanTargetPreference = p_Reader.ReadSingle();
			p_Instance.MinimapIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.AllowFallbackOnNextAvailabeVehicleEntry = p_Reader.ReadBool();
			p_Instance.CheckMaxPlayersInVehicle = p_Reader.ReadBool();
			p_Instance.AffectMinimapPosition = p_Reader.ReadBool();
			p_Instance.IsTarget = p_Reader.ReadBool();
			p_Instance.IgnoreVehicleIcon = p_Reader.ReadBool();
			p_Reader.Seek(7, SeekOrigin.Current);
		}

	}
}
