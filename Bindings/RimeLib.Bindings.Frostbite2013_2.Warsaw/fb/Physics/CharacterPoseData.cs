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
public class CharacterPoseData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<Vec2> ThrottleModifierCurve { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float StepHeight { get; set; } = 0.300f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 EyePosition { get; set; } = new()
	{
		z = 0.000f,
		y = 1.700f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 CollisionBoxMinExpand { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 CollisionBoxMaxExpand { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float Height { get; set; } = 1.800f;
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public List<PoseTransitionTime> TransitionTimes { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public LookConstraintsData LookConstraints { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public CharacterPoseType PoseType { get; set; } = CharacterPoseType.CharacterPoseType_Stand;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public CharacterPoseCollisionType CollisionType { get; set; } = CharacterPoseCollisionType.CharacterPoseCollisionType_Pencil;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ThrottleModifierCurve = p_EbxWriter.GetArrayWriter(ThrottleModifierCurve.GetType(), ThrottleModifierCurve.Count);
		p_Writer.Write(s_ThrottleModifierCurve.ArrayIndex);
		foreach (var s_Entry in ThrottleModifierCurve)
		{
			s_Entry.Serialize(s_ThrottleModifierCurve.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(StepHeight);
		p_Writer.WriteNullBytes(4);
		EyePosition.Serialize(p_Writer, p_EbxWriter);
		CollisionBoxMinExpand.Serialize(p_Writer, p_EbxWriter);
		CollisionBoxMaxExpand.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Height);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_TransitionTimes = p_EbxWriter.GetArrayWriter(TransitionTimes.GetType(), TransitionTimes.Count);
		p_Writer.Write(s_TransitionTimes.ArrayIndex);
		foreach (var s_Entry in TransitionTimes)
		{
			s_Entry.Serialize(s_TransitionTimes.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		LookConstraints.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) PoseType);
		p_Writer.Write((int) CollisionType);
		p_Writer.WriteNullBytes(8);
	}
}

