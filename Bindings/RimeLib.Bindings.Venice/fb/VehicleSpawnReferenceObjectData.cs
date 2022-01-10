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
	[ContainerType(16, 512)]
	public class VehicleSpawnReferenceObjectData : 
		SpawnReferenceObjectData
	{
		[ContainerField(384), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AirDropCarrierTransform { get; set; } = new();

		[ContainerField(448), LayoutImmutable, Blittable]
		public float TimeUntilAbandoned { get; set; }

		[ContainerField(452), LayoutImmutable, Blittable]
		public float TimeUntilAbandonedIsDestroyed { get; set; }

		[ContainerField(456)]
		public EntryEnterRestriction EnterRestriction { get; set; } = new();

		[ContainerField(460), LayoutImmutable, Blittable]
		public float BotBailWhenHealthBelow { get; set; }

		[ContainerField(464), LayoutImmutable, Blittable]
		public float BotBailOutDelay { get; set; }

		[ContainerField(468), LayoutImmutable, Blittable]
		public float WreckDuration { get; set; }

		[ContainerField(472), LayoutImmutable, Blittable]
		public float RespawnRange { get; set; }

		[ContainerField(476), LayoutImmutable, Blittable]
		public int ActiveStanceEntryIndex { get; set; }

		[ContainerField(480), LayoutImmutable, Blittable]
		public int ActiveStance { get; set; }

		[ContainerField(484), LayoutImmutable, Blittable]
		public float KeepAliveRadius { get; set; }

		[ContainerField(488), LayoutImmutable, Blittable]
		public float VehicleIsNearDistance { get; set; }

		[ContainerField(492), LayoutImmutable, Blittable]
		public bool SetTeamOnSpawn { get; set; }

		[ContainerField(493), LayoutImmutable, Blittable]
		public bool ApplyDamageToAbandonedVehicles { get; set; }

		[ContainerField(494), LayoutImmutable, Blittable]
		public bool EnableAvailableSeatOutput { get; set; }

		[ContainerField(495), LayoutImmutable, Blittable]
		public bool DisregardSpawnAllowedSetting { get; set; }

		[ContainerField(496), LayoutImmutable, Blittable]
		public bool AffectedByImpulse { get; set; }

		public static void Deserialize(VehicleSpawnReferenceObjectData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.LinearTransform.Deserialize(p_Instance.AirDropCarrierTransform, p_Reader, p_Parser);
			p_Instance.TimeUntilAbandoned = p_Reader.ReadSingle();
			p_Instance.TimeUntilAbandonedIsDestroyed = p_Reader.ReadSingle();
			p_Instance.EnterRestriction = (EntryEnterRestriction) p_Reader.ReadInt32();
			p_Instance.BotBailWhenHealthBelow = p_Reader.ReadSingle();
			p_Instance.BotBailOutDelay = p_Reader.ReadSingle();
			p_Instance.WreckDuration = p_Reader.ReadSingle();
			p_Instance.RespawnRange = p_Reader.ReadSingle();
			p_Instance.ActiveStanceEntryIndex = p_Reader.ReadInt32();
			p_Instance.ActiveStance = p_Reader.ReadInt32();
			p_Instance.KeepAliveRadius = p_Reader.ReadSingle();
			p_Instance.VehicleIsNearDistance = p_Reader.ReadSingle();
			p_Instance.SetTeamOnSpawn = p_Reader.ReadBool();
			p_Instance.ApplyDamageToAbandonedVehicles = p_Reader.ReadBool();
			p_Instance.EnableAvailableSeatOutput = p_Reader.ReadBool();
			p_Instance.DisregardSpawnAllowedSetting = p_Reader.ReadBool();
			p_Instance.AffectedByImpulse = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
