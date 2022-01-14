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
	[ContainerType(16, 240)]
	public class StaticCameraData :
		TargetCameraData
	{
		[ContainerField(160), JsonProperty(Order = 160)]
		public List<Vec3> LeftCurve { get; set; } = new();

		[ContainerField(164), JsonProperty(Order = 164)]
		public List<Vec3> RightCurve { get; set; } = new();

		[ContainerField(168), JsonProperty(Order = 168)]
		public List<Vec3> UpCurve { get; set; } = new();

		[ContainerField(172), JsonProperty(Order = 172)]
		public List<Vec3> DownCurve { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float UpPitchAngle { get; set; }

		[ContainerField(180), JsonProperty(Order = 180)]
		public EntryInputActionEnum YawInputAction { get; set; } = new();

		[ContainerField(184), JsonProperty(Order = 184)]
		public RefArray<CameraLoosePartPhysicsData> LoosePartPhysics { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float LeftYawAngle { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float RightYawAngle { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public float PitchSensitivityZoomed { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public float DownPitchAngle { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public int AverageFilterFrames { get; set; }

		[ContainerField(208), JsonProperty(Order = 208)]
		public EntryInputActionEnum PitchInputAction { get; set; } = new();

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float YawSensitivityZoomed { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float PitchSensitivityNonZoomed { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float YawSensitivityNonZoomed { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public bool ResetAccumulatedInputOnViewChange { get; set; }

		[ContainerField(225), LayoutImmutable, Blittable, JsonProperty(Order = 225)]
		public bool MirrorHorizontalCurves { get; set; }

		[ContainerField(226), LayoutImmutable, Blittable, JsonProperty(Order = 226)]
		public bool AccumulateInput { get; set; }

		[ContainerField(227), LayoutImmutable, Blittable, JsonProperty(Order = 227)]
		public bool MirrorVerticalCurves { get; set; }

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
