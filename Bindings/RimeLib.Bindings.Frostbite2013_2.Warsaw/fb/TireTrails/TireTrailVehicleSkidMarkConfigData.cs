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

using fb.Entity;
using fb.Core;

namespace fb.TireTrails;

[ContainerType(8, 80)]
public class TireTrailVehicleSkidMarkConfigData
	: fb.Entity.DataContainerPolicyAsset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float SkidLongSlipMinIntensity { get; set; } = 0.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float SkidLongSlipMaxIntensity { get; set; } = 0.800f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float SkidLongSlipRatioThreshold { get; set; } = 0.250f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float SkidLongSlipPeakRatio { get; set; } = 5.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float BrakeSkidLongSlipMinIntensity { get; set; } = 0.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float BrakeSkidLongSlipMaxIntensity { get; set; } = 0.900f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float BrakeSkidLongSlipRatioThreshold { get; set; } = 0.100f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float BrakeSkidLongSlipPeakRatio { get; set; } = 5.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float SkidLatSlipMinIntensity { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float SkidLatSlipMaxIntensity { get; set; } = 0.700f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float SkidLatSlipAngleThreshold { get; set; } = 0.200f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float SkidLatSlipPeakAngle { get; set; } = 3.140f;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public MaterialDecl GripMaterialPair { get; set; } = new();
	
	[ContainerField(0x4c), JsonProperty(Order = 76)]
	public MaterialDecl SlipMaterialPair { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SkidLongSlipMinIntensity);
		p_Writer.Write(SkidLongSlipMaxIntensity);
		p_Writer.Write(SkidLongSlipRatioThreshold);
		p_Writer.Write(SkidLongSlipPeakRatio);
		p_Writer.Write(BrakeSkidLongSlipMinIntensity);
		p_Writer.Write(BrakeSkidLongSlipMaxIntensity);
		p_Writer.Write(BrakeSkidLongSlipRatioThreshold);
		p_Writer.Write(BrakeSkidLongSlipPeakRatio);
		p_Writer.Write(SkidLatSlipMinIntensity);
		p_Writer.Write(SkidLatSlipMaxIntensity);
		p_Writer.Write(SkidLatSlipAngleThreshold);
		p_Writer.Write(SkidLatSlipPeakAngle);
		GripMaterialPair.Serialize(p_Writer, p_EbxWriter);
		SlipMaterialPair.Serialize(p_Writer, p_EbxWriter);
	}
}

