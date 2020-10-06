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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(160), ContainerClass]
	public class InputRestrictionEntityData : 
		GameEntityData
	{
		protected bool m_ApplyRestrictionsToSpecificPlayer = new bool();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3694371998)]
		public bool ApplyRestrictionsToSpecificPlayer { get { return m_ApplyRestrictionsToSpecificPlayer; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(ApplyRestrictionsToSpecificPlayer), this, m_ApplyRestrictionsToSpecificPlayer, value)) m_ApplyRestrictionsToSpecificPlayer = value; } } // 0x60 (96)
		
		protected bool m_Throttle = new bool();
		[ContainerField(97), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2709773613)]
		public bool Throttle { get { return m_Throttle; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Throttle), this, m_Throttle, value)) m_Throttle = value; } } // 0x61 (97)
		
		protected bool m_Strafe = new bool();
		[ContainerField(98), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3320105042)]
		public bool Strafe { get { return m_Strafe; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Strafe), this, m_Strafe, value)) m_Strafe = value; } } // 0x62 (98)
		
		protected bool m_Brake = new bool();
		[ContainerField(99), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(211741658)]
		public bool Brake { get { return m_Brake; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Brake), this, m_Brake, value)) m_Brake = value; } } // 0x63 (99)
		
		protected bool m_HandBrake = new bool();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1007643609)]
		public bool HandBrake { get { return m_HandBrake; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(HandBrake), this, m_HandBrake, value)) m_HandBrake = value; } } // 0x64 (100)
		
		protected bool m_Clutch = new bool();
		[ContainerField(101), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2722700928)]
		public bool Clutch { get { return m_Clutch; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Clutch), this, m_Clutch, value)) m_Clutch = value; } } // 0x65 (101)
		
		protected bool m_Yaw = new bool();
		[ContainerField(102), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(193468618)]
		public bool Yaw { get { return m_Yaw; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Yaw), this, m_Yaw, value)) m_Yaw = value; } } // 0x66 (102)
		
		protected bool m_Pitch = new bool();
		[ContainerField(103), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(232604323)]
		public bool Pitch { get { return m_Pitch; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Pitch), this, m_Pitch, value)) m_Pitch = value; } } // 0x67 (103)
		
		protected bool m_Roll = new bool();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2089387576)]
		public bool Roll { get { return m_Roll; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Roll), this, m_Roll, value)) m_Roll = value; } } // 0x68 (104)
		
		protected bool m_Fire = new bool();
		[ContainerField(105), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2088671869)]
		public bool Fire { get { return m_Fire; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Fire), this, m_Fire, value)) m_Fire = value; } } // 0x69 (105)
		
		protected bool m_FireCountermeasure = new bool();
		[ContainerField(106), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1324003345)]
		public bool FireCountermeasure { get { return m_FireCountermeasure; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(FireCountermeasure), this, m_FireCountermeasure, value)) m_FireCountermeasure = value; } } // 0x6A (106)
		
		protected bool m_AltFire = new bool();
		[ContainerField(107), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(650582980)]
		public bool AltFire { get { return m_AltFire; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(AltFire), this, m_AltFire, value)) m_AltFire = value; } } // 0x6B (107)
		
		protected bool m_CycleRadioChannel = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(47933063)]
		public bool CycleRadioChannel { get { return m_CycleRadioChannel; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(CycleRadioChannel), this, m_CycleRadioChannel, value)) m_CycleRadioChannel = value; } } // 0x6C (108)
		
		protected bool m_SelectMeleeWeapon = new bool();
		[ContainerField(109), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(343680843)]
		public bool SelectMeleeWeapon { get { return m_SelectMeleeWeapon; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SelectMeleeWeapon), this, m_SelectMeleeWeapon, value)) m_SelectMeleeWeapon = value; } } // 0x6D (109)
		
		protected bool m_Zoom = new bool();
		[ContainerField(110), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2089658322)]
		public bool Zoom { get { return m_Zoom; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Zoom), this, m_Zoom, value)) m_Zoom = value; } } // 0x6E (110)
		
		protected bool m_Jump = new bool();
		[ContainerField(111), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2089106695)]
		public bool Jump { get { return m_Jump; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Jump), this, m_Jump, value)) m_Jump = value; } } // 0x6F (111)
		
		protected bool m_ChangeVehicle = new bool();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(960547387)]
		public bool ChangeVehicle { get { return m_ChangeVehicle; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(ChangeVehicle), this, m_ChangeVehicle, value)) m_ChangeVehicle = value; } } // 0x70 (112)
		
		protected bool m_ChangeEntry = new bool();
		[ContainerField(113), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(253258167)]
		public bool ChangeEntry { get { return m_ChangeEntry; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(ChangeEntry), this, m_ChangeEntry, value)) m_ChangeEntry = value; } } // 0x71 (113)
		
		protected bool m_ChangePose = new bool();
		[ContainerField(114), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3652565642)]
		public bool ChangePose { get { return m_ChangePose; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(ChangePose), this, m_ChangePose, value)) m_ChangePose = value; } } // 0x72 (114)
		
		protected bool m_ToggleParachute = new bool();
		[ContainerField(115), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3109359034)]
		public bool ToggleParachute { get { return m_ToggleParachute; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(ToggleParachute), this, m_ToggleParachute, value)) m_ToggleParachute = value; } } // 0x73 (115)
		
		protected bool m_ChangeWeapon = new bool();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(453899009)]
		public bool ChangeWeapon { get { return m_ChangeWeapon; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(ChangeWeapon), this, m_ChangeWeapon, value)) m_ChangeWeapon = value; } } // 0x74 (116)
		
		protected bool m_Reload = new bool();
		[ContainerField(117), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3294210644)]
		public bool Reload { get { return m_Reload; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Reload), this, m_Reload, value)) m_Reload = value; } } // 0x75 (117)
		
		protected bool m_ToggleCamera = new bool();
		[ContainerField(118), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(466804014)]
		public bool ToggleCamera { get { return m_ToggleCamera; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(ToggleCamera), this, m_ToggleCamera, value)) m_ToggleCamera = value; } } // 0x76 (118)
		
		protected bool m_Sprint = new bool();
		[ContainerField(119), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3324856903)]
		public bool Sprint { get { return m_Sprint; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Sprint), this, m_Sprint, value)) m_Sprint = value; } } // 0x77 (119)
		
		protected bool m_ScoreboardMenu = new bool();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2278540708)]
		public bool ScoreboardMenu { get { return m_ScoreboardMenu; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(ScoreboardMenu), this, m_ScoreboardMenu, value)) m_ScoreboardMenu = value; } } // 0x78 (120)
		
		protected bool m_MapZoom = new bool();
		[ContainerField(121), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1322946702)]
		public bool MapZoom { get { return m_MapZoom; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(MapZoom), this, m_MapZoom, value)) m_MapZoom = value; } } // 0x79 (121)
		
		protected bool m_GearUp = new bool();
		[ContainerField(122), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2564425393)]
		public bool GearUp { get { return m_GearUp; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(GearUp), this, m_GearUp, value)) m_GearUp = value; } } // 0x7A (122)
		
		protected bool m_GearDown = new bool();
		[ContainerField(123), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(931118502)]
		public bool GearDown { get { return m_GearDown; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(GearDown), this, m_GearDown, value)) m_GearDown = value; } } // 0x7B (123)
		
		protected bool m_ThreeDimensionalMap = new bool();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(514584298)]
		public bool ThreeDimensionalMap { get { return m_ThreeDimensionalMap; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(ThreeDimensionalMap), this, m_ThreeDimensionalMap, value)) m_ThreeDimensionalMap = value; } } // 0x7C (124)
		
		protected bool m_GiveOrder = new bool();
		[ContainerField(125), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2886694454)]
		public bool GiveOrder { get { return m_GiveOrder; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(GiveOrder), this, m_GiveOrder, value)) m_GiveOrder = value; } } // 0x7D (125)
		
		protected bool m_Prone = new bool();
		[ContainerField(126), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(231940067)]
		public bool Prone { get { return m_Prone; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(Prone), this, m_Prone, value)) m_Prone = value; } } // 0x7E (126)
		
		protected bool m_SwitchPrimaryInventory = new bool();
		[ContainerField(127), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(638758289)]
		public bool SwitchPrimaryInventory { get { return m_SwitchPrimaryInventory; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SwitchPrimaryInventory), this, m_SwitchPrimaryInventory, value)) m_SwitchPrimaryInventory = value; } } // 0x7F (127)
		
		protected bool m_SwitchPrimaryWeapon = new bool();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1158994585)]
		public bool SwitchPrimaryWeapon { get { return m_SwitchPrimaryWeapon; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SwitchPrimaryWeapon), this, m_SwitchPrimaryWeapon, value)) m_SwitchPrimaryWeapon = value; } } // 0x80 (128)
		
		protected bool m_GrenadeLauncher = new bool();
		[ContainerField(129), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3548319793)]
		public bool GrenadeLauncher { get { return m_GrenadeLauncher; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(GrenadeLauncher), this, m_GrenadeLauncher, value)) m_GrenadeLauncher = value; } } // 0x81 (129)
		
		protected bool m_StaticGadget = new bool();
		[ContainerField(130), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3854347497)]
		public bool StaticGadget { get { return m_StaticGadget; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(StaticGadget), this, m_StaticGadget, value)) m_StaticGadget = value; } } // 0x82 (130)
		
		protected bool m_DynamicGadget1 = new bool();
		[ContainerField(131), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2620754581)]
		public bool DynamicGadget1 { get { return m_DynamicGadget1; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(DynamicGadget1), this, m_DynamicGadget1, value)) m_DynamicGadget1 = value; } } // 0x83 (131)
		
		protected bool m_DynamicGadget2 = new bool();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2620754582)]
		public bool DynamicGadget2 { get { return m_DynamicGadget2; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(DynamicGadget2), this, m_DynamicGadget2, value)) m_DynamicGadget2 = value; } } // 0x84 (132)
		
		protected bool m_MeleeAttack = new bool();
		[ContainerField(133), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(834934665)]
		public bool MeleeAttack { get { return m_MeleeAttack; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(MeleeAttack), this, m_MeleeAttack, value)) m_MeleeAttack = value; } } // 0x85 (133)
		
		protected bool m_ThrowGrenade = new bool();
		[ContainerField(134), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2210644077)]
		public bool ThrowGrenade { get { return m_ThrowGrenade; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(ThrowGrenade), this, m_ThrowGrenade, value)) m_ThrowGrenade = value; } } // 0x86 (134)
		
		protected bool m_SelectWeapon1 = new bool();
		[ContainerField(135), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1052582590)]
		public bool SelectWeapon1 { get { return m_SelectWeapon1; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SelectWeapon1), this, m_SelectWeapon1, value)) m_SelectWeapon1 = value; } } // 0x87 (135)
		
		protected bool m_SelectWeapon2 = new bool();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1052582589)]
		public bool SelectWeapon2 { get { return m_SelectWeapon2; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SelectWeapon2), this, m_SelectWeapon2, value)) m_SelectWeapon2 = value; } } // 0x88 (136)
		
		protected bool m_SelectWeapon3 = new bool();
		[ContainerField(137), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1052582588)]
		public bool SelectWeapon3 { get { return m_SelectWeapon3; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SelectWeapon3), this, m_SelectWeapon3, value)) m_SelectWeapon3 = value; } } // 0x89 (137)
		
		protected bool m_SelectWeapon4 = new bool();
		[ContainerField(138), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1052582587)]
		public bool SelectWeapon4 { get { return m_SelectWeapon4; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SelectWeapon4), this, m_SelectWeapon4, value)) m_SelectWeapon4 = value; } } // 0x8A (138)
		
		protected bool m_SelectWeapon5 = new bool();
		[ContainerField(139), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1052582586)]
		public bool SelectWeapon5 { get { return m_SelectWeapon5; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SelectWeapon5), this, m_SelectWeapon5, value)) m_SelectWeapon5 = value; } } // 0x8B (139)
		
		protected bool m_SelectWeapon6 = new bool();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1052582585)]
		public bool SelectWeapon6 { get { return m_SelectWeapon6; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SelectWeapon6), this, m_SelectWeapon6, value)) m_SelectWeapon6 = value; } } // 0x8C (140)
		
		protected bool m_SelectWeapon7 = new bool();
		[ContainerField(141), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1052582584)]
		public bool SelectWeapon7 { get { return m_SelectWeapon7; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SelectWeapon7), this, m_SelectWeapon7, value)) m_SelectWeapon7 = value; } } // 0x8D (141)
		
		protected bool m_SelectWeapon8 = new bool();
		[ContainerField(142), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1052582583)]
		public bool SelectWeapon8 { get { return m_SelectWeapon8; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SelectWeapon8), this, m_SelectWeapon8, value)) m_SelectWeapon8 = value; } } // 0x8E (142)
		
		protected bool m_SelectWeapon9 = new bool();
		[ContainerField(143), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1052582582)]
		public bool SelectWeapon9 { get { return m_SelectWeapon9; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(SelectWeapon9), this, m_SelectWeapon9, value)) m_SelectWeapon9 = value; } } // 0x8F (143)
		
		protected bool m_OverridePreviousInputRestriction = new bool();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2082064290)]
		public bool OverridePreviousInputRestriction { get { return m_OverridePreviousInputRestriction; } set { if (OnPropertyChanging("InputRestrictionEntityData." + nameof(OverridePreviousInputRestriction), this, m_OverridePreviousInputRestriction, value)) m_OverridePreviousInputRestriction = value; } } // 0x90 (144)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3694371998:
					ApplyRestrictionsToSpecificPlayer = (bool) p_Value;
					break;

				case 2709773613:
					Throttle = (bool) p_Value;
					break;

				case 3320105042:
					Strafe = (bool) p_Value;
					break;

				case 211741658:
					Brake = (bool) p_Value;
					break;

				case 1007643609:
					HandBrake = (bool) p_Value;
					break;

				case 2722700928:
					Clutch = (bool) p_Value;
					break;

				case 193468618:
					Yaw = (bool) p_Value;
					break;

				case 232604323:
					Pitch = (bool) p_Value;
					break;

				case 2089387576:
					Roll = (bool) p_Value;
					break;

				case 2088671869:
					Fire = (bool) p_Value;
					break;

				case 1324003345:
					FireCountermeasure = (bool) p_Value;
					break;

				case 650582980:
					AltFire = (bool) p_Value;
					break;

				case 47933063:
					CycleRadioChannel = (bool) p_Value;
					break;

				case 343680843:
					SelectMeleeWeapon = (bool) p_Value;
					break;

				case 2089658322:
					Zoom = (bool) p_Value;
					break;

				case 2089106695:
					Jump = (bool) p_Value;
					break;

				case 960547387:
					ChangeVehicle = (bool) p_Value;
					break;

				case 253258167:
					ChangeEntry = (bool) p_Value;
					break;

				case 3652565642:
					ChangePose = (bool) p_Value;
					break;

				case 3109359034:
					ToggleParachute = (bool) p_Value;
					break;

				case 453899009:
					ChangeWeapon = (bool) p_Value;
					break;

				case 3294210644:
					Reload = (bool) p_Value;
					break;

				case 466804014:
					ToggleCamera = (bool) p_Value;
					break;

				case 3324856903:
					Sprint = (bool) p_Value;
					break;

				case 2278540708:
					ScoreboardMenu = (bool) p_Value;
					break;

				case 1322946702:
					MapZoom = (bool) p_Value;
					break;

				case 2564425393:
					GearUp = (bool) p_Value;
					break;

				case 931118502:
					GearDown = (bool) p_Value;
					break;

				case 514584298:
					ThreeDimensionalMap = (bool) p_Value;
					break;

				case 2886694454:
					GiveOrder = (bool) p_Value;
					break;

				case 231940067:
					Prone = (bool) p_Value;
					break;

				case 638758289:
					SwitchPrimaryInventory = (bool) p_Value;
					break;

				case 1158994585:
					SwitchPrimaryWeapon = (bool) p_Value;
					break;

				case 3548319793:
					GrenadeLauncher = (bool) p_Value;
					break;

				case 3854347497:
					StaticGadget = (bool) p_Value;
					break;

				case 2620754581:
					DynamicGadget1 = (bool) p_Value;
					break;

				case 2620754582:
					DynamicGadget2 = (bool) p_Value;
					break;

				case 834934665:
					MeleeAttack = (bool) p_Value;
					break;

				case 2210644077:
					ThrowGrenade = (bool) p_Value;
					break;

				case 1052582590:
					SelectWeapon1 = (bool) p_Value;
					break;

				case 1052582589:
					SelectWeapon2 = (bool) p_Value;
					break;

				case 1052582588:
					SelectWeapon3 = (bool) p_Value;
					break;

				case 1052582587:
					SelectWeapon4 = (bool) p_Value;
					break;

				case 1052582586:
					SelectWeapon5 = (bool) p_Value;
					break;

				case 1052582585:
					SelectWeapon6 = (bool) p_Value;
					break;

				case 1052582584:
					SelectWeapon7 = (bool) p_Value;
					break;

				case 1052582583:
					SelectWeapon8 = (bool) p_Value;
					break;

				case 1052582582:
					SelectWeapon9 = (bool) p_Value;
					break;

				case 2082064290:
					OverridePreviousInputRestriction = (bool) p_Value;
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
				case 3694371998:
					return ApplyRestrictionsToSpecificPlayer;

				case 2709773613:
					return Throttle;

				case 3320105042:
					return Strafe;

				case 211741658:
					return Brake;

				case 1007643609:
					return HandBrake;

				case 2722700928:
					return Clutch;

				case 193468618:
					return Yaw;

				case 232604323:
					return Pitch;

				case 2089387576:
					return Roll;

				case 2088671869:
					return Fire;

				case 1324003345:
					return FireCountermeasure;

				case 650582980:
					return AltFire;

				case 47933063:
					return CycleRadioChannel;

				case 343680843:
					return SelectMeleeWeapon;

				case 2089658322:
					return Zoom;

				case 2089106695:
					return Jump;

				case 960547387:
					return ChangeVehicle;

				case 253258167:
					return ChangeEntry;

				case 3652565642:
					return ChangePose;

				case 3109359034:
					return ToggleParachute;

				case 453899009:
					return ChangeWeapon;

				case 3294210644:
					return Reload;

				case 466804014:
					return ToggleCamera;

				case 3324856903:
					return Sprint;

				case 2278540708:
					return ScoreboardMenu;

				case 1322946702:
					return MapZoom;

				case 2564425393:
					return GearUp;

				case 931118502:
					return GearDown;

				case 514584298:
					return ThreeDimensionalMap;

				case 2886694454:
					return GiveOrder;

				case 231940067:
					return Prone;

				case 638758289:
					return SwitchPrimaryInventory;

				case 1158994585:
					return SwitchPrimaryWeapon;

				case 3548319793:
					return GrenadeLauncher;

				case 3854347497:
					return StaticGadget;

				case 2620754581:
					return DynamicGadget1;

				case 2620754582:
					return DynamicGadget2;

				case 834934665:
					return MeleeAttack;

				case 2210644077:
					return ThrowGrenade;

				case 1052582590:
					return SelectWeapon1;

				case 1052582589:
					return SelectWeapon2;

				case 1052582588:
					return SelectWeapon3;

				case 1052582587:
					return SelectWeapon4;

				case 1052582586:
					return SelectWeapon5;

				case 1052582585:
					return SelectWeapon6;

				case 1052582584:
					return SelectWeapon7;

				case 1052582583:
					return SelectWeapon8;

				case 1052582582:
					return SelectWeapon9;

				case 2082064290:
					return OverridePreviousInputRestriction;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3694371998:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(ApplyRestrictionsToSpecificPlayer));

				case 2709773613:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Throttle));

				case 3320105042:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Strafe));

				case 211741658:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Brake));

				case 1007643609:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(HandBrake));

				case 2722700928:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Clutch));

				case 193468618:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Yaw));

				case 232604323:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Pitch));

				case 2089387576:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Roll));

				case 2088671869:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Fire));

				case 1324003345:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(FireCountermeasure));

				case 650582980:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(AltFire));

				case 47933063:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(CycleRadioChannel));

				case 343680843:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SelectMeleeWeapon));

				case 2089658322:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Zoom));

				case 2089106695:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Jump));

				case 960547387:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(ChangeVehicle));

				case 253258167:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(ChangeEntry));

				case 3652565642:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(ChangePose));

				case 3109359034:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(ToggleParachute));

				case 453899009:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(ChangeWeapon));

				case 3294210644:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Reload));

				case 466804014:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(ToggleCamera));

				case 3324856903:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Sprint));

				case 2278540708:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(ScoreboardMenu));

				case 1322946702:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(MapZoom));

				case 2564425393:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(GearUp));

				case 931118502:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(GearDown));

				case 514584298:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(ThreeDimensionalMap));

				case 2886694454:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(GiveOrder));

				case 231940067:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(Prone));

				case 638758289:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SwitchPrimaryInventory));

				case 1158994585:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SwitchPrimaryWeapon));

				case 3548319793:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(GrenadeLauncher));

				case 3854347497:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(StaticGadget));

				case 2620754581:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(DynamicGadget1));

				case 2620754582:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(DynamicGadget2));

				case 834934665:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(MeleeAttack));

				case 2210644077:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(ThrowGrenade));

				case 1052582590:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SelectWeapon1));

				case 1052582589:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SelectWeapon2));

				case 1052582588:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SelectWeapon3));

				case 1052582587:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SelectWeapon4));

				case 1052582586:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SelectWeapon5));

				case 1052582585:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SelectWeapon6));

				case 1052582584:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SelectWeapon7));

				case 1052582583:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SelectWeapon8));

				case 1052582582:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(SelectWeapon9));

				case 2082064290:
					return typeof(InputRestrictionEntityData).GetProperty(nameof(OverridePreviousInputRestriction));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
