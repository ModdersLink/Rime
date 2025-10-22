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

namespace fb.VeniceShared;

[ContainerType(8, 72)]
public class DamageScoringHandlerData
	: fb.VeniceShared.ScoringHandlerData
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float RepairVehicleLimit { get; set; } = 0.010f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float DamageTeamVehicleLimit { get; set; } = 0.500f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float TeamHealingLimit { get; set; } = 0.500f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float TeamDamageLimit { get; set; } = 0.500f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float KillAssistLimit { get; set; } = 0.500f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float KillAssistAsKillLimit { get; set; } = 0.750f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float KillAssistTimeout { get; set; } = 10.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float VehicleDestroyAssistLimit { get; set; } = 0.500f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float SaviorKillTimeout { get; set; } = 2.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float SaviorDamageLimit { get; set; } = 0.500f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float DamageDoneTimeout { get; set; } = 10.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float DamageDoneMaxValue { get; set; } = 1000.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float HotVehicleTimeout { get; set; } = 10.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RepairVehicleLimit);
		p_Writer.Write(DamageTeamVehicleLimit);
		p_Writer.Write(TeamHealingLimit);
		p_Writer.Write(TeamDamageLimit);
		p_Writer.Write(KillAssistLimit);
		p_Writer.Write(KillAssistAsKillLimit);
		p_Writer.Write(KillAssistTimeout);
		p_Writer.Write(VehicleDestroyAssistLimit);
		p_Writer.Write(SaviorKillTimeout);
		p_Writer.Write(SaviorDamageLimit);
		p_Writer.Write(DamageDoneTimeout);
		p_Writer.Write(DamageDoneMaxValue);
		p_Writer.Write(HotVehicleTimeout);
		p_Writer.WriteNullBytes(4);
	}
}

