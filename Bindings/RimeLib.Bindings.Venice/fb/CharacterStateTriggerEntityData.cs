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
	public class CharacterStateTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public uint ActiveWeaponSlot { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float Pitch { get; set; } // 0x74 (116)
		
		[ContainerField(120)]
		public CharacterPoseAction CharacterPose { get; set; } = new CharacterPoseAction(); // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public uint AmmoToSet { get; set; } // 0x7C (124)
		
		[ContainerField(128)]
		public CharacterPoseAction PoseToCheck { get; set; } = new CharacterPoseAction(); // 0x80 (128)
		
		[ContainerField(132)]
		public CtrRef<SoldierWeaponBlueprint> Weapon { get; set; } = new CtrRef<SoldierWeaponBlueprint>(); // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public uint HealthToSet { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public uint HealthToCheck { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public uint SeatIndex { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool ExcludeConnectedVehicles { get; set; } // 0x94 (148)
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool ContinueToCheckIfHoldingWrongWeapon { get; set; } // 0x95 (149)
		
		[ContainerField(150), LayoutImmutable, Blittable]
		public bool StayInVehicleOnMove { get; set; } // 0x96 (150)
		
		[ContainerField(151), LayoutImmutable, Blittable]
		public bool CheckHealthGreaterOrEqual { get; set; } // 0x97 (151)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool CheckAllWeapons { get; set; } // 0x98 (152)
		
		[ContainerField(153), LayoutImmutable, Blittable]
		public bool ShouldCheckSeatIndex { get; set; } // 0x99 (153)
		
		[ContainerField(154), LayoutImmutable, Blittable]
		public bool UseExitPointWhenLeavingVehicle { get; set; } // 0x9A (154)
		
		[ContainerField(155), LayoutImmutable, Blittable]
		public bool DisablePhysicsWhenLeavingVehicle { get; set; } // 0x9B (155)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public bool UsePitch { get; set; } // 0x9C (156)
		
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
