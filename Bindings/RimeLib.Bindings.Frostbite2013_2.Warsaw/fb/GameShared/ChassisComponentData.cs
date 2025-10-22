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
using fb.Physics;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 240)]
public class ChassisComponentData
	: fb.GameShared.PartComponentData
{
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 TriggerGroundEffectOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<VehicleConfigData> VehicleConfig { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<GearboxConfigData> GearboxConfig { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<CameraRelativeControlData> CameraRelativeControlConfig { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public RefArray<VehicleWaterEffectData> WaterEffects { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public RefArray<VehicleWaterEffectData> WaterStreakEffects { get; set; } = new();
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float TriggerGroundEffectImpulse { get; set; } = 0.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float TriggerGroundEffectHeight { get; set; } = 0.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float GroundEffectFadeParam { get; set; } = 0.000f;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public CtrRef<LandingGearLogicData> LandingGearLogic { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public List<OnImpulseModifierData> OnImpulseModifiers { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public bool AlwaysFullThrottle { get; set; } = false;
	
	[ContainerField(0xe9), LayoutImmutable, Blittable, JsonProperty(Order = 233)]
	public bool TriggerGroundEffectUseBBCenter { get; set; } = true;
	
	[ContainerField(0xea), LayoutImmutable, Blittable, JsonProperty(Order = 234)]
	public bool GroundEffectOnTerrainOnly { get; set; } = false;
	
	[ContainerField(0xeb), LayoutImmutable, Blittable, JsonProperty(Order = 235)]
	public bool AllowNegativeThrottle { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		TriggerGroundEffectOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(VehicleConfig));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(GearboxConfig));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CameraRelativeControlConfig));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_WaterEffects = p_EbxWriter.GetArrayWriter(WaterEffects.GetType(), WaterEffects.Count);
		p_Writer.Write(s_WaterEffects.ArrayIndex);
		foreach (var s_Entry in WaterEffects)
		{
			s_WaterEffects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_WaterStreakEffects = p_EbxWriter.GetArrayWriter(WaterStreakEffects.GetType(), WaterStreakEffects.Count);
		p_Writer.Write(s_WaterStreakEffects.ArrayIndex);
		foreach (var s_Entry in WaterStreakEffects)
		{
			s_WaterStreakEffects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TriggerGroundEffectImpulse);
		p_Writer.Write(TriggerGroundEffectHeight);
		p_Writer.Write(GroundEffectFadeParam);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LandingGearLogic));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OnImpulseModifiers = p_EbxWriter.GetArrayWriter(OnImpulseModifiers.GetType(), OnImpulseModifiers.Count);
		p_Writer.Write(s_OnImpulseModifiers.ArrayIndex);
		foreach (var s_Entry in OnImpulseModifiers)
		{
			s_Entry.Serialize(s_OnImpulseModifiers.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AlwaysFullThrottle);
		p_Writer.Write(TriggerGroundEffectUseBBCenter);
		p_Writer.Write(GroundEffectOnTerrainOnly);
		p_Writer.Write(AllowNegativeThrottle);
		p_Writer.WriteNullBytes(4);
	}
}

