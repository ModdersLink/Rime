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

namespace fb.Venice;

[ContainerType(8, 80)]
public class SkeletonInputEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float LeanSideLevelOutSpeed { get; set; } = 2.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float LeanSideCenterDeadZoneSize { get; set; } = 0.001f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float LeanSideCenterDeadZoneScale { get; set; } = 1.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float LeanSideSensitivity { get; set; } = 30.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float LeanSideRecalibrationTime { get; set; } = 1.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float LeanSideBlockStart { get; set; } = 1.500f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float LeanSideBlockEnd { get; set; } = 0.500f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float LeanSideBlockStartHeightOffset { get; set; } = 0.500f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float HeadYawSensitivity { get; set; } = 2.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float HeadPitchSensitivity { get; set; } = 2.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float HeadSmoothingFactorMin { get; set; } = 0.350f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float HeadSmoothingFactorMax { get; set; } = 0.990f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float HeadSmoothingFactorChangeLimit { get; set; } = 0.200f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool UseLeaning { get; set; } = false;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool UseHeadTracking { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LeanSideLevelOutSpeed);
		p_Writer.Write(LeanSideCenterDeadZoneSize);
		p_Writer.Write(LeanSideCenterDeadZoneScale);
		p_Writer.Write(LeanSideSensitivity);
		p_Writer.Write(LeanSideRecalibrationTime);
		p_Writer.Write(LeanSideBlockStart);
		p_Writer.Write(LeanSideBlockEnd);
		p_Writer.Write(LeanSideBlockStartHeightOffset);
		p_Writer.Write(HeadYawSensitivity);
		p_Writer.Write(HeadPitchSensitivity);
		p_Writer.Write(HeadSmoothingFactorMin);
		p_Writer.Write(HeadSmoothingFactorMax);
		p_Writer.Write(HeadSmoothingFactorChangeLimit);
		p_Writer.Write(UseLeaning);
		p_Writer.Write(UseHeadTracking);
		p_Writer.WriteNullBytes(2);
	}
}

