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

using fb.Core;
using fb.GameShared;
using fb.Entity;

namespace fb.SoldierShared;

[ContainerType(16, 192)]
public class CharacterStateTriggerEntityData
	: fb.GameShared.TriggerEntityData
{
	public CharacterStateTriggerEntityData()
	{
		//TriggerEntityData
		RunOnce = false;
	}
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float Pitch { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public CharacterPoseAction CharacterPose { get; set; } = CharacterPoseAction.CPTForceToStand;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<SoldierWeaponUnlockAsset> SoldierWeapon { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public uint SeatIndex { get; set; } = 0;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public uint HealthToSet { get; set; } = 100;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public uint HealthToCheck { get; set; } = 100;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float ImmortalTime { get; set; } = 0.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public uint AmmoToSet { get; set; } = 75;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public CharacterPoseAction PoseToCheck { get; set; } = CharacterPoseAction.CPTForceToStand;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public uint ActiveWeaponSlot { get; set; } = 0;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float MoveSpeedMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float SprintSpeedMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float JumpHeightMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float LookSpeedMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public bool UsePitch { get; set; } = false;
	
	[ContainerField(0xad), LayoutImmutable, Blittable, JsonProperty(Order = 173)]
	public bool ExcludeConnectedVehicles { get; set; } = false;
	
	[ContainerField(0xae), LayoutImmutable, Blittable, JsonProperty(Order = 174)]
	public bool StayInVehicleOnMove { get; set; } = false;
	
	[ContainerField(0xaf), LayoutImmutable, Blittable, JsonProperty(Order = 175)]
	public bool LeaveVehicleOnMove { get; set; } = true;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public bool CheckAllWeapons { get; set; } = false;
	
	[ContainerField(0xb1), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
	public bool CheckOnlyReadyWeapons { get; set; } = false;
	
	[ContainerField(0xb2), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
	public bool ContinueToCheckIfHoldingWrongWeapon { get; set; } = false;
	
	[ContainerField(0xb3), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
	public bool ShouldCheckSeatIndex { get; set; } = false;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public bool AllowRemoteControlledVehicles { get; set; } = false;
	
	[ContainerField(0xb5), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
	public bool InstantDeath { get; set; } = false;
	
	[ContainerField(0xb6), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
	public bool CheckHealthGreaterOrEqual { get; set; } = true;
	
	[ContainerField(0xb7), LayoutImmutable, Blittable, JsonProperty(Order = 183)]
	public bool UseExitPointWhenLeavingVehicle { get; set; } = true;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public bool DisablePhysicsWhenLeavingVehicle { get; set; } = false;
	
	[ContainerField(0xb9), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
	public bool LeaveRemoteVehicles { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Pitch);
		p_Writer.Write((int) CharacterPose);
		p_Writer.Write(p_EbxWriter.WriteImport(SoldierWeapon));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SeatIndex);
		p_Writer.Write(HealthToSet);
		p_Writer.Write(HealthToCheck);
		p_Writer.Write(ImmortalTime);
		p_Writer.Write(AmmoToSet);
		p_Writer.Write((int) PoseToCheck);
		p_Writer.Write(ActiveWeaponSlot);
		p_Writer.Write(MoveSpeedMultiplier);
		p_Writer.Write(SprintSpeedMultiplier);
		p_Writer.Write(JumpHeightMultiplier);
		p_Writer.Write(LookSpeedMultiplier);
		p_Writer.Write(UsePitch);
		p_Writer.Write(ExcludeConnectedVehicles);
		p_Writer.Write(StayInVehicleOnMove);
		p_Writer.Write(LeaveVehicleOnMove);
		p_Writer.Write(CheckAllWeapons);
		p_Writer.Write(CheckOnlyReadyWeapons);
		p_Writer.Write(ContinueToCheckIfHoldingWrongWeapon);
		p_Writer.Write(ShouldCheckSeatIndex);
		p_Writer.Write(AllowRemoteControlledVehicles);
		p_Writer.Write(InstantDeath);
		p_Writer.Write(CheckHealthGreaterOrEqual);
		p_Writer.Write(UseExitPointWhenLeavingVehicle);
		p_Writer.Write(DisablePhysicsWhenLeavingVehicle);
		p_Writer.Write(LeaveRemoteVehicles);
		p_Writer.WriteNullBytes(6);
	}
}

