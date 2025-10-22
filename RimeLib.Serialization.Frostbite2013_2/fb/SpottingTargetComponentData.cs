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

[ContainerType(16, 144)]
public class SpottingTargetComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float ActiveSpottedTime { get; set; } = 5.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float PassiveSpottedTime { get; set; } = 3.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float ActiveSpottedTimeMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float PassiveSpottedTimeMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float SpotOnFireMultiplier { get; set; } = 0.500f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float RadarSpottedSpeedThresholdOverride { get; set; } = -1.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public bool TargetBoundingBoxCenter { get; set; } = true;
	
	[ContainerField(0x89), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
	public bool CalculateAngleOutsideBoundingSphere { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ActiveSpottedTime);
		p_Writer.Write(PassiveSpottedTime);
		p_Writer.Write(ActiveSpottedTimeMultiplier);
		p_Writer.Write(PassiveSpottedTimeMultiplier);
		p_Writer.Write(SpotOnFireMultiplier);
		p_Writer.Write(RadarSpottedSpeedThresholdOverride);
		p_Writer.Write(TargetBoundingBoxCenter);
		p_Writer.Write(CalculateAngleOutsideBoundingSphere);
		p_Writer.WriteNullBytes(6);
	}
}

