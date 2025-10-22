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

[ContainerType(16, 160)]
public class VehicleStateTriggerEntityData
	: fb.GameShared.TriggerEntityData
{
	public VehicleStateTriggerEntityData()
	{
		//TriggerEntityData
		RunOnce = false;
	}
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float LockAmount { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public uint SeatSpecificIndexForHuman { get; set; } = 0;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint SeatSpecificIndexForAi { get; set; } = 0;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public uint BulletCount { get; set; } = 1;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public uint HealthToSet { get; set; } = 100;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public uint HealthToCheck { get; set; } = 100;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float DestructionRadius { get; set; } = 5.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public uint VehicleSeatIndex { get; set; } = 0;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool AllowHumanToEnterAllSeats { get; set; } = true;
	
	[ContainerField(0x91), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
	public bool RestrictHumanToSpecificSeat { get; set; } = false;
	
	[ContainerField(0x92), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
	public bool AllowAiToEnterAllSeats { get; set; } = true;
	
	[ContainerField(0x93), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
	public bool BanAiFromSpecificSeat { get; set; } = false;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public bool TriggerCriticalOnHealthSet { get; set; } = false;
	
	[ContainerField(0x95), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
	public bool CheckHealthGreaterOrEqual { get; set; } = true;
	
	[ContainerField(0x96), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
	public bool ShouldDestroyVehicles { get; set; } = true;
	
	[ContainerField(0x97), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
	public bool ShouldDestroyBangers { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LockAmount);
		p_Writer.Write(SeatSpecificIndexForHuman);
		p_Writer.Write(SeatSpecificIndexForAi);
		p_Writer.Write(BulletCount);
		p_Writer.Write(HealthToSet);
		p_Writer.Write(HealthToCheck);
		p_Writer.Write(DestructionRadius);
		p_Writer.Write(VehicleSeatIndex);
		p_Writer.Write(AllowHumanToEnterAllSeats);
		p_Writer.Write(RestrictHumanToSpecificSeat);
		p_Writer.Write(AllowAiToEnterAllSeats);
		p_Writer.Write(BanAiFromSpecificSeat);
		p_Writer.Write(TriggerCriticalOnHealthSet);
		p_Writer.Write(CheckHealthGreaterOrEqual);
		p_Writer.Write(ShouldDestroyVehicles);
		p_Writer.Write(ShouldDestroyBangers);
		p_Writer.WriteNullBytes(8);
	}
}

