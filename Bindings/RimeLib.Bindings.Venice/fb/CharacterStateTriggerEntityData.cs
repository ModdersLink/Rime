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
	public class CharacterStateTriggerEntityData : 
		TriggerEntityData
	{
		protected uint m_ActiveWeaponSlot = new uint();
		[ContainerField(Name: "ActiveWeaponSlot", Offset: 112, NameHash: 504468399, Flags: 49421), LayoutImmutable, Blittable]
		public uint ActiveWeaponSlot { get { return m_ActiveWeaponSlot; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(ActiveWeaponSlot), this, m_ActiveWeaponSlot, value)) m_ActiveWeaponSlot = value; } } // 0x70 (112)
		
		protected float m_Pitch = new float();
		[ContainerField(Name: "Pitch", Offset: 116, NameHash: 232604323, Flags: 49469), LayoutImmutable, Blittable]
		public float Pitch { get { return m_Pitch; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(Pitch), this, m_Pitch, value)) m_Pitch = value; } } // 0x74 (116)
		
		protected CharacterPoseAction m_CharacterPose = new CharacterPoseAction();
		[ContainerField(Name: "CharacterPose", Offset: 120, NameHash: 3077951669, Flags: 137)]
		public CharacterPoseAction CharacterPose { get { return m_CharacterPose; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(CharacterPose), this, m_CharacterPose, value)) m_CharacterPose = value; } } // 0x78 (120)
		
		protected uint m_AmmoToSet = new uint();
		[ContainerField(Name: "AmmoToSet", Offset: 124, NameHash: 2338400178, Flags: 49421), LayoutImmutable, Blittable]
		public uint AmmoToSet { get { return m_AmmoToSet; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(AmmoToSet), this, m_AmmoToSet, value)) m_AmmoToSet = value; } } // 0x7C (124)
		
		protected CharacterPoseAction m_PoseToCheck = new CharacterPoseAction();
		[ContainerField(Name: "PoseToCheck", Offset: 128, NameHash: 3246448817, Flags: 137)]
		public CharacterPoseAction PoseToCheck { get { return m_PoseToCheck; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(PoseToCheck), this, m_PoseToCheck, value)) m_PoseToCheck = value; } } // 0x80 (128)
		
		protected CtrRef<SoldierWeaponBlueprint> m_Weapon = new CtrRef<SoldierWeaponBlueprint>();
		[ContainerField(Name: "Weapon", Offset: 132, NameHash: 3190562823, Flags: 53)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get { return m_Weapon; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(Weapon), this, m_Weapon, value)) m_Weapon = value; } } // 0x84 (132)
		
		protected uint m_HealthToSet = new uint();
		[ContainerField(Name: "HealthToSet", Offset: 136, NameHash: 2415816000, Flags: 49421), LayoutImmutable, Blittable]
		public uint HealthToSet { get { return m_HealthToSet; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(HealthToSet), this, m_HealthToSet, value)) m_HealthToSet = value; } } // 0x88 (136)
		
		protected uint m_HealthToCheck = new uint();
		[ContainerField(Name: "HealthToCheck", Offset: 140, NameHash: 2284800324, Flags: 49421), LayoutImmutable, Blittable]
		public uint HealthToCheck { get { return m_HealthToCheck; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(HealthToCheck), this, m_HealthToCheck, value)) m_HealthToCheck = value; } } // 0x8C (140)
		
		protected uint m_SeatIndex = new uint();
		[ContainerField(Name: "SeatIndex", Offset: 144, NameHash: 2889834840, Flags: 49421), LayoutImmutable, Blittable]
		public uint SeatIndex { get { return m_SeatIndex; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(SeatIndex), this, m_SeatIndex, value)) m_SeatIndex = value; } } // 0x90 (144)
		
		protected bool m_ExcludeConnectedVehicles = new bool();
		[ContainerField(Name: "ExcludeConnectedVehicles", Offset: 148, NameHash: 1088742167, Flags: 49325), LayoutImmutable, Blittable]
		public bool ExcludeConnectedVehicles { get { return m_ExcludeConnectedVehicles; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(ExcludeConnectedVehicles), this, m_ExcludeConnectedVehicles, value)) m_ExcludeConnectedVehicles = value; } } // 0x94 (148)
		
		protected bool m_ContinueToCheckIfHoldingWrongWeapon = new bool();
		[ContainerField(Name: "ContinueToCheckIfHoldingWrongWeapon", Offset: 149, NameHash: 119797112, Flags: 49325), LayoutImmutable, Blittable]
		public bool ContinueToCheckIfHoldingWrongWeapon { get { return m_ContinueToCheckIfHoldingWrongWeapon; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(ContinueToCheckIfHoldingWrongWeapon), this, m_ContinueToCheckIfHoldingWrongWeapon, value)) m_ContinueToCheckIfHoldingWrongWeapon = value; } } // 0x95 (149)
		
		protected bool m_StayInVehicleOnMove = new bool();
		[ContainerField(Name: "StayInVehicleOnMove", Offset: 150, NameHash: 1616420053, Flags: 49325), LayoutImmutable, Blittable]
		public bool StayInVehicleOnMove { get { return m_StayInVehicleOnMove; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(StayInVehicleOnMove), this, m_StayInVehicleOnMove, value)) m_StayInVehicleOnMove = value; } } // 0x96 (150)
		
		protected bool m_CheckHealthGreaterOrEqual = new bool();
		[ContainerField(Name: "CheckHealthGreaterOrEqual", Offset: 151, NameHash: 1235807484, Flags: 49325), LayoutImmutable, Blittable]
		public bool CheckHealthGreaterOrEqual { get { return m_CheckHealthGreaterOrEqual; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(CheckHealthGreaterOrEqual), this, m_CheckHealthGreaterOrEqual, value)) m_CheckHealthGreaterOrEqual = value; } } // 0x97 (151)
		
		protected bool m_CheckAllWeapons = new bool();
		[ContainerField(Name: "CheckAllWeapons", Offset: 152, NameHash: 3517400915, Flags: 49325), LayoutImmutable, Blittable]
		public bool CheckAllWeapons { get { return m_CheckAllWeapons; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(CheckAllWeapons), this, m_CheckAllWeapons, value)) m_CheckAllWeapons = value; } } // 0x98 (152)
		
		protected bool m_ShouldCheckSeatIndex = new bool();
		[ContainerField(Name: "ShouldCheckSeatIndex", Offset: 153, NameHash: 1176546167, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShouldCheckSeatIndex { get { return m_ShouldCheckSeatIndex; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(ShouldCheckSeatIndex), this, m_ShouldCheckSeatIndex, value)) m_ShouldCheckSeatIndex = value; } } // 0x99 (153)
		
		protected bool m_UseExitPointWhenLeavingVehicle = new bool();
		[ContainerField(Name: "UseExitPointWhenLeavingVehicle", Offset: 154, NameHash: 1271662616, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseExitPointWhenLeavingVehicle { get { return m_UseExitPointWhenLeavingVehicle; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(UseExitPointWhenLeavingVehicle), this, m_UseExitPointWhenLeavingVehicle, value)) m_UseExitPointWhenLeavingVehicle = value; } } // 0x9A (154)
		
		protected bool m_DisablePhysicsWhenLeavingVehicle = new bool();
		[ContainerField(Name: "DisablePhysicsWhenLeavingVehicle", Offset: 155, NameHash: 2661841096, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisablePhysicsWhenLeavingVehicle { get { return m_DisablePhysicsWhenLeavingVehicle; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(DisablePhysicsWhenLeavingVehicle), this, m_DisablePhysicsWhenLeavingVehicle, value)) m_DisablePhysicsWhenLeavingVehicle = value; } } // 0x9B (155)
		
		protected bool m_UsePitch = new bool();
		[ContainerField(Name: "UsePitch", Offset: 156, NameHash: 269553984, Flags: 49325), LayoutImmutable, Blittable]
		public bool UsePitch { get { return m_UsePitch; } set { if (OnPropertyChanging("CharacterStateTriggerEntityData." + nameof(UsePitch), this, m_UsePitch, value)) m_UsePitch = value; } } // 0x9C (156)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 504468399:
					ActiveWeaponSlot = (uint) p_Value;
					break;

				case 232604323:
					Pitch = (float) p_Value;
					break;

				case 3077951669:
					CharacterPose = (CharacterPoseAction) Enum.ToObject(typeof(CharacterPoseAction), p_Value);
					break;

				case 2338400178:
					AmmoToSet = (uint) p_Value;
					break;

				case 3246448817:
					PoseToCheck = (CharacterPoseAction) Enum.ToObject(typeof(CharacterPoseAction), p_Value);
					break;

				case 3190562823:
					Weapon = (CtrRef<SoldierWeaponBlueprint>) p_Value;
					break;

				case 2415816000:
					HealthToSet = (uint) p_Value;
					break;

				case 2284800324:
					HealthToCheck = (uint) p_Value;
					break;

				case 2889834840:
					SeatIndex = (uint) p_Value;
					break;

				case 1088742167:
					ExcludeConnectedVehicles = (bool) p_Value;
					break;

				case 119797112:
					ContinueToCheckIfHoldingWrongWeapon = (bool) p_Value;
					break;

				case 1616420053:
					StayInVehicleOnMove = (bool) p_Value;
					break;

				case 1235807484:
					CheckHealthGreaterOrEqual = (bool) p_Value;
					break;

				case 3517400915:
					CheckAllWeapons = (bool) p_Value;
					break;

				case 1176546167:
					ShouldCheckSeatIndex = (bool) p_Value;
					break;

				case 1271662616:
					UseExitPointWhenLeavingVehicle = (bool) p_Value;
					break;

				case 2661841096:
					DisablePhysicsWhenLeavingVehicle = (bool) p_Value;
					break;

				case 269553984:
					UsePitch = (bool) p_Value;
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
				case 504468399:
					return ActiveWeaponSlot;

				case 232604323:
					return Pitch;

				case 3077951669:
					return CharacterPose;

				case 2338400178:
					return AmmoToSet;

				case 3246448817:
					return PoseToCheck;

				case 3190562823:
					return Weapon;

				case 2415816000:
					return HealthToSet;

				case 2284800324:
					return HealthToCheck;

				case 2889834840:
					return SeatIndex;

				case 1088742167:
					return ExcludeConnectedVehicles;

				case 119797112:
					return ContinueToCheckIfHoldingWrongWeapon;

				case 1616420053:
					return StayInVehicleOnMove;

				case 1235807484:
					return CheckHealthGreaterOrEqual;

				case 3517400915:
					return CheckAllWeapons;

				case 1176546167:
					return ShouldCheckSeatIndex;

				case 1271662616:
					return UseExitPointWhenLeavingVehicle;

				case 2661841096:
					return DisablePhysicsWhenLeavingVehicle;

				case 269553984:
					return UsePitch;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 504468399:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(ActiveWeaponSlot));

				case 232604323:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(Pitch));

				case 3077951669:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(CharacterPose));

				case 2338400178:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(AmmoToSet));

				case 3246448817:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(PoseToCheck));

				case 3190562823:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(Weapon));

				case 2415816000:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(HealthToSet));

				case 2284800324:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(HealthToCheck));

				case 2889834840:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(SeatIndex));

				case 1088742167:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(ExcludeConnectedVehicles));

				case 119797112:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(ContinueToCheckIfHoldingWrongWeapon));

				case 1616420053:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(StayInVehicleOnMove));

				case 1235807484:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(CheckHealthGreaterOrEqual));

				case 3517400915:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(CheckAllWeapons));

				case 1176546167:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(ShouldCheckSeatIndex));

				case 1271662616:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(UseExitPointWhenLeavingVehicle));

				case 2661841096:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(DisablePhysicsWhenLeavingVehicle));

				case 269553984:
					return typeof(CharacterStateTriggerEntityData).GetProperty(nameof(UsePitch));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
