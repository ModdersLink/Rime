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
	[ContainerType(16, 240)]
	public partial class StaticCameraData :
		TargetCameraData
	{
		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private List<Vec3> _LeftCurve = new();

		[ObservableProperty]
		[property: ContainerField(164), JsonProperty(Order = 164)]
		private List<Vec3> _RightCurve = new();

		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private List<Vec3> _UpCurve = new();

		[ObservableProperty]
		[property: ContainerField(172), JsonProperty(Order = 172)]
		private List<Vec3> _DownCurve = new();

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _UpPitchAngle;

		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private EntryInputActionEnum _YawInputAction = new();

		[ObservableProperty]
		[property: ContainerField(184), JsonProperty(Order = 184)]
		private RefArray<CameraLoosePartPhysicsData> _LoosePartPhysics = new();

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _LeftYawAngle;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private float _RightYawAngle;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private float _PitchSensitivityZoomed;

		[ObservableProperty]
		[property: ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		private float _DownPitchAngle;

		[ObservableProperty]
		[property: ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		private int _AverageFilterFrames;

		[ObservableProperty]
		[property: ContainerField(208), JsonProperty(Order = 208)]
		private EntryInputActionEnum _PitchInputAction = new();

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		private float _YawSensitivityZoomed;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _PitchSensitivityNonZoomed;

		[ObservableProperty]
		[property: ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		private float _YawSensitivityNonZoomed;

		[ObservableProperty]
		[property: ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		private bool _ResetAccumulatedInputOnViewChange;

		[ObservableProperty]
		[property: ContainerField(225), LayoutImmutable, Blittable, JsonProperty(Order = 225)]
		private bool _MirrorHorizontalCurves;

		[ObservableProperty]
		[property: ContainerField(226), LayoutImmutable, Blittable, JsonProperty(Order = 226)]
		private bool _AccumulateInput;

		[ObservableProperty]
		[property: ContainerField(227), LayoutImmutable, Blittable, JsonProperty(Order = 227)]
		private bool _MirrorVerticalCurves;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_LeftCurve = p_EbxWriter.GetArrayWriter(LeftCurve.GetType(), LeftCurve.Count);
			p_Writer.Write(s_LeftCurve.ArrayIndex);
			foreach (var s_Entry in LeftCurve)
			{
				s_Entry.Serialize(s_LeftCurve.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_RightCurve = p_EbxWriter.GetArrayWriter(RightCurve.GetType(), RightCurve.Count);
			p_Writer.Write(s_RightCurve.ArrayIndex);
			foreach (var s_Entry in RightCurve)
			{
				s_Entry.Serialize(s_RightCurve.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_UpCurve = p_EbxWriter.GetArrayWriter(UpCurve.GetType(), UpCurve.Count);
			p_Writer.Write(s_UpCurve.ArrayIndex);
			foreach (var s_Entry in UpCurve)
			{
				s_Entry.Serialize(s_UpCurve.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_DownCurve = p_EbxWriter.GetArrayWriter(DownCurve.GetType(), DownCurve.Count);
			p_Writer.Write(s_DownCurve.ArrayIndex);
			foreach (var s_Entry in DownCurve)
			{
				s_Entry.Serialize(s_DownCurve.Writer, p_EbxWriter);
			}
			p_Writer.Write(UpPitchAngle);
			p_Writer.Write((int) YawInputAction);
			(RimeWriter Writer, uint ArrayIndex) s_LoosePartPhysics = p_EbxWriter.GetArrayWriter(LoosePartPhysics.GetType(), LoosePartPhysics.Count);
			p_Writer.Write(s_LoosePartPhysics.ArrayIndex);
			foreach (var s_Entry in LoosePartPhysics)
			{
				s_LoosePartPhysics.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(LeftYawAngle);
			p_Writer.Write(RightYawAngle);
			p_Writer.Write(PitchSensitivityZoomed);
			p_Writer.Write(DownPitchAngle);
			p_Writer.Write(AverageFilterFrames);
			p_Writer.Write((int) PitchInputAction);
			p_Writer.Write(YawSensitivityZoomed);
			p_Writer.Write(PitchSensitivityNonZoomed);
			p_Writer.Write(YawSensitivityNonZoomed);
			p_Writer.Write(ResetAccumulatedInputOnViewChange);
			p_Writer.Write(MirrorHorizontalCurves);
			p_Writer.Write(AccumulateInput);
			p_Writer.Write(MirrorVerticalCurves);
			p_Writer.WriteNullBytes(12);
		}
	}
}
