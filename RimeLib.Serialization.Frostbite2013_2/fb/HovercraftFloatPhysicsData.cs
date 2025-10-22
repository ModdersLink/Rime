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

[ContainerType(16, 208)]
public class HovercraftFloatPhysicsData
	: fb.Physics.HullFloatPhysicsData
{
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 LandResistanceAxisMod { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec3 LandFrictionAxisMod { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Vec3 LandFrictionAxisModEngineOff { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float FrontLength { get; set; } = 0.500f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float SideLength { get; set; } = 0.500f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float LiftModifierEngineOff { get; set; } = 1.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float EngineTransitionTime { get; set; } = 2.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		LandResistanceAxisMod.Serialize(p_Writer, p_EbxWriter);
		LandFrictionAxisMod.Serialize(p_Writer, p_EbxWriter);
		LandFrictionAxisModEngineOff.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FrontLength);
		p_Writer.Write(SideLength);
		p_Writer.Write(LiftModifierEngineOff);
		p_Writer.Write(EngineTransitionTime);
	}
}

