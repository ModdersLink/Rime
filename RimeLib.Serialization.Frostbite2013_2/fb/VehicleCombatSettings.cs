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

namespace fb.BFAI2Data;

[ContainerType(8, 88)]
public class VehicleCombatSettings
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public Distances Distances { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float NeverLoseInterestDistance { get; set; } = 20.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float LoseInterestTime { get; set; } = 15.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float SixthSenseRadius { get; set; } = 8.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float EvadeTime { get; set; } = 40.000f;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public VehicleVsVehicle VehicleVsVehicle { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public VehicleVsSoldier VehicleVsSoldier { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool UseSimpleBehavior { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Distances.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(NeverLoseInterestDistance);
		p_Writer.Write(LoseInterestTime);
		p_Writer.Write(SixthSenseRadius);
		p_Writer.Write(EvadeTime);
		VehicleVsVehicle.Serialize(p_Writer, p_EbxWriter);
		VehicleVsSoldier.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UseSimpleBehavior);
		p_Writer.WriteNullBytes(7);
	}
}

