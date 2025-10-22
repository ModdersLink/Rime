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

namespace fb.SoldierShared;

[ContainerType(8, 88)]
public class DefibrillatorWeaponData
	: fb.GameShared.WeaponData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float AttackTime { get; set; } = 0.250f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float FullHealthTime { get; set; } = 2.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float InitialStartHealth { get; set; } = 0.500f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float MaxAngleToVictimXZ { get; set; } = 32.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float DefibActionCooldownTime { get; set; } = 0.750f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float MaxClientBodyDistance { get; set; } = 5.000f;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public DefibrillatorUpgradeWeaponData UpgradeWeaponData { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool ClientSideRevive { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool ClientSideKillInVehicles { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AttackTime);
		p_Writer.Write(FullHealthTime);
		p_Writer.Write(InitialStartHealth);
		p_Writer.Write(MaxAngleToVictimXZ);
		p_Writer.Write(DefibActionCooldownTime);
		p_Writer.Write(MaxClientBodyDistance);
		UpgradeWeaponData.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ClientSideRevive);
		p_Writer.Write(ClientSideKillInVehicles);
		p_Writer.WriteNullBytes(6);
	}
}

