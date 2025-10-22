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

[ContainerType(16, 128)]
public class FakeHingeData
	: fb.Physics.FakePhysicsData
{
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MinAngle { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float MaxAngle { get; set; } = 360.000f;
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 Pivot { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 RotationAxis { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 ExtensionAxis { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float AngularDampening { get; set; } = 0.050f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float PullbackAcceleration { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float ProgressiveExponent { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float InertiaModifier { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MinAngle);
		p_Writer.Write(MaxAngle);
		Pivot.Serialize(p_Writer, p_EbxWriter);
		RotationAxis.Serialize(p_Writer, p_EbxWriter);
		ExtensionAxis.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AngularDampening);
		p_Writer.Write(PullbackAcceleration);
		p_Writer.Write(ProgressiveExponent);
		p_Writer.Write(InertiaModifier);
	}
}

