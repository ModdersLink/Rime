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

namespace fb.RailRideHeli;

[ContainerType(16, 416)]
public class RailRideHeliData
	: fb.Entity.GameComponentEntityData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public LinearTransform RootTransform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public LinearTransform ReferenceTransform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0x100), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public LinearTransform BlendTransform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0x140), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public Vec3 PointToOverride { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public float AngularApproachSlow { get; set; } = 5.000f;
	
	[ContainerField(0x154), LayoutImmutable, Blittable, JsonProperty(Order = 340)]
	public float AngularApproachFast { get; set; } = 15.000f;
	
	[ContainerField(0x158), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
	public float TiltMax { get; set; } = 5.000f;
	
	[ContainerField(0x15c), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
	public float TiltAccelMult { get; set; } = 0.060f;
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float TiltSpeedMult { get; set; } = 0.010f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float VeerDurationMin { get; set; } = 2.000f;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public float VeerDurationMax { get; set; } = 4.000f;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public float VeerPositionOffsetMin { get; set; } = 15.000f;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public float VeerPositionOffsetMax { get; set; } = 25.000f;
	
	[ContainerField(0x174), LayoutImmutable, Blittable, JsonProperty(Order = 372)]
	public float VeerHeadingOffsetMin { get; set; } = 0.500f;
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public float VeerHeadingOffsetMax { get; set; } = 1.500f;
	
	[ContainerField(0x17c), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
	public int SimulationStepsPerFrame { get; set; } = 1;
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public float SoundAccelToThrottleMult { get; set; } = 1.000f;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public float SoundSpeedToThrottleMult { get; set; } = 0.030f;
	
	[ContainerField(0x188), LayoutImmutable, Blittable, JsonProperty(Order = 392)]
	public float Blend { get; set; } = 0.000f;
	
	[ContainerField(0x18c), LayoutImmutable, Blittable, JsonProperty(Order = 396)]
	public float SpeedMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x190), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public bool EnablePointToOverride { get; set; } = false;
	
	[ContainerField(0x191), LayoutImmutable, Blittable, JsonProperty(Order = 401)]
	public bool UseSegmentExternalTime { get; set; } = false;
	
	[ContainerField(0x192), LayoutImmutable, Blittable, JsonProperty(Order = 402)]
	public bool Braking { get; set; } = false;
	
	[ContainerField(0x193), LayoutImmutable, Blittable, JsonProperty(Order = 403)]
	public bool TransformWaypoints { get; set; } = false;
	
	[ContainerField(0x194), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
	public bool ApplySpeedFix { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		RootTransform.Serialize(p_Writer, p_EbxWriter);
		ReferenceTransform.Serialize(p_Writer, p_EbxWriter);
		BlendTransform.Serialize(p_Writer, p_EbxWriter);
		PointToOverride.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AngularApproachSlow);
		p_Writer.Write(AngularApproachFast);
		p_Writer.Write(TiltMax);
		p_Writer.Write(TiltAccelMult);
		p_Writer.Write(TiltSpeedMult);
		p_Writer.Write(VeerDurationMin);
		p_Writer.Write(VeerDurationMax);
		p_Writer.Write(VeerPositionOffsetMin);
		p_Writer.Write(VeerPositionOffsetMax);
		p_Writer.Write(VeerHeadingOffsetMin);
		p_Writer.Write(VeerHeadingOffsetMax);
		p_Writer.Write(SimulationStepsPerFrame);
		p_Writer.Write(SoundAccelToThrottleMult);
		p_Writer.Write(SoundSpeedToThrottleMult);
		p_Writer.Write(Blend);
		p_Writer.Write(SpeedMultiplier);
		p_Writer.Write(EnablePointToOverride);
		p_Writer.Write(UseSegmentExternalTime);
		p_Writer.Write(Braking);
		p_Writer.Write(TransformWaypoints);
		p_Writer.Write(ApplySpeedFix);
		p_Writer.WriteNullBytes(11);
	}
}

