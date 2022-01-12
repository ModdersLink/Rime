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
	[ContainerType(16, 160)]
	public class InputRestrictionEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool ApplyRestrictionsToSpecificPlayer { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool Throttle { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable]
		public bool Strafe { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable]
		public bool Brake { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool HandBrake { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable]
		public bool Clutch { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable]
		public bool Yaw { get; set; }

		[ContainerField(103), LayoutImmutable, Blittable]
		public bool Pitch { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool Roll { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool Fire { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable]
		public bool FireCountermeasure { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable]
		public bool AltFire { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool CycleRadioChannel { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool SelectMeleeWeapon { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable]
		public bool Zoom { get; set; }

		[ContainerField(111), LayoutImmutable, Blittable]
		public bool Jump { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public bool ChangeVehicle { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable]
		public bool ChangeEntry { get; set; }

		[ContainerField(114), LayoutImmutable, Blittable]
		public bool ChangePose { get; set; }

		[ContainerField(115), LayoutImmutable, Blittable]
		public bool ToggleParachute { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool ChangeWeapon { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable]
		public bool Reload { get; set; }

		[ContainerField(118), LayoutImmutable, Blittable]
		public bool ToggleCamera { get; set; }

		[ContainerField(119), LayoutImmutable, Blittable]
		public bool Sprint { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public bool ScoreboardMenu { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable]
		public bool MapZoom { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable]
		public bool GearUp { get; set; }

		[ContainerField(123), LayoutImmutable, Blittable]
		public bool GearDown { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool ThreeDimensionalMap { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool GiveOrder { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable]
		public bool Prone { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable]
		public bool SwitchPrimaryInventory { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool SwitchPrimaryWeapon { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable]
		public bool GrenadeLauncher { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable]
		public bool StaticGadget { get; set; }

		[ContainerField(131), LayoutImmutable, Blittable]
		public bool DynamicGadget1 { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool DynamicGadget2 { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable]
		public bool MeleeAttack { get; set; }

		[ContainerField(134), LayoutImmutable, Blittable]
		public bool ThrowGrenade { get; set; }

		[ContainerField(135), LayoutImmutable, Blittable]
		public bool SelectWeapon1 { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool SelectWeapon2 { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool SelectWeapon3 { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable]
		public bool SelectWeapon4 { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable]
		public bool SelectWeapon5 { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool SelectWeapon6 { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable]
		public bool SelectWeapon7 { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable]
		public bool SelectWeapon8 { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable]
		public bool SelectWeapon9 { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool OverridePreviousInputRestriction { get; set; }

	}
}
