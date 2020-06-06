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
	public class InputRestrictionEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool ApplyRestrictionsToSpecificPlayer { get; set; } // 0x60 (96)
		
		[ContainerField(97), LayoutImmutable, Blittable]
		public bool Throttle { get; set; } // 0x61 (97)
		
		[ContainerField(98), LayoutImmutable, Blittable]
		public bool Strafe { get; set; } // 0x62 (98)
		
		[ContainerField(99), LayoutImmutable, Blittable]
		public bool Brake { get; set; } // 0x63 (99)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool HandBrake { get; set; } // 0x64 (100)
		
		[ContainerField(101), LayoutImmutable, Blittable]
		public bool Clutch { get; set; } // 0x65 (101)
		
		[ContainerField(102), LayoutImmutable, Blittable]
		public bool Yaw { get; set; } // 0x66 (102)
		
		[ContainerField(103), LayoutImmutable, Blittable]
		public bool Pitch { get; set; } // 0x67 (103)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool Roll { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool Fire { get; set; } // 0x69 (105)
		
		[ContainerField(106), LayoutImmutable, Blittable]
		public bool FireCountermeasure { get; set; } // 0x6A (106)
		
		[ContainerField(107), LayoutImmutable, Blittable]
		public bool AltFire { get; set; } // 0x6B (107)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool CycleRadioChannel { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool SelectMeleeWeapon { get; set; } // 0x6D (109)
		
		[ContainerField(110), LayoutImmutable, Blittable]
		public bool Zoom { get; set; } // 0x6E (110)
		
		[ContainerField(111), LayoutImmutable, Blittable]
		public bool Jump { get; set; } // 0x6F (111)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public bool ChangeVehicle { get; set; } // 0x70 (112)
		
		[ContainerField(113), LayoutImmutable, Blittable]
		public bool ChangeEntry { get; set; } // 0x71 (113)
		
		[ContainerField(114), LayoutImmutable, Blittable]
		public bool ChangePose { get; set; } // 0x72 (114)
		
		[ContainerField(115), LayoutImmutable, Blittable]
		public bool ToggleParachute { get; set; } // 0x73 (115)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool ChangeWeapon { get; set; } // 0x74 (116)
		
		[ContainerField(117), LayoutImmutable, Blittable]
		public bool Reload { get; set; } // 0x75 (117)
		
		[ContainerField(118), LayoutImmutable, Blittable]
		public bool ToggleCamera { get; set; } // 0x76 (118)
		
		[ContainerField(119), LayoutImmutable, Blittable]
		public bool Sprint { get; set; } // 0x77 (119)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public bool ScoreboardMenu { get; set; } // 0x78 (120)
		
		[ContainerField(121), LayoutImmutable, Blittable]
		public bool MapZoom { get; set; } // 0x79 (121)
		
		[ContainerField(122), LayoutImmutable, Blittable]
		public bool GearUp { get; set; } // 0x7A (122)
		
		[ContainerField(123), LayoutImmutable, Blittable]
		public bool GearDown { get; set; } // 0x7B (123)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool ThreeDimensionalMap { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool GiveOrder { get; set; } // 0x7D (125)
		
		[ContainerField(126), LayoutImmutable, Blittable]
		public bool Prone { get; set; } // 0x7E (126)
		
		[ContainerField(127), LayoutImmutable, Blittable]
		public bool SwitchPrimaryInventory { get; set; } // 0x7F (127)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool SwitchPrimaryWeapon { get; set; } // 0x80 (128)
		
		[ContainerField(129), LayoutImmutable, Blittable]
		public bool GrenadeLauncher { get; set; } // 0x81 (129)
		
		[ContainerField(130), LayoutImmutable, Blittable]
		public bool StaticGadget { get; set; } // 0x82 (130)
		
		[ContainerField(131), LayoutImmutable, Blittable]
		public bool DynamicGadget1 { get; set; } // 0x83 (131)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public bool DynamicGadget2 { get; set; } // 0x84 (132)
		
		[ContainerField(133), LayoutImmutable, Blittable]
		public bool MeleeAttack { get; set; } // 0x85 (133)
		
		[ContainerField(134), LayoutImmutable, Blittable]
		public bool ThrowGrenade { get; set; } // 0x86 (134)
		
		[ContainerField(135), LayoutImmutable, Blittable]
		public bool SelectWeapon1 { get; set; } // 0x87 (135)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public bool SelectWeapon2 { get; set; } // 0x88 (136)
		
		[ContainerField(137), LayoutImmutable, Blittable]
		public bool SelectWeapon3 { get; set; } // 0x89 (137)
		
		[ContainerField(138), LayoutImmutable, Blittable]
		public bool SelectWeapon4 { get; set; } // 0x8A (138)
		
		[ContainerField(139), LayoutImmutable, Blittable]
		public bool SelectWeapon5 { get; set; } // 0x8B (139)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool SelectWeapon6 { get; set; } // 0x8C (140)
		
		[ContainerField(141), LayoutImmutable, Blittable]
		public bool SelectWeapon7 { get; set; } // 0x8D (141)
		
		[ContainerField(142), LayoutImmutable, Blittable]
		public bool SelectWeapon8 { get; set; } // 0x8E (142)
		
		[ContainerField(143), LayoutImmutable, Blittable]
		public bool SelectWeapon9 { get; set; } // 0x8F (143)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool OverridePreviousInputRestriction { get; set; } // 0x90 (144)
		
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
