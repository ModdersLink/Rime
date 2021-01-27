///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 160)]
	public class VehicleStateTriggerEntityData : 
		TriggerEntityData
	{
		protected float m_LockAmount = new float();
		[ContainerField(Name: "LockAmount", Offset: 112, NameHash: 1911182178, Flags: 49469), LayoutImmutable, Blittable]
		public float LockAmount { get { return m_LockAmount; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(LockAmount), this, m_LockAmount, value)) m_LockAmount = value; } } // 0x70 (112)
		
		protected uint m_BulletCount = new uint();
		[ContainerField(Name: "BulletCount", Offset: 116, NameHash: 3022064768, Flags: 49421), LayoutImmutable, Blittable]
		public uint BulletCount { get { return m_BulletCount; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(BulletCount), this, m_BulletCount, value)) m_BulletCount = value; } } // 0x74 (116)
		
		protected uint m_HealthToSet = new uint();
		[ContainerField(Name: "HealthToSet", Offset: 120, NameHash: 2415816000, Flags: 49421), LayoutImmutable, Blittable]
		public uint HealthToSet { get { return m_HealthToSet; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(HealthToSet), this, m_HealthToSet, value)) m_HealthToSet = value; } } // 0x78 (120)
		
		protected uint m_SeatSpecificIndexForHuman = new uint();
		[ContainerField(Name: "SeatSpecificIndexForHuman", Offset: 124, NameHash: 3193401916, Flags: 49421), LayoutImmutable, Blittable]
		public uint SeatSpecificIndexForHuman { get { return m_SeatSpecificIndexForHuman; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(SeatSpecificIndexForHuman), this, m_SeatSpecificIndexForHuman, value)) m_SeatSpecificIndexForHuman = value; } } // 0x7C (124)
		
		protected uint m_SeatSpecificIndexForAi = new uint();
		[ContainerField(Name: "SeatSpecificIndexForAi", Offset: 128, NameHash: 1335416267, Flags: 49421), LayoutImmutable, Blittable]
		public uint SeatSpecificIndexForAi { get { return m_SeatSpecificIndexForAi; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(SeatSpecificIndexForAi), this, m_SeatSpecificIndexForAi, value)) m_SeatSpecificIndexForAi = value; } } // 0x80 (128)
		
		protected float m_DestructionRadius = new float();
		[ContainerField(Name: "DestructionRadius", Offset: 132, NameHash: 3165645571, Flags: 49469), LayoutImmutable, Blittable]
		public float DestructionRadius { get { return m_DestructionRadius; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(DestructionRadius), this, m_DestructionRadius, value)) m_DestructionRadius = value; } } // 0x84 (132)
		
		protected uint m_HealthToCheck = new uint();
		[ContainerField(Name: "HealthToCheck", Offset: 136, NameHash: 2284800324, Flags: 49421), LayoutImmutable, Blittable]
		public uint HealthToCheck { get { return m_HealthToCheck; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(HealthToCheck), this, m_HealthToCheck, value)) m_HealthToCheck = value; } } // 0x88 (136)
		
		protected bool m_AllowHumanToEnterAllSeats = new bool();
		[ContainerField(Name: "AllowHumanToEnterAllSeats", Offset: 140, NameHash: 1793202945, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowHumanToEnterAllSeats { get { return m_AllowHumanToEnterAllSeats; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(AllowHumanToEnterAllSeats), this, m_AllowHumanToEnterAllSeats, value)) m_AllowHumanToEnterAllSeats = value; } } // 0x8C (140)
		
		protected bool m_AllowAiToEnterAllSeats = new bool();
		[ContainerField(Name: "AllowAiToEnterAllSeats", Offset: 141, NameHash: 2314846518, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowAiToEnterAllSeats { get { return m_AllowAiToEnterAllSeats; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(AllowAiToEnterAllSeats), this, m_AllowAiToEnterAllSeats, value)) m_AllowAiToEnterAllSeats = value; } } // 0x8D (141)
		
		protected bool m_BanAiFromSpecificSeat = new bool();
		[ContainerField(Name: "BanAiFromSpecificSeat", Offset: 142, NameHash: 1238752085, Flags: 49325), LayoutImmutable, Blittable]
		public bool BanAiFromSpecificSeat { get { return m_BanAiFromSpecificSeat; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(BanAiFromSpecificSeat), this, m_BanAiFromSpecificSeat, value)) m_BanAiFromSpecificSeat = value; } } // 0x8E (142)
		
		protected bool m_TriggerCriticalOnHealthSet = new bool();
		[ContainerField(Name: "TriggerCriticalOnHealthSet", Offset: 143, NameHash: 1831040713, Flags: 49325), LayoutImmutable, Blittable]
		public bool TriggerCriticalOnHealthSet { get { return m_TriggerCriticalOnHealthSet; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(TriggerCriticalOnHealthSet), this, m_TriggerCriticalOnHealthSet, value)) m_TriggerCriticalOnHealthSet = value; } } // 0x8F (143)
		
		protected bool m_CheckHealthGreaterOrEqual = new bool();
		[ContainerField(Name: "CheckHealthGreaterOrEqual", Offset: 144, NameHash: 1235807484, Flags: 49325), LayoutImmutable, Blittable]
		public bool CheckHealthGreaterOrEqual { get { return m_CheckHealthGreaterOrEqual; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(CheckHealthGreaterOrEqual), this, m_CheckHealthGreaterOrEqual, value)) m_CheckHealthGreaterOrEqual = value; } } // 0x90 (144)
		
		protected bool m_RestrictHumanToSpecificSeat = new bool();
		[ContainerField(Name: "RestrictHumanToSpecificSeat", Offset: 145, NameHash: 3516468286, Flags: 49325), LayoutImmutable, Blittable]
		public bool RestrictHumanToSpecificSeat { get { return m_RestrictHumanToSpecificSeat; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(RestrictHumanToSpecificSeat), this, m_RestrictHumanToSpecificSeat, value)) m_RestrictHumanToSpecificSeat = value; } } // 0x91 (145)
		
		protected bool m_ShouldDestroyVehicles = new bool();
		[ContainerField(Name: "ShouldDestroyVehicles", Offset: 146, NameHash: 2908980741, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShouldDestroyVehicles { get { return m_ShouldDestroyVehicles; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(ShouldDestroyVehicles), this, m_ShouldDestroyVehicles, value)) m_ShouldDestroyVehicles = value; } } // 0x92 (146)
		
		protected bool m_ShouldDestroyBangers = new bool();
		[ContainerField(Name: "ShouldDestroyBangers", Offset: 147, NameHash: 565605152, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShouldDestroyBangers { get { return m_ShouldDestroyBangers; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(ShouldDestroyBangers), this, m_ShouldDestroyBangers, value)) m_ShouldDestroyBangers = value; } } // 0x93 (147)
		
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
