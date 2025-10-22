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

[ContainerType(8, 72)]
public class RotationBodyData
	: fb.Physics.MovingBodyData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float AngularMomentumMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float AngularMomentumThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float AngularMomentumDamping { get; set; } = 0.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float AngularMomentumDampingAcc { get; set; } = 0.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float AngularMomentumDampingDeacc { get; set; } = -1.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float AngularConstraintMin { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float AngularConstraintMax { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int RotationAxis { get; set; } = 0;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<ExtendedConstraintsData> ExtendedConstraints { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool UsePostSatisfyConstraints { get; set; } = true;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool UseAngularMomentumThreshold { get; set; } = false;
	
	[ContainerField(0x42), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
	public bool UseAngularMomentumDamping { get; set; } = false;
	
	[ContainerField(0x43), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
	public bool UseAngularConstraint { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AngularMomentumMultiplier);
		p_Writer.Write(AngularMomentumThreshold);
		p_Writer.Write(AngularMomentumDamping);
		p_Writer.Write(AngularMomentumDampingAcc);
		p_Writer.Write(AngularMomentumDampingDeacc);
		p_Writer.Write(AngularConstraintMin);
		p_Writer.Write(AngularConstraintMax);
		p_Writer.Write(RotationAxis);
		p_Writer.Write(p_EbxWriter.WriteImport(ExtendedConstraints));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UsePostSatisfyConstraints);
		p_Writer.Write(UseAngularMomentumThreshold);
		p_Writer.Write(UseAngularMomentumDamping);
		p_Writer.Write(UseAngularConstraint);
		p_Writer.WriteNullBytes(4);
	}
}

