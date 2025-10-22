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

[ContainerType(8, 88)]
public class GearboxConfigData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<float> ForwardGearRatios { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<float> ForwardGearSpeeds { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<float> ReverseGearRatios { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<float> ReverseGearSpeeds { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int GearboxType { get; set; } = 0;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int GearboxMode { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float GearChangeTime { get; set; } = 0.062f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float GearDownSpeedFactor { get; set; } = 0.800f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float OppositeDirGearChangeMaxSpeed { get; set; } = 50.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float OppositeDirGearChangeTime { get; set; } = 0.125f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float ClutchSpeedFactor { get; set; } = 10.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float TransmissionEfficiency { get; set; } = 1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool UseAutoClutch { get; set; } = true;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool UseClassicGearBoxAutoClutch { get; set; } = false;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool UseNeutralGear { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ForwardGearRatios = p_EbxWriter.GetArrayWriter(ForwardGearRatios.GetType(), ForwardGearRatios.Count);
		p_Writer.Write(s_ForwardGearRatios.ArrayIndex);
		foreach (var s_Entry in ForwardGearRatios)
		{
			s_ForwardGearRatios.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ForwardGearSpeeds = p_EbxWriter.GetArrayWriter(ForwardGearSpeeds.GetType(), ForwardGearSpeeds.Count);
		p_Writer.Write(s_ForwardGearSpeeds.ArrayIndex);
		foreach (var s_Entry in ForwardGearSpeeds)
		{
			s_ForwardGearSpeeds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ReverseGearRatios = p_EbxWriter.GetArrayWriter(ReverseGearRatios.GetType(), ReverseGearRatios.Count);
		p_Writer.Write(s_ReverseGearRatios.ArrayIndex);
		foreach (var s_Entry in ReverseGearRatios)
		{
			s_ReverseGearRatios.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ReverseGearSpeeds = p_EbxWriter.GetArrayWriter(ReverseGearSpeeds.GetType(), ReverseGearSpeeds.Count);
		p_Writer.Write(s_ReverseGearSpeeds.ArrayIndex);
		foreach (var s_Entry in ReverseGearSpeeds)
		{
			s_ReverseGearSpeeds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(GearboxType);
		p_Writer.Write(GearboxMode);
		p_Writer.Write(GearChangeTime);
		p_Writer.Write(GearDownSpeedFactor);
		p_Writer.Write(OppositeDirGearChangeMaxSpeed);
		p_Writer.Write(OppositeDirGearChangeTime);
		p_Writer.Write(ClutchSpeedFactor);
		p_Writer.Write(TransmissionEfficiency);
		p_Writer.Write(UseAutoClutch);
		p_Writer.Write(UseClassicGearBoxAutoClutch);
		p_Writer.Write(UseNeutralGear);
		p_Writer.WriteNullBytes(5);
	}
}

