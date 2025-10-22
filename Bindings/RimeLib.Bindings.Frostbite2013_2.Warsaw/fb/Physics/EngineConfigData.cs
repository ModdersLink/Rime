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

[ContainerType(16, 112)]
public class EngineConfigData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<float> RpmCurvePoints { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<float> TorqueCurvePoints { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 Position { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float RpmMin { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float RpmMax { get; set; } = 10000.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float RpmCut { get; set; } = 9500.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float EnginePowerMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float InternalAccelerationFactor { get; set; } = 0.500f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float InternalDeaccelerationFactor { get; set; } = 0.500f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float MaxReverseSpeed { get; set; } = 10000.000f;
	
	[ContainerField(0x4c), JsonProperty(Order = 76)]
	public Boost Boost { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float MaxVehicleHeightOffset { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_RpmCurvePoints = p_EbxWriter.GetArrayWriter(RpmCurvePoints.GetType(), RpmCurvePoints.Count);
		p_Writer.Write(s_RpmCurvePoints.ArrayIndex);
		foreach (var s_Entry in RpmCurvePoints)
		{
			s_RpmCurvePoints.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_TorqueCurvePoints = p_EbxWriter.GetArrayWriter(TorqueCurvePoints.GetType(), TorqueCurvePoints.Count);
		p_Writer.Write(s_TorqueCurvePoints.ArrayIndex);
		foreach (var s_Entry in TorqueCurvePoints)
		{
			s_TorqueCurvePoints.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		Position.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RpmMin);
		p_Writer.Write(RpmMax);
		p_Writer.Write(RpmCut);
		p_Writer.Write(EnginePowerMultiplier);
		p_Writer.Write(InternalAccelerationFactor);
		p_Writer.Write(InternalDeaccelerationFactor);
		p_Writer.Write(MaxReverseSpeed);
		Boost.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxVehicleHeightOffset);
		p_Writer.WriteNullBytes(4);
	}
}

