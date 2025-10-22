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

namespace fb.VeniceShared;

[ContainerType(16, 208)]
public class SpottingComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float SpottingFov { get; set; } = 5.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float SpottingDistFov { get; set; } = -1.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float PassiveSpottingFov { get; set; } = -1.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float PassiveSpottingDistFov { get; set; } = -1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float TeamOrderFov { get; set; } = 15.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float TeamOrderDistFov { get; set; } = -1.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float SpottingDistance { get; set; } = 1200.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float PassiveSpottingDistance { get; set; } = -1.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float PassiveSpottingTimeInterval { get; set; } = 1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float TimeRequiredToPassiveSpot { get; set; } = 2.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float OrderNeedAmmoPercentage { get; set; } = 50.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float OrderHealPercentage { get; set; } = 50.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float OrderRepairPercentage { get; set; } = 65.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float PickupOrderDistance { get; set; } = 50.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float HealOrderDistance { get; set; } = 30.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float AmmoOrderDistance { get; set; } = 30.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float RepairOrderDistance { get; set; } = 50.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float CoolDownHistoryTime { get; set; } = 3.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public int CoolDownAllowedSpotsWithinHistory { get; set; } = 3;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float AutoSpottingTimeInterval { get; set; } = 1.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float ActiveSpottingTargetTimeMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float AutoSpottingSpeedThreshold { get; set; } = 0.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public bool OnlyAllowedToHaveOneSpottedPlayer { get; set; } = false;
	
	[ContainerField(0xc9), LayoutImmutable, Blittable, JsonProperty(Order = 201)]
	public bool RequireLineOfSight { get; set; } = true;
	
	[ContainerField(0xca), LayoutImmutable, Blittable, JsonProperty(Order = 202)]
	public bool ActiveSpottingEnabled { get; set; } = true;
	
	[ContainerField(0xcb), LayoutImmutable, Blittable, JsonProperty(Order = 203)]
	public bool PassiveSpottingEnabled { get; set; } = false;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public bool AutoSpottingEnabled { get; set; } = false;
	
	[ContainerField(0xcd), LayoutImmutable, Blittable, JsonProperty(Order = 205)]
	public bool AutoSpottingHighlightSpottedEnemies { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SpottingFov);
		p_Writer.Write(SpottingDistFov);
		p_Writer.Write(PassiveSpottingFov);
		p_Writer.Write(PassiveSpottingDistFov);
		p_Writer.Write(TeamOrderFov);
		p_Writer.Write(TeamOrderDistFov);
		p_Writer.Write(SpottingDistance);
		p_Writer.Write(PassiveSpottingDistance);
		p_Writer.Write(PassiveSpottingTimeInterval);
		p_Writer.Write(TimeRequiredToPassiveSpot);
		p_Writer.Write(OrderNeedAmmoPercentage);
		p_Writer.Write(OrderHealPercentage);
		p_Writer.Write(OrderRepairPercentage);
		p_Writer.Write(PickupOrderDistance);
		p_Writer.Write(HealOrderDistance);
		p_Writer.Write(AmmoOrderDistance);
		p_Writer.Write(RepairOrderDistance);
		p_Writer.Write(CoolDownHistoryTime);
		p_Writer.Write(CoolDownAllowedSpotsWithinHistory);
		p_Writer.Write(AutoSpottingTimeInterval);
		p_Writer.Write(ActiveSpottingTargetTimeMultiplier);
		p_Writer.Write(AutoSpottingSpeedThreshold);
		p_Writer.Write(OnlyAllowedToHaveOneSpottedPlayer);
		p_Writer.Write(RequireLineOfSight);
		p_Writer.Write(ActiveSpottingEnabled);
		p_Writer.Write(PassiveSpottingEnabled);
		p_Writer.Write(AutoSpottingEnabled);
		p_Writer.Write(AutoSpottingHighlightSpottedEnemies);
		p_Writer.WriteNullBytes(2);
	}
}

