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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class CharacterPoseData :
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 EyePosition { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 CollisionBoxMaxExpand { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 CollisionBoxMinExpand { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float Height { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float StepHeight { get; set; }

		[ContainerField(72), JsonProperty(Order = 72)]
		public List<Vec2> ThrottleModifierCurve { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public CharacterPoseType PoseType { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public CharacterPoseCollisionType CollisionType { get; set; } = new();

		[ContainerField(84), JsonProperty(Order = 84)]
		public LookConstraintsData LookConstraints { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public List<PoseTransitionTime> TransitionTimes { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			EyePosition.Serialize(p_Writer, p_EbxWriter);
			CollisionBoxMaxExpand.Serialize(p_Writer, p_EbxWriter);
			CollisionBoxMinExpand.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Height);
			p_Writer.Write(StepHeight);
			(RimeWriter Writer, uint ArrayIndex) s_ThrottleModifierCurve = p_EbxWriter.GetArrayWriter(ThrottleModifierCurve.GetType(), ThrottleModifierCurve.Count);
			p_Writer.Write(s_ThrottleModifierCurve.ArrayIndex);
			foreach (var s_Entry in ThrottleModifierCurve)
			{
				s_Entry.Serialize(s_ThrottleModifierCurve.Writer, p_EbxWriter);
			}
			p_Writer.Write((int) PoseType);
			p_Writer.Write((int) CollisionType);
			LookConstraints.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_TransitionTimes = p_EbxWriter.GetArrayWriter(TransitionTimes.GetType(), TransitionTimes.Count);
			p_Writer.Write(s_TransitionTimes.ArrayIndex);
			foreach (var s_Entry in TransitionTimes)
			{
				s_Entry.Serialize(s_TransitionTimes.Writer, p_EbxWriter);
			}
			p_Writer.WriteNullBytes(8);
		}
	}
}
