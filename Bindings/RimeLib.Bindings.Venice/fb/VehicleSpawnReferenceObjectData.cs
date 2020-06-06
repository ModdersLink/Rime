///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class VehicleSpawnReferenceObjectData : 
		SpawnReferenceObjectData
	{
		[ContainerField(384), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AirDropCarrierTransform { get; set; } = new LinearTransform(); // 0x180 (384)
		
		[ContainerField(448), LayoutImmutable, Blittable]
		public float TimeUntilAbandoned { get; set; } // 0x1C0 (448)
		
		[ContainerField(452), LayoutImmutable, Blittable]
		public float TimeUntilAbandonedIsDestroyed { get; set; } // 0x1C4 (452)
		
		[ContainerField(456)]
		public EntryEnterRestriction EnterRestriction { get; set; } = new EntryEnterRestriction(); // 0x1C8 (456)
		
		[ContainerField(460), LayoutImmutable, Blittable]
		public float BotBailWhenHealthBelow { get; set; } // 0x1CC (460)
		
		[ContainerField(464), LayoutImmutable, Blittable]
		public float BotBailOutDelay { get; set; } // 0x1D0 (464)
		
		[ContainerField(468), LayoutImmutable, Blittable]
		public float WreckDuration { get; set; } // 0x1D4 (468)
		
		[ContainerField(472), LayoutImmutable, Blittable]
		public float RespawnRange { get; set; } // 0x1D8 (472)
		
		[ContainerField(476), LayoutImmutable, Blittable]
		public int ActiveStanceEntryIndex { get; set; } // 0x1DC (476)
		
		[ContainerField(480), LayoutImmutable, Blittable]
		public int ActiveStance { get; set; } // 0x1E0 (480)
		
		[ContainerField(484), LayoutImmutable, Blittable]
		public float KeepAliveRadius { get; set; } // 0x1E4 (484)
		
		[ContainerField(488), LayoutImmutable, Blittable]
		public float VehicleIsNearDistance { get; set; } // 0x1E8 (488)
		
		[ContainerField(492), LayoutImmutable, Blittable]
		public bool SetTeamOnSpawn { get; set; } // 0x1EC (492)
		
		[ContainerField(493), LayoutImmutable, Blittable]
		public bool ApplyDamageToAbandonedVehicles { get; set; } // 0x1ED (493)
		
		[ContainerField(494), LayoutImmutable, Blittable]
		public bool EnableAvailableSeatOutput { get; set; } // 0x1EE (494)
		
		[ContainerField(495), LayoutImmutable, Blittable]
		public bool DisregardSpawnAllowedSetting { get; set; } // 0x1EF (495)
		
		[ContainerField(496), LayoutImmutable, Blittable]
		public bool AffectedByImpulse { get; set; } // 0x1F0 (496)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1315516038:
					AirDropCarrierTransform = (LinearTransform) p_Value;
					break;

				case 590788402:
					TimeUntilAbandoned = (float) p_Value;
					break;

				case 1439912203:
					TimeUntilAbandonedIsDestroyed = (float) p_Value;
					break;

				case 1187365209:
					EnterRestriction = (EntryEnterRestriction) Enum.ToObject(typeof(EntryEnterRestriction), p_Value);
					break;

				case 2439578209:
					BotBailWhenHealthBelow = (float) p_Value;
					break;

				case 2997620897:
					BotBailOutDelay = (float) p_Value;
					break;

				case 3721892947:
					WreckDuration = (float) p_Value;
					break;

				case 696491990:
					RespawnRange = (float) p_Value;
					break;

				case 1513018797:
					ActiveStanceEntryIndex = (int) p_Value;
					break;

				case 3998105031:
					ActiveStance = (int) p_Value;
					break;

				case 3493637041:
					KeepAliveRadius = (float) p_Value;
					break;

				case 3573981180:
					VehicleIsNearDistance = (float) p_Value;
					break;

				case 1290825280:
					SetTeamOnSpawn = (bool) p_Value;
					break;

				case 3721191714:
					ApplyDamageToAbandonedVehicles = (bool) p_Value;
					break;

				case 154114977:
					EnableAvailableSeatOutput = (bool) p_Value;
					break;

				case 3707783529:
					DisregardSpawnAllowedSetting = (bool) p_Value;
					break;

				case 3802426327:
					AffectedByImpulse = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1315516038:
					return AirDropCarrierTransform;

				case 590788402:
					return TimeUntilAbandoned;

				case 1439912203:
					return TimeUntilAbandonedIsDestroyed;

				case 1187365209:
					return EnterRestriction;

				case 2439578209:
					return BotBailWhenHealthBelow;

				case 2997620897:
					return BotBailOutDelay;

				case 3721892947:
					return WreckDuration;

				case 696491990:
					return RespawnRange;

				case 1513018797:
					return ActiveStanceEntryIndex;

				case 3998105031:
					return ActiveStance;

				case 3493637041:
					return KeepAliveRadius;

				case 3573981180:
					return VehicleIsNearDistance;

				case 1290825280:
					return SetTeamOnSpawn;

				case 3721191714:
					return ApplyDamageToAbandonedVehicles;

				case 154114977:
					return EnableAvailableSeatOutput;

				case 3707783529:
					return DisregardSpawnAllowedSetting;

				case 3802426327:
					return AffectedByImpulse;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1315516038:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(AirDropCarrierTransform));

				case 590788402:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(TimeUntilAbandoned));

				case 1439912203:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(TimeUntilAbandonedIsDestroyed));

				case 1187365209:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(EnterRestriction));

				case 2439578209:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(BotBailWhenHealthBelow));

				case 2997620897:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(BotBailOutDelay));

				case 3721892947:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(WreckDuration));

				case 696491990:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(RespawnRange));

				case 1513018797:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(ActiveStanceEntryIndex));

				case 3998105031:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(ActiveStance));

				case 3493637041:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(KeepAliveRadius));

				case 3573981180:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(VehicleIsNearDistance));

				case 1290825280:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(SetTeamOnSpawn));

				case 3721191714:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(ApplyDamageToAbandonedVehicles));

				case 154114977:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(EnableAvailableSeatOutput));

				case 3707783529:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(DisregardSpawnAllowedSetting));

				case 3802426327:
					return typeof(VehicleSpawnReferenceObjectData).GetProperty(nameof(AffectedByImpulse));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
