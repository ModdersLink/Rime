///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class VehicleStateTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float LockAmount { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public uint BulletCount { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public uint HealthToSet { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public uint SeatSpecificIndexForHuman { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public uint SeatSpecificIndexForAi { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float DestructionRadius { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public uint HealthToCheck { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool AllowHumanToEnterAllSeats { get; set; } // 0x8C (140)
		
		[ContainerField(141), LayoutImmutable, Blittable]
		public bool AllowAiToEnterAllSeats { get; set; } // 0x8D (141)
		
		[ContainerField(142), LayoutImmutable, Blittable]
		public bool BanAiFromSpecificSeat { get; set; } // 0x8E (142)
		
		[ContainerField(143), LayoutImmutable, Blittable]
		public bool TriggerCriticalOnHealthSet { get; set; } // 0x8F (143)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool CheckHealthGreaterOrEqual { get; set; } // 0x90 (144)
		
		[ContainerField(145), LayoutImmutable, Blittable]
		public bool RestrictHumanToSpecificSeat { get; set; } // 0x91 (145)
		
		[ContainerField(146), LayoutImmutable, Blittable]
		public bool ShouldDestroyVehicles { get; set; } // 0x92 (146)
		
		[ContainerField(147), LayoutImmutable, Blittable]
		public bool ShouldDestroyBangers { get; set; } // 0x93 (147)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1911182178:
					LockAmount = (float) p_Value;
					break;

				case 3022064768:
					BulletCount = (uint) p_Value;
					break;

				case 2415816000:
					HealthToSet = (uint) p_Value;
					break;

				case 3193401916:
					SeatSpecificIndexForHuman = (uint) p_Value;
					break;

				case 1335416267:
					SeatSpecificIndexForAi = (uint) p_Value;
					break;

				case 3165645571:
					DestructionRadius = (float) p_Value;
					break;

				case 2284800324:
					HealthToCheck = (uint) p_Value;
					break;

				case 1793202945:
					AllowHumanToEnterAllSeats = (bool) p_Value;
					break;

				case 2314846518:
					AllowAiToEnterAllSeats = (bool) p_Value;
					break;

				case 1238752085:
					BanAiFromSpecificSeat = (bool) p_Value;
					break;

				case 1831040713:
					TriggerCriticalOnHealthSet = (bool) p_Value;
					break;

				case 1235807484:
					CheckHealthGreaterOrEqual = (bool) p_Value;
					break;

				case 3516468286:
					RestrictHumanToSpecificSeat = (bool) p_Value;
					break;

				case 2908980741:
					ShouldDestroyVehicles = (bool) p_Value;
					break;

				case 565605152:
					ShouldDestroyBangers = (bool) p_Value;
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
				case 1911182178:
					return LockAmount;

				case 3022064768:
					return BulletCount;

				case 2415816000:
					return HealthToSet;

				case 3193401916:
					return SeatSpecificIndexForHuman;

				case 1335416267:
					return SeatSpecificIndexForAi;

				case 3165645571:
					return DestructionRadius;

				case 2284800324:
					return HealthToCheck;

				case 1793202945:
					return AllowHumanToEnterAllSeats;

				case 2314846518:
					return AllowAiToEnterAllSeats;

				case 1238752085:
					return BanAiFromSpecificSeat;

				case 1831040713:
					return TriggerCriticalOnHealthSet;

				case 1235807484:
					return CheckHealthGreaterOrEqual;

				case 3516468286:
					return RestrictHumanToSpecificSeat;

				case 2908980741:
					return ShouldDestroyVehicles;

				case 565605152:
					return ShouldDestroyBangers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1911182178:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(LockAmount));

				case 3022064768:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(BulletCount));

				case 2415816000:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(HealthToSet));

				case 3193401916:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(SeatSpecificIndexForHuman));

				case 1335416267:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(SeatSpecificIndexForAi));

				case 3165645571:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(DestructionRadius));

				case 2284800324:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(HealthToCheck));

				case 1793202945:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(AllowHumanToEnterAllSeats));

				case 2314846518:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(AllowAiToEnterAllSeats));

				case 1238752085:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(BanAiFromSpecificSeat));

				case 1831040713:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(TriggerCriticalOnHealthSet));

				case 1235807484:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(CheckHealthGreaterOrEqual));

				case 3516468286:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(RestrictHumanToSpecificSeat));

				case 2908980741:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(ShouldDestroyVehicles));

				case 565605152:
					return typeof(VehicleStateTriggerEntityData).GetProperty(nameof(ShouldDestroyBangers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
