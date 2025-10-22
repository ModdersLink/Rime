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

namespace fb.Physics;

[ContainerType(16, 144)]
public class PhysicsRagdollContraintData
	: fb.Physics.PhysicsConstraintData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float TwistMinAngularLimit { get; set; } = -45.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float TwistMaxAngularLimit { get; set; } = 45.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float PlaneMinAngularLimit { get; set; } = -45.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float PlaneMaxAngularLimit { get; set; } = 45.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float ConeAngularLimit { get; set; } = 45.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float AngularFriction { get; set; } = 0.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float AngularStiffness { get; set; } = 1.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public bool HasLimits { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TwistMinAngularLimit);
		p_Writer.Write(TwistMaxAngularLimit);
		p_Writer.Write(PlaneMinAngularLimit);
		p_Writer.Write(PlaneMaxAngularLimit);
		p_Writer.Write(ConeAngularLimit);
		p_Writer.Write(AngularFriction);
		p_Writer.Write(AngularStiffness);
		p_Writer.Write(HasLimits);
		p_Writer.WriteNullBytes(3);
	}
}

