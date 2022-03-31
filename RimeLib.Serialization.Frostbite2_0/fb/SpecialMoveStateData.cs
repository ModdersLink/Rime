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

namespace fb
{
	[ContainerType(4, 60)]
	public class SpecialMoveStateData :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float MinHeightScale { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float OptimumDistanceFromObject { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float OptimumHeightOfObject { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float OptimumLengthOfObject { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float MaxDistanceScale { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float MinDistanceScale { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float MaxHeightScale { get; set; }
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public List<SpecialMoveInterpolatedPoint> MotionPoints { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float MaxObjectLengthScale { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float MinObjectLengthScale { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float ExitAnimationDrivenStateVelocity { get; set; }
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public SpecialMovesPoseType ResetPose { get; set; } = new();
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public SpecialMovesPoseType OverridePose { get; set; } = new();
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public List<SpecialMoveInterpolatedPoint> GravityPoints { get; set; } = new();
		
		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool KeepInitialSoldierDirection { get; set; }
		
		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool ScaleWithDistanceToObject { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MinHeightScale);
			p_Writer.Write(OptimumDistanceFromObject);
			p_Writer.Write(OptimumHeightOfObject);
			p_Writer.Write(OptimumLengthOfObject);
			p_Writer.Write(MaxDistanceScale);
			p_Writer.Write(MinDistanceScale);
			p_Writer.Write(MaxHeightScale);
			(RimeWriter Writer, uint ArrayIndex) s_MotionPoints = p_EbxWriter.GetArrayWriter(MotionPoints.GetType(), MotionPoints.Count);
			p_Writer.Write(s_MotionPoints.ArrayIndex);
			foreach (var s_Entry in MotionPoints)
			{
				s_Entry.Serialize(s_MotionPoints.Writer, p_EbxWriter);
			}
			p_Writer.Write(MaxObjectLengthScale);
			p_Writer.Write(MinObjectLengthScale);
			p_Writer.Write(ExitAnimationDrivenStateVelocity);
			p_Writer.Write((int) ResetPose);
			p_Writer.Write((int) OverridePose);
			(RimeWriter Writer, uint ArrayIndex) s_GravityPoints = p_EbxWriter.GetArrayWriter(GravityPoints.GetType(), GravityPoints.Count);
			p_Writer.Write(s_GravityPoints.ArrayIndex);
			foreach (var s_Entry in GravityPoints)
			{
				s_Entry.Serialize(s_GravityPoints.Writer, p_EbxWriter);
			}
			p_Writer.Write(KeepInitialSoldierDirection);
			p_Writer.Write(ScaleWithDistanceToObject);
			p_Writer.WriteNullBytes(2);
		}
	}
}
