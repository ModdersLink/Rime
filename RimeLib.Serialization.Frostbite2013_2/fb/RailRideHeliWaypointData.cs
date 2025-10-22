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
using fb.GameShared;

namespace fb.RailRideHeli;

[ContainerType(16, 96)]
public class RailRideHeliWaypointData
	: fb.GameShared.WaypointData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float WindNoise { get; set; } = 1.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float Speed { get; set; } = 9.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float PointToDistance { get; set; } = 1000.000f;
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 ForwardDirection { get; set; } = new()
	{
		z = 1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float Curvature { get; set; } = 0.670f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float Constraint { get; set; } = 1.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float ForcePitch { get; set; } = 0.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float BankingScale { get; set; } = 1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public int PointToIndex { get; set; } = -1;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool LimitWindToHorizontal { get; set; } = false;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool UseVelocityDirection { get; set; } = false;
	
	[ContainerField(0x56), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
	public bool PointForward { get; set; } = false;
	
	[ContainerField(0x57), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
	public bool WingMode { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WindNoise);
		p_Writer.Write(Speed);
		p_Writer.Write(PointToDistance);
		p_Writer.WriteNullBytes(4);
		ForwardDirection.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Curvature);
		p_Writer.Write(Constraint);
		p_Writer.Write(ForcePitch);
		p_Writer.Write(BankingScale);
		p_Writer.Write(PointToIndex);
		p_Writer.Write(LimitWindToHorizontal);
		p_Writer.Write(UseVelocityDirection);
		p_Writer.Write(PointForward);
		p_Writer.Write(WingMode);
		p_Writer.WriteNullBytes(8);
	}
}

