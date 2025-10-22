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

[ContainerType(16, 160)]
public class RailRideNodeHeliData
	: fb.Entity.GameComponentEntityData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float WindNoise { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float Speed { get; set; } = 9.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float PointToDistance { get; set; } = 1000.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float Curvature { get; set; } = 0.670f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float Constraint { get; set; } = 1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float ForcePitch { get; set; } = 0.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float BankingScale { get; set; } = 1.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public bool LimitWindToHorizontal { get; set; } = false;
	
	[ContainerField(0x9d), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
	public bool UseVelocityDirection { get; set; } = false;
	
	[ContainerField(0x9e), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
	public bool PointForward { get; set; } = false;
	
	[ContainerField(0x9f), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
	public bool WingMode { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WindNoise);
		p_Writer.Write(Speed);
		p_Writer.Write(PointToDistance);
		p_Writer.Write(Curvature);
		p_Writer.Write(Constraint);
		p_Writer.Write(ForcePitch);
		p_Writer.Write(BankingScale);
		p_Writer.Write(LimitWindToHorizontal);
		p_Writer.Write(UseVelocityDirection);
		p_Writer.Write(PointForward);
		p_Writer.Write(WingMode);
	}
}

