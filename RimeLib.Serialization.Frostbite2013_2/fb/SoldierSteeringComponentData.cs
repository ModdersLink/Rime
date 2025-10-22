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

[ContainerType(16, 160)]
public class SoldierSteeringComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float WantedSpeed { get; set; } = 5.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float Acceleration { get; set; } = 4.500f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float Deceleration { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float MoveAngularAcceleration { get; set; } = 320.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float MoveAngularSpeedFactor { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float MaxForwardDir { get; set; } = 45.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float MaxStrafeDir { get; set; } = 90.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float StandingStillCutoffSpeed { get; set; } = 0.010f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float TurnAngularAcceleration { get; set; } = 360.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float AimMinPrecisionTolerance { get; set; } = 0.250f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float PitchSpeed { get; set; } = 230.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float TurningSpeed { get; set; } = 123.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WantedSpeed);
		p_Writer.Write(Acceleration);
		p_Writer.Write(Deceleration);
		p_Writer.Write(MoveAngularAcceleration);
		p_Writer.Write(MoveAngularSpeedFactor);
		p_Writer.Write(MaxForwardDir);
		p_Writer.Write(MaxStrafeDir);
		p_Writer.Write(StandingStillCutoffSpeed);
		p_Writer.Write(TurnAngularAcceleration);
		p_Writer.Write(AimMinPrecisionTolerance);
		p_Writer.Write(PitchSpeed);
		p_Writer.Write(TurningSpeed);
	}
}

