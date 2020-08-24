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
	public class VehicleSpawnReferenceObjectData : 
		SpawnReferenceObjectData
	{
		protected LinearTransform m_AirDropCarrierTransform = new LinearTransform();
		[ContainerField(384), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1315516038)]
		public LinearTransform AirDropCarrierTransform { get { return m_AirDropCarrierTransform; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(AirDropCarrierTransform), this, m_AirDropCarrierTransform, value)) m_AirDropCarrierTransform = value; } } // 0x180 (384)
		
		protected float m_TimeUntilAbandoned = new float();
		[ContainerField(448), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(590788402)]
		public float TimeUntilAbandoned { get { return m_TimeUntilAbandoned; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(TimeUntilAbandoned), this, m_TimeUntilAbandoned, value)) m_TimeUntilAbandoned = value; } } // 0x1C0 (448)
		
		protected float m_TimeUntilAbandonedIsDestroyed = new float();
		[ContainerField(452), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1439912203)]
		public float TimeUntilAbandonedIsDestroyed { get { return m_TimeUntilAbandonedIsDestroyed; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(TimeUntilAbandonedIsDestroyed), this, m_TimeUntilAbandonedIsDestroyed, value)) m_TimeUntilAbandonedIsDestroyed = value; } } // 0x1C4 (452)
		
		protected EntryEnterRestriction m_EnterRestriction = new EntryEnterRestriction();
		[ContainerField(456), MemberInfoFlag(137), ContainerFieldNameHash(1187365209)]
		public EntryEnterRestriction EnterRestriction { get { return m_EnterRestriction; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(EnterRestriction), this, m_EnterRestriction, value)) m_EnterRestriction = value; } } // 0x1C8 (456)
		
		protected float m_BotBailWhenHealthBelow = new float();
		[ContainerField(460), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2439578209)]
		public float BotBailWhenHealthBelow { get { return m_BotBailWhenHealthBelow; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(BotBailWhenHealthBelow), this, m_BotBailWhenHealthBelow, value)) m_BotBailWhenHealthBelow = value; } } // 0x1CC (460)
		
		protected float m_BotBailOutDelay = new float();
		[ContainerField(464), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2997620897)]
		public float BotBailOutDelay { get { return m_BotBailOutDelay; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(BotBailOutDelay), this, m_BotBailOutDelay, value)) m_BotBailOutDelay = value; } } // 0x1D0 (464)
		
		protected float m_WreckDuration = new float();
		[ContainerField(468), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3721892947)]
		public float WreckDuration { get { return m_WreckDuration; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(WreckDuration), this, m_WreckDuration, value)) m_WreckDuration = value; } } // 0x1D4 (468)
		
		protected float m_RespawnRange = new float();
		[ContainerField(472), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(696491990)]
		public float RespawnRange { get { return m_RespawnRange; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(RespawnRange), this, m_RespawnRange, value)) m_RespawnRange = value; } } // 0x1D8 (472)
		
		protected int m_ActiveStanceEntryIndex = new int();
		[ContainerField(476), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1513018797)]
		public int ActiveStanceEntryIndex { get { return m_ActiveStanceEntryIndex; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(ActiveStanceEntryIndex), this, m_ActiveStanceEntryIndex, value)) m_ActiveStanceEntryIndex = value; } } // 0x1DC (476)
		
		protected int m_ActiveStance = new int();
		[ContainerField(480), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3998105031)]
		public int ActiveStance { get { return m_ActiveStance; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(ActiveStance), this, m_ActiveStance, value)) m_ActiveStance = value; } } // 0x1E0 (480)
		
		protected float m_KeepAliveRadius = new float();
		[ContainerField(484), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3493637041)]
		public float KeepAliveRadius { get { return m_KeepAliveRadius; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(KeepAliveRadius), this, m_KeepAliveRadius, value)) m_KeepAliveRadius = value; } } // 0x1E4 (484)
		
		protected float m_VehicleIsNearDistance = new float();
		[ContainerField(488), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3573981180)]
		public float VehicleIsNearDistance { get { return m_VehicleIsNearDistance; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(VehicleIsNearDistance), this, m_VehicleIsNearDistance, value)) m_VehicleIsNearDistance = value; } } // 0x1E8 (488)
		
		protected bool m_SetTeamOnSpawn = new bool();
		[ContainerField(492), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1290825280)]
		public bool SetTeamOnSpawn { get { return m_SetTeamOnSpawn; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(SetTeamOnSpawn), this, m_SetTeamOnSpawn, value)) m_SetTeamOnSpawn = value; } } // 0x1EC (492)
		
		protected bool m_ApplyDamageToAbandonedVehicles = new bool();
		[ContainerField(493), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3721191714)]
		public bool ApplyDamageToAbandonedVehicles { get { return m_ApplyDamageToAbandonedVehicles; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(ApplyDamageToAbandonedVehicles), this, m_ApplyDamageToAbandonedVehicles, value)) m_ApplyDamageToAbandonedVehicles = value; } } // 0x1ED (493)
		
		protected bool m_EnableAvailableSeatOutput = new bool();
		[ContainerField(494), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(154114977)]
		public bool EnableAvailableSeatOutput { get { return m_EnableAvailableSeatOutput; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(EnableAvailableSeatOutput), this, m_EnableAvailableSeatOutput, value)) m_EnableAvailableSeatOutput = value; } } // 0x1EE (494)
		
		protected bool m_DisregardSpawnAllowedSetting = new bool();
		[ContainerField(495), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3707783529)]
		public bool DisregardSpawnAllowedSetting { get { return m_DisregardSpawnAllowedSetting; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(DisregardSpawnAllowedSetting), this, m_DisregardSpawnAllowedSetting, value)) m_DisregardSpawnAllowedSetting = value; } } // 0x1EF (495)
		
		protected bool m_AffectedByImpulse = new bool();
		[ContainerField(496), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3802426327)]
		public bool AffectedByImpulse { get { return m_AffectedByImpulse; } set { if (OnPropertyChanging("VehicleSpawnReferenceObjectData." + nameof(AffectedByImpulse), this, m_AffectedByImpulse, value)) m_AffectedByImpulse = value; } } // 0x1F0 (496)
		
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
