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
using fb.UI;

namespace fb.VeniceShared;

[ContainerType(8, 96)]
public class UISoldierCompData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float CriticalHealthThreshold { get; set; } = 10.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int ShockTraumaAbilityIndex { get; set; } = -1;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int RangerPTProgramAbilityIndex { get; set; } = -1;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int FocusAbilityIndex { get; set; } = -1;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float HitShaderDamageMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float HitShaderMinDamage { get; set; } = 0.100f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float HitShaderMaxDamage { get; set; } = 0.600f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float HitShaderGradientDurationMultiplier { get; set; } = 6.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float HitShaderIndicatorDurationMultiplier { get; set; } = 1.500f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float EKGLineThickness { get; set; } = 12.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float EKGLineAlpha { get; set; } = 1.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool UseSquadSpawn { get; set; } = true;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool SpawnOnSquadLeaders { get; set; } = true;
	
	[ContainerField(0x5e), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
	public bool UseVehicleTeamSpawn { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CriticalHealthThreshold);
		p_Writer.Write(ShockTraumaAbilityIndex);
		p_Writer.Write(RangerPTProgramAbilityIndex);
		p_Writer.Write(FocusAbilityIndex);
		p_Writer.Write(HitShaderDamageMultiplier);
		p_Writer.Write(HitShaderMinDamage);
		p_Writer.Write(HitShaderMaxDamage);
		p_Writer.Write(HitShaderGradientDurationMultiplier);
		p_Writer.Write(HitShaderIndicatorDurationMultiplier);
		p_Writer.Write(EKGLineThickness);
		p_Writer.Write(EKGLineAlpha);
		p_Writer.Write(UseSquadSpawn);
		p_Writer.Write(SpawnOnSquadLeaders);
		p_Writer.Write(UseVehicleTeamSpawn);
		p_Writer.WriteNullBytes(1);
	}
}

