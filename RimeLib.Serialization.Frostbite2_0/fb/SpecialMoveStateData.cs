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
	[ContainerType(4, 60)]
	public partial class SpecialMoveStateData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private float _MinHeightScale;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private float _OptimumDistanceFromObject;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _OptimumHeightOfObject;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _OptimumLengthOfObject;
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _MaxDistanceScale;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _MinDistanceScale;
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _MaxHeightScale;
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private List<SpecialMoveInterpolatedPoint> _MotionPoints = new();
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _MaxObjectLengthScale;
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _MinObjectLengthScale;
		
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _ExitAnimationDrivenStateVelocity;
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private SpecialMovesPoseType _ResetPose = new();
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private SpecialMovesPoseType _OverridePose = new();
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private List<SpecialMoveInterpolatedPoint> _GravityPoints = new();
		
		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private bool _KeepInitialSoldierDirection;
		
		[ObservableProperty]
		[property: ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		private bool _ScaleWithDistanceToObject;
		
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
