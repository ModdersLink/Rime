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

[ContainerType(16, 144)]
public class AimingComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float TrackHeatSignatureThreshold { get; set; } = -1.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float Range { get; set; } = 100.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float AngularTolerance { get; set; } = 10.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float PitchVelocity { get; set; } = 45.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float YawVelocity { get; set; } = 45.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float OcclusionTimeout { get; set; } = 0.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float UnoccupiedTimeout { get; set; } = 0.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public bool TrackActivelySpottedTargets { get; set; } = true;
	
	[ContainerField(0x8d), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
	public bool TrackPassivelySpottedTargets { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TrackHeatSignatureThreshold);
		p_Writer.Write(Range);
		p_Writer.Write(AngularTolerance);
		p_Writer.Write(PitchVelocity);
		p_Writer.Write(YawVelocity);
		p_Writer.Write(OcclusionTimeout);
		p_Writer.Write(UnoccupiedTimeout);
		p_Writer.Write(TrackActivelySpottedTargets);
		p_Writer.Write(TrackPassivelySpottedTargets);
		p_Writer.WriteNullBytes(2);
	}
}

