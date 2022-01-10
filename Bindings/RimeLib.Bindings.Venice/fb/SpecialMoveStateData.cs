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
	[ContainerType(4, 60)]
	public class SpecialMoveStateData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MinHeightScale { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float OptimumDistanceFromObject { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float OptimumHeightOfObject { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float OptimumLengthOfObject { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxDistanceScale { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinDistanceScale { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxHeightScale { get; set; }
		
		[ContainerField(28)]
		public List<SpecialMoveInterpolatedPoint> MotionPoints { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float MaxObjectLengthScale { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float MinObjectLengthScale { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float ExitAnimationDrivenStateVelocity { get; set; }
		
		[ContainerField(44)]
		public SpecialMovesPoseType ResetPose { get; set; } = new();
		
		[ContainerField(48)]
		public SpecialMovesPoseType OverridePose { get; set; } = new();
		
		[ContainerField(52)]
		public List<SpecialMoveInterpolatedPoint> GravityPoints { get; set; } = new();
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool KeepInitialSoldierDirection { get; set; }
		
		[ContainerField(57), LayoutImmutable, Blittable]
		public bool ScaleWithDistanceToObject { get; set; }
		
		public static void Deserialize(SpecialMoveStateData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MinHeightScale = p_Reader.ReadSingle();
			p_Instance.OptimumDistanceFromObject = p_Reader.ReadSingle();
			p_Instance.OptimumHeightOfObject = p_Reader.ReadSingle();
			p_Instance.OptimumLengthOfObject = p_Reader.ReadSingle();
			p_Instance.MaxDistanceScale = p_Reader.ReadSingle();
			p_Instance.MinDistanceScale = p_Reader.ReadSingle();
			p_Instance.MaxHeightScale = p_Reader.ReadSingle();
			p_Instance.MotionPoints.Clear();
			(RimeReader Reader, uint Count) s_MotionPoints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_MotionPoints.Count; ++i)
			{
				var s_Value = new SpecialMoveInterpolatedPoint();
				fb.SpecialMoveInterpolatedPoint.Deserialize(s_Value, s_MotionPoints.Reader, p_Parser);
				p_Instance.MotionPoints.Add(s_Value);
			}
			
			s_MotionPoints.Reader.Dispose();
			p_Instance.MaxObjectLengthScale = p_Reader.ReadSingle();
			p_Instance.MinObjectLengthScale = p_Reader.ReadSingle();
			p_Instance.ExitAnimationDrivenStateVelocity = p_Reader.ReadSingle();
			p_Instance.ResetPose = (SpecialMovesPoseType) p_Reader.ReadInt32();
			p_Instance.OverridePose = (SpecialMovesPoseType) p_Reader.ReadInt32();
			p_Instance.GravityPoints.Clear();
			(RimeReader Reader, uint Count) s_GravityPoints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_GravityPoints.Count; ++i)
			{
				var s_Value = new SpecialMoveInterpolatedPoint();
				fb.SpecialMoveInterpolatedPoint.Deserialize(s_Value, s_GravityPoints.Reader, p_Parser);
				p_Instance.GravityPoints.Add(s_Value);
			}
			
			s_GravityPoints.Reader.Dispose();
			p_Instance.KeepInitialSoldierDirection = p_Reader.ReadBool();
			p_Instance.ScaleWithDistanceToObject = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
