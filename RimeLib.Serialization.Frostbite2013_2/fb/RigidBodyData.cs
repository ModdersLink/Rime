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

[ContainerType(16, 240)]
public class RigidBodyData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public RigidBodyType RigidBodyType { get; set; } = fb.Physics.RigidBodyType.RBTypeCollision;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 InertiaModifier { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public LinearTransform Transform { get; set; } = new()
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
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public LinearTransform KeyframeTransform { get; set; } = new()
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
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float Mass { get; set; } = 0.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float Friction { get; set; } = 0.500f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float Restitution { get; set; } = 0.400f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float AngularVelocityDamping { get; set; } = -1.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float LinearVelocityDamping { get; set; } = -1.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public uint InteractionToolkitCollisionVolumeId { get; set; } = 0;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public RigidBodyMotionType MotionType { get; set; } = RigidBodyMotionType.RigidBodyMotionType_Invalid;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public RigidBodyQualityType QualityType { get; set; } = RigidBodyQualityType.RigidBodyQualityType_Invalid;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public RigidBodyCollisionLayer CollisionLayer { get; set; } = RigidBodyCollisionLayer.RigidBodyCollisionLayer_Invalid;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public List<uint> PartIndices { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public bool IsRootController { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) RigidBodyType);
		p_Writer.WriteNullBytes(4);
		InertiaModifier.Serialize(p_Writer, p_EbxWriter);
		Transform.Serialize(p_Writer, p_EbxWriter);
		KeyframeTransform.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Mass);
		p_Writer.Write(Friction);
		p_Writer.Write(Restitution);
		p_Writer.Write(AngularVelocityDamping);
		p_Writer.Write(LinearVelocityDamping);
		p_Writer.Write(InteractionToolkitCollisionVolumeId);
		p_Writer.Write((int) MotionType);
		p_Writer.Write((int) QualityType);
		p_Writer.Write((int) CollisionLayer);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PartIndices = p_EbxWriter.GetArrayWriter(PartIndices.GetType(), PartIndices.Count);
		p_Writer.Write(s_PartIndices.ArrayIndex);
		foreach (var s_Entry in PartIndices)
		{
			s_PartIndices.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FloatPhysics));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(IsRootController);
		p_Writer.WriteNullBytes(7);
	}
}

