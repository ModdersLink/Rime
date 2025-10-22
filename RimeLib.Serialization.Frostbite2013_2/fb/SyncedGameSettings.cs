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

namespace fb.GameShared;

[ContainerType(8, 112)]
public class SyncedGameSettings
	: fb.Core.SystemSettings
{
	public SyncedGameSettings()
	{
		//SystemSettings
		Name = @"SyncedGame";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint DifficultyIndex { get; set; } = 0;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float ManDownTimeModifier { get; set; } = 1.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float BulletDamageModifier { get; set; } = 1.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float MaxAllowedLatency { get; set; } = 0.850f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float HighLatency { get; set; } = 0.170f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float CriticalLatency { get; set; } = 0.220f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float HighLatencyVariation { get; set; } = 0.300f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float CriticalLatencyVariation { get; set; } = 0.500f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float MaxLatencyForHighFreq { get; set; } = 0.200f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float HighPacketLossRatio { get; set; } = 0.010f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float CriticalPacketLossRatio { get; set; } = 0.050f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float LowMonitorRefresh { get; set; } = 0.980f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float LowClientFps { get; set; } = 0.950f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float BadExperienceIconsHoldTime { get; set; } = 1.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float PromoteHighFrequencyScore { get; set; } = 30.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float DemoteHighFrequencyScore { get; set; } = -5.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool DisableToggleEntryCamera { get; set; } = false;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public bool DisableRegenerateHealth { get; set; } = false;
	
	[ContainerField(0x62), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
	public bool EnableFriendlyFire { get; set; } = false;
	
	[ContainerField(0x63), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
	public bool AllowClientSideDamageArbitration { get; set; } = true;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public bool ForceReloadWholeMags { get; set; } = false;
	
	[ContainerField(0x65), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
	public bool TireTrailsEnabled { get; set; } = true;
	
	[ContainerField(0x66), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
	public bool SpecEvent1 { get; set; } = false;
	
	[ContainerField(0x67), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
	public bool SpecEvent2 { get; set; } = false;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool SpecEvent3 { get; set; } = false;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool SpecEvent4 { get; set; } = false;
	
	[ContainerField(0x6a), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
	public bool SpecEvent5 { get; set; } = false;
	
	[ContainerField(0x6b), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
	public bool AimAssistRotationEnabled { get; set; } = true;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool AimAssistSlowdownEnabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DifficultyIndex);
		p_Writer.Write(ManDownTimeModifier);
		p_Writer.Write(BulletDamageModifier);
		p_Writer.Write(MaxAllowedLatency);
		p_Writer.Write(HighLatency);
		p_Writer.Write(CriticalLatency);
		p_Writer.Write(HighLatencyVariation);
		p_Writer.Write(CriticalLatencyVariation);
		p_Writer.Write(MaxLatencyForHighFreq);
		p_Writer.Write(HighPacketLossRatio);
		p_Writer.Write(CriticalPacketLossRatio);
		p_Writer.Write(LowMonitorRefresh);
		p_Writer.Write(LowClientFps);
		p_Writer.Write(BadExperienceIconsHoldTime);
		p_Writer.Write(PromoteHighFrequencyScore);
		p_Writer.Write(DemoteHighFrequencyScore);
		p_Writer.Write(DisableToggleEntryCamera);
		p_Writer.Write(DisableRegenerateHealth);
		p_Writer.Write(EnableFriendlyFire);
		p_Writer.Write(AllowClientSideDamageArbitration);
		p_Writer.Write(ForceReloadWholeMags);
		p_Writer.Write(TireTrailsEnabled);
		p_Writer.Write(SpecEvent1);
		p_Writer.Write(SpecEvent2);
		p_Writer.Write(SpecEvent3);
		p_Writer.Write(SpecEvent4);
		p_Writer.Write(SpecEvent5);
		p_Writer.Write(AimAssistRotationEnabled);
		p_Writer.Write(AimAssistSlowdownEnabled);
		p_Writer.WriteNullBytes(3);
	}
}

