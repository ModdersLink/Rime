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

namespace fb.Physics;

[ContainerType(16, 176)]
public class JetEngineConfigData
	: fb.Physics.EngineConfigData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public uint DirectionVectorIndex { get; set; } = 2;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float ForceMagnitudeMultiplier { get; set; } = 100.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float AngleInputYMultiplier { get; set; } = 90.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float AngleInputPitchMultiplier { get; set; } = 0.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float PitchForceModifier { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float MaxVelocity { get; set; } = 0.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float OutOfWaterContactThresholdTime { get; set; } = 0.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float OutOfWaterContactRampDownTime { get; set; } = 0.000f;
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public List<SensitivityAtVelocity> SteeringSensitivity { get; set; } = new();
	
	[ContainerField(0x98), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public Vec2 PowerFadeOutRange { get; set; } = new()
	{
		y = 1500.000f,
		x = 1000.000f,
	};
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool IsTurnable { get; set; } = true;
	
	[ContainerField(0xa1), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
	public bool IsWaterJetEngine { get; set; } = true;
	
	[ContainerField(0xa2), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
	public bool UseForcePositionWaterTest { get; set; } = true;
	
	[ContainerField(0xa3), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
	public bool UseHullInWaterTest { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DirectionVectorIndex);
		p_Writer.Write(ForceMagnitudeMultiplier);
		p_Writer.Write(AngleInputYMultiplier);
		p_Writer.Write(AngleInputPitchMultiplier);
		p_Writer.Write(PitchForceModifier);
		p_Writer.Write(MaxVelocity);
		p_Writer.Write(OutOfWaterContactThresholdTime);
		p_Writer.Write(OutOfWaterContactRampDownTime);
		(RimeWriter Writer, uint ArrayIndex) s_SteeringSensitivity = p_EbxWriter.GetArrayWriter(SteeringSensitivity.GetType(), SteeringSensitivity.Count);
		p_Writer.Write(s_SteeringSensitivity.ArrayIndex);
		foreach (var s_Entry in SteeringSensitivity)
		{
			s_Entry.Serialize(s_SteeringSensitivity.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		PowerFadeOutRange.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(IsTurnable);
		p_Writer.Write(IsWaterJetEngine);
		p_Writer.Write(UseForcePositionWaterTest);
		p_Writer.Write(UseHullInWaterTest);
		p_Writer.WriteNullBytes(12);
	}
}

