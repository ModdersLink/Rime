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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class VehicleStateTriggerEntityData : 
		TriggerEntityData
	{
		protected float m_LockAmount = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1911182178)]
		public float LockAmount { get { return m_LockAmount; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(LockAmount), this, m_LockAmount, value)) m_LockAmount = value; } } // 0x70 (112)
		
		protected uint m_BulletCount = new uint();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3022064768)]
		public uint BulletCount { get { return m_BulletCount; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(BulletCount), this, m_BulletCount, value)) m_BulletCount = value; } } // 0x74 (116)
		
		protected uint m_HealthToSet = new uint();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2415816000)]
		public uint HealthToSet { get { return m_HealthToSet; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(HealthToSet), this, m_HealthToSet, value)) m_HealthToSet = value; } } // 0x78 (120)
		
		protected uint m_SeatSpecificIndexForHuman = new uint();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3193401916)]
		public uint SeatSpecificIndexForHuman { get { return m_SeatSpecificIndexForHuman; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(SeatSpecificIndexForHuman), this, m_SeatSpecificIndexForHuman, value)) m_SeatSpecificIndexForHuman = value; } } // 0x7C (124)
		
		protected uint m_SeatSpecificIndexForAi = new uint();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(1335416267)]
		public uint SeatSpecificIndexForAi { get { return m_SeatSpecificIndexForAi; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(SeatSpecificIndexForAi), this, m_SeatSpecificIndexForAi, value)) m_SeatSpecificIndexForAi = value; } } // 0x80 (128)
		
		protected float m_DestructionRadius = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3165645571)]
		public float DestructionRadius { get { return m_DestructionRadius; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(DestructionRadius), this, m_DestructionRadius, value)) m_DestructionRadius = value; } } // 0x84 (132)
		
		protected uint m_HealthToCheck = new uint();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2284800324)]
		public uint HealthToCheck { get { return m_HealthToCheck; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(HealthToCheck), this, m_HealthToCheck, value)) m_HealthToCheck = value; } } // 0x88 (136)
		
		protected bool m_AllowHumanToEnterAllSeats = new bool();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1793202945)]
		public bool AllowHumanToEnterAllSeats { get { return m_AllowHumanToEnterAllSeats; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(AllowHumanToEnterAllSeats), this, m_AllowHumanToEnterAllSeats, value)) m_AllowHumanToEnterAllSeats = value; } } // 0x8C (140)
		
		protected bool m_AllowAiToEnterAllSeats = new bool();
		[ContainerField(141), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2314846518)]
		public bool AllowAiToEnterAllSeats { get { return m_AllowAiToEnterAllSeats; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(AllowAiToEnterAllSeats), this, m_AllowAiToEnterAllSeats, value)) m_AllowAiToEnterAllSeats = value; } } // 0x8D (141)
		
		protected bool m_BanAiFromSpecificSeat = new bool();
		[ContainerField(142), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1238752085)]
		public bool BanAiFromSpecificSeat { get { return m_BanAiFromSpecificSeat; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(BanAiFromSpecificSeat), this, m_BanAiFromSpecificSeat, value)) m_BanAiFromSpecificSeat = value; } } // 0x8E (142)
		
		protected bool m_TriggerCriticalOnHealthSet = new bool();
		[ContainerField(143), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1831040713)]
		public bool TriggerCriticalOnHealthSet { get { return m_TriggerCriticalOnHealthSet; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(TriggerCriticalOnHealthSet), this, m_TriggerCriticalOnHealthSet, value)) m_TriggerCriticalOnHealthSet = value; } } // 0x8F (143)
		
		protected bool m_CheckHealthGreaterOrEqual = new bool();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1235807484)]
		public bool CheckHealthGreaterOrEqual { get { return m_CheckHealthGreaterOrEqual; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(CheckHealthGreaterOrEqual), this, m_CheckHealthGreaterOrEqual, value)) m_CheckHealthGreaterOrEqual = value; } } // 0x90 (144)
		
		protected bool m_RestrictHumanToSpecificSeat = new bool();
		[ContainerField(145), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3516468286)]
		public bool RestrictHumanToSpecificSeat { get { return m_RestrictHumanToSpecificSeat; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(RestrictHumanToSpecificSeat), this, m_RestrictHumanToSpecificSeat, value)) m_RestrictHumanToSpecificSeat = value; } } // 0x91 (145)
		
		protected bool m_ShouldDestroyVehicles = new bool();
		[ContainerField(146), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2908980741)]
		public bool ShouldDestroyVehicles { get { return m_ShouldDestroyVehicles; } set { if (OnPropertyChanging("VehicleStateTriggerEntityData." + nameof(ShouldDestroyVehicles), this, m_ShouldDestroyVehicles, value)) m_ShouldDestroyVehicles = value; } } // 0x92 (146)
		
		protected bool m_ShouldDestroyBangers = new bool();
		[ContainerField(147), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(565605152)]
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
