///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 160)]
	public class InputRestrictionEntityData :
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool ApplyRestrictionsToSpecificPlayer { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		public bool Throttle { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		public bool Strafe { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		public bool Brake { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public bool HandBrake { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		public bool Clutch { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		public bool Yaw { get; set; }

		[ContainerField(103), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
		public bool Pitch { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool Roll { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		public bool Fire { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		public bool FireCountermeasure { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
		public bool AltFire { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool CycleRadioChannel { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool SelectMeleeWeapon { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		public bool Zoom { get; set; }

		[ContainerField(111), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
		public bool Jump { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public bool ChangeVehicle { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		public bool ChangeEntry { get; set; }

		[ContainerField(114), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
		public bool ChangePose { get; set; }

		[ContainerField(115), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
		public bool ToggleParachute { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public bool ChangeWeapon { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		public bool Reload { get; set; }

		[ContainerField(118), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
		public bool ToggleCamera { get; set; }

		[ContainerField(119), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
		public bool Sprint { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public bool ScoreboardMenu { get; set; }

		[ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		public bool MapZoom { get; set; }

		[ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		public bool GearUp { get; set; }

		[ContainerField(123), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
		public bool GearDown { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public bool ThreeDimensionalMap { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		public bool GiveOrder { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		public bool Prone { get; set; }

		[ContainerField(127), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
		public bool SwitchPrimaryInventory { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool SwitchPrimaryWeapon { get; set; }

		[ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		public bool GrenadeLauncher { get; set; }

		[ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		public bool StaticGadget { get; set; }

		[ContainerField(131), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
		public bool DynamicGadget1 { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public bool DynamicGadget2 { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		public bool MeleeAttack { get; set; }

		[ContainerField(134), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
		public bool ThrowGrenade { get; set; }

		[ContainerField(135), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
		public bool SelectWeapon1 { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public bool SelectWeapon2 { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		public bool SelectWeapon3 { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		public bool SelectWeapon4 { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
		public bool SelectWeapon5 { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public bool SelectWeapon6 { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		public bool SelectWeapon7 { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		public bool SelectWeapon8 { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		public bool SelectWeapon9 { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public bool OverridePreviousInputRestriction { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ApplyRestrictionsToSpecificPlayer);
			p_Writer.Write(Throttle);
			p_Writer.Write(Strafe);
			p_Writer.Write(Brake);
			p_Writer.Write(HandBrake);
			p_Writer.Write(Clutch);
			p_Writer.Write(Yaw);
			p_Writer.Write(Pitch);
			p_Writer.Write(Roll);
			p_Writer.Write(Fire);
			p_Writer.Write(FireCountermeasure);
			p_Writer.Write(AltFire);
			p_Writer.Write(CycleRadioChannel);
			p_Writer.Write(SelectMeleeWeapon);
			p_Writer.Write(Zoom);
			p_Writer.Write(Jump);
			p_Writer.Write(ChangeVehicle);
			p_Writer.Write(ChangeEntry);
			p_Writer.Write(ChangePose);
			p_Writer.Write(ToggleParachute);
			p_Writer.Write(ChangeWeapon);
			p_Writer.Write(Reload);
			p_Writer.Write(ToggleCamera);
			p_Writer.Write(Sprint);
			p_Writer.Write(ScoreboardMenu);
			p_Writer.Write(MapZoom);
			p_Writer.Write(GearUp);
			p_Writer.Write(GearDown);
			p_Writer.Write(ThreeDimensionalMap);
			p_Writer.Write(GiveOrder);
			p_Writer.Write(Prone);
			p_Writer.Write(SwitchPrimaryInventory);
			p_Writer.Write(SwitchPrimaryWeapon);
			p_Writer.Write(GrenadeLauncher);
			p_Writer.Write(StaticGadget);
			p_Writer.Write(DynamicGadget1);
			p_Writer.Write(DynamicGadget2);
			p_Writer.Write(MeleeAttack);
			p_Writer.Write(ThrowGrenade);
			p_Writer.Write(SelectWeapon1);
			p_Writer.Write(SelectWeapon2);
			p_Writer.Write(SelectWeapon3);
			p_Writer.Write(SelectWeapon4);
			p_Writer.Write(SelectWeapon5);
			p_Writer.Write(SelectWeapon6);
			p_Writer.Write(SelectWeapon7);
			p_Writer.Write(SelectWeapon8);
			p_Writer.Write(SelectWeapon9);
			p_Writer.Write(OverridePreviousInputRestriction);
			p_Writer.WriteNullBytes(15);
		}
	}
}
