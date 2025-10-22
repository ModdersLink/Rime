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

[ContainerType(16, 144)]
public class HullFloatPhysicsData
	: fb.Physics.FloatPhysicsData
{
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 WaterResistanceAxisMod { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 WaterFrictionAxisMod { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 Offset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public int SubSurfaceSplits { get; set; } = 10;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float Depth { get; set; } = 0.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float Width { get; set; } = 0.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float Length { get; set; } = 0.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float FrontCurveDegree { get; set; } = 2.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float SideCurveDegree { get; set; } = 2.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float NonEngineSteer { get; set; } = 0.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float NonEngineSteerMinSpeed { get; set; } = 0.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float NonEngineSteerMaxSpeed { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float WaterDampeningMod { get; set; } = 1.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float LiftModifier { get; set; } = 1.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float SupportSizeMod { get; set; } = 1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float SampleHeightModifier { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float AngularDampening { get; set; } = 0.010f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float FrictionThrottleModifier { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(8);
		WaterResistanceAxisMod.Serialize(p_Writer, p_EbxWriter);
		WaterFrictionAxisMod.Serialize(p_Writer, p_EbxWriter);
		Offset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SubSurfaceSplits);
		p_Writer.Write(Depth);
		p_Writer.Write(Width);
		p_Writer.Write(Length);
		p_Writer.Write(FrontCurveDegree);
		p_Writer.Write(SideCurveDegree);
		p_Writer.Write(NonEngineSteer);
		p_Writer.Write(NonEngineSteerMinSpeed);
		p_Writer.Write(NonEngineSteerMaxSpeed);
		p_Writer.Write(WaterDampeningMod);
		p_Writer.Write(LiftModifier);
		p_Writer.Write(SupportSizeMod);
		p_Writer.Write(SampleHeightModifier);
		p_Writer.Write(AngularDampening);
		p_Writer.Write(FrictionThrottleModifier);
		p_Writer.WriteNullBytes(4);
	}
}

