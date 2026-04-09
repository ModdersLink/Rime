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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 160)]
	public partial class InputRestrictionEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _ApplyRestrictionsToSpecificPlayer;

		[ObservableProperty]
		[property: ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		private bool _Throttle;

		[ObservableProperty]
		[property: ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		private bool _Strafe;

		[ObservableProperty]
		[property: ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		private bool _Brake;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private bool _HandBrake;

		[ObservableProperty]
		[property: ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		private bool _Clutch;

		[ObservableProperty]
		[property: ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		private bool _Yaw;

		[ObservableProperty]
		[property: ContainerField(103), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
		private bool _Pitch;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private bool _Roll;

		[ObservableProperty]
		[property: ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		private bool _Fire;

		[ObservableProperty]
		[property: ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		private bool _FireCountermeasure;

		[ObservableProperty]
		[property: ContainerField(107), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
		private bool _AltFire;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private bool _CycleRadioChannel;

		[ObservableProperty]
		[property: ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		private bool _SelectMeleeWeapon;

		[ObservableProperty]
		[property: ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		private bool _Zoom;

		[ObservableProperty]
		[property: ContainerField(111), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
		private bool _Jump;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private bool _ChangeVehicle;

		[ObservableProperty]
		[property: ContainerField(113), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
		private bool _ChangeEntry;

		[ObservableProperty]
		[property: ContainerField(114), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
		private bool _ChangePose;

		[ObservableProperty]
		[property: ContainerField(115), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
		private bool _ToggleParachute;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private bool _ChangeWeapon;

		[ObservableProperty]
		[property: ContainerField(117), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
		private bool _Reload;

		[ObservableProperty]
		[property: ContainerField(118), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
		private bool _ToggleCamera;

		[ObservableProperty]
		[property: ContainerField(119), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
		private bool _Sprint;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private bool _ScoreboardMenu;

		[ObservableProperty]
		[property: ContainerField(121), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
		private bool _MapZoom;

		[ObservableProperty]
		[property: ContainerField(122), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
		private bool _GearUp;

		[ObservableProperty]
		[property: ContainerField(123), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
		private bool _GearDown;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private bool _ThreeDimensionalMap;

		[ObservableProperty]
		[property: ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		private bool _GiveOrder;

		[ObservableProperty]
		[property: ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		private bool _Prone;

		[ObservableProperty]
		[property: ContainerField(127), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
		private bool _SwitchPrimaryInventory;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _SwitchPrimaryWeapon;

		[ObservableProperty]
		[property: ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		private bool _GrenadeLauncher;

		[ObservableProperty]
		[property: ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		private bool _StaticGadget;

		[ObservableProperty]
		[property: ContainerField(131), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
		private bool _DynamicGadget1;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private bool _DynamicGadget2;

		[ObservableProperty]
		[property: ContainerField(133), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
		private bool _MeleeAttack;

		[ObservableProperty]
		[property: ContainerField(134), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
		private bool _ThrowGrenade;

		[ObservableProperty]
		[property: ContainerField(135), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
		private bool _SelectWeapon1;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private bool _SelectWeapon2;

		[ObservableProperty]
		[property: ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		private bool _SelectWeapon3;

		[ObservableProperty]
		[property: ContainerField(138), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
		private bool _SelectWeapon4;

		[ObservableProperty]
		[property: ContainerField(139), LayoutImmutable, Blittable, JsonProperty(Order = 139)]
		private bool _SelectWeapon5;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private bool _SelectWeapon6;

		[ObservableProperty]
		[property: ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		private bool _SelectWeapon7;

		[ObservableProperty]
		[property: ContainerField(142), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
		private bool _SelectWeapon8;

		[ObservableProperty]
		[property: ContainerField(143), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
		private bool _SelectWeapon9;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private bool _OverridePreviousInputRestriction;

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
