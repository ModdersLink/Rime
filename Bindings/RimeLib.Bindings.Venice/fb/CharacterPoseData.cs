///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class CharacterPoseData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EyePosition { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CollisionBoxMaxExpand { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CollisionBoxMinExpand { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public float Height { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float StepHeight { get; set; }

		[ContainerField(72)]
		public List<Vec2> ThrottleModifierCurve { get; set; } = new();

		[ContainerField(76)]
		public CharacterPoseType PoseType { get; set; } = new();

		[ContainerField(80)]
		public CharacterPoseCollisionType CollisionType { get; set; } = new();

		[ContainerField(84)]
		public LookConstraintsData LookConstraints { get; set; } = new();

		[ContainerField(100)]
		public List<PoseTransitionTime> TransitionTimes { get; set; } = new();

		public static void Deserialize(CharacterPoseData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.EyePosition, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.CollisionBoxMaxExpand, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.CollisionBoxMinExpand, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Height = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.StepHeight = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ThrottleModifierCurve.Clear();
			(RimeReader Reader, uint Count) s_ThrottleModifierCurve = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ThrottleModifierCurve.Count; ++i)
			{
				var s_Value = new Vec2();
				fb.Vec2.Deserialize(s_Value, s_ThrottleModifierCurve.Reader, p_Parser);
				p_Instance.ThrottleModifierCurve.Add(s_Value);
			}
			
			s_ThrottleModifierCurve.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.PoseType = (CharacterPoseType) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CollisionType = (CharacterPoseCollisionType) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.LookConstraintsData.Deserialize(p_Instance.LookConstraints, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TransitionTimes.Clear();
			(RimeReader Reader, uint Count) s_TransitionTimes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TransitionTimes.Count; ++i)
			{
				var s_Value = new PoseTransitionTime();
				fb.PoseTransitionTime.Deserialize(s_Value, s_TransitionTimes.Reader, p_Parser);
				p_Instance.TransitionTimes.Add(s_Value);
			}
			
			s_TransitionTimes.Reader.Dispose();
			p_Reader.Seek(16, SeekOrigin.Current);
		}

	}
}
