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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 112)]
	public partial class CharacterPoseData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _EyePosition = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _CollisionBoxMaxExpand = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec3 _CollisionBoxMinExpand = new();

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _Height;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _StepHeight;

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private List<Vec2> _ThrottleModifierCurve = new();

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private CharacterPoseType _PoseType = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private CharacterPoseCollisionType _CollisionType = new();

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private LookConstraintsData _LookConstraints = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private List<PoseTransitionTime> _TransitionTimes = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(16);
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
