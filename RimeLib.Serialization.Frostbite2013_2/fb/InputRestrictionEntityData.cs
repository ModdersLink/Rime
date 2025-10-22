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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 80)]
public class InputRestrictionEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public bool OverridePreviousInputRestriction { get; set; } = true;
	
	[ContainerField(0x19), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
	public bool ApplyRestrictionsToSpecificPlayer { get; set; } = false;
	
	[ContainerField(0x1a), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
	public bool Throttle { get; set; } = true;
	
	[ContainerField(0x1b), LayoutImmutable, Blittable, JsonProperty(Order = 27)]
	public bool Strafe { get; set; } = true;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public bool Brake { get; set; } = true;
	
	[ContainerField(0x1d), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
	public bool HandBrake { get; set; } = true;
	
	[ContainerField(0x1e), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
	public bool Clutch { get; set; } = true;
	
	[ContainerField(0x1f), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
	public bool Yaw { get; set; } = true;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool Pitch { get; set; } = true;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool Roll { get; set; } = true;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public bool Fire { get; set; } = true;
	
	[ContainerField(0x23), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
	public bool FireCountermeasure { get; set; } = true;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool AltFire { get; set; } = true;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool CycleRadioChannel { get; set; } = true;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool SelectMeleeWeapon { get; set; } = true;
	
	[ContainerField(0x27), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
	public bool Zoom { get; set; } = true;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool Jump { get; set; } = true;
	
	[ContainerField(0x29), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
	public bool ChangeVehicle { get; set; } = true;
	
	[ContainerField(0x2a), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
	public bool ChangeEntry { get; set; } = true;
	
	[ContainerField(0x2b), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
	public bool ChangePose { get; set; } = true;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public bool ToggleParachute { get; set; } = true;
	
	[ContainerField(0x2d), LayoutImmutable, Blittable, JsonProperty(Order = 45)]
	public bool ChangeWeapon { get; set; } = true;
	
	[ContainerField(0x2e), LayoutImmutable, Blittable, JsonProperty(Order = 46)]
	public bool Reload { get; set; } = true;
	
	[ContainerField(0x2f), LayoutImmutable, Blittable, JsonProperty(Order = 47)]
	public bool ToggleCamera { get; set; } = true;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool Sprint { get; set; } = true;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool ScoreboardMenu { get; set; } = true;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool MapZoom { get; set; } = true;
	
	[ContainerField(0x33), LayoutImmutable, Blittable, JsonProperty(Order = 51)]
	public bool GearUp { get; set; } = true;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool GearDown { get; set; } = true;
	
	[ContainerField(0x35), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
	public bool ThreeDimensionalMap { get; set; } = true;
	
	[ContainerField(0x36), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
	public bool GiveOrder { get; set; } = true;
	
	[ContainerField(0x37), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
	public bool Prone { get; set; } = true;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool SwitchPrimaryInventory { get; set; } = true;
	
	[ContainerField(0x39), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
	public bool SwitchPrimaryWeapon { get; set; } = true;
	
	[ContainerField(0x3a), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
	public bool GrenadeLauncher { get; set; } = true;
	
	[ContainerField(0x3b), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
	public bool StaticGadget { get; set; } = true;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public bool DynamicGadget1 { get; set; } = true;
	
	[ContainerField(0x3d), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
	public bool DynamicGadget2 { get; set; } = true;
	
	[ContainerField(0x3e), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
	public bool MeleeAttack { get; set; } = true;
	
	[ContainerField(0x3f), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
	public bool ThrowGrenade { get; set; } = true;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool SelectWeapon1 { get; set; } = true;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool SelectWeapon2 { get; set; } = true;
	
	[ContainerField(0x42), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
	public bool SelectWeapon3 { get; set; } = true;
	
	[ContainerField(0x43), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
	public bool SelectWeapon4 { get; set; } = true;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool SelectWeapon5 { get; set; } = true;
	
	[ContainerField(0x45), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
	public bool SelectWeapon6 { get; set; } = true;
	
	[ContainerField(0x46), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
	public bool SelectWeapon7 { get; set; } = true;
	
	[ContainerField(0x47), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
	public bool SelectWeapon8 { get; set; } = true;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool SelectWeapon9 { get; set; } = true;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool CommoRose { get; set; } = true;
	
	[ContainerField(0x4a), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
	public bool ToggleLight { get; set; } = true;
	
	[ContainerField(0x4b), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
	public bool CycleFireMode { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(OverridePreviousInputRestriction);
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
		p_Writer.Write(CommoRose);
		p_Writer.Write(ToggleLight);
		p_Writer.Write(CycleFireMode);
		p_Writer.WriteNullBytes(4);
	}
}

