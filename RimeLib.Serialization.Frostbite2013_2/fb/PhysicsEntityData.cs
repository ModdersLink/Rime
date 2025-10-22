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

[ContainerType(16, 112)]
public class PhysicsEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<HavokAsset> Asset { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 InertiaModifier { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<RigidBodyData> RigidBodies { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<FloatPhysicsData> FloatPhysics { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float Mass { get; set; } = -1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float Friction { get; set; } = -1.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float Restitution { get; set; } = -1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float AngularVelocityDamping { get; set; } = -1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float LinearVelocityDamping { get; set; } = -1.000f;
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<ProximityData> Proximity { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public RefArray<PhysicsConstraintData> Constraints { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool MovableParts { get; set; } = false;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool IsComposite { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Asset));
		p_Writer.WriteNullBytes(4);
		InertiaModifier.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_RigidBodies = p_EbxWriter.GetArrayWriter(RigidBodies.GetType(), RigidBodies.Count);
		p_Writer.Write(s_RigidBodies.ArrayIndex);
		foreach (var s_Entry in RigidBodies)
		{
			s_RigidBodies.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FloatPhysics));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Mass);
		p_Writer.Write(Friction);
		p_Writer.Write(Restitution);
		p_Writer.Write(AngularVelocityDamping);
		p_Writer.Write(LinearVelocityDamping);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Proximity));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Constraints = p_EbxWriter.GetArrayWriter(Constraints.GetType(), Constraints.Count);
		p_Writer.Write(s_Constraints.ArrayIndex);
		foreach (var s_Entry in Constraints)
		{
			s_Constraints.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MovableParts);
		p_Writer.Write(IsComposite);
		p_Writer.WriteNullBytes(6);
	}
}

