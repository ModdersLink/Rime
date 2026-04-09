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
	public partial class CharacterStateTriggerEntityData :
		TriggerEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private uint _ActiveWeaponSlot;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _Pitch;

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private CharacterPoseAction _CharacterPose = new();

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private uint _AmmoToSet;

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private CharacterPoseAction _PoseToCheck = new();

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private CtrRef<SoldierWeaponBlueprint> _Weapon = new();

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private uint _HealthToSet;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private uint _HealthToCheck;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private uint _SeatIndex;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _ExcludeConnectedVehicles;

		[ObservableProperty]
		[property: ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		private bool _ContinueToCheckIfHoldingWrongWeapon;

		[ObservableProperty]
		[property: ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		private bool _StayInVehicleOnMove;

		[ObservableProperty]
		[property: ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		private bool _CheckHealthGreaterOrEqual;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private bool _CheckAllWeapons;

		[ObservableProperty]
		[property: ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		private bool _ShouldCheckSeatIndex;

		[ObservableProperty]
		[property: ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		private bool _UseExitPointWhenLeavingVehicle;

		[ObservableProperty]
		[property: ContainerField(155), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
		private bool _DisablePhysicsWhenLeavingVehicle;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private bool _UsePitch;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ActiveWeaponSlot);
			p_Writer.Write(Pitch);
			p_Writer.Write((int) CharacterPose);
			p_Writer.Write(AmmoToSet);
			p_Writer.Write((int) PoseToCheck);
			p_Writer.Write(p_EbxWriter.WriteImport(Weapon));
			p_Writer.Write(HealthToSet);
			p_Writer.Write(HealthToCheck);
			p_Writer.Write(SeatIndex);
			p_Writer.Write(ExcludeConnectedVehicles);
			p_Writer.Write(ContinueToCheckIfHoldingWrongWeapon);
			p_Writer.Write(StayInVehicleOnMove);
			p_Writer.Write(CheckHealthGreaterOrEqual);
			p_Writer.Write(CheckAllWeapons);
			p_Writer.Write(ShouldCheckSeatIndex);
			p_Writer.Write(UseExitPointWhenLeavingVehicle);
			p_Writer.Write(DisablePhysicsWhenLeavingVehicle);
			p_Writer.Write(UsePitch);
			p_Writer.WriteNullBytes(3);
		}
	}
}
